#!/usr/bin/env bash
set -euo pipefail

readonly SCRIPT_DIR="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
cd "$SCRIPT_DIR"

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.yaml https://raw.githubusercontent.com/soundcloud/api/master/openapi/api.yaml
autosdk generate openapi.yaml \
  --namespace SoundCloud \
  --clientClassName SoundCloudClient \
  --targetFramework net10.0 \
  --output Generated \
  --methodNamingConvention Summary \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:OAuth \
  --generate-retry-handler \
  --generate-http-exception-hierarchy \
  --generate-pageable-helpers \
  --generate-raw-model-data \
  --direction-aware-json-generation-mode
