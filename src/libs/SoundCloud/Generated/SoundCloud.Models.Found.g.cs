
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Found
    {
        /// <summary>
        /// Status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Location URL of the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Found" /> class.
        /// </summary>
        /// <param name="status">
        /// Status code.
        /// </param>
        /// <param name="location">
        /// Location URL of the resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Found(
            string? status,
            string? location)
        {
            this.Status = status;
            this.Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Found" /> class.
        /// </summary>
        public Found()
        {
        }

    }
}