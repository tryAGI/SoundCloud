
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetUsersTracksSort
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsersTracksSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsersTracksSort value)
        {
            return value switch
            {
                GetUsersTracksSort.Asc => "asc",
                GetUsersTracksSort.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsersTracksSort? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetUsersTracksSort.Asc,
                "desc" => GetUsersTracksSort.Desc,
                _ => null,
            };
        }
    }
}