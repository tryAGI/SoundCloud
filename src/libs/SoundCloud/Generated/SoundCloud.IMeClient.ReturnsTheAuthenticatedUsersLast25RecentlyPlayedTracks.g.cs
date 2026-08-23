#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace SoundCloud
{
    public partial interface IMeClient
    {
        /// <summary>
        /// Returns the authenticated user's last 25 recently played tracks.<br/>
        /// Returns up to 25 full track objects in reverse chronological order. Duplicate tracks are omitted, keeping only the most recent play. Tracks that are not visible to the caller are omitted. This endpoint does not support pagination or a `limit` query parameter.
        /// </summary>
        /// <param name="access">
        /// Default Value: playable,preview,blocked
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>> ReturnsTheAuthenticatedUsersLast25RecentlyPlayedTracksAsync(
            global::System.Collections.Generic.IList<global::SoundCloud.GetMeRecentlyPlayedTracksAcces>? access = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the authenticated user's last 25 recently played tracks.<br/>
        /// Returns up to 25 full track objects in reverse chronological order. Duplicate tracks are omitted, keeping only the most recent play. Tracks that are not visible to the caller are omitted. This endpoint does not support pagination or a `limit` query parameter.
        /// </summary>
        /// <param name="access">
        /// Default Value: playable,preview,blocked
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>>> ReturnsTheAuthenticatedUsersLast25RecentlyPlayedTracksAsResponseAsync(
            global::System.Collections.Generic.IList<global::SoundCloud.GetMeRecentlyPlayedTracksAcces>? access = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}