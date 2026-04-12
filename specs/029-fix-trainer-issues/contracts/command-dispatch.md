# Contract: Command Dispatch (In-Scope Set)

**Feature**: 029-fix-trainer-issues
**User Story**: US1 — Non-Move unit commands actually move/fight/attack the target unit
**Affected Requirements**: FR-001, FR-002, FR-003, FR-004, FR-016

## Surface

The proxy ↔ engine boundary for unit commands. The wire protocol (protobuf `AICommand` oneof) is unchanged. The proxy's dispatch behavior changes such that commands in the in-scope set actually produce in-engine effects, and commands outside the in-scope set return a non-zero result code.

## In-Scope Command Set (FR-002)

Per clarification Q1, exactly these 12 protobuf oneof cases are in-scope for this feature:

| Proto field | Engine topic | Engine struct | Effect |
|---|---|---|---|
| `move_unit` (42) | `COMMAND_UNIT_MOVE` | `SMoveUnitCommand` | Unit moves to position (already works — must not regress) |
| `fight` (44) | `COMMAND_UNIT_FIGHT` | `SFightUnitCommand` | Unit fights to position |
| `attack` (45) | `COMMAND_UNIT_ATTACK` | `SAttackUnitCommand` | Unit attacks target unit |
| `patrol` (43) | `COMMAND_UNIT_PATROL` | `SPatrolUnitCommand` | Unit patrols to point |
| `guard` (47) | `COMMAND_UNIT_GUARD` | `SGuardUnitCommand` | Unit guards another unit |
| `repair` (51 engine / 48 proto) | `COMMAND_UNIT_REPAIR` | `SRepairUnitCommand` | Unit repairs another |
| `reclaim_unit` (63 engine / 49 proto) | `COMMAND_UNIT_RECLAIM_UNIT` | `SReclaimUnitUnitCommand` | Unit reclaims target |
| `stop` (36) | `COMMAND_UNIT_STOP` | `SStopUnitCommand` | Unit halts |
| ~~`set_wanted_max_speed`~~ | — | — | **EXCLUDED per FR-002 update; engine marks `COMMAND_UNIT_SET_WANTED_MAX_SPEED = 56` as `// unused` and original struct removed. Returns `rc=-2` per FR-003.** |
| `self_destruct` (55 engine / 59 proto) | `COMMAND_UNIT_SELF_DESTROY` | `SSelfDestroyUnitCommand` | Unit dies |
| `build_unit` (35) | `COMMAND_UNIT_BUILD` | `SBuildUnitCommand` | Builder constructs unit |
| `give_me` (20) | `COMMAND_CHEATS_GIVE_ME_RESOURCE` | `SGiveMeResourceCheatCommand` | Team resource changes (cheats only) |
| `give_me_new_unit` (79) | `COMMAND_CHEATS_GIVE_ME_NEW_UNIT` | `SGiveMeNewUnitCheatCommand` | Unit spawns (cheats only) |

(12 entries: Move is the regression-protect baseline plus 11 active fixes. `SetWantedMaxSpeedCommand` was removed from the in-scope set per the C1 remediation — the engine marks it unused and the struct was removed.)

## Before / After

### Before (broken — Issues 1, 4)

```
Bot → AICommand{ attack: { unit_id: 25947, target_unit_id: 18203 } }
Proxy → deserialize.c switch on command_case → matches HIGHBAR__AICOMMAND__COMMAND_ATTACK
      → fills SAttackUnitCommand { unitId=25947, groupId=0, options=8, timeOut=MAX_INT, toAttackUnitId=18203 }
      → handle_command(skirmish_ai_id, -1, COMMAND_ID_UNTRACKED, COMMAND_ATTACK, &s)
Engine → returns rc=0  ← engine accepts
Engine → unit 25947 does NOT move, unit 18203 does NOT take damage
```

### After (fixed — Issue 1)

```
Bot → AICommand{ attack: { unit_id: 25947, target_unit_id: 18203 } }
Proxy → deserialize.c switch → ATTACK case
      → fills SAttackUnitCommand with the SAME fields PLUS the diagnostic-determined fix
        (e.g., groupId=-1 instead of 0, OR toId=unit_id instead of -1, OR a struct layout adjustment)
      → handle_command(...)
Engine → returns rc=0
Engine → unit 25947 moves toward 18203 within 600 frames; 18203 takes damage
```

**The fix is intentionally specified at the contract level as "whatever the diagnostic identifies" rather than a specific code change.** The plan defers the concrete patch until research confirms the root cause. See `research.md § Issue 1` for hypotheses and `quickstart.md` for the diagnostic procedure.

## API Contract — proxy `default:` branch (FR-003)

Today, every protobuf oneof case has an explicit `case` in `deserialize.c`'s switch, even for commands that the engine doesn't actually process. The `default:` branch handles unknown protobuf tags. Per clarification Q2, the `default:` branch must return a non-zero result code so the bot can detect "command type unsupported by this proxy."

### Existing default branch

```c
default:
    return -1;  // (or whatever it currently returns — verify)
```

### Post-fix contract

```c
default:
    fprintf(stderr, "[HB] unsupported command oneof case=%d (proxy switch table miss)\n",
            (int)cmd->command_case);
    return -2;  // distinct from -1 (null cmd) and 0 (engine accepted)
```

### Result code mapping for the bot

