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
using Spectaris.LADS;

namespace IPI.OpcUaServer.GAM
{
    #region StartMethodState Class
    #if (!OPCUA_EXCLUDE_StartMethodState)
    /// <summary>
    /// Stores an instance of the StartMethodType Method.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class StartMethodState : MethodState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public StartMethodState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Constructs an instance of a node.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <returns>The new node.</returns>
        public new static NodeState Construct(NodeState parent)
        {
            return new StartMethodState(parent);
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
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "<StartMethodType xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://in-process.com/UA/GAM/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://in-process.com/UA/GAM/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5409</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>StartMethodType</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Causes the Program to transition from the Ready state to the Running state.</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5409</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5409</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<InputArguments xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5410</uax:Identifier>" +
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
           "<uax:NumericId>5410</uax:NumericId>" +
           "<uax:Value>" +
           "<uax:Value>" +
           "<uax:ListOfExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>TemplateID</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>JobID</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>SampleIDs</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>" +
           "<uax:UInt32>0</uax:UInt32>" +
           "</uax:ArrayDimensions>" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>Properties</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=14533</uax:Identifier>" +
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
           "<uax:Identifier>ns=3;i=5411</uax:Identifier>" +
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
           "<uax:NumericId>5411</uax:NumericId>" +
           "<uax:Value>" +
           "<uax:Value>" +
           "<uax:ListOfExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>ResultID</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=22</uax:Identifier>" +
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
           "</StartMethodType>";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        /// <summary>
        /// Raised when the the method is called.
        /// </summary>
        public StartMethodStateMethodCallHandler OnCall;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Invokes the method, returns the result and output argument.
        /// </summary>
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult result = null;

            string templateID = (string)_inputArguments[0];
            string jobID = (string)_inputArguments[1];
            string[] sampleIDs = (string[])_inputArguments[2];
            KeyValuePair properties = (KeyValuePair)ExtensionObject.ToEncodeable((ExtensionObject)_inputArguments[3]);

            ExtensionObject resultID = (ExtensionObject)_outputArguments[0];

            if (OnCall != null)
            {
                result = OnCall(
                    _context,
                    this,
                    _objectId,
                    templateID,
                    jobID,
                    sampleIDs,
                    properties,
                    ref resultID);
            }

            _outputArguments[0] = resultID;

            return result;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    /// <summary>
    /// Used to receive notifications when the method is called.
    /// </summary>
    /// <exclude />
    public delegate ServiceResult StartMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string templateID,
        string jobID,
        string[] sampleIDs,
        KeyValuePair properties,
        ref ExtensionObject resultID);
    #endif
    #endregion

    #region GAMStateMachineState Class
    #if (!OPCUA_EXCLUDE_GAMStateMachineState)
    /// <summary>
    /// Stores an instance of the GAMStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GAMStateMachineState : LADSBaseStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GAMStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(IPI.OpcUaServer.GAM.ObjectTypes.GAMStateMachineType, IPI.OpcUaServer.GAM.Namespaces.GAM, namespaceUris);
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
           "<GAMStateMachineTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://in-process.com/UA/GAM/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://in-process.com/UA/GAM/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=562</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>GAMStateMachineTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=562</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>562</uax:NumericId>" +
           "<CurrentState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=563</uax:Identifier>" +
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
           "<uax:NumericId>563</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=564</uax:Identifier>" +
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
           "<uax:NumericId>564</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=566</uax:Identifier>" +
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
           "<uax:NumericId>566</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=568</uax:Identifier>" +
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
           "<uax:NumericId>568</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=569</uax:Identifier>" +
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
           "<uax:NumericId>569</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=571</uax:Identifier>" +
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
           "<uax:NumericId>571</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=572</uax:Identifier>" +
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
           "<uax:NumericId>572</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=577</uax:Identifier>" +
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
           "<uax:NumericId>577</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=578</uax:Identifier>" +
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
           "<uax:NumericId>578</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=579</uax:Identifier>" +
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
           "<uax:NumericId>579</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=6</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</RecycleCount>" +
           "<Start>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=623</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Start</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Causes the Program to transition from the Ready state to the Running state.</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2426</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>623</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=53</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:IsInverse>true</uax:IsInverse>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=3;i=607</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "</Start>" +
           "<Stop>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=628</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Stop</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Causes the Program to transition from the Running to the Ready state.</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=628</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>628</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</Stop>" +
           "</GAMStateMachineTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MethodState Start
        {
            get
            {
                return m_startMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startMethod = value;
            }
        }

