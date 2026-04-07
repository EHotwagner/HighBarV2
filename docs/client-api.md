# F# Client API Reference

The `HighBar.Client` library provides an idiomatic F# interface for building AI agents that play Beyond All Reason through the HighBar V2 proxy.

**Project:** `clients/fsharp/HighBar.Client.fsproj` | **Target:** net10.0

## HighBarClient

The main connection class. Manages socket communication, handshake, frame loop, and callback queries.

```fsharp
type HighBarClient(socketPath: string)
```

### Connection Methods

| Method | Description |
|--------|-------------|
| `Connect()` | Connect to a proxy socket (client initiates) |
| `AcceptFrom(listener)` | Accept a connection from the proxy on a listening socket |
| `WrapSocket(socket)` | Wrap an already-connected socket |
| `Disconnect()` | Close the connection |
| `Handshake()` | Wait for Handshake, send HandshakeResponse. Returns `Handshake` metadata |

### Static Constructors

```fsharp
// Connect to proxy (proxy is already listening)
let client = HighBarClient.Connect("/tmp/highbar.sock")

// Listen and wait for proxy to connect (typical for testing)
let client = HighBarClient.AcceptFromProxy("/tmp/highbar.sock", timeoutMs = 30000)
```

### Frame Loop

```fsharp
member Run(onFrame: GameFrame -> AICommand list) : unit
member StepFrame(onFrame: GameFrame -> AICommand list) : GameFrame option
```

`Run` runs the continuous game loop — receives frames, calls `onFrame`, sends commands. Exits on `Shutdown`.

`StepFrame` processes a single frame: receives one Frame, calls handler, sends response, returns `Some frame` or `None` on Shutdown. Useful for controlled frame-by-frame operation.

```fsharp
client.Run(fun frame ->
    // Process frame.Events, return commands
    [ Commands.MoveCommand 1 100.0f 0.0f 100.0f ]
)
```

### Callback Queries

Query engine state mid-frame. These can be called during frame processing or initialization.

**Unit Definition Queries:**

| Method | Signature | Description |
|--------|-----------|-------------|
| `GetUnitDefs(maxCount)` | `int -> int array` | All valid unitDefId values |
| `GetUnitDefName(defId)` | `int -> string` | Engine name for a unit type |
| `GetBuildOptions(defId)` | `int -> int array` | Buildable defIds for a unit type |
| `GetMaxWeaponRange(defId)` | `int -> float32` | Weapon range (0 = unarmed) |
| `GetBuildSpeed(defId)` | `int -> float32` | Build speed (0 = not builder) |
| `GetUnitDefCost(defId)` | `int -> float32` | Metal cost |
| `GetUnitDefBuildTime(defId)` | `int -> float32` | Build time |

**Live Unit Queries:**

| Method | Signature | Description |
|--------|-----------|-------------|
| `GetUnitDef(unitId)` | `int -> int` | Unit's defId |
| `GetUnitPos(unitId)` | `int -> float32 * float32 * float32` | Position (x, y, z) |
| `GetUnitHealth(unitId)` | `int -> float32` | Current health |
| `GetUnitMaxHealth(unitId)` | `int -> float32` | Maximum health |
| `GetUnitTeam(unitId)` | `int -> int` | Team ID |
| `GetUnitMaxSpeed(unitId)` | `int -> float32` | Maximum speed |

**Map Queries:**

| Method | Signature | Description |
|--------|-----------|-------------|
| `GetMapWidth()` | `unit -> int` | Map width (map squares) |
| `GetMapHeight()` | `unit -> int` | Map height (map squares) |
| `GetStartPos(teamId)` | `int -> float32 * float32 * float32` | Team start position |
| `GetMetalSpots()` | `unit -> (float32 * float32 * float32 * float32) array` | Metal spots (x,y,z,value) |

**Economy Queries:**

| Method | Signature | Description |
|--------|-----------|-------------|
| `GetEconomyCurrent(resourceId)` | `int -> float32` | Current amount (0=metal, 1=energy) |
| `GetEconomyIncome(resourceId)` | `int -> float32` | Income per second |
| `GetEconomyUsage(resourceId)` | `int -> float32` | Usage per second |
| `GetEconomyStorage(resourceId)` | `int -> float32` | Storage capacity |

**Game Queries:**

| Method | Signature | Description |
|--------|-----------|-------------|
| `GetMyTeam()` | `unit -> int` | Our team ID |
| `GetMyAllyTeam()` | `unit -> int` | Our ally team ID |
| `SetCheatEventsEnabled(enabled)` | `bool -> bool` | Enable cheat events; returns previous state |

