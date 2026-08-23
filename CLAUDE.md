# SoundCloud SDK

Generated .NET client for SoundCloud's official Public API OpenAPI document.

## Regeneration

Run `cd src/libs/SoundCloud && ./generate.sh`. The script refreshes the official schema and regenerates `Generated/`; never edit that directory manually.

SoundCloud access tokens use the non-standard `Authorization: OAuth <token>` scheme. The generator's `Http:Header:OAuth` security override lets consumers pass the raw access token to `SoundCloudClient`.

The Advantage integration depends on typed track search, `/tracks/{track_urn}/streams`, and `/resolve`, as well as retry behavior and forward-compatible raw model data.
