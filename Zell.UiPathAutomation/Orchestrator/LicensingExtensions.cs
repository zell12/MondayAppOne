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
    /// Extension methods for Licensing.
    /// </summary>
    public static partial class LicensingExtensions
    {
            /// <summary>
            /// Acquire license units
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static LicenseResultDto Acquire(this ILicensing operations, ConsumptionLicenseDto body = default(ConsumptionLicenseDto))
            {
                return operations.AcquireAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Acquire license units
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LicenseResultDto> AcquireAsync(this ILicensing operations, ConsumptionLicenseDto body = default(ConsumptionLicenseDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AcquireWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Release acquired license units
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static LicenseResultDto Release(this ILicensing operations, ConsumptionLicenseDto body = default(ConsumptionLicenseDto))
            {
                return operations.ReleaseAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Release acquired license units
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Administration or
            /// Administration.Write.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LicenseResultDto> ReleaseAsync(this ILicensing operations, ConsumptionLicenseDto body = default(ConsumptionLicenseDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ReleaseWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
