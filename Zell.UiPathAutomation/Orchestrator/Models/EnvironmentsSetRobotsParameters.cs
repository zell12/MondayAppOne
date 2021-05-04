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

    public partial class EnvironmentsSetRobotsParameters
    {
        /// <summary>
        /// Initializes a new instance of the EnvironmentsSetRobotsParameters
        /// class.
        /// </summary>
        public EnvironmentsSetRobotsParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnvironmentsSetRobotsParameters
        /// class.
        /// </summary>
        public EnvironmentsSetRobotsParameters(IList<long?> addedRobotIds, IList<long?> removedRobotIds)
        {
            AddedRobotIds = addedRobotIds;
            RemovedRobotIds = removedRobotIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addedRobotIds")]
        public IList<long?> AddedRobotIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "removedRobotIds")]
        public IList<long?> RemovedRobotIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AddedRobotIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AddedRobotIds");
            }
            if (RemovedRobotIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RemovedRobotIds");
            }
        }
    }
}
