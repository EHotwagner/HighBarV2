# Feature Specification: Fix Five Proxy Issues from FSBarV1 Trainer Session

**Feature Branch**: `029-fix-trainer-issues`
**Created**: 2026-04-12
**Status**: Draft
**Input**: User description: "@Mailbox/2026-04-12_FSBarV1_trainer_session_findings.md fix that."

## Background

During a 22-iteration FSBarV1 trainer run on 2026-04-12 (commander-assassin bot vs NullAI / BARb-dev on `Avalanche 3.4`, headless engine `recoil_2025.06.19`, proxy `HighBar V2 - Native Proxy Bridge-0.1`), five proxy- or callback-level defects blocked or obscured iteration progress. None are engine bugs, none are in the F# client. The findings document is preserved at `Mailbox/2026-04-12_FSBarV1_trainer_session_findings.md`; this feature spec fixes those defects so the next bot author does not pay the same debugging cost.

## Clarifications

### Session 2026-04-12

- Q: Scope of US1 — fix every command in `commands.proto`, or only the FR-002 list? → A: Fix exactly the 12 commands in FR-002; every other `commands.proto` case returns non-zero `rc` until separately specified.
- Q: What does "non-zero rc" mean for FR-003 — switch-table check, propagate engine rc, or full effect verification? → A: Proxy-side switch-table check only (non-zero `rc` iff the proxy has no handler for that command oneof case).
- Q: How should the economy error sentinel for invalid `resourceId` be represented? → A: Drop the "no proto schema changes" assumption — proto changes are permitted; the specific mechanism (error field on the response, NaN sentinel, etc.) is a plan-phase decision.
- Q: Default verbosity for the `CMD_DETAIL` log line — remove, gate behind flag, or just relabel? → A: Gate behind an explicit debug verbosity flag (default OFF) and also relabel `enum_move` so the constant is unambiguous.
- Q: After emitting the GameOver Shutdown event, should the proxy close the socket? → A: Yes — proxy MUST close the socket cleanly immediately after emitting the Shutdown event.

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Non-Move unit commands actually move/fight/attack the target unit (Priority: P1)

A bot author writes an F# bot that issues `FightCommand`, `AttackCommand`, `PatrolCommand`, `GuardCommand`, `RepairCommand`, `ReclaimUnitCommand`, `StopCommand`, `SelfDestructCommand`, `SetWantedMaxSpeedCommand`, `BuildCommand`, or any other non-`MoveUnit` command via the protobuf protocol. When the proxy delivers that command to the engine, the targeted unit reacts in-engine the same way it would if the command had been issued from a Lua gadget or the GUI.

**Why this priority**: This is the largest source of trainer iteration pain. In the cited session, ~6 iterations (002–010) were burned debugging dead-end "AttackCommand sent, commander not moving" before the author switched to MoveCommand and confirmed only MoveCommand had any effect. Every bot author after this one will hit the same wall. Until this is fixed, the only useful command in the entire protocol is `MoveUnit`, which is far less than what the proto schema advertises.

**Independent Test**: A live-engine test that issues an `AttackCommand` against a known enemy unit, polls the attacker's position via `getUnitPos`, and asserts the position changes within N frames. Repeat for `Fight`, `Patrol`, `Guard`, `Repair`. Each can be tested without the others.

**Acceptance Scenarios**:

1. **Given** an active engine session with an own commander at position A and an enemy unit at position B in attack range, **When** the bot issues an `AttackCommand` targeting the enemy unit id, **Then** within 600 frames the commander's position changes (it moves toward or fires on the enemy) and the enemy unit's health decreases.
2. **Given** an own commander stationary, **When** the bot issues a `FightCommand` to a destination position, **Then** within 600 frames the commander's position changes toward the destination.
3. **Given** an own commander stationary, **When** the bot issues a `PatrolCommand` to a position, **Then** within 600 frames the commander's position changes toward the patrol point.
4. **Given** an own commander, **When** the bot issues a `StopCommand` while the commander is moving, **Then** the commander's position stops changing within 60 frames.
5. **Given** any command type for which the proxy cannot or does not implement engine dispatch, **When** the bot sends that command, **Then** the proxy returns a non-zero result code (or an explicit error event) so the bot can detect the unsupported command instead of seeing a silent `rc=0`.

