using IPI.OpcUaServer.Base;
using Opc.Ua;
using Spectaris.LADS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPI.OpcUaServer.GAM
{
    internal class GAMMeasureFunctionalUnitState : FunctionalUnitState
    {
        Simulator _simulator;
        List<int> _methodIDs = new List<int>() { 1, 2, 3, 4 };
        ushort _namespaceIndex = 0;
        Random _random = new Random();

        public GAMMeasureFunctionalUnitState(NodeState parent, ushort namespaceIndex) : base(parent)
        {
            _namespaceIndex = namespaceIndex;
            _simulator = new Simulator(UpdateFunctionSet);
        }

        #region Initialization
        /// <summary>
        /// Initializes the object as a collection of counters which change value on read.
        /// </summary>
        protected override void OnAfterCreate(ISystemContext context, NodeState node)
        {
            base.OnAfterCreate(context, node);

            this.ComponentName.Value = "Measure";
            this.ProgramManager.ActiveProgram = CreatePredefinedState(context, _namespaceIndex, "ActiveProgram", () => new GAMMeasureStateMachineState(this));
            this.ProgramManager.ActiveProgram.OnAfterTransition += OnControlMeasurement;

            var functionSet = CreatePredefinedState(context, _namespaceIndex, "FunctionSet", () => new Spectaris.LADS.FunctionSetState(this));
            this.FunctionSet = functionSet;

            AddNewSensor(context, functionSet, "Concentration_Ar", "Argon");
            AddNewSensor(context, functionSet, "Concentration_N2", "Nitrogen");
            AddNewSensor(context, functionSet, "Concentration_O2", "Oxygen");

            AddNewSensor(context, functionSet, "Intensity_2", "2 m/z");
            AddNewSensor(context, functionSet, "Intensity_4", "4 m/z");
            AddNewSensor(context, functionSet, "Intensity_12", "12 m/z");
            AddNewSensor(context, functionSet, "Intensity_14", "14 m/z");
            AddNewSensor(context, functionSet, "Intensity_16", "16 m/z");
            AddNewSensor(context, functionSet, "Intensity_28", "28 m/z");
            AddNewSensor(context, functionSet, "Intensity_32", "32 m/z");
            AddNewSensor(context, functionSet, "Intensity_40", "40 m/z");
            AddNewSensor(context, functionSet, "Intensity_44", "44 m/z");

            foreach (var methodID in _methodIDs)
            {
                AddProgramTemplate(context, this.ProgramManager.ProgramTemplateSet, methodID);
            }

            InitializeFunctionSet(context);
        }
        #endregion

        /// <summary>
        /// Changes the state of the simulation.
        /// </summary>
        private ServiceResult OnControlMeasurement(
            ISystemContext context,
            StateMachineState machine,
            uint transitionId,
            uint causeId,
            IList<object> inputArguments,
            IList<object> outputArguments)
        {
            switch (causeId)
            {
                case Opc.Ua.Methods.ProgramStateMachineType_Start:
                    Start(context, inputArguments);
                    break;
                case Opc.Ua.Methods.ProgramStateMachineType_Halt:
                    Stop(context);
                    break;
                case Opc.Ua.Methods.ProgramStateMachineType_Suspend:
                case Opc.Ua.Methods.ProgramStateMachineType_Reset:
                    break;
            }

            return ServiceResult.Good;
        }

        private void Start(ISystemContext context, IList<object> inputArguments)
        {
            string startMethodID = string.Empty;
            if (inputArguments.Count > 0 && inputArguments[0] != null) startMethodID = inputArguments[0].ToString();

            // Load Method
            if (!int.TryParse(startMethodID, out var methodID))
            {
                throw new ArgumentException("Unknown program template");
            }

            if (!_methodIDs.Contains(methodID))
            {
                throw new ArgumentException("Unknown program template");
            }

            // create the new Nodes in FunctionSet related to the method
            _simulator.Start(context);
        }

        private void Stop(ISystemContext context)
        {
            _simulator.Stop(context);
        }

        private void AddNewSensor(ISystemContext context, Spectaris.LADS.FunctionSetState functionSet, string name, string description)
        {
            var sensorFunction = CreatePredefinedState(context, _namespaceIndex, name, () => new DoubleAnalogSensorFunctionState(functionSet));

            sensorFunction.SymbolicName = name;
            sensorFunction.BrowseName = new QualifiedName(name);
            sensorFunction.Description = new LocalizedText(description);
            functionSet.AddChild(sensorFunction);
        }

        private void AddProgramTemplate(ISystemContext context, Spectaris.LADS.ProgramTemplateSetState programTemplateSet, int id)
        {
            string name = $"Method {id}";

            var programTemplate = CreatePredefinedState(context, 4, name, () => new Spectaris.LADS.ProgramTemplateState(programTemplateSet));

            programTemplate.Description = name;
            programTemplate.Name.Value = name;
            programTemplate.TemplateID.Value = id.ToString();
            programTemplate.Author.Value = new LocalizedText("InProcess Instruments GmbH");
            programTemplate.Created.Value = DateTime.UtcNow;
            programTemplate.Modified.Value = programTemplate.Created.Value;
            programTemplate.Version.Value = "1.0";
            programTemplate.Status.Value = "Valid";

            programTemplateSet.AddChild(programTemplate);
        }

        private void InitializeFunctionSet(ISystemContext context)
        {
            InitializeSensor(context, "Concentration_Ar", "Ar", 0, 100, "P1");
            InitializeSensor(context, "Concentration_N2", "N2", 0, 100, "P1");
            InitializeSensor(context, "Concentration_O2", "O2", 0, 100, "P1");

            InitializeSensor(context, "Intensity_28", "28", 0, 1e-5, "AMP");
            InitializeSensor(context, "Intensity_32", "32", 0, 1e-5, "AMP");
            InitializeSensor(context, "Intensity_40", "40", 0, 1e-5, "AMP");
        }

        private void UpdateFunctionSet(ISystemContext context)
        {
            var timeStamp = DateTime.UtcNow;

            UpdateSensor(context, "Concentration_Ar", timeStamp, 0.934);
            UpdateSensor(context, "Concentration_N2", timeStamp, 78.084);
            UpdateSensor(context, "Concentration_O2", timeStamp, 20.942);

            UpdateSensor(context, "Intensity_28", timeStamp, 1.234e-12);
            UpdateSensor(context, "Intensity_32", timeStamp, 2.345e-08);
            UpdateSensor(context, "Intensity_40", timeStamp, 3.456e-10);

            this.ClearChangeMasks(context, true);
        }

        private void InitializeSensor(ISystemContext context, string name, string displayName, double lowValue, double highValue, string unceCode)
        {
            var sensorFunctionState = FunctionSet.FindChildBySymbolicName(context, name) as DoubleAnalogSensorFunctionState;
            if (sensorFunctionState != null) SensorFunctionHelper.Initialize_SensorFunctionState(sensorFunctionState, displayName, lowValue, highValue, unceCode);
        }

        private void UpdateSensor(ISystemContext context, string name, DateTime timeStamp, double value)
        {
            value = SensorFunctionHelper.Randomize(_random, value, 3);

            var sensorFunctionState = FunctionSet.FindChildBySymbolicName(context, name) as DoubleAnalogSensorFunctionState;
            if (sensorFunctionState != null) SensorFunctionHelper.Update_SensorFunctionState(sensorFunctionState, timeStamp, value);
        }

        private T CreatePredefinedState<T>(ISystemContext context, ushort namespaceIndex, string name, Func<T> createState) where T : BaseInstanceState
        {
            var qualifiedName = new QualifiedName(name, namespaceIndex);
            T instance = createState();
            instance.Create(context, null, qualifiedName, null, true);
            return instance;
        }
    }
}
