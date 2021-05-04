using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace Utilities
{
    public class JsonProcessing
    {
        public static string ExtractFromODataJsonByKey(string oDataResponse, string keyName)
        {
            JObject oDataJson = JObject.Parse(oDataResponse);
            string keyValue = oDataJson?["value"]?[0]?[keyName]?.ToString();
            return keyValue;
        }
    }
}