
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public enum TrackUpdateFormRequestTrackLicense
    {
        /// <summary>
        /// 
        /// </summary>
        AllRightsReserved,
        /// <summary>
        /// 
        /// </summary>
        CcBy,
        /// <summary>
        /// 
        /// </summary>
        CcByNc,
        /// <summary>
        /// 
        /// </summary>
        CcByNcNd,
        /// <summary>
        /// 
        /// </summary>
        CcByNcSa,
        /// <summary>
        /// 
        /// </summary>
        CcByNd,
        /// <summary>
        /// 
        /// </summary>
        CcBySa,
        /// <summary>
        /// 
        /// </summary>
        NoRightsReserved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackUpdateFormRequestTrackLicenseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackUpdateFormRequestTrackLicense value)
        {
            return value switch
            {
                TrackUpdateFormRequestTrackLicense.AllRightsReserved => "all-rights-reserved",
                TrackUpdateFormRequestTrackLicense.CcBy => "cc-by",
                TrackUpdateFormRequestTrackLicense.CcByNc => "cc-by-nc",
                TrackUpdateFormRequestTrackLicense.CcByNcNd => "cc-by-nc-nd",
                TrackUpdateFormRequestTrackLicense.CcByNcSa => "cc-by-nc-sa",
                TrackUpdateFormRequestTrackLicense.CcByNd => "cc-by-nd",
                TrackUpdateFormRequestTrackLicense.CcBySa => "cc-by-sa",
                TrackUpdateFormRequestTrackLicense.NoRightsReserved => "no-rights-reserved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackUpdateFormRequestTrackLicense? ToEnum(string value)
        {
            return value switch
            {
                "all-rights-reserved" => TrackUpdateFormRequestTrackLicense.AllRightsReserved,
                "cc-by" => TrackUpdateFormRequestTrackLicense.CcBy,
                "cc-by-nc" => TrackUpdateFormRequestTrackLicense.CcByNc,
                "cc-by-nc-nd" => TrackUpdateFormRequestTrackLicense.CcByNcNd,
                "cc-by-nc-sa" => TrackUpdateFormRequestTrackLicense.CcByNcSa,
                "cc-by-nd" => TrackUpdateFormRequestTrackLicense.CcByNd,
                "cc-by-sa" => TrackUpdateFormRequestTrackLicense.CcBySa,
                "no-rights-reserved" => TrackUpdateFormRequestTrackLicense.NoRightsReserved,
                _ => null,
            };
        }
    }
}