# Tasks: Fix Scripting Command Execution (Proxy → Engine Handoff)

**Feature**: 034-fix-command-execute
**Branch**: `034-fix-command-execute`
**Input**: `/home/developer/projects/HighBarV2/specs/034-fix-command-execute/`
**Available docs**: plan.md, spec.md, research.md, data-model.md, contracts/dispatch-log.md, quickstart.md

## Overview

The fix is a targeted proxy bug hunt: add a compile-time probe that compares candidate `SSkirmishAICallback` dispatch conventions, identify the one that produces engine-observable effect, ship that single path, and prove it with a live-engine regression covering BUILD/MOVE/STOP/REPAIR. No schema changes, no engine changes, ≤50 LOC proxy delta.

## Phase 1: Setup

- [ ] T001 Rebase `034-fix-command-execute` onto current `master` (033 landed) and rebuild the baseline from `/home/developer/projects/HighBarV2`: run `cd proto && buf lint && buf generate && cd ..` then `cmake -B build -DCMAKE_BUILD_TYPE=Release -S proxy && cmake --build build`. Confirm `./tests/check-prerequisites.sh` is green. Export `FSBARV1_HOME` in the current shell pointing to the FSBarV1 checkout root (the `diag_one_build.py` gate in later tasks resolves through this variable).
- [ ] T002 [P] Reproduce the 033 failure signature from `/home/developer/projects/HighBarV2` by running FSBarV1's `diag_one_build.py` (resolved as `"$FSBARV1_HOME/diag_one_build.py"`; fail fast if `FSBARV1_HOME` is unset) once against a fresh headless session and capturing the engine infolog path plus the `[HB] dispatch … engine_rc=0` line — file as `specs/034-fix-command-execute/baseline-infolog.txt` (gitignored scratch, not committed).

## Phase 2: Foundational

Blocking prerequisites that every user story needs.

- [ ] T003 Add the compile-time probe scaffold in `proxy/src/proxy.c`: introduce `#ifdef HB_DISPATCH_PROBE` around the per-unit dispatch branch so the current `Engine_handleCommand(skirmishAIId, toId=-1, commandId=-1, topic, data)` call can be paired with alternative candidates (Decision 1 in `research.md`). Probe-emitted log lines MUST use the `[HB] probe …` prefix (distinct from `[HB] dispatch`) to preserve the 033 log contract per `contracts/dispatch-log.md`.
- [ ] T004 Wire the probe flag into the build by adding `option(HB_DISPATCH_PROBE "Enable dual-dispatch probe" OFF)` and a conditional `target_compile_definitions(... HB_DISPATCH_PROBE)` in `proxy/CMakeLists.txt`. Verify `cmake -B build -DHB_DISPATCH_PROBE=ON -S proxy && cmake --build build` compiles cleanly and that the default (`-DHB_DISPATCH_PROBE=OFF` or omitted) leaves the shipped path byte-identical to T001's baseline.
- [ ] T005 [P] Stand up an empty persistent test module `tests/persistent/T13_ExternalWireDispatch.fs` (placeholder test class using xUnit 2.9.x + `HighBar.Client` + `GameRunner`) and register it in the corresponding `.fsproj` under `tests/persistent/`. The module must compile and be discovered by `./tests/run-all.sh --category persistent` with a single skipped test so later stories can add cases without touching project wiring.

## Phase 3: User Story 1 — External scripting client's BuildUnitCommand actually builds a unit (P1)

**Goal**: A single external `BuildUnitCommand` produces a friendly nanoframe within 1500 engine frames, repeatable 3/3 times (SC-001).

**Independent test**: `diag_one_build.py` run three consecutive times against one headless session — all three produce a nanoframe; `[HB] dispatch … engine_rc=0` present each time.

