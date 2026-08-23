
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// User's Comment
    /// </summary>
    public sealed partial class Comment
    {
        /// <summary>
        /// Comment body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Created timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urn")]
        public string? Urn { get; set; }

        /// <summary>
        /// Kind (comment).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// User's identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_urn")]
        public string? UserUrn { get; set; }

        /// <summary>
        /// Timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// Track's identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_urn")]
        public string? TrackUrn { get; set; }

        /// <summary>
        /// Comment's URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// SoundCloud User object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::SoundCloud.CommentUser? User { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Comment" /> class.
        /// </summary>
        /// <param name="body">
        /// Comment body.
        /// </param>
        /// <param name="createdAt">
        /// Created timestamp.
        /// </param>
        /// <param name="urn">
        /// Identifier.
        /// </param>
        /// <param name="kind">
        /// Kind (comment).
        /// </param>
        /// <param name="userUrn">
        /// User's identifier.
        /// </param>
        /// <param name="timestamp">
        /// Timestamp.
        /// </param>
        /// <param name="trackUrn">
        /// Track's identifier.
        /// </param>
        /// <param name="uri">
        /// Comment's URL.
        /// </param>
        /// <param name="user">
        /// SoundCloud User object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Comment(
            string? body,
            string? createdAt,
            string? urn,
            string? kind,
            string? userUrn,
            string? timestamp,
            string? trackUrn,
            string? uri,
            global::SoundCloud.CommentUser? user)
        {
            this.Body = body;
            this.CreatedAt = createdAt;
            this.Urn = urn;
            this.Kind = kind;
            this.UserUrn = userUrn;
            this.Timestamp = timestamp;
            this.TrackUrn = trackUrn;
            this.Uri = uri;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Comment" /> class.
        /// </summary>
        public Comment()
        {
        }

    }
}