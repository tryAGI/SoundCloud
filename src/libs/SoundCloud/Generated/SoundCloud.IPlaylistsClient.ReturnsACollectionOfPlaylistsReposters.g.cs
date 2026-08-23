#nullable enable

namespace SoundCloud
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Returns a collection of playlist's reposters.
        /// </summary>
        /// <param name="playlistUrn"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Users> ReturnsACollectionOfPlaylistsRepostersAsync(
            string playlistUrn,
            int? limit = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a collection of playlist's reposters.
        /// </summary>
        /// <param name="playlistUrn"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Users>> ReturnsACollectionOfPlaylistsRepostersAsResponseAsync(
            string playlistUrn,
            int? limit = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}