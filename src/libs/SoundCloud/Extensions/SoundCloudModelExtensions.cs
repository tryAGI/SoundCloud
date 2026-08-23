using System.Text.Json;

namespace SoundCloud;

/// <summary>Helpers for SoundCloud response fields used by playback clients.</summary>
public static class SoundCloudModelExtensions
{
    /// <summary>Returns the stable track identifier, preferring the current URN representation.</summary>
    public static string? GetIdentifier(this Track track)
    {
        ArgumentNullException.ThrowIfNull(track);

        if (!string.IsNullOrWhiteSpace(track.Urn))
            return track.Urn;

        if (!track.AdditionalProperties.TryGetValue("id", out var id))
            return null;

        return id.ValueKind switch
        {
            JsonValueKind.String => id.GetString(),
            JsonValueKind.Number => id.GetRawText(),
            _ => null,
        };
    }

    /// <summary>Returns the progressive 128 kbps MP3 URL when SoundCloud includes it.</summary>
    public static Uri? GetHttpMp3128Uri(this Streams streams)
    {
        ArgumentNullException.ThrowIfNull(streams);
        return TryGetUri(streams.AdditionalProperties, "http_mp3_128_url");
    }

    /// <summary>Returns the 96 kbps HLS AAC URL when SoundCloud includes it.</summary>
    public static Uri? GetHlsAac96Uri(this Streams streams)
    {
        ArgumentNullException.ThrowIfNull(streams);
        return TryGetUri(streams.AdditionalProperties, "hls_aac_96_url");
    }

    /// <summary>Returns whether the response contains at least one full-track stream.</summary>
    public static bool HasFullTrackStream(this Streams streams)
    {
        ArgumentNullException.ThrowIfNull(streams);
        return FirstUri(streams.HlsAac160Url, streams.HlsMp3128Url) is not null ||
               streams.GetHlsAac96Uri() is not null ||
               streams.GetHttpMp3128Uri() is not null;
    }

    private static Uri? FirstUri(params string?[] values)
    {
        foreach (var value in values)
        {
            if (Uri.TryCreate(value, UriKind.Absolute, out var uri))
                return uri;
        }

        return null;
    }

    private static string? TryGetString(
        IDictionary<string, JsonElement> properties,
        string name) =>
        properties.TryGetValue(name, out var value) && value.ValueKind == JsonValueKind.String
            ? value.GetString()
            : null;

    private static Uri? TryGetUri(IDictionary<string, JsonElement> properties, string name) =>
        Uri.TryCreate(TryGetString(properties, name), UriKind.Absolute, out var uri) ? uri : null;
}
