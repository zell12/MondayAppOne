using Microsoft.Rest;
using MondayAppOne.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Zell.UiPathAutomation.Orchestrator;
using Zell.UiPathAutomation.Orchestrator.Models;
using Zell.UiPathAutomation.Other.Models;
using static Zell.UiPathAutomation.Other.Models.StartJobParamSearch;

namespace MondayAppOne.Services
{
    public class UiPathOrchestratorService : IUiPathOrchestratorService
    {
    
        readonly ITokenCustom _token;
        readonly TokenRequest _tokenRequest;

        Dictionary<string, List<string>> _headers;
        IUiPathWebApi110 _uiPathWebApi110;

        public UiPathOrchestratorService(ITokenCustom token, TokenRequest tokenRequest, Uri baseUri)
        {
            _token = token;
            _tokenRequest = tokenRequest;
            _uiPathWebApi110 = new UiPathWebApi110(new HttpClient(), true);
            _uiPathWebApi110.BaseUri = baseUri;
        }

        public async Task InitializeHeaders()
        {
            _headers = new Dictionary<string, List<string>>();
            TokenResponse tokenResponse = await _token.GetAccessToken(_tokenRequest, _headers);

            // Add token in the header for the Process query
            _headers.Add("Authorization", new List<string> { "Bearer " + tokenResponse.access_token });
        }

        public async Task<HttpOperationResponse<ODataValueOfIEnumerableOfJobDto>> StartJob(string inputArgs, string jobNameSearchTerm, ExecutionType executionType = ExecutionType.Background)
        {
            await InitializeHeaders();
            var jobsStartJobsParameters = new Dictionary<long?, JobsStartJobsParameters>();

            switch (executionType)
            {
                case ExecutionType.Foreground:
                    jobsStartJobsParameters = await BuildStartJobParameters(inputArgs, jobNameSearchTerm, "Personal", "KD2ME87R");
                    break;
                case ExecutionType.Background:
                    jobsStartJobsParameters = await BuildStartJobParameters(inputArgs, jobNameSearchTerm);
                    break;
                default:
                    jobsStartJobsParameters = await BuildStartJobParameters(inputArgs, jobNameSearchTerm);
                    break;
            }

            // Start job
            return await _uiPathWebApi110.Jobs.StartJobsWithHttpMessagesAsync(jobsStartJobsParameters.FirstOrDefault().Value, customHeaders: _headers, xUIPATHOrganizationUnitId: jobsStartJobsParameters.FirstOrDefault().Key);
        }

        public async Task<HttpOperationResponse<ODataValueOfIEnumerableOfJobDto>> StartJob(string inputArgs, string jobNameSearchTerm, string folderNameSearchTerm, string userNameSearchTerm)
        {
            await InitializeHeaders();
            var jobsStartJobsParameters = await BuildStartJobParameters(inputArgs, jobNameSearchTerm, folderNameSearchTerm, userNameSearchTerm);

            // Start job
            return await _uiPathWebApi110.Jobs.StartJobsWithHttpMessagesAsync(jobsStartJobsParameters.FirstOrDefault().Value, customHeaders: _headers, xUIPATHOrganizationUnitId: jobsStartJobsParameters.FirstOrDefault().Key);
        }

        private async Task<Dictionary<long?,JobsStartJobsParameters>> BuildStartJobParameters(string inputArgs, string jobNameSearchTerm = "Monday", string folderNameSearchTerm = "External", string userNameSearchTerm = "DataManager")
        {
            //Get process key
            var release = await _uiPathWebApi110.Releases.GetWithHttpMessagesAsync(filter: $"contains(Name,'{jobNameSearchTerm}') and contains(Description, '{folderNameSearchTerm}')", customHeaders: _headers);
            var releaseKey = release?.Body?.Value?.FirstOrDefault()?.Key;

            // Get organization unit Id
            var folders = await _uiPathWebApi110.Folders.GetWithHttpMessagesAsync(filter: $"Displayname eq '{folderNameSearchTerm}'", customHeaders: _headers);
            var orgUnitId = folders?.Body?.Value?.FirstOrDefault()?.Id;

            // Get robot Id
            //var robots = await _uiPathWebApi110.Robots.GetWithHttpMessagesAsync(filter: $"contains(MachineName,'{userNameSearchTerm}')", customHeaders: _headers, xUIPATHOrganizationUnitId: orgUnitId);
            var robots = await _uiPathWebApi110.Robots.GetRobotsFromFolderWithHttpMessagesAsync(orgUnitId.ToString(), filter: $"contains(Username,'{userNameSearchTerm}')", customHeaders: _headers);
            var robot = robots?.Body?.Value?.FirstOrDefault()?.Id;

            // Start job
            JobsStartJobsParameters jobsStartJobsParameters = new JobsStartJobsParameters(new StartProcessDto(releaseKey, StartProcessDtoStrategy.Specific, robotIds: new[] { robot }, inputArguments: inputArgs));
            return new Dictionary<long?, JobsStartJobsParameters>() { { orgUnitId, jobsStartJobsParameters } };
        }
    }
}
