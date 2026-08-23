
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Possible values: no-rights-reserved, all-rights-reserved, cc-by, cc-by-nc, cc-by-nd, cc-by-sa, cc-by-nc-nd, cc-by-nc-sa
    /// </summary>
    public enum TrackMetadataRequestTrackLicense
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
    public static class TrackMetadataRequestTrackLicenseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackMetadataRequestTrackLicense value)
        {
            return value switch
            {
                TrackMetadataRequestTrackLicense.AllRightsReserved => "all-rights-reserved",
                TrackMetadataRequestTrackLicense.CcBy => "cc-by",
                TrackMetadataRequestTrackLicense.CcByNc => "cc-by-nc",
                TrackMetadataRequestTrackLicense.CcByNcNd => "cc-by-nc-nd",
                TrackMetadataRequestTrackLicense.CcByNcSa => "cc-by-nc-sa",
                TrackMetadataRequestTrackLicense.CcByNd => "cc-by-nd",
                TrackMetadataRequestTrackLicense.CcBySa => "cc-by-sa",
                TrackMetadataRequestTrackLicense.NoRightsReserved => "no-rights-reserved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackMetadataRequestTrackLicense? ToEnum(string value)
        {
            return value switch
            {
                "all-rights-reserved" => TrackMetadataRequestTrackLicense.AllRightsReserved,
                "cc-by" => TrackMetadataRequestTrackLicense.CcBy,
                "cc-by-nc" => TrackMetadataRequestTrackLicense.CcByNc,
                "cc-by-nc-nd" => TrackMetadataRequestTrackLicense.CcByNcNd,
                "cc-by-nc-sa" => TrackMetadataRequestTrackLicense.CcByNcSa,
                "cc-by-nd" => TrackMetadataRequestTrackLicense.CcByNd,
                "cc-by-sa" => TrackMetadataRequestTrackLicense.CcBySa,
                "no-rights-reserved" => TrackMetadataRequestTrackLicense.NoRightsReserved,
                _ => null,
            };
        }
    }
}