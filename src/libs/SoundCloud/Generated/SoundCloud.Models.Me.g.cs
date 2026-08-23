
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// SoundCloud Me object
    /// </summary>
    public sealed partial class Me
    {
        /// <summary>
        /// URL to a JPEG image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// city.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// comments count. From now on, the field always has a `0` value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_count")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? CommentsCount { get; set; }

        /// <summary>
        /// country.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// created at date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// discogs name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discogs_name")]
        public string? DiscogsName { get; set; }

        /// <summary>
        /// first name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

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
        /// first and last name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

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
        /// last modified timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_modified")]
        public string? LastModified { get; set; }

        /// <summary>
        /// last name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// likes count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likes_count")]
        public int? LikesCount { get; set; }

        /// <summary>
        /// locale.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// online.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("online")]
        public bool? Online { get; set; }

        /// <summary>
        /// permalink of the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink")]
        public string? Permalink { get; set; }

        /// <summary>
        /// URL to the SoundCloud.com page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink_url")]
        public string? PermalinkUrl { get; set; }

        /// <summary>
        /// subscription plan of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public string? Plan { get; set; }

        /// <summary>
        /// number of public playlists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_count")]
        public int? PlaylistCount { get; set; }

        /// <summary>
        /// boolean if email is confirmed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_email_confirmed")]
        public bool? PrimaryEmailConfirmed { get; set; }

        /// <summary>
        /// number of private playlists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_playlists_count")]
        public int? PrivatePlaylistsCount { get; set; }

        /// <summary>
        /// number of private tracks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_tracks_count")]
        public int? PrivateTracksCount { get; set; }

        /// <summary>
        /// number of favorited public tracks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_favorites_count")]
        public int? PublicFavoritesCount { get; set; }

        /// <summary>
        /// user's upload quota
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quota")]
        public global::SoundCloud.MeQuota? Quota { get; set; }

        /// <summary>
        /// number of reposts from user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reposts_count")]
        public int? RepostsCount { get; set; }

        /// <summary>
        /// a list subscriptions associated with the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptions")]
        public global::System.Collections.Generic.IList<byte[]>? Subscriptions { get; set; }

        /// <summary>
        /// number of public tracks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_count")]
        public int? TrackCount { get; set; }

        /// <summary>
        /// upload seconds left.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_seconds_left")]
        public int? UploadSecondsLeft { get; set; }

        /// <summary>
        /// API resource URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// username
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// a URL to the website.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// a custom title for the website.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_title")]
        public string? WebsiteTitle { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Me" /> class.
        /// </summary>
        /// <param name="avatarUrl">
        /// URL to a JPEG image.
        /// </param>
        /// <param name="city">
        /// city.
        /// </param>
        /// <param name="country">
        /// country.
        /// </param>
        /// <param name="createdAt">
        /// created at date
        /// </param>
        /// <param name="description">
        /// description.
        /// </param>
        /// <param name="discogsName">
        /// discogs name.
        /// </param>
        /// <param name="firstName">
        /// first name.
        /// </param>
        /// <param name="followersCount">
        /// number of followers.
        /// </param>
        /// <param name="followingsCount">
        /// number of followed users.
        /// </param>
        /// <param name="fullName">
        /// first and last name.
        /// </param>
        /// <param name="urn">
        /// unique identifier
        /// </param>
        /// <param name="kind">
        /// kind of resource.
        /// </param>
        /// <param name="lastModified">
        /// last modified timestamp.
        /// </param>
        /// <param name="lastName">
        /// last name.
        /// </param>
        /// <param name="likesCount">
        /// likes count.
        /// </param>
        /// <param name="locale">
        /// locale.
        /// </param>
        /// <param name="online">
        /// online.
        /// </param>
        /// <param name="permalink">
        /// permalink of the resource.
        /// </param>
        /// <param name="permalinkUrl">
        /// URL to the SoundCloud.com page.
        /// </param>
        /// <param name="plan">
        /// subscription plan of the user.
        /// </param>
        /// <param name="playlistCount">
        /// number of public playlists.
        /// </param>
        /// <param name="primaryEmailConfirmed">
        /// boolean if email is confirmed.
        /// </param>
        /// <param name="privatePlaylistsCount">
        /// number of private playlists.
        /// </param>
        /// <param name="privateTracksCount">
        /// number of private tracks.
        /// </param>
        /// <param name="publicFavoritesCount">
        /// number of favorited public tracks
        /// </param>
        /// <param name="quota">
        /// user's upload quota
        /// </param>
        /// <param name="repostsCount">
        /// number of reposts from user
        /// </param>
        /// <param name="subscriptions">
        /// a list subscriptions associated with the user
        /// </param>
        /// <param name="trackCount">
        /// number of public tracks.
        /// </param>
        /// <param name="uploadSecondsLeft">
        /// upload seconds left.
        /// </param>
        /// <param name="uri">
        /// API resource URL.
        /// </param>
        /// <param name="username">
        /// username
        /// </param>
        /// <param name="website">
        /// a URL to the website.
        /// </param>
        /// <param name="websiteTitle">
        /// a custom title for the website.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Me(
            string? avatarUrl,
            string? city,
            string? country,
            string? createdAt,
            string? description,
            string? discogsName,
            string? firstName,
            int? followersCount,
            int? followingsCount,
            string? fullName,
            string? urn,
            string? kind,
            string? lastModified,
            string? lastName,
            int? likesCount,
            string? locale,
            bool? online,
            string? permalink,
            string? permalinkUrl,
            string? plan,
            int? playlistCount,
            bool? primaryEmailConfirmed,
            int? privatePlaylistsCount,
            int? privateTracksCount,
            int? publicFavoritesCount,
            global::SoundCloud.MeQuota? quota,
            int? repostsCount,
            global::System.Collections.Generic.IList<byte[]>? subscriptions,
            int? trackCount,
            int? uploadSecondsLeft,
            string? uri,
            string? username,
            string? website,
            string? websiteTitle)
        {
            this.AvatarUrl = avatarUrl;
            this.City = city;
            this.Country = country;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.DiscogsName = discogsName;
            this.FirstName = firstName;
            this.FollowersCount = followersCount;
            this.FollowingsCount = followingsCount;
            this.FullName = fullName;
            this.Urn = urn;
            this.Kind = kind;
            this.LastModified = lastModified;
            this.LastName = lastName;
            this.LikesCount = likesCount;
            this.Locale = locale;
            this.Online = online;
            this.Permalink = permalink;
            this.PermalinkUrl = permalinkUrl;
            this.Plan = plan;
            this.PlaylistCount = playlistCount;
            this.PrimaryEmailConfirmed = primaryEmailConfirmed;
            this.PrivatePlaylistsCount = privatePlaylistsCount;
            this.PrivateTracksCount = privateTracksCount;
            this.PublicFavoritesCount = publicFavoritesCount;
            this.Quota = quota;
            this.RepostsCount = repostsCount;
            this.Subscriptions = subscriptions;
            this.TrackCount = trackCount;
            this.UploadSecondsLeft = uploadSecondsLeft;
            this.Uri = uri;
            this.Username = username;
            this.Website = website;
            this.WebsiteTitle = websiteTitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Me" /> class.
        /// </summary>
        public Me()
        {
        }

    }
}