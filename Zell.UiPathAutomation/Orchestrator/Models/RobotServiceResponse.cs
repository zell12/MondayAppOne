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

    public partial class RobotServiceResponse
    {
        /// <summary>
        /// Initializes a new instance of the RobotServiceResponse class.
        /// </summary>
        public RobotServiceResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RobotServiceResponse class.
        /// </summary>
        public RobotServiceResponse(IList<RobotDetailsDto> robots = default(IList<RobotDetailsDto>))
        {
            Robots = robots;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "robots")]
        public IList<RobotDetailsDto> Robots { get; set; }

    }
}