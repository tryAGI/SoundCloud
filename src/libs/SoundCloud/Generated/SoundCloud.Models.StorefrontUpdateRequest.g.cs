
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Creates or updates the storefront (Artist Storefront / buy module) of a track. The request<br/>
    /// replaces the whole storefront - omitted optional fields are cleared, so always send every<br/>
    /// value the storefront should keep.
    /// </summary>
    public sealed partial class StorefrontUpdateRequest
    {
        /// <summary>
        /// Card title shown on the storefront module.<br/>
        /// Example: Download now
        /// </summary>
        /// <example>Download now</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The type of item offered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.StorefrontUpdateRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SoundCloud.StorefrontUpdateRequestType Type { get; set; }

        /// <summary>
        /// External http(s) URL the storefront button opens.<br/>
        /// Example: https://example.com/my-track
        /// </summary>
        /// <example>https://example.com/my-track</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Link { get; set; }

        /// <summary>
        /// Label of the storefront button. Omit to clear.<br/>
        /// Example: Download
        /// </summary>
        /// <example>Download</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_title")]
        public string? LinkTitle { get; set; }

        /// <summary>
        /// Description shown on the storefront module. Omit to clear.<br/>
        /// Example: Get the track original files for free.
        /// </summary>
        /// <example>Get the track original files for free.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Display-only price text shown next to the item type. No payment is processed by SoundCloud. Omit to clear.<br/>
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
        /// Initializes a new instance of the <see cref="StorefrontUpdateRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorefrontUpdateRequest(
            string title,
            global::SoundCloud.StorefrontUpdateRequestType type,
            string link,
            string? linkTitle,
            string? description,
            string? price)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Type = type;
            this.Link = link ?? throw new global::System.ArgumentNullException(nameof(link));
            this.LinkTitle = linkTitle;
            this.Description = description;
            this.Price = price;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorefrontUpdateRequest" /> class.
        /// </summary>
        public StorefrontUpdateRequest()
        {
        }

    }
}