---

### User Story 2 - Economy queries return real metal/energy values (Priority: P1)

A bot author calls `Callbacks.getEconomyCurrent(0)` for metal and `getEconomyCurrent(1)` for energy from F# during any frame of an active session. The proxy returns the team's actual current metal and energy storage as the engine sees them. The same applies to `getEconomyIncome`.

**Why this priority**: Without working economy queries, the trainer's `peak_metal` / `peak_energy` stall-detection is meaningless — every run reports `peak_metal: 0`, so every run looks stalled, and the playbook's stall-recovery checks cannot fire. This blocks any economy-aware bot strategy and silently corrupts trainer telemetry.

**Independent Test**: Start a live session, wait until the commander has accrued income for ~300 frames, call `getEconomyCurrent(0)` and `getEconomyCurrent(1)`, and assert both are strictly greater than zero. Cross-check against `Spring.GetTeamResources(myTeam, "metal" / "energy")` queried via a Lua gadget on the same team for parity.

**Acceptance Scenarios**:

1. **Given** an active session past frame 300 with a commander generating income, **When** the bot calls `getEconomyCurrent(0)` (metal), **Then** the returned value is strictly greater than 0 and matches the engine's view of the team's current metal storage within a small tolerance.
2. **Given** the same session, **When** the bot calls `getEconomyCurrent(1)` (energy), **Then** the returned value is strictly greater than 0 and matches the engine's view of the team's current energy storage.
3. **Given** the same session, **When** the bot calls `getEconomyIncome(0)` and `getEconomyIncome(1)`, **Then** both return strictly positive values reflecting the team's per-second income.
4. **Given** an invalid resource id (e.g. 99), **When** the bot calls `getEconomyCurrent(99)`, **Then** the proxy returns a sentinel or error result the bot can detect (not a silent 0).

---

### User Story 3 - Proxy notifies surviving AI clients when the game ends via GameOver (Priority: P2)

When BAR's `game_end.lua` calls `Spring.GameOver` because one allyteam has been wiped out, the proxy emits a `Shutdown` protobuf event (or equivalent terminal protocol event) to **every** connected AI client, not just the team that died. The bot's `Protocol.receiveFrame` loop observes the shutdown and exits cleanly.

**Why this priority**: P2 because there is a working bot-side workaround (FSBarV1 implemented `botDeclaredVictory` watching for the enemy commander DefId disappearing from `GameState.Enemies`). Without the fix, every NullAI match runs to frame limit and reports `outcome: "timeout"` even on wins, and any bot author has to re-implement the same workaround. With the fix, the workaround can be deleted.

**Independent Test**: Run a 1v1 headless match where the bot kills the enemy commander, then assert the bot's protocol stream receives a Shutdown event within N frames of `Spring.GameOver` firing in the engine infolog. Today the bot receives no terminal event and continues until its own frame limit.

**Acceptance Scenarios**:

1. **Given** a 1v1 headless session where the bot's team kills the only enemy commander and `Spring.GameOver` fires (engine logs `EndGame Graph disabled`), **When** the bot's next `receiveFrame` call returns, **Then** the bot observes a Shutdown / terminal protocol event with a reason indicating game-over, victory, or defeat — not another normal frame.
2. **Given** the same session, **When** the bot exits its frame loop in response to the shutdown event, **Then** the bot does not need to maintain its own commander-watch workaround to detect victory.
3. **Given** a session where the bot's OWN team is killed (engine destroys our skirmish AI), **Then** the existing socket-close behaviour continues to work as it does today — this fix must not regress that path.

---

### User Story 4 - `GiveMeResource` cheat command actually changes team resources (Priority: P2)

