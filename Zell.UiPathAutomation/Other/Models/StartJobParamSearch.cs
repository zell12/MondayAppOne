using System;
using System.Collections.Generic;
using System.Text;

namespace Zell.UiPathAutomation.Other.Models
{
    public class StartJobParamSearch
    {
        public enum ExecutionType
        {
            None,
            Foreground,
            Background
        }

        public ExecutionType ProcessExecution { get; set; }

        public string Process { get; set; }

        public string Folder { get; set; }

        public string Machine { get; set; }
    }
}
