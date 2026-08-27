
#nullable enable

namespace SoundCloud
{
    /// <summary>
    /// public or private
    /// </summary>
    public enum CreateUpdatePlaylistRequestPlaylistSharing
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
    public static class CreateUpdatePlaylistRequestPlaylistSharingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateUpdatePlaylistRequestPlaylistSharing value)
        {
            return value switch
            {
                CreateUpdatePlaylistRequestPlaylistSharing.Private => "private",
                CreateUpdatePlaylistRequestPlaylistSharing.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateUpdatePlaylistRequestPlaylistSharing? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateUpdatePlaylistRequestPlaylistSharing.Private,
                "public" => CreateUpdatePlaylistRequestPlaylistSharing.Public,
                _ => null,
            };
        }
    }
}