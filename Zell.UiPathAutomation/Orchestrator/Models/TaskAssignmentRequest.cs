// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class to hold assignment request details of a task.
    /// </summary>
    public partial class TaskAssignmentRequest
    {
        /// <summary>
        /// Initializes a new instance of the TaskAssignmentRequest class.
        /// </summary>
        public TaskAssignmentRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskAssignmentRequest class.
        /// </summary>
        /// <param name="taskId">Gets or sets the taskId for this task
        /// assignment.</param>
        /// <param name="userId">Gets or sets the userId for this task
        /// assignment.</param>
        /// <param name="userNameOrEmail">Gets or sets the UserName or Email
        /// for this task assignment. If UserId is provided, this property is
        /// ignored.</param>
        public TaskAssignmentRequest(long? taskId = default(long?), long? userId = default(long?), string userNameOrEmail = default(string))
        {
            TaskId = taskId;
            UserId = userId;
            UserNameOrEmail = userNameOrEmail;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the taskId for this task assignment.
        /// </summary>
        [JsonProperty(PropertyName = "TaskId")]
        public long? TaskId { get; set; }

        /// <summary>
        /// Gets or sets the userId for this task assignment.
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or sets the UserName or Email for this task assignment. If
        /// UserId is provided, this property is ignored.
        /// </summary>
        [JsonProperty(PropertyName = "UserNameOrEmail")]
        public string UserNameOrEmail { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TaskId != null)
            {
                if (TaskId < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "TaskId", 1);
                }
            }
            if (UserNameOrEmail != null)
            {
                if (UserNameOrEmail.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "UserNameOrEmail", 256);
                }
            }
        }
    }
}
