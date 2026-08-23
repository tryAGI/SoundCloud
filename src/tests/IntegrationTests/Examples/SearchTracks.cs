/*
order: 10
title: Search tracks
slug: search-tracks
*/

namespace SoundCloud.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SearchTracks()
    {
        using var client = GetAuthenticatedClient();

        //// SoundCloud uses the OAuth authorization scheme. Pass the raw access token to the client.
        var result = await client.Search.PerformsATrackSearchBasedOnAQueryAsync(
            q: "ambient",
            limit: 10,
            linkedPartitioning: true);

        result.Object.Should().NotBeNull();
    }
}
