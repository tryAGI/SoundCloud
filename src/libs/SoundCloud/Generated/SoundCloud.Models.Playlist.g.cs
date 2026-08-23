
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Soundcloud Playlist Object
    /// </summary>
    public sealed partial class Playlist
    {
        /// <summary>
        /// Playlist title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Playlist identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urn")]
        public string? Urn { get; set; }

        /// <summary>
        /// Type of Soundcloud object (playlist).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// URL to a JPEG image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artwork_url")]
        public string? ArtworkUrl { get; set; }

        /// <summary>
        /// Created timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Playlist description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// is downloadable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadable")]
        public bool? Downloadable { get; set; }

        /// <summary>
        /// Playlist duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// European Article Number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ean")]
        public string? Ean { get; set; }

        /// <summary>
        /// Embeddable by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddable_by")]
        public string? EmbeddableBy { get; set; }

        /// <summary>
        /// Playlist genre.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        public string? Genre { get; set; }

        /// <summary>
        /// Label user identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_id")]
        public int? LabelId { get; set; }

        /// <summary>
        /// Label name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_name")]
        public string? LabelName { get; set; }

        /// <summary>
        /// Last modified timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modified")]
        public string? LastModified { get; set; }

        /// <summary>
        /// License.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// Playlist permalink.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink")]
        public string? Permalink { get; set; }

        /// <summary>
        /// Playlist permalink URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink_url")]
        public string? PermalinkUrl { get; set; }

        /// <summary>
        /// Type of playlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_type")]
        public string? PlaylistType { get; set; }

        /// <summary>
        /// Purchase title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchase_title")]
        public string? PurchaseTitle { get; set; }

        /// <summary>
        /// Purchase URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchase_url")]
        public string? PurchaseUrl { get; set; }

        /// <summary>
        /// Release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release")]
        public string? Release { get; set; }

        /// <summary>
        /// Day of release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_day")]
        public int? ReleaseDay { get; set; }

        /// <summary>
        /// Month of release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_month")]
        public int? ReleaseMonth { get; set; }

        /// <summary>
        /// Year of release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_year")]
        public int? ReleaseYear { get; set; }

        /// <summary>
        /// Type of sharing (private/public).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharing")]
        public string? Sharing { get; set; }

        /// <summary>
        /// Is streamable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streamable")]
        public bool? Streamable { get; set; }

        /// <summary>
        /// Tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_list")]
        public string? TagList { get; set; }

        /// <summary>
        /// Count of tracks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_count")]
        public int? TrackCount { get; set; }

        /// <summary>
        /// List of tracks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        public global::System.Collections.Generic.IList<global::SoundCloud.Track>? Tracks { get; set; }

        /// <summary>
        /// Playlist type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Playlist URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// SoundCloud User object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::SoundCloud.User? User { get; set; }

        /// <summary>
        /// User identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_urn")]
        public string? UserUrn { get; set; }

        /// <summary>
        /// Count of playlist likes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likes_count")]
        public int? LikesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.AllOfJsonConverter<object, global::SoundCloud.User>))]
        public global::SoundCloud.AllOf<object, global::SoundCloud.User>? Label { get; set; }

        /// <summary>
        /// tracks URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks_uri")]
        public string? TracksUri { get; set; }

        /// <summary>
        /// Tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public string? Tags { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Playlist" /> class.
        /// </summary>
        /// <param name="title">
        /// Playlist title.
        /// </param>
        /// <param name="urn">
        /// Playlist identifier.
        /// </param>
        /// <param name="kind">
        /// Type of Soundcloud object (playlist).
        /// </param>
        /// <param name="artworkUrl">
        /// URL to a JPEG image.
        /// </param>
        /// <param name="createdAt">
        /// Created timestamp.
        /// </param>
        /// <param name="description">
        /// Playlist description.
        /// </param>
        /// <param name="downloadable">
        /// is downloadable.
        /// </param>
        /// <param name="duration">
        /// Playlist duration.
        /// </param>
        /// <param name="ean">
        /// European Article Number.
        /// </param>
        /// <param name="embeddableBy">
        /// Embeddable by.
        /// </param>
        /// <param name="genre">
        /// Playlist genre.
        /// </param>
        /// <param name="labelId">
        /// Label user identifier.
        /// </param>
        /// <param name="labelName">
        /// Label name.
        /// </param>
        /// <param name="lastModified">
        /// Last modified timestamp.
        /// </param>
        /// <param name="license">
        /// License.
        /// </param>
        /// <param name="permalink">
        /// Playlist permalink.
        /// </param>
        /// <param name="permalinkUrl">
        /// Playlist permalink URL.
        /// </param>
        /// <param name="playlistType">
        /// Type of playlist.
        /// </param>
        /// <param name="purchaseTitle">
        /// Purchase title.
        /// </param>
        /// <param name="purchaseUrl">
        /// Purchase URL.
        /// </param>
        /// <param name="release">
        /// Release.
        /// </param>
        /// <param name="releaseDay">
        /// Day of release.
        /// </param>
        /// <param name="releaseMonth">
        /// Month of release.
        /// </param>
        /// <param name="releaseYear">
        /// Year of release.
        /// </param>
        /// <param name="sharing">
        /// Type of sharing (private/public).
        /// </param>
        /// <param name="streamable">
        /// Is streamable.
        /// </param>
        /// <param name="tagList">
        /// Tags.
        /// </param>
        /// <param name="trackCount">
        /// Count of tracks.
        /// </param>
        /// <param name="tracks">
        /// List of tracks.
        /// </param>
        /// <param name="type">
        /// Playlist type.
        /// </param>
        /// <param name="uri">
        /// Playlist URI.
        /// </param>
        /// <param name="user">
        /// SoundCloud User object
        /// </param>
        /// <param name="userUrn">
        /// User identifier.
        /// </param>
        /// <param name="likesCount">
        /// Count of playlist likes.
        /// </param>
        /// <param name="label"></param>
        /// <param name="tracksUri">
        /// tracks URI.
        /// </param>
        /// <param name="tags">
        /// Tags.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Playlist(
            string? title,
            string? urn,
            string? kind,
            string? artworkUrl,
            string? createdAt,
            string? description,
            bool? downloadable,
            int? duration,
            string? ean,
            string? embeddableBy,
            string? genre,
            int? labelId,
            string? labelName,
            string? lastModified,
            string? license,
            string? permalink,
            string? permalinkUrl,
            string? playlistType,
            string? purchaseTitle,
            string? purchaseUrl,
            string? release,
            int? releaseDay,
            int? releaseMonth,
            int? releaseYear,
            string? sharing,
            bool? streamable,
            string? tagList,
            int? trackCount,
            global::System.Collections.Generic.IList<global::SoundCloud.Track>? tracks,
            string? type,
            string? uri,
            global::SoundCloud.User? user,
            string? userUrn,
            int? likesCount,
            global::SoundCloud.AllOf<object, global::SoundCloud.User>? label,
            string? tracksUri,
            string? tags)
        {
            this.Title = title;
            this.Urn = urn;
            this.Kind = kind;
            this.ArtworkUrl = artworkUrl;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Downloadable = downloadable;
            this.Duration = duration;
            this.Ean = ean;
            this.EmbeddableBy = embeddableBy;
            this.Genre = genre;
            this.LabelId = labelId;
            this.LabelName = labelName;
            this.LastModified = lastModified;
            this.License = license;
            this.Permalink = permalink;
            this.PermalinkUrl = permalinkUrl;
            this.PlaylistType = playlistType;
            this.PurchaseTitle = purchaseTitle;
            this.PurchaseUrl = purchaseUrl;
            this.Release = release;
            this.ReleaseDay = releaseDay;
            this.ReleaseMonth = releaseMonth;
            this.ReleaseYear = releaseYear;
            this.Sharing = sharing;
            this.Streamable = streamable;
            this.TagList = tagList;
            this.TrackCount = trackCount;
            this.Tracks = tracks;
            this.Type = type;
            this.Uri = uri;
            this.User = user;
            this.UserUrn = userUrn;
            this.LikesCount = likesCount;
            this.Label = label;
            this.TracksUri = tracksUri;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Playlist" /> class.
        /// </summary>
        public Playlist()
        {
        }

    }
}