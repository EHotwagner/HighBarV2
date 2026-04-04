# Feature Specification: BAR AI Competitive Assessment

**Feature Branch**: `014-bar-ai-competitive-assessment`  
**Created**: 2026-04-04  
**Status**: Draft  
**Input**: Comprehensive assessment of what features are necessary to run a competitive AI in BAR, current project state analysis, comparison with existing AIs (CircuitAI/BARb), headless/live testing evaluation, and forward plan.

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Competitive AI Game Loop (Priority: P1)

An AI developer loads the HighBarV2 AI into a BAR game (either headless or live) and the AI plays a complete game from start to finish: it manages economy, builds a base, produces an army, scouts the enemy, and engages in combat. The AI makes strategic decisions based on game state and adapts to what the opponent is doing.

**Why this priority**: Without a functioning end-to-end game loop, no competitive play is possible. This is the foundational capability everything else builds on.

**Independent Test**: Can be tested by launching a game with the AI and observing it complete all phases (economy bootstrap, base building, army production, combat engagement) without crashing or stalling.

**Acceptance Scenarios**:

1. **Given** a fresh game start with a single commander, **When** the AI initializes, **Then** it issues build orders to construct metal extractors and energy generators within the first 60 seconds of game time
2. **Given** an established base with resource income, **When** the AI has surplus economy, **Then** it builds factories and begins producing combat units
3. **Given** produced combat units, **When** the AI detects enemy units or structures, **Then** it coordinates attacks against enemy positions
4. **Given** a complete game, **When** the AI runs from start to finish, **Then** it does not crash, stall, or stop issuing commands at any point

---

### User Story 2 - Economy Management (Priority: P1)

The AI efficiently manages its metal and energy economy throughout the game, balancing income and expenditure, expanding to new resource locations, and avoiding stalls.

**Why this priority**: Economy is the foundation of all RTS gameplay. An AI that stalls on resources cannot build, produce, or compete.

**Independent Test**: Can be tested by monitoring resource levels over time and verifying the AI maintains positive income and avoids prolonged stalls.

**Acceptance Scenarios**:

1. **Given** game start, **When** the AI has its commander, **Then** it identifies and builds on the nearest metal spots within efficient range
2. **Given** rising metal income, **When** energy becomes the bottleneck, **Then** the AI builds energy structures to match demand
3. **Given** available map resources, **When** nearby metal spots are exhausted, **Then** the AI expands to claim additional resource locations
4. **Given** a functioning economy, **When** income exceeds expenditure, **Then** the AI increases spending (more factories, more production) rather than stockpiling

---

### User Story 3 - Build Order and Base Layout (Priority: P1)

The AI follows sensible build orders and places structures in functional locations, building the right structures in the right order to establish a working base.

**Why this priority**: Build order determines early-game viability. Poor structure placement or ordering leads to economy stalls and vulnerability.

**Independent Test**: Can be tested by observing the first 5 minutes of AI play and verifying structures are built in a viable order with reasonable placement.

**Acceptance Scenarios**:

1. **Given** game start, **When** the AI begins building, **Then** it follows a build order that prioritizes resource income (metal extractors before factories)
2. **Given** a build order, **When** the AI places structures, **Then** structures do not overlap, block pathing corridors, or prevent future expansion
3. **Given** initial economy, **When** the AI reaches factory-building stage, **Then** it builds at least one factory capable of producing combat units

---

### User Story 4 - Unit Production and Army Composition (Priority: P2)

The AI produces a balanced army from its factories, choosing unit types appropriate for the game state and map terrain.

**Why this priority**: Producing the wrong units or failing to produce at all makes the AI ineffective in combat even with good economy.

**Independent Test**: Can be tested by checking factory output over time and verifying a mix of unit types are produced.

**Acceptance Scenarios**:

1. **Given** operational factories, **When** the AI has economy to spend, **Then** factories continuously produce units without idle time
2. **Given** combat unit options, **When** the AI selects what to build, **Then** it produces a mix of units (not exclusively one type)
3. **Given** knowledge of enemy composition (via scouting), **When** the AI observes air threats, **Then** it produces anti-air units or air units in response

---

### User Story 5 - Scouting and Map Awareness (Priority: P2)

