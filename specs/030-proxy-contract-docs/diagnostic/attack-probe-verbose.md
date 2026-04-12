# Diagnostic: AttackCommand Verbose Probe

**Feature**: 030-proxy-contract-docs
**Date**: 2026-04-12
**Status**: Inconclusive (engine crash) — source analysis provided instead

## Probe Attempt

Ran persistent test `T6.11 AttackCommand — attack target unit, no crash` with
`HIGHBAR_VERBOSE_COMMANDS=1` and `HIGHBAR_TEST_ENGINE` pointing to
`~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/spring-headless`.

The engine crashed during the test session before the AttackCommand was
dispatched. The only command captured in verbose mode was the
`GiveMeNewUnitCommand` spawn (`case=79`, `rc=0` at frame 1615). The engine
process died shortly after, and the test fixture threw
`ThrowIfEngineCrashed()`.

The crash is unrelated to AttackCommand — the persistent test harness runs a
long warm-up phase (~1600 frames) and the engine became unstable before
reaching the attack dispatch. This is a test infrastructure issue, not an
AttackCommand issue.

## Source Analysis (proxy side)

### AttackCommand is fully wired

Confirmed at `proxy/src/deserialize.c` lines 149-158:

```c
case HIGHBAR__AICOMMAND__COMMAND_ATTACK: {
    const Highbar__AttackCommand *c = cmd->attack;
    struct SAttackUnitCommand s;
    memset(&s, 0, sizeof(s));
    s.unitId = c->unit_id;
    s.groupId = c->group_id;
    s.options = (short)c->options;
    s.timeOut = c->timeout;
    s.toAttackUnitId = c->target_unit_id;
    return handle_command(skirmish_ai_id, -1, COMMAND_ID_UNTRACKED, COMMAND_ATTACK, &s);
}
```

The command maps to engine topic `COMMAND_ATTACK` via `handle_command()` with
`commandId = -1` (COMMAND_ID_UNTRACKED).

### F# client field values

From `clients/fsharp/src/Commands.fs` line 50-57, `AttackCommand` sends:

| Field | Value | Notes |
|-------|-------|-------|
| `unit_id` | caller-provided | The attacking unit |
| `target_unit_id` | caller-provided | The target to attack |
| `options` | `8` (`INTERNAL_ORDER`, `1 << 3`) | Marks as programmatic AI order |
| `timeout` | `2147483647` (INT32_MAX) | Never expires |
| `group_id` | `0` (proto3 default) | Not explicitly set by client |

### Struct mapping is correct

The `SAttackUnitCommand` struct fields are populated 1:1 from the protobuf
message. No field is dropped, no implicit conversion is applied beyond the
`(short)` cast on options and the direct integer assignment for all other
fields.

### Why the unit might be stationary

The proxy dispatches the command correctly. If the engine returns `rc=0`, the
command was accepted at the API level. But `rc=0` does **not** guarantee
in-game effect (see `contracts/command-dispatch.md` result code table).

Possible engine/game-logic explanations for stationary behavior:

1. **Target not in LOS**: The engine may silently ignore attack commands
   against units that the AI's team cannot see. FSBarV1's probe targeted a
   critter at ~2438 elmos and an enemy commander at ~4527 elmos — both
   potentially outside line-of-sight if global LOS is not enabled.

2. **Pathing not ready at frame 0**: The engine's pathfinding system may not
   be fully initialized at the frame the command is issued. The FSBarV1 probe
   issued the command early in the session; a brief delay (10-30 frames) may
   be needed.

3. **30-frame observation window too short**: FSBarV1 checked position after
   a short window. The unit's pathfinding may not have started producing
   visible movement yet, especially against a distant target.

4. **`groupId=0` interaction**: The `memset` zeros the struct, giving
   `groupId=0`. Some engine command handlers treat `groupId=0` differently
   from `groupId=-1` (ungrouped). This was identified as a hypothesis in the
   029 command-dispatch contract but was not confirmed as the root cause for
   AttackCommand specifically.

### Recommended re-probe

A definitive probe should:

1. **Enable `verbose_commands=true`** to capture `Cmd N: case=45` and
   `Cmd N: rc=<int>` in the infolog
2. **Enable global LOS** (`cheat|globallos` in the script) to rule out
   visibility as a factor
3. **Spawn attacker and target close together** (~200-500 elmos apart) to
   rule out pathing distance
4. **Delay the command** to frame 10-30 (not frame 0) to ensure pathing is
   ready
5. **Observe for 600 frames** (not 30) to give the unit time to pathfind and
   move
6. **Record position at frame 0, frame 300, and frame 600** to detect
   gradual movement

If `rc=0` and the unit still doesn't move over 600 frames with global LOS
and a nearby target, the issue is in the engine's command processing for
`COMMAND_ATTACK`, not in the proxy's dispatch.
