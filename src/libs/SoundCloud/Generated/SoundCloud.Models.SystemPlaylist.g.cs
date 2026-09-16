
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// SoundCloud system playlist object (e.g. track station, artist station).
    /// </summary>
    public sealed partial class SystemPlaylist
    {
        /// <summary>
        /// Type of object (system-playlist).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// System playlist URN.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urn")]
        public string? Urn { get; set; }

        /// <summary>
        /// Playlist title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Playlist description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Playlist type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_type")]
        public string? PlaylistType { get; set; }

        /// <summary>
        /// System playlist permalink slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink")]
        public string? Permalink { get; set; }

        /// <summary>
        /// Permalink URL on soundcloud.com.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink_url")]
        public string? PermalinkUrl { get; set; }

        /// <summary>
        /// Last updated timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated")]
        public string? LastUpdated { get; set; }

        /// <summary>
        /// Tracking feature name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracking_feature_name")]
        public string? TrackingFeatureName { get; set; }

        /// <summary>
        /// Number of visible tracks in the playlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_count")]
        public int? TrackCount { get; set; }

        /// <summary>
        /// Query URN used to generate the playlist, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_urn")]
        public string? QueryUrn { get; set; }

        /// <summary>
        /// Visible tracks in the playlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        public global::System.Collections.Generic.IList<global::SoundCloud.Track>? Tracks { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemPlaylist" /> class.
        /// </summary>
        /// <param name="kind">
        /// Type of object (system-playlist).
        /// </param>
        /// <param name="urn">
        /// System playlist URN.
        /// </param>
        /// <param name="title">
        /// Playlist title.
        /// </param>
        /// <param name="description">
        /// Playlist description.
        /// </param>
        /// <param name="playlistType">
        /// Playlist type.
        /// </param>
        /// <param name="permalink">
        /// System playlist permalink slug.
        /// </param>
        /// <param name="permalinkUrl">
        /// Permalink URL on soundcloud.com.
        /// </param>
        /// <param name="lastUpdated">
        /// Last updated timestamp.
        /// </param>
        /// <param name="trackingFeatureName">
        /// Tracking feature name.
        /// </param>
        /// <param name="trackCount">
        /// Number of visible tracks in the playlist.
        /// </param>
        /// <param name="queryUrn">
        /// Query URN used to generate the playlist, when available.
        /// </param>
        /// <param name="tracks">
        /// Visible tracks in the playlist.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemPlaylist(
            string? kind,
            string? urn,
            string? title,
            string? description,
            string? playlistType,
            string? permalink,
            string? permalinkUrl,
            string? lastUpdated,
            string? trackingFeatureName,
            int? trackCount,
            string? queryUrn,
            global::System.Collections.Generic.IList<global::SoundCloud.Track>? tracks)
        {
            this.Kind = kind;
            this.Urn = urn;
            this.Title = title;
            this.Description = description;
            this.PlaylistType = playlistType;
            this.Permalink = permalink;
            this.PermalinkUrl = permalinkUrl;
            this.LastUpdated = lastUpdated;
            this.TrackingFeatureName = trackingFeatureName;
            this.TrackCount = trackCount;
            this.QueryUrn = queryUrn;
            this.Tracks = tracks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemPlaylist" /> class.
        /// </summary>
        public SystemPlaylist()
        {
        }

    }
}