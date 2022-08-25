using Opc.Ua;
using System;
using System.Threading.Tasks;

namespace GAM
{
    public partial class GAMDeviceState
    {
        Random _random = new Random();
        Task _simulationTask;
        ISystemContext _simulationContext;

        //public GAMDeviceState()
        //{
        //    Task t = DoSimulation();
        //}

        #region Initialization
        /// <summary>
        /// Initializes the object as a collection of counters which change value on read.
        /// </summary>
        protected override void OnAfterCreate(ISystemContext context, NodeState node)
        {
            base.OnAfterCreate(context, node);

            _simulationContext = context;
            _simulationTask = DoSimulation();
            _random = new Random();
            
            this.Manufacturer.Value = "InProcess Instruments GmbH";
            //this.ManufacturerUri.Value = "www.in-process.com";
            this.Model.Value = "GAM 2000";
            this.HardwareRevision.Value = "0.4";
            this.SoftwareRevision.Value = "0.3.11";
            this.DeviceRevision.Value = "1.0";
            this.SerialNumber.Value = "800012345";

            this.DeviceHealth.Value = Opc.Ua.Di.DeviceHealthEnumeration.NORMAL;
        }
        #endregion

        #region IDisposeable Methods
        /// <summary>
        /// Cleans up when the object is disposed.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_simulationTask != null)
                {
                    _simulationTask.Dispose();
                }
            }
        }
        #endregion

        private async Task DoSimulation()
        {
            do
            {
                try
                {
                    var timeStamp = DateTime.UtcNow;

                    UpdateWatchdog(timeStamp);
                    UpdateSystemStatus(timeStamp);

                    UpdateReadback_TuneParameters(timeStamp);

                    this.ClearChangeMasks(_simulationContext, true);
                }
                catch (Exception e)
                {
                    Utils.Trace(e, "Unexpected error during GAM simulation.");
                }
                await Task.Delay(1000);
            } while (true);
        }

        private void UpdateReadback_TuneParameters(DateTime timeStamp)
        {
            Update_ReadbackValue(m_readbackTuneParameters.IonReference, timeStamp, 84.0, "VLT");
            Update_ReadbackValue(m_readbackTuneParameters.Cathode, timeStamp, -70.0, "VLT");
            Update_ReadbackValue(m_readbackTuneParameters.Extraction, timeStamp, -240.0, "VLT");
            Update_ReadbackValue(m_readbackTuneParameters.Focus, timeStamp, -24.0, "VLT");
            Update_ReadbackValue(m_readbackTuneParameters.FilamentCurrent, timeStamp, 4.0, "AMP");
            Update_ReadbackValue(m_readbackTuneParameters.EmissionCurrent, timeStamp, 0.8, "AMP");
            Update_ReadbackValue(m_readbackTuneParameters.Deflection, timeStamp, 0.0, "VLT");
            Update_ReadbackValue(m_readbackTuneParameters.Prefilter, timeStamp, -18.0, "VLT");
            Update_ReadbackValue(m_readbackTuneParameters.SEMVoltage, timeStamp, 900.0, "VLT");
            Update_ReadbackValue(m_readbackTuneParameters.UVRatio, timeStamp, 1.0655, "C62");
            Update_ReadbackValue(m_readbackTuneParameters.FieldAxis, timeStamp, 79.0, "VLT");
            Update_ReadbackValue(m_readbackTuneParameters.SelectedFilament, timeStamp, 1, "C62");
            Update_ReadbackValue(m_readbackTuneParameters.Resolution, timeStamp, 72, "C62");
            Update_ReadbackValue(m_readbackTuneParameters.Slope, timeStamp, 34.752, "C62");
            Update_ReadbackValue(m_readbackTuneParameters.UOffset, timeStamp, 2400, "C62");
            Update_ReadbackValue(m_readbackTuneParameters.DetectorType, timeStamp, "SEM");
            Update_ReadbackValue(m_readbackTuneParameters.DetectorInputPin, timeStamp, 1, "C62");
            Update_ReadbackValue(m_readbackTuneParameters.FIREnabled, timeStamp, false);
        }

        private void UpdateSystemStatus(DateTime timeStamp)
        {
            m_systemStatus.AutomaticMode.Value = true;
            m_systemStatus.ManualMode.Value = false;
            m_systemStatus.GAMtemperatureOver35DegreeC.Value = false;
            m_systemStatus.GAMOK.Value = true;
            m_systemStatus.SystemStatusText.Value = "Stand by";
        }

        private void UpdateWatchdog(DateTime timeStamp)
        {
            m_watchdog.Trigger.Value = !m_watchdog.Trigger.Value;
            m_watchdog.Trigger.Timestamp = timeStamp;

            m_watchdog.Counter.Value = (Int16)((m_watchdog.Counter.Value + 1) % 1000);
            m_watchdog.Counter.Timestamp = timeStamp;
        }

        private void Update_ReadbackValue(AnalogUnitState<double> analogUnitState, DateTime timeStamp, double value, string unceCode)
        {
            Update_AnalogUnitState(analogUnitState, timeStamp, value + (_random.NextDouble() - 0.5) * (value / 100.0), unceCode);
        }

        private void Update_ReadbackValue(AnalogUnitState<short> analogUnitState, DateTime timeStamp, short value, string unceCode)
        {
            Update_AnalogUnitState(analogUnitState, timeStamp, value, unceCode);
        }

        private void Update_ReadbackValue(AnalogUnitState<int> analogUnitState, DateTime timeStamp, int value, string unceCode)
        {
            Update_AnalogUnitState(analogUnitState, timeStamp, value, unceCode);
        }

        private void Update_ReadbackValue(AnalogUnitState<string> analogUnitState, DateTime timeStamp, string value)
        {
            Update_AnalogUnitState(analogUnitState, timeStamp, value, "C62");
        }

        private void Update_ReadbackValue(AnalogUnitState<bool> analogUnitState, DateTime timeStamp, bool value)
        {
            Update_AnalogUnitState(analogUnitState, timeStamp, value, "C62");
        }

        private void Update_AnalogUnitState<T>(AnalogUnitState<T> analogUnitState, DateTime timeStamp, T value, string unceCode)
        {
            analogUnitState.Value = value;
            //analogUnitState.EURange.Value = new Opc.Ua.Range() { High = 200, Low = 0 };
            analogUnitState.Timestamp = timeStamp;

            switch (unceCode)
            {
                case "C62":
                    analogUnitState.EngineeringUnits.Value = new EUInformation("1", "one", " http://www.opcfoundation.org/UA/units/un/cefact");
                    analogUnitState.EngineeringUnits.Value.UnitId = 4404786;
                    break;
                case "VLT":
                    analogUnitState.EngineeringUnits.Value = new EUInformation("V", "volt", " http://www.opcfoundation.org/UA/units/un/cefact");
                    analogUnitState.EngineeringUnits.Value.UnitId = 5655636;
                    break;
                case "AMP":
                    analogUnitState.EngineeringUnits.Value = new EUInformation("A", "ampere", " http://www.opcfoundation.org/UA/units/un/cefact");
                    analogUnitState.EngineeringUnits.Value.UnitId = 4279632;
                    break;
            }
        }
    }
}
