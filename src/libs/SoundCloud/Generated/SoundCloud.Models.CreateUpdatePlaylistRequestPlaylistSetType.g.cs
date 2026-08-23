
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Playlist or album type
    /// </summary>
    public enum CreateUpdatePlaylistRequestPlaylistSetType
    {
        /// <summary>
        /// 
        /// </summary>
        Album,
        /// <summary>
        /// 
        /// </summary>
        Playlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateUpdatePlaylistRequestPlaylistSetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateUpdatePlaylistRequestPlaylistSetType value)
        {
            return value switch
            {
                CreateUpdatePlaylistRequestPlaylistSetType.Album => "album",
                CreateUpdatePlaylistRequestPlaylistSetType.Playlist => "playlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateUpdatePlaylistRequestPlaylistSetType? ToEnum(string value)
        {
            return value switch
            {
                "album" => CreateUpdatePlaylistRequestPlaylistSetType.Album,
                "playlist" => CreateUpdatePlaylistRequestPlaylistSetType.Playlist,
                _ => null,
            };
        }
    }
}