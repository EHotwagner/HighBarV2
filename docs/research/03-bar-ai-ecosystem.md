# BAR AI Development Ecosystem

## Two Parallel AI Systems

BAR supports two distinct AI systems that can coexist:

### A. Native Skirmish AIs (C/C++/Java)

Compiled shared libraries loaded through the AI Interface plugin system. Examples: CircuitAI (C++), AAI, RAI.

- **Loading**: Engine -> AI Interface (.so) -> Skirmish AI (.so) via dlopen
- **API**: `SSkirmishAICallback` struct (C function pointers, ~200 functions)
- **Events**: `handleEvent()` with 28 topic IDs and C structs
- **Commands**: `Engine_handleCommand()` with 97 command topics
- **Performance**: Engine blocks waiting for AI response (no frame skipping)
- **Distribution**: Independent plugin, installed separately

### B. Lua AIs (Mod-Bundled)

Run inside the engine's Lua VM as gadgets. BAR's primary AI uses the **Shard AI Framework**.

- **Loading**: `LuaAI.lua` config + `AILoader.lua` gadget
- **API**: Spring Lua API (`Spring.GiveOrderToUnit()`, `Spring.GetTeamUnits()`, etc.)
- **Events**: Gadget callbacks (`UnitCreated()`, `GameFrame()`, etc.)
- **Commands**: `Spring.GiveOrder*()` variants
- **Performance**: Runs within frame budget in Lua VM
- **Distribution**: Bundled with game mod

### Comparison

| Aspect | Native AI | Lua AI |
|--------|-----------|--------|
| Language | C/C++/Java/Rust | Lua 5.1 |
| Distribution | Independent plugin | Bundled with mod |
| API | SSkirmishAICallback (C struct) | Spring Lua API |
| State isolation | Full per-instance | Must manually separate by teamID |
| Performance | Blocks engine | Shares Lua VM budget |
| Compilation | Build shared library | Interpreted scripts |
| Debugging | External debugger | In-game Lua console |

## BAR's Shard AI Framework

BAR's primary AI system, entirely Lua-based:

### Architecture
- **AILoader gadget** (`luarules/gadgets/AILoader.lua`) -- discovers and initializes AI instances
- **Task Queues** -- priority-ordered: Economy, Build, Bot, Vehicle; hierarchical subtasks
- **Behaviors** -- group strategies: Attackers, Raiders, Defenders, Scouts
- **Handlers** -- subsystems: Placement, Artillery, Constructor, Economy, Factory
- **Unit Tracking** -- categorized sets: `ownUnitIds`, `friendlyUnitIds`, `alliedUnitIds`, `enemyUnitIds`, `neutralUnitIds`

### Command Dispatch Variants
- `spGiveOrderToUnit()` -- 1 order to 1 unit
- `spGiveOrderArrayToUnit()` -- N orders to 1 unit
- `spGiveOrderToUnitArray()` -- 1 order to N units
- `spGiveOrderArrayToUnitArray()` -- N orders to N units

### Memory Management
- Table recycling pools (`RezTable`/`KillTable`/`ResetTable`)
- GC every ~121 frames
- Base allocation: 200MB runtime + 50MB per AI instance, capped at 1GB

### Registration
```lua
-- LuaAI.lua at mod root
return {
    {name = 'ShardLua', desc = 'Shard-based AI'},
}
```

## Existing Out-of-Process Approaches

**None exist for Spring/Recoil.** Research found no projects that proxy Spring AI through external processes via any IPC mechanism.

### What Does Exist
- **Rust bindings** (`spring_ai_rs` / `spring_ai_sys`) -- wraps C interface in Rust, still in-process
- **Java AI Interface** -- loads JVM inside engine process, in-process
- **Lua <-> Native bridge**: `COMMAND_CALL_LUA_RULES` + `EVENT_LUA_MESSAGE` -- bidirectional string messaging, still in-process
- **HighBar V1** -- Lua bridge approach (TCP/NDJSON), only approach that achieves out-of-process control

### Reference: Other Game AI Proxies
- **SC2API (StarCraft II)**: Protobuf over WebSocket/TCP. The gold standard. Uses `Request`/`Response` messages with `oneof` for ~30 message types. Synchronous per game step.
- **BWAPI (Brood War)**: Shared memory for AI communication via injected DLL.
- **OpenAI Gym environments**: Typically TCP-based with JSON or custom binary protocols.

## Key Insight for V2

A native C shared library proxy is the cleanest approach:
1. Export `SSkirmishAILibrary` functions (handleEvent, init, release)
2. On init, establish pipe/socket IPC to external process
3. On each handleEvent, serialize event data via protobuf, forward over IPC
4. Receive command responses, call `Engine_handleCommand()` on behalf of external process
5. Forward callback queries similarly (or cache/batch game state per frame)

This avoids the Lua bridge bottleneck entirely and gives full access to the 200+ callback functions, 28 events, and 97 commands.
