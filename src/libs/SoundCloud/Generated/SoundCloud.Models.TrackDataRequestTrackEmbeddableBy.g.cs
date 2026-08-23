
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// who can embed this track "all", "me", or "none"
    /// </summary>
    public enum TrackDataRequestTrackEmbeddableBy
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
    public static class TrackDataRequestTrackEmbeddableByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackDataRequestTrackEmbeddableBy value)
        {
            return value switch
            {
                TrackDataRequestTrackEmbeddableBy.All => "all",
                TrackDataRequestTrackEmbeddableBy.Me => "me",
                TrackDataRequestTrackEmbeddableBy.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackDataRequestTrackEmbeddableBy? ToEnum(string value)
        {
            return value switch
            {
                "all" => TrackDataRequestTrackEmbeddableBy.All,
                "me" => TrackDataRequestTrackEmbeddableBy.Me,
                "none" => TrackDataRequestTrackEmbeddableBy.None,
                _ => null,
            };
        }
    }
}