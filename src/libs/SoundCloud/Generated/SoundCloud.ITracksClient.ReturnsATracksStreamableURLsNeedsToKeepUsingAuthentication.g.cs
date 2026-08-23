#nullable enable

namespace SoundCloud
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Returns a track's streamable URLs (needs to keep using authentication)
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="secretToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Streams> ReturnsATracksStreamableURLsNeedsToKeepUsingAuthenticationAsync(
            string trackUrn,
            string? secretToken = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a track's streamable URLs (needs to keep using authentication)
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="secretToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Streams>> ReturnsATracksStreamableURLsNeedsToKeepUsingAuthenticationAsResponseAsync(
            string trackUrn,
            string? secretToken = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}