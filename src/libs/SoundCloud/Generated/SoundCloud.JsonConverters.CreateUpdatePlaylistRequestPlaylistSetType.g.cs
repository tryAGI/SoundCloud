#nullable enable

namespace SoundCloud.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateUpdatePlaylistRequestPlaylistSetTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSetType>
    {
        /// <inheritdoc />
        public override global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSetType Read(
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
                        return global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSetTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSetType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSetType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSetType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSetTypeExtensions.ToValueString(value));
        }
    }
}
