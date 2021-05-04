using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MondayAppOne.Models;
using MondayAppOne.Services;
using MondayLibs.Models.Monday;
using MondayLibs.Providers;
using MondayLibs.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiceResult;
using Zell.UiPathAutomation.Other.Enums;
using Zell.UiPathAutomation.Other.Models;
using static Zell.UiPathAutomation.Other.Enums.Workflow;
using static Zell.UiPathAutomation.Other.Models.StartJobParamSearch;

namespace MondayAppOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        #region Properties, Fields and Constructor
        static string _host;
        string _accessToken;
        private readonly IMondayDataProvider _mondayDataProvider;
        private readonly IUiPathOrchestratorService _uiPathOrchestratorService;
        private readonly IConfiguration _configuration;
        private readonly IStorageService _storageService;
        private readonly ITokenVerificationService _jwtTokenVerificationService;

        public MainController(IMondayDataProvider mondayDataProvider, IUiPathOrchestratorService uiPathOrchestratorService, 
                                IConfiguration configuration, IStorageService storageService, ITokenVerificationService jwtTokenVerificationService)
        {
            _mondayDataProvider = mondayDataProvider;
            _uiPathOrchestratorService = uiPathOrchestratorService;
            _configuration = configuration;
            _storageService = storageService;
            _jwtTokenVerificationService = jwtTokenVerificationService;

            _host = _configuration["App:Host"];
            _accessToken = _configuration["MondayAPI:AccessToken"];
        }
        #endregion

        #region Monday Integration Recipe -> UiPath Workflows
        [HttpPost("[action]")]
        public async Task<IActionResult> ExtractDocument([FromBody] MondayApiRequest value, [FromQuery] ExecutionType executionType, [FromQuery] StartJobParamSearch jobParam)
        {
            var headerToken = Request.Headers["Authorization"];
            //JwtPayload JwtPayload = Redirect($"api/auth/PerformVerification?token={headerToken}");
            // Verify JWT token (contains a default redirect URI)
            var jwtPayloadStr = _jwtTokenVerificationService.Verify(headerToken, _configuration["MondayAPI:SS"]);
            if (jwtPayloadStr.Contains("invalid") || jwtPayloadStr.Contains("expired"))
                return Unauthorized();
            var jwtPayload = JsonConvert.DeserializeObject<JwtPayload>(jwtPayloadStr);
            _accessToken = jwtPayload.shortLivedToken ?? _configuration["MondayAPI:AccessToken"];

            WorkflowInputRequest wfInputReq = new WorkflowInputRequest();
            InboundFieldValues inboundValues = value.Payload.InboundFieldValues;

            // Mark as processing
            var item = await _mondayDataProvider.UpdateItem(_accessToken, inboundValues.BoardId, inboundValues.ItemId, "{  \"name\": \"Extracting Document.. Please wait...\"}".Replace("\"", "\\\""));

            // Initialize workflow input values
            wfInputReq.in_ParentItemId = inboundValues.ItemId;
            wfInputReq.in_SS = _configuration["MondayAPI:SS"];
            // Get webhook url based on the subscribed boards to trigger monday update after extract completion
            string boardId = inboundValues.BoardId.ToString();
            var subsPayload = await _storageService.GetAsync(boardId);
            wfInputReq.in_CompletionTriggerUrl = subsPayload?.Data?.WebhookUrl;

            // Get input file/s
            Result<Item[]> items = await _mondayDataProvider.GetItemsDetails(_accessToken, wfInputReq.in_ParentItemId.ToString());
            Item currentItem = items?.Data.FirstOrDefault();
            JArray filesJArray = JArray.Parse(JObject.Parse(currentItem.ColumnValues.Where(c => c.Id == inboundValues.FileColumnId)
                ?.Single()?.Value)["files"].ToString());
            var fileAssetIds = filesJArray.Select(f => f["assetId"].ToString()).ToList();
            wfInputReq.in_FileUrls = fileAssetIds.Select(f => _mondayDataProvider.GetAssetDetails(_accessToken, f))
                                        .ToDictionary(a => a.Result?.Data.FirstOrDefault().Name, a => a.Result?.Data.FirstOrDefault().PublicUrl);
            if (wfInputReq.in_FileUrls.Count() == 0)
            {
                await _mondayDataProvider.UpdateItem(_accessToken, inboundValues.BoardId, inboundValues.ItemId, "{  \"name\": \"Please attach a file first.\"}".Replace("\"", "\\\""));
                return Ok();
            }

            // Check subitem columns metadata
            Result<Board[]> boards = await _mondayDataProvider.GetBoardDetails(_accessToken);
            var currentBoardName = currentItem.Board.Name;
            Board subItemBoard;
            try { subItemBoard = boards?.Data.Where(b => b.Name.ToUpper() == $"SUBITEMS OF {currentBoardName.ToUpper()}")?.Single(); }
            catch (Exception ex) { subItemBoard = null; }
         
            if (subItemBoard != null)
            {
                var columnList = subItemBoard.Columns;
                var subItemTemplateDict = new Dictionary<string, string>();
                foreach (Column col in columnList)
                {
                    var colObjectStr = JsonConvert.SerializeObject(col);
                    if (col.type == "name")
                        subItemTemplateDict.Add(colObjectStr, $"\\\"{col.id}\\\":\\\"<>\\\"");
                    else
                        subItemTemplateDict.Add(colObjectStr, $"\\\"{col.id}\\\":<>");
                }
                wfInputReq.in_SubItemTemplate = subItemTemplateDict;
            }

            // Prepare inputs and start UiPath job for DU
            string inputArgs = JsonConvert.SerializeObject(wfInputReq);
            jobParam.Process = "Monday";
            jobParam.ProcessExecution = executionType;
            if (jobParam.ProcessExecution == ExecutionType.None)
                await _uiPathOrchestratorService.StartJob(inputArgs, jobParam.Process, jobParam.Folder, jobParam.Machine);
            else
                await _uiPathOrchestratorService.StartJob(inputArgs, jobParam.Process, jobParam.ProcessExecution);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ProcessOrder([FromBody] MondayApiRequest value, [FromQuery] ExecutionType executionType, [FromQuery] StartJobParamSearch jobParam)
        {
            var headerToken = Request.Headers["Authorization"];
            //JwtPayload JwtPayload = Redirect($"api/auth/PerformVerification?token={headerToken}");
            // Verify JWT token (contains a default redirect URI)
            var jwtPayloadStr = _jwtTokenVerificationService.Verify(headerToken, _configuration["MondayAPI:SS"]);
            if (jwtPayloadStr.Contains("invalid") || jwtPayloadStr.Contains("expired"))
                return Unauthorized();
            var jwtPayload = JsonConvert.DeserializeObject<JwtPayload>(jwtPayloadStr);
            _accessToken = jwtPayload.shortLivedToken ?? _configuration["MondayAPI:AccessToken"];

            WorkflowInputRequest wfInputReq = new WorkflowInputRequest();
            InboundFieldValues inboundValues = value.Payload.InboundFieldValues;

            // Initialize workflow input values
            wfInputReq.in_ParentItemId = inboundValues.ItemId;
            wfInputReq.in_SS = _configuration["MondayAPI:SS"];
            // Get webhook url based on the subscribed boards to trigger monday update after extract completion
            string boardId = inboundValues.BoardId.ToString();
            var subsPayload = await _storageService.GetAsync(boardId);
            wfInputReq.in_CompletionTriggerUrl = subsPayload?.Data?.WebhookUrl;

            // Get inputs
            Result<Item[]> items = await _mondayDataProvider.GetItemsDetails(_accessToken, wfInputReq.in_ParentItemId.ToString());
            try { wfInputReq.in_PoNumber = items?.Data.FirstOrDefault().ColumnValues.Where(c => c.Id == inboundValues.OrderColumnId)?.Single()?.Text; }
            catch (Exception) { wfInputReq.in_PoNumber = new Random().Next(10000, 99999).ToString(); }
            

            // Prepare inputs and start UiPath job
            string inputArgs = JsonConvert.SerializeObject(wfInputReq);
            jobParam.Process = "Posting";
            jobParam.ProcessExecution = executionType;
            string postToValue = "SAP BAPI";
            try { postToValue = items?.Data.FirstOrDefault().ColumnValues.Where(c => c.Id == inboundValues.PostToColumnId)?.Single()?.Text; }
            catch (Exception) { }
            
            if (jobParam.ProcessExecution == ExecutionType.None)
                await _uiPathOrchestratorService.StartJob(inputArgs, jobParam.Process, jobParam.Folder, jobParam.Machine);
            else if (jobParam.ProcessExecution == ExecutionType.Foreground && postToValue != null)
            {          
                wfInputReq.in_System = postToValue.Contains(Enum.GetName(typeof(Application), Application.SAP)) ? Enum.GetName(typeof(Application), Application.SAP) : "";
                if (wfInputReq.in_System == Application.SAP.ToString())
                    wfInputReq.in_PostViaBapi = postToValue.Contains(Enum.GetName(typeof(SAP_Interaction), SAP_Interaction.BAPI)) ? "Y" : "N";
                inputArgs = JsonConvert.SerializeObject(wfInputReq);
                await _uiPathOrchestratorService.StartJob(inputArgs, jobParam.Process, jobParam.ProcessExecution);
            }
            else
                await _uiPathOrchestratorService.StartJob(inputArgs, jobParam.Process, jobParam.ProcessExecution);

            // In case no document number 
            var templateFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                @$"Workflows\SOPosting\templates\Payload\BodyTemplate_Order.txt");
            var bodyTemplateTrigger = await System.IO.File.ReadAllTextAsync(templateFile);
            bodyTemplateTrigger = bodyTemplateTrigger.Replace("<Document No.>", new Random().Next(10000,99999).ToString()).Replace("<in_ParentItemId>", wfInputReq.in_ParentItemId.ToString());
            Utilities.WebUtility webUtility = new Utilities.WebUtility(wfInputReq.in_CompletionTriggerUrl);
            string response = await webUtility.PostAsync(bodyTemplateTrigger, new Dictionary<string, List<string>>() { { "Authorization", new List<string>() { wfInputReq.in_SS } } });

            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ProcessExpense([FromBody] MondayApiRequest value)
        {
            // For expenses, the desktop automation is already being done from Document Understanding workflow
            return Ok();
        }
        #endregion

        #region Dynamic Mapping (via Custom Entity)
        [HttpPost("Mapping/[action]")]
        public async Task<IActionResult> OrderItem_Map([FromBody] MondayApiRequest request)
        {
            var extractedOrderData = await Task.Run(() => _mondayDataProvider.GetCustomEntityList(new Dictionary<string, string>()
                {
                    { "Customer Name", "text" }, { "Supplier", "text" }, { "Order Number", "text" },
                    { "Order Date", "date" }, { "Terms", "text" }, { "Delivery Date", "date" }, { "Delivery Address", "text" },
                    { "Document Number", "text"}
                })
            );
            
            return Ok(extractedOrderData.Data);
        }

        [HttpPost("Mapping/[action]")]
        public async Task<IActionResult> ExpenseItem_Map([FromBody] MondayApiRequest request)
        {
            var extractedExpenseData = await Task.Run(() => _mondayDataProvider.GetCustomEntityList(new Dictionary<string, string>()
                {
                    { "Name", "text" }, { "Expenses", "text" }, { "Date", "date" }
                })
            );

            return Ok(extractedExpenseData.Data);
        }

        [HttpPost("Mapping/[action]")]
        public async Task<IActionResult> OrderExpensesSubItem_Map([FromBody] MondayApiRequest request)
        {
            var extractedSubItemData = await Task.Run(() => _mondayDataProvider.GetCustomEntityList(new Dictionary<string, string>()
                    {
                        { "SubItem Mapping List (Create SubItem field with 3 numeric columns)", "text"}
                    })
            );

            return Ok(extractedSubItemData.Data);
        }
        #endregion

        #region UiPath Workflows -> Monday API (via Custom Trigger)
        // Custom Trigger - Webhook Subscription - Sample input
        //  {
        //     "payload": {
        //       "subscriptionId": 123, //unique identifier of the specific user subscription    
        //       "inputFields": { ///values of all input fields, which were configured for your custom trigger
        //         "boardId": 118607425 //f.e. boardId
        //       }, 
        //       "webhookUrl": "https://api.monday.com/trigger/123", //callback url, which you should call when recipe action should be triggered
        //       "recipeId": 123456 // unique ID of the recipe in your app. the same same recipe ID will be sent if two different accounts are using the same recipe. 
        //  }
        [HttpPost("Trigger/[action]")]
        public async Task<IActionResult> ExtractComplete_Subscribe([FromBody] MondayApiRequest request)
        {
            // Verify authorization header (token expiry, aud or endpoint must match subscription url)
            // Manage and persist subscription details (e.g. subscriptionId, accountId, userId,webhook url)
            // Webhook url is the one that will be used by the uipath workflow to callback or trigger the custom action of the recipe
            await _storageService.DownloadFromBlobStorage();
            await _storageService.StoreAsync(request.Payload);
            await _storageService.UploadToBlobStorage();
            // Return webhook id, if not supplied this will be the same as subscriptionId
            return Ok();
        }

        //  Custom Trigger - Webhook Unsubscribe - Sample input
        //  {
        //     "payload": {
        //       "webhookId": 111 //the same webhookId, which you responded in your Subscribe endpoint
        //      }
        //  }
        [HttpPost("Trigger/[action]")]
        public async Task<IActionResult> ExtractComplete_Unsubscribe([FromBody] MondayApiRequest request)
        {
            // Remove the subscription from your persistent storage based on the unique webhookId
            await _storageService.DownloadFromBlobStorage();
            await _storageService.RemoveAsync(request.Payload.WebHookId.ToString());
            await _storageService.UploadToBlobStorage();
            return Ok();
        }


        // Gets called when the uipath workflow calls the webhook url of the board that subscribed to the custom trigger
        // > UiPath workflow API call to Monday webhook:
        // Endpoint = webhook url from subscribe body
        // Authorization header = signing secret
        // Body = "trigger": {
        //        "outputFields": { 
        //         "itemId": 841832852, 
        //         "extractedOrderData": {
        //                   "OrderNumber": "po214sdd35"
        //          }
        //          "extractedSubItem": {
        //                   "SubItemMappingList": "[...]"
        //          }
        //   }
        // > Monday webhook API call to this custom action
        // Body = "inboundFieldValues": {
        //           "boardId": 815837180,
        //           "itemId": 841832852,
        //           "itemMapping": {
        //               "order_no_": "po214sdd35",
        //               ...
        //               "name": "New item",
        //               "__groupId__": "topics"
        //            }
        //          "sudoSubItemMapping": {
        //                   ...
        //          }
        [HttpPost("Trigger/[action]")]
        public async Task<IActionResult> ExtractComplete_Action([FromBody] MondayApiRequest request)
        {
            var headerToken = Request.Headers["Authorization"];
            //JwtPayload JwtPayload = Redirect($"api/auth/PerformVerification?token={headerToken}");
            // Verify JWT token (contains a default redirect URI)
            var jwtPayloadStr = _jwtTokenVerificationService.Verify(headerToken, _configuration["MondayAPI:SS"]);
            if (jwtPayloadStr.Contains("invalid") || jwtPayloadStr.Contains("expired"))
                return Unauthorized();
            var jwtPayload = JsonConvert.DeserializeObject<JwtPayload>(jwtPayloadStr);
            _accessToken = jwtPayload.shortLivedToken ?? _configuration["MondayAPI:AccessToken"];

            ///TODO: Identify what instance of the recipe (subscription) you would like triggered on the monday.com side
            var values = request.Payload.InboundFieldValues;

            // UPDATE ITEM -  Perform mutation on monday board (change_multiple_column_values) using the request body 
            string columnValue = JsonConvert.SerializeObject(values.ItemMapping,
                                    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var itemJObject = JsonConvert.DeserializeObject<JObject>(columnValue);
            itemJObject.Property("__groupId__").Remove();
            try
            {
                if (String.IsNullOrEmpty(itemJObject["name"].ToString()))
                    itemJObject["name"] = "Extraction Complete. Customer Name is missing or not mapped.";
            }
            catch (Exception ex) { }
            columnValue = itemJObject.ToString().Replace("\"", "\\\"");
            var item = await _mondayDataProvider.UpdateItem(_accessToken, values.BoardId,
                                                            values.ItemId, columnValue);
            

            // CREATE SUBITEM -  Perform mutation on monday board (create_subitem) using the request body
            columnValue = JsonConvert.SerializeObject(values.SudoSubitemMapping,
                                    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            itemJObject = JsonConvert.DeserializeObject<JObject>(columnValue);
            itemJObject.Property("name").Remove();
            itemJObject.Property("__groupId__").Remove();
            columnValue = itemJObject.PropertyValues().FirstOrDefault().ToString().Replace(",,",",").Replace(",,", ",");
            var subItemJArray = JsonConvert.DeserializeObject<JArray>(columnValue);

            ///TODO: Implement using Parallel for each
            foreach (JObject subItem in subItemJArray)
            {
                try
                {
                    var subItemName = subItem["name"].ToString();
                    subItem.Property("name").Remove();
                    columnValue = subItem.ToString().Replace("\"", "\\\"");
                    await _mondayDataProvider.CreateSubItem(_accessToken, values.ItemId, subItemName, columnValue);
                }
                catch (Exception)
                {} 
            }

            return Ok("Completed Monday updates for " + values.ItemId);
        }
        #endregion
    }
}
