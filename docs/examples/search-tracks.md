# Search tracks



This example assumes `using SoundCloud;` is in scope and `apiKey` contains your SoundCloud API key.

```csharp
using var client = new SoundCloudClient(apiKey);

// SoundCloud uses the OAuth authorization scheme. Pass the raw access token to the client.
var result = await client.Search.PerformsATrackSearchBasedOnAQueryAsync(
    q: "ambient",
    limit: 10,
    linkedPartitioning: true);
```