# Implementation Plan: Fix Unit Commands

**Branch**: `017-fix-unit-commands` | **Date**: 2026-04-04 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/017-fix-unit-commands/spec.md`

## Summary

Unit commands (move, patrol, fight, etc.) sent by the HighBarV2 proxy are silently dropped by the Recoil GameServer because the proxy passes `commandId = 0` as the third parameter to `Engine_handleCommand`. This causes the engine to create `NETMSG_AICOMMAND_TRACKED` network packets, which the GameServer has no handler for. The fix is to pass `-1` instead, producing `NETMSG_AICOMMAND` packets that are correctly processed. CircuitAI and BARb AI both use `-1`.

## Technical Context

**Language/Version**: C11 (proxy), F# / .NET 8.0 (client)
**Primary Dependencies**: protobuf-c (C proxy), Google.Protobuf 3.28 (F#)
**Storage**: N/A
**Testing**: CTest (C proxy tests), xUnit (F# tests)
**Target Platform**: Linux x86_64
**Project Type**: Shared library (proxy) + client library (F#)
**Performance Goals**: < 1ms total proxy overhead per frame
**Constraints**: No engine modifications (constitution principle I)
**Scale/Scope**: Single constant change in ~35 call sites + 3 direct test call sites + mock engine test enhancement

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | Fix is entirely in the proxy; no engine patches |
| II. Binary Protocol First | PASS | No protocol changes; protobuf messages unchanged |
| III. Correctness Over Cleverness | PASS | Fix is a single constant correction (`0` → `-1`) matching the engine's expected interface contract |
| IV. Test at the Boundary | PASS | Will add mock engine verification of `commandId` parameter |
| V. Latency Budget Discipline | PASS | No performance impact — same code path, different constant |
| VI. Language-Agnostic by Default | PASS | No proto schema changes |
| VII. Explicit Over Implicit | PASS | The `-1` sentinel is explicit in the engine API; documenting it via a named constant improves clarity |

## Project Structure

### Documentation (this feature)

```text
specs/017-fix-unit-commands/
├── plan.md              # This file
├── research.md          # Root cause analysis (Phase 0)
├── data-model.md        # Affected data structures (Phase 1)
└── quickstart.md        # Verification steps (Phase 1)
```

### Source Code (files to modify)

```text
proxy/
├── include/highbar/
│   └── engine_types.h        # Add COMMAND_ID_UNTRACKED constant
├── src/
│   ├── deserialize.c          # Change 0 → -1 in ~35 handle_command() calls
│   ��── proxy.c                # Update/remove direct test code
└── tests/
    ├── mock_engine.c          # Record and expose commandId for verification
    ├── mock_engine.h          # Add commandId getter
    └── test_deserialize.c     # Add commandId assertions

clients/fsharp/
└── src/Commands.fs            # No changes needed (commandId is proxy-side)
```

**Structure Decision**: Existing project structure. All changes are within existing files — no new files needed except spec artifacts.

## Complexity Tracking

No violations. This is a minimal bug fix.