| Proxy `rc` | Meaning |
|---|---|
| `0` | Proxy switch matched AND engine returned 0. **Does NOT mean the engine produced an in-engine effect** — see clarification Q2. |
| `-1` | `cmd == NULL` or `handle_command == NULL` (programmer error) |
| `-2` | Proxy switch table miss (command type not in FR-002 in-scope set, or unrecognized oneof case) |
| Other engine return value | Engine returned non-zero — propagated as-is |

The bot's `client.Reset()` and command-issue paths can detect `-2` to know "the proxy doesn't dispatch this command type" vs `0` "the proxy forwarded it to the engine."

## API Contract — F# client (no change)

The F# client at `clients/fsharp/src/Commands.fs:18-117` already builds correct protobuf messages for the in-scope set. No client edits required for the dispatch fix itself.

If the diagnostic determines that the fix requires the F# client to set a field it currently leaves at proto3 default (e.g., `groupId = -1`), the client gets a small edit to do so. Otherwise the client is untouched.

## Test Contract

### C round-trip test (`proxy/tests/test_deserialize.c` — extend)

For each in-scope command type, assert that `hb_deserialize_and_execute` calls the mock engine's `Engine_handleCommand` with:

- Correct `commandTopic` (the engine `COMMAND_UNIT_*` enum value)
- Correct `commandId` (`-1` for untracked, per 017)
- Correct struct field values (especially `unitId`, `groupId`, `options`, plus the per-command-type payload)
- Whatever the post-diagnostic fix dictates for the `toId` arg

Mock engine assertions:

```c
TEST(test_deserialize_attack_dispatches_with_correct_fields) {
    Highbar__AICommand cmd = ...;
    cmd.command_case = HIGHBAR__AICOMMAND__COMMAND_ATTACK;
    cmd.attack = &(Highbar__AttackCommand) {
        .unit_id = 25947, .target_unit_id = 18203, .options = 8, .timeout = INT32_MAX,
    };
    int rc = hb_deserialize_and_execute(&cmd, /*ai_id=*/0, mock_engine_handle_command);
    ASSERT_EQ(rc, 0);

    MockCallRecord *r = mock_engine_get_last_call();
    ASSERT_EQ(r->commandTopic, COMMAND_UNIT_ATTACK);
    ASSERT_EQ(r->commandId, COMMAND_ID_UNTRACKED);
    SAttackUnitCommand *s = (SAttackUnitCommand *)r->commandData;
    ASSERT_EQ(s->unitId, 25947);
    ASSERT_EQ(s->toAttackUnitId, 18203);
    ASSERT_EQ(s->options, 8);
    // toId arg assertion depends on diagnostic outcome:
    // ASSERT_EQ(r->toId, -1);  // if root cause was groupId or struct
    // ASSERT_EQ(r->toId, 25947);  // if root cause was toId arg
}

TEST(test_deserialize_unknown_command_returns_negative) {
    Highbar__AICommand cmd = ...;
    cmd.command_case = (int)999;  // unrecognized
    int rc = hb_deserialize_and_execute(&cmd, 0, mock_engine_handle_command);
    ASSERT_LT(rc, 0);  // -2 specifically
    ASSERT_EQ(mock_engine_call_count(), 0);  // never reached engine
}
```

### Live engine test (`tests/persistent/fsharp/T029_NonMoveCommandEffect.fs`)

The single most important test for this feature. It MUST fail today (regression baseline) and MUST pass after the Issue 1 fix. Closes the test gap that allowed 017 to ship with broken Fight/Attack/Patrol.

```fsharp
[<Fact>]
[<Priority(1)>]
member _.``T029.4 AttackCommand actually moves attacker toward target``() =
    engine.ResetGameState()
    let attackerId = spawnMobile() |> Option.get
    let targetId = spawnEnemyMobile() |> Option.get  // enemy team, in cheats mode

    let posBefore = Callbacks.getUnitPos client.Stream attackerId
    engine.RunFrames(600, fun _ idx ->
        if idx = 0 then [ AttackCommand attackerId targetId ] else []
    ) |> ignore
    let posAfter = Callbacks.getUnitPos client.Stream attackerId
    let dist = Vector3.Distance(posBefore, posAfter)
    Assert.True(dist > 50.0f, $"attacker should have moved >50 elmos, moved {dist}")

[<Fact>]
[<Priority(2)>]
member _.``T029.5 FightCommand actually moves unit to destination``() = ...
[<Fact>]
member _.``T029.6 PatrolCommand actually moves unit toward patrol point``() = ...
[<Fact>]
member _.``T029.7 GuardCommand actually moves guard near target``() = ...
[<Fact>]
member _.``T029.8 RepairCommand moves unit toward repair target``() = ...
[<Fact>]
member _.``T029.9 StopCommand halts a moving unit within 60 frames``() = ...
```

Each scenario polls `getUnitPos` (and where applicable `getUnitHealth`) to verify observable state change. **No "engine survives the command" assertions** — that pattern (used by `T6.11`) is what allowed Issue 1 to ship undetected.

### Live test for unsupported-command rc=-2 (FR-003)

```fsharp
[<Fact>]
member _.``T029.10 unsupported command type returns nonzero rc``() =
    // Issue a command type NOT in FR-002 (e.g., DrawAddPoint)
    let drawCmd = AICommand()
    drawCmd.DrawAddPoint <- DrawAddPointCommand(Position = Vector3(100f, 0f, 100f))
    let rc = client.SendCommand drawCmd
    Assert.NotEqual(0, rc)  // proxy should return -2
```
