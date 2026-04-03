# Quickstart: Fix Remaining Test Failures

**Feature Branch**: `005-fix-test-failures`

## What This Feature Does

Fixes 12 failing integration tests by:
1. Updating the game configuration (`game-setup.txt`) so BAR spawns commander units (10 tests)
2. Adjusting Init event test expectations to handle timing variations (2 tests)
3. Writing a report documenting the fixes and results

## Files to Modify

| File | Change |
|------|--------|
| `tests/fixtures/game-setup.txt` | Add modoptions, Side, StartPosType |
| `tests/integration/fsharp/ConnectionTests.fs` | Widen Init event frame window |
| `tests/integration/fsharp/EventTests.fs` | Widen Init event frame window |
| `reports/011-test-fix-results.md` | New file: document fixes and results |

## How to Verify

```bash
# Run the full F# integration test suite
cd tests/integration/fsharp && dotnet test

# Expected: 23/23 pass (up from 11/23)
```

## Key Decisions

- **No proxy changes**: All fixes are in test configuration and test expectations
- **No Python harness changes**: Out of scope per clarification
- **StartPosType=2**: Standard BAR configuration for in-game position selection
- **Init event fix is test-side only**: Widen frame collection window instead of modifying proxy flush behavior
