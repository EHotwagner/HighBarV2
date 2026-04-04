# HighBar V2

> **Note:** This project uses [Spec Kit](https://github.com/github/spec-kit) for specification-driven development.
> Development is guided by a project constitution — see [constitution](.specify/memory/constitution.md) for the
> governing principles and architectural constraints.

A native proxy bridge for building AI agents that play [Beyond All Reason](https://www.beyondallreason.info/), a free open-source RTS game on the Recoil engine. HighBar V2 bridges the engine's C plugin interface with external AI processes over a high-performance binary protobuf protocol.

## How It Works

```
Recoil Engine ←→ C Proxy (libSkirmishAI.so) ←→ Unix Socket ←→ F# AI Client
                 serialize/deserialize            protobuf       GameState framework
                 arena allocation                  < 500us        5 AI managers
```

The C proxy loads as a standard Skirmish AI plugin. It serializes engine events to protobuf, sends them over a Unix domain socket, and executes the AI's command responses — all within a 1ms per-frame overhead budget. The F# client provides an idiomatic game loop with event processing, unit tracking, economy management, threat mapping, and a modular manager architecture.

## Features

- **Binary protocol** — Protobuf over Unix sockets targeting < 500us round-trip (10x improvement over V1's JSON/TCP)
- **28 event types, 97 command types, 135 callbacks** — Complete engine coverage
- **953 unit definitions** — Full BAR unit data with stats, weapons, economy, and capabilities
- **Modular AI framework** — GameState with Build, Economy, Production, Military, and Scout managers
- **Multi-tier test suite** — Unit, data, integration, persistent engine, and AI validation tests
- **Language-agnostic** — Proto schema is the contract; write clients in any language
- **Zero engine modifications** — Standard Skirmish AI plugin interface only

## Quick Start

### Build

```bash
# Generate protobuf bindings
cd proto && buf lint && buf generate && cd ..

# Build C proxy
cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build

# Build F# client
cd clients/fsharp && dotnet build && cd ../..
```

### Install

```bash
./scripts/install-ai.sh
```

### Run

```bash
# Start the AI client (listens for proxy connection)
cd tools/reference-ai && dotnet run &

# Launch BAR → Skirmish → Select "HighBar V2 AI" → Start
```

### Test

```bash
./tests/run-all.sh                        # All tests
./tests/run-all.sh --category unit        # Unit tests (no engine)
./tests/run-all.sh --category proxy       # C proxy tests (no engine)
./tests/run-all.sh --category integration # Integration (needs engine)
```

## Write Your Own AI

```fsharp
open HighBar.Client

let client = HighBarClient.AcceptFromProxy("/tmp/highbar.sock", 30000)

client.Run(fun frame ->
    frame.Events
    |> List.choose (fun ev ->
        match ev with
        | GameEvent.UnitIdle unitId ->
            Some (Commands.MoveCommand unitId 4096.0f 100.0f 4096.0f)
        | _ -> None
    )
)
```

Or use the full GameState framework for economy, building, and combat:

```fsharp
let client = HighBarClient.AcceptFromProxy("/tmp/highbar.sock", 30000)
let hs = client.Handshake()
let gs = GameState.init client hs.TeamId "/tmp/decisions.jsonl"
client.Run(GameState.createFrameHandler gs)
```

## Documentation

Full documentation is in the [`docs/`](docs/index.md) directory:

- [Getting Started](docs/getting-started.md) ��� Prerequisites, building, installation
- [Architecture](docs/architecture.md) — System design and data flow
- [Protocol Reference](docs/protocol.md) — Protobuf schema, events, commands, callbacks
- [F# Client API](docs/client-api.md) — HighBarClient, GameEvent, Commands, GameState
- [C Proxy Reference](docs/proxy-reference.md) — Plugin interface, memory model
- [Game Data](docs/game-data.md) — 953 BAR unit definitions
- [Configuration](docs/configuration.md) — Proxy options and environment variables
- [Tools](docs/tools.md) — echo-ai, game-runner, replay, reference-ai
- [Testing](docs/testing.md) — Multi-tier test documentation
- [Known Issues](docs/known-issues.md) — Current limitations and TODOs

## Project Structure

```
proto/              Protobuf schema definitions (source of truth)
proxy/              C shared library (Recoil engine AI plugin)
clients/fsharp/     F# client library (HighBar.Client)
data/bar/           Generated BAR unit data library (953 units)
tools/              Development utilities
tests/              Multi-tier test suites
specs/              Feature specifications (20 completed features)
docs/               Documentation
```

## Technology Stack

| Component | Technology |
|-----------|-----------|
| Proxy | C11, protobuf-c, CMake |
| Client | F# / .NET 10.0, Google.Protobuf |
| Protocol | Protocol Buffers 3, buf CLI |
| Testing | xUnit, CTest, custom test runner |
| Game | Beyond All Reason (Recoil engine) |

## Known Issues

- Headless engine does not simulate weapon physics — use graphical engine for combat tests
- Save/load state passthrough not yet implemented (stubs in proxy)
- See [Known Issues](docs/known-issues.md) for details

## License

This project is licensed under the MIT License — see [LICENSE](LICENSE) for details.
