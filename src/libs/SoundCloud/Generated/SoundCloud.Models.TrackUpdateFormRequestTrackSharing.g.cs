
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Default Value: public
    /// </summary>
    public enum TrackUpdateFormRequestTrackSharing
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackUpdateFormRequestTrackSharingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackUpdateFormRequestTrackSharing value)
        {
            return value switch
            {
                TrackUpdateFormRequestTrackSharing.Private => "private",
                TrackUpdateFormRequestTrackSharing.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackUpdateFormRequestTrackSharing? ToEnum(string value)
        {
            return value switch
            {
                "private" => TrackUpdateFormRequestTrackSharing.Private,
                "public" => TrackUpdateFormRequestTrackSharing.Public,
                _ => null,
            };
        }
    }
}