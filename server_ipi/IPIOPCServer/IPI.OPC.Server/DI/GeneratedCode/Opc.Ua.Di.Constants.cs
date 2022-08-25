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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Opc.Ua.Di
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the DeviceHealthEnumeration DataType.
        /// </summary>
        public const uint DeviceHealthEnumeration = 1013;

        /// <summary>
        /// The identifier for the FetchResultDataType DataType.
        /// </summary>
        public const uint FetchResultDataType = 1101;

        /// <summary>
        /// The identifier for the TransferResultErrorDataType DataType.
        /// </summary>
        public const uint TransferResultErrorDataType = 1102;

        /// <summary>
        /// The identifier for the TransferResultDataDataType DataType.
        /// </summary>
        public const uint TransferResultDataDataType = 1103;

        /// <summary>
        /// The identifier for the ParameterResultDataType DataType.
        /// </summary>
        public const uint ParameterResultDataType = 1104;

        /// <summary>
        /// The identifier for the SoftwareVersionFileType DataType.
        /// </summary>
        public const uint SoftwareVersionFileType = 1463;

        /// <summary>
        /// The identifier for the UpdateBehavior DataType.
        /// </summary>
        public const uint UpdateBehavior = 1465;
    }
    #endregion

    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_Open = 16;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_Close = 19;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_Read = 21;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_Write = 24;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_GetPosition = 26;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_SetPosition = 29;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock Method.
        /// </summary>
        public const uint TopologyElementType_Lock_InitLock = 56;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RenewLock Method.
        /// </summary>
        public const uint TopologyElementType_Lock_RenewLock = 59;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_ExitLock Method.
        /// </summary>
        public const uint TopologyElementType_Lock_ExitLock = 61;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_BreakLock Method.
        /// </summary>
        public const uint TopologyElementType_Lock_BreakLock = 63;

        /// <summary>
        /// The identifier for the ComponentType_Lock_InitLock Method.
        /// </summary>
        public const uint ComponentType_Lock_InitLock = 106;

        /// <summary>
        /// The identifier for the ComponentType_Lock_RenewLock Method.
        /// </summary>
        public const uint ComponentType_Lock_RenewLock = 109;

        /// <summary>
        /// The identifier for the ComponentType_Lock_ExitLock Method.
        /// </summary>
        public const uint ComponentType_Lock_ExitLock = 111;

        /// <summary>
        /// The identifier for the ComponentType_Lock_BreakLock Method.
        /// </summary>
        public const uint ComponentType_Lock_BreakLock = 113;

        /// <summary>
        /// The identifier for the DeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint DeviceType_Lock_InitLock = 142;

        /// <summary>
        /// The identifier for the DeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint DeviceType_Lock_RenewLock = 145;

        /// <summary>
        /// The identifier for the DeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint DeviceType_Lock_ExitLock = 147;

        /// <summary>
        /// The identifier for the DeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint DeviceType_Lock_BreakLock = 149;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint DeviceType_CPIdentifier_Lock_InitLock = 176;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint DeviceType_CPIdentifier_Lock_RenewLock = 179;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint DeviceType_CPIdentifier_Lock_ExitLock = 181;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint DeviceType_CPIdentifier_Lock_BreakLock = 183;

        /// <summary>
        /// The identifier for the SoftwareType_Lock_InitLock Method.
        /// </summary>
        public const uint SoftwareType_Lock_InitLock = 210;

        /// <summary>
        /// The identifier for the SoftwareType_Lock_RenewLock Method.
        /// </summary>
        public const uint SoftwareType_Lock_RenewLock = 213;

        /// <summary>
        /// The identifier for the SoftwareType_Lock_ExitLock Method.
        /// </summary>
        public const uint SoftwareType_Lock_ExitLock = 215;

        /// <summary>
        /// The identifier for the SoftwareType_Lock_BreakLock Method.
        /// </summary>
        public const uint SoftwareType_Lock_BreakLock = 217;

        /// <summary>
        /// The identifier for the BlockType_Lock_InitLock Method.
        /// </summary>
        public const uint BlockType_Lock_InitLock = 246;

        /// <summary>
        /// The identifier for the BlockType_Lock_RenewLock Method.
        /// </summary>
        public const uint BlockType_Lock_RenewLock = 249;

        /// <summary>
        /// The identifier for the BlockType_Lock_ExitLock Method.
        /// </summary>
        public const uint BlockType_Lock_ExitLock = 251;

        /// <summary>
        /// The identifier for the BlockType_Lock_BreakLock Method.
        /// </summary>
        public const uint BlockType_Lock_BreakLock = 253;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_ShelvingState_TimedShelve = 366;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_ShelvingState_Unshelve = 368;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_ShelvingState_OneShotShelve = 369;

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint FailureAlarmType_ShelvingState_TimedShelve = 515;

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint FailureAlarmType_ShelvingState_Unshelve = 517;

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint FailureAlarmType_ShelvingState_OneShotShelve = 518;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint CheckFunctionAlarmType_ShelvingState_TimedShelve = 664;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint CheckFunctionAlarmType_ShelvingState_Unshelve = 666;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint CheckFunctionAlarmType_ShelvingState_OneShotShelve = 667;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint OffSpecAlarmType_ShelvingState_TimedShelve = 813;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint OffSpecAlarmType_ShelvingState_Unshelve = 815;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint OffSpecAlarmType_ShelvingState_OneShotShelve = 816;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_ShelvingState_TimedShelve = 962;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_ShelvingState_Unshelve = 964;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_ShelvingState_OneShotShelve = 965;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint NetworkType_CPIdentifier_Lock_InitLock = 1029;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint NetworkType_CPIdentifier_Lock_RenewLock = 1032;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint NetworkType_CPIdentifier_Lock_ExitLock = 1034;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint NetworkType_CPIdentifier_Lock_BreakLock = 1036;

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock Method.
        /// </summary>
        public const uint NetworkType_Lock_InitLock = 1045;

        /// <summary>
        /// The identifier for the NetworkType_Lock_RenewLock Method.
        /// </summary>
        public const uint NetworkType_Lock_RenewLock = 1048;

        /// <summary>
        /// The identifier for the NetworkType_Lock_ExitLock Method.
        /// </summary>
        public const uint NetworkType_Lock_ExitLock = 1050;

        /// <summary>
        /// The identifier for the NetworkType_Lock_BreakLock Method.
        /// </summary>
        public const uint NetworkType_Lock_BreakLock = 1052;

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_InitLock Method.
        /// </summary>
        public const uint ConnectionPointType_Lock_InitLock = 1067;

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_RenewLock Method.
        /// </summary>
        public const uint ConnectionPointType_Lock_RenewLock = 1070;

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_ExitLock Method.
        /// </summary>
        public const uint ConnectionPointType_Lock_ExitLock = 1072;

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_BreakLock Method.
        /// </summary>
        public const uint ConnectionPointType_Lock_BreakLock = 1074;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_InitLock = 1085;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_RenewLock = 1088;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_ExitLock = 1090;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_BreakLock = 1092;

        /// <summary>
        /// The identifier for the TransferServicesType_TransferToDevice Method.
        /// </summary>
        public const uint TransferServicesType_TransferToDevice = 1106;

        /// <summary>
        /// The identifier for the TransferServicesType_TransferFromDevice Method.
        /// </summary>
        public const uint TransferServicesType_TransferFromDevice = 1108;

        /// <summary>
        /// The identifier for the TransferServicesType_FetchTransferResultData Method.
        /// </summary>
        public const uint TransferServicesType_FetchTransferResultData = 1110;

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock Method.
        /// </summary>
        public const uint LockingServicesType_InitLock = 1129;

        /// <summary>
        /// The identifier for the LockingServicesType_RenewLock Method.
        /// </summary>
        public const uint LockingServicesType_RenewLock = 1132;

        /// <summary>
        /// The identifier for the LockingServicesType_ExitLock Method.
        /// </summary>
        public const uint LockingServicesType_ExitLock = 1134;

        /// <summary>
        /// The identifier for the LockingServicesType_BreakLock Method.
        /// </summary>
        public const uint LockingServicesType_BreakLock = 1136;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PrepareForUpdate_Prepare Method.
        /// </summary>
        public const uint SoftwareUpdateType_PrepareForUpdate_Prepare = 1156;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PrepareForUpdate_Abort Method.
        /// </summary>
        public const uint SoftwareUpdateType_PrepareForUpdate_Abort = 1157;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation_Resume Method.
        /// </summary>
        public const uint SoftwareUpdateType_Installation_Resume = 1180;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Confirmation_Confirm Method.
        /// </summary>
        public const uint SoftwareUpdateType_Confirmation_Confirm = 1209;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_GenerateFileForRead Method.
        /// </summary>
        public const uint SoftwareUpdateType_Parameters_GenerateFileForRead = 1213;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_GenerateFileForWrite Method.
        /// </summary>
        public const uint SoftwareUpdateType_Parameters_GenerateFileForWrite = 1216;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_CloseAndCommit Method.
        /// </summary>
        public const uint SoftwareUpdateType_Parameters_CloseAndCommit = 1219;

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_GenerateFileForRead Method.
        /// </summary>
        public const uint PackageLoadingType_FileTransfer_GenerateFileForRead = 1239;

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_GenerateFileForWrite Method.
        /// </summary>
        public const uint PackageLoadingType_FileTransfer_GenerateFileForWrite = 1242;

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_CloseAndCommit Method.
        /// </summary>
        public const uint PackageLoadingType_FileTransfer_CloseAndCommit = 1245;

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_GenerateFileForRead Method.
        /// </summary>
        public const uint DirectLoadingType_FileTransfer_GenerateFileForRead = 1262;

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_GenerateFileForWrite Method.
        /// </summary>
        public const uint DirectLoadingType_FileTransfer_GenerateFileForWrite = 1265;

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_CloseAndCommit Method.
        /// </summary>
        public const uint DirectLoadingType_FileTransfer_CloseAndCommit = 1268;

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_GenerateFileForRead Method.
        /// </summary>
        public const uint CachedLoadingType_FileTransfer_GenerateFileForRead = 1287;

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_GenerateFileForWrite Method.
        /// </summary>
        public const uint CachedLoadingType_FileTransfer_GenerateFileForWrite = 1290;

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_CloseAndCommit Method.
        /// </summary>
        public const uint CachedLoadingType_FileTransfer_CloseAndCommit = 1293;

        /// <summary>
        /// The identifier for the CachedLoadingType_GetUpdateBehavior Method.
        /// </summary>
        public const uint CachedLoadingType_GetUpdateBehavior = 1314;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_CreateDirectory Method.
        /// </summary>
        public const uint FileSystemLoadingType_FileSystem_CreateDirectory = 1320;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_CreateFile Method.
        /// </summary>
        public const uint FileSystemLoadingType_FileSystem_CreateFile = 1323;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_DeleteFileSystemObject Method.
        /// </summary>
        public const uint FileSystemLoadingType_FileSystem_DeleteFileSystemObject = 1326;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_MoveOrCopy Method.
        /// </summary>
        public const uint FileSystemLoadingType_FileSystem_MoveOrCopy = 1328;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_GetUpdateBehavior Method.
        /// </summary>
        public const uint FileSystemLoadingType_GetUpdateBehavior = 1331;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_ValidateFiles Method.
        /// </summary>
        public const uint FileSystemLoadingType_ValidateFiles = 1334;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Prepare Method.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_Prepare = 1360;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Abort Method.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_Abort = 1361;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Resume Method.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_Resume = 1362;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallSoftwarePackage Method.
        /// </summary>
        public const uint InstallationStateMachineType_InstallSoftwarePackage = 1397;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallFiles Method.
        /// </summary>
        public const uint InstallationStateMachineType_InstallFiles = 1400;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Resume Method.
        /// </summary>
        public const uint InstallationStateMachineType_Resume = 1402;

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_Confirm Method.
        /// </summary>
        public const uint ConfirmationStateMachineType_Confirm = 1453;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata Object.
        /// </summary>
        public const uint OPCUADINamespaceMetadata = 1;

        /// <summary>
        /// The identifier for the DeviceSet Object.
        /// </summary>
        public const uint DeviceSet = 38;

        /// <summary>
        /// The identifier for the DeviceFeatures Object.
        /// </summary>
        public const uint DeviceFeatures = 39;

        /// <summary>
        /// The identifier for the NetworkSet Object.
        /// </summary>
        public const uint NetworkSet = 40;

        /// <summary>
        /// The identifier for the DeviceTopology Object.
        /// </summary>
        public const uint DeviceTopology = 41;

        /// <summary>
        /// The identifier for the TopologyElementType_ParameterSet Object.
        /// </summary>
        public const uint TopologyElementType_ParameterSet = 44;

        /// <summary>
        /// The identifier for the TopologyElementType_MethodSet Object.
        /// </summary>
        public const uint TopologyElementType_MethodSet = 46;

        /// <summary>
        /// The identifier for the TopologyElementType_GroupIdentifier Object.
        /// </summary>
        public const uint TopologyElementType_GroupIdentifier = 47;

        /// <summary>
        /// The identifier for the TopologyElementType_Identification Object.
        /// </summary>
        public const uint TopologyElementType_Identification = 49;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock Object.
        /// </summary>
        public const uint TopologyElementType_Lock = 51;

        /// <summary>
        /// The identifier for the IDeviceHealthType_DeviceHealthAlarms Object.
        /// </summary>
        public const uint IDeviceHealthType_DeviceHealthAlarms = 83;

        /// <summary>
        /// The identifier for the ISupportInfoType_DeviceTypeImage Object.
        /// </summary>
        public const uint ISupportInfoType_DeviceTypeImage = 85;

        /// <summary>
        /// The identifier for the ISupportInfoType_Documentation Object.
        /// </summary>
        public const uint ISupportInfoType_Documentation = 87;

        /// <summary>
        /// The identifier for the ISupportInfoType_ProtocolSupport Object.
        /// </summary>
        public const uint ISupportInfoType_ProtocolSupport = 89;

        /// <summary>
        /// The identifier for the ISupportInfoType_ImageSet Object.
        /// </summary>
        public const uint ISupportInfoType_ImageSet = 91;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier Object.
        /// </summary>
        public const uint DeviceType_CPIdentifier = 165;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint DeviceType_CPIdentifier_NetworkAddress = 185;

        /// <summary>
        /// The identifier for the DeviceType_DeviceHealthAlarms Object.
        /// </summary>
        public const uint DeviceType_DeviceHealthAlarms = 188;

        /// <summary>
        /// The identifier for the DeviceType_DeviceTypeImage Object.
        /// </summary>
        public const uint DeviceType_DeviceTypeImage = 189;

        /// <summary>
        /// The identifier for the DeviceType_Documentation Object.
        /// </summary>
        public const uint DeviceType_Documentation = 191;

        /// <summary>
        /// The identifier for the DeviceType_ProtocolSupport Object.
        /// </summary>
        public const uint DeviceType_ProtocolSupport = 193;

        /// <summary>
        /// The identifier for the DeviceType_ImageSet Object.
        /// </summary>
        public const uint DeviceType_ImageSet = 195;

        /// <summary>
        /// The identifier for the ConfigurableObjectType_SupportedTypes Object.
        /// </summary>
        public const uint ConfigurableObjectType_SupportedTypes = 1006;

        /// <summary>
        /// The identifier for the ConfigurableObjectType_ObjectIdentifier Object.
        /// </summary>
        public const uint ConfigurableObjectType_ObjectIdentifier = 1007;

        /// <summary>
        /// The identifier for the FunctionalGroupType_GroupIdentifier Object.
        /// </summary>
        public const uint FunctionalGroupType_GroupIdentifier = 1009;

        /// <summary>
        /// The identifier for the NetworkType_ProfileIdentifier Object.
        /// </summary>
        public const uint NetworkType_ProfileIdentifier = 1017;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier Object.
        /// </summary>
        public const uint NetworkType_CPIdentifier = 1018;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint NetworkType_CPIdentifier_NetworkAddress = 1038;

        /// <summary>
        /// The identifier for the NetworkType_Lock Object.
        /// </summary>
        public const uint NetworkType_Lock = 1040;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkAddress Object.
        /// </summary>
        public const uint ConnectionPointType_NetworkAddress = 1076;

        /// <summary>
        /// The identifier for the ConnectionPointType_ProfileIdentifier Object.
        /// </summary>
        public const uint ConnectionPointType_ProfileIdentifier = 1078;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier Object.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier = 1079;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Loading Object.
        /// </summary>
        public const uint SoftwareUpdateType_Loading = 1139;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PrepareForUpdate Object.
        /// </summary>
        public const uint SoftwareUpdateType_PrepareForUpdate = 1141;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation Object.
        /// </summary>
        public const uint SoftwareUpdateType_Installation = 1159;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PowerCycle Object.
        /// </summary>
        public const uint SoftwareUpdateType_PowerCycle = 1181;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Confirmation Object.
        /// </summary>
        public const uint SoftwareUpdateType_Confirmation = 1195;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters Object.
        /// </summary>
        public const uint SoftwareUpdateType_Parameters = 1211;

        /// <summary>
        /// The identifier for the PackageLoadingType_CurrentVersion Object.
        /// </summary>
        public const uint PackageLoadingType_CurrentVersion = 1229;

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer Object.
        /// </summary>
        public const uint PackageLoadingType_FileTransfer = 1237;

        /// <summary>
        /// The identifier for the CachedLoadingType_PendingVersion Object.
        /// </summary>
        public const uint CachedLoadingType_PendingVersion = 1298;

        /// <summary>
        /// The identifier for the CachedLoadingType_FallbackVersion Object.
        /// </summary>
        public const uint CachedLoadingType_FallbackVersion = 1306;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem Object.
        /// </summary>
        public const uint FileSystemLoadingType_FileSystem = 1319;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Idle Object.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_Idle = 1363;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Preparing Object.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_Preparing = 1365;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparedForUpdate Object.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_PreparedForUpdate = 1367;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Resuming Object.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_Resuming = 1369;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_IdleToPreparing Object.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_IdleToPreparing = 1371;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparingToIdle Object.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_PreparingToIdle = 1373;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate Object.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate = 1375;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparedForUpdateToResuming Object.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_PreparedForUpdateToResuming = 1377;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_ResumingToIdle Object.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_ResumingToIdle = 1379;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Idle Object.
        /// </summary>
        public const uint InstallationStateMachineType_Idle = 1403;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Installing Object.
        /// </summary>
        public const uint InstallationStateMachineType_Installing = 1405;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Error Object.
        /// </summary>
        public const uint InstallationStateMachineType_Error = 1407;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_IdleToInstalling Object.
        /// </summary>
        public const uint InstallationStateMachineType_IdleToInstalling = 1409;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallingToIdle Object.
        /// </summary>
        public const uint InstallationStateMachineType_InstallingToIdle = 1411;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallingToError Object.
        /// </summary>
        public const uint InstallationStateMachineType_InstallingToError = 1413;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_ErrorToIdle Object.
        /// </summary>
        public const uint InstallationStateMachineType_ErrorToIdle = 1415;

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_NotWaitingForPowerCycle Object.
        /// </summary>
        public const uint PowerCycleStateMachineType_NotWaitingForPowerCycle = 1431;

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_WaitingForPowerCycle Object.
        /// </summary>
        public const uint PowerCycleStateMachineType_WaitingForPowerCycle = 1433;

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle Object.
        /// </summary>
        public const uint PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle = 1435;

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle Object.
        /// </summary>
        public const uint PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle = 1437;

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_NotWaitingForConfirm Object.
        /// </summary>
        public const uint ConfirmationStateMachineType_NotWaitingForConfirm = 1455;

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_WaitingForConfirm Object.
        /// </summary>
        public const uint ConfirmationStateMachineType_WaitingForConfirm = 1457;

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm Object.
        /// </summary>
        public const uint ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm = 1459;

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm Object.
        /// </summary>
        public const uint ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm = 1461;

        /// <summary>
        /// The identifier for the FetchResultDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint FetchResultDataType_Encoding_DefaultBinary = 1480;

        /// <summary>
        /// The identifier for the TransferResultErrorDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint TransferResultErrorDataType_Encoding_DefaultBinary = 1481;

        /// <summary>
        /// The identifier for the TransferResultDataDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint TransferResultDataDataType_Encoding_DefaultBinary = 1482;

        /// <summary>
        /// The identifier for the ParameterResultDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ParameterResultDataType_Encoding_DefaultBinary = 1483;

        /// <summary>
        /// The identifier for the FetchResultDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint FetchResultDataType_Encoding_DefaultXml = 1500;

        /// <summary>
        /// The identifier for the TransferResultErrorDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint TransferResultErrorDataType_Encoding_DefaultXml = 1501;

        /// <summary>
        /// The identifier for the TransferResultDataDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint TransferResultDataDataType_Encoding_DefaultXml = 1502;

        /// <summary>
        /// The identifier for the ParameterResultDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ParameterResultDataType_Encoding_DefaultXml = 1503;

        /// <summary>
        /// The identifier for the FetchResultDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint FetchResultDataType_Encoding_DefaultJson = 1520;

        /// <summary>
        /// The identifier for the TransferResultErrorDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint TransferResultErrorDataType_Encoding_DefaultJson = 1521;

        /// <summary>
        /// The identifier for the TransferResultDataDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint TransferResultDataDataType_Encoding_DefaultJson = 1522;

        /// <summary>
        /// The identifier for the ParameterResultDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint ParameterResultDataType_Encoding_DefaultJson = 1523;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the TopologyElementType ObjectType.
        /// </summary>
        public const uint TopologyElementType = 43;

        /// <summary>
        /// The identifier for the IVendorNameplateType ObjectType.
        /// </summary>
        public const uint IVendorNameplateType = 65;

        /// <summary>
        /// The identifier for the ITagNameplateType ObjectType.
        /// </summary>
        public const uint ITagNameplateType = 78;

        /// <summary>
        /// The identifier for the IDeviceHealthType ObjectType.
        /// </summary>
        public const uint IDeviceHealthType = 81;

        /// <summary>
        /// The identifier for the ISupportInfoType ObjectType.
        /// </summary>
        public const uint ISupportInfoType = 84;

        /// <summary>
        /// The identifier for the ComponentType ObjectType.
        /// </summary>
        public const uint ComponentType = 93;

        /// <summary>
        /// The identifier for the DeviceType ObjectType.
        /// </summary>
        public const uint DeviceType = 129;

        /// <summary>
        /// The identifier for the SoftwareType ObjectType.
        /// </summary>
        public const uint SoftwareType = 197;

        /// <summary>
        /// The identifier for the BlockType ObjectType.
        /// </summary>
        public const uint BlockType = 233;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType ObjectType.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType = 260;

        /// <summary>
        /// The identifier for the FailureAlarmType ObjectType.
        /// </summary>
        public const uint FailureAlarmType = 409;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType ObjectType.
        /// </summary>
        public const uint CheckFunctionAlarmType = 558;

        /// <summary>
        /// The identifier for the OffSpecAlarmType ObjectType.
        /// </summary>
        public const uint OffSpecAlarmType = 707;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType ObjectType.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType = 856;

        /// <summary>
        /// The identifier for the ConfigurableObjectType ObjectType.
        /// </summary>
        public const uint ConfigurableObjectType = 1005;

        /// <summary>
        /// The identifier for the FunctionalGroupType ObjectType.
        /// </summary>
        public const uint FunctionalGroupType = 1008;

        /// <summary>
        /// The identifier for the ProtocolType ObjectType.
        /// </summary>
        public const uint ProtocolType = 1012;

        /// <summary>
        /// The identifier for the NetworkType ObjectType.
        /// </summary>
        public const uint NetworkType = 1016;

        /// <summary>
        /// The identifier for the ConnectionPointType ObjectType.
        /// </summary>
        public const uint ConnectionPointType = 1054;

        /// <summary>
        /// The identifier for the TransferServicesType ObjectType.
        /// </summary>
        public const uint TransferServicesType = 1105;

        /// <summary>
        /// The identifier for the LockingServicesType ObjectType.
        /// </summary>
        public const uint LockingServicesType = 1123;

        /// <summary>
        /// The identifier for the SoftwareUpdateType ObjectType.
        /// </summary>
        public const uint SoftwareUpdateType = 1138;

        /// <summary>
        /// The identifier for the SoftwareLoadingType ObjectType.
        /// </summary>
        public const uint SoftwareLoadingType = 1225;

        /// <summary>
        /// The identifier for the PackageLoadingType ObjectType.
        /// </summary>
        public const uint PackageLoadingType = 1227;

        /// <summary>
        /// The identifier for the DirectLoadingType ObjectType.
        /// </summary>
        public const uint DirectLoadingType = 1250;

        /// <summary>
        /// The identifier for the CachedLoadingType ObjectType.
        /// </summary>
        public const uint CachedLoadingType = 1275;

        /// <summary>
        /// The identifier for the FileSystemLoadingType ObjectType.
        /// </summary>
        public const uint FileSystemLoadingType = 1317;

        /// <summary>
        /// The identifier for the SoftwareVersionType ObjectType.
        /// </summary>
        public const uint SoftwareVersionType = 1337;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType ObjectType.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType = 1345;

        /// <summary>
        /// The identifier for the InstallationStateMachineType ObjectType.
        /// </summary>
        public const uint InstallationStateMachineType = 1381;

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType ObjectType.
        /// </summary>
        public const uint PowerCycleStateMachineType = 1417;

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType ObjectType.
        /// </summary>
        public const uint ConfirmationStateMachineType = 1439;
    }
    #endregion

    #region ReferenceType Identifiers
    /// <summary>
    /// A class that declares constants for all ReferenceTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypes
    {
        /// <summary>
        /// The identifier for the ConnectsTo ReferenceType.
        /// </summary>
        public const uint ConnectsTo = 35;

        /// <summary>
        /// The identifier for the ConnectsToParent ReferenceType.
        /// </summary>
        public const uint ConnectsToParent = 36;

        /// <summary>
        /// The identifier for the IsOnline ReferenceType.
        /// </summary>
        public const uint IsOnline = 37;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceUri = 2;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceVersion = 3;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespacePublicationDate = 4;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_IsNamespaceSubset = 5;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_StaticNodeIdTypes = 6;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_StaticNumericNodeIdRange = 7;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_StaticStringNodeIdPattern = 8;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_Size = 10;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_Writable = 11;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_UserWritable = 12;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_OpenCount = 13;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_Open_InputArguments = 17;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_Open_OutputArguments = 18;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_Close_InputArguments = 20;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_Read_InputArguments = 22;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_Read_OutputArguments = 23;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_Write_InputArguments = 25;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_GetPosition_InputArguments = 27;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = 28;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_NamespaceFile_SetPosition_InputArguments = 30;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_DefaultRolePermissions = 32;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_DefaultUserRolePermissions = 33;

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public const uint OPCUADINamespaceMetadata_DefaultAccessRestrictions = 34;

        /// <summary>
        /// The identifier for the DeviceTopology_OnlineAccess Variable.
        /// </summary>
        public const uint DeviceTopology_OnlineAccess = 42;

        /// <summary>
        /// The identifier for the TopologyElementType_ParameterSet_ParameterIdentifier Variable.
        /// </summary>
        public const uint TopologyElementType_ParameterSet_ParameterIdentifier = 45;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_Locked Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_Locked = 52;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_LockingClient Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_LockingClient = 53;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_LockingUser Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_LockingUser = 54;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_RemainingLockTime = 55;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_InitLock_InputArguments = 57;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_InitLock_OutputArguments = 58;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_RenewLock_OutputArguments = 60;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_ExitLock_OutputArguments = 62;

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TopologyElementType_Lock_BreakLock_OutputArguments = 64;

        /// <summary>
        /// The identifier for the IVendorNameplateType_Manufacturer Variable.
        /// </summary>
        public const uint IVendorNameplateType_Manufacturer = 66;

        /// <summary>
        /// The identifier for the IVendorNameplateType_ManufacturerUri Variable.
        /// </summary>
        public const uint IVendorNameplateType_ManufacturerUri = 67;

        /// <summary>
        /// The identifier for the IVendorNameplateType_Model Variable.
        /// </summary>
        public const uint IVendorNameplateType_Model = 68;

        /// <summary>
        /// The identifier for the IVendorNameplateType_HardwareRevision Variable.
        /// </summary>
        public const uint IVendorNameplateType_HardwareRevision = 69;

        /// <summary>
        /// The identifier for the IVendorNameplateType_SoftwareRevision Variable.
        /// </summary>
        public const uint IVendorNameplateType_SoftwareRevision = 70;

        /// <summary>
        /// The identifier for the IVendorNameplateType_DeviceRevision Variable.
        /// </summary>
        public const uint IVendorNameplateType_DeviceRevision = 71;

        /// <summary>
        /// The identifier for the IVendorNameplateType_ProductCode Variable.
        /// </summary>
        public const uint IVendorNameplateType_ProductCode = 72;

        /// <summary>
        /// The identifier for the IVendorNameplateType_DeviceManual Variable.
        /// </summary>
        public const uint IVendorNameplateType_DeviceManual = 73;

        /// <summary>
        /// The identifier for the IVendorNameplateType_DeviceClass Variable.
        /// </summary>
        public const uint IVendorNameplateType_DeviceClass = 74;

        /// <summary>
        /// The identifier for the IVendorNameplateType_SerialNumber Variable.
        /// </summary>
        public const uint IVendorNameplateType_SerialNumber = 75;

        /// <summary>
        /// The identifier for the IVendorNameplateType_ProductInstanceUri Variable.
        /// </summary>
        public const uint IVendorNameplateType_ProductInstanceUri = 76;

        /// <summary>
        /// The identifier for the IVendorNameplateType_RevisionCounter Variable.
        /// </summary>
        public const uint IVendorNameplateType_RevisionCounter = 77;

        /// <summary>
        /// The identifier for the ITagNameplateType_AssetId Variable.
        /// </summary>
        public const uint ITagNameplateType_AssetId = 79;

        /// <summary>
        /// The identifier for the ITagNameplateType_ComponentName Variable.
        /// </summary>
        public const uint ITagNameplateType_ComponentName = 80;

        /// <summary>
        /// The identifier for the IDeviceHealthType_DeviceHealth Variable.
        /// </summary>
        public const uint IDeviceHealthType_DeviceHealth = 82;

        /// <summary>
        /// The identifier for the ISupportInfoType_DeviceTypeImage_ImageIdentifier Variable.
        /// </summary>
        public const uint ISupportInfoType_DeviceTypeImage_ImageIdentifier = 86;

        /// <summary>
        /// The identifier for the ISupportInfoType_Documentation_DocumentIdentifier Variable.
        /// </summary>
        public const uint ISupportInfoType_Documentation_DocumentIdentifier = 88;

        /// <summary>
        /// The identifier for the ISupportInfoType_ProtocolSupport_ProtocolSupportIdentifier Variable.
        /// </summary>
        public const uint ISupportInfoType_ProtocolSupport_ProtocolSupportIdentifier = 90;

        /// <summary>
        /// The identifier for the ISupportInfoType_ImageSet_ImageIdentifier Variable.
        /// </summary>
        public const uint ISupportInfoType_ImageSet_ImageIdentifier = 92;

        /// <summary>
        /// The identifier for the ComponentType_Lock_Locked Variable.
        /// </summary>
        public const uint ComponentType_Lock_Locked = 102;

        /// <summary>
        /// The identifier for the ComponentType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ComponentType_Lock_LockingClient = 103;

        /// <summary>
        /// The identifier for the ComponentType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ComponentType_Lock_LockingUser = 104;

        /// <summary>
        /// The identifier for the ComponentType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ComponentType_Lock_RemainingLockTime = 105;

        /// <summary>
        /// The identifier for the ComponentType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ComponentType_Lock_InitLock_InputArguments = 107;

        /// <summary>
        /// The identifier for the ComponentType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ComponentType_Lock_InitLock_OutputArguments = 108;

        /// <summary>
        /// The identifier for the ComponentType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ComponentType_Lock_RenewLock_OutputArguments = 110;

        /// <summary>
        /// The identifier for the ComponentType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ComponentType_Lock_ExitLock_OutputArguments = 112;

        /// <summary>
        /// The identifier for the ComponentType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ComponentType_Lock_BreakLock_OutputArguments = 114;

        /// <summary>
        /// The identifier for the ComponentType_Manufacturer Variable.
        /// </summary>
        public const uint ComponentType_Manufacturer = 115;

        /// <summary>
        /// The identifier for the ComponentType_ManufacturerUri Variable.
        /// </summary>
        public const uint ComponentType_ManufacturerUri = 116;

        /// <summary>
        /// The identifier for the ComponentType_Model Variable.
        /// </summary>
        public const uint ComponentType_Model = 117;

        /// <summary>
        /// The identifier for the ComponentType_HardwareRevision Variable.
        /// </summary>
        public const uint ComponentType_HardwareRevision = 118;

        /// <summary>
        /// The identifier for the ComponentType_SoftwareRevision Variable.
        /// </summary>
        public const uint ComponentType_SoftwareRevision = 119;

        /// <summary>
        /// The identifier for the ComponentType_DeviceRevision Variable.
        /// </summary>
        public const uint ComponentType_DeviceRevision = 120;

        /// <summary>
        /// The identifier for the ComponentType_ProductCode Variable.
        /// </summary>
        public const uint ComponentType_ProductCode = 121;

        /// <summary>
        /// The identifier for the ComponentType_DeviceManual Variable.
        /// </summary>
        public const uint ComponentType_DeviceManual = 122;

        /// <summary>
        /// The identifier for the ComponentType_DeviceClass Variable.
        /// </summary>
        public const uint ComponentType_DeviceClass = 123;

        /// <summary>
        /// The identifier for the ComponentType_SerialNumber Variable.
        /// </summary>
        public const uint ComponentType_SerialNumber = 124;

        /// <summary>
        /// The identifier for the ComponentType_ProductInstanceUri Variable.
        /// </summary>
        public const uint ComponentType_ProductInstanceUri = 125;

        /// <summary>
        /// The identifier for the ComponentType_RevisionCounter Variable.
        /// </summary>
        public const uint ComponentType_RevisionCounter = 126;

        /// <summary>
        /// The identifier for the ComponentType_AssetId Variable.
        /// </summary>
        public const uint ComponentType_AssetId = 127;

        /// <summary>
        /// The identifier for the ComponentType_ComponentName Variable.
        /// </summary>
        public const uint ComponentType_ComponentName = 128;

        /// <summary>
        /// The identifier for the DeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint DeviceType_Lock_Locked = 138;

        /// <summary>
        /// The identifier for the DeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint DeviceType_Lock_LockingClient = 139;

        /// <summary>
        /// The identifier for the DeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint DeviceType_Lock_LockingUser = 140;

        /// <summary>
        /// The identifier for the DeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint DeviceType_Lock_RemainingLockTime = 141;

        /// <summary>
        /// The identifier for the DeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint DeviceType_Lock_InitLock_InputArguments = 143;

        /// <summary>
        /// The identifier for the DeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceType_Lock_InitLock_OutputArguments = 144;

        /// <summary>
        /// The identifier for the DeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceType_Lock_RenewLock_OutputArguments = 146;

        /// <summary>
        /// The identifier for the DeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceType_Lock_ExitLock_OutputArguments = 148;

        /// <summary>
        /// The identifier for the DeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceType_Lock_BreakLock_OutputArguments = 150;

        /// <summary>
        /// The identifier for the DeviceType_Manufacturer Variable.
        /// </summary>
        public const uint DeviceType_Manufacturer = 151;

        /// <summary>
        /// The identifier for the DeviceType_ManufacturerUri Variable.
        /// </summary>
        public const uint DeviceType_ManufacturerUri = 152;

        /// <summary>
        /// The identifier for the DeviceType_Model Variable.
        /// </summary>
        public const uint DeviceType_Model = 153;

        /// <summary>
        /// The identifier for the DeviceType_HardwareRevision Variable.
        /// </summary>
        public const uint DeviceType_HardwareRevision = 154;

        /// <summary>
        /// The identifier for the DeviceType_SoftwareRevision Variable.
        /// </summary>
        public const uint DeviceType_SoftwareRevision = 155;

        /// <summary>
        /// The identifier for the DeviceType_DeviceRevision Variable.
        /// </summary>
        public const uint DeviceType_DeviceRevision = 156;

        /// <summary>
        /// The identifier for the DeviceType_ProductCode Variable.
        /// </summary>
        public const uint DeviceType_ProductCode = 157;

        /// <summary>
        /// The identifier for the DeviceType_DeviceManual Variable.
        /// </summary>
        public const uint DeviceType_DeviceManual = 158;

        /// <summary>
        /// The identifier for the DeviceType_DeviceClass Variable.
        /// </summary>
        public const uint DeviceType_DeviceClass = 159;

        /// <summary>
        /// The identifier for the DeviceType_SerialNumber Variable.
        /// </summary>
        public const uint DeviceType_SerialNumber = 160;

        /// <summary>
        /// The identifier for the DeviceType_ProductInstanceUri Variable.
        /// </summary>
        public const uint DeviceType_ProductInstanceUri = 161;

        /// <summary>
        /// The identifier for the DeviceType_RevisionCounter Variable.
        /// </summary>
        public const uint DeviceType_RevisionCounter = 162;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint DeviceType_CPIdentifier_Lock_Locked = 172;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint DeviceType_CPIdentifier_Lock_LockingClient = 173;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint DeviceType_CPIdentifier_Lock_LockingUser = 174;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint DeviceType_CPIdentifier_Lock_RemainingLockTime = 175;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint DeviceType_CPIdentifier_Lock_InitLock_InputArguments = 177;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 178;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 180;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 182;

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint DeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 184;

        /// <summary>
        /// The identifier for the DeviceType_DeviceHealth Variable.
        /// </summary>
        public const uint DeviceType_DeviceHealth = 187;

        /// <summary>
        /// The identifier for the DeviceType_DeviceTypeImage_ImageIdentifier Variable.
        /// </summary>
        public const uint DeviceType_DeviceTypeImage_ImageIdentifier = 190;

        /// <summary>
        /// The identifier for the DeviceType_Documentation_DocumentIdentifier Variable.
        /// </summary>
        public const uint DeviceType_Documentation_DocumentIdentifier = 192;

        /// <summary>
        /// The identifier for the DeviceType_ProtocolSupport_ProtocolSupportIdentifier Variable.
        /// </summary>
        public const uint DeviceType_ProtocolSupport_ProtocolSupportIdentifier = 194;

        /// <summary>
        /// The identifier for the DeviceType_ImageSet_ImageIdentifier Variable.
        /// </summary>
        public const uint DeviceType_ImageSet_ImageIdentifier = 196;

        /// <summary>
        /// The identifier for the SoftwareType_Lock_Locked Variable.
        /// </summary>
        public const uint SoftwareType_Lock_Locked = 206;

        /// <summary>
        /// The identifier for the SoftwareType_Lock_LockingClient Variable.
        /// </summary>
        public const uint SoftwareType_Lock_LockingClient = 207;

        /// <summary>
        /// The identifier for the SoftwareType_Lock_LockingUser Variable.
        /// </summary>
        public const uint SoftwareType_Lock_LockingUser = 208;

        /// <summary>
        /// The identifier for the SoftwareType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint SoftwareType_Lock_RemainingLockTime = 209;

        /// <summary>
        /// The identifier for the SoftwareType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint SoftwareType_Lock_InitLock_InputArguments = 211;

        /// <summary>
        /// The identifier for the SoftwareType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint SoftwareType_Lock_InitLock_OutputArguments = 212;

        /// <summary>
        /// The identifier for the SoftwareType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint SoftwareType_Lock_RenewLock_OutputArguments = 214;

        /// <summary>
        /// The identifier for the SoftwareType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint SoftwareType_Lock_ExitLock_OutputArguments = 216;

        /// <summary>
        /// The identifier for the SoftwareType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint SoftwareType_Lock_BreakLock_OutputArguments = 218;

        /// <summary>
        /// The identifier for the SoftwareType_Manufacturer Variable.
        /// </summary>
        public const uint SoftwareType_Manufacturer = 219;

        /// <summary>
        /// The identifier for the SoftwareType_Model Variable.
        /// </summary>
        public const uint SoftwareType_Model = 221;

        /// <summary>
        /// The identifier for the SoftwareType_SoftwareRevision Variable.
        /// </summary>
        public const uint SoftwareType_SoftwareRevision = 223;

        /// <summary>
        /// The identifier for the BlockType_Lock_Locked Variable.
        /// </summary>
        public const uint BlockType_Lock_Locked = 242;

        /// <summary>
        /// The identifier for the BlockType_Lock_LockingClient Variable.
        /// </summary>
        public const uint BlockType_Lock_LockingClient = 243;

        /// <summary>
        /// The identifier for the BlockType_Lock_LockingUser Variable.
        /// </summary>
        public const uint BlockType_Lock_LockingUser = 244;

        /// <summary>
        /// The identifier for the BlockType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint BlockType_Lock_RemainingLockTime = 245;

        /// <summary>
        /// The identifier for the BlockType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint BlockType_Lock_InitLock_InputArguments = 247;

        /// <summary>
        /// The identifier for the BlockType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint BlockType_Lock_InitLock_OutputArguments = 248;

        /// <summary>
        /// The identifier for the BlockType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint BlockType_Lock_RenewLock_OutputArguments = 250;

        /// <summary>
        /// The identifier for the BlockType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint BlockType_Lock_ExitLock_OutputArguments = 252;

        /// <summary>
        /// The identifier for the BlockType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint BlockType_Lock_BreakLock_OutputArguments = 254;

        /// <summary>
        /// The identifier for the BlockType_RevisionCounter Variable.
        /// </summary>
        public const uint BlockType_RevisionCounter = 255;

        /// <summary>
        /// The identifier for the BlockType_ActualMode Variable.
        /// </summary>
        public const uint BlockType_ActualMode = 256;

        /// <summary>
        /// The identifier for the BlockType_PermittedMode Variable.
        /// </summary>
        public const uint BlockType_PermittedMode = 257;

        /// <summary>
        /// The identifier for the BlockType_NormalMode Variable.
        /// </summary>
        public const uint BlockType_NormalMode = 258;

        /// <summary>
        /// The identifier for the BlockType_TargetMode Variable.
        /// </summary>
        public const uint BlockType_TargetMode = 259;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_EnabledState_Id Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_EnabledState_Id = 278;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_Quality_SourceTimestamp = 287;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_LastSeverity_SourceTimestamp = 289;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_Comment_SourceTimestamp = 291;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_AddComment_InputArguments = 296;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_ConditionRefresh_InputArguments = 298;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_ConditionRefresh2_InputArguments = 300;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_AckedState_Id Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_AckedState_Id = 302;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ConfirmedState_Id Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_ConfirmedState_Id = 311;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_Acknowledge_InputArguments = 320;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_Confirm_InputArguments Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_Confirm_InputArguments = 322;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ActiveState_Id Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_ActiveState_Id = 324;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_SuppressedState_Id Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_SuppressedState_Id = 334;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_OutOfServiceState_Id = 343;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_ShelvingState_CurrentState = 352;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_ShelvingState_CurrentState_Id = 353;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_ShelvingState_LastTransition_Id = 358;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_ShelvingState_UnshelveTime = 365;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_ShelvingState_TimedShelve_InputArguments = 367;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_SilenceState_Id Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_SilenceState_Id = 378;

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_LatchedState_Id Variable.
        /// </summary>
        public const uint DeviceHealthDiagnosticAlarmType_LatchedState_Id = 391;

        /// <summary>
        /// The identifier for the FailureAlarmType_EnabledState_Id Variable.
        /// </summary>
        public const uint FailureAlarmType_EnabledState_Id = 427;

        /// <summary>
        /// The identifier for the FailureAlarmType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint FailureAlarmType_Quality_SourceTimestamp = 436;

        /// <summary>
        /// The identifier for the FailureAlarmType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint FailureAlarmType_LastSeverity_SourceTimestamp = 438;

        /// <summary>
        /// The identifier for the FailureAlarmType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint FailureAlarmType_Comment_SourceTimestamp = 440;

        /// <summary>
        /// The identifier for the FailureAlarmType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint FailureAlarmType_AddComment_InputArguments = 445;

        /// <summary>
        /// The identifier for the FailureAlarmType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint FailureAlarmType_ConditionRefresh_InputArguments = 447;

        /// <summary>
        /// The identifier for the FailureAlarmType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint FailureAlarmType_ConditionRefresh2_InputArguments = 449;

        /// <summary>
        /// The identifier for the FailureAlarmType_AckedState_Id Variable.
        /// </summary>
        public const uint FailureAlarmType_AckedState_Id = 451;

        /// <summary>
        /// The identifier for the FailureAlarmType_ConfirmedState_Id Variable.
        /// </summary>
        public const uint FailureAlarmType_ConfirmedState_Id = 460;

        /// <summary>
        /// The identifier for the FailureAlarmType_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint FailureAlarmType_Acknowledge_InputArguments = 469;

        /// <summary>
        /// The identifier for the FailureAlarmType_Confirm_InputArguments Variable.
        /// </summary>
        public const uint FailureAlarmType_Confirm_InputArguments = 471;

        /// <summary>
        /// The identifier for the FailureAlarmType_ActiveState_Id Variable.
        /// </summary>
        public const uint FailureAlarmType_ActiveState_Id = 473;

        /// <summary>
        /// The identifier for the FailureAlarmType_SuppressedState_Id Variable.
        /// </summary>
        public const uint FailureAlarmType_SuppressedState_Id = 483;

        /// <summary>
        /// The identifier for the FailureAlarmType_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint FailureAlarmType_OutOfServiceState_Id = 492;

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint FailureAlarmType_ShelvingState_CurrentState = 501;

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint FailureAlarmType_ShelvingState_CurrentState_Id = 502;

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint FailureAlarmType_ShelvingState_LastTransition_Id = 507;

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint FailureAlarmType_ShelvingState_UnshelveTime = 514;

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint FailureAlarmType_ShelvingState_TimedShelve_InputArguments = 516;

        /// <summary>
        /// The identifier for the FailureAlarmType_SilenceState_Id Variable.
        /// </summary>
        public const uint FailureAlarmType_SilenceState_Id = 527;

        /// <summary>
        /// The identifier for the FailureAlarmType_LatchedState_Id Variable.
        /// </summary>
        public const uint FailureAlarmType_LatchedState_Id = 540;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_EnabledState_Id Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_EnabledState_Id = 576;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_Quality_SourceTimestamp = 585;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_LastSeverity_SourceTimestamp = 587;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_Comment_SourceTimestamp = 589;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_AddComment_InputArguments = 594;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_ConditionRefresh_InputArguments = 596;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_ConditionRefresh2_InputArguments = 598;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_AckedState_Id Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_AckedState_Id = 600;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ConfirmedState_Id Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_ConfirmedState_Id = 609;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_Acknowledge_InputArguments = 618;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_Confirm_InputArguments Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_Confirm_InputArguments = 620;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ActiveState_Id Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_ActiveState_Id = 622;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_SuppressedState_Id Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_SuppressedState_Id = 632;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_OutOfServiceState_Id = 641;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_ShelvingState_CurrentState = 650;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_ShelvingState_CurrentState_Id = 651;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_ShelvingState_LastTransition_Id = 656;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_ShelvingState_UnshelveTime = 663;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_ShelvingState_TimedShelve_InputArguments = 665;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_SilenceState_Id Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_SilenceState_Id = 676;

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_LatchedState_Id Variable.
        /// </summary>
        public const uint CheckFunctionAlarmType_LatchedState_Id = 689;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_EnabledState_Id Variable.
        /// </summary>
        public const uint OffSpecAlarmType_EnabledState_Id = 725;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint OffSpecAlarmType_Quality_SourceTimestamp = 734;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint OffSpecAlarmType_LastSeverity_SourceTimestamp = 736;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint OffSpecAlarmType_Comment_SourceTimestamp = 738;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint OffSpecAlarmType_AddComment_InputArguments = 743;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint OffSpecAlarmType_ConditionRefresh_InputArguments = 745;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint OffSpecAlarmType_ConditionRefresh2_InputArguments = 747;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_AckedState_Id Variable.
        /// </summary>
        public const uint OffSpecAlarmType_AckedState_Id = 749;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ConfirmedState_Id Variable.
        /// </summary>
        public const uint OffSpecAlarmType_ConfirmedState_Id = 758;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint OffSpecAlarmType_Acknowledge_InputArguments = 767;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_Confirm_InputArguments Variable.
        /// </summary>
        public const uint OffSpecAlarmType_Confirm_InputArguments = 769;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ActiveState_Id Variable.
        /// </summary>
        public const uint OffSpecAlarmType_ActiveState_Id = 771;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_SuppressedState_Id Variable.
        /// </summary>
        public const uint OffSpecAlarmType_SuppressedState_Id = 781;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint OffSpecAlarmType_OutOfServiceState_Id = 790;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint OffSpecAlarmType_ShelvingState_CurrentState = 799;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint OffSpecAlarmType_ShelvingState_CurrentState_Id = 800;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint OffSpecAlarmType_ShelvingState_LastTransition_Id = 805;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint OffSpecAlarmType_ShelvingState_UnshelveTime = 812;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint OffSpecAlarmType_ShelvingState_TimedShelve_InputArguments = 814;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_SilenceState_Id Variable.
        /// </summary>
        public const uint OffSpecAlarmType_SilenceState_Id = 825;

        /// <summary>
        /// The identifier for the OffSpecAlarmType_LatchedState_Id Variable.
        /// </summary>
        public const uint OffSpecAlarmType_LatchedState_Id = 838;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_EnabledState_Id Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_EnabledState_Id = 874;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_Quality_SourceTimestamp = 883;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_LastSeverity_SourceTimestamp = 885;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_Comment_SourceTimestamp = 887;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_AddComment_InputArguments = 892;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_ConditionRefresh_InputArguments = 894;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_ConditionRefresh2_InputArguments = 896;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_AckedState_Id Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_AckedState_Id = 898;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ConfirmedState_Id Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_ConfirmedState_Id = 907;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_Acknowledge_InputArguments = 916;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_Confirm_InputArguments Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_Confirm_InputArguments = 918;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ActiveState_Id Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_ActiveState_Id = 920;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_SuppressedState_Id Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_SuppressedState_Id = 930;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_OutOfServiceState_Id = 939;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_ShelvingState_CurrentState = 948;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_ShelvingState_CurrentState_Id = 949;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_ShelvingState_LastTransition_Id = 954;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_ShelvingState_UnshelveTime = 961;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_ShelvingState_TimedShelve_InputArguments = 963;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_SilenceState_Id Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_SilenceState_Id = 974;

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_LatchedState_Id Variable.
        /// </summary>
        public const uint MaintenanceRequiredAlarmType_LatchedState_Id = 987;

        /// <summary>
        /// The identifier for the FunctionalGroupType_GroupIdentifier_UIElement Variable.
        /// </summary>
        public const uint FunctionalGroupType_GroupIdentifier_UIElement = 1010;

        /// <summary>
        /// The identifier for the FunctionalGroupType_UIElement Variable.
        /// </summary>
        public const uint FunctionalGroupType_UIElement = 1011;

        /// <summary>
        /// The identifier for the DeviceHealthEnumeration_EnumStrings Variable.
        /// </summary>
        public const uint DeviceHealthEnumeration_EnumStrings = 1014;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_Lock_Locked = 1025;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_Lock_LockingClient = 1026;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_Lock_LockingUser = 1027;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_Lock_RemainingLockTime = 1028;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_Lock_InitLock_InputArguments = 1030;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_Lock_InitLock_OutputArguments = 1031;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_Lock_RenewLock_OutputArguments = 1033;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_Lock_ExitLock_OutputArguments = 1035;

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_CPIdentifier_Lock_BreakLock_OutputArguments = 1037;

        /// <summary>
        /// The identifier for the NetworkType_Lock_Locked Variable.
        /// </summary>
        public const uint NetworkType_Lock_Locked = 1041;

        /// <summary>
        /// The identifier for the NetworkType_Lock_LockingClient Variable.
        /// </summary>
        public const uint NetworkType_Lock_LockingClient = 1042;

        /// <summary>
        /// The identifier for the NetworkType_Lock_LockingUser Variable.
        /// </summary>
        public const uint NetworkType_Lock_LockingUser = 1043;

        /// <summary>
        /// The identifier for the NetworkType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint NetworkType_Lock_RemainingLockTime = 1044;

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_InitLock_InputArguments = 1046;

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_InitLock_OutputArguments = 1047;

        /// <summary>
        /// The identifier for the NetworkType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_RenewLock_OutputArguments = 1049;

        /// <summary>
        /// The identifier for the NetworkType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_ExitLock_OutputArguments = 1051;

        /// <summary>
        /// The identifier for the NetworkType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint NetworkType_Lock_BreakLock_OutputArguments = 1053;

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_Locked Variable.
        /// </summary>
        public const uint ConnectionPointType_Lock_Locked = 1063;

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ConnectionPointType_Lock_LockingClient = 1064;

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ConnectionPointType_Lock_LockingUser = 1065;

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ConnectionPointType_Lock_RemainingLockTime = 1066;

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_Lock_InitLock_InputArguments = 1068;

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_Lock_InitLock_OutputArguments = 1069;

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_Lock_RenewLock_OutputArguments = 1071;

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_Lock_ExitLock_OutputArguments = 1073;

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_Lock_BreakLock_OutputArguments = 1075;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_Locked = 1081;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_LockingClient = 1082;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_LockingUser = 1083;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime = 1084;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments = 1086;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments = 1087;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments = 1089;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments = 1091;

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments = 1093;

        /// <summary>
        /// The identifier for the TransferServicesType_TransferToDevice_OutputArguments Variable.
        /// </summary>
        public const uint TransferServicesType_TransferToDevice_OutputArguments = 1107;

        /// <summary>
        /// The identifier for the TransferServicesType_TransferFromDevice_OutputArguments Variable.
        /// </summary>
        public const uint TransferServicesType_TransferFromDevice_OutputArguments = 1109;

        /// <summary>
        /// The identifier for the TransferServicesType_FetchTransferResultData_InputArguments Variable.
        /// </summary>
        public const uint TransferServicesType_FetchTransferResultData_InputArguments = 1111;

        /// <summary>
        /// The identifier for the TransferServicesType_FetchTransferResultData_OutputArguments Variable.
        /// </summary>
        public const uint TransferServicesType_FetchTransferResultData_OutputArguments = 1112;

        /// <summary>
        /// The identifier for the MaxInactiveLockTime Variable.
        /// </summary>
        public const uint MaxInactiveLockTime = 1113;

        /// <summary>
        /// The identifier for the LockingServicesType_DefaultInstanceBrowseName Variable.
        /// </summary>
        public const uint LockingServicesType_DefaultInstanceBrowseName = 1124;

        /// <summary>
        /// The identifier for the LockingServicesType_Locked Variable.
        /// </summary>
        public const uint LockingServicesType_Locked = 1125;

        /// <summary>
        /// The identifier for the LockingServicesType_LockingClient Variable.
        /// </summary>
        public const uint LockingServicesType_LockingClient = 1126;

        /// <summary>
        /// The identifier for the LockingServicesType_LockingUser Variable.
        /// </summary>
        public const uint LockingServicesType_LockingUser = 1127;

        /// <summary>
        /// The identifier for the LockingServicesType_RemainingLockTime Variable.
        /// </summary>
        public const uint LockingServicesType_RemainingLockTime = 1128;

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock_InputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_InitLock_InputArguments = 1130;

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_InitLock_OutputArguments = 1131;

        /// <summary>
        /// The identifier for the LockingServicesType_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_RenewLock_OutputArguments = 1133;

        /// <summary>
        /// The identifier for the LockingServicesType_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_ExitLock_OutputArguments = 1135;

        /// <summary>
        /// The identifier for the LockingServicesType_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint LockingServicesType_BreakLock_OutputArguments = 1137;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PrepareForUpdate_CurrentState Variable.
        /// </summary>
        public const uint SoftwareUpdateType_PrepareForUpdate_CurrentState = 1142;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PrepareForUpdate_CurrentState_Id Variable.
        /// </summary>
        public const uint SoftwareUpdateType_PrepareForUpdate_CurrentState_Id = 1143;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PrepareForUpdate_LastTransition_Id Variable.
        /// </summary>
        public const uint SoftwareUpdateType_PrepareForUpdate_LastTransition_Id = 1148;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation_CurrentState Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Installation_CurrentState = 1160;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation_CurrentState_Id Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Installation_CurrentState_Id = 1161;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation_LastTransition_Id Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Installation_LastTransition_Id = 1166;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation_InstallSoftwarePackage_InputArguments Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Installation_InstallSoftwarePackage_InputArguments = 1176;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation_InstallFiles_InputArguments Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Installation_InstallFiles_InputArguments = 1179;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PowerCycle_CurrentState Variable.
        /// </summary>
        public const uint SoftwareUpdateType_PowerCycle_CurrentState = 1182;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PowerCycle_CurrentState_Id Variable.
        /// </summary>
        public const uint SoftwareUpdateType_PowerCycle_CurrentState_Id = 1183;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PowerCycle_LastTransition_Id Variable.
        /// </summary>
        public const uint SoftwareUpdateType_PowerCycle_LastTransition_Id = 1188;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Confirmation_CurrentState Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Confirmation_CurrentState = 1196;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Confirmation_CurrentState_Id Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Confirmation_CurrentState_Id = 1197;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Confirmation_LastTransition_Id Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Confirmation_LastTransition_Id = 1202;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Confirmation_ConfirmationTimeout Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Confirmation_ConfirmationTimeout = 1210;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_ClientProcessingTimeout Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Parameters_ClientProcessingTimeout = 1212;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_GenerateFileForRead_InputArguments Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Parameters_GenerateFileForRead_InputArguments = 1214;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_GenerateFileForRead_OutputArguments Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Parameters_GenerateFileForRead_OutputArguments = 1215;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_GenerateFileForWrite_InputArguments Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Parameters_GenerateFileForWrite_InputArguments = 1217;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_GenerateFileForWrite_OutputArguments Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Parameters_GenerateFileForWrite_OutputArguments = 1218;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_CloseAndCommit_InputArguments Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Parameters_CloseAndCommit_InputArguments = 1220;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_CloseAndCommit_OutputArguments Variable.
        /// </summary>
        public const uint SoftwareUpdateType_Parameters_CloseAndCommit_OutputArguments = 1221;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_UpdateStatus Variable.
        /// </summary>
        public const uint SoftwareUpdateType_UpdateStatus = 1222;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_VendorErrorCode Variable.
        /// </summary>
        public const uint SoftwareUpdateType_VendorErrorCode = 1223;

        /// <summary>
        /// The identifier for the SoftwareUpdateType_DefaultInstanceBrowseName Variable.
        /// </summary>
        public const uint SoftwareUpdateType_DefaultInstanceBrowseName = 1224;

        /// <summary>
        /// The identifier for the SoftwareLoadingType_UpdateKey Variable.
        /// </summary>
        public const uint SoftwareLoadingType_UpdateKey = 1226;

        /// <summary>
        /// The identifier for the PackageLoadingType_CurrentVersion_Manufacturer Variable.
        /// </summary>
        public const uint PackageLoadingType_CurrentVersion_Manufacturer = 1230;

        /// <summary>
        /// The identifier for the PackageLoadingType_CurrentVersion_ManufacturerUri Variable.
        /// </summary>
        public const uint PackageLoadingType_CurrentVersion_ManufacturerUri = 1231;

        /// <summary>
        /// The identifier for the PackageLoadingType_CurrentVersion_SoftwareRevision Variable.
        /// </summary>
        public const uint PackageLoadingType_CurrentVersion_SoftwareRevision = 1232;

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_ClientProcessingTimeout Variable.
        /// </summary>
        public const uint PackageLoadingType_FileTransfer_ClientProcessingTimeout = 1238;

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_GenerateFileForRead_InputArguments Variable.
        /// </summary>
        public const uint PackageLoadingType_FileTransfer_GenerateFileForRead_InputArguments = 1240;

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_GenerateFileForRead_OutputArguments Variable.
        /// </summary>
        public const uint PackageLoadingType_FileTransfer_GenerateFileForRead_OutputArguments = 1241;

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_GenerateFileForWrite_InputArguments Variable.
        /// </summary>
        public const uint PackageLoadingType_FileTransfer_GenerateFileForWrite_InputArguments = 1243;

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments Variable.
        /// </summary>
        public const uint PackageLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments = 1244;

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_CloseAndCommit_InputArguments Variable.
        /// </summary>
        public const uint PackageLoadingType_FileTransfer_CloseAndCommit_InputArguments = 1246;

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_CloseAndCommit_OutputArguments Variable.
        /// </summary>
        public const uint PackageLoadingType_FileTransfer_CloseAndCommit_OutputArguments = 1247;

        /// <summary>
        /// The identifier for the PackageLoadingType_ErrorMessage Variable.
        /// </summary>
        public const uint PackageLoadingType_ErrorMessage = 1248;

        /// <summary>
        /// The identifier for the PackageLoadingType_WriteBlockSize Variable.
        /// </summary>
        public const uint PackageLoadingType_WriteBlockSize = 1249;

        /// <summary>
        /// The identifier for the DirectLoadingType_CurrentVersion_Manufacturer Variable.
        /// </summary>
        public const uint DirectLoadingType_CurrentVersion_Manufacturer = 1253;

        /// <summary>
        /// The identifier for the DirectLoadingType_CurrentVersion_ManufacturerUri Variable.
        /// </summary>
        public const uint DirectLoadingType_CurrentVersion_ManufacturerUri = 1254;

        /// <summary>
        /// The identifier for the DirectLoadingType_CurrentVersion_SoftwareRevision Variable.
        /// </summary>
        public const uint DirectLoadingType_CurrentVersion_SoftwareRevision = 1255;

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_ClientProcessingTimeout Variable.
        /// </summary>
        public const uint DirectLoadingType_FileTransfer_ClientProcessingTimeout = 1261;

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_GenerateFileForRead_InputArguments Variable.
        /// </summary>
        public const uint DirectLoadingType_FileTransfer_GenerateFileForRead_InputArguments = 1263;

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_GenerateFileForRead_OutputArguments Variable.
        /// </summary>
        public const uint DirectLoadingType_FileTransfer_GenerateFileForRead_OutputArguments = 1264;

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_GenerateFileForWrite_InputArguments Variable.
        /// </summary>
        public const uint DirectLoadingType_FileTransfer_GenerateFileForWrite_InputArguments = 1266;

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments Variable.
        /// </summary>
        public const uint DirectLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments = 1267;

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_CloseAndCommit_InputArguments Variable.
        /// </summary>
        public const uint DirectLoadingType_FileTransfer_CloseAndCommit_InputArguments = 1269;

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_CloseAndCommit_OutputArguments Variable.
        /// </summary>
        public const uint DirectLoadingType_FileTransfer_CloseAndCommit_OutputArguments = 1270;

        /// <summary>
        /// The identifier for the DirectLoadingType_UpdateBehavior Variable.
        /// </summary>
        public const uint DirectLoadingType_UpdateBehavior = 1273;

        /// <summary>
        /// The identifier for the DirectLoadingType_WriteTimeout Variable.
        /// </summary>
        public const uint DirectLoadingType_WriteTimeout = 1274;

        /// <summary>
        /// The identifier for the CachedLoadingType_CurrentVersion_Manufacturer Variable.
        /// </summary>
        public const uint CachedLoadingType_CurrentVersion_Manufacturer = 1278;

        /// <summary>
        /// The identifier for the CachedLoadingType_CurrentVersion_ManufacturerUri Variable.
        /// </summary>
        public const uint CachedLoadingType_CurrentVersion_ManufacturerUri = 1279;

        /// <summary>
        /// The identifier for the CachedLoadingType_CurrentVersion_SoftwareRevision Variable.
        /// </summary>
        public const uint CachedLoadingType_CurrentVersion_SoftwareRevision = 1280;

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_ClientProcessingTimeout Variable.
        /// </summary>
        public const uint CachedLoadingType_FileTransfer_ClientProcessingTimeout = 1286;

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_GenerateFileForRead_InputArguments Variable.
        /// </summary>
        public const uint CachedLoadingType_FileTransfer_GenerateFileForRead_InputArguments = 1288;

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_GenerateFileForRead_OutputArguments Variable.
        /// </summary>
        public const uint CachedLoadingType_FileTransfer_GenerateFileForRead_OutputArguments = 1289;

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_GenerateFileForWrite_InputArguments Variable.
        /// </summary>
        public const uint CachedLoadingType_FileTransfer_GenerateFileForWrite_InputArguments = 1291;

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments Variable.
        /// </summary>
        public const uint CachedLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments = 1292;

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_CloseAndCommit_InputArguments Variable.
        /// </summary>
        public const uint CachedLoadingType_FileTransfer_CloseAndCommit_InputArguments = 1294;

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_CloseAndCommit_OutputArguments Variable.
        /// </summary>
        public const uint CachedLoadingType_FileTransfer_CloseAndCommit_OutputArguments = 1295;

        /// <summary>
        /// The identifier for the CachedLoadingType_PendingVersion_Manufacturer Variable.
        /// </summary>
        public const uint CachedLoadingType_PendingVersion_Manufacturer = 1299;

        /// <summary>
        /// The identifier for the CachedLoadingType_PendingVersion_ManufacturerUri Variable.
        /// </summary>
        public const uint CachedLoadingType_PendingVersion_ManufacturerUri = 1300;

        /// <summary>
        /// The identifier for the CachedLoadingType_PendingVersion_SoftwareRevision Variable.
        /// </summary>
        public const uint CachedLoadingType_PendingVersion_SoftwareRevision = 1301;

        /// <summary>
        /// The identifier for the CachedLoadingType_FallbackVersion_Manufacturer Variable.
        /// </summary>
        public const uint CachedLoadingType_FallbackVersion_Manufacturer = 1307;

        /// <summary>
        /// The identifier for the CachedLoadingType_FallbackVersion_ManufacturerUri Variable.
        /// </summary>
        public const uint CachedLoadingType_FallbackVersion_ManufacturerUri = 1308;

        /// <summary>
        /// The identifier for the CachedLoadingType_FallbackVersion_SoftwareRevision Variable.
        /// </summary>
        public const uint CachedLoadingType_FallbackVersion_SoftwareRevision = 1309;

        /// <summary>
        /// The identifier for the CachedLoadingType_GetUpdateBehavior_InputArguments Variable.
        /// </summary>
        public const uint CachedLoadingType_GetUpdateBehavior_InputArguments = 1315;

        /// <summary>
        /// The identifier for the CachedLoadingType_GetUpdateBehavior_OutputArguments Variable.
        /// </summary>
        public const uint CachedLoadingType_GetUpdateBehavior_OutputArguments = 1316;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_CreateDirectory_InputArguments Variable.
        /// </summary>
        public const uint FileSystemLoadingType_FileSystem_CreateDirectory_InputArguments = 1321;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_CreateDirectory_OutputArguments Variable.
        /// </summary>
        public const uint FileSystemLoadingType_FileSystem_CreateDirectory_OutputArguments = 1322;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_CreateFile_InputArguments Variable.
        /// </summary>
        public const uint FileSystemLoadingType_FileSystem_CreateFile_InputArguments = 1324;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_CreateFile_OutputArguments Variable.
        /// </summary>
        public const uint FileSystemLoadingType_FileSystem_CreateFile_OutputArguments = 1325;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_DeleteFileSystemObject_InputArguments Variable.
        /// </summary>
        public const uint FileSystemLoadingType_FileSystem_DeleteFileSystemObject_InputArguments = 1327;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_MoveOrCopy_InputArguments Variable.
        /// </summary>
        public const uint FileSystemLoadingType_FileSystem_MoveOrCopy_InputArguments = 1329;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_MoveOrCopy_OutputArguments Variable.
        /// </summary>
        public const uint FileSystemLoadingType_FileSystem_MoveOrCopy_OutputArguments = 1330;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_GetUpdateBehavior_InputArguments Variable.
        /// </summary>
        public const uint FileSystemLoadingType_GetUpdateBehavior_InputArguments = 1332;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_GetUpdateBehavior_OutputArguments Variable.
        /// </summary>
        public const uint FileSystemLoadingType_GetUpdateBehavior_OutputArguments = 1333;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_ValidateFiles_InputArguments Variable.
        /// </summary>
        public const uint FileSystemLoadingType_ValidateFiles_InputArguments = 1335;

        /// <summary>
        /// The identifier for the FileSystemLoadingType_ValidateFiles_OutputArguments Variable.
        /// </summary>
        public const uint FileSystemLoadingType_ValidateFiles_OutputArguments = 1336;

        /// <summary>
        /// The identifier for the SoftwareVersionType_Manufacturer Variable.
        /// </summary>
        public const uint SoftwareVersionType_Manufacturer = 1338;

        /// <summary>
        /// The identifier for the SoftwareVersionType_ManufacturerUri Variable.
        /// </summary>
        public const uint SoftwareVersionType_ManufacturerUri = 1339;

        /// <summary>
        /// The identifier for the SoftwareVersionType_SoftwareRevision Variable.
        /// </summary>
        public const uint SoftwareVersionType_SoftwareRevision = 1340;

        /// <summary>
        /// The identifier for the SoftwareVersionType_PatchIdentifiers Variable.
        /// </summary>
        public const uint SoftwareVersionType_PatchIdentifiers = 1341;

        /// <summary>
        /// The identifier for the SoftwareVersionType_ReleaseDate Variable.
        /// </summary>
        public const uint SoftwareVersionType_ReleaseDate = 1342;

        /// <summary>
        /// The identifier for the SoftwareVersionType_ChangeLogReference Variable.
        /// </summary>
        public const uint SoftwareVersionType_ChangeLogReference = 1343;

        /// <summary>
        /// The identifier for the SoftwareVersionType_Hash Variable.
        /// </summary>
        public const uint SoftwareVersionType_Hash = 1344;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_CurrentState_Id = 1347;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_LastTransition_Id = 1352;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PercentComplete Variable.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_PercentComplete = 1359;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Idle_StateNumber Variable.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_Idle_StateNumber = 1364;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Preparing_StateNumber Variable.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_Preparing_StateNumber = 1366;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparedForUpdate_StateNumber Variable.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_PreparedForUpdate_StateNumber = 1368;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Resuming_StateNumber Variable.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_Resuming_StateNumber = 1370;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_IdleToPreparing_TransitionNumber Variable.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_IdleToPreparing_TransitionNumber = 1372;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparingToIdle_TransitionNumber Variable.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_PreparingToIdle_TransitionNumber = 1374;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate_TransitionNumber Variable.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate_TransitionNumber = 1376;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparedForUpdateToResuming_TransitionNumber Variable.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_PreparedForUpdateToResuming_TransitionNumber = 1378;

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_ResumingToIdle_TransitionNumber Variable.
        /// </summary>
        public const uint PrepareForUpdateStateMachineType_ResumingToIdle_TransitionNumber = 1380;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public const uint InstallationStateMachineType_CurrentState_Id = 1383;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public const uint InstallationStateMachineType_LastTransition_Id = 1388;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_PercentComplete Variable.
        /// </summary>
        public const uint InstallationStateMachineType_PercentComplete = 1395;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallationDelay Variable.
        /// </summary>
        public const uint InstallationStateMachineType_InstallationDelay = 1396;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallSoftwarePackage_InputArguments Variable.
        /// </summary>
        public const uint InstallationStateMachineType_InstallSoftwarePackage_InputArguments = 1398;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallSoftwarePackage_OutputArguments Variable.
        /// </summary>
        public const uint InstallationStateMachineType_InstallSoftwarePackage_OutputArguments = 1399;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallFiles_InputArguments Variable.
        /// </summary>
        public const uint InstallationStateMachineType_InstallFiles_InputArguments = 1401;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Idle_StateNumber Variable.
        /// </summary>
        public const uint InstallationStateMachineType_Idle_StateNumber = 1404;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Installing_StateNumber Variable.
        /// </summary>
        public const uint InstallationStateMachineType_Installing_StateNumber = 1406;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Error_StateNumber Variable.
        /// </summary>
        public const uint InstallationStateMachineType_Error_StateNumber = 1408;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_IdleToInstalling_TransitionNumber Variable.
        /// </summary>
        public const uint InstallationStateMachineType_IdleToInstalling_TransitionNumber = 1410;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallingToIdle_TransitionNumber Variable.
        /// </summary>
        public const uint InstallationStateMachineType_InstallingToIdle_TransitionNumber = 1412;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallingToError_TransitionNumber Variable.
        /// </summary>
        public const uint InstallationStateMachineType_InstallingToError_TransitionNumber = 1414;

        /// <summary>
        /// The identifier for the InstallationStateMachineType_ErrorToIdle_TransitionNumber Variable.
        /// </summary>
        public const uint InstallationStateMachineType_ErrorToIdle_TransitionNumber = 1416;

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public const uint PowerCycleStateMachineType_CurrentState_Id = 1419;

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public const uint PowerCycleStateMachineType_LastTransition_Id = 1424;

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_NotWaitingForPowerCycle_StateNumber Variable.
        /// </summary>
        public const uint PowerCycleStateMachineType_NotWaitingForPowerCycle_StateNumber = 1432;

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_WaitingForPowerCycle_StateNumber Variable.
        /// </summary>
        public const uint PowerCycleStateMachineType_WaitingForPowerCycle_StateNumber = 1434;

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle_TransitionNumber Variable.
        /// </summary>
        public const uint PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle_TransitionNumber = 1436;

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle_TransitionNumber Variable.
        /// </summary>
        public const uint PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle_TransitionNumber = 1438;

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public const uint ConfirmationStateMachineType_CurrentState_Id = 1441;

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public const uint ConfirmationStateMachineType_LastTransition_Id = 1446;

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_ConfirmationTimeout Variable.
        /// </summary>
        public const uint ConfirmationStateMachineType_ConfirmationTimeout = 1454;

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_NotWaitingForConfirm_StateNumber Variable.
        /// </summary>
        public const uint ConfirmationStateMachineType_NotWaitingForConfirm_StateNumber = 1456;

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_WaitingForConfirm_StateNumber Variable.
        /// </summary>
        public const uint ConfirmationStateMachineType_WaitingForConfirm_StateNumber = 1458;

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm_TransitionNumber Variable.
        /// </summary>
        public const uint ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm_TransitionNumber = 1460;

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm_TransitionNumber Variable.
        /// </summary>
        public const uint ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm_TransitionNumber = 1462;

        /// <summary>
        /// The identifier for the SoftwareVersionFileType_EnumStrings Variable.
        /// </summary>
        public const uint SoftwareVersionFileType_EnumStrings = 1464;

        /// <summary>
        /// The identifier for the UpdateBehavior_OptionSetValues Variable.
        /// </summary>
        public const uint UpdateBehavior_OptionSetValues = 1466;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema = 1484;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_NamespaceUri = 1486;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_Deprecated = 1487;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_FetchResultDataType Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_FetchResultDataType = 1488;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_TransferResultErrorDataType Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_TransferResultErrorDataType = 1491;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_TransferResultDataDataType Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_TransferResultDataDataType = 1494;

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_ParameterResultDataType Variable.
        /// </summary>
        public const uint OpcUaDi_BinarySchema_ParameterResultDataType = 1497;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema = 1504;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_NamespaceUri = 1506;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_Deprecated = 1507;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_FetchResultDataType Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_FetchResultDataType = 1508;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_TransferResultErrorDataType Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_TransferResultErrorDataType = 1511;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_TransferResultDataDataType Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_TransferResultDataDataType = 1514;

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_ParameterResultDataType Variable.
        /// </summary>
        public const uint OpcUaDi_XmlSchema_ParameterResultDataType = 1517;
    }
    #endregion

    #region VariableType Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypes
    {
        /// <summary>
        /// The identifier for the UIElementType VariableType.
        /// </summary>
        public const uint UIElementType = 1015;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the DeviceHealthEnumeration DataType.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthEnumeration = new ExpandedNodeId(Opc.Ua.Di.DataTypes.DeviceHealthEnumeration, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchResultDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId FetchResultDataType = new ExpandedNodeId(Opc.Ua.Di.DataTypes.FetchResultDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferResultErrorDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId TransferResultErrorDataType = new ExpandedNodeId(Opc.Ua.Di.DataTypes.TransferResultErrorDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferResultDataDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId TransferResultDataDataType = new ExpandedNodeId(Opc.Ua.Di.DataTypes.TransferResultDataDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ParameterResultDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ParameterResultDataType = new ExpandedNodeId(Opc.Ua.Di.DataTypes.ParameterResultDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareVersionFileType DataType.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareVersionFileType = new ExpandedNodeId(Opc.Ua.Di.DataTypes.SoftwareVersionFileType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the UpdateBehavior DataType.
        /// </summary>
        public static readonly ExpandedNodeId UpdateBehavior = new ExpandedNodeId(Opc.Ua.Di.DataTypes.UpdateBehavior, Opc.Ua.Di.Namespaces.OpcUaDi);
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_Open = new ExpandedNodeId(Opc.Ua.Di.Methods.OPCUADINamespaceMetadata_NamespaceFile_Open, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_Close = new ExpandedNodeId(Opc.Ua.Di.Methods.OPCUADINamespaceMetadata_NamespaceFile_Close, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_Read = new ExpandedNodeId(Opc.Ua.Di.Methods.OPCUADINamespaceMetadata_NamespaceFile_Read, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_Write = new ExpandedNodeId(Opc.Ua.Di.Methods.OPCUADINamespaceMetadata_NamespaceFile_Write, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_GetPosition = new ExpandedNodeId(Opc.Ua.Di.Methods.OPCUADINamespaceMetadata_NamespaceFile_GetPosition, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_SetPosition = new ExpandedNodeId(Opc.Ua.Di.Methods.OPCUADINamespaceMetadata_NamespaceFile_SetPosition, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.TopologyElementType_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.TopologyElementType_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.TopologyElementType_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.TopologyElementType_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ComponentType_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ComponentType_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ComponentType_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ComponentType_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceType_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceType_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceType_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceType_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.SoftwareType_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.SoftwareType_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.SoftwareType_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.SoftwareType_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.BlockType_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.BlockType_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.BlockType_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.BlockType_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_ShelvingState_TimedShelve = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceHealthDiagnosticAlarmType_ShelvingState_TimedShelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_ShelvingState_Unshelve = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceHealthDiagnosticAlarmType_ShelvingState_Unshelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_ShelvingState_OneShotShelve = new ExpandedNodeId(Opc.Ua.Di.Methods.DeviceHealthDiagnosticAlarmType_ShelvingState_OneShotShelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_ShelvingState_TimedShelve = new ExpandedNodeId(Opc.Ua.Di.Methods.FailureAlarmType_ShelvingState_TimedShelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_ShelvingState_Unshelve = new ExpandedNodeId(Opc.Ua.Di.Methods.FailureAlarmType_ShelvingState_Unshelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_ShelvingState_OneShotShelve = new ExpandedNodeId(Opc.Ua.Di.Methods.FailureAlarmType_ShelvingState_OneShotShelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_ShelvingState_TimedShelve = new ExpandedNodeId(Opc.Ua.Di.Methods.CheckFunctionAlarmType_ShelvingState_TimedShelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_ShelvingState_Unshelve = new ExpandedNodeId(Opc.Ua.Di.Methods.CheckFunctionAlarmType_ShelvingState_Unshelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_ShelvingState_OneShotShelve = new ExpandedNodeId(Opc.Ua.Di.Methods.CheckFunctionAlarmType_ShelvingState_OneShotShelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_ShelvingState_TimedShelve = new ExpandedNodeId(Opc.Ua.Di.Methods.OffSpecAlarmType_ShelvingState_TimedShelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_ShelvingState_Unshelve = new ExpandedNodeId(Opc.Ua.Di.Methods.OffSpecAlarmType_ShelvingState_Unshelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_ShelvingState_OneShotShelve = new ExpandedNodeId(Opc.Ua.Di.Methods.OffSpecAlarmType_ShelvingState_OneShotShelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_ShelvingState_TimedShelve = new ExpandedNodeId(Opc.Ua.Di.Methods.MaintenanceRequiredAlarmType_ShelvingState_TimedShelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_ShelvingState_Unshelve = new ExpandedNodeId(Opc.Ua.Di.Methods.MaintenanceRequiredAlarmType_ShelvingState_Unshelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_ShelvingState_OneShotShelve = new ExpandedNodeId(Opc.Ua.Di.Methods.MaintenanceRequiredAlarmType_ShelvingState_OneShotShelve, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_CPIdentifier_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_CPIdentifier_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_CPIdentifier_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_CPIdentifier_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.NetworkType_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ConnectionPointType_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ConnectionPointType_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ConnectionPointType_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ConnectionPointType_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ConnectionPointType_NetworkIdentifier_Lock_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ConnectionPointType_NetworkIdentifier_Lock_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ConnectionPointType_NetworkIdentifier_Lock_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.ConnectionPointType_NetworkIdentifier_Lock_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_TransferToDevice Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_TransferToDevice = new ExpandedNodeId(Opc.Ua.Di.Methods.TransferServicesType_TransferToDevice, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_TransferFromDevice Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_TransferFromDevice = new ExpandedNodeId(Opc.Ua.Di.Methods.TransferServicesType_TransferFromDevice, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_FetchTransferResultData Method.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_FetchTransferResultData = new ExpandedNodeId(Opc.Ua.Di.Methods.TransferServicesType_FetchTransferResultData, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_InitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.LockingServicesType_InitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_RenewLock = new ExpandedNodeId(Opc.Ua.Di.Methods.LockingServicesType_RenewLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_ExitLock = new ExpandedNodeId(Opc.Ua.Di.Methods.LockingServicesType_ExitLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_BreakLock = new ExpandedNodeId(Opc.Ua.Di.Methods.LockingServicesType_BreakLock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PrepareForUpdate_Prepare Method.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_PrepareForUpdate_Prepare = new ExpandedNodeId(Opc.Ua.Di.Methods.SoftwareUpdateType_PrepareForUpdate_Prepare, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PrepareForUpdate_Abort Method.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_PrepareForUpdate_Abort = new ExpandedNodeId(Opc.Ua.Di.Methods.SoftwareUpdateType_PrepareForUpdate_Abort, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Installation_Resume = new ExpandedNodeId(Opc.Ua.Di.Methods.SoftwareUpdateType_Installation_Resume, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Confirmation_Confirm Method.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Confirmation_Confirm = new ExpandedNodeId(Opc.Ua.Di.Methods.SoftwareUpdateType_Confirmation_Confirm, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_GenerateFileForRead Method.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_GenerateFileForRead = new ExpandedNodeId(Opc.Ua.Di.Methods.SoftwareUpdateType_Parameters_GenerateFileForRead, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_GenerateFileForWrite Method.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_GenerateFileForWrite = new ExpandedNodeId(Opc.Ua.Di.Methods.SoftwareUpdateType_Parameters_GenerateFileForWrite, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_CloseAndCommit Method.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_CloseAndCommit = new ExpandedNodeId(Opc.Ua.Di.Methods.SoftwareUpdateType_Parameters_CloseAndCommit, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_GenerateFileForRead Method.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_GenerateFileForRead = new ExpandedNodeId(Opc.Ua.Di.Methods.PackageLoadingType_FileTransfer_GenerateFileForRead, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_GenerateFileForWrite Method.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_GenerateFileForWrite = new ExpandedNodeId(Opc.Ua.Di.Methods.PackageLoadingType_FileTransfer_GenerateFileForWrite, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_CloseAndCommit Method.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_CloseAndCommit = new ExpandedNodeId(Opc.Ua.Di.Methods.PackageLoadingType_FileTransfer_CloseAndCommit, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_GenerateFileForRead Method.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_GenerateFileForRead = new ExpandedNodeId(Opc.Ua.Di.Methods.DirectLoadingType_FileTransfer_GenerateFileForRead, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_GenerateFileForWrite Method.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_GenerateFileForWrite = new ExpandedNodeId(Opc.Ua.Di.Methods.DirectLoadingType_FileTransfer_GenerateFileForWrite, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_CloseAndCommit Method.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_CloseAndCommit = new ExpandedNodeId(Opc.Ua.Di.Methods.DirectLoadingType_FileTransfer_CloseAndCommit, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_GenerateFileForRead Method.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_GenerateFileForRead = new ExpandedNodeId(Opc.Ua.Di.Methods.CachedLoadingType_FileTransfer_GenerateFileForRead, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_GenerateFileForWrite Method.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_GenerateFileForWrite = new ExpandedNodeId(Opc.Ua.Di.Methods.CachedLoadingType_FileTransfer_GenerateFileForWrite, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_CloseAndCommit Method.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_CloseAndCommit = new ExpandedNodeId(Opc.Ua.Di.Methods.CachedLoadingType_FileTransfer_CloseAndCommit, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_GetUpdateBehavior Method.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_GetUpdateBehavior = new ExpandedNodeId(Opc.Ua.Di.Methods.CachedLoadingType_GetUpdateBehavior, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_CreateDirectory Method.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_CreateDirectory = new ExpandedNodeId(Opc.Ua.Di.Methods.FileSystemLoadingType_FileSystem_CreateDirectory, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_CreateFile Method.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_CreateFile = new ExpandedNodeId(Opc.Ua.Di.Methods.FileSystemLoadingType_FileSystem_CreateFile, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_DeleteFileSystemObject Method.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_DeleteFileSystemObject = new ExpandedNodeId(Opc.Ua.Di.Methods.FileSystemLoadingType_FileSystem_DeleteFileSystemObject, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_MoveOrCopy Method.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_MoveOrCopy = new ExpandedNodeId(Opc.Ua.Di.Methods.FileSystemLoadingType_FileSystem_MoveOrCopy, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_GetUpdateBehavior Method.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_GetUpdateBehavior = new ExpandedNodeId(Opc.Ua.Di.Methods.FileSystemLoadingType_GetUpdateBehavior, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_ValidateFiles Method.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_ValidateFiles = new ExpandedNodeId(Opc.Ua.Di.Methods.FileSystemLoadingType_ValidateFiles, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Prepare Method.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Prepare = new ExpandedNodeId(Opc.Ua.Di.Methods.PrepareForUpdateStateMachineType_Prepare, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Abort Method.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Abort = new ExpandedNodeId(Opc.Ua.Di.Methods.PrepareForUpdateStateMachineType_Abort, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Resume = new ExpandedNodeId(Opc.Ua.Di.Methods.PrepareForUpdateStateMachineType_Resume, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallSoftwarePackage Method.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallSoftwarePackage = new ExpandedNodeId(Opc.Ua.Di.Methods.InstallationStateMachineType_InstallSoftwarePackage, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallFiles Method.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallFiles = new ExpandedNodeId(Opc.Ua.Di.Methods.InstallationStateMachineType_InstallFiles, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Resume Method.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_Resume = new ExpandedNodeId(Opc.Ua.Di.Methods.InstallationStateMachineType_Resume, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_Confirm Method.
        /// </summary>
        public static readonly ExpandedNodeId ConfirmationStateMachineType_Confirm = new ExpandedNodeId(Opc.Ua.Di.Methods.ConfirmationStateMachineType_Confirm, Opc.Ua.Di.Namespaces.OpcUaDi);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata Object.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata = new ExpandedNodeId(Opc.Ua.Di.Objects.OPCUADINamespaceMetadata, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceSet Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceSet = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceFeatures Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceFeatures = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceFeatures, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkSet Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkSet = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceTopology, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_ParameterSet = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_ParameterSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_MethodSet = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_MethodSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_GroupIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_GroupIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_GroupIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Identification Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Identification = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_Identification, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock Object.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock = new ExpandedNodeId(Opc.Ua.Di.Objects.TopologyElementType_Lock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IDeviceHealthType_DeviceHealthAlarms Object.
        /// </summary>
        public static readonly ExpandedNodeId IDeviceHealthType_DeviceHealthAlarms = new ExpandedNodeId(Opc.Ua.Di.Objects.IDeviceHealthType_DeviceHealthAlarms, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ISupportInfoType_DeviceTypeImage Object.
        /// </summary>
        public static readonly ExpandedNodeId ISupportInfoType_DeviceTypeImage = new ExpandedNodeId(Opc.Ua.Di.Objects.ISupportInfoType_DeviceTypeImage, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ISupportInfoType_Documentation Object.
        /// </summary>
        public static readonly ExpandedNodeId ISupportInfoType_Documentation = new ExpandedNodeId(Opc.Ua.Di.Objects.ISupportInfoType_Documentation, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ISupportInfoType_ProtocolSupport Object.
        /// </summary>
        public static readonly ExpandedNodeId ISupportInfoType_ProtocolSupport = new ExpandedNodeId(Opc.Ua.Di.Objects.ISupportInfoType_ProtocolSupport, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ISupportInfoType_ImageSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ISupportInfoType_ImageSet = new ExpandedNodeId(Opc.Ua.Di.Objects.ISupportInfoType_ImageSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceType_CPIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceType_CPIdentifier_NetworkAddress, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_DeviceHealthAlarms Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_DeviceHealthAlarms = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceType_DeviceHealthAlarms, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_DeviceTypeImage Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_DeviceTypeImage = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceType_DeviceTypeImage, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Documentation Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Documentation = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceType_Documentation, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_ProtocolSupport Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_ProtocolSupport = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceType_ProtocolSupport, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_ImageSet Object.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_ImageSet = new ExpandedNodeId(Opc.Ua.Di.Objects.DeviceType_ImageSet, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfigurableObjectType_SupportedTypes Object.
        /// </summary>
        public static readonly ExpandedNodeId ConfigurableObjectType_SupportedTypes = new ExpandedNodeId(Opc.Ua.Di.Objects.ConfigurableObjectType_SupportedTypes, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfigurableObjectType_ObjectIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId ConfigurableObjectType_ObjectIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.ConfigurableObjectType_ObjectIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FunctionalGroupType_GroupIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalGroupType_GroupIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.FunctionalGroupType_GroupIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_ProfileIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_ProfileIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkType_ProfileIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkType_CPIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkType_CPIdentifier_NetworkAddress, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock Object.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock = new ExpandedNodeId(Opc.Ua.Di.Objects.NetworkType_Lock, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkAddress = new ExpandedNodeId(Opc.Ua.Di.Objects.ConnectionPointType_NetworkAddress, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_ProfileIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_ProfileIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.ConnectionPointType_ProfileIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier Object.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier = new ExpandedNodeId(Opc.Ua.Di.Objects.ConnectionPointType_NetworkIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Loading Object.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Loading = new ExpandedNodeId(Opc.Ua.Di.Objects.SoftwareUpdateType_Loading, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PrepareForUpdate Object.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_PrepareForUpdate = new ExpandedNodeId(Opc.Ua.Di.Objects.SoftwareUpdateType_PrepareForUpdate, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation Object.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Installation = new ExpandedNodeId(Opc.Ua.Di.Objects.SoftwareUpdateType_Installation, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PowerCycle Object.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_PowerCycle = new ExpandedNodeId(Opc.Ua.Di.Objects.SoftwareUpdateType_PowerCycle, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Confirmation Object.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Confirmation = new ExpandedNodeId(Opc.Ua.Di.Objects.SoftwareUpdateType_Confirmation, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters Object.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters = new ExpandedNodeId(Opc.Ua.Di.Objects.SoftwareUpdateType_Parameters, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_CurrentVersion Object.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_CurrentVersion = new ExpandedNodeId(Opc.Ua.Di.Objects.PackageLoadingType_CurrentVersion, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer Object.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer = new ExpandedNodeId(Opc.Ua.Di.Objects.PackageLoadingType_FileTransfer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_PendingVersion Object.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_PendingVersion = new ExpandedNodeId(Opc.Ua.Di.Objects.CachedLoadingType_PendingVersion, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FallbackVersion Object.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FallbackVersion = new ExpandedNodeId(Opc.Ua.Di.Objects.CachedLoadingType_FallbackVersion, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem Object.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem = new ExpandedNodeId(Opc.Ua.Di.Objects.FileSystemLoadingType_FileSystem, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Idle Object.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Idle = new ExpandedNodeId(Opc.Ua.Di.Objects.PrepareForUpdateStateMachineType_Idle, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Preparing Object.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Preparing = new ExpandedNodeId(Opc.Ua.Di.Objects.PrepareForUpdateStateMachineType_Preparing, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparedForUpdate Object.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparedForUpdate = new ExpandedNodeId(Opc.Ua.Di.Objects.PrepareForUpdateStateMachineType_PreparedForUpdate, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Resuming Object.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Resuming = new ExpandedNodeId(Opc.Ua.Di.Objects.PrepareForUpdateStateMachineType_Resuming, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_IdleToPreparing Object.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_IdleToPreparing = new ExpandedNodeId(Opc.Ua.Di.Objects.PrepareForUpdateStateMachineType_IdleToPreparing, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparingToIdle Object.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparingToIdle = new ExpandedNodeId(Opc.Ua.Di.Objects.PrepareForUpdateStateMachineType_PreparingToIdle, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate Object.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate = new ExpandedNodeId(Opc.Ua.Di.Objects.PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparedForUpdateToResuming Object.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparedForUpdateToResuming = new ExpandedNodeId(Opc.Ua.Di.Objects.PrepareForUpdateStateMachineType_PreparedForUpdateToResuming, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_ResumingToIdle Object.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_ResumingToIdle = new ExpandedNodeId(Opc.Ua.Di.Objects.PrepareForUpdateStateMachineType_ResumingToIdle, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Idle Object.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_Idle = new ExpandedNodeId(Opc.Ua.Di.Objects.InstallationStateMachineType_Idle, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Installing Object.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_Installing = new ExpandedNodeId(Opc.Ua.Di.Objects.InstallationStateMachineType_Installing, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Error Object.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_Error = new ExpandedNodeId(Opc.Ua.Di.Objects.InstallationStateMachineType_Error, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_IdleToInstalling Object.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_IdleToInstalling = new ExpandedNodeId(Opc.Ua.Di.Objects.InstallationStateMachineType_IdleToInstalling, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallingToIdle Object.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallingToIdle = new ExpandedNodeId(Opc.Ua.Di.Objects.InstallationStateMachineType_InstallingToIdle, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallingToError Object.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallingToError = new ExpandedNodeId(Opc.Ua.Di.Objects.InstallationStateMachineType_InstallingToError, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_ErrorToIdle Object.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_ErrorToIdle = new ExpandedNodeId(Opc.Ua.Di.Objects.InstallationStateMachineType_ErrorToIdle, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_NotWaitingForPowerCycle Object.
        /// </summary>
        public static readonly ExpandedNodeId PowerCycleStateMachineType_NotWaitingForPowerCycle = new ExpandedNodeId(Opc.Ua.Di.Objects.PowerCycleStateMachineType_NotWaitingForPowerCycle, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_WaitingForPowerCycle Object.
        /// </summary>
        public static readonly ExpandedNodeId PowerCycleStateMachineType_WaitingForPowerCycle = new ExpandedNodeId(Opc.Ua.Di.Objects.PowerCycleStateMachineType_WaitingForPowerCycle, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle Object.
        /// </summary>
        public static readonly ExpandedNodeId PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle = new ExpandedNodeId(Opc.Ua.Di.Objects.PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle Object.
        /// </summary>
        public static readonly ExpandedNodeId PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle = new ExpandedNodeId(Opc.Ua.Di.Objects.PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_NotWaitingForConfirm Object.
        /// </summary>
        public static readonly ExpandedNodeId ConfirmationStateMachineType_NotWaitingForConfirm = new ExpandedNodeId(Opc.Ua.Di.Objects.ConfirmationStateMachineType_NotWaitingForConfirm, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_WaitingForConfirm Object.
        /// </summary>
        public static readonly ExpandedNodeId ConfirmationStateMachineType_WaitingForConfirm = new ExpandedNodeId(Opc.Ua.Di.Objects.ConfirmationStateMachineType_WaitingForConfirm, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm Object.
        /// </summary>
        public static readonly ExpandedNodeId ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm = new ExpandedNodeId(Opc.Ua.Di.Objects.ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm Object.
        /// </summary>
        public static readonly ExpandedNodeId ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm = new ExpandedNodeId(Opc.Ua.Di.Objects.ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchResultDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId FetchResultDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.Di.Objects.FetchResultDataType_Encoding_DefaultBinary, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferResultErrorDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId TransferResultErrorDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.Di.Objects.TransferResultErrorDataType_Encoding_DefaultBinary, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferResultDataDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId TransferResultDataDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.Di.Objects.TransferResultDataDataType_Encoding_DefaultBinary, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ParameterResultDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ParameterResultDataType_Encoding_DefaultBinary = new ExpandedNodeId(Opc.Ua.Di.Objects.ParameterResultDataType_Encoding_DefaultBinary, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchResultDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId FetchResultDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.Di.Objects.FetchResultDataType_Encoding_DefaultXml, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferResultErrorDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId TransferResultErrorDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.Di.Objects.TransferResultErrorDataType_Encoding_DefaultXml, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferResultDataDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId TransferResultDataDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.Di.Objects.TransferResultDataDataType_Encoding_DefaultXml, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ParameterResultDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ParameterResultDataType_Encoding_DefaultXml = new ExpandedNodeId(Opc.Ua.Di.Objects.ParameterResultDataType_Encoding_DefaultXml, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FetchResultDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId FetchResultDataType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.Di.Objects.FetchResultDataType_Encoding_DefaultJson, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferResultErrorDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId TransferResultErrorDataType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.Di.Objects.TransferResultErrorDataType_Encoding_DefaultJson, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferResultDataDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId TransferResultDataDataType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.Di.Objects.TransferResultDataDataType_Encoding_DefaultJson, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ParameterResultDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId ParameterResultDataType_Encoding_DefaultJson = new ExpandedNodeId(Opc.Ua.Di.Objects.ParameterResultDataType_Encoding_DefaultJson, Opc.Ua.Di.Namespaces.OpcUaDi);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the TopologyElementType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.TopologyElementType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IVendorNameplateType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId IVendorNameplateType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.IVendorNameplateType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ITagNameplateType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ITagNameplateType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.ITagNameplateType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IDeviceHealthType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId IDeviceHealthType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.IDeviceHealthType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ISupportInfoType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ISupportInfoType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.ISupportInfoType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.ComponentType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.DeviceType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.SoftwareType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId BlockType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.BlockType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.DeviceHealthDiagnosticAlarmType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.FailureAlarmType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.CheckFunctionAlarmType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.OffSpecAlarmType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.MaintenanceRequiredAlarmType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfigurableObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ConfigurableObjectType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.ConfigurableObjectType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FunctionalGroupType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalGroupType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.FunctionalGroupType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ProtocolType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ProtocolType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.ProtocolType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.NetworkType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.ConnectionPointType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.TransferServicesType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.LockingServicesType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.SoftwareUpdateType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareLoadingType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareLoadingType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.SoftwareLoadingType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.PackageLoadingType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.DirectLoadingType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.CachedLoadingType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.FileSystemLoadingType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareVersionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareVersionType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.SoftwareVersionType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.PrepareForUpdateStateMachineType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.InstallationStateMachineType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PowerCycleStateMachineType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.PowerCycleStateMachineType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ConfirmationStateMachineType = new ExpandedNodeId(Opc.Ua.Di.ObjectTypes.ConfirmationStateMachineType, Opc.Ua.Di.Namespaces.OpcUaDi);
    }
    #endregion

    #region ReferenceType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ReferenceTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ReferenceTypeIds
    {
        /// <summary>
        /// The identifier for the ConnectsTo ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId ConnectsTo = new ExpandedNodeId(Opc.Ua.Di.ReferenceTypes.ConnectsTo, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectsToParent ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId ConnectsToParent = new ExpandedNodeId(Opc.Ua.Di.ReferenceTypes.ConnectsToParent, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IsOnline ReferenceType.
        /// </summary>
        public static readonly ExpandedNodeId IsOnline = new ExpandedNodeId(Opc.Ua.Di.ReferenceTypes.IsOnline, Opc.Ua.Di.Namespaces.OpcUaDi);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceUri = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceVersion = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceVersion, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespacePublicationDate Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespacePublicationDate = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespacePublicationDate, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_IsNamespaceSubset Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_IsNamespaceSubset = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_IsNamespaceSubset, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_StaticNodeIdTypes Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_StaticNodeIdTypes = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_StaticNodeIdTypes, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_StaticNumericNodeIdRange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_StaticNumericNodeIdRange = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_StaticNumericNodeIdRange, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_StaticStringNodeIdPattern Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_StaticStringNodeIdPattern = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_StaticStringNodeIdPattern, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_Size = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceFile_Size, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Writable Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_Writable = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceFile_Writable, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_UserWritable Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_UserWritable = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceFile_UserWritable, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_OpenCount = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceFile_OpenCount, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_Open_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceFile_Open_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_Open_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceFile_Open_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_Close_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceFile_Close_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_Read_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceFile_Read_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_Read_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceFile_Read_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_Write_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceFile_Write_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_GetPosition_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceFile_GetPosition_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_GetPosition_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceFile_GetPosition_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_NamespaceFile_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_NamespaceFile_SetPosition_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_NamespaceFile_SetPosition_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_DefaultRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_DefaultRolePermissions = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_DefaultRolePermissions, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_DefaultUserRolePermissions Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_DefaultUserRolePermissions = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_DefaultUserRolePermissions, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OPCUADINamespaceMetadata_DefaultAccessRestrictions Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUADINamespaceMetadata_DefaultAccessRestrictions = new ExpandedNodeId(Opc.Ua.Di.Variables.OPCUADINamespaceMetadata_DefaultAccessRestrictions, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceTopology_OnlineAccess Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceTopology_OnlineAccess = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceTopology_OnlineAccess, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_ParameterSet_ParameterIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_ParameterSet_ParameterIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_ParameterSet_ParameterIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TopologyElementType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TopologyElementType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TopologyElementType_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IVendorNameplateType_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId IVendorNameplateType_Manufacturer = new ExpandedNodeId(Opc.Ua.Di.Variables.IVendorNameplateType_Manufacturer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IVendorNameplateType_ManufacturerUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId IVendorNameplateType_ManufacturerUri = new ExpandedNodeId(Opc.Ua.Di.Variables.IVendorNameplateType_ManufacturerUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IVendorNameplateType_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId IVendorNameplateType_Model = new ExpandedNodeId(Opc.Ua.Di.Variables.IVendorNameplateType_Model, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IVendorNameplateType_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId IVendorNameplateType_HardwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.IVendorNameplateType_HardwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IVendorNameplateType_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId IVendorNameplateType_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.IVendorNameplateType_SoftwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IVendorNameplateType_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId IVendorNameplateType_DeviceRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.IVendorNameplateType_DeviceRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IVendorNameplateType_ProductCode Variable.
        /// </summary>
        public static readonly ExpandedNodeId IVendorNameplateType_ProductCode = new ExpandedNodeId(Opc.Ua.Di.Variables.IVendorNameplateType_ProductCode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IVendorNameplateType_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId IVendorNameplateType_DeviceManual = new ExpandedNodeId(Opc.Ua.Di.Variables.IVendorNameplateType_DeviceManual, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IVendorNameplateType_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId IVendorNameplateType_DeviceClass = new ExpandedNodeId(Opc.Ua.Di.Variables.IVendorNameplateType_DeviceClass, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IVendorNameplateType_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId IVendorNameplateType_SerialNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.IVendorNameplateType_SerialNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IVendorNameplateType_ProductInstanceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId IVendorNameplateType_ProductInstanceUri = new ExpandedNodeId(Opc.Ua.Di.Variables.IVendorNameplateType_ProductInstanceUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IVendorNameplateType_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId IVendorNameplateType_RevisionCounter = new ExpandedNodeId(Opc.Ua.Di.Variables.IVendorNameplateType_RevisionCounter, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ITagNameplateType_AssetId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ITagNameplateType_AssetId = new ExpandedNodeId(Opc.Ua.Di.Variables.ITagNameplateType_AssetId, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ITagNameplateType_ComponentName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ITagNameplateType_ComponentName = new ExpandedNodeId(Opc.Ua.Di.Variables.ITagNameplateType_ComponentName, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the IDeviceHealthType_DeviceHealth Variable.
        /// </summary>
        public static readonly ExpandedNodeId IDeviceHealthType_DeviceHealth = new ExpandedNodeId(Opc.Ua.Di.Variables.IDeviceHealthType_DeviceHealth, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ISupportInfoType_DeviceTypeImage_ImageIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISupportInfoType_DeviceTypeImage_ImageIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.ISupportInfoType_DeviceTypeImage_ImageIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ISupportInfoType_Documentation_DocumentIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISupportInfoType_Documentation_DocumentIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.ISupportInfoType_Documentation_DocumentIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ISupportInfoType_ProtocolSupport_ProtocolSupportIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISupportInfoType_ProtocolSupport_ProtocolSupportIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.ISupportInfoType_ProtocolSupport_ProtocolSupportIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ISupportInfoType_ImageSet_ImageIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId ISupportInfoType_ImageSet_ImageIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.ISupportInfoType_ImageSet_ImageIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_Lock_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Manufacturer = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_Manufacturer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_ManufacturerUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_ManufacturerUri = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_ManufacturerUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_Model = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_Model, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_HardwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_HardwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_SoftwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_DeviceRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_DeviceRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_ProductCode Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_ProductCode = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_ProductCode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_DeviceManual = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_DeviceManual, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_DeviceClass = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_DeviceClass, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_SerialNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_SerialNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_ProductInstanceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_ProductInstanceUri = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_ProductInstanceUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_RevisionCounter = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_RevisionCounter, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_AssetId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_AssetId = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_AssetId, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ComponentType_ComponentName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ComponentType_ComponentName = new ExpandedNodeId(Opc.Ua.Di.Variables.ComponentType_ComponentName, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Lock_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Manufacturer = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Manufacturer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_ManufacturerUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_ManufacturerUri = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_ManufacturerUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Model = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Model, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_HardwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_HardwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_SoftwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_DeviceRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_DeviceRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_ProductCode Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_ProductCode = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_ProductCode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_DeviceManual = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_DeviceManual, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_DeviceClass = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_DeviceClass, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_SerialNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_SerialNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_ProductInstanceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_ProductInstanceUri = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_ProductInstanceUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_RevisionCounter = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_RevisionCounter, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_CPIdentifier_Lock_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_DeviceHealth Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_DeviceHealth = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_DeviceHealth, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_DeviceTypeImage_ImageIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_DeviceTypeImage_ImageIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_DeviceTypeImage_ImageIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_Documentation_DocumentIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_Documentation_DocumentIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_Documentation_DocumentIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_ProtocolSupport_ProtocolSupportIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_ProtocolSupport_ProtocolSupportIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_ProtocolSupport_ProtocolSupportIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceType_ImageSet_ImageIdentifier Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceType_ImageSet_ImageIdentifier = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceType_ImageSet_ImageIdentifier, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareType_Lock_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareType_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareType_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareType_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareType_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareType_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareType_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareType_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareType_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Manufacturer = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareType_Manufacturer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_Model = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareType_Model, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareType_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareType_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareType_SoftwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_Lock_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_RevisionCounter = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_RevisionCounter, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_ActualMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_ActualMode = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_ActualMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_PermittedMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_PermittedMode = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_PermittedMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_NormalMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_NormalMode = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_NormalMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the BlockType_TargetMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlockType_TargetMode = new ExpandedNodeId(Opc.Ua.Di.Variables.BlockType_TargetMode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_EnabledState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_Quality_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_LastSeverity_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_Comment_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_AddComment_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_ConditionRefresh_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_ConditionRefresh2_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_AckedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_AckedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_ConfirmedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_ConfirmedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_Acknowledge_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_Confirm_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_Confirm_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_ActiveState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_SuppressedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_SuppressedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_OutOfServiceState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_OutOfServiceState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_ShelvingState_CurrentState = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_ShelvingState_CurrentState, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_ShelvingState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_ShelvingState_CurrentState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_ShelvingState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_ShelvingState_LastTransition_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_ShelvingState_UnshelveTime = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_ShelvingState_UnshelveTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_ShelvingState_TimedShelve_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_SilenceState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_SilenceState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthDiagnosticAlarmType_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthDiagnosticAlarmType_LatchedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthDiagnosticAlarmType_LatchedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_EnabledState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_Quality_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_LastSeverity_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_Comment_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_AddComment_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_ConditionRefresh_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_ConditionRefresh2_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_AckedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_AckedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_ConfirmedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_ConfirmedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_Acknowledge_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_Confirm_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_Confirm_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_ActiveState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_SuppressedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_SuppressedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_OutOfServiceState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_OutOfServiceState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_ShelvingState_CurrentState = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_ShelvingState_CurrentState, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_ShelvingState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_ShelvingState_CurrentState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_ShelvingState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_ShelvingState_LastTransition_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_ShelvingState_UnshelveTime = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_ShelvingState_UnshelveTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_ShelvingState_TimedShelve_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_SilenceState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_SilenceState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FailureAlarmType_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FailureAlarmType_LatchedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.FailureAlarmType_LatchedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_EnabledState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_Quality_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_LastSeverity_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_Comment_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_AddComment_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_ConditionRefresh_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_ConditionRefresh2_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_AckedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_AckedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_ConfirmedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_ConfirmedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_Acknowledge_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_Confirm_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_Confirm_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_ActiveState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_SuppressedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_SuppressedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_OutOfServiceState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_OutOfServiceState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_ShelvingState_CurrentState = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_ShelvingState_CurrentState, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_ShelvingState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_ShelvingState_CurrentState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_ShelvingState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_ShelvingState_LastTransition_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_ShelvingState_UnshelveTime = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_ShelvingState_UnshelveTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_ShelvingState_TimedShelve_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_SilenceState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_SilenceState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CheckFunctionAlarmType_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CheckFunctionAlarmType_LatchedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.CheckFunctionAlarmType_LatchedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_EnabledState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_Quality_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_LastSeverity_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_Comment_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_AddComment_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_ConditionRefresh_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_ConditionRefresh2_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_AckedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_AckedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_ConfirmedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_ConfirmedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_Acknowledge_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_Confirm_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_Confirm_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_ActiveState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_SuppressedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_SuppressedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_OutOfServiceState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_OutOfServiceState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_ShelvingState_CurrentState = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_ShelvingState_CurrentState, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_ShelvingState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_ShelvingState_CurrentState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_ShelvingState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_ShelvingState_LastTransition_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_ShelvingState_UnshelveTime = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_ShelvingState_UnshelveTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_ShelvingState_TimedShelve_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_SilenceState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_SilenceState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OffSpecAlarmType_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId OffSpecAlarmType_LatchedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.OffSpecAlarmType_LatchedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_EnabledState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_EnabledState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_Quality_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_Quality_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_LastSeverity_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_LastSeverity_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_Comment_SourceTimestamp = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_Comment_SourceTimestamp, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_AddComment_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_AddComment_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_ConditionRefresh_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_ConditionRefresh_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_ConditionRefresh2_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_ConditionRefresh2_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_AckedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_AckedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_ConfirmedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_ConfirmedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_Acknowledge_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_Acknowledge_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_Confirm_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_Confirm_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_ActiveState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_ActiveState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_SuppressedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_SuppressedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_OutOfServiceState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_OutOfServiceState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_ShelvingState_CurrentState = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_ShelvingState_CurrentState, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_ShelvingState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_ShelvingState_CurrentState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_ShelvingState_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_ShelvingState_LastTransition_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_ShelvingState_UnshelveTime = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_ShelvingState_UnshelveTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_ShelvingState_TimedShelve_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_SilenceState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_SilenceState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaintenanceRequiredAlarmType_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaintenanceRequiredAlarmType_LatchedState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.MaintenanceRequiredAlarmType_LatchedState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FunctionalGroupType_GroupIdentifier_UIElement Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalGroupType_GroupIdentifier_UIElement = new ExpandedNodeId(Opc.Ua.Di.Variables.FunctionalGroupType_GroupIdentifier_UIElement, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FunctionalGroupType_UIElement Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalGroupType_UIElement = new ExpandedNodeId(Opc.Ua.Di.Variables.FunctionalGroupType_UIElement, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DeviceHealthEnumeration_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceHealthEnumeration_EnumStrings = new ExpandedNodeId(Opc.Ua.Di.Variables.DeviceHealthEnumeration_EnumStrings, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_Lock_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the NetworkType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId NetworkType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.NetworkType_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_Lock_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.ConnectionPointType_NetworkIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_TransferToDevice_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_TransferToDevice_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TransferServicesType_TransferToDevice_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_TransferFromDevice_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_TransferFromDevice_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TransferServicesType_TransferFromDevice_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_FetchTransferResultData_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_FetchTransferResultData_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TransferServicesType_FetchTransferResultData_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the TransferServicesType_FetchTransferResultData_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TransferServicesType_FetchTransferResultData_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.TransferServicesType_FetchTransferResultData_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the MaxInactiveLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MaxInactiveLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.MaxInactiveLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_DefaultInstanceBrowseName Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_DefaultInstanceBrowseName, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_Locked = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_Locked, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_LockingClient = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_LockingClient, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_LockingUser = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_LockingUser, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_RemainingLockTime, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_InitLock_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_InitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_RenewLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_ExitLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the LockingServicesType_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LockingServicesType_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.LockingServicesType_BreakLock_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PrepareForUpdate_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_PrepareForUpdate_CurrentState = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_PrepareForUpdate_CurrentState, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PrepareForUpdate_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_PrepareForUpdate_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_PrepareForUpdate_CurrentState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PrepareForUpdate_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_PrepareForUpdate_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_PrepareForUpdate_LastTransition_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Installation_CurrentState = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Installation_CurrentState, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Installation_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Installation_CurrentState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Installation_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Installation_LastTransition_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation_InstallSoftwarePackage_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Installation_InstallSoftwarePackage_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Installation_InstallSoftwarePackage_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Installation_InstallFiles_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Installation_InstallFiles_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Installation_InstallFiles_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PowerCycle_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_PowerCycle_CurrentState = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_PowerCycle_CurrentState, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PowerCycle_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_PowerCycle_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_PowerCycle_CurrentState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_PowerCycle_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_PowerCycle_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_PowerCycle_LastTransition_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Confirmation_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Confirmation_CurrentState = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Confirmation_CurrentState, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Confirmation_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Confirmation_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Confirmation_CurrentState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Confirmation_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Confirmation_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Confirmation_LastTransition_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Confirmation_ConfirmationTimeout Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Confirmation_ConfirmationTimeout = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Confirmation_ConfirmationTimeout, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_ClientProcessingTimeout Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_ClientProcessingTimeout = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Parameters_ClientProcessingTimeout, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_GenerateFileForRead_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_GenerateFileForRead_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Parameters_GenerateFileForRead_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_GenerateFileForRead_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_GenerateFileForRead_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Parameters_GenerateFileForRead_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_GenerateFileForWrite_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_GenerateFileForWrite_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Parameters_GenerateFileForWrite_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_GenerateFileForWrite_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_GenerateFileForWrite_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Parameters_GenerateFileForWrite_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_CloseAndCommit_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_CloseAndCommit_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Parameters_CloseAndCommit_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_Parameters_CloseAndCommit_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_Parameters_CloseAndCommit_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_Parameters_CloseAndCommit_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_UpdateStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_UpdateStatus = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_UpdateStatus, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_VendorErrorCode Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_VendorErrorCode = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_VendorErrorCode, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareUpdateType_DefaultInstanceBrowseName Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareUpdateType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareUpdateType_DefaultInstanceBrowseName, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareLoadingType_UpdateKey Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareLoadingType_UpdateKey = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareLoadingType_UpdateKey, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_CurrentVersion_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_CurrentVersion_Manufacturer = new ExpandedNodeId(Opc.Ua.Di.Variables.PackageLoadingType_CurrentVersion_Manufacturer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_CurrentVersion_ManufacturerUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_CurrentVersion_ManufacturerUri = new ExpandedNodeId(Opc.Ua.Di.Variables.PackageLoadingType_CurrentVersion_ManufacturerUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_CurrentVersion_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_CurrentVersion_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.PackageLoadingType_CurrentVersion_SoftwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_ClientProcessingTimeout Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_ClientProcessingTimeout = new ExpandedNodeId(Opc.Ua.Di.Variables.PackageLoadingType_FileTransfer_ClientProcessingTimeout, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_GenerateFileForRead_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_GenerateFileForRead_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.PackageLoadingType_FileTransfer_GenerateFileForRead_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_GenerateFileForRead_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_GenerateFileForRead_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.PackageLoadingType_FileTransfer_GenerateFileForRead_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_GenerateFileForWrite_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_GenerateFileForWrite_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.PackageLoadingType_FileTransfer_GenerateFileForWrite_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.PackageLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_CloseAndCommit_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_CloseAndCommit_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.PackageLoadingType_FileTransfer_CloseAndCommit_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_FileTransfer_CloseAndCommit_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_FileTransfer_CloseAndCommit_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.PackageLoadingType_FileTransfer_CloseAndCommit_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_ErrorMessage Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_ErrorMessage = new ExpandedNodeId(Opc.Ua.Di.Variables.PackageLoadingType_ErrorMessage, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PackageLoadingType_WriteBlockSize Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackageLoadingType_WriteBlockSize = new ExpandedNodeId(Opc.Ua.Di.Variables.PackageLoadingType_WriteBlockSize, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_CurrentVersion_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_CurrentVersion_Manufacturer = new ExpandedNodeId(Opc.Ua.Di.Variables.DirectLoadingType_CurrentVersion_Manufacturer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_CurrentVersion_ManufacturerUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_CurrentVersion_ManufacturerUri = new ExpandedNodeId(Opc.Ua.Di.Variables.DirectLoadingType_CurrentVersion_ManufacturerUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_CurrentVersion_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_CurrentVersion_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.DirectLoadingType_CurrentVersion_SoftwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_ClientProcessingTimeout Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_ClientProcessingTimeout = new ExpandedNodeId(Opc.Ua.Di.Variables.DirectLoadingType_FileTransfer_ClientProcessingTimeout, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_GenerateFileForRead_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_GenerateFileForRead_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DirectLoadingType_FileTransfer_GenerateFileForRead_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_GenerateFileForRead_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_GenerateFileForRead_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DirectLoadingType_FileTransfer_GenerateFileForRead_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_GenerateFileForWrite_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_GenerateFileForWrite_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DirectLoadingType_FileTransfer_GenerateFileForWrite_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DirectLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_CloseAndCommit_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_CloseAndCommit_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DirectLoadingType_FileTransfer_CloseAndCommit_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_FileTransfer_CloseAndCommit_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_FileTransfer_CloseAndCommit_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.DirectLoadingType_FileTransfer_CloseAndCommit_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_UpdateBehavior Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_UpdateBehavior = new ExpandedNodeId(Opc.Ua.Di.Variables.DirectLoadingType_UpdateBehavior, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the DirectLoadingType_WriteTimeout Variable.
        /// </summary>
        public static readonly ExpandedNodeId DirectLoadingType_WriteTimeout = new ExpandedNodeId(Opc.Ua.Di.Variables.DirectLoadingType_WriteTimeout, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_CurrentVersion_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_CurrentVersion_Manufacturer = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_CurrentVersion_Manufacturer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_CurrentVersion_ManufacturerUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_CurrentVersion_ManufacturerUri = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_CurrentVersion_ManufacturerUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_CurrentVersion_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_CurrentVersion_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_CurrentVersion_SoftwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_ClientProcessingTimeout Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_ClientProcessingTimeout = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_FileTransfer_ClientProcessingTimeout, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_GenerateFileForRead_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_GenerateFileForRead_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_FileTransfer_GenerateFileForRead_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_GenerateFileForRead_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_GenerateFileForRead_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_FileTransfer_GenerateFileForRead_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_GenerateFileForWrite_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_GenerateFileForWrite_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_FileTransfer_GenerateFileForWrite_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_FileTransfer_GenerateFileForWrite_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_CloseAndCommit_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_CloseAndCommit_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_FileTransfer_CloseAndCommit_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FileTransfer_CloseAndCommit_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FileTransfer_CloseAndCommit_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_FileTransfer_CloseAndCommit_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_PendingVersion_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_PendingVersion_Manufacturer = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_PendingVersion_Manufacturer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_PendingVersion_ManufacturerUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_PendingVersion_ManufacturerUri = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_PendingVersion_ManufacturerUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_PendingVersion_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_PendingVersion_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_PendingVersion_SoftwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FallbackVersion_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FallbackVersion_Manufacturer = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_FallbackVersion_Manufacturer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FallbackVersion_ManufacturerUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FallbackVersion_ManufacturerUri = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_FallbackVersion_ManufacturerUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_FallbackVersion_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_FallbackVersion_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_FallbackVersion_SoftwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_GetUpdateBehavior_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_GetUpdateBehavior_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_GetUpdateBehavior_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the CachedLoadingType_GetUpdateBehavior_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CachedLoadingType_GetUpdateBehavior_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.CachedLoadingType_GetUpdateBehavior_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_CreateDirectory_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_CreateDirectory_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FileSystemLoadingType_FileSystem_CreateDirectory_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_CreateDirectory_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_CreateDirectory_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FileSystemLoadingType_FileSystem_CreateDirectory_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_CreateFile_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_CreateFile_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FileSystemLoadingType_FileSystem_CreateFile_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_CreateFile_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_CreateFile_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FileSystemLoadingType_FileSystem_CreateFile_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_DeleteFileSystemObject_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_DeleteFileSystemObject_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FileSystemLoadingType_FileSystem_DeleteFileSystemObject_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_MoveOrCopy_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_MoveOrCopy_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FileSystemLoadingType_FileSystem_MoveOrCopy_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_FileSystem_MoveOrCopy_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_FileSystem_MoveOrCopy_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FileSystemLoadingType_FileSystem_MoveOrCopy_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_GetUpdateBehavior_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_GetUpdateBehavior_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FileSystemLoadingType_GetUpdateBehavior_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_GetUpdateBehavior_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_GetUpdateBehavior_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FileSystemLoadingType_GetUpdateBehavior_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_ValidateFiles_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_ValidateFiles_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FileSystemLoadingType_ValidateFiles_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the FileSystemLoadingType_ValidateFiles_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FileSystemLoadingType_ValidateFiles_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.FileSystemLoadingType_ValidateFiles_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareVersionType_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareVersionType_Manufacturer = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareVersionType_Manufacturer, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareVersionType_ManufacturerUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareVersionType_ManufacturerUri = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareVersionType_ManufacturerUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareVersionType_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareVersionType_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareVersionType_SoftwareRevision, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareVersionType_PatchIdentifiers Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareVersionType_PatchIdentifiers = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareVersionType_PatchIdentifiers, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareVersionType_ReleaseDate Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareVersionType_ReleaseDate = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareVersionType_ReleaseDate, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareVersionType_ChangeLogReference Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareVersionType_ChangeLogReference = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareVersionType_ChangeLogReference, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareVersionType_Hash Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareVersionType_Hash = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareVersionType_Hash, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.PrepareForUpdateStateMachineType_CurrentState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.PrepareForUpdateStateMachineType_LastTransition_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PercentComplete Variable.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PercentComplete = new ExpandedNodeId(Opc.Ua.Di.Variables.PrepareForUpdateStateMachineType_PercentComplete, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Idle_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Idle_StateNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.PrepareForUpdateStateMachineType_Idle_StateNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Preparing_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Preparing_StateNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.PrepareForUpdateStateMachineType_Preparing_StateNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparedForUpdate_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparedForUpdate_StateNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.PrepareForUpdateStateMachineType_PreparedForUpdate_StateNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_Resuming_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_Resuming_StateNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.PrepareForUpdateStateMachineType_Resuming_StateNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_IdleToPreparing_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_IdleToPreparing_TransitionNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.PrepareForUpdateStateMachineType_IdleToPreparing_TransitionNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparingToIdle_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparingToIdle_TransitionNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.PrepareForUpdateStateMachineType_PreparingToIdle_TransitionNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate_TransitionNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.PrepareForUpdateStateMachineType_PreparingToPreparedForUpdate_TransitionNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_PreparedForUpdateToResuming_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_PreparedForUpdateToResuming_TransitionNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.PrepareForUpdateStateMachineType_PreparedForUpdateToResuming_TransitionNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PrepareForUpdateStateMachineType_ResumingToIdle_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PrepareForUpdateStateMachineType_ResumingToIdle_TransitionNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.PrepareForUpdateStateMachineType_ResumingToIdle_TransitionNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_CurrentState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_LastTransition_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_PercentComplete Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_PercentComplete = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_PercentComplete, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallationDelay Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallationDelay = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_InstallationDelay, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallSoftwarePackage_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallSoftwarePackage_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_InstallSoftwarePackage_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallSoftwarePackage_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallSoftwarePackage_OutputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_InstallSoftwarePackage_OutputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallFiles_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallFiles_InputArguments = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_InstallFiles_InputArguments, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Idle_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_Idle_StateNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_Idle_StateNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Installing_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_Installing_StateNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_Installing_StateNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_Error_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_Error_StateNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_Error_StateNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_IdleToInstalling_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_IdleToInstalling_TransitionNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_IdleToInstalling_TransitionNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallingToIdle_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallingToIdle_TransitionNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_InstallingToIdle_TransitionNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_InstallingToError_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_InstallingToError_TransitionNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_InstallingToError_TransitionNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the InstallationStateMachineType_ErrorToIdle_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId InstallationStateMachineType_ErrorToIdle_TransitionNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.InstallationStateMachineType_ErrorToIdle_TransitionNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PowerCycleStateMachineType_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.PowerCycleStateMachineType_CurrentState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId PowerCycleStateMachineType_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.PowerCycleStateMachineType_LastTransition_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_NotWaitingForPowerCycle_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PowerCycleStateMachineType_NotWaitingForPowerCycle_StateNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.PowerCycleStateMachineType_NotWaitingForPowerCycle_StateNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_WaitingForPowerCycle_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PowerCycleStateMachineType_WaitingForPowerCycle_StateNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.PowerCycleStateMachineType_WaitingForPowerCycle_StateNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle_TransitionNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.PowerCycleStateMachineType_NotWaitingForPowerCycleToWaitingForPowerCycle_TransitionNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle_TransitionNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.PowerCycleStateMachineType_WaitingForPowerCycleToNotWaitingForPowerCycle_TransitionNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConfirmationStateMachineType_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.ConfirmationStateMachineType_CurrentState_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConfirmationStateMachineType_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Di.Variables.ConfirmationStateMachineType_LastTransition_Id, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_ConfirmationTimeout Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConfirmationStateMachineType_ConfirmationTimeout = new ExpandedNodeId(Opc.Ua.Di.Variables.ConfirmationStateMachineType_ConfirmationTimeout, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_NotWaitingForConfirm_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConfirmationStateMachineType_NotWaitingForConfirm_StateNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.ConfirmationStateMachineType_NotWaitingForConfirm_StateNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_WaitingForConfirm_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConfirmationStateMachineType_WaitingForConfirm_StateNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.ConfirmationStateMachineType_WaitingForConfirm_StateNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm_TransitionNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.ConfirmationStateMachineType_NotWaitingForConfirmToWaitingForConfirm_TransitionNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm_TransitionNumber = new ExpandedNodeId(Opc.Ua.Di.Variables.ConfirmationStateMachineType_WaitingForConfirmToNotWaitingForConfirm_TransitionNumber, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the SoftwareVersionFileType_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId SoftwareVersionFileType_EnumStrings = new ExpandedNodeId(Opc.Ua.Di.Variables.SoftwareVersionFileType_EnumStrings, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the UpdateBehavior_OptionSetValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId UpdateBehavior_OptionSetValues = new ExpandedNodeId(Opc.Ua.Di.Variables.UpdateBehavior_OptionSetValues, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_NamespaceUri = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_NamespaceUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_Deprecated = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_Deprecated, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_FetchResultDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_FetchResultDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_FetchResultDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_TransferResultErrorDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_TransferResultErrorDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_TransferResultErrorDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_TransferResultDataDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_TransferResultDataDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_TransferResultDataDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_BinarySchema_ParameterResultDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_BinarySchema_ParameterResultDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_BinarySchema_ParameterResultDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_NamespaceUri = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_NamespaceUri, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_Deprecated = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_Deprecated, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_FetchResultDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_FetchResultDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_FetchResultDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_TransferResultErrorDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_TransferResultErrorDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_TransferResultErrorDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_TransferResultDataDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_TransferResultDataDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_TransferResultDataDataType, Opc.Ua.Di.Namespaces.OpcUaDi);

        /// <summary>
        /// The identifier for the OpcUaDi_XmlSchema_ParameterResultDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpcUaDi_XmlSchema_ParameterResultDataType = new ExpandedNodeId(Opc.Ua.Di.Variables.OpcUaDi_XmlSchema_ParameterResultDataType, Opc.Ua.Di.Namespaces.OpcUaDi);
    }
    #endregion

    #region VariableType Node Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableTypeIds
    {
        /// <summary>
        /// The identifier for the UIElementType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId UIElementType = new ExpandedNodeId(Opc.Ua.Di.VariableTypes.UIElementType, Opc.Ua.Di.Namespaces.OpcUaDi);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Abort component.
        /// </summary>
        public const string Abort = "Abort";

        /// <summary>
        /// The BrowseName for the ActualMode component.
        /// </summary>
        public const string ActualMode = "ActualMode";

        /// <summary>
        /// The BrowseName for the AssetId component.
        /// </summary>
        public const string AssetId = "AssetId";

        /// <summary>
        /// The BrowseName for the BlockType component.
        /// </summary>
        public const string BlockType = "BlockType";

        /// <summary>
        /// The BrowseName for the BreakLock component.
        /// </summary>
        public const string BreakLock = "BreakLock";

        /// <summary>
        /// The BrowseName for the CachedLoadingType component.
        /// </summary>
        public const string CachedLoadingType = "CachedLoadingType";

        /// <summary>
        /// The BrowseName for the ChangeLogReference component.
        /// </summary>
        public const string ChangeLogReference = "ChangeLogReference";

        /// <summary>
        /// The BrowseName for the CheckFunctionAlarmType component.
        /// </summary>
        public const string CheckFunctionAlarmType = "CheckFunctionAlarmType";

        /// <summary>
        /// The BrowseName for the ComponentName component.
        /// </summary>
        public const string ComponentName = "ComponentName";

        /// <summary>
        /// The BrowseName for the ComponentType component.
        /// </summary>
        public const string ComponentType = "ComponentType";

        /// <summary>
        /// The BrowseName for the ConfigurableObjectType component.
        /// </summary>
        public const string ConfigurableObjectType = "ConfigurableObjectType";

        /// <summary>
        /// The BrowseName for the Confirm component.
        /// </summary>
        public const string Confirm = "Confirm";

        /// <summary>
        /// The BrowseName for the Confirmation component.
        /// </summary>
        public const string Confirmation = "Confirmation";

        /// <summary>
        /// The BrowseName for the ConfirmationStateMachineType component.
        /// </summary>
        public const string ConfirmationStateMachineType = "ConfirmationStateMachineType";

        /// <summary>
        /// The BrowseName for the ConfirmationTimeout component.
        /// </summary>
        public const string ConfirmationTimeout = "ConfirmationTimeout";

        /// <summary>
        /// The BrowseName for the ConnectionPointType component.
        /// </summary>
        public const string ConnectionPointType = "ConnectionPointType";

        /// <summary>
        /// The BrowseName for the ConnectsTo component.
        /// </summary>
        public const string ConnectsTo = "ConnectsTo";

        /// <summary>
        /// The BrowseName for the ConnectsToParent component.
        /// </summary>
        public const string ConnectsToParent = "ConnectsToParent";

        /// <summary>
        /// The BrowseName for the CPIdentifier component.
        /// </summary>
        public const string CPIdentifier = "<CPIdentifier>";

        /// <summary>
        /// The BrowseName for the CurrentVersion component.
        /// </summary>
        public const string CurrentVersion = "CurrentVersion";

        /// <summary>
        /// The BrowseName for the DeviceClass component.
        /// </summary>
        public const string DeviceClass = "DeviceClass";

        /// <summary>
        /// The BrowseName for the DeviceFeatures component.
        /// </summary>
        public const string DeviceFeatures = "DeviceFeatures";

        /// <summary>
        /// The BrowseName for the DeviceHealth component.
        /// </summary>
        public const string DeviceHealth = "DeviceHealth";

        /// <summary>
        /// The BrowseName for the DeviceHealthAlarms component.
        /// </summary>
        public const string DeviceHealthAlarms = "DeviceHealthAlarms";

        /// <summary>
        /// The BrowseName for the DeviceHealthDiagnosticAlarmType component.
        /// </summary>
        public const string DeviceHealthDiagnosticAlarmType = "DeviceHealthDiagnosticAlarmType";

        /// <summary>
        /// The BrowseName for the DeviceHealthEnumeration component.
        /// </summary>
        public const string DeviceHealthEnumeration = "DeviceHealthEnumeration";

        /// <summary>
        /// The BrowseName for the DeviceManual component.
        /// </summary>
        public const string DeviceManual = "DeviceManual";

        /// <summary>
        /// The BrowseName for the DeviceRevision component.
        /// </summary>
        public const string DeviceRevision = "DeviceRevision";

        /// <summary>
        /// The BrowseName for the DeviceSet component.
        /// </summary>
        public const string DeviceSet = "DeviceSet";

        /// <summary>
        /// The BrowseName for the DeviceTopology component.
        /// </summary>
        public const string DeviceTopology = "DeviceTopology";

        /// <summary>
        /// The BrowseName for the DeviceType component.
        /// </summary>
        public const string DeviceType = "DeviceType";

        /// <summary>
        /// The BrowseName for the DeviceTypeImage component.
        /// </summary>
        public const string DeviceTypeImage = "DeviceTypeImage";

        /// <summary>
        /// The BrowseName for the DirectLoadingType component.
        /// </summary>
        public const string DirectLoadingType = "DirectLoadingType";

        /// <summary>
        /// The BrowseName for the Documentation component.
        /// </summary>
        public const string Documentation = "Documentation";

        /// <summary>
        /// The BrowseName for the Error component.
        /// </summary>
        public const string Error = "Error";

        /// <summary>
        /// The BrowseName for the ErrorMessage component.
        /// </summary>
        public const string ErrorMessage = "ErrorMessage";

        /// <summary>
        /// The BrowseName for the ErrorToIdle component.
        /// </summary>
        public const string ErrorToIdle = "ErrorToIdle";

        /// <summary>
        /// The BrowseName for the ExitLock component.
        /// </summary>
        public const string ExitLock = "ExitLock";

        /// <summary>
        /// The BrowseName for the FailureAlarmType component.
        /// </summary>
        public const string FailureAlarmType = "FailureAlarmType";

        /// <summary>
        /// The BrowseName for the FallbackVersion component.
        /// </summary>
        public const string FallbackVersion = "FallbackVersion";

        /// <summary>
        /// The BrowseName for the FetchResultDataType component.
        /// </summary>
        public const string FetchResultDataType = "FetchResultDataType";

        /// <summary>
        /// The BrowseName for the FetchTransferResultData component.
        /// </summary>
        public const string FetchTransferResultData = "FetchTransferResultData";

        /// <summary>
        /// The BrowseName for the FileSystemLoadingType component.
        /// </summary>
        public const string FileSystemLoadingType = "FileSystemLoadingType";

        /// <summary>
        /// The BrowseName for the FileTransfer component.
        /// </summary>
        public const string FileTransfer = "FileTransfer";

        /// <summary>
        /// The BrowseName for the FunctionalGroupType component.
        /// </summary>
        public const string FunctionalGroupType = "FunctionalGroupType";

        /// <summary>
        /// The BrowseName for the GetUpdateBehavior component.
        /// </summary>
        public const string GetUpdateBehavior = "GetUpdateBehavior";

        /// <summary>
        /// The BrowseName for the GroupIdentifier component.
        /// </summary>
        public const string GroupIdentifier = "<GroupIdentifier>";

        /// <summary>
        /// The BrowseName for the HardwareRevision component.
        /// </summary>
        public const string HardwareRevision = "HardwareRevision";

        /// <summary>
        /// The BrowseName for the Hash component.
        /// </summary>
        public const string Hash = "Hash";

        /// <summary>
        /// The BrowseName for the Identification component.
        /// </summary>
        public const string Identification = "Identification";

        /// <summary>
        /// The BrowseName for the IDeviceHealthType component.
        /// </summary>
        public const string IDeviceHealthType = "IDeviceHealthType";

        /// <summary>
        /// The BrowseName for the Idle component.
        /// </summary>
        public const string Idle = "Idle";

        /// <summary>
        /// The BrowseName for the IdleToInstalling component.
        /// </summary>
        public const string IdleToInstalling = "IdleToInstalling";

        /// <summary>
        /// The BrowseName for the IdleToPreparing component.
        /// </summary>
        public const string IdleToPreparing = "IdleToPreparing";

        /// <summary>
        /// The BrowseName for the ImageSet component.
        /// </summary>
        public const string ImageSet = "ImageSet";

        /// <summary>
        /// The BrowseName for the InitLock component.
        /// </summary>
        public const string InitLock = "InitLock";

        /// <summary>
        /// The BrowseName for the Installation component.
        /// </summary>
        public const string Installation = "Installation";

        /// <summary>
        /// The BrowseName for the InstallationDelay component.
        /// </summary>
        public const string InstallationDelay = "InstallationDelay";

        /// <summary>
        /// The BrowseName for the InstallationStateMachineType component.
        /// </summary>
        public const string InstallationStateMachineType = "InstallationStateMachineType";

        /// <summary>
        /// The BrowseName for the InstallFiles component.
        /// </summary>
        public const string InstallFiles = "InstallFiles";

        /// <summary>
        /// The BrowseName for the Installing component.
        /// </summary>
        public const string Installing = "Installing";

        /// <summary>
        /// The BrowseName for the InstallingToError component.
        /// </summary>
        public const string InstallingToError = "InstallingToError";

        /// <summary>
        /// The BrowseName for the InstallingToIdle component.
        /// </summary>
        public const string InstallingToIdle = "InstallingToIdle";

        /// <summary>
        /// The BrowseName for the InstallSoftwarePackage component.
        /// </summary>
        public const string InstallSoftwarePackage = "InstallSoftwarePackage";

        /// <summary>
        /// The BrowseName for the IsOnline component.
        /// </summary>
        public const string IsOnline = "IsOnline";

        /// <summary>
        /// The BrowseName for the ISupportInfoType component.
        /// </summary>
        public const string ISupportInfoType = "ISupportInfoType";

        /// <summary>
        /// The BrowseName for the ITagNameplateType component.
        /// </summary>
        public const string ITagNameplateType = "ITagNameplateType";

        /// <summary>
        /// The BrowseName for the IVendorNameplateType component.
        /// </summary>
        public const string IVendorNameplateType = "IVendorNameplateType";

        /// <summary>
        /// The BrowseName for the Loading component.
        /// </summary>
        public const string Loading = "Loading";

        /// <summary>
        /// The BrowseName for the Lock component.
        /// </summary>
        public const string Lock = "Lock";

        /// <summary>
        /// The BrowseName for the Locked component.
        /// </summary>
        public const string Locked = "Locked";

        /// <summary>
        /// The BrowseName for the LockingClient component.
        /// </summary>
        public const string LockingClient = "LockingClient";

        /// <summary>
        /// The BrowseName for the LockingServicesType component.
        /// </summary>
        public const string LockingServicesType = "LockingServicesType";

        /// <summary>
        /// The BrowseName for the LockingUser component.
        /// </summary>
        public const string LockingUser = "LockingUser";

        /// <summary>
        /// The BrowseName for the MaintenanceRequiredAlarmType component.
        /// </summary>
        public const string MaintenanceRequiredAlarmType = "MaintenanceRequiredAlarmType";

        /// <summary>
        /// The BrowseName for the Manufacturer component.
        /// </summary>
        public const string Manufacturer = "Manufacturer";

        /// <summary>
        /// The BrowseName for the ManufacturerUri component.
        /// </summary>
        public const string ManufacturerUri = "ManufacturerUri";

        /// <summary>
        /// The BrowseName for the MaxInactiveLockTime component.
        /// </summary>
        public const string MaxInactiveLockTime = "MaxInactiveLockTime";

        /// <summary>
        /// The BrowseName for the MethodSet component.
        /// </summary>
        public const string MethodSet = "MethodSet";

        /// <summary>
        /// The BrowseName for the Model component.
        /// </summary>
        public const string Model = "Model";

        /// <summary>
        /// The BrowseName for the NetworkAddress component.
        /// </summary>
        public const string NetworkAddress = "NetworkAddress";

        /// <summary>
        /// The BrowseName for the NetworkIdentifier component.
        /// </summary>
        public const string NetworkIdentifier = "<NetworkIdentifier>";

        /// <summary>
        /// The BrowseName for the NetworkSet component.
        /// </summary>
        public const string NetworkSet = "NetworkSet";

        /// <summary>
        /// The BrowseName for the NetworkType component.
        /// </summary>
        public const string NetworkType = "NetworkType";

        /// <summary>
        /// The BrowseName for the NormalMode component.
        /// </summary>
        public const string NormalMode = "NormalMode";

        /// <summary>
        /// The BrowseName for the NotWaitingForConfirm component.
        /// </summary>
        public const string NotWaitingForConfirm = "NotWaitingForConfirm";

        /// <summary>
        /// The BrowseName for the NotWaitingForConfirmToWaitingForConfirm component.
        /// </summary>
        public const string NotWaitingForConfirmToWaitingForConfirm = "NotWaitingForConfirmToWaitingForConfirm";

        /// <summary>
        /// The BrowseName for the NotWaitingForPowerCycle component.
        /// </summary>
        public const string NotWaitingForPowerCycle = "NotWaitingForPowerCycle";

        /// <summary>
        /// The BrowseName for the NotWaitingForPowerCycleToWaitingForPowerCycle component.
        /// </summary>
        public const string NotWaitingForPowerCycleToWaitingForPowerCycle = "NotWaitingForPowerCycleToWaitingForPowerCycle";

        /// <summary>
        /// The BrowseName for the ObjectIdentifier component.
        /// </summary>
        public const string ObjectIdentifier = "<ObjectIdentifier>";

        /// <summary>
        /// The BrowseName for the OffSpecAlarmType component.
        /// </summary>
        public const string OffSpecAlarmType = "OffSpecAlarmType";

        /// <summary>
        /// The BrowseName for the OnlineAccess component.
        /// </summary>
        public const string OnlineAccess = "OnlineAccess";

        /// <summary>
        /// The BrowseName for the OpcUaDi_BinarySchema component.
        /// </summary>
        public const string OpcUaDi_BinarySchema = "Opc.Ua.Di";

        /// <summary>
        /// The BrowseName for the OpcUaDi_XmlSchema component.
        /// </summary>
        public const string OpcUaDi_XmlSchema = "Opc.Ua.Di";

        /// <summary>
        /// The BrowseName for the OPCUADINamespaceMetadata component.
        /// </summary>
        public const string OPCUADINamespaceMetadata = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The BrowseName for the PackageLoadingType component.
        /// </summary>
        public const string PackageLoadingType = "PackageLoadingType";

        /// <summary>
        /// The BrowseName for the ParameterResultDataType component.
        /// </summary>
        public const string ParameterResultDataType = "ParameterResultDataType";

        /// <summary>
        /// The BrowseName for the Parameters component.
        /// </summary>
        public const string Parameters = "Parameters";

        /// <summary>
        /// The BrowseName for the ParameterSet component.
        /// </summary>
        public const string ParameterSet = "ParameterSet";

        /// <summary>
        /// The BrowseName for the PatchIdentifiers component.
        /// </summary>
        public const string PatchIdentifiers = "PatchIdentifiers";

        /// <summary>
        /// The BrowseName for the PendingVersion component.
        /// </summary>
        public const string PendingVersion = "PendingVersion";

        /// <summary>
        /// The BrowseName for the PercentComplete component.
        /// </summary>
        public const string PercentComplete = "PercentComplete";

        /// <summary>
        /// The BrowseName for the PermittedMode component.
        /// </summary>
        public const string PermittedMode = "PermittedMode";

        /// <summary>
        /// The BrowseName for the PowerCycle component.
        /// </summary>
        public const string PowerCycle = "PowerCycle";

        /// <summary>
        /// The BrowseName for the PowerCycleStateMachineType component.
        /// </summary>
        public const string PowerCycleStateMachineType = "PowerCycleStateMachineType";

        /// <summary>
        /// The BrowseName for the Prepare component.
        /// </summary>
        public const string Prepare = "Prepare";

        /// <summary>
        /// The BrowseName for the PreparedForUpdate component.
        /// </summary>
        public const string PreparedForUpdate = "PreparedForUpdate";

        /// <summary>
        /// The BrowseName for the PreparedForUpdateToResuming component.
        /// </summary>
        public const string PreparedForUpdateToResuming = "PreparedForUpdateToResuming";

        /// <summary>
        /// The BrowseName for the PrepareForUpdate component.
        /// </summary>
        public const string PrepareForUpdate = "PrepareForUpdate";

        /// <summary>
        /// The BrowseName for the PrepareForUpdateStateMachineType component.
        /// </summary>
        public const string PrepareForUpdateStateMachineType = "PrepareForUpdateStateMachineType";

        /// <summary>
        /// The BrowseName for the Preparing component.
        /// </summary>
        public const string Preparing = "Preparing";

        /// <summary>
        /// The BrowseName for the PreparingToIdle component.
        /// </summary>
        public const string PreparingToIdle = "PreparingToIdle";

        /// <summary>
        /// The BrowseName for the PreparingToPreparedForUpdate component.
        /// </summary>
        public const string PreparingToPreparedForUpdate = "PreparingToPreparedForUpdate";

        /// <summary>
        /// The BrowseName for the ProductCode component.
        /// </summary>
        public const string ProductCode = "ProductCode";

        /// <summary>
        /// The BrowseName for the ProductInstanceUri component.
        /// </summary>
        public const string ProductInstanceUri = "ProductInstanceUri";

        /// <summary>
        /// The BrowseName for the ProfileIdentifier component.
        /// </summary>
        public const string ProfileIdentifier = "<ProfileIdentifier>";

        /// <summary>
        /// The BrowseName for the ProtocolSupport component.
        /// </summary>
        public const string ProtocolSupport = "ProtocolSupport";

        /// <summary>
        /// The BrowseName for the ProtocolType component.
        /// </summary>
        public const string ProtocolType = "ProtocolType";

        /// <summary>
        /// The BrowseName for the ReleaseDate component.
        /// </summary>
        public const string ReleaseDate = "ReleaseDate";

        /// <summary>
        /// The BrowseName for the RemainingLockTime component.
        /// </summary>
        public const string RemainingLockTime = "RemainingLockTime";

        /// <summary>
        /// The BrowseName for the RenewLock component.
        /// </summary>
        public const string RenewLock = "RenewLock";

        /// <summary>
        /// The BrowseName for the Resume component.
        /// </summary>
        public const string Resume = "Resume";

        /// <summary>
        /// The BrowseName for the Resuming component.
        /// </summary>
        public const string Resuming = "Resuming";

        /// <summary>
        /// The BrowseName for the ResumingToIdle component.
        /// </summary>
        public const string ResumingToIdle = "ResumingToIdle";

        /// <summary>
        /// The BrowseName for the RevisionCounter component.
        /// </summary>
        public const string RevisionCounter = "RevisionCounter";

        /// <summary>
        /// The BrowseName for the SerialNumber component.
        /// </summary>
        public const string SerialNumber = "SerialNumber";

        /// <summary>
        /// The BrowseName for the SoftwareLoadingType component.
        /// </summary>
        public const string SoftwareLoadingType = "SoftwareLoadingType";

        /// <summary>
        /// The BrowseName for the SoftwareRevision component.
        /// </summary>
        public const string SoftwareRevision = "SoftwareRevision";

        /// <summary>
        /// The BrowseName for the SoftwareType component.
        /// </summary>
        public const string SoftwareType = "SoftwareType";

        /// <summary>
        /// The BrowseName for the SoftwareUpdateType component.
        /// </summary>
        public const string SoftwareUpdateType = "SoftwareUpdateType";

        /// <summary>
        /// The BrowseName for the SoftwareVersionFileType component.
        /// </summary>
        public const string SoftwareVersionFileType = "SoftwareVersionFileType";

        /// <summary>
        /// The BrowseName for the SoftwareVersionType component.
        /// </summary>
        public const string SoftwareVersionType = "SoftwareVersionType";

        /// <summary>
        /// The BrowseName for the SupportedTypes component.
        /// </summary>
        public const string SupportedTypes = "SupportedTypes";

        /// <summary>
        /// The BrowseName for the TargetMode component.
        /// </summary>
        public const string TargetMode = "TargetMode";

        /// <summary>
        /// The BrowseName for the TopologyElementType component.
        /// </summary>
        public const string TopologyElementType = "TopologyElementType";

        /// <summary>
        /// The BrowseName for the TransferFromDevice component.
        /// </summary>
        public const string TransferFromDevice = "TransferFromDevice";

        /// <summary>
        /// The BrowseName for the TransferResultDataDataType component.
        /// </summary>
        public const string TransferResultDataDataType = "TransferResultDataDataType";

        /// <summary>
        /// The BrowseName for the TransferResultErrorDataType component.
        /// </summary>
        public const string TransferResultErrorDataType = "TransferResultErrorDataType";

        /// <summary>
        /// The BrowseName for the TransferServicesType component.
        /// </summary>
        public const string TransferServicesType = "TransferServicesType";

        /// <summary>
        /// The BrowseName for the TransferToDevice component.
        /// </summary>
        public const string TransferToDevice = "TransferToDevice";

        /// <summary>
        /// The BrowseName for the UIElement component.
        /// </summary>
        public const string UIElement = "UIElement";

        /// <summary>
        /// The BrowseName for the UIElementType component.
        /// </summary>
        public const string UIElementType = "UIElementType";

        /// <summary>
        /// The BrowseName for the UpdateBehavior component.
        /// </summary>
        public const string UpdateBehavior = "UpdateBehavior";

        /// <summary>
        /// The BrowseName for the UpdateKey component.
        /// </summary>
        public const string UpdateKey = "UpdateKey";

        /// <summary>
        /// The BrowseName for the UpdateStatus component.
        /// </summary>
        public const string UpdateStatus = "UpdateStatus";

        /// <summary>
        /// The BrowseName for the ValidateFiles component.
        /// </summary>
        public const string ValidateFiles = "ValidateFiles";

        /// <summary>
        /// The BrowseName for the VendorErrorCode component.
        /// </summary>
        public const string VendorErrorCode = "VendorErrorCode";

        /// <summary>
        /// The BrowseName for the WaitingForConfirm component.
        /// </summary>
        public const string WaitingForConfirm = "WaitingForConfirm";

        /// <summary>
        /// The BrowseName for the WaitingForConfirmToNotWaitingForConfirm component.
        /// </summary>
        public const string WaitingForConfirmToNotWaitingForConfirm = "WaitingForConfirmToNotWaitingForConfirm";

        /// <summary>
        /// The BrowseName for the WaitingForPowerCycle component.
        /// </summary>
        public const string WaitingForPowerCycle = "WaitingForPowerCycle";

        /// <summary>
        /// The BrowseName for the WaitingForPowerCycleToNotWaitingForPowerCycle component.
        /// </summary>
        public const string WaitingForPowerCycleToNotWaitingForPowerCycle = "WaitingForPowerCycleToNotWaitingForPowerCycle";

        /// <summary>
        /// The BrowseName for the WriteBlockSize component.
        /// </summary>
        public const string WriteBlockSize = "WriteBlockSize";

        /// <summary>
        /// The BrowseName for the WriteTimeout component.
        /// </summary>
        public const string WriteTimeout = "WriteTimeout";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}