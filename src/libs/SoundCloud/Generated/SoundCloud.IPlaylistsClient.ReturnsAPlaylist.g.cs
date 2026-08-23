#nullable enable

namespace SoundCloud
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Returns a playlist.
        /// </summary>
        /// <param name="playlistUrn"></param>
        /// <param name="secretToken"></param>
        /// <param name="access">
        /// Default Value: playable,preview
        /// </param>
        /// <param name="showTracks"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Playlist> ReturnsAPlaylistAsync(
            string playlistUrn,
            string? secretToken = default,
            global::System.Collections.Generic.IList<global::SoundCloud.GetPlaylistsAcces2>? access = default,
            bool? showTracks = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a playlist.
        /// </summary>
        /// <param name="playlistUrn"></param>
        /// <param name="secretToken"></param>
        /// <param name="access">
        /// Default Value: playable,preview
        /// </param>
        /// <param name="showTracks"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Playlist>> ReturnsAPlaylistAsResponseAsync(
            string playlistUrn,
            string? secretToken = default,
            global::System.Collections.Generic.IList<global::SoundCloud.GetPlaylistsAcces2>? access = default,
            bool? showTracks = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}