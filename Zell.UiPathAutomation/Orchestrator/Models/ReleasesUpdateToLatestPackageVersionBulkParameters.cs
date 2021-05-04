// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ReleasesUpdateToLatestPackageVersionBulkParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ReleasesUpdateToLatestPackageVersionBulkParameters class.
        /// </summary>
        public ReleasesUpdateToLatestPackageVersionBulkParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ReleasesUpdateToLatestPackageVersionBulkParameters class.
        /// </summary>
        public ReleasesUpdateToLatestPackageVersionBulkParameters(IList<long?> releaseIds)
        {
            ReleaseIds = releaseIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "releaseIds")]
        public IList<long?> ReleaseIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReleaseIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReleaseIds");
            }
        }
    }
}
