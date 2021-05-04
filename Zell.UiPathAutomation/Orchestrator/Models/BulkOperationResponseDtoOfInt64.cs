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

    public partial class BulkOperationResponseDtoOfInt64
    {
        /// <summary>
        /// Initializes a new instance of the BulkOperationResponseDtoOfInt64
        /// class.
        /// </summary>
        public BulkOperationResponseDtoOfInt64()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BulkOperationResponseDtoOfInt64
        /// class.
        /// </summary>
        public BulkOperationResponseDtoOfInt64(bool? success = default(bool?), string message = default(string), IList<long?> failedItems = default(IList<long?>))
        {
            Success = success;
            Message = message;
            FailedItems = failedItems;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Success")]
        public bool? Success { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FailedItems")]
        public IList<long?> FailedItems { get; set; }

    }
}
