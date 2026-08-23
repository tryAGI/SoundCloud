#nullable enable

namespace SoundCloud
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Creates a playlist.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Playlist> CreatesAPlaylistAsync(

            global::SoundCloud.CreateUpdatePlaylistRequest request,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a playlist.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Playlist>> CreatesAPlaylistAsResponseAsync(

            global::SoundCloud.CreateUpdatePlaylistRequest request,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a playlist.
        /// </summary>
        /// <param name="playlist"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Playlist> CreatesAPlaylistAsync(
            global::SoundCloud.CreateUpdatePlaylistRequestPlaylist? playlist = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}