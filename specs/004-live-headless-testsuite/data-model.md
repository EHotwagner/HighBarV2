# Data Model: Live Headless Engine Test Suite

**Branch**: `004-live-headless-testsuite` | **Date**: 2026-04-03

## Entities

### EngineVersion (Configuration)

Pinned version configuration stored in `tests/engine-version.json`.

| Field | Type | Description |
|-------|------|-------------|
| engine.version | string | Expected engine sync-version string |
| engine.binary | string | Default binary name (e.g., "spring-headless") |
| engine.downloadUrl | string | URL for manual download |
| game.name | string | Full game archive name with version tag |
| game.rapidTag | string | pr-downloader rapid tag for automated download |
| map.name | string | Map name for test scenarios |

**Lifecycle**: Static file, updated manually when new versions are validated.

### TestSession (Runtime)

A single test run's runtime state. Not persisted; exists only during test execution.

| Field | Type | Description |
|-------|------|-------------|
| sessionId | string (GUID) | Unique identifier for this test run |
| socketPath | string | Unix socket path: `/tmp/highbar-test-{sessionId}.sock` |
| pidFile | string | Engine process PID file: `{socketPath}.pid` |
| sessionDir | string | Temporary directory for logs and engine write-dir |
| enginePid | int | PID of the running spring-headless process |
| startTime | timestamp | When the engine was launched |
| status | enum | STARTING, READY, RUNNING, CRASHED, STOPPED |

**State transitions**:
```
STARTING → READY (socket becomes available)
STARTING → CRASHED (engine exits before socket ready)
READY → RUNNING (first test begins)
RUNNING → CRASHED (engine exits during tests)
RUNNING → STOPPED (harness terminates engine after tests)
```

### PrerequisiteCheck (Runtime)

Result of a prerequisites validation run.

| Field | Type | Description |
|-------|------|-------------|
| engineFound | bool | Engine binary exists on PATH or at configured path |
| engineVersionMatch | bool | Installed engine version matches pinned version |
| gameArchiveFound | bool | Game archive present in data directory |
| mapFound | bool | Map file present in data directory |
| allPassed | bool | All checks passed |
| issues | list[string] | Human-readable descriptions of each failing check |
| resolutions | list[string] | Actionable steps to fix each issue |

**Lifecycle**: Computed on demand, not persisted.

## Relationships

```
EngineVersion (config) ─── read by ──→ PrerequisiteCheck (validation)
EngineVersion (config) ─── read by ──→ TestSession (startup)
PrerequisiteCheck ─── gates ──→ TestSession (must pass before launch)
TestSession ─── produces ──→ Log files (engine-stdout.log, engine-stderr.log, infolog.txt)
```
