using IPI.OpcUaServer.Base;
using Opc.Ua;
using Spectaris.LADS;
using System;
using System.Collections.Generic;

namespace IPI.OpcUaServer.GAM
{
    internal class GAMTuneParametersFunctionalUnit : FunctionalUnitState //TuneParametersFunctionSetState, IStartStop
    {
        Simulator _simulator;
        ushort _namespaceIndex = 0;
        TuneParametersFunctionSetState _tuneParametersFunctionSetState;
        Random _random = new Random();

        public GAMTuneParametersFunctionalUnit(NodeState parent, ushort namespaceIndex) : base(parent)
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

            this.ComponentName.Value = "TuneParameters";
            var gamStateMachine = new GAMStateMachineState(this);
            this.ProgramManager.ActiveProgram = CreatePredefinedState(context, "ActiveProgram", () => gamStateMachine);
            this.ProgramManager.ActiveProgram.OnAfterTransition += OnControlMeasurement;

            _tuneParametersFunctionSetState = new TuneParametersFunctionSetState(this);
            this.FunctionSet = CreatePredefinedState(context, "FunctionSet", () => _tuneParametersFunctionSetState);

            InitializeFunctionSet(context);

            // Autostart readback of tune parameters
            MethodState start = gamStateMachine.Start;
            IList<Variant> inputArguments = new List<Variant>();
            IList<Variant> outputArguments = new List<Variant>();
            List<ServiceResult> errors = new List<ServiceResult>();
            start.Call(context, this.NodeId, inputArguments, errors, outputArguments);
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
            _simulator.Start(context);
        }

        private void Stop(ISystemContext context)
        {
            _simulator.Stop(context);
        }

        private void InitializeFunctionSet(ISystemContext context)
        {
            InitializeSensor(_tuneParametersFunctionSetState.IonReference, "IonReference", 0, 100, "VLT");
            InitializeSensor(_tuneParametersFunctionSetState.Cathode, "Cathode", 0, 100, "VLT");
            InitializeSensor(_tuneParametersFunctionSetState.Extraction, "Extraction", 0, 100, "VLT");
            InitializeSensor(_tuneParametersFunctionSetState.Focus, "Focus", 0, 100, "VLT");
            InitializeSensor(_tuneParametersFunctionSetState.FilamentCurrent, "FilamentCurrent", 0, 100, "AMP");
            InitializeSensor(_tuneParametersFunctionSetState.EmissionCurrent, "EmissionCurrent", 0, 100, "AMP");
            InitializeSensor(_tuneParametersFunctionSetState.Deflection, "Deflection", 0, 100, "VLT");
            InitializeSensor(_tuneParametersFunctionSetState.Prefilter, "Prefilter", 0, 100, "VLT");
            InitializeSensor(_tuneParametersFunctionSetState.SEMVoltage, "SEMVoltage", 0, 100, "VLT");
            InitializeSensor(_tuneParametersFunctionSetState.UVRatio, "UVRatio", 0, 100, string.Empty);
            InitializeSensor(_tuneParametersFunctionSetState.FieldAxis, "FieldAxis", 0, 100, "VLT");
            InitializeSensor(_tuneParametersFunctionSetState.Resolution, "Resolution", 0, 100, string.Empty);
            InitializeSensor(_tuneParametersFunctionSetState.Slope, "Slope", 0, 100, string.Empty);
            InitializeSensor(_tuneParametersFunctionSetState.UOffset, "UOffset", 0, 100, string.Empty);
        }

        private void UpdateFunctionSet(ISystemContext context)
        {
            var timeStamp = DateTime.UtcNow;

            UpdateSensor(_tuneParametersFunctionSetState.IonReference, timeStamp, 84.0);
            UpdateSensor(_tuneParametersFunctionSetState.Cathode, timeStamp, -70.0);
            UpdateSensor(_tuneParametersFunctionSetState.Extraction, timeStamp, -240.0);
            UpdateSensor(_tuneParametersFunctionSetState.Focus, timeStamp, -24.0);
            UpdateSensor(_tuneParametersFunctionSetState.FilamentCurrent, timeStamp, 4.0);
            UpdateSensor(_tuneParametersFunctionSetState.EmissionCurrent, timeStamp, 0.8);
            UpdateSensor(_tuneParametersFunctionSetState.Deflection, timeStamp, 0.0);
            UpdateSensor(_tuneParametersFunctionSetState.Prefilter, timeStamp, -18.0);
            UpdateSensor(_tuneParametersFunctionSetState.SEMVoltage, timeStamp, 900.0);
            UpdateSensor(_tuneParametersFunctionSetState.UVRatio, timeStamp, 1.0655);
            UpdateSensor(_tuneParametersFunctionSetState.FieldAxis, timeStamp, 79.0);
            UpdateSensor(_tuneParametersFunctionSetState.Resolution, timeStamp, 72);
            UpdateSensor(_tuneParametersFunctionSetState.Slope, timeStamp, 34.752);
            UpdateSensor(_tuneParametersFunctionSetState.UOffset, timeStamp, 2400);

            this.ClearChangeMasks(context, true);
        }

        private void InitializeSensor(DoubleAnalogSensorFunctionState sensorFunctionState, string displayName, double lowValue, double highValue, string unceCode)
        {
            if (sensorFunctionState != null) SensorFunctionHelper.Initialize_SensorFunctionState(sensorFunctionState, displayName, lowValue, highValue, unceCode);
        }

        private void UpdateSensor(DoubleAnalogSensorFunctionState sensorFunctionState, DateTime timeStamp, double value)
        {
            value = SensorFunctionHelper.Randomize(_random, value, 2);

            if (sensorFunctionState != null) SensorFunctionHelper.Update_SensorFunctionState(sensorFunctionState, timeStamp, value);
        }

        private T CreatePredefinedState<T>(ISystemContext context, string name, Func<T> createState) where T : BaseInstanceState
        {
            var qualifiedName = new QualifiedName(name, _namespaceIndex);
            T instance = createState();
            instance.Create(context, null, qualifiedName, null, true);
            return instance;
        }
    }
}