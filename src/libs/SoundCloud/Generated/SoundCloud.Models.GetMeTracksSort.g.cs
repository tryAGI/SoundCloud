
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetMeTracksSort
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
    public static class GetMeTracksSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMeTracksSort value)
        {
            return value switch
            {
                GetMeTracksSort.Asc => "asc",
                GetMeTracksSort.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMeTracksSort? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetMeTracksSort.Asc,
                "desc" => GetMeTracksSort.Desc,
                _ => null,
            };
        }
    }
}