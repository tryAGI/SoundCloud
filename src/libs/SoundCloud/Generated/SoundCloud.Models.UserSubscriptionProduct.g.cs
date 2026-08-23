
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// product
    /// </summary>
    public sealed partial class UserSubscriptionProduct
    {
        /// <summary>
        /// subscription id instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// subscription name instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscriptionProduct" /> class.
        /// </summary>
        /// <param name="id">
        /// subscription id instance.
        /// </param>
        /// <param name="name">
        /// subscription name instance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserSubscriptionProduct(
            string? id,
            string? name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscriptionProduct" /> class.
        /// </summary>
        public UserSubscriptionProduct()
        {
        }

    }
}