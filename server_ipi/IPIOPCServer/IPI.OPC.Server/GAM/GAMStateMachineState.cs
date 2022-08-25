using Opc.Ua;

namespace IPI.OpcUaServer.GAM
{
    public partial class GAMStateMachineState
    {
        //
        // Summary:
        //     A table of transitions for the available causes.
        private uint[,] s_CauseMappings = new uint[2, 3]
        {
            {
                2426u,  // Start
                2400u,  // Ready
                2410u   // ReadyToRunning
            },
            {
                2429u,  // Halt
                2402u,  // Running
                2414u   // RunningToReady
            },
        };

        #region Initialization
        /// <summary>
        /// Initializes the object as a collection of counters which change value on read.
        /// </summary>
        protected override void OnAfterCreate(ISystemContext context, NodeState node)
        {
            base.OnAfterCreate(context, node);

            Start.OnCallMethod = OnStart;
            Start.OnReadExecutable = IsStartExecutable;
            Start.OnReadUserExecutable = IsStartUserExecutable;

            Stop.OnCallMethod = OnHalt;
            Stop.OnReadExecutable = IsHaltExecutable;
            Stop.OnReadUserExecutable = IsHaltUserExecutable;
        }

        //
        // Summary:
        //     The mapping between transitions and their from and to states.
        //
        // Summary:
        //     The mapping between causes, the current state and a transition.
        protected override uint[,] CauseMappings => s_CauseMappings;

        #endregion
    }
}
