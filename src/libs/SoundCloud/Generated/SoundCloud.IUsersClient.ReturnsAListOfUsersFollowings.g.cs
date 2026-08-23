#nullable enable

namespace SoundCloud
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Returns a list of user’s followings.<br/>
        /// Returns list of users that (user_urn) follows.
        /// </summary>
        /// <param name="userUrn"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Users> ReturnsAListOfUsersFollowingsAsync(
            string userUrn,
            int? limit = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a list of user’s followings.<br/>
        /// Returns list of users that (user_urn) follows.
        /// </summary>
        /// <param name="userUrn"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Users>> ReturnsAListOfUsersFollowingsAsResponseAsync(
            string userUrn,
            int? limit = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}