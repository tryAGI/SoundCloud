#nullable enable

namespace SoundCloud
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Starts playback of a preview of the track
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="secretToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task StartsPlaybackOfAPreviewOfTheTrackAsync(
            string trackUrn,
            string? secretToken = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Starts playback of a preview of the track
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="secretToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse> StartsPlaybackOfAPreviewOfTheTrackAsResponseAsync(
            string trackUrn,
            string? secretToken = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}