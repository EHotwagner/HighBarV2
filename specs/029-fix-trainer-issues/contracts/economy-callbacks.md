# Contract: Economy Callbacks

**Feature**: 029-fix-trainer-issues
**User Story**: US2 — Economy queries return real metal/energy values
**Affected Requirements**: FR-005, FR-006, FR-007, FR-008, FR-017

## Surface

The proxy ↔ client wire surface for economy queries. Wire format is unchanged; only the proxy's response value changes from "always 0.0" to "real engine state."

## Before / After

### Before (broken)

```
Client → CallbackRequest{ id: CALLBACK_ECONOMY_GET_CURRENT, params: [resourceId=0] }
Proxy  → switch on id ... falls through to default
Proxy → CallbackResponse{ success: false, error: "Unknown callback ID" }
Client (Client.fs:400-433) → silently maps !success to 0.0f
Caller → 0.0f for every query
```

### After (fixed)

```
Client → CallbackRequest{ id: CALLBACK_ECONOMY_GET_CURRENT, params: [resourceId=0] }
Proxy  → switch on id → matches new ECONOMY_GET_CURRENT case
       → if resourceId ∉ {0,1}: make_float_response(req_id, NaN)
       → else: float v = callback->Economy_getCurrent(skirmish_ai_id, resourceId)
              make_float_response(req_id, v)
Proxy → CallbackResponse{ success: true, result: { float_value: <real metal storage> } }
Client (Client.fs) → reads float_value, surfaces to caller
                   → if Single.IsNaN(v): caller sees Single.NaN
```

## API Contract — F# client (`clients/fsharp/src/Client.fs`)

### Existing public surface (no breaking change)

```fsharp
module Callbacks =
    val getEconomyCurrent : Stream -> int -> float32  // resourceId → value
    val getEconomyIncome  : Stream -> int -> float32
    val getEconomyUsage   : Stream -> int -> float32
    val getEconomyStorage : Stream -> int -> float32
```

### Behavioral contract (new)

| Input | Pre-fix return | Post-fix return |
|---|---|---|
| `resourceId = 0` (metal) | `0.0f` always | Real metal storage as `Spring.GetTeamResources(myTeam, "metal").current` |
| `resourceId = 1` (energy) | `0.0f` always | Real energy storage |
| `resourceId = 2..N` (unknown) | `0.0f` (silent) | `Single.NaN` (detectable via `Single.IsNaN`) |
| `resourceId = -1` (invalid) | `0.0f` (silent) | `Single.NaN` |

### Caller-side detection of invalid id

```fsharp
let metal = Callbacks.getEconomyCurrent client.Stream 0
let energy = Callbacks.getEconomyCurrent client.Stream 1
let bogus = Callbacks.getEconomyCurrent client.Stream 99
// metal, energy: real numbers >= 0
// bogus: Single.NaN — caller can detect with Single.IsNaN bogus
```

### F# client implementation note

`Client.fs` may decide to wrap the new NaN behavior in an opt-in helper (e.g., `tryGetEconomyCurrent` returning `float32 voption`) instead of changing the existing function's contract. **The plan defers this ergonomic decision** — the wire contract is the only thing pinned by this feature. Either the existing function returns `Single.NaN` directly, or a new `tryGet*` variant exists alongside; both satisfy FR-008.

## API Contract — C proxy (`proxy/src/callbacks.c`)

### New switch cases (added before `default:` at line 457)

```c
case HIGHBAR__CALLBACK_ID__CALLBACK_ECONOMY_GET_CURRENT: {
    if (!callback->Economy_getCurrent) {
        return make_error_response(req_id, "Economy_getCurrent unavailable", alloc);
    }
    int rid = get_int_param(request, 0, 0);
    if (rid < 0 || rid > 1) {
        return make_float_response(req_id, NAN, alloc);
    }
    float v = callback->Economy_getCurrent(skirmish_ai_id, rid);
    return make_float_response(req_id, v, alloc);
}

case HIGHBAR__CALLBACK_ID__CALLBACK_ECONOMY_GET_INCOME:   { /* analogous */ }
case HIGHBAR__CALLBACK_ID__CALLBACK_ECONOMY_GET_USAGE:    { /* analogous */ }
case HIGHBAR__CALLBACK_ID__CALLBACK_ECONOMY_GET_STORAGE:  { /* analogous */ }
```

### Implementation invariants

- **No proto schema change.** Reuses the existing `make_float_response` helper.
- **No heap allocation per call.** `make_float_response` uses arena allocation per Constitution V.
- **No engine API speculation.** All four `Economy_get*` functions are documented at `SSkirmishAICallback.h:454-470` and exist in the vendored header.
- **NaN sentinel** is the only "extra" semantic — the engine itself may also return NaN for unknown ids; the proxy's explicit check is defense-in-depth and ensures the contract holds even if the engine changes.

## Test Contract

### C round-trip test (`proxy/tests/test_callbacks.c`)

```c
TEST(test_economy_get_current_metal) {
    mock_engine_set_economy_current(0, 123.5f);  // resourceId=0 → 123.5
    CallbackResponse *resp = dispatch(CALLBACK_ECONOMY_GET_CURRENT, /*params=*/ {0});
    ASSERT_TRUE(resp->success);
    ASSERT_EQ(resp->result.float_value, 123.5f);
}

TEST(test_economy_get_current_invalid_id_returns_nan) {
    CallbackResponse *resp = dispatch(CALLBACK_ECONOMY_GET_CURRENT, /*params=*/ {99});
    ASSERT_TRUE(resp->success);
    ASSERT_TRUE(isnan(resp->result.float_value));
}
```

Mock engine additions in `proxy/tests/mock_engine.{c,h}`: stub `Economy_getCurrent`, `Economy_getIncome`, `Economy_getUsage`, `Economy_getStorage` returning configurable per-resource values.

### Live engine test (`tests/persistent/fsharp/T029_EconomyCallbacks.fs`)

```fsharp
[<Fact>]
member _.``T029.1 EconomyCurrent metal returns nonzero after income accrues``() =
    engine.ResetGameState()
    let (_, _) = engine.RunFrames(400, fun _ _ -> [])  // wait for income
    let metal = Callbacks.getEconomyCurrent client.Stream 0
    let energy = Callbacks.getEconomyCurrent client.Stream 1
    Assert.True(metal > 0.0f, $"metal should be positive after 400 frames, got {metal}")
    Assert.True(energy > 0.0f, $"energy should be positive after 400 frames, got {energy}")

[<Fact>]
member _.``T029.2 EconomyCurrent invalid resourceId returns NaN``() =
    let v = Callbacks.getEconomyCurrent client.Stream 99
    Assert.True(Single.IsNaN v, $"expected NaN for resourceId=99, got {v}")
```

These satisfy FR-017 and FR-008 acceptance.
