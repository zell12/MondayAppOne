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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CredentialStores operations.
    /// </summary>
    public partial interface ICredentialStores
    {
        /// <summary>
        /// Gets all Credential Stores.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
        ///
        /// Required permissions: Settings.View or Assets.Create or Assets.Edit
        /// or Assets.View or Robots.Create or Robots.Edit or Robots.View.
        /// </remarks>
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
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfCredentialStoreDto>> GetWithHttpMessagesAsync(string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new Credential Store.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: Settings.Create.
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
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<CredentialStoreDto>> PostWithHttpMessagesAsync(CredentialStoreDto body = default(CredentialStoreDto), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a single Credential Store by its key.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
        ///
        /// Required permissions: Settings.View.
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
        Task<HttpOperationResponse<CredentialStoreDto>> GetByIdWithHttpMessagesAsync(long key, string expand = default(string), string select = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a Credential Store.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: Settings.Edit.
        /// </remarks>
        /// <param name='key'>
        /// </param>
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
        Task<HttpOperationResponse> PutByIdWithHttpMessagesAsync(long key, CredentialStoreDto body = default(CredentialStoreDto), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a Credential Store.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: Settings.Delete.
        /// </remarks>
        /// <param name='key'>
        /// </param>
        /// <param name='forceDelete'>
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
        Task<HttpOperationResponse> DeleteByIdWithHttpMessagesAsync(long key, bool? forceDelete = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sets a credential store as the default for the given credential
        /// type.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Write.
        ///
        /// Required permissions: Settings.Edit.
        /// </remarks>
        /// <param name='key'>
        /// Provides the ID of the credential store to set as default.
        /// </param>
        /// <param name='body'>
        /// Provides the resourceType that indicates
        /// the resource type for which the stores becomes default.
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
        Task<HttpOperationResponse> SetDefaultStoreForResourceTypeByIdWithHttpMessagesAsync(long key, CredentialStoresSetDefaultStoreForResourceTypeParameters body = default(CredentialStoresSetDefaultStoreForResourceTypeParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets available Credential Store types.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
        ///
        /// Required permissions: Settings.View.
        /// </remarks>
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
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfString>> GetAvailableCredentialStoreTypesWithHttpMessagesAsync(string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the default credential store for the given resource type.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
        ///
        /// Required permissions: Settings.View or Assets.Create or Assets.Edit
        /// or Assets.View or Robots.Create or Robots.Edit or Robots.View.
        /// </remarks>
        /// <param name='resourceType'>
        /// Provides the resource type for which to retrieve the default.
        /// Possible values include: 'AssetCredential', 'RobotCredential',
        /// 'BucketCredential', 'Secrets'
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
        Task<HttpOperationResponse<ODataValueOfInt64>> GetDefaultStoreForResourceTypeByResourcetypeWithHttpMessagesAsync(CredentialStoreResourceType resourceType, string expand = default(string), string select = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets available resources robots (and later assets) for a credential
        /// store.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: Settings or
        /// Settings.Read.
        ///
        /// Required permissions: Settings.View.
        /// </remarks>
        /// <param name='key'>
        /// Provides the ID of the credential store for which to retrieve
        /// resources.
        /// </param>
        /// <param name='resourceType'>
        /// Possible values include: 'AssetCredential', 'RobotCredential',
        /// 'BucketCredential', 'Secrets'
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
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfCredentialStoreResourceDto>> GetResourcesForCredentialStoreTypesByKeyAndResourcetypeWithHttpMessagesAsync(long key, CredentialStoreResourceType resourceType, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
