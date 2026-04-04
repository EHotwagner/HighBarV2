# Architecture Overview

HighBar V2 is a native proxy bridge that enables AI development for the [Beyond All Reason](https://www.beyondallreason.info/) (BAR) real-time strategy game. It bridges the Recoil game engine's C plugin interface with external AI processes over a binary protobuf protocol.

> **Spec Kit:** This project uses specification-driven development. See the [constitution](./../.specify/memory/constitution.md) for governing principles and architectural constraints.

## System Overview

```
┌──────────────────────────────────────────────────────────┐
│                    Recoil Game Engine                     │
│                                                          │
│  ┌─────────────────────────────────────────────────────┐ │
│  │        Skirmish AI Plugin Interface                  │ │
│  │  init() · handleEvent() · release()                 │ │
│  │  SSkirmishAICallback function table                 │ │
│  └──────────────┬──────────────────────────────────────┘ │
└─────────────────┼────────────────────────────────────────┘
                  │ C ABI
┌─────────────────┼────────────────────────────────────────┐
│  C Proxy        │  (libSkirmishAI.so)                    │
│  ┌──────────────┴──────────────────────────────────────┐ │
│  │ serialize.c ──→ protobuf ──→ connection.c ──→ wire  │ │
│  │ wire ──→ connection.c ──→ deserialize.c ──→ execute │ │
│  │                                                     │ │
│  │ arena.c (bump allocator) · config.c · callbacks.c   │ │
│  └──────────────┬──────────────────────────────────────┘ │
└─────────────────┼────────────────────────────────────────┘
                  │ Length-prefixed protobuf over
                  │ Unix domain socket / TCP loopback
┌─────────────────┼────────────────────────────────────────┐
│  F# AI Client   │  (HighBar.Client)                      │
│  ┌──────────────┴──────────────────────────────────────┐ │
│  │ Client.fs ─── Events.fs ─── Commands.fs             │ │
│  │ GameState.fs ─── UnitRegistry.fs ─── EconomyModel.fs│ │
│  │ ThreatMap.fs ─── TaskAssigner.fs                    │ │
│  │                                                     │ │
│  │ Managers: Build · Economy · Production · Military ·  │ │
│  │           Scout                                     │ │
│  │ Strategy: StrategyController · BuildOrder · MapAnalys│ │
│  └─────────────────────────────────────────────────────┘ │
│                                                          │
│  BarData (953 unit definitions)                          │
└──────────────────────────────────────────────────────────┘
```

## Components

### C Proxy (`proxy/`)

A shared library (`libSkirmishAI.so`) loaded by the Recoil engine as a Skirmish AI plugin. It implements the three-function AI interface:

| Function | Purpose |
|----------|---------|
| `init()` | Load config, create arena, connect socket, perform handshake, enable cheats |
| `handleEvent()` | Serialize engine events to protobuf, send frames, receive and execute AI commands |
| `release()` | Send shutdown notification, close socket, destroy arena |

**Key design decisions:**
- **Single-threaded.** The engine calls `handleEvent` sequentially; threading adds complexity with no benefit.
- **Arena allocation.** A bump allocator (`arena.c`) is reset per frame for all protobuf message construction. No heap allocation on the hot path.
- **Batched framing.** Events accumulate within a frame and are sent as a single `Frame` message on the `UPDATE` event, reducing socket round-trips.

Source files:

| File | Responsibility |
|------|---------------|
| `proxy.c` | Plugin lifecycle, frame batching, handshake |
| `connection.c` | Socket I/O with length-prefixed framing |
| `serialize.c` | Engine event structs → protobuf messages (28 event types) |
| `deserialize.c` | Protobuf commands → engine command structs (97 command types) |
| `callbacks.c` | Callback dispatch (AI queries engine state) |
| `arena.c` | Bump allocator with per-frame reset |
| `config.c` | Configuration from engine info and environment variables |

### Protobuf Schema (`proto/highbar/`)

The `.proto` files are the single source of truth for the protocol. Five schema files define the complete protocol:

| File | Contents |
|------|----------|
| `common.proto` | Shared types: `Vector3`, `UnitRef`, `CommandOptions` |
| `messages.proto` | Top-level envelope: `ProxyMessage`, `AIMessage`, `Handshake`, `Frame`, `FrameResponse` |
| `events.proto` | 28 engine event types (`EngineEvent` oneof) |
| `commands.proto` | 97 AI command types (`AICommand` oneof) |
| `callbacks.proto` | 135 callback types for engine state queries |

Code generation produces:
- **C bindings** via `protobuf-c` in `proto/gen/c/`
- **C# bindings** via `Google.Protobuf` in `proto/gen/csharp/` (consumed by F# client)

### F# Client Library (`clients/fsharp/`)

An idiomatic F# client that connects to the proxy and implements a complete AI game loop.

**Core layer:**
- `HighBarClient` — Socket connection, handshake, frame loop, callback queries
- `GameEvent` — Discriminated union wrapping all 28 engine event types
- `Commands` — Builder functions for all 17 frequently-used command types
- `UnitRegistry` — Runtime unit tracking with lifecycle state (Alive → Ready → Dead → LastKnown)
- `EconomyModel` — Metal/energy income, usage, storage tracking
- `ThreatMap` — Grid-based spatial threat model with exponential decay

**AI layer:**
- `GameState` — Root state container with event processing and command generation
- `TaskAssigner` — Priority-based task assignment with conflict resolution
- `StrategyController` — Phase-based strategy (Opening → Expansion → MidGame → LateGame)
- **Five managers:** Build, Economy, Production, Military, Scout — each proposes tasks weighted by game phase

### BarData Library (`data/bar/`)

A generated F# library containing 953 unit definitions for Beyond All Reason, covering all factions:

| Faction | Unit Count |
|---------|-----------|
| Armada (Arm) | 200+ |
| Cortex (Cor) | 200+ |
| Legion | 220+ |
| Scavengers | 80+ |
| Other (raptors, critters, etc.) | 50+ |

Each unit has full stat data: cost, health, weapons, movement, builder capabilities, economy output, and custom parameters. Generated from BAR game Lua files by `tools/generate-bar-data.fsx`.

### Tools (`tools/`)

| Tool | Purpose |
|------|---------|
| `echo-ai` | Minimal AI that echoes events — useful for protocol debugging |
| `game-runner` | Engine lifecycle management (start, stop, health check) |
| `reference-ai` | Full reference AI implementation using GameState framework |
| `replay` | Replay file reader for recorded game sessions |
| `generate-bar-data.fsx` | Parses BAR Lua unit files and generates the BarData F# library |

## Data Flow

### Frame Loop (steady state)

```
Engine                    Proxy                     F# Client
  │                         │                          │
  │── handleEvent(UPDATE) ──│                          │
  │                         │── Frame (protobuf) ──────│
  │                         │                          │── process events
  │                         │                          │── update state
  │                         │                          │── run managers
  │                         │                          │── generate commands
  │                         │◄── FrameResponse ────────│
  │                         │── deserialize commands    │
  │◄── handleCommand() ────│                          │
  │                         │                          │
```

### Callback Flow (mid-frame engine queries)

```
F# Client                 Proxy                     Engine
  │                         │                          │
  │── CallbackRequest ─────│                          │
  │                         │── SSkirmishAICallback() ─│
  │                         │◄── result ──────────────│
  │◄── CallbackResponse ───│                          │
  │                         │                          │
```

### AI Decision Pipeline (per frame)

```
Events received
  └─→ Process events (update UnitRegistry, EconomyModel, ThreatMap)
       └─→ Update economy (every 8 frames)
       └─→ Evaluate phase transitions (every 30 frames)
       └─→ Decay threat map (every 60 frames)
       └─→ Collect manager proposals (20ms frame budget)
            ├── BuildManager: execute build order
            ├── EconomyManager: assign builders to mex/energy
            ├── ProductionManager: factory production queues
            ├── MilitaryManager: retreat, defend, attack squads
            └── ScoutManager: explore map quadrants
       └─→ Merge proposals by priority → task assignments
       └─→ Generate commands from tasks
```

## Design Principles

The project is governed by seven constitutional principles (see [constitution](./../.specify/memory/constitution.md)):

1. **Zero Engine Modifications** — Standard Skirmish AI plugin interface only
2. **Binary Protocol First** — Protobuf + Unix sockets, targeting < 500us round-trip
3. **Correctness Over Cleverness** — 1:1 struct mapping, no lossy conversions
4. **Test at the Boundary** — Round-trip serialization tests are highest value
5. **Latency Budget Discipline** — < 1ms proxy overhead, < 25ms AI response budget
6. **Language-Agnostic by Default** — Proto schema is the contract; clients in any language
7. **Explicit Over Implicit** — All config documented with defaults and env overrides

## Performance Targets

| Metric | Budget |
|--------|--------|
| Event serialization | < 100us per frame (all events batched) |
| Socket round-trip | < 500us per frame |
| Total proxy overhead | < 1ms per frame |
| AI response budget | < 25ms of 33ms frame time (30fps) |
| Memory | Arena allocation, reset per frame, no per-event heap alloc |
