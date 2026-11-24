
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Identifies a per-uploader track creation limit, as opposed to an app rate limit.
    /// </summary>
    public enum TrackCreationLimitedVariant2ErrorCode
    {
        /// <summary>
        ///
        /// </summary>
        TrackCreationLimitReached,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackCreationLimitedVariant2ErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackCreationLimitedVariant2ErrorCode value)
        {
            return value switch
            {
                TrackCreationLimitedVariant2ErrorCode.TrackCreationLimitReached => "track_creation_limit_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackCreationLimitedVariant2ErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "track_creation_limit_reached" => TrackCreationLimitedVariant2ErrorCode.TrackCreationLimitReached,
                _ => null,
            };
        }
    }
}