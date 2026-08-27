
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTracksCommentsRequestComment
    {
        /// <summary>
        /// Comment's content<br/>
        /// Example: test comment
        /// </summary>
        /// <example>test comment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Timestamp of a comment. String or float representation is supported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::SoundCloud.OneOf<string, double?>? Timestamp { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTracksCommentsRequestComment" /> class.
        /// </summary>
        /// <param name="body">
        /// Comment's content<br/>
        /// Example: test comment
        /// </param>
        /// <param name="timestamp">
        /// Timestamp of a comment. String or float representation is supported
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTracksCommentsRequestComment(
            string body,
            global::SoundCloud.OneOf<string, double?>? timestamp)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTracksCommentsRequestComment" /> class.
        /// </summary>
        public CreateTracksCommentsRequestComment()
        {
        }

    }
}