The AI actively scouts the map to discover enemy positions, expansions, and army movements, maintaining situational awareness throughout the game.

**Why this priority**: An AI that cannot see the enemy cannot make informed strategic decisions about when to attack, defend, or expand.

**Independent Test**: Can be tested by verifying the AI sends scout units to explore unknown map areas and tracks enemy positions.

**Acceptance Scenarios**:

1. **Given** early game, **When** the AI has mobile units, **Then** it sends at least one unit to scout enemy starting locations
2. **Given** mid-game, **When** the AI has radar coverage, **Then** it maintains awareness of enemy positions via radar and periodic visual scouting
3. **Given** enemy units detected, **When** the AI receives LOS/radar events, **Then** it updates its threat model with enemy positions and composition

---

### User Story 6 - Combat Micro and Tactics (Priority: P2)

The AI coordinates its army in combat, engaging enemies with reasonable tactical behavior (focus fire, retreat damaged units, avoid unfavorable engagements).

**Why this priority**: Even with good economy and production, poor combat execution wastes the army. Basic tactical coordination dramatically improves combat effectiveness.

**Independent Test**: Can be tested in a live game by staging combat encounters and observing unit behavior.

**Acceptance Scenarios**:

1. **Given** an army group, **When** ordered to attack, **Then** units engage as a coordinated group rather than trickling in individually
2. **Given** damaged units, **When** a unit reaches critically low health, **Then** it retreats to safety if retreat is viable
3. **Given** a clearly superior enemy force, **When** the AI detects overwhelming opposition at an attack target, **Then** it pulls back rather than feeding units piecemeal

---

### User Story 7 - Full Game Testing with Combat Validation (Priority: P3)

The AI can be tested in a full game environment where weapon physics, damage, and combat outcomes are validated — requiring a live (non-headless) engine instance.

**Why this priority**: Headless mode does not simulate weapon physics, so all combat-related behaviors must be validated in a live engine. Without this, combat AI cannot be developed or tested.

**Independent Test**: Can be tested by running a live engine instance (with Xvfb or GPU) and verifying combat events (UnitDamaged, UnitDestroyed, WeaponFired) are delivered.

**Acceptance Scenarios**:

1. **Given** a live engine instance, **When** two opposing units are placed in combat range, **Then** WeaponFired, UnitDamaged, and UnitDestroyed events are delivered to the AI
2. **Given** a live test harness, **When** a full AI-vs-AI game runs, **Then** the game completes with a definitive outcome (one side wins)
3. **Given** live combat events, **When** the AI processes damage/destruction events, **Then** it correctly updates its unit tracking and threat model

---

### Edge Cases

- What happens when the AI's commander is destroyed? The AI must continue playing with remaining units and factories (or gracefully handle game-over if deathmode is set)
- How does the AI handle maps with unusual terrain (water-heavy, mountain-heavy, very small, very large)? Initial scope is limited to small-to-medium 1v1 land maps; naval and extreme terrain maps are deferred
- What happens when the AI faces a rush (enemy attacks within the first 2-3 minutes)?
- How does the AI handle being given units via the UnitGiven event (shared units from allies)?
- What happens when all metal spots near the starting position are already claimed by an ally?
- How does the AI handle reconnection if the proxy socket drops mid-game?

## Requirements *(mandatory)*

### Functional Requirements

#### Core Game Loop

- **FR-001**: System MUST receive and process all engine events (unit lifecycle, combat, economy, map) through the proxy-client pipeline without dropping events
- **FR-002**: System MUST respond to each frame within the engine's timeout window (default ~1 second) to avoid being kicked for unresponsiveness
- **FR-003**: System MUST maintain a persistent game state model that tracks all known friendly units, their types, positions, health, and current commands
- **FR-004**: System MUST maintain a model of known enemy units based on LOS/radar events, including last-known positions

#### Economy Management

