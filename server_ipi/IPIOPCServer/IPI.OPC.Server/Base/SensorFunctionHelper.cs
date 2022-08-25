using IPI.OpcUaServer.GAM;
using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI.OpcUaServer.Base
{
    internal static class SensorFunctionHelper
    {
        public static double Randomize(Random random, double value, int precision)
        {
            var randomValue = value + (random.NextDouble() - 0.5) * (value / 100.0);
            double scalingFactor = Math.Pow(10, precision);
            return Math.Floor(randomValue * scalingFactor) / scalingFactor;
        }

        public static void Initialize_SensorFunctionState(DoubleAnalogSensorFunctionState sensorFunctionState, string displayName, double lowValue, double highValue, string unceCode)
        {
            Initialize_AnalogUnitRangeState(sensorFunctionState.Operational.RawValue, displayName + " Raw", lowValue, highValue, unceCode);
            Initialize_AnalogUnitRangeState(sensorFunctionState.Operational.SensorValue, displayName, lowValue, highValue, unceCode);
        }

        public static void Update_SensorFunctionState(DoubleAnalogSensorFunctionState sensorFunctionState, DateTime timeStamp, double value)
        {
            Update_AnalogUnitRangeState(sensorFunctionState.Operational.RawValue, timeStamp, value);
            Update_AnalogUnitRangeState(sensorFunctionState.Operational.SensorValue, timeStamp, value);
        }

        public static void Initialize_AnalogUnitRangeState<T>(AnalogUnitRangeState<T> analogUnitState, string displayName, double lowValue, double highValue, string unceCode)
        {
            //analogUnitState.DisplayName = displayName;
            analogUnitState.EURange.Value = new Opc.Ua.Range() { High = highValue, Low = lowValue };
            analogUnitState.EngineeringUnits.Value = null;

            switch (unceCode)
            {
                case "P1":
                    analogUnitState.EngineeringUnits.Value = new EUInformation("%", "percent", " http://www.opcfoundation.org/UA/units/un/cefact");
                    analogUnitState.EngineeringUnits.Value.UnitId = 20529;
                    break;
                case "VLT":
                    analogUnitState.EngineeringUnits.Value = new EUInformation("V", "volt", " http://www.opcfoundation.org/UA/units/un/cefact");
                    analogUnitState.EngineeringUnits.Value.UnitId = 5655636;
                    break;
                case "AMP":
                    analogUnitState.EngineeringUnits.Value = new EUInformation("A", "ampere", " http://www.opcfoundation.org/UA/units/un/cefact");
                    analogUnitState.EngineeringUnits.Value.UnitId = 4279632;
                    break;
            }
        }

        public static void Update_AnalogUnitRangeState<T>(AnalogUnitRangeState<T> analogUnitState, DateTime timeStamp, T value)
        {
            analogUnitState.Value = value;
            analogUnitState.Timestamp = timeStamp;
        }
    }
}
