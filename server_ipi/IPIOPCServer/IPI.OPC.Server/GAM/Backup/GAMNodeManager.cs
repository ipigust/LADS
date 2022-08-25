using System.Collections.Generic;
using Opc.Ua;
using GAM;
using System.Reflection;
using IPI.Opc.Server;
using System.Linq;

namespace GAM
{
    /// <summary>
    /// A node manager the diagnostic information exposed by the server.
    /// </summary>
    public class GAMNodeManager : NodeManager
    {
        #region Private Fields
        private ushort m_namespaceIndex;
        private ushort m_typeNamespaceIndex;
        private long m_lastUsedId;
        private List<GAMDeviceState> m_GAMDevices;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        public GAMNodeManager(
            Opc.Ua.Server.IServerInternal server, 
            ApplicationConfiguration configuration)
        :
            base(server)
        {
            List<string> namespaceUris = new List<string>();
            namespaceUris.Add(global::GAM.Namespaces.GAM);
            namespaceUris.Add(global::GAM.Namespaces.GAM +"/Instance");
            NamespaceUris = namespaceUris;

            m_typeNamespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[0]);
            m_namespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[1]);

            m_lastUsedId = 0;
            m_GAMDevices = new List<global::GAM.GAMDeviceState>();
        }
        #endregion

        #region INodeIdFactory Members
        /// <summary>
        /// Creates the NodeId for the specified node.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="node">The node.</param>
        /// <returns>The new NodeId.</returns>
        public override NodeId New(ISystemContext context, NodeState node)
        {
            uint id = Utils.IncrementIdentifier(ref m_lastUsedId);
            return new NodeId(id, m_namespaceIndex);
        }
        #endregion

        #region INodeManager Members
        /// <summary>
        /// Does any initialization required before the address space can be used.
        /// </summary>
        /// <remarks>
        /// The externalReferences is an out parameter that allows the node manager to link to nodes
        /// in other node managers. For example, the 'Objects' node is managed by the CoreNodeManager and
        /// should have a reference to the root folder node(s) exposed by this node manager.  
        /// </remarks>
        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                base.CreateAddressSpace(externalReferences);
                CreateGAM(SystemContext);
            }
        }

        /// <summary>
        /// Creates a GAM and adds it to the address space.
        /// </summary>
        /// <param name="context">The context to use.</param>
        private void CreateGAM(SystemContext context)
        {
            GAMDeviceState gamDevice = new GAMDeviceState(null);

            string name = Utils.Format("GAM 2000");

            gamDevice.Create(
                context,
                null, 
                new QualifiedName(name, m_namespaceIndex),
                null, 
                true);

            var diNodeManager = Server.NodeManager.NodeManagers.ToList().Find(_ => _ is Opc.Ua.Di.DINodeManager) as Opc.Ua.Di.DINodeManager;
            if (diNodeManager != null)
            {
                NodeState deviceSet = (NodeState)diNodeManager.FindPredefinedNode(
                ExpandedNodeId.ToNodeId(global::Opc.Ua.Di.ObjectIds.DeviceSet, Server.NamespaceUris),
                typeof(NodeState));

                if (deviceSet != null)
                {
                    deviceSet.AddReference(Opc.Ua.ReferenceTypeIds.Organizes, false, gamDevice.NodeId);
                    gamDevice.AddReference(Opc.Ua.ReferenceTypeIds.Organizes, true, deviceSet.NodeId);
                }
            }

            string unitLabel = Utils.Format("10");

            UpdateDisplayName(gamDevice.Watchdog, unitLabel);

            m_GAMDevices.Add(gamDevice);

            AddPredefinedNode(context, gamDevice);

            //// Autostart GAM simulation state machine
            //MethodState start = gamDevice.Simulation.Start;
            //IList<Variant> inputArguments = new List<Variant>();
            //IList<Variant> outputArguments = new List<Variant>();
            //List<ServiceResult> errors = new List<ServiceResult>();
            //start.Call(context, gamDevice.NodeId, inputArguments, errors, outputArguments);
        }

        /// <summary>
        /// Updates the display name for an instance with the unit label name.
        /// </summary>
        /// <param name="instance">The instance to update.</param>
        /// <param name="label">The label to apply.</param>
        /// <remarks>This method assumes the DisplayName has the form NameX001 where X0 is the unit label placeholder.</remarks>
        private void UpdateDisplayName(BaseInstanceState instance, string unitLabel)
        {
            LocalizedText displayName = instance.DisplayName;

            if (displayName != null)
            {
                string text = displayName.Text;

                if (text != null)
                {
                    text = text.Replace("X0", unitLabel);
                }

                displayName = new LocalizedText(displayName.Locale, text);
            }

            instance.DisplayName = displayName;
        }

        /// <summary>
        /// Loads a node set from a file or resource and addes them to the set of predefined nodes.
        /// </summary>
        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context, "IPI.Opc.Server.GAM.GAM.PredefinedNodes.uanodes", this.GetType().GetTypeInfo().Assembly, true);

            return predefinedNodes;
        }

        /// <summary>
        /// Replaces the generic node with a node specific to the model.
        /// </summary>
        protected override NodeState AddBehaviourToPredefinedNode(ISystemContext context, NodeState predefinedNode)
        {
            BaseObjectState passiveNode = predefinedNode as BaseObjectState;

            if (passiveNode == null)
            {
                return predefinedNode;
            }

            NodeId typeId = passiveNode.TypeDefinitionId;

            if (!IsNodeIdInNamespace(typeId) || typeId.IdType != IdType.Numeric)
            {
                return predefinedNode;
            }

            switch ((uint)typeId.Identifier)
            {
                case global::GAM.ObjectTypes.GAMDeviceType:
                {
                    if (passiveNode is GAMDeviceState)
                    {
                        break;
                    }

                    GAMDeviceState activeNode = new GAMDeviceState(passiveNode.Parent);
                    activeNode.Create(context, passiveNode);

                    // replace the node in the parent.
                    if (passiveNode.Parent != null)
                    {
                        passiveNode.Parent.ReplaceChild(context, activeNode);
                    }

                    //// Autostart GAM simulation state machine
                    //MethodState start = activeNode.Simulation.Start;
                    //IList<Variant> inputArguments = new List<Variant>();
                    //IList<Variant> outputArguments = new List<Variant>();
                    //List<ServiceResult> errors = new List<ServiceResult>();
                    //start.Call(context, activeNode.NodeId, inputArguments, errors, outputArguments);

                    return activeNode;
                }
            }

            return predefinedNode;
        }

        /// <summary>
        /// Does any processing after a monitored item is created.
        /// </summary>
        protected override void OnCreateMonitoredItem(
            ISystemContext systemContext,
            MonitoredItemCreateRequest itemToCreate,
            MonitoredNode monitoredNode,
            DataChangeMonitoredItem monitoredItem)
        {
            // TBD
        }

        /// <summary>
        /// Does any processing after a monitored item is created.
        /// </summary>
        protected override void OnModifyMonitoredItem(
            ISystemContext systemContext,
            MonitoredItemModifyRequest itemToModify,
            MonitoredNode monitoredNode,
            DataChangeMonitoredItem monitoredItem,
            double previousSamplingInterval)
        {
            // TBD
        }

        /// <summary>
        /// Does any processing after a monitored item is deleted.
        /// </summary>
        protected override void OnDeleteMonitoredItem(
            ISystemContext systemContext,
            MonitoredNode monitoredNode,
            DataChangeMonitoredItem monitoredItem)
        {
            // TBD
        }

        /// <summary>
        /// Does any processing after a monitored item is created.
        /// </summary>
        protected override void OnSetMonitoringMode(
            ISystemContext systemContext,
            MonitoredNode monitoredNode,
            DataChangeMonitoredItem monitoredItem,
            MonitoringMode previousMode,
            MonitoringMode currentMode)
        {
            // TBD
        }
        #endregion
    }
}
