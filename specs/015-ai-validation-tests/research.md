# Research: AI Validation and Competitive Testing

**Feature**: 015-ai-validation-tests | **Date**: 2026-04-04

## R1: Multi-Game Orchestration Architecture

**Decision**: The test harness drives the AI brain by passing frames to `GameState.createFrameHandler` (in-process, Option A).

**Rationale**: The existing socket architecture has a 1:1 relationship — one socket path connects one AI process to the proxy. The test harness already fills the AI role (receives frames via `client.Run(onFrame)`). Passing the AI brain's frame handler as the `onFrame` callback is the simplest integration: zero additional processes, full observability of `DecisionLog`/`UnitRegistry`/`TaskAssigner` state, and fresh `GameState` per game.

**Alternatives considered**:
- **Separate AI process** (Option B): Would require spawning reference-ai as a separate executable, adds IPC complexity, loses observability, doesn't match game-setup.txt's single-socket architecture. Rejected.
- **Hybrid** (Option C): Test drives AI for N frames then injects test-specific commands. Viable for edge-case testing but unnecessary for end-to-end validation. Deferred.

**Implementation pattern**:
```fsharp
// Per game:
let gs = GameState.init client teamId logPath
let frameHandler = GameState.createFrameHandler gs
client.Run(frameHandler)
// After game: inspect gs.UnitRegistry, gs.Economy, gs.DecisionLog
```

## R2: Game Termination and Win/Loss Detection

**Decision**: Use three approaches depending on test type and engine:
1. **End-to-end tests (headless, US1)**: Keep `deathmode=neverend` because headless engine cannot simulate weapon physics — games can never end via combat. Use a frame timeout (18000 frames = 10 min) as the termination mechanism. "Success" means competency milestones met (economy, army production) without crash or stall, not literal win/loss.
2. **Competitive tests (live engine, US2)**: Change `deathmode` from `neverend` to default (`killall` — game ends when one team is eliminated). Detect game end via `Shutdown` message with `GAME_OVER` reason. Frame timeout at 108000 frames (60 min) as safety net.
3. **Non-combat/combat unit tests (US3/US4)**: Keep `deathmode=neverend` with fixed frame counts (like existing persistent tests) since these validate specific behaviors within time windows, not game outcomes.

**Rationale**: The proxy already sends `Shutdown { reason = GAME_OVER }` when the engine calls `release()`. With `deathmode=neverend`, `release()` is never called. Changing to default deathmode enables natural game ending. The `Client.Run()` loop already exits on `Shutdown` message.

**Win/loss detection**: Track during the game via events:
- **Victory**: `Client.Run` exits naturally (game ends) + our units still exist (check `UnitRegistry`)
- **Defeat**: `Client.Run` exits naturally + our commander was destroyed (track `UnitDestroyed` for commander ID)
- **Stall**: Frame count exceeds timeout without game ending → counted as failure
- **Crash**: Engine process dies → socket error in `Client.Run` → counted as crash

**Alternatives considered**:
- Event-based aggregation (count `EnemyDestroyed` until zero): More complex, prone to missed events. Rejected in favor of letting the engine handle victory detection natively.
- Adding a new `GameEndedEvent` to proto: Unnecessary scope creep — `Shutdown` with reason already provides this. Rejected.

## R3: Headless vs Live Engine for Each Test Suite

**Decision**: Test suite → engine mapping:

| Test Suite | Engine | Why |
|-----------|--------|-----|
| US1: End-to-end vs NullAI | Headless (`spring-headless`) | NullAI produces no combat; victory by building/existing; 17s/game |
| US2: Competitive vs BARb | Live (`spring` + Xvfb) | BARb fights; combat events needed for accurate outcome |
| US3: Non-combat suite | Headless | Economy, build, movement, scouting — no weapon physics needed |
| US4: Combat suite | Live (`spring` + Xvfb) | WeaponFired/UnitDamaged/UnitDestroyed require live engine |

**Rationale**: Confirmed in 014-research that headless engine produces zero weapon physics events. Non-combat behaviors (unit spawn, movement, build orders, economy, LOS/radar) work correctly in headless mode. Using headless for US1 and US3 keeps those suites fast (~17s/game at 100x speed).

## R4: BARbarianAI (BARb) Game Configuration

**Decision**: Create a separate `game-setup-barb.txt` fixture with `ShortName=BARb` for AI1, and change `deathmode` to allow natural game ending.

**Rationale**: BARb's registered ShortName in the engine is `BARb` (case-sensitive). It must be pre-installed in the engine's `AI/Skirmish/BARb/` directory. A separate fixture file avoids modifying the existing NullAI setup used by integration/persistent tests.

