
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Streams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hls_aac_160_url")]
        public string? HlsAac160Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hls_mp3_128_url")]
        public string? HlsMp3128Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_mp3_128_url")]
        public string? PreviewMp3128Url { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Streams" /> class.
        /// </summary>
        /// <param name="hlsAac160Url"></param>
        /// <param name="hlsMp3128Url"></param>
        /// <param name="previewMp3128Url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Streams(
            string? hlsAac160Url,
            string? hlsMp3128Url,
            string? previewMp3128Url)
        {
            this.HlsAac160Url = hlsAac160Url;
            this.HlsMp3128Url = hlsMp3128Url;
            this.PreviewMp3128Url = previewMp3128Url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Streams" /> class.
        /// </summary>
        public Streams()
        {
        }

    }
}