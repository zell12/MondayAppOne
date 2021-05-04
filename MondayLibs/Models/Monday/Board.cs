using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MondayLibs.Models.Monday
{
    public class Board
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Item[] Items { get; set; }
        public Group[] Groups { get; set; }
        public List<Column> Columns { get; set; }
    }
}
