
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrackDataRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[title]")]
        public string? TrackTitle { get; set; }

        /// <summary>
        /// Optional artist name for the track. Returned as metadata_artist in track responses. Do not use track[metadata_artist] on upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[artist]")]
        public string? TrackArtist { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[asset_data]")]
        public byte[]? TrackAssetData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[asset_data]name")]
        public string? TrackAssetDataname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[permalink]")]
        public string? TrackPermalink { get; set; }

        /// <summary>
        /// Default Value: public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[sharing]")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.TrackDataRequestTrackSharingJsonConverter))]
        public global::SoundCloud.TrackDataRequestTrackSharing? TrackSharing { get; set; }

        /// <summary>
        /// who can embed this track "all", "me", or "none"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[embeddable_by]")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.TrackDataRequestTrackEmbeddableByJsonConverter))]
        public global::SoundCloud.TrackDataRequestTrackEmbeddableBy? TrackEmbeddableBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[purchase_url]")]
        public string? TrackPurchaseUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[description]")]
        public string? TrackDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[genre]")]
        public string? TrackGenre { get; set; }

        /// <summary>
        /// The tag_list property contains a list of tags separated by spaces. Multiword tags are quoted in double quotes. We also support machine tags that follow the pattern NAMESPACE:KEY=VALUE. For example: geo:lat=43.555 camel:size=medium “machine:tag=with space” Machine tags are not revealed to the user on the track pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[tag_list]")]
        public string? TrackTagList { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[label_name]")]
        public string? TrackLabelName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[release]")]
        public string? TrackRelease { get; set; }

        /// <summary>
        /// string, formatted as yyyy-mm-dd, representing release date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[release_date]")]
        public string? TrackReleaseDate { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[streamable]")]
        public bool? TrackStreamable { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[downloadable]")]
        public bool? TrackDownloadable { get; set; }

        /// <summary>
        /// Possible values: no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[license]")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.TrackDataRequestTrackLicenseJsonConverter))]
        public global::SoundCloud.TrackDataRequestTrackLicense? TrackLicense { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[commentable]")]
        public bool? TrackCommentable { get; set; }

        /// <summary>
        /// When false (quiet mode), play and favorite counts are hidden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[reveal_stats]")]
        public bool? TrackRevealStats { get; set; }

        /// <summary>
        /// When false (quiet mode), comments are hidden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[reveal_comments]")]
        public bool? TrackRevealComments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[isrc]")]
        public string? TrackIsrc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[artwork_data]")]
        public byte[]? TrackArtworkData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track[artwork_data]name")]
        public string? TrackArtworkDataname { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackDataRequest" /> class.
        /// </summary>
        /// <param name="trackTitle"></param>
        /// <param name="trackArtist">
        /// Optional artist name for the track. Returned as metadata_artist in track responses. Do not use track[metadata_artist] on upload.
        /// </param>
        /// <param name="trackAssetData"></param>
        /// <param name="trackAssetDataname"></param>
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
        /// The tag_list property contains a list of tags separated by spaces. Multiword tags are quoted in double quotes. We also support machine tags that follow the pattern NAMESPACE:KEY=VALUE. For example: geo:lat=43.555 camel:size=medium “machine:tag=with space” Machine tags are not revealed to the user on the track pages.
        /// </param>
        /// <param name="trackLabelName"></param>
        /// <param name="trackRelease"></param>
        /// <param name="trackReleaseDate">
        /// string, formatted as yyyy-mm-dd, representing release date
        /// </param>
        /// <param name="trackStreamable">
        /// Default Value: true
        /// </param>
        /// <param name="trackDownloadable">
        /// Default Value: true
        /// </param>
        /// <param name="trackLicense">
        /// Possible values: no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
        /// </param>
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
        /// <param name="trackArtworkData"></param>
        /// <param name="trackArtworkDataname"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackDataRequest(
            string? trackTitle,
            string? trackArtist,
            byte[]? trackAssetData,
            string? trackAssetDataname,
            string? trackPermalink,
            global::SoundCloud.TrackDataRequestTrackSharing? trackSharing,
            global::SoundCloud.TrackDataRequestTrackEmbeddableBy? trackEmbeddableBy,
            string? trackPurchaseUrl,
            string? trackDescription,
            string? trackGenre,
            string? trackTagList,
            string? trackLabelName,
            string? trackRelease,
            string? trackReleaseDate,
            bool? trackStreamable,
            bool? trackDownloadable,
            global::SoundCloud.TrackDataRequestTrackLicense? trackLicense,
            bool? trackCommentable,
            bool? trackRevealStats,
            bool? trackRevealComments,
            string? trackIsrc,
            byte[]? trackArtworkData,
            string? trackArtworkDataname)
        {
            this.TrackTitle = trackTitle;
            this.TrackArtist = trackArtist;
            this.TrackAssetData = trackAssetData;
            this.TrackAssetDataname = trackAssetDataname;
            this.TrackPermalink = trackPermalink;
            this.TrackSharing = trackSharing;
            this.TrackEmbeddableBy = trackEmbeddableBy;
            this.TrackPurchaseUrl = trackPurchaseUrl;
            this.TrackDescription = trackDescription;
            this.TrackGenre = trackGenre;
            this.TrackTagList = trackTagList;
            this.TrackLabelName = trackLabelName;
            this.TrackRelease = trackRelease;
            this.TrackReleaseDate = trackReleaseDate;
            this.TrackStreamable = trackStreamable;
            this.TrackDownloadable = trackDownloadable;
            this.TrackLicense = trackLicense;
            this.TrackCommentable = trackCommentable;
            this.TrackRevealStats = trackRevealStats;
            this.TrackRevealComments = trackRevealComments;
            this.TrackIsrc = trackIsrc;
            this.TrackArtworkData = trackArtworkData;
            this.TrackArtworkDataname = trackArtworkDataname;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackDataRequest" /> class.
        /// </summary>
        public TrackDataRequest()
        {
        }

    }
}