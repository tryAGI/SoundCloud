
#nullable enable

namespace SoundCloud
{
    public partial class TracksClient
    {


        private static readonly global::SoundCloud.EndPointSecurityRequirement s_CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackSecurityRequirement0 =
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
        private static readonly global::SoundCloud.EndPointSecurityRequirement[] s_CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackSecurityRequirements =
            new global::SoundCloud.EndPointSecurityRequirement[]
            {                s_CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackSecurityRequirement0,
            };
        partial void PrepareCreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string trackUrn,
            global::SoundCloud.StorefrontUpdateRequest request);
        partial void PrepareCreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string trackUrn,
            global::SoundCloud.StorefrontUpdateRequest request);
        partial void ProcessCreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates or updates the storefront (Artist Storefront) of a track.<br/>
        /// Creates or updates the storefront module shown on the track page. The request replaces<br/>
        /// the whole storefront: optional fields (link_title, description, price) are cleared when<br/>
        /// omitted, so always send every value the storefront should keep. The request fails with<br/>
        /// 403 when the authenticated user does not own the track, and also when the user does not<br/>
        /// hold a creator subscription that includes external purchase options. The storefront<br/>
        /// links to an external page — no payment is processed by SoundCloud.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::SoundCloud.Storefront> CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsync(
            string trackUrn,

            global::SoundCloud.StorefrontUpdateRequest request,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsResponseAsync(
                trackUrn: trackUrn,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Creates or updates the storefront (Artist Storefront) of a track.<br/>
        /// Creates or updates the storefront module shown on the track page. The request replaces<br/>
        /// the whole storefront: optional fields (link_title, description, price) are cleared when<br/>
        /// omitted, so always send every value the storefront should keep. The request fails with<br/>
        /// 403 when the authenticated user does not own the track, and also when the user does not<br/>
        /// hold a creator subscription that includes external purchase options. The storefront<br/>
        /// links to an external page — no payment is processed by SoundCloud.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::SoundCloud.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Storefront>> CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsResponseAsync(
            string trackUrn,

            global::SoundCloud.StorefrontUpdateRequest request,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackArguments(
                httpClient: HttpClient,
                trackUrn: ref trackUrn,
                request: request);


            var __authorizations = global::SoundCloud.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackSecurityRequirements,
                operationName: "CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsync");

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
                                path: $"/tracks/{trackUrn}/storefront",
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
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::SoundCloud.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackRequest(
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
                                operationId: "CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrack",
                                methodName: "CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsync",
                                pathTemplate: "$\"/tracks/{trackUrn}/storefront\"",
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
                                operationId: "CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrack",
                                methodName: "CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsync",
                                pathTemplate: "$\"/tracks/{trackUrn}/storefront\"",
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
                                operationId: "CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrack",
                                methodName: "CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsync",
                                pathTemplate: "$\"/tracks/{trackUrn}/storefront\"",
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
                ProcessCreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::SoundCloud.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::SoundCloud.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrack",
                                methodName: "CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsync",
                                pathTemplate: "$\"/tracks/{trackUrn}/storefront\"",
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
                                operationId: "CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrack",
                                methodName: "CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsync",
                                pathTemplate: "$\"/tracks/{trackUrn}/storefront\"",
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
                            // Forbidden
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::SoundCloud.Error? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::SoundCloud.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::SoundCloud.Error.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::SoundCloud.ApiException<global::SoundCloud.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Not Found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::SoundCloud.Error? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::SoundCloud.Error.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::SoundCloud.Error.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::SoundCloud.ApiException<global::SoundCloud.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
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
                                ProcessCreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::SoundCloud.Storefront.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Storefront>(
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

                                    var __value = await global::SoundCloud.Storefront.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::SoundCloud.AutoSDKHttpResponse<global::SoundCloud.Storefront>(
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
        /// Creates or updates the storefront (Artist Storefront) of a track.<br/>
        /// Creates or updates the storefront module shown on the track page. The request replaces<br/>
        /// the whole storefront: optional fields (link_title, description, price) are cleared when<br/>
        /// omitted, so always send every value the storefront should keep. The request fails with<br/>
        /// 403 when the authenticated user does not own the track, and also when the user does not<br/>
        /// hold a creator subscription that includes external purchase options. The storefront<br/>
        /// links to an external page — no payment is processed by SoundCloud.
        /// </summary>
        /// <param name="trackUrn"></param>
        /// <param name="title">
        /// Card title shown on the storefront module.<br/>
        /// Example: Download now
        /// </param>
        /// <param name="type">
        /// The type of item offered.
        /// </param>
        /// <param name="link">
        /// External http(s) URL the storefront button opens.<br/>
        /// Example: https://example.com/my-track
        /// </param>
        /// <param name="linkTitle">
        /// Label of the storefront button. Omit to clear.<br/>
        /// Example: Download
        /// </param>
        /// <param name="description">
        /// Description shown on the storefront module. Omit to clear.<br/>
        /// Example: Get the track original files for free.
        /// </param>
        /// <param name="price">
        /// Display-only price text shown next to the item type. No payment is processed by SoundCloud. Omit to clear.<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::SoundCloud.Storefront> CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsync(
            string trackUrn,
            string title,
            global::SoundCloud.StorefrontUpdateRequestType type,
            string link,
            string? linkTitle = default,
            string? description = default,
            string? price = default,
            global::SoundCloud.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::SoundCloud.StorefrontUpdateRequest
            {
                Title = title,
                Type = type,
                Link = link,
                LinkTitle = linkTitle,
                Description = description,
                Price = price,
            };

            return await CreatesOrUpdatesTheStorefrontArtistStorefrontOfATrackAsync(
                trackUrn: trackUrn,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}