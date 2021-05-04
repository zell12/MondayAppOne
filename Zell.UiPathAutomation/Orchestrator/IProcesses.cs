// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Processes operations.
    /// </summary>
    public partial interface IProcesses
    {
        /// <summary>
        /// Gets the processes.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Execution or
        /// Execution.Read.
        ///
        /// Required permissions: (Packages.View - Lists packages in a Tenant
        /// Feed) and (FolderPackages.View - Lists packages in a Folder Feed).
        /// </remarks>
        /// <param name='searchTerm'>
        /// </param>
        /// <param name='feedId'>
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='filter'>
        /// Restricts the set of items returned. The maximum number of
        /// expressions is 100.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='orderby'>
        /// Specifies the order in which items are returned. The maximum number
        /// of expressions is 5.
        /// </param>
        /// <param name='top'>
        /// Limits the number of items returned from a collection. The maximum
        /// value is 1000.
        /// </param>
        /// <param name='skip'>
        /// Excludes the specified number of items of the queried collection
        /// from the result.
        /// </param>
        /// <param name='count'>
        /// Indicates whether the total count of items within a collection are
        /// returned in the result.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfProcessDto>> GetWithHttpMessagesAsync(string searchTerm = "", System.Guid? feedId = default(System.Guid?), string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a package.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Execution or
        /// Execution.Write.
        ///
        /// Required permissions: (Packages.Delete - Deletes a package in a
        /// Tenant Feed) and (FolderPackages.Delete - Deletes a package in a
        /// Folder Feed).
        /// </remarks>
        /// <param name='key'>
        /// </param>
        /// <param name='feedId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteByIdWithHttpMessagesAsync(string key, System.Guid? feedId = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Downloads the .nupkg file of a Package.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Execution or
        /// Execution.Read.
        ///
        /// Required permissions: (Packages.View - Downloads a package from a
        /// Tenant Feed) and (FolderPackages.View - Downloads a package from a
        /// Folder Feed).
        /// </remarks>
        /// <param name='key'>
        /// </param>
        /// <param name='feedId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Stream>> DownloadPackageByKeyWithHttpMessagesAsync(string key, System.Guid? feedId = default(System.Guid?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get process parameters
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Execution or
        /// Execution.Read.
        ///
        /// Required permissions: Packages.View.
        /// </remarks>
        /// <param name='key'>
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ArgumentMetadata>> GetArgumentsByKeyWithHttpMessagesAsync(string key, string expand = default(string), string select = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a collection of all available versions of a given process.
        /// Allows odata query options.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Execution or
        /// Execution.Read.
        ///
        /// Required permissions: (Packages.View - Lists versions of a package
        /// in a Tenant Feed) and (FolderPackages.View - Lists versions of a
        /// package in a Folder Feed).
        /// </remarks>
        /// <param name='processId'>
        /// The Id of the process for which the versions are fetched.
        /// </param>
        /// <param name='feedId'>
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='filter'>
        /// Restricts the set of items returned. The maximum number of
        /// expressions is 100.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='orderby'>
        /// Specifies the order in which items are returned. The maximum number
        /// of expressions is 5.
        /// </param>
        /// <param name='top'>
        /// Limits the number of items returned from a collection. The maximum
        /// value is 1000.
        /// </param>
        /// <param name='skip'>
        /// Excludes the specified number of items of the queried collection
        /// from the result.
        /// </param>
        /// <param name='count'>
        /// Indicates whether the total count of items within a collection are
        /// returned in the result.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfProcessDto>> GetProcessVersionsByProcessidWithHttpMessagesAsync(string processId, System.Guid? feedId = default(System.Guid?), string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Saves process arguments
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Execution or
        /// Execution.Write.
        ///
        /// Required permissions: Packages.Edit.
        /// </remarks>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> SetArgumentsWithHttpMessagesAsync(ProcessesSetArgumentsParameters body = default(ProcessesSetArgumentsParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Uploads a new package or a new version of an existing package. The
        /// content of the package is sent as a .nupkg file embedded in the
        /// HTTP request.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Execution or
        /// Execution.Write.
        ///
        /// Required permissions: (Packages.Create - Uploads a package in a
        /// Tenant Feed) and (FolderPackages.Create - Uploads a package in a
        /// Folder Feed).
        /// </remarks>
        /// <param name='file'>
        /// </param>
        /// <param name='feedId'>
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='filter'>
        /// Restricts the set of items returned. The maximum number of
        /// expressions is 100.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='orderby'>
        /// Specifies the order in which items are returned. The maximum number
        /// of expressions is 5.
        /// </param>
        /// <param name='count'>
        /// Indicates whether the total count of items within a collection are
        /// returned in the result.
        /// </param>
        /// <param name='file1'>
        /// </param>
        /// <param name='file2'>
        /// </param>
        /// <param name='file3'>
        /// </param>
        /// <param name='file4'>
        /// </param>
        /// <param name='file5'>
        /// </param>
        /// <param name='file6'>
        /// </param>
        /// <param name='file7'>
        /// </param>
        /// <param name='file8'>
        /// </param>
        /// <param name='file9'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfBulkItemDtoOfString>> UploadPackageWithHttpMessagesAsync(Stream file, System.Guid? feedId = default(System.Guid?), string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), Stream file1 = default(Stream), Stream file2 = default(Stream), Stream file3 = default(Stream), Stream file4 = default(Stream), Stream file5 = default(Stream), Stream file6 = default(Stream), Stream file7 = default(Stream), Stream file8 = default(Stream), Stream file9 = default(Stream), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
