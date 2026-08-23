#nullable enable

namespace SoundCloud
{
    public partial interface IMeClient
    {
        /// <summary>
        /// Deletes a user who is followed by the authenticated user.
        /// </summary>
        /// <param name="userUrn"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletesAUserWhoIsFollowedByTheAuthenticatedUserAsync(
            string userUrn,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a user who is followed by the authenticated user.
        /// </summary>
        /// <param name="userUrn"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse> DeletesAUserWhoIsFollowedByTheAuthenticatedUserAsResponseAsync(
            string userUrn,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}