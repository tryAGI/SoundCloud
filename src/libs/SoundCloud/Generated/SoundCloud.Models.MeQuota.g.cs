
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// user's upload quota
    /// </summary>
    public sealed partial class MeQuota
    {
        /// <summary>
        /// unlimited upload quota.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unlimited_upload_quota")]
        public bool? UnlimitedUploadQuota { get; set; }

        /// <summary>
        /// upload seconds used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_seconds_used")]
        public int? UploadSecondsUsed { get; set; }

        /// <summary>
        /// upload seconds left.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_seconds_left")]
        public int? UploadSecondsLeft { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeQuota" /> class.
        /// </summary>
        /// <param name="unlimitedUploadQuota">
        /// unlimited upload quota.
        /// </param>
        /// <param name="uploadSecondsUsed">
        /// upload seconds used.
        /// </param>
        /// <param name="uploadSecondsLeft">
        /// upload seconds left.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeQuota(
            bool? unlimitedUploadQuota,
            int? uploadSecondsUsed,
            int? uploadSecondsLeft)
        {
            this.UnlimitedUploadQuota = unlimitedUploadQuota;
            this.UploadSecondsUsed = uploadSecondsUsed;
            this.UploadSecondsLeft = uploadSecondsLeft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeQuota" /> class.
        /// </summary>
        public MeQuota()
        {
        }

    }
}