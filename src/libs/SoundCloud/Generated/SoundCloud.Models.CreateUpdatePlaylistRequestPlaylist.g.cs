
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateUpdatePlaylistRequestPlaylist
    {
        /// <summary>
        /// Title of the playlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description of the playlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// public or private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.CreateUpdatePlaylistRequestPlaylistSharingJsonConverter))]
        public global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSharing? Sharing { get; set; }

        /// <summary>
        /// List of tracks to add to playlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        public global::System.Collections.Generic.IList<global::SoundCloud.CreateUpdatePlaylistRequestPlaylistTrack>? Tracks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artwork_data")]
        public byte[]? ArtworkData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artwork_dataname")]
        public string? ArtworkDataname { get; set; }

        /// <summary>
        /// The European Article Number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ean")]
        public string? Ean { get; set; }

        /// <summary>
        /// Playlist's genre
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        public string? Genre { get; set; }

        /// <summary>
        /// Label name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_name")]
        public string? LabelName { get; set; }

        /// <summary>
        /// License number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// Playlist's permalink
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink")]
        public string? Permalink { get; set; }

        /// <summary>
        /// Full permalink URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink_url")]
        public string? PermalinkUrl { get; set; }

        /// <summary>
        /// Purchase title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchase_title")]
        public string? PurchaseTitle { get; set; }

        /// <summary>
        /// Purchase URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchase_url")]
        public string? PurchaseUrl { get; set; }

        /// <summary>
        /// Playlist's release
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release")]
        public string? Release { get; set; }

        /// <summary>
        /// Release date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date")]
        public string? ReleaseDate { get; set; }

        /// <summary>
        /// Playlist or album type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("set_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.CreateUpdatePlaylistRequestPlaylistSetTypeJsonConverter))]
        public global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSetType? SetType { get; set; }

        /// <summary>
        /// A comma-separated list of tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_list")]
        public string? TagList { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUpdatePlaylistRequestPlaylist" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the playlist
        /// </param>
        /// <param name="description">
        /// Description of the playlist
        /// </param>
        /// <param name="sharing">
        /// public or private
        /// </param>
        /// <param name="tracks">
        /// List of tracks to add to playlist
        /// </param>
        /// <param name="artworkData"></param>
        /// <param name="artworkDataname"></param>
        /// <param name="ean">
        /// The European Article Number
        /// </param>
        /// <param name="genre">
        /// Playlist's genre
        /// </param>
        /// <param name="labelName">
        /// Label name
        /// </param>
        /// <param name="license">
        /// License number
        /// </param>
        /// <param name="permalink">
        /// Playlist's permalink
        /// </param>
        /// <param name="permalinkUrl">
        /// Full permalink URL
        /// </param>
        /// <param name="purchaseTitle">
        /// Purchase title
        /// </param>
        /// <param name="purchaseUrl">
        /// Purchase URL
        /// </param>
        /// <param name="release">
        /// Playlist's release
        /// </param>
        /// <param name="releaseDate">
        /// Release date
        /// </param>
        /// <param name="setType">
        /// Playlist or album type
        /// </param>
        /// <param name="tagList">
        /// A comma-separated list of tags
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUpdatePlaylistRequestPlaylist(
            string? title,
            string? description,
            global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSharing? sharing,
            global::System.Collections.Generic.IList<global::SoundCloud.CreateUpdatePlaylistRequestPlaylistTrack>? tracks,
            byte[]? artworkData,
            string? artworkDataname,
            string? ean,
            string? genre,
            string? labelName,
            string? license,
            string? permalink,
            string? permalinkUrl,
            string? purchaseTitle,
            string? purchaseUrl,
            string? release,
            string? releaseDate,
            global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSetType? setType,
            string? tagList)
        {
            this.Title = title;
            this.Description = description;
            this.Sharing = sharing;
            this.Tracks = tracks;
            this.ArtworkData = artworkData;
            this.ArtworkDataname = artworkDataname;
            this.Ean = ean;
            this.Genre = genre;
            this.LabelName = labelName;
            this.License = license;
            this.Permalink = permalink;
            this.PermalinkUrl = permalinkUrl;
            this.PurchaseTitle = purchaseTitle;
            this.PurchaseUrl = purchaseUrl;
            this.Release = release;
            this.ReleaseDate = releaseDate;
            this.SetType = setType;
            this.TagList = tagList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUpdatePlaylistRequestPlaylist" /> class.
        /// </summary>
        public CreateUpdatePlaylistRequestPlaylist()
        {
        }

    }
}