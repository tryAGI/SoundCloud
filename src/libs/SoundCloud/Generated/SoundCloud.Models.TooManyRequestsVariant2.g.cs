
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TooManyRequestsVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spam_warning_urn")]
        public string? SpamWarningUrn { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TooManyRequestsVariant2" /> class.
        /// </summary>
        /// <param name="spamWarningUrn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TooManyRequestsVariant2(
            string? spamWarningUrn)
        {
            this.SpamWarningUrn = spamWarningUrn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TooManyRequestsVariant2" /> class.
        /// </summary>
        public TooManyRequestsVariant2()
        {
        }

    }
}