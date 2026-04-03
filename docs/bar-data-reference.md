# BAR Game Data Reference

Where all Beyond All Reason game data lives in the HighBarV2 repo.

## 1. Generated F# Unit Library — `data/bar/`

The primary structured data source. A .NET 8.0 F# library containing **953 unit definitions**, **46 engine commands**, and **22 BAR custom commands**, all parsed from the official BAR repo.

### Key Files

| File | Contents |
|------|----------|
| `src/Types.fs` | Typed record definitions: `ValueOrExpr<'T>`, `UnitDef`, `MovementDef`, `BuilderDef`, `WeaponDef`, `EconomyDef`, `BuildingDef`, `FeatureDef`, `SoundDef` |
| `src/Commands.fs` | 46 engine command literal constants (`MOVE = 10`, `ATTACK = 20`, `GUARD = 25`, etc.) plus `buildCmd` helper and `all` list |
| `src/CustomCommands.fs` | 22 BAR-specific command IDs (`FACTORY_GUARD = 13921`, `MORPH = 31210`, `AREA_MEX = 30100`, etc.) |
| `src/AllUnits.fs` | Master index: `all` is a `(name * subfolder * UnitDef) list` of all 953 units, plus `tryFind` by name |

### Unit Module Files (102 files in `src/`)

Organized by faction and category, each module exposes individual unit bindings and an `all` list:

**Armada (Arm)** — 19 modules, ~214 units
- `ArmAircraft.fs`, `ArmAircraft_T2.fs` — aircraft (T1 + T2)
- `ArmBots.fs`, `ArmBots_T2.fs` — kbots (T1 + T2)
- `ArmVehicles.fs`, `ArmVehicles_T2.fs` — vehicles (T1 + T2)
- `ArmShips.fs`, `ArmShips_T2.fs` — naval (T1 + T2)
- `ArmBuildings_LandDefenceOffence.fs` — turrets, shields, nukes
- `ArmBuildings_LandEconomy.fs` — metal extractors, solar, fusion
- `ArmBuildings_LandFactories.fs` — bot lab, vehicle plant, aircraft plant
- `ArmBuildings_LandUtil.fs` — radar, storage, teleporter
- `ArmBuildings_Sea*.fs` — naval equivalents (4 modules)
- `ArmGantry.fs`, `ArmHovercraft.fs`, `ArmSeaplanes.fs`

**Cortex (Cor)** — 19 modules, ~222 units
- Same structure as Arm: Aircraft, Bots, Vehicles, Ships, Buildings, Gantry, Hovercraft, Seaplanes

**Legion** — 28 modules, ~233 units
- `Legion_Air.fs`, `Legion_Air_T2_Air.fs`
- `Legion_Bots.fs`, `Legion_Bots_T2_Bots.fs`
- `Legion_Vehicles.fs`, `Legion_Vehicles_T2_Vehicles.fs`
- `Legion_Ships.fs`, `Legion_Ships_T2.fs`
- `Legion_Constructors.fs`, `Legion_Labs.fs`
- `Legion_Defenses.fs`, `Legion_Economy.fs`, `Legion_Utilities.fs`
- `Legion_T3.fs` — tier 3 experimentals
- `Legion_SeaDefenses.fs`, `Legion_SeaEconomy.fs`, `Legion_SeaPlanes.fs`, etc.
- `Legion_Legion_EvoCom.fs`, `Legion_Other_Commanders.fs`

**Scavengers** — 9 modules, ~83 units
- `Scavengers_Air.fs`, `Scavengers_Bots.fs`, `Scavengers_Vehicles.fs`, `Scavengers_Ships.fs`
- `Scavengers_Boss.fs` — boss units
- `Scavengers_Buildings_*.fs` — 3 modules (DefenseOffense, Economy, Utility)
- `Scavengers_Other.fs`

**Other** — 27 modules, ~201 units
- `other.fs` — misc units (walls, dragons teeth, nanobots)
- `other_critters.fs` — decorative animals
- `other_evocom.fs` — evolving commander variants
- `other_hats.fs` — cosmetic hat items
- `other_lootboxes.fs` — loot containers
- `other_raptors*.fs` — 17 raptor variant modules (Acid, Arty, Assault, Bomber, Brood, Electric, Fighter, Flamer, Healer, Kamikaze, Miniqueen, Overseer, Scout, Spectre, Spiker, Structures, Swarmer)

### Data Format

Each unit is a typed `UnitDef` record with native F# field access and composable capability sub-records:

