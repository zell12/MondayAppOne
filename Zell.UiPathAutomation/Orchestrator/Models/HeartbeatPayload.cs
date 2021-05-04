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

    public partial class HeartbeatPayload
    {
        /// <summary>
        /// Initializes a new instance of the HeartbeatPayload class.
        /// </summary>
        public HeartbeatPayload()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HeartbeatPayload class.
        /// </summary>
        /// <param name="commandState">Possible values include: 'All',
        /// 'Pending'</param>
        public HeartbeatPayload(IList<HeartbeatDto> heartbeats = default(IList<HeartbeatDto>), HeartbeatPayloadCommandState? commandState = default(HeartbeatPayloadCommandState?), string serviceUserName = default(string))
        {
            Heartbeats = heartbeats;
            CommandState = commandState;
            ServiceUserName = serviceUserName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "heartbeats")]
        public IList<HeartbeatDto> Heartbeats { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'All', 'Pending'
        /// </summary>
        [JsonProperty(PropertyName = "commandState")]
        public HeartbeatPayloadCommandState? CommandState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceUserName")]
        public string ServiceUserName { get; set; }

    }
}
