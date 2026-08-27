
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// who can embed this track "all", "me", or "none"
    /// </summary>
    public enum TrackMetadataRequestTrackEmbeddableBy
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Me,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackMetadataRequestTrackEmbeddableByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackMetadataRequestTrackEmbeddableBy value)
        {
            return value switch
            {
                TrackMetadataRequestTrackEmbeddableBy.All => "all",
                TrackMetadataRequestTrackEmbeddableBy.Me => "me",
                TrackMetadataRequestTrackEmbeddableBy.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackMetadataRequestTrackEmbeddableBy? ToEnum(string value)
        {
            return value switch
            {
                "all" => TrackMetadataRequestTrackEmbeddableBy.All,
                "me" => TrackMetadataRequestTrackEmbeddableBy.Me,
                "none" => TrackMetadataRequestTrackEmbeddableBy.None,
                _ => null,
            };
        }
    }
}