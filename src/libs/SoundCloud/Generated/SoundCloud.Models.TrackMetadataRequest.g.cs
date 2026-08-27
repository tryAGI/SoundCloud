
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrackMetadataRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track")]
        public global::SoundCloud.TrackMetadataRequestTrack? Track { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackMetadataRequest" /> class.
        /// </summary>
        /// <param name="track"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackMetadataRequest(
            global::SoundCloud.TrackMetadataRequestTrack? track)
        {
            this.Track = track;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackMetadataRequest" /> class.
        /// </summary>
        public TrackMetadataRequest()
        {
        }

    }
}