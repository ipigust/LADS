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
    internal class GAMMeasureFunctionSetState : FunctionSetState, IStartStop
    {
        Random _random = new Random();
        Simulator _simulator;
        List<string> _methods = new List<string>() { "Method 1", "Method 2", "Method 3", "Method 4" };

        public GAMMeasureFunctionSetState(Spectaris.LADS.FunctionalUnitState functionalUnitState) : base(functionalUnitState)
        {
            _simulator = new Simulator(UpdateFunctionSet);
        }

        #region Initialization
        /// <summary>
        /// Initializes the object as a collection of counters which change value on read.
        /// </summary>
        protected override void OnAfterCreate(ISystemContext context, NodeState node)
        {
            base.OnAfterCreate(context, node);

            _random = new Random();

            InitializeFunctionSet(context);
        }
        #endregion

        public void Start(ISystemContext context, IList<object> inputArguments)
        {
            string startMethod = string.Empty;
            if (inputArguments.Count > 0 && inputArguments[0] != null) startMethod = inputArguments[0].ToString();

            // Load Method
            if (!_methods.Contains(startMethod))
            {
                throw new ArgumentException("Unknown program template");
            }

            _simulator.Start(context);
        }

        public void Stop(ISystemContext context)
        {
            _simulator.Stop(context);
        }

        private void InitializeFunctionSet(ISystemContext context)
        {
            InitializeSensor(context, "Concentration_Ar", 0, 100, "P1");
            InitializeSensor(context, "Concentration_N2", 0, 100, "P1");
            InitializeSensor(context, "Concentration_O2", 0, 100, "P1");

            InitializeSensor(context, "Intensity_28", 0, 1e-5, "AMP");
            InitializeSensor(context, "Intensity_32", 0, 1e-5, "AMP");
            InitializeSensor(context, "Intensity_40", 0, 1e-5, "AMP");
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

        private void InitializeSensor(ISystemContext context, string name, double lowValue, double highValue, string unceCode)
        {
            var sensorFunctionState = FindChildBySymbolicName(context, name) as DoubleAnalogSensorFunctionState;
            if (sensorFunctionState != null) SensorFunctionHelper.Initialize_SensorFunctionState(sensorFunctionState, lowValue, highValue, unceCode);
        }

        private void UpdateSensor(ISystemContext context, string name, DateTime timeStamp, double value)
        {
            var sensorFunctionState = FindChildBySymbolicName(context, name) as DoubleAnalogSensorFunctionState;
            if (sensorFunctionState != null) SensorFunctionHelper.Update_SensorFunctionState(sensorFunctionState, timeStamp, value);
        }

    }
}
