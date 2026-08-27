
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// The type of item offered.
    /// </summary>
    public enum StorefrontUpdateRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Apparel,
        /// <summary>
        ///
        /// </summary>
        Cassette,
        /// <summary>
        ///
        /// </summary>
        Cd,
        /// <summary>
        ///
        /// </summary>
        Digital,
        /// <summary>
        ///
        /// </summary>
        LiveEvent,
        /// <summary>
        ///
        /// </summary>
        LiveStream,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        SamplePack,
        /// <summary>
        ///
        /// </summary>
        Subscription,
        /// <summary>
        ///
        /// </summary>
        Vinyl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StorefrontUpdateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StorefrontUpdateRequestType value)
        {
            return value switch
            {
                StorefrontUpdateRequestType.Apparel => "apparel",
                StorefrontUpdateRequestType.Cassette => "cassette",
                StorefrontUpdateRequestType.Cd => "cd",
                StorefrontUpdateRequestType.Digital => "digital",
                StorefrontUpdateRequestType.LiveEvent => "live_event",
                StorefrontUpdateRequestType.LiveStream => "live_stream",
                StorefrontUpdateRequestType.Other => "other",
                StorefrontUpdateRequestType.SamplePack => "sample_pack",
                StorefrontUpdateRequestType.Subscription => "subscription",
                StorefrontUpdateRequestType.Vinyl => "vinyl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StorefrontUpdateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "apparel" => StorefrontUpdateRequestType.Apparel,
                "cassette" => StorefrontUpdateRequestType.Cassette,
                "cd" => StorefrontUpdateRequestType.Cd,
                "digital" => StorefrontUpdateRequestType.Digital,
                "live_event" => StorefrontUpdateRequestType.LiveEvent,
                "live_stream" => StorefrontUpdateRequestType.LiveStream,
                "other" => StorefrontUpdateRequestType.Other,
                "sample_pack" => StorefrontUpdateRequestType.SamplePack,
                "subscription" => StorefrontUpdateRequestType.Subscription,
                "vinyl" => StorefrontUpdateRequestType.Vinyl,
                _ => null,
            };
        }
    }
}