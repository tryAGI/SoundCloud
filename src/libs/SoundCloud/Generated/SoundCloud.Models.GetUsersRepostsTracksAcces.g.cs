
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetUsersRepostsTracksAcces
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
    public static class GetUsersRepostsTracksAccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsersRepostsTracksAcces value)
        {
            return value switch
            {
                GetUsersRepostsTracksAcces.Blocked => "blocked",
                GetUsersRepostsTracksAcces.Playable => "playable",
                GetUsersRepostsTracksAcces.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsersRepostsTracksAcces? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GetUsersRepostsTracksAcces.Blocked,
                "playable" => GetUsersRepostsTracksAcces.Playable,
                "preview" => GetUsersRepostsTracksAcces.Preview,
                _ => null,
            };
        }
    }
}