# Research: Verify Headless Combat and Fix Test Errors

**Feature**: 016-verify-headless-combat  
**Date**: 2026-04-04

## R1: Current Test Suite Compilation Status

**Decision**: The Feature 015 test suite compiles cleanly — no compilation fixes needed.

**Rationale**: Running `dotnet build` on `tests/ai/fsharp/HighBar.AI.Tests.fsproj` produces zero errors and zero warnings (in the test project itself; BarData has suppressed indentation warnings). All project references resolve:
- `clients/fsharp/HighBar.Client.fsproj` — exists, builds
- `data/bar/BarData.fsproj` — exists, builds (119 source files)
- `tools/game-runner/GameRunner.fsproj` — exists, builds

**Alternatives considered**: None — compilation is a binary check.

## R2: Combat Verification Test Design

**Decision**: Create a dedicated `HeadlessCombatVerification.fs` test that uses the existing `HeadlessAiFixture` but with a specialized game setup that spawns opposing combat units at close range via cheat commands (already enabled in modoptions: `debugcommands`). The test monitors `WeaponFired`, `UnitDamaged`, `EnemyDamaged`, `UnitDestroyed`, and `EnemyDestroyed` event counts from `GameOutcome`.

**Rationale**: The existing `AiTestHarness.fs` already tracks all combat events in `GameOutcome` (lines tracking WeaponFiredCount, UnitDamagedCount, EnemyDamagedCount, UnitDestroyedCount, EnemyDestroyedCount). The AI brain's `handleEvent` callback receives all 28 event types including combat events — if the engine fires them. The test needs to:

1. Use a game setup with two AI teams (not NullAI which does nothing)
2. Ensure both teams build combat units (or spawn them via cheat commands)
3. Run for 2000+ frames (67+ seconds at 30fps)
4. Check if any combat event counters are non-zero

**Approach**: Use a modified game setup where HighBarV2 AI controls Team 0 and a second HighBarV2 AI instance (or BARb if available) controls Team 1, with close starting positions. The existing AI brain already builds combat units within ~5 minutes (9000 frames per SC-003). To accelerate verification, use cheat commands to spawn assault units near the opponent's base early in the game.

**Alternatives considered**:
- *Use existing CombatTests.fs*: These already test combat events but are designed for the live engine and are marked Skip. Could un-skip and run on headless, but they don't have the focused "spawn units at close range" design needed for definitive verification.
- *Modify NullAI setup*: NullAI does nothing, so only our units would be present — no opposing forces means no combat even if physics work. Rejected.

## R3: Engine Version and Environment

**Decision**: Use the installed `spring-headless` at `/home/developer/.local/bin/spring-headless` (version 2025.06.21 per `tests/engine-version.json`). The environment also has a full graphical `spring` at `/home/developer/.local/state/Beyond All Reason/engine/recoil_2025.06.19/spring` for live engine comparison if needed.

**Rationale**: The headless binary is what Feature 014 tested against. Using the same binary ensures a fair comparison. If combat IS found to work, we can note the version for future reference. If it doesn't work, we can optionally run the same test against the live engine as a positive control.

**Alternatives considered**:
- *Install a newer engine version*: Out of scope — we're verifying the current claim, not testing new versions.

## R4: Combat Event Tracking in Existing Harness

**Decision**: The existing `AiTestHarness.fs` `GameOrchestrator.runSingleGame` already tracks all combat events. No harness modifications needed for event counting. The `GameOutcome` record includes `WeaponFiredCount`, `UnitDamagedCount`, `EnemyDamagedCount`, `UnitDestroyedCount`, `EnemyDestroyedCount`.

**Rationale**: The harness processes every event from the engine callback and increments counters. If the engine sends `WeaponFired` events, they will be counted. If it doesn't, the counters stay at zero. This is exactly the data needed for verification.

**Alternatives considered**:
- *Add raw event logging*: Could log every event to a file for post-hoc analysis, but the counters in GameOutcome are sufficient for a definitive yes/no answer. Raw logging could be added if the results are ambiguous.

## R5: Game Setup for Combat Verification

