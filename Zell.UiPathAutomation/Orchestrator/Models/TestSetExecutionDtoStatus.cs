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
    /// Defines values for TestSetExecutionDtoStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TestSetExecutionDtoStatus
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Cancelling")]
        Cancelling,
        [EnumMember(Value = "Passed")]
        Passed,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Cancelled")]
        Cancelled
    }
    internal static class TestSetExecutionDtoStatusEnumExtension
    {
        internal static string ToSerializedValue(this TestSetExecutionDtoStatus? value)
        {
            return value == null ? null : ((TestSetExecutionDtoStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TestSetExecutionDtoStatus value)
        {
            switch( value )
            {
                case TestSetExecutionDtoStatus.Pending:
                    return "Pending";
                case TestSetExecutionDtoStatus.Running:
                    return "Running";
                case TestSetExecutionDtoStatus.Cancelling:
                    return "Cancelling";
                case TestSetExecutionDtoStatus.Passed:
                    return "Passed";
                case TestSetExecutionDtoStatus.Failed:
                    return "Failed";
                case TestSetExecutionDtoStatus.Cancelled:
                    return "Cancelled";
            }
            return null;
        }

        internal static TestSetExecutionDtoStatus? ParseTestSetExecutionDtoStatus(this string value)
        {
            switch( value )
            {
                case "Pending":
                    return TestSetExecutionDtoStatus.Pending;
                case "Running":
                    return TestSetExecutionDtoStatus.Running;
                case "Cancelling":
                    return TestSetExecutionDtoStatus.Cancelling;
                case "Passed":
                    return TestSetExecutionDtoStatus.Passed;
                case "Failed":
                    return TestSetExecutionDtoStatus.Failed;
                case "Cancelled":
                    return TestSetExecutionDtoStatus.Cancelled;
            }
            return null;
        }
    }
}
