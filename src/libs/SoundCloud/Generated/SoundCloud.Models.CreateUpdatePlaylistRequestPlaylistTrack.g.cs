
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateUpdatePlaylistRequestPlaylistTrack
    {
        /// <summary>
        /// SoundCloud track urn
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Urn { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUpdatePlaylistRequestPlaylistTrack" /> class.
        /// </summary>
        /// <param name="urn">
        /// SoundCloud track urn
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUpdatePlaylistRequestPlaylistTrack(
            string urn)
        {
            this.Urn = urn ?? throw new global::System.ArgumentNullException(nameof(urn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUpdatePlaylistRequestPlaylistTrack" /> class.
        /// </summary>
        public CreateUpdatePlaylistRequestPlaylistTrack()
        {
        }

    }
}