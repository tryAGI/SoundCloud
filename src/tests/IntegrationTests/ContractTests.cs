using System.Net;
using System.Net.Http.Headers;

namespace SoundCloud.IntegrationTests;

[TestClass]
public sealed class ContractTests
{
    [TestMethod]
    public async Task Streams_UsesOAuthAuthorizationAndTrackUrn()
    {
        var handler = new RecordingHandler(_ => new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent("{}"),
        });
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri(SoundCloudClient.DefaultBaseUrl),
        };
        using var client = new SoundCloudClient("access-token", httpClient, disposeHttpClient: false);

        var streams = await client.Tracks.ReturnsATracksStreamableURLsNeedsToKeepUsingAuthenticationAsync(
            "soundcloud:tracks:123");

        streams.Should().NotBeNull();
        handler.LastMethod.Should().Be(HttpMethod.Get);
        handler.LastRequestUri.Should().NotBeNull();
        handler.LastRequestUri!.AbsolutePath.Should().EndWith("/tracks/soundcloud:tracks:123/streams");
        handler.LastAuthorization.Should().Be(new AuthenticationHeaderValue("OAuth", "access-token"));
    }

    private sealed class RecordingHandler(Func<HttpRequestMessage, HttpResponseMessage> responseFactory)
        : HttpMessageHandler
    {
        public HttpMethod? LastMethod { get; private set; }
        public Uri? LastRequestUri { get; private set; }
        public AuthenticationHeaderValue? LastAuthorization { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            LastMethod = request.Method;
            LastRequestUri = request.RequestUri;
            LastAuthorization = request.Headers.Authorization;
            return Task.FromResult(responseFactory(request));
        }
    }
}
