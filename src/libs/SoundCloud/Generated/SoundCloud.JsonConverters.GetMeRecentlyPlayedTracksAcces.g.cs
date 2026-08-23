#nullable enable

namespace SoundCloud.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetMeRecentlyPlayedTracksAccesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SoundCloud.GetMeRecentlyPlayedTracksAcces>
    {
        /// <inheritdoc />
        public override global::SoundCloud.GetMeRecentlyPlayedTracksAcces Read(
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
                        return global::SoundCloud.GetMeRecentlyPlayedTracksAccesExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SoundCloud.GetMeRecentlyPlayedTracksAcces)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SoundCloud.GetMeRecentlyPlayedTracksAcces);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SoundCloud.GetMeRecentlyPlayedTracksAcces value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::SoundCloud.GetMeRecentlyPlayedTracksAccesExtensions.ToValueString(value));
        }
    }
}
