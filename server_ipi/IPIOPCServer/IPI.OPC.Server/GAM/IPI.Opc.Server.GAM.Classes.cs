/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.Di;

namespace IPI.Opc.Server.GAM
{
    #region GenericSensorState Class
    #if (!OPCUA_EXCLUDE_GenericSensorState)
    /// <summary>
    /// Stores an instance of the GenericSensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericSensorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericSensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(IPI.Opc.Server.GAM.ObjectTypes.GenericSensorType, IPI.Opc.Server.GAM.Namespaces.GAM, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHQAAAGh0dHA6Ly9pbi1wcm9jZXNz" +
           "LmNvbS9VQS9HQU0v/////wRggAIBAAAAAgAZAAAAR2VuZXJpY1NlbnNvclR5cGVJbnN0YW5jZQECAQAB" +
           "AgEAAQAAAP////8BAAAAFWCJCgIAAAACAAYAAABPdXRwdXQBAgIAAC8BAFlEAgAAAAAL/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAgcAAC4ARAcAAAABAHcD/////wEB////" +
           "/wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogUnitState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_output != null)
            {
                children.Add(m_output);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case IPI.Opc.Server.GAM.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                Output = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogUnitState<double> m_output;
        #endregion
    }
    #endif
    #endregion

    #region GenericActuatorState Class
    #if (!OPCUA_EXCLUDE_GenericActuatorState)
    /// <summary>
    /// Stores an instance of the GenericActuatorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericActuatorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericActuatorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(IPI.Opc.Server.GAM.ObjectTypes.GenericActuatorType, IPI.Opc.Server.GAM.Namespaces.GAM, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHQAAAGh0dHA6Ly9pbi1wcm9jZXNz" +
           "LmNvbS9VQS9HQU0v/////wRggAIBAAAAAgAbAAAAR2VuZXJpY0FjdHVhdG9yVHlwZUluc3RhbmNlAQII" +
           "AAECCAAIAAAA/////wEAAAAVYIkKAgAAAAIABQAAAElucHV0AQIJAAAvAQBACQkAAAAAC/////8CAv//" +
           "//8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQINAAAuAEQNAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Input
        {
            get
            {
                return m_input;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_input != null)
            {
                children.Add(m_input);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case IPI.Opc.Server.GAM.BrowseNames.Input:
                {
                    if (createOrReplace)
                    {
                        if (Input == null)
                        {
                            if (replacement == null)
                            {
                                Input = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Input = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Input;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_input;
        #endregion
    }
    #endif
    #endregion

    #region WatchdogState Class
    #if (!OPCUA_EXCLUDE_WatchdogState)
    /// <summary>
    /// Stores an instance of the WatchdogType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WatchdogState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public WatchdogState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(IPI.Opc.Server.GAM.ObjectTypes.WatchdogType, IPI.Opc.Server.GAM.Namespaces.GAM, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHQAAAGh0dHA6Ly9pbi1wcm9jZXNz" +
           "LmNvbS9VQS9HQU0v/////wRggAIBAAAAAgAUAAAAV2F0Y2hkb2dUeXBlSW5zdGFuY2UBAg8AAQIPAA8A" +
           "AAACAAAAADAAAQIQAAAwAAECFgACAAAAFWCJCgIAAAACAAcAAABUcmlnZ2VyAQIQAAAvAQBACRAAAAAA" +
           "Af////8BAQEAAAAAMAEBAg8AAQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQECFAAALgBEFAAAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAgAHAAAAQ291bnRlcgECFgAALwEAQAkWAAAAAAT/////AQEBAAAA" +
           "ADABAQIPAAEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAhoAAC4ARBoAAAABAHQD/////wEB/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<bool> Trigger
        {
            get
            {
                return m_trigger;
            }

            set
            {
                if (!Object.ReferenceEquals(m_trigger, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_trigger = value;
            }
        }

        /// <remarks />
        public AnalogItemState<short> Counter
        {
            get
            {
                return m_counter;
            }

            set
            {
                if (!Object.ReferenceEquals(m_counter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_counter = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_trigger != null)
            {
                children.Add(m_trigger);
            }

            if (m_counter != null)
            {
                children.Add(m_counter);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case IPI.Opc.Server.GAM.BrowseNames.Trigger:
                {
                    if (createOrReplace)
                    {
                        if (Trigger == null)
                        {
                            if (replacement == null)
                            {
                                Trigger = new AnalogItemState<bool>(this);
                            }
                            else
                            {
                                Trigger = (AnalogItemState<bool>)replacement;
                            }
                        }
                    }

                    instance = Trigger;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.Counter:
                {
                    if (createOrReplace)
                    {
                        if (Counter == null)
                        {
                            if (replacement == null)
                            {
                                Counter = new AnalogItemState<short>(this);
                            }
                            else
                            {
                                Counter = (AnalogItemState<short>)replacement;
                            }
                        }
                    }

                    instance = Counter;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<bool> m_trigger;
        private AnalogItemState<short> m_counter;
        #endregion
    }
    #endif
    #endregion

    #region GAMSystemStatusState Class
    #if (!OPCUA_EXCLUDE_GAMSystemStatusState)
    /// <summary>
    /// Stores an instance of the GAMSystemStatusType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GAMSystemStatusState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GAMSystemStatusState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(IPI.Opc.Server.GAM.ObjectTypes.GAMSystemStatusType, IPI.Opc.Server.GAM.Namespaces.GAM, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHQAAAGh0dHA6Ly9pbi1wcm9jZXNz" +
           "LmNvbS9VQS9HQU0v/////wRggAIBAAAAAgAbAAAAR0FNU3lzdGVtU3RhdHVzVHlwZUluc3RhbmNlAQI5" +
           "AAECOQA5AAAA/////wUAAAAVYIkKAgAAAAIADQAAAEF1dG9tYXRpY01vZGUBAjoAAC4ARDoAAAAAAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAACAAUAAABHQU1PSwECOwAALgBEOwAAAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAIAGwAAAEdBTXRlbXBlcmF0dXJlT3ZlcjM1RGVncmVlQwECPAAALgBEPAAAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAIACgAAAE1hbnVhbE1vZGUBAj0AAC4ARD0AAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAACABAAAABTeXN0ZW1TdGF0dXNUZXh0AQI+AAAuAEQ+AAAAABX/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<bool> AutomaticMode
        {
            get
            {
                return m_automaticMode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_automaticMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_automaticMode = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> GAMOK
        {
            get
            {
                return m_gAMOK;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gAMOK, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gAMOK = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> GAMtemperatureOver35DegreeC
        {
            get
            {
                return m_gAMtemperatureOver35DegreeC;
            }

            set
            {
                if (!Object.ReferenceEquals(m_gAMtemperatureOver35DegreeC, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_gAMtemperatureOver35DegreeC = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> ManualMode
        {
            get
            {
                return m_manualMode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manualMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manualMode = value;
            }
        }

        /// <remarks />
        public PropertyState<LocalizedText> SystemStatusText
        {
            get
            {
                return m_systemStatusText;
            }

            set
            {
                if (!Object.ReferenceEquals(m_systemStatusText, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_systemStatusText = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_automaticMode != null)
            {
                children.Add(m_automaticMode);
            }

            if (m_gAMOK != null)
            {
                children.Add(m_gAMOK);
            }

            if (m_gAMtemperatureOver35DegreeC != null)
            {
                children.Add(m_gAMtemperatureOver35DegreeC);
            }

            if (m_manualMode != null)
            {
                children.Add(m_manualMode);
            }

            if (m_systemStatusText != null)
            {
                children.Add(m_systemStatusText);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case IPI.Opc.Server.GAM.BrowseNames.AutomaticMode:
                {
                    if (createOrReplace)
                    {
                        if (AutomaticMode == null)
                        {
                            if (replacement == null)
                            {
                                AutomaticMode = new PropertyState<bool>(this);
                            }
                            else
                            {
                                AutomaticMode = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = AutomaticMode;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.GAMOK:
                {
                    if (createOrReplace)
                    {
                        if (GAMOK == null)
                        {
                            if (replacement == null)
                            {
                                GAMOK = new PropertyState<bool>(this);
                            }
                            else
                            {
                                GAMOK = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = GAMOK;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.GAMtemperatureOver35DegreeC:
                {
                    if (createOrReplace)
                    {
                        if (GAMtemperatureOver35DegreeC == null)
                        {
                            if (replacement == null)
                            {
                                GAMtemperatureOver35DegreeC = new PropertyState<bool>(this);
                            }
                            else
                            {
                                GAMtemperatureOver35DegreeC = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = GAMtemperatureOver35DegreeC;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.ManualMode:
                {
                    if (createOrReplace)
                    {
                        if (ManualMode == null)
                        {
                            if (replacement == null)
                            {
                                ManualMode = new PropertyState<bool>(this);
                            }
                            else
                            {
                                ManualMode = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = ManualMode;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.SystemStatusText:
                {
                    if (createOrReplace)
                    {
                        if (SystemStatusText == null)
                        {
                            if (replacement == null)
                            {
                                SystemStatusText = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                SystemStatusText = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = SystemStatusText;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<bool> m_automaticMode;
        private PropertyState<bool> m_gAMOK;
        private PropertyState<bool> m_gAMtemperatureOver35DegreeC;
        private PropertyState<bool> m_manualMode;
        private PropertyState<LocalizedText> m_systemStatusText;
        #endregion
    }
    #endif
    #endregion

    #region ReadbackTuneParametersState Class
    #if (!OPCUA_EXCLUDE_ReadbackTuneParametersState)
    /// <summary>
    /// Stores an instance of the ReadbackTuneParametersType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ReadbackTuneParametersState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ReadbackTuneParametersState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(IPI.Opc.Server.GAM.ObjectTypes.ReadbackTuneParametersType, IPI.Opc.Server.GAM.Namespaces.GAM, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHQAAAGh0dHA6Ly9pbi1wcm9jZXNz" +
           "LmNvbS9VQS9HQU0v/////wRggAIBAAAAAgAiAAAAUmVhZGJhY2tUdW5lUGFyYW1ldGVyc1R5cGVJbnN0" +
           "YW5jZQECSwABAksASwAAAP////8SAAAAFWCJCgIAAAACAAwAAABJb25SZWZlcmVuY2UBAkwAAC8BAFlE" +
           "TAAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAlEAAC4ARFEA" +
           "AAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAIABwAAAENhdGhvZGUBAtQAAC8BAFlE1AAAAAAL////" +
           "/wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAtkAAC4ARNkAAAABAHcD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAIACgAAAEV4dHJhY3Rpb24BAtoAAC8BAFlE2gAAAAAL/////wEB////" +
           "/wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAt8AAC4ARN8AAAABAHcD/////wEB////" +
           "/wAAAAAVYIkKAgAAAAIABQAAAEZvY3VzAQLgAAAvAQBZROAAAAAAC/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQLlAAAuAETlAAAAAQB3A/////8BAf////8AAAAAFWCJCgIA" +
           "AAACAA8AAABGaWxhbWVudEN1cnJlbnQBAuYAAC8BAFlE5gAAAAAL/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAusAAC4AROsAAAABAHcD/////wEB/////wAAAAAVYIkKAgAA" +
           "AAIADwAAAEVtaXNzaW9uQ3VycmVudAEC7AAALwEAWUTsAAAAAAv/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAQAAAARW5naW5lZXJpbmdVbml0cwEC8QAALgBE8QAAAAEAdwP/////AQH/////AAAAABVgiQoCAAAA" +
           "AgAKAAAARGVmbGVjdGlvbgEC8gAALwEAWUTyAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAQAAAA" +
           "RW5naW5lZXJpbmdVbml0cwEC9wAALgBE9wAAAAEAdwP/////AQH/////AAAAABVgiQoCAAAAAgAJAAAA" +
           "UHJlZmlsdGVyAQL4AAAvAQBZRPgAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAABAAAABFbmdpbmVl" +
           "cmluZ1VuaXRzAQL9AAAuAET9AAAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAACAAoAAABTRU1Wb2x0" +
           "YWdlAQKUAQAvAQBZRJQBAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1Vu" +
           "aXRzAQKZAQAuAESZAQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAACAAcAAABVVlJhdGlvAQIEAQAv" +
           "AQBZRAQBAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQIJAQAu" +
           "AEQJAQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAACAAkAAABGaWVsZEF4aXMBAgoBAC8BAFlECgEA" +
           "AAAL/////wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAg8BAC4ARA8BAAAB" +
           "AHcD/////wEB/////wAAAAAVYIkKAgAAAAIAEAAAAFNlbGVjdGVkRmlsYW1lbnQBAhABAC8BAFlEEAEA" +
           "AAAE/////wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAhUBAC4ARBUBAAAB" +
           "AHcD/////wEB/////wAAAAAVYIkKAgAAAAIACgAAAFJlc29sdXRpb24BAhYBAC8BAFlEFgEAAAAL////" +
           "/wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAhsBAC4ARBsBAAABAHcD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAIABQAAAFNsb3BlAQIcAQAvAQBZRBwBAAAAC/////8BAf////8BAAAA" +
           "FWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQIhAQAuAEQhAQAAAQB3A/////8BAf////8AAAAA" +
           "FWCJCgIAAAACAAcAAABVT2Zmc2V0AQIiAQAvAQBZRCIBAAAABP////8BAf////8BAAAAFWCJCgIAAAAA" +
           "ABAAAABFbmdpbmVlcmluZ1VuaXRzAQInAQAuAEQnAQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAAC" +
           "AAwAAABEZXRlY3RvclR5cGUBAigBAC8BAFlEKAEAAAAM/////wEB/////wEAAAAVYIkKAgAAAAAAEAAA" +
           "AEVuZ2luZWVyaW5nVW5pdHMBAi0BAC4ARC0BAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAIAEAAA" +
           "AERldGVjdG9ySW5wdXRQaW4BAi4BAC8BAFlELgEAAAAE/////wEB/////wEAAAAVYIkKAgAAAAAAEAAA" +
           "AEVuZ2luZWVyaW5nVW5pdHMBAjMBAC4ARDMBAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAIACgAA" +
           "AEZJUkVuYWJsZWQBAqABAC8BAFlEoAEAAAAB/////wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2lu" +
           "ZWVyaW5nVW5pdHMBAqUBAC4ARKUBAAABAHcD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogUnitState<double> IonReference
        {
            get
            {
                return m_ionReference;
            }

            set
            {
                if (!Object.ReferenceEquals(m_ionReference, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_ionReference = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<double> Cathode
        {
            get
            {
                return m_cathode;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cathode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cathode = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<double> Extraction
        {
            get
            {
                return m_extraction;
            }

            set
            {
                if (!Object.ReferenceEquals(m_extraction, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_extraction = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<double> Focus
        {
            get
            {
                return m_focus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_focus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_focus = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<double> FilamentCurrent
        {
            get
            {
                return m_filamentCurrent;
            }

            set
            {
                if (!Object.ReferenceEquals(m_filamentCurrent, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_filamentCurrent = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<double> EmissionCurrent
        {
            get
            {
                return m_emissionCurrent;
            }

            set
            {
                if (!Object.ReferenceEquals(m_emissionCurrent, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_emissionCurrent = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<double> Deflection
        {
            get
            {
                return m_deflection;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deflection, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deflection = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<double> Prefilter
        {
            get
            {
                return m_prefilter;
            }

            set
            {
                if (!Object.ReferenceEquals(m_prefilter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_prefilter = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<double> SEMVoltage
        {
            get
            {
                return m_sEMVoltage;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sEMVoltage, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sEMVoltage = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<double> UVRatio
        {
            get
            {
                return m_uVRatio;
            }

            set
            {
                if (!Object.ReferenceEquals(m_uVRatio, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_uVRatio = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<double> FieldAxis
        {
            get
            {
                return m_fieldAxis;
            }

            set
            {
                if (!Object.ReferenceEquals(m_fieldAxis, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fieldAxis = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<short> SelectedFilament
        {
            get
            {
                return m_selectedFilament;
            }

            set
            {
                if (!Object.ReferenceEquals(m_selectedFilament, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_selectedFilament = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<double> Resolution
        {
            get
            {
                return m_resolution;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resolution, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resolution = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<double> Slope
        {
            get
            {
                return m_slope;
            }

            set
            {
                if (!Object.ReferenceEquals(m_slope, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_slope = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<short> UOffset
        {
            get
            {
                return m_uOffset;
            }

            set
            {
                if (!Object.ReferenceEquals(m_uOffset, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_uOffset = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<string> DetectorType
        {
            get
            {
                return m_detectorType;
            }

            set
            {
                if (!Object.ReferenceEquals(m_detectorType, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_detectorType = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<short> DetectorInputPin
        {
            get
            {
                return m_detectorInputPin;
            }

            set
            {
                if (!Object.ReferenceEquals(m_detectorInputPin, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_detectorInputPin = value;
            }
        }

        /// <remarks />
        public AnalogUnitState<bool> FIREnabled
        {
            get
            {
                return m_fIREnabled;
            }

            set
            {
                if (!Object.ReferenceEquals(m_fIREnabled, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fIREnabled = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_ionReference != null)
            {
                children.Add(m_ionReference);
            }

            if (m_cathode != null)
            {
                children.Add(m_cathode);
            }

            if (m_extraction != null)
            {
                children.Add(m_extraction);
            }

            if (m_focus != null)
            {
                children.Add(m_focus);
            }

            if (m_filamentCurrent != null)
            {
                children.Add(m_filamentCurrent);
            }

            if (m_emissionCurrent != null)
            {
                children.Add(m_emissionCurrent);
            }

            if (m_deflection != null)
            {
                children.Add(m_deflection);
            }

            if (m_prefilter != null)
            {
                children.Add(m_prefilter);
            }

            if (m_sEMVoltage != null)
            {
                children.Add(m_sEMVoltage);
            }

            if (m_uVRatio != null)
            {
                children.Add(m_uVRatio);
            }

            if (m_fieldAxis != null)
            {
                children.Add(m_fieldAxis);
            }

            if (m_selectedFilament != null)
            {
                children.Add(m_selectedFilament);
            }

            if (m_resolution != null)
            {
                children.Add(m_resolution);
            }

            if (m_slope != null)
            {
                children.Add(m_slope);
            }

            if (m_uOffset != null)
            {
                children.Add(m_uOffset);
            }

            if (m_detectorType != null)
            {
                children.Add(m_detectorType);
            }

            if (m_detectorInputPin != null)
            {
                children.Add(m_detectorInputPin);
            }

            if (m_fIREnabled != null)
            {
                children.Add(m_fIREnabled);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case IPI.Opc.Server.GAM.BrowseNames.IonReference:
                {
                    if (createOrReplace)
                    {
                        if (IonReference == null)
                        {
                            if (replacement == null)
                            {
                                IonReference = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                IonReference = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = IonReference;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.Cathode:
                {
                    if (createOrReplace)
                    {
                        if (Cathode == null)
                        {
                            if (replacement == null)
                            {
                                Cathode = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                Cathode = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = Cathode;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.Extraction:
                {
                    if (createOrReplace)
                    {
                        if (Extraction == null)
                        {
                            if (replacement == null)
                            {
                                Extraction = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                Extraction = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = Extraction;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.Focus:
                {
                    if (createOrReplace)
                    {
                        if (Focus == null)
                        {
                            if (replacement == null)
                            {
                                Focus = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                Focus = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = Focus;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.FilamentCurrent:
                {
                    if (createOrReplace)
                    {
                        if (FilamentCurrent == null)
                        {
                            if (replacement == null)
                            {
                                FilamentCurrent = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                FilamentCurrent = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = FilamentCurrent;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.EmissionCurrent:
                {
                    if (createOrReplace)
                    {
                        if (EmissionCurrent == null)
                        {
                            if (replacement == null)
                            {
                                EmissionCurrent = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                EmissionCurrent = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = EmissionCurrent;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.Deflection:
                {
                    if (createOrReplace)
                    {
                        if (Deflection == null)
                        {
                            if (replacement == null)
                            {
                                Deflection = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                Deflection = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = Deflection;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.Prefilter:
                {
                    if (createOrReplace)
                    {
                        if (Prefilter == null)
                        {
                            if (replacement == null)
                            {
                                Prefilter = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                Prefilter = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = Prefilter;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.SEMVoltage:
                {
                    if (createOrReplace)
                    {
                        if (SEMVoltage == null)
                        {
                            if (replacement == null)
                            {
                                SEMVoltage = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                SEMVoltage = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = SEMVoltage;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.UVRatio:
                {
                    if (createOrReplace)
                    {
                        if (UVRatio == null)
                        {
                            if (replacement == null)
                            {
                                UVRatio = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                UVRatio = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = UVRatio;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.FieldAxis:
                {
                    if (createOrReplace)
                    {
                        if (FieldAxis == null)
                        {
                            if (replacement == null)
                            {
                                FieldAxis = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                FieldAxis = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = FieldAxis;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.SelectedFilament:
                {
                    if (createOrReplace)
                    {
                        if (SelectedFilament == null)
                        {
                            if (replacement == null)
                            {
                                SelectedFilament = new AnalogUnitState<short>(this);
                            }
                            else
                            {
                                SelectedFilament = (AnalogUnitState<short>)replacement;
                            }
                        }
                    }

                    instance = SelectedFilament;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.Resolution:
                {
                    if (createOrReplace)
                    {
                        if (Resolution == null)
                        {
                            if (replacement == null)
                            {
                                Resolution = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                Resolution = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = Resolution;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.Slope:
                {
                    if (createOrReplace)
                    {
                        if (Slope == null)
                        {
                            if (replacement == null)
                            {
                                Slope = new AnalogUnitState<double>(this);
                            }
                            else
                            {
                                Slope = (AnalogUnitState<double>)replacement;
                            }
                        }
                    }

                    instance = Slope;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.UOffset:
                {
                    if (createOrReplace)
                    {
                        if (UOffset == null)
                        {
                            if (replacement == null)
                            {
                                UOffset = new AnalogUnitState<short>(this);
                            }
                            else
                            {
                                UOffset = (AnalogUnitState<short>)replacement;
                            }
                        }
                    }

                    instance = UOffset;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.DetectorType:
                {
                    if (createOrReplace)
                    {
                        if (DetectorType == null)
                        {
                            if (replacement == null)
                            {
                                DetectorType = new AnalogUnitState<string>(this);
                            }
                            else
                            {
                                DetectorType = (AnalogUnitState<string>)replacement;
                            }
                        }
                    }

                    instance = DetectorType;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.DetectorInputPin:
                {
                    if (createOrReplace)
                    {
                        if (DetectorInputPin == null)
                        {
                            if (replacement == null)
                            {
                                DetectorInputPin = new AnalogUnitState<short>(this);
                            }
                            else
                            {
                                DetectorInputPin = (AnalogUnitState<short>)replacement;
                            }
                        }
                    }

                    instance = DetectorInputPin;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.FIREnabled:
                {
                    if (createOrReplace)
                    {
                        if (FIREnabled == null)
                        {
                            if (replacement == null)
                            {
                                FIREnabled = new AnalogUnitState<bool>(this);
                            }
                            else
                            {
                                FIREnabled = (AnalogUnitState<bool>)replacement;
                            }
                        }
                    }

                    instance = FIREnabled;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogUnitState<double> m_ionReference;
        private AnalogUnitState<double> m_cathode;
        private AnalogUnitState<double> m_extraction;
        private AnalogUnitState<double> m_focus;
        private AnalogUnitState<double> m_filamentCurrent;
        private AnalogUnitState<double> m_emissionCurrent;
        private AnalogUnitState<double> m_deflection;
        private AnalogUnitState<double> m_prefilter;
        private AnalogUnitState<double> m_sEMVoltage;
        private AnalogUnitState<double> m_uVRatio;
        private AnalogUnitState<double> m_fieldAxis;
        private AnalogUnitState<short> m_selectedFilament;
        private AnalogUnitState<double> m_resolution;
        private AnalogUnitState<double> m_slope;
        private AnalogUnitState<short> m_uOffset;
        private AnalogUnitState<string> m_detectorType;
        private AnalogUnitState<short> m_detectorInputPin;
        private AnalogUnitState<bool> m_fIREnabled;
        #endregion
    }
    #endif
    #endregion

    #region GAMDeviceState Class
    #if (!OPCUA_EXCLUDE_GAMDeviceState)
    /// <summary>
    /// Stores an instance of the GAMDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GAMDeviceState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GAMDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(IPI.Opc.Server.GAM.ObjectTypes.GAMDeviceType, IPI.Opc.Server.GAM.Namespaces.GAM, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkvHQAAAGh0dHA6Ly9pbi1wcm9jZXNz" +
           "LmNvbS9VQS9HQU0v/////4RggAIBAAAAAgAVAAAAR0FNRGV2aWNlVHlwZUluc3RhbmNlAQIcAAECHAAc" +
           "AAAAAf////8LAAAANWCJCgIAAAABAAwAAABNYW51ZmFjdHVyZXIBAm0AAwAAAAAwAAAATmFtZSBvZiB0" +
           "aGUgY29tcGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARG0AAAAAFf////8BAf////8A" +
           "AAAANWCJCgIAAAABAAUAAABNb2RlbAECbwADAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UA" +
           "LgBEbwAAAAAV/////wEB/////wAAAAA1YIkKAgAAAAEAEAAAAEhhcmR3YXJlUmV2aXNpb24BAnAAAwAA" +
           "AAAsAAAAUmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEcAAAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAEAEAAAAFNvZnR3YXJlUmV2aXNpb24BAnEAAwAAAAA1AAAAUmV2" +
           "aXNpb24gbGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEcQAAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAEADgAAAERldmljZVJldmlzaW9uAQJyAAMAAAAAJAAAAE92ZXJh" +
           "bGwgcmV2aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAERyAAAAAAz/////AQH/////AAAAADVgiQoC" +
           "AAAAAQAMAAAARGV2aWNlTWFudWFsAQJ0AAMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBm" +
           "aWxlIHN5c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRl" +
           "dmljZQAuAER0AAAAAAz/////AQH/////AAAAADVgiQoCAAAAAQAMAAAAU2VyaWFsTnVtYmVyAQJ2AAMA" +
           "AAAATQAAAElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFj" +
           "dHVyZXIsIGEgZGV2aWNlIGluc3RhbmNlAC4ARHYAAAAADP////8BAf////8AAAAANWCJCgIAAAABAA8A" +
           "AABSZXZpc2lvbkNvdW50ZXIBAngAAwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0" +
           "aW5nIHRoZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhh" +
           "cyBiZWVuIG1vZGlmaWVkAC4ARHgAAAAABv////8BAf////8AAAAAhGCACgEAAAACAAgAAABXYXRjaGRv" +
           "ZwECHQAALwECDwAdAAAAAQIAAAAAMAABAh4AADAAAQIkAAIAAAAVYIkKAgAAAAIABwAAAFRyaWdnZXIB" +
           "Ah4AAC8BAEAJHgAAAAAB/////wEBAQAAAAAwAQECHQABAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQIi" +
           "AAAuAEQiAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAACAAcAAABDb3VudGVyAQIkAAAvAQBACSQA" +
           "AAAABP////8BAQEAAAAAMAEBAh0AAQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQECKAAALgBEKAAAAAEA" +
           "dAP/////AQH/////AAAAAIRggAoBAAAAAgAMAAAAU3lzdGVtU3RhdHVzAQI/AAAvAQI5AD8AAAAB////" +
           "/wUAAAAVYIkKAgAAAAIADQAAAEF1dG9tYXRpY01vZGUBAkAAAC4AREAAAAAAAf////8BAf////8AAAAA" +
           "FWCJCgIAAAACAAUAAABHQU1PSwECQQAALgBEQQAAAAAB/////wEB/////wAAAAAVYIkKAgAAAAIAGwAA" +
           "AEdBTXRlbXBlcmF0dXJlT3ZlcjM1RGVncmVlQwECQgAALgBEQgAAAAAB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAIACgAAAE1hbnVhbE1vZGUBAkMAAC4AREMAAAAAAf////8BAf////8AAAAAFWCJCgIAAAACABAA" +
           "AABTeXN0ZW1TdGF0dXNUZXh0AQJEAAAuAEREAAAAABX/////AQH/////AAAAAIRggAoBAAAAAgAWAAAA" +
           "UmVhZGJhY2tUdW5lUGFyYW1ldGVycwECxgAALwECSwDGAAAAAf////8SAAAAFWCJCgIAAAACAAwAAABJ" +
           "b25SZWZlcmVuY2UBAscAAC8BAFlExwAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2lu" +
           "ZWVyaW5nVW5pdHMBAswAAC4ARMwAAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAIABwAAAENhdGhv" +
           "ZGUBAjQBAC8BAFlENAEAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5p" +
           "dHMBAjkBAC4ARDkBAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAIACgAAAEV4dHJhY3Rpb24BAjoB" +
           "AC8BAFlEOgEAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAj8B" +
           "AC4ARD8BAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAIABQAAAEZvY3VzAQJAAQAvAQBZREABAAAA" +
           "C/////8BAf////8BAAAAFWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQJFAQAuAERFAQAAAQB3" +
           "A/////8BAf////8AAAAAFWCJCgIAAAACAA8AAABGaWxhbWVudEN1cnJlbnQBAkYBAC8BAFlERgEAAAAL" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAksBAC4AREsBAAABAHcD" +
           "/////wEB/////wAAAAAVYIkKAgAAAAIADwAAAEVtaXNzaW9uQ3VycmVudAECTAEALwEAWURMAQAAAAv/" +
           "////AQH/////AQAAABVgiQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwECUQEALgBEUQEAAAEAdwP/" +
           "////AQH/////AAAAABVgiQoCAAAAAgAKAAAARGVmbGVjdGlvbgECUgEALwEAWURSAQAAAAv/////AQH/" +
           "////AQAAABVgiQoCAAAAAAAQAAAARW5naW5lZXJpbmdVbml0cwECVwEALgBEVwEAAAEAdwP/////AQH/" +
           "////AAAAABVgiQoCAAAAAgAJAAAAUHJlZmlsdGVyAQJYAQAvAQBZRFgBAAAAC/////8BAf////8BAAAA" +
           "FWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQJdAQAuAERdAQAAAQB3A/////8BAf////8AAAAA" +
           "FWCJCgIAAAACAAoAAABTRU1Wb2x0YWdlAQKaAQAvAQBZRJoBAAAAC/////8BAf////8BAAAAFWCJCgIA" +
           "AAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQKfAQAuAESfAQAAAQB3A/////8BAf////8AAAAAFWCJCgIA" +
           "AAACAAcAAABVVlJhdGlvAQJkAQAvAQBZRGQBAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAABAAAABF" +
           "bmdpbmVlcmluZ1VuaXRzAQJpAQAuAERpAQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAACAAkAAABG" +
           "aWVsZEF4aXMBAmoBAC8BAFlEagEAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVy" +
           "aW5nVW5pdHMBAm8BAC4ARG8BAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAIAEAAAAFNlbGVjdGVk" +
           "RmlsYW1lbnQBAnABAC8BAFlEcAEAAAAE/////wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVy" +
           "aW5nVW5pdHMBAnUBAC4ARHUBAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAIACgAAAFJlc29sdXRp" +
           "b24BAnYBAC8BAFlEdgEAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5p" +
           "dHMBAnsBAC4ARHsBAAABAHcD/////wEB/////wAAAAAVYIkKAgAAAAIABQAAAFNsb3BlAQJ8AQAvAQBZ" +
           "RHwBAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQKBAQAuAESB" +
           "AQAAAQB3A/////8BAf////8AAAAAFWCJCgIAAAACAAcAAABVT2Zmc2V0AQKCAQAvAQBZRIIBAAAABP//" +
           "//8BAf////8BAAAAFWCJCgIAAAAAABAAAABFbmdpbmVlcmluZ1VuaXRzAQKHAQAuAESHAQAAAQB3A///" +
           "//8BAf////8AAAAAFWCJCgIAAAACAAwAAABEZXRlY3RvclR5cGUBAogBAC8BAFlEiAEAAAAM/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAo0BAC4ARI0BAAABAHcD/////wEB" +
           "/////wAAAAAVYIkKAgAAAAIAEAAAAERldGVjdG9ySW5wdXRQaW4BAo4BAC8BAFlEjgEAAAAE/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBApMBAC4ARJMBAAABAHcD/////wEB" +
           "/////wAAAAAVYIkKAgAAAAIACgAAAEZJUkVuYWJsZWQBAqYBAC8BAFlEpgEAAAAB/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAqsBAC4ARKsBAAABAHcD/////wEB/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public WatchdogState Watchdog
        {
            get
            {
                return m_watchdog;
            }

            set
            {
                if (!Object.ReferenceEquals(m_watchdog, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_watchdog = value;
            }
        }

        /// <remarks />
        public GAMSystemStatusState SystemStatus
        {
            get
            {
                return m_systemStatus;
            }

            set
            {
                if (!Object.ReferenceEquals(m_systemStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_systemStatus = value;
            }
        }

        /// <remarks />
        public ReadbackTuneParametersState ReadbackTuneParameters
        {
            get
            {
                return m_readbackTuneParameters;
            }

            set
            {
                if (!Object.ReferenceEquals(m_readbackTuneParameters, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_readbackTuneParameters = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_watchdog != null)
            {
                children.Add(m_watchdog);
            }

            if (m_systemStatus != null)
            {
                children.Add(m_systemStatus);
            }

            if (m_readbackTuneParameters != null)
            {
                children.Add(m_readbackTuneParameters);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case IPI.Opc.Server.GAM.BrowseNames.Watchdog:
                {
                    if (createOrReplace)
                    {
                        if (Watchdog == null)
                        {
                            if (replacement == null)
                            {
                                Watchdog = new WatchdogState(this);
                            }
                            else
                            {
                                Watchdog = (WatchdogState)replacement;
                            }
                        }
                    }

                    instance = Watchdog;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.SystemStatus:
                {
                    if (createOrReplace)
                    {
                        if (SystemStatus == null)
                        {
                            if (replacement == null)
                            {
                                SystemStatus = new GAMSystemStatusState(this);
                            }
                            else
                            {
                                SystemStatus = (GAMSystemStatusState)replacement;
                            }
                        }
                    }

                    instance = SystemStatus;
                    break;
                }

                case IPI.Opc.Server.GAM.BrowseNames.ReadbackTuneParameters:
                {
                    if (createOrReplace)
                    {
                        if (ReadbackTuneParameters == null)
                        {
                            if (replacement == null)
                            {
                                ReadbackTuneParameters = new ReadbackTuneParametersState(this);
                            }
                            else
                            {
                                ReadbackTuneParameters = (ReadbackTuneParametersState)replacement;
                            }
                        }
                    }

                    instance = ReadbackTuneParameters;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private WatchdogState m_watchdog;
        private GAMSystemStatusState m_systemStatus;
        private ReadbackTuneParametersState m_readbackTuneParameters;
        #endregion
    }
    #endif
    #endregion
}