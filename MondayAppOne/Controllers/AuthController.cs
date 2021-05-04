using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MondayAppOne.Services;
using MondayLibs.Models.Monday;
using Newtonsoft.Json;

namespace MondayAppOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ITokenVerificationService _jwtTokenVerificationService;
        private readonly IConfiguration _configuration;

        public AuthController(ITokenVerificationService jwtTokenVerificationService, IConfiguration configuration)
        {
            _jwtTokenVerificationService = jwtTokenVerificationService;
            _configuration = configuration;
        }

        #region Authorization
        [HttpGet("[action]")]
        public async Task<IActionResult> Authorization([FromQuery] string token)
        {
            // Verify JWT token (contains a default redirect URI)
            var jwtPayloadStr = _jwtTokenVerificationService.Verify(token, _configuration["MondayAPI:SS"]);
            if (jwtPayloadStr.Contains("invalid") || jwtPayloadStr.Contains("expired"))
                return Unauthorized();
            var jwtPayload = JsonConvert.DeserializeObject<JwtPayload>(jwtPayloadStr);

            // Check if you already have proper access token for that user
            // For example: const accessToken = await tokenStoreService.getToken(userId, token);
            // If already has token, redirect to Recipe (Set in the Monday App OAuth Configuration)
            // return Redirect(jwtPayload.backToUrl);

            // Else, Monday Authorization Request (OAuth) [https://monday.com/developers/apps/oauth]
            var requestUrl = $"{_configuration["MondayAPI:OAuthRequestUrl"]}?client_id={_configuration["MondayAPI:ClientId"]}&state={token}";
            return Redirect(requestUrl);

            // Any 3rd party OAuth
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Callback([FromQuery] string code, [FromQuery] string state)
        {
            // Verify JWT token (contains a default redirect URI)
            var jwtPayloadStr = _jwtTokenVerificationService.Verify(state, _configuration["MondayAPI:SS"]);
            if (jwtPayloadStr.Contains("invalid") || jwtPayloadStr.Contains("expired"))
                return Unauthorized();
            var jwtPayload = JsonConvert.DeserializeObject<JwtPayload>(jwtPayloadStr);

            // Get access token
            // var token = await monday.oauthToken(code, process.env.CLIENT_ID, process.env.CLIENT_SECRET);
            var request = new Utilities.WebUtility(_configuration["MondayAPI:AccessTokenUrl"]);
            //string response = await webUtility.PostAsync(bodyTemplateTrigger, new Dictionary<string, List<string>>() { { "Authorization", new List<string>() { wfInputReq.in_SS } } });

            // TODO - Store the token in a secure way in a way you'll can later on find it using the user ID. 
            // For example: await tokenStoreService.storeToken(userId, token);

            return Redirect(jwtPayload.backToUrl);
        }
        #endregion

        [HttpGet("[action]")]
        public async Task<IActionResult> PerformVerification([FromQuery] string token)
        {
            // Verify JWT token (contains a default redirect URI)
            var jwtPayloadStr = _jwtTokenVerificationService.Verify(token, _configuration["MondayAPI:SS"]);
            if (jwtPayloadStr.Contains("invalid") || jwtPayloadStr.Contains("expired"))
                return Unauthorized();
            var jwtPayload = JsonConvert.DeserializeObject<JwtPayload>(jwtPayloadStr);
            return Ok(jwtPayload);
        }
    }
}
