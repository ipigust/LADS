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
using Opc.Ua.Di;

namespace Spectaris.LADS
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the FunctionType_Lock_InitLock Method.
        /// </summary>
        public const uint FunctionType_Lock_InitLock = 14;

        /// <summary>
        /// The identifier for the FunctionType_Lock_RenewLock Method.
        /// </summary>
        public const uint FunctionType_Lock_RenewLock = 17;

        /// <summary>
        /// The identifier for the FunctionType_Lock_ExitLock Method.
        /// </summary>
        public const uint FunctionType_Lock_ExitLock = 19;

        /// <summary>
        /// The identifier for the FunctionType_Lock_BreakLock Method.
        /// </summary>
        public const uint FunctionType_Lock_BreakLock = 21;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_InitLock Method.
        /// </summary>
        public const uint BaseSensorFunctionType_Lock_InitLock = 66;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_RenewLock Method.
        /// </summary>
        public const uint BaseSensorFunctionType_Lock_RenewLock = 69;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_ExitLock Method.
        /// </summary>
        public const uint BaseSensorFunctionType_Lock_ExitLock = 71;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_BreakLock Method.
        /// </summary>
        public const uint BaseSensorFunctionType_Lock_BreakLock = 73;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_Disable = 112;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_Enable = 113;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_AddComment = 114;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_Acknowledge = 134;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve = 181;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve = 183;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve = 184;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_InitLock Method.
        /// </summary>
        public const uint AnalogSensorFunctionType_Lock_InitLock = 302;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_RenewLock Method.
        /// </summary>
        public const uint AnalogSensorFunctionType_Lock_RenewLock = 305;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_ExitLock Method.
        /// </summary>
        public const uint AnalogSensorFunctionType_Lock_ExitLock = 307;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_BreakLock Method.
        /// </summary>
        public const uint AnalogSensorFunctionType_Lock_BreakLock = 309;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_Disable = 348;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_Enable = 349;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_AddComment = 350;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_Acknowledge = 370;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve = 417;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve = 419;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve = 420;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_InitLock Method.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_Lock_InitLock = 517;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_RenewLock Method.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_Lock_RenewLock = 520;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_ExitLock Method.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_Lock_ExitLock = 522;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_BreakLock Method.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_Lock_BreakLock = 524;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_Disable = 563;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_Enable = 564;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_AddComment = 565;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge = 585;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_TimedShelve = 632;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_Unshelve = 634;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_OneShotShelve = 635;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_InitLock Method.
        /// </summary>
        public const uint FunctionalUnitType_Lock_InitLock = 41;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_RenewLock Method.
        /// </summary>
        public const uint FunctionalUnitType_Lock_RenewLock = 44;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_ExitLock Method.
        /// </summary>
        public const uint FunctionalUnitType_Lock_ExitLock = 46;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_BreakLock Method.
        /// </summary>
        public const uint FunctionalUnitType_Lock_BreakLock = 48;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_InitLock Method.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Lock_InitLock = 735;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_RenewLock Method.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Lock_RenewLock = 738;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_ExitLock Method.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Lock_ExitLock = 740;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_BreakLock Method.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Lock_BreakLock = 742;

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_InitLock Method.
        /// </summary>
        public const uint ProgramManagerType_Lock_InitLock = 805;

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_RenewLock Method.
        /// </summary>
        public const uint ProgramManagerType_Lock_RenewLock = 808;

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_ExitLock Method.
        /// </summary>
        public const uint ProgramManagerType_Lock_ExitLock = 810;

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_BreakLock Method.
        /// </summary>
        public const uint ProgramManagerType_Lock_BreakLock = 812;

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_InitLock Method.
        /// </summary>
        public const uint LADSComponentType_Lock_InitLock = 919;

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_RenewLock Method.
        /// </summary>
        public const uint LADSComponentType_Lock_RenewLock = 922;

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_ExitLock Method.
        /// </summary>
        public const uint LADSComponentType_Lock_ExitLock = 924;

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_BreakLock Method.
        /// </summary>
        public const uint LADSComponentType_Lock_BreakLock = 926;

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint LADSDeviceType_Lock_InitLock = 962;

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint LADSDeviceType_Lock_RenewLock = 965;

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint LADSDeviceType_Lock_ExitLock = 967;

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint LADSDeviceType_Lock_BreakLock = 969;
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
        /// The identifier for the FunctionType_ParameterSet Object.
        /// </summary>
        public const uint FunctionType_ParameterSet = 2;

        /// <summary>
        /// The identifier for the FunctionType_Configuration Object.
        /// </summary>
        public const uint FunctionType_Configuration = 23;

        /// <summary>
        /// The identifier for the FunctionType_FunctionSet Object.
        /// </summary>
        public const uint FunctionType_FunctionSet = 25;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_ParameterSet Object.
        /// </summary>
        public const uint BaseSensorFunctionType_ParameterSet = 54;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor Object.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor = 79;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_LimitState = 230;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Operational Object.
        /// </summary>
        public const uint BaseSensorFunctionType_Operational = 253;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Tuning Object.
        /// </summary>
        public const uint BaseSensorFunctionType_Tuning = 263;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_ParameterSet Object.
        /// </summary>
        public const uint AnalogSensorFunctionType_ParameterSet = 290;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_LimitState = 466;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_ParameterSet Object.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_ParameterSet = 505;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState = 681;

        /// <summary>
        /// The identifier for the FunctionalUnitType_MethodSet Object.
        /// </summary>
        public const uint FunctionalUnitType_MethodSet = 31;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Identification Object.
        /// </summary>
        public const uint FunctionalUnitType_Identification = 34;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock Object.
        /// </summary>
        public const uint FunctionalUnitType_Lock = 36;

        /// <summary>
        /// The identifier for the FunctionalUnitType_FunctionSet Object.
        /// </summary>
        public const uint FunctionalUnitType_FunctionSet = 721;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Operational Object.
        /// </summary>
        public const uint FunctionalUnitType_Operational = 722;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager Object.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager = 724;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram Object.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram = 744;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Operational Object.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Operational = 758;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ProgramTemplateSet Object.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ProgramTemplateSet = 760;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ResultSet Object.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ResultSet = 762;

        /// <summary>
        /// The identifier for the FunctionalUnitType_SupportedPropertySet Object.
        /// </summary>
        public const uint FunctionalUnitType_SupportedPropertySet = 764;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram Object.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram = 814;

        /// <summary>
        /// The identifier for the ProgramManagerType_Operational Object.
        /// </summary>
        public const uint ProgramManagerType_Operational = 828;

        /// <summary>
        /// The identifier for the ProgramManagerType_ProgramTemplateSet Object.
        /// </summary>
        public const uint ProgramManagerType_ProgramTemplateSet = 830;

        /// <summary>
        /// The identifier for the ProgramManagerType_ResultSet Object.
        /// </summary>
        public const uint ProgramManagerType_ResultSet = 832;

        /// <summary>
        /// The identifier for the LADSComponentType_ComponentSet Object.
        /// </summary>
        public const uint LADSComponentType_ComponentSet = 942;

        /// <summary>
        /// The identifier for the LADSComponentType_Maintenance Object.
        /// </summary>
        public const uint LADSComponentType_Maintenance = 945;

        /// <summary>
        /// The identifier for the LADSDeviceType_ComponentSet Object.
        /// </summary>
        public const uint LADSDeviceType_ComponentSet = 985;

        /// <summary>
        /// The identifier for the LADSDeviceType_FunctionalUnitSet Object.
        /// </summary>
        public const uint LADSDeviceType_FunctionalUnitSet = 986;
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
        /// The identifier for the FunctionType ObjectType.
        /// </summary>
        public const uint FunctionType = 1;

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType ObjectType.
        /// </summary>
        public const uint BaseSensorFunctionOperationalType = 1076;

        /// <summary>
        /// The identifier for the BaseSensorFunctionParameterSetType ObjectType.
        /// </summary>
        public const uint BaseSensorFunctionParameterSetType = 244;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType ObjectType.
        /// </summary>
        public const uint BaseSensorFunctionType = 53;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType ObjectType.
        /// </summary>
        public const uint AnalogSensorFunctionType = 289;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType ObjectType.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType = 504;

        /// <summary>
        /// The identifier for the FunctionSetType ObjectType.
        /// </summary>
        public const uint FunctionSetType = 27;

        /// <summary>
        /// The identifier for the SupportedPropertySetType ObjectType.
        /// </summary>
        public const uint SupportedPropertySetType = 719;

        /// <summary>
        /// The identifier for the FunctionalUnitType ObjectType.
        /// </summary>
        public const uint FunctionalUnitType = 28;

        /// <summary>
        /// The identifier for the FunctionalUnitSetType ObjectType.
        /// </summary>
        public const uint FunctionalUnitSetType = 51;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType ObjectType.
        /// </summary>
        public const uint LADSBaseStateMachineType = 765;

        /// <summary>
        /// The identifier for the ProgramTemplateType ObjectType.
        /// </summary>
        public const uint ProgramTemplateType = 779;

        /// <summary>
        /// The identifier for the ProgramTemplateSetType ObjectType.
        /// </summary>
        public const uint ProgramTemplateSetType = 788;

        /// <summary>
        /// The identifier for the ResultSetType ObjectType.
        /// </summary>
        public const uint ResultSetType = 790;

        /// <summary>
        /// The identifier for the ProgramManagerType ObjectType.
        /// </summary>
        public const uint ProgramManagerType = 792;

        /// <summary>
        /// The identifier for the LADSComponentType ObjectType.
        /// </summary>
        public const uint LADSComponentType = 906;

        /// <summary>
        /// The identifier for the ComponentSetType ObjectType.
        /// </summary>
        public const uint ComponentSetType = 943;

        /// <summary>
        /// The identifier for the LADSDeviceType ObjectType.
        /// </summary>
        public const uint LADSDeviceType = 949;
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
        /// The identifier for the FunctionType_Lock_Locked Variable.
        /// </summary>
        public const uint FunctionType_Lock_Locked = 10;

        /// <summary>
        /// The identifier for the FunctionType_Lock_LockingClient Variable.
        /// </summary>
        public const uint FunctionType_Lock_LockingClient = 11;

        /// <summary>
        /// The identifier for the FunctionType_Lock_LockingUser Variable.
        /// </summary>
        public const uint FunctionType_Lock_LockingUser = 12;

        /// <summary>
        /// The identifier for the FunctionType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FunctionType_Lock_RemainingLockTime = 13;

        /// <summary>
        /// The identifier for the FunctionType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FunctionType_Lock_InitLock_InputArguments = 15;

        /// <summary>
        /// The identifier for the FunctionType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FunctionType_Lock_InitLock_OutputArguments = 16;

        /// <summary>
        /// The identifier for the FunctionType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FunctionType_Lock_RenewLock_OutputArguments = 18;

        /// <summary>
        /// The identifier for the FunctionType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FunctionType_Lock_ExitLock_OutputArguments = 20;

        /// <summary>
        /// The identifier for the FunctionType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FunctionType_Lock_BreakLock_OutputArguments = 22;

        /// <summary>
        /// The identifier for the FunctionType_Enabled Variable.
        /// </summary>
        public const uint FunctionType_Enabled = 26;

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType_RawValue Variable.
        /// </summary>
        public const uint BaseSensorFunctionOperationalType_RawValue = 1080;

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType_RawValue_EURange Variable.
        /// </summary>
        public const uint BaseSensorFunctionOperationalType_RawValue_EURange = 1084;

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint BaseSensorFunctionOperationalType_RawValue_EngineeringUnits = 1085;

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType_SensorValue Variable.
        /// </summary>
        public const uint BaseSensorFunctionOperationalType_SensorValue = 1086;

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType_SensorValue_EURange Variable.
        /// </summary>
        public const uint BaseSensorFunctionOperationalType_SensorValue_EURange = 1090;

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint BaseSensorFunctionOperationalType_SensorValue_EngineeringUnits = 1091;

        /// <summary>
        /// The identifier for the BaseSensorFunctionParameterSetType_CalibrationValues Variable.
        /// </summary>
        public const uint BaseSensorFunctionParameterSetType_CalibrationValues = 245;

        /// <summary>
        /// The identifier for the BaseSensorFunctionParameterSetType_CompensationValue Variable.
        /// </summary>
        public const uint BaseSensorFunctionParameterSetType_CompensationValue = 246;

        /// <summary>
        /// The identifier for the BaseSensorFunctionParameterSetType_CompensationValue_EURange Variable.
        /// </summary>
        public const uint BaseSensorFunctionParameterSetType_CompensationValue_EURange = 250;

        /// <summary>
        /// The identifier for the BaseSensorFunctionParameterSetType_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint BaseSensorFunctionParameterSetType_CompensationValue_EngineeringUnits = 251;

        /// <summary>
        /// The identifier for the BaseSensorFunctionParameterSetType_Damping Variable.
        /// </summary>
        public const uint BaseSensorFunctionParameterSetType_Damping = 252;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_Locked Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_Lock_Locked = 62;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_LockingClient Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_Lock_LockingClient = 63;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_LockingUser Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_Lock_LockingUser = 64;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_Lock_RemainingLockTime = 65;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_Lock_InitLock_InputArguments = 67;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_Lock_InitLock_OutputArguments = 68;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_Lock_RenewLock_OutputArguments = 70;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_Lock_ExitLock_OutputArguments = 72;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_Lock_BreakLock_OutputArguments = 74;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_EventId = 80;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_EventType = 81;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_SourceNode = 82;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_SourceName = 83;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_Time = 84;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ReceiveTime = 85;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_Message = 87;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_Severity = 88;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ConditionClassId = 89;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ConditionClassName = 90;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ConditionName = 93;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_BranchId = 94;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_Retain = 95;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_EnabledState = 96;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_EnabledState_Id = 97;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_Quality = 105;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp = 106;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_LastSeverity = 107;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = 108;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_Comment = 109;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp = 110;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ClientUserId = 111;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_AddComment_InputArguments = 115;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_AckedState = 116;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_AckedState_Id = 117;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ConfirmedState_Id = 126;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments = 135;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_Confirm_InputArguments = 137;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ActiveState = 138;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ActiveState_Id = 139;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_InputNode = 147;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_SuppressedState_Id = 149;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_OutOfServiceState_Id = 158;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState = 167;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id = 168;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id = 173;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime = 180;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 182;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_SuppressedOrShelved = 185;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_SilenceState_Id = 193;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_LatchedState_Id = 206;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_LimitState_CurrentState = 231;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id = 232;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id = 237;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_ParameterSet_CompensationValue_EURange = 260;

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint BaseSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits = 261;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_Locked Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_Lock_Locked = 298;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_LockingClient Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_Lock_LockingClient = 299;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_LockingUser Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_Lock_LockingUser = 300;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_Lock_RemainingLockTime = 301;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_Lock_InitLock_InputArguments = 303;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_Lock_InitLock_OutputArguments = 304;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_Lock_RenewLock_OutputArguments = 306;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_Lock_ExitLock_OutputArguments = 308;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_Lock_BreakLock_OutputArguments = 310;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_EventId = 316;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_EventType = 317;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_SourceNode = 318;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_SourceName = 319;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_Time = 320;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ReceiveTime = 321;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_Message = 323;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_Severity = 324;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ConditionClassId = 325;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ConditionClassName = 326;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ConditionName = 329;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_BranchId = 330;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_Retain = 331;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_EnabledState = 332;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_EnabledState_Id = 333;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_Quality = 341;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp = 342;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_LastSeverity = 343;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = 344;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_Comment = 345;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp = 346;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ClientUserId = 347;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_AddComment_InputArguments = 351;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_AckedState = 352;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_AckedState_Id = 353;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ConfirmedState_Id = 362;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments = 371;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_Confirm_InputArguments = 373;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ActiveState = 374;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ActiveState_Id = 375;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_InputNode = 383;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_SuppressedState_Id = 385;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_OutOfServiceState_Id = 394;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState = 403;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id = 404;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id = 409;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime = 416;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 418;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_SuppressedOrShelved = 421;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_SilenceState_Id = 429;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_LatchedState_Id = 442;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState = 467;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id = 468;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id = 473;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_ParameterSet_CompensationValue_EURange = 487;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint AnalogSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits = 488;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_Locked Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_Lock_Locked = 513;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_LockingClient Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_Lock_LockingClient = 514;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_LockingUser Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_Lock_LockingUser = 515;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_Lock_RemainingLockTime = 516;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_Lock_InitLock_InputArguments = 518;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_Lock_InitLock_OutputArguments = 519;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_Lock_RenewLock_OutputArguments = 521;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_Lock_ExitLock_OutputArguments = 523;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_Lock_BreakLock_OutputArguments = 525;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_EventId = 531;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_EventType = 532;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_SourceNode = 533;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_SourceName = 534;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_Time = 535;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ReceiveTime = 536;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_Message = 538;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_Severity = 539;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassId = 540;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassName = 541;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionName = 544;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_BranchId = 545;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_Retain = 546;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_EnabledState = 547;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_EnabledState_Id = 548;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_Quality = 556;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_Quality_SourceTimestamp = 557;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity = 558;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity_SourceTimestamp = 559;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_Comment = 560;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_Comment_SourceTimestamp = 561;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ClientUserId = 562;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_AddComment_InputArguments = 566;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_AckedState = 567;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_AckedState_Id = 568;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConfirmedState_Id = 577;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge_InputArguments = 586;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_Confirm_InputArguments = 588;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ActiveState = 589;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ActiveState_Id = 590;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_InputNode = 598;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_SuppressedState_Id = 600;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_OutOfServiceState_Id = 609;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_CurrentState = 618;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_CurrentState_Id = 619;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_LastTransition_Id = 624;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_UnshelveTime = 631;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 633;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_SuppressedOrShelved = 636;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_SilenceState_Id = 644;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_LatchedState_Id = 657;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState = 682;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState_Id = 683;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_LastTransition_Id = 688;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_ParameterSet_CompensationValue_EURange = 702;

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint AnalogSensorFunctionWithCompensationType_ParameterSet_CompensationValue_EngineeringUnits = 703;

        /// <summary>
        /// The identifier for the SupportedPropertySetType_Property Variable.
        /// </summary>
        public const uint SupportedPropertySetType_Property = 720;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_Locked Variable.
        /// </summary>
        public const uint FunctionalUnitType_Lock_Locked = 37;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_LockingClient Variable.
        /// </summary>
        public const uint FunctionalUnitType_Lock_LockingClient = 38;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_LockingUser Variable.
        /// </summary>
        public const uint FunctionalUnitType_Lock_LockingUser = 39;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FunctionalUnitType_Lock_RemainingLockTime = 40;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FunctionalUnitType_Lock_InitLock_InputArguments = 42;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FunctionalUnitType_Lock_InitLock_OutputArguments = 43;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FunctionalUnitType_Lock_RenewLock_OutputArguments = 45;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FunctionalUnitType_Lock_ExitLock_OutputArguments = 47;

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FunctionalUnitType_Lock_BreakLock_OutputArguments = 49;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ComponentName Variable.
        /// </summary>
        public const uint FunctionalUnitType_ComponentName = 50;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_Locked Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Lock_Locked = 731;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_LockingClient Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Lock_LockingClient = 732;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_LockingUser Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Lock_LockingUser = 733;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Lock_RemainingLockTime = 734;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Lock_InitLock_InputArguments = 736;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Lock_InitLock_OutputArguments = 737;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Lock_RenewLock_OutputArguments = 739;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Lock_ExitLock_OutputArguments = 741;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_Lock_BreakLock_OutputArguments = 743;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState = 745;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState_Id Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState_Id = 746;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState_Number Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState_Number = 748;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition = 750;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_Id Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_Id = 751;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_Number Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_Number = 753;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_TransitionTime = 754;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_Deletable Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_Deletable = 990;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_AutoDelete Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_AutoDelete = 991;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_RecycleCount Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_RecycleCount = 992;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_CreateSessionId = 994;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_CreateClientName = 995;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_InvocationCreationTime = 996;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastTransitionTime = 997;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodCall = 998;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodSessionId = 999;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodInputArguments = 1000;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodOutputArguments = 1001;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodInputValues = 1002;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodOutputValues = 1003;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodCallTime = 1004;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodReturnStatus = 1005;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ProgramTemplateSet_NodeVersion Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ProgramTemplateSet_NodeVersion = 761;

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ResultSet_NodeVersion Variable.
        /// </summary>
        public const uint FunctionalUnitType_ProgramManager_ResultSet_NodeVersion = 763;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_CurrentState_Id = 767;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_CurrentState_Number Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_CurrentState_Number = 769;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_LastTransition_Id = 772;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_LastTransition_Number Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_LastTransition_Number = 774;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_LastTransition_TransitionTime = 775;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ProgramDiagnostic_CreateSessionId = 1015;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ProgramDiagnostic_CreateClientName = 1016;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ProgramDiagnostic_InvocationCreationTime = 1017;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ProgramDiagnostic_LastTransitionTime = 1018;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ProgramDiagnostic_LastMethodCall = 1019;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ProgramDiagnostic_LastMethodSessionId = 1020;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ProgramDiagnostic_LastMethodInputArguments = 1021;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ProgramDiagnostic_LastMethodOutputArguments = 1022;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ProgramDiagnostic_LastMethodInputValues = 1023;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ProgramDiagnostic_LastMethodOutputValues = 1024;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ProgramDiagnostic_LastMethodCallTime = 1025;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ProgramDiagnostic_LastMethodReturnStatus = 1026;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_Halted_StateNumber Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_Halted_StateNumber = 1029;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_Ready_StateNumber Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_Ready_StateNumber = 1031;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_Running_StateNumber Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_Running_StateNumber = 1033;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_Suspended_StateNumber = 1035;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_HaltedToReady_TransitionNumber = 1037;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ReadyToRunning_TransitionNumber = 1039;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_RunningToHalted_TransitionNumber = 1041;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_RunningToReady_TransitionNumber = 1043;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_RunningToSuspended_TransitionNumber = 1045;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_SuspendedToRunning_TransitionNumber = 1047;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_SuspendedToHalted_TransitionNumber = 1049;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_SuspendedToReady_TransitionNumber = 1051;

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint LADSBaseStateMachineType_ReadyToHalted_TransitionNumber = 1053;

        /// <summary>
        /// The identifier for the ProgramTemplateType_Name Variable.
        /// </summary>
        public const uint ProgramTemplateType_Name = 780;

        /// <summary>
        /// The identifier for the ProgramTemplateType_TemplateID Variable.
        /// </summary>
        public const uint ProgramTemplateType_TemplateID = 782;

        /// <summary>
        /// The identifier for the ProgramTemplateType_Author Variable.
        /// </summary>
        public const uint ProgramTemplateType_Author = 783;

        /// <summary>
        /// The identifier for the ProgramTemplateType_Created Variable.
        /// </summary>
        public const uint ProgramTemplateType_Created = 784;

        /// <summary>
        /// The identifier for the ProgramTemplateType_Modified Variable.
        /// </summary>
        public const uint ProgramTemplateType_Modified = 785;

        /// <summary>
        /// The identifier for the ProgramTemplateType_Version Variable.
        /// </summary>
        public const uint ProgramTemplateType_Version = 786;

        /// <summary>
        /// The identifier for the ProgramTemplateType_Status Variable.
        /// </summary>
        public const uint ProgramTemplateType_Status = 787;

        /// <summary>
        /// The identifier for the ProgramTemplateSetType_NodeVersion Variable.
        /// </summary>
        public const uint ProgramTemplateSetType_NodeVersion = 789;

        /// <summary>
        /// The identifier for the ResultSetType_NodeVersion Variable.
        /// </summary>
        public const uint ResultSetType_NodeVersion = 791;

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_Locked Variable.
        /// </summary>
        public const uint ProgramManagerType_Lock_Locked = 801;

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ProgramManagerType_Lock_LockingClient = 802;

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ProgramManagerType_Lock_LockingUser = 803;

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ProgramManagerType_Lock_RemainingLockTime = 804;

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ProgramManagerType_Lock_InitLock_InputArguments = 806;

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ProgramManagerType_Lock_InitLock_OutputArguments = 807;

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ProgramManagerType_Lock_RenewLock_OutputArguments = 809;

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ProgramManagerType_Lock_ExitLock_OutputArguments = 811;

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ProgramManagerType_Lock_BreakLock_OutputArguments = 813;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_CurrentState Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_CurrentState = 815;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_CurrentState_Id Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_CurrentState_Id = 816;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_CurrentState_Number Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_CurrentState_Number = 818;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_LastTransition Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_LastTransition = 820;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_LastTransition_Id Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_LastTransition_Id = 821;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_LastTransition_Number Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_LastTransition_Number = 823;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_LastTransition_TransitionTime = 824;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_Deletable Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_Deletable = 1059;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_AutoDelete Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_AutoDelete = 1060;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_RecycleCount Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_RecycleCount = 1061;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_ProgramDiagnostic_CreateSessionId = 1063;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_ProgramDiagnostic_CreateClientName = 1064;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_ProgramDiagnostic_InvocationCreationTime = 1065;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastTransitionTime = 1066;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodCall = 1067;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodSessionId = 1068;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodInputArguments = 1069;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodOutputArguments = 1070;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodInputValues = 1071;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodOutputValues = 1072;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodCallTime = 1073;

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodReturnStatus = 1074;

        /// <summary>
        /// The identifier for the ProgramManagerType_ProgramTemplateSet_NodeVersion Variable.
        /// </summary>
        public const uint ProgramManagerType_ProgramTemplateSet_NodeVersion = 831;

        /// <summary>
        /// The identifier for the ProgramManagerType_ResultSet_NodeVersion Variable.
        /// </summary>
        public const uint ProgramManagerType_ResultSet_NodeVersion = 833;

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_Locked Variable.
        /// </summary>
        public const uint LADSComponentType_Lock_Locked = 915;

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_LockingClient Variable.
        /// </summary>
        public const uint LADSComponentType_Lock_LockingClient = 916;

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_LockingUser Variable.
        /// </summary>
        public const uint LADSComponentType_Lock_LockingUser = 917;

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint LADSComponentType_Lock_RemainingLockTime = 918;

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint LADSComponentType_Lock_InitLock_InputArguments = 920;

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint LADSComponentType_Lock_InitLock_OutputArguments = 921;

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint LADSComponentType_Lock_RenewLock_OutputArguments = 923;

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint LADSComponentType_Lock_ExitLock_OutputArguments = 925;

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint LADSComponentType_Lock_BreakLock_OutputArguments = 927;

        /// <summary>
        /// The identifier for the LADSComponentType_DeviceHealth Variable.
        /// </summary>
        public const uint LADSComponentType_DeviceHealth = 947;

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint LADSDeviceType_Lock_Locked = 958;

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint LADSDeviceType_Lock_LockingClient = 959;

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint LADSDeviceType_Lock_LockingUser = 960;

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint LADSDeviceType_Lock_RemainingLockTime = 961;

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint LADSDeviceType_Lock_InitLock_InputArguments = 963;

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint LADSDeviceType_Lock_InitLock_OutputArguments = 964;

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint LADSDeviceType_Lock_RenewLock_OutputArguments = 966;

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint LADSDeviceType_Lock_ExitLock_OutputArguments = 968;

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint LADSDeviceType_Lock_BreakLock_OutputArguments = 970;
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
        /// The identifier for the FunctionType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Lock_InitLock = new ExpandedNodeId(Spectaris.LADS.Methods.FunctionType_Lock_InitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Lock_RenewLock = new ExpandedNodeId(Spectaris.LADS.Methods.FunctionType_Lock_RenewLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Lock_ExitLock = new ExpandedNodeId(Spectaris.LADS.Methods.FunctionType_Lock_ExitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Lock_BreakLock = new ExpandedNodeId(Spectaris.LADS.Methods.FunctionType_Lock_BreakLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_InitLock = new ExpandedNodeId(Spectaris.LADS.Methods.BaseSensorFunctionType_Lock_InitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_RenewLock = new ExpandedNodeId(Spectaris.LADS.Methods.BaseSensorFunctionType_Lock_RenewLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_ExitLock = new ExpandedNodeId(Spectaris.LADS.Methods.BaseSensorFunctionType_Lock_ExitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_BreakLock = new ExpandedNodeId(Spectaris.LADS.Methods.BaseSensorFunctionType_Lock_BreakLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_Disable = new ExpandedNodeId(Spectaris.LADS.Methods.BaseSensorFunctionType_AlarmMonitor_Disable, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_Enable = new ExpandedNodeId(Spectaris.LADS.Methods.BaseSensorFunctionType_AlarmMonitor_Enable, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_AddComment = new ExpandedNodeId(Spectaris.LADS.Methods.BaseSensorFunctionType_AlarmMonitor_AddComment, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Spectaris.LADS.Methods.BaseSensorFunctionType_AlarmMonitor_Acknowledge, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(Spectaris.LADS.Methods.BaseSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(Spectaris.LADS.Methods.BaseSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(Spectaris.LADS.Methods.BaseSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_InitLock = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionType_Lock_InitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_RenewLock = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionType_Lock_RenewLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_ExitLock = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionType_Lock_ExitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_BreakLock = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionType_Lock_BreakLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Disable = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionType_AlarmMonitor_Disable, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Enable = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionType_AlarmMonitor_Enable, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_AddComment = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionType_AlarmMonitor_AddComment, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionType_AlarmMonitor_Acknowledge, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_Lock_InitLock = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionWithCompensationType_Lock_InitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_Lock_RenewLock = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionWithCompensationType_Lock_RenewLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_Lock_ExitLock = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionWithCompensationType_Lock_ExitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_Lock_BreakLock = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionWithCompensationType_Lock_BreakLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_Disable = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionWithCompensationType_AlarmMonitor_Disable, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_Enable = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionWithCompensationType_AlarmMonitor_Enable, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_AddComment = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionWithCompensationType_AlarmMonitor_AddComment, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_TimedShelve, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_Unshelve, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(Spectaris.LADS.Methods.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_OneShotShelve, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_InitLock = new ExpandedNodeId(Spectaris.LADS.Methods.FunctionalUnitType_Lock_InitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_RenewLock = new ExpandedNodeId(Spectaris.LADS.Methods.FunctionalUnitType_Lock_RenewLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_ExitLock = new ExpandedNodeId(Spectaris.LADS.Methods.FunctionalUnitType_Lock_ExitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_BreakLock = new ExpandedNodeId(Spectaris.LADS.Methods.FunctionalUnitType_Lock_BreakLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_InitLock = new ExpandedNodeId(Spectaris.LADS.Methods.FunctionalUnitType_ProgramManager_Lock_InitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_RenewLock = new ExpandedNodeId(Spectaris.LADS.Methods.FunctionalUnitType_ProgramManager_Lock_RenewLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_ExitLock = new ExpandedNodeId(Spectaris.LADS.Methods.FunctionalUnitType_ProgramManager_Lock_ExitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_BreakLock = new ExpandedNodeId(Spectaris.LADS.Methods.FunctionalUnitType_ProgramManager_Lock_BreakLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Lock_InitLock = new ExpandedNodeId(Spectaris.LADS.Methods.ProgramManagerType_Lock_InitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Lock_RenewLock = new ExpandedNodeId(Spectaris.LADS.Methods.ProgramManagerType_Lock_RenewLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Lock_ExitLock = new ExpandedNodeId(Spectaris.LADS.Methods.ProgramManagerType_Lock_ExitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Lock_BreakLock = new ExpandedNodeId(Spectaris.LADS.Methods.ProgramManagerType_Lock_BreakLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Lock_InitLock = new ExpandedNodeId(Spectaris.LADS.Methods.LADSComponentType_Lock_InitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Lock_RenewLock = new ExpandedNodeId(Spectaris.LADS.Methods.LADSComponentType_Lock_RenewLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Lock_ExitLock = new ExpandedNodeId(Spectaris.LADS.Methods.LADSComponentType_Lock_ExitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Lock_BreakLock = new ExpandedNodeId(Spectaris.LADS.Methods.LADSComponentType_Lock_BreakLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_Lock_InitLock = new ExpandedNodeId(Spectaris.LADS.Methods.LADSDeviceType_Lock_InitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_Lock_RenewLock = new ExpandedNodeId(Spectaris.LADS.Methods.LADSDeviceType_Lock_RenewLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_Lock_ExitLock = new ExpandedNodeId(Spectaris.LADS.Methods.LADSDeviceType_Lock_ExitLock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_Lock_BreakLock = new ExpandedNodeId(Spectaris.LADS.Methods.LADSDeviceType_Lock_BreakLock, Spectaris.LADS.Namespaces.LADS);
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
        /// The identifier for the FunctionType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_ParameterSet = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionType_ParameterSet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Configuration = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionType_Configuration, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_FunctionSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_FunctionSet = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionType_FunctionSet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_ParameterSet = new ExpandedNodeId(Spectaris.LADS.Objects.BaseSensorFunctionType_ParameterSet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor Object.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor = new ExpandedNodeId(Spectaris.LADS.Objects.BaseSensorFunctionType_AlarmMonitor, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_LimitState = new ExpandedNodeId(Spectaris.LADS.Objects.BaseSensorFunctionType_AlarmMonitor_LimitState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Operational = new ExpandedNodeId(Spectaris.LADS.Objects.BaseSensorFunctionType_Operational, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Tuning Object.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Tuning = new ExpandedNodeId(Spectaris.LADS.Objects.BaseSensorFunctionType_Tuning, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_ParameterSet = new ExpandedNodeId(Spectaris.LADS.Objects.AnalogSensorFunctionType_ParameterSet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_LimitState = new ExpandedNodeId(Spectaris.LADS.Objects.AnalogSensorFunctionType_AlarmMonitor_LimitState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_ParameterSet = new ExpandedNodeId(Spectaris.LADS.Objects.AnalogSensorFunctionWithCompensationType_ParameterSet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState = new ExpandedNodeId(Spectaris.LADS.Objects.AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_MethodSet = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionalUnitType_MethodSet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Identification Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Identification = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionalUnitType_Identification, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionalUnitType_Lock, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_FunctionSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_FunctionSet = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionalUnitType_FunctionSet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Operational = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionalUnitType_Operational, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionalUnitType_ProgramManager, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionalUnitType_ProgramManager_ActiveProgram, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Operational = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionalUnitType_ProgramManager_Operational, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ProgramTemplateSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ProgramTemplateSet = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionalUnitType_ProgramManager_ProgramTemplateSet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ResultSet Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ResultSet = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionalUnitType_ProgramManager_ResultSet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_SupportedPropertySet Object.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_SupportedPropertySet = new ExpandedNodeId(Spectaris.LADS.Objects.FunctionalUnitType_SupportedPropertySet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram Object.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram = new ExpandedNodeId(Spectaris.LADS.Objects.ProgramManagerType_ActiveProgram, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Operational = new ExpandedNodeId(Spectaris.LADS.Objects.ProgramManagerType_Operational, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ProgramTemplateSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ProgramTemplateSet = new ExpandedNodeId(Spectaris.LADS.Objects.ProgramManagerType_ProgramTemplateSet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ResultSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ResultSet = new ExpandedNodeId(Spectaris.LADS.Objects.ProgramManagerType_ResultSet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_ComponentSet Object.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_ComponentSet = new ExpandedNodeId(Spectaris.LADS.Objects.LADSComponentType_ComponentSet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Maintenance Object.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Maintenance = new ExpandedNodeId(Spectaris.LADS.Objects.LADSComponentType_Maintenance, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_ComponentSet Object.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_ComponentSet = new ExpandedNodeId(Spectaris.LADS.Objects.LADSDeviceType_ComponentSet, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_FunctionalUnitSet Object.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_FunctionalUnitSet = new ExpandedNodeId(Spectaris.LADS.Objects.LADSDeviceType_FunctionalUnitSet, Spectaris.LADS.Namespaces.LADS);
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
        /// The identifier for the FunctionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.FunctionType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionOperationalType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.BaseSensorFunctionOperationalType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionParameterSetType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionParameterSetType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.BaseSensorFunctionParameterSetType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.BaseSensorFunctionType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.AnalogSensorFunctionType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.AnalogSensorFunctionWithCompensationType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionSetType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FunctionSetType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.FunctionSetType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the SupportedPropertySetType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SupportedPropertySetType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.SupportedPropertySetType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.FunctionalUnitType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitSetType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitSetType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.FunctionalUnitSetType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.LADSBaseStateMachineType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramTemplateType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ProgramTemplateType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.ProgramTemplateType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramTemplateSetType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ProgramTemplateSetType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.ProgramTemplateSetType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ResultSetType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ResultSetType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.ResultSetType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.ProgramManagerType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.LADSComponentType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ComponentSetType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ComponentSetType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.ComponentSetType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType = new ExpandedNodeId(Spectaris.LADS.ObjectTypes.LADSDeviceType, Spectaris.LADS.Namespaces.LADS);
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
        /// The identifier for the FunctionType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Lock_Locked = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionType_Lock_Locked, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Lock_LockingClient = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionType_Lock_LockingClient, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Lock_LockingUser = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionType_Lock_LockingUser, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionType_Lock_RemainingLockTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionType_Lock_InitLock_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionType_Lock_InitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionType_Lock_RenewLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionType_Lock_ExitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionType_Lock_BreakLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionType_Enabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionType_Enabled = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionType_Enabled, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionOperationalType_RawValue = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionOperationalType_RawValue, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionOperationalType_RawValue_EURange = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionOperationalType_RawValue_EURange, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionOperationalType_RawValue_EngineeringUnits = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionOperationalType_RawValue_EngineeringUnits, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionOperationalType_SensorValue = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionOperationalType_SensorValue, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionOperationalType_SensorValue_EURange = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionOperationalType_SensorValue_EURange, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionOperationalType_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionOperationalType_SensorValue_EngineeringUnits = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionOperationalType_SensorValue_EngineeringUnits, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionParameterSetType_CalibrationValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionParameterSetType_CalibrationValues = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionParameterSetType_CalibrationValues, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionParameterSetType_CompensationValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionParameterSetType_CompensationValue = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionParameterSetType_CompensationValue, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionParameterSetType_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionParameterSetType_CompensationValue_EURange = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionParameterSetType_CompensationValue_EURange, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionParameterSetType_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionParameterSetType_CompensationValue_EngineeringUnits = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionParameterSetType_CompensationValue_EngineeringUnits, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionParameterSetType_Damping Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionParameterSetType_Damping = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionParameterSetType_Damping, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_Locked = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_Lock_Locked, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_LockingClient = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_Lock_LockingClient, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_LockingUser = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_Lock_LockingUser, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_Lock_RemainingLockTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_Lock_InitLock_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_Lock_InitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_Lock_RenewLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_Lock_ExitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_Lock_BreakLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_EventId = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_EventId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_EventType = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_EventType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_SourceNode = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_SourceNode, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_SourceName = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_SourceName, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_Time = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_Time, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_ReceiveTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_Message = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_Message, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_Severity = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_Severity, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_ConditionClassId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_ConditionClassName, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ConditionName = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_ConditionName, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_BranchId = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_BranchId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_Retain = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_Retain, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_EnabledState = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_EnabledState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_EnabledState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_Quality = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_Quality, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_LastSeverity, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_Comment = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_Comment, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_ClientUserId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_AddComment_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_AckedState = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_AckedState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_AckedState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_ConfirmedState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_Confirm_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ActiveState = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_ActiveState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_ActiveState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_InputNode = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_InputNode, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_SuppressedState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_OutOfServiceState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_SuppressedOrShelved, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_SilenceState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_LatchedState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_LimitState_CurrentState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_ParameterSet_CompensationValue_EURange, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the BaseSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId BaseSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(Spectaris.LADS.Variables.BaseSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_Locked = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_Lock_Locked, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_LockingClient = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_Lock_LockingClient, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_LockingUser = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_Lock_LockingUser, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_Lock_RemainingLockTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_Lock_InitLock_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_Lock_InitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_Lock_RenewLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_Lock_ExitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_Lock_BreakLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_EventId = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_EventId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_EventType = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_EventType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_SourceNode = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_SourceNode, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_SourceName = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_SourceName, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Time = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Time, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ReceiveTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Message = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Message, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Severity = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Severity, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ConditionClassId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ConditionClassName, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ConditionName = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ConditionName, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_BranchId = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_BranchId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Retain = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Retain, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_EnabledState = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_EnabledState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_EnabledState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Quality = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Quality, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_LastSeverity, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Comment = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Comment, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ClientUserId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_AddComment_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_AckedState = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_AckedState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_AckedState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ConfirmedState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_Confirm_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ActiveState = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ActiveState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ActiveState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_InputNode = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_InputNode, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_SuppressedState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_OutOfServiceState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_SuppressedOrShelved, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_SilenceState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_LatchedState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_ParameterSet_CompensationValue_EURange, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_Lock_Locked = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_Lock_Locked, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_Lock_LockingClient = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_Lock_LockingClient, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_Lock_LockingUser = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_Lock_LockingUser, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_Lock_RemainingLockTime = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_Lock_RemainingLockTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_Lock_InitLock_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_Lock_InitLock_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_Lock_InitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_Lock_RenewLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_Lock_ExitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_Lock_BreakLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_EventId = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_EventId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_EventType = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_EventType, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_SourceNode = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_SourceNode, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_SourceName = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_SourceName, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_Time = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_Time, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ReceiveTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_Message = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_Message, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_Severity = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_Severity, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionClassName, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionName = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConditionName, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_BranchId = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_BranchId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_Retain = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_Retain, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_EnabledState = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_EnabledState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_EnabledState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_Quality = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_Quality, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_Quality_SourceTimestamp, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_LastSeverity_SourceTimestamp, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_Comment = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_Comment, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_Comment_SourceTimestamp, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ClientUserId = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ClientUserId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_AddComment_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_AckedState = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_AckedState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_AckedState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ConfirmedState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_Acknowledge_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_Confirm_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ActiveState = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ActiveState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ActiveState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_InputNode = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_InputNode, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_SuppressedState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_OutOfServiceState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_CurrentState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_CurrentState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_LastTransition_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_UnshelveTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_SuppressedOrShelved, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_SilenceState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_LatchedState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_CurrentState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_AlarmMonitor_LimitState_LastTransition_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_ParameterSet_CompensationValue_EURange, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the AnalogSensorFunctionWithCompensationType_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorFunctionWithCompensationType_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(Spectaris.LADS.Variables.AnalogSensorFunctionWithCompensationType_ParameterSet_CompensationValue_EngineeringUnits, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the SupportedPropertySetType_Property Variable.
        /// </summary>
        public static readonly ExpandedNodeId SupportedPropertySetType_Property = new ExpandedNodeId(Spectaris.LADS.Variables.SupportedPropertySetType_Property, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_Locked = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_Lock_Locked, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_LockingClient = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_Lock_LockingClient, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_LockingUser = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_Lock_LockingUser, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_RemainingLockTime = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_Lock_RemainingLockTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_InitLock_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_Lock_InitLock_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_Lock_InitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_Lock_RenewLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_Lock_ExitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_Lock_BreakLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ComponentName Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ComponentName = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ComponentName, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_Locked = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_Locked, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_LockingClient = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_LockingClient, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_LockingUser = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_LockingUser, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_RemainingLockTime = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_RemainingLockTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_InitLock_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_InitLock_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_InitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_InitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_RenewLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_ExitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_Lock_BreakLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState_Number = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_CurrentState_Number, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_Id = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_Number = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_Number, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_TransitionTime = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_LastTransition_TransitionTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_Deletable = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_Deletable, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_AutoDelete = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_AutoDelete, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_RecycleCount = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_RecycleCount, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_CreateSessionId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_CreateClientName, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_InvocationCreationTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastTransitionTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodCall, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodSessionId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodInputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodOutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodInputValues, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodOutputValues, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodCallTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ActiveProgram_ProgramDiagnostic_LastMethodReturnStatus, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ProgramTemplateSet_NodeVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ProgramTemplateSet_NodeVersion = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ProgramTemplateSet_NodeVersion, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the FunctionalUnitType_ProgramManager_ResultSet_NodeVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId FunctionalUnitType_ProgramManager_ResultSet_NodeVersion = new ExpandedNodeId(Spectaris.LADS.Variables.FunctionalUnitType_ProgramManager_ResultSet_NodeVersion, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_CurrentState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_CurrentState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_CurrentState_Number = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_CurrentState_Number, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_LastTransition_Id = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_LastTransition_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_LastTransition_Number = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_LastTransition_Number, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_LastTransition_TransitionTime = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_LastTransition_TransitionTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ProgramDiagnostic_CreateSessionId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ProgramDiagnostic_CreateClientName, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ProgramDiagnostic_InvocationCreationTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ProgramDiagnostic_LastTransitionTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ProgramDiagnostic_LastMethodCall, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ProgramDiagnostic_LastMethodSessionId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ProgramDiagnostic_LastMethodInputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ProgramDiagnostic_LastMethodOutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ProgramDiagnostic_LastMethodInputValues, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ProgramDiagnostic_LastMethodOutputValues, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ProgramDiagnostic_LastMethodCallTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ProgramDiagnostic_LastMethodReturnStatus, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_Halted_StateNumber = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_Halted_StateNumber, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_Ready_StateNumber = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_Ready_StateNumber, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_Running_StateNumber = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_Running_StateNumber, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_Suspended_StateNumber = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_Suspended_StateNumber, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_HaltedToReady_TransitionNumber = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_HaltedToReady_TransitionNumber, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ReadyToRunning_TransitionNumber, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_RunningToHalted_TransitionNumber = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_RunningToHalted_TransitionNumber, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_RunningToReady_TransitionNumber = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_RunningToReady_TransitionNumber, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_RunningToSuspended_TransitionNumber, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_SuspendedToRunning_TransitionNumber, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_SuspendedToHalted_TransitionNumber, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_SuspendedToReady_TransitionNumber, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSBaseStateMachineType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSBaseStateMachineType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(Spectaris.LADS.Variables.LADSBaseStateMachineType_ReadyToHalted_TransitionNumber, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramTemplateType_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramTemplateType_Name = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramTemplateType_Name, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramTemplateType_TemplateID Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramTemplateType_TemplateID = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramTemplateType_TemplateID, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramTemplateType_Author Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramTemplateType_Author = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramTemplateType_Author, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramTemplateType_Created Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramTemplateType_Created = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramTemplateType_Created, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramTemplateType_Modified Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramTemplateType_Modified = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramTemplateType_Modified, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramTemplateType_Version Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramTemplateType_Version = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramTemplateType_Version, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramTemplateType_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramTemplateType_Status = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramTemplateType_Status, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramTemplateSetType_NodeVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramTemplateSetType_NodeVersion = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramTemplateSetType_NodeVersion, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ResultSetType_NodeVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId ResultSetType_NodeVersion = new ExpandedNodeId(Spectaris.LADS.Variables.ResultSetType_NodeVersion, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Lock_Locked = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_Lock_Locked, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Lock_LockingClient = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_Lock_LockingClient, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Lock_LockingUser = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_Lock_LockingUser, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Lock_RemainingLockTime = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_Lock_RemainingLockTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Lock_InitLock_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_Lock_InitLock_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_Lock_InitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_Lock_RenewLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_Lock_ExitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_Lock_BreakLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_CurrentState = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_CurrentState, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_CurrentState_Id = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_CurrentState_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_CurrentState_Number = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_CurrentState_Number, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_LastTransition Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_LastTransition = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_LastTransition, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_LastTransition_Id = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_LastTransition_Id, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_LastTransition_Number = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_LastTransition_Number, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_LastTransition_TransitionTime = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_LastTransition_TransitionTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_Deletable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_Deletable = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_Deletable, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_AutoDelete Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_AutoDelete = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_AutoDelete, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_RecycleCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_RecycleCount = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_RecycleCount, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_ProgramDiagnostic_CreateSessionId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_ProgramDiagnostic_CreateClientName, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_ProgramDiagnostic_InvocationCreationTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastTransitionTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodCall, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodSessionId, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodInputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodOutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodInputValues, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodOutputValues, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodCallTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ActiveProgram_ProgramDiagnostic_LastMethodReturnStatus, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ProgramTemplateSet_NodeVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ProgramTemplateSet_NodeVersion = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ProgramTemplateSet_NodeVersion, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the ProgramManagerType_ResultSet_NodeVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProgramManagerType_ResultSet_NodeVersion = new ExpandedNodeId(Spectaris.LADS.Variables.ProgramManagerType_ResultSet_NodeVersion, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Lock_Locked = new ExpandedNodeId(Spectaris.LADS.Variables.LADSComponentType_Lock_Locked, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Lock_LockingClient = new ExpandedNodeId(Spectaris.LADS.Variables.LADSComponentType_Lock_LockingClient, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Lock_LockingUser = new ExpandedNodeId(Spectaris.LADS.Variables.LADSComponentType_Lock_LockingUser, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Lock_RemainingLockTime = new ExpandedNodeId(Spectaris.LADS.Variables.LADSComponentType_Lock_RemainingLockTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Lock_InitLock_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.LADSComponentType_Lock_InitLock_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.LADSComponentType_Lock_InitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.LADSComponentType_Lock_RenewLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.LADSComponentType_Lock_ExitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.LADSComponentType_Lock_BreakLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSComponentType_DeviceHealth Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSComponentType_DeviceHealth = new ExpandedNodeId(Spectaris.LADS.Variables.LADSComponentType_DeviceHealth, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_Lock_Locked = new ExpandedNodeId(Spectaris.LADS.Variables.LADSDeviceType_Lock_Locked, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_Lock_LockingClient = new ExpandedNodeId(Spectaris.LADS.Variables.LADSDeviceType_Lock_LockingClient, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_Lock_LockingUser = new ExpandedNodeId(Spectaris.LADS.Variables.LADSDeviceType_Lock_LockingUser, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Spectaris.LADS.Variables.LADSDeviceType_Lock_RemainingLockTime, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.LADSDeviceType_Lock_InitLock_InputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.LADSDeviceType_Lock_InitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.LADSDeviceType_Lock_RenewLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.LADSDeviceType_Lock_ExitLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);

        /// <summary>
        /// The identifier for the LADSDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LADSDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Spectaris.LADS.Variables.LADSDeviceType_Lock_BreakLock_OutputArguments, Spectaris.LADS.Namespaces.LADS);
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
        /// The BrowseName for the ActiveProgram component.
        /// </summary>
        public const string ActiveProgram = "ActiveProgram";

        /// <summary>
        /// The BrowseName for the AlarmMonitor component.
        /// </summary>
        public const string AlarmMonitor = "AlarmMonitor";

        /// <summary>
        /// The BrowseName for the AnalogSensorFunctionType component.
        /// </summary>
        public const string AnalogSensorFunctionType = "AnalogSensorFunctionType";

        /// <summary>
        /// The BrowseName for the AnalogSensorFunctionWithCompensationType component.
        /// </summary>
        public const string AnalogSensorFunctionWithCompensationType = "AnalogSensorFunctionWithCompensationType";

        /// <summary>
        /// The BrowseName for the Author component.
        /// </summary>
        public const string Author = "Author";

        /// <summary>
        /// The BrowseName for the BaseSensorFunctionOperationalType component.
        /// </summary>
        public const string BaseSensorFunctionOperationalType = "BaseSensorFunctionOperationalType";

        /// <summary>
        /// The BrowseName for the BaseSensorFunctionParameterSetType component.
        /// </summary>
        public const string BaseSensorFunctionParameterSetType = "BaseSensorFunctionParameterSetType";

        /// <summary>
        /// The BrowseName for the BaseSensorFunctionType component.
        /// </summary>
        public const string BaseSensorFunctionType = "BaseSensorFunctionType";

        /// <summary>
        /// The BrowseName for the CalibrationValues component.
        /// </summary>
        public const string CalibrationValues = "CalibrationValues";

        /// <summary>
        /// The BrowseName for the CompensationValue component.
        /// </summary>
        public const string CompensationValue = "CompensationValue";

        /// <summary>
        /// The BrowseName for the ComponentName component.
        /// </summary>
        public const string ComponentName = "ComponentName";

        /// <summary>
        /// The BrowseName for the ComponentSet component.
        /// </summary>
        public const string ComponentSet = "ComponentSet";

        /// <summary>
        /// The BrowseName for the ComponentSetType component.
        /// </summary>
        public const string ComponentSetType = "ComponentSetType";

        /// <summary>
        /// The BrowseName for the Configuration component.
        /// </summary>
        public const string Configuration = "Configuration";

        /// <summary>
        /// The BrowseName for the Created component.
        /// </summary>
        public const string Created = "Created";

        /// <summary>
        /// The BrowseName for the Damping component.
        /// </summary>
        public const string Damping = "Damping";

        /// <summary>
        /// The BrowseName for the DeviceHealth component.
        /// </summary>
        public const string DeviceHealth = "DeviceHealth";

        /// <summary>
        /// The BrowseName for the Enabled component.
        /// </summary>
        public const string Enabled = "Enabled";

        /// <summary>
        /// The BrowseName for the FunctionalUnitSet component.
        /// </summary>
        public const string FunctionalUnitSet = "FunctionalUnitSet";

        /// <summary>
        /// The BrowseName for the FunctionalUnitSetType component.
        /// </summary>
        public const string FunctionalUnitSetType = "FunctionalUnitSetType";

        /// <summary>
        /// The BrowseName for the FunctionalUnitType component.
        /// </summary>
        public const string FunctionalUnitType = "FunctionalUnitType";

        /// <summary>
        /// The BrowseName for the FunctionSet component.
        /// </summary>
        public const string FunctionSet = "FunctionSet";

        /// <summary>
        /// The BrowseName for the FunctionSetType component.
        /// </summary>
        public const string FunctionSetType = "FunctionSetType";

        /// <summary>
        /// The BrowseName for the FunctionType component.
        /// </summary>
        public const string FunctionType = "FunctionType";

        /// <summary>
        /// The BrowseName for the Identification component.
        /// </summary>
        public const string Identification = "Identification";

        /// <summary>
        /// The BrowseName for the LADSBaseStateMachineType component.
        /// </summary>
        public const string LADSBaseStateMachineType = "LADSBaseStateMachineType";

        /// <summary>
        /// The BrowseName for the LADSComponentType component.
        /// </summary>
        public const string LADSComponentType = "LADSComponentType";

        /// <summary>
        /// The BrowseName for the LADSDeviceType component.
        /// </summary>
        public const string LADSDeviceType = "LADSDeviceType";

        /// <summary>
        /// The BrowseName for the Lock component.
        /// </summary>
        public const string Lock = "Lock";

        /// <summary>
        /// The BrowseName for the Maintenance component.
        /// </summary>
        public const string Maintenance = "Maintenance";

        /// <summary>
        /// The BrowseName for the MethodSet component.
        /// </summary>
        public const string MethodSet = "MethodSet";

        /// <summary>
        /// The BrowseName for the Modified component.
        /// </summary>
        public const string Modified = "Modified";

        /// <summary>
        /// The BrowseName for the Name component.
        /// </summary>
        public const string Name = "Name";

        /// <summary>
        /// The BrowseName for the NodeVersion component.
        /// </summary>
        public const string NodeVersion = "NodeVersion";

        /// <summary>
        /// The BrowseName for the Operational component.
        /// </summary>
        public const string Operational = "Operational";

        /// <summary>
        /// The BrowseName for the ParameterSet component.
        /// </summary>
        public const string ParameterSet = "ParameterSet";

        /// <summary>
        /// The BrowseName for the ProgramManager component.
        /// </summary>
        public const string ProgramManager = "ProgramManager";

        /// <summary>
        /// The BrowseName for the ProgramManagerType component.
        /// </summary>
        public const string ProgramManagerType = "ProgramManagerType";

        /// <summary>
        /// The BrowseName for the ProgramTemplateSet component.
        /// </summary>
        public const string ProgramTemplateSet = "ProgramTemplateSet";

        /// <summary>
        /// The BrowseName for the ProgramTemplateSetType component.
        /// </summary>
        public const string ProgramTemplateSetType = "ProgramTemplateSetType";

        /// <summary>
        /// The BrowseName for the ProgramTemplateType component.
        /// </summary>
        public const string ProgramTemplateType = "ProgramTemplateType";

        /// <summary>
        /// The BrowseName for the Property component.
        /// </summary>
        public const string Property = "Property";

        /// <summary>
        /// The BrowseName for the RawValue component.
        /// </summary>
        public const string RawValue = "RawValue";

        /// <summary>
        /// The BrowseName for the ResultSet component.
        /// </summary>
        public const string ResultSet = "ResultSet";

        /// <summary>
        /// The BrowseName for the ResultSetType component.
        /// </summary>
        public const string ResultSetType = "ResultSetType";

        /// <summary>
        /// The BrowseName for the SensorValue component.
        /// </summary>
        public const string SensorValue = "SensorValue";

        /// <summary>
        /// The BrowseName for the Status component.
        /// </summary>
        public const string Status = "Status";

        /// <summary>
        /// The BrowseName for the SupportedPropertySet component.
        /// </summary>
        public const string SupportedPropertySet = "SupportedPropertySet";

        /// <summary>
        /// The BrowseName for the SupportedPropertySetType component.
        /// </summary>
        public const string SupportedPropertySetType = "SupportedPropertySetType";

        /// <summary>
        /// The BrowseName for the TemplateID component.
        /// </summary>
        public const string TemplateID = "TemplateID";

        /// <summary>
        /// The BrowseName for the Tuning component.
        /// </summary>
        public const string Tuning = "Tuning";

        /// <summary>
        /// The BrowseName for the Version component.
        /// </summary>
        public const string Version = "Version";
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
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the LADS namespace (.NET code namespace is 'Spectaris.LADS').
        /// </summary>
        public const string LADS = "http://spectaris.de/LADS/";

        /// <summary>
        /// The URI for the LADSXsd namespace (.NET code namespace is 'Spectaris.LADS').
        /// </summary>
        public const string LADSXsd = "http://spectaris.de/LADS/Types.xsd";
    }
    #endregion
}