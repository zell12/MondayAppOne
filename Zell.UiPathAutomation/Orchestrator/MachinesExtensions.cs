// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Machines.
    /// </summary>
    public static partial class MachinesExtensions
    {
            /// <summary>
            /// Gets machines.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Read.
            ///
            /// Required permissions: Machines.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='top'>
            /// Limits the number of items returned from a collection. The maximum value is
            /// 1000.
            /// </param>
            /// <param name='skip'>
            /// Excludes the specified number of items of the queried collection from the
            /// result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            public static ODataValueOfIEnumerableOfExtendedMachineDto Get(this IMachines operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets machines.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Read.
            ///
            /// Required permissions: Machines.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='top'>
            /// Limits the number of items returned from a collection. The maximum value is
            /// 1000.
            /// </param>
            /// <param name='skip'>
            /// Excludes the specified number of items of the queried collection from the
            /// result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfExtendedMachineDto> GetAsync(this IMachines operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new machine.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Write.
            ///
            /// Required permissions: Machines.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static MachineDto Post(this IMachines operations, MachineDto body = default(MachineDto))
            {
                return operations.PostAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new machine.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Write.
            ///
            /// Required permissions: Machines.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MachineDto> PostAsync(this IMachines operations, MachineDto body = default(MachineDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single machine based on its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Read.
            ///
            /// Required permissions: Machines.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            public static MachineDto GetById(this IMachines operations, long key, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(key, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single machine based on its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Read.
            ///
            /// Required permissions: Machines.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MachineDto> GetByIdAsync(this IMachines operations, long key, string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(key, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Edits a machine based on its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Write.
            ///
            /// Required permissions: Machines.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static MachineDto PutById(this IMachines operations, long key, MachineDto body = default(MachineDto))
            {
                return operations.PutByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Edits a machine based on its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Write.
            ///
            /// Required permissions: Machines.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MachineDto> PutByIdAsync(this IMachines operations, long key, MachineDto body = default(MachineDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Partially updates a machine.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Write.
            ///
            /// Required permissions: Machines.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void PatchById(this IMachines operations, long key, MachineDto body = default(MachineDto))
            {
                operations.PatchByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Partially updates a machine.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Write.
            ///
            /// Required permissions: Machines.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PatchByIdAsync(this IMachines operations, long key, MachineDto body = default(MachineDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PatchByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes a machine based on its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Write.
            ///
            /// Required permissions: Machines.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            public static void DeleteById(this IMachines operations, long key)
            {
                operations.DeleteByIdAsync(key).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a machine based on its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Write.
            ///
            /// Required permissions: Machines.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IMachines operations, long key, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(key, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes multiple machines based on their keys.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Write.
            ///
            /// Required permissions: Machines.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void DeleteBulk(this IMachines operations, MachineDeleteBulkRequest body = default(MachineDeleteBulkRequest))
            {
                operations.DeleteBulkAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes multiple machines based on their keys.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Write.
            ///
            /// Required permissions: Machines.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteBulkAsync(this IMachines operations, MachineDeleteBulkRequest body = default(MachineDeleteBulkRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteBulkWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets runtimes for the specified folder
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Read.
            ///
            /// Required permissions: Machines.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='folderId'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            public static ODataValueOfIEnumerableOfMachineRuntimeDto GetRuntimesForFolderByFolderid(this IMachines operations, long folderId, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?))
            {
                return operations.GetRuntimesForFolderByFolderidAsync(folderId, expand, filter, select, orderby, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets runtimes for the specified folder
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Machines or Machines.Read.
            ///
            /// Required permissions: Machines.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='folderId'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfMachineRuntimeDto> GetRuntimesForFolderByFolderidAsync(this IMachines operations, long folderId, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRuntimesForFolderByFolderidWithHttpMessagesAsync(folderId, expand, filter, select, orderby, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
