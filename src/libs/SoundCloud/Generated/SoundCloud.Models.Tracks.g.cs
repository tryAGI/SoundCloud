
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Tracks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public global::System.Collections.Generic.IList<global::SoundCloud.Track>? Collection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_href")]
        public string? NextHref { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tracks" /> class.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="nextHref"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Tracks(
            global::System.Collections.Generic.IList<global::SoundCloud.Track>? collection,
            string? nextHref)
        {
            this.Collection = collection;
            this.NextHref = nextHref;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tracks" /> class.
        /// </summary>
        public Tracks()
        {
        }

    }
}