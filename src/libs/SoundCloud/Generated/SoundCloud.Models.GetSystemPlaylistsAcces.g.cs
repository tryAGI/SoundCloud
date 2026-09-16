
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSystemPlaylistsAcces
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
    public static class GetSystemPlaylistsAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSystemPlaylistsAcces value)
        {
            return value switch
            {
                GetSystemPlaylistsAcces.Blocked => "blocked",
                GetSystemPlaylistsAcces.Playable => "playable",
                GetSystemPlaylistsAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSystemPlaylistsAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetSystemPlaylistsAcces.Blocked,
                "playable" => GetSystemPlaylistsAcces.Playable,
                "preview" => GetSystemPlaylistsAcces.Preview,
                _ => null,
            };
        }
    }
}