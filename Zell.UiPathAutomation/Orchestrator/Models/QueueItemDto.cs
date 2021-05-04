// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines a piece of data that can be processed by a robot and the
    /// information associated with its processing status.
    /// &lt;para /&gt;Queue items are grouped in queues.
    /// </summary>
    public partial class QueueItemDto
    {
        /// <summary>
        /// Initializes a new instance of the QueueItemDto class.
        /// </summary>
        public QueueItemDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueueItemDto class.
        /// </summary>
        /// <param name="queueDefinitionId">The Id of the parent queue.</param>
        /// <param name="specificContent">A collection of key value pairs
        /// containing custom data configured in the Add Queue Item activity,
        /// in UiPath Studio.</param>
        /// <param name="output">A collection of key value pairs containing
        /// custom data resulted after successful processing.</param>
        /// <param name="outputData">A JSON representation of the output data
        /// generated by the item's processing.</param>
        /// <param name="analytics">A collection of key value pairs containing
        /// custom data for further analytics processing.</param>
        /// <param name="analyticsData">A JSON representation of the analytics
        /// data generated by the item's processing.</param>
        /// <param name="status">The processing state of the item. Possible
        /// values include: 'New', 'InProgress', 'Failed', 'Successful',
        /// 'Abandoned', 'Retried', 'Deleted'</param>
        /// <param name="reviewStatus">The review state of the item -
        /// applicable only for failed items. Possible values include: 'None',
        /// 'InReview', 'Verified', 'Retried'</param>
        /// <param name="reviewerUserId">The UserId of the Reviewer, if
        /// any.</param>
        /// <param name="key">The unique identifier of a queue item.</param>
        /// <param name="reference">An optional, user-specified value for queue
        /// item identification.</param>
        /// <param name="processingExceptionType">The processing exception. If
        /// the item has not been processed or has been processed successfully
        /// it will be null. Possible values include: 'ApplicationException',
        /// 'BusinessException'</param>
        /// <param name="dueDate">The latest date and time at which the item
        /// should be processed. If empty the item can be processed at any
        /// given time.</param>
        /// <param name="riskSlaDate">The RiskSla date at time which is
        /// considered as risk zone for the item to be processed.</param>
        /// <param name="priority">Sets the processing importance for a given
        /// item. Possible values include: 'High', 'Normal', 'Low'</param>
        /// <param name="deferDate">The earliest date and time at which the
        /// item is available for processing. If empty the item can be
        /// processed as soon as possible.</param>
        /// <param name="startProcessing">The date and time at which the item
        /// processing started. This is null if the item was not
        /// processed.</param>
        /// <param name="endProcessing">The date and time at which the item
        /// processing ended. This is null if the item was not
        /// processed.</param>
        /// <param name="secondsInPreviousAttempts">The number of seconds that
        /// the last failed processing lasted.</param>
        /// <param name="ancestorId">The Id of an ancestor item connected to
        /// the current item.</param>
        /// <param name="retryNumber">The number of times this work item has
        /// been processed.
        /// &lt;para /&gt;This can be higher than 0 only if MaxRetried number
        /// is set and the item processing failed at least once with
        /// ApplicationException.</param>
        /// <param name="specificData">A JSON representation of the specific
        /// content.</param>
        /// <param name="creationTime">The date and time when the item was
        /// created.</param>
        /// <param name="progress">String field which is used to keep track of
        /// the business flow progress.</param>
        /// <param name="rowVersion">Identifier used for optimistic
        /// concurrency, so Orchestrator can figure whether data is out of date
        /// or not.</param>
        /// <param name="organizationUnitId">Id of the folder this item is part
        /// of.</param>
        /// <param name="organizationUnitFullyQualifiedName">Fully qualified
        /// name of the folder this item is part of.</param>
        public QueueItemDto(long? queueDefinitionId = default(long?), QueueDefinitionDto queueDefinition = default(QueueDefinitionDto), ProcessingExceptionDto processingException = default(ProcessingExceptionDto), IDictionary<string, object> specificContent = default(IDictionary<string, object>), IDictionary<string, object> output = default(IDictionary<string, object>), string outputData = default(string), IDictionary<string, object> analytics = default(IDictionary<string, object>), string analyticsData = default(string), QueueItemDtoStatus? status = default(QueueItemDtoStatus?), QueueItemDtoReviewStatus? reviewStatus = default(QueueItemDtoReviewStatus?), long? reviewerUserId = default(long?), SimpleUserDto reviewerUser = default(SimpleUserDto), System.Guid? key = default(System.Guid?), string reference = default(string), QueueItemDtoProcessingExceptionType? processingExceptionType = default(QueueItemDtoProcessingExceptionType?), System.DateTime? dueDate = default(System.DateTime?), System.DateTime? riskSlaDate = default(System.DateTime?), QueueItemDtoPriority? priority = default(QueueItemDtoPriority?), SimpleRobotDto robot = default(SimpleRobotDto), System.DateTime? deferDate = default(System.DateTime?), System.DateTime? startProcessing = default(System.DateTime?), System.DateTime? endProcessing = default(System.DateTime?), int? secondsInPreviousAttempts = default(int?), long? ancestorId = default(long?), int? retryNumber = default(int?), string specificData = default(string), System.DateTime? creationTime = default(System.DateTime?), string progress = default(string), byte[] rowVersion = default(byte[]), long? organizationUnitId = default(long?), string organizationUnitFullyQualifiedName = default(string), long? id = default(long?))
        {
            QueueDefinitionId = queueDefinitionId;
            QueueDefinition = queueDefinition;
            ProcessingException = processingException;
            SpecificContent = specificContent;
            Output = output;
            OutputData = outputData;
            Analytics = analytics;
            AnalyticsData = analyticsData;
            Status = status;
            ReviewStatus = reviewStatus;
            ReviewerUserId = reviewerUserId;
            ReviewerUser = reviewerUser;
            Key = key;
            Reference = reference;
            ProcessingExceptionType = processingExceptionType;
            DueDate = dueDate;
            RiskSlaDate = riskSlaDate;
            Priority = priority;
            Robot = robot;
            DeferDate = deferDate;
            StartProcessing = startProcessing;
            EndProcessing = endProcessing;
            SecondsInPreviousAttempts = secondsInPreviousAttempts;
            AncestorId = ancestorId;
            RetryNumber = retryNumber;
            SpecificData = specificData;
            CreationTime = creationTime;
            Progress = progress;
            RowVersion = rowVersion;
            OrganizationUnitId = organizationUnitId;
            OrganizationUnitFullyQualifiedName = organizationUnitFullyQualifiedName;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Id of the parent queue.
        /// </summary>
        [JsonProperty(PropertyName = "QueueDefinitionId")]
        public long? QueueDefinitionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueDefinition")]
        public QueueDefinitionDto QueueDefinition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProcessingException")]
        public ProcessingExceptionDto ProcessingException { get; set; }

        /// <summary>
        /// Gets or sets a collection of key value pairs containing custom data
        /// configured in the Add Queue Item activity, in UiPath Studio.
        /// </summary>
        [JsonProperty(PropertyName = "SpecificContent")]
        public IDictionary<string, object> SpecificContent { get; set; }

        /// <summary>
        /// Gets or sets a collection of key value pairs containing custom data
        /// resulted after successful processing.
        /// </summary>
        [JsonProperty(PropertyName = "Output")]
        public IDictionary<string, object> Output { get; set; }

        /// <summary>
        /// Gets or sets a JSON representation of the output data generated by
        /// the item's processing.
        /// </summary>
        [JsonProperty(PropertyName = "OutputData")]
        public string OutputData { get; set; }

        /// <summary>
        /// Gets or sets a collection of key value pairs containing custom data
        /// for further analytics processing.
        /// </summary>
        [JsonProperty(PropertyName = "Analytics")]
        public IDictionary<string, object> Analytics { get; set; }

        /// <summary>
        /// Gets or sets a JSON representation of the analytics data generated
        /// by the item's processing.
        /// </summary>
        [JsonProperty(PropertyName = "AnalyticsData")]
        public string AnalyticsData { get; set; }

        /// <summary>
        /// Gets or sets the processing state of the item. Possible values
        /// include: 'New', 'InProgress', 'Failed', 'Successful', 'Abandoned',
        /// 'Retried', 'Deleted'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public QueueItemDtoStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets the review state of the item - applicable only for
        /// failed items. Possible values include: 'None', 'InReview',
        /// 'Verified', 'Retried'
        /// </summary>
        [JsonProperty(PropertyName = "ReviewStatus")]
        public QueueItemDtoReviewStatus? ReviewStatus { get; set; }

        /// <summary>
        /// Gets or sets the UserId of the Reviewer, if any.
        /// </summary>
        [JsonProperty(PropertyName = "ReviewerUserId")]
        public long? ReviewerUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReviewerUser")]
        public SimpleUserDto ReviewerUser { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of a queue item.
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public System.Guid? Key { get; set; }

        /// <summary>
        /// Gets or sets an optional, user-specified value for queue item
        /// identification.
        /// </summary>
        [JsonProperty(PropertyName = "Reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the processing exception. If the item has not been
        /// processed or has been processed successfully it will be null.
        /// Possible values include: 'ApplicationException',
        /// 'BusinessException'
        /// </summary>
        [JsonProperty(PropertyName = "ProcessingExceptionType")]
        public QueueItemDtoProcessingExceptionType? ProcessingExceptionType { get; set; }

        /// <summary>
        /// Gets or sets the latest date and time at which the item should be
        /// processed. If empty the item can be processed at any given time.
        /// </summary>
        [JsonProperty(PropertyName = "DueDate")]
        public System.DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets the RiskSla date at time which is considered as risk
        /// zone for the item to be processed.
        /// </summary>
        [JsonProperty(PropertyName = "RiskSlaDate")]
        public System.DateTime? RiskSlaDate { get; set; }

        /// <summary>
        /// Gets or sets sets the processing importance for a given item.
        /// Possible values include: 'High', 'Normal', 'Low'
        /// </summary>
        [JsonProperty(PropertyName = "Priority")]
        public QueueItemDtoPriority? Priority { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Robot")]
        public SimpleRobotDto Robot { get; set; }

        /// <summary>
        /// Gets or sets the earliest date and time at which the item is
        /// available for processing. If empty the item can be processed as
        /// soon as possible.
        /// </summary>
        [JsonProperty(PropertyName = "DeferDate")]
        public System.DateTime? DeferDate { get; set; }

        /// <summary>
        /// Gets or sets the date and time at which the item processing
        /// started. This is null if the item was not processed.
        /// </summary>
        [JsonProperty(PropertyName = "StartProcessing")]
        public System.DateTime? StartProcessing { get; set; }

        /// <summary>
        /// Gets or sets the date and time at which the item processing ended.
        /// This is null if the item was not processed.
        /// </summary>
        [JsonProperty(PropertyName = "EndProcessing")]
        public System.DateTime? EndProcessing { get; set; }

        /// <summary>
        /// Gets or sets the number of seconds that the last failed processing
        /// lasted.
        /// </summary>
        [JsonProperty(PropertyName = "SecondsInPreviousAttempts")]
        public int? SecondsInPreviousAttempts { get; set; }

        /// <summary>
        /// Gets or sets the Id of an ancestor item connected to the current
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "AncestorId")]
        public long? AncestorId { get; set; }

        /// <summary>
        /// Gets or sets the number of times this work item has been processed.
        /// &amp;lt;para /&amp;gt;This can be higher than 0 only if MaxRetried
        /// number is set and the item processing failed at least once with
        /// ApplicationException.
        /// </summary>
        [JsonProperty(PropertyName = "RetryNumber")]
        public int? RetryNumber { get; set; }

        /// <summary>
        /// Gets or sets a JSON representation of the specific content.
        /// </summary>
        [JsonProperty(PropertyName = "SpecificData")]
        public string SpecificData { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the item was created.
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets string field which is used to keep track of the
        /// business flow progress.
        /// </summary>
        [JsonProperty(PropertyName = "Progress")]
        public string Progress { get; set; }

        /// <summary>
        /// Gets or sets identifier used for optimistic concurrency, so
        /// Orchestrator can figure whether data is out of date or not.
        /// </summary>
        [JsonProperty(PropertyName = "RowVersion")]
        public byte[] RowVersion { get; set; }

        /// <summary>
        /// Gets or sets id of the folder this item is part of.
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationUnitId")]
        public long? OrganizationUnitId { get; set; }

        /// <summary>
        /// Gets or sets fully qualified name of the folder this item is part
        /// of.
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationUnitFullyQualifiedName")]
        public string OrganizationUnitFullyQualifiedName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (QueueDefinition != null)
            {
                QueueDefinition.Validate();
            }
            if (ReviewerUser != null)
            {
                ReviewerUser.Validate();
            }
            if (Reference != null)
            {
                if (Reference.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Reference", 128);
                }
                if (Reference.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Reference", 0);
                }
            }
            if (Robot != null)
            {
                Robot.Validate();
            }
        }
    }
}
