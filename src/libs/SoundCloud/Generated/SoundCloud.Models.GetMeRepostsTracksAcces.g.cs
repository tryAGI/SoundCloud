
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMeRepostsTracksAcces
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
    public static class GetMeRepostsTracksAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMeRepostsTracksAcces value)
        {
            return value switch
            {
                GetMeRepostsTracksAcces.Blocked => "blocked",
                GetMeRepostsTracksAcces.Playable => "playable",
                GetMeRepostsTracksAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMeRepostsTracksAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetMeRepostsTracksAcces.Blocked,
                "playable" => GetMeRepostsTracksAcces.Playable,
                "preview" => GetMeRepostsTracksAcces.Preview,
                _ => null,
            };
        }
    }
}