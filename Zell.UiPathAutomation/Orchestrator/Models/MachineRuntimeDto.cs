// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MachineRuntimeDto
    {
        /// <summary>
        /// Initializes a new instance of the MachineRuntimeDto class.
        /// </summary>
        public MachineRuntimeDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MachineRuntimeDto class.
        /// </summary>
        /// <param name="type">Possible values include: 'NonProduction',
        /// 'Attended', 'Unattended', 'Studio', 'Development', 'StudioX',
        /// 'Headless', 'StudioPro', 'TestAutomation'</param>
        public MachineRuntimeDto(MachineRuntimeDtoType? type = default(MachineRuntimeDtoType?), long? total = default(long?), long? connected = default(long?), long? available = default(long?))
        {
            Type = type;
            Total = total;
            Connected = connected;
            Available = available;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'NonProduction', 'Attended',
        /// 'Unattended', 'Studio', 'Development', 'StudioX', 'Headless',
        /// 'StudioPro', 'TestAutomation'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public MachineRuntimeDtoType? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Total")]
        public long? Total { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Connected")]
        public long? Connected { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Available")]
        public long? Available { get; set; }

    }
}
