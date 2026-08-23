
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Default Value: public
    /// </summary>
    public enum TrackMetadataRequestTrackSharing
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
    public static class TrackMetadataRequestTrackSharingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackMetadataRequestTrackSharing value)
        {
            return value switch
            {
                TrackMetadataRequestTrackSharing.Private => "private",
                TrackMetadataRequestTrackSharing.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackMetadataRequestTrackSharing? ToEnum(string value)
        {
            return value switch
            {
                "private" => TrackMetadataRequestTrackSharing.Private,
                "public" => TrackMetadataRequestTrackSharing.Public,
                _ => null,
            };
        }
    }
}