A bot calls `client.Reset()` (or directly issues `GiveMeResourceCommand`) with cheats enabled. After the call returns, a follow-up `getEconomyCurrent` query reflects the new resource amount.

**Why this priority**: P2 because (a) it is partially blocked behind US2 — once economy queries return real data we can re-test whether GiveMe was actually broken or the query was the only issue — and (b) it is needed by `client.Reset()` and trainer-style harnesses that drain and restore resources between iterations. The two issues are coupled but separable.

**Independent Test**: With cheats enabled, query `getEconomyCurrent(0)`, issue `GiveMeResourceCommand 0 1000.0f`, query again, and assert the second value is approximately 1000 higher than the first (modulo any income accrued in the gap).

**Acceptance Scenarios**:

1. **Given** an active session with cheats enabled and US2 fixed, **When** the bot issues `GiveMeResourceCommand 0 1000.0f`, **Then** the next `getEconomyCurrent(0)` call reports a value at least ~1000 higher than the prior reading.
2. **Given** the same session, **When** the bot issues `GiveMeResourceCommand 0 -1000000.0f` (the drain pattern used by `client.Reset()`), **Then** the next `getEconomyCurrent(0)` call reports a value clamped at 0 (or the drained-floor).
3. **Given** a `GiveMe` command type for which the proxy cannot dispatch, **When** the bot sends it, **Then** the proxy returns a non-zero result so the bot can detect the failure (consistent with US1 acceptance #5).

---

### User Story 5 - Proxy command-dispatch debug logging is accurate and quiet (Priority: P3)

When a bot author reads `engine.infolog` to debug a command-dispatch problem, every per-command log line in the proxy reflects what the proxy actually did with that command. Misleading constants are removed or labelled. The high-volume per-command tracing is gated behind a verbosity flag so a normal session does not produce tens of MB of `CMD_DETAIL` / `send_frame` noise.

**Why this priority**: P3 because the misleading line did not block iteration progress directly, but it sent the bot author down a rabbit hole (it looked like every command was being translated to `CMD_MOVE`) and the per-command volume bloats infolog files (60–70 MB per 18000-frame run is reported in the findings).

**Independent Test**: Run a session at default verbosity, count the number of `CMD_DETAIL` log lines in `engine.infolog`, and assert it is below a chosen threshold (e.g. 0 at default, all of them at debug verbosity).

**Acceptance Scenarios**:

1. **Given** a session run at the default proxy verbosity, **When** the author inspects `engine.infolog`, **Then** there are no per-command `CMD_DETAIL` lines (or the line is omitted entirely).
2. **Given** a session run at an explicit debug verbosity, **When** the author inspects `engine.infolog`, **Then** the `CMD_DETAIL` line either no longer prints `enum_move=42` for every command, or labels that field clearly (e.g. `CMD_MOVE_CONST=42`) so it is obviously a reference constant and not the per-command dispatch target.
3. **Given** any verbosity, **When** the author inspects `engine.infolog`, **Then** the line that is printed matches what the proxy actually executed for that specific command (case number accurate, no stale constants from a different command type).

---

### Edge Cases

- **Unsupported command types**: If a command in `commands.proto` cannot be dispatched (because the underlying engine command id is not supported, or because the proxy maintainer has not yet wired it up), the proxy must return a non-zero result so the bot can distinguish "command unsupported" from "command dispatched and engine accepted it." Today both produce `rc=0`.
- **Economy query before frame 0**: If `getEconomyCurrent` is called before the first simulation frame (during handshake / unit-defs batch), it should return either zero (legitimate engine state) or a clearly distinguishable not-yet-ready response. A 0 here is acceptable and is not what US2 fixes.
- **GameOver with multiple surviving allyteams**: If three or more allyteams exist and one dies, surviving teams should NOT receive a Shutdown event for that partial elimination — only when the engine's true `gameOver` state transitions. (This matches engine semantics; the fix should hook the same signal `game_end.lua` uses, not infer game-over from individual team death.)
- **Concurrent commands in a single frame**: The 22-iteration session showed up to two commands per frame (`Executing 2 commands at frame N`). All accepted command types must dispatch reliably even when batched in a single `FrameResponse`.
- **Cheat-mode dependence**: `GiveMe` is only meaningful with cheats enabled. The proxy already enables cheats during init; the bot author should not have to re-enable them. If cheats are somehow disabled, `GiveMe` commands must return a non-zero result, not silently no-op.
- **Issue 1 root cause is engine-side and unfixable in the proxy**: The diagnostic spike in the implementation phase tests five hypotheses for why non-Move commands no-op. If all five are ruled out and a sixth investigation (engine source review) determines the root cause is a Recoil engine bug or limitation that cannot be fixed in the proxy without violating Constitution I (Zero Engine Modifications), the affected command(s) move to FR-003's out-of-scope set: their proxy switch case is removed and they return `rc=-2`. The corresponding live test in `T029_NonMoveCommandEffect.fs` is downgraded from "asserts observable effect" to "asserts the proxy returns `-2` and logs the unsupported case." A documented out-of-scope justification per SC-007 is filed in `specs/029-fix-trainer-issues/diagnostic/engine-side-root-cause.md` naming the affected commands and the engine code reference.

## Requirements *(mandatory)*

### Functional Requirements

#### Command Dispatch (US1, US4)

- **FR-001**: The "in-scope command set" for this feature is exactly the 12 commands listed in FR-002. When the bot sends one of those commands via `FrameResponse.commands`, the proxy MUST dispatch it to the engine such that the engine applies the same effect as it would for an equivalent command issued from a Lua gadget or the in-game UI. Every other command type in `proto/highbar/commands.proto` is explicitly out of scope for this feature and MUST follow FR-003.
- **FR-002**: The in-scope command set is: `MoveUnitCommand` (already working — must not regress), `FightCommand`, `AttackCommand`, `PatrolCommand`, `GuardCommand`, `RepairCommand`, `ReclaimUnitCommand`, `StopCommand`, `SelfDestructCommand`, `BuildCommand`, `GiveMeCommand`, and `GiveMeNewUnitCommand` (12 commands total). The proxy MUST cause the corresponding in-engine effect on the named unit for each of these. **`SetWantedMaxSpeedCommand` is explicitly excluded** because the engine marks `COMMAND_UNIT_SET_WANTED_MAX_SPEED = 56` as `// unused` (`AISCommands.h:95`) and the original engine struct was removed (only a stub remains in `engine_types.h:161`); fixing it would require engine modifications and violate Constitution I. It falls under FR-003 (returns non-zero `rc`).
- **FR-003**: For any command type NOT in the FR-002 in-scope set (whether intentionally deferred or simply not yet wired), the proxy MUST return a non-zero result code from its per-command dispatch path so the bot can distinguish "command type unsupported by this proxy" from "engine accepted." The check is purely proxy-side: if the command's protobuf oneof case is not present in the proxy's dispatch switch table, return non-zero. The proxy MUST NOT attempt to verify in-engine effect — `rc=0` from a successful switch-table dispatch only means "the proxy forwarded it to the engine," not "the engine produced an observable effect." Bots that need stronger guarantees must observe state via callbacks (e.g. `getUnitPos`).
- **FR-004**: A bot's `MoveCommand` flow MUST continue to work exactly as it does today (this is the only path currently known to work and must not regress).

#### Economy Callbacks (US2, US4)

- **FR-005**: `getEconomyCurrent(resourceId)` MUST return the bot team's current storage of the requested resource as the engine sees it, for both metal (`resourceId=0`) and energy (`resourceId=1`).
- **FR-006**: `getEconomyIncome(resourceId)` MUST return the bot team's per-second income of the requested resource for both metal and energy.
- **FR-007**: Both economy callbacks MUST agree with the value a Lua gadget on the same team would observe via `Spring.GetTeamResources`, within ±1.0 metal/energy units (or ±0.5% of the value, whichever is larger). The tolerance accommodates the one-frame delay between when the Lua gadget reads team state and when the callback marshals the response across the IPC boundary.
- **FR-008**: For an unknown `resourceId` (anything other than 0 or 1, or any future engine-supported resource), the callbacks MUST return a clearly-error response, not a silent 0.

#### Game Over Notification (US3)

- **FR-009**: When the engine reaches `Spring.GameOver` (the same condition observable in `engine.infolog` as `EndGame Graph disabled`), the proxy MUST emit a terminal protocol event to every connected AI client, including teams that were not themselves destroyed.
- **FR-010**: The terminal protocol event MUST carry a reason that lets the bot tell game-over from a generic disconnect (e.g. `gameover`, or a flag indicating victory/defeat for the receiving team).
- **FR-011**: For a team whose AI was destroyed by the engine itself (the existing `[EOH::DestroySkirmishAI(id=N)]` path), the existing socket-close-driven shutdown MUST continue to work and MUST NOT be regressed by FR-009.
- **FR-012**: After emitting the terminal event on engine `GameOver`, the proxy MUST close the connection cleanly. The bot's next `receiveFrame` call MUST observe the closed socket via the existing `EngineDisconnectedException` path (the same path used today when the engine destroys the bot's own AI), so the frame loop terminates without further frames.

