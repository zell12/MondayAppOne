// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zell.UiPathAutomation.Orchestrator
{
    using Models;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HostLicenses.
    /// </summary>
    public static partial class HostLicensesExtensions
    {
            /// <summary>
            /// Gets host licenses.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Read.
            ///
            /// Host only. Requires authentication.
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
            public static ODataValueOfIEnumerableOfHostLicenseDto Get(this IHostLicenses operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets host licenses.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Read.
            ///
            /// Host only. Requires authentication.
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
            public static async Task<ODataValueOfIEnumerableOfHostLicenseDto> GetAsync(this IHostLicenses operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single host license based on its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Read.
            ///
            /// Host only. Requires authentication.
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
            public static HostLicenseDto GetById(this IHostLicenses operations, long key, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(key, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single host license based on its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Read.
            ///
            /// Host only. Requires authentication.
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
            public static async Task<HostLicenseDto> GetByIdAsync(this IHostLicenses operations, long key, string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(key, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a host license based on its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            public static void DeleteById(this IHostLicenses operations, long key)
            {
                operations.DeleteByIdAsync(key).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a host license based on its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IHostLicenses operations, long key, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(key, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Uploads a new offline license activation.
            /// The content of the license is sent as a file embedded in the HTTP request.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='file'>
            /// </param>
            public static void ActivateLicenseOffline(this IHostLicenses operations, Stream file)
            {
                operations.ActivateLicenseOfflineAsync(file).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Uploads a new offline license activation.
            /// The content of the license is sent as a file embedded in the HTTP request.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='file'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ActivateLicenseOfflineAsync(this IHostLicenses operations, Stream file, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ActivateLicenseOfflineWithHttpMessagesAsync(file, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Activate the license for the host
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void ActivateLicenseOnline(this IHostLicenses operations, HostLicensesActivateLicenseOnlineParameters body = default(HostLicensesActivateLicenseOnlineParameters))
            {
                operations.ActivateLicenseOnlineAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Activate the license for the host
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ActivateLicenseOnlineAsync(this IHostLicenses operations, HostLicensesActivateLicenseOnlineParameters body = default(HostLicensesActivateLicenseOnlineParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ActivateLicenseOnlineWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deactivate the license for the host
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void DeactivateLicenseOnline(this IHostLicenses operations, object body = default(object))
            {
                operations.DeactivateLicenseOnlineAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deactivate the license for the host
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeactivateLicenseOnlineAsync(this IHostLicenses operations, object body = default(object), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeactivateLicenseOnlineWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes a tenant license based on its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void DeleteTenantLicense(this IHostLicenses operations, HostLicensesDeleteTenantLicenseParameters body = default(HostLicensesDeleteTenantLicenseParameters))
            {
                operations.DeleteTenantLicenseAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a tenant license based on its key.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteTenantLicenseAsync(this IHostLicenses operations, HostLicensesDeleteTenantLicenseParameters body = default(HostLicensesDeleteTenantLicenseParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteTenantLicenseWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deactivate the license offline for the host
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            public static ODataValueOfString GetDeactivateLicenseOffline(this IHostLicenses operations, object body = default(object), string expand = default(string), string select = default(string))
            {
                return operations.GetDeactivateLicenseOfflineAsync(body, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deactivate the license offline for the host
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
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
            public static async Task<ODataValueOfString> GetDeactivateLicenseOfflineAsync(this IHostLicenses operations, object body = default(object), string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDeactivateLicenseOfflineWithHttpMessagesAsync(body, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create the offline activation request for the host
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            public static ODataValueOfString GetLicenseOffline(this IHostLicenses operations, HostLicensesGetLicenseOfflineParameters body = default(HostLicensesGetLicenseOfflineParameters), string expand = default(string), string select = default(string))
            {
                return operations.GetLicenseOfflineAsync(body, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create the offline activation request for the host
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
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
            public static async Task<ODataValueOfString> GetLicenseOfflineAsync(this IHostLicenses operations, HostLicensesGetLicenseOfflineParameters body = default(HostLicensesGetLicenseOfflineParameters), string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLicenseOfflineWithHttpMessagesAsync(body, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single tenant license based on its id.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Read.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantId'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            public static LicenseDto GetTenantLicenseByTenantid(this IHostLicenses operations, int tenantId, string expand = default(string), string select = default(string))
            {
                return operations.GetTenantLicenseByTenantidAsync(tenantId, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single tenant license based on its id.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Read.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='tenantId'>
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
            public static async Task<LicenseDto> GetTenantLicenseByTenantidAsync(this IHostLicenses operations, int tenantId, string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTenantLicenseByTenantidWithHttpMessagesAsync(tenantId, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets the license for a specific tenant
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void SetTenantLicense(this IHostLicenses operations, HostLicensesSetTenantLicenseParameters body = default(HostLicensesSetTenantLicenseParameters))
            {
                operations.SetTenantLicenseAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the license for a specific tenant
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SetTenantLicenseAsync(this IHostLicenses operations, HostLicensesSetTenantLicenseParameters body = default(HostLicensesSetTenantLicenseParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SetTenantLicenseWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update the license for the host
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void UpdateLicenseOnline(this IHostLicenses operations)
            {
                operations.UpdateLicenseOnlineAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the license for the host
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateLicenseOnlineAsync(this IHostLicenses operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateLicenseOnlineWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Uploads a new host license file that was previously generated with Regutil.
            /// The content of the license is sent as a file embedded in the HTTP request.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='file'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            public static HostLicenseDto UploadLicense(this IHostLicenses operations, Stream file, string expand = default(string), string select = default(string))
            {
                return operations.UploadLicenseAsync(file, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Uploads a new host license file that was previously generated with Regutil.
            /// The content of the license is sent as a file embedded in the HTTP request.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Host only. Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='file'>
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
            public static async Task<HostLicenseDto> UploadLicenseAsync(this IHostLicenses operations, Stream file, string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UploadLicenseWithHttpMessagesAsync(file, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
