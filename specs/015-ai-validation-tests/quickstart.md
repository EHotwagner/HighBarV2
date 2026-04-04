# Quickstart: AI Validation and Competitive Testing

**Feature**: 015-ai-validation-tests | **Date**: 2026-04-04

## Prerequisites

1. **Headless engine** installed (`spring-headless` on PATH or `HIGHBAR_TEST_ENGINE` set)
2. **Live graphical engine** installed (for US2/US4 — path in `start-live.sh`)
3. **Xvfb** installed and running (for US2/US4 — `Xvfb :99 -screen 0 1024x768x24 &`)
4. **BAR game content** installed (game archive + Comet Catcher Remake map)
5. **BARbarianAI** installed in engine's AI directory (for US2)
6. **Proxy** built: `cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build`
7. **F# client** builds: `cd clients/fsharp && dotnet build`

## Build

```bash
# Build all test projects
cd tests/ai/fsharp && dotnet build
```

## Run Tests

### End-to-End Validation (US1 — headless, ~3 min)

```bash
dotnet test tests/ai/fsharp/ --filter "Category=EndToEnd" --logger "console;verbosity=normal"
```

Runs 10 games against NullAI using headless engine. Validates: no crashes, economy bootstrap, army production, 100% win rate.

### Competitive Validation (US2 — live + Xvfb, ~20 min)

```bash
export DISPLAY=:99  # Or wherever Xvfb is running
dotnet test tests/ai/fsharp/ --filter "Category=Competitive" --logger "console;verbosity=normal"
```

Runs 10 games against BARb using live graphical engine. Validates: 15+ minute survival in 80% of games.

### Non-Combat Suite (US3 — headless, ~6 min)

```bash
dotnet test tests/ai/fsharp/ --filter "Category=NonCombat" --logger "console;verbosity=normal"
```

Runs 20 games validating economy, build order, movement, and scouting. Target: 95%+ pass rate.

### Combat Suite (US4 — live + Xvfb, ~10 min)

```bash
export DISPLAY=:99
dotnet test tests/ai/fsharp/ --filter "Category=Combat" --logger "console;verbosity=normal"
```

Runs 10 games validating combat events (WeaponFired, UnitDamaged, UnitDestroyed). Target: 90%+ pass rate.

### All Suites

```bash
export DISPLAY=:99
dotnet test tests/ai/fsharp/ --logger "console;verbosity=normal"
```

## Reports

After each suite runs, a markdown report is written to `tests/ai/fsharp/reports/`. Reports include per-game outcomes and aggregate success criteria pass/fail.

## Key Architecture Decisions

- **AI brain runs in-process**: Test fixture creates `GameState`, passes `createFrameHandler` to `client.Run()`. No separate AI process needed.
- **Headless for non-combat, live for combat**: Headless engine doesn't simulate weapon physics. Combat validation requires live engine + Xvfb.
- **Natural game ending**: End-to-end and competitive tests remove `deathmode=neverend` so games end when one team is eliminated.
- **Independent games**: Each game in a batch gets a fresh engine instance. A crash in game 3 doesn't prevent game 4.