- **FR-005**: System MUST identify metal spot locations on the map (via Map callbacks: GetMetalSpots)
- **FR-006**: System MUST issue build commands for metal extractors on available metal spots
- **FR-007**: System MUST monitor resource income and expenditure (via Economy callbacks: GetCurrent, GetIncome, GetUsage) and build energy structures when energy is the bottleneck
- **FR-008**: System MUST detect economy stalls (resource at zero with positive demand) and adjust build priorities accordingly
- **FR-009**: System MUST expand to claim new resource locations as nearby spots are exhausted
- **FR-009a**: System's economy model MUST be designed to accommodate BAR's overdrive mechanic (excess energy converted to bonus metal via pylon grid), with overdrive optimization implemented after basic metal/energy economy is functional

#### Building and Production

- **FR-010**: System MUST query unit definitions to determine what each builder/factory can construct (via UnitDef callbacks: GetBuildOptions)
- **FR-011**: System MUST issue build commands with valid positions that respect unit footprints and terrain constraints
- **FR-012**: System MUST manage factory production queues, keeping factories continuously producing when economy allows
- **FR-013**: System MUST select appropriate unit types for production based on game state (available unit types, known enemy composition, map characteristics). Unit selection MUST be faction-agnostic (driven by unit properties, not hardcoded unit names) to support future faction expansion, with Armada as the initial implementation target

#### Scouting and Intelligence

- **FR-014**: System MUST send mobile units to explore unexplored map areas to discover enemy positions
- **FR-015**: System MUST process EnemyEnterLOS, EnemyLeaveLOS, EnemyEnterRadar, EnemyLeaveRadar events to maintain enemy tracking
- **FR-016**: System MUST query enemy unit properties when visible (via Unit callbacks on enemy IDs) to determine enemy composition
- **FR-017**: System MUST maintain a threat map or equivalent data structure representing known enemy force distributions

#### Combat

- **FR-018**: System MUST issue attack, fight, and patrol commands to combat units to engage enemy forces
- **FR-019**: System MUST coordinate unit groups for attacks rather than sending individual units
- **FR-020**: System MUST process UnitDamaged and UnitDestroyed events to track combat outcomes and update unit tracking
- **FR-021**: System MUST process WeaponFired events for special weapons (D-Gun, nukes) that require manual fire

#### Testing Infrastructure

- **FR-022**: System MUST support testing in headless mode for non-combat behaviors (economy, building, movement, scouting)
- **FR-023**: System MUST support testing in live engine mode for combat behaviors (weapon fire, damage, destruction)
- **FR-024**: System MUST provide a test harness that can run automated AI-vs-AI games and collect outcome metrics
- **FR-025**: System MUST support deterministic replay via FixedRNGSeed for reproducible test scenarios

#### Engine Integration

- **FR-026**: System MUST dynamically discover unit definition IDs from the engine at runtime rather than relying on static BarData indices (addresses the DefId mismatch issue from Feature 013)
- **FR-027**: System MUST handle the full set of 28 engine event types without crashing or ignoring unknown events
- **FR-028**: System MUST use engine callbacks to query map data (dimensions, height map, metal spots, start positions) for strategic planning

#### Observability

- **FR-029**: System MUST produce structured decision logs recording phase transitions, build decisions, attack decisions, and economy state snapshots at key moments
- **FR-030**: Decision logs MUST include sufficient context to understand *why* each decision was made (e.g., "built factory because metal income exceeded 10/s and no factory exists", "attacked position X because threat map showed low enemy presence")

### Key Entities

- **GameState**: The AI's complete model of the current game — friendly units, enemy units, economy, map knowledge, current strategy phase
- **UnitRegistry**: Registry of all known units (friendly and enemy) with type, position, health, last-seen time, and current orders
- **EconomyModel**: Current resource levels, income, expenditure, projected surplus/deficit, build priority queue. Must be extensible to model overdrive (energy-to-metal conversion via pylon grid) in a later phase
- **ThreatMap**: Spatial model of enemy force distribution, updated from LOS/radar events, used for attack/defense decisions
- **BuildManager**: Tracks build orders, structure placement, and tech progression. Factory queue management is handled separately by ProductionManager
- **StrategyController**: High-level decision maker that determines current game phase (opening, expansion, mid-game, late-game) and adjusts behavior accordingly. Phase transitions are triggered by economy and military milestones (e.g., factory count, army value, metal income thresholds) rather than fixed time windows

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: The AI completes a full game from start to finish without crashing, stalling, or ceasing to issue commands — verified across 10 consecutive game runs
- **SC-002**: The AI builds at least 3 metal extractors and 2 energy structures within the first 3 minutes of game time in 90% of games
- **SC-003**: The AI achieves positive metal and energy income within 2 minutes of game start
- **SC-004**: The AI produces combat units from at least one factory within 5 minutes of game start
- **SC-005**: The AI sends scout units to explore at least 2 distinct map regions within 4 minutes of game start
- **SC-006**: The AI engages enemy units in combat when enemy positions are known (does not passively sit in base)
- **SC-007**: The AI beats the default "do-nothing" engine AI in 100% of test games
- **SC-008**: The AI survives for at least 15 minutes against BARbarianAI (BARb) in 80% of test games
- **SC-009**: Non-combat tests (economy, building, movement) pass reliably in headless mode with 95%+ success rate
- **SC-010**: Combat tests (damage, destruction, weapon events) pass reliably in live engine mode with 90%+ success rate

