#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace SoundCloud.JsonConverters
{
    /// <inheritdoc />
    public class TooManyRequestsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::SoundCloud.TooManyRequests>
    {
        /// <inheritdoc />
        public override global::SoundCloud.TooManyRequests Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("code")) __score0++;
            if (__jsonProps.Contains("error")) __score0++;
            if (__jsonProps.Contains("errors")) __score0++;
            if (__jsonProps.Contains("link")) __score0++;
            if (__jsonProps.Contains("message")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("spam_warning_urn")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::SoundCloud.Error? error = default;
            global::SoundCloud.TooManyRequestsVariant2? tooManyRequestsVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SoundCloud.Error), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SoundCloud.Error> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SoundCloud.Error).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SoundCloud.TooManyRequestsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SoundCloud.TooManyRequestsVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SoundCloud.TooManyRequestsVariant2).Name}");
                        tooManyRequestsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (error == null && tooManyRequestsVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SoundCloud.Error), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SoundCloud.Error> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SoundCloud.Error).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (error == null && tooManyRequestsVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SoundCloud.TooManyRequestsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SoundCloud.TooManyRequestsVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SoundCloud.TooManyRequestsVariant2).Name}");
                    tooManyRequestsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::SoundCloud.TooManyRequests(
                error,

                tooManyRequestsVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::SoundCloud.TooManyRequests value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SoundCloud.Error), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SoundCloud.Error?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SoundCloud.Error).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsTooManyRequestsVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::SoundCloud.TooManyRequestsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::SoundCloud.TooManyRequestsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::SoundCloud.TooManyRequestsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TooManyRequestsVariant2!, typeInfo);
            }
        }
    }
}