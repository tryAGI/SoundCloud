
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMeActivitiesAllOwnAcces
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
    public static class GetMeActivitiesAllOwnAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMeActivitiesAllOwnAcces value)
        {
            return value switch
            {
                GetMeActivitiesAllOwnAcces.Blocked => "blocked",
                GetMeActivitiesAllOwnAcces.Playable => "playable",
                GetMeActivitiesAllOwnAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMeActivitiesAllOwnAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetMeActivitiesAllOwnAcces.Blocked,
                "playable" => GetMeActivitiesAllOwnAcces.Playable,
                "preview" => GetMeActivitiesAllOwnAcces.Preview,
                _ => null,
            };
        }
    }
}