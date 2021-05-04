using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MondayLibs.Models.Monday
{
    public partial class MondayApiRequest
    {
        [JsonProperty("payload")]
        public Payload Payload { get; set; }
    }

    public partial class Payload
    {
        #region General
        [JsonProperty("blockKind")]
        public string BlockKind { get; set; }

        [JsonProperty("blockMetadata")]
        public object BlockMetadata { get; set; }

        [JsonProperty("inboundFieldValues")]
        public InboundFieldValues InboundFieldValues { get; set; }

        [JsonProperty("inputFields")]
        public InboundFieldValues InputFields { get; set; }

        [JsonProperty("recipeId")]
        public long RecipeId { get; set; }
        #endregion

        #region Custom Trigger
        [JsonProperty("subscriptionId")]
        public long SubscriptionId { get; set; }

        [JsonProperty("webHookId")]
        public long WebHookId { get; set; }

        [JsonProperty("webhookUrl")]
        public string WebhookUrl { get; set; }
        #endregion
    }

    public partial class InboundFieldValues
    {
        #region General
        [JsonProperty("boardId")]
        public long BoardId { get; set; }

        [JsonProperty("itemId")]
        public long ItemId { get; set; }

        [JsonProperty("itemMapping")]
        public dynamic ItemMapping { get; set; }

        [JsonProperty("sudoSubitemMapping")]
        public dynamic SudoSubitemMapping { get; set; }
        #endregion

        #region Sales Order & Expense - Extraction (Document Understanding)
        [JsonProperty("fileColumnId")]
        public string FileColumnId { get; set; }
        #endregion

        #region Sales Order - Posting
        [JsonProperty("orderColumnId")]
        public string OrderColumnId { get; set; }

        [JsonProperty("postToColumnId")]
        public string PostToColumnId { get; set; }
        #endregion
    }
}
