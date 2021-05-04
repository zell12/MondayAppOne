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
    /// Extension methods for Environments.
    /// </summary>
    public static partial class EnvironmentsExtensions
    {
            /// <summary>
            /// Gets Environments.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Read.
            ///
            /// Required permissions: Environments.View.
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
            public static ODataValueOfIEnumerableOfEnvironmentDto Get(this IEnvironments operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetAsync(expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets Environments.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Read.
            ///
            /// Required permissions: Environments.View.
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
            public static async Task<ODataValueOfIEnumerableOfEnvironmentDto> GetAsync(this IEnvironments operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Post new environment
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Write.
            ///
            /// Required permissions: Environments.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static EnvironmentDto Post(this IEnvironments operations, EnvironmentDto body = default(EnvironmentDto), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.PostAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post new environment
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Write.
            ///
            /// Required permissions: Environments.Create.
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
            public static async Task<EnvironmentDto> PostAsync(this IEnvironments operations, EnvironmentDto body = default(EnvironmentDto), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single environment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Read.
            ///
            /// Required permissions: Environments.View.
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
            public static EnvironmentDto GetById(this IEnvironments operations, long key, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetByIdAsync(key, expand, select, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single environment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Read.
            ///
            /// Required permissions: Environments.View.
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
            public static async Task<EnvironmentDto> GetByIdAsync(this IEnvironments operations, long key, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(key, expand, select, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an environment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Write.
            ///
            /// Required permissions: Environments.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void PutById(this IEnvironments operations, long key, EnvironmentDto body = default(EnvironmentDto), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.PutByIdAsync(key, body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an environment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Write.
            ///
            /// Required permissions: Environments.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutByIdAsync(this IEnvironments operations, long key, EnvironmentDto body = default(EnvironmentDto), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutByIdWithHttpMessagesAsync(key, body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes an environment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Write.
            ///
            /// Required permissions: Environments.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void DeleteById(this IEnvironments operations, long key, long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.DeleteByIdAsync(key, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an environment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Write.
            ///
            /// Required permissions: Environments.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IEnvironments operations, long key, long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(key, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Associates a robot with the given environment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Write.
            ///
            /// Required permissions: Environments.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The associated Environment Id.
            /// </param>
            /// <param name='body'>
            /// RobotId - The associated robot Id.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void AddRobotById(this IEnvironments operations, long key, EnvironmentsAddRobotParameters body = default(EnvironmentsAddRobotParameters), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.AddRobotByIdAsync(key, body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Associates a robot with the given environment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Write.
            ///
            /// Required permissions: Environments.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The associated Environment Id.
            /// </param>
            /// <param name='body'>
            /// RobotId - The associated robot Id.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task AddRobotByIdAsync(this IEnvironments operations, long key, EnvironmentsAddRobotParameters body = default(EnvironmentsAddRobotParameters), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.AddRobotByIdWithHttpMessagesAsync(key, body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Dissociates a robot from the given environment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Write.
            ///
            /// Required permissions: Environments.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// Given environment's Id.
            /// </param>
            /// <param name='body'>
            /// RobotId - The dissociated robot Id.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void RemoveRobotById(this IEnvironments operations, long key, EnvironmentsRemoveRobotParameters body = default(EnvironmentsRemoveRobotParameters), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.RemoveRobotByIdAsync(key, body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Dissociates a robot from the given environment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Write.
            ///
            /// Required permissions: Environments.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// Given environment's Id.
            /// </param>
            /// <param name='body'>
            /// RobotId - The dissociated robot Id.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RemoveRobotByIdAsync(this IEnvironments operations, long key, EnvironmentsRemoveRobotParameters body = default(EnvironmentsRemoveRobotParameters), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RemoveRobotByIdWithHttpMessagesAsync(key, body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Associates a group of robots with and dissociates another group of robots
            /// from the given environment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Write.
            ///
            /// Required permissions: Environments.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The environment id.
            /// </param>
            /// <param name='body'>
            /// &lt;para /&gt;addedRobotIds - The id of the robots to be associated with
            /// the environment.
            /// &lt;para /&gt;removedRobotIds - The id of the robots to be dissociated from
            /// the environment.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void SetRobotsById(this IEnvironments operations, long key, EnvironmentsSetRobotsParameters body = default(EnvironmentsSetRobotsParameters), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.SetRobotsByIdAsync(key, body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Associates a group of robots with and dissociates another group of robots
            /// from the given environment.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Write.
            ///
            /// Required permissions: Environments.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The environment id.
            /// </param>
            /// <param name='body'>
            /// &lt;para /&gt;addedRobotIds - The id of the robots to be associated with
            /// the environment.
            /// &lt;para /&gt;removedRobotIds - The id of the robots to be dissociated from
            /// the environment.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SetRobotsByIdAsync(this IEnvironments operations, long key, EnvironmentsSetRobotsParameters body = default(EnvironmentsSetRobotsParameters), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SetRobotsByIdWithHttpMessagesAsync(key, body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a collection of all the ids of the robots associated to an
            /// environment based on environment Id.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Read.
            ///
            /// Required permissions: Environments.View and Robots.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The Id of the environment for which the robot ids are fetched.
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
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static ODataValueOfIEnumerableOfInt64 GetRobotIdsForEnvironmentByKey(this IEnvironments operations, long key, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetRobotIdsForEnvironmentByKeyAsync(key, expand, filter, select, orderby, count, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a collection of all the ids of the robots associated to an
            /// environment based on environment Id.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Read.
            ///
            /// Required permissions: Environments.View and Robots.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The Id of the environment for which the robot ids are fetched.
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
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfInt64> GetRobotIdsForEnvironmentByKeyAsync(this IEnvironments operations, long key, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRobotIdsForEnvironmentByKeyWithHttpMessagesAsync(key, expand, filter, select, orderby, count, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a collection of all robots and, if no other sorting is provided,
            /// will place first those belonging to the environment. Allows odata query
            /// options.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Read.
            ///
            /// Required permissions: Environments.View and Robots.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The Id of the environment for which the associated robots are placed first.
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
            public static ODataValueOfIEnumerableOfRobotDto GetRobotsForEnvironmentByKey(this IEnvironments operations, long key, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetRobotsForEnvironmentByKeyAsync(key, expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a collection of all robots and, if no other sorting is provided,
            /// will place first those belonging to the environment. Allows odata query
            /// options.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Robots or Robots.Read.
            ///
            /// Required permissions: Environments.View and Robots.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The Id of the environment for which the associated robots are placed first.
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
            public static async Task<ODataValueOfIEnumerableOfRobotDto> GetRobotsForEnvironmentByKeyAsync(this IEnvironments operations, long key, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRobotsForEnvironmentByKeyWithHttpMessagesAsync(key, expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
