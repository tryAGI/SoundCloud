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
            Content = new StringContent("""
                {
                  "http_mp3_128_url": "https://media.example.test/full.mp3",
                  "hls_aac_96_url": "https://media.example.test/full.m3u8",
                  "preview_mp3_128_url": "https://media.example.test/preview.mp3"
                }
                """),
        });
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri(SoundCloudClient.DefaultBaseUrl),
        };
        using var client = new SoundCloudClient("access-token", httpClient, disposeHttpClient: false);

        var streams = await client.Tracks.ReturnsATracksStreamableURLsNeedsToKeepUsingAuthenticationAsync(
            "soundcloud:tracks:123");

        streams.Should().NotBeNull();
        streams.GetHttpMp3128Uri().Should().Be(new Uri("https://media.example.test/full.mp3"));
        streams.GetHlsAac96Uri().Should().Be(new Uri("https://media.example.test/full.m3u8"));
        streams.HasFullTrackStream().Should().BeTrue();
        handler.LastMethod.Should().Be(HttpMethod.Get);
        handler.LastRequestUri.Should().NotBeNull();
        handler.LastRequestUri!.AbsolutePath.Should().EndWith("/tracks/soundcloud:tracks:123/streams");
        handler.LastAuthorization.Should().Be(new AuthenticationHeaderValue("OAuth", "access-token"));
    }

    [TestMethod]
    public void TrackIdentifier_PrefersUrnAndSupportsLegacyId()
    {
        new Track { Urn = "soundcloud:tracks:123" }.GetIdentifier()
            .Should().Be("soundcloud:tracks:123");

        new Track
        {
            AdditionalProperties = new Dictionary<string, System.Text.Json.JsonElement>
            {
                ["id"] = System.Text.Json.JsonDocument.Parse("456").RootElement.Clone(),
            },
        }.GetIdentifier().Should().Be("456");
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
