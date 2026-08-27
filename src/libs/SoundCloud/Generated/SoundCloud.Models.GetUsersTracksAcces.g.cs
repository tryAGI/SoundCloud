
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUsersTracksAcces
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
    public static class GetUsersTracksAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsersTracksAcces value)
        {
            return value switch
            {
                GetUsersTracksAcces.Blocked => "blocked",
                GetUsersTracksAcces.Playable => "playable",
                GetUsersTracksAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsersTracksAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetUsersTracksAcces.Blocked,
                "playable" => GetUsersTracksAcces.Playable,
                "preview" => GetUsersTracksAcces.Preview,
                _ => null,
            };
        }
    }
}