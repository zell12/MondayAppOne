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
    /// Extension methods for TestDataQueues.
    /// </summary>
    public static partial class TestDataQueuesExtensions
    {
            /// <summary>
            /// Return a list of test data queues
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Read.
            ///
            /// Required permissions: TestDataQueues.View.
            ///
            /// Responses:
            /// 200 Returns a list of test data queues filtered with queryOptions
            /// 403 If the caller doesn't have permissions to view test data queues
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
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static ODataValueOfIEnumerableOfTestDataQueueDto Get(this ITestDataQueues operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetAsync(expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return a list of test data queues
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Read.
            ///
            /// Required permissions: TestDataQueues.View.
            ///
            /// Responses:
            /// 200 Returns a list of test data queues filtered with queryOptions
            /// 403 If the caller doesn't have permissions to view test data queues
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
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfTestDataQueueDto> GetAsync(this ITestDataQueues operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new test data queue
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueues.Create.
            ///
            /// Responses:
            /// 201 Returns the newly created test data queue
            /// 403 If the caller doesn't have permissions to create test data queues
            /// 409 If a queue with the same name already exists
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TestDataQueueDto Post(this ITestDataQueues operations, TestDataQueueDto body = default(TestDataQueueDto), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.PostAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new test data queue
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueues.Create.
            ///
            /// Responses:
            /// 201 Returns the newly created test data queue
            /// 403 If the caller doesn't have permissions to create test data queues
            /// 409 If a queue with the same name already exists
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestDataQueueDto> PostAsync(this ITestDataQueues operations, TestDataQueueDto body = default(TestDataQueueDto), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Return a specific test data queue identified by key
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Read.
            ///
            /// Required permissions: TestDataQueues.View.
            ///
            /// Responses:
            /// 200 Returns a specific test data queue identified by key
            /// 403 If the caller doesn't have permissions to view test data queues
            /// 404 If the test data queue is not found
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
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TestDataQueueDto GetById(this ITestDataQueues operations, long key, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetByIdAsync(key, expand, select, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return a specific test data queue identified by key
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Read.
            ///
            /// Required permissions: TestDataQueues.View.
            ///
            /// Responses:
            /// 200 Returns a specific test data queue identified by key
            /// 403 If the caller doesn't have permissions to view test data queues
            /// 404 If the test data queue is not found
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
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestDataQueueDto> GetByIdAsync(this ITestDataQueues operations, long key, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(key, expand, select, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an existing test data queue
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueues.Edit.
            ///
            /// Responses:
            /// 200 Returns the updated test data queue
            /// 403 If the caller doesn't have permissions to update test data queues
            /// 409 If trying to change the queue name
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// Id of the test data queue to be updated
            /// </param>
            /// <param name='body'>
            /// Update information
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TestDataQueueDto PutById(this ITestDataQueues operations, long key, TestDataQueueDto body = default(TestDataQueueDto), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.PutByIdAsync(key, body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an existing test data queue
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueues.Edit.
            ///
            /// Responses:
            /// 200 Returns the updated test data queue
            /// 403 If the caller doesn't have permissions to update test data queues
            /// 409 If trying to change the queue name
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// Id of the test data queue to be updated
            /// </param>
            /// <param name='body'>
            /// Update information
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestDataQueueDto> PutByIdAsync(this ITestDataQueues operations, long key, TestDataQueueDto body = default(TestDataQueueDto), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutByIdWithHttpMessagesAsync(key, body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an existing test data queue
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueues.Delete.
            ///
            /// Responses:
            /// 204 The test data queue was deleted
            /// 403 If the caller doesn't have permissions to delete test data queues
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// Id of the test data queue to be deleted
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void DeleteById(this ITestDataQueues operations, long key, long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.DeleteByIdAsync(key, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an existing test data queue
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: TestDataQueues or
            /// TestDataQueues.Write.
            ///
            /// Required permissions: TestDataQueues.Delete.
            ///
            /// Responses:
            /// 204 The test data queue was deleted
            /// 403 If the caller doesn't have permissions to delete test data queues
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// Id of the test data queue to be deleted
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this ITestDataQueues operations, long key, long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(key, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