```fsharp
open BarData
open BarData.Units

let ham = ArmBots.armham
ham.metalCost       // ValueOrExpr.Concrete 130.0
ham.health          // ValueOrExpr.Concrete 1000.0
ham.movement.Value.speed  // ValueOrExpr.Concrete 46.2
ham.movement.Value.movementClass  // Some "BOT3"

// Capability checking via option pattern matching
match ham.weapons with
| Some ws -> printfn "Weapons: %d" ws.Length
| None -> printfn "Unarmed"

match ham.builder with
| Some b -> printfn "Can build: %A" b.buildOptions
| None -> printfn "Not a builder"

// Commander has all capabilities
let com = Root.armcom
com.movement.IsSome  // true
com.builder.IsSome   // true
com.weapons.IsSome   // true

// Economy building
let solar = ArmBuildings_LandEconomy.armadvsol
solar.economy.Value.energyMake  // Some (ValueOrExpr.Concrete 80.0)

// Handle ValueOrExpr for fields that may be runtime Lua expressions
match solar.economy.Value.energyMake with
| Some (ValueOrExpr.Concrete v) -> printfn "Energy: %f" v
| Some (ValueOrExpr.Expr s) -> printfn "Dynamic: %s" s
| None -> printfn "No production"

// Find units by name
AllUnits.tryFind "armham"  // UnitDef option

// Browse all units
for (name, sub, def) in AllUnits.all do
    printfn "%s (%s): %A metal" name sub def.metalCost
```

Universal fields (`metalCost`, `energyCost`, `buildTime`, `health`, `sightDistance`, `footprintX/Z`, etc.) are present on every unit. Capability sub-records (`movement`, `builder`, `weapons`, `economy`, `building`) are `option` types — present only when the unit has that capability. Unrecognized fields are preserved in `extras: Map<string, string>`.

Runtime Lua expressions (e.g., `Spring.GetModOptions()`) are captured as `ValueOrExpr.Expr` strings — these appear in ~35 unit files.

### Generator Script

`tools/generate-bar-data.fsx` — F# script using XParsec to parse Lua table literals.

```bash
dotnet fsi tools/generate-bar-data.fsx              # clone BAR repo + generate
dotnet fsi tools/generate-bar-data.fsx --skip-clone  # regenerate from existing clone
dotnet build data/bar/BarData.fsproj                 # build the library
```

---

## 2. Protobuf Protocol Definitions — `proto/highbar/`

The serialization schema for all AI-engine communication. 5 proto files defining ~200 message types.

| File | Contents |
|------|----------|
| `common.proto` | `Vector3`, `UnitRef`, `CommandOptions` bitfield |
| `commands.proto` | 97 command types in `AICommand` oneof: Move, Attack, Build, Patrol, Fight, Guard, Repair, Reclaim, Resurrect, Capture, LoadUnits, UnloadUnit, SelfDestruct, SetFireState, SetMoveState, CallLuaRules, CallLuaUI, DrawPoint, DrawLine, GiveMeNewUnit, etc. |
| `events.proto` | 28 event types in `EngineEvent` oneof: Init, Update, UnitCreated, UnitFinished, UnitIdle, UnitMoveFailied, UnitDamaged, UnitDestroyed, UnitGiven, UnitCaptured, EnemyEnterLOS, EnemyLeaveLOS, EnemyEnterRadar, EnemyLeaveRadar, EnemyDamaged, EnemyDestroyed, EnemyCreated, EnemyFinished, WeaponFired, CommandFinished, Message, PlayerCommand, SeismicPing, LuaMessage, Save, Load, Release |
| `callbacks.proto` | 30+ callback request/response types for querying engine state: map dimensions, heightmap, LOS/radar maps, metal spots, unit position/health/speed/def, economy, team info, engine version |
| `messages.proto` | Top-level framing: `Handshake` (protocol version, engine version, map, mod, team), `Frame` (batched events), `FrameResponse` (batched commands + callbacks) |

---

## 3. F# Client Bindings — `clients/fsharp/src/`

Type-safe wrappers over the protobuf protocol.

| File | Contents |
|------|----------|
| `Events.fs` | `GameEvent` discriminated union with 28 variants + `fromProto` converter from raw protobuf |
| `Commands.fs` | Builder functions for all command types: `MoveCommand`, `AttackCommand`, `BuildUnitCommand`, `PatrolCommand`, `FightCommand`, `GuardCommand`, `RepairCommand`, `ReclaimUnitCommand`, `StopCommand`, `SetFireStateCommand`, `SetMoveStateCommand`, `SelfDestructCommand`, `CallLuaRulesCommand`, etc. |
| `Client.fs` | `HighBarClient` class with `Connect()`, `Handshake()`, `Run(handler)` — manages socket, frame loop, event/command dispatch |

