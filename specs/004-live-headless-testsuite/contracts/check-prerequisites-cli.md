# Contract: Prerequisites Check CLI

**Script**: `tests/check-prerequisites.sh`
**Consumers**: Developers (interactive), F# Harness, Python conftest

## Interface

```bash
tests/check-prerequisites.sh [--json] [--fix]
```

### Options

| Flag | Description |
|------|-------------|
| (none) | Human-readable output with colored status indicators |
| `--json` | Machine-parseable JSON output |
| `--fix` | Attempt automated fixes (download missing components) |

### Exit Codes

| Code | Meaning |
|------|---------|
| 0 | All prerequisites met |
| 1 | One or more prerequisites missing (details in output) |
| 2 | Script error (e.g., cannot read config file) |

### JSON Output Schema

```json
{
  "passed": true,
  "checks": [
    {
      "name": "engine_binary",
      "passed": true,
      "detail": "spring-headless found at /usr/local/bin/spring-headless"
    },
    {
      "name": "engine_version",
      "passed": false,
      "detail": "Expected 105.1.1-2549, got 104.0.1-1234",
      "resolution": "Download correct version from https://github.com/..."
    },
    {
      "name": "game_archive",
      "passed": true,
      "detail": "Beyond All Reason test-27612-e70fbc0 found"
    },
    {
      "name": "map_file",
      "passed": true,
      "detail": "Comet Catcher Remake 1.8 found"
    }
  ]
}
```

### Human-Readable Output

```
[✓] Engine binary: spring-headless found at /usr/local/bin/spring-headless
[✗] Engine version: Expected 105.1.1-2549, got 104.0.1-1234
    → Download correct version from https://github.com/...
[✓] Game archive: Beyond All Reason test-27612-e70fbc0 found
[✓] Map file: Comet Catcher Remake 1.8 found

Result: FAILED (1 of 4 checks failed)
```

## Environment Variables

| Variable | Used For |
|----------|----------|
| `HIGHBAR_TEST_ENGINE` | Override engine binary path |
| `SPRING_DATADIR` | Game content directory |

## Dependencies

- `jq` for JSON parsing of `tests/engine-version.json`
- Engine binary must support `--sync-version` flag
