
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrackCreationLimitedVariant2
    {
        /// <summary>
        /// Identifies a per-uploader track creation limit, as opposed to an app rate limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.TrackCreationLimitedVariant2ErrorCodeJsonConverter))]
        public global::SoundCloud.TrackCreationLimitedVariant2ErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// When track creation will be allowed again, null when unknown.<br/>
        /// Example: 2026/11/17 12:00:00 +0000
        /// </summary>
        /// <example>2026/11/17 12:00:00 +0000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resume_at")]
        public string? ResumeAt { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackCreationLimitedVariant2" /> class.
        /// </summary>
        /// <param name="errorCode">
        /// Identifies a per-uploader track creation limit, as opposed to an app rate limit.
        /// </param>
        /// <param name="resumeAt">
        /// When track creation will be allowed again, null when unknown.<br/>
        /// Example: 2026/11/17 12:00:00 +0000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackCreationLimitedVariant2(
            global::SoundCloud.TrackCreationLimitedVariant2ErrorCode? errorCode,
            string? resumeAt)
        {
            this.ErrorCode = errorCode;
            this.ResumeAt = resumeAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackCreationLimitedVariant2" /> class.
        /// </summary>
        public TrackCreationLimitedVariant2()
        {
        }

    }
}