
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetUsersPlaylistsAcces
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
        /// <summary>
        /// 
        /// </summary>
        Playable,
        /// <summary>
        /// 
        /// </summary>
        Preview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsersPlaylistsAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsersPlaylistsAcces value)
        {
            return value switch
            {
                GetUsersPlaylistsAcces.Blocked => "blocked",
                GetUsersPlaylistsAcces.Playable => "playable",
                GetUsersPlaylistsAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsersPlaylistsAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetUsersPlaylistsAcces.Blocked,
                "playable" => GetUsersPlaylistsAcces.Playable,
                "preview" => GetUsersPlaylistsAcces.Preview,
                _ => null,
            };
        }
    }
}