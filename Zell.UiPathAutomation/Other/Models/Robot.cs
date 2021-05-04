namespace Zell.UiPathAutomation.Other.Models
{
    public class Robot
    {
        string _machineName;

        string Name { get; set; }
        /// <summary>
        /// Input for GET endpoint
        /// </summary>
        public string MachineName { get => _machineName; }
        /// <summary>
        /// Output
        /// </summary>
        public string Id { get; set; }

        public Robot()
        { }

        public Robot(string machineName)
        {
            _machineName = machineName;
        }

        
    }
}