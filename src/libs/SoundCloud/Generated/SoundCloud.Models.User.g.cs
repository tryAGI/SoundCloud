
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// SoundCloud User object
    /// </summary>
    public sealed partial class User
    {
        /// <summary>
        /// URL to a JPEG image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// city
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// country
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// discogs name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discogs_name")]
        public string? DiscogsName { get; set; }

        /// <summary>
        /// first name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// number of followers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers_count")]
        public int? FollowersCount { get; set; }

        /// <summary>
        /// number of followed users
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followings_count")]
        public int? FollowingsCount { get; set; }

        /// <summary>
        /// first and last name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urn")]
        public string? Urn { get; set; }

        /// <summary>
        /// kind of resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// profile creation datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// last modified datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modified")]
        public global::System.DateTime? LastModified { get; set; }

        /// <summary>
        /// last name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// permalink of the resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink")]
        public string? Permalink { get; set; }

        /// <summary>
        /// URL to the SoundCloud.com page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink_url")]
        public string? PermalinkUrl { get; set; }

        /// <summary>
        /// subscription plan of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public string? Plan { get; set; }

        /// <summary>
        /// number of public playlists
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_count")]
        public int? PlaylistCount { get; set; }

        /// <summary>
        /// number of favorited public tracks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_favorites_count")]
        public int? PublicFavoritesCount { get; set; }

        /// <summary>
        /// number of reposts from user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reposts_count")]
        public int? RepostsCount { get; set; }

        /// <summary>
        /// number of public tracks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_count")]
        public int? TrackCount { get; set; }

        /// <summary>
        /// API resource URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// username
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// a URL to the website
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// a custom title for the website
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_title")]
        public string? WebsiteTitle { get; set; }

        /// <summary>
        /// a list subscriptions associated with the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptions")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<byte[]>? Subscriptions { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="avatarUrl">
        /// URL to a JPEG image
        /// </param>
        /// <param name="city">
        /// city
        /// </param>
        /// <param name="country">
        /// country
        /// </param>
        /// <param name="description">
        /// description
        /// </param>
        /// <param name="discogsName">
        /// discogs name
        /// </param>
        /// <param name="firstName">
        /// first name
        /// </param>
        /// <param name="followersCount">
        /// number of followers
        /// </param>
        /// <param name="followingsCount">
        /// number of followed users
        /// </param>
        /// <param name="fullName">
        /// first and last name
        /// </param>
        /// <param name="urn">
        /// unique identifier
        /// </param>
        /// <param name="kind">
        /// kind of resource
        /// </param>
        /// <param name="createdAt">
        /// profile creation datetime
        /// </param>
        /// <param name="lastModified">
        /// last modified datetime
        /// </param>
        /// <param name="lastName">
        /// last name
        /// </param>
        /// <param name="permalink">
        /// permalink of the resource
        /// </param>
        /// <param name="permalinkUrl">
        /// URL to the SoundCloud.com page
        /// </param>
        /// <param name="plan">
        /// subscription plan of the user
        /// </param>
        /// <param name="playlistCount">
        /// number of public playlists
        /// </param>
        /// <param name="publicFavoritesCount">
        /// number of favorited public tracks
        /// </param>
        /// <param name="repostsCount">
        /// number of reposts from user
        /// </param>
        /// <param name="trackCount">
        /// number of public tracks
        /// </param>
        /// <param name="uri">
        /// API resource URL
        /// </param>
        /// <param name="username">
        /// username
        /// </param>
        /// <param name="website">
        /// a URL to the website
        /// </param>
        /// <param name="websiteTitle">
        /// a custom title for the website
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public User(
            string? avatarUrl,
            string? city,
            string? country,
            string? description,
            string? discogsName,
            string? firstName,
            int? followersCount,
            int? followingsCount,
            string? fullName,
            string? urn,
            string? kind,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastModified,
            string? lastName,
            string? permalink,
            string? permalinkUrl,
            string? plan,
            int? playlistCount,
            int? publicFavoritesCount,
            int? repostsCount,
            int? trackCount,
            string? uri,
            string? username,
            string? website,
            string? websiteTitle)
        {
            this.AvatarUrl = avatarUrl;
            this.City = city;
            this.Country = country;
            this.Description = description;
            this.DiscogsName = discogsName;
            this.FirstName = firstName;
            this.FollowersCount = followersCount;
            this.FollowingsCount = followingsCount;
            this.FullName = fullName;
            this.Urn = urn;
            this.Kind = kind;
            this.CreatedAt = createdAt;
            this.LastModified = lastModified;
            this.LastName = lastName;
            this.Permalink = permalink;
            this.PermalinkUrl = permalinkUrl;
            this.Plan = plan;
            this.PlaylistCount = playlistCount;
            this.PublicFavoritesCount = publicFavoritesCount;
            this.RepostsCount = repostsCount;
            this.TrackCount = trackCount;
            this.Uri = uri;
            this.Username = username;
            this.Website = website;
            this.WebsiteTitle = websiteTitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
        }

    }
}