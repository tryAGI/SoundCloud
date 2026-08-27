
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Soundcloud Track object.
    /// </summary>
    public sealed partial class Track
    {
        /// <summary>
        /// Type of object (track).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Track title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL to a JPEG image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artwork_url")]
        public string? ArtworkUrl { get; set; }

        /// <summary>
        /// Tempo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        public double? Bpm { get; set; }

        /// <summary>
        /// Number of comments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_count")]
        public long? CommentCount { get; set; }

        /// <summary>
        /// Is commentable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commentable")]
        public bool? Commentable { get; set; }

        /// <summary>
        /// Created timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Track description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Number of downloads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_count")]
        public long? DownloadCount { get; set; }

        /// <summary>
        /// Is downloadable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadable")]
        public bool? Downloadable { get; set; }

        /// <summary>
        /// Track duration in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Embeddable by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddable_by")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EmbeddableBy { get; set; }

        /// <summary>
        /// Number of favoritings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favoritings_count")]
        public long? FavoritingsCount { get; set; }

        /// <summary>
        /// Genre
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        public string? Genre { get; set; }

        /// <summary>
        /// Track URN identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urn")]
        public string? Urn { get; set; }

        /// <summary>
        /// ISRC code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isrc")]
        public string? Isrc { get; set; }

        /// <summary>
        /// Key signature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_signature")]
        public string? KeySignature { get; set; }

        /// <summary>
        /// Label user name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_name")]
        public string? LabelName { get; set; }

        /// <summary>
        /// License
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// Optional artist name, when different from user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_artist")]
        public string? MetadataArtist { get; set; }

        /// <summary>
        /// Permalink URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink_url")]
        public string? PermalinkUrl { get; set; }

        /// <summary>
        /// Number of plays.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playback_count")]
        public long? PlaybackCount { get; set; }

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
        /// Type of sharing (public/private).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharing")]
        public string? Sharing { get; set; }

        /// <summary>
        /// URL to stream (preview only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? StreamUrl { get; set; }

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
        /// Track URI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.AllOfJsonConverter<global::SoundCloud.User, object>))]
        public global::SoundCloud.AllOf<global::SoundCloud.User, object>? User { get; set; }

        /// <summary>
        /// Is user's favourite. It is only set when fetching search results or single track, otherwise it is false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_favorite")]
        public bool? UserFavorite { get; set; }

        /// <summary>
        /// Number of plays by a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_playback_count")]
        public int? UserPlaybackCount { get; set; }

        /// <summary>
        /// Waveform URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waveform_url")]
        public string? WaveformUrl { get; set; }

        /// <summary>
        /// List of country codes where track is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_country_codes")]
        public string? AvailableCountryCodes { get; set; }

        /// <summary>
        /// Level of access the user (logged in or anonymous) has to the track.<br/>
        ///   * `playable` - user is allowed to listen to a full track.<br/>
        ///   * `preview` - user is allowed to preview a track, meaning a snippet is available<br/>
        ///   * `blocked` - user can only see the metadata of a track, no streaming is possible
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.TrackAccessJsonConverter))]
        public global::SoundCloud.TrackAccess? Access { get; set; }

        /// <summary>
        /// URL to download a track. Omitted or null when track is not downloadable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// Number of reposts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reposts_count")]
        public int? RepostsCount { get; set; }

        /// <summary>
        /// Whether play and favorite counts are visible. When false (quiet mode), stats are hidden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reveal_stats")]
        public bool? RevealStats { get; set; }

        /// <summary>
        /// Whether comments are visible. When false (quiet mode), comments are hidden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reveal_comments")]
        public bool? RevealComments { get; set; }

        /// <summary>
        /// Secret URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_uri")]
        public string? SecretUri { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Track" /> class.
        /// </summary>
        /// <param name="kind">
        /// Type of object (track).
        /// </param>
        /// <param name="title">
        /// Track title.
        /// </param>
        /// <param name="artworkUrl">
        /// URL to a JPEG image.
        /// </param>
        /// <param name="bpm">
        /// Tempo.
        /// </param>
        /// <param name="commentCount">
        /// Number of comments.
        /// </param>
        /// <param name="commentable">
        /// Is commentable.
        /// </param>
        /// <param name="createdAt">
        /// Created timestamp.
        /// </param>
        /// <param name="description">
        /// Track description.
        /// </param>
        /// <param name="downloadCount">
        /// Number of downloads.
        /// </param>
        /// <param name="downloadable">
        /// Is downloadable.
        /// </param>
        /// <param name="duration">
        /// Track duration in milliseconds.
        /// </param>
        /// <param name="favoritingsCount">
        /// Number of favoritings.
        /// </param>
        /// <param name="genre">
        /// Genre
        /// </param>
        /// <param name="urn">
        /// Track URN identifier.
        /// </param>
        /// <param name="isrc">
        /// ISRC code.
        /// </param>
        /// <param name="keySignature">
        /// Key signature.
        /// </param>
        /// <param name="labelName">
        /// Label user name.
        /// </param>
        /// <param name="license">
        /// License
        /// </param>
        /// <param name="metadataArtist">
        /// Optional artist name, when different from user.
        /// </param>
        /// <param name="permalinkUrl">
        /// Permalink URL.
        /// </param>
        /// <param name="playbackCount">
        /// Number of plays.
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
        /// Type of sharing (public/private).
        /// </param>
        /// <param name="streamable">
        /// Is streamable.
        /// </param>
        /// <param name="tagList">
        /// Tags.
        /// </param>
        /// <param name="uri">
        /// Track URI.
        /// </param>
        /// <param name="user"></param>
        /// <param name="userFavorite">
        /// Is user's favourite. It is only set when fetching search results or single track, otherwise it is false.
        /// </param>
        /// <param name="userPlaybackCount">
        /// Number of plays by a user.
        /// </param>
        /// <param name="waveformUrl">
        /// Waveform URL.
        /// </param>
        /// <param name="availableCountryCodes">
        /// List of country codes where track is available.
        /// </param>
        /// <param name="access">
        /// Level of access the user (logged in or anonymous) has to the track.<br/>
        ///   * `playable` - user is allowed to listen to a full track.<br/>
        ///   * `preview` - user is allowed to preview a track, meaning a snippet is available<br/>
        ///   * `blocked` - user can only see the metadata of a track, no streaming is possible
        /// </param>
        /// <param name="downloadUrl">
        /// URL to download a track. Omitted or null when track is not downloadable.
        /// </param>
        /// <param name="repostsCount">
        /// Number of reposts.
        /// </param>
        /// <param name="revealStats">
        /// Whether play and favorite counts are visible. When false (quiet mode), stats are hidden.
        /// </param>
        /// <param name="revealComments">
        /// Whether comments are visible. When false (quiet mode), comments are hidden.
        /// </param>
        /// <param name="secretUri">
        /// Secret URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Track(
            string? kind,
            string? title,
            string? artworkUrl,
            double? bpm,
            long? commentCount,
            bool? commentable,
            string? createdAt,
            string? description,
            long? downloadCount,
            bool? downloadable,
            int? duration,
            long? favoritingsCount,
            string? genre,
            string? urn,
            string? isrc,
            string? keySignature,
            string? labelName,
            string? license,
            string? metadataArtist,
            string? permalinkUrl,
            long? playbackCount,
            string? purchaseTitle,
            string? purchaseUrl,
            string? release,
            int? releaseDay,
            int? releaseMonth,
            int? releaseYear,
            string? sharing,
            bool? streamable,
            string? tagList,
            string? uri,
            global::SoundCloud.AllOf<global::SoundCloud.User, object>? user,
            bool? userFavorite,
            int? userPlaybackCount,
            string? waveformUrl,
            string? availableCountryCodes,
            global::SoundCloud.TrackAccess? access,
            string? downloadUrl,
            int? repostsCount,
            bool? revealStats,
            bool? revealComments,
            string? secretUri)
        {
            this.Kind = kind;
            this.Title = title;
            this.ArtworkUrl = artworkUrl;
            this.Bpm = bpm;
            this.CommentCount = commentCount;
            this.Commentable = commentable;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.DownloadCount = downloadCount;
            this.Downloadable = downloadable;
            this.Duration = duration;
            this.FavoritingsCount = favoritingsCount;
            this.Genre = genre;
            this.Urn = urn;
            this.Isrc = isrc;
            this.KeySignature = keySignature;
            this.LabelName = labelName;
            this.License = license;
            this.MetadataArtist = metadataArtist;
            this.PermalinkUrl = permalinkUrl;
            this.PlaybackCount = playbackCount;
            this.PurchaseTitle = purchaseTitle;
            this.PurchaseUrl = purchaseUrl;
            this.Release = release;
            this.ReleaseDay = releaseDay;
            this.ReleaseMonth = releaseMonth;
            this.ReleaseYear = releaseYear;
            this.Sharing = sharing;
            this.Streamable = streamable;
            this.TagList = tagList;
            this.Uri = uri;
            this.User = user;
            this.UserFavorite = userFavorite;
            this.UserPlaybackCount = userPlaybackCount;
            this.WaveformUrl = waveformUrl;
            this.AvailableCountryCodes = availableCountryCodes;
            this.Access = access;
            this.DownloadUrl = downloadUrl;
            this.RepostsCount = repostsCount;
            this.RevealStats = revealStats;
            this.RevealComments = revealComments;
            this.SecretUri = secretUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Track" /> class.
        /// </summary>
        public Track()
        {
        }

    }
}