- [ ] T006 [US1] In `proxy/src/proxy.c`, implement probe candidate A (baseline: `Engine_handleCommand`, `toId=-1`, `commandId=-1`) and candidate B (`Engine_handleCommand`, `toId=unitId`, `commandId=-1`) inside the `#ifdef HB_DISPATCH_PROBE` block. Each candidate logs `[HB] probe variant=A|B rc=<int>` before returning. Verify via `cmake --build build` with `-DHB_DISPATCH_PROBE=ON`.
- [ ] T007 [US1] In `proxy/src/proxy.c`, add probe candidate C (`Engine_executeCommand(skirmishAIId, unitId, commandId=-1, topic, data)`) using the prototype from `proxy/include/AI/SSkirmishAICallback.h`. Log as `[HB] probe variant=C rc=<int>`. Rebuild with `-DHB_DISPATCH_PROBE=ON`.
- [ ] T008 [US1] Run `python "$FSBARV1_HOME/diag_one_build.py"` against the probe-enabled proxy on a fresh headless session. Capture the engine infolog, correlate each `[HB] probe variant=…` line with any unit-created event in the same frame window. Record findings (winning variant, per-variant rc, per-variant effect) in `specs/034-fix-command-execute/probe-run.md` (not shipped; local-only artefact that feeds the mailbox reply).
- [ ] T009 [US1] If T008 identifies a single winner, collapse `proxy/src/proxy.c` to that one call: delete the `#ifdef HB_DISPATCH_PROBE` block entirely (FR-008), keep only the winning `Engine_handleCommand|Engine_executeCommand` invocation on the shipped per-unit dispatch path. Confirm the `[HB] dispatch frame=… case=… unit=… engine_rc=…` line remains unchanged (FR-002 / `contracts/dispatch-log.md`).
- [ ] T010 [US1] Also remove the `HB_DISPATCH_PROBE` option from `proxy/CMakeLists.txt` (added in T004). Rebuild with plain `cmake -B build -DCMAKE_BUILD_TYPE=Release -S proxy && cmake --build build` and confirm the `.so` deploys to `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/AI/Skirmish/...`.
- [ ] T011 [US1] Execute the SC-001 acceptance: run `python "$FSBARV1_HOME/diag_one_build.py"` three times consecutively against a single fresh headless session. Record that all three produce a friendly nanoframe within 1500 engine frames and that `[HB] dispatch … engine_rc=0` appears each time (appended to `probe-run.md`).
- [ ] T012 [US1] Add the first real test case to `tests/persistent/T13_ExternalWireDispatch.fs`: `BuildUnit_ProducesNanoframeWithin1500Frames` — issue a single external-wire `BuildUnitCommand` for the commander at a known valid metal spot and assert a friendly unit of the requested def-id appears within 1500 frames. Un-skip the module. Verify via `./tests/run-all.sh --category persistent`.

**Checkpoint**: At the end of US1 the MVP is shippable — `diag_one_build.py` passes 3/3 and `T13_ExternalWireDispatch.BuildUnit…` passes.

## Phase 4: User Story 2 — Regression coverage: other per-unit commands also execute (P1)

**Goal**: MOVE, STOP, and REPAIR produce their engine-observable effects through the same shipped dispatch path (SC-003).

**Independent test**: `./tests/run-all.sh --category persistent` runs the T13 module with BUILD/MOVE/STOP/REPAIR cases and each asserts its effect within its frame budget.

