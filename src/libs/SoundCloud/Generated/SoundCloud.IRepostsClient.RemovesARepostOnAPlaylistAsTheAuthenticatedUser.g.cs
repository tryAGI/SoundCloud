#nullable enable

namespace SoundCloud
{
    public partial interface IRepostsClient
    {
        /// <summary>
        /// Removes a repost on a playlist as the authenticated user
        /// </summary>
        /// <param name="playlistUrn"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task RemovesARepostOnAPlaylistAsTheAuthenticatedUserAsync(
            string playlistUrn,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Removes a repost on a playlist as the authenticated user
        /// </summary>
        /// <param name="playlistUrn"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse> RemovesARepostOnAPlaylistAsTheAuthenticatedUserAsResponseAsync(
            string playlistUrn,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}