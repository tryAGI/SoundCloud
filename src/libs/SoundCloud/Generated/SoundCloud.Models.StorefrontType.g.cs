
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// The type of item offered.
    /// </summary>
    public enum StorefrontType
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
    public static class StorefrontTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StorefrontType value)
        {
            return value switch
            {
                StorefrontType.Apparel => "apparel",
                StorefrontType.Cassette => "cassette",
                StorefrontType.Cd => "cd",
                StorefrontType.Digital => "digital",
                StorefrontType.LiveEvent => "live_event",
                StorefrontType.LiveStream => "live_stream",
                StorefrontType.Other => "other",
                StorefrontType.SamplePack => "sample_pack",
                StorefrontType.Subscription => "subscription",
                StorefrontType.Vinyl => "vinyl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StorefrontType? ToEnum(string value)
        {
            return value switch
            {
                "apparel" => StorefrontType.Apparel,
                "cassette" => StorefrontType.Cassette,
                "cd" => StorefrontType.Cd,
                "digital" => StorefrontType.Digital,
                "live_event" => StorefrontType.LiveEvent,
                "live_stream" => StorefrontType.LiveStream,
                "other" => StorefrontType.Other,
                "sample_pack" => StorefrontType.SamplePack,
                "subscription" => StorefrontType.Subscription,
                "vinyl" => StorefrontType.Vinyl,
                _ => null,
            };
        }
    }
}