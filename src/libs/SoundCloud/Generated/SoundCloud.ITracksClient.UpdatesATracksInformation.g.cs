#nullable enable

namespace SoundCloud
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Updates a track's information.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Track> UpdatesATracksInformationAsync(
            string trackUrn,

            global::SoundCloud.TrackMetadataRequest request,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a track's information.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Track>> UpdatesATracksInformationAsResponseAsync(
            string trackUrn,

            global::SoundCloud.TrackMetadataRequest request,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a track's information.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="track"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Track> UpdatesATracksInformationAsync(
            string trackUrn,
            global::SoundCloud.TrackMetadataRequestTrack? track = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}