
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMeFeedAcces
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
    public static class GetMeFeedAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMeFeedAcces value)
        {
            return value switch
            {
                GetMeFeedAcces.Blocked => "blocked",
                GetMeFeedAcces.Playable => "playable",
                GetMeFeedAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMeFeedAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetMeFeedAcces.Blocked,
                "playable" => GetMeFeedAcces.Playable,
                "preview" => GetMeFeedAcces.Preview,
                _ => null,
            };
        }
    }
}