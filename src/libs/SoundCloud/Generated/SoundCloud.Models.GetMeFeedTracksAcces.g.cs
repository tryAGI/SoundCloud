
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMeFeedTracksAcces
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
    public static class GetMeFeedTracksAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMeFeedTracksAcces value)
        {
            return value switch
            {
                GetMeFeedTracksAcces.Blocked => "blocked",
                GetMeFeedTracksAcces.Playable => "playable",
                GetMeFeedTracksAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMeFeedTracksAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetMeFeedTracksAcces.Blocked,
                "playable" => GetMeFeedTracksAcces.Playable,
                "preview" => GetMeFeedTracksAcces.Preview,
                _ => null,
            };
        }
    }
}