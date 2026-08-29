
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
            typeof(global::SoundCloud.JsonConverters.OAuthTokenGrantTypeJsonConverter),

            typeof(global::SoundCloud.JsonConverters.OAuthTokenGrantTypeNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackMetadataRequestTrackSharingJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackMetadataRequestTrackSharingNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackMetadataRequestTrackEmbeddableByJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackMetadataRequestTrackEmbeddableByNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackMetadataRequestTrackLicenseJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackMetadataRequestTrackLicenseNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.StorefrontTypeJsonConverter),

            typeof(global::SoundCloud.JsonConverters.StorefrontTypeNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.StorefrontUpdateRequestTypeJsonConverter),

            typeof(global::SoundCloud.JsonConverters.StorefrontUpdateRequestTypeNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.CreateUpdatePlaylistRequestPlaylistSharingJsonConverter),

            typeof(global::SoundCloud.JsonConverters.CreateUpdatePlaylistRequestPlaylistSharingNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.CreateUpdatePlaylistRequestPlaylistSetTypeJsonConverter),

            typeof(global::SoundCloud.JsonConverters.CreateUpdatePlaylistRequestPlaylistSetTypeNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.CreateUpdatePlaylistFormRequestPlaylistSharingJsonConverter),

            typeof(global::SoundCloud.JsonConverters.CreateUpdatePlaylistFormRequestPlaylistSharingNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.CreateUpdatePlaylistFormRequestPlaylistSetTypeJsonConverter),

            typeof(global::SoundCloud.JsonConverters.CreateUpdatePlaylistFormRequestPlaylistSetTypeNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackDataRequestTrackSharingJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackDataRequestTrackSharingNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackDataRequestTrackEmbeddableByJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackDataRequestTrackEmbeddableByNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackDataRequestTrackLicenseJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackDataRequestTrackLicenseNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackUpdateFormRequestTrackSharingJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackUpdateFormRequestTrackSharingNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackUpdateFormRequestTrackEmbeddableByJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackUpdateFormRequestTrackEmbeddableByNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackUpdateFormRequestTrackLicenseJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackUpdateFormRequestTrackLicenseNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackAccessJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TrackAccessNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeActivitiesAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeActivitiesAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeActivitiesAllOwnAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeActivitiesAllOwnAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeActivitiesTracksAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeActivitiesTracksAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeFeedAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeFeedAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeFeedTracksAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeFeedTracksAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeRecentlyPlayedTracksAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeRecentlyPlayedTracksAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeLikesTracksAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeLikesTracksAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeFollowingsTracksAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeFollowingsTracksAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeTracksSortJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeTracksSortNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeRepostsTracksAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetMeRepostsTracksAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetTracksAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetTracksAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetPlaylistsAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetPlaylistsAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetPlaylistsAcces2JsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetPlaylistsAcces2NullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetPlaylistsTracksAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetPlaylistsTracksAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetTracksRelatedAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetTracksRelatedAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetUsersPlaylistsAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetUsersPlaylistsAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetUsersTracksAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetUsersTracksAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetUsersTracksSortJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetUsersTracksSortNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetUsersLikesTracksAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetUsersLikesTracksAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetUsersRepostsTracksAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetUsersRepostsTracksAccesNullableJsonConverter),

            typeof(global::SoundCloud.JsonConverters.TooManyRequestsJsonConverter),

            typeof(global::SoundCloud.JsonConverters.AllOfJsonConverter<global::SoundCloud.User, object>),

            typeof(global::SoundCloud.JsonConverters.AllOfJsonConverter<object, global::SoundCloud.User>),

            typeof(global::SoundCloud.JsonConverters.AnyOfJsonConverter<global::SoundCloud.Track, global::SoundCloud.Playlist>),

            typeof(global::SoundCloud.JsonConverters.AllOfJsonConverter<global::SoundCloud.TrackDataRequest, object>),

            typeof(global::SoundCloud.JsonConverters.AllOfJsonConverter<global::SoundCloud.TrackDataRequest, object>),

            typeof(global::SoundCloud.JsonConverters.AllOfJsonConverter<global::SoundCloud.CreateUpdatePlaylistFormRequest, object>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>),

            typeof(global::SoundCloud.JsonConverters.OneOfJsonConverter<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>),

            typeof(global::SoundCloud.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OAuthToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OAuthTokenGrantType), TypeInfoPropertyName = "OAuthTokenGrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackMetadataRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackMetadataRequestTrack), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackMetadataRequestTrackSharing), TypeInfoPropertyName = "TrackMetadataRequestTrackSharing2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackMetadataRequestTrackEmbeddableBy), TypeInfoPropertyName = "TrackMetadataRequestTrackEmbeddableBy2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackMetadataRequestTrackLicense), TypeInfoPropertyName = "TrackMetadataRequestTrackLicense2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Storefront), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.StorefrontType), TypeInfoPropertyName = "StorefrontType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.StorefrontUpdateRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.StorefrontUpdateRequestType), TypeInfoPropertyName = "StorefrontUpdateRequestType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistRequestPlaylist), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSharing), TypeInfoPropertyName = "CreateUpdatePlaylistRequestPlaylistSharing2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.CreateUpdatePlaylistRequestPlaylistTrack>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistRequestPlaylistTrack), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSetType), TypeInfoPropertyName = "CreateUpdatePlaylistRequestPlaylistSetType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistFormRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSharing), TypeInfoPropertyName = "CreateUpdatePlaylistFormRequestPlaylistSharing2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSetType), TypeInfoPropertyName = "CreateUpdatePlaylistFormRequestPlaylistSetType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackDataRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackDataRequestTrackSharing), TypeInfoPropertyName = "TrackDataRequestTrackSharing2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackDataRequestTrackEmbeddableBy), TypeInfoPropertyName = "TrackDataRequestTrackEmbeddableBy2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackDataRequestTrackLicense), TypeInfoPropertyName = "TrackDataRequestTrackLicense2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackUpdateFormRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackUpdateFormRequestTrackSharing), TypeInfoPropertyName = "TrackUpdateFormRequestTrackSharing2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackUpdateFormRequestTrackEmbeddableBy), TypeInfoPropertyName = "TrackUpdateFormRequestTrackEmbeddableBy2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackUpdateFormRequestTrackLicense), TypeInfoPropertyName = "TrackUpdateFormRequestTrackLicense2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Found), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Error), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.ErrorError>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.ErrorError), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TooManyRequests), TypeInfoPropertyName = "TooManyRequests2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TooManyRequestsVariant2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.User), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.UserSubscription), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.UserSubscriptionProduct), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Me), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.MeQuota), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.MeSubscription), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.MeSubscriptionProduct), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Users), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.User?>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Activities), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.ActivitiesCollectionItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.ActivitiesCollectionItem), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AnyOf<global::SoundCloud.Track, global::SoundCloud.Playlist>), TypeInfoPropertyName = "AnyOfTrackPlaylist2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.WebProfile>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.WebProfile), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Comment), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CommentUser), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Comments), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.Comment>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Streams), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AllOf<global::SoundCloud.TrackDataRequest, object>), TypeInfoPropertyName = "AllOfTrackDataRequestObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AllOf<global::SoundCloud.CreateUpdatePlaylistFormRequest, object>), TypeInfoPropertyName = "AllOfCreateUpdatePlaylistFormRequestObject2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateTracksCommentsRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateTracksCommentsRequestComment), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<string, double?>), TypeInfoPropertyName = "OneOfStringDouble2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeActivitiesAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeActivitiesAcces), TypeInfoPropertyName = "GetMeActivitiesAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeActivitiesAllOwnAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeActivitiesAllOwnAcces), TypeInfoPropertyName = "GetMeActivitiesAllOwnAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeActivitiesTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeActivitiesTracksAcces), TypeInfoPropertyName = "GetMeActivitiesTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeFeedAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeFeedAcces), TypeInfoPropertyName = "GetMeFeedAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeFeedTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeFeedTracksAcces), TypeInfoPropertyName = "GetMeFeedTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeRecentlyPlayedTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeRecentlyPlayedTracksAcces), TypeInfoPropertyName = "GetMeRecentlyPlayedTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeLikesTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeLikesTracksAcces), TypeInfoPropertyName = "GetMeLikesTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeFollowingsTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeFollowingsTracksAcces), TypeInfoPropertyName = "GetMeFollowingsTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeTracksSort), TypeInfoPropertyName = "GetMeTracksSort2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeRepostsTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeRepostsTracksAcces), TypeInfoPropertyName = "GetMeRepostsTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksBpm), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksDuration), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksCreatedAt), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksAcces), TypeInfoPropertyName = "GetTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetPlaylistsAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetPlaylistsAcces), TypeInfoPropertyName = "GetPlaylistsAcces2_3", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetPlaylistsAcces2>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetPlaylistsAcces2), TypeInfoPropertyName = "GetPlaylistsAcces22", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetPlaylistsTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetPlaylistsTracksAcces), TypeInfoPropertyName = "GetPlaylistsTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetTracksRelatedAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksRelatedAcces), TypeInfoPropertyName = "GetTracksRelatedAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetUsersPlaylistsAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetUsersPlaylistsAcces), TypeInfoPropertyName = "GetUsersPlaylistsAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetUsersTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetUsersTracksAcces), TypeInfoPropertyName = "GetUsersTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetUsersTracksSort), TypeInfoPropertyName = "GetUsersTracksSort2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetUsersLikesTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetUsersLikesTracksAcces), TypeInfoPropertyName = "GetUsersLikesTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetUsersRepostsTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetUsersRepostsTracksAcces), TypeInfoPropertyName = "GetUsersRepostsTracksAcces2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>), TypeInfoPropertyName = "OneOfTracksIListTrack2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>), TypeInfoPropertyName = "OneOfPlaylistsIListPlaylist2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.CreateUpdatePlaylistRequestPlaylistTrack>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.ErrorError>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.User?>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.Track>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.Playlist>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.ActivitiesCollectionItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.WebProfile>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.Comment>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeActivitiesAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeActivitiesAllOwnAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeActivitiesTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeFeedAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeFeedTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeRecentlyPlayedTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeLikesTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeFollowingsTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeRepostsTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetPlaylistsAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetPlaylistsAcces2>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetPlaylistsTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetTracksRelatedAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetUsersPlaylistsAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetUsersTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetUsersLikesTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetUsersRepostsTracksAcces>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.List<global::SoundCloud.Track>>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.List<global::SoundCloud.Playlist>>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}