**Raw Callback:**

```fsharp
member SendCallback(callbackId: uint32, params: CallbackParam list) : CallbackResponse
```

---

## GameFrame

```fsharp
type GameFrame = {
    FrameNumber: uint32
    Events: GameEvent list
}
```

---

## GameEvent

Discriminated union wrapping all 28 engine event types for idiomatic pattern matching.

```fsharp
[<RequireQualifiedAccess>]
type GameEvent =
    | Init of teamId: int
    | Release
    | Update of frame: int
    | Message of player: int * message: string
    | UnitCreated of unitId: int * builderId: int
    | UnitFinished of unitId: int
    | UnitIdle of unitId: int
    | UnitMoveFailed of unitId: int
    | UnitDamaged of unitId: int * attackerId: int option * damage: float32
                     * weaponDefId: int * isParalyzer: bool
    | UnitDestroyed of unitId: int * attackerId: int option
    | UnitGiven of unitId: int * oldTeamId: int * newTeamId: int
    | UnitCaptured of unitId: int * oldTeamId: int * newTeamId: int
    | EnemyEnterLOS of enemyId: int
    | EnemyLeaveLOS of enemyId: int
    | EnemyEnterRadar of enemyId: int
    | EnemyLeaveRadar of enemyId: int
    | EnemyDamaged of enemyId: int * attackerId: int option * damage: float32
                     * weaponDefId: int
    | EnemyDestroyed of enemyId: int * attackerId: int option
    | WeaponFired of unitId: int * weaponDefId: int
    | PlayerCommand of units: int list * commandTopicId: int * commandId: int
    | SeismicPing of x: float32 * y: float32 * z: float32 * strength: float32
    | CommandFinished of unitId: int * commandId: int * commandTopicId: int
    | Load
    | Save
    | EnemyCreated of enemyId: int
    | EnemyFinished of enemyId: int
    | LuaMessage of data: string * inMessageId: int
    | Unknown
```

---

## Commands Module

Builder functions that create protobuf `AICommand` messages. All unit commands set the `INTERNAL_ORDER` flag (8).

```fsharp
module Commands
```

| Function | Signature | Description |
|----------|-----------|-------------|
| `MoveCommand` | `int -> float32 -> float32 -> float32 -> AICommand` | Move unit to (x,y,z) |
| `BuildCommand` | `int -> int -> float32 -> float32 -> float32 -> int -> AICommand` | Build structure (unitId, defId, x, y, z, facing) |
| `PatrolCommand` | `int -> float32 -> float32 -> float32 -> AICommand` | Patrol to waypoint |
| `FightCommand` | `int -> float32 -> float32 -> float32 -> AICommand` | Attack-move to position |
| `AttackCommand` | `int -> int -> AICommand` | Attack target unit |
| `GuardCommand` | `int -> int -> AICommand` | Guard another unit |
| `StopCommand` | `int -> AICommand` | Cancel all orders |
| `RepairCommand` | `int -> int -> AICommand` | Repair a unit |
| `ReclaimUnitCommand` | `int -> int -> AICommand` | Reclaim a unit |
| `SelfDestructCommand` | `int -> AICommand` | Self-destruct |
| `SetWantedMaxSpeedCommand` | `int -> float32 -> AICommand` | Limit speed |
| `SendTextMessageCommand` | `string -> int -> AICommand` | Chat message |
| `CustomCommand` | `int -> int -> float32 list -> AICommand` | Custom engine command |
| `GiveMeResourceCommand` | `int -> float32 -> AICommand` | Cheat: give resources |
| `GiveMeNewUnitCommand` | `int -> float32 -> float32 -> float32 -> AICommand` | Cheat: spawn unit |
| `CallLuaRulesCommand` | `string -> AICommand` | Call Lua rules |
| `CallLuaUICommand` | `string -> AICommand` | Call Lua UI |

---

## UnitRegistry

Runtime registry that maps engine unit IDs to definitions and tracks unit state.

```fsharp
type UnitRegistry()
```

### Unit Definitions

| Method | Description |
|--------|-------------|
| `DiscoverFromEngine(client)` | Query all unitDefs from engine and populate registry |
| `RegisterDef(defId, name, buildOptions, maxWeaponRange, buildSpeed, cost, buildTime)` | Register a unit definition |
| `TryGetDef(defId) : RuntimeUnitDef option` | Look up definition by defId |
| `TryGetDefByName(name) : RuntimeUnitDef option` | Look up definition by name |

