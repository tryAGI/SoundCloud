
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMeActivitiesTracksAcces
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
    public static class GetMeActivitiesTracksAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMeActivitiesTracksAcces value)
        {
            return value switch
            {
                GetMeActivitiesTracksAcces.Blocked => "blocked",
                GetMeActivitiesTracksAcces.Playable => "playable",
                GetMeActivitiesTracksAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMeActivitiesTracksAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetMeActivitiesTracksAcces.Blocked,
                "playable" => GetMeActivitiesTracksAcces.Playable,
                "preview" => GetMeActivitiesTracksAcces.Preview,
                _ => null,
            };
        }
    }
}