// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class TestCaseInfoDto
    {
        /// <summary>
        /// Initializes a new instance of the TestCaseInfoDto class.
        /// </summary>
        public TestCaseInfoDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestCaseInfoDto class.
        /// </summary>
        public TestCaseInfoDto(System.Guid uniqueId, string packageIdentifier = default(string), IList<object> inputArgumentsVariations = default(IList<object>))
        {
            UniqueId = uniqueId;
            PackageIdentifier = packageIdentifier;
            InputArgumentsVariations = inputArgumentsVariations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UniqueId")]
        public System.Guid UniqueId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PackageIdentifier")]
        public string PackageIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InputArgumentsVariations")]
        public IList<object> InputArgumentsVariations { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
