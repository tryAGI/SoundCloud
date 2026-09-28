
#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.ErrorError>))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.ErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.UserSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.UserSubscriptionProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Users))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.User?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Track))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AllOf<global::SoundCloud.User, object>), TypeInfoPropertyName = "AllOfUserObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackAccess), TypeInfoPropertyName = "TrackAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Tracks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.Track>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Playlist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AllOf<object, global::SoundCloud.User>), TypeInfoPropertyName = "AllOfObjectUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Playlists))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.Playlist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksBpm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksCreatedAt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksAcces), TypeInfoPropertyName = "GetTracksAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetPlaylistsAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetPlaylistsAcces), TypeInfoPropertyName = "GetPlaylistsAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>), TypeInfoPropertyName = "OneOfTracksIListTrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>), TypeInfoPropertyName = "OneOfPlaylistsIListPlaylist2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AllOf<global::SoundCloud.User, object>?), TypeInfoPropertyName = "NullableAllOfUserObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackAccess?), TypeInfoPropertyName = "NullableTrackAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AllOf<object, global::SoundCloud.User>?), TypeInfoPropertyName = "NullableAllOfObjectUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksAcces?), TypeInfoPropertyName = "NullableGetTracksAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetPlaylistsAcces?), TypeInfoPropertyName = "NullableGetPlaylistsAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>?), TypeInfoPropertyName = "NullableOneOfTracksIListTrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>?), TypeInfoPropertyName = "NullableOneOfPlaylistsIListPlaylist2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.ErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.User?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.Track>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.Playlist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetPlaylistsAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.List<global::SoundCloud.Track>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.List<global::SoundCloud.Playlist>>))]
    internal sealed partial class SearchSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SearchSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SearchSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::SoundCloud.JsonConverters.AllOfJsonConverter<global::SoundCloud.User, object>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.AllOfJsonConverter<object, global::SoundCloud.User>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.AnyOfJsonConverter<global::SoundCloud.Track, global::SoundCloud.Playlist>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>());
            options.Converters.Add(new global::SoundCloud.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::SoundCloud.TrackAccess)

                    || typeToConvert == typeof(global::SoundCloud.TrackAccess?)

                    || typeToConvert == typeof(global::SoundCloud.GetTracksAcces)

                    || typeToConvert == typeof(global::SoundCloud.GetTracksAcces?)

                    || typeToConvert == typeof(global::SoundCloud.GetPlaylistsAcces)

                    || typeToConvert == typeof(global::SoundCloud.GetPlaylistsAcces?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::SoundCloud.TrackAccess))
                {
                    return new global::SoundCloud.JsonConverters.TrackAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::SoundCloud.TrackAccess?))
                {
                    return new global::SoundCloud.JsonConverters.TrackAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SoundCloud.GetTracksAcces))
                {
                    return new global::SoundCloud.JsonConverters.GetTracksAccesJsonConverter();
                }

                if (typeToConvert == typeof(global::SoundCloud.GetTracksAcces?))
                {
                    return new global::SoundCloud.JsonConverters.GetTracksAccesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SoundCloud.GetPlaylistsAcces))
                {
                    return new global::SoundCloud.JsonConverters.GetPlaylistsAccesJsonConverter();
                }

                if (typeToConvert == typeof(global::SoundCloud.GetPlaylistsAcces?))
                {
                    return new global::SoundCloud.JsonConverters.GetPlaylistsAccesNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SearchSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}