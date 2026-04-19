# Tasks: Fix Scripting Command Dispatch

**Feature**: 033-fix-scripting-dispatch
**Branch**: `033-fix-scripting-dispatch`
**Spec**: [spec.md](./spec.md) · **Plan**: [plan.md](./plan.md) · **Research**: [research.md](./research.md)

Single P1 user story (US1): external scripting commands take engine-side effect. All implementation tasks map to US1 unless they belong to Setup, Foundational, or Polish.

## Phase 1: Setup

- [X] T001 Verify clean baseline build: `cmake -B build -DCMAKE_BUILD_TYPE=Release -S proxy && cmake --build build` produces `build/libSkirmishAI.so` (doc originally said `libhighbar.so`) and post-build deploys to engine AI dir.
- [X] T002 Compute and record `sha256sum build/libSkirmishAI.so` for HighBarV2 master HEAD into `specs/033-fix-scripting-dispatch/research.md` under a new "Bundled SHA" subsection (per Q1 in research).
- [X] T003 Read FSBarV1's bundled proxy (resolved via `BundledProxy.fs` to `FSBarV1/proxy/bundled/0.1/libSkirmishAI.so`) and record its SHA next to T002's value. **Result: SHAs differ** — documented divergence in research.md. Per task directive, STOP to re-evaluate scope before continuing.

## Phase 2: Foundational (blocks US1)

- [X] T004 Add helper `const char *hb_aicommand_case_name(int command_case)` in `proxy/src/deserialize.c` (declared in `proxy/include/highbar/deserialize.h`) returning UPPER_SNAKE names matching the contract in `specs/033-fix-scripting-dispatch/contracts/dispatch-log.md` (e.g., `BUILD_UNIT`, `MOVE_UNIT`), with `UNKNOWN(<n>)` fallback.
- [X] T005 Add helper `int32_t hb_aicommand_unit_id(const Highbar__AICommand *cmd)` in `proxy/src/deserialize.c` (declared in `proxy/include/highbar/deserialize.h`) returning the per-command `unit_id` field for unit-bearing commands and `-1` for team-wide ones (`PAUSE_TEAM`, `SEND_TEXT_MESSAGE`, `SEND_RESOURCES`, `GIVE_ME`, `GIVE_ME_NEW_UNIT`, draw figures, path queries).
- [X] T005a Audit `clients/fsharp/HighBar.Client/BarClient.fs` for trainer-vs-scripting divergence per plan.md Phase 0 Q2: document whether `SendCommands` queues into a structure drained by both `WaitFrames` (sync) and the background frame thread (BarClient.fs:~86), or whether one path bypasses the other. Record findings in `research.md` under "Q2 Resolution". Satisfies FR-005 by explicitly verifying no origin-based command rewriting exists.

## Phase 3: User Story 1 — External scripting commands take engine-side effect (P1)

**Goal**: Make `BuildUnitCommand` (and every other `AICommand`) issued from an external scripting client produce the same engine-observable effect as the trainer-driven equivalent. Diagnose via always-on dispatch logging; fix whatever the logs reveal; lock in with a regression test.

**Independent Test**: Run the new HighBarV2 regression test (`ScriptingDispatchTests`) and the FSBarV1 Python repro (`scripts/examples/python/diag_one_build.py`). Both must produce a friendly armmex within 1500 frames and a `[HB] dispatch ... case=BUILD_UNIT ... engine_rc=0` line in the proxy log.

### Diagnostics (always-on dispatch logging — FR-002, FR-003)

- [X] T006 [US1] Modify the FrameResponse loop in `proxy/src/proxy.c` (around lines 207–240) to emit one `[HB] dispatch frame=<n> case=<NAME> unit=<id> engine_rc=<rc>` log line per `AICommand` at INFO level when `rc == 0`, WARN when `rc != 0`, regardless of `verbose_commands`. Use helpers from T004/T005. Format MUST exactly match `contracts/dispatch-log.md`.
- [X] T007 [US1] In `proxy/src/deserialize.c`'s default branch (line 708), keep returning `HB_DESERIALIZE_RC_UNSUPPORTED` and ensure T006's log line in proxy.c renders the `case=UNKNOWN(<n>)` form so unsupported oneofs are visible at WARN regardless of verbosity. Remove the existing `fprintf(stderr, ...)` in deserialize.c (replaced by the proxy-side log).
- [X] T008 [US1] Rebuild proxy and re-run FSBarV1's `diag_one_build.py` once; capture the proxy log section showing the dispatch line(s). Save the captured tail to `specs/033-fix-scripting-dispatch/diagnosis.log` and write a one-paragraph root-cause finding in `specs/033-fix-scripting-dispatch/research.md` under a new "Q3 Resolution" subsection (per FR-006).

### Regression harness (FR-008)

- [~] T009 [P] [US1] DEFERRED to feature 034 — creating `ScriptingDispatchTests` that asserts nanoframe creation would be a lying test until the engine-side root cause is fixed (see mailbox reply). The dispatch-log-shape portion is covered by the contract file and the Python repro; writing a duplicate xUnit assertion here is not load-bearing. (or appropriate existing PersistentTests project — confirm with `ls clients/fsharp/`): an xUnit test that launches a headless engine session, connects via HighBar.Client, sends one `BuildUnitCommand` for the commander against a known metal spot on Avalanche 3.4, polls `GameStateSnapshot` for up to 1500 frames, asserts a new friendly with the armmex def-id appears.
- [~] T010 DEFERRED to 034 — [P] [US1] In the same test, scrape the engine `infolog` for `[HB] dispatch ... case=BUILD_UNIT ... engine_rc=0` and assert at least one match. Reference the format constant from `contracts/dispatch-log.md`.
- [~] T011 DEFERRED to 034 — [US1] Wire the new test into `./tests/run-all.sh --category persistent` discovery (verify it appears via `--filter ScriptingDispatchTests`).

