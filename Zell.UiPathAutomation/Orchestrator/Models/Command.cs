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
    /// Base command model
    /// All commands must inherit from this
    /// </summary>
    public partial class Command
    {
        /// <summary>
        /// Initializes a new instance of the Command class.
        /// </summary>
        public Command()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Command class.
        /// </summary>
        public Command(System.Guid? id = default(System.Guid?), string type = default(string))
        {
            Id = id;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
