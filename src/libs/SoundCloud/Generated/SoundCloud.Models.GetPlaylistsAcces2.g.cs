
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPlaylistsAcces2
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
    public static class GetPlaylistsAcces2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPlaylistsAcces2 value)
        {
            return value switch
            {
                GetPlaylistsAcces2.Blocked => "blocked",
                GetPlaylistsAcces2.Playable => "playable",
                GetPlaylistsAcces2.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPlaylistsAcces2? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetPlaylistsAcces2.Blocked,
                "playable" => GetPlaylistsAcces2.Playable,
                "preview" => GetPlaylistsAcces2.Preview,
                _ => null,
            };
        }
    }
}