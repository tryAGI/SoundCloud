
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// One of `authorization_code`, `client_credentials`, `refresh_token`<br/>
    /// Example: authorization_code
    /// </summary>
    public enum OAuthTokenGrantType
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationCode,
        /// <summary>
        /// 
        /// </summary>
        ClientCredentials,
        /// <summary>
        /// 
        /// </summary>
        RefreshToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuthTokenGrantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuthTokenGrantType value)
        {
            return value switch
            {
                OAuthTokenGrantType.AuthorizationCode => "authorization_code",
                OAuthTokenGrantType.ClientCredentials => "client_credentials",
                OAuthTokenGrantType.RefreshToken => "refresh_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuthTokenGrantType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_code" => OAuthTokenGrantType.AuthorizationCode,
                "client_credentials" => OAuthTokenGrantType.ClientCredentials,
                "refresh_token" => OAuthTokenGrantType.RefreshToken,
                _ => null,
            };
        }
    }
}