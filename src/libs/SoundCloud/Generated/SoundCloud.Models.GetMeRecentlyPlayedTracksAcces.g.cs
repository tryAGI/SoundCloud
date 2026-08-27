
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMeRecentlyPlayedTracksAcces
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
    public static class GetMeRecentlyPlayedTracksAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMeRecentlyPlayedTracksAcces value)
        {
            return value switch
            {
                GetMeRecentlyPlayedTracksAcces.Blocked => "blocked",
                GetMeRecentlyPlayedTracksAcces.Playable => "playable",
                GetMeRecentlyPlayedTracksAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMeRecentlyPlayedTracksAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetMeRecentlyPlayedTracksAcces.Blocked,
                "playable" => GetMeRecentlyPlayedTracksAcces.Playable,
                "preview" => GetMeRecentlyPlayedTracksAcces.Preview,
                _ => null,
            };
        }
    }
}