#### Debug Logging (US5)

- **FR-013**: The per-command `CMD_DETAIL` log line MUST be gated behind an explicit debug verbosity flag whose default is OFF. When gated off (the default), the proxy MUST NOT emit any per-command tracing line at all.
- **FR-014**: When the debug verbosity flag is ON, the per-command tracing line MUST NOT print the misleading `enum_move=42` constant from the current implementation. The reference constant MUST either be removed from the line or relabelled to a name that cannot be confused with the per-command dispatch target (e.g. `CMD_MOVE_CONST=42`, or simply omit it).
- **FR-015**: Whatever per-command log line the proxy does emit (only at debug verbosity per FR-013) MUST accurately reflect the command actually dispatched: correct case number, no stale shared variables carried over from a previous command type.

#### Test Coverage

- **FR-016**: A live-engine test (in the same harness as `tests/run-all.sh --category integration` or `--category persistent`) MUST exist that asserts a non-Move command (e.g. `AttackCommand` or `FightCommand`) produces an observable in-engine effect on the targeted unit. This test MUST fail today and pass after this feature is implemented.
- **FR-017**: A live-engine test MUST exist that asserts `getEconomyCurrent` returns a non-zero value after the commander has accrued income for at least 300 frames.
- **FR-018**: A live-engine test MUST exist that asserts the proxy emits a terminal protocol event to a surviving AI when the enemy team is wiped out and `Spring.GameOver` fires. This test MUST fail today and pass after this feature is implemented.

