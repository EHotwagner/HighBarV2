# HighBar V1 Project Analysis

## Repository

https://github.com/EHotwagner/HighBar/tree/master

## Project Summary

HighBar V1 is an **active work-in-progress** external AI bridge for Beyond All Reason. It allows controlling BAR AI teams from a separate process over TCP. Created 2026-04-01.

## Architecture

HighBar V1 uses a **Lua bridge** approach (no engine modifications required):

```
External Process (Python) <--TCP/NDJSON--> Lua Widget (unsynced) <--SendLuaMsg--> Lua Gadget (synced) --> Spring.GiveOrder*()
```

### Components

1. **Lua Widget** (`luaui/Widgets/api_ai_bridge.lua`, ~77 KB) -- Runs in unsynced (render) context. Opens TCP server on `127.0.0.1:18457` via `luasocket`. Handles observation, serialization, and message routing.

2. **Lua Gadget** (`luarules/Gadgets/api_ai_executor.lua`, ~10 KB) -- Runs in synced (simulation) context. Validates ownership, bounds, rate limits. Executes commands via `Spring.GiveOrderToUnit()`.

3. **Python Client** (`bar_ai_client/`, stdlib-only) -- `BARClient` class with dataclass models. Zero external dependencies.

### Communication Flow

- Widget-to-Gadget: `Spring.SendLuaRulesMsg("@AIX|{json}")` 
- Gadget-to-Widget: `Spring.SendLuaUIMsg("@AIX_RESULT|{json}")`
- External-to-Widget: TCP socket with NDJSON protocol

## Technology Stack

| Layer | Technology |
|-------|-----------|
| Bridge (in-engine) | Lua 5.1 + luasocket |
| Protocol | NDJSON (newline-delimited JSON) over TCP |
| Client library | Python 3.10+, stdlib only |
| Tests | pytest (69 tests: protocol, unit, integration) |
| Serialization | JSON (MessagePack upgrade planned) |

**No C/C++, F#, or protobuf files exist** in the repo despite CLAUDE.md mentioning F#/.NET 10.0 for test infrastructure.

## Protocol Details

- Protocol version: **2** (backward-compatible with v1)
- Max message size: **20 MB**
- Max commands per frame: **256**
- Supports **stepped mode** (pause/unpause frame control) and **realtime mode**
- Supports base64-encoded grid data for heightmaps, slopemaps, etc.
- Single client only (v0.1 limitation)

## Supported Operations (V2)

### Queries
- Unit definitions and properties
- Weapon definitions
- Heightmaps, slopemaps, LOS maps, metal maps
- Pathfinding
- Team info, resource status
- Camera control

### Commands
- Unit movement/combat orders
- Build orders
- Cheat/debug commands
- Team operations
- Map drawing

## Current State

**Late alpha / early beta.** Core architecture solid but real-world integration with BAR engine is being debugged.

- 7 specifications (001-007) tracking development
- Specs 004-007 are bug-fix specs for handshake, headless socket, synced ops, and integration issues
- Mailbox folder (004-008) contains debugging session notes
- `reports/007-current-situation-and-fix-plan.md` indicates remaining integration problems

## Project Structure

```
HighBar/
├── .claude/commands/          # Claude Code slash-command templates
├── .specify/                  # Specification scaffolding
├── CLAUDE.md                  # Development guidelines
├── README.md                  # Full documentation
├── pyproject.toml             # Python package config
├── bar_ai_client/             # Python client library
│   ├── __init__.py
│   ├── client.py              # BARClient class (~17 KB)
│   ├── models.py              # Dataclasses (~26 KB)
│   ├── protocol.py            # NDJSON serialization (~4 KB)
│   └── exceptions.py          # Exception hierarchy
├── luaui/Widgets/
│   └── api_ai_bridge.lua      # TCP server + observation (~77 KB)
├── luarules/Gadgets/
│   └── api_ai_executor.lua    # Synced command execution (~10 KB)
├── scripts/
│   └── script.txt             # Headless game launch template
├── tests/                     # 69 tests
├── specs/                     # 7 feature specifications
└── reports/                   # Research & status reports
```

## Limitations of V1 Approach

1. **JSON overhead**: NDJSON serialization is slow for large game states (heightmaps, unit lists)
2. **TCP overhead**: Extra latency vs. pipes/Unix sockets for local-only communication
3. **Lua bridge bottleneck**: All data must pass through Lua's string serialization and the SendLuaMsg mechanism
4. **Single client**: Only one external process can connect
5. **No binary data support**: Grid data requires base64 encoding, adding ~33% overhead
6. **Frame timing**: Lua widget update frequency depends on render frame rate, not sim frame rate

## Relevance to V2

HighBar V1 validates that external AI control works for BAR. V2 (this project) aims to:
- Replace NDJSON/TCP with protobuf/pipes for lower latency and better binary data handling
- Move from Lua bridge to native C shared library proxy for direct access to SSkirmishAICallback
- Support the full engine AI interface (28 events, 97 commands, complete callback)
- Enable high-performance use cases (RL training, faster-than-realtime simulation)
