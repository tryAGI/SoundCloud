#nullable enable

namespace SoundCloud.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetPlaylistsTracksAccesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SoundCloud.GetPlaylistsTracksAcces>
    {
        /// <inheritdoc />
        public override global::SoundCloud.GetPlaylistsTracksAcces Read(
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
                        return global::SoundCloud.GetPlaylistsTracksAccesExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SoundCloud.GetPlaylistsTracksAcces)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SoundCloud.GetPlaylistsTracksAcces);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SoundCloud.GetPlaylistsTracksAcces value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::SoundCloud.GetPlaylistsTracksAccesExtensions.ToValueString(value));
        }
    }
}
