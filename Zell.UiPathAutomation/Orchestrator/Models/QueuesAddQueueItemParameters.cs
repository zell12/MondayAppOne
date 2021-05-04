// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class QueuesAddQueueItemParameters
    {
        /// <summary>
        /// Initializes a new instance of the QueuesAddQueueItemParameters
        /// class.
        /// </summary>
        public QueuesAddQueueItemParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueuesAddQueueItemParameters
        /// class.
        /// </summary>
        public QueuesAddQueueItemParameters(QueueItemDataDto itemData = default(QueueItemDataDto))
        {
            ItemData = itemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemData")]
        public QueueItemDataDto ItemData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ItemData != null)
            {
                ItemData.Validate();
            }
        }
    }
}
