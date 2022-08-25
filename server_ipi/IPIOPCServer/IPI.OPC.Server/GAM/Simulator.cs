using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPI.OpcUaServer.GAM
{
    internal class Simulator
    {
        Task _simulationTask;
        CancellationTokenSource _simulationTaskCancel;
        Action<ISystemContext> _updateFunctionSet;

        public Simulator(Action<ISystemContext> updateValues)
        {
            _updateFunctionSet = updateValues;
        }

        public void Start(ISystemContext context)
        {
            if (_simulationTask != null)
            {
                _simulationTaskCancel.Cancel();
                _simulationTask = null;
            }

            _simulationTaskCancel = new CancellationTokenSource();

            _simulationTask = DoSimulation(context, _simulationTaskCancel);
        }

        public void Stop(ISystemContext context)
        {
            if (_simulationTask != null)
            {
                if (_simulationTaskCancel != null) _simulationTaskCancel.Cancel();
                _simulationTask = null;
            }
        }

        private async Task DoSimulation(ISystemContext context, CancellationTokenSource cancellationTokenSource)
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                try
                {
                    _updateFunctionSet(context);
                }
                catch (Exception e)
                {
                    Utils.Trace(e, "Unexpected error during GAM measurement.");
                }
                await Task.Delay(1000);
            }
        }
    }
}
