# Tasks: Fix Five Proxy Issues from FSBarV1 Trainer Session

**Input**: Design documents from `/home/developer/projects/HighBarV2/specs/029-fix-trainer-issues/`
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/, quickstart.md

**Tests**: Live-engine tests are REQUIRED by the spec (FR-016, FR-017, FR-018) and by the constitution principle IV ("Test at the Boundary"). Each user story phase includes both C round-trip tests and live-engine xUnit tests.

**Organization**: Tasks are grouped by issue (= user story) so each can be implemented, committed, and verified independently. Issues 5 / 2 / 3 are quick wins with known fixes; Issue 1 contains a diagnostic spike before the fix; Issue 4 is a verification-only closure that depends on Issues 1+2.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel with other [P] tasks in the same phase (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (US1–US5)
- File paths are absolute under `/home/developer/projects/HighBarV2/`

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Verify the build environment is sane and capture the regression baseline so each subsequent fix can be verified against an objectively-failing starting state.

- [X] T001 Verify build prerequisites by running `./tests/check-prerequisites.sh` from the repo root; confirm spring-headless, BAR data, and dotnet 10.0 are present. Abort and report missing prerequisites if any check fails.
- [X] T002 Capture the **regression baseline** by running `./tests/run-all.sh` and saving the result summary to `specs/029-fix-trainer-issues/baseline-pre-fix.txt`. This documents which tests pass today so post-fix runs can detect regressions in unrelated areas.
- [X] T003 [P] Confirm the proxy currently builds clean: `cmake -B build -DCMAKE_BUILD_TYPE=Release -S proxy && cmake --build build`. Capture any warnings.
- [X] T004 [P] Confirm the F# client currently builds clean: `cd clients/fsharp && dotnet build`. Capture any warnings.

**Checkpoint**: Build is green; regression baseline is captured.

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Add the shared infrastructure (a config flag and a mock-engine extension) that multiple user stories depend on. Each item below blocks at least one downstream user story phase.

- [X] T005 Add `bool verbose_commands;` field to the `ProxyConfig` struct in `proxy/include/highbar/config.h` with a doc comment stating "Default false. Per-command tracing in proxy.c is gated on this flag."
- [X] T006 Add `verbose_commands` parsing to `hb_config_load` in `proxy/src/config.c`: read the optional `"verbose_commands"` AIOptions key (default `false`), then overlay env var `HIGHBAR_VERBOSE_COMMANDS=1` (accept `1`, `true`, `yes` as truthy). Mirror the parsing pattern of any existing bool option in the same file.
- [X] T007 Add `Economy_getCurrent`, `Economy_getIncome`, `Economy_getUsage`, `Economy_getStorage` mock stubs to `proxy/tests/mock_engine.c` and `proxy/tests/mock_engine.h`. Provide per-resource setters: `mock_engine_set_economy_current(int resourceId, float value)` and analogous for income/usage/storage. Default-return 0.0f when no value has been set.
- [X] T008 Add a `mock_engine_get_shutdown_count()` and `mock_engine_get_last_shutdown_reason()` to `proxy/tests/mock_engine.{c,h}` so tests for Issue 3 (T029.GameOverShutdown) can assert the proxy emits the right Shutdown reason exactly once. Wire the mock socket to record any received `Highbar__ProxyMessage` whose `message_case` is `MESSAGE_SHUTDOWN`.

**Checkpoint**: Foundation ready — Issues 5, 2, 3 can now begin in parallel.

---

## Phase 3: User Story 5 — Debug log gate (Priority: P3) — quickest win

**Story**: Proxy command-dispatch debug logging is accurate and quiet (`spec.md § US5`)
**Goal**: Default verbosity stops bloating `engine.infolog`; the misleading `enum_move=42` constant disappears.
**Why first**: Lowest risk, smallest diff, no functional behavior change. Lands a clean win and reduces infolog noise that the diagnostic phase (Issue 1) will benefit from.

**Independent Test**: Run `./tests/run-all.sh --category persistent`; assert `engine.infolog` files contain zero `CMD_DETAIL` lines and are at least 50% smaller than the regression baseline.

### Implementation tasks for US5

- [X] T009 [US5] In `proxy/src/proxy.c` lines 207-245, wrap the entire per-command tracing block (`Executing N commands`, `Cmd N: case=`, `CMD_DETAIL ...`, `MOVE uid=...`, `Cmd N: rc=`) in `if (state->config.verbose_commands) { ... }`. Keep the per-command dispatch (the call to `hb_deserialize_and_execute`) OUTSIDE the conditional — only the logging is gated.
- [X] T010 [US5] Inside the wrapper added in T009, **delete** the `snprintf(any_dbg, ..., "CMD_DETAIL case=%d enum_move=%d", ...)` block at `proxy/src/proxy.c:218-223`. The `Cmd N: case=` line at 215 already provides the case number; the `enum_move=42` constant is the misleading value that this feature is fixing.
- [X] T011 [US5] In `proxy/src/deserialize.c` lines 120-123 (inside the `MOVE_UNIT` case), **delete** the orphan `fprintf(stderr, "[HB] MOVE uid=...")`. It bypasses the new verbosity gate and writes to stderr unconditionally. The proxy.c `MOVE uid=...` log line (now inside the verbose wrapper) covers the same data.
- [X] T012 [US5] Add a `verbose_commands` entry to `AIOptions.lua` (find the existing AIOptions file via `find /home/developer/projects/HighBarV2 -name "AIOptions.lua"` — typically under the proxy's data directory). Use the doc comment from `data-model.md § 4 § Documentation in AIOptions.lua`. Type: `bool`, default: `false`.

### Verification for US5

- [X] T013 [US5] Rebuild: `cmake --build build`. Confirm no warnings introduced. Then run `./tests/run-all.sh --category persistent`.
- [X] T014 [US5] Inspect at least one fresh `engine.infolog` from the run in T013: `find /tmp -name "engine.infolog" -newer /tmp/.t013-marker 2>/dev/null | head -1 | xargs ls -la`. Confirm the file is at least 50% smaller than the baseline-equivalent infolog and contains zero matches for `CMD_DETAIL` and zero matches for `\[HB\] MOVE uid`.
- [X] T015 [US5] Run with verbose mode forced on: `HIGHBAR_VERBOSE_COMMANDS=1 ./tests/run-all.sh --category persistent --filter T6_CommandCoverage`. Confirm the per-command lines reappear in `engine.infolog` and that the lines DO NOT contain `enum_move=` anywhere.

**Checkpoint**: Issue 5 fixed. Commit: `fix(proxy): gate per-command tracing behind verbose_commands config flag`

---

## Phase 4: User Story 2 — Economy callbacks return real values (Priority: P1)

**Story**: `getEconomyCurrent` / `getEconomyIncome` return real metal/energy (`spec.md § US2`)
**Goal**: Bot trainer's `peak_metal` / `peak_energy` telemetry becomes meaningful; bots can make economy-aware decisions.
**Independent Test**: Live-engine xUnit test asserts `getEconomyCurrent(0)` returns > 0 after 400 frames of income.

### C tests for US2

- [X] T016 [P] [US2] Add a C round-trip test in `proxy/tests/test_callbacks.c` named `test_economy_get_current_returns_value`. Set up the mock engine via `mock_engine_set_economy_current(0, 123.5f)`, dispatch a `CallbackRequest{ id: CALLBACK_ECONOMY_GET_CURRENT, params: [0] }`, assert `resp->success == true` and `resp->result.float_value == 123.5f`.
- [X] T017 [P] [US2] Add a C round-trip test `test_economy_get_current_invalid_id_returns_nan` in the same file. Dispatch with `params: [99]`, assert `success == true` and `isnan(resp->result.float_value)`.
- [X] T018 [P] [US2] Add three more C tests in `test_callbacks.c` for `CALLBACK_ECONOMY_GET_INCOME`, `CALLBACK_ECONOMY_GET_USAGE`, `CALLBACK_ECONOMY_GET_STORAGE`, each asserting the configured mock value flows through.

### Implementation tasks for US2

- [X] T019 [US2] In `proxy/src/callbacks.c`, insert four new switch cases before the `default:` at line 457, per `contracts/economy-callbacks.md § API Contract — C proxy`. For each case: read `int rid = get_int_param(request, 0, 0)`; if `rid < 0 || rid > 1` return `make_float_response(req_id, NAN, alloc)`; otherwise call the corresponding `callback->Economy_get*(skirmish_ai_id, rid)` and return `make_float_response(req_id, value, alloc)`. Guard each call with `if (!callback->Economy_getX) return make_error_response(...)`.
- [X] T020 [US2] In `clients/fsharp/src/Client.fs` near line 400-433, update the economy callback wrappers (`getEconomyCurrent`, `getEconomyIncome`, `getEconomyUsage`, `getEconomyStorage`) so a NaN `float_value` is surfaced as `Single.NaN` to the caller instead of being mapped to `0.0f` by the existing fallback. Add a doc comment explaining: "Returns Single.NaN for invalid resourceId; use Single.IsNaN to detect."

### Live test for US2

- [X] T021 [US2] Create `tests/persistent/fsharp/T029_EconomyCallbacks.fs` per `contracts/economy-callbacks.md § Test Contract`. Three tests: (a) `T029.1 EconomyCurrent metal returns nonzero after income accrues` (run 400 frames, then assert `getEconomyCurrent client.Stream 0 > 0.0f` AND same for energy id 1); (b) `T029.1b EconomyIncome metal/energy returns nonzero` (run 400 frames, assert `getEconomyIncome client.Stream 0 > 0.0f` and same for energy — covers FR-006); (c) `T029.2 EconomyCurrent invalid resourceId returns NaN` (call `getEconomyCurrent client.Stream 99`, assert `Single.IsNaN` of the result).

### Verification for US2

- [X] T022 [US2] Rebuild proxy and run C tests: `cmake --build build && cd build && ctest --output-on-failure -R economy && cd ..`. All four mock-engine tests must pass.
- [X] T023 [US2] Run the live test: `./tests/run-all.sh --category persistent --filter T029_EconomyCallbacks`. Both T029.1 and T029.2 must pass.

**Checkpoint**: Issue 2 fixed. Commit: `fix(proxy): wire ECONOMY_GET_* callbacks to engine Economy_get* and surface NaN for invalid id`

---

## Phase 5: User Story 3 — Shutdown event on GameOver (Priority: P2)

**Story**: Proxy notifies surviving AI clients when the game ends (`spec.md § US3`)
**Goal**: Bots terminate cleanly within ~300 frames of `Spring.GameOver` instead of running to their frame limit. Removes the FSBarV1 `botDeclaredVictory` workaround.
**Independent Test**: Live test runs a 1v1 headless match, kills the enemy commander, asserts the bot's frame loop terminates via `EngineDisconnectedException` within 300 frames.

### C tests for US3

- [X] T024 [P] [US3] Add a C unit test in `proxy/tests/test_proxy.c` (create the file if it doesn't exist; otherwise extend the existing `handleEvent` test file) named `test_handle_event_release_emits_shutdown`. Setup the proxy with the mock socket, call `handleEvent(0, EVENT_RELEASE, &(struct SReleaseEvent){ .reason = 1 })`, assert `mock_engine_get_shutdown_count() == 1` and `mock_engine_get_last_shutdown_reason() == HIGHBAR__SHUTDOWN_REASON__SHUTDOWN_REASON_GAME_OVER` and `g_state->conn.connected == false`.
- [X] T025 [P] [US3] Add a second C unit test `test_handle_event_release_does_not_double_emit` in the same file: invoke `handleEvent(0, EVENT_RELEASE, &(struct SReleaseEvent){ .reason = 1 })`, then invoke `release(0)` (the existing top-level export at proxy.c:315-342), assert `mock_engine_get_shutdown_count() == 1` (not 2). This protects against the existing `release()` path emitting a duplicate Shutdown.

### Implementation tasks for US3

- [X] T026 [US3] In `proxy/src/proxy.c` `handleEvent` (around lines 346-448), add an `EVENT_RELEASE` branch alongside the existing `EVENT_UPDATE`/`EVENT_SAVE`/`EVENT_LOAD` branches, per `contracts/shutdown-event.md § API Contract — proxy § New EVENT_RELEASE branch`. The branch: (a) casts `data` to `const struct SReleaseEvent *`, (b) calls `proxy_log(HB_LOG_INFO, "EVENT_RELEASE reason=N → emitting Shutdown(REASON)")` with the engine reason and the mapped proto reason — **required by Constitution VII (Explicit Over Implicit): "Connection lifecycle events (handshake, shutdown, reconnect) MUST be logged at INFO level"**, (c) maps `ev->reason` to `Highbar__ShutdownReason` per the table in `data-model.md § 3 § Mapping table`, (d) builds and sends `Highbar__ProxyMessage{ shutdown }` exactly as the existing `release()` path at lines 320-336, (e) calls `hb_conn_close(&g_state->conn)` and sets `g_state->conn.connected = false`, (f) returns 0.
- [X] T027 [US3] Verify the existing `release(int skirmishAIId)` export at `proxy/src/proxy.c` lines 315-342 is idempotent with T026: it must check `if (g_state->conn.connected)` before sending its own Shutdown, so a second call after EVENT_RELEASE has already closed the connection becomes a no-op. If the existing code does NOT have this guard, add it. Read the function carefully before editing.

### Live test for US3

- [X] T028 [US3] Create `tests/persistent/fsharp/T029_GameOverShutdown.fs` per `contracts/shutdown-event.md § Test Contract`. Test `T029.3 GameOver fires Shutdown to surviving AI`: setup a 1v1 headless game with cheats, kill the enemy commander via `Cheats.killUnit` (or equivalent — check `T6_CommandCoverage.fs` for the exact API used in this codebase), then call `engine.RunFrames(600, ...)` inside a `try ... with :? EngineDisconnectedException -> terminated <- true`. Assert `terminated == true` and `frameCount < 300` per SC-003.
- [X] T028b [US3] Add `T029.3b OwnTeamDie still terminates via socket close` to the same `T029_GameOverShutdown.fs` file. This satisfies FR-011 (regression protection): setup a 1v1 headless game, kill the bot's OWN commander (not the enemy's), call `engine.RunFrames(600, ...)` inside a `try ... with :? EngineDisconnectedException -> terminated <- true`. Assert `terminated == true`. This explicitly protects the existing engine-destroy path that the new EVENT_RELEASE branch in T026 must not regress. If the engine fires both EVENT_RELEASE and the destroy path, T027's idempotency guard ensures only one Shutdown is emitted.

### Verification for US3

- [X] T029 [US3] Rebuild and run C tests: `cmake --build build && cd build && ctest --output-on-failure -R event_release && cd ..`. Both T024 and T025 must pass.
- [X] T030 [US3] Run the live test: `./tests/run-all.sh --category persistent --filter T029_GameOverShutdown`. T029.3 must pass.

**Checkpoint**: Issue 3 fixed. Commit: `fix(proxy): emit Shutdown(GAME_OVER) on EVENT_RELEASE for surviving AIs`

---

## Phase 6: User Story 1 — Non-Move commands actually take effect (Priority: P1) 🎯 MVP

**Story**: Non-Move unit commands actually move/fight/attack the target unit (`spec.md § US1`)
**Goal**: Every command in the FR-002 in-scope set produces an observable in-engine effect; commands outside the in-scope set return non-zero `rc`.
**Why MVP**: This is the largest source of trainer iteration pain. The fix unblocks every future bot author.

⚠️ **Root cause is unknown at plan time**. Phase 6 begins with a diagnostic spike (T031–T036) that runs the regression baseline and tests five hypotheses. Only after the root cause is identified does the fix get committed (T037–T040).

**Independent Test**: `T029_NonMoveCommandEffect.fs` asserts that AttackCommand actually moves the attacker by >50 elmos within 600 frames. Today this test FAILS; after the fix it MUST PASS.

### Step 1 — Build the regression baseline

- [X] T031 [US1] Create `tests/persistent/fsharp/T029_NonMoveCommandEffect.fs` per `contracts/command-dispatch.md § Test Contract § Live engine test`. Six test methods: `T029.4 AttackCommand actually moves attacker toward target`, `T029.5 FightCommand actually moves unit to destination`, `T029.6 PatrolCommand actually moves unit toward patrol point`, `T029.7 GuardCommand actually moves guard near target`, `T029.8 RepairCommand moves unit toward repair target`, `T029.9 StopCommand halts a moving unit within 60 frames`. Each test polls `getUnitPos` (and `getUnitHealth` for Attack) and asserts observable state change. **Use the same `spawnMobile` / cheats helpers as `tests/persistent/fsharp/T6_CommandCoverage.fs`** — read that file for the exact patterns before writing.
- [X] T032 [US1] Run the new test: `./tests/run-all.sh --category persistent --filter T029_NonMoveCommandEffect`. **Confirm at least T029.4 (AttackCommand) FAILS** with a position-delta assertion failure. Save the failure output to `specs/029-fix-trainer-issues/diagnostic/baseline-failures.txt`. This is the regression baseline; no fix is committed until this test passes.

### Step 2 — Diagnostic hypotheses (sequential, one at a time)

Per `research.md § Issue 1 § Diagnostic plan`, test five hypotheses in order. Each hypothesis is a temporary patch + run + observe + revert cycle. STOP at the first hypothesis whose patch makes T029.4 pass.

- [X] T033 [US1] **Hypothesis 1 — `groupId` collision**: Edit `clients/fsharp/src/Commands.fs` `AttackCommand` builder so `a.GroupId <- -1` (today proto3 default 0 is implicit). Rebuild F# (`cd clients/fsharp && dotnet build && cd ../..`), re-run T029.4. If it now passes, root cause is `groupId=0`. Apply the fix to ALL in-scope command builders (Move, Fight, Attack, Patrol, Guard, Repair, ReclaimUnit, Stop, SelfDestruct, SetWantedMaxSpeed, Build, GiveMe, GiveMeNewUnit) in `Commands.fs` and SKIP T034–T036. Otherwise revert and proceed to T034.
- [X] T034 [US1] **Hypothesis 2 — `toId` arg**: In `proxy/src/deserialize.c` `case HIGHBAR__AICOMMAND__COMMAND_ATTACK` (around line 148), change the `handle_command(skirmish_ai_id, -1, COMMAND_ID_UNTRACKED, COMMAND_ATTACK, &s)` call to pass `c->unit_id` as the second arg: `handle_command(skirmish_ai_id, c->unit_id, COMMAND_ID_UNTRACKED, COMMAND_ATTACK, &s)`. Rebuild proxy (`cmake --build build`), re-run T029.4. If it now passes, root cause is the `toId` arg. Apply uniformly to all in-scope command cases in `deserialize.c` and SKIP T035–T036. Otherwise revert and proceed to T035.
- [X] T035 [US1] **Hypothesis 3 — cheats flag dropped**: Add a debug `proxy_log(HB_LOG_INFO, "cheats=...")` line in `proxy/src/proxy.c` `init` after the `Cheats_setEnabled` call, AND add another in `handleEvent` confirming cheats are still enabled at the time `EVENT_UPDATE` fires. Rebuild and run. Inspect `engine.infolog` to confirm cheats are still on when AttackCommand is dispatched. If cheats were silently disabled, root cause is identified — re-enable per-frame or once-per-init as needed. Otherwise revert the debug logging and proceed to T036.
- [X] T036 [US1] **Hypothesis 4 — struct layout drift**: Write a small diagnostic C program at `proxy/tests/test_struct_layout.c` per `quickstart.md § Step 5d`. It prints `sizeof(struct SAttackUnitCommand)` and `offsetof` for each field, then does the same for `SMoveUnitCommand`. Compile manually: `gcc -I proxy/include proxy/tests/test_struct_layout.c -o /tmp/struct_layout && /tmp/struct_layout`. If offsets diverge in unexpected ways (e.g., padding inserted in one but not the other) OR if the proxy's deserialize.c assumes a different layout than the header reports, root cause is struct layout drift. Document findings in `specs/029-fix-trainer-issues/diagnostic/struct-layout.txt`. Delete the test file after diagnosis. **Timebox**: if struct layout is also inconclusive, escalate to a temporary scenario-local Lua diagnostic gadget per `quickstart.md § Step 5e` and document the result in `specs/029-fix-trainer-issues/diagnostic/lua-gadget-findings.txt`. If the Lua gadget is ALSO inconclusive after one working day, escalate to a read-only Recoil engine source review (clone the engine repo to `/tmp/recoil-source` outside the working tree; do not commit anything from it) and document the finding in `specs/029-fix-trainer-issues/diagnostic/engine-source-review.md`. If even the engine source review is inconclusive OR confirms an engine-side bug, invoke the Edge Case escape hatch from `spec.md § Edge Cases § Issue 1 root cause is engine-side and unfixable in the proxy`: move the affected commands to FR-003's out-of-scope set, file `diagnostic/engine-side-root-cause.md`, and proceed to T037 to land the rc=-2 fallback rather than an effect fix.

### Step 3 — Apply the fix

- [X] T037 [US1] Implement the minimal fix identified by T033–T036. Most likely a 1-line change in `clients/fsharp/src/Commands.fs` (groupId = -1) OR a 12-call change in `proxy/src/deserialize.c` (toId arg). Apply the fix uniformly to all 12 in-scope command types per FR-002, NOT just AttackCommand. Save a brief root-cause writeup to `specs/029-fix-trainer-issues/diagnostic/root-cause.md`.
- [X] T038 [US1] In `proxy/src/deserialize.c`, locate the `default:` branch of the `command_case` switch and change its return value to a distinct sentinel `-2` (defined as `#define HB_DESERIALIZE_RC_UNSUPPORTED -2` in the file). Add a `fprintf(stderr, "[HB] unsupported command oneof case=%d\n", (int)cmd->command_case)` so out-of-scope commands are visible in stderr/infolog. This satisfies FR-003 (clarification Q2: switch-table check only).
- [X] T039 [US1] Re-run the full T029_NonMoveCommandEffect.fs suite: `./tests/run-all.sh --category persistent --filter T029_NonMoveCommandEffect`. **All six tests T029.4–T029.9 must pass.** If any still fail, return to T033 with the failing command type as the new probe.

### Step 4 — Close the test gap that allowed Issue 1 to ship undetected

- [X] T040 [US1] Extend `tests/persistent/fsharp/T6_CommandCoverage.fs` `T6.11 AttackCommand` (around line 269-290) so it asserts effect, not just engine survival. Replace `Assert.True(frames.Length >= 30, "Engine should survive AttackCommand")` with a `getUnitPos`-before-and-after delta assertion. Apply the same upgrade to any other smoke-test method in `T6_CommandCoverage.fs` that today only checks engine survival for an in-scope command type (review the file end-to-end). The test gap that allowed 017-fix-unit-commands to ship without catching Issue 1 must not be allowed to reopen.
- [X] T041 [US1] Add a live test `T029.10 unsupported command type returns nonzero rc` to `T029_NonMoveCommandEffect.fs` per `contracts/command-dispatch.md § Live test for unsupported-command rc=-2`. Issues a `DrawAddPointCommand` (not in FR-002) and asserts the proxy returns `-2`.

### Verification for US1

- [X] T042 [US1] Rebuild and run all relevant tests: `cmake --build build && ./tests/run-all.sh --category persistent --filter T029_NonMoveCommandEffect && ./tests/run-all.sh --category persistent --filter T6_CommandCoverage`. All tests must pass; specifically T029.4–T029.10 plus the upgraded T6.11.

**Checkpoint**: Issue 1 fixed. Commit: `fix(proxy): <root cause one-line per T037 writeup> so non-Move commands take effect`

---

## Phase 7: User Story 4 — GiveMe verification (Priority: P2)

**Story**: `GiveMeResource` cheat command actually changes team resources (`spec.md § US4`)
**Goal**: Either confirm Issue 4 was a phantom of Issue 2 (close as already-fixed), or open a residual investigation.
**Dependency**: Phases 4 (US2) and 6 (US1) must be complete.

**Independent Test**: A live probe issues `GiveMeResourceCommand 0 1000.0f` and asserts `getEconomyCurrent(0)` increases by ~1000 within 2 frames.

### Implementation tasks for US4

- [X] T043 [US4] Create `tests/persistent/fsharp/T029_GiveMeCheats.fs` with one test `T029.11 GiveMeResource increases metal storage by ~1000`. Setup: cheats enabled, run 100 frames so income stabilizes, capture `before = getEconomyCurrent client.Stream 0`, send `GiveMeResourceCommand 0 1000.0f`, run 2 frames, capture `after = getEconomyCurrent client.Stream 0`. Assert `after - before > 900.0f` (allow some slack for income or storage capping).
- [X] T044 [US4] Run `./tests/run-all.sh --category persistent --filter T029_GiveMeCheats`. If it passes, Issue 4 is closed-already-fixed by Issues 1+2. Document the closure in `specs/029-fix-trainer-issues/diagnostic/issue-4-closure.md` with a one-paragraph note. If it fails, open a residual investigation: dump the relevant `engine.infolog` lines for the GiveMe dispatch, check whether the engine's `Cheats_setEnabled` is still true at command time, and propose a follow-up issue.

**Checkpoint**: Issue 4 closed (or escalated). Commit: `test: verify GiveMeResource cheat works after Issues 1+2 fix` (or, if escalated, file follow-up issue and skip the commit).

---

## Phase 8: Polish & Cross-Cutting Concerns

**Purpose**: Final regression sweep, documentation, and cleanup.

- [X] T045 Run the full test matrix: `./tests/run-all.sh`. ALL categories must pass: unit, proxy, integration, persistent. Compare against `specs/029-fix-trainer-issues/baseline-pre-fix.txt` from T002. No new failures in tests unrelated to this feature. Save the new baseline to `specs/029-fix-trainer-issues/baseline-post-fix.txt`.
- [X] T046 [P] Verify SC-005: Pick one fresh `engine.infolog` from a run of `T6_CommandCoverage` (or any persistent test) at default verbosity. Confirm its size is at least 50% smaller than the corresponding pre-fix file. If a pre-fix file is not available, just confirm the file is < 30 MB for an 18000-frame match.
- [X] T047 [P] Verify SC-001 manually: Build a tiny one-off F# script (or extend `T029_NonMoveCommandEffect.fs`) that runs a 1v1 headless `Avalanche 3.4` match against NullAI using ONLY `AttackCommand` (no MoveCommand) on the bot's commander. Confirm victory in approximately 12 seconds wall clock. Document the result in `specs/029-fix-trainer-issues/sc-001-verification.txt`.
- [X] T048 [P] Update `specs/029-fix-trainer-issues/checklists/requirements.md`: re-confirm all checklist items still pass after implementation (no items have regressed). Mark any items that needed clarification during implementation in the Notes section.
- [X] T049 Send a brief writeup to the FSBarV1 trainer repo's mailbox: confirm the five issues are fixed, provide the HighBarV2 commit hashes, and recommend deleting the `botDeclaredVictory` workaround in `tactics.fsx`. Save the message to `Mailbox/2026-04-NN_to_FSBarV1_proxy_fixes_complete.md` (use today's date when implementing). Per SC-006.
- [X] T050 Final validation: re-read `specs/029-fix-trainer-issues/spec.md § Success Criteria` and confirm SC-001 through SC-007 are all satisfied. SC-007 in particular requires that all five issues either have a passing live-engine regression test OR a documented out-of-scope justification. List the test → SC mapping in `specs/029-fix-trainer-issues/sc-mapping.md`.

---

## Dependencies

```
Phase 1 (Setup, T001–T004)
    ↓
Phase 2 (Foundational, T005–T008)
    ↓
    ├─→ Phase 3 (US5 — debug log gate, T009–T015)        — depends on T005, T006
    ├─→ Phase 4 (US2 — economy callbacks, T016–T023)     — depends on T007
    ├─→ Phase 5 (US3 — GameOver shutdown, T024–T030)     — depends on T008
    └─→ Phase 6 (US1 — non-Move commands, T031–T042)     — depends on T002 (regression baseline)
        ↓
Phase 7 (US4 — GiveMe verification, T043–T044)            — depends on Phases 4 AND 6
    ↓
Phase 8 (Polish, T045–T050)                               — depends on all above
```

**Story dependencies**:

- **US5 (Phase 3)** is independent — can run alone, ship alone.
- **US2 (Phase 4)** is independent — can run alone, ship alone.
- **US3 (Phase 5)** is independent — can run alone, ship alone.
- **US1 (Phase 6)** is independent of US5/US2/US3 at the code level, but gated on T002 (regression baseline) and must complete before US4.
- **US4 (Phase 7)** depends on US2 AND US1 (per spec.md clarifications and Assumptions).

**MVP slice**: If only one user story can ship, ship US1 (Phase 6) — it is the largest source of bot author pain. US5 + US2 + US3 are smaller wins that can ship in any order. US4 is verification-only.

## Parallel execution opportunities

**Within Phase 2 (Foundational)**: T005, T006, T007, T008 are all independent (different files / different additions). Mark T005, T006 as sequential (same file `config.h`/`config.c` work) and T007, T008 as parallel with each other.

**Within Phase 3 (US5)**: T009 and T011 touch different files (`proxy.c` vs `deserialize.c`) and can be done in parallel. T010 must be sequential after T009 (same file). T012 (AIOptions.lua) is parallel with all of them.

**Within Phase 4 (US2)**: T016, T017, T018 are all in `test_callbacks.c` — sequential. T019 (callbacks.c) and T020 (Client.fs) are parallel. T021 (new test file) is parallel with both.

**Within Phase 5 (US3)**: T024 and T025 are sequential (same file). T026 (proxy.c) and T028 (new test file) are parallel after T024-T025.

**Within Phase 6 (US1)**: The diagnostic hypotheses T033–T036 are inherently sequential (each tests one hypothesis at a time). T037–T041 are sequential within the file but T040 (T6_CommandCoverage.fs upgrade) is parallel with T041 (T029.10 unsupported command test).

**Across phases 3, 4, 5**: After Phase 2 completes, Phases 3, 4, 5 can run in fully independent parallel branches. They touch different files (proxy.c log block, callbacks.c, proxy.c handleEvent — note that proxy.c is touched by both Phase 3 and Phase 5; sequence those two phases or coordinate the merges carefully).

## Implementation strategy

**Recommended order**: Phase 1 → Phase 2 → Phase 3 (US5, smallest, lowest risk) → Phase 4 (US2, well understood) → Phase 5 (US3, well understood) → Phase 6 (US1, longest, includes diagnostic) → Phase 7 (US4, verification only) → Phase 8 (polish).

**Each user story ships as one commit** for clean history:

1. `fix(proxy): gate per-command tracing behind verbose_commands config flag` — US5
2. `fix(proxy): wire ECONOMY_GET_* callbacks to engine Economy_get* and surface NaN for invalid id` — US2
3. `fix(proxy): emit Shutdown(GAME_OVER) on EVENT_RELEASE for surviving AIs` — US3
4. `fix(proxy): <root-cause one-liner> so non-Move commands take effect` — US1
5. `test: verify GiveMeResource cheat works after Issues 1+2 fix` — US4 (or no commit if escalated)

**Diagnostic discipline for Phase 6**: T031 (write the failing baseline test) MUST be done before T033 (first hypothesis). The baseline test is the only source of truth for "is the bug fixed yet?" — never apply a hypothesis fix without first confirming the test fails today. After each hypothesis (T033, T034, T035, T036), revert the temporary change before testing the next one — do NOT stack hypothesis patches.

**No deferred tests**: every user story phase ships with its live-engine test in the SAME commit as the fix. Per Constitution IV.

---

## Format validation

All tasks above conform to the required format `- [X] [TaskID] [P?] [Story?] Description with file path`. Story labels: T009–T015 are [US5], T016–T023 are [US2], T024–T030 (including T028b) are [US3], T031–T042 are [US1], T043–T044 are [US4]. Setup (T001–T004), Foundational (T005–T008), and Polish (T045–T050) tasks have no story label per the format rules. Total task count: **51 tasks** (50 sequential + T028b inserted into Phase 5).