**Key config changes vs game-setup.txt**:
- `[AI1]`: `ShortName=BARb; Version=<default>;` (instead of `NullAI`)
- `[MODOPTIONS]`: Remove `deathmode=neverend;` (allow natural game ending)
- Keep `FixedRNGSeed=1` for reproducibility
- Keep `MinSpeed=100; MaxSpeed=100;` for fast execution

**BARb capability profile** (from 014-research):
- 0-3min: Economy bootstrap (mex, energy)
- 3-5min: Production (factory, first units)
- 5-10min: Army formation, initial attacks
- 10-15min: T2 tech transition
- 15min+: Late-game army
- Known limitation: occasional crashes, limited map adaptation

## R5: Xvfb Integration Pattern

**Decision**: Xvfb is expected to be pre-running before live tests execute. Tests validate DISPLAY is set and fail fast if not.

**Rationale**: The existing `start-live.sh` already uses `DISPLAY=${DISPLAY:-:0}`. Starting Xvfb is an infrastructure concern (CI pipeline or developer setup), not a test concern. Mixing process lifecycle management into tests adds fragility.

**Implementation**:
1. Live test fixture validates `DISPLAY` environment variable is set
2. If not set, test fails immediately with descriptive error: "Live engine tests require DISPLAY (run Xvfb or set DISPLAY)"
3. CI pipeline starts Xvfb before test run: `Xvfb :99 -screen 0 1024x768x24 & export DISPLAY=:99`
4. `start-live.sh` already handles the rest (engine launch, AI plugin installation)

**Alternatives considered**:
- Auto-start Xvfb in test fixture: Adds process management complexity, cleanup responsibility, potential port conflicts. Rejected.
- Use headless-gl or Mesa offscreen: Not supported by Spring engine; it requires real X11. Rejected.

## R6: Game Setup for End-to-End Validation (NullAI)

**Decision**: Create `game-setup-e2e.txt` — same as existing `game-setup.txt` with `deathmode=neverend` retained. Keep `MinSpeed=100; MaxSpeed=100;` for fast execution. Keep `FixedRNGSeed=1` for reproducibility.

**Rationale**: Headless engine cannot simulate weapon physics (zero WeaponFired/UnitDamaged/UnitDestroyed events, confirmed in 014-research). With no combat, games against NullAI can never end naturally regardless of deathmode setting. Therefore `deathmode=neverend` is correct — the harness terminates games via frame timeout (18000 frames = 10 min).

**"Win" detection for NullAI headless games**: Since actual wins are impossible in headless mode, SC-004 is redefined as "combat readiness" — the AI produces combat units from a factory (FirstCombatUnitFrame.IsSome). Actual win/loss validation against BARb occurs in US2 using the live engine where combat works.

## R7: Test Outcome Collection and Reporting

**Decision**: Reuse and extend the existing `GameOutcome` type from `tools/game-runner/GameRunner.fs`. Add milestone tracking (mex built, energy built, factory built, first combat unit) with frame timestamps.

**Rationale**: The `GameOutcome` type already captures game number, won, duration, units produced/lost, enemy destroyed. Adding milestone timestamps enables the specific success criteria checks (e.g., "3 mex within 3 minutes" = 3 mex within 5400 frames at 30fps).

**Extended outcome fields**:
```fsharp
type GameOutcome = {
    GameNumber: int
    Result: GameResult  // Win | Loss | Crash | Stall | Timeout
    DurationFrames: int
    DurationMinutes: float
    UnitsProduced: int
    UnitsLost: int
    EnemyUnitsDestroyed: int
    MexBuiltCount: int
    MexFirstBuiltFrame: int option
    EnergyBuiltCount: int
    EnergyFirstBuiltFrame: int option
    FactoryBuiltCount: int
    FactoryFirstBuiltFrame: int option
    FirstCombatUnitFrame: int option
    CrashMessage: string option
}
```

**Report generation**: Extend `GameRunner.generateReport` to include per-criterion pass/fail table matching spec success criteria (SC-001 through SC-008).

## R8: Test Project Structure

**Decision**: All validation tests go in the existing `tests/ai/fsharp/HighBar.AI.Tests.fsproj` project, which already references `HighBar.Client` and `BarData`.

**Rationale**: The project exists and is correctly configured. Adding test files requires only updating the `.fsproj` `<Compile>` items. The xUnit test runner handles discovery automatically.

**File organization**:
- `AiTestHarness.fs` — Shared fixture for multi-game orchestration (headless and live variants)
- `ValidationReport.fs` — Report generation utilities
- `EndToEndTests.fs` — US1: 10 games vs NullAI
- `CompetitiveTests.fs` — US2: 10 games vs BARb
- `NonCombatTests.fs` — US3: 20-run non-combat suite
- `CombatTests.fs` — US4: 10-run combat suite
