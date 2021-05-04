using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MondayLibs.Models.Monday
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Board Board { get; set; }

        [JsonProperty("column_values")]
        public List<ColumnValue> ColumnValues { get; set; }
    }
}
