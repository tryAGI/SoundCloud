
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Error), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.ErrorError>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.ErrorError), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.User), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.UserSubscription), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.UserSubscriptionProduct), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Track), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AllOf<global::SoundCloud.User, object>), TypeInfoPropertyName = "AllOfUserObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackAccess), TypeInfoPropertyName = "TrackAccess2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Tracks), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.Track>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Playlist), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AllOf<object, global::SoundCloud.User>), TypeInfoPropertyName = "AllOfObjectUser2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Playlists), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.Playlist>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeRepostsTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeRepostsTracksAcces), TypeInfoPropertyName = "GetMeRepostsTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetUsersRepostsTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetUsersRepostsTracksAcces), TypeInfoPropertyName = "GetUsersRepostsTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>), TypeInfoPropertyName = "OneOfTracksIListTrack2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>), TypeInfoPropertyName = "OneOfPlaylistsIListPlaylist2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AllOf<global::SoundCloud.User, object>?), TypeInfoPropertyName = "NullableAllOfUserObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackAccess?), TypeInfoPropertyName = "NullableTrackAccess2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AllOf<object, global::SoundCloud.User>?), TypeInfoPropertyName = "NullableAllOfObjectUser2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeRepostsTracksAcces?), TypeInfoPropertyName = "NullableGetMeRepostsTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetUsersRepostsTracksAcces?), TypeInfoPropertyName = "NullableGetUsersRepostsTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>?), TypeInfoPropertyName = "NullableOneOfTracksIListTrack2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>?), TypeInfoPropertyName = "NullableOneOfPlaylistsIListPlaylist2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.ErrorError>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.Track>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.Playlist>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeRepostsTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetUsersRepostsTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.List<global::SoundCloud.Track>>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.List<global::SoundCloud.Playlist>>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    internal sealed partial class RepostsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RepostsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RepostsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RepostsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::SoundCloud.GetMeRepostsTracksAcces)

                    || typeToConvert == typeof(global::SoundCloud.GetMeRepostsTracksAcces?)

                    || typeToConvert == typeof(global::SoundCloud.GetUsersRepostsTracksAcces)

                    || typeToConvert == typeof(global::SoundCloud.GetUsersRepostsTracksAcces?);
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

                if (typeToConvert == typeof(global::SoundCloud.GetMeRepostsTracksAcces))
                {
                    return new global::SoundCloud.JsonConverters.GetMeRepostsTracksAccesJsonConverter();
                }

                if (typeToConvert == typeof(global::SoundCloud.GetMeRepostsTracksAcces?))
                {
                    return new global::SoundCloud.JsonConverters.GetMeRepostsTracksAccesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::SoundCloud.GetUsersRepostsTracksAcces))
                {
                    return new global::SoundCloud.JsonConverters.GetUsersRepostsTracksAccesJsonConverter();
                }

                if (typeToConvert == typeof(global::SoundCloud.GetUsersRepostsTracksAcces?))
                {
                    return new global::SoundCloud.JsonConverters.GetUsersRepostsTracksAccesNullableJsonConverter();
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
                    0 => new RepostsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}