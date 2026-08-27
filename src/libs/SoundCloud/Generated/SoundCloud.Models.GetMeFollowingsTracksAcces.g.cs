
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMeFollowingsTracksAcces
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
    public static class GetMeFollowingsTracksAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMeFollowingsTracksAcces value)
        {
            return value switch
            {
                GetMeFollowingsTracksAcces.Blocked => "blocked",
                GetMeFollowingsTracksAcces.Playable => "playable",
                GetMeFollowingsTracksAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMeFollowingsTracksAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetMeFollowingsTracksAcces.Blocked,
                "playable" => GetMeFollowingsTracksAcces.Playable,
                "preview" => GetMeFollowingsTracksAcces.Preview,
                _ => null,
            };
        }
    }
}