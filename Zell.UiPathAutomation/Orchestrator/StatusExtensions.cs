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
    /// Extension methods for Status.
    /// </summary>
    public static partial class StatusExtensions
    {
            /// <summary>
            /// Returns whether the current endpoint should be serving traffic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Get(this IStatus operations)
            {
                operations.GetAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns whether the current endpoint should be serving traffic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetAsync(this IStatus operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Requires authentication.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='url'>
            /// </param>
            public static HostAvailabilityDto VerifyHostAvailibility(this IStatus operations, string url = default(string))
            {
                return operations.VerifyHostAvailibilityAsync(url).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Requires authentication.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='url'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HostAvailabilityDto> VerifyHostAvailibilityAsync(this IStatus operations, string url = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.VerifyHostAvailibilityWithHttpMessagesAsync(url, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