## Clarifications

### Session 2026-04-04

- Q: Which BAR faction should the AI support? → A: Start with Armada, design unit selection to be faction-agnostic for later expansion to Cortex and Legion.
- Q: Should the AI handle BAR's overdrive/pylon economy mechanic? → A: Design economy model to accommodate overdrive, implement after basic economy works (Phase 3+).
- Q: What map types should the AI initially target? → A: Small-to-medium 1v1 land maps (no naval, no team games).
- Q: What triggers game phase transitions (opening/expansion/mid/late)? → A: Economy and military milestones (e.g., factory count, army value, metal income thresholds).
- Q: What level of AI decision observability is needed? → A: Structured decision logging — log phase transitions, build/attack decisions, economy state snapshots at key moments.

## Assumptions

- The Recoil engine's Skirmish AI C interface (SSkirmishAICallback with ~596 function pointers) provides sufficient data for competitive AI decision-making — this is the same interface used by CircuitAI/BARb
- Headless mode (`spring-headless`) does NOT simulate weapon physics, projectile creation, or damage calculations — this is confirmed by empirical testing in Feature 013 across 1200+ frames showing zero combat events
- Live engine mode (`spring` binary with GPU or Xvfb) is required for any combat validation — there is no workaround for headless combat testing
- The BAR game content (units, maps, game rules) is available via pr-downloader and pinned to a specific version (test-29833-ee0f96a) for reproducibility
- The HighBarV2 proxy's current protocol (protobuf over Unix domain sockets) has acceptable latency for competitive play — the proxy adds serialization overhead per frame, but this is expected to be negligible compared to AI decision time
- Unit definition IDs (DefIds) must be queried from the engine at runtime — static BarData indices do not match engine assignments (581 engine defIds vs 953 in BarData)
- The AI will initially play as Armada faction, with unit selection logic designed to be faction-agnostic (based on unit properties like cost, speed, damage rather than hardcoded names) so Cortex and Legion can be added later
- The AI will initially target small-to-medium 1v1 land maps only — naval units, team coordination, and large 8v8 maps are out of scope for the initial version
- The AI will initially target single-player vs. AI opponents (Skirmish mode), with multiplayer support as a future goal
- BAR's Lua gadgets (game rules) may modify unit behavior in ways not captured by the engine's C callback interface — the AI may need to use CallLuaRules for BAR-specific interactions

---

## Appendix A: Current Project Architecture

### System Overview

HighBarV2 uses a **proxy bridge architecture** that separates the AI logic from the engine plugin:

```
┌──────────────────┐     Unix Domain Socket    ┌──────────────────┐
│  Recoil Engine   │     (protobuf IPC)        │   F# AI Client   │
│                  │                            │                  │
│  ┌────────────┐  │   EngineEvents (28 types)  │  ┌────────────┐  │
│  │ Game Sim   │──┼──────────────────────────▶│  │ Event Loop │  │
│  │            │  │                            │  │            │  │
│  │            │◀─┼────────────────────────────│  │ Decision   │  │
│  │            │  │   AICommands (97 types)     │  │ Engine     │  │
│  └────────────┘  │                            │  └────────────┘  │
│                  │   CallbackReq/Resp (46+)   │                  │
│  ┌────────────┐  │◀─────────────────────────▶│  ┌────────────┐  │
│  │ C Proxy    │  │                            │  │ BarData    │  │
│  │ Plugin     │  │                            │  │ (1000+ units)│ │
│  │ (SkirmAI)  │  │                            │  │            │  │
│  └────────────┘  │                            │  └────────────┘  │
└──────────────────┘                            └──────────────────┘
```

