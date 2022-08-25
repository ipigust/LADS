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
using Spectaris.LADS;

namespace IPI.OpcUaServer.GAM
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
        /// The identifier for the GAMStateMachineType_Start Method.
        /// </summary>
        public const uint GAMStateMachineType_Start = 623;

        /// <summary>
        /// The identifier for the GAMStateMachineType_Stop Method.
        /// </summary>
        public const uint GAMStateMachineType_Stop = 628;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Start Method.
        /// </summary>
        public const uint GAMMeasureStateMachineType_Start = 5473;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Stop Method.
        /// </summary>
        public const uint GAMMeasureStateMachineType_Stop = 5478;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_InitLock Method.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Lock_InitLock = 5139;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_RenewLock Method.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Lock_RenewLock = 5142;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_ExitLock Method.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Lock_ExitLock = 5144;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_BreakLock Method.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Lock_BreakLock = 5146;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_Disable = 5185;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_Enable = 5186;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_AddComment = 5187;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_Acknowledge = 5207;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve = 5254;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve = 5256;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve = 5257;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Lock_InitLock = 1041;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Lock_RenewLock = 1044;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Lock_ExitLock = 1046;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Lock_BreakLock = 1048;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_Disable = 1087;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_Enable = 1088;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_AddComment = 1089;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_Acknowledge = 1109;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_TimedShelve = 1156;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_Unshelve = 1158;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_OneShotShelve = 1159;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Lock_InitLock = 1254;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Lock_RenewLock = 1257;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Lock_ExitLock = 1259;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Lock_BreakLock = 1261;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_Disable = 1300;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_Enable = 1301;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_AddComment = 1302;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_Acknowledge = 1322;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_TimedShelve = 1369;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_Unshelve = 1371;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_OneShotShelve = 1372;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Lock_InitLock = 1467;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Lock_RenewLock = 1470;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Lock_ExitLock = 1472;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Lock_BreakLock = 1474;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_Disable = 1513;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_Enable = 1514;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_AddComment = 1515;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_Acknowledge = 1535;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_TimedShelve = 1582;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_Unshelve = 1584;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_OneShotShelve = 1585;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Lock_InitLock = 1680;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Lock_RenewLock = 1683;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Lock_ExitLock = 1685;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Lock_BreakLock = 1687;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_Disable = 1726;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_Enable = 1727;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_AddComment = 1728;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_Acknowledge = 1748;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_TimedShelve = 1795;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_Unshelve = 1797;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_OneShotShelve = 1798;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock = 1893;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Lock_RenewLock = 1896;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Lock_ExitLock = 1898;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Lock_BreakLock = 1900;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Disable = 1939;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Enable = 1940;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AddComment = 1941;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Acknowledge = 1961;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_TimedShelve = 2008;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_Unshelve = 2010;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_OneShotShelve = 2011;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock = 2106;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Lock_RenewLock = 2109;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Lock_ExitLock = 2111;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Lock_BreakLock = 2113;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Disable = 2152;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Enable = 2153;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AddComment = 2154;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Acknowledge = 2174;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_TimedShelve = 2221;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_Unshelve = 2223;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_OneShotShelve = 2224;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Lock_InitLock = 2319;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Lock_RenewLock = 2322;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Lock_ExitLock = 2324;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Lock_BreakLock = 2326;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_Disable = 2365;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_Enable = 2366;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_AddComment = 2367;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_Acknowledge = 2387;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_TimedShelve = 2434;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_Unshelve = 2436;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_OneShotShelve = 2437;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Lock_InitLock = 2532;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Lock_RenewLock = 2535;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Lock_ExitLock = 2537;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Lock_BreakLock = 2539;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Disable = 2578;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Enable = 2579;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AddComment = 2580;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Acknowledge = 2600;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_TimedShelve = 2647;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_Unshelve = 2649;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_OneShotShelve = 2650;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock = 2745;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Lock_RenewLock = 2748;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Lock_ExitLock = 2750;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Lock_BreakLock = 2752;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Disable = 2791;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Enable = 2792;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AddComment = 2793;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Acknowledge = 2813;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_TimedShelve = 2860;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_Unshelve = 2862;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_OneShotShelve = 2863;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Lock_InitLock = 2958;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Lock_RenewLock = 2961;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Lock_ExitLock = 2963;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Lock_BreakLock = 2965;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Disable = 3004;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Enable = 3005;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AddComment = 3006;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Acknowledge = 3026;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_TimedShelve = 3073;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_Unshelve = 3075;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_OneShotShelve = 3076;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Lock_InitLock = 3171;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Lock_RenewLock = 3174;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Lock_ExitLock = 3176;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Lock_BreakLock = 3178;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Disable = 3217;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Enable = 3218;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AddComment = 3219;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Acknowledge = 3239;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_TimedShelve = 3286;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_Unshelve = 3288;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_OneShotShelve = 3289;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Lock_InitLock = 3597;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Lock_RenewLock = 3600;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Lock_ExitLock = 3602;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Lock_BreakLock = 3604;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_Disable = 3643;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_Enable = 3644;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_AddComment = 3645;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_Acknowledge = 3665;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_TimedShelve = 3712;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_Unshelve = 3714;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_OneShotShelve = 3715;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Lock_InitLock = 3810;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Lock_RenewLock = 3813;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Lock_ExitLock = 3815;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Lock_BreakLock = 3817;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_Disable = 3856;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_Enable = 3857;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_AddComment = 3858;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_Acknowledge = 3878;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_TimedShelve = 3925;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_Unshelve = 3927;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_OneShotShelve = 3928;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_InitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Lock_InitLock = 4023;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_RenewLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Lock_RenewLock = 4026;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_ExitLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Lock_ExitLock = 4028;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_BreakLock Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Lock_BreakLock = 4030;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Disable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_Disable = 4069;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Enable Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_Enable = 4070;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_AddComment Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_AddComment = 4071;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_Acknowledge = 4091;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_TimedShelve = 4138;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_Unshelve = 4140;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_OneShotShelve = 4141;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint GAMDeviceType_Lock_InitLock = 156;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint GAMDeviceType_Lock_RenewLock = 159;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint GAMDeviceType_Lock_ExitLock = 161;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint GAMDeviceType_Lock_BreakLock = 163;
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
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState = 5303;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational Object.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Operational = 5317;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference = 1030;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_ParameterSet = 1031;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState = 1205;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Operational = 1219;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode = 1243;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_ParameterSet = 1244;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState = 1418;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Operational = 1432;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction = 1456;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_ParameterSet = 1457;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState = 1631;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Operational = 1645;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus = 1669;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_ParameterSet = 1670;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState = 1844;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Operational = 1858;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent = 1882;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_ParameterSet = 1883;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState = 2057;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Operational = 2071;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent = 2095;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_ParameterSet = 2096;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState = 2270;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Operational = 2284;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection = 2308;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_ParameterSet = 2309;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState = 2483;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Operational = 2497;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter = 2521;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_ParameterSet = 2522;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState = 2696;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Operational = 2710;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage = 2734;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_ParameterSet = 2735;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState = 2909;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Operational = 2923;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio = 2947;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_ParameterSet = 2948;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState = 3122;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Operational = 3136;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis = 3160;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_ParameterSet = 3161;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState = 3335;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Operational = 3349;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution = 3586;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_ParameterSet = 3587;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState = 3761;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Operational = 3775;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope = 3799;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_ParameterSet = 3800;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState = 3974;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Operational = 3988;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset = 4012;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_ParameterSet Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_ParameterSet = 4013;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState = 4187;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational Object.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Operational = 4201;

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus Object.
        /// </summary>
        public const uint GAMDeviceType_SystemStatus = 224;
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
        /// The identifier for the GAMStateMachineType ObjectType.
        /// </summary>
        public const uint GAMStateMachineType = 562;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType ObjectType.
        /// </summary>
        public const uint GAMMeasureStateMachineType = 5412;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType ObjectType.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionOperationalType = 5110;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType ObjectType.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType = 5126;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType ObjectType.
        /// </summary>
        public const uint TuneParametersFunctionSetType = 1029;

        /// <summary>
        /// The identifier for the WatchdogType ObjectType.
        /// </summary>
        public const uint WatchdogType = 15;

        /// <summary>
        /// The identifier for the GAMSystemStatusType ObjectType.
        /// </summary>
        public const uint GAMSystemStatusType = 28;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType ObjectType.
        /// </summary>
        public const uint ReadbackTuneParametersType = 34;

        /// <summary>
        /// The identifier for the MCDValueType ObjectType.
        /// </summary>
        public const uint MCDValueType = 900;

        /// <summary>
        /// The identifier for the GAMDeviceType ObjectType.
        /// </summary>
        public const uint GAMDeviceType = 143;
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
        /// The identifier for the GAMStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public const uint GAMStateMachineType_CurrentState_Id = 564;

        /// <summary>
        /// The identifier for the GAMStateMachineType_CurrentState_Number Variable.
        /// </summary>
        public const uint GAMStateMachineType_CurrentState_Number = 566;

        /// <summary>
        /// The identifier for the GAMStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public const uint GAMStateMachineType_LastTransition_Id = 569;

        /// <summary>
        /// The identifier for the GAMStateMachineType_LastTransition_Number Variable.
        /// </summary>
        public const uint GAMStateMachineType_LastTransition_Number = 571;

        /// <summary>
        /// The identifier for the GAMStateMachineType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint GAMStateMachineType_LastTransition_TransitionTime = 572;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint GAMStateMachineType_ProgramDiagnostic_CreateSessionId = 584;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint GAMStateMachineType_ProgramDiagnostic_CreateClientName = 585;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint GAMStateMachineType_ProgramDiagnostic_InvocationCreationTime = 586;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint GAMStateMachineType_ProgramDiagnostic_LastTransitionTime = 587;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint GAMStateMachineType_ProgramDiagnostic_LastMethodCall = 588;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint GAMStateMachineType_ProgramDiagnostic_LastMethodSessionId = 589;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint GAMStateMachineType_ProgramDiagnostic_LastMethodInputArguments = 590;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint GAMStateMachineType_ProgramDiagnostic_LastMethodOutputArguments = 591;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint GAMStateMachineType_ProgramDiagnostic_LastMethodInputValues = 592;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint GAMStateMachineType_ProgramDiagnostic_LastMethodOutputValues = 593;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint GAMStateMachineType_ProgramDiagnostic_LastMethodCallTime = 594;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint GAMStateMachineType_ProgramDiagnostic_LastMethodReturnStatus = 595;

        /// <summary>
        /// The identifier for the GAMStateMachineType_Halted_StateNumber Variable.
        /// </summary>
        public const uint GAMStateMachineType_Halted_StateNumber = 598;

        /// <summary>
        /// The identifier for the GAMStateMachineType_Ready_StateNumber Variable.
        /// </summary>
        public const uint GAMStateMachineType_Ready_StateNumber = 600;

        /// <summary>
        /// The identifier for the GAMStateMachineType_Running_StateNumber Variable.
        /// </summary>
        public const uint GAMStateMachineType_Running_StateNumber = 602;

        /// <summary>
        /// The identifier for the GAMStateMachineType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint GAMStateMachineType_Suspended_StateNumber = 604;

        /// <summary>
        /// The identifier for the GAMStateMachineType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GAMStateMachineType_HaltedToReady_TransitionNumber = 606;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GAMStateMachineType_ReadyToRunning_TransitionNumber = 608;

        /// <summary>
        /// The identifier for the GAMStateMachineType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GAMStateMachineType_RunningToHalted_TransitionNumber = 610;

        /// <summary>
        /// The identifier for the GAMStateMachineType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GAMStateMachineType_RunningToReady_TransitionNumber = 612;

        /// <summary>
        /// The identifier for the GAMStateMachineType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint GAMStateMachineType_RunningToSuspended_TransitionNumber = 614;

        /// <summary>
        /// The identifier for the GAMStateMachineType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GAMStateMachineType_SuspendedToRunning_TransitionNumber = 616;

        /// <summary>
        /// The identifier for the GAMStateMachineType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GAMStateMachineType_SuspendedToHalted_TransitionNumber = 618;

        /// <summary>
        /// The identifier for the GAMStateMachineType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GAMStateMachineType_SuspendedToReady_TransitionNumber = 620;

        /// <summary>
        /// The identifier for the GAMStateMachineType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GAMStateMachineType_ReadyToHalted_TransitionNumber = 622;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_CurrentState_Id = 5414;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_CurrentState_Number Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_CurrentState_Number = 5416;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_LastTransition_Id = 5419;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_LastTransition_Number Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_LastTransition_Number = 5421;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_LastTransition_TransitionTime Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_LastTransition_TransitionTime = 5422;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ProgramDiagnostic_CreateSessionId = 5434;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ProgramDiagnostic_CreateClientName = 5435;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ProgramDiagnostic_InvocationCreationTime = 5436;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ProgramDiagnostic_LastTransitionTime = 5437;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodCall = 5438;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodSessionId = 5439;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodInputArguments = 5440;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodOutputArguments = 5441;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodInputValues = 5442;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodOutputValues = 5443;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodCallTime = 5444;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodReturnStatus = 5445;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Halted_StateNumber Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_Halted_StateNumber = 5448;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Ready_StateNumber Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_Ready_StateNumber = 5450;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Running_StateNumber Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_Running_StateNumber = 5452;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Suspended_StateNumber Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_Suspended_StateNumber = 5454;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_HaltedToReady_TransitionNumber = 5456;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ReadyToRunning_TransitionNumber = 5458;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_RunningToHalted_TransitionNumber = 5460;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_RunningToReady_TransitionNumber = 5462;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_RunningToSuspended_TransitionNumber = 5464;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_SuspendedToRunning_TransitionNumber = 5466;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_SuspendedToHalted_TransitionNumber = 5468;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_SuspendedToReady_TransitionNumber = 5470;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_ReadyToHalted_TransitionNumber = 5472;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Start_InputArguments Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_Start_InputArguments = 5479;

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Start_OutputArguments Variable.
        /// </summary>
        public const uint GAMMeasureStateMachineType_Start_OutputArguments = 5480;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType_RawValue Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionOperationalType_RawValue = 5114;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType_RawValue_EURange Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionOperationalType_RawValue_EURange = 5118;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionOperationalType_RawValue_EngineeringUnits = 5119;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType_SensorValue Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionOperationalType_SensorValue = 5120;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType_SensorValue_EURange Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionOperationalType_SensorValue_EURange = 5124;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionOperationalType_SensorValue_EngineeringUnits = 5125;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_Locked Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Lock_Locked = 5135;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_LockingClient Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Lock_LockingClient = 5136;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_LockingUser Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Lock_LockingUser = 5137;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Lock_RemainingLockTime = 5138;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Lock_InitLock_InputArguments = 5140;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Lock_InitLock_OutputArguments = 5141;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Lock_RenewLock_OutputArguments = 5143;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Lock_ExitLock_OutputArguments = 5145;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Lock_BreakLock_OutputArguments = 5147;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_EventId = 5153;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_EventType = 5154;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_SourceNode = 5155;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_SourceName = 5156;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_Time = 5157;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ReceiveTime = 5158;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_Message = 5160;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_Severity = 5161;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionClassId = 5162;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionClassName = 5163;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionName = 5166;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_BranchId = 5167;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_Retain = 5168;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_EnabledState = 5169;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_EnabledState_Id = 5170;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_Quality = 5178;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp = 5179;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_LastSeverity = 5180;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = 5181;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_Comment = 5182;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp = 5183;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ClientUserId = 5184;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_AddComment_InputArguments = 5188;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_AckedState = 5189;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_AckedState_Id = 5190;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ConfirmedState_Id = 5199;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments = 5208;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_Confirm_InputArguments = 5210;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ActiveState = 5211;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ActiveState_Id = 5212;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_InputNode = 5220;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_SuppressedState_Id = 5222;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_OutOfServiceState_Id = 5231;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState = 5240;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id = 5241;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id = 5246;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime = 5253;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 5255;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_SuppressedOrShelved = 5258;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_SilenceState_Id = 5266;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_LatchedState_Id = 5279;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState = 5304;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id = 5305;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id = 5310;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_ParameterSet_CompensationValue_EURange = 5324;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits = 5325;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational_RawValue Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Operational_RawValue = 5329;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Operational_RawValue_EURange = 5333;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Operational_RawValue_EngineeringUnits = 5334;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational_SensorValue Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Operational_SensorValue = 5335;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Operational_SensorValue_EURange = 5339;

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint DoubleAnalogSensorFunctionType_Operational_SensorValue_EngineeringUnits = 5340;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Lock_Locked = 1037;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Lock_LockingClient = 1038;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Lock_LockingUser = 1039;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Lock_RemainingLockTime = 1040;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Lock_InitLock_InputArguments = 1042;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Lock_InitLock_OutputArguments = 1043;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Lock_RenewLock_OutputArguments = 1045;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Lock_ExitLock_OutputArguments = 1047;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Lock_BreakLock_OutputArguments = 1049;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_EventId = 1055;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_EventType = 1056;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_SourceNode = 1057;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_SourceName = 1058;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_Time = 1059;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ReceiveTime = 1060;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_Message = 1062;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_Severity = 1063;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionClassId = 1064;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionClassName = 1065;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionName = 1068;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_BranchId = 1069;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_Retain = 1070;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_EnabledState = 1071;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_EnabledState_Id = 1072;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_Quality = 1080;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_Quality_SourceTimestamp = 1081;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_LastSeverity = 1082;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_LastSeverity_SourceTimestamp = 1083;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_Comment = 1084;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_Comment_SourceTimestamp = 1085;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ClientUserId = 1086;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_AddComment_InputArguments = 1090;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_AckedState = 1091;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_AckedState_Id = 1092;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConfirmedState_Id = 1101;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_Acknowledge_InputArguments = 1110;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_Confirm_InputArguments = 1112;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ActiveState = 1113;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ActiveState_Id = 1114;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_InputNode = 1122;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_SuppressedState_Id = 1124;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_OutOfServiceState_Id = 1133;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_CurrentState = 1142;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_CurrentState_Id = 1143;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_LastTransition_Id = 1148;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_UnshelveTime = 1155;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 1157;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_SuppressedOrShelved = 1160;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_SilenceState_Id = 1168;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_LatchedState_Id = 1181;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_CurrentState = 1206;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_CurrentState_Id = 1207;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_LastTransition_Id = 1212;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_ParameterSet_CompensationValue_EURange = 1226;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_ParameterSet_CompensationValue_EngineeringUnits = 1227;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Operational_RawValue = 4864;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Operational_RawValue_EURange = 4868;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Operational_RawValue_EngineeringUnits = 4869;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Operational_SensorValue = 4870;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Operational_SensorValue_EURange = 4874;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_IonReference_Operational_SensorValue_EngineeringUnits = 4875;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Lock_Locked = 1250;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Lock_LockingClient = 1251;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Lock_LockingUser = 1252;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Lock_RemainingLockTime = 1253;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Lock_InitLock_InputArguments = 1255;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Lock_InitLock_OutputArguments = 1256;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Lock_RenewLock_OutputArguments = 1258;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Lock_ExitLock_OutputArguments = 1260;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Lock_BreakLock_OutputArguments = 1262;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_EventId = 1268;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_EventType = 1269;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_SourceNode = 1270;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_SourceName = 1271;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_Time = 1272;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ReceiveTime = 1273;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_Message = 1275;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_Severity = 1276;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionClassId = 1277;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionClassName = 1278;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionName = 1281;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_BranchId = 1282;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_Retain = 1283;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_EnabledState = 1284;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_EnabledState_Id = 1285;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_Quality = 1293;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_Quality_SourceTimestamp = 1294;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_LastSeverity = 1295;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_LastSeverity_SourceTimestamp = 1296;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_Comment = 1297;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_Comment_SourceTimestamp = 1298;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ClientUserId = 1299;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_AddComment_InputArguments = 1303;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_AckedState = 1304;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_AckedState_Id = 1305;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConfirmedState_Id = 1314;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_Acknowledge_InputArguments = 1323;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_Confirm_InputArguments = 1325;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ActiveState = 1326;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ActiveState_Id = 1327;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_InputNode = 1335;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_SuppressedState_Id = 1337;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_OutOfServiceState_Id = 1346;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_CurrentState = 1355;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_CurrentState_Id = 1356;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_LastTransition_Id = 1361;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_UnshelveTime = 1368;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 1370;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_SuppressedOrShelved = 1373;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_SilenceState_Id = 1381;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_LatchedState_Id = 1394;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_CurrentState = 1419;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_CurrentState_Id = 1420;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_LastTransition_Id = 1425;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_ParameterSet_CompensationValue_EURange = 1439;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_ParameterSet_CompensationValue_EngineeringUnits = 1440;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Operational_RawValue = 4876;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Operational_RawValue_EURange = 4880;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Operational_RawValue_EngineeringUnits = 4881;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Operational_SensorValue = 4882;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Operational_SensorValue_EURange = 4886;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Cathode_Operational_SensorValue_EngineeringUnits = 4887;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Lock_Locked = 1463;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Lock_LockingClient = 1464;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Lock_LockingUser = 1465;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Lock_RemainingLockTime = 1466;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Lock_InitLock_InputArguments = 1468;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Lock_InitLock_OutputArguments = 1469;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Lock_RenewLock_OutputArguments = 1471;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Lock_ExitLock_OutputArguments = 1473;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Lock_BreakLock_OutputArguments = 1475;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_EventId = 1481;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_EventType = 1482;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_SourceNode = 1483;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_SourceName = 1484;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_Time = 1485;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ReceiveTime = 1486;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_Message = 1488;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_Severity = 1489;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionClassId = 1490;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionClassName = 1491;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionName = 1494;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_BranchId = 1495;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_Retain = 1496;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_EnabledState = 1497;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_EnabledState_Id = 1498;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_Quality = 1506;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_Quality_SourceTimestamp = 1507;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_LastSeverity = 1508;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_LastSeverity_SourceTimestamp = 1509;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_Comment = 1510;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_Comment_SourceTimestamp = 1511;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ClientUserId = 1512;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_AddComment_InputArguments = 1516;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_AckedState = 1517;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_AckedState_Id = 1518;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConfirmedState_Id = 1527;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_Acknowledge_InputArguments = 1536;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_Confirm_InputArguments = 1538;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ActiveState = 1539;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ActiveState_Id = 1540;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_InputNode = 1548;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_SuppressedState_Id = 1550;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_OutOfServiceState_Id = 1559;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_CurrentState = 1568;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_CurrentState_Id = 1569;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_LastTransition_Id = 1574;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_UnshelveTime = 1581;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 1583;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_SuppressedOrShelved = 1586;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_SilenceState_Id = 1594;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_LatchedState_Id = 1607;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_CurrentState = 1632;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_CurrentState_Id = 1633;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_LastTransition_Id = 1638;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_ParameterSet_CompensationValue_EURange = 1652;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_ParameterSet_CompensationValue_EngineeringUnits = 1653;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Operational_RawValue = 4888;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Operational_RawValue_EURange = 4892;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Operational_RawValue_EngineeringUnits = 4893;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Operational_SensorValue = 4894;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Operational_SensorValue_EURange = 4898;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Extraction_Operational_SensorValue_EngineeringUnits = 4899;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Lock_Locked = 1676;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Lock_LockingClient = 1677;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Lock_LockingUser = 1678;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Lock_RemainingLockTime = 1679;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Lock_InitLock_InputArguments = 1681;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Lock_InitLock_OutputArguments = 1682;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Lock_RenewLock_OutputArguments = 1684;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Lock_ExitLock_OutputArguments = 1686;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Lock_BreakLock_OutputArguments = 1688;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_EventId = 1694;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_EventType = 1695;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_SourceNode = 1696;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_SourceName = 1697;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_Time = 1698;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ReceiveTime = 1699;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_Message = 1701;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_Severity = 1702;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionClassId = 1703;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionClassName = 1704;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionName = 1707;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_BranchId = 1708;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_Retain = 1709;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_EnabledState = 1710;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_EnabledState_Id = 1711;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_Quality = 1719;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_Quality_SourceTimestamp = 1720;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_LastSeverity = 1721;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_LastSeverity_SourceTimestamp = 1722;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_Comment = 1723;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_Comment_SourceTimestamp = 1724;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ClientUserId = 1725;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_AddComment_InputArguments = 1729;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_AckedState = 1730;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_AckedState_Id = 1731;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ConfirmedState_Id = 1740;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_Acknowledge_InputArguments = 1749;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_Confirm_InputArguments = 1751;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ActiveState = 1752;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ActiveState_Id = 1753;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_InputNode = 1761;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_SuppressedState_Id = 1763;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_OutOfServiceState_Id = 1772;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_CurrentState = 1781;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_CurrentState_Id = 1782;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_LastTransition_Id = 1787;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_UnshelveTime = 1794;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 1796;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_SuppressedOrShelved = 1799;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_SilenceState_Id = 1807;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_LatchedState_Id = 1820;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_CurrentState = 1845;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_CurrentState_Id = 1846;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_LastTransition_Id = 1851;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_ParameterSet_CompensationValue_EURange = 1865;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_ParameterSet_CompensationValue_EngineeringUnits = 1866;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Operational_RawValue = 4900;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Operational_RawValue_EURange = 4904;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Operational_RawValue_EngineeringUnits = 4905;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Operational_SensorValue = 4906;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Operational_SensorValue_EURange = 4910;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Focus_Operational_SensorValue_EngineeringUnits = 4911;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Lock_Locked = 1889;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Lock_LockingClient = 1890;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Lock_LockingUser = 1891;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Lock_RemainingLockTime = 1892;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock_InputArguments = 1894;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock_OutputArguments = 1895;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Lock_RenewLock_OutputArguments = 1897;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Lock_ExitLock_OutputArguments = 1899;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Lock_BreakLock_OutputArguments = 1901;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EventId = 1907;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EventType = 1908;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SourceNode = 1909;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SourceName = 1910;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Time = 1911;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ReceiveTime = 1912;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Message = 1914;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Severity = 1915;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionClassId = 1916;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionClassName = 1917;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionName = 1920;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_BranchId = 1921;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Retain = 1922;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EnabledState = 1923;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EnabledState_Id = 1924;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Quality = 1932;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Quality_SourceTimestamp = 1933;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LastSeverity = 1934;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LastSeverity_SourceTimestamp = 1935;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Comment = 1936;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Comment_SourceTimestamp = 1937;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ClientUserId = 1938;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AddComment_InputArguments = 1942;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AckedState = 1943;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AckedState_Id = 1944;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConfirmedState_Id = 1953;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Acknowledge_InputArguments = 1962;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Confirm_InputArguments = 1964;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ActiveState = 1965;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ActiveState_Id = 1966;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_InputNode = 1974;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SuppressedState_Id = 1976;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_OutOfServiceState_Id = 1985;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_CurrentState = 1994;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_CurrentState_Id = 1995;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_LastTransition_Id = 2000;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_UnshelveTime = 2007;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 2009;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SuppressedOrShelved = 2012;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SilenceState_Id = 2020;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LatchedState_Id = 2033;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_CurrentState = 2058;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_CurrentState_Id = 2059;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_LastTransition_Id = 2064;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_ParameterSet_CompensationValue_EURange = 2078;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_ParameterSet_CompensationValue_EngineeringUnits = 2079;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue = 4912;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue_EURange = 4916;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue_EngineeringUnits = 4917;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue = 4918;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue_EURange = 4922;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue_EngineeringUnits = 4923;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Lock_Locked = 2102;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Lock_LockingClient = 2103;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Lock_LockingUser = 2104;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Lock_RemainingLockTime = 2105;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock_InputArguments = 2107;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock_OutputArguments = 2108;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Lock_RenewLock_OutputArguments = 2110;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Lock_ExitLock_OutputArguments = 2112;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Lock_BreakLock_OutputArguments = 2114;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EventId = 2120;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EventType = 2121;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SourceNode = 2122;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SourceName = 2123;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Time = 2124;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ReceiveTime = 2125;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Message = 2127;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Severity = 2128;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionClassId = 2129;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionClassName = 2130;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionName = 2133;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_BranchId = 2134;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Retain = 2135;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EnabledState = 2136;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EnabledState_Id = 2137;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Quality = 2145;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Quality_SourceTimestamp = 2146;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LastSeverity = 2147;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LastSeverity_SourceTimestamp = 2148;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Comment = 2149;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Comment_SourceTimestamp = 2150;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ClientUserId = 2151;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AddComment_InputArguments = 2155;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AckedState = 2156;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AckedState_Id = 2157;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConfirmedState_Id = 2166;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Acknowledge_InputArguments = 2175;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Confirm_InputArguments = 2177;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ActiveState = 2178;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ActiveState_Id = 2179;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_InputNode = 2187;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SuppressedState_Id = 2189;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_OutOfServiceState_Id = 2198;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_CurrentState = 2207;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_CurrentState_Id = 2208;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_LastTransition_Id = 2213;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_UnshelveTime = 2220;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 2222;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SuppressedOrShelved = 2225;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SilenceState_Id = 2233;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LatchedState_Id = 2246;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_CurrentState = 2271;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_CurrentState_Id = 2272;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_LastTransition_Id = 2277;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_ParameterSet_CompensationValue_EURange = 2291;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_ParameterSet_CompensationValue_EngineeringUnits = 2292;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue = 4924;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue_EURange = 4928;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue_EngineeringUnits = 4929;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue = 4930;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue_EURange = 4934;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue_EngineeringUnits = 4935;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Lock_Locked = 2315;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Lock_LockingClient = 2316;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Lock_LockingUser = 2317;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Lock_RemainingLockTime = 2318;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Lock_InitLock_InputArguments = 2320;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Lock_InitLock_OutputArguments = 2321;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Lock_RenewLock_OutputArguments = 2323;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Lock_ExitLock_OutputArguments = 2325;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Lock_BreakLock_OutputArguments = 2327;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_EventId = 2333;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_EventType = 2334;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_SourceNode = 2335;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_SourceName = 2336;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_Time = 2337;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ReceiveTime = 2338;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_Message = 2340;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_Severity = 2341;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionClassId = 2342;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionClassName = 2343;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionName = 2346;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_BranchId = 2347;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_Retain = 2348;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_EnabledState = 2349;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_EnabledState_Id = 2350;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_Quality = 2358;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_Quality_SourceTimestamp = 2359;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_LastSeverity = 2360;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_LastSeverity_SourceTimestamp = 2361;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_Comment = 2362;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_Comment_SourceTimestamp = 2363;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ClientUserId = 2364;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_AddComment_InputArguments = 2368;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_AckedState = 2369;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_AckedState_Id = 2370;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConfirmedState_Id = 2379;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_Acknowledge_InputArguments = 2388;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_Confirm_InputArguments = 2390;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ActiveState = 2391;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ActiveState_Id = 2392;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_InputNode = 2400;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_SuppressedState_Id = 2402;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_OutOfServiceState_Id = 2411;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_CurrentState = 2420;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_CurrentState_Id = 2421;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_LastTransition_Id = 2426;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_UnshelveTime = 2433;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 2435;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_SuppressedOrShelved = 2438;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_SilenceState_Id = 2446;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_LatchedState_Id = 2459;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_CurrentState = 2484;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_CurrentState_Id = 2485;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_LastTransition_Id = 2490;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_ParameterSet_CompensationValue_EURange = 2504;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_ParameterSet_CompensationValue_EngineeringUnits = 2505;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Operational_RawValue = 4936;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Operational_RawValue_EURange = 4940;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Operational_RawValue_EngineeringUnits = 4941;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Operational_SensorValue = 4942;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Operational_SensorValue_EURange = 4946;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Deflection_Operational_SensorValue_EngineeringUnits = 4947;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Lock_Locked = 2528;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Lock_LockingClient = 2529;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Lock_LockingUser = 2530;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Lock_RemainingLockTime = 2531;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Lock_InitLock_InputArguments = 2533;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Lock_InitLock_OutputArguments = 2534;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Lock_RenewLock_OutputArguments = 2536;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Lock_ExitLock_OutputArguments = 2538;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Lock_BreakLock_OutputArguments = 2540;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EventId = 2546;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EventType = 2547;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SourceNode = 2548;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SourceName = 2549;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Time = 2550;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ReceiveTime = 2551;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Message = 2553;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Severity = 2554;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionClassId = 2555;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionClassName = 2556;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionName = 2559;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_BranchId = 2560;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Retain = 2561;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EnabledState = 2562;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EnabledState_Id = 2563;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Quality = 2571;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Quality_SourceTimestamp = 2572;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LastSeverity = 2573;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LastSeverity_SourceTimestamp = 2574;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Comment = 2575;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Comment_SourceTimestamp = 2576;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ClientUserId = 2577;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AddComment_InputArguments = 2581;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AckedState = 2582;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AckedState_Id = 2583;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConfirmedState_Id = 2592;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Acknowledge_InputArguments = 2601;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Confirm_InputArguments = 2603;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ActiveState = 2604;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ActiveState_Id = 2605;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_InputNode = 2613;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SuppressedState_Id = 2615;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_OutOfServiceState_Id = 2624;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_CurrentState = 2633;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_CurrentState_Id = 2634;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_LastTransition_Id = 2639;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_UnshelveTime = 2646;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 2648;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SuppressedOrShelved = 2651;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SilenceState_Id = 2659;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LatchedState_Id = 2672;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_CurrentState = 2697;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_CurrentState_Id = 2698;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_LastTransition_Id = 2703;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_ParameterSet_CompensationValue_EURange = 2717;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_ParameterSet_CompensationValue_EngineeringUnits = 2718;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Operational_RawValue = 4948;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Operational_RawValue_EURange = 4952;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Operational_RawValue_EngineeringUnits = 4953;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Operational_SensorValue = 4954;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Operational_SensorValue_EURange = 4958;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Prefilter_Operational_SensorValue_EngineeringUnits = 4959;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Lock_Locked = 2741;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Lock_LockingClient = 2742;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Lock_LockingUser = 2743;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Lock_RemainingLockTime = 2744;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock_InputArguments = 2746;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock_OutputArguments = 2747;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Lock_RenewLock_OutputArguments = 2749;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Lock_ExitLock_OutputArguments = 2751;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Lock_BreakLock_OutputArguments = 2753;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EventId = 2759;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EventType = 2760;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SourceNode = 2761;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SourceName = 2762;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Time = 2763;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ReceiveTime = 2764;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Message = 2766;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Severity = 2767;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionClassId = 2768;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionClassName = 2769;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionName = 2772;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_BranchId = 2773;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Retain = 2774;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EnabledState = 2775;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EnabledState_Id = 2776;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Quality = 2784;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Quality_SourceTimestamp = 2785;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LastSeverity = 2786;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LastSeverity_SourceTimestamp = 2787;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Comment = 2788;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Comment_SourceTimestamp = 2789;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ClientUserId = 2790;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AddComment_InputArguments = 2794;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AckedState = 2795;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AckedState_Id = 2796;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConfirmedState_Id = 2805;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Acknowledge_InputArguments = 2814;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Confirm_InputArguments = 2816;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ActiveState = 2817;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ActiveState_Id = 2818;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_InputNode = 2826;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SuppressedState_Id = 2828;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_OutOfServiceState_Id = 2837;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_CurrentState = 2846;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_CurrentState_Id = 2847;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_LastTransition_Id = 2852;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_UnshelveTime = 2859;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 2861;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SuppressedOrShelved = 2864;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SilenceState_Id = 2872;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LatchedState_Id = 2885;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_CurrentState = 2910;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_CurrentState_Id = 2911;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_LastTransition_Id = 2916;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_ParameterSet_CompensationValue_EURange = 2930;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_ParameterSet_CompensationValue_EngineeringUnits = 2931;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue = 4960;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue_EURange = 4964;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue_EngineeringUnits = 4965;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue = 4966;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue_EURange = 4970;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue_EngineeringUnits = 4971;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Lock_Locked = 2954;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Lock_LockingClient = 2955;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Lock_LockingUser = 2956;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Lock_RemainingLockTime = 2957;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Lock_InitLock_InputArguments = 2959;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Lock_InitLock_OutputArguments = 2960;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Lock_RenewLock_OutputArguments = 2962;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Lock_ExitLock_OutputArguments = 2964;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Lock_BreakLock_OutputArguments = 2966;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EventId = 2972;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EventType = 2973;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SourceNode = 2974;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SourceName = 2975;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Time = 2976;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ReceiveTime = 2977;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Message = 2979;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Severity = 2980;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionClassId = 2981;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionClassName = 2982;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionName = 2985;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_BranchId = 2986;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Retain = 2987;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EnabledState = 2988;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EnabledState_Id = 2989;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Quality = 2997;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Quality_SourceTimestamp = 2998;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LastSeverity = 2999;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LastSeverity_SourceTimestamp = 3000;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Comment = 3001;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Comment_SourceTimestamp = 3002;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ClientUserId = 3003;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AddComment_InputArguments = 3007;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AckedState = 3008;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AckedState_Id = 3009;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConfirmedState_Id = 3018;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Acknowledge_InputArguments = 3027;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Confirm_InputArguments = 3029;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ActiveState = 3030;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ActiveState_Id = 3031;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_InputNode = 3039;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SuppressedState_Id = 3041;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_OutOfServiceState_Id = 3050;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_CurrentState = 3059;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_CurrentState_Id = 3060;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_LastTransition_Id = 3065;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_UnshelveTime = 3072;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 3074;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SuppressedOrShelved = 3077;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SilenceState_Id = 3085;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LatchedState_Id = 3098;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_CurrentState = 3123;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_CurrentState_Id = 3124;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_LastTransition_Id = 3129;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_ParameterSet_CompensationValue_EURange = 3143;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_ParameterSet_CompensationValue_EngineeringUnits = 3144;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Operational_RawValue = 4972;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Operational_RawValue_EURange = 4976;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Operational_RawValue_EngineeringUnits = 4977;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Operational_SensorValue = 4978;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Operational_SensorValue_EURange = 4982;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UVRatio_Operational_SensorValue_EngineeringUnits = 4983;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Lock_Locked = 3167;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Lock_LockingClient = 3168;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Lock_LockingUser = 3169;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Lock_RemainingLockTime = 3170;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Lock_InitLock_InputArguments = 3172;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Lock_InitLock_OutputArguments = 3173;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Lock_RenewLock_OutputArguments = 3175;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Lock_ExitLock_OutputArguments = 3177;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Lock_BreakLock_OutputArguments = 3179;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EventId = 3185;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EventType = 3186;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SourceNode = 3187;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SourceName = 3188;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Time = 3189;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ReceiveTime = 3190;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Message = 3192;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Severity = 3193;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionClassId = 3194;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionClassName = 3195;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionName = 3198;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_BranchId = 3199;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Retain = 3200;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EnabledState = 3201;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EnabledState_Id = 3202;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Quality = 3210;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Quality_SourceTimestamp = 3211;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LastSeverity = 3212;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LastSeverity_SourceTimestamp = 3213;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Comment = 3214;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Comment_SourceTimestamp = 3215;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ClientUserId = 3216;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AddComment_InputArguments = 3220;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AckedState = 3221;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AckedState_Id = 3222;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConfirmedState_Id = 3231;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Acknowledge_InputArguments = 3240;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Confirm_InputArguments = 3242;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ActiveState = 3243;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ActiveState_Id = 3244;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_InputNode = 3252;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SuppressedState_Id = 3254;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_OutOfServiceState_Id = 3263;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_CurrentState = 3272;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_CurrentState_Id = 3273;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_LastTransition_Id = 3278;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_UnshelveTime = 3285;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 3287;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SuppressedOrShelved = 3290;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SilenceState_Id = 3298;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LatchedState_Id = 3311;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_CurrentState = 3336;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_CurrentState_Id = 3337;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_LastTransition_Id = 3342;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_ParameterSet_CompensationValue_EURange = 3356;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_ParameterSet_CompensationValue_EngineeringUnits = 3357;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Operational_RawValue = 4984;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Operational_RawValue_EURange = 4988;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Operational_RawValue_EngineeringUnits = 4989;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue = 4990;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue_EURange = 4994;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue_EngineeringUnits = 4995;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Lock_Locked = 3593;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Lock_LockingClient = 3594;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Lock_LockingUser = 3595;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Lock_RemainingLockTime = 3596;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Lock_InitLock_InputArguments = 3598;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Lock_InitLock_OutputArguments = 3599;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Lock_RenewLock_OutputArguments = 3601;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Lock_ExitLock_OutputArguments = 3603;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Lock_BreakLock_OutputArguments = 3605;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_EventId = 3611;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_EventType = 3612;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_SourceNode = 3613;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_SourceName = 3614;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_Time = 3615;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ReceiveTime = 3616;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_Message = 3618;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_Severity = 3619;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionClassId = 3620;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionClassName = 3621;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionName = 3624;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_BranchId = 3625;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_Retain = 3626;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_EnabledState = 3627;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_EnabledState_Id = 3628;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_Quality = 3636;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_Quality_SourceTimestamp = 3637;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_LastSeverity = 3638;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_LastSeverity_SourceTimestamp = 3639;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_Comment = 3640;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_Comment_SourceTimestamp = 3641;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ClientUserId = 3642;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_AddComment_InputArguments = 3646;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_AckedState = 3647;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_AckedState_Id = 3648;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConfirmedState_Id = 3657;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_Acknowledge_InputArguments = 3666;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_Confirm_InputArguments = 3668;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ActiveState = 3669;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ActiveState_Id = 3670;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_InputNode = 3678;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_SuppressedState_Id = 3680;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_OutOfServiceState_Id = 3689;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_CurrentState = 3698;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_CurrentState_Id = 3699;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_LastTransition_Id = 3704;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_UnshelveTime = 3711;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 3713;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_SuppressedOrShelved = 3716;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_SilenceState_Id = 3724;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_LatchedState_Id = 3737;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_CurrentState = 3762;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_CurrentState_Id = 3763;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_LastTransition_Id = 3768;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_ParameterSet_CompensationValue_EURange = 3782;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_ParameterSet_CompensationValue_EngineeringUnits = 3783;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Operational_RawValue = 5008;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Operational_RawValue_EURange = 5012;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Operational_RawValue_EngineeringUnits = 5013;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Operational_SensorValue = 5014;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Operational_SensorValue_EURange = 5018;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Resolution_Operational_SensorValue_EngineeringUnits = 5019;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Lock_Locked = 3806;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Lock_LockingClient = 3807;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Lock_LockingUser = 3808;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Lock_RemainingLockTime = 3809;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Lock_InitLock_InputArguments = 3811;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Lock_InitLock_OutputArguments = 3812;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Lock_RenewLock_OutputArguments = 3814;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Lock_ExitLock_OutputArguments = 3816;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Lock_BreakLock_OutputArguments = 3818;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_EventId = 3824;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_EventType = 3825;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_SourceNode = 3826;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_SourceName = 3827;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_Time = 3828;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ReceiveTime = 3829;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_Message = 3831;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_Severity = 3832;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionClassId = 3833;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionClassName = 3834;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionName = 3837;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_BranchId = 3838;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_Retain = 3839;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_EnabledState = 3840;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_EnabledState_Id = 3841;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_Quality = 3849;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_Quality_SourceTimestamp = 3850;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_LastSeverity = 3851;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_LastSeverity_SourceTimestamp = 3852;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_Comment = 3853;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_Comment_SourceTimestamp = 3854;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ClientUserId = 3855;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_AddComment_InputArguments = 3859;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_AckedState = 3860;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_AckedState_Id = 3861;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ConfirmedState_Id = 3870;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_Acknowledge_InputArguments = 3879;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_Confirm_InputArguments = 3881;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ActiveState = 3882;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ActiveState_Id = 3883;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_InputNode = 3891;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_SuppressedState_Id = 3893;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_OutOfServiceState_Id = 3902;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_CurrentState = 3911;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_CurrentState_Id = 3912;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_LastTransition_Id = 3917;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_UnshelveTime = 3924;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 3926;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_SuppressedOrShelved = 3929;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_SilenceState_Id = 3937;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_LatchedState_Id = 3950;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_CurrentState = 3975;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_CurrentState_Id = 3976;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_LastTransition_Id = 3981;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_ParameterSet_CompensationValue_EURange = 3995;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_ParameterSet_CompensationValue_EngineeringUnits = 3996;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Operational_RawValue = 5020;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Operational_RawValue_EURange = 5024;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Operational_RawValue_EngineeringUnits = 5025;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Operational_SensorValue = 5026;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Operational_SensorValue_EURange = 5030;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_Slope_Operational_SensorValue_EngineeringUnits = 5031;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_Locked Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Lock_Locked = 4019;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_LockingClient Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Lock_LockingClient = 4020;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_LockingUser Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Lock_LockingUser = 4021;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Lock_RemainingLockTime = 4022;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Lock_InitLock_InputArguments = 4024;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Lock_InitLock_OutputArguments = 4025;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Lock_RenewLock_OutputArguments = 4027;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Lock_ExitLock_OutputArguments = 4029;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Lock_BreakLock_OutputArguments = 4031;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_EventId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_EventId = 4037;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_EventType Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_EventType = 4038;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_SourceNode = 4039;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_SourceName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_SourceName = 4040;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Time Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_Time = 4041;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ReceiveTime = 4042;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Message Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_Message = 4044;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Severity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_Severity = 4045;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionClassId = 4046;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionClassName = 4047;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionName = 4050;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_BranchId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_BranchId = 4051;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Retain Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_Retain = 4052;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_EnabledState = 4053;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_EnabledState_Id = 4054;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Quality Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_Quality = 4062;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_Quality_SourceTimestamp = 4063;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_LastSeverity = 4064;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_LastSeverity_SourceTimestamp = 4065;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Comment Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_Comment = 4066;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_Comment_SourceTimestamp = 4067;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ClientUserId = 4068;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_AddComment_InputArguments = 4072;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_AckedState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_AckedState = 4073;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_AckedState_Id = 4074;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConfirmedState_Id = 4083;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_Acknowledge_InputArguments = 4092;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_Confirm_InputArguments = 4094;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ActiveState = 4095;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ActiveState_Id = 4096;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_InputNode Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_InputNode = 4104;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_SuppressedState_Id = 4106;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_OutOfServiceState_Id = 4115;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_CurrentState = 4124;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_CurrentState_Id = 4125;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_LastTransition_Id = 4130;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_UnshelveTime = 4137;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = 4139;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_SuppressedOrShelved = 4142;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_SilenceState_Id = 4150;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_LatchedState_Id = 4163;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_CurrentState = 4188;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_CurrentState_Id = 4189;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_LastTransition_Id = 4194;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_ParameterSet_CompensationValue_EURange = 4208;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_ParameterSet_CompensationValue_EngineeringUnits = 4209;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational_RawValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Operational_RawValue = 5032;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational_RawValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Operational_RawValue_EURange = 5036;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Operational_RawValue_EngineeringUnits = 5037;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational_SensorValue Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Operational_SensorValue = 5038;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational_SensorValue_EURange Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Operational_SensorValue_EURange = 5042;

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public const uint TuneParametersFunctionSetType_UOffset_Operational_SensorValue_EngineeringUnits = 5043;

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
        public const uint GAMSystemStatusType_AutomaticMode = 29;

        /// <summary>
        /// The identifier for the GAMSystemStatusType_GAMOK Variable.
        /// </summary>
        public const uint GAMSystemStatusType_GAMOK = 30;

        /// <summary>
        /// The identifier for the GAMSystemStatusType_GAMtemperatureOver35DegreeC Variable.
        /// </summary>
        public const uint GAMSystemStatusType_GAMtemperatureOver35DegreeC = 31;

        /// <summary>
        /// The identifier for the GAMSystemStatusType_ManualMode Variable.
        /// </summary>
        public const uint GAMSystemStatusType_ManualMode = 32;

        /// <summary>
        /// The identifier for the GAMSystemStatusType_SystemStatusText Variable.
        /// </summary>
        public const uint GAMSystemStatusType_SystemStatusText = 33;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_IonReference Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_IonReference = 35;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_IonReference_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_IonReference_EngineeringUnits = 40;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Cathode Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Cathode = 41;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Cathode_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Cathode_EngineeringUnits = 46;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Extraction Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Extraction = 47;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Extraction_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Extraction_EngineeringUnits = 52;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Focus Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Focus = 53;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Focus_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Focus_EngineeringUnits = 58;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FilamentCurrent Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_FilamentCurrent = 59;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FilamentCurrent_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_FilamentCurrent_EngineeringUnits = 64;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_EmissionCurrent Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_EmissionCurrent = 65;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_EmissionCurrent_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_EmissionCurrent_EngineeringUnits = 70;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Deflection Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Deflection = 71;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Deflection_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Deflection_EngineeringUnits = 76;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Prefilter Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Prefilter = 77;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Prefilter_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Prefilter_EngineeringUnits = 82;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SEMVoltage Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_SEMVoltage = 83;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SEMVoltage_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_SEMVoltage_EngineeringUnits = 88;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UVRatio Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_UVRatio = 89;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UVRatio_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_UVRatio_EngineeringUnits = 94;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FieldAxis Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_FieldAxis = 95;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FieldAxis_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_FieldAxis_EngineeringUnits = 100;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SelectedFilament Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_SelectedFilament = 101;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SelectedFilament_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_SelectedFilament_EngineeringUnits = 106;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Resolution Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Resolution = 107;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Resolution_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Resolution_EngineeringUnits = 112;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Slope Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Slope = 113;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Slope_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_Slope_EngineeringUnits = 118;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UOffset Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_UOffset = 119;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UOffset_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_UOffset_EngineeringUnits = 124;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorType Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_DetectorType = 125;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorType_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_DetectorType_EngineeringUnits = 130;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorInputPin Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_DetectorInputPin = 131;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorInputPin_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_DetectorInputPin_EngineeringUnits = 136;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FIREnabled Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_FIREnabled = 137;

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FIREnabled_EngineeringUnits Variable.
        /// </summary>
        public const uint ReadbackTuneParametersType_FIREnabled_EngineeringUnits = 142;

        /// <summary>
        /// The identifier for the MCDValueType_IsValid Variable.
        /// </summary>
        public const uint MCDValueType_IsValid = 901;

        /// <summary>
        /// The identifier for the MCDValueType_Component Variable.
        /// </summary>
        public const uint MCDValueType_Component = 902;

        /// <summary>
        /// The identifier for the MCDValueType_Concentration Variable.
        /// </summary>
        public const uint MCDValueType_Concentration = 903;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_Locked = 152;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_LockingClient = 153;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_LockingUser = 154;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_RemainingLockTime = 155;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_InitLock_InputArguments = 157;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_InitLock_OutputArguments = 158;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_RenewLock_OutputArguments = 160;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_ExitLock_OutputArguments = 162;

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint GAMDeviceType_Lock_BreakLock_OutputArguments = 164;

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_AutomaticMode Variable.
        /// </summary>
        public const uint GAMDeviceType_SystemStatus_AutomaticMode = 225;

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_GAMOK Variable.
        /// </summary>
        public const uint GAMDeviceType_SystemStatus_GAMOK = 226;

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_GAMtemperatureOver35DegreeC Variable.
        /// </summary>
        public const uint GAMDeviceType_SystemStatus_GAMtemperatureOver35DegreeC = 227;

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_ManualMode Variable.
        /// </summary>
        public const uint GAMDeviceType_SystemStatus_ManualMode = 228;

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_SystemStatusText Variable.
        /// </summary>
        public const uint GAMDeviceType_SystemStatus_SystemStatusText = 229;
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
        /// The identifier for the GAMStateMachineType_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_Start = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.GAMStateMachineType_Start, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_Stop = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.GAMStateMachineType_Stop, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_Start = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.GAMMeasureStateMachineType_Start, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_Stop = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.GAMMeasureStateMachineType_Stop, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.DoubleAnalogSensorFunctionType_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.DoubleAnalogSensorFunctionType_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.DoubleAnalogSensorFunctionType_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.DoubleAnalogSensorFunctionType_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.DoubleAnalogSensorFunctionType_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.DoubleAnalogSensorFunctionType_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.DoubleAnalogSensorFunctionType_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.DoubleAnalogSensorFunctionType_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_IonReference_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_IonReference_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_IonReference_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_IonReference_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_IonReference_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_IonReference_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_IonReference_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_IonReference_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Cathode_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Cathode_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Cathode_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Cathode_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Cathode_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Cathode_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Cathode_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Cathode_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Extraction_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Extraction_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Extraction_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Extraction_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Extraction_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Extraction_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Extraction_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Extraction_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Focus_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Focus_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Focus_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Focus_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Focus_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Focus_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Focus_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Focus_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FilamentCurrent_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FilamentCurrent_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FilamentCurrent_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_EmissionCurrent_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_EmissionCurrent_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_EmissionCurrent_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Deflection_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Deflection_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Deflection_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Deflection_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Deflection_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Deflection_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Deflection_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Deflection_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Prefilter_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Prefilter_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Prefilter_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Prefilter_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_SEMVoltage_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_SEMVoltage_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_SEMVoltage_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UVRatio_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UVRatio_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UVRatio_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UVRatio_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FieldAxis_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FieldAxis_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FieldAxis_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FieldAxis_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Resolution_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Resolution_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Resolution_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Resolution_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Resolution_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Resolution_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Resolution_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Resolution_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Slope_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Slope_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Slope_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Slope_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Slope_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Slope_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Slope_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Slope_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UOffset_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UOffset_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UOffset_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UOffset_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_Disable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UOffset_AlarmMonitor_Disable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_Enable = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UOffset_AlarmMonitor_Enable, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_AddComment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UOffset_AlarmMonitor_AddComment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_Acknowledge = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UOffset_AlarmMonitor_Acknowledge, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_TimedShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_TimedShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_TimedShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_Unshelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_Unshelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_Unshelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_OneShotShelve Method.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_OneShotShelve = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_OneShotShelve, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_InitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.GAMDeviceType_Lock_InitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_RenewLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.GAMDeviceType_Lock_RenewLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_ExitLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.GAMDeviceType_Lock_ExitLock, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_BreakLock = new ExpandedNodeId(IPI.OpcUaServer.GAM.Methods.GAMDeviceType_Lock_BreakLock, IPI.OpcUaServer.GAM.Namespaces.GAM);
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
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.DoubleAnalogSensorFunctionType_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_IonReference, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_IonReference_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_IonReference_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Cathode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Cathode_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Cathode_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Extraction, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Extraction_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Extraction_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Focus, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Focus_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Focus_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_FilamentCurrent, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_FilamentCurrent_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_FilamentCurrent_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_EmissionCurrent, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_EmissionCurrent_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_EmissionCurrent_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Deflection, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Deflection_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Deflection_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Prefilter, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Prefilter_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Prefilter_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_SEMVoltage, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_SEMVoltage_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_SEMVoltage_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_UVRatio, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_UVRatio_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_UVRatio_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_FieldAxis, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_FieldAxis_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_FieldAxis_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Resolution, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Resolution_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Resolution_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Slope, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Slope_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_Slope_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_UOffset, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_ParameterSet = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_UOffset_ParameterSet, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational Object.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Operational = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.TuneParametersFunctionSetType_UOffset_Operational, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus Object.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_SystemStatus = new ExpandedNodeId(IPI.OpcUaServer.GAM.Objects.GAMDeviceType_SystemStatus, IPI.OpcUaServer.GAM.Namespaces.GAM);
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
        /// The identifier for the GAMStateMachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType = new ExpandedNodeId(IPI.OpcUaServer.GAM.ObjectTypes.GAMStateMachineType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType = new ExpandedNodeId(IPI.OpcUaServer.GAM.ObjectTypes.GAMMeasureStateMachineType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionOperationalType = new ExpandedNodeId(IPI.OpcUaServer.GAM.ObjectTypes.DoubleAnalogSensorFunctionOperationalType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType = new ExpandedNodeId(IPI.OpcUaServer.GAM.ObjectTypes.DoubleAnalogSensorFunctionType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType = new ExpandedNodeId(IPI.OpcUaServer.GAM.ObjectTypes.TuneParametersFunctionSetType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the WatchdogType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId WatchdogType = new ExpandedNodeId(IPI.OpcUaServer.GAM.ObjectTypes.WatchdogType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMSystemStatusType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GAMSystemStatusType = new ExpandedNodeId(IPI.OpcUaServer.GAM.ObjectTypes.GAMSystemStatusType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType = new ExpandedNodeId(IPI.OpcUaServer.GAM.ObjectTypes.ReadbackTuneParametersType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the MCDValueType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MCDValueType = new ExpandedNodeId(IPI.OpcUaServer.GAM.ObjectTypes.MCDValueType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType = new ExpandedNodeId(IPI.OpcUaServer.GAM.ObjectTypes.GAMDeviceType, IPI.OpcUaServer.GAM.Namespaces.GAM);
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
        /// The identifier for the GAMStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_CurrentState_Number = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_CurrentState_Number, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_LastTransition_Number = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_LastTransition_Number, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_LastTransition_TransitionTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_LastTransition_TransitionTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ProgramDiagnostic_CreateSessionId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ProgramDiagnostic_CreateClientName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ProgramDiagnostic_InvocationCreationTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ProgramDiagnostic_LastTransitionTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ProgramDiagnostic_LastMethodCall, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ProgramDiagnostic_LastMethodSessionId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ProgramDiagnostic_LastMethodInputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ProgramDiagnostic_LastMethodOutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ProgramDiagnostic_LastMethodInputValues, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ProgramDiagnostic_LastMethodOutputValues, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ProgramDiagnostic_LastMethodCallTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ProgramDiagnostic_LastMethodReturnStatus, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_Halted_StateNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_Halted_StateNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_Ready_StateNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_Ready_StateNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_Running_StateNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_Running_StateNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_Suspended_StateNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_Suspended_StateNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_HaltedToReady_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_HaltedToReady_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ReadyToRunning_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_RunningToHalted_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_RunningToHalted_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_RunningToReady_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_RunningToReady_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_RunningToSuspended_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_SuspendedToRunning_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_SuspendedToHalted_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_SuspendedToReady_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMStateMachineType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMStateMachineType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMStateMachineType_ReadyToHalted_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_CurrentState_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_CurrentState_Number = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_CurrentState_Number, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_LastTransition_Number Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_LastTransition_Number = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_LastTransition_Number, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_LastTransition_TransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_LastTransition_TransitionTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_LastTransition_TransitionTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_CreateSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ProgramDiagnostic_CreateSessionId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ProgramDiagnostic_CreateSessionId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_CreateClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ProgramDiagnostic_CreateClientName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ProgramDiagnostic_CreateClientName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_InvocationCreationTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ProgramDiagnostic_InvocationCreationTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ProgramDiagnostic_InvocationCreationTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastTransitionTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ProgramDiagnostic_LastTransitionTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ProgramDiagnostic_LastTransitionTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodCall Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodCall = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodCall, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodSessionId Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodSessionId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodSessionId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodInputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodInputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodInputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodOutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodOutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodOutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodInputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodInputValues = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodInputValues, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodOutputValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodOutputValues = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodOutputValues, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodCallTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodCallTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodCallTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodReturnStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodReturnStatus = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ProgramDiagnostic_LastMethodReturnStatus, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Halted_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_Halted_StateNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_Halted_StateNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Ready_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_Ready_StateNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_Ready_StateNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Running_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_Running_StateNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_Running_StateNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Suspended_StateNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_Suspended_StateNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_Suspended_StateNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_HaltedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_HaltedToReady_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_HaltedToReady_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ReadyToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ReadyToRunning_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ReadyToRunning_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_RunningToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_RunningToHalted_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_RunningToHalted_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_RunningToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_RunningToReady_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_RunningToReady_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_RunningToSuspended_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_RunningToSuspended_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_RunningToSuspended_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_SuspendedToRunning_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_SuspendedToRunning_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_SuspendedToRunning_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_SuspendedToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_SuspendedToHalted_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_SuspendedToHalted_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_SuspendedToReady_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_SuspendedToReady_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_SuspendedToReady_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_ReadyToHalted_TransitionNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_ReadyToHalted_TransitionNumber = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_ReadyToHalted_TransitionNumber, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Start_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_Start_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_Start_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMMeasureStateMachineType_Start_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMMeasureStateMachineType_Start_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMMeasureStateMachineType_Start_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionOperationalType_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionOperationalType_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionOperationalType_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionOperationalType_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionOperationalType_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionOperationalType_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionOperationalType_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionOperationalType_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionOperationalType_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionOperationalType_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionOperationalType_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionOperationalType_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionOperationalType_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the DoubleAnalogSensorFunctionType_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId DoubleAnalogSensorFunctionType_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.DoubleAnalogSensorFunctionType_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_IonReference_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_IonReference_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_IonReference_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Cathode_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Cathode_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Cathode_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Extraction_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Extraction_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Extraction_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Focus_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Focus_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Focus_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FilamentCurrent_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_EmissionCurrent_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Deflection_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Deflection_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Deflection_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Prefilter_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Prefilter_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Prefilter_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_SEMVoltage_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UVRatio_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UVRatio_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UVRatio_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_FieldAxis_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Resolution_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Resolution_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Resolution_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_Slope_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_Slope_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_Slope_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_EventId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_EventId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_EventType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_EventType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_SourceNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_SourceNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_SourceName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_SourceName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_Time = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_Time, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ReceiveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ReceiveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_Message = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_Message, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_Severity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_Severity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionClassId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionClassId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionClassName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionClassName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionName = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConditionName, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_BranchId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_BranchId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_Retain = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_Retain, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_EnabledState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_EnabledState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_EnabledState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_EnabledState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_Quality = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_Quality, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_Quality_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_Quality_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_LastSeverity = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_LastSeverity, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_LastSeverity_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_LastSeverity_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_Comment = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_Comment, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_Comment_SourceTimestamp = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_Comment_SourceTimestamp, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ClientUserId = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ClientUserId, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_AddComment_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_AddComment_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_AckedState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_AckedState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_AckedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_AckedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConfirmedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ConfirmedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_Acknowledge_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_Acknowledge_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_Confirm_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_Confirm_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ActiveState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ActiveState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ActiveState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ActiveState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ActiveState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ActiveState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_InputNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_InputNode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_InputNode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_SuppressedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_SuppressedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_SuppressedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_OutOfServiceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_OutOfServiceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_OutOfServiceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_UnshelveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_UnshelveTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_UnshelveTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_TimedShelve_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_TimedShelve_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_ShelvingState_TimedShelve_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_SuppressedOrShelved Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_SuppressedOrShelved = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_SuppressedOrShelved, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_SilenceState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_SilenceState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_SilenceState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LatchedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_LatchedState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_LatchedState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_CurrentState = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_CurrentState, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_CurrentState_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_CurrentState_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_LastTransition_Id = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_AlarmMonitor_LimitState_LastTransition_Id, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_ParameterSet_CompensationValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_ParameterSet_CompensationValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_ParameterSet_CompensationValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_ParameterSet_CompensationValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_ParameterSet_CompensationValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_ParameterSet_CompensationValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational_RawValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Operational_RawValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Operational_RawValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational_RawValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Operational_RawValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Operational_RawValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational_RawValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Operational_RawValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Operational_RawValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational_SensorValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Operational_SensorValue = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Operational_SensorValue, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational_SensorValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Operational_SensorValue_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Operational_SensorValue_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the TuneParametersFunctionSetType_UOffset_Operational_SensorValue_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId TuneParametersFunctionSetType_UOffset_Operational_SensorValue_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.TuneParametersFunctionSetType_UOffset_Operational_SensorValue_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the WatchdogType_Trigger Variable.
        /// </summary>
        public static readonly ExpandedNodeId WatchdogType_Trigger = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.WatchdogType_Trigger, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the WatchdogType_Trigger_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId WatchdogType_Trigger_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.WatchdogType_Trigger_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the WatchdogType_Counter Variable.
        /// </summary>
        public static readonly ExpandedNodeId WatchdogType_Counter = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.WatchdogType_Counter, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the WatchdogType_Counter_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId WatchdogType_Counter_EURange = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.WatchdogType_Counter_EURange, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMSystemStatusType_AutomaticMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMSystemStatusType_AutomaticMode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMSystemStatusType_AutomaticMode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMSystemStatusType_GAMOK Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMSystemStatusType_GAMOK = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMSystemStatusType_GAMOK, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMSystemStatusType_GAMtemperatureOver35DegreeC Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMSystemStatusType_GAMtemperatureOver35DegreeC = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMSystemStatusType_GAMtemperatureOver35DegreeC, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMSystemStatusType_ManualMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMSystemStatusType_ManualMode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMSystemStatusType_ManualMode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMSystemStatusType_SystemStatusText Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMSystemStatusType_SystemStatusText = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMSystemStatusType_SystemStatusText, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_IonReference Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_IonReference = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_IonReference, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_IonReference_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_IonReference_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_IonReference_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Cathode Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Cathode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Cathode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Cathode_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Cathode_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Cathode_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Extraction Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Extraction = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Extraction, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Extraction_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Extraction_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Extraction_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Focus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Focus = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Focus, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Focus_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Focus_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Focus_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FilamentCurrent Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_FilamentCurrent = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_FilamentCurrent, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FilamentCurrent_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_FilamentCurrent_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_FilamentCurrent_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_EmissionCurrent Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_EmissionCurrent = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_EmissionCurrent, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_EmissionCurrent_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_EmissionCurrent_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_EmissionCurrent_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Deflection Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Deflection = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Deflection, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Deflection_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Deflection_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Deflection_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Prefilter Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Prefilter = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Prefilter, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Prefilter_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Prefilter_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Prefilter_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SEMVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_SEMVoltage = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_SEMVoltage, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SEMVoltage_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_SEMVoltage_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_SEMVoltage_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UVRatio Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_UVRatio = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_UVRatio, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UVRatio_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_UVRatio_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_UVRatio_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FieldAxis Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_FieldAxis = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_FieldAxis, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FieldAxis_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_FieldAxis_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_FieldAxis_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SelectedFilament Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_SelectedFilament = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_SelectedFilament, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_SelectedFilament_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_SelectedFilament_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_SelectedFilament_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Resolution Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Resolution = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Resolution, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Resolution_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Resolution_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Resolution_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Slope Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Slope = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Slope, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_Slope_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_Slope_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_Slope_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UOffset Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_UOffset = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_UOffset, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_UOffset_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_UOffset_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_UOffset_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorType Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_DetectorType = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_DetectorType, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorType_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_DetectorType_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_DetectorType_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorInputPin Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_DetectorInputPin = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_DetectorInputPin, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_DetectorInputPin_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_DetectorInputPin_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_DetectorInputPin_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FIREnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_FIREnabled = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_FIREnabled, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the ReadbackTuneParametersType_FIREnabled_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId ReadbackTuneParametersType_FIREnabled_EngineeringUnits = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.ReadbackTuneParametersType_FIREnabled_EngineeringUnits, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the MCDValueType_IsValid Variable.
        /// </summary>
        public static readonly ExpandedNodeId MCDValueType_IsValid = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.MCDValueType_IsValid, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the MCDValueType_Component Variable.
        /// </summary>
        public static readonly ExpandedNodeId MCDValueType_Component = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.MCDValueType_Component, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the MCDValueType_Concentration Variable.
        /// </summary>
        public static readonly ExpandedNodeId MCDValueType_Concentration = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.MCDValueType_Concentration, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_Locked = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_Lock_Locked, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_LockingClient = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_Lock_LockingClient, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_LockingUser = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_Lock_LockingUser, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_Lock_RemainingLockTime, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_Lock_InitLock_InputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_Lock_InitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_Lock_RenewLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_Lock_ExitLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_Lock_BreakLock_OutputArguments, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_AutomaticMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_SystemStatus_AutomaticMode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_SystemStatus_AutomaticMode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_GAMOK Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_SystemStatus_GAMOK = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_SystemStatus_GAMOK, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_GAMtemperatureOver35DegreeC Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_SystemStatus_GAMtemperatureOver35DegreeC = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_SystemStatus_GAMtemperatureOver35DegreeC, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_ManualMode Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_SystemStatus_ManualMode = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_SystemStatus_ManualMode, IPI.OpcUaServer.GAM.Namespaces.GAM);

        /// <summary>
        /// The identifier for the GAMDeviceType_SystemStatus_SystemStatusText Variable.
        /// </summary>
        public static readonly ExpandedNodeId GAMDeviceType_SystemStatus_SystemStatusText = new ExpandedNodeId(IPI.OpcUaServer.GAM.Variables.GAMDeviceType_SystemStatus_SystemStatusText, IPI.OpcUaServer.GAM.Namespaces.GAM);
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
        /// The BrowseName for the Component component.
        /// </summary>
        public const string Component = "Component";

        /// <summary>
        /// The BrowseName for the Concentration component.
        /// </summary>
        public const string Concentration = "Concentration";

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
        /// The BrowseName for the DoubleAnalogSensorFunctionOperationalType component.
        /// </summary>
        public const string DoubleAnalogSensorFunctionOperationalType = "DoubleAnalogSensorFunctionOperationalType";

        /// <summary>
        /// The BrowseName for the DoubleAnalogSensorFunctionType component.
        /// </summary>
        public const string DoubleAnalogSensorFunctionType = "DoubleAnalogSensorFunctionType";

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
        /// The BrowseName for the GAMMeasureStateMachineType component.
        /// </summary>
        public const string GAMMeasureStateMachineType = "GAMMeasureStateMachineType";

        /// <summary>
        /// The BrowseName for the GAMOK component.
        /// </summary>
        public const string GAMOK = "GAMOK";

        /// <summary>
        /// The BrowseName for the GAMStateMachineType component.
        /// </summary>
        public const string GAMStateMachineType = "GAMStateMachineType";

        /// <summary>
        /// The BrowseName for the GAMSystemStatusType component.
        /// </summary>
        public const string GAMSystemStatusType = "GAMSystemStatusType";

        /// <summary>
        /// The BrowseName for the GAMtemperatureOver35DegreeC component.
        /// </summary>
        public const string GAMtemperatureOver35DegreeC = "GAMtemperatureOver35DegreeC";

        /// <summary>
        /// The BrowseName for the IonReference component.
        /// </summary>
        public const string IonReference = "IonReference";

        /// <summary>
        /// The BrowseName for the IsValid component.
        /// </summary>
        public const string IsValid = "IsValid";

        /// <summary>
        /// The BrowseName for the ManualMode component.
        /// </summary>
        public const string ManualMode = "ManualMode";

        /// <summary>
        /// The BrowseName for the MCDValueType component.
        /// </summary>
        public const string MCDValueType = "MCDValueType";

        /// <summary>
        /// The BrowseName for the Operational component.
        /// </summary>
        public const string Operational = "Operational";

        /// <summary>
        /// The BrowseName for the Prefilter component.
        /// </summary>
        public const string Prefilter = "Prefilter";

        /// <summary>
        /// The BrowseName for the RawValue component.
        /// </summary>
        public const string RawValue = "RawValue";

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
        /// The BrowseName for the SensorValue component.
        /// </summary>
        public const string SensorValue = "SensorValue";

        /// <summary>
        /// The BrowseName for the Slope component.
        /// </summary>
        public const string Slope = "Slope";

        /// <summary>
        /// The BrowseName for the Start component.
        /// </summary>
        public const string Start = "Start";

        /// <summary>
        /// The BrowseName for the Stop component.
        /// </summary>
        public const string Stop = "Stop";

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
        /// The BrowseName for the TuneParametersFunctionSetType component.
        /// </summary>
        public const string TuneParametersFunctionSetType = "TuneParametersFunctionSetType";

        /// <summary>
        /// The BrowseName for the UOffset component.
        /// </summary>
        public const string UOffset = "UOffset";

        /// <summary>
        /// The BrowseName for the UVRatio component.
        /// </summary>
        public const string UVRatio = "UVRatio";

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
        /// The URI for the LADS namespace (.NET code namespace is 'Spectaris.LADS').
        /// </summary>
        public const string LADS = "http://spectaris.de/LADS/";

        /// <summary>
        /// The URI for the LADSXsd namespace (.NET code namespace is 'Spectaris.LADS').
        /// </summary>
        public const string LADSXsd = "http://spectaris.de/LADS/Types.xsd";

        /// <summary>
        /// The URI for the GAM namespace (.NET code namespace is 'IPI.OpcUaServer.GAM').
        /// </summary>
        public const string GAM = "http://in-process.com/UA/GAM/";

        /// <summary>
        /// The URI for the GAMXsd namespace (.NET code namespace is 'IPI.OpcUaServer.GAM').
        /// </summary>
        public const string GAMXsd = "http://in-process.com/UA/GAM/Types.xsd";
    }
    #endregion
}