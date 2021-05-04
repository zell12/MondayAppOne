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

    public partial class TestSetExecutionDto
    {
        /// <summary>
        /// Initializes a new instance of the TestSetExecutionDto class.
        /// </summary>
        public TestSetExecutionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestSetExecutionDto class.
        /// </summary>
        /// <param name="status">Possible values include: 'Pending', 'Running',
        /// 'Cancelling', 'Passed', 'Failed', 'Cancelled'</param>
        /// <param name="triggerType">Possible values include: 'Manual',
        /// 'Scheduled', 'ExternalTool'</param>
        public TestSetExecutionDto(string name = default(string), long? testSetId = default(long?), long? organizationUnitId = default(long?), TestSetDto testSet = default(TestSetDto), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), TestSetExecutionDtoStatus? status = default(TestSetExecutionDtoStatus?), TestSetExecutionDtoTriggerType? triggerType = default(TestSetExecutionDtoTriggerType?), long? scheduleId = default(long?), System.Guid? batchExecutionKey = default(System.Guid?), IList<TestCaseExecutionDto> testCaseExecutions = default(IList<TestCaseExecutionDto>), System.DateTime? creationTime = default(System.DateTime?), long? creatorUserId = default(long?), long? id = default(long?))
        {
            Name = name;
            TestSetId = testSetId;
            OrganizationUnitId = organizationUnitId;
            TestSet = testSet;
            StartTime = startTime;
            EndTime = endTime;
            Status = status;
            TriggerType = triggerType;
            ScheduleId = scheduleId;
            BatchExecutionKey = batchExecutionKey;
            TestCaseExecutions = testCaseExecutions;
            CreationTime = creationTime;
            CreatorUserId = creatorUserId;
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
        [JsonProperty(PropertyName = "TestSetId")]
        public long? TestSetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationUnitId")]
        public long? OrganizationUnitId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TestSet")]
        public TestSetDto TestSet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StartTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EndTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Pending', 'Running',
        /// 'Cancelling', 'Passed', 'Failed', 'Cancelled'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public TestSetExecutionDtoStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Manual', 'Scheduled',
        /// 'ExternalTool'
        /// </summary>
        [JsonProperty(PropertyName = "TriggerType")]
        public TestSetExecutionDtoTriggerType? TriggerType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ScheduleId")]
        public long? ScheduleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BatchExecutionKey")]
        public System.Guid? BatchExecutionKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TestCaseExecutions")]
        public IList<TestCaseExecutionDto> TestCaseExecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatorUserId")]
        public long? CreatorUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TestSet != null)
            {
                TestSet.Validate();
            }
            if (TestCaseExecutions != null)
            {
                foreach (var element in TestCaseExecutions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