---

## 4. Python Client Bindings — `clients/python/`

Python dataclass-based wrappers.

| File | Contents |
|------|----------|
| `events.py` | 28 event dataclasses mirroring the protobuf events |
| `commands.py` | Command builder functions returning dicts, `Position` dataclass |
| `client.py` | Client connection and frame loop |

---

## 5. C Proxy Plugin — `proxy/`

The native shared library loaded by the Recoil engine.

| Path | Contents |
|------|----------|
| `src/proxy.c` | Plugin lifecycle: init, release, update, event handlers |
| `src/connection.c` | Unix domain socket / TCP loopback connection |
| `src/serialize.c` | Engine events → protobuf serialization |
| `src/deserialize.c` | Protobuf → engine commands deserialization (759 lines, largest file) |
| `src/callbacks.c` | Engine callback invocation and response marshaling |
| `src/config.c` | Configuration loading from Lua options |
| `src/arena.c` | Arena allocator for protobuf buffers |
| `data/AIOptions.lua` | Configurable options: `socket_path`, `timeout_ms` (default 25), `log_level`, `frame_mode`, `max_message_size` (default 8MB), transport (unix/tcp), port |
| `data/AIInfo.lua` | Plugin identity: name "HighBar", version, engine compatibility |

---

## 6. Engine & Architecture Research — `docs/research/`

| Document | Key Data |
|----------|----------|
| `01-recoil-engine-ai-interface.md` | Complete catalog of all 28 events, 97 commands, and 200+ callback functions available through the engine's C AI interface |
| `05-architecture-spec.md` | System design: proxy architecture, protocol framing, frame sync model |
| `06-protobuf-schema-design.md` | Full message catalog with field definitions for every proto type |

---

## 7. Test Fixtures — `tests/`

| File | Contents |
|------|----------|
| `engine-version.json` | Pinned versions: engine `2025.06.21`, game content `test-29833-ee0f96a`, map `Comet Catcher Remake` |
| `fixtures/game-setup.lua` | Lua start script: 2 teams, 2 AIs, builder units, close spawns for combat testing |
| `fixtures/game-setup.txt` | TDF-format start script template with `__SOCKET_PATH__` / `__AI_DLL__` placeholders |

---

## 8. Feature Specifications — `specs/`

| Spec | Relevant Data |
|------|---------------|
| `001-native-proxy-bridge/` | Protocol design, socket options, message size limits, timeout behavior |
| `001-native-proxy-bridge/contracts/protocol.md` | Wire format: length-prefixed protobuf, backpressure rules, error handling |
| `003-tools-prereqs-test-fixes/data-model.md` | Test entity definitions |
| `004-live-headless-testsuite/` | Engine download, game content setup, headless test execution |
| `005-fix-test-failures/data-model.md` | Game-setup.txt format, init event expectations |

---

## Quick Reference: Where to Find What

| Looking for... | Go to... |
|----------------|----------|
| All unit stats (cost, health, speed, weapons) | `data/bar/src/` — individual modules or `AllUnits.tryFind "unitname"` |
| What a specific unit can build | `unitDef.builder.Value.buildOptions` |
| Engine command IDs | `data/bar/src/Commands.fs` — `EngineCommands.MOVE`, etc. |
| BAR custom command IDs | `data/bar/src/CustomCommands.fs` — `CustomCommands.MORPH`, etc. |
| Build command for a unit | `EngineCommands.buildCmd unitDefId` (negative of def ID) |
| Command options bitfield | `proto/highbar/commands.proto` — SHIFT=32, CTRL=64, ALT=128 |
| What events the AI receives | `proto/highbar/events.proto` or `clients/fsharp/src/Events.fs` |
| What the AI can query at runtime | `proto/highbar/callbacks.proto` |
| Proxy configuration options | `proxy/data/AIOptions.lua` |
| How to issue a command in F# | `clients/fsharp/src/Commands.fs` — `Commands.MoveCommand`, etc. |
| How to issue a command in Python | `clients/python/commands.py` |
| Full engine AI API reference | `docs/research/01-recoil-engine-ai-interface.md` |
| Wire protocol format | `specs/001-native-proxy-bridge/contracts/protocol.md` |
| Regenerate unit data | `dotnet fsi tools/generate-bar-data.fsx` |
