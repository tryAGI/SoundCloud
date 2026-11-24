
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.OAuthToken? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.OAuthTokenGrantType? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackMetadataRequest? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackMetadataRequestTrack? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackMetadataRequestTrackSharing? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackMetadataRequestTrackEmbeddableBy? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackMetadataRequestTrackLicense? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Storefront? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.StorefrontType? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.StorefrontUpdateRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.StorefrontUpdateRequestType? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.CreateUpdatePlaylistRequest? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.CreateUpdatePlaylistRequestPlaylist? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSharing? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.CreateUpdatePlaylistRequestPlaylistTrack>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.CreateUpdatePlaylistRequestPlaylistTrack? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.CreateUpdatePlaylistRequestPlaylistSetType? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.CreateUpdatePlaylistFormRequest? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSharing? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.CreateUpdatePlaylistFormRequestPlaylistSetType? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackDataRequest? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackDataRequestTrackSharing? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackDataRequestTrackEmbeddableBy? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackDataRequestTrackLicense? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackUpdateFormRequest? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackUpdateFormRequestTrackSharing? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackUpdateFormRequestTrackEmbeddableBy? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackUpdateFormRequestTrackLicense? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Found? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Error? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.ErrorError>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.ErrorError? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TooManyRequests? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TooManyRequestsVariant2? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackCreationLimited? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackCreationLimitedVariant2? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackCreationLimitedVariant2ErrorCode? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.User? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<byte[]>? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.UserSubscription? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.UserSubscriptionProduct? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Me? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.MeQuota? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.MeSubscription? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.MeSubscriptionProduct? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Users? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.User?>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Track? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.AllOf<global::SoundCloud.User, object>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackAccess? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Tracks? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.Track>? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Playlist? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.AllOf<object, global::SoundCloud.User>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.SystemPlaylist? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.SystemPlaylists? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.SystemPlaylist>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Playlists? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.Playlist>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Activities? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.ActivitiesCollectionItem>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.ActivitiesCollectionItem? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.AnyOf<global::SoundCloud.Track, global::SoundCloud.Playlist>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.WebProfile>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.WebProfile? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Comment? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.CommentUser? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Comments? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.Comment>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Streams? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.AllOf<global::SoundCloud.TrackDataRequest, object>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.AllOf<global::SoundCloud.CreateUpdatePlaylistFormRequest, object>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.CreateTracksCommentsRequest? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.CreateTracksCommentsRequestComment? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.OneOf<string, double?>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetMeActivitiesAcces>? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetMeActivitiesAcces? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetMeActivitiesAllOwnAcces>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetMeActivitiesAllOwnAcces? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetMeActivitiesTracksAcces>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetMeActivitiesTracksAcces? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetMeFeedAcces>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetMeFeedAcces? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetMeFeedTracksAcces>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetMeFeedTracksAcces? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetMeRecentlyPlayedTracksAcces>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetMeRecentlyPlayedTracksAcces? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetMeLikesTracksAcces>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetMeLikesTracksAcces? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetMeFollowingsTracksAcces>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetMeFollowingsTracksAcces? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetMeTracksSort? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetMeRepostsTracksAcces>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetMeRepostsTracksAcces? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetTracksBpm? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetTracksDuration? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetTracksCreatedAt? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetTracksAcces>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetTracksAcces? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetPlaylistsAcces>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetPlaylistsAcces? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetPlaylistsTracksAcces>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetPlaylistsTracksAcces? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetTracksRelatedAcces>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetTracksRelatedAcces? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetSystemPlaylistsAcces>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetSystemPlaylistsAcces? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetUsersPlaylistsAcces>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetUsersPlaylistsAcces? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetUsersTracksAcces>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetUsersTracksAcces? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetUsersTracksSort? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetUsersLikesTracksAcces>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetUsersLikesTracksAcces? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::SoundCloud.GetUsersRepostsTracksAcces>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.GetUsersRepostsTracksAcces? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.IList<global::SoundCloud.Track>>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.IList<global::SoundCloud.Playlist>>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.OneOf<global::SoundCloud.SystemPlaylists, global::System.Collections.Generic.IList<global::SoundCloud.SystemPlaylist>>? Type126 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.CreateUpdatePlaylistRequestPlaylistTrack>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.ErrorError>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<byte[]>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.User?>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.Track>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.SystemPlaylist>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.Playlist>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.ActivitiesCollectionItem>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.WebProfile>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.Comment>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetMeActivitiesAcces>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetMeActivitiesAllOwnAcces>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetMeActivitiesTracksAcces>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetMeFeedAcces>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetMeFeedTracksAcces>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetMeRecentlyPlayedTracksAcces>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetMeLikesTracksAcces>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetMeFollowingsTracksAcces>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetMeRepostsTracksAcces>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetTracksAcces>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetPlaylistsAcces>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetPlaylistsTracksAcces>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetTracksRelatedAcces>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetSystemPlaylistsAcces>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetUsersPlaylistsAcces>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetUsersTracksAcces>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetUsersLikesTracksAcces>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::SoundCloud.GetUsersRepostsTracksAcces>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.OneOf<global::SoundCloud.Tracks, global::System.Collections.Generic.List<global::SoundCloud.Track>>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.OneOf<global::SoundCloud.Playlists, global::System.Collections.Generic.List<global::SoundCloud.Playlist>>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.OneOf<global::SoundCloud.SystemPlaylists, global::System.Collections.Generic.List<global::SoundCloud.SystemPlaylist>>? ListType30 { get; set; }
    }
}