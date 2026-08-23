#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace SoundCloud
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Returns tracks under a playlist.
        /// </summary>
        /// <param name="playlistUrn"></param>
        /// <param name="secretToken"></param>
        /// <param name="access">
        /// Default Value: playable,preview
        /// </param>
        /// <param name="linkedPartitioning"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>> ReturnsTracksUnderAPlaylistAsync(
            string playlistUrn,
            string? secretToken = default,
            global::System.Collections.Generic.IList<global::SoundCloud.GetPlaylistsTracksAcces>? access = default,
            bool? linkedPartitioning = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns tracks under a playlist.
        /// </summary>
        /// <param name="playlistUrn"></param>
        /// <param name="secretToken"></param>
        /// <param name="access">
        /// Default Value: playable,preview
        /// </param>
        /// <param name="linkedPartitioning"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>>> ReturnsTracksUnderAPlaylistAsResponseAsync(
            string playlistUrn,
            string? secretToken = default,
            global::System.Collections.Generic.IList<global::SoundCloud.GetPlaylistsTracksAcces>? access = default,
            bool? linkedPartitioning = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}