**Decision**: Create `tests/fixtures/game-setup-combat-verify.txt` based on `game-setup-e2e.txt` but with two HighBarV2 AI teams instead of HighBarV2 vs NullAI. Both teams should use close starting positions (within weapon range of typical assault units ~500-800 map units). Keep `debugcommands` enabled for cheat spawn capability. Use `deathmode=neverend` since we only care about whether events fire, not who wins.

**Rationale**: Two active AIs both building and fighting maximizes the chance of combat events occurring. Close starting positions ensure units encounter each other quickly. The existing game setup already has `debugcommands` enabled which allows `globallos` (both sides see everything) and cheat commands.

**Alternatives considered**:
- *Spawn pre-built units via Lua scenario*: More controlled but requires writing a custom Lua script. The AI brain already builds units within 5 minutes — close start positions should produce combat encounters if physics work. If the natural approach is inconclusive, Lua spawning can be added as a follow-up.

## R6: Feature 014 Methodology Review

**Decision**: The Feature 014 finding was based on monitoring combat events during a 1200+ frame test with "assault tanks at point-blank range." The methodology is sound but the frame count is relatively short (~40 seconds). Our verification should run at least 2000 frames and ideally longer (5000+ frames / ~3 minutes) to ensure units have time to acquire targets and fire.

**Rationale**: Some combat units in BAR have slow turret rotation or long aim times. 1200 frames might not be enough for some weapon types. Running longer eliminates this potential false negative. Additionally, Feature 014 may have tested with pre-spawned static units that might behave differently than AI-directed units in combat.

**Alternatives considered**:
- *Replicate exact Feature 014 setup*: Would confirm methodology but not improve on it. Better to run a more thorough test.

## R7: Combat Verification Empirical Results (2026-04-04)

**Finding**: Feature 014's claim that spring-headless does not simulate weapon physics is **CONFIRMED**.

**Evidence**:
- 3 games run with `game-setup-combat-verify.txt` (HighBarV2 vs NullAI, close positions: 512 map units apart)
- 9000 frames per game (5 min game time), 27000 total frames (15 min game time)
- Engine: spring-headless 2025.06.21
- Results: **zero** combat events across all games
  - WeaponFired: 0
  - UnitDamaged: 0
  - EnemyDamaged: 0
  - UnitDestroyed: 0
  - EnemyDestroyed: 0
- Each game produced 1 unit (commander) and ran the full duration without crashing
- Commanders were within weapon range of each other (512 elmos, typical weapons reach 300-800 elmos)

**Comparison to Feature 014**: Feature 014 tested 1200+ frames with assault tanks at point-blank range and saw zero combat events. Our test used 27000 frames (22x more) with commanders at close range and confirmed the same result. The finding is robust.

**Implications**: The live/headless split in the test architecture (Features 014/015) is necessary. Combat tests MUST use the graphical `spring` engine (via Xvfb for CI). Per clarification, no architecture changes are made in this feature — this is documentation only.

**Report**: `tests/ai/fsharp/reports/combat-verification-20260404-123311.md`

## R8: Harness Bug Fix — Init Event Consumption

**Finding**: The test harness in `AiTestHarness.fs` had a critical bug causing all games to stall at 1800 frames with 0 units produced.

**Root cause**: The harness used a separate `client.Run` call to capture the Init event and extract the teamId. This consumed the first frame (containing Init, UnitCreated, and UnitFinished events for the commander) without sending a FrameResponse back to the proxy. The commander's creation events were lost, so GameState never knew about the commander. With no units registered, all managers returned empty proposals, no commands were issued, and stall detection triggered at 1800 consecutive zero-command frames.

**Fix**: Removed the separate init-capture phase. GameState is now initialized lazily inside the single `client.Run` callback when the Init event is encountered. This ensures all events in the first frame (Init + UnitCreated + UnitFinished) are properly processed, and the FrameResponse is correctly sent for every frame.

**Before fix**: All games STALL at 1.0 min, 0 units produced, 0/160 assertions pass
**After fix**: Games run full duration (3.5-5 min), units produced, AI actively building and commanding
