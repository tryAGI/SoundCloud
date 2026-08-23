#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace SoundCloud
{
    public partial interface IMeClient
    {
        /// <summary>
        /// Returns a list of recent tracks from users followed by the authenticated user.
        /// </summary>
        /// <param name="access">
        /// Default Value: playable,preview
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::SoundCloud.Track>> ReturnsAListOfRecentTracksFromUsersFollowedByTheAuthenticatedUserAsync(
            global::System.Collections.Generic.IList<global::SoundCloud.GetMeFollowingsTracksAcces>? access = default,
            int? limit = default,
            int? offset = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a list of recent tracks from users followed by the authenticated user.
        /// </summary>
        /// <param name="access">
        /// Default Value: playable,preview
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::SoundCloud.Track>>> ReturnsAListOfRecentTracksFromUsersFollowedByTheAuthenticatedUserAsResponseAsync(
            global::System.Collections.Generic.IList<global::SoundCloud.GetMeFollowingsTracksAcces>? access = default,
            int? limit = default,
            int? offset = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}