
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Default Value: public
    /// </summary>
    public enum TrackDataRequestTrackSharing
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
    public static class TrackDataRequestTrackSharingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackDataRequestTrackSharing value)
        {
            return value switch
            {
                TrackDataRequestTrackSharing.Private => "private",
                TrackDataRequestTrackSharing.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackDataRequestTrackSharing? ToEnum(string value)
        {
            return value switch
            {
                "private" => TrackDataRequestTrackSharing.Private,
                "public" => TrackDataRequestTrackSharing.Public,
                _ => null,
            };
        }
    }
}