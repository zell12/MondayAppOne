using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zell.UiPathAutomation.Other.Models
{
    public class Asset
    {
        string _name;
        string _jsonData;

        public string JsonData { get => _jsonData ; set => _jsonData = value; }
        /// <summary>
        /// Input for GET endpoint
        /// </summary>
        public string Name { get => _name; }
        /// <summary>
        /// Output
        /// </summary>
        public string Id { get; set; }
        public string Value {
            get 
            {
                return JObject.Parse(_jsonData)?["Value"]?.ToString();
            }
        }
        public string StringValue
        {
            get
            {
                return JObject.Parse(_jsonData)?["StringValue"]?.ToString();
            }
        }

        public Asset(string workflowName, string variableName)
        {
            _name = $"{workflowName}{variableName}Asset"; 
        }
    }
}