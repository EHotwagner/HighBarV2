# Contract: Engine Version Configuration Schema

**File**: `tests/engine-version.json`
**Consumers**: `tests/check-prerequisites.sh`, `tests/setup-engine.sh`, F# Harness, Python conftest

## Schema

```json
{
  "engine": {
    "version": "<string: engine sync-version output>",
    "binary": "<string: default binary name>",
    "downloadUrl": "<string: URL for manual download>"
  },
  "game": {
    "name": "<string: full game archive name with version>",
    "rapidTag": "<string: pr-downloader rapid tag>"
  },
  "map": {
    "name": "<string: map name matching engine map list>"
  }
}
```

## Rules

- All fields are required.
- `engine.version` MUST match the exact output of `spring-headless --sync-version`.
- `game.name` MUST match the archive name that `pr-downloader` produces.
- `map.name` MUST match the map name as recognized by the engine (case-sensitive).
- File MUST be valid JSON parseable by `jq`, `System.Text.Json`, and Python `json` module.
