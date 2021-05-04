// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SettingsUpdateUserSettingParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SettingsUpdateUserSettingParameters class.
        /// </summary>
        public SettingsUpdateUserSettingParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SettingsUpdateUserSettingParameters class.
        /// </summary>
        public SettingsUpdateUserSettingParameters(SettingsDto setting = default(SettingsDto))
        {
            Setting = setting;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "setting")]
        public SettingsDto Setting { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Setting != null)
            {
                Setting.Validate();
            }
        }
    }
}