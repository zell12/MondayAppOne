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
    /// TestSetExecutions operations.
    /// </summary>
    public partial interface ITestSetExecutions
    {
        /// <summary>
        /// Returns a list of Test Set Executions cross-folder when no current
        /// folder is sent by header.
        /// It will return Test Set Executions from folder where current user
        /// has TestSetExecutionsView.
        /// If there is none, will return forbidden.
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: TestSetExecutions or
        /// TestSetExecutions.Read.
        ///
        /// Required permissions: TestSetExecutions.View.
        ///
        /// Responses:
        /// 200 Returns a list of Test Set Executions filtered with
        /// queryOptions
        /// 403 If the caller doesn't have permissions to view Test Set
        /// Executions
        /// </remarks>
        /// <param name='mandatoryPermissions'>
        /// If in a cross-folder scenario, these represent the additional
        /// permissions
        /// required in the folders the data is retrieved from; all permissions
        /// in this set must be met
        /// </param>
        /// <param name='atLeastOnePermissions'>
        /// If in a cross-folder scenario, these represent the additional
        /// permissions
        /// required in the folders the data is retrieved from; at least one
        /// permission in this set must be met
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
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
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
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfTestSetExecutionDto>> GetWithHttpMessagesAsync(IList<string> mandatoryPermissions = default(IList<string>), IList<string> atLeastOnePermissions = default(IList<string>), string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Return a specific Test Set Execution identified by key
        /// </summary>
        /// <remarks>
        /// Client Credentials Flow required permissions: TestSetExecutions or
        /// TestSetExecutions.Read.
        ///
        /// Required permissions: TestSetExecutions.View.
        ///
        /// Responses:
        /// 200 Return a specific Test Set Execution identified by key
        /// 403 If the caller doesn't have permissions to view Test Set
        /// Executions
        /// 404 It the test set execution is not found
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
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
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
        Task<HttpOperationResponse<TestSetExecutionDto>> GetByIdWithHttpMessagesAsync(long key, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