### Unit Tracking

| Method | Description |
|--------|-------------|
| `TrackFriendly(unitId, defId, team, name)` | Start tracking a friendly unit |
| `TrackEnemy(unitId, defId, team, name)` | Start tracking an enemy unit |
| `UpdatePosition(unitId, x, y, z, frame)` | Update unit position |
| `UpdateHealth(unitId, health, maxHealth)` | Update unit health |
| `MarkFinished(unitId)` | Mark unit construction complete (Ready) |
| `MarkDestroyed(unitId)` | Mark unit as Dead |
| `MarkLastKnown(unitId)` | Mark enemy as last-known position |
| `MarkInLOS(unitId, frame)` | Mark enemy as visible |

### Queries

| Method | Description |
|--------|-------------|
| `TryGet(unitId) : UnitRecord option` | Get tracked unit by ID |
| `GetFriendlyByClass(cls) : UnitRecord list` | Get friendly units matching classification |
| `GetAliveEnemies() : UnitRecord list` | Get all known-alive enemies |

### Unit Classification

```fsharp
static member Classify(name, buildOptions, maxWeaponRange, buildSpeed, cost) : UnitClass
```

Heuristic classification based on engine properties:

| Class | Criteria |
|-------|---------|
| `Commander` | Name contains "com"/"decoy" + builder + weapons |
| `Builder` | buildSpeed > 0 |
| `Factory` | Has build options + buildSpeed > 0 |
| `MobileArmed` | maxWeaponRange > 0 |
| `Scout` | cost < 200 + no weapons + no build |
| `Economy` | Name contains "mex", "solar", "wind", "fusion", "geo", "moho" |
| `Radar` | Name contains "radar", "arad" |

---

## UnitRecord

```fsharp
type UnitRecord = {
    UnitId: int
    DefId: int
    Team: int
    Name: string
    mutable Classification: UnitClass
    mutable Lifecycle: UnitLifecycle
    mutable PosX: float32
    mutable PosY: float32
    mutable PosZ: float32
    mutable Health: float32
    mutable MaxHealth: float32
    mutable LastSeenFrame: uint32
}
```

### UnitLifecycle

```fsharp
type UnitLifecycle = Alive | Ready | Dead | LastKnown | Forgotten
```

### UnitClass (Flags)

```fsharp
[<Flags>]
type UnitClass =
    | None = 0
    | Commander = 1
    | Builder = 2
    | Factory = 4
    | MobileArmed = 8
    | StaticDefense = 16
    | Scout = 32
    | Economy = 64
    | Radar = 128
    | Transport = 256
```

---

## RuntimeUnitDef

```fsharp
type RuntimeUnitDef = {
    DefId: int
    Name: string
    BuildOptions: int array
    MaxWeaponRange: float32
    BuildSpeed: float32
    Cost: float32
    BuildTime: float32
    mutable Classification: UnitClass
}
```

---

## GameState Module

Root game state management with event processing, manager orchestration, and command generation.

### Initialization

```fsharp
GameState.init (client: HighBarClient) (teamId: int) (logPath: string) : GameState
```

Queries the engine for map data, metal spots, start positions, and unit definitions. Creates the unit registry, economy model, threat map, and decision log.

### Frame Processing

```fsharp
GameState.processFrame (gs: GameState)
    (economyMgr: EconomyManager) (buildMgr: BuildManager)
    (productionMgr: ProductionManager) (militaryMgr: MilitaryManager)
    (scoutMgr: ScoutManager) (frame: GameFrame) : AICommand list
```

Per-frame pipeline:
1. Process all events (update registry, economy, threat)
2. Update economy (every 8 frames)
3. Evaluate phase transitions (every 30 frames)
4. Decay threat map (every 60 frames)
5. Collect manager proposals (20ms frame budget)
6. Merge proposals by priority → task assignments
7. Generate commands from tasks

### Convenience

```fsharp
GameState.createFrameHandler (gs: GameState) : (GameFrame -> AICommand list)
```

Creates all managers and returns a closure suitable for `HighBarClient.Run()`.

---

## Strategy Types

### GamePhase

```fsharp
type GamePhase = Opening | Expansion | MidGame | LateGame
```

Phase transitions:
- **Opening → Expansion:** When first factory is built
- **Expansion → MidGame:** When army value > 2000 metal
- **MidGame → LateGame:** When a T2 factory (cost > 2000) is available

### PhaseWeights

