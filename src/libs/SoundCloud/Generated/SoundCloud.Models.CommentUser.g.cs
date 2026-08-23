
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// SoundCloud User object
    /// </summary>
    public sealed partial class CommentUser
    {
        /// <summary>
        /// unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urn")]
        public string? Urn { get; set; }

        /// <summary>
        /// kind of resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// permalink of the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink")]
        public string? Permalink { get; set; }

        /// <summary>
        /// username
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// last modified timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modified")]
        public string? LastModified { get; set; }

        /// <summary>
        /// API resource URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// URL to the SoundCloud.com page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink_url")]
        public string? PermalinkUrl { get; set; }

        /// <summary>
        /// URL to a JPEG image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// number of followers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers_count")]
        public int? FollowersCount { get; set; }

        /// <summary>
        /// number of followed users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followings_count")]
        public int? FollowingsCount { get; set; }

        /// <summary>
        /// number of reposts from user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reposts_count")]
        public int? RepostsCount { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentUser" /> class.
        /// </summary>
        /// <param name="urn">
        /// unique identifier
        /// </param>
        /// <param name="kind">
        /// kind of resource.
        /// </param>
        /// <param name="permalink">
        /// permalink of the resource.
        /// </param>
        /// <param name="username">
        /// username
        /// </param>
        /// <param name="lastModified">
        /// last modified timestamp.
        /// </param>
        /// <param name="uri">
        /// API resource URL.
        /// </param>
        /// <param name="permalinkUrl">
        /// URL to the SoundCloud.com page.
        /// </param>
        /// <param name="avatarUrl">
        /// URL to a JPEG image.
        /// </param>
        /// <param name="followersCount">
        /// number of followers.
        /// </param>
        /// <param name="followingsCount">
        /// number of followed users.
        /// </param>
        /// <param name="repostsCount">
        /// number of reposts from user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommentUser(
            string? urn,
            string? kind,
            string? permalink,
            string? username,
            string? lastModified,
            string? uri,
            string? permalinkUrl,
            string? avatarUrl,
            int? followersCount,
            int? followingsCount,
            int? repostsCount)
        {
            this.Urn = urn;
            this.Kind = kind;
            this.Permalink = permalink;
            this.Username = username;
            this.LastModified = lastModified;
            this.Uri = uri;
            this.PermalinkUrl = permalinkUrl;
            this.AvatarUrl = avatarUrl;
            this.FollowersCount = followersCount;
            this.FollowingsCount = followingsCount;
            this.RepostsCount = repostsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommentUser" /> class.
        /// </summary>
        public CommentUser()
        {
        }

    }
}