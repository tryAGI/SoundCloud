
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateUpdatePlaylistFormRequestPlaylistSetType
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
    public static class CreateUpdatePlaylistFormRequestPlaylistSetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateUpdatePlaylistFormRequestPlaylistSetType value)
        {
            return value switch
            {
                CreateUpdatePlaylistFormRequestPlaylistSetType.Album => "album",
                CreateUpdatePlaylistFormRequestPlaylistSetType.Playlist => "playlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateUpdatePlaylistFormRequestPlaylistSetType? ToEnum(string value)
        {
            return value switch
            {
                "album" => CreateUpdatePlaylistFormRequestPlaylistSetType.Album,
                "playlist" => CreateUpdatePlaylistFormRequestPlaylistSetType.Playlist,
                _ => null,
            };
        }
    }
}