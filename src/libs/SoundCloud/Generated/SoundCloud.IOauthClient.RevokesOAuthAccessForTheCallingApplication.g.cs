#nullable enable

namespace SoundCloud
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Revokes OAuth access for the calling application.<br/>
        /// Invalidates access tokens for the client application that issued the current access token.<br/>
        /// Returns 400 if disconnect is not supported for the current token.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task RevokesOAuthAccessForTheCallingApplicationAsync(
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revokes OAuth access for the calling application.<br/>
        /// Invalidates access tokens for the client application that issued the current access token.<br/>
        /// Returns 400 if disconnect is not supported for the current token.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse> RevokesOAuthAccessForTheCallingApplicationAsResponseAsync(
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}