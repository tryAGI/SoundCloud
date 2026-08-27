#nullable enable

namespace SoundCloud.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateUpdatePlaylistFormRequestPlaylistSharingNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSharing?>
    {
        /// <inheritdoc />
        public override global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSharing? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSharingExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSharing)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSharing?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSharing? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSharingExtensions.ToValueString(value.Value));
            }
        }
    }
}
