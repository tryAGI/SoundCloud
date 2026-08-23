
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPlaylistsTracksAcces
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
    public static class GetPlaylistsTracksAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPlaylistsTracksAcces value)
        {
            return value switch
            {
                GetPlaylistsTracksAcces.Blocked => "blocked",
                GetPlaylistsTracksAcces.Playable => "playable",
                GetPlaylistsTracksAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPlaylistsTracksAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetPlaylistsTracksAcces.Blocked,
                "playable" => GetPlaylistsTracksAcces.Playable,
                "preview" => GetPlaylistsTracksAcces.Preview,
                _ => null,
            };
        }
    }
}