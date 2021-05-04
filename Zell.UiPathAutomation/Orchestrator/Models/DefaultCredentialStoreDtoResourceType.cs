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
    /// Defines values for DefaultCredentialStoreDtoResourceType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DefaultCredentialStoreDtoResourceType
    {
        [EnumMember(Value = "AssetCredential")]
        AssetCredential,
        [EnumMember(Value = "RobotCredential")]
        RobotCredential,
        [EnumMember(Value = "BucketCredential")]
        BucketCredential,
        [EnumMember(Value = "Secrets")]
        Secrets
    }
    internal static class DefaultCredentialStoreDtoResourceTypeEnumExtension
    {
        internal static string ToSerializedValue(this DefaultCredentialStoreDtoResourceType? value)
        {
            return value == null ? null : ((DefaultCredentialStoreDtoResourceType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DefaultCredentialStoreDtoResourceType value)
        {
            switch( value )
            {
                case DefaultCredentialStoreDtoResourceType.AssetCredential:
                    return "AssetCredential";
                case DefaultCredentialStoreDtoResourceType.RobotCredential:
                    return "RobotCredential";
                case DefaultCredentialStoreDtoResourceType.BucketCredential:
                    return "BucketCredential";
                case DefaultCredentialStoreDtoResourceType.Secrets:
                    return "Secrets";
            }
            return null;
        }

        internal static DefaultCredentialStoreDtoResourceType? ParseDefaultCredentialStoreDtoResourceType(this string value)
        {
            switch( value )
            {
                case "AssetCredential":
                    return DefaultCredentialStoreDtoResourceType.AssetCredential;
                case "RobotCredential":
                    return DefaultCredentialStoreDtoResourceType.RobotCredential;
                case "BucketCredential":
                    return DefaultCredentialStoreDtoResourceType.BucketCredential;
                case "Secrets":
                    return DefaultCredentialStoreDtoResourceType.Secrets;
            }
            return null;
        }
    }
}