        /// <remarks />
        public MethodState Stop
        {
            get
            {
                return m_stopMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopMethod = value;
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
            if (m_startMethod != null)
            {
                children.Add(m_startMethod);
            }

            if (m_stopMethod != null)
            {
                children.Add(m_stopMethod);
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
                case IPI.OpcUaServer.GAM.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new MethodState(this);
                            }
                            else
                            {
                                Start = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Start;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.Stop:
                {
                    if (createOrReplace)
                    {
                        if (Stop == null)
                        {
                            if (replacement == null)
                            {
                                Stop = new MethodState(this);
                            }
                            else
                            {
                                Stop = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Stop;
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
        private MethodState m_startMethod;
        private MethodState m_stopMethod;
        #endregion
    }
    #endif
    #endregion

    #region GAMMeasureStateMachineState Class
    #if (!OPCUA_EXCLUDE_GAMMeasureStateMachineState)
    /// <summary>
    /// Stores an instance of the GAMMeasureStateMachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GAMMeasureStateMachineState : GAMStateMachineState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GAMMeasureStateMachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(IPI.OpcUaServer.GAM.ObjectTypes.GAMMeasureStateMachineType, IPI.OpcUaServer.GAM.Namespaces.GAM, namespaceUris);
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
           "<GAMMeasureStateMachineTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://in-process.com/UA/GAM/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://in-process.com/UA/GAM/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5412</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>GAMMeasureStateMachineTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5412</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5412</uax:NumericId>" +
           "<CurrentState xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5413</uax:Identifier>" +
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
           "<uax:NumericId>5413</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5414</uax:Identifier>" +
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
           "<uax:NumericId>5414</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5416</uax:Identifier>" +
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
           "<uax:NumericId>5416</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5418</uax:Identifier>" +
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
           "<uax:NumericId>5418</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<Id>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5419</uax:Identifier>" +
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
           "<uax:NumericId>5419</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5421</uax:Identifier>" +
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
           "<uax:NumericId>5421</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5422</uax:Identifier>" +
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
           "<uax:NumericId>5422</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5427</uax:Identifier>" +
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
           "<uax:NumericId>5427</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5428</uax:Identifier>" +
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
           "<uax:NumericId>5428</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5429</uax:Identifier>" +
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
           "<uax:NumericId>5429</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=6</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</RecycleCount>" +
           "<Start>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5473</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Start</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Causes the Program to transition from the Ready state to the Running state.</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2426</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5473</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=53</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:IsInverse>true</uax:IsInverse>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=3;i=5457</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<InputArguments xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5479</uax:Identifier>" +
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
           "<uax:NumericId>5479</uax:NumericId>" +
           "<uax:Value>" +
           "<uax:Value>" +
           "<uax:ListOfExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>TemplateID</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>JobID</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:ArrayDimensions />" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>SampleIDs</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>1</uax:ValueRank>" +
           "<uax:ArrayDimensions>" +
           "<uax:UInt32>0</uax:UInt32>" +
           "</uax:ArrayDimensions>" +
           "</uax:Argument>" +
           "</uax:Body>" +
           "</uax:ExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>Properties</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=14533</uax:Identifier>" +
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
           "<uax:Identifier>ns=3;i=5480</uax:Identifier>" +
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
           "<uax:NumericId>5480</uax:NumericId>" +
           "<uax:Value>" +
           "<uax:Value>" +
           "<uax:ListOfExtensionObject>" +
           "<uax:ExtensionObject>" +
           "<uax:TypeId>" +
           "<uax:Identifier>i=297</uax:Identifier>" +
           "</uax:TypeId>" +
           "<uax:Body>" +
           "<uax:Argument>" +
           "<uax:Name>ResultID</uax:Name>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=22</uax:Identifier>" +
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
           "</Start>" +
           "<Stop>" +
           "<uax:NodeClass>Method_4</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5478</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Stop</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:Description>" +
           "<uax:Text>Causes the Program to transition from the Running to the Ready state.</uax:Text>" +
           "</uax:Description>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=628</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5478</uax:NumericId>" +
           "<uax:Executable>true</uax:Executable>" +
           "<uax:UserExecutable>true</uax:UserExecutable>" +
           "</Stop>" +
           "</GAMMeasureStateMachineTypeInstance>";
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

    #region DoubleAnalogSensorFunctionOperationalState Class
    #if (!OPCUA_EXCLUDE_DoubleAnalogSensorFunctionOperationalState)
    /// <summary>
    /// Stores an instance of the DoubleAnalogSensorFunctionOperationalType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DoubleAnalogSensorFunctionOperationalState : BaseSensorFunctionOperationalState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DoubleAnalogSensorFunctionOperationalState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(IPI.OpcUaServer.GAM.ObjectTypes.DoubleAnalogSensorFunctionOperationalType, IPI.OpcUaServer.GAM.Namespaces.GAM, namespaceUris);
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
           "<DoubleAnalogSensorFunctionOperationalTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://in-process.com/UA/GAM/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://in-process.com/UA/GAM/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>DoubleAnalogSensorFunctionOperationalTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5110</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5114</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5114</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5118</uax:Identifier>" +
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
           "<uax:NumericId>5118</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5119</uax:Identifier>" +
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
           "<uax:NumericId>5119</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5120</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5120</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5124</uax:Identifier>" +
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
           "<uax:NumericId>5124</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5125</uax:Identifier>" +
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
           "<uax:NumericId>5125</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</DoubleAnalogSensorFunctionOperationalTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new AnalogUnitRangeState<double> RawValue
        {
            get { return (AnalogUnitRangeState<double>)base.RawValue; }
            set { base.RawValue = value; }
        }

        /// <remarks />
        public new AnalogUnitRangeState<double> SensorValue
        {
            get { return (AnalogUnitRangeState<double>)base.SensorValue; }
            set { base.SensorValue = value; }
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
                case IPI.OpcUaServer.GAM.BrowseNames.RawValue:
                {
                    if (createOrReplace)
                    {
                        if (RawValue == null)
                        {
                            if (replacement == null)
                            {
                                RawValue = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                RawValue = (AnalogUnitRangeState<double>)replacement;
                            }
                        }
                    }

                    instance = RawValue;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.SensorValue:
                {
                    if (createOrReplace)
                    {
                        if (SensorValue == null)
                        {
                            if (replacement == null)
                            {
                                SensorValue = new AnalogUnitRangeState<double>(this);
                            }
                            else
                            {
                                SensorValue = (AnalogUnitRangeState<double>)replacement;
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
        #endregion
    }
    #endif
    #endregion

    #region DoubleAnalogSensorFunctionState Class
    #if (!OPCUA_EXCLUDE_DoubleAnalogSensorFunctionState)
    /// <summary>
    /// Stores an instance of the DoubleAnalogSensorFunctionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class DoubleAnalogSensorFunctionState : AnalogSensorFunctionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public DoubleAnalogSensorFunctionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(IPI.OpcUaServer.GAM.ObjectTypes.DoubleAnalogSensorFunctionType, IPI.OpcUaServer.GAM.Namespaces.GAM, namespaceUris);
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
           "<DoubleAnalogSensorFunctionTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://in-process.com/UA/GAM/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://in-process.com/UA/GAM/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>DoubleAnalogSensorFunctionTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5126</uax:NumericId>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5127</uax:Identifier>" +
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
           "<uax:NumericId>5127</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5317</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5317</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5329</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5329</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5333</uax:Identifier>" +
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
           "<uax:NumericId>5333</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5334</uax:Identifier>" +
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
           "<uax:NumericId>5334</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5335</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5335</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5339</uax:Identifier>" +
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
           "<uax:NumericId>5339</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5340</uax:Identifier>" +
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
           "<uax:NumericId>5340</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</DoubleAnalogSensorFunctionTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public new DoubleAnalogSensorFunctionOperationalState Operational
        {
            get { return (DoubleAnalogSensorFunctionOperationalState)base.Operational; }
            set { base.Operational = value; }
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
                case IPI.OpcUaServer.GAM.BrowseNames.Operational:
                {
                    if (createOrReplace)
                    {
                        if (Operational == null)
                        {
                            if (replacement == null)
                            {
                                Operational = new DoubleAnalogSensorFunctionOperationalState(this);
                            }
                            else
                            {
                                Operational = (DoubleAnalogSensorFunctionOperationalState)replacement;
                            }
                        }
                    }

                    instance = Operational;
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
        #endregion
    }
    #endif
    #endregion

    #region TuneParametersFunctionSetState Class
    #if (!OPCUA_EXCLUDE_TuneParametersFunctionSetState)
    /// <summary>
    /// Stores an instance of the TuneParametersFunctionSetType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TuneParametersFunctionSetState : FunctionSetState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TuneParametersFunctionSetState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(IPI.OpcUaServer.GAM.ObjectTypes.TuneParametersFunctionSetType, IPI.OpcUaServer.GAM.Namespaces.GAM, namespaceUris);
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
           "<TuneParametersFunctionSetTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://in-process.com/UA/GAM/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://in-process.com/UA/GAM/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1029</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>TuneParametersFunctionSetTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=1029</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1029</uax:NumericId>" +
           "<IonReference>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1030</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>IonReference</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1030</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1031</uax:Identifier>" +
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
           "<uax:NumericId>1031</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1219</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1219</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4864</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4864</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4868</uax:Identifier>" +
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
           "<uax:NumericId>4868</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4869</uax:Identifier>" +
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
           "<uax:NumericId>4869</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4870</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4870</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4874</uax:Identifier>" +
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
           "<uax:NumericId>4874</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4875</uax:Identifier>" +
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
           "<uax:NumericId>4875</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</IonReference>" +
           "<Cathode>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1243</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Cathode</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1243</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1244</uax:Identifier>" +
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
           "<uax:NumericId>1244</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1432</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1432</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4876</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4876</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4880</uax:Identifier>" +
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
           "<uax:NumericId>4880</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4881</uax:Identifier>" +
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
           "<uax:NumericId>4881</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4882</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4882</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4886</uax:Identifier>" +
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
           "<uax:NumericId>4886</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4887</uax:Identifier>" +
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
           "<uax:NumericId>4887</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</Cathode>" +
           "<Extraction>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1456</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Extraction</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1456</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1457</uax:Identifier>" +
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
           "<uax:NumericId>1457</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1645</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1645</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4888</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4888</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4892</uax:Identifier>" +
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
           "<uax:NumericId>4892</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4893</uax:Identifier>" +
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
           "<uax:NumericId>4893</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4894</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4894</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4898</uax:Identifier>" +
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
           "<uax:NumericId>4898</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4899</uax:Identifier>" +
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
           "<uax:NumericId>4899</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</Extraction>" +
           "<Focus>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1669</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Focus</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1669</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1670</uax:Identifier>" +
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
           "<uax:NumericId>1670</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1858</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1858</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4900</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4900</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4904</uax:Identifier>" +
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
           "<uax:NumericId>4904</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4905</uax:Identifier>" +
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
           "<uax:NumericId>4905</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4906</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4906</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4910</uax:Identifier>" +
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
           "<uax:NumericId>4910</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4911</uax:Identifier>" +
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
           "<uax:NumericId>4911</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</Focus>" +
           "<FilamentCurrent>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1882</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>FilamentCurrent</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>1882</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1883</uax:Identifier>" +
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
           "<uax:NumericId>1883</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2071</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>2071</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4912</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4912</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4916</uax:Identifier>" +
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
           "<uax:NumericId>4916</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4917</uax:Identifier>" +
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
           "<uax:NumericId>4917</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4918</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4918</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4922</uax:Identifier>" +
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
           "<uax:NumericId>4922</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4923</uax:Identifier>" +
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
           "<uax:NumericId>4923</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</FilamentCurrent>" +
           "<EmissionCurrent>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2095</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>EmissionCurrent</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>2095</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2096</uax:Identifier>" +
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
           "<uax:NumericId>2096</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2284</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>2284</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4924</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4924</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4928</uax:Identifier>" +
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
           "<uax:NumericId>4928</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4929</uax:Identifier>" +
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
           "<uax:NumericId>4929</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4930</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4930</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4934</uax:Identifier>" +
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
           "<uax:NumericId>4934</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4935</uax:Identifier>" +
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
           "<uax:NumericId>4935</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</EmissionCurrent>" +
           "<Deflection>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2308</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Deflection</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>2308</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2309</uax:Identifier>" +
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
           "<uax:NumericId>2309</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2497</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>2497</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4936</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4936</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4940</uax:Identifier>" +
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
           "<uax:NumericId>4940</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4941</uax:Identifier>" +
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
           "<uax:NumericId>4941</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4942</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4942</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4946</uax:Identifier>" +
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
           "<uax:NumericId>4946</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4947</uax:Identifier>" +
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
           "<uax:NumericId>4947</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</Deflection>" +
           "<Prefilter>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2521</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Prefilter</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>2521</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2522</uax:Identifier>" +
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
           "<uax:NumericId>2522</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2710</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>2710</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4948</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4948</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4952</uax:Identifier>" +
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
           "<uax:NumericId>4952</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4953</uax:Identifier>" +
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
           "<uax:NumericId>4953</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4954</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4954</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4958</uax:Identifier>" +
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
           "<uax:NumericId>4958</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4959</uax:Identifier>" +
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
           "<uax:NumericId>4959</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</Prefilter>" +
           "<SEMVoltage>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2734</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SEMVoltage</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>2734</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2735</uax:Identifier>" +
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
           "<uax:NumericId>2735</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2923</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>2923</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4960</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4960</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4964</uax:Identifier>" +
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
           "<uax:NumericId>4964</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4965</uax:Identifier>" +
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
           "<uax:NumericId>4965</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4966</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4966</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4970</uax:Identifier>" +
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
           "<uax:NumericId>4970</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4971</uax:Identifier>" +
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
           "<uax:NumericId>4971</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</SEMVoltage>" +
           "<UVRatio>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2947</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>UVRatio</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>2947</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=2948</uax:Identifier>" +
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
           "<uax:NumericId>2948</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=3136</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>3136</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4972</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4972</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4976</uax:Identifier>" +
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
           "<uax:NumericId>4976</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4977</uax:Identifier>" +
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
           "<uax:NumericId>4977</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4978</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4978</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4982</uax:Identifier>" +
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
           "<uax:NumericId>4982</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4983</uax:Identifier>" +
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
           "<uax:NumericId>4983</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</UVRatio>" +
           "<FieldAxis>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=3160</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>FieldAxis</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>3160</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=3161</uax:Identifier>" +
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
           "<uax:NumericId>3161</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=3349</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>3349</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4984</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4984</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4988</uax:Identifier>" +
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
           "<uax:NumericId>4988</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4989</uax:Identifier>" +
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
           "<uax:NumericId>4989</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4990</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4990</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4994</uax:Identifier>" +
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
           "<uax:NumericId>4994</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=4995</uax:Identifier>" +
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
           "<uax:NumericId>4995</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</FieldAxis>" +
           "<Resolution>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=3586</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Resolution</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>3586</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=3587</uax:Identifier>" +
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
           "<uax:NumericId>3587</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=3775</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>3775</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5008</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5008</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5012</uax:Identifier>" +
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
           "<uax:NumericId>5012</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5013</uax:Identifier>" +
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
           "<uax:NumericId>5013</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5014</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5014</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5018</uax:Identifier>" +
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
           "<uax:NumericId>5018</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5019</uax:Identifier>" +
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
           "<uax:NumericId>5019</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</Resolution>" +
           "<Slope>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=3799</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Slope</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>3799</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=3800</uax:Identifier>" +
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
           "<uax:NumericId>3800</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=3988</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>3988</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5020</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5020</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5024</uax:Identifier>" +
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
           "<uax:NumericId>5024</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5025</uax:Identifier>" +
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
           "<uax:NumericId>5025</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5026</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5026</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5030</uax:Identifier>" +
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
           "<uax:NumericId>5030</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5031</uax:Identifier>" +
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
           "<uax:NumericId>5031</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</Slope>" +
           "<UOffset>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4012</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>UOffset</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5126</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4012</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ParameterSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4013</uax:Identifier>" +
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
           "<uax:NumericId>4013</uax:NumericId>" +
           "</ParameterSet>" +
           "<Operational>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=4201</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Operational</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=5110</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>4201</uax:NumericId>" +
           "<RawValue>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5032</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>RawValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5032</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5036</uax:Identifier>" +
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
           "<uax:NumericId>5036</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5037</uax:Identifier>" +
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
           "<uax:NumericId>5037</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5038</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SensorValue</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17570</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>5038</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=5042</uax:Identifier>" +
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
           "<uax:NumericId>5042</uax:NumericId>" +
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
           "<uax:Identifier>ns=3;i=5043</uax:Identifier>" +
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
           "<uax:NumericId>5043</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SensorValue>" +
           "</Operational>" +
           "</UOffset>" +
           "</TuneParametersFunctionSetTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public DoubleAnalogSensorFunctionState IonReference
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
        public DoubleAnalogSensorFunctionState Cathode
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
        public DoubleAnalogSensorFunctionState Extraction
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
        public DoubleAnalogSensorFunctionState Focus
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
        public DoubleAnalogSensorFunctionState FilamentCurrent
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
        public DoubleAnalogSensorFunctionState EmissionCurrent
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
        public DoubleAnalogSensorFunctionState Deflection
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
        public DoubleAnalogSensorFunctionState Prefilter
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
        public DoubleAnalogSensorFunctionState SEMVoltage
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
        public DoubleAnalogSensorFunctionState UVRatio
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
        public DoubleAnalogSensorFunctionState FieldAxis
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
        public DoubleAnalogSensorFunctionState Resolution
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
        public DoubleAnalogSensorFunctionState Slope
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
        public DoubleAnalogSensorFunctionState UOffset
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
                case IPI.OpcUaServer.GAM.BrowseNames.IonReference:
                {
                    if (createOrReplace)
                    {
                        if (IonReference == null)
                        {
                            if (replacement == null)
                            {
                                IonReference = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                IonReference = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = IonReference;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.Cathode:
                {
                    if (createOrReplace)
                    {
                        if (Cathode == null)
                        {
                            if (replacement == null)
                            {
                                Cathode = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                Cathode = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = Cathode;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.Extraction:
                {
                    if (createOrReplace)
                    {
                        if (Extraction == null)
                        {
                            if (replacement == null)
                            {
                                Extraction = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                Extraction = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = Extraction;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.Focus:
                {
                    if (createOrReplace)
                    {
                        if (Focus == null)
                        {
                            if (replacement == null)
                            {
                                Focus = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                Focus = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = Focus;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.FilamentCurrent:
                {
                    if (createOrReplace)
                    {
                        if (FilamentCurrent == null)
                        {
                            if (replacement == null)
                            {
                                FilamentCurrent = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                FilamentCurrent = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = FilamentCurrent;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.EmissionCurrent:
                {
                    if (createOrReplace)
                    {
                        if (EmissionCurrent == null)
                        {
                            if (replacement == null)
                            {
                                EmissionCurrent = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                EmissionCurrent = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = EmissionCurrent;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.Deflection:
                {
                    if (createOrReplace)
                    {
                        if (Deflection == null)
                        {
                            if (replacement == null)
                            {
                                Deflection = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                Deflection = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = Deflection;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.Prefilter:
                {
                    if (createOrReplace)
                    {
                        if (Prefilter == null)
                        {
                            if (replacement == null)
                            {
                                Prefilter = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                Prefilter = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = Prefilter;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.SEMVoltage:
                {
                    if (createOrReplace)
                    {
                        if (SEMVoltage == null)
                        {
                            if (replacement == null)
                            {
                                SEMVoltage = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                SEMVoltage = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = SEMVoltage;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.UVRatio:
                {
                    if (createOrReplace)
                    {
                        if (UVRatio == null)
                        {
                            if (replacement == null)
                            {
                                UVRatio = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                UVRatio = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = UVRatio;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.FieldAxis:
                {
                    if (createOrReplace)
                    {
                        if (FieldAxis == null)
                        {
                            if (replacement == null)
                            {
                                FieldAxis = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                FieldAxis = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = FieldAxis;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.Resolution:
                {
                    if (createOrReplace)
                    {
                        if (Resolution == null)
                        {
                            if (replacement == null)
                            {
                                Resolution = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                Resolution = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = Resolution;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.Slope:
                {
                    if (createOrReplace)
                    {
                        if (Slope == null)
                        {
                            if (replacement == null)
                            {
                                Slope = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                Slope = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = Slope;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.UOffset:
                {
                    if (createOrReplace)
                    {
                        if (UOffset == null)
                        {
                            if (replacement == null)
                            {
                                UOffset = new DoubleAnalogSensorFunctionState(this);
                            }
                            else
                            {
                                UOffset = (DoubleAnalogSensorFunctionState)replacement;
                            }
                        }
                    }

                    instance = UOffset;
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
        private DoubleAnalogSensorFunctionState m_ionReference;
        private DoubleAnalogSensorFunctionState m_cathode;
        private DoubleAnalogSensorFunctionState m_extraction;
        private DoubleAnalogSensorFunctionState m_focus;
        private DoubleAnalogSensorFunctionState m_filamentCurrent;
        private DoubleAnalogSensorFunctionState m_emissionCurrent;
        private DoubleAnalogSensorFunctionState m_deflection;
        private DoubleAnalogSensorFunctionState m_prefilter;
        private DoubleAnalogSensorFunctionState m_sEMVoltage;
        private DoubleAnalogSensorFunctionState m_uVRatio;
        private DoubleAnalogSensorFunctionState m_fieldAxis;
        private DoubleAnalogSensorFunctionState m_resolution;
        private DoubleAnalogSensorFunctionState m_slope;
        private DoubleAnalogSensorFunctionState m_uOffset;
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
            return Opc.Ua.NodeId.Create(IPI.OpcUaServer.GAM.ObjectTypes.WatchdogType, IPI.OpcUaServer.GAM.Namespaces.GAM, namespaceUris);
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
           "<WatchdogTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://in-process.com/UA/GAM/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://in-process.com/UA/GAM/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=15</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>WatchdogTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=15</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>15</uax:NumericId>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=48</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=3;i=16</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=48</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=3;i=22</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<Trigger>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=16</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Trigger</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>16</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=48</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:IsInverse>true</uax:IsInverse>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=3;i=15</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=20</uax:Identifier>" +
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
           "<uax:NumericId>20</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</Trigger>" +
           "<Counter>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=22</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Counter</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=2368</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>22</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=4</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<uax:References>" +
           "<uax:Reference>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=48</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:IsInverse>true</uax:IsInverse>" +
           "<uax:TargetId>" +
           "<uax:Identifier>ns=3;i=15</uax:Identifier>" +
           "</uax:TargetId>" +
           "</uax:Reference>" +
           "</uax:References>" +
           "<EURange xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=26</uax:Identifier>" +
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
           "<uax:NumericId>26</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=884</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EURange>" +
           "</Counter>" +
           "</WatchdogTypeInstance>";
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
                case IPI.OpcUaServer.GAM.BrowseNames.Trigger:
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

                case IPI.OpcUaServer.GAM.BrowseNames.Counter:
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
            return Opc.Ua.NodeId.Create(IPI.OpcUaServer.GAM.ObjectTypes.GAMSystemStatusType, IPI.OpcUaServer.GAM.Namespaces.GAM, namespaceUris);
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
           "<GAMSystemStatusTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://in-process.com/UA/GAM/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://in-process.com/UA/GAM/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=28</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>GAMSystemStatusTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=28</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>28</uax:NumericId>" +
           "<AutomaticMode>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=29</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>AutomaticMode</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>29</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</AutomaticMode>" +
           "<GAMOK>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=30</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>GAMOK</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>30</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</GAMOK>" +
           "<GAMtemperatureOver35DegreeC>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=31</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>GAMtemperatureOver35DegreeC</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>31</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</GAMtemperatureOver35DegreeC>" +
           "<ManualMode>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=32</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>ManualMode</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>32</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ManualMode>" +
           "<SystemStatusText>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=33</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SystemStatusText</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>33</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SystemStatusText>" +
           "</GAMSystemStatusTypeInstance>";
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
                case IPI.OpcUaServer.GAM.BrowseNames.AutomaticMode:
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

                case IPI.OpcUaServer.GAM.BrowseNames.GAMOK:
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

                case IPI.OpcUaServer.GAM.BrowseNames.GAMtemperatureOver35DegreeC:
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

                case IPI.OpcUaServer.GAM.BrowseNames.ManualMode:
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

                case IPI.OpcUaServer.GAM.BrowseNames.SystemStatusText:
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
            return Opc.Ua.NodeId.Create(IPI.OpcUaServer.GAM.ObjectTypes.ReadbackTuneParametersType, IPI.OpcUaServer.GAM.Namespaces.GAM, namespaceUris);
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
           "<ReadbackTuneParametersTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://in-process.com/UA/GAM/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://in-process.com/UA/GAM/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=34</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>ReadbackTuneParametersTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=34</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>34</uax:NumericId>" +
           "<IonReference>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=35</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>IonReference</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>35</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=40</uax:Identifier>" +
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
           "<uax:NumericId>40</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</IonReference>" +
           "<Cathode>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=41</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Cathode</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>41</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=46</uax:Identifier>" +
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
           "<uax:NumericId>46</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</Cathode>" +
           "<Extraction>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=47</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Extraction</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>47</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=52</uax:Identifier>" +
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
           "<uax:NumericId>52</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</Extraction>" +
           "<Focus>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=53</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Focus</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>53</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=58</uax:Identifier>" +
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
           "<uax:NumericId>58</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</Focus>" +
           "<FilamentCurrent>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=59</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>FilamentCurrent</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>59</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=64</uax:Identifier>" +
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
           "<uax:NumericId>64</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</FilamentCurrent>" +
           "<EmissionCurrent>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=65</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>EmissionCurrent</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>65</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=70</uax:Identifier>" +
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
           "<uax:NumericId>70</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</EmissionCurrent>" +
           "<Deflection>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=71</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Deflection</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>71</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=76</uax:Identifier>" +
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
           "<uax:NumericId>76</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</Deflection>" +
           "<Prefilter>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=77</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Prefilter</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>77</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=82</uax:Identifier>" +
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
           "<uax:NumericId>82</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</Prefilter>" +
           "<SEMVoltage>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=83</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SEMVoltage</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>83</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=88</uax:Identifier>" +
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
           "<uax:NumericId>88</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SEMVoltage>" +
           "<UVRatio>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=89</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>UVRatio</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>89</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=94</uax:Identifier>" +
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
           "<uax:NumericId>94</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</UVRatio>" +
           "<FieldAxis>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=95</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>FieldAxis</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>95</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=100</uax:Identifier>" +
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
           "<uax:NumericId>100</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</FieldAxis>" +
           "<SelectedFilament>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=101</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SelectedFilament</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>101</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=4</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=106</uax:Identifier>" +
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
           "<uax:NumericId>106</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</SelectedFilament>" +
           "<Resolution>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=107</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Resolution</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>107</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=112</uax:Identifier>" +
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
           "<uax:NumericId>112</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</Resolution>" +
           "<Slope>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=113</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Slope</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>113</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=11</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=118</uax:Identifier>" +
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
           "<uax:NumericId>118</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</Slope>" +
           "<UOffset>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=119</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>UOffset</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>119</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=4</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=124</uax:Identifier>" +
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
           "<uax:NumericId>124</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</UOffset>" +
           "<DetectorType>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=125</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>DetectorType</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>125</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=130</uax:Identifier>" +
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
           "<uax:NumericId>130</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</DetectorType>" +
           "<DetectorInputPin>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=131</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>DetectorInputPin</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>131</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=4</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=136</uax:Identifier>" +
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
           "<uax:NumericId>136</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</DetectorInputPin>" +
           "<FIREnabled>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=137</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>FIREnabled</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=17497</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>137</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "<EngineeringUnits xmlns=\"http://opcfoundation.org/UA/\">" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=142</uax:Identifier>" +
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
           "<uax:NumericId>142</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=887</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</EngineeringUnits>" +
           "</FIREnabled>" +
           "</ReadbackTuneParametersTypeInstance>";
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
                case IPI.OpcUaServer.GAM.BrowseNames.IonReference:
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

                case IPI.OpcUaServer.GAM.BrowseNames.Cathode:
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

                case IPI.OpcUaServer.GAM.BrowseNames.Extraction:
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

                case IPI.OpcUaServer.GAM.BrowseNames.Focus:
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

                case IPI.OpcUaServer.GAM.BrowseNames.FilamentCurrent:
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

                case IPI.OpcUaServer.GAM.BrowseNames.EmissionCurrent:
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

                case IPI.OpcUaServer.GAM.BrowseNames.Deflection:
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

                case IPI.OpcUaServer.GAM.BrowseNames.Prefilter:
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

                case IPI.OpcUaServer.GAM.BrowseNames.SEMVoltage:
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

                case IPI.OpcUaServer.GAM.BrowseNames.UVRatio:
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

                case IPI.OpcUaServer.GAM.BrowseNames.FieldAxis:
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

                case IPI.OpcUaServer.GAM.BrowseNames.SelectedFilament:
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

                case IPI.OpcUaServer.GAM.BrowseNames.Resolution:
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

                case IPI.OpcUaServer.GAM.BrowseNames.Slope:
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

                case IPI.OpcUaServer.GAM.BrowseNames.UOffset:
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

                case IPI.OpcUaServer.GAM.BrowseNames.DetectorType:
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

                case IPI.OpcUaServer.GAM.BrowseNames.DetectorInputPin:
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

                case IPI.OpcUaServer.GAM.BrowseNames.FIREnabled:
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

    #region MCDValueState Class
    #if (!OPCUA_EXCLUDE_MCDValueState)
    /// <summary>
    /// Stores an instance of the MCDValueType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MCDValueState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MCDValueState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(IPI.OpcUaServer.GAM.ObjectTypes.MCDValueType, IPI.OpcUaServer.GAM.Namespaces.GAM, namespaceUris);
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
           "<MCDValueTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://in-process.com/UA/GAM/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://in-process.com/UA/GAM/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=900</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>MCDValueTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=900</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>900</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<IsValid>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=901</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>IsValid</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=63</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>901</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</IsValid>" +
           "<Component>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=902</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Component</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=63</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>902</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Component>" +
           "<Concentration>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=903</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>Concentration</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=63</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>903</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=12</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</Concentration>" +
           "</MCDValueTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> IsValid
        {
            get
            {
                return m_isValid;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isValid, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isValid = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> Component
        {
            get
            {
                return m_component;
            }

            set
            {
                if (!Object.ReferenceEquals(m_component, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_component = value;
            }
        }

        /// <remarks />
        public BaseDataVariableState<string> Concentration
        {
            get
            {
                return m_concentration;
            }

            set
            {
                if (!Object.ReferenceEquals(m_concentration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_concentration = value;
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
            if (m_isValid != null)
            {
                children.Add(m_isValid);
            }

            if (m_component != null)
            {
                children.Add(m_component);
            }

            if (m_concentration != null)
            {
                children.Add(m_concentration);
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
                case IPI.OpcUaServer.GAM.BrowseNames.IsValid:
                {
                    if (createOrReplace)
                    {
                        if (IsValid == null)
                        {
                            if (replacement == null)
                            {
                                IsValid = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                IsValid = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsValid;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.Component:
                {
                    if (createOrReplace)
                    {
                        if (Component == null)
                        {
                            if (replacement == null)
                            {
                                Component = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Component = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Component;
                    break;
                }

                case IPI.OpcUaServer.GAM.BrowseNames.Concentration:
                {
                    if (createOrReplace)
                    {
                        if (Concentration == null)
                        {
                            if (replacement == null)
                            {
                                Concentration = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Concentration = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Concentration;
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
        private BaseDataVariableState<bool> m_isValid;
        private BaseDataVariableState<string> m_component;
        private BaseDataVariableState<string> m_concentration;
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
    public partial class GAMDeviceState : LADSDeviceState
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
            return Opc.Ua.NodeId.Create(IPI.OpcUaServer.GAM.ObjectTypes.GAMDeviceType, IPI.OpcUaServer.GAM.Namespaces.GAM, namespaceUris);
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
           "<GAMDeviceTypeInstance xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:uax=\"http://opcfoundation.org/UA/2008/02/Types.xsd\" xmlns=\"http://in-process.com/UA/GAM/\">" +
           "<uax:NamespaceUris>" +
           "<uax:NamespaceUri>http://opcfoundation.org/UA/DI/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://spectaris.de/LADS/</uax:NamespaceUri>" +
           "<uax:NamespaceUri>http://in-process.com/UA/GAM/</uax:NamespaceUri>" +
           "</uax:NamespaceUris>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=143</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>GAMDeviceTypeInstance</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=143</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>143</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<ComponentSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=1026</uax:Identifier>" +
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
           "<uax:NumericId>1026</uax:NumericId>" +
           "</ComponentSet>" +
           "<FunctionalUnitSet xmlns=\"http://spectaris.de/LADS/\">" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=340</uax:Identifier>" +
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
           "<uax:NumericId>340</uax:NumericId>" +
           "</FunctionalUnitSet>" +
           "<SystemStatus>" +
           "<uax:NodeClass>Object_1</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=224</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SystemStatus</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=47</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>ns=3;i=28</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>224</uax:NumericId>" +
           "<uax:EventNotifier>1</uax:EventNotifier>" +
           "<AutomaticMode>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=225</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>AutomaticMode</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>225</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</AutomaticMode>" +
           "<GAMOK>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=226</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>GAMOK</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>226</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</GAMOK>" +
           "<GAMtemperatureOver35DegreeC>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=227</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>GAMtemperatureOver35DegreeC</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>227</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</GAMtemperatureOver35DegreeC>" +
           "<ManualMode>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=228</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>ManualMode</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>228</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=1</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</ManualMode>" +
           "<SystemStatusText>" +
           "<uax:NodeClass>Variable_2</uax:NodeClass>" +
           "<uax:NodeId>" +
           "<uax:Identifier>ns=3;i=229</uax:Identifier>" +
           "</uax:NodeId>" +
           "<uax:BrowseName>" +
           "<uax:NamespaceIndex>3</uax:NamespaceIndex>" +
           "<uax:Name>SystemStatusText</uax:Name>" +
           "</uax:BrowseName>" +
           "<uax:ReferenceTypeId>" +
           "<uax:Identifier>i=46</uax:Identifier>" +
           "</uax:ReferenceTypeId>" +
           "<uax:TypeDefinitionId>" +
           "<uax:Identifier>i=68</uax:Identifier>" +
           "</uax:TypeDefinitionId>" +
           "<uax:NumericId>229</uax:NumericId>" +
           "<uax:DataType>" +
           "<uax:Identifier>i=21</uax:Identifier>" +
           "</uax:DataType>" +
           "<uax:ValueRank>-1</uax:ValueRank>" +
           "<uax:AccessLevel>1</uax:AccessLevel>" +
           "<uax:UserAccessLevel>1</uax:UserAccessLevel>" +
           "</SystemStatusText>" +
           "</SystemStatus>" +
           "</GAMDeviceTypeInstance>";
        #endregion
        #endif
        #endregion

        #region Public Properties
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
            if (m_systemStatus != null)
            {
                children.Add(m_systemStatus);
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
                case IPI.OpcUaServer.GAM.BrowseNames.SystemStatus:
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
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private GAMSystemStatusState m_systemStatus;
        #endregion
    }
    #endif
    #endregion
}