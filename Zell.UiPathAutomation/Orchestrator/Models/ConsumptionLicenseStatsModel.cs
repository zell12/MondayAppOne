// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ConsumptionLicenseStatsModel
    {
        /// <summary>
        /// Initializes a new instance of the ConsumptionLicenseStatsModel
        /// class.
        /// </summary>
        public ConsumptionLicenseStatsModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConsumptionLicenseStatsModel
        /// class.
        /// </summary>
        public ConsumptionLicenseStatsModel(string type = default(string), long? used = default(long?), long? total = default(long?), System.DateTime? timestamp = default(System.DateTime?))
        {
            Type = type;
            Used = used;
            Total = total;
            Timestamp = timestamp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "used")]
        public long? Used { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public long? Total { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

    }
}
