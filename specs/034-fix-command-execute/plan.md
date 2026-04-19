# Implementation Plan: Fix Scripting Command Execution (Proxy → Engine Handoff)

**Branch**: `034-fix-command-execute` | **Date**: 2026-04-19 | **Spec**: [spec.md](./spec.md)
**Input**: `/home/developer/projects/HighBarV2/specs/034-fix-command-execute/spec.md`

## Summary

Feature 033 proved that scripting-origin `AICommand`s reach the proxy dispatch loop and are accepted by the engine (`engine_rc=0`), but no engine-observable effect occurs. This feature finds the correct proxy↔engine handoff convention empirically via a temporary in-proxy probe that compares `Engine_handleCommand` vs. `Engine_executeCommand` (and/or `toId` variants), adopts the one that actually causes the engine to queue the order, and removes the probe. The fix is expected to be ≤50 LOC in `proxy/src/proxy.c` or `proxy/src/deserialize.c`, with no schema changes and no engine modifications.

## Technical Context

**Language/Version**: C11 (proxy, the only code that changes), F# / .NET 10.0 (live regression tests)
**Primary Dependencies**: protobuf-c (proxy), Recoil `SSkirmishAICallback` vendored headers (`proxy/include/AI/`), HighBar.Client (Google.Protobuf 3.28), xUnit 2.9.x
**Storage**: N/A — the change is in-process proxy dispatch; logs to `engine.infolog` and temporary session dirs under `/tmp` only
**Testing**: xUnit persistent/live-engine tests via `./tests/run-all.sh --category persistent`; FSBarV1 `diag_one_build.py` as end-to-end gate
**Target Platform**: Linux x86_64, spring-headless 2025.06.19, BAR game archive
**Project Type**: Proxy shared library + F# client + test harness (existing layout, no new projects)
**Performance Goals**: No regression to 033 per-command overhead budget; dispatch remains on the hot path (`handleEvent` thread), no heap allocation per command
**Constraints**: Constitution I (no engine mods), II (no wire-format changes), V (<1ms proxy overhead per frame), VIII (033 `[HB] dispatch` log contract must survive verbatim)
**Scale/Scope**: ≤50 LOC proxy change, 1 new persistent test covering ≥4 per-unit command types, 1 mailbox reply

## Constitution Check

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | Fix lives in proxy; empirical probe reads engine effect via existing logs/callbacks only. |
| II. Binary Protocol First | PASS | No schema changes. Wire format unchanged. |
| III. Correctness Over Cleverness | PASS | Goal is to adopt the single engine-documented convention that actually works; probe is removed before ship (FR-008). |
| IV. Test at the Boundary | PASS | New persistent test exercises real engine end-to-end; covers BUILD, MOVE, STOP, REPAIR. |
| V. Latency Budget Discipline | PASS | Final change is a single callback swap or `toId` tweak; no added allocations. |
| VI. Language-Agnostic by Default | PASS | Fix validated from F# test harness *and* FSBarV1 Python repro. |
| VII. Explicit Over Implicit | PASS | The 033 `[HB] dispatch` log line is preserved (FR-002); chosen convention is documented in the mailbox reply (FR-007). |

**Result**: No violations. Complexity Tracking section not needed.

## Project Structure

### Documentation (this feature)

```text
specs/034-fix-command-execute/
├── plan.md              # This file
├── research.md          # Phase 0: probe strategy + convention hypotheses
├── data-model.md        # Phase 1: dispatch-convention decision table
├── quickstart.md        # Phase 1: how to reproduce the fix locally
├── contracts/
│   └── dispatch-log.md  # Phase 1: 033 log contract preserved, plus mailbox schema
└── tasks.md             # (created by /speckit.tasks)
```

### Source Code (repository root)

```text
proxy/
├── src/
│   ├── proxy.c                  # Primary edit site (dispatch callback + toId)
│   └── deserialize.c            # Secondary edit site if SCommand layout is at fault
└── include/AI/                  # Recoil vendored headers (read-only reference)

clients/fsharp/
└── HighBar.Client/              # Version bump (FR-006), no code changes expected

tests/
├── persistent/                  # New test covering BUILD/MOVE/STOP/REPAIR (FR-004)
└── run-all.sh                   # Existing unified runner

Mailbox/                         # Reply written here (FR-007)
```

**Structure Decision**: Existing monorepo layout is sufficient. The feature is a localized proxy bug fix plus one new persistent F# test. No new projects, directories, or build targets.

## Complexity Tracking

Not applicable — no constitution violations.
