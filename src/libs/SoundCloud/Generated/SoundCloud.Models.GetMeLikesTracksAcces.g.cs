
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMeLikesTracksAcces
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
    public static class GetMeLikesTracksAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMeLikesTracksAcces value)
        {
            return value switch
            {
                GetMeLikesTracksAcces.Blocked => "blocked",
                GetMeLikesTracksAcces.Playable => "playable",
                GetMeLikesTracksAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMeLikesTracksAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetMeLikesTracksAcces.Blocked,
                "playable" => GetMeLikesTracksAcces.Playable,
                "preview" => GetMeLikesTracksAcces.Preview,
                _ => null,
            };
        }
    }
}