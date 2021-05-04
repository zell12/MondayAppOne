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
    /// Defines values for FolderNavigationContextDtoProvisionType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FolderNavigationContextDtoProvisionType
    {
        [EnumMember(Value = "Manual")]
        Manual,
        [EnumMember(Value = "Automatic")]
        Automatic
    }
    internal static class FolderNavigationContextDtoProvisionTypeEnumExtension
    {
        internal static string ToSerializedValue(this FolderNavigationContextDtoProvisionType? value)
        {
            return value == null ? null : ((FolderNavigationContextDtoProvisionType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this FolderNavigationContextDtoProvisionType value)
        {
            switch( value )
            {
                case FolderNavigationContextDtoProvisionType.Manual:
                    return "Manual";
                case FolderNavigationContextDtoProvisionType.Automatic:
                    return "Automatic";
            }
            return null;
        }

        internal static FolderNavigationContextDtoProvisionType? ParseFolderNavigationContextDtoProvisionType(this string value)
        {
            switch( value )
            {
                case "Manual":
                    return FolderNavigationContextDtoProvisionType.Manual;
                case "Automatic":
                    return FolderNavigationContextDtoProvisionType.Automatic;
            }
            return null;
        }
    }
}