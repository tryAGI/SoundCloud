#nullable enable

namespace SoundCloud.JsonConverters
{
    /// <inheritdoc />
    public sealed class TrackDataRequestTrackEmbeddableByNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SoundCloud.TrackDataRequestTrackEmbeddableBy?>
    {
        /// <inheritdoc />
        public override global::SoundCloud.TrackDataRequestTrackEmbeddableBy? Read(
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
                        return global::SoundCloud.TrackDataRequestTrackEmbeddableByExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::SoundCloud.TrackDataRequestTrackEmbeddableBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::SoundCloud.TrackDataRequestTrackEmbeddableBy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SoundCloud.TrackDataRequestTrackEmbeddableBy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::SoundCloud.TrackDataRequestTrackEmbeddableByExtensions.ToValueString(value.Value));
            }
        }
    }
}
