# Quickstart: 024-fix-persistent-test-gaps

## Prerequisites

- .NET 10.0 SDK
- Persistent tests build: `cd tests/persistent/fsharp && dotnet build`
- Headless BAR engine available (checked by `./tests/check-prerequisites.sh`)

## Key Files

| Purpose | Path |
|---------|------|
| Map tests (T9 fix) | `tests/persistent/fsharp/T9_MapTests.fs` |
| Test harness (init fix) | `tests/persistent/fsharp/PersistentHarness.fs` |
| Engine-kill tests (new) | `tests/persistent/fsharp/T10_EngineKillTests.fs` |

## The Bugs

### T9.3/T9.4 Map Test Failures
- T9.3 and T9.4 don't call `ResetGameState()` before querying map callbacks
- The `queryInFrame` helper silently swallows all exceptions (`with _ -> ()`)
- Result: after heavy combat tests, map queries fail silently and tests produce misleading "SKIP" messages instead of passing

### Init Disconnect Handling
- `InitializeAsync` has three `c.Run(...)` warm-up loops with no `EngineDisconnectedException` catch
- If engine dies during warm-up, a raw exception propagates with no diagnostic info

## Testing the Fixes

```bash
# Build persistent tests
cd tests/persistent/fsharp && dotnet build

# Run full persistent suite (should be 47/47 pass)
./tests/run-all.sh --category persistent

# Run just T9 map tests
dotnet test tests/persistent/fsharp/ --filter "T9"

# Run just engine-kill verification tests
dotnet test tests/persistent/fsharp/ --filter "T10"

# Run T10 with custom timeout
HIGHBAR_CLIENT_TIMEOUT_MS=2000 dotnet test tests/persistent/fsharp/ --filter "T10.3"
```
