using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IPI.OpcUaServer.GAM
{
    internal class GAMStartStopStateMachine : GAMStateMachineState
    {
        IStartStop _startStop;

        public GAMStartStopStateMachine(IStartStop startStop, NodeState parent) : base(parent)
        {
            _startStop = startStop;
        }

        #region Initialization
        /// <summary>
        /// Initializes the object as a collection of counters which change value on read.
        /// </summary>
        protected override void OnAfterCreate(ISystemContext context, NodeState node)
        {
            base.OnAfterCreate(context, node);

            OnAfterTransition = OnControlMeasurement;
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
                    {
                        _startStop?.Start(context, inputArguments);

                        break;
                    }

                case Opc.Ua.Methods.ProgramStateMachineType_Halt:
                    {
                        _startStop?.Stop(context);

                        break;
                    }

                case Opc.Ua.Methods.ProgramStateMachineType_Suspend:
                case Opc.Ua.Methods.ProgramStateMachineType_Reset:
                    break;
            }

            return ServiceResult.Good;
        }


    }
}
