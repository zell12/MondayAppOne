// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UserLoginInfoDto
    {
        /// <summary>
        /// Initializes a new instance of the UserLoginInfoDto class.
        /// </summary>
        public UserLoginInfoDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserLoginInfoDto class.
        /// </summary>
        public UserLoginInfoDto(string name = default(string), string surname = default(string), string userName = default(string), string emailAddress = default(string), long? id = default(long?))
        {
            Name = name;
            Surname = surname;
            UserName = userName;
            EmailAddress = emailAddress;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }

    }
}