# Report: Test Suite Overview

**Date**: 2026-04-02
**Iteration**: 7

## Context

Final summary of the headless integration test suite development. This report documents total test count, coverage by category, known limitations, and recommended next steps.

## Test Count Summary

### F# Integration Tests (tests/integration/fsharp/)

| Category | File | Test Count | Description |
|----------|------|------------|-------------|
| Harness | ConnectionTests.fs | 1 | Engine starts, socket available |
| Connection | ConnectionTests.fs | 4 | Connect, handshake, frames, disconnect |
| Events | EventTests.fs | 6 | Init, Update, UnitCreated, UnitIdle, Unknown, Combat |
| Commands | CommandTests.fs | 6 | Move, Stop, Build, Patrol, Guard/Attack/Repair/Fight, StopAll |
| Callbacks | CallbackTests.fs | 4 | Unit position, resources, frame numbers, invalid callback |
| Scenarios | ScenarioTests.fs | 1 | Full AI turn sequence |
| **Total** | | **22** | |

**Total: 22 F# integration tests**

## Coverage by User Story

| User Story | Priority | F# Tests | Status |
|------------|----------|----------|--------|
| US1: Connection & Handshake | P1 (MVP) | 5 | Complete |
| US2: Event Delivery | P2 | 6 | Complete |
| US3: Command Execution | P2 | 7 | Complete |
| US4: Callback Queries | P2 | 4 | Complete (indirect) |
| US5: Reports & KB | P3 | - | Complete |

## Known Limitations

1. **Callback queries are indirect**: The F# client doesn't expose a direct callback query API. Tests validate callback-dependent behavior through events and state consistency rather than direct queries.

3. **Combat event coverage**: UnitDamaged tests depend on the game scenario producing combat. With builder-only units, combat may not occur. The expanded game-setup.lua places teams closer, but armed units may be needed.

4. **BuildCommand unitDefId**: Tests use a hardcoded `unitDefId=1` which may not be valid for all game content. The test verifies the command doesn't crash rather than verifying the build succeeds.

5. **Frame loop termination**: Tests use exception-based control flow (`failwith "CAPTURED_ENOUGH"`) to exit the blocking `Run()` loop. This is functional but not ideal.

## Recommended Next Steps

1. **Add direct callback API**: Extend the F# client to support explicit callback queries (if the proxy protocol supports it).

3. **Expand game scenario**: Add armed units to game-setup.lua to ensure combat events fire reliably.

4. **Add timeout assertions**: Verify tests complete within expected time bounds (not just that they complete).

5. **CI integration**: Document and test the suite in a CI environment with spring-headless and the proxy plugin pre-installed.

6. **Replay tool fallback**: Implement a test mode using the `tools/replay/` recorded session replayer for environments without the full engine.

## Architecture Notes

- **Test isolation**: Each test run uses a unique socket path (`/tmp/highbar-test-{guid}.sock`) to prevent interference
- **Engine sharing**: All tests in a collection share one engine instance via `ICollectionFixture<EngineFixture>`
- **Language-agnostic fixtures**: Shell scripts (`start-headless.sh`, `stop-headless.sh`) and Lua (`game-setup.lua`) are shared across test suites
- **Report-driven development**: Each phase produces an iteration report capturing problems and solutions for institutional memory