### Key Entities *(include if feature involves data)*

- **AICommand (proto)**: A protobuf oneof spanning all command types the bot can send to the proxy. Today only the `MoveUnit` case has a verified end-to-end effect; this feature broadens that to the rest of the documented set.
- **CallbackResponse (proto)**: A protobuf oneof spanning all callback responses the proxy returns to the bot. This feature adds (or fixes) the `EconomyCurrent` and `EconomyIncome` cases so they return real engine state.
- **Shutdown / terminal protocol event**: The protobuf message the proxy sends when the bot's session must end. This feature broadens the conditions under which it is emitted (currently only on the proxy's `release()` path; after this feature, also on engine-side `Spring.GameOver`).
- **Engine GameOver signal**: The engine-side condition observable today as `Spring.GameOver` firing and `EndGame Graph disabled` appearing in `engine.infolog`. This feature wires it to the proxy's terminal-event emission path.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: A bot that issues only `AttackCommand` (no MoveCommand) against an enemy commander wins a 1v1 headless `Avalanche 3.4` match against NullAI within the same wall-clock budget the move-only bot took on 2026-04-12 (~12 seconds at GameSpeed=100).
- **SC-002**: After 400 simulation frames in any HighBarV2 live test session, `getEconomyCurrent(0)` and `getEconomyCurrent(1)` both return strictly positive values that increase monotonically over a 100-frame window when the team is generating income. (This is the HighBarV2-internal version of the FSBarV1 trainer's `peak_metal` / `peak_energy` telemetry — verifying it here means the trainer's stall-detection will also work once the fix lands. Confirmation in the FSBarV1 trainer is captured by the followup mailbox writeup in T049.)
- **SC-003**: When the bot kills the enemy commander in a 1v1 headless match, the bot's frame loop exits within 300 frames of `Spring.GameOver` firing — without any bot-side commander-watch workaround.
- **SC-004**: A bot author who searches `engine.infolog` after a failed command sees no log line that misleads them into thinking a non-Move command was translated to `CMD_MOVE`.
- **SC-005**: The total size of `engine.infolog` for a clean 18000-frame match at default verbosity is less than half its current size (target: less than 30 MB compared to the cited 60–70 MB).
- **SC-006**: Future bot authors do not need the FSBarV1 `botDeclaredVictory` workaround in `tactics.fsx` — the trainer's tactics module can rely on the proxy's terminal event as the canonical victory signal.
- **SC-007**: All five issues from `Mailbox/2026-04-12_FSBarV1_trainer_session_findings.md` either (a) have a passing live-engine regression test in `tests/run-all.sh`, or (b) have a documented out-of-scope justification recorded in this feature's plan.

