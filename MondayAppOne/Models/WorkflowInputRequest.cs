using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MondayAppOne.Models
{
    public class WorkflowInputRequest
    {
        #region General
        [JsonProperty("in_ParentItemId")]
        public long in_ParentItemId { get; set; }

        [JsonProperty("in_SS")]
        public string in_SS { get; set; }

        [JsonProperty("in_CompletionTriggerUrl")]
        public string in_CompletionTriggerUrl { get; set; }
        #endregion

        #region Sales Order & Expense - Extraction (Document Understanding)
        [JsonProperty("in_FileUrls")]
        public Dictionary<string,string> in_FileUrls { get; set; }

        [JsonProperty("in_SubItemTemplate")]
        public Dictionary<string,string> in_SubItemTemplate { get; set; }
        #endregion

        #region Sales Order -  Posting
        [JsonProperty("in_PostViaBapi")]
        public string in_PostViaBapi { get; set; }

        [JsonProperty("in_System")]
        public string in_System { get; set; }

        [JsonProperty("in_PoNumber")]
        public string in_PoNumber { get; set; }
        #endregion

        #region Storage - Upload
        [JsonProperty("in_File")]
        public string in_File { get; set; }
        #endregion
    }
}
