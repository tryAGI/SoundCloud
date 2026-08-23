#nullable enable

namespace SoundCloud
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Returns list of user's links added to their profile (website, facebook, instagram).
        /// </summary>
        /// <param name="userUrn"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::SoundCloud.WebProfile>> ReturnsListOfUsersLinksAddedToTheirProfileWebsite_Facebook_InstagramAsync(
            string userUrn,
            int? limit = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns list of user's links added to their profile (website, facebook, instagram).
        /// </summary>
        /// <param name="userUrn"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::SoundCloud.WebProfile>>> ReturnsListOfUsersLinksAddedToTheirProfileWebsite_Facebook_InstagramAsResponseAsync(
            string userUrn,
            int? limit = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}