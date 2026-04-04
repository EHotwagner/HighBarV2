# Report: Live Game AI Installation & Unit Command Investigation

**Date**: 2026-04-04
**Iteration**: 14

## Context

Goal was to install the HighBarV2 custom AI into the live BAR (Beyond All Reason) game client so it could be selected from the lobby and play a real game. This involved deploying the C proxy shared library, registering the AI in the Chobby lobby, connecting the F# AI client, and verifying that unit commands actually work.

## Problem

### Installation (Solved)
1. BAR AppImage required FUSE module (unavailable) — extracted with `--appimage-extract`
2. AI not visible in lobby — Chobby's `aisimplename.lua` whitelist controls which AIs appear
3. Patching rapid pool files corrupted Chobby (black screen on launch)

### Unit Commands (Open — Critical Bug)
The proxy successfully connects to the engine, receives events, and sends commands. **Cheat commands** (e.g., `COMMAND_CHEATS_GIVE_ME_NEW_UNIT`) execute correctly — spawned units appear in-game. However, **all unit commands** (move, patrol, fight, self-destruct) are silently ignored despite `Engine_handleCommand` returning 0 (success).

## Investigation

### Installation Steps

1. **Proxy deployment**: Built via CMake, installed to `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/AI/Skirmish/HighBarV2/0.1/` with `libSkirmishAI.so`, `AIInfo.lua`, `AIOptions.lua`

2. **Chobby registration**: BAR's lobby uses `aisimplename.lua` (inside a rapid pool package) to control which AIs appear in the bot selection list. The VFS load order is `rMmeb` — raw filesystem files override pool files. Placing a modified `aiSimpleName.lua` at `~/.local/state/Beyond All Reason/LuaMenu/configs/gameConfig/byar/aiSimpleName.lua` successfully registers the AI without modifying pool files. **Do NOT patch pool files directly** — this corrupts checksums and causes Chobby to fail to load (black screen).

3. **Developer mode**: `devmode.txt` must exist in the BAR data directory (`~/.local/state/Beyond All Reason/`) for dev options.

4. **F# client connection**: The proxy connects to the F# client via Unix domain socket at `/tmp/highbar.sock`. The F# client must be listening (`AcceptFromProxy`) before the game starts. The proxy attempts connection during its `init()` function (called when the engine loads skirmish AIs).

5. **Automated script**: `scripts/install-ai.sh` automates: proto generation → CMake build → file installation → devmode.txt creation. `scripts/patch-chobby-ai.py` handles lobby registration.

### Unit Command Investigation

Extensive debugging was performed to isolate why unit commands fail:

#### What Works
- **Proxy ↔ F# client communication**: Events flow correctly. Callbacks (GetMapWidth, GetUnitDef, etc.) work.
- **Cheat commands**: `COMMAND_CHEATS_GIVE_ME_NEW_UNIT` (topic 79) successfully spawns units.
- **Engine_handleCommand return**: Always returns 0 for unit commands.

