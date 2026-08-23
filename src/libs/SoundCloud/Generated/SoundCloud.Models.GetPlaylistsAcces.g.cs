
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPlaylistsAcces
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
    public static class GetPlaylistsAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPlaylistsAcces value)
        {
            return value switch
            {
                GetPlaylistsAcces.Blocked => "blocked",
                GetPlaylistsAcces.Playable => "playable",
                GetPlaylistsAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPlaylistsAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetPlaylistsAcces.Blocked,
                "playable" => GetPlaylistsAcces.Playable,
                "preview" => GetPlaylistsAcces.Preview,
                _ => null,
            };
        }
    }
}