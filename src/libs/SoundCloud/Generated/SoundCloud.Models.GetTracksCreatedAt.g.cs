
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetTracksCreatedAt
    {
        /// <summary>
        /// (yyyy-mm-dd hh:mm:ss) return tracks created at this date or later<br/>
        /// Example: 2020-12-24 00:00:00
        /// </summary>
        /// <example>2020-12-24 00:00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// (yyyy-mm-dd hh:mm:ss) return tracks created at this date or earlier<br/>
        /// Example: 2020-12-26 00:00:00
        /// </summary>
        /// <example>2020-12-26 00:00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTracksCreatedAt" /> class.
        /// </summary>
        /// <param name="from">
        /// (yyyy-mm-dd hh:mm:ss) return tracks created at this date or later<br/>
        /// Example: 2020-12-24 00:00:00
        /// </param>
        /// <param name="to">
        /// (yyyy-mm-dd hh:mm:ss) return tracks created at this date or earlier<br/>
        /// Example: 2020-12-26 00:00:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTracksCreatedAt(
            string? from,
            string? to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTracksCreatedAt" /> class.
        /// </summary>
        public GetTracksCreatedAt()
        {
        }

    }
}