### Component Status

| Component | Status | Key Capability |
|-----------|--------|----------------|
| C Proxy (SkirmishAI.so) | Complete | Event serialization, command deserialization, arena allocator, socket IPC |
| Protobuf Schema | Complete | 97 commands, 28 events, 46+ callbacks, session protocol |
| F# Client Library | Complete | Connection, handshake, frame loop, typed command builders, event parsing |
| Python Client | Partial | Connection/events working, command builders are stubs |
| BarData Library | Complete | 1000+ typed unit definitions generated from BAR game content |
| Test Harness | Complete | Engine lifecycle, prerequisites, session management, diagnostics |
| Integration Tests (T0-T3) | Passing | Smoke, spawn, movement, build tests all stable |
| Integration Tests (T4-T8) | Partial | Combat tests blocked by headless limitation; large spawn tests limited |
| DefId Discovery | In Progress | Engine-to-BarData mapping needed (Feature 013) |
| AI Decision Engine | Not Started | No strategic/tactical decision-making logic exists yet |

### What Works Today

1. **Full proxy pipeline**: Engine events serialize to protobuf, travel over Unix socket, deserialize in F# client; commands go back the same way
2. **All 97 command types**: Typed builders exist for every engine command (Move, Build, Attack, Repair, Reclaim, etc.)
3. **All 28 event types**: Event parsing covers the complete engine event vocabulary
4. **46+ callback queries**: Unit position, health, definition, economy, map data, team info
5. **Unit data**: 1000+ BAR units with typed records (cost, health, speed, weapons, build options)
6. **Headless testing**: Engine lifecycle management, prerequisite validation, automated test runs
7. **Cheat commands**: Spawn units, give resources (for testing scenarios)

### What Does NOT Work Today

1. **No AI brain**: No decision-making logic — the client can talk to the engine but has no strategy
2. **Combat events in headless**: WeaponFired, UnitDamaged, UnitDestroyed, EnemyDamaged, EnemyDestroyed are never generated in `spring-headless`
3. **DefId mismatch**: BarData indices don't match engine's runtime DefId assignments — build commands using BarData IDs fail
4. **No live test harness**: No automated testing against the graphical `spring` binary
5. **Large spawn instability**: Engine crashes when spawning 953+ units in quick succession

---

## Appendix B: How Existing BAR AIs Work (CircuitAI / BARbarianAI)

### CircuitAI Architecture

CircuitAI (by rlcevg) is BAR's primary AI opponent. It is written in C++ and loaded directly as a Skirmish AI through the engine's C interface — no proxy or IPC layer.

**Key architectural differences from HighBarV2:**

