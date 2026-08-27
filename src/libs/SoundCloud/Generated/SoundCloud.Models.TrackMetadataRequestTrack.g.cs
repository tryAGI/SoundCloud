
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrackMetadataRequestTrack
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink")]
        public string? Permalink { get; set; }

        /// <summary>
        /// Default Value: public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.TrackMetadataRequestTrackSharingJsonConverter))]
        public global::SoundCloud.TrackMetadataRequestTrackSharing? Sharing { get; set; }

        /// <summary>
        /// who can embed this track "all", "me", or "none"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddable_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.TrackMetadataRequestTrackEmbeddableByJsonConverter))]
        public global::SoundCloud.TrackMetadataRequestTrackEmbeddableBy? EmbeddableBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchase_url")]
        public string? PurchaseUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        public string? Genre { get; set; }

        /// <summary>
        /// The tag_list property contains a list of tags separated by spaces. Multiword tags are quoted in double quotes. We also support machine tags that follow the pattern NAMESPACE:KEY=VALUE. For example: geo:lat=43.555 camel:size=medium “machine:tag=with space” Machine tags are not revealed to the user on the track pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_list")]
        public string? TagList { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_name")]
        public string? LabelName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release")]
        public string? Release { get; set; }

        /// <summary>
        /// string, formatted as yyyy-mm-dd, representing release date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date")]
        public string? ReleaseDate { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streamable")]
        public bool? Streamable { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadable")]
        public bool? Downloadable { get; set; }

        /// <summary>
        /// Possible values: no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.TrackMetadataRequestTrackLicenseJsonConverter))]
        public global::SoundCloud.TrackMetadataRequestTrackLicense? License { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commentable")]
        public bool? Commentable { get; set; }

        /// <summary>
        /// When false (quiet mode), play and favorite counts are hidden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reveal_stats")]
        public bool? RevealStats { get; set; }

        /// <summary>
        /// When false (quiet mode), comments are hidden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reveal_comments")]
        public bool? RevealComments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isrc")]
        public string? Isrc { get; set; }

        /// <summary>
        /// Optional artist name, when different from user. Use this field in JSON PUT requests (or track[metadata_artist] in multipart PUT requests); use track[artist] in multipart POST uploads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_artist")]
        public string? MetadataArtist { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackMetadataRequestTrack" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="permalink"></param>
        /// <param name="sharing">
        /// Default Value: public
        /// </param>
        /// <param name="embeddableBy">
        /// who can embed this track "all", "me", or "none"
        /// </param>
        /// <param name="purchaseUrl"></param>
        /// <param name="description"></param>
        /// <param name="genre"></param>
        /// <param name="tagList">
        /// The tag_list property contains a list of tags separated by spaces. Multiword tags are quoted in double quotes. We also support machine tags that follow the pattern NAMESPACE:KEY=VALUE. For example: geo:lat=43.555 camel:size=medium “machine:tag=with space” Machine tags are not revealed to the user on the track pages.
        /// </param>
        /// <param name="labelName"></param>
        /// <param name="release"></param>
        /// <param name="releaseDate">
        /// string, formatted as yyyy-mm-dd, representing release date
        /// </param>
        /// <param name="streamable">
        /// Default Value: true
        /// </param>
        /// <param name="downloadable">
        /// Default Value: true
        /// </param>
        /// <param name="license">
        /// Possible values: no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
        /// </param>
        /// <param name="commentable">
        /// Default Value: true
        /// </param>
        /// <param name="revealStats">
        /// When false (quiet mode), play and favorite counts are hidden.
        /// </param>
        /// <param name="revealComments">
        /// When false (quiet mode), comments are hidden.
        /// </param>
        /// <param name="isrc"></param>
        /// <param name="metadataArtist">
        /// Optional artist name, when different from user. Use this field in JSON PUT requests (or track[metadata_artist] in multipart PUT requests); use track[artist] in multipart POST uploads.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackMetadataRequestTrack(
            string? title,
            string? permalink,
            global::SoundCloud.TrackMetadataRequestTrackSharing? sharing,
            global::SoundCloud.TrackMetadataRequestTrackEmbeddableBy? embeddableBy,
            string? purchaseUrl,
            string? description,
            string? genre,
            string? tagList,
            string? labelName,
            string? release,
            string? releaseDate,
            bool? streamable,
            bool? downloadable,
            global::SoundCloud.TrackMetadataRequestTrackLicense? license,
            bool? commentable,
            bool? revealStats,
            bool? revealComments,
            string? isrc,
            string? metadataArtist)
        {
            this.Title = title;
            this.Permalink = permalink;
            this.Sharing = sharing;
            this.EmbeddableBy = embeddableBy;
            this.PurchaseUrl = purchaseUrl;
            this.Description = description;
            this.Genre = genre;
            this.TagList = tagList;
            this.LabelName = labelName;
            this.Release = release;
            this.ReleaseDate = releaseDate;
            this.Streamable = streamable;
            this.Downloadable = downloadable;
            this.License = license;
            this.Commentable = commentable;
            this.RevealStats = revealStats;
            this.RevealComments = revealComments;
            this.Isrc = isrc;
            this.MetadataArtist = metadataArtist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackMetadataRequestTrack" /> class.
        /// </summary>
        public TrackMetadataRequestTrack()
        {
        }

    }
}