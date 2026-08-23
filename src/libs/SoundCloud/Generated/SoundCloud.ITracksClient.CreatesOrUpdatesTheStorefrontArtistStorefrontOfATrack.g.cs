#nullable enable

namespace SoundCloud
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Creates or updates the storefront (Artist Storefront) of a track.<br/>
        /// Creates or updates the storefront module shown on the track page. The request replaces<br/>
        /// the whole storefront: optional fields (link_title, description, price) are cleared when<br/>
        /// omitted, so always send every value the storefront should keep. The request fails with<br/>
        /// 403 when the authenticated user does not own the track, and also when the user does not<br/>
        /// hold a creator subscription that includes external purchase options. The storefront<br/>
        /// links to an external page — no payment is processed by SoundCloud.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Storefront> CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsync(
            string trackUrn,

            global::SoundCloud.StorefrontUpdateRequest request,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates or updates the storefront (Artist Storefront) of a track.<br/>
        /// Creates or updates the storefront module shown on the track page. The request replaces<br/>
        /// the whole storefront: optional fields (link_title, description, price) are cleared when<br/>
        /// omitted, so always send every value the storefront should keep. The request fails with<br/>
        /// 403 when the authenticated user does not own the track, and also when the user does not<br/>
        /// hold a creator subscription that includes external purchase options. The storefront<br/>
        /// links to an external page — no payment is processed by SoundCloud.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Storefront>> CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsResponseAsync(
            string trackUrn,

            global::SoundCloud.StorefrontUpdateRequest request,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates or updates the storefront (Artist Storefront) of a track.<br/>
        /// Creates or updates the storefront module shown on the track page. The request replaces<br/>
        /// the whole storefront: optional fields (link_title, description, price) are cleared when<br/>
        /// omitted, so always send every value the storefront should keep. The request fails with<br/>
        /// 403 when the authenticated user does not own the track, and also when the user does not<br/>
        /// hold a creator subscription that includes external purchase options. The storefront<br/>
        /// links to an external page — no payment is processed by SoundCloud.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="title">
        /// Card title shown on the storefront module.<br/>
        /// Example: Download now
        /// </param>
        /// <param name="type">
        /// The type of item offered.
        /// </param>
        /// <param name="link">
        /// External http(s) URL the storefront button opens.<br/>
        /// Example: https://example.com/my-track
        /// </param>
        /// <param name="linkTitle">
        /// Label of the storefront button. Omit to clear.<br/>
        /// Example: Download
        /// </param>
        /// <param name="description">
        /// Description shown on the storefront module. Omit to clear.<br/>
        /// Example: Get the track original files for free.
        /// </param>
        /// <param name="price">
        /// Display-only price text shown next to the item type. No payment is processed by SoundCloud. Omit to clear.<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Storefront> CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsync(
            string trackUrn,
            string title,
            global::SoundCloud.StorefrontUpdateRequestType type,
            string link,
            string? linkTitle = default,
            string? description = default,
            string? price = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}