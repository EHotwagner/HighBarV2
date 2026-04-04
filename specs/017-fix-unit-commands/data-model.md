# Data Model: Fix Unit Commands

**Feature**: 017-fix-unit-commands
**Date**: 2026-04-04

## Affected Data Structures

### `Engine_handleCommand` Parameters

The C callback function pointer with signature:

```
int (*Engine_handleCommand)(int skirmishAIId, int toId, int commandId, int commandTopic, void* commandData)
```

| Parameter | Current Value | Correct Value | Impact |
|-----------|--------------|---------------|--------|
| `skirmishAIId` | AI instance ID | No change | N/A |
| `toId` | -1 (COMMAND_TO_ID_ENGINE) | No change | N/A |
| `commandId` | **0** | **-1** | Controls NETMSG packet type |
| `commandTopic` | Command enum (e.g., 42) | No change | N/A |
| `commandData` | Pointer to S*Command struct | No change | N/A |

### Engine Packet Type Selection

```
commandId == -1  →  NETMSG_AICOMMAND          →  GameServer handles it  →  command executes
commandId != -1  →  NETMSG_AICOMMAND_TRACKED  →  GameServer drops it    →  command lost
```

### Named Constant

Introduce `COMMAND_ID_UNTRACKED` (-1) in `proxy/include/highbar/engine_types.h` to document the semantic meaning and avoid magic numbers.

## No Schema Changes

- No protobuf schema changes
- No new entities
- No state transitions
- The `commandId` is internal to the proxy-engine interface, not exposed in the client protocol
