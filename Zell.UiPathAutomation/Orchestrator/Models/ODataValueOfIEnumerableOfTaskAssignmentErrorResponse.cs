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

    public partial class ODataValueOfIEnumerableOfTaskAssignmentErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ODataValueOfIEnumerableOfTaskAssignmentErrorResponse class.
        /// </summary>
        public ODataValueOfIEnumerableOfTaskAssignmentErrorResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ODataValueOfIEnumerableOfTaskAssignmentErrorResponse class.
        /// </summary>
        public ODataValueOfIEnumerableOfTaskAssignmentErrorResponse(IList<TaskAssignmentErrorResponse> value = default(IList<TaskAssignmentErrorResponse>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<TaskAssignmentErrorResponse> Value { get; set; }

    }
}
