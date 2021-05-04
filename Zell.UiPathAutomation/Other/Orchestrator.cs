using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Utilities;
using Zell.UiPathAutomation.Other.Models;
using static Zell.UiPathAutomation.Other.Models.Job;

namespace Zell.UiPathAutomation.Other
{
    public class Orchestrator
    {
        const string AuthenticationEndpoint = "https://platform.uipath.com/api/account/authenticate";
        const string ProcessReleaseEndpoint = "https://platform.uipath.com/odata/Releases";
        const string RobotEndpoint = "https://platform.uipath.com/odata/Robots";
        const string StartJobEndpoint = "https://platform.uipath.com/odata/Jobs/UiPath.Server.Configuration.OData.StartJobs";
        const string AssetsEndpoint = "https://platform.uipath.com/odata/Assets";
        const string JobsEndpoint = "https://platform.uipath.com/odata/Jobs";
        Dictionary<string, string> _headerList;

        string _workflowName;
        string _envName;
        string _machineName;
        string _authToken;

        public Orchestrator(string workflowName, string envName, string machineName)
        {
            _workflowName = workflowName;
            _envName = envName;
            _machineName = machineName;
            _headerList = new Dictionary<string, string>
            {
                { "contentType", "application/json"}
            };
        }

        public async Task Authenticate()
        {
            Utilities.WebUtility uipathApiAuthenticate = new Utilities.WebUtility(AuthenticationEndpoint);
            string responseString = await uipathApiAuthenticate.PostAsync("{\"tenancyName\" : \"robo-zell\",\"usernameOrEmailAddress\" : \"admin\",\"password\" : \"uip@thr0b0t\"}", _headerList);
            JObject responseJson = JObject.Parse(responseString);
            _authToken = responseJson["result"].ToString();
        }

        /// <summary>
        /// Job execution related methods
        /// </summary>
        private async Task<ProcessRelease> GetProcessRelease()
        {
            ProcessRelease processRelease = new ProcessRelease(_workflowName, _envName);
            string getEndpoint = $"{ProcessReleaseEndpoint}?$filter=Name eq '{processRelease.Name}'";
            Utilities.WebUtility uipathApiProcRelease = new Utilities.WebUtility(getEndpoint);
            string jsonStringResponse = await uipathApiProcRelease.GetAsync("application/json", _authToken);
            processRelease.Key = JsonProcessing.ExtractFromODataJsonByKey(jsonStringResponse, "Key");
            return processRelease;
        }

        private async Task<Robot> GetRobot()
        {
            Robot robot = new Robot(_machineName);
            string getEndpoint = $"{RobotEndpoint}?$filter=MachineName eq '{robot.MachineName}'";
            Utilities.WebUtility uipathApiRobot = new Utilities.WebUtility(getEndpoint);
            string jsonStringResponse = await uipathApiRobot.GetAsync("application/json", _authToken);
            robot.Id = JsonProcessing.ExtractFromODataJsonByKey(jsonStringResponse, "Id");
            return robot;
        }

        public async Task<string> StartJob()
        {
            ProcessRelease release = await GetProcessRelease();
            Robot robot = await GetRobot();
            Utilities.WebUtility uipathApiStartJob = new Utilities.WebUtility(StartJobEndpoint);
            string jobJsonBody = "{\"startInfo\": {\"ReleaseKey\": \""+ release.Key + "\",\"Strategy\": \"Specific\",\"RobotIds\": ["+ robot.Id +"],\"NoOfRobots\": 0}}";
            string jobResponse = await uipathApiStartJob.PostAsync(jobJsonBody, _headerList, _authToken);
            return jobResponse;
        }

        public async Task<Status> GetJobStatusById(string jobId)
        {
            string getEndpoint = $"{JobsEndpoint}({jobId})";
            Utilities.WebUtility uipathApiJob = new Utilities.WebUtility(getEndpoint);
            string jsonStringResponse = await uipathApiJob.GetAsync("application/json", _authToken);
            string statusString = JObject.Parse(jsonStringResponse)?["State"]?.ToString();
            switch (statusString)
            {
                case "Pending":
                    return Status.Pending;
                case "Running":
                    return Status.Running;
                case "Successful":
                    return Status.Successful;
                case "Faulted":
                    return Status.Faulted;
                case "Stopping":
                    return Status.Stopping;
                case "Terminating":
                    return Status.Terminating;
                case "Stopped":
                    return Status.Stopped;
                default:
                    return Status.Pending;
            }
        }

        public async Task<bool> IsRobotBusy()
        {
            string getEndpoint = $"{JobsEndpoint}?$filter=Robot/MachineName eq '{_machineName}' and (State eq 'Running' or State eq 'Pending')";
            Utilities.WebUtility uipathApiRobot = new Utilities.WebUtility(getEndpoint);
            string jsonStringResponse = await uipathApiRobot.GetAsync("application/json", _authToken);
            string statusString = JObject.Parse(jsonStringResponse)?["@odata.count"]?.ToString();
            int numPendingJobs;
            if (int.TryParse(statusString, out numPendingJobs))
                if (numPendingJobs > 0)
                    return true;
            return false;
        }

        /// <summary>
        /// Asset (process variables) related methods
        /// </summary>
        public async Task<Asset> GetAsset(string variableName)
        {
            Asset asset = new Asset(_workflowName, variableName);
            string getEndpoint = $"{AssetsEndpoint}?$filter=Name eq '{asset.Name}'";
            Utilities.WebUtility uipathApiAsset = new Utilities.WebUtility(getEndpoint);
            string jsonStringResponse = await uipathApiAsset.GetAsync("application/json", _authToken);
            try
            {
                asset.JsonData = JObject.Parse(jsonStringResponse)?["value"]?[0]?.ToString();
                asset.Id = JsonProcessing.ExtractFromODataJsonByKey(jsonStringResponse, "Id");
                return asset;
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                // Asset not existing
                return null;
            }
        }

        public async Task<Asset> CreateAndGetTextAsset(string variableName)
        {
            string endpoint = $"{AssetsEndpoint}";
            Utilities.WebUtility uipathApiAsset = new Utilities.WebUtility(endpoint);
            Asset existingAsset = await GetAsset(variableName);
            if (existingAsset != null)
            {
                // Asset already exists
                return existingAsset;
            }
            string jsonPayloadString = Properties.Resources.ResourceManager.GetString("TextAssetTemplate");
            string jsonStringResponse = await uipathApiAsset.PostAsync(jsonPayloadString, _headerList, _authToken);
            // Asset created successfully
            return await GetAsset(variableName);
        }

        public async Task<string> EditTextAssetValue(Asset asset, string updatedValueParam)
        {
            string getEndpoint = $"{AssetsEndpoint}({asset.Id})";
            Utilities.WebUtility uipathApiAsset = new Utilities.WebUtility(getEndpoint);
            var jsonPayload = JObject.Parse(asset.JsonData);
            jsonPayload["Value"] = jsonPayload["StringValue"] = updatedValueParam;
            string jsonPayloadString = jsonPayload.ToString();
            string jsonStringResponse = await uipathApiAsset.PutAsync(jsonPayloadString, _headerList, _authToken);
            return jsonStringResponse; 
        }
    }
}