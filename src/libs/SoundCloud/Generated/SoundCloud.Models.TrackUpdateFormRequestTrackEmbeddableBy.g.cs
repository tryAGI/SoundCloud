
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// who can embed this track "all", "me", or "none"
    /// </summary>
    public enum TrackUpdateFormRequestTrackEmbeddableBy
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
    public static class TrackUpdateFormRequestTrackEmbeddableByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackUpdateFormRequestTrackEmbeddableBy value)
        {
            return value switch
            {
                TrackUpdateFormRequestTrackEmbeddableBy.All => "all",
                TrackUpdateFormRequestTrackEmbeddableBy.Me => "me",
                TrackUpdateFormRequestTrackEmbeddableBy.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackUpdateFormRequestTrackEmbeddableBy? ToEnum(string value)
        {
            return value switch
            {
                "all" => TrackUpdateFormRequestTrackEmbeddableBy.All,
                "me" => TrackUpdateFormRequestTrackEmbeddableBy.Me,
                "none" => TrackUpdateFormRequestTrackEmbeddableBy.None,
                _ => null,
            };
        }
    }
}