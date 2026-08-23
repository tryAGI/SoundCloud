#nullable enable

namespace SoundCloud
{
    public partial interface IMeClient
    {
        /// <summary>
        /// Follows a user.<br/>
        /// Fails with 422 when the user cannot be followed, for example when the authenticated user has reached the maximum number of followings. The response `message` states the reason.
        /// </summary>
        /// <param name="userUrn"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.User> FollowsAUserAsync(
            string userUrn,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Follows a user.<br/>
        /// Fails with 422 when the user cannot be followed, for example when the authenticated user has reached the maximum number of followings. The response `message` states the reason.
        /// </summary>
        /// <param name="userUrn"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.User>> FollowsAUserAsResponseAsync(
            string userUrn,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}