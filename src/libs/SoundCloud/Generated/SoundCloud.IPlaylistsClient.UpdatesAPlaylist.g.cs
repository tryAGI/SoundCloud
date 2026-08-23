#nullable enable

namespace SoundCloud
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Updates a playlist.
        /// </summary>
        /// <param name="playlistUrn"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Playlist> UpdatesAPlaylistAsync(
            string playlistUrn,

            global::SoundCloud.CreateUpdatePlaylistRequest request,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a playlist.
        /// </summary>
        /// <param name="playlistUrn"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Playlist>> UpdatesAPlaylistAsResponseAsync(
            string playlistUrn,

            global::SoundCloud.CreateUpdatePlaylistRequest request,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a playlist.
        /// </summary>
        /// <param name="playlistUrn"></param>
        /// <param name="playlist"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Playlist> UpdatesAPlaylistAsync(
            string playlistUrn,
            global::SoundCloud.CreateUpdatePlaylistRequestPlaylist? playlist = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}