# Plugin Interface Contract: Skirmish AI C Interface

**Engine**: Recoil (Spring RTS fork) via Beyond All Reason

## Shared Library Exports

The proxy MUST export these symbols conforming to `SSkirmishAILibrary`:

```c
// Called when engine loads the AI. Store callback pointer.
// Returns: 0 on success, non-zero on failure (AI not loaded)
int init(int skirmishAIId, const struct SSkirmishAICallback* callback);

// Called when engine unloads the AI. Cleanup resources.
// Returns: 0 on success
int release(int skirmishAIId);

// Called for each game event. Cast data based on topicId.
// Returns: 0 on success, non-zero signals engine to remove AI
int handleEvent(int skirmishAIId, int topicId, const void* data);
```

## Installation Layout

```
AI/Skirmish/HighBarV2/0.1/
├── AIInfo.lua          # interfaceShortName="C", interfaceVersion="0.1"
├── AIOptions.lua       # Configurable options
└── SkirmishAI.so       # Linux shared library (SkirmishAI.dll on Windows)
```

## AIInfo.lua Required Fields

```lua
local info = {
    { key = 'shortName',             value = 'HighBarV2' },
    { key = 'version',               value = '0.1' },
    { key = 'name',                  value = 'HighBar V2 - Native Proxy Bridge' },
    { key = 'description',           value = 'Forwards AI events over protobuf/UDS to external process' },
    { key = 'interfaceShortName',    value = 'C' },
    { key = 'interfaceVersion',      value = '0.1' },
}
return info
```

## Engine Callback Interface (SSkirmishAICallback)

Subset of critical callbacks the proxy must support:

| Category | Example Functions | Return Type |
|----------|-------------------|-------------|
| Engine | Engine_handleCommand, Engine_Version_getMajor | int, int |
| Game | Game_getTeamCount, Game_getMyTeam | int |
| Unit | Unit_getPos, Unit_getHealth, Unit_getMaxHealth, Unit_getDef | float[3], float, float, int |
| UnitDef | UnitDef_getName, UnitDef_getBuildOptions | const char*, int* |
| Map | Map_getWidth, Map_getHeight, Map_getHeightMap | int, int, float* |
| Resource | Resource_getName, Economy_getCurrent | const char*, float |

All callbacks take `int skirmishAIId` as first parameter. May ONLY be called from within `handleEvent` (engine thread context).

## Command Execution

Commands are issued via:
```c
int Engine_handleCommand(
    int skirmishAIId,
    int toId,          // -1 for engine
    int commandId,     // unique command instance ID
    int commandTopic,  // command type enum value
    void* commandData  // pointer to command-specific struct
);
```

Returns 0 on success, non-zero on failure.