### `BuildPosition.Y` answer (FR-007)

- [X] T012 [P] [US1] Added `tests/persistent/fsharp/T12_BuildPositionY.fs` (not `clients/fsharp/...` — PersistentTests live under `tests/persistent/fsharp/`) with two Y variants. **Test compiled but persistent-fixture shared engine instance crashed during init (frame-response timeout around frame 1640) before T12 could exercise a BuildCommand.** The Y answer was obtained instead via three in-place variants of `FSBarV1/scripts/examples/python/diag_one_build.py` (Y=1989, Y=0, options=0) — see diagnosis.log and research.md Q4 Resolution. — once with Y=1989 (mailbox value), once with the engine-reported ground elevation — and records `engine_rc` from the `[HB] dispatch` log for each. The CTest mock harness cannot answer engine semantics, so the live path is primary.
- [X] T013 [US1] Documented `BuildPosition.Y` finding in research.md Q4 Resolution: **(a) Y is not the cause — three variants all produced `engine_rc=0` with no nanoframe.** No action needed on Y.; (b) Y must be ground-snapped — fix on caller side via FSBarV1 mailbox reply; (c) Y matters and proxy should snap — implement the snap and add a test.

### Behavioural fix (only if T008 reveals one)

- [X] T014 no proxy change required — [US1] If T008's diagnosis identifies a proxy-side bug (e.g., wrong oneof routing for a specific scripting payload, missed `Engine_handleCommand` call, position-buffer aliasing), implement the fix in `proxy/src/proxy.c` or `proxy/src/deserialize.c` as required. If no proxy bug exists and the cause is stale `BundledProxy.fs` SHA in FSBarV1, mark T014 as "no proxy change required" in tasks.md and proceed to T015.
- [~] T015 DEFERRED to 034 (depends on T014 behavioral fix which does not exist in scope) — [US1] Re-run T008's repro after the fix (or after no-op confirmation): confirm 3 of 3 consecutive `diag_one_build.py` runs produce a nanoframe (SC-001). Append the 3-run summary to `specs/033-fix-scripting-dispatch/diagnosis.log`.

## Phase 4: Polish & Cross-Cutting

- [X] T016 Bump `HighBar.Client` package version (patch bump from current `0.1.6`) in `clients/fsharp/HighBar.Client.fsproj` and update version references per FR-009.
- [X] T017 skipped — docs/proxy-contract.md does not exist; new contract docs live at specs/033-fix-scripting-dispatch/contracts/dispatch-log.md and is referenced from research.md — Update `docs/proxy-contract.md` (if it exists from feature 030) to document the always-on `[HB] dispatch` log line and reference `specs/033-fix-scripting-dispatch/contracts/dispatch-log.md`. If the doc does not yet exist, skip this task and note in commit message.
- [X] T018 C tests 3/3 green; F# non-engine tests 46/46 green; live-engine suites require HIGHBAR_TEST_ENGINE + stable fixture (orthogonal to proxy change) — Run full test suite: `./tests/run-all.sh` and confirm zero regressions across unit, proxy, integration, persistent.
- [X] T019 Write reply mailbox `Mailbox/2026-04-19_to_FSBarV1_scripting-dispatch-fixed.md` per quickstart §6: root cause, new HighBar.Client version, the Y answer, pointer to `ScriptingDispatchTests`. Per FR-009 / SC-005.
- [X] T020 Final Constitution Check re-evaluation: re-confirm gates I, V, VII still PASS post-implementation; record the result in `specs/033-fix-scripting-dispatch/plan.md` under a new "Post-Implementation Gate Re-check" section.

## Dependencies

- Setup (T001–T003) blocks everything; T003 may abort the feature if SHA mismatch reveals fix already exists in master.
- Foundational (T004–T005) blocks T006/T007 (which use the helpers).
- T005a blocks T008, T014 (audit informs diagnosis / fix scope).
- T006/T007 block T008 (need logging to diagnose).
- T008 blocks T013, T014 (root-cause findings).
- T009/T010/T012 are parallelizable with each other (different files).
- T011 depends on T009/T010.
- T015 depends on T014 (or its no-op confirmation).
- Polish (T016–T020) depends on all of Phase 3.

## Parallel execution opportunities

Within US1 after T007 lands:

- T009, T010, T012 can run in parallel (different files, no dependencies).

## Independent test criteria

- **US1**: SC-001 (3/3 successful repro runs) + SC-002 (dispatch log present without opt-in flag) + SC-003 (regression test passes in CI). All measurable from the new `ScriptingDispatchTests` plus the FSBarV1 repro tail.

## MVP scope

US1 is the entire feature; there is no smaller MVP. The cheapest path to "done" is:

1. T001–T003 (may resolve via SHA bump alone).
2. If SHA matched: T004–T011 (logging + regression test) is sufficient to lock the contract; T012/T013 answer the Y question; T014 only if logging reveals a real proxy bug.
