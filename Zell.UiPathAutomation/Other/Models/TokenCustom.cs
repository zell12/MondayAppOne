using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Zell.UiPathAutomation.Orchestrator;

namespace Zell.UiPathAutomation.Other.Models
{
    public class TokenCustom : ITokenCustom
    {
        private readonly IConfiguration Configuration;

        public TokenCustom(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<TokenResponse> GetAccessToken(TokenRequest tokenRequest, Dictionary<string, List<string>> headers)
        {
            string tokenRequestUrl = Configuration["OrchestratorAPI:TokenUrl"];
            Utilities.WebUtility webUtility = new Utilities.WebUtility(tokenRequestUrl);
            var body = JsonConvert.SerializeObject(tokenRequest);
            string response = await webUtility.PostAsync(body, headers);
            TokenResponse tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(response);
            return tokenResponse;
        }
    }
}
