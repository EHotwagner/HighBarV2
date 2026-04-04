# Tools Reference

Development utilities in the `tools/` directory.

## echo-ai

**Project:** `tools/echo-ai/EchoAI.fsproj`

A minimal AI that echoes received events to the console. Useful for verifying the proxy is sending events correctly and debugging the protocol.

```bash
cd tools/echo-ai && dotnet run
```

Connects to `/tmp/highbar.sock`, accepts the handshake, and prints every received event. Returns empty command lists (passive AI).

## reference-ai

**Project:** `tools/reference-ai/ReferenceAI.fsproj`

A full reference AI implementation using the `GameState` framework with all five managers (Build, Economy, Production, Military, Scout). This is the canonical example of a complete AI built on HighBar V2.

```bash
cd tools/reference-ai && dotnet run
```

Uses `HighBarClient.AcceptFromProxy()` to listen for the proxy connection, initializes `GameState`, and runs the frame loop with `GameState.createFrameHandler()`.

## game-runner

**Project:** `tools/game-runner/GameRunner.fsproj`

Engine lifecycle management utility. Handles starting and stopping the Recoil engine for testing and development.

```fsharp
open GameRunner

// GameRunner provides:
// - Engine process start/stop
// - Health checking
// - Log collection
// - Cleanup on exit
```

Used by the test harnesses to manage engine instances during integration and persistent tests.

## replay

**Project:** `tools/replay/Replay.fsproj`

Reads binary replay files recorded by the proxy's connection recording feature. Useful for post-game analysis and debugging.

```bash
cd tools/replay && dotnet run -- /path/to/recording.bin
```

The replay tool deserializes the length-prefixed protobuf messages from the recording file and displays the frame-by-frame event and command history.

**ReplayFormat.fs** handles the binary format: sequences of length-prefixed messages tagged with direction (proxy→AI or AI→proxy).

## generate-bar-data.fsx

**Location:** `tools/generate-bar-data.fsx` (81KB F# script)

Generates the `BarData` library from Beyond All Reason Lua unit definition files.

```bash
cd tools && dotnet fsi generate-bar-data.fsx
```

This script:
1. Locates the BAR game content directory
2. Reads all `units/` Lua files using XParsec (Lua parser)
3. Extracts unit definitions with full stat data
4. Generates F# source files in `data/bar/src/`:
   - Per-faction/category modules with individual unit records
   - `AllUnits.fs` with the global summary index
   - `AllUnitDefs.fs` with composable definitions
   - `Types.fs` and `ComposableTypes.fs` with shared type definitions
5. Preserves Lua expressions as `Expr` values where direct parsing fails

## Scripts

### `scripts/install-ai.sh`

Complete installation and registration:
1. Generates protobuf C sources via buf
2. Builds proxy with cmake
3. Installs to BAR engine AI directory
4. Registers in Chobby lobby

### `scripts/patch-chobby-ai.sh`

Patches the BAR lobby (Chobby) rapid pool to register HighBar V2 in the AI selection dropdown. Parses the SDP binary format and replaces the `aisimplename.lua` content with entries for HighBar V2.

### `proxy/scripts/deploy-proxy.sh`

Post-build deployment: copies the proxy binary and data files to all BAR engine version directories found on the system. Called automatically by CMake after a successful build.

See also: [Getting Started](getting-started.md) | [Architecture](architecture.md)