| Aspect | CircuitAI / BARb | HighBarV2 |
|--------|-------------------|-----------|
| Language | C++ (direct engine integration) | F# (via C proxy + protobuf IPC) |
| Latency | Zero overhead (in-process) | Socket + serialization per frame |
| Engine access | Direct callback pointer calls | Proxy-mediated callback requests |
| State management | In-process C++ objects | Cross-process protobuf messages |
| Development speed | Slow (C++ compile, engine restart) | Fast (F# hot-reload potential, separate process) |
| Debugging | Attach to engine process | Independent process, standard F# tooling |
| Crash isolation | AI crash = engine crash | AI crash = proxy handles gracefully |

**CircuitAI Module Structure:**

- **`CircuitAI.cpp`** — Main class, receives engine events, dispatches to manager modules
- **`BuilderManager`** — Construction planning: decides what to build, where, and when. Uses metal spot analysis, build queues, and terrain evaluation
- **`EconomyManager`** — Monitors metal/energy income vs expenditure, adjusts build priorities, manages resource sharing
- **`FactoryManager`** — Controls factory production queues: unit type selection, build rate optimization, tech tier progression
- **`MilitaryManager`** — Combat coordination: threat assessment, target selection, army grouping, attack/defense decisions

**CircuitAI Task System:**

Builder tasks: MexTask, EnergyTask, FactoryTask, DefenceTask, RadarTask, RepairTask, ReclaimTask, TerraformTask, BigGunTask, BunkerTask, PylonTask, StoreTask

Fighter tasks: AttackTask, RaidTask, ScoutTask, DefendTask, AntiAirTask, AntiHeavyTask, ArtilleryTask, BombTask, SquadTask, SupportTask

Common: IdleTask, RetreatTask, RearmTask, PlayerTask

**Key Takeaways from CircuitAI:**

1. **Manager pattern works**: Separate managers for economy, building, factory, military — each handles its domain independently
2. **Task-based unit control**: Each unit has an assigned task (build mex, scout, raid, defend) that drives its behavior
3. **Terrain analysis is critical**: CircuitAI analyzes the map's metal spots, chokepoints, elevation, and pathability before making decisions
4. **Threat mapping**: Maintains spatial threat data from enemy observations to inform attack/defense decisions
5. **Adaptive production**: Changes factory output based on observed enemy composition (counter-building)

### BARbarianAI (BARb)

BARbarianAI is the BAR-specific fork of CircuitAI, maintained by the BAR community. It adds BAR-specific unit knowledge, build orders tuned for BAR's unit roster, and handles BAR-specific game mechanics (e.g., energy grid/pylon system, BAR-specific unit abilities).

**Known BARb limitations:**
- Occasionally crashes in certain game configurations (known issue on BAR GitHub)
- Limited adaptation to unusual maps or game modes
- No learning or improvement between games

---

## Appendix C: Headless vs. Live Engine Testing

### The Headless Limitation

`spring-headless` is designed for testing Lua game logic, not full physics simulation. The critical limitation:

**Headless mode does NOT simulate weapon physics, projectile creation, or damage calculations.**

This means in headless mode:
- Units accept attack/fight commands without error
- Weapon definitions are loaded (WeaponDefs takes ~26ms at startup)
- But weapons never actually fire — no projectiles are created
- No UnitDamaged, UnitDestroyed, EnemyDamaged, EnemyDestroyed, or WeaponFired events are ever generated
- This was confirmed empirically in HighBarV2 testing: 1200+ frames, assault tanks at point-blank range, zero combat events

### What CAN Be Tested Headless

| Capability | Headless | Live |
|-----------|----------|------|
| Unit spawning & discovery | Yes | Yes |
| Movement commands | Yes | Yes |
| Build orders | Yes | Yes |
| Economy (metal/energy) | Yes | Yes |
| LOS/radar events (with globallos) | Yes | Yes |
| Lua gadget interactions | Yes | Yes |
| Weapon fire & damage | **No** | Yes |
| Unit destruction from combat | **No** | Yes |
| Combat event processing | **No** | Yes |
| Tactical effectiveness | **No** | Yes |

### How BAR Community Handles This

The official BAR headless testing (in `tools/headless_testing/`) runs:
- Lua-level logic tests (command filtering, self-destruct handling)
- BARb smoke tests: two AIs run for 30 minutes to verify no crashes — but **does not validate combat outcomes**
- `infolog.txt` error scanning to detect runtime problems

Key configuration from BAR's official headless tests:
```
debugcommands=1:cheat|2:godmode|3:globallos|30:runtestsheadless;
deathmode=neverend;
FixedRNGSeed=1;
```

### Live Testing Strategy

For combat validation, the options are:
1. **Xvfb + `spring`**: Run the graphical engine against a virtual framebuffer (no physical GPU needed, but requires Xvfb installed). This is the most practical approach for CI/automated testing
2. **GPU-equipped machine + `spring`**: Full graphical engine with a real display. Best for interactive debugging
3. **`spring-dedicated` + TCP**: Use the dedicated server binary with a connecting client — but this changes the networking model from Unix sockets

---

## Appendix D: Comprehensive Forward Plan

### Phase 1: Foundation Fixes (Prerequisite)

**Goal**: Resolve blocking issues from Feature 013 before building AI logic

1. **Fix DefId Discovery** — Implement runtime DefId-to-unitName mapping by querying the engine's GetUnitDefs callback at init. Build a dynamic registry that maps engine DefIds to BarData unit records. This unblocks build commands and unit classification.

2. **Establish Live Test Harness** — Create a test fixture that launches `spring` (graphical binary) with Xvfb for combat testing. Verify all combat events (WeaponFired, UnitDamaged, UnitDestroyed) are delivered. This unblocks all combat AI development.

3. **Stabilize Large Spawn** — Identify which DefIds cause crashes at high unit counts. Build a safe-spawn list. This ensures stress testing works reliably.

### Phase 2: AI Core Architecture

**Goal**: Build the foundational AI decision-making framework

4. **GameState Model** — Implement a persistent game state that tracks:
   - All friendly units (type, position, health, current orders, idle state)
   - All known enemy units (type, last-known position, last-seen frame)
   - Economy state (metal/energy current, income, expenditure)
   - Map knowledge (metal spots, start positions, explored areas)

5. **Manager Framework** — Following CircuitAI's proven pattern, implement:
   - `EconomyManager` — Monitor resources, set build priorities
   - `BuildManager` — Decide what to build and where
   - `ProductionManager` — Control factory queues
   - `MilitaryManager` — Coordinate combat units
   - `ScoutManager` — Direct exploration

6. **Unit Task System** — Assign each unit a task (build-mex, build-energy, scout, idle) that determines its behavior each frame. Tasks can be reassigned as priorities change.

### Phase 3: Economy & Building AI

**Goal**: AI can bootstrap economy and build a functional base

7. **Metal Spot Analysis** — Query map for metal spots, rank by distance from start position and strategic value, assign builders to claim spots in priority order.

8. **Build Order Engine** — Implement opening build orders:
   - Commander builds metal extractors on nearest spots
   - Build energy to match metal income
   - Build first factory when economy supports it
   - Expand to more metal spots with additional builders

9. **Structure Placement** — Implement placement logic that:
   - Respects unit footprints (no overlaps)
   - Keeps pathways open
   - Places defenses at chokepoints (later phase)

10. **Factory Management** — Implement production queue logic:
    - Build ratio of combat/utility units
    - Keep factories busy when economy allows
    - Adjust production based on needs (more builders if expanding, more combat if under threat)

### Phase 4: Scouting & Intelligence

**Goal**: AI maintains awareness of enemy state

11. **Map Exploration** — Send early scout units to enemy start positions and resource-rich areas. Maintain a fog-of-war model of which map regions have been explored.

12. **Enemy Tracking** — Process LOS/radar events to maintain enemy unit database. Track enemy last-known positions, estimated strength, and likely unit composition.

13. **Threat Assessment** — Build a spatial threat model from enemy observations. Use it to identify:
    - Safe expansion directions
    - Vulnerable attack targets
    - Areas requiring defense

### Phase 5: Combat AI

**Goal**: AI engages in combat with tactical coordination (requires live engine testing)

14. **Army Grouping** — Form combat units into squads based on unit type and location. Move squads as coordinated groups.

15. **Attack Decision** — Decide when and where to attack based on:
    - Relative army strength (estimated from scouting)
    - Enemy base vulnerability
    - Own economic security

16. **Tactical Micro** — Basic combat micro:
    - Focus fire on high-value targets
    - Retreat critically damaged units
    - Use terrain advantages (high ground, chokepoints)

17. **Defense Response** — React to enemy attacks:
    - Pull nearby combat units to defend
    - Use guard commands on critical structures
    - Rebuild destroyed structures

### Phase 6: Integration & Competitive Testing

**Goal**: AI plays complete games and improves against BARb

18. **End-to-End Game Runner** — Automated tool that:
    - Launches AI vs BARb games (live engine with Xvfb)
    - Collects game outcomes (win/loss, game duration, units produced, resources gathered)
    - Generates performance reports

19. **Performance Benchmarking** — Track AI performance metrics across game versions:
    - Win rate vs BARb
    - Average game duration
    - Economy efficiency (resources gathered vs spent)
    - Combat efficiency (damage dealt vs taken)

20. **Iterative Improvement** — Use game outcome data to identify weaknesses and tune:
    - Build order timing
    - Production ratios
    - Attack timing thresholds
    - Scouting patterns
