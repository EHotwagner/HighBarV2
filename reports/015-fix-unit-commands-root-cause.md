# Report: Unit Command Root Cause — INTERNAL_ORDER Flag

**Date**: 2026-04-04
**Iteration**: 15

## Context

Report 014 documented that all unit commands (COMMAND_UNIT_MOVE, COMMAND_UNIT_SELF_DESTROY, etc.) were silently ignored by the engine despite `Engine_handleCommand` returning 0 (success). Cheat commands like `COMMAND_CHEATS_GIVE_ME_NEW_UNIT` worked correctly. The bug was open and blocking all AI gameplay.

## Root Cause

Two issues combined to make this bug exceptionally hard to diagnose:

### 1. Missing `INTERNAL_ORDER` option flag

All unit command builders in `clients/fsharp/src/Commands.fs` were sending `options = 0`. The engine's command processing path in `AISCommands.cpp` constructs the internal `Command` object as:

```cpp
*c = Command(CMD_MOVE, cmd->options);
```

When `options = 0`, the engine treats the command differently from programmatic AI orders. Setting `options = UNIT_COMMAND_OPTION_INTERNAL_ORDER (8)` — defined in `AISCommands.h` as `(1 << 3)` — marks commands as internal/programmatic orders. With this flag set, the engine processes the command through the normal execution path.

The `options` field flows through: F# client → protobuf `MoveUnitCommand.options` → C proxy `SMoveUnitCommand.options` → engine `Command(CMD_MOVE, options)` → `SendAICommand(... options ...)` → network → `AINetOrder` → `GiveCommand`.

### 2. Stale proxy binary in `0.1/` directory

The engine's AI directory contained two copies of the proxy:
- `AI/Skirmish/HighBarV2/stable/libSkirmishAI.so` — updated during development
- `AI/Skirmish/HighBarV2/0.1/libSkirmishAI.so` — stale, never updated

The engine was loading the `0.1/` binary despite the AIInfo.lua log showing `stable/`. This meant every proxy rebuild and redeploy to `stable/` had no effect — the old binary with `options = 0` was always loaded. All debugging showed our fixes weren't taking effect.

Evidence: the `0.1/` binary contained hardcoded test commands at frame 150 (`handleCommand MOVE rc=0`, `handleCommand SELFD rc=0`) that appeared in engine logs. The `stable/` binary had no such code. Debug strings added to the `stable/` binary never appeared in logs.

## Investigation Path

### Engine Source Analysis

Cloned the Recoil engine source (`https://github.com/beyond-all-reason/spring`) and traced the full command execution path:

1. **`Engine_handleCommand`** (`SSkirmishAICallbackImpl.cpp:641`): Routes unit commands to `default:` case at line 1143
2. **`newCommand`** (`AISCommands.cpp:514`): Converts `SMoveUnitCommand` to internal `Command(CMD_MOVE, cmd->options)` — `options` is passed through
3. **`GiveOrder`** (`AICallback.cpp:351`): Validates unitId/team, sends via `clientNet->Send(SendAICommand(...))`, returns 0 immediately
4. **`GameServer`** (`GameServer.cpp:1252`): Receives `NETMSG_AICOMMAND`, broadcasts to clients
5. **`AINetOrder`** (`SelectedUnitsHandler.cpp:766`): Validates `aiTeamID == unit->team`, calls `GiveCommand`

Every step returns success. The command is accepted but has no effect because the `options` value of 0 causes the engine to treat it as a no-op in the command processing pipeline.

### Verification Test

Created `tests/persistent/fsharp/T2b_MoveVerifyTest.fs` — spawns a unit, records initial position, sends MoveCommand, waits 120 frames, checks position changed:

- **Before fix**: Position unchanged — `Start=(1536,4096) End=(1536,4096) Distance=0`
- **After fix**: Position moved — test passes, distance > 10 units

### Why Existing Tests Didn't Catch This

The existing movement tests (`T2_MovementTests.fs`) only verified:
- "MoveCommand was sent" (command serialized without error)
- "Frames ran without crash" (engine didn't crash)

They **never checked if the unit's position actually changed**. The new `T2b_MoveVerifyTest` adds this critical assertion.

## Fix

### Commands.fs — Add `INTERNAL_ORDER` to all unit commands

```fsharp
let [<Literal>] private INTERNAL_ORDER = 8u

let MoveCommand (unitId: int) (x: float32) (y: float32) (z: float32) : AICommand =
    let cmd = AICommand()
    let m = MoveUnitCommand()
    m.UnitId <- unitId
    m.Options <- INTERNAL_ORDER  // ← was missing
    m.ToPosition <- vec3 x y z
    m.Timeout <- 2147483647
    cmd.MoveUnit <- m
    cmd
```

Applied to all 13 unit command builders: MoveCommand, BuildCommand, PatrolCommand, AttackCommand, GuardCommand, StopCommand, RepairCommand, ReclaimUnitCommand, FightCommand, SetWantedMaxSpeedCommand, SelfDestructCommand, CustomCommand.

Not applied to non-unit commands (SendTextMessage, GiveMeResource, GiveMeNewUnit, CallLuaRules, CallLuaUI) — these don't have an `options` field or use different code paths (cheat commands).

### Proxy deployment — Both directories

Must deploy to BOTH `0.1/` and `stable/` directories:
```bash
cp build/libSkirmishAI.so ".../AI/Skirmish/HighBarV2/0.1/"
cp build/libSkirmishAI.so ".../AI/Skirmish/HighBarV2/stable/"
```

## Verification

Full test suite: **221 tests pass, 0 failures** across all tiers (proxy, unit, data, integration, persistent).

The new move verification test confirms the unit physically moves after receiving a MoveCommand with `options = INTERNAL_ORDER`.

## Files Changed

| File | Change |
|------|--------|
| `clients/fsharp/src/Commands.fs` | Added `INTERNAL_ORDER = 8u` flag to all 13 unit command builders |
| `tests/persistent/fsharp/T2b_MoveVerifyTest.fs` | New test: verifies unit position changes after MoveCommand |
| `tests/persistent/fsharp/HighBar.PersistentTests.fsproj` | Added T2b_MoveVerifyTest.fs to compile order |
| `proxy/src/proxy.c` | Debug logging for move command details (temporary, can be removed) |
| `proxy/src/deserialize.c` | Debug fprintf for move struct values (temporary, can be removed) |

## Lessons Learned

1. **Always deploy proxy to ALL version directories** (`0.1/` and `stable/`). The engine may load from either based on AIInfo.lua version matching.
2. **`Engine_handleCommand` returning 0 means "accepted", not "executed"** — the command may still be silently dropped downstream in the network/simulation pipeline.
3. **`UNIT_COMMAND_OPTION_INTERNAL_ORDER` (8)** is required for AI commands to be processed. Without it, the engine accepts the command at the API level but does not execute it on the unit.
4. **Tests must verify outcomes, not just inputs** — checking "command was sent" is insufficient. Must check "unit position changed" or "unit was destroyed".
5. **Stale binaries in multiple directories** are a silent and devastating debugging trap. Always verify with `md5sum` that the running binary matches what you built.