- [ ] T013 [P] [US2] Add `MoveUnit_PositionChangesWithin300Frames` to `tests/persistent/T13_ExternalWireDispatch.fs`: issue a `MoveUnitCommand` for the commander to a reachable position and assert the commander's engine-reported position moves toward the target within 300 frames. Assert `[HB] dispatch case=MOVE_UNIT … engine_rc=0` appears in the infolog.
- [ ] T014 [P] [US2] Add `Stop_CancelsOutstandingOrder` to `tests/persistent/T13_ExternalWireDispatch.fs`: queue a long-running move, then send a `StopCommand`, and assert the commander halts (position stable for ≥60 frames) with `[HB] dispatch case=STOP … engine_rc=0`.
- [ ] T015 [P] [US2] Add `Repair_OrderIsQueuedAndDispatched` to `tests/persistent/T13_ExternalWireDispatch.fs`: spawn a friendly builder and a friendly target via `GiveMeNewUnitCommand`, send a `RepairCommand` from the builder toward the target, and assert (a) `[HB] dispatch case=REPAIR … engine_rc=0` appears, and (b) the builder's engine-reported current-order is REPAIR within 120 frames. Do not assert health increase (target is undamaged in a clean session); the dispatch + order-acceptance signal is sufficient to prove the per-unit REPAIR path executes.
- [ ] T015a [P] [US2] Add `RapidBuildQueue_FiveCommandsProduceFiveDistinctNanoframes` to `tests/persistent/T13_ExternalWireDispatch.fs`: issue 5 `BuildUnitCommand`s for the commander at 5 distinct valid metal spots within a single `FrameResponse`, and assert (a) 5 nanoframes appear within 2500 frames, (b) their positions match the 5 requested spots (no aliasing from the proxy's static position-buffer pool, per spec Edge Case §3), and (c) `[HB] dispatch case=BUILD_UNIT … engine_rc=0` appears 5 times in the infolog.
- [ ] T016 [US2] Run `./tests/run-all.sh --category persistent` from `/home/developer/projects/HighBarV2` and confirm all five T13 cases (BUILD, MOVE, STOP, REPAIR, rapid-BUILD-queue) pass on first clean run (SC-003). If any case fails, return to T009/T010 — the chosen convention is not categorical and the decision table in `data-model.md` must be re-examined before shipping.

**Checkpoint**: Per-unit command class is fully validated end-to-end.

## Phase 5: User Story 3 — No regression for team-wide / unit-less commands (P2)

**Goal**: Team-wide commands continue producing their pre-034 effects (FR-003, SC-002).

**Independent test**: existing persistent tests for `GiveMeNewUnitCommand` and `SendTextMessageCommand` pass unmodified.

- [ ] T017 [US3] Identify the existing persistent tests covering `GiveMeNewUnitCommand` and `SendTextMessageCommand` under `tests/persistent/` (do not add new coverage — reuse whatever 033 shipped). Re-run `./tests/run-all.sh --category persistent` against the 034 proxy build and confirm zero regressions (SC-002). If the fix touched only the per-unit branch these must already pass; if a regression appears, the change was not localized and must be narrowed in `proxy/src/proxy.c`.
- [ ] T018 [US3] Verify SC-004 across the full persistent-test run from T016 + T017: the `[HB] dispatch case=… engine_rc=0` line appears for every accepted command, preserving the 033 log contract in `contracts/dispatch-log.md`.

**Checkpoint**: No regressions; log contract preserved.

## Phase 6: Polish & Cross-Cutting

- [ ] T019 Bump the `HighBar.Client` NuGet version by one patch level in `clients/fsharp/HighBar.Client/HighBar.Client.fsproj` (FR-006) and rebuild via `cd clients/fsharp && dotnet build`.
- [ ] T020 [P] Write the mailbox reply at `Mailbox/2026-04-19-034-fix-command-execute.md` (adjust date to the landing day) following the H2 schema in `contracts/dispatch-log.md`: `## Root cause`, `## Adopted dispatch convention`, `## Caller guidance`, `## Client version`, `## Followups` (FR-005, FR-007). If no single candidate won (Decision 4 fallback in `research.md`), write `## Adopted dispatch convention: none` and document the negative result — no proxy change ships.
- [ ] T021 [P] Decide disposition of `tests/persistent/T12_BuildPositionY.fs` per spec Assumption: repair it if the 034 fix makes it pass, otherwise delete it or mark its cases skipped with a reference to this feature's mailbox reply.
- [ ] T022 Delete local-only scratch artefacts (`specs/034-fix-command-execute/baseline-infolog.txt`, `specs/034-fix-command-execute/probe-run.md`) so only committed design docs remain in the feature dir. Verify `git status` shows only the intended proxy diff, the new test module, the client version bump, the mailbox reply, and the speckit docs under `specs/034-fix-command-execute/`.
- [ ] T023 Final full sweep from `/home/developer/projects/HighBarV2`: run `./tests/run-all.sh` (all categories) and `python "$FSBARV1_HOME/diag_one_build.py"` three times. Commit with Conventional Commits prefixes (`fix:` for the proxy change, `test:` for T13, `build:` for the client bump, `docs:` for the mailbox reply and specs).

## Dependencies

- **Setup (T001–T002)** blocks everything.
- **Foundational (T003–T005)** blocks all user stories.
- **US1 (T006–T012)** is the MVP and must complete before US2 / US3 are meaningful, because the chosen convention in T009 is what US2 and US3 regress-test.
- **US2 (T013–T016)** depends on US1 (shipped path is what US2 exercises across more command types).
- **US3 (T017–T018)** depends on the shipped path from US1 but is independent of US2's new test cases.
- **Polish (T019–T023)** depends on all three user stories passing.

## Parallel Execution Examples

- Within Foundational: T005 (new F# test module scaffold) is parallelizable with T003/T004 (C proxy probe scaffold) — different files, different languages.
- Within US2: T013, T014, T015 are all `[P]` — three independent xUnit test cases added to the same module but no dependencies between them. Can be authored in parallel and share a single `./tests/run-all.sh` verification in T016.
- Within Polish: T020 (mailbox reply) and T021 (T12 disposition) are `[P]` — different files, no shared state.

## Implementation Strategy (MVP first)

1. **MVP = Phase 1 + Phase 2 + Phase 3 (US1)**. Land T001–T012 and the fix is shippable: FSBarV1 unblocked, SC-001 green.
2. **Incremental**: Add US2 (T013–T016) next to prove the fix is categorical across per-unit commands (SC-003). If US2 surfaces a regression, do *not* proceed — revisit T009.
3. **Regression fence**: US3 (T017–T018) is a cheap, existing-test-only pass; run it before Polish to catch unintended breakage in team-wide commands (SC-002).
4. **Ship**: Polish phase bumps the client, files the mailbox reply, cleans scratch, and commits.

If Decision 4 (research.md) triggers — no candidate wins — skip T009–T018 and ship only T020 (mailbox reply with negative result) plus the speckit docs. The branch still lands a valuable artefact: a documented negative result that narrows the hypothesis space for feature 035.