#### What Fails
- **COMMAND_UNIT_MOVE** (topic 42): Returns 0, unit doesn't move
- **COMMAND_UNIT_SELF_DESTROY** (topic 110): Returns 0, unit doesn't self-destruct
- **COMMAND_SEND_TEXT_MESSAGE** (topic 6): Returns 0, no chat message appears, no LOG entry
- All of the above fail even when called **directly from C code** inside the proxy (bypassing the F# client entirely)

#### Engine Code Path Analysis

Cloned the Recoil engine source (https://github.com/beyond-all-reason/spring) and traced the command execution path:

1. **`Engine_handleCommand`** (`SSkirmishAICallbackImpl.cpp:641`): Large switch on `commandTopic`.
   - Cheat commands (topics 1-5, 79) are handled with dedicated cases that call engine APIs directly.
   - `COMMAND_SEND_TEXT_MESSAGE` (topic 6) calls `clb->SendTextMsg()`.
   - Unit commands (topics 42+) fall through to the `default:` case.

2. **`default:` case** (`SSkirmishAICallbackImpl.cpp:1143`): Calls `newCommand()` to convert the C struct to an internal `Command` object, then calls `clb->GiveOrder(unitId, &c)`.

3. **`newCommand`** (`AISCommands.cpp:463`): Maps `COMMAND_UNIT_MOVE` → `CMD_MOVE` (10), copies position via `PushPos(cmd->toPos_posF3)`, sets timeout. Returns true on success.

4. **`GiveOrder`** (`AICallback.cpp:351`): Validates unitId, checks `allowOrders` flag, verifies unit exists and belongs to the AI's team. If all pass, sends the command over the network via `clientNet->Send(SendAICommand(...))`.

5. **Server receives** (`GameServer.cpp:1252`): Checks `noHelperAIs` (false), then broadcasts the packet.

6. **Client processes** (`NetCommands.cpp:750`): Unpacks the packet, constructs a `Command` object, calls `selectedUnitsHandler.AINetOrder(unitID, aiTeamID, playerID, c)`.

7. **`AINetOrder`** (`SelectedUnitsHandler.cpp:766`): Validates team ownership, then calls `unit->commandAI->GiveCommand(c, playerID, true, false)`.

8. **`GiveCommand`** (`CommandAI.cpp:821`): Calls `eventHandler.AllowCommand(...)` — any Lua gadget returning false blocks the command. Then calls `GiveCommandReal()`.

All return codes are 0 (success) at every step we can observe. No error logs, no warnings, no dropped command messages.

#### Hypotheses Tested

| # | Hypothesis | Test | Result |
|---|-----------|------|--------|
| 1 | Commands sent at frame 0 lost during placement phase | Delayed to frame 300 | Still no movement |
| 2 | `timeout = -1` causes immediate expiry | Changed to `INT_MAX` (2147483647) | Confirmed engine default is INT_MAX, but fix didn't help |
| 3 | Stack-local `float[3]` arrays for position have dangling pointers | Changed to static buffer pool | No change — engine copies synchronously in `PushPos` |
| 4 | F# client serialization issue | Sent commands directly from C code in proxy | Same failure |
| 5 | Wrong `skirmishAIId` or team mismatch | Engine validates in `GiveOrder()` — returns 0 | Team check passes |
| 6 | Lua `AllowCommand` gadgets blocking | Reviewed all gadgets with CMD.ANY | All return true for normal commands |
| 7 | `noHelperAIs` modoption blocking | Checked engine log | Value is 0 (allowed) |
| 8 | Struct layout mismatch between our headers and engine | Diffed AISCommands.h and SSkirmishAICallback.h | Files identical |
| 9 | `CALLING_CONV` ABI mismatch | Checked — x86_64 Linux uses System V ABI | No effect on 64-bit |

## Root Cause

**Unknown.** The command enters the engine, passes all validation, returns success (0), but has no observable effect on the unit. The most likely remaining explanation is:

1. The network send/receive path silently discards or malforms the command between `GiveOrder` (which returns 0 after sending) and `AINetOrder` (which receives it).
2. A Lua gadget in the AllowCommand chain returns false for AI-originated commands specifically (would need to instrument AllowCommand in the engine to confirm).
3. The `playerNum` value (`gu->myPlayerNum`) causes `player->CanControlTeam` to fail in the `AINetOrder` team check, but since `aiTeamID != MAX_TEAMS`, that branch isn't taken — however there may be another check.

## Solution

### Installation — Solved
- `scripts/install-ai.sh`: Full automated build + install
- `scripts/patch-chobby-ai.py`: Lobby registration
- Filesystem override for `aiSimpleName.lua` (not pool file patching)

### Unit Commands — Not Yet Solved
Further investigation needed. Recommended next steps:
1. **Test with BARb AI** in the same game to confirm the C callback `handleCommand` path works at all in this engine version
2. **Add engine-side instrumentation** by building a debug Recoil engine with logging in `AINetOrder` and `GiveCommand`
3. **Try `Engine_executeCommand`** API instead of `Engine_handleCommand` — it takes a `RawCommand` struct which is the internal engine format
4. **Ask the BAR/Recoil community** — this may be a known issue with the C AI interface in Recoil

## Hypotheses

### Most Likely
The `GiveOrder` → `SendAICommand` → network → `AINetOrder` → `GiveCommand` path has a subtle issue where the command is accepted at the API level but dropped during network processing. This could be:
- A timing issue where the command arrives before the unit is fully initialized in the simulation
- A singleplayer-specific issue where the network loopback doesn't process AI commands correctly
- A Recoil-specific regression in the AI command network path

### CircuitAI Comparison
CircuitAI (a working C++ AI) uses the Spring C++ wrapper `unit->MoveTo()` which internally calls `Engine_handleCommand` with the same parameters. However, CircuitAI links against the C++ wrapper library provided by the engine, which may use a different initialization or callback path than what the bare C AI Interface provides to our proxy.

## Lessons Learned

1. **Chobby AI registration** requires filesystem override of `aiSimpleName.lua`, not pool file modification
2. **DevMode.txt** must be present for custom AIs to appear
3. **AppImage extraction** works when FUSE is unavailable: `--appimage-extract` then run `squashfs-root/beyond-all-reason --no-sandbox`
4. **Frame 0 commands** may be lost during the commander placement phase — delay commands to a later frame
5. **`Engine_handleCommand` returning 0** does NOT guarantee the command was executed — it only means the API call was accepted
6. **The Spring/Recoil C AI callback API** is poorly documented and the command execution path involves network serialization even in singleplayer, making it difficult to debug
7. **Cheat commands bypass the normal command path** — they execute directly on the engine thread without going through the network/simulation layer, which is why `GIVE_ME_NEW_UNIT` works but `COMMAND_UNIT_MOVE` doesn't

## Files Changed

| File | Change | Status |
|------|--------|--------|
| `scripts/install-ai.sh` | Automated AI installation script | New, committed |
| `scripts/patch-chobby-ai.py` | Chobby lobby registration | New, committed |
| `tools/reference-ai/Program.fs` | AcceptFromProxy, delayed commands, logging | Modified, uncommitted |
| `clients/fsharp/src/Commands.fs` | Timeout changed from -1 to INT_MAX | Modified, uncommitted |
| `proxy/src/deserialize.c` | Static position buffer pool | Modified, uncommitted |
| `proxy/src/proxy.c` | Debug logging, direct command tests | Modified, uncommitted |
| `proxy/src/config.c` | Increased timeout, debug log level | Modified, uncommitted |

## Key Paths

- BAR data: `~/.local/state/Beyond All Reason/`
- Engine AI dir: `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/AI/Skirmish/`
- Chobby override: `~/.local/state/Beyond All Reason/LuaMenu/configs/gameConfig/byar/aiSimpleName.lua`
- Proxy socket: `/tmp/highbar.sock`
- BAR launch: `/home/developer/applications/squashfs-root/beyond-all-reason --no-sandbox`