## Assumptions

- **Headless engine path is sufficient for verification**: This environment has a full BAR + spring-headless installation, so live-engine tests via `tests/run-all.sh --category integration` or `--category persistent` are the authoritative validation. No mock-only fix is acceptable for any of the five issues.
- **The five issues are independent of each other at the code level**: Issues 1, 2, 3, 4, and 5 touch different proxy code paths (command dispatch, callback dispatch, event emission, debug logging) and can be fixed and tested independently. The plan phase may reveal coupling — in particular Issue 4 (GiveMe) cannot be cleanly verified until Issue 2 (economy queries) is fixed — but the fixes themselves are separable.
- **The `HighBar V2 - Native Proxy Bridge-0.1` proxy version cited in the findings corresponds to current `master`**: The findings were collected against the same proxy that lives in `proxy/` on the master branch as of 2026-04-12. Subsequent work happens on top of that master.
- **Proto schema changes are permitted where needed**: The required commands (`Attack`, `Fight`, `Patrol`, `Guard`, `Repair`, etc.) and callbacks (`EconomyCurrent`, `EconomyIncome`) are already declared in `proto/highbar/commands.proto` and `proto/highbar/callbacks.proto`, so the bulk of the fix is in the C proxy's dispatch and callback handlers and (for Issue 3) the proxy's event-emission path. However, this feature MAY introduce proto schema additions where needed — for example, an explicit error/status field on economy responses (US2 acceptance #4), or a richer reason on the terminal protocol event (US3 / FR-010). The plan phase decides exactly which schema additions are warranted.
- **`Spring.GameOver` is hookable from a C SSkirmishAI plugin**: There is some engine-exposed signal — either an engine event topic delivered to `handleEvent`, or a polled value via the existing callback API — that the proxy can use to detect game-over without needing engine-side patches. The plan phase will identify the exact mechanism; this spec assumes one exists.
- **The trainer FSBarV1 client `0.1.4` is a faithful exerciser of the protocol**: When the findings say "the bot sent an AttackCommand and nothing happened," that observation trusts the F# client's protobuf encoding is correct. The findings document explicitly verified this against `Generated/highbar/commands.proto.gen.fs` (`Attack = (45, "attack")`), so the bug is on the proxy side.
- **`Critter` units and other neutral wildlife are not relevant**: The findings rule these out as a non-issue. This feature does not need to address them.
