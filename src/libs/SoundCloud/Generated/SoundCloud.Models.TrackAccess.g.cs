
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Level of access the user (logged in or anonymous) has to the track.<br/>
    ///   * `playable` - user is allowed to listen to a full track.<br/>
    ///   * `preview` - user is allowed to preview a track, meaning a snippet is available<br/>
    ///   * `blocked` - user can only see the metadata of a track, no streaming is possible
    /// </summary>
    public enum TrackAccess
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
        /// <summary>
        /// 
        /// </summary>
        Playable,
        /// <summary>
        /// 
        /// </summary>
        Preview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackAccess value)
        {
            return value switch
            {
                TrackAccess.Blocked => "blocked",
                TrackAccess.Playable => "playable",
                TrackAccess.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackAccess? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => TrackAccess.Blocked,
                "playable" => TrackAccess.Playable,
                "preview" => TrackAccess.Preview,
                _ => null,
            };
        }
    }
}