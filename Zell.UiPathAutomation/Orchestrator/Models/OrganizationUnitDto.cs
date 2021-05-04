// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stores information about an organization unit in Orchestrator.
    /// &lt;para /&gt; An orchestrator unit can be understood as a company
    /// department and it is used to group different entities.
    /// </summary>
    public partial class OrganizationUnitDto
    {
        /// <summary>
        /// Initializes a new instance of the OrganizationUnitDto class.
        /// </summary>
        public OrganizationUnitDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrganizationUnitDto class.
        /// </summary>
        /// <param name="displayName">The name of the organization
        /// unit.</param>
        public OrganizationUnitDto(string displayName, long? id = default(long?))
        {
            DisplayName = displayName;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the organization unit.
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 128);
                }
            }
        }
    }
}
