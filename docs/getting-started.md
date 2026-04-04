# Getting Started

This guide walks through building HighBar V2 from source and running your first AI game against Beyond All Reason.

## Prerequisites

| Requirement | Version | Purpose |
|-------------|---------|---------|
| .NET SDK | 10.0+ | F# client, data library, tools, tests |
| CMake | 3.10+ | C proxy build system |
| protobuf-c | 1.4+ | C protobuf library (`pkg-config --libs libprotobuf-c`) |
| buf CLI | latest | Proto linting and code generation |
| jq | any | JSON parsing in shell scripts |
| BAR AppImage | 1.2988.0+ | Beyond All Reason game (for live testing) |

### Install Dependencies (Arch Linux)

```bash
# .NET SDK
sudo pacman -S dotnet-sdk

# C build tools
sudo pacman -S cmake protobuf-c pkg-config

# buf CLI (proto tooling)
# See https://buf.build/docs/installation

# BAR game dependencies
sudo pacman -S sdl2 fuse2 openal gtk3 alsa-lib nss binutils
```

## Building

### 1. Generate Protobuf Bindings

```bash
cd proto && buf lint && buf generate && cd ..
```

This generates:
- C bindings in `proto/gen/c/highbar/`
- C# bindings in `proto/gen/csharp/Highbar/`

### 2. Build the C Proxy

```bash
cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/
cmake --build build
```

This produces `build/libSkirmishAI.so`, the engine plugin.

### 3. Build the F# Client

```bash
cd clients/fsharp && dotnet build && cd ../..
```

### 4. Build the BarData Library

```bash
cd data/bar && dotnet build && cd ../..
```

## Installing the AI

The `scripts/install-ai.sh` script handles the full installation:

```bash
./scripts/install-ai.sh
```

This will:
1. Generate protobuf C sources
2. Build the proxy shared library
3. Copy files to the BAR engine AI directory
4. Register the AI in the BAR lobby (Chobby)

### Manual Installation

If you prefer to install manually:

```bash
# Find your BAR engine directory
ENGINE_DIR=~/.local/state/Beyond\ All\ Reason/engine/recoil_*/

# Create the AI directory
mkdir -p "$ENGINE_DIR/AI/Skirmish/HighBarV2/0.1"

# Copy proxy binary and data files
cp build/libSkirmishAI.so "$ENGINE_DIR/AI/Skirmish/HighBarV2/0.1/"
cp proxy/data/AIInfo.lua "$ENGINE_DIR/AI/Skirmish/HighBarV2/0.1/"
cp proxy/data/AIOptions.lua "$ENGINE_DIR/AI/Skirmish/HighBarV2/0.1/"
```

## Running Your First Game

### Step 1: Start the F# AI Client

The AI client listens on a Unix domain socket and waits for the proxy to connect:

```bash
cd tools/reference-ai
dotnet run
```

By default, it listens on `/tmp/highbar.sock`.

### Step 2: Launch BAR with HighBar AI

1. Start BAR: `~/applications/Beyond-All-Reason-*.AppImage` (windowed mode)
2. Go to **Skirmish** in the lobby
3. Select **HighBar V2 AI** as your opponent
4. Start the game

The proxy loads inside the engine, connects to the F# client over the socket, performs a handshake, and begins the frame loop.

### Writing a Minimal AI

Here's a minimal F# AI that moves its first unit to the map center:

```fsharp
open HighBar.Client

let socketPath = "/tmp/highbar.sock"

// Accept proxy connection (proxy connects to us)
let client = HighBarClient.AcceptFromProxy(socketPath, 30000)

// Run the frame loop
client.Run(fun frame ->
    frame.Events
    |> List.choose (fun ev ->
        match ev with
        | GameEvent.UnitIdle unitId ->
            // Move idle units to map center
            Some (Commands.MoveCommand unitId 4096.0f 100.0f 4096.0f)
        | _ -> None
    )
)
```

### Using the GameState Framework

For a full AI with economy management, build orders, and combat:

```fsharp
open HighBar.Client
open HighBar.Client.Strategy

let socketPath = "/tmp/highbar.sock"
let client = HighBarClient.AcceptFromProxy(socketPath, 30000)
let hs = client.Handshake()

// Initialize game state from engine
let gs = GameState.init client hs.TeamId "/tmp/highbar-decisions.jsonl"

// Create the frame handler (initializes all managers)
let handleFrame = GameState.createFrameHandler gs

// Run the game
client.Run(handleFrame)
```

## Running Tests

```bash
# Run all tests (auto-detects engine)
./tests/run-all.sh

# Run specific categories
./tests/run-all.sh --category unit        # F# unit tests (no engine needed)
./tests/run-all.sh --category proxy       # C proxy tests (no engine needed)
./tests/run-all.sh --category data        # BarData validation (no engine needed)
./tests/run-all.sh --category integration # Integration tests (needs engine)
./tests/run-all.sh --category persistent  # Persistent engine tests (needs engine)

# Check engine prerequisites
./tests/check-prerequisites.sh
```

See [Testing](testing.md) for the full test documentation.

## Project Structure

```
proto/              Protobuf schema definitions (source of truth)
proxy/              C shared library (Recoil engine AI plugin)
clients/fsharp/     F# client library
data/bar/           Generated BAR unit data library (953 units)
tools/              Development utilities
tests/              Multi-tier test suites
specs/              Feature specifications (20 completed features)
docs/               Documentation
reports/            Test and investigation reports
scripts/            Installation and deployment scripts
```

## Next Steps

- [Architecture Overview](architecture.md) — Understand how the components fit together
- [Protocol Reference](protocol.md) — Learn the protobuf message format
- [Client API Reference](client-api.md) — Full F# client API documentation
- [Configuration](configuration.md) — Proxy options and environment variables
- [Game Data Reference](game-data.md) — Working with BAR unit definitions
