# Quickstart: Native C Proxy Bridge

**Feature**: 001-native-proxy-bridge | **Date**: 2026-04-02

## Prerequisites

- Beyond All Reason installed
- CMake 3.20+, C compiler (gcc/clang), protobuf-c compiler
- For F# client: .NET 8+ SDK
- For Python client: Python 3.10+, pip
- `buf` CLI for proto linting/generation

## Build the Proxy

```bash
# Clone and build
git clone <repo-url> && cd HighBarV2
cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/
cmake --build build

# Install into BAR
cp build/SkirmishAI.so ~/.spring/AI/Skirmish/HighBarV2/0.1/
cp proxy/data/AIInfo.lua ~/.spring/AI/Skirmish/HighBarV2/0.1/
cp proxy/data/AIOptions.lua ~/.spring/AI/Skirmish/HighBarV2/0.1/
```

## Generate Client Code

```bash
# Generate all language bindings from proto schemas
buf generate
```

## Install F# Client

```bash
cd clients/fsharp
dotnet build
# Reference HighBar.Client in your project
```

## Install Python Client

```bash
cd clients/python
pip install -e .
```

## Write Your First AI (F#)

```fsharp
open HighBar.Client

let myAI = HighBarClient.Connect("/tmp/highbar.sock")

myAI.OnFrame(fun frame ->
    for event in frame.Events do
        match event with
        | UnitFinished unitId ->
            // Order finished units to patrol
            [ PatrolCommand(unitId, Position(500.0f, 0.0f, 500.0f)) ]
        | _ -> []
)

myAI.Run()
```

## Write Your First AI (Python)

```python
from highbar import HighBarClient, PatrolCommand, Position

client = HighBarClient("/tmp/highbar.sock")

@client.on_frame
def handle_frame(frame):
    commands = []
    for event in frame.events:
        if event.HasField("unit_finished"):
            commands.append(PatrolCommand(
                unit_id=event.unit_finished.unit_id,
                position=Position(500, 0, 500)
            ))
    return commands

client.run()
```

## Run a Game

1. Start your AI process first (it listens on the socket)
2. Launch Beyond All Reason
3. Start a skirmish, select "HighBarV2" as an AI opponent
4. The proxy connects to your AI process and begins streaming events

## Configuration (AIOptions.lua)

```lua
local options = {
    {
        key    = 'socket_path',
        name   = 'Socket Path',
        desc   = 'Unix domain socket path for AI communication',
        type   = 'string',
        def    = '/tmp/highbar.sock',
    },
    {
        key    = 'timeout_ms',
        name   = 'Frame Timeout (ms)',
        desc   = 'Max time to wait for AI response per frame',
        type   = 'number',
        def    = '25',
        min    = '1',
        max    = '1000',
    },
    {
        key    = 'log_level',
        name   = 'Log Level',
        desc   = 'Logging verbosity (0=ERROR, 1=WARN, 2=INFO, 3=DEBUG)',
        type   = 'number',
        def    = '2',
        min    = '0',
        max    = '3',
    },
    {
        key    = 'frame_mode',
        name   = 'Frame Mode',
        desc   = 'Event delivery mode (0=INDIVIDUAL, 1=BATCHED)',
        type   = 'number',
        def    = '1',
    },
    {
        key    = 'push_state',
        name   = 'Push State',
        desc   = 'Include game state snapshot with frame updates',
        type   = 'bool',
        def    = 'false',
    },
}
return options
```

## Environment Variable Overrides

All config options can be overridden via environment variables:

| Variable | Overrides |
|----------|-----------|
| HIGHBAR_SOCKET_PATH | socket_path |
| HIGHBAR_TIMEOUT_MS | timeout_ms |
| HIGHBAR_LOG_LEVEL | log_level |
| HIGHBAR_FRAME_MODE | frame_mode |
| HIGHBAR_PUSH_STATE | push_state |
| HIGHBAR_MAX_MSG_SIZE | max_message_size |
| HIGHBAR_TRANSPORT | transport (UNIX/TCP) |
| HIGHBAR_TCP_PORT | tcp_port |

## Verify It Works

```bash
# Run the echo test AI (logs all events)
cd tools/echo-ai
dotnet run
# In another terminal, start a BAR game with HighBarV2
# You should see events streaming in the echo-ai output
```
