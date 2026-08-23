#nullable enable

namespace SoundCloud.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetUsersLikesTracksAccesNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SoundCloud.GetUsersLikesTracksAcces?>
    {
        /// <inheritdoc />
        public override global::SoundCloud.GetUsersLikesTracksAcces? Read(
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
                        return global::SoundCloud.GetUsersLikesTracksAccesExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SoundCloud.GetUsersLikesTracksAcces)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SoundCloud.GetUsersLikesTracksAcces?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SoundCloud.GetUsersLikesTracksAcces? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::SoundCloud.GetUsersLikesTracksAccesExtensions.ToValueString(value.Value));
            }
        }
    }
}
