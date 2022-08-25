using Opc.Ua;
using Opc.Ua.Di;
using System;

namespace IPI.OpcUaServer.GAM
{
    public partial class GAMDeviceState
    {
        #region Initialization
        /// <summary>
        /// Initializes the object as a collection of counters which change value on read.
        /// </summary>
        protected override void OnAfterCreate(ISystemContext context, NodeState node)
        {
            base.OnAfterCreate(context, node);

            this.Manufacturer.Value = "InProcess Instruments GmbH";
            this.Model.Value = "GAM 2000";
            this.HardwareRevision.Value = "0.4";
            this.SoftwareRevision.Value = "0.3.11";
            this.DeviceRevision.Value = "1.0";
            this.SerialNumber.Value = "800012345";

            this.DeviceHealth.Value = DeviceHealthEnumeration.NORMAL;

            UpdateSystemStatus(DateTime.UtcNow);
        }
        #endregion

        #region IDisposeable Methods
        /// <summary>
        /// Cleans up when the object is disposed.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    if (_simulationTask != null)
            //    {
            //        _simulationTask.Dispose();
            //    }
            //}
        }
        #endregion

        private void UpdateSystemStatus(DateTime timeStamp)
        {
            m_systemStatus.AutomaticMode.Value = true;
            m_systemStatus.ManualMode.Value = false;
            m_systemStatus.GAMtemperatureOver35DegreeC.Value = false;
            m_systemStatus.GAMOK.Value = true;
            m_systemStatus.SystemStatusText.Value = "Stand by";
        }
    }
}
