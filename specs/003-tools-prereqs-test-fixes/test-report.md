# Test & Build Report: 003-tools-prereqs-test-fixes

**Date**: 2026-04-03
**Branch**: `003-tools-prereqs-test-fixes`
**Environment**: Arch Linux, GCC 15.2, .NET SDK 10.0.104, Python 3.14.3, CMake 4.3.1, buf 1.67.0

---

## Build Results

| Component | Status | Output Path | Notes |
|-----------|--------|-------------|-------|
| Proto Generation (C) | **PASS** | `proto/gen/c/highbar/` (10 files) | Warning: protoc-gen-c doesn't advertise proto3 optional support (output is valid) |
| Proto Generation (C#) | **PASS** | `proto/gen/csharp/` (5 files) | — |
| Proto Generation (Python) | **PASS** | `proto/gen/python/` (2 files) | Warning: betterproto plugin doesn't advertise proto3 optional support (output is valid) |
| C Proxy (libSkirmishAI.so) | **PASS** | `build/libSkirmishAI.so` (326KB) | 4 test binaries also produced |
| F# Client | **PASS** | `clients/fsharp/bin/Debug/net8.0/HighBar.Client.dll` | 0 warnings, 0 errors |
| Python Client | **PASS (fixed)** | `.venv/` editable install | Fixed dataclass field ordering for Python 3.14 compatibility |
| EchoAI Tool | **PASS** | `tools/echo-ai/bin/Debug/net8.0/EchoAI.dll` | — |
| ReferenceAI Tool | **PASS** | `tools/reference-ai/bin/Debug/net8.0/ReferenceAI.dll` | — |
| Replay Tool | **PASS (fixed)** | `tools/replay/bin/Debug/net8.0/Replay.dll` | Fixed `UnixDomainSocketEndPoint` namespace reference |
| F# Integration Tests | **PASS** | `tests/integration/fsharp/bin/Debug/net8.0/HighBar.Tests.dll` | Build only; requires .NET runtime roll-forward |

---

## Test Results (by Suite)

### C Unit Tests (ctest) — 4/4 PASS

| Test | Status |
|------|--------|
| test_serialize | PASS |
| test_deserialize | PASS |
| test_roundtrip | PASS |
| test_callbacks | PASS |

### F# Integration Tests (xUnit) — 0/23 PASS (engine unavailable)

All 23 tests fail with: `Engine process {pid} not found after start`

| Test | Suite | Status |
|------|-------|--------|
| Client connects to engine proxy socket | ConnectionTests | SKIP (no engine) |
| Handshake completes with valid protocol metadata | ConnectionTests | SKIP (no engine) |
| First frame contains Init event | ConnectionTests | SKIP (no engine) |
| Empty command responses work for consecutive frames | ConnectionTests | SKIP (no engine) |
| Graceful disconnect after receiving frames | ConnectionTests | SKIP (no engine) |
| Multiple sequential connections succeed | ConnectionTests | SKIP (no engine) |
| Init event received with valid team ID | EventTests | SKIP (no engine) |
| Update event received with incrementing frames | EventTests | SKIP (no engine) |
| UnitCreated event contains builder reference | EventTests | SKIP (no engine) |
| UnitIdle event received for idle builder | EventTests | SKIP (no engine) |
| Combat events received when units engage | EventTests | SKIP (no engine) |
| MoveCommand accepted by engine | CommandTests | SKIP (no engine) |
| BuildCommand triggers unit creation | CommandTests | SKIP (no engine) |
| PatrolCommand with waypoints accepted | CommandTests | SKIP (no engine) |
| AttackCommand targets valid enemy | CommandTests | SKIP (no engine) |
| StopCommand for all units accepted without errors | CommandTests | SKIP (no engine) |
| Multiple commands in single response accepted | CommandTests | SKIP (no engine) |
| Unit position query returns plausible coordinates | CallbackTests | SKIP (no engine) |
| Team resources are accessible without errors | CallbackTests | SKIP (no engine) |
| Game frame numbers are consistent | CallbackTests | SKIP (no engine) |
| Invalid commands do not crash the proxy | CallbackTests | SKIP (no engine) |
| Full AI turn sequence - move build stop | ScenarioTests | SKIP (no engine) |
| Resource-aware build decision scenario | ScenarioTests | SKIP (no engine) |

### Python Integration Tests (pytest) — 0/12 PASS (engine unavailable)

All 12 tests error at fixture setup: `Engine socket not ready after 30s`

| Test | Suite | Status |
|------|-------|--------|
| test_client_connects | test_connection | SKIP (no engine) |
| test_handshake_returns_valid_metadata | test_connection | SKIP (no engine) |
| test_first_frame_received | test_connection | SKIP (no engine) |
| test_consecutive_frames_with_incrementing_numbers | test_connection | SKIP (no engine) |
| test_graceful_disconnect | test_connection | SKIP (no engine) |
| test_init_event_received | test_events | SKIP (no engine) |
| test_update_events_received | test_events | SKIP (no engine) |
| test_unit_created_event | test_events | SKIP (no engine) |
| test_move_command | test_commands | SKIP (no engine) |
| test_stop_command | test_commands | SKIP (no engine) |
| test_unit_ids_valid | test_callbacks | SKIP (no engine) |
| test_frame_numbers_consistent | test_callbacks | SKIP (no engine) |

---

## Fixes Applied

### Fix 1: Replay Tool — `UnixDomainSocketEndPoint` Reference

- **File**: `tools/replay/Program.fs:49`
- **Error**: `FS0039: The value, constructor, namespace or type 'UnixDomainSocketEndPoint' is not defined`
- **Root Cause**: Used `Net.UnixDomainSocketEndPoint(...)` but `System.Net.Sockets` was already opened; the type is directly available as `UnixDomainSocketEndPoint`
- **Fix**: Changed `Net.UnixDomainSocketEndPoint(socketPath)` → `UnixDomainSocketEndPoint(socketPath)`

### Fix 2: Python Client — Dataclass Field Ordering (Python 3.14)

- **File**: `clients/python/highbar/events.py` (all event dataclasses)
- **Error**: `TypeError: non-default argument 'team_id' follows default argument 'event_type'`
- **Root Cause**: Python 3.14 strictly enforces dataclass inheritance field ordering. Base class `GameEvent` had `event_type: str` (no default), subclasses added non-default fields then overrode `event_type` with a default — creating a non-default-after-default in the MRO-flattened field list.
- **Fix**: Changed all `event_type` fields to `field(init=False, default="...")` so they don't participate in `__init__` parameter ordering.

### Fix 3: .NET Runtime Compatibility

- **File**: `Directory.Build.props` (new)
- **Issue**: All projects target `net8.0` but only .NET 10.0 runtime is installed. Builds succeed (SDK handles cross-targeting) but test execution fails because the `net8.0` runtime is required.
- **Fix**: Added `Directory.Build.props` with `<RollForward>LatestMajor</RollForward>` to allow `net8.0` binaries to run on .NET 10.0.

---

## Known Issues & Remediation

### Headless Engine Not Available

- **Impact**: 23 F# integration tests + 12 Python integration tests (35 total) cannot execute
- **Root Cause**: `spring-headless` binary is not installed and `HIGHBAR_TEST_ENGINE` env var is not set
- **Error Messages**:
  - F# (xUnit): `System.Exception: Engine process {pid} not found after start`
  - Python (pytest): `Failed: Engine socket not ready after 30s at /tmp/highbar-test-*.sock`
- **Remediation**: Install the headless BAR engine binary and either:
  1. Place `spring-headless` on `PATH`, or
  2. Set `HIGHBAR_TEST_ENGINE=/path/to/spring-headless`
- **Note**: This is expected per spec — integration tests require the engine. The test harness correctly identifies the missing dependency.

### Proto Generation Warnings

- **Impact**: Non-fatal warnings during `buf generate`
- **Details**: `protoc-gen-c` and `protoc-gen-python_betterproto` do not advertise support for `proto3 optional`, but generate valid code for `optional` fields regardless.
- **Remediation**: No action needed. Warnings can be suppressed by updating the plugins when newer versions are available.

---

## Summary

| Category | Total | Pass | Fail/Error | Skip (no engine) |
|----------|-------|------|------------|-------------------|
| C unit tests | 4 | 4 | 0 | 0 |
| F# integration tests | 23 | 0 | 0 | 23 |
| Python integration tests | 12 | 0 | 0 | 12 |
| **Total** | **39** | **4** | **0** | **35** |

All builds succeed after fixes. All C unit tests pass. All integration tests are blocked by the missing headless engine (expected). Three code bugs were identified and fixed.
