
#nullable enable

namespace SoundCloud
{
    public partial class TracksClient
    {


        private static readonly global::SoundCloud.EndPointSecurityRequirement s_UpdatesATracksInformationWithRawBodySecurityRequirement0 =
            new global::SoundCloud.EndPointSecurityRequirement
            {
                Authorizations = new global::SoundCloud.EndPointAuthorizationRequirement[]
                {                    new global::SoundCloud.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpOauth",
                        Location = "Header",
                        Name = "OAuth",
                        FriendlyName = "OAuth",
                    },
                },
            };
        private static readonly global::SoundCloud.EndPointSecurityRequirement[] s_UpdatesATracksInformationWithRawBodySecurityRequirements =
            new global::SoundCloud.EndPointSecurityRequirement[]
            {                s_UpdatesATracksInformationWithRawBodySecurityRequirement0,
            };
        partial void PrepareUpdatesATracksInformationWithRawBodyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string trackUrn,
            global::SoundCloud.TrackUpdateFormRequest request);
        partial void PrepareUpdatesATracksInformationWithRawBodyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string trackUrn,
            global::SoundCloud.TrackUpdateFormRequest request);
        partial void ProcessUpdatesATracksInformationWithRawBodyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdatesATracksInformationWithRawBodyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Updates a track's information.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::SoundCloud.Track> UpdatesATracksInformationWithRawBodyAsync(
            string trackUrn,

            global::SoundCloud.TrackUpdateFormRequest request,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await UpdatesATracksInformationWithRawBodyAsResponseAsync(
                trackUrn: trackUrn,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Updates a track's information.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Track>> UpdatesATracksInformationWithRawBodyAsResponseAsync(
            string trackUrn,

            global::SoundCloud.TrackUpdateFormRequest request,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdatesATracksInformationWithRawBodyArguments(
                httpClient: HttpClient,
                trackUrn: ref trackUrn,
                request: request);


            var __authorizations = global::SoundCloud.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UpdatesATracksInformationWithRawBodySecurityRequirements,
                operationName: "UpdatesATracksInformationWithRawBodyAsync");

            using var __timeoutCancellationTokenSource = global::SoundCloud.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::SoundCloud.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::SoundCloud.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::SoundCloud.PathBuilder(
                                path: $"/tracks/{trackUrn}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::SoundCloud.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Put,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "multipart/x-www-form-urlencoded");
                            __httpRequest.Content = __httpRequestContent;
                global::SoundCloud.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareUpdatesATracksInformationWithRawBodyRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    trackUrn: trackUrn!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::SoundCloud.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::SoundCloud.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UpdatesATracksInformationWithRawBody",
                                methodName: "UpdatesATracksInformationWithRawBodyAsync",
                                pathTemplate: "$\"/tracks/{trackUrn}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::SoundCloud.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::SoundCloud.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::SoundCloud.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UpdatesATracksInformationWithRawBody",
                                methodName: "UpdatesATracksInformationWithRawBodyAsync",
                                pathTemplate: "$\"/tracks/{trackUrn}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::SoundCloud.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::SoundCloud.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::SoundCloud.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::SoundCloud.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::SoundCloud.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UpdatesATracksInformationWithRawBody",
                                methodName: "UpdatesATracksInformationWithRawBodyAsync",
                                pathTemplate: "$\"/tracks/{trackUrn}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::SoundCloud.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessUpdatesATracksInformationWithRawBodyResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::SoundCloud.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::SoundCloud.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UpdatesATracksInformationWithRawBody",
                                methodName: "UpdatesATracksInformationWithRawBodyAsync",
                                pathTemplate: "$\"/tracks/{trackUrn}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::SoundCloud.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::SoundCloud.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UpdatesATracksInformationWithRawBody",
                                methodName: "UpdatesATracksInformationWithRawBodyAsync",
                                pathTemplate: "$\"/tracks/{trackUrn}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Bad Request
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::SoundCloud.Error? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::SoundCloud.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::SoundCloud.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::SoundCloud.ApiException<global::SoundCloud.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unauthorized
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::SoundCloud.Error? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::SoundCloud.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::SoundCloud.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::SoundCloud.ApiException<global::SoundCloud.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessUpdatesATracksInformationWithRawBodyResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::SoundCloud.Track.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Track>(
                                        statusCode: __response.StatusCode,
                                        headers: global::SoundCloud.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::SoundCloud.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::SoundCloud.Track.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Track>(
                                        statusCode: __response.StatusCode,
                                        headers: global::SoundCloud.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::SoundCloud.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Updates a track's information.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="trackTitle"></param>
        /// <param name="trackPermalink"></param>
        /// <param name="trackSharing">
        /// Default Value: public
        /// </param>
        /// <param name="trackEmbeddableBy">
        /// who can embed this track "all", "me", or "none"
        /// </param>
        /// <param name="trackPurchaseUrl"></param>
        /// <param name="trackDescription"></param>
        /// <param name="trackGenre"></param>
        /// <param name="trackTagList">
        /// The tag_list property contains a list of tags separated by spaces. Multiword tags are quoted in double quotes. We also support machine tags that follow the pattern NAMESPACE:KEY=VALUE. For example: geo:lat=43.555<br/>
        /// camel:size=medium<br/>
        /// "machine:tag=with space"<br/>
        /// Machine tags are not revealed to the user on the track pages.
        /// </param>
        /// <param name="trackLabelName"></param>
        /// <param name="trackRelease"></param>
        /// <param name="trackReleaseDate">
        /// string, formatted as yyyy-mm-dd, representing release date<br/>
        /// Included only in requests
        /// </param>
        /// <param name="trackStreamable">
        /// Default Value: true
        /// </param>
        /// <param name="trackDownloadable">
        /// Default Value: true
        /// </param>
        /// <param name="trackLicense"></param>
        /// <param name="trackCommentable">
        /// Default Value: true
        /// </param>
        /// <param name="trackRevealStats">
        /// When false (quiet mode), play and favorite counts are hidden.
        /// </param>
        /// <param name="trackRevealComments">
        /// When false (quiet mode), comments are hidden.
        /// </param>
        /// <param name="trackIsrc"></param>
        /// <param name="trackArtworkData">
        /// Track artwork in binary format. Only for PRO users. Supported formats are gif, jpeg and png.
        /// </param>
        /// <param name="trackArtworkDataname">
        /// Track artwork in binary format. Only for PRO users. Supported formats are gif, jpeg and png.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::SoundCloud.Track> UpdatesATracksInformationWithRawBodyAsync(
            string trackUrn,
            string? trackTitle = default,
            string? trackPermalink = default,
            global::SoundCloud.TrackUpdateFormRequestTrackSharing? trackSharing = default,
            global::SoundCloud.TrackUpdateFormRequestTrackEmbeddableBy? trackEmbeddableBy = default,
            string? trackPurchaseUrl = default,
            string? trackDescription = default,
            string? trackGenre = default,
            string? trackTagList = default,
            string? trackLabelName = default,
            string? trackRelease = default,
            string? trackReleaseDate = default,
            bool? trackStreamable = default,
            bool? trackDownloadable = default,
            global::SoundCloud.TrackUpdateFormRequestTrackLicense? trackLicense = default,
            bool? trackCommentable = default,
            bool? trackRevealStats = default,
            bool? trackRevealComments = default,
            string? trackIsrc = default,
            byte[]? trackArtworkData = default,
            string? trackArtworkDataname = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::SoundCloud.TrackUpdateFormRequest
            {
                TrackTitle = trackTitle,
                TrackPermalink = trackPermalink,
                TrackSharing = trackSharing,
                TrackEmbeddableBy = trackEmbeddableBy,
                TrackPurchaseUrl = trackPurchaseUrl,
                TrackDescription = trackDescription,
                TrackGenre = trackGenre,
                TrackTagList = trackTagList,
                TrackLabelName = trackLabelName,
                TrackRelease = trackRelease,
                TrackReleaseDate = trackReleaseDate,
                TrackStreamable = trackStreamable,
                TrackDownloadable = trackDownloadable,
                TrackLicense = trackLicense,
                TrackCommentable = trackCommentable,
                TrackRevealStats = trackRevealStats,
                TrackRevealComments = trackRevealComments,
                TrackIsrc = trackIsrc,
                TrackArtworkData = trackArtworkData,
                TrackArtworkDataname = trackArtworkDataname,
            };

            return await UpdatesATracksInformationWithRawBodyAsync(
                trackUrn: trackUrn,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}