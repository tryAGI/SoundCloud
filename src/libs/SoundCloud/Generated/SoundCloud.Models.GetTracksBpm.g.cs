
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetTracksBpm
    {
        /// <summary>
        /// Return tracks with at least this bpm value<br/>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public int? From { get; set; }

        /// <summary>
        /// Return tracks with at most this bpm value<br/>
        /// Example: 456
        /// </summary>
        /// <example>456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public int? To { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTracksBpm" /> class.
        /// </summary>
        /// <param name="from">
        /// Return tracks with at least this bpm value<br/>
        /// Example: 123
        /// </param>
        /// <param name="to">
        /// Return tracks with at most this bpm value<br/>
        /// Example: 456
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTracksBpm(
            int? from,
            int? to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTracksBpm" /> class.
        /// </summary>
        public GetTracksBpm()
        {
        }

    }
}