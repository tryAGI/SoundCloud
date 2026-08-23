
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebProfile
    {
        /// <summary>
        /// Timestamp of when the link was added to the profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urn")]
        public string? Urn { get; set; }

        /// <summary>
        /// Kind
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Service or platform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        public string? Service { get; set; }

        /// <summary>
        /// Link's title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL of the external link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Username extracted from the external link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebProfile" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Timestamp of when the link was added to the profile.
        /// </param>
        /// <param name="urn">
        /// Id
        /// </param>
        /// <param name="kind">
        /// Kind
        /// </param>
        /// <param name="service">
        /// Service or platform
        /// </param>
        /// <param name="title">
        /// Link's title
        /// </param>
        /// <param name="url">
        /// URL of the external link
        /// </param>
        /// <param name="username">
        /// Username extracted from the external link
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebProfile(
            string? createdAt,
            string? urn,
            string? kind,
            string? service,
            string? title,
            string? url,
            string? username)
        {
            this.CreatedAt = createdAt;
            this.Urn = urn;
            this.Kind = kind;
            this.Service = service;
            this.Title = title;
            this.Url = url;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebProfile" /> class.
        /// </summary>
        public WebProfile()
        {
        }

    }
}