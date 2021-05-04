// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details about credential store
    /// </summary>
    public partial class CredentialStoreDetailsDto
    {
        /// <summary>
        /// Initializes a new instance of the CredentialStoreDetailsDto class.
        /// </summary>
        public CredentialStoreDetailsDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CredentialStoreDetailsDto class.
        /// </summary>
        /// <param name="isReadOnly">Current store is read only</param>
        public CredentialStoreDetailsDto(bool? isReadOnly = default(bool?))
        {
            IsReadOnly = isReadOnly;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets current store is read only
        /// </summary>
        [JsonProperty(PropertyName = "IsReadOnly")]
        public bool? IsReadOnly { get; set; }

    }
}
