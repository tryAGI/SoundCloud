
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// A track's storefront (Artist Storefront / buy module) shown on the track page.
    /// </summary>
    public sealed partial class Storefront
    {
        /// <summary>
        /// The urn of the track the storefront belongs to.<br/>
        /// Example: soundcloud:tracks:1495999657
        /// </summary>
        /// <example>soundcloud:tracks:1495999657</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_urn")]
        public string? TrackUrn { get; set; }

        /// <summary>
        /// Card title shown on the storefront module.<br/>
        /// Example: Download now
        /// </summary>
        /// <example>Download now</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The type of item offered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.StorefrontTypeJsonConverter))]
        public global::SoundCloud.StorefrontType? Type { get; set; }

        /// <summary>
        /// External URL the storefront button opens.<br/>
        /// Example: https://example.com/my-track
        /// </summary>
        /// <example>https://example.com/my-track</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Label of the storefront button.<br/>
        /// Example: Download
        /// </summary>
        /// <example>Download</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_title")]
        public string? LinkTitle { get; set; }

        /// <summary>
        /// Description shown on the storefront module.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Image shown on the storefront module. Read-only; managed on soundcloud.com.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Display-only price text shown next to the item type. No payment is processed by SoundCloud.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public string? Price { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Storefront" /> class.
        /// </summary>
        /// <param name="trackUrn">
        /// The urn of the track the storefront belongs to.<br/>
        /// Example: soundcloud:tracks:1495999657
        /// </param>
        /// <param name="title">
        /// Card title shown on the storefront module.<br/>
        /// Example: Download now
        /// </param>
        /// <param name="type">
        /// The type of item offered.
        /// </param>
        /// <param name="link">
        /// External URL the storefront button opens.<br/>
        /// Example: https://example.com/my-track
        /// </param>
        /// <param name="linkTitle">
        /// Label of the storefront button.<br/>
        /// Example: Download
        /// </param>
        /// <param name="description">
        /// Description shown on the storefront module.
        /// </param>
        /// <param name="imageUrl">
        /// Image shown on the storefront module. Read-only; managed on soundcloud.com.
        /// </param>
        /// <param name="price">
        /// Display-only price text shown next to the item type. No payment is processed by SoundCloud.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Storefront(
            string? trackUrn,
            string? title,
            global::SoundCloud.StorefrontType? type,
            string? link,
            string? linkTitle,
            string? description,
            string? imageUrl,
            string? price)
        {
            this.TrackUrn = trackUrn;
            this.Title = title;
            this.Type = type;
            this.Link = link;
            this.LinkTitle = linkTitle;
            this.Description = description;
            this.ImageUrl = imageUrl;
            this.Price = price;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Storefront" /> class.
        /// </summary>
        public Storefront()
        {
        }

    }
}