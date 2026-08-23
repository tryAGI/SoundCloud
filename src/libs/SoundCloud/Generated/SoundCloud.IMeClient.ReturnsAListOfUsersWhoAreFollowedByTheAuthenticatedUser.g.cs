#nullable enable

namespace SoundCloud
{
    public partial interface IMeClient
    {
        /// <summary>
        /// Returns a list of users who are followed by the authenticated user.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Users> ReturnsAListOfUsersWhoAreFollowedByTheAuthenticatedUserAsync(
            int? limit = default,
            int? offset = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a list of users who are followed by the authenticated user.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Users>> ReturnsAListOfUsersWhoAreFollowedByTheAuthenticatedUserAsResponseAsync(
            int? limit = default,
            int? offset = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}