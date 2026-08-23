
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMeActivitiesAcces
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
    public static class GetMeActivitiesAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMeActivitiesAcces value)
        {
            return value switch
            {
                GetMeActivitiesAcces.Blocked => "blocked",
                GetMeActivitiesAcces.Playable => "playable",
                GetMeActivitiesAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMeActivitiesAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetMeActivitiesAcces.Blocked,
                "playable" => GetMeActivitiesAcces.Playable,
                "preview" => GetMeActivitiesAcces.Preview,
                _ => null,
            };
        }
    }
}