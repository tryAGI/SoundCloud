
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OAuthToken
    {
        /// <summary>
        /// One of `authorization_code`, `client_credentials`, `refresh_token`<br/>
        /// Example: authorization_code
        /// </summary>
        /// <example>authorization_code</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::SoundCloud.JsonConverters.OAuthTokenGrantTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::SoundCloud.OAuthTokenGrantType GrantType { get; set; }

        /// <summary>
        /// Client ID<br/>
        /// Example: CLIENT_ID
        /// </summary>
        /// <example>CLIENT_ID</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// Client secret<br/>
        /// Example: CLIENT_SECRET
        /// </summary>
        /// <example>CLIENT_SECRET</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// Authorization code. Required on `grant_type = authorization_code`.<br/>
        /// Example: 1-123456-12345678-FAbcfbe9ir2wdj0
        /// </summary>
        /// <example>1-123456-12345678-FAbcfbe9ir2wdj0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Redirect URI. Required on `grant_type = (authorization_code|refresh_token)`.<br/>
        /// Example: https://mywebsite/auth/soundcloud
        /// </summary>
        /// <example>https://mywebsite/auth/soundcloud</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// Refresh token. Required on `grant_type = refresh_token`.<br/>
        /// Example: 1234c331329477150e7b6056ff212345
        /// </summary>
        /// <example>1234c331329477150e7b6056ff212345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthToken" /> class.
        /// </summary>
        /// <param name="grantType">
        /// One of `authorization_code`, `client_credentials`, `refresh_token`<br/>
        /// Example: authorization_code
        /// </param>
        /// <param name="clientId">
        /// Client ID<br/>
        /// Example: CLIENT_ID
        /// </param>
        /// <param name="clientSecret">
        /// Client secret<br/>
        /// Example: CLIENT_SECRET
        /// </param>
        /// <param name="code">
        /// Authorization code. Required on `grant_type = authorization_code`.<br/>
        /// Example: 1-123456-12345678-FAbcfbe9ir2wdj0
        /// </param>
        /// <param name="redirectUri">
        /// Redirect URI. Required on `grant_type = (authorization_code|refresh_token)`.<br/>
        /// Example: https://mywebsite/auth/soundcloud
        /// </param>
        /// <param name="refreshToken">
        /// Refresh token. Required on `grant_type = refresh_token`.<br/>
        /// Example: 1234c331329477150e7b6056ff212345
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuthToken(
            global::SoundCloud.OAuthTokenGrantType grantType,
            string clientId,
            string clientSecret,
            string? code,
            string? redirectUri,
            string? refreshToken)
        {
            this.GrantType = grantType;
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.Code = code;
            this.RedirectUri = redirectUri;
            this.RefreshToken = refreshToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthToken" /> class.
        /// </summary>
        public OAuthToken()
        {
        }

    }
}