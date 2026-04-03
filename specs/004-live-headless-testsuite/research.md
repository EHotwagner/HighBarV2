# Research: Live Headless Engine Test Suite

**Branch**: `004-live-headless-testsuite` | **Date**: 2026-04-03

## R1: Version Pinning Mechanism

**Decision**: Create a `tests/engine-version.json` configuration file specifying pinned engine and game versions.

**Rationale**: The project currently has no version pinning — engine version is embedded in `proxy/data/AIInfo.lua` (proxy version "0.1") and game version/map name are only in `tests/fixtures/game-setup.lua` as defaults. A dedicated JSON file is the simplest format that both shell scripts and F#/Python test harnesses can parse without extra dependencies.

**Alternatives considered**:
- `.env` file: Harder to parse structured data (nested fields), no standard parser in F#.
- YAML: Requires a YAML parser dependency in F# and shell scripts.
- TOML: Good for Rust/Python but no native F# support without a dependency.
- Embedding in existing files: Scatters version info across multiple locations, harder to update atomically.

**Format**:
```json
{
  "engine": {
    "version": "105.1.1-2549-g5765528 bar",
    "binary": "spring-headless",
    "downloadUrl": "https://github.com/beyond-all-reason/spring/releases"
  },
  "game": {
    "name": "Beyond All Reason test-27612-e70fbc0",
    "rapidTag": "byar-test:test"
  },
  "map": {
    "name": "Comet Catcher Remake 1.8"
  }
}
```

## R2: Prerequisites Check Script Design

**Decision**: Create a `tests/check-prerequisites.sh` script that validates engine binary, game content, and version compatibility before test execution.

**Rationale**: The existing test harnesses (F# `Harness.fs`, Python `conftest.py`) launch the engine directly and fail with opaque errors when prerequisites are missing. A dedicated check script runs fast (<5s), provides actionable diagnostics, and can be called from both harnesses and standalone.

**Alternatives considered**:
- Embedding checks in each harness: Duplicates logic across F# and Python; shell script is shared.
- Makefile target: Less portable, harder to produce structured output.
- Docker-based approach: Overkill for local dev; doesn't help developers understand their environment.

**Validation sequence**:
1. Check engine binary exists (PATH or `HIGHBAR_TEST_ENGINE`)
2. Check engine version matches pinned version (`spring-headless --sync-version`)
3. Check game archive exists in data directory (scan `SPRING_DATADIR/games/` or `SPRING_DATADIR/packages/`)
4. Check map exists in data directory (scan `SPRING_DATADIR/maps/`)
5. Report all findings with actionable fix instructions

## R3: Victory Condition Disable

**Decision**: Set `GameMode=3` (off) in the game start script to disable victory conditions.

**Rationale**: The existing `game-setup.lua` does not set `GameMode`, which defaults to `0` (commander dies = game over). With AI opponents, a commander kill could end the game mid-test. Setting `GameMode=3` disables all victory conditions, keeping the game alive until the harness kills it.

**Source**: Report `008-bar-headless-mode.md` Section 3 documents `GameMode=0` (commander dies), `1` (lineage), `2` (KillAll), `3` (off). The start script format supports this in `[MODOPTIONS]`.

**Alternatives considered**:
- Using NullAI on both sides: Prevents combat scenarios needed for command/event tests.
- Time limit via `MaxSpeed`/frame counting: Fragile; depends on test duration estimates.

## R4: Engine Crash Detection

**Decision**: Detect engine process death via PID polling in the test harness, using the existing PID file mechanism.

**Rationale**: Both harnesses already write and read PID files. Adding a periodic liveness check (or checking before each test) is minimal additional code. On crash detection, the harness should capture any remaining stderr output, mark untested items as skipped, and exit with failure.

**Implementation approach**:
- F# harness: Check `Process.HasExited` on the engine process before each test or in a background monitor.
- Python harness: Check `os.kill(pid, 0)` or `psutil.pid_exists(pid)` before each test.
- Both: On detection, read engine log file from write-dir for diagnostics.

**Alternatives considered**:
- Socket error detection only: Catches some crashes but not all (engine may crash before socket creation).
- SIGCHLD signal handler: More complex, platform-dependent, overkill for test harness.

## R5: Engine Log Capture for Diagnostics

**Decision**: Redirect engine stdout/stderr to log files in a per-session temporary directory and surface them on test failure.

**Rationale**: The current `start-headless.sh` launches the engine as a background process but does not capture its output. For FR-008 (diagnostics), we need engine logs available. The engine also writes its own `infolog.txt` to its write-dir, which can be surfaced.

**Implementation approach**:
- Modify `start-headless.sh` to redirect stdout/stderr to `{session_dir}/engine-stdout.log` and `engine-stderr.log`.
- Use `--write-dir {session_dir}` so engine's own `infolog.txt` lands in the session directory.
- Both harnesses expose a `DiagnosticInfo` property/function that reads these files on failure.
- xUnit: Use `ITestOutputHelper` to attach log excerpts. Python: Use pytest's `capfd` or write to test report.

**Alternatives considered**:
- In-memory pipe capture: Risk of buffer deadlock if engine produces high log volume.
- systemd journal integration: Not portable, not available in all environments.

## R6: Content Provisioning Automation

**Decision**: Create a `tests/setup-engine.sh` script that automates downloading engine binary, game archive, and maps using `pr-downloader` and direct downloads.

**Rationale**: FR-002 requires identifying missing content, and Story 2 calls for automated provisioning. A shell script that reads `tests/engine-version.json` and downloads missing components is the simplest approach that works for both interactive use and future CI.

**Steps**:
1. Read pinned versions from `tests/engine-version.json`.
2. Check for engine binary; if missing, download from GitHub releases.
3. Check for game archive; if missing, run `pr-downloader --download-game "..."`.
4. Check for map; if missing, provide download instructions (maps are large and hosted on Google Drive).

**Alternatives considered**:
- Docker image with pre-installed content: Good for CI but doesn't help local dev understanding.
- Git LFS for game content: Files are too large (>1GB) and change frequently.
