# Research: Harden Persistent Engine Tests

## R1: UnitDefId Discovery Strategy

**Decision**: Probe unitDefIds 1 through 953 during fixture initialization by spawning each in small batches, recording which ones produce UnitCreated events, then cross-reference with BarData's AllUnits list to classify by category.

**Rationale**: The engine assigns unitDefIds as integers internally during game content loading. There is no query API to look up unitDefId by name. However, BarData provides 953 named unit summaries with category flags (isBuilder, isArmed, isMobile, isBuilding). By probing all 953 IDs and matching the spawned count to the BarData count, we can build a reliable mapping. The discovery can be done during fixture init or as a dedicated discovery test.

**Alternatives considered**:
- CallLuaRulesCommand to query Lua for ID mapping: Uncertain if BAR's Lua rules handle AI messages for this purpose. Would require a Lua handler.
- Hardcode known IDs: Fragile; changes with game content version.

## R2: BarData Cross-Reference for Unit Classification

**Decision**: After discovering which unitDefIds produce UnitCreated events, use BarData's AllUnits.all list (953 entries) to classify units. Since unitDefIds are 1-indexed and correspond to the engine's loading order, probe results at index N map to BarData entry at index N-1 (if ordering is consistent).

**Rationale**: BarData provides `isBuilder`, `isArmed`, `isMobile`, `canFly`, `hasEconomy`, `isBuilding` flags. Once we have a mapping of unitDefId → success/failure, we can identify which IDs correspond to builders, armed units, etc.

**Key finding**: If the engine loads units in alphabetical order by name (common in Spring engine), the unitDefId ordering matches the sorted AllUnits list. This needs to be validated during the discovery phase.

**Fallback**: If ordering doesn't match, the discovery test can probe a broader range and classify units empirically by observing behavior (e.g., a builder can execute BuildCommand).

## R3: Combat Test Setup — Enemy Unit Spawning

**Decision**: Spawn enemy units using GiveMeNewUnitCommand. The cheat command creates units for the AI's own team (team 0). To create enemy units, use SendTextMessageCommand with the `.give` cheat syntax which may allow specifying a team, or spawn friendly units and use them for friendly-fire combat tests.

**Rationale**: The GiveMeNewUnitCommand creates units for team 0 (our AI team). For actual enemy combat, we need team 1 units. The NullAI on team 1 has a commander spawned at game start. We can use FightCommand to move our units toward the enemy commander's position (4608, 4096) to trigger EnemyEnterLOS and combat events.

**Alternatives considered**:
- Spawn two friendly units and attack each other: Would produce UnitDamaged events but not EnemyDamaged/EnemyEnterLOS. Useful for some tests but not full coverage.
- Rely on NullAI's commander: The NullAI spawns one commander. This is sufficient for basic combat tests.

## R4: Command Coverage — Full Inventory

**Decision**: Test all 17 command types identified in the client library.

**Command types** (from Commands.fs):
1. MoveCommand
2. BuildCommand
3. PatrolCommand
4. AttackCommand
5. GuardCommand
6. StopCommand
7. RepairCommand
8. ReclaimUnitCommand
9. FightCommand
10. SetWantedMaxSpeedCommand
11. SelfDestructCommand
12. SendTextMessageCommand
13. CustomCommand
14. GiveMeResourceCommand
15. GiveMeNewUnitCommand
16. CallLuaRulesCommand
17. CallLuaUICommand

**Note**: The existing integration tests already cover Move, Stop, Build, Patrol, Guard, Attack, Repair, Fight. The persistent tests need to add coverage for SetWantedMaxSpeed, SelfDestruct, Reclaim, Custom, SendTextMessage, GiveMeResource, GiveMeNewUnit, CallLuaRules, CallLuaUI.

## R5: Exhaustive UnitDef Spawn — Batch Strategy

**Decision**: Spawn all 953 unitDefIds in batches of 50. Each batch: (1) send 50 GiveMeNewUnitCommand, (2) run 20 frames to collect UnitCreated events, (3) record success/failure per ID, (4) call ResetGameState. Total: ~19 batches.

**Rationale**: Batches of 50 balance speed (under 2 minutes total) with debuggability (if a batch crashes the engine, only 50 IDs need investigation). The reset between batches prevents unit count from growing unbounded.

**Timing estimate**: ~19 batches × (20 frames + reset ~2.5s) ≈ ~60-90 seconds total.

## R6: Frame Counts for Event Observation

**Decision**: Use adaptive frame counts based on the event type:
- UnitCreated after spawn: 10-15 frames (events arrive within 1-2 frames)
- UnitFinished after BuildCommand: 300-500 frames (construction takes significant game time; give extra metal/energy via cheat)
- UnitDamaged after AttackCommand: 50-100 frames (depends on weapon range and fire rate)
- EnemyEnterLOS: 100-200 frames (depends on unit speed and distance to enemy)

**Rationale**: The existing T3/T4 tests used 80-200 frames, which was insufficient for build completion. Construction in BAR takes hundreds of game frames depending on the structure. Giving the builder extra resources via GiveMeResourceCommand ensures metal/energy aren't the bottleneck.
