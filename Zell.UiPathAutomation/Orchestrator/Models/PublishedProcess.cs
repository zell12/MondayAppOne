// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PublishedProcess
    {
        /// <summary>
        /// Initializes a new instance of the PublishedProcess class.
        /// </summary>
        public PublishedProcess()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublishedProcess class.
        /// </summary>
        public PublishedProcess(string activationKey = default(string), string processName = default(string), string processDescription = default(string), System.Guid? processKey = default(System.Guid?), string packageId = default(string), string packageVersion = default(string), string inputArguments = default(string), long? folderId = default(long?), string folderName = default(string), ProcessSettingsDto processSettings = default(ProcessSettingsDto), string folderFullyQualifiedName = default(string), string feedUrl = default(string))
        {
            ActivationKey = activationKey;
            ProcessName = processName;
            ProcessDescription = processDescription;
            ProcessKey = processKey;
            PackageId = packageId;
            PackageVersion = packageVersion;
            InputArguments = inputArguments;
            FolderId = folderId;
            FolderName = folderName;
            ProcessSettings = processSettings;
            FolderFullyQualifiedName = folderFullyQualifiedName;
            FeedUrl = feedUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activationKey")]
        public string ActivationKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processName")]
        public string ProcessName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processDescription")]
        public string ProcessDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processKey")]
        public System.Guid? ProcessKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "packageId")]
        public string PackageId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "packageVersion")]
        public string PackageVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inputArguments")]
        public string InputArguments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "folderId")]
        public long? FolderId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "folderName")]
        public string FolderName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processSettings")]
        public ProcessSettingsDto ProcessSettings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "folderFullyQualifiedName")]
        public string FolderFullyQualifiedName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "feedUrl")]
        public string FeedUrl { get; set; }

    }
}
