#nullable enable

namespace SoundCloud
{
    public partial interface ISystemPlaylistsClient
    {
        /// <summary>
        /// Returns a system playlist.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="access">
        /// Default Value: playable,preview
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.SystemPlaylist> ReturnsASystemPlaylistAsync(
            string id,
            global::System.Collections.Generic.IList<global::SoundCloud.GetSystemPlaylistsAcces>? access = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a system playlist.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="access">
        /// Default Value: playable,preview
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.SystemPlaylist>> ReturnsASystemPlaylistAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::SoundCloud.GetSystemPlaylistsAcces>? access = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}