# Research: Remove Python and Upgrade to .NET 10

**Feature**: 019-remove-python-dotnet10 | **Date**: 2026-04-04

## R1: .NET 10 Compatibility

**Decision**: Upgrade all 11 .fsproj files from `net8.0` to `net10.0`

**Rationale**: .NET 10 SDK (10.0.104) is already installed in the development environment. All NuGet package dependencies use flexible version constraints (e.g., `3.28.*`, `17.*`) that resolve correctly under .NET 10. No breaking API changes affect this codebase — it uses standard protobuf serialization, xUnit testing, and System.Text.Json, all of which are fully supported.

**Alternatives considered**:
- net9.0 (STS release, shorter support window — rejected)
- Stay on net8.0 (still in support but user explicitly requested .NET 10 — rejected)

**Risks**: None identified. The codebase uses mainstream APIs with no platform-specific P/Invokes or deprecated framework features.

## R2: patch-chobby-ai.py Replacement

**Decision**: Rewrite as `patch-chobby-ai.sh` (Bash script)

**Rationale**: The Python script reads gzipped .sdp (Spring Data Package) files, locates `aisimplename.lua` in a pool directory, and patches Lua configuration text. The core operations are:
1. Parse .sdp (gzipped text with file listings) — `zcat` + `grep`
2. Read pool files by MD5 path — `cat` with path construction
3. Text replacement in Lua source — `sed`
4. Write back to pool — redirect

These are all natural Bash operations. The script is ~110 lines of Python; the Bash equivalent should be comparable in length.

**Alternatives considered**:
- Keep as Python (defeats the purpose of removing Python — rejected)
- Rewrite in F# as a dotnet tool (overkill for a deployment config script — rejected)
- Rewrite in C (unnecessary complexity — rejected)

## R3: dummy-client.py Replacement

**Decision**: Remove without replacement; existing F# test infrastructure covers the same functionality

**Rationale**: The `dummy-client.py` fixture is a minimal socket client that accepts proxy connections, performs handshake, reads frames, and sends empty responses. The F# test harness (`HighBar.Tests`, `HighBar.PersistentTests`) already implements equivalent functionality using the F# client library. The Python fixture was a bootstrapping tool from early development; it is no longer referenced by any active test.

**Alternatives considered**:
- Rewrite as F# standalone tool (unnecessary — F# test harness already exists — rejected)
- Keep as Python (defeats the purpose — rejected)

## R4: betterproto Code Generation Removal

**Decision**: Remove the betterproto plugin entry from `proto/buf.gen.yaml` and delete `proto/gen/python/` if it exists

**Rationale**: The betterproto plugin generates Python protobuf bindings. With the Python client removed, these generated files have no consumers. The F# (Google.Protobuf) and C (protobuf-c) generation targets are unaffected — they are separate plugin entries in buf.gen.yaml.

**Alternatives considered**:
- Keep Python generation for potential future use (unnecessary — can be re-added from schema at any time — rejected)

## R5: Test Runner Cleanup

**Decision**: Remove the `python` test category from `tests/run-all.sh`

**Rationale**: The test runner checks for pytest and runs `tests/integration/python/` when the `python` category is selected. With those tests and pytest removed, the category becomes dead code. The remaining categories (proxy, unit, data, integration, persistent, ai) cover all active test suites.

**Alternatives considered**:
- Leave as a no-op category (confusing for developers — rejected)

## R6: Documentation Python References

**Decision**: Update all documentation to remove Python mentions and update .NET version references

**Rationale**: CLAUDE.md, spec files, and shell scripts all reference Python 3.10+, betterproto, pytest, and pip as project technologies. These references must be updated to reflect the actual state: F#/.NET 10 and C11 only. Historical spec files in `specs/` subdirectories will have their technology sections updated but content otherwise preserved.

**Files requiring documentation updates**:
- `CLAUDE.md` — Active Technologies, Commands, Project Structure sections
- `specs/001-native-proxy-bridge/` — plan.md, spec.md (betterproto, Python client references)
- `specs/002-headless-test-suite/` — plan.md (Python 3.10+, pytest references)
- `specs/003-tools-prereqs-test-fixes/` — plan.md, spec.md (betterproto, Python references)
- `tests/setup-engine.sh` — summary comments mentioning pytest
