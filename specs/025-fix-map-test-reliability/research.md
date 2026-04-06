# Research: Fix Map Test Reliability

**Feature**: 025-fix-map-test-reliability  
**Date**: 2026-04-06

## R1: Proxy Callback Support Status

**Decision**: No proxy changes needed — all 5 map callbacks (52-56) are fully implemented.

**Rationale**: Verified in `proxy/src/callbacks.c` lines 198-281. All callbacks have:
- Correct buffer allocation and engine API calls
- Proper response construction (`make_float_array_response` / `make_int_array_response`)
- Memory cleanup
- Mock test coverage in `proxy/tests/test_callbacks.c` lines 124-215

**Alternatives considered**: None — the proxy work was completed in feature 021.

## R2: F# Client Wrapper Pattern

**Decision**: Follow the existing `GetHeightMap()` pattern for float returns and `GetUnitDefs()` pattern for int returns.

**Rationale**: 
- FloatArrayValue: `resp.Result.FloatArrayValue.Values |> Seq.toArray` (Client.fs:272-273)
- IntArrayValue: `resp.Result.IntArrayValue.Values |> Seq.map int |> Seq.toArray` (Client.fs:186-187)
- Parameterized callbacks: Use `CallbackParam()` with `p.IntValue <- value` (Client.fs:278-279)

**Alternatives considered**: Direct array access vs Seq pipeline. Seq pipeline is the established pattern across all existing methods — consistency wins.

## R3: Silent Skip Replacement Strategy

**Decision**: Replace `output.WriteLine("SKIP: ...")` with `Assert.Fail("...")` in all map test branches.

**Rationale**: The proxy now supports all map callbacks. A `None` result from `queryInFrame` indicates a real failure (connection error, protocol error), not a missing feature. Tests should fail loudly to catch regressions.

**Alternatives considered**:
- `Assert.Skip()` (xUnit v3 feature) — not available in xUnit 2.9.x
- `[<Fact(Skip="reason")>]` — wrong because the callbacks ARE supported now
- Keep silent skips — defeats the purpose of this feature

## R4: Always-True Assertion Fix

**Decision**: Replace `Assert.True(losEvents.Length >= 0)` with `output.WriteLine` logging.

**Rationale**: LOS events are genuinely optional (depend on map size, unit placement, timing). Cannot assert they exist (flaky). Cannot assert they don't exist (also wrong). The current assertion (`>= 0`) is a tautology. Logging the count preserves diagnostic value without false confidence.

**Alternatives considered**:
- Remove entirely — loses diagnostic value in test output
- Assert `> 0` — would be flaky depending on test scenario
- Assert specific count — too brittle
