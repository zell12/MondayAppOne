// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TestEnvironmentDto
    {
        /// <summary>
        /// Initializes a new instance of the TestEnvironmentDto class.
        /// </summary>
        public TestEnvironmentDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestEnvironmentDto class.
        /// </summary>
        public TestEnvironmentDto(string name = default(string), long? id = default(long?))
        {
            Name = name;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
