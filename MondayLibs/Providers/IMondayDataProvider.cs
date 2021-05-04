using MondayLibs.Models.Monday;
using ServiceResult;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MondayLibs.Providers
{
    public interface IMondayDataProvider
    {
        Task<Result<Item[]>> GetItemsDetails(string accessToken, string itemId);
        Task<Result<Board[]>> GetBoardDetails(string accessToken);
        Task<Result<Asset[]>> GetAssetDetails(string accessToken, string assetId);
        Task<Result<Item>> UpdateItem(string accessToken, long boardId, long itemId, string columnValueJsonString);
        Task<Result<Item>> CreateSubItem(string accessToken, long parentItemId, string newSubItemName, string columnValueJsonString);
        Task<Result<Item>> CreateItem(string accessToken, string boardId, string groupId, string title);
        Result<List<CustomEntity>> GetCustomEntityList(Dictionary<string, string> dict);
    }
}
