using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MondayLibs.Models.Monday
{
    public class Asset
    {
        public string Name { get; set; }

        public string Url { get; set; }

        [JsonProperty("public_url")]
        public string PublicUrl { get; set; }
    }
}
