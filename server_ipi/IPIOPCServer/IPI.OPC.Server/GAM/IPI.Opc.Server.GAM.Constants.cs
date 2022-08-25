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

namespace IPI.Opc.Server.GAM
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
        /// The identifier for the GAMDeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint GAMDeviceType_Lock_InitLock = 100;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint GAMDeviceType_Lock_RenewLock = 103;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint GAMDeviceType_Lock_ExitLock = 105;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint GAMDeviceType_Lock_BreakLock = 107;

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_Lock_InitLock = 167;

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_Lock_RenewLock = 170;

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_Lock_ExitLock = 172;

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_Lock_BreakLock = 174;
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
        /// The identifier for the GAMDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_NetworkAddress = 176;

        /// <summary>
        /// The identifier for the GAMDeviceType_Watchdog Object.
        /// </summary>
        public const uint GAMDeviceType_Watchdog = 29;

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus Object.
        /// </summary>
        public const uint GAMDeviceType_SystemStatus = 63;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters Object.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters = 198;
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
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public const uint GenericSensorType = 1;

        /// <summary>
        /// The identifier for the GenericActuatorType ObjectType.
        /// </summary>
        public const uint GenericActuatorType = 8;

        /// <summary>
        /// The identifier for the WatchdogType ObjectType.
        /// </summary>
        public const uint WatchdogType = 15;

        /// <summary>
        /// The identifier for the GAMSystemStatusType ObjectType.
        /// </summary>
        public const uint GAMSystemStatusType = 57;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType ObjectType.
        /// </summary>
        public const uint ReadbackTuneParametersType = 75;

        /// <summary>
        /// The identifier for the GAMDeviceType ObjectType.
        /// </summary>
        public const uint GAMDeviceType = 28;
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
        /// The identifier for the GenericSensorType_Output Variable.
        /// </summary>
        public const uint GenericSensorType_Output = 2;

        /// <summary>
        /// The identifier for the GenericSensorType_Output_EngineeringUnits Variable.
        /// </summary>
        public const uint GenericSensorType_Output_EngineeringUnits = 7;

        /// <summary>
        /// The identifier for the GenericActuatorType_Input Variable.
        /// </summary>
        public const uint GenericActuatorType_Input = 9;

        /// <summary>
        /// The identifier for the GenericActuatorType_Input_EURange Variable.
        /// </summary>
        public const uint GenericActuatorType_Input_EURange = 13;

        /// <summary>
        /// The identifier for the WatchdogType_Trigger Variable.
        /// </summary>
        public const uint WatchdogType_Trigger = 16;

        /// <summary>
        /// The identifier for the WatchdogType_Trigger_EURange Variable.
        /// </summary>
        public const uint WatchdogType_Trigger_EURange = 20;

        /// <summary>
        /// The identifier for the WatchdogType_Counter Variable.
        /// </summary>
        public const uint WatchdogType_Counter = 22;

        /// <summary>
        /// The identifier for the WatchdogType_Counter_EURange Variable.
        /// </summary>
        public const uint WatchdogType_Counter_EURange = 26;

        /// <summary>
        /// The identifier for the GAMSystemStatusType_AutomaticMode Variable.
        /// </summary>
        public const uint GAMSystemStatusType_AutomaticMode = 58;

        /// <summary>
        /// The identifier for the GAMSystemStatusType_GAMOK Variable.
        /// </summary>
        public const uint GAMSystemStatusType_GAMOK = 59;

        /// <summary>
        /// The identifier for the GAMSystemStatusType_GAMtemperatureOver35DegreeC Variable.
        /// </summary>
        public const uint GAMSystemStatusType_GAMtemperatureOver35DegreeC = 60;

        /// <summary>
        /// The identifier for the GAMSystemStatusType_ManualMode Variable.
        /// </summary>
        public const uint GAMSystemStatusType_ManualMode = 61;

        /// <summary>
        /// The identifier for the GAMSystemStatusType_SystemStatusText Variable.
        /// </summary>
        public const uint GAMSystemStatusType_SystemStatusText = 62;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_IonReference Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_IonReference = 76;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_IonReference_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_IonReference_EngineeringUnits = 81;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Cathode Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Cathode = 212;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Cathode_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Cathode_EngineeringUnits = 217;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Extraction Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Extraction = 218;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Extraction_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Extraction_EngineeringUnits = 223;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Focus Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Focus = 224;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Focus_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Focus_EngineeringUnits = 229;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FilamentCurrent Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_FilamentCurrent = 230;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FilamentCurrent_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_FilamentCurrent_EngineeringUnits = 235;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_EmissionCurrent Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_EmissionCurrent = 236;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_EmissionCurrent_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_EmissionCurrent_EngineeringUnits = 241;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Deflection Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Deflection = 242;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Deflection_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Deflection_EngineeringUnits = 247;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Prefilter Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Prefilter = 248;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Prefilter_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Prefilter_EngineeringUnits = 253;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SEMVoltage Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_SEMVoltage = 404;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SEMVoltage_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_SEMVoltage_EngineeringUnits = 409;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UVRatio Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_UVRatio = 260;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UVRatio_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_UVRatio_EngineeringUnits = 265;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FieldAxis Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_FieldAxis = 266;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FieldAxis_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_FieldAxis_EngineeringUnits = 271;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SelectedFilament Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_SelectedFilament = 272;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SelectedFilament_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_SelectedFilament_EngineeringUnits = 277;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Resolution Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Resolution = 278;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Resolution_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Resolution_EngineeringUnits = 283;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Slope Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Slope = 284;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Slope_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Slope_EngineeringUnits = 289;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UOffset Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_UOffset = 290;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UOffset_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_UOffset_EngineeringUnits = 295;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorType Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_DetectorType = 296;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorType_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_DetectorType_EngineeringUnits = 301;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorInputPin Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_DetectorInputPin = 302;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorInputPin_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_DetectorInputPin_EngineeringUnits = 307;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FIREnabled Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_FIREnabled = 416;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FIREnabled_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_FIREnabled_EngineeringUnits = 421;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_Locked = 96;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_LockingClient = 97;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_LockingUser = 98;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_RemainingLockTime = 99;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_InitLock_InputArguments = 101;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_InitLock_OutputArguments = 102;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_RenewLock_OutputArguments = 104;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_ExitLock_OutputArguments = 106;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_BreakLock_OutputArguments = 108;

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_Lock_Locked = 163;

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_Lock_LockingClient = 164;

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_Lock_LockingUser = 165;

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_Lock_RemainingLockTime = 166;

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 168;

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 169;

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 171;

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 173;

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 175;

        /// <summary>
        /// The identifier for the GAMDeviceType_Watchdog_Trigger Variable.
        /// </summary>
        public const uint GAMDeviceType_Watchdog_Trigger = 30;

        /// <summary>
        /// The identifier for the GAMDeviceType_Watchdog_Trigger_EURange Variable.
        /// </summary>
        public const uint GAMDeviceType_Watchdog_Trigger_EURange = 34;

        /// <summary>
        /// The identifier for the GAMDeviceType_Watchdog_Counter Variable.
        /// </summary>
        public const uint GAMDeviceType_Watchdog_Counter = 36;

        /// <summary>
        /// The identifier for the GAMDeviceType_Watchdog_Counter_EURange Variable.
        /// </summary>
        public const uint GAMDeviceType_Watchdog_Counter_EURange = 40;

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_AutomaticMode Variable.
        /// </summary>
        public const uint GAMDeviceType_SystemStatus_AutomaticMode = 64;

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_GAMOK Variable.
        /// </summary>
        public const uint GAMDeviceType_SystemStatus_GAMOK = 65;

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_GAMtemperatureOver35DegreeC Variable.
        /// </summary>
        public const uint GAMDeviceType_SystemStatus_GAMtemperatureOver35DegreeC = 66;

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_ManualMode Variable.
        /// </summary>
        public const uint GAMDeviceType_SystemStatus_ManualMode = 67;

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_SystemStatusText Variable.
        /// </summary>
        public const uint GAMDeviceType_SystemStatus_SystemStatusText = 68;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_IonReference Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_IonReference = 199;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_IonReference_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_IonReference_EngineeringUnits = 204;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Cathode Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Cathode = 308;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Cathode_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Cathode_EngineeringUnits = 313;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Extraction Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Extraction = 314;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Extraction_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Extraction_EngineeringUnits = 319;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Focus Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Focus = 320;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Focus_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Focus_EngineeringUnits = 325;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_FilamentCurrent Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_FilamentCurrent = 326;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_FilamentCurrent_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_FilamentCurrent_EngineeringUnits = 331;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_EmissionCurrent Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_EmissionCurrent = 332;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_EmissionCurrent_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_EmissionCurrent_EngineeringUnits = 337;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Deflection Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Deflection = 338;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Deflection_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Deflection_EngineeringUnits = 343;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Prefilter Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Prefilter = 344;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Prefilter_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Prefilter_EngineeringUnits = 349;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_SEMVoltage Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_SEMVoltage = 410;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_SEMVoltage_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_SEMVoltage_EngineeringUnits = 415;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_UVRatio Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_UVRatio = 356;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_UVRatio_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_UVRatio_EngineeringUnits = 361;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_FieldAxis Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_FieldAxis = 362;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_FieldAxis_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_FieldAxis_EngineeringUnits = 367;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_SelectedFilament Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_SelectedFilament = 368;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_SelectedFilament_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_SelectedFilament_EngineeringUnits = 373;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Resolution Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Resolution = 374;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Resolution_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Resolution_EngineeringUnits = 379;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Slope Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Slope = 380;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Slope_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_Slope_EngineeringUnits = 385;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_UOffset Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_UOffset = 386;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_UOffset_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_UOffset_EngineeringUnits = 391;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_DetectorType Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_DetectorType = 392;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_DetectorType_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_DetectorType_EngineeringUnits = 397;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_DetectorInputPin Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_DetectorInputPin = 398;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_DetectorInputPin_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_DetectorInputPin_EngineeringUnits = 403;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_FIREnabled Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_FIREnabled = 422;

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_FIREnabled_EngineeringUnits Variable.
        /// </summary>
        public const uint GAMDeviceType_ReadbackTuneParameters_FIREnabled_EngineeringUnits = 427;
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
        /// The identifier for the GAMDeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_InitLock = new ExpandedNodeId(IPI.Opc.Server.GAM.Methods.GAMDeviceType_Lock_InitLock, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_RenewLock = new ExpandedNodeId(IPI.Opc.Server.GAM.Methods.GAMDeviceType_Lock_RenewLock, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_ExitLock = new ExpandedNodeId(IPI.Opc.Server.GAM.Methods.GAMDeviceType_Lock_ExitLock, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_BreakLock = new ExpandedNodeId(IPI.Opc.Server.GAM.Methods.GAMDeviceType_Lock_BreakLock, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(IPI.Opc.Server.GAM.Methods.GAMDeviceType_CPIdentifier_Lock_InitLock, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(IPI.Opc.Server.GAM.Methods.GAMDeviceType_CPIdentifier_Lock_RenewLock, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(IPI.Opc.Server.GAM.Methods.GAMDeviceType_CPIdentifier_Lock_ExitLock, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(IPI.Opc.Server.GAM.Methods.GAMDeviceType_CPIdentifier_Lock_BreakLock, IPI.Opc.Server.GAM.Namespaces.GAM);
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
        /// The identifier for the GAMDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(IPI.Opc.Server.GAM.Objects.GAMDeviceType_CPIdentifier_NetworkAddress, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Watchdog Object.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Watchdog = new ExpandedNodeId(IPI.Opc.Server.GAM.Objects.GAMDeviceType_Watchdog, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus Object.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_SystemStatus = new ExpandedNodeId(IPI.Opc.Server.GAM.Objects.GAMDeviceType_SystemStatus, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters Object.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters = new ExpandedNodeId(IPI.Opc.Server.GAM.Objects.GAMDeviceType_ReadbackTuneParameters, IPI.Opc.Server.GAM.Namespaces.GAM);
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
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType = new ExpandedNodeId(IPI.Opc.Server.GAM.ObjectTypes.GenericSensorType, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GenericActuatorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType = new ExpandedNodeId(IPI.Opc.Server.GAM.ObjectTypes.GenericActuatorType, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the WatchdogType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId WatchdogType = new ExpandedNodeId(IPI.Opc.Server.GAM.ObjectTypes.WatchdogType, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMSystemStatusType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GAMSystemStatusType = new ExpandedNodeId(IPI.Opc.Server.GAM.ObjectTypes.GAMSystemStatusType, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType = new ExpandedNodeId(IPI.Opc.Server.GAM.ObjectTypes.ReadbackTuneParametersType, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType = new ExpandedNodeId(IPI.Opc.Server.GAM.ObjectTypes.GAMDeviceType, IPI.Opc.Server.GAM.Namespaces.GAM);
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
        /// The identifier for the GenericSensorType_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Output = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GenericSensorType_Output, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GenericSensorType_Output_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Output_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GenericSensorType_Output_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GenericActuatorType_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Input = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GenericActuatorType_Input, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GenericActuatorType_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Input_EURange = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GenericActuatorType_Input_EURange, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the WatchdogType_Trigger Variable.
        /// </summary>
        public static readonly ExpandedNodeId WatchdogType_Trigger = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.WatchdogType_Trigger, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the WatchdogType_Trigger_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId WatchdogType_Trigger_EURange = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.WatchdogType_Trigger_EURange, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the WatchdogType_Counter Variable.
        /// </summary>
        public static readonly ExpandedNodeId WatchdogType_Counter = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.WatchdogType_Counter, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the WatchdogType_Counter_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId WatchdogType_Counter_EURange = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.WatchdogType_Counter_EURange, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMSystemStatusType_AutomaticMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMSystemStatusType_AutomaticMode = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMSystemStatusType_AutomaticMode, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMSystemStatusType_GAMOK Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMSystemStatusType_GAMOK = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMSystemStatusType_GAMOK, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMSystemStatusType_GAMtemperatureOver35DegreeC Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMSystemStatusType_GAMtemperatureOver35DegreeC = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMSystemStatusType_GAMtemperatureOver35DegreeC, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMSystemStatusType_ManualMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMSystemStatusType_ManualMode = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMSystemStatusType_ManualMode, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMSystemStatusType_SystemStatusText Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMSystemStatusType_SystemStatusText = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMSystemStatusType_SystemStatusText, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_IonReference Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_IonReference = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_IonReference, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_IonReference_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_IonReference_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_IonReference_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Cathode Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Cathode = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Cathode, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Cathode_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Cathode_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Cathode_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Extraction Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Extraction = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Extraction, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Extraction_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Extraction_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Extraction_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Focus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Focus = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Focus, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Focus_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Focus_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Focus_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FilamentCurrent Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_FilamentCurrent = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_FilamentCurrent, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FilamentCurrent_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_FilamentCurrent_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_FilamentCurrent_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_EmissionCurrent Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_EmissionCurrent = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_EmissionCurrent, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_EmissionCurrent_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_EmissionCurrent_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_EmissionCurrent_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Deflection Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Deflection = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Deflection, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Deflection_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Deflection_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Deflection_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Prefilter Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Prefilter = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Prefilter, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Prefilter_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Prefilter_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Prefilter_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SEMVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_SEMVoltage = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_SEMVoltage, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SEMVoltage_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_SEMVoltage_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_SEMVoltage_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UVRatio Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_UVRatio = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_UVRatio, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UVRatio_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_UVRatio_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_UVRatio_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FieldAxis Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_FieldAxis = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_FieldAxis, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FieldAxis_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_FieldAxis_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_FieldAxis_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SelectedFilament Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_SelectedFilament = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_SelectedFilament, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SelectedFilament_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_SelectedFilament_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_SelectedFilament_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Resolution Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Resolution = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Resolution, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Resolution_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Resolution_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Resolution_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Slope Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Slope = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Slope, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Slope_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Slope_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_Slope_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UOffset Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_UOffset = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_UOffset, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UOffset_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_UOffset_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_UOffset_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorType Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_DetectorType = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_DetectorType, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorType_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_DetectorType_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_DetectorType_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorInputPin Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_DetectorInputPin = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_DetectorInputPin, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorInputPin_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_DetectorInputPin_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_DetectorInputPin_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FIREnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_FIREnabled = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_FIREnabled, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FIREnabled_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_FIREnabled_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.ReadbackTuneParametersType_FIREnabled_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_Locked = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_Lock_Locked, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_LockingClient = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_Lock_LockingClient, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_LockingUser = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_Lock_LockingUser, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_Lock_RemainingLockTime, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_Lock_InitLock_InputArguments, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_Lock_InitLock_OutputArguments, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_Lock_RenewLock_OutputArguments, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_Lock_ExitLock_OutputArguments, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_Lock_BreakLock_OutputArguments, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_CPIdentifier_Lock_Locked, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_CPIdentifier_Lock_LockingClient, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_CPIdentifier_Lock_LockingUser, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_CPIdentifier_Lock_RemainingLockTime, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_CPIdentifier_Lock_InitLock_InputArguments, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Watchdog_Trigger Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Watchdog_Trigger = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_Watchdog_Trigger, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Watchdog_Trigger_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Watchdog_Trigger_EURange = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_Watchdog_Trigger_EURange, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Watchdog_Counter Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Watchdog_Counter = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_Watchdog_Counter, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Watchdog_Counter_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Watchdog_Counter_EURange = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_Watchdog_Counter_EURange, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_AutomaticMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_SystemStatus_AutomaticMode = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_SystemStatus_AutomaticMode, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_GAMOK Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_SystemStatus_GAMOK = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_SystemStatus_GAMOK, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_GAMtemperatureOver35DegreeC Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_SystemStatus_GAMtemperatureOver35DegreeC = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_SystemStatus_GAMtemperatureOver35DegreeC, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_ManualMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_SystemStatus_ManualMode = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_SystemStatus_ManualMode, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_SystemStatusText Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_SystemStatus_SystemStatusText = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_SystemStatus_SystemStatusText, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_IonReference Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_IonReference = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_IonReference, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_IonReference_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_IonReference_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_IonReference_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Cathode Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Cathode = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Cathode, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Cathode_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Cathode_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Cathode_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Extraction Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Extraction = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Extraction, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Extraction_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Extraction_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Extraction_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Focus Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Focus = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Focus, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Focus_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Focus_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Focus_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_FilamentCurrent Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_FilamentCurrent = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_FilamentCurrent, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_FilamentCurrent_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_FilamentCurrent_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_FilamentCurrent_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_EmissionCurrent Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_EmissionCurrent = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_EmissionCurrent, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_EmissionCurrent_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_EmissionCurrent_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_EmissionCurrent_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Deflection Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Deflection = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Deflection, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Deflection_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Deflection_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Deflection_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Prefilter Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Prefilter = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Prefilter, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Prefilter_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Prefilter_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Prefilter_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_SEMVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_SEMVoltage = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_SEMVoltage, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_SEMVoltage_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_SEMVoltage_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_SEMVoltage_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_UVRatio Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_UVRatio = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_UVRatio, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_UVRatio_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_UVRatio_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_UVRatio_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_FieldAxis Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_FieldAxis = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_FieldAxis, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_FieldAxis_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_FieldAxis_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_FieldAxis_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_SelectedFilament Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_SelectedFilament = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_SelectedFilament, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_SelectedFilament_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_SelectedFilament_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_SelectedFilament_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Resolution Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Resolution = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Resolution, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Resolution_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Resolution_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Resolution_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Slope Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Slope = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Slope, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_Slope_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_Slope_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_Slope_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_UOffset Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_UOffset = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_UOffset, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_UOffset_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_UOffset_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_UOffset_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_DetectorType Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_DetectorType = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_DetectorType, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_DetectorType_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_DetectorType_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_DetectorType_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_DetectorInputPin Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_DetectorInputPin = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_DetectorInputPin, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_DetectorInputPin_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_DetectorInputPin_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_DetectorInputPin_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_FIREnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_FIREnabled = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_FIREnabled, IPI.Opc.Server.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_ReadbackTuneParameters_FIREnabled_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_ReadbackTuneParameters_FIREnabled_EngineeringUnits = new ExpandedNodeId(IPI.Opc.Server.GAM.Variables.GAMDeviceType_ReadbackTuneParameters_FIREnabled_EngineeringUnits, IPI.Opc.Server.GAM.Namespaces.GAM);
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
        /// The BrowseName for the AutomaticMode component.
        /// </summary>
        public const string AutomaticMode = "AutomaticMode";

        /// <summary>
        /// The BrowseName for the Cathode component.
        /// </summary>
        public const string Cathode = "Cathode";

        /// <summary>
        /// The BrowseName for the Counter component.
        /// </summary>
        public const string Counter = "Counter";

        /// <summary>
        /// The BrowseName for the Deflection component.
        /// </summary>
        public const string Deflection = "Deflection";

        /// <summary>
        /// The BrowseName for the DetectorInputPin component.
        /// </summary>
        public const string DetectorInputPin = "DetectorInputPin";

        /// <summary>
        /// The BrowseName for the DetectorType component.
        /// </summary>
        public const string DetectorType = "DetectorType";

        /// <summary>
        /// The BrowseName for the EmissionCurrent component.
        /// </summary>
        public const string EmissionCurrent = "EmissionCurrent";

        /// <summary>
        /// The BrowseName for the Extraction component.
        /// </summary>
        public const string Extraction = "Extraction";

        /// <summary>
        /// The BrowseName for the FieldAxis component.
        /// </summary>
        public const string FieldAxis = "FieldAxis";

        /// <summary>
        /// The BrowseName for the FilamentCurrent component.
        /// </summary>
        public const string FilamentCurrent = "FilamentCurrent";

        /// <summary>
        /// The BrowseName for the FIREnabled component.
        /// </summary>
        public const string FIREnabled = "FIREnabled";

        /// <summary>
        /// The BrowseName for the Focus component.
        /// </summary>
        public const string Focus = "Focus";

        /// <summary>
        /// The BrowseName for the GAMDeviceType component.
        /// </summary>
        public const string GAMDeviceType = "GAMDeviceType";

        /// <summary>
        /// The BrowseName for the GAMOK component.
        /// </summary>
        public const string GAMOK = "GAMOK";

        /// <summary>
        /// The BrowseName for the GAMSystemStatusType component.
        /// </summary>
        public const string GAMSystemStatusType = "GAMSystemStatusType";

        /// <summary>
        /// The BrowseName for the GAMtemperatureOver35DegreeC component.
        /// </summary>
        public const string GAMtemperatureOver35DegreeC = "GAMtemperatureOver35DegreeC";

        /// <summary>
        /// The BrowseName for the GenericActuatorType component.
        /// </summary>
        public const string GenericActuatorType = "GenericActuatorType";

        /// <summary>
        /// The BrowseName for the GenericSensorType component.
        /// </summary>
        public const string GenericSensorType = "GenericSensorType";

        /// <summary>
        /// The BrowseName for the Input component.
        /// </summary>
        public const string Input = "Input";

        /// <summary>
        /// The BrowseName for the IonReference component.
        /// </summary>
        public const string IonReference = "IonReference";

        /// <summary>
        /// The BrowseName for the ManualMode component.
        /// </summary>
        public const string ManualMode = "ManualMode";

        /// <summary>
        /// The BrowseName for the Output component.
        /// </summary>
        public const string Output = "Output";

        /// <summary>
        /// The BrowseName for the Prefilter component.
        /// </summary>
        public const string Prefilter = "Prefilter";

        /// <summary>
        /// The BrowseName for the ReadbackTuneParameters component.
        /// </summary>
        public const string ReadbackTuneParameters = "ReadbackTuneParameters";

        /// <summary>
        /// The BrowseName for the ReadbackTuneParametersType component.
        /// </summary>
        public const string ReadbackTuneParametersType = "ReadbackTuneParametersType";

        /// <summary>
        /// The BrowseName for the Resolution component.
        /// </summary>
        public const string Resolution = "Resolution";

        /// <summary>
        /// The BrowseName for the SelectedFilament component.
        /// </summary>
        public const string SelectedFilament = "SelectedFilament";

        /// <summary>
        /// The BrowseName for the SEMVoltage component.
        /// </summary>
        public const string SEMVoltage = "SEMVoltage";

        /// <summary>
        /// The BrowseName for the Slope component.
        /// </summary>
        public const string Slope = "Slope";

        /// <summary>
        /// The BrowseName for the SystemStatus component.
        /// </summary>
        public const string SystemStatus = "SystemStatus";

        /// <summary>
        /// The BrowseName for the SystemStatusText component.
        /// </summary>
        public const string SystemStatusText = "SystemStatusText";

        /// <summary>
        /// The BrowseName for the Trigger component.
        /// </summary>
        public const string Trigger = "Trigger";

        /// <summary>
        /// The BrowseName for the UOffset component.
        /// </summary>
        public const string UOffset = "UOffset";

        /// <summary>
        /// The BrowseName for the UVRatio component.
        /// </summary>
        public const string UVRatio = "UVRatio";

        /// <summary>
        /// The BrowseName for the Watchdog component.
        /// </summary>
        public const string Watchdog = "Watchdog";

        /// <summary>
        /// The BrowseName for the WatchdogType component.
        /// </summary>
        public const string WatchdogType = "WatchdogType";
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
        /// The URI for the GAM namespace (.NET code namespace is 'IPI.Opc.Server.GAM').
        /// </summary>
        public const string GAM = "http://in-process.com/UA/GAM/";

        /// <summary>
        /// The URI for the GAMXsd namespace (.NET code namespace is 'IPI.Opc.Server.GAM').
        /// </summary>
        public const string GAMXsd = "http://in-process.com/UA/GAM/Types.xsd";
    }
    #endregion
}