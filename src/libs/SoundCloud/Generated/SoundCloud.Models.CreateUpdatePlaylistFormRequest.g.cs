
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateUpdatePlaylistFormRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[title]")]
        public string? PlaylistTitle { get; set; }

        /// <summary>
        /// Default Value: public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[sharing]")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.CreateUpdatePlaylistFormRequestPlaylistSharingJsonConverter))]
        public global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSharing? PlaylistSharing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[description]")]
        public string? PlaylistDescription { get; set; }

        /// <summary>
        /// To pass multiple tracks, pass multiple comma-separated values, e.g. -F "playlist[tracks][][urn]=soundcloud:tracks:111,soundcloud:tracks:222"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[tracks][][urn]")]
        public string? PlaylistTracksUrn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[artwork_data]")]
        public byte[]? PlaylistArtworkData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[artwork_data]name")]
        public string? PlaylistArtworkDataname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[ean]")]
        public string? PlaylistEan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[genre]")]
        public string? PlaylistGenre { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[label_name]")]
        public string? PlaylistLabelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[license]")]
        public string? PlaylistLicense { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[permalink]")]
        public string? PlaylistPermalink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[permalink_url]")]
        public string? PlaylistPermalinkUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[purchase_title]")]
        public string? PlaylistPurchaseTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[purchase_url]")]
        public string? PlaylistPurchaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[release]")]
        public string? PlaylistRelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[release_date]")]
        public string? PlaylistReleaseDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[set_type]")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.CreateUpdatePlaylistFormRequestPlaylistSetTypeJsonConverter))]
        public global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSetType? PlaylistSetType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist[tag_list]")]
        public string? PlaylistTagList { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUpdatePlaylistFormRequest" /> class.
        /// </summary>
        /// <param name="playlistTitle"></param>
        /// <param name="playlistSharing">
        /// Default Value: public
        /// </param>
        /// <param name="playlistDescription"></param>
        /// <param name="playlistTracksUrn">
        /// To pass multiple tracks, pass multiple comma-separated values, e.g. -F "playlist[tracks][][urn]=soundcloud:tracks:111,soundcloud:tracks:222"
        /// </param>
        /// <param name="playlistArtworkData"></param>
        /// <param name="playlistArtworkDataname"></param>
        /// <param name="playlistEan"></param>
        /// <param name="playlistGenre"></param>
        /// <param name="playlistLabelName"></param>
        /// <param name="playlistLicense"></param>
        /// <param name="playlistPermalink"></param>
        /// <param name="playlistPermalinkUrl"></param>
        /// <param name="playlistPurchaseTitle"></param>
        /// <param name="playlistPurchaseUrl"></param>
        /// <param name="playlistRelease"></param>
        /// <param name="playlistReleaseDate"></param>
        /// <param name="playlistSetType"></param>
        /// <param name="playlistTagList"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUpdatePlaylistFormRequest(
            string? playlistTitle,
            global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSharing? playlistSharing,
            string? playlistDescription,
            string? playlistTracksUrn,
            byte[]? playlistArtworkData,
            string? playlistArtworkDataname,
            string? playlistEan,
            string? playlistGenre,
            string? playlistLabelName,
            string? playlistLicense,
            string? playlistPermalink,
            string? playlistPermalinkUrl,
            string? playlistPurchaseTitle,
            string? playlistPurchaseUrl,
            string? playlistRelease,
            string? playlistReleaseDate,
            global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSetType? playlistSetType,
            string? playlistTagList)
        {
            this.PlaylistTitle = playlistTitle;
            this.PlaylistSharing = playlistSharing;
            this.PlaylistDescription = playlistDescription;
            this.PlaylistTracksUrn = playlistTracksUrn;
            this.PlaylistArtworkData = playlistArtworkData;
            this.PlaylistArtworkDataname = playlistArtworkDataname;
            this.PlaylistEan = playlistEan;
            this.PlaylistGenre = playlistGenre;
            this.PlaylistLabelName = playlistLabelName;
            this.PlaylistLicense = playlistLicense;
            this.PlaylistPermalink = playlistPermalink;
            this.PlaylistPermalinkUrl = playlistPermalinkUrl;
            this.PlaylistPurchaseTitle = playlistPurchaseTitle;
            this.PlaylistPurchaseUrl = playlistPurchaseUrl;
            this.PlaylistRelease = playlistRelease;
            this.PlaylistReleaseDate = playlistReleaseDate;
            this.PlaylistSetType = playlistSetType;
            this.PlaylistTagList = playlistTagList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUpdatePlaylistFormRequest" /> class.
        /// </summary>
        public CreateUpdatePlaylistFormRequest()
        {
        }

    }
}