```fsharp
type PhaseWeights = {
    Economy: int; Build: int; Production: int; Scout: int; Military: int
}
```

### MapModel

```fsharp
type MapModel = {
    Width: int; Height: int
    MetalSpots: MetalSpot list
    StartPositions: (float32 * float32 * float32) list
    OurStartX: float32; OurStartY: float32; OurStartZ: float32
}
```

---

## Task System

### UnitTask

```fsharp
type UnitTask =
    | Idle
    | BuildMex of x: float32 * y: float32 * z: float32
    | BuildEnergy of x: float32 * y: float32 * z: float32
    | BuildFactory of defId: int * x: float32 * y: float32 * z: float32
    | BuildStructure of defId: int * x: float32 * y: float32 * z: float32
    | Produce of defId: int
    | Scout of x: float32 * y: float32 * z: float32
    | Attack of x: float32 * y: float32 * z: float32
    | Defend of x: float32 * y: float32 * z: float32
    | Retreat of x: float32 * y: float32 * z: float32
    | Guard of targetId: int
    | Reclaim of targetId: int
    | Repair of targetId: int
```

### TaskAssigner

```fsharp
type TaskAssigner()
```

| Method | Description |
|--------|-------------|
| `GetTask(unitId) : UnitTask option` | Current task for a unit |
| `Assign(unitId, task)` | Directly assign a task |
| `Remove(unitId)` | Remove task assignment |
| `ProcessProposals(proposals)` | Merge proposals by priority, resolve conflicts |
| `AllAssignments : (int * UnitTask) seq` | All current assignments |

### CommandProposal

```fsharp
type CommandProposal = {
    UnitId: int
    Task: UnitTask
    Priority: int
}
```

---

## Managers

All managers inherit from `ManagerBase(name)` and produce `CommandProposal list`.

### BuildManager

Executes a predefined build order (Armada opening): 2 mex → energy → factory → 2 mex → energy.

### EconomyManager

Assigns idle builders to best mex spots or energy positions based on resource state:
- Metal stalled → build mex at nearest unoccupied spot
- Energy stalled → build energy near base
- Balanced → build mex (expanding economy)

### ProductionManager

Assigns idle factories to produce units with a 70% combat / 30% builder ratio.

### MilitaryManager

- **Defense:** Retreat damaged units (health < 30%), defend base when threatened
- **Offense:** Attack with squads of 5+ armed units

### ScoutManager

Sends up to 2 idle combat units to explore enemy start positions and map quadrants.

---

## EconomyModel

```fsharp
type EconomyModel = {
    mutable MetalCurrent: float32; mutable MetalIncome: float32
    mutable MetalUsage: float32; mutable MetalStorage: float32
    mutable EnergyCurrent: float32; mutable EnergyIncome: float32
    mutable EnergyUsage: float32; mutable EnergyStorage: float32
}
```

| Function | Description |
|----------|-------------|
| `EconomyModel.create()` | Create with zero values |
| `EconomyModel.update client model` | Query engine for current values |
| `EconomyModel.isMetalStalled model` | Metal income < usage and current < 50 |
| `EconomyModel.isEnergyStalled model` | Energy income < usage and current < 100 |

---

## ThreatMap

Grid-based spatial threat model overlaid on the game map.

```fsharp
type ThreatMap(mapWidthElmos: int, mapHeightElmos: int, cellSize: int)
```

| Method | Description |
|--------|-------------|
| `ToGrid(x, z)` | Convert world position to grid coordinates |
| `GetAt(gx, gz)` | Get threat value at grid cell |
| `SetGroundThreat(gx, gz, value)` | Set threat at cell |
| `AddGroundThreat(gx, gz, delta)` | Add to threat at cell |
| `RemoveGroundThreat(gx, gz, delta)` | Remove from threat at cell |
| `Decay(frame, factor)` | Apply exponential decay (default 0.95x) to all cells |
| `GetThreat(x, z)` | Get threat at world position |

Default cell size is 512 elmos.

---

## DecisionLog

JSON lines logger for structured AI decision tracking.

```fsharp
type DecisionLog(path: string)
```

| Method | Description |
|--------|-------------|
| `Open()` | Create/open log file |
| `Log(entry)` | Write a decision log entry |
| `Close()` | Flush and close |

```fsharp
type DecisionLogEntry = {
    Frame: uint32
    Manager: string
    Type: string
    UnitId: int option
    Details: string
    Context: Map<string, string>
}
```

---

## Engine Lifecycle Management

Modules for launching, configuring, and managing the BAR engine process. Used by test fixtures and can be used by any F# application that needs to orchestrate engine sessions.

