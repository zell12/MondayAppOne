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
    /// Stores information about the last status reported to Orchestrator by a
    /// registered robot.
    /// </summary>
    public partial class SessionDto
    {
        /// <summary>
        /// Initializes a new instance of the SessionDto class.
        /// </summary>
        public SessionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SessionDto class.
        /// </summary>
        /// <param name="hostMachineName">The name of the machine a Robot is
        /// hosted on.</param>
        /// <param name="machineId">The Id of the Machine.</param>
        /// <param name="machineName">The Machine's name.</param>
        /// <param name="state">The value of the last reported status. Possible
        /// values include: 'Available', 'Busy', 'Disconnected',
        /// 'Unknown'</param>
        /// <param name="reportingTime">The date and time when the last
        /// heartbeat came.</param>
        /// <param name="info">May store additional information about the robot
        /// state.</param>
        /// <param name="isUnresponsive">If the robot did not report status for
        /// longer than 120 seconds.</param>
        /// <param name="licenseErrorCode">DEPRECATED. Last licensing error
        /// status. Possible values include: 'NoLicense', 'LicenseExpired',
        /// 'LicenseUnregistered', 'NoAvailableLicenses',
        /// 'NotEnoughAvailableSlots', 'NotEnoughRuntimeLicenses',
        /// 'LicenseIsAlreadyInUse', 'InvalidRequest',
        /// 'SlotsExceedLicenseLimit', 'RuntimeDisabled',
        /// 'ExternalNotSupported', 'UsageExceedsLicenseLimit',
        /// 'LicenseNotCompatible'</param>
        /// <param name="organizationUnitId">The folder Id.</param>
        /// <param name="folderName">The folder display name.</param>
        public SessionDto(RobotWithLicenseDto robot = default(RobotWithLicenseDto), string hostMachineName = default(string), long? machineId = default(long?), string machineName = default(string), SessionDtoState? state = default(SessionDtoState?), JobDto job = default(JobDto), System.DateTime? reportingTime = default(System.DateTime?), string info = default(string), bool? isUnresponsive = default(bool?), SessionDtoLicenseErrorCode? licenseErrorCode = default(SessionDtoLicenseErrorCode?), long? organizationUnitId = default(long?), string folderName = default(string), long? id = default(long?))
        {
            Robot = robot;
            HostMachineName = hostMachineName;
            MachineId = machineId;
            MachineName = machineName;
            State = state;
            Job = job;
            ReportingTime = reportingTime;
            Info = info;
            IsUnresponsive = isUnresponsive;
            LicenseErrorCode = licenseErrorCode;
            OrganizationUnitId = organizationUnitId;
            FolderName = folderName;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Robot")]
        public RobotWithLicenseDto Robot { get; set; }

        /// <summary>
        /// Gets or sets the name of the machine a Robot is hosted on.
        /// </summary>
        [JsonProperty(PropertyName = "HostMachineName")]
        public string HostMachineName { get; set; }

        /// <summary>
        /// Gets or sets the Id of the Machine.
        /// </summary>
        [JsonProperty(PropertyName = "MachineId")]
        public long? MachineId { get; set; }

        /// <summary>
        /// Gets or sets the Machine's name.
        /// </summary>
        [JsonProperty(PropertyName = "MachineName")]
        public string MachineName { get; set; }

        /// <summary>
        /// Gets or sets the value of the last reported status. Possible values
        /// include: 'Available', 'Busy', 'Disconnected', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public SessionDtoState? State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Job")]
        public JobDto Job { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the last heartbeat came.
        /// </summary>
        [JsonProperty(PropertyName = "ReportingTime")]
        public System.DateTime? ReportingTime { get; set; }

        /// <summary>
        /// Gets or sets may store additional information about the robot
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "Info")]
        public string Info { get; set; }

        /// <summary>
        /// Gets or sets if the robot did not report status for longer than 120
        /// seconds.
        /// </summary>
        [JsonProperty(PropertyName = "IsUnresponsive")]
        public bool? IsUnresponsive { get; set; }

        /// <summary>
        /// Gets or sets DEPRECATED. Last licensing error status. Possible
        /// values include: 'NoLicense', 'LicenseExpired',
        /// 'LicenseUnregistered', 'NoAvailableLicenses',
        /// 'NotEnoughAvailableSlots', 'NotEnoughRuntimeLicenses',
        /// 'LicenseIsAlreadyInUse', 'InvalidRequest',
        /// 'SlotsExceedLicenseLimit', 'RuntimeDisabled',
        /// 'ExternalNotSupported', 'UsageExceedsLicenseLimit',
        /// 'LicenseNotCompatible'
        /// </summary>
        [JsonProperty(PropertyName = "LicenseErrorCode")]
        [System.Obsolete("This property is deprecated. Please do not use it any longer.")]
        public SessionDtoLicenseErrorCode? LicenseErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the folder Id.
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationUnitId")]
        public long? OrganizationUnitId { get; set; }

        /// <summary>
        /// Gets or sets the folder display name.
        /// </summary>
        [JsonProperty(PropertyName = "FolderName")]
        public string FolderName { get; set; }

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
            if (Robot != null)
            {
                Robot.Validate();
            }
            if (Job != null)
            {
                Job.Validate();
            }
        }
    }
}
