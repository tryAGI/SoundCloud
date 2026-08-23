
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// subscription
    /// </summary>
    public sealed partial class UserSubscription
    {
        /// <summary>
        /// product
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        public global::SoundCloud.UserSubscriptionProduct? Product { get; set; }

        /// <summary>
        /// if the subscription is recurring or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recurring")]
        public bool? Recurring { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscription" /> class.
        /// </summary>
        /// <param name="product">
        /// product
        /// </param>
        /// <param name="recurring">
        /// if the subscription is recurring or not
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserSubscription(
            global::SoundCloud.UserSubscriptionProduct? product,
            bool? recurring)
        {
            this.Product = product;
            this.Recurring = recurring;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscription" /> class.
        /// </summary>
        public UserSubscription()
        {
        }

    }
}