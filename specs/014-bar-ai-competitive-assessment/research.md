# Research: BAR AI Competitive Assessment

**Feature**: 014-bar-ai-competitive-assessment
**Date**: 2026-04-04

## R1: AI Architecture Pattern for RTS Games

**Decision**: Manager-per-domain + per-unit task system

**Rationale**: CircuitAI (BAR's primary AI, C++) uses this exact pattern and has proven it competitive in BAR. The pattern naturally maps to the per-frame event loop: each manager evaluates its domain, proposes commands, and the strategy controller resolves conflicts. The per-unit task system (each unit has exactly one active task) prevents conflicting orders and makes debugging straightforward — you can always answer "why is this unit doing X?" by checking its assigned task.

**Alternatives considered**:
- **Behavior trees**: Common in game AI but adds tree evaluation overhead per unit per frame. Better suited for individual unit AI (e.g., NPCs) than strategic-level RTS AI. Would require a BT library dependency.
- **Utility AI / scoring**: Scores all possible actions and picks highest. More adaptive but computationally expensive at RTS scale (hundreds of units * dozens of possible actions = thousands of scores per frame). Better as a future enhancement for specific decision points (e.g., target selection).
- **GOAP (Goal-Oriented Action Planning)**: Powerful but complex to implement and debug. Planning horizon doesn't fit RTS well — game state changes too rapidly for long-horizon plans to remain valid.
- **Reinforcement learning**: Highest ceiling but requires massive training infrastructure and game state representation engineering. Viable as a future research direction, not for initial implementation.

## R2: DefId Discovery Strategy

**Decision**: Query engine's `GetUnitDefs` callback at init, build runtime registry mapping DefIds to classified unit records

**Rationale**: The engine assigns DefIds at load time based on game content ordering, which differs from BarData's static generation order (581 engine DefIds vs 953 BarData entries). The `GetUnitDefs` callback returns the full list of runtime DefIds. For each DefId, we can query `UnitDef_getName`, `UnitDef_getBuildOptions`, `UnitDef_getMaxWeaponRange`, `UnitDef_getCost`, etc. to classify units without relying on name matching. This makes the system both correct (matches engine reality) and faction-agnostic.

**Alternatives considered**:
- **Name-based matching (BarData name → engine name)**: Fragile — assumes naming conventions match, fails if BAR renames units.
- **Static ID table (hardcoded mapping)**: Breaks on any game content update.
- **Hybrid (query engine, fall back to BarData for properties)**: Over-complex. Engine callbacks provide all needed properties directly.

## R3: Headless vs Live Engine Testing

**Decision**: Dual-mode test harness — headless for non-combat, Xvfb + live engine for combat

**Rationale**: Empirically confirmed that `spring-headless` does not simulate weapon physics (zero WeaponFired, UnitDamaged, UnitDestroyed, EnemyDamaged, EnemyDestroyed events across 1200+ frames with assault tanks at point-blank range). This is by design — headless mode is for Lua logic testing, not physics simulation. The BAR community's own headless tests (in `tools/headless_testing/`) only validate non-crash behavior, not combat outcomes.

For combat testing, the graphical `spring` binary is required. Xvfb (X Virtual Framebuffer) allows running it without a physical display, making CI-compatible automated testing possible. The only alternative would be `spring-dedicated` with TCP networking, but this would require changing the proxy's Unix socket transport.

**Key findings**:
- Headless works for: unit spawn, movement, build orders, economy, LOS/radar events, Lua gadgets
- Headless does NOT work for: weapon fire, damage, destruction, combat events
- BAR's BARb smoke test runs two AIs for 30 minutes headless — verifies no crashes but NOT combat outcomes
- Xvfb is the standard approach for headless graphical testing on Linux CI systems

## R4: BAR-Specific Game Mechanics

**Decision**: Design for overdrive from the start, implement basic economy first, add overdrive in Phase 3+

**Rationale**: BAR's overdrive mechanic converts excess energy into bonus metal income via the pylon/energy grid system. This is the primary way competitive AIs (and players) scale economy in mid-to-late game — it can multiply metal income 2-3x. BARb heavily exploits overdrive.

However, overdrive requires understanding the pylon grid topology (which energy structures are connected), the conversion rate formula, and optimal energy-to-metal ratios. This adds significant complexity. The economy model will be designed with extensibility points for overdrive (tracking energy surplus, pylon connectivity) but the initial implementation will focus on basic metal extractors + energy buildings.

**Key BAR mechanics to support (phased)**:
1. **Phase 3 (basic)**: Metal extractors, energy buildings (solar/wind/fusion), factory production
2. **Phase 3+ (overdrive)**: Pylon grid, energy-to-metal conversion, optimal energy surplus targeting
3. **Future**: Unit morphing (T1 → T2 upgrades), commander upgrade paths, air transports

## R5: Competitive Benchmark — BARbarianAI Capabilities

**Decision**: Use BARb as primary competitive benchmark, with "do-nothing AI" as minimum baseline

**Rationale**: BARb (BAR fork of CircuitAI) is the standard AI opponent in BAR. It builds economy efficiently, uses overdrive, produces balanced armies, scouts, and attacks. Known limitations: occasional crashes in certain configs, limited map adaptation, no learning between games. Surviving 15 minutes against BARb requires competent economy and basic army production. Beating BARb requires overdrive optimization and tactical combat.

**BARb capability tiers (approximate)**:
- **Minutes 0-3**: Commander builds metal extractors, first energy, first factory
- **Minutes 3-5**: Factory producing T1 units, expanding economy, radar built
- **Minutes 5-10**: Multiple factories, T1 army forming, scouting, overdrive ramping
- **Minutes 10-15**: T2 tech transition begins, coordinated attacks, defense response
- **Minutes 15+**: T2 economy and units, strategic pressure, big guns (artillery/nukes in late game)

## R6: Frame Budget Analysis

**Decision**: Target < 25ms for AI decision logic per frame

**Rationale**: At 30fps, each frame is ~33ms. Constitution mandates < 1ms proxy overhead (serialization + socket + deserialization). That leaves ~32ms for AI response. Targeting 25ms provides a 7ms safety margin for GC pauses, OS scheduling jitter, and complex game states.

Per-frame budget breakdown (target):
- Event processing & state update: < 2ms (parse events, update unit positions/health)
- Manager evaluations: < 10ms total (5 managers, ~2ms each average)
- Task assignment & command generation: < 5ms
- Decision logging: < 1ms (async write, buffered)
- Callback queries: < 5ms (map data, unit properties — cached after first query)
- Buffer: ~2ms

This is achievable because managers use incremental evaluation (only process changed state) and most per-frame work is O(units changed) not O(total units).
