#nullable enable

namespace SoundCloud
{
    public partial interface IMiscellaneousClient
    {
        /// <summary>
        /// Resolves soundcloud.com and on.soundcloud.com URLs to Resource URLs to use with the API.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task ResolvesSoundcloudComAndOnSoundcloudComURLsToResourceURLsToUseWithTheApiAsync(
            string url,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolves soundcloud.com and on.soundcloud.com URLs to Resource URLs to use with the API.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse> ResolvesSoundcloudComAndOnSoundcloudComURLsToResourceURLsToUseWithTheApiAsResponseAsync(
            string url,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}