using System;
using System.Collections.Generic;
using System.Text;

namespace MondayLibs.Models.Monday
{
    public class CustomEntity
    {
        public string id { get; set; }
        public string title { get; set; }
        public string outboundType { get; set; }
        public List<string> inboundTypes { get; set; }
    }
}
