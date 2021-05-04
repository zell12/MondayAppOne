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
    /// Entity that represents an acquired Robot license
    /// </summary>
    public partial class RobotLicenseDto
    {
        /// <summary>
        /// Initializes a new instance of the RobotLicenseDto class.
        /// </summary>
        public RobotLicenseDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RobotLicenseDto class.
        /// </summary>
        /// <param name="robotId">The associated Robot's Id</param>
        /// <param name="timestamp">The date when the license was
        /// acquired</param>
        public RobotLicenseDto(long? robotId = default(long?), System.DateTime? timestamp = default(System.DateTime?), long? id = default(long?))
        {
            RobotId = robotId;
            Timestamp = timestamp;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the associated Robot's Id
        /// </summary>
        [JsonProperty(PropertyName = "RobotId")]
        public long? RobotId { get; set; }

        /// <summary>
        /// Gets or sets the date when the license was acquired
        /// </summary>
        [JsonProperty(PropertyName = "Timestamp")]
        public System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
