
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Possible values: no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
    /// </summary>
    public enum TrackDataRequestTrackLicense
    {
        /// <summary>
        /// no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
        /// </summary>
        AllRightsReserved,
        /// <summary>
        /// no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
        /// </summary>
        CcBy,
        /// <summary>
        /// no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
        /// </summary>
        CcByNc,
        /// <summary>
        /// no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
        /// </summary>
        CcByNcNd,
        /// <summary>
        /// no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
        /// </summary>
        CcByNcSa,
        /// <summary>
        /// no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
        /// </summary>
        CcByNd,
        /// <summary>
        /// no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
        /// </summary>
        CcBySa,
        /// <summary>
        /// no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
        /// </summary>
        NoRightsReserved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackDataRequestTrackLicenseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackDataRequestTrackLicense value)
        {
            return value switch
            {
                TrackDataRequestTrackLicense.AllRightsReserved => "all-rights-reserved",
                TrackDataRequestTrackLicense.CcBy => "cc-by",
                TrackDataRequestTrackLicense.CcByNc => "cc-by-nc",
                TrackDataRequestTrackLicense.CcByNcNd => "cc-by-nc-nd",
                TrackDataRequestTrackLicense.CcByNcSa => "cc-by-nc-sa",
                TrackDataRequestTrackLicense.CcByNd => "cc-by-nd",
                TrackDataRequestTrackLicense.CcBySa => "cc-by-sa",
                TrackDataRequestTrackLicense.NoRightsReserved => "no-rights-reserved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackDataRequestTrackLicense? ToEnum(string value)
        {
            return value switch
            {
                "all-rights-reserved" => TrackDataRequestTrackLicense.AllRightsReserved,
                "cc-by" => TrackDataRequestTrackLicense.CcBy,
                "cc-by-nc" => TrackDataRequestTrackLicense.CcByNc,
                "cc-by-nc-nd" => TrackDataRequestTrackLicense.CcByNcNd,
                "cc-by-nc-sa" => TrackDataRequestTrackLicense.CcByNcSa,
                "cc-by-nd" => TrackDataRequestTrackLicense.CcByNd,
                "cc-by-sa" => TrackDataRequestTrackLicense.CcBySa,
                "no-rights-reserved" => TrackDataRequestTrackLicense.NoRightsReserved,
                _ => null,
            };
        }
    }
}