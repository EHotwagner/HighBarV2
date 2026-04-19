# Quickstart: Using `getGameState()`

## From F#

```fsharp
open HighBar.Client

let client = Client.connect sessionConfig

// Once per GameEvent.Update:
let! snapshot = client.GetGameState()

printfn "frame=%d friendlies=%d los=%d radar=%d"
        snapshot.Frame
        snapshot.Friendlies.Length
        snapshot.LosEnemies.Length
        snapshot.RadarOnlyEnemies.Length

// Replace per-unit refreshUnit loops with snapshot.Friendlies / snapshot.LosEnemies
// Existing per-unit callbacks (getUnitPos, getUnitHealth) still work for single-unit queries.
```

## Build + test

```bash
# 1. Regenerate proto bindings after schema changes
cd proto && buf lint && buf generate && cd ..

# 2. Rebuild the proxy (deploys via post-build script)
cmake -B build -DCMAKE_BUILD_TYPE=Release -S proxy && cmake --build build

# 3. Rebuild F# client
cd clients/fsharp && dotnet build

# 4. Run tests
./tests/run-all.sh --category unit          # round-trip proto tests
./tests/run-all.sh --category proxy         # C proxy snapshot builder
./tests/run-all.sh --category integration   # live-engine snapshot correctness (needs engine)
./tests/run-all.sh --category persistent    # reference-load perf check (200+50)
```

## What to verify manually

1. A single `GetGameState()` call returns all friendlies and all visible enemies in one round-trip — confirm round-trip count in debug logs is 1, not N.
2. Radar-only enemy entries have no `Health` field at the F# type level (compile error if accessed) — the "no health" contract is structural, not runtime.
3. At the reference load (200 friendlies + 50 enemies), wall-clock round-trip stays under 10 ms (SC-001).
4. Existing single-unit callers (`getUnitPos`, `getUnitHealth`) still work unchanged — no regression in existing tests.