### EngineConfig

Configuration record for an engine session. All fields have sensible defaults.

```fsharp
type EngineMode = Headless | Graphical

type EngineConfig = {
    Mode: EngineMode
    SocketPath: string          // Auto-generated: /tmp/highbar-{guid}.sock
    MapName: string             // From engine-version.json or HIGHBAR_TEST_MAP
    GameType: string            // From engine-version.json
    EngineBin: string           // "spring-headless" or HIGHBAR_TEST_ENGINE
    DataDir: string option      // Auto-detected or SPRING_DATADIR
    OpponentAI: string          // "NullAI"
    OpponentSide: string        // "Cortex"
    OurSide: string             // "Armada"
    AcceptTimeoutMs: int        // 30000 or HIGHBAR_TEST_TIMEOUT * 1000
    ReadTimeoutMs: int          // 10000 or HIGHBAR_CLIENT_TIMEOUT_MS
    GameSpeed: int              // 10
    ShutdownGraceMs: int        // 5000
}
```

**Factory functions:**

| Function | Description |
|----------|-------------|
| `EngineConfig.defaultConfig()` | Defaults with unique GUID socket path |
| `EngineConfig.fromVersionFile(path)` | Load from `engine-version.json`, apply env var overrides |
| `EngineConfig.validate(config)` | Fail fast on invalid values (empty strings, negative timeouts) |

### EngineSession

Unified lifecycle abstraction — manages engine process, socket, handshake, frame loop, and cleanup.

```fsharp
type SessionState = Idle | Starting | Connected | Running | Stopped | Error of string

type EngineSession(config: EngineConfig) =
    member Start() : unit                                    // Launch engine, connect, handshake
    member Step() : GameFrame                                // Receive one frame (no commands)
    member StepWith(handler) : GameFrame                     // Receive frame, send commands
    member Run(count, handler) : GameFrame list              // Run N frames
    member RunUntil(predicate, handler) : GameFrame list     // Run until condition met
    member Stop(preserveSession: bool) : unit                // Cleanup (preserve logs on failure)
    member GetDiagnostics() : SessionDiagnostics             // Collect log excerpts
    member ThrowIfEngineCrashed() : unit                     // Raise with diagnostic context
    member Client : HighBarClient                            // Direct client access for callbacks
    member IsEngineAlive : bool
    member State : SessionState
    member SessionDir : string
    interface IDisposable
```

**Usage:**

```fsharp
let config = EngineConfig.fromVersionFile "tests/engine-version.json" |> EngineConfig.validate
use session = new EngineSession(config)
session.Start()

// Run 30 warm-up frames
let frames = session.Run(30, fun _ -> [])

// Use client for callbacks inside frame handlers
session.Client.Run(fun frame ->
    let pos = session.Client.GetUnitPos(unitId)
    [ Commands.MoveCommand unitId pos.X pos.Y pos.Z ]
)

session.Stop(preserveSession = false)
```

### EngineLauncher

Process management: spawning, data directory detection, graceful shutdown, orphan cleanup.

| Function | Description |
|----------|-------------|
| `launch(config, scriptContent)` | Spawn engine process, write PID file, redirect logs |
| `stop(socketPath, proc, graceMs)` | SIGTERM → wait → SIGKILL, clean up files |
| `detectDataDir(engineBin)` | Walk up from binary, fall back to standard BAR paths |
| `getSessionDir(config)` | Derive `/tmp/highbar-{guid}/` from socket path |
| `cleanupStaleProcesses()` | Scan PID files, kill dead processes, warn about untracked ones |

### ScriptGenerator

Generates Spring engine TDF-format startup scripts programmatically from `EngineConfig`.

```fsharp
let script = ScriptGenerator.generate config
// Produces complete [GAME] block with map, factions, teams, AI config, socket path, cheats
```

### SessionDiagnostics

Collects engine log excerpts for error reporting.

```fsharp
type SessionDiagnostics = {
    SessionDir: string
    SocketPath: string
    LastFrameNumber: uint32
    EngineExitCode: int option
    StdoutTail: string list     // Last 50 lines
    StderrTail: string list
    InfologTail: string list
}
```

| Function | Description |
|----------|-------------|
| `collect(sessionDir, socketPath, lastFrame, proc)` | Read log tails from session directory |
| `formatReport(diag)` | Human-readable multi-line diagnostic string |

See also: [Architecture](architecture.md) | [Protocol](protocol.md) | [Game Data](game-data.md)
