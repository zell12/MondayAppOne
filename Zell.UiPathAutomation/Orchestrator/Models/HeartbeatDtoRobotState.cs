// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for HeartbeatDtoRobotState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HeartbeatDtoRobotState
    {
        [EnumMember(Value = "Available")]
        Available,
        [EnumMember(Value = "Busy")]
        Busy,
        [EnumMember(Value = "Disconnected")]
        Disconnected,
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    internal static class HeartbeatDtoRobotStateEnumExtension
    {
        internal static string ToSerializedValue(this HeartbeatDtoRobotState? value)
        {
            return value == null ? null : ((HeartbeatDtoRobotState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this HeartbeatDtoRobotState value)
        {
            switch( value )
            {
                case HeartbeatDtoRobotState.Available:
                    return "Available";
                case HeartbeatDtoRobotState.Busy:
                    return "Busy";
                case HeartbeatDtoRobotState.Disconnected:
                    return "Disconnected";
                case HeartbeatDtoRobotState.Unknown:
                    return "Unknown";
            }
            return null;
        }

        internal static HeartbeatDtoRobotState? ParseHeartbeatDtoRobotState(this string value)
        {
            switch( value )
            {
                case "Available":
                    return HeartbeatDtoRobotState.Available;
                case "Busy":
                    return HeartbeatDtoRobotState.Busy;
                case "Disconnected":
                    return HeartbeatDtoRobotState.Disconnected;
                case "Unknown":
                    return HeartbeatDtoRobotState.Unknown;
            }
            return null;
        }
    }
}
