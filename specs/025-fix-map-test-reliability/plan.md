# Implementation Plan: Fix Map Test Reliability

**Branch**: `025-fix-map-test-reliability` | **Date**: 2026-04-06 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/025-fix-map-test-reliability/spec.md`

## Summary

Add 4 missing F# client wrappers for proxy map callbacks (slope, LOS, radar, resource), replace silent-skip test patterns with real assertions, add new map data tests, and fix an always-true assertion. The proxy already implements all callbacks — this is purely client + test work.

## Technical Context

**Language/Version**: F# / .NET 10.0  
**Primary Dependencies**: HighBar.Client, Google.Protobuf 3.28, xUnit 2.9.x  
**Storage**: N/A  
**Testing**: xUnit persistent tests (live engine), xUnit integration tests  
**Target Platform**: Linux (BAR headless engine)  
**Project Type**: Library (client) + test harness  
**Performance Goals**: N/A (test reliability, not performance)  
**Constraints**: Must follow existing Client.fs patterns exactly  
**Scale/Scope**: 3 files modified, ~80 lines added

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | No engine changes — client + tests only |
| II. Binary Protocol First | PASS | Uses existing protobuf callbacks, no new protocol |
| III. Correctness Over Cleverness | PASS | New wrappers are 1:1 copies of existing pattern |
| IV. Test at the Boundary | PASS | Tests validate callback response data at the serialization boundary |
| V. Latency Budget Discipline | PASS | No hot-path changes |
| VI. Language-Agnostic by Default | PASS | Thin typed wrappers above generated protobuf code |
| VII. Explicit Over Implicit | PASS | Tests fail explicitly instead of silently skipping |

No violations. Complexity Tracking table not needed.

## Project Structure

### Documentation (this feature)

```text
specs/025-fix-map-test-reliability/
├── plan.md              # This file
├── research.md          # Phase 0 output
├── data-model.md        # Phase 1 output
└── checklists/
    └── requirements.md  # Spec quality checklist
```

### Source Code (files to modify)

```text
clients/fsharp/src/Client.fs          # Add 4 new map data methods
tests/persistent/fsharp/T9_MapTests.fs # Replace skips, add 4 new tests
tests/integration/fsharp/EventTests.fs # Fix always-true assertion
```

**Structure Decision**: No new files. All changes are additions/modifications to existing files following established patterns.

## Implementation Details

### Phase 1: Client.fs — Add 4 Map Data Wrappers

Insert after `GetHeightMap()` (line 274), before `GetStartPos` (line 276).

**GetSlopeMap** — follows exact `GetHeightMap` pattern (FloatArrayValue):
```fsharp
member this.GetSlopeMap() : float32 array =
    let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetSlopeMap, [])
    if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.FloatArrayValue then
        resp.Result.FloatArrayValue.Values |> Seq.toArray
    else [||]
```

**GetLosMap** — follows `GetUnitDefs` pattern (IntArrayValue, line 186):
```fsharp
member this.GetLosMap() : int array =
    let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetLosMap, [])
    if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntArrayValue then
        resp.Result.IntArrayValue.Values |> Seq.map int |> Seq.toArray
    else [||]
```

**GetRadarMap** — same IntArrayValue pattern:
```fsharp
member this.GetRadarMap() : int array =
    let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetRadarMap, [])
    if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntArrayValue then
        resp.Result.IntArrayValue.Values |> Seq.map int |> Seq.toArray
    else [||]
```

**GetResourceMap** — IntArrayValue with int param (follows `GetStartPos` param pattern):
```fsharp
member this.GetResourceMap(resourceId: int) : int array =
    let p = CallbackParam()
    p.IntValue <- resourceId
    let resp = this.SendCallback(uint32 CallbackId.CallbackMapGetResourceMap, [p])
    if resp.Success && resp.Result <> null && resp.Result.ValueCase = CallbackResult.ValueOneofCase.IntArrayValue then
        resp.Result.IntArrayValue.Values |> Seq.map int |> Seq.toArray
    else [||]
```

### Phase 2: T9_MapTests.fs — Replace Silent Skips + Add Tests

**A. Replace silent-skip branches in T9.1-T9.4:**

| Test | Line | Old | New |
|------|------|-----|-----|
| T9.1 | 50-51 | `\| _ -> output.WriteLine("SKIP: ...")` | `\| _ -> Assert.Fail("Map dimension callbacks should be supported by proxy")` |
| T9.2 | 68-69 | `\| Some _ -> output.WriteLine("SKIP: ...")` | `\| Some _ -> Assert.Fail("Height map returned empty — proxy should return data")` |
| T9.2 | 70-71 | `\| None -> output.WriteLine("SKIP: ...")` | `\| None -> Assert.Fail("Height map callback should be supported by proxy")` |
| T9.3 | 91-92 | `\| _ -> output.WriteLine("SKIP: ...")` | `\| _ -> Assert.Fail("Start position and map dimension callbacks should be supported by proxy")` |
| T9.4 | 113-114 | `\| Some _ -> output.WriteLine("SKIP: ...")` | `\| Some _ -> Assert.Fail("Metal spots should be non-empty on a real map")` |
| T9.4 | 115-116 | `\| None -> output.WriteLine("SKIP: ...")` | `\| None -> Assert.Fail("Metal spots callback should be supported by proxy")` |

**B. Add 4 new tests after T9.4 (after line 116):**

- **T9.5 Slope map** — `queryInFrame (fun c -> c.GetSlopeMap())`, assert non-empty, values in [0, 1]
- **T9.6 LOS map** — `queryInFrame (fun c -> c.GetLosMap())`, assert non-empty, values >= 0
- **T9.7 Radar map** — `queryInFrame (fun c -> c.GetRadarMap())`, assert non-empty, values >= 0
- **T9.8 Resource map (metal)** — `queryInFrame (fun c -> c.GetResourceMap(0))`, assert non-empty, values >= 0

All new tests use `Assert.Fail` for empty/None branches (no silent skips).

### Phase 3: EventTests.fs — Fix Always-True Assertion

Replace line 169:
```fsharp
// Before:
Assert.True(losEvents.Length >= 0, "LOS events count should be non-negative")
// After:
output.WriteLine($"LOS events: {losEvents.Length} (optional — depends on map size and unit placement)")
```

LOS events are genuinely optional (depends on map/unit placement). Asserting they exist would be flaky. Asserting `>= 0` is tautological. Replace with informational logging.

## Implementation Order

1. **Client.fs** — add 4 methods (tests depend on these)
2. **T9_MapTests.fs** — replace skips + add tests
3. **EventTests.fs** — single-line fix

## Verification

1. `dotnet build` in `clients/fsharp/` — confirms new methods compile and CallbackId enum members resolve
2. `dotnet build` in `tests/persistent/fsharp/` and `tests/integration/fsharp/` — confirms test compilation
3. `./tests/run-all.sh --category persistent` — all T9 tests pass with real assertions (no SKIP messages in output)
4. `./tests/run-all.sh --category integration` — EventTests still pass
5. Grep for `"SKIP:"` in T9_MapTests.fs — should find zero matches after changes

## Risks

- **CallbackId enum naming**: `CallbackMapGetSlopeMap` follows the same `CALLBACK_MAP_GET_SLOPE_MAP` -> PascalCase convention as all other enum values. Low risk.
- **LOS/Radar map sizes vary**: These depend on engine mip level, so tests assert non-empty + non-negative only (not specific sizes). Correct.
- **queryInFrame exception handling**: The existing helper already handles disconnects. `Assert.Fail` in match arms only fires when `queryInFrame` successfully returns `None`/empty.
