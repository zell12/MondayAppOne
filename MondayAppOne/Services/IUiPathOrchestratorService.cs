using Microsoft.Rest;
using MondayAppOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zell.UiPathAutomation.Orchestrator.Models;
using static Zell.UiPathAutomation.Other.Models.StartJobParamSearch;

namespace MondayAppOne.Services
{
    public interface IUiPathOrchestratorService
    {
        Task InitializeHeaders();
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfJobDto>> StartJob(string inputArgs, string jobNameSearchTerm, ExecutionType executionType);
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfJobDto>> StartJob(string inputArgs, string jobNameSearchTerm, string folderNameSearchTerm, string userNameSearchTerm);
    }
}
