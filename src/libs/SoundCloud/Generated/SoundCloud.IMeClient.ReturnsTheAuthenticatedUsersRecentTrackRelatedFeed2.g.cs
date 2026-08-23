#nullable enable

namespace SoundCloud
{
    public partial interface IMeClient
    {
        /// <summary>
        /// Returns the authenticated user's recent track related feed.
        /// </summary>
        /// <param name="access">
        /// Default Value: playable,preview
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Activities> ReturnsTheAuthenticatedUsersRecentTrackRelatedFeed2Async(
            global::System.Collections.Generic.IList<global::SoundCloud.GetMeFeedTracksAcces>? access = default,
            int? limit = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the authenticated user's recent track related feed.
        /// </summary>
        /// <param name="access">
        /// Default Value: playable,preview
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Activities>> ReturnsTheAuthenticatedUsersRecentTrackRelatedFeed2AsResponseAsync(
            global::System.Collections.Generic.IList<global::SoundCloud.GetMeFeedTracksAcces>? access = default,
            int? limit = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}