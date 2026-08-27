
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActivitiesCollectionItem
    {
        /// <summary>
        /// Type of activity (e.g. `track`, `track:repost`, `playlist`, `playlist:repost`).<br/>
        /// For `track:repost` and `playlist:repost`, the API also returns a top-level string field<br/>
        /// `reposter` with the URN of the user who reposted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Created timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Origin (track or playlist).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.AnyOfJsonConverter<global::SoundCloud.Track, global::SoundCloud.Playlist>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SoundCloud.AnyOf<global::SoundCloud.Track, global::SoundCloud.Playlist> Origin { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitiesCollectionItem" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of activity (e.g. `track`, `track:repost`, `playlist`, `playlist:repost`).<br/>
        /// For `track:repost` and `playlist:repost`, the API also returns a top-level string field<br/>
        /// `reposter` with the URN of the user who reposted.
        /// </param>
        /// <param name="createdAt">
        /// Created timestamp.
        /// </param>
        /// <param name="origin">
        /// Origin (track or playlist).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivitiesCollectionItem(
            string type,
            string createdAt,
            global::SoundCloud.AnyOf<global::SoundCloud.Track, global::SoundCloud.Playlist> origin)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitiesCollectionItem" /> class.
        /// </summary>
        public ActivitiesCollectionItem()
        {
        }

    }
}