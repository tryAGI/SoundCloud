
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// Default Value: public
    /// </summary>
    public enum CreateUpdatePlaylistFormRequestPlaylistSharing
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateUpdatePlaylistFormRequestPlaylistSharingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateUpdatePlaylistFormRequestPlaylistSharing value)
        {
            return value switch
            {
                CreateUpdatePlaylistFormRequestPlaylistSharing.Private => "private",
                CreateUpdatePlaylistFormRequestPlaylistSharing.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateUpdatePlaylistFormRequestPlaylistSharing? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateUpdatePlaylistFormRequestPlaylistSharing.Private,
                "public" => CreateUpdatePlaylistFormRequestPlaylistSharing.Public,
                _ => null,
            };
        }
    }
}