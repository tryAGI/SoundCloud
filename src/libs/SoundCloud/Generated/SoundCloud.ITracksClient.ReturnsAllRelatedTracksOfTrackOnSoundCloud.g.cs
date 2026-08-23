#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace SoundCloud
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Returns all related tracks of track on SoundCloud.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="access">
        /// Default Value: playable,preview
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="linkedPartitioning"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>> ReturnsAllRelatedTracksOfTrackOnSoundCloudAsync(
            string trackUrn,
            global::System.Collections.Generic.IList<global::SoundCloud.GetTracksRelatedAcces>? access = default,
            int? limit = default,
            int? offset = default,
            bool? linkedPartitioning = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns all related tracks of track on SoundCloud.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="access">
        /// Default Value: playable,preview
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="linkedPartitioning"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>>> ReturnsAllRelatedTracksOfTrackOnSoundCloudAsResponseAsync(
            string trackUrn,
            global::System.Collections.Generic.IList<global::SoundCloud.GetTracksRelatedAcces>? access = default,
            int? limit = default,
            int? offset = default,
            bool? linkedPartitioning = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}