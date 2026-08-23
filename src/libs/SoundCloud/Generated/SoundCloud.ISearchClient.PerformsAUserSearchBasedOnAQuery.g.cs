#nullable enable

namespace SoundCloud
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Performs a user search based on a query
        /// </summary>
        /// <param name="q"></param>
        /// <param name="urns"></param>
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
        global::System.Threading.Tasks.Task<global::SoundCloud.Users> PerformsAUserSearchBasedOnAQueryAsync(
            string? q = default,
            string? urns = default,
            int? limit = default,
            int? offset = default,
            bool? linkedPartitioning = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Performs a user search based on a query
        /// </summary>
        /// <param name="q"></param>
        /// <param name="urns"></param>
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
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Users>> PerformsAUserSearchBasedOnAQueryAsResponseAsync(
            string? q = default,
            string? urns = default,
            int? limit = default,
            int? offset = default,
            bool? linkedPartitioning = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}