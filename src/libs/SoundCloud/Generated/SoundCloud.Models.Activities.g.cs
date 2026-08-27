
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// User's activities.
    /// </summary>
    public sealed partial class Activities
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public global::System.Collections.Generic.IList<global::SoundCloud.ActivitiesCollectionItem>? Collection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_href")]
        public string? NextHref { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("future_href")]
        public string? FutureHref { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Activities" /> class.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="nextHref"></param>
        /// <param name="futureHref"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Activities(
            global::System.Collections.Generic.IList<global::SoundCloud.ActivitiesCollectionItem>? collection,
            string? nextHref,
            string? futureHref)
        {
            this.Collection = collection;
            this.NextHref = nextHref;
            this.FutureHref = futureHref;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Activities" /> class.
        /// </summary>
        public Activities()
        {
        }

    }
}