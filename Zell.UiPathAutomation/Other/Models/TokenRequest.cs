using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zell.UiPathAutomation.Other.Models
{
    public class TokenRequest
    {
        public TokenRequest(string clientId, string userKey, string grantType = "refresh_token")
        {
            GrantType = grantType;
            ClientId = clientId;
            UserKey = userKey;
        }

        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("refresh_token")]
        public string UserKey { get; set; }
    }
}
