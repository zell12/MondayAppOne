namespace Zell.UiPathAutomation.Other.Models
{
    public class ProcessRelease
    {
        string _name;
        public string ProcessKey;
        /// <summary>
        /// Input for GET endpoint
        /// </summary>
        public string Name { get => _name; }
        /// <summary>
        /// Output
        /// </summary>
        public string Key { get; set; }
        
        public ProcessRelease(string workflowName, string envName)
        {
            ProcessKey = workflowName;
            _name = $"{ProcessKey}_{envName}";
        }
    }
}