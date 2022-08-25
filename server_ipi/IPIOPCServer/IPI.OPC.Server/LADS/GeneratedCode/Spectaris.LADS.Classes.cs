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

namespace Spectaris.LADS
{
    #region FunctionState Class
    #if (!OPCUA_EXCLUDE_FunctionState)
    /// <summary>
    /// Stores an instance of the FunctionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FunctionState : TopologyElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FunctionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.FunctionType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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

            if (Enabled != null)
            {
                Enabled.Initialize(context, Enabled_InitializationString);
            }

            if (Configuration != null)
            {
                Configuration.Initialize(context, Configuration_InitializationString);
            }

            if (FunctionSet != null)
            {
                FunctionSet.Initialize(context, FunctionSet_InitializationString);
            }

            if (ParameterSet != null)
            {
                ParameterSet.Initialize(context, ParameterSet_InitializationString);
            }
        }

        #region Initialization String
        private const string Enabled_InitializationString =
           "<Enabled xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=26</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Enabled</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>26</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Enabled>";

        private const string Configuration_InitializationString =
           "<Configuration xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=23</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Configuration</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>23</uax:NumericId>" +
           "</Configuration>";

        private const string FunctionSet_InitializationString =
           "<FunctionSet xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=25</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>FunctionSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=27</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>25</uax:NumericId>" +
           "</FunctionSet>";

        private const string ParameterSet_InitializationString =
           "<ParameterSet xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=2</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ParameterSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Flat list of Parameters</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=58</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>2</uax:NumericId>" +
           "</ParameterSet>";

        private const string InitializationString =
           "<FunctionTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>FunctionTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=1</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1</uax:NumericId>" +
           "<ParameterSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=2</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ParameterSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Flat list of Parameters</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=58</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>2</uax:NumericId>" +
           "</ParameterSet>" +
           "<Enabled>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=26</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Enabled</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>26</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Enabled>" +
           "<Configuration>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=23</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Configuration</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>23</uax:NumericId>" +
           "</Configuration>" +
           "<FunctionSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=25</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>FunctionSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=27</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>25</uax:NumericId>" +
           "</FunctionSet>" +
           "</FunctionTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<bool> Enabled
        {
            get
            {
                return m_enabled;
            }

            set
            {
                if (!Object.ReferenceEquals(m_enabled, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_enabled = value;
            }
        }

        /// <remarks />
        public FunctionalGroupState Configuration
        {
            get
            {
                return m_configuration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_configuration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_configuration = value;
            }
        }

        /// <remarks />
        public FunctionSetState FunctionSet
        {
            get
            {
                return m_functionSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_functionSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_functionSet = value;
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
            if (m_enabled != null)
            {
                children.Add(m_enabled);
            }

            if (m_configuration != null)
            {
                children.Add(m_configuration);
            }

            if (m_functionSet != null)
            {
                children.Add(m_functionSet);
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
                case Spectaris.LADS.BrowseNames.Enabled:
                {
                    if (createOrReplace)
                    {
                        if (Enabled == null)
                        {
                            if (replacement == null)
                            {
                                Enabled = new PropertyState<bool>(this);
                            }
                            else
                            {
                                Enabled = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = Enabled;
                    break;
                }

                case Spectaris.LADS.BrowseNames.Configuration:
                {
                    if (createOrReplace)
                    {
                        if (Configuration == null)
                        {
                            if (replacement == null)
                            {
                                Configuration = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Configuration = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Configuration;
                    break;
                }

                case Spectaris.LADS.BrowseNames.FunctionSet:
                {
                    if (createOrReplace)
                    {
                        if (FunctionSet == null)
                        {
                            if (replacement == null)
                            {
                                FunctionSet = new FunctionSetState(this);
                            }
                            else
                            {
                                FunctionSet = (FunctionSetState)replacement;
                            }
                        }
                    }

                    instance = FunctionSet;
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
        private PropertyState<bool> m_enabled;
        private FunctionalGroupState m_configuration;
        private FunctionSetState m_functionSet;
        #endregion
    }
    #endif
    #endregion

    #region BaseSensorFunctionOperationalState Class
    #if (!OPCUA_EXCLUDE_BaseSensorFunctionOperationalState)
    /// <summary>
    /// Stores an instance of the BaseSensorFunctionOperationalType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BaseSensorFunctionOperationalState : FunctionalGroupState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public BaseSensorFunctionOperationalState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.BaseSensorFunctionOperationalType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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

            if (RawValue != null)
            {
                RawValue.Initialize(context, RawValue_InitializationString);
            }

            if (SensorValue != null)
            {
                SensorValue.Initialize(context, SensorValue_InitializationString);
            }
        }

        #region Initialization String
        private const string RawValue_InitializationString =
           "<RawValue xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1080</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1080</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1084</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1084</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1085</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EngineeringUnits</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1085</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</RawValue>";

        private const string SensorValue_InitializationString =
           "<SensorValue xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1086</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1086</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1090</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1090</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1091</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EngineeringUnits</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1091</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>";

        private const string InitializationString =
           "<BaseSensorFunctionOperationalTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1076</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>BaseSensorFunctionOperationalTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=1076</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1076</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1080</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1080</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1084</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1084</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1085</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EngineeringUnits</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1085</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</RawValue>" +
           "<SensorValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1086</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1086</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1090</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1090</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1091</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EngineeringUnits</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1091</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</BaseSensorFunctionOperationalTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogUnitRangeState RawValue
        {
            get
            {
                return m_rawValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rawValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rawValue = value;
            }
        }

        /// <remarks />
        public AnalogUnitRangeState SensorValue
        {
            get
            {
                return m_sensorValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_sensorValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_sensorValue = value;
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
            if (m_rawValue != null)
            {
                children.Add(m_rawValue);
            }

            if (m_sensorValue != null)
            {
                children.Add(m_sensorValue);
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
                case Spectaris.LADS.BrowseNames.RawValue:
                {
                    if (createOrReplace)
                    {
                        if (RawValue == null)
                        {
                            if (replacement == null)
                            {
                                RawValue = new AnalogUnitRangeState(this);
                            }
                            else
                            {
                                RawValue = (AnalogUnitRangeState)replacement;
                            }
                        }
                    }

                    instance = RawValue;
                    break;
                }

                case Spectaris.LADS.BrowseNames.SensorValue:
                {
                    if (createOrReplace)
                    {
                        if (SensorValue == null)
                        {
                            if (replacement == null)
                            {
                                SensorValue = new AnalogUnitRangeState(this);
                            }
                            else
                            {
                                SensorValue = (AnalogUnitRangeState)replacement;
                            }
                        }
                    }

                    instance = SensorValue;
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
        private AnalogUnitRangeState m_rawValue;
        private AnalogUnitRangeState m_sensorValue;
        #endregion
    }
    #endif
    #endregion

    #region BaseSensorFunctionParameterSetState Class
    #if (!OPCUA_EXCLUDE_BaseSensorFunctionParameterSetState)
    /// <summary>
    /// Stores an instance of the BaseSensorFunctionParameterSetType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BaseSensorFunctionParameterSetState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public BaseSensorFunctionParameterSetState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.BaseSensorFunctionParameterSetType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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

            if (CalibrationValues != null)
            {
                CalibrationValues.Initialize(context, CalibrationValues_InitializationString);
            }

            if (CompensationValue != null)
            {
                CompensationValue.Initialize(context, CompensationValue_InitializationString);
            }

            if (Damping != null)
            {
                Damping.Initialize(context, Damping_InitializationString);
            }
        }

        #region Initialization String
        private const string CalibrationValues_InitializationString =
           "<CalibrationValues xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=245</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>CalibrationValues</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=63</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>245</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</CalibrationValues>";

        private const string CompensationValue_InitializationString =
           "<CompensationValue xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=246</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>CompensationValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>246</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=250</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>250</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=251</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EngineeringUnits</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>251</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</CompensationValue>";

        private const string Damping_InitializationString =
           "<Damping xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=252</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Damping</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>252</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Damping>";

        private const string InitializationString =
           "<BaseSensorFunctionParameterSetTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=244</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>BaseSensorFunctionParameterSetTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=244</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>244</uax:NumericId>" +
           "<CalibrationValues>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=245</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>CalibrationValues</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=63</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>245</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</CalibrationValues>" +
           "<CompensationValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=246</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>CompensationValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>246</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=26</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=250</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EURange</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>250</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=251</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EngineeringUnits</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>251</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</CompensationValue>" +
           "<Damping>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=252</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Damping</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>252</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Damping>" +
           "</BaseSensorFunctionParameterSetTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double[]> CalibrationValues
        {
            get
            {
                return m_calibrationValues;
            }

            set
            {
                if (!Object.ReferenceEquals(m_calibrationValues, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_calibrationValues = value;
            }
        }

        /// <remarks />
        public AnalogUnitRangeState CompensationValue
        {
            get
            {
                return m_compensationValue;
            }

            set
            {
                if (!Object.ReferenceEquals(m_compensationValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_compensationValue = value;
            }
        }

        /// <remarks />
        public PropertyState<double> Damping
        {
            get
            {
                return m_damping;
            }

            set
            {
                if (!Object.ReferenceEquals(m_damping, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_damping = value;
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
            if (m_calibrationValues != null)
            {
                children.Add(m_calibrationValues);
            }

            if (m_compensationValue != null)
            {
                children.Add(m_compensationValue);
            }

            if (m_damping != null)
            {
                children.Add(m_damping);
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
                case Spectaris.LADS.BrowseNames.CalibrationValues:
                {
                    if (createOrReplace)
                    {
                        if (CalibrationValues == null)
                        {
                            if (replacement == null)
                            {
                                CalibrationValues = new BaseDataVariableState<double[]>(this);
                            }
                            else
                            {
                                CalibrationValues = (BaseDataVariableState<double[]>)replacement;
                            }
                        }
                    }

                    instance = CalibrationValues;
                    break;
                }

                case Spectaris.LADS.BrowseNames.CompensationValue:
                {
                    if (createOrReplace)
                    {
                        if (CompensationValue == null)
                        {
                            if (replacement == null)
                            {
                                CompensationValue = new AnalogUnitRangeState(this);
                            }
                            else
                            {
                                CompensationValue = (AnalogUnitRangeState)replacement;
                            }
                        }
                    }

                    instance = CompensationValue;
                    break;
                }

                case Spectaris.LADS.BrowseNames.Damping:
                {
                    if (createOrReplace)
                    {
                        if (Damping == null)
                        {
                            if (replacement == null)
                            {
                                Damping = new PropertyState<double>(this);
                            }
                            else
                            {
                                Damping = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = Damping;
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
        private BaseDataVariableState<double[]> m_calibrationValues;
        private AnalogUnitRangeState m_compensationValue;
        private PropertyState<double> m_damping;
        #endregion
    }
    #endif
    #endregion

    #region BaseSensorFunctionState Class
    #if (!OPCUA_EXCLUDE_BaseSensorFunctionState)
    /// <summary>
    /// Stores an instance of the BaseSensorFunctionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BaseSensorFunctionState : FunctionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public BaseSensorFunctionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.BaseSensorFunctionType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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

            if (AlarmMonitor != null)
            {
                AlarmMonitor.Initialize(context, AlarmMonitor_InitializationString);
            }

            if (Tuning != null)
            {
                Tuning.Initialize(context, Tuning_InitializationString);
            }
        }

        #region Initialization String
        private const string AlarmMonitor_InitializationString =
           "<AlarmMonitor xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=79</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>AlarmMonitor</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9482</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>79</uax:NumericId>" +
           "<EventId xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=80</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EventId</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>80</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=15</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EventId>" +
           "<EventType xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=81</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EventType</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>81</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EventType>" +
           "<SourceNode xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=82</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>SourceNode</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>82</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SourceNode>" +
           "<SourceName xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=83</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>SourceName</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>83</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SourceName>" +
           "<Time xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=84</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Time</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>84</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Time>" +
           "<ReceiveTime xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=85</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>ReceiveTime</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>85</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ReceiveTime>" +
           "<Message xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=87</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Message</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>87</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Message>" +
           "<Severity xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=88</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Severity</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>88</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=5</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Severity>" +
           "<ConditionClassId xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=89</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>ConditionClassId</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>89</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ConditionClassId>" +
           "<ConditionClassName xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=90</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>ConditionClassName</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>90</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ConditionClassName>" +
           "<ConditionName xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=93</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>ConditionName</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>93</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ConditionName>" +
           "<BranchId xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=94</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>BranchId</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>94</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</BranchId>" +
           "<Retain xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=95</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Retain</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>95</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Retain>" +
           "<EnabledState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=96</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EnabledState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=8995</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>96</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=116</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=125</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=138</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=148</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=166</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=97</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>97</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "</EnabledState>" +
           "<Quality xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=105</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Quality</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9002</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>105</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=19</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<SourceTimestamp>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=106</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>SourceTimestamp</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>106</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SourceTimestamp>" +
           "</Quality>" +
           "<LastSeverity xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=107</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>LastSeverity</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9002</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>107</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=5</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<SourceTimestamp>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=108</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>SourceTimestamp</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>108</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SourceTimestamp>" +
           "</LastSeverity>" +
           "<Comment xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=109</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Comment</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9002</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>109</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<SourceTimestamp>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=110</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>SourceTimestamp</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>110</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SourceTimestamp>" +
           "</Comment>" +
           "<ClientUserId xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=111</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>ClientUserId</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>111</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ClientUserId>" +
           "<Disable xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=112</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Disable</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9028</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>112</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=3065</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>i=2803</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "</Disable>" +
           "<Enable xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=113</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Enable</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9027</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>113</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=3065</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>i=2803</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "</Enable>" +
           "<AddComment xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=114</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>AddComment</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9029</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>114</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=3065</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>i=2829</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<InputArguments>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=115</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>InputArguments</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>115</uax:NumericId>" +
           "<uax:Value>" +
           "<uax:Value>" +
           "<uax:ListOfExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>EventId</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=15</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "<uax:Description>" +
           "<uax:Text>The identifier for the event to comment.</uax:Text>" +
           "</uax:Description>" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>Comment</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "<uax:Description>" +
           "<uax:Text>The comment to add to the condition.</uax:Text>" +
           "</uax:Description>" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "</uax:ListOfExtensionObject>" +
           "</uax:Value>" +
           "</uax:Value>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=296</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</InputArguments>" +
           "</AddComment>" +
           "<AckedState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=116</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>AckedState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=8995</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>116</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:IsInverse>true</uax:IsInverse>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=96</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=117</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>117</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "</AckedState>" +
           "<Acknowledge xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=134</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Acknowledge</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9111</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>134</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=3065</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>i=8944</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<InputArguments>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=135</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>InputArguments</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>135</uax:NumericId>" +
           "<uax:Value>" +
           "<uax:Value>" +
           "<uax:ListOfExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>EventId</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=15</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "<uax:Description>" +
           "<uax:Text>The identifier for the event to comment.</uax:Text>" +
           "</uax:Description>" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>Comment</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "<uax:Description>" +
           "<uax:Text>The comment to add to the condition.</uax:Text>" +
           "</uax:Description>" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "</uax:ListOfExtensionObject>" +
           "</uax:Value>" +
           "</uax:Value>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=296</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</InputArguments>" +
           "</Acknowledge>" +
           "<ActiveState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=138</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>ActiveState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=8995</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>138</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:IsInverse>true</uax:IsInverse>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=96</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=230</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=139</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>139</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "</ActiveState>" +
           "<InputNode xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=147</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>InputNode</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>147</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</InputNode>" +
           "<SuppressedOrShelved xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=185</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>SuppressedOrShelved</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>185</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SuppressedOrShelved>" +
           "<LimitState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=230</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>LimitState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9318</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>230</uax:NumericId>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:IsInverse>true</uax:IsInverse>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=138</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<CurrentState>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=231</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>CurrentState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2760</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>231</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=232</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>232</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "</CurrentState>" +
           "</LimitState>" +
           "</AlarmMonitor>";

        private const string Tuning_InitializationString =
           "<Tuning xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=263</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Tuning</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>263</uax:NumericId>" +
           "</Tuning>";

        private const string InitializationString =
           "<BaseSensorFunctionTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=53</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>BaseSensorFunctionTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=53</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>53</uax:NumericId>" +
           "<ParameterSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=54</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ParameterSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Flat list of Parameters</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=244</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>54</uax:NumericId>" +
           "</ParameterSet>" +
           "<AlarmMonitor>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=79</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>AlarmMonitor</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9482</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>79</uax:NumericId>" +
           "<EventId xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=80</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EventId</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>80</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=15</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EventId>" +
           "<EventType xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=81</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EventType</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>81</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EventType>" +
           "<SourceNode xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=82</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>SourceNode</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>82</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SourceNode>" +
           "<SourceName xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=83</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>SourceName</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>83</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SourceName>" +
           "<Time xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=84</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Time</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>84</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Time>" +
           "<ReceiveTime xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=85</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>ReceiveTime</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>85</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ReceiveTime>" +
           "<Message xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=87</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Message</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>87</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Message>" +
           "<Severity xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=88</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Severity</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>88</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=5</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Severity>" +
           "<ConditionClassId xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=89</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>ConditionClassId</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>89</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ConditionClassId>" +
           "<ConditionClassName xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=90</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>ConditionClassName</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>90</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ConditionClassName>" +
           "<ConditionName xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=93</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>ConditionName</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>93</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ConditionName>" +
           "<BranchId xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=94</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>BranchId</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>94</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</BranchId>" +
           "<Retain xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=95</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Retain</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>95</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Retain>" +
           "<EnabledState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=96</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>EnabledState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=8995</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>96</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=116</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=125</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=138</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=148</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=166</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=97</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>97</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "</EnabledState>" +
           "<Quality xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=105</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Quality</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9002</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>105</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=19</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<SourceTimestamp>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=106</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>SourceTimestamp</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>106</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SourceTimestamp>" +
           "</Quality>" +
           "<LastSeverity xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=107</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>LastSeverity</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9002</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>107</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=5</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<SourceTimestamp>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=108</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>SourceTimestamp</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>108</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SourceTimestamp>" +
           "</LastSeverity>" +
           "<Comment xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=109</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Comment</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9002</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>109</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<SourceTimestamp>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=110</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>SourceTimestamp</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>110</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SourceTimestamp>" +
           "</Comment>" +
           "<ClientUserId xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=111</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>ClientUserId</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>111</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ClientUserId>" +
           "<Disable xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=112</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Disable</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9028</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>112</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=3065</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>i=2803</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "</Disable>" +
           "<Enable xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=113</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Enable</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9027</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>113</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=3065</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>i=2803</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "</Enable>" +
           "<AddComment xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=114</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>AddComment</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9029</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>114</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=3065</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>i=2829</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<InputArguments>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=115</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>InputArguments</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>115</uax:NumericId>" +
           "<uax:Value>" +
           "<uax:Value>" +
           "<uax:ListOfExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>EventId</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=15</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "<uax:Description>" +
           "<uax:Text>The identifier for the event to comment.</uax:Text>" +
           "</uax:Description>" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>Comment</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "<uax:Description>" +
           "<uax:Text>The comment to add to the condition.</uax:Text>" +
           "</uax:Description>" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "</uax:ListOfExtensionObject>" +
           "</uax:Value>" +
           "</uax:Value>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=296</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</InputArguments>" +
           "</AddComment>" +
           "<AckedState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=116</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>AckedState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=8995</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>116</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:IsInverse>true</uax:IsInverse>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=96</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=117</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>117</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "</AckedState>" +
           "<Acknowledge xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=134</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Acknowledge</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9111</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>134</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=3065</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>i=8944</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<InputArguments>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=135</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>InputArguments</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>135</uax:NumericId>" +
           "<uax:Value>" +
           "<uax:Value>" +
           "<uax:ListOfExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>EventId</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=15</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "<uax:Description>" +
           "<uax:Text>The identifier for the event to comment.</uax:Text>" +
           "</uax:Description>" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>Comment</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "<uax:Description>" +
           "<uax:Text>The comment to add to the condition.</uax:Text>" +
           "</uax:Description>" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "</uax:ListOfExtensionObject>" +
           "</uax:Value>" +
           "</uax:Value>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=296</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</InputArguments>" +
           "</Acknowledge>" +
           "<ActiveState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=138</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>ActiveState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=8995</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>138</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:IsInverse>true</uax:IsInverse>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=96</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=230</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=139</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>139</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "</ActiveState>" +
           "<InputNode xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=147</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>InputNode</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>147</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</InputNode>" +
           "<SuppressedOrShelved xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=185</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>SuppressedOrShelved</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>185</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SuppressedOrShelved>" +
           "<LimitState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=230</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>LimitState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=9318</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>230</uax:NumericId>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=9004</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:IsInverse>true</uax:IsInverse>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=2;i=138</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<CurrentState>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=231</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>CurrentState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2760</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>231</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=232</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>232</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "</CurrentState>" +
           "</LimitState>" +
           "</AlarmMonitor>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=253</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>253</uax:NumericId>" +
           "</Operational>" +
           "<Tuning>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=263</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Tuning</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>263</uax:NumericId>" +
           "</Tuning>" +
           "</BaseSensorFunctionTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ExclusiveLevelAlarmState AlarmMonitor
        {
            get
            {
                return m_alarmMonitor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_alarmMonitor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_alarmMonitor = value;
            }
        }

        /// <remarks />
        public FunctionalGroupState Operational
        {
            get
            {
                return m_operational;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operational, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operational = value;
            }
        }

        /// <remarks />
        public new BaseSensorFunctionParameterSetState ParameterSet
        {
            get { return (BaseSensorFunctionParameterSetState)base.ParameterSet; }
            set { base.ParameterSet = value; }
        }

        /// <remarks />
        public FunctionalGroupState Tuning
        {
            get
            {
                return m_tuning;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tuning, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tuning = value;
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
            if (m_alarmMonitor != null)
            {
                children.Add(m_alarmMonitor);
            }

            if (m_operational != null)
            {
                children.Add(m_operational);
            }

            if (m_tuning != null)
            {
                children.Add(m_tuning);
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
                case Spectaris.LADS.BrowseNames.AlarmMonitor:
                {
                    if (createOrReplace)
                    {
                        if (AlarmMonitor == null)
                        {
                            if (replacement == null)
                            {
                                AlarmMonitor = new ExclusiveLevelAlarmState(this);
                            }
                            else
                            {
                                AlarmMonitor = (ExclusiveLevelAlarmState)replacement;
                            }
                        }
                    }

                    instance = AlarmMonitor;
                    break;
                }

                case Spectaris.LADS.BrowseNames.Operational:
                {
                    if (createOrReplace)
                    {
                        if (Operational == null)
                        {
                            if (replacement == null)
                            {
                                Operational = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Operational = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Operational;
                    break;
                }

                case Spectaris.LADS.BrowseNames.ParameterSet:
                {
                    if (createOrReplace)
                    {
                        if (ParameterSet == null)
                        {
                            if (replacement == null)
                            {
                                ParameterSet = new BaseSensorFunctionParameterSetState(this);
                            }
                            else
                            {
                                ParameterSet = (BaseSensorFunctionParameterSetState)replacement;
                            }
                        }
                    }

                    instance = ParameterSet;
                    break;
                }

                case Spectaris.LADS.BrowseNames.Tuning:
                {
                    if (createOrReplace)
                    {
                        if (Tuning == null)
                        {
                            if (replacement == null)
                            {
                                Tuning = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Tuning = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Tuning;
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
        private ExclusiveLevelAlarmState m_alarmMonitor;
        private FunctionalGroupState m_operational;
        private FunctionalGroupState m_tuning;
        #endregion
    }
    #endif
    #endregion

    #region AnalogSensorFunctionState Class
    #if (!OPCUA_EXCLUDE_AnalogSensorFunctionState)
    /// <summary>
    /// Stores an instance of the AnalogSensorFunctionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogSensorFunctionState : BaseSensorFunctionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogSensorFunctionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.AnalogSensorFunctionType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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
           "<AnalogSensorFunctionTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=289</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>AnalogSensorFunctionTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=289</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>289</uax:NumericId>" +
           "<ParameterSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=290</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ParameterSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Flat list of Parameters</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=244</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>290</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=480</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>480</uax:NumericId>" +
           "</Operational>" +
           "</AnalogSensorFunctionTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region AnalogSensorFunctionWithCompensationState Class
    #if (!OPCUA_EXCLUDE_AnalogSensorFunctionWithCompensationState)
    /// <summary>
    /// Stores an instance of the AnalogSensorFunctionWithCompensationType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class AnalogSensorFunctionWithCompensationState : BaseSensorFunctionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public AnalogSensorFunctionWithCompensationState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.AnalogSensorFunctionWithCompensationType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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
           "<AnalogSensorFunctionWithCompensationTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=504</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>AnalogSensorFunctionWithCompensationTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=504</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>504</uax:NumericId>" +
           "<ParameterSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=505</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ParameterSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Flat list of Parameters</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=244</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>505</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=695</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>695</uax:NumericId>" +
           "</Operational>" +
           "</AnalogSensorFunctionWithCompensationTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region FunctionSetState Class
    #if (!OPCUA_EXCLUDE_FunctionSetState)
    /// <summary>
    /// Stores an instance of the FunctionSetType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FunctionSetState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FunctionSetState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.FunctionSetType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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
           "<FunctionSetTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=27</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>FunctionSetTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=27</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>27</uax:NumericId>" +
           "</FunctionSetTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region SupportedPropertySetState Class
    #if (!OPCUA_EXCLUDE_SupportedPropertySetState)
    /// <summary>
    /// Stores an instance of the SupportedPropertySetType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class SupportedPropertySetState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public SupportedPropertySetState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.SupportedPropertySetType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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
           "<SupportedPropertySetTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=719</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>SupportedPropertySetTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=719</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>719</uax:NumericId>" +
           "</SupportedPropertySetTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region FunctionalUnitState Class
    #if (!OPCUA_EXCLUDE_FunctionalUnitState)
    /// <summary>
    /// Stores an instance of the FunctionalUnitType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FunctionalUnitState : TopologyElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FunctionalUnitState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.FunctionalUnitType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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

            if (MethodSet != null)
            {
                MethodSet.Initialize(context, MethodSet_InitializationString);
            }

            if (ProgramManager != null)
            {
                ProgramManager.Initialize(context, ProgramManager_InitializationString);
            }

            if (SupportedPropertySet != null)
            {
                SupportedPropertySet.Initialize(context, SupportedPropertySet_InitializationString);
            }
        }

        #region Initialization String
        private const string MethodSet_InitializationString =
           "<MethodSet xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=31</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>MethodSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Flat list of Methods</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=58</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>31</uax:NumericId>" +
           "</MethodSet>";

        private const string ProgramManager_InitializationString =
           "<ProgramManager xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=724</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ProgramManager</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=792</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>724</uax:NumericId>" +
           "<ActiveProgram>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=744</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ActiveProgram</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=765</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>744</uax:NumericId>" +
           "<CurrentState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=745</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>CurrentState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2760</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>745</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=746</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>746</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "<Number>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=748</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Number</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>748</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Number>" +
           "</CurrentState>" +
           "<LastTransition xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=750</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>LastTransition</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2767</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>750</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=751</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>751</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "<Number>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=753</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Number</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>753</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Number>" +
           "<TransitionTime>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=754</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>TransitionTime</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>754</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</TransitionTime>" +
           "</LastTransition>" +
           "<Deletable xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=990</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Deletable</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>990</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Deletable>" +
           "<AutoDelete xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=991</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>AutoDelete</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>991</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</AutoDelete>" +
           "<RecycleCount xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=992</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>RecycleCount</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>992</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=6</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</RecycleCount>" +
           "</ActiveProgram>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=758</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>758</uax:NumericId>" +
           "</Operational>" +
           "<ProgramTemplateSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=760</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ProgramTemplateSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=788</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>760</uax:NumericId>" +
           "<NodeVersion>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=761</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>NodeVersion</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>761</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</NodeVersion>" +
           "</ProgramTemplateSet>" +
           "<ResultSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=762</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ResultSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=790</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>762</uax:NumericId>" +
           "<NodeVersion>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=763</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>NodeVersion</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>763</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</NodeVersion>" +
           "</ResultSet>" +
           "</ProgramManager>";

        private const string SupportedPropertySet_InitializationString =
           "<SupportedPropertySet xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=764</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>SupportedPropertySet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=719</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>764</uax:NumericId>" +
           "</SupportedPropertySet>";

        private const string InitializationString =
           "<FunctionalUnitTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=28</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>FunctionalUnitTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=28</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>28</uax:NumericId>" +
           "<MethodSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=31</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>MethodSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Flat list of Methods</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=58</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>31</uax:NumericId>" +
           "</MethodSet>" +
           "<Identification>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=34</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Identification</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Used to organize parameters for identification of this TopologyElement</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>34</uax:NumericId>" +
           "</Identification>" +
           "<Lock>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=36</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Lock</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Used to lock the topology element.</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1123</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>36</uax:NumericId>" +
           "<Locked xmlns=\"http://opcfoundation.org/UA/DI/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=37</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>Locked</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>37</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Locked>" +
           "<LockingClient xmlns=\"http://opcfoundation.org/UA/DI/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=38</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>LockingClient</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>38</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</LockingClient>" +
           "<LockingUser xmlns=\"http://opcfoundation.org/UA/DI/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=39</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>LockingUser</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>39</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</LockingUser>" +
           "<RemainingLockTime xmlns=\"http://opcfoundation.org/UA/DI/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=40</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>RemainingLockTime</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>40</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=290</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</RemainingLockTime>" +
           "<InitLock xmlns=\"http://opcfoundation.org/UA/DI/\">" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=41</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>InitLock</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1129</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>41</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<InputArguments xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=42</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>InputArguments</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>42</uax:NumericId>" +
           "<uax:Value>" +
           "<uax:Value>" +
           "<uax:ListOfExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>Context</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "</uax:ListOfExtensionObject>" +
           "</uax:Value>" +
           "</uax:Value>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=296</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</InputArguments>" +
           "<OutputArguments xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=43</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>OutputArguments</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>43</uax:NumericId>" +
           "<uax:Value>" +
           "<uax:Value>" +
           "<uax:ListOfExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>InitLockStatus</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=6</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "</uax:ListOfExtensionObject>" +
           "</uax:Value>" +
           "</uax:Value>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=296</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</OutputArguments>" +
           "</InitLock>" +
           "<RenewLock xmlns=\"http://opcfoundation.org/UA/DI/\">" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=44</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>RenewLock</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1132</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>44</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<OutputArguments xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=45</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>OutputArguments</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>45</uax:NumericId>" +
           "<uax:Value>" +
           "<uax:Value>" +
           "<uax:ListOfExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>RenewLockStatus</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=6</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "</uax:ListOfExtensionObject>" +
           "</uax:Value>" +
           "</uax:Value>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=296</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</OutputArguments>" +
           "</RenewLock>" +
           "<ExitLock xmlns=\"http://opcfoundation.org/UA/DI/\">" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=46</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>ExitLock</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1134</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>46</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<OutputArguments xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=47</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>OutputArguments</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>47</uax:NumericId>" +
           "<uax:Value>" +
           "<uax:Value>" +
           "<uax:ListOfExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>ExitLockStatus</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=6</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "</uax:ListOfExtensionObject>" +
           "</uax:Value>" +
           "</uax:Value>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=296</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</OutputArguments>" +
           "</ExitLock>" +
           "<BreakLock xmlns=\"http://opcfoundation.org/UA/DI/\">" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=48</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>1</uax:NamespaceIndex>" +
           "<uax:Name>BreakLock</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1136</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>48</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<OutputArguments xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=49</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>OutputArguments</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>49</uax:NumericId>" +
           "<uax:Value>" +
           "<uax:Value>" +
           "<uax:ListOfExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>BreakLockStatus</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=6</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "</uax:ListOfExtensionObject>" +
           "</uax:Value>" +
           "</uax:Value>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=296</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>0</uax:ArrayDimensions>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</OutputArguments>" +
           "</BreakLock>" +
           "</Lock>" +
           "<ComponentName>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=50</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ComponentName</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>50</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ComponentName>" +
           "<FunctionSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=721</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>FunctionSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=27</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>721</uax:NumericId>" +
           "</FunctionSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=722</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>722</uax:NumericId>" +
           "</Operational>" +
           "<ProgramManager>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=724</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ProgramManager</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=792</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>724</uax:NumericId>" +
           "<ActiveProgram>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=744</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ActiveProgram</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=765</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>744</uax:NumericId>" +
           "<CurrentState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=745</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>CurrentState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2760</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>745</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=746</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>746</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "<Number>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=748</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Number</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>748</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Number>" +
           "</CurrentState>" +
           "<LastTransition xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=750</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>LastTransition</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2767</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>750</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=751</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>751</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "<Number>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=753</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Number</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>753</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Number>" +
           "<TransitionTime>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=754</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>TransitionTime</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>754</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</TransitionTime>" +
           "</LastTransition>" +
           "<Deletable xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=990</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Deletable</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>990</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Deletable>" +
           "<AutoDelete xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=991</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>AutoDelete</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>991</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</AutoDelete>" +
           "<RecycleCount xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=992</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>RecycleCount</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>992</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=6</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</RecycleCount>" +
           "</ActiveProgram>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=758</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>758</uax:NumericId>" +
           "</Operational>" +
           "<ProgramTemplateSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=760</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ProgramTemplateSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=788</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>760</uax:NumericId>" +
           "<NodeVersion>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=761</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>NodeVersion</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>761</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</NodeVersion>" +
           "</ProgramTemplateSet>" +
           "<ResultSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=762</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ResultSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=790</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>762</uax:NumericId>" +
           "<NodeVersion>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=763</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>NodeVersion</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>763</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</NodeVersion>" +
           "</ResultSet>" +
           "</ProgramManager>" +
           "<SupportedPropertySet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=764</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>SupportedPropertySet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=719</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>764</uax:NumericId>" +
           "</SupportedPropertySet>" +
           "</FunctionalUnitTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<LocalizedText> ComponentName
        {
            get
            {
                return m_componentName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_componentName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_componentName = value;
            }
        }

        /// <remarks />
        public FunctionSetState FunctionSet
        {
            get
            {
                return m_functionSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_functionSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_functionSet = value;
            }
        }

        /// <remarks />
        public FunctionalGroupState Operational
        {
            get
            {
                return m_operational;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operational, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operational = value;
            }
        }

        /// <remarks />
        public ProgramManagerState ProgramManager
        {
            get
            {
                return m_programManager;
            }

            set
            {
                if (!Object.ReferenceEquals(m_programManager, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_programManager = value;
            }
        }

        /// <remarks />
        public SupportedPropertySetState SupportedPropertySet
        {
            get
            {
                return m_supportedPropertySet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_supportedPropertySet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supportedPropertySet = value;
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
            if (m_componentName != null)
            {
                children.Add(m_componentName);
            }

            if (m_functionSet != null)
            {
                children.Add(m_functionSet);
            }

            if (m_operational != null)
            {
                children.Add(m_operational);
            }

            if (m_programManager != null)
            {
                children.Add(m_programManager);
            }

            if (m_supportedPropertySet != null)
            {
                children.Add(m_supportedPropertySet);
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
                case Spectaris.LADS.BrowseNames.ComponentName:
                {
                    if (createOrReplace)
                    {
                        if (ComponentName == null)
                        {
                            if (replacement == null)
                            {
                                ComponentName = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                ComponentName = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = ComponentName;
                    break;
                }

                case Spectaris.LADS.BrowseNames.FunctionSet:
                {
                    if (createOrReplace)
                    {
                        if (FunctionSet == null)
                        {
                            if (replacement == null)
                            {
                                FunctionSet = new FunctionSetState(this);
                            }
                            else
                            {
                                FunctionSet = (FunctionSetState)replacement;
                            }
                        }
                    }

                    instance = FunctionSet;
                    break;
                }

                case Spectaris.LADS.BrowseNames.Operational:
                {
                    if (createOrReplace)
                    {
                        if (Operational == null)
                        {
                            if (replacement == null)
                            {
                                Operational = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Operational = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Operational;
                    break;
                }

                case Spectaris.LADS.BrowseNames.ProgramManager:
                {
                    if (createOrReplace)
                    {
                        if (ProgramManager == null)
                        {
                            if (replacement == null)
                            {
                                ProgramManager = new ProgramManagerState(this);
                            }
                            else
                            {
                                ProgramManager = (ProgramManagerState)replacement;
                            }
                        }
                    }

                    instance = ProgramManager;
                    break;
                }

                case Spectaris.LADS.BrowseNames.SupportedPropertySet:
                {
                    if (createOrReplace)
                    {
                        if (SupportedPropertySet == null)
                        {
                            if (replacement == null)
                            {
                                SupportedPropertySet = new SupportedPropertySetState(this);
                            }
                            else
                            {
                                SupportedPropertySet = (SupportedPropertySetState)replacement;
                            }
                        }
                    }

                    instance = SupportedPropertySet;
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
        private PropertyState<LocalizedText> m_componentName;
        private FunctionSetState m_functionSet;
        private FunctionalGroupState m_operational;
        private ProgramManagerState m_programManager;
        private SupportedPropertySetState m_supportedPropertySet;
        #endregion
    }
    #endif
    #endregion

    #region FunctionalUnitSetState Class
    #if (!OPCUA_EXCLUDE_FunctionalUnitSetState)
    /// <summary>
    /// Stores an instance of the FunctionalUnitSetType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FunctionalUnitSetState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FunctionalUnitSetState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.FunctionalUnitSetType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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
           "<FunctionalUnitSetTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=51</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>FunctionalUnitSetTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=51</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>51</uax:NumericId>" +
           "</FunctionalUnitSetTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LADSBaseStateMachineState Class
    #if (!OPCUA_EXCLUDE_LADSBaseStateMachineState)
    /// <summary>
    /// Stores an instance of the LADSBaseStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LADSBaseStateMachineState : ProgramStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LADSBaseStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.LADSBaseStateMachineType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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
           "<LADSBaseStateMachineTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=765</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>LADSBaseStateMachineTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=765</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>765</uax:NumericId>" +
           "<CurrentState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=766</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>CurrentState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2760</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>766</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=767</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>767</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "<Number>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=769</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Number</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>769</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Number>" +
           "</CurrentState>" +
           "<LastTransition xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=771</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>LastTransition</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2767</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>771</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=772</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>772</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "<Number>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=774</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Number</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>774</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Number>" +
           "<TransitionTime>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=775</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>TransitionTime</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>775</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</TransitionTime>" +
           "</LastTransition>" +
           "<Deletable xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1008</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Deletable</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1008</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Deletable>" +
           "<AutoDelete xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1009</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>AutoDelete</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1009</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</AutoDelete>" +
           "<RecycleCount xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1010</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>RecycleCount</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1010</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=6</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</RecycleCount>" +
           "</LADSBaseStateMachineTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ProgramTemplateState Class
    #if (!OPCUA_EXCLUDE_ProgramTemplateState)
    /// <summary>
    /// Stores an instance of the ProgramTemplateType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramTemplateState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProgramTemplateState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.ProgramTemplateType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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
           "<ProgramTemplateTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=779</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ProgramTemplateTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=779</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>779</uax:NumericId>" +
           "<Name>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=780</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Name</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>780</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Name>" +
           "<TemplateID>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=782</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>TemplateID</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>782</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</TemplateID>" +
           "<Author>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=783</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Author</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>783</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Author>" +
           "<Created>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=784</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Created</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>784</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=13</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Created>" +
           "<Modified>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=785</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Modified</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>785</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=13</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Modified>" +
           "<Version>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=786</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Version</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>786</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Version>" +
           "<Status>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=787</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Status</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>787</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Status>" +
           "</ProgramTemplateTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> Name
        {
            get
            {
                return m_name;
            }

            set
            {
                if (!Object.ReferenceEquals(m_name, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_name = value;
            }
        }

        /// <remarks />
        public PropertyState<string> TemplateID
        {
            get
            {
                return m_templateID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_templateID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_templateID = value;
            }
        }

        /// <remarks />
        public PropertyState<LocalizedText> Author
        {
            get
            {
                return m_author;
            }

            set
            {
                if (!Object.ReferenceEquals(m_author, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_author = value;
            }
        }

        /// <remarks />
        public PropertyState<DateTime> Created
        {
            get
            {
                return m_created;
            }

            set
            {
                if (!Object.ReferenceEquals(m_created, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_created = value;
            }
        }

        /// <remarks />
        public PropertyState<DateTime> Modified
        {
            get
            {
                return m_modified;
            }

            set
            {
                if (!Object.ReferenceEquals(m_modified, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_modified = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Version
        {
            get
            {
                return m_version;
            }

            set
            {
                if (!Object.ReferenceEquals(m_version, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_version = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Status
        {
            get
            {
                return m_status;
            }

            set
            {
                if (!Object.ReferenceEquals(m_status, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_status = value;
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
            if (m_name != null)
            {
                children.Add(m_name);
            }

            if (m_templateID != null)
            {
                children.Add(m_templateID);
            }

            if (m_author != null)
            {
                children.Add(m_author);
            }

            if (m_created != null)
            {
                children.Add(m_created);
            }

            if (m_modified != null)
            {
                children.Add(m_modified);
            }

            if (m_version != null)
            {
                children.Add(m_version);
            }

            if (m_status != null)
            {
                children.Add(m_status);
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
                case Spectaris.LADS.BrowseNames.Name:
                {
                    if (createOrReplace)
                    {
                        if (Name == null)
                        {
                            if (replacement == null)
                            {
                                Name = new PropertyState<string>(this);
                            }
                            else
                            {
                                Name = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Name;
                    break;
                }

                case Spectaris.LADS.BrowseNames.TemplateID:
                {
                    if (createOrReplace)
                    {
                        if (TemplateID == null)
                        {
                            if (replacement == null)
                            {
                                TemplateID = new PropertyState<string>(this);
                            }
                            else
                            {
                                TemplateID = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = TemplateID;
                    break;
                }

                case Spectaris.LADS.BrowseNames.Author:
                {
                    if (createOrReplace)
                    {
                        if (Author == null)
                        {
                            if (replacement == null)
                            {
                                Author = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Author = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Author;
                    break;
                }

                case Spectaris.LADS.BrowseNames.Created:
                {
                    if (createOrReplace)
                    {
                        if (Created == null)
                        {
                            if (replacement == null)
                            {
                                Created = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                Created = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = Created;
                    break;
                }

                case Spectaris.LADS.BrowseNames.Modified:
                {
                    if (createOrReplace)
                    {
                        if (Modified == null)
                        {
                            if (replacement == null)
                            {
                                Modified = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                Modified = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = Modified;
                    break;
                }

                case Spectaris.LADS.BrowseNames.Version:
                {
                    if (createOrReplace)
                    {
                        if (Version == null)
                        {
                            if (replacement == null)
                            {
                                Version = new PropertyState<string>(this);
                            }
                            else
                            {
                                Version = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Version;
                    break;
                }

                case Spectaris.LADS.BrowseNames.Status:
                {
                    if (createOrReplace)
                    {
                        if (Status == null)
                        {
                            if (replacement == null)
                            {
                                Status = new PropertyState<string>(this);
                            }
                            else
                            {
                                Status = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Status;
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
        private PropertyState<string> m_name;
        private PropertyState<string> m_templateID;
        private PropertyState<LocalizedText> m_author;
        private PropertyState<DateTime> m_created;
        private PropertyState<DateTime> m_modified;
        private PropertyState<string> m_version;
        private PropertyState<string> m_status;
        #endregion
    }
    #endif
    #endregion

    #region ProgramTemplateSetState Class
    #if (!OPCUA_EXCLUDE_ProgramTemplateSetState)
    /// <summary>
    /// Stores an instance of the ProgramTemplateSetType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramTemplateSetState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProgramTemplateSetState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.ProgramTemplateSetType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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
           "<ProgramTemplateSetTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=788</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ProgramTemplateSetTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=788</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>788</uax:NumericId>" +
           "<NodeVersion>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=789</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>NodeVersion</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>789</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</NodeVersion>" +
           "</ProgramTemplateSetTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<uint> NodeVersion
        {
            get
            {
                return m_nodeVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nodeVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nodeVersion = value;
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
            if (m_nodeVersion != null)
            {
                children.Add(m_nodeVersion);
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
                case Spectaris.LADS.BrowseNames.NodeVersion:
                {
                    if (createOrReplace)
                    {
                        if (NodeVersion == null)
                        {
                            if (replacement == null)
                            {
                                NodeVersion = new PropertyState<uint>(this);
                            }
                            else
                            {
                                NodeVersion = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = NodeVersion;
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
        private PropertyState<uint> m_nodeVersion;
        #endregion
    }
    #endif
    #endregion

    #region ResultSetState Class
    #if (!OPCUA_EXCLUDE_ResultSetState)
    /// <summary>
    /// Stores an instance of the ResultSetType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ResultSetState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ResultSetState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.ResultSetType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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
           "<ResultSetTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=790</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ResultSetTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=790</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>790</uax:NumericId>" +
           "<NodeVersion>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=791</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>NodeVersion</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>791</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</NodeVersion>" +
           "</ResultSetTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<uint> NodeVersion
        {
            get
            {
                return m_nodeVersion;
            }

            set
            {
                if (!Object.ReferenceEquals(m_nodeVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_nodeVersion = value;
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
            if (m_nodeVersion != null)
            {
                children.Add(m_nodeVersion);
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
                case Spectaris.LADS.BrowseNames.NodeVersion:
                {
                    if (createOrReplace)
                    {
                        if (NodeVersion == null)
                        {
                            if (replacement == null)
                            {
                                NodeVersion = new PropertyState<uint>(this);
                            }
                            else
                            {
                                NodeVersion = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = NodeVersion;
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
        private PropertyState<uint> m_nodeVersion;
        #endregion
    }
    #endif
    #endregion

    #region ProgramManagerState Class
    #if (!OPCUA_EXCLUDE_ProgramManagerState)
    /// <summary>
    /// Stores an instance of the ProgramManagerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProgramManagerState : TopologyElementState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProgramManagerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.ProgramManagerType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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
           "<ProgramManagerTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=792</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ProgramManagerTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=792</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>792</uax:NumericId>" +
           "<ActiveProgram>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=814</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ActiveProgram</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=765</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>814</uax:NumericId>" +
           "<CurrentState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=815</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>CurrentState</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2760</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>815</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=816</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>816</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "<Number>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=818</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Number</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>818</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Number>" +
           "</CurrentState>" +
           "<LastTransition xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=820</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>LastTransition</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2767</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>820</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=821</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Id</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>821</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=17</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Id>" +
           "<Number>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=823</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Number</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>823</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Number>" +
           "<TransitionTime>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=824</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>TransitionTime</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>824</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=294</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</TransitionTime>" +
           "</LastTransition>" +
           "<Deletable xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1059</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>Deletable</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1059</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Deletable>" +
           "<AutoDelete xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1060</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>AutoDelete</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1060</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</AutoDelete>" +
           "<RecycleCount xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=1061</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>0</uax:NamespaceIndex>" +
           "<uax:Name>RecycleCount</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1061</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=6</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</RecycleCount>" +
           "</ActiveProgram>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=828</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>828</uax:NumericId>" +
           "</Operational>" +
           "<ProgramTemplateSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=830</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ProgramTemplateSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=788</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>830</uax:NumericId>" +
           "<NodeVersion>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=831</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>NodeVersion</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>831</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</NodeVersion>" +
           "</ProgramTemplateSet>" +
           "<ResultSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=832</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ResultSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=790</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>832</uax:NumericId>" +
           "<NodeVersion>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=833</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>NodeVersion</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>833</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=7</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</NodeVersion>" +
           "</ResultSet>" +
           "</ProgramManagerTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LADSBaseStateMachineState ActiveProgram
        {
            get
            {
                return m_activeProgram;
            }

            set
            {
                if (!Object.ReferenceEquals(m_activeProgram, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_activeProgram = value;
            }
        }

        /// <remarks />
        public FunctionalGroupState Operational
        {
            get
            {
                return m_operational;
            }

            set
            {
                if (!Object.ReferenceEquals(m_operational, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operational = value;
            }
        }

        /// <remarks />
        public ProgramTemplateSetState ProgramTemplateSet
        {
            get
            {
                return m_programTemplateSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_programTemplateSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_programTemplateSet = value;
            }
        }

        /// <remarks />
        public ResultSetState ResultSet
        {
            get
            {
                return m_resultSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_resultSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resultSet = value;
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
            if (m_activeProgram != null)
            {
                children.Add(m_activeProgram);
            }

            if (m_operational != null)
            {
                children.Add(m_operational);
            }

            if (m_programTemplateSet != null)
            {
                children.Add(m_programTemplateSet);
            }

            if (m_resultSet != null)
            {
                children.Add(m_resultSet);
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
                case Spectaris.LADS.BrowseNames.ActiveProgram:
                {
                    if (createOrReplace)
                    {
                        if (ActiveProgram == null)
                        {
                            if (replacement == null)
                            {
                                ActiveProgram = new LADSBaseStateMachineState(this);
                            }
                            else
                            {
                                ActiveProgram = (LADSBaseStateMachineState)replacement;
                            }
                        }
                    }

                    instance = ActiveProgram;
                    break;
                }

                case Spectaris.LADS.BrowseNames.Operational:
                {
                    if (createOrReplace)
                    {
                        if (Operational == null)
                        {
                            if (replacement == null)
                            {
                                Operational = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Operational = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Operational;
                    break;
                }

                case Spectaris.LADS.BrowseNames.ProgramTemplateSet:
                {
                    if (createOrReplace)
                    {
                        if (ProgramTemplateSet == null)
                        {
                            if (replacement == null)
                            {
                                ProgramTemplateSet = new ProgramTemplateSetState(this);
                            }
                            else
                            {
                                ProgramTemplateSet = (ProgramTemplateSetState)replacement;
                            }
                        }
                    }

                    instance = ProgramTemplateSet;
                    break;
                }

                case Spectaris.LADS.BrowseNames.ResultSet:
                {
                    if (createOrReplace)
                    {
                        if (ResultSet == null)
                        {
                            if (replacement == null)
                            {
                                ResultSet = new ResultSetState(this);
                            }
                            else
                            {
                                ResultSet = (ResultSetState)replacement;
                            }
                        }
                    }

                    instance = ResultSet;
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
        private LADSBaseStateMachineState m_activeProgram;
        private FunctionalGroupState m_operational;
        private ProgramTemplateSetState m_programTemplateSet;
        private ResultSetState m_resultSet;
        #endregion
    }
    #endif
    #endregion

    #region LADSComponentState Class
    #if (!OPCUA_EXCLUDE_LADSComponentState)
    /// <summary>
    /// Stores an instance of the LADSComponentType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LADSComponentState : ComponentState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LADSComponentState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.LADSComponentType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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

            if (ComponentSet != null)
            {
                ComponentSet.Initialize(context, ComponentSet_InitializationString);
            }

            if (Maintenance != null)
            {
                Maintenance.Initialize(context, Maintenance_InitializationString);
            }

            if (DeviceHealth != null)
            {
                DeviceHealth.Initialize(context, DeviceHealth_InitializationString);
            }
        }

        #region Initialization String
        private const string ComponentSet_InitializationString =
           "<ComponentSet xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=942</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ComponentSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=943</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>942</uax:NumericId>" +
           "</ComponentSet>";

        private const string Maintenance_InitializationString =
           "<Maintenance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=945</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Maintenance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>945</uax:NumericId>" +
           "</Maintenance>";

        private const string DeviceHealth_InitializationString =
           "<DeviceHealth xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=947</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>DeviceHealth</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=63</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>947</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>ns=1;i=1013</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</DeviceHealth>";

        private const string InitializationString =
           "<LADSComponentTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=906</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>LADSComponentTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=906</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>906</uax:NumericId>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=17603</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=1;i=81</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<ComponentSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=942</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ComponentSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=943</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>942</uax:NumericId>" +
           "</ComponentSet>" +
           "<Maintenance>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=945</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>Maintenance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=1;i=1008</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>945</uax:NumericId>" +
           "</Maintenance>" +
           "<DeviceHealth>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=947</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>DeviceHealth</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=63</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>947</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>ns=1;i=1013</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</DeviceHealth>" +
           "</LADSComponentTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ComponentSetState ComponentSet
        {
            get
            {
                return m_componentSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_componentSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_componentSet = value;
            }
        }

        /// <remarks />
        public FunctionalGroupState Maintenance
        {
            get
            {
                return m_maintenance;
            }

            set
            {
                if (!Object.ReferenceEquals(m_maintenance, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_maintenance = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<DeviceHealthEnumeration> DeviceHealth
        {
            get
            {
                return m_deviceHealth;
            }

            set
            {
                if (!Object.ReferenceEquals(m_deviceHealth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceHealth = value;
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
            if (m_componentSet != null)
            {
                children.Add(m_componentSet);
            }

            if (m_maintenance != null)
            {
                children.Add(m_maintenance);
            }

            if (m_deviceHealth != null)
            {
                children.Add(m_deviceHealth);
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
                case Spectaris.LADS.BrowseNames.ComponentSet:
                {
                    if (createOrReplace)
                    {
                        if (ComponentSet == null)
                        {
                            if (replacement == null)
                            {
                                ComponentSet = new ComponentSetState(this);
                            }
                            else
                            {
                                ComponentSet = (ComponentSetState)replacement;
                            }
                        }
                    }

                    instance = ComponentSet;
                    break;
                }

                case Spectaris.LADS.BrowseNames.Maintenance:
                {
                    if (createOrReplace)
                    {
                        if (Maintenance == null)
                        {
                            if (replacement == null)
                            {
                                Maintenance = new FunctionalGroupState(this);
                            }
                            else
                            {
                                Maintenance = (FunctionalGroupState)replacement;
                            }
                        }
                    }

                    instance = Maintenance;
                    break;
                }

                case Spectaris.LADS.BrowseNames.DeviceHealth:
                {
                    if (createOrReplace)
                    {
                        if (DeviceHealth == null)
                        {
                            if (replacement == null)
                            {
                                DeviceHealth = new BaseDataVariableState<DeviceHealthEnumeration>(this);
                            }
                            else
                            {
                                DeviceHealth = (BaseDataVariableState<DeviceHealthEnumeration>)replacement;
                            }
                        }
                    }

                    instance = DeviceHealth;
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
        private ComponentSetState m_componentSet;
        private FunctionalGroupState m_maintenance;
        private BaseDataVariableState<DeviceHealthEnumeration> m_deviceHealth;
        #endregion
    }
    #endif
    #endregion

    #region ComponentSetState Class
    #if (!OPCUA_EXCLUDE_ComponentSetState)
    /// <summary>
    /// Stores an instance of the ComponentSetType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ComponentSetState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ComponentSetState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.ComponentSetType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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
           "<ComponentSetTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=943</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ComponentSetTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=943</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>943</uax:NumericId>" +
           "</ComponentSetTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LADSDeviceState Class
    #if (!OPCUA_EXCLUDE_LADSDeviceState)
    /// <summary>
    /// Stores an instance of the LADSDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LADSDeviceState : LADSComponentState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LADSDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Spectaris.LADS.ObjectTypes.LADSDeviceType, Spectaris.LADS.Namespaces.LADS, namespaceUris);
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
           "<LADSDeviceTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=949</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>LADSDeviceTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=949</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>949</uax:NumericId>" +
           "<ComponentSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=985</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>ComponentSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=943</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>985</uax:NumericId>" +
           "</ComponentSet>" +
           "<FunctionalUnitSet>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=2;i=986</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>2</uax:NamespaceIndex>" +
           "<uax:Name>FunctionalUnitSet</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=2;i=51</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>986</uax:NumericId>" +
           "</FunctionalUnitSet>" +
           "</LADSDeviceTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public FunctionalUnitSetState FunctionalUnitSet
        {
            get
            {
                return m_functionalUnitSet;
            }

            set
            {
                if (!Object.ReferenceEquals(m_functionalUnitSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_functionalUnitSet = value;
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
            if (m_functionalUnitSet != null)
            {
                children.Add(m_functionalUnitSet);
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
                case Spectaris.LADS.BrowseNames.FunctionalUnitSet:
                {
                    if (createOrReplace)
                    {
                        if (FunctionalUnitSet == null)
                        {
                            if (replacement == null)
                            {
                                FunctionalUnitSet = new FunctionalUnitSetState(this);
                            }
                            else
                            {
                                FunctionalUnitSet = (FunctionalUnitSetState)replacement;
                            }
                        }
                    }

                    instance = FunctionalUnitSet;
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
        private FunctionalUnitSetState m_functionalUnitSet;
        #endregion
    }
    #endif
    #endregion
}