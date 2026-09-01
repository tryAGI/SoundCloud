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
        global::System.Threading.Tasks.Task<global::SoundCloud.Track> UpdatesATracksInformationWithRawBodyAsync(
            string trackUrn,

            global::SoundCloud.TrackUpdateFormRequest request,
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
        global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Track>> UpdatesATracksInformationWithRawBodyAsResponseAsync(
            string trackUrn,

            global::SoundCloud.TrackUpdateFormRequest request,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a track's information.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="trackTitle"></param>
        /// <param name="trackPermalink"></param>
        /// <param name="trackSharing">
        /// Default Value: public
        /// </param>
        /// <param name="trackEmbeddableBy">
        /// who can embed this track "all", "me", or "none"
        /// </param>
        /// <param name="trackPurchaseUrl"></param>
        /// <param name="trackDescription"></param>
        /// <param name="trackGenre"></param>
        /// <param name="trackTagList">
        /// The tag_list property contains a list of tags separated by spaces. Multiword tags are quoted in double quotes. We also support machine tags that follow the pattern NAMESPACE:KEY=VALUE. For example: geo:lat=43.555<br/>
        /// camel:size=medium<br/>
        /// "machine:tag=with space"<br/>
        /// Machine tags are not revealed to the user on the track pages.
        /// </param>
        /// <param name="trackLabelName"></param>
        /// <param name="trackRelease"></param>
        /// <param name="trackReleaseDate">
        /// string, formatted as yyyy-mm-dd, representing release date<br/>
        /// Included only in requests
        /// </param>
        /// <param name="trackStreamable">
        /// Default Value: true
        /// </param>
        /// <param name="trackDownloadable">
        /// Default Value: true
        /// </param>
        /// <param name="trackLicense"></param>
        /// <param name="trackCommentable">
        /// Default Value: true
        /// </param>
        /// <param name="trackRevealStats">
        /// When false (quiet mode), play and favorite counts are hidden.
        /// </param>
        /// <param name="trackRevealComments">
        /// When false (quiet mode), comments are hidden.
        /// </param>
        /// <param name="trackIsrc"></param>
        /// <param name="trackArtworkData">
        /// Track artwork in binary format. Only for PRO users. Supported formats are gif, jpeg and png.
        /// </param>
        /// <param name="trackArtworkDataname">
        /// Track artwork in binary format. Only for PRO users. Supported formats are gif, jpeg and png.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::SoundCloud.Track> UpdatesATracksInformationWithRawBodyAsync(
            string trackUrn,
            string? trackTitle = default,
            string? trackPermalink = default,
            global::SoundCloud.TrackUpdateFormRequestTrackSharing? trackSharing = default,
            global::SoundCloud.TrackUpdateFormRequestTrackEmbeddableBy? trackEmbeddableBy = default,
            string? trackPurchaseUrl = default,
            string? trackDescription = default,
            string? trackGenre = default,
            string? trackTagList = default,
            string? trackLabelName = default,
            string? trackRelease = default,
            string? trackReleaseDate = default,
            bool? trackStreamable = default,
            bool? trackDownloadable = default,
            global::SoundCloud.TrackUpdateFormRequestTrackLicense? trackLicense = default,
            bool? trackCommentable = default,
            bool? trackRevealStats = default,
            bool? trackRevealComments = default,
            string? trackIsrc = default,
            byte[]? trackArtworkData = default,
            string? trackArtworkDataname = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}