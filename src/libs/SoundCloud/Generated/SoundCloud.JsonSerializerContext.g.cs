
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
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata,
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

            typeof(global::SoundCloud.JsonConverters.GetSystemPlaylistsAccesJsonConverter),

            typeof(global::SoundCloud.JsonConverters.GetSystemPlaylistsAccesNullableJsonConverter),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackMetadataRequestTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackMetadataRequestTrackSharing), TypeInfoPropertyName = "TrackMetadataRequestTrackSharing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackMetadataRequestTrackEmbeddableBy), TypeInfoPropertyName = "TrackMetadataRequestTrackEmbeddableBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackMetadataRequestTrackLicense), TypeInfoPropertyName = "TrackMetadataRequestTrackLicense2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Storefront))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.StorefrontType), TypeInfoPropertyName = "StorefrontType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.StorefrontUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.StorefrontUpdateRequestType), TypeInfoPropertyName = "StorefrontUpdateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistRequestPlaylist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSharing), TypeInfoPropertyName = "CreateUpdatePlaylistRequestPlaylistSharing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.CreateUpdatePlaylistRequestPlaylistTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistRequestPlaylistTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSetType), TypeInfoPropertyName = "CreateUpdatePlaylistRequestPlaylistSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistFormRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSharing), TypeInfoPropertyName = "CreateUpdatePlaylistFormRequestPlaylistSharing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSetType), TypeInfoPropertyName = "CreateUpdatePlaylistFormRequestPlaylistSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackDataRequestTrackSharing), TypeInfoPropertyName = "TrackDataRequestTrackSharing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackDataRequestTrackEmbeddableBy), TypeInfoPropertyName = "TrackDataRequestTrackEmbeddableBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackDataRequestTrackLicense), TypeInfoPropertyName = "TrackDataRequestTrackLicense2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackUpdateFormRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackUpdateFormRequestTrackSharing), TypeInfoPropertyName = "TrackUpdateFormRequestTrackSharing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackUpdateFormRequestTrackEmbeddableBy), TypeInfoPropertyName = "TrackUpdateFormRequestTrackEmbeddableBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TrackUpdateFormRequestTrackLicense), TypeInfoPropertyName = "TrackUpdateFormRequestTrackLicense2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Found))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.ErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.ErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TooManyRequests), TypeInfoPropertyName = "TooManyRequests2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.TooManyRequestsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.UserSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.UserSubscriptionProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Me))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.MeQuota))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.MeSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.MeSubscriptionProduct))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.SystemPlaylist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Playlists))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.Playlist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Activities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.ActivitiesCollectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.ActivitiesCollectionItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AnyOf<global::SoundCloud.Track, global::SoundCloud.Playlist>), TypeInfoPropertyName = "AnyOfTrackPlaylist2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.WebProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.WebProfile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Comment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CommentUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Comments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.Streams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AllOf<global::SoundCloud.TrackDataRequest, object>), TypeInfoPropertyName = "AllOfTrackDataRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.AllOf<global::SoundCloud.CreateUpdatePlaylistFormRequest, object>), TypeInfoPropertyName = "AllOfCreateUpdatePlaylistFormRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateTracksCommentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.CreateTracksCommentsRequestComment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<string, double?>), TypeInfoPropertyName = "OneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeActivitiesAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeActivitiesAcces), TypeInfoPropertyName = "GetMeActivitiesAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeActivitiesAllOwnAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeActivitiesAllOwnAcces), TypeInfoPropertyName = "GetMeActivitiesAllOwnAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeActivitiesTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeActivitiesTracksAcces), TypeInfoPropertyName = "GetMeActivitiesTracksAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeFeedAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeFeedAcces), TypeInfoPropertyName = "GetMeFeedAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeFeedTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeFeedTracksAcces), TypeInfoPropertyName = "GetMeFeedTracksAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeRecentlyPlayedTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeRecentlyPlayedTracksAcces), TypeInfoPropertyName = "GetMeRecentlyPlayedTracksAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeLikesTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeLikesTracksAcces), TypeInfoPropertyName = "GetMeLikesTracksAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeFollowingsTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeFollowingsTracksAcces), TypeInfoPropertyName = "GetMeFollowingsTracksAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeTracksSort), TypeInfoPropertyName = "GetMeTracksSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetMeRepostsTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetMeRepostsTracksAcces), TypeInfoPropertyName = "GetMeRepostsTracksAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksBpm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksCreatedAt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksAcces), TypeInfoPropertyName = "GetTracksAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetPlaylistsAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetPlaylistsAcces), TypeInfoPropertyName = "GetPlaylistsAcces2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetPlaylistsAcces2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetPlaylistsAcces2), TypeInfoPropertyName = "GetPlaylistsAcces22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetPlaylistsTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetPlaylistsTracksAcces), TypeInfoPropertyName = "GetPlaylistsTracksAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetTracksRelatedAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetTracksRelatedAcces), TypeInfoPropertyName = "GetTracksRelatedAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetSystemPlaylistsAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetSystemPlaylistsAcces), TypeInfoPropertyName = "GetSystemPlaylistsAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetUsersPlaylistsAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetUsersPlaylistsAcces), TypeInfoPropertyName = "GetUsersPlaylistsAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetUsersTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetUsersTracksAcces), TypeInfoPropertyName = "GetUsersTracksAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetUsersTracksSort), TypeInfoPropertyName = "GetUsersTracksSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetUsersLikesTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetUsersLikesTracksAcces), TypeInfoPropertyName = "GetUsersLikesTracksAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::SoundCloud.GetUsersRepostsTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.GetUsersRepostsTracksAcces), TypeInfoPropertyName = "GetUsersRepostsTracksAcces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>), TypeInfoPropertyName = "OneOfTracksIListTrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>), TypeInfoPropertyName = "OneOfPlaylistsIListPlaylist2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.CreateUpdatePlaylistRequestPlaylistTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.ErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.User?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.Track>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.Playlist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.ActivitiesCollectionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.WebProfile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeActivitiesAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeActivitiesAllOwnAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeActivitiesTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeFeedAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeFeedTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeRecentlyPlayedTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeLikesTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeFollowingsTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetMeRepostsTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetPlaylistsAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetPlaylistsAcces2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetPlaylistsTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetTracksRelatedAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetSystemPlaylistsAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetUsersPlaylistsAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetUsersTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetUsersLikesTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::SoundCloud.GetUsersRepostsTracksAcces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.List<global::SoundCloud.Track>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.List<global::SoundCloud.Playlist>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}