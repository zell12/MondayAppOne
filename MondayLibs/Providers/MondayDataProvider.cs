using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using MondayLibs.Models.Monday;
using ServiceResult;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MondayLibs.Providers
{
    public class MondayDataProvider : IMondayDataProvider
    {
        readonly GraphQLHttpClient _client;

        public MondayDataProvider(GraphQLHttpClient client)
        {
            _client = client;
        }

        public async Task<Result<Item[]>> GetItemsDetails(string accessToken, string itemId)
        {
            var itemsResponse = await SendQuery<ItemsResponse>(
                    accessToken,
                    $@"{{items(ids: {itemId}) {{
                                id
                                name
                                board {{ id, name}}
                                column_values {{ id, title, text, value, type }}
                              }}
                            }}"
                );
            return new SuccessResult<Item[]>(itemsResponse.Items);
        }

        public async Task<Result<Board[]>> GetBoardDetails(string accessToken)
        {
            string mutation = @"{boards {
                  id
                  name
                  columns { id, type }
                  items { id, name }
                }}";
            var boardsResponse = await SendQuery<BoardsResponse>(accessToken, mutation);

            return new SuccessResult<Board[]>(boardsResponse.Boards);
        }

        public async Task<Result<Asset[]>> GetAssetDetails(string accessToken, string assetId)
        {
            string mutation = @$"{{ assets (ids: [{assetId}]) {{ name url public_url }} }}";
            var boardsResponse = await SendQuery<AssetsResponse>(accessToken, mutation);

            return new SuccessResult<Asset[]>(boardsResponse.Assets);
        }

        public async Task<Result<Item>> UpdateItem(string accessToken, long boardId, long itemId, string columnValueJsonString)
        {
            string mutation = $@"mutation{{
                  change_multiple_column_values(board_id: {boardId}, item_id: {itemId},
                    column_values: ""{columnValueJsonString}""){{
                        id
                        name   
                   }}
            }}";

            var changedColumnValues = await SendMutation<Item>(accessToken, mutation);
            return new SuccessResult<Item>(changedColumnValues);
        }

        public async Task<Result<Item>> CreateSubItem(string accessToken, long parentItemId, string newSubItemName, string columnValueJsonString)
        {
            string mutation = $@"mutation {{
                                  create_subitem(parent_item_id: {parentItemId}, item_name: ""{newSubItemName}"", column_values: ""{columnValueJsonString}"") 
                                    {{ id, name
                                    column_values {{ id, title, text,value, type }}
                                  }}
                                }}
                                ";
            var subItem = await SendMutation<Item>(accessToken, mutation);
            return new SuccessResult<Item>(subItem);
        }

        public async Task<Result<Item>> CreateItem(string accessToken, string boardId, string groupId, string title)
        {
            var query = $@"mutation {{
                            create_item (
                            board_id: {boardId},
                            group_id: ""{groupId}"",
                            item_name: ""{title}""
                            ) {{ id, name
                            }}
                        }}";
            var response = await SendMutation<Item>(accessToken, query);

            return new SuccessResult<Item>(response);
            //return new UnexpectedResult<Item>();
        }

        private async Task<T> SendQuery<T>(string accessToken, string query)
        {
            if (!_client.HttpClient.DefaultRequestHeaders.Contains("Authorization"))
                _client.HttpClient.DefaultRequestHeaders.Add("Authorization", accessToken);
            var response = await _client.SendQueryAsync<T>(new GraphQLRequest(query));
            return response.Data;
        }

        private async Task<T> SendMutation<T>(string accessToken, string query)
        {
            if (!_client.HttpClient.DefaultRequestHeaders.Contains("Authorization"))
                _client.HttpClient.DefaultRequestHeaders.Add("Authorization", accessToken);
            var response = await _client.SendMutationAsync<T>(new GraphQLRequest(query));
            return response.Data;
        }

        #region Helper Methods
        public Result<List<CustomEntity>> GetCustomEntityList(Dictionary<string, string> dict)
        {
            var customEntityList = new List<CustomEntity>();
            foreach (var item in dict)
            {
                string id = item.Key.Replace(" ", "");
                if (item.Key.Contains("("))
                    id = id.Split("(".ToCharArray())[0];
                customEntityList.Add(
                    new CustomEntity()
                    {
                        id = id,
                        title = item.Key,
                        outboundType = item.Value,
                        inboundTypes = new List<string> { "numeric", "text", "date", "text_array" }
                    }
                );
            }
            return new SuccessResult<List<CustomEntity>>(customEntityList);
        }
        #endregion
    }
}
