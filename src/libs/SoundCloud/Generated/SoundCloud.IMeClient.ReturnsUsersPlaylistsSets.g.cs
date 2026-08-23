#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace SoundCloud
{
    public partial interface IMeClient
    {
        /// <summary>
        /// Returns user’s playlists (sets).<br/>
        /// Returns playlist info, playlist tracks and tracks owner info.
        /// </summary>
        /// <param name="showTracks"></param>
        /// <param name="linkedPartitioning"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>> ReturnsUsersPlaylistsSetsAsync(
            bool? showTracks = default,
            bool? linkedPartitioning = default,
            int? limit = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns user’s playlists (sets).<br/>
        /// Returns playlist info, playlist tracks and tracks owner info.
        /// </summary>
        /// <param name="showTracks"></param>
        /// <param name="linkedPartitioning"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>>> ReturnsUsersPlaylistsSetsAsResponseAsync(
            bool? showTracks = default,
            bool? linkedPartitioning = default,
            int? limit = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}