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

    public partial class ODataValueOfIEnumerableOfTestSetScheduleDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ODataValueOfIEnumerableOfTestSetScheduleDto class.
        /// </summary>
        public ODataValueOfIEnumerableOfTestSetScheduleDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ODataValueOfIEnumerableOfTestSetScheduleDto class.
        /// </summary>
        public ODataValueOfIEnumerableOfTestSetScheduleDto(IList<TestSetScheduleDto> value = default(IList<TestSetScheduleDto>))
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
        public IList<TestSetScheduleDto> Value { get; set; }

    }
}
