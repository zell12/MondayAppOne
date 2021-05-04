// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SimpleFolderDto
    {
        /// <summary>
        /// Initializes a new instance of the SimpleFolderDto class.
        /// </summary>
        public SimpleFolderDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimpleFolderDto class.
        /// </summary>
        public SimpleFolderDto(string displayName = default(string), string fullyQualifiedName = default(string), long? id = default(long?))
        {
            DisplayName = displayName;
            FullyQualifiedName = fullyQualifiedName;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FullyQualifiedName")]
        public string FullyQualifiedName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
