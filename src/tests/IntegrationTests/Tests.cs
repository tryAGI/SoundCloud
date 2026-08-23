namespace SoundCloud.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static SoundCloudClient GetAuthenticatedClient()
    {
        var accessToken =
            Environment.GetEnvironmentVariable("SOUNDCLOUD_ACCESS_TOKEN") is { Length: > 0 } accessTokenValue
                ? accessTokenValue
                : throw new AssertInconclusiveException("SOUNDCLOUD_ACCESS_TOKEN environment variable is not found.");

        var client = new SoundCloudClient(accessToken);

        return client;
    }
}
