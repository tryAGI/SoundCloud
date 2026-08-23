
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTracksCommentsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public global::SoundCloud.CreateTracksCommentsRequestComment? Comment { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTracksCommentsRequest" /> class.
        /// </summary>
        /// <param name="comment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTracksCommentsRequest(
            global::SoundCloud.CreateTracksCommentsRequestComment? comment)
        {
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTracksCommentsRequest" /> class.
        /// </summary>
        public CreateTracksCommentsRequest()
        {
        }

    }
}