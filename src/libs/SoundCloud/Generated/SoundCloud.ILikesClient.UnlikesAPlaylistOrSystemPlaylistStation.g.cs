#nullable enable

namespace SoundCloud
{
    public partial interface ILikesClient
    {
        /// <summary>
        /// Unlikes a playlist or system playlist (station).
        /// </summary>
        /// <param name="playlistUrn"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task UnlikesAPlaylistOrSystemPlaylistStationAsync(
            string playlistUrn,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unlikes a playlist or system playlist (station).
        /// </summary>
        /// <param name="playlistUrn"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse> UnlikesAPlaylistOrSystemPlaylistStationAsResponseAsync(
            string playlistUrn,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}