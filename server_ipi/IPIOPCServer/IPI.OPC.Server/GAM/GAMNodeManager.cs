using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IPI.OpcUaServer.GAM
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
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        public GAMNodeManager(
            IServerInternal server,
            ApplicationConfiguration configuration)
        :
            base(server)
        {
            List<string> namespaceUris = new List<string>();
            namespaceUris.Add(Namespaces.GAM);
            namespaceUris.Add(Namespaces.GAM + "/Instance");
            NamespaceUris = namespaceUris;

            m_typeNamespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[0]);
            m_namespaceIndex = Server.NamespaceUris.GetIndexOrAppend(namespaceUris[1]);

            m_lastUsedId = 0;
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
            var diNodeManager = Server.NodeManager.NodeManagers.ToList().Find(_ => _ is global::Opc.Ua.Di.DINodeManager) as global::Opc.Ua.Di.DINodeManager;
            if (diNodeManager != null)
            {
                NodeState deviceSet = (NodeState)diNodeManager.FindPredefinedNode(
                    ExpandedNodeId.ToNodeId(global::Opc.Ua.Di.ObjectIds.DeviceSet, Server.NamespaceUris),
                    typeof(NodeState));

                if (deviceSet != null)
                {
                    GAMDeviceState gamDevice = CreatePredefinedState(context, "IPI Mass Spectrometer", () => new GAMDeviceState(deviceSet));

                    deviceSet.AddReference(ReferenceTypeIds.Organizes, false, gamDevice.NodeId);
                    gamDevice.AddReference(ReferenceTypeIds.Organizes, true, deviceSet.NodeId);

                    AddMeasurementFunctionalUnit(context, gamDevice);
                    AddTuneParameterFunctionalUnit(context, gamDevice);

                    AddPredefinedNode(context, gamDevice);
                }
            }
        }

        private void AddTuneParameterFunctionalUnit(SystemContext context, GAMDeviceState gamDevice)
        {
            var functionalUnitStateTuneParameters = CreateFunctionalUnit(context, "TuneParameter", () => new GAMTuneParametersFunctionalUnit(gamDevice.FunctionalUnitSet, m_namespaceIndex));

            AddChildToNodeSet(gamDevice.FunctionalUnitSet, functionalUnitStateTuneParameters);
        }

        private void AddMeasurementFunctionalUnit(SystemContext context, GAMDeviceState gamDevice)
        {
            var functionalUnitStateMeasure = CreateFunctionalUnit(context, "Measure", () => new GAMMeasureFunctionalUnitState(gamDevice.FunctionalUnitSet, m_namespaceIndex));

            AddChildToNodeSet(gamDevice.FunctionalUnitSet, functionalUnitStateMeasure);
        }

        private T CreateFunctionalUnit<T>(SystemContext context, string name, Func<T> create) where T : Spectaris.LADS.FunctionalUnitState
        {
            var functionalUnitStateMeasure = create();
            functionalUnitStateMeasure.Create(context, null, new QualifiedName(name, m_namespaceIndex), null, true);
            functionalUnitStateMeasure.ComponentName.Value = name;
            return functionalUnitStateMeasure;
        }

        private T CreatePredefinedState<T>(SystemContext context, string name, Func<T> createState) where T : BaseInstanceState
        {
            var qualifiedName = new QualifiedName(name, m_namespaceIndex);
            T instance = createState();
            instance.Create(context, null, qualifiedName, null, true);
            return instance;
        }

        private void AddChildToNodeSet(NodeState parent, BaseInstanceState child)
        {
            //var childNodeId = CreateNode(SystemContext, parent.NodeId, null, child.BrowseName, child);
            parent.AddChild(child);
            parent.AddReference(ReferenceTypeIds.Organizes, false, child.NodeId);
            child.AddReference(ReferenceTypeIds.Organizes, true, parent.NodeId);
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

        #region Protected Members
        /// <summary>
        /// The resource path of the predefined nodes.
        /// </summary>
        protected override string PredefinedNodesResourcePath => "IPI.OpcUaServer.GAM.GeneratedCode.IPI.OpcUaServer.GAM.PredefinedNodes.uanodes";
        #endregion
    }
}
