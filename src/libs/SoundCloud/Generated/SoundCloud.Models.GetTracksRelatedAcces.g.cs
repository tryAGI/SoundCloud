
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTracksRelatedAcces
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
    public static class GetTracksRelatedAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTracksRelatedAcces value)
        {
            return value switch
            {
                GetTracksRelatedAcces.Blocked => "blocked",
                GetTracksRelatedAcces.Playable => "playable",
                GetTracksRelatedAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTracksRelatedAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetTracksRelatedAcces.Blocked,
                "playable" => GetTracksRelatedAcces.Playable,
                "preview" => GetTracksRelatedAcces.Preview,
                _ => null,
            };
        }
    }
}