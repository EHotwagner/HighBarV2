# Tasks: Remove Python and Upgrade to .NET 10

**Input**: Design documents from `/specs/019-remove-python-dotnet10/`
**Prerequisites**: plan.md (required), spec.md (required), research.md, data-model.md, quickstart.md

**Tests**: No test tasks included — spec does not request TDD. Existing F# and C tests serve as regression validation.

**Organization**: Tasks grouped by user story. US1 and US2 are both P1 but independent; US3 depends on both.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup

**Purpose**: Verify environment readiness before making changes

- [x] T001 Verify .NET 10 SDK is installed by running `dotnet --version` (expect 10.x)
- [x] T002 Run full existing test suite via `./tests/run-all.sh` to establish passing baseline

**Checkpoint**: Environment confirmed ready; baseline test results recorded

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Rewrite the Python deployment script before deleting Python — `scripts/install-ai.sh` depends on it

**CRITICAL**: T003 must complete before US1 can delete `scripts/patch-chobby-ai.py`

- [x] T003 Rewrite `scripts/patch-chobby-ai.py` as `scripts/patch-chobby-ai.sh` (Bash) — parse .sdp with zcat/grep, locate aisimplename.lua in pool dir, patch Lua config with sed, write back
- [x] T004 Update `scripts/install-ai.sh` to call `scripts/patch-chobby-ai.sh` instead of `python3 scripts/patch-chobby-ai.py`

**Checkpoint**: Bash replacement script works; `scripts/install-ai.sh` no longer depends on Python

---

## Phase 3: User Story 1 — Remove Python Client and Tests (Priority: P1) MVP

**Goal**: Eliminate all Python code, configuration, and test infrastructure from the repository

**Independent Test**: `find . -name "*.py" -not -path "./.specify/*" | wc -l` returns 0; `grep -r "betterproto\|pytest" --include="*.sh" --include="*.yaml" .` returns nothing

### Implementation for User Story 1

- [x] T005 [P] [US1] Delete `clients/python/` directory (entire Python client library)
- [x] T006 [P] [US1] Delete `tests/integration/python/` directory (Python integration tests)
- [x] T007 [P] [US1] Delete `tests/fixtures/dummy-client.py` (Python test fixture)
- [x] T008 [P] [US1] Delete `scripts/patch-chobby-ai.py` (replaced by .sh in T003)
- [x] T009 [P] [US1] Delete `proto/gen/python/` directory if it exists (generated Python protobuf bindings)
- [x] T010 [US1] Remove betterproto plugin entry from `proto/buf.gen.yaml`
- [x] T011 [US1] Remove the `python` test category and all pytest logic from `tests/run-all.sh`
- [x] T012 [US1] Remove Python references from `tests/setup-engine.sh` (summary comments mentioning pytest)
- [x] T013 [US1] Verify proto generation still works: run `cd proto && buf lint && buf generate` after betterproto removal

**Checkpoint**: Zero `.py` files in repo; proto generation works; test runner has no python category

---

## Phase 4: User Story 2 — Upgrade F# Projects to .NET 10 (Priority: P1)

**Goal**: All F# projects target `net10.0` and build/test successfully

**Independent Test**: `grep -r "net8.0" --include="*.fsproj" .` returns nothing; `dotnet build` succeeds on all projects; `dotnet test` passes on all test projects

### Implementation for User Story 2

- [x] T014 [P] [US2] Update `TargetFramework` from `net8.0` to `net10.0` in `clients/fsharp/HighBar.Client.fsproj`
- [x] T015 [P] [US2] Update `TargetFramework` from `net8.0` to `net10.0` in `data/bar/BarData.fsproj`
- [x] T016 [P] [US2] Update `TargetFramework` from `net8.0` to `net10.0` in `data/bar.tests/BarData.Tests.fsproj`
- [x] T017 [P] [US2] Update `TargetFramework` from `net8.0` to `net10.0` in `tests/ai/fsharp/HighBar.AI.Tests.fsproj`
- [x] T018 [P] [US2] Update `TargetFramework` from `net8.0` to `net10.0` in `tests/unit/fsharp/HighBar.Unit.Tests.fsproj`
- [x] T019 [P] [US2] Update `TargetFramework` from `net8.0` to `net10.0` in `tests/integration/fsharp/HighBar.Tests.fsproj`
- [x] T020 [P] [US2] Update `TargetFramework` from `net8.0` to `net10.0` in `tests/persistent/fsharp/HighBar.PersistentTests.fsproj`
- [x] T021 [P] [US2] Update `TargetFramework` from `net8.0` to `net10.0` in `tools/echo-ai/EchoAI.fsproj`
- [x] T022 [P] [US2] Update `TargetFramework` from `net8.0` to `net10.0` in `tools/game-runner/GameRunner.fsproj`
- [x] T023 [P] [US2] Update `TargetFramework` from `net8.0` to `net10.0` in `tools/reference-ai/ReferenceAI.fsproj`
- [x] T024 [P] [US2] Update `TargetFramework` from `net8.0` to `net10.0` in `tools/replay/Replay.fsproj`
- [x] T025 [US2] Build all F# projects: `dotnet build clients/fsharp/HighBar.Client.fsproj` and each tool/test project
- [x] T026 [US2] Run F# unit tests: `./tests/run-all.sh --category unit`
- [x] T027 [US2] Run F# data tests: `./tests/run-all.sh --category data`

**Checkpoint**: All 11 .fsproj files target net10.0; all builds succeed; all F# tests pass

---

## Phase 5: User Story 3 — Update Project Documentation (Priority: P2)

**Goal**: All documentation reflects F#/.NET 10 + C only; no Python references remain

**Independent Test**: `grep -ri "python\|betterproto\|pytest\|pip install" CLAUDE.md tests/*.sh scripts/*.sh` returns nothing; `grep -r "net8.0" --include="*.md" --include="*.sh" .` returns nothing

### Implementation for User Story 3

- [x] T028 [US3] Update `CLAUDE.md` — remove Python 3.10+ from Active Technologies, remove pip/pytest from Commands, remove `clients/python/` from Project Structure, update all `.NET 8.0` references to `.NET 10`
- [x] T029 [P] [US3] Update Python/betterproto references in `specs/001-native-proxy-bridge/plan.md` and `specs/001-native-proxy-bridge/spec.md`
- [x] T030 [P] [US3] Update Python/pytest references in `specs/002-headless-test-suite/plan.md`
- [x] T031 [P] [US3] Update Python/betterproto references in `specs/003-tools-prereqs-test-fixes/plan.md` and `specs/003-tools-prereqs-test-fixes/spec.md`
- [x] T032 [P] [US3] Update `.NET 8.0` to `.NET 10` in all remaining spec files that reference the framework version (search `specs/` for `net8.0` and `.NET 8`)
- [x] T033 [US3] Final sweep: search entire repo for stale Python references (`grep -ri "python\|betterproto\|pytest" --include="*.md" --include="*.sh" --include="*.yaml" .`) and fix any remaining hits

**Checkpoint**: Documentation is fully consistent with F#/.NET 10 + C only stack

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Final validation across all changes

- [x] T034 Run full test suite via `./tests/run-all.sh` — confirm all categories pass with no regressions
- [x] T035 Run C proxy tests: `./tests/run-all.sh --category proxy`
- [x] T036 Validate quickstart.md verification steps: `find . -name "*.py" -not -path "./.specify/*" | wc -l` returns 0, `grep -r "net8.0" --include="*.fsproj" .` returns nothing
- [x] T037 Run `.specify/scripts/bash/update-agent-context.sh claude` to ensure CLAUDE.md agent context is current

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — start immediately
- **Foundational (Phase 2)**: Depends on Setup — BLOCKS US1 (Python deletion depends on Bash replacement)
- **US1 (Phase 3)**: Depends on Foundational (T003, T004 must complete before deleting .py files)
- **US2 (Phase 4)**: Depends on Setup only — can run in parallel with US1
- **US3 (Phase 5)**: Depends on US1 and US2 (documentation must reflect final state)
- **Polish (Phase 6)**: Depends on all user stories complete

### User Story Dependencies

- **User Story 1 (P1)**: Depends on Foundational phase (Bash rewrite must exist before Python deletion)
- **User Story 2 (P1)**: Independent of US1 — can start after Setup phase
- **User Story 3 (P2)**: Depends on US1 + US2 completion (must document final state)

### Within Each User Story

- US1: Delete directories first (T005-T009, parallel), then modify configs (T010-T012), then verify (T013)
- US2: Update all .fsproj files (T014-T024, all parallel), then build (T025), then test (T026-T027)
- US3: Update CLAUDE.md first (T028), then spec files (T029-T032, parallel), then final sweep (T033)

### Parallel Opportunities

- **US1 + US2 can run in parallel** after Foundational phase completes
- T005-T009 (all file deletions) can run in parallel
- T014-T024 (all .fsproj updates) can run in parallel
- T029-T032 (spec file updates) can run in parallel

---

## Parallel Example: User Story 2

```bash
# Launch all .fsproj updates together (all [P] marked):
Task: "Update TargetFramework in clients/fsharp/HighBar.Client.fsproj"
Task: "Update TargetFramework in data/bar/BarData.fsproj"
Task: "Update TargetFramework in data/bar.tests/BarData.Tests.fsproj"
Task: "Update TargetFramework in tests/ai/fsharp/HighBar.AI.Tests.fsproj"
Task: "Update TargetFramework in tests/unit/fsharp/HighBar.Unit.Tests.fsproj"
Task: "Update TargetFramework in tests/integration/fsharp/HighBar.Tests.fsproj"
Task: "Update TargetFramework in tests/persistent/fsharp/HighBar.PersistentTests.fsproj"
Task: "Update TargetFramework in tools/echo-ai/EchoAI.fsproj"
Task: "Update TargetFramework in tools/game-runner/GameRunner.fsproj"
Task: "Update TargetFramework in tools/reference-ai/ReferenceAI.fsproj"
Task: "Update TargetFramework in tools/replay/Replay.fsproj"

# Then sequentially:
Task: "Build all F# projects"
Task: "Run F# unit tests"
```

---

## Implementation Strategy

### MVP First (User Stories 1 + 2)

1. Complete Phase 1: Setup (verify environment)
2. Complete Phase 2: Foundational (rewrite patch-chobby-ai.sh)
3. Complete Phase 3: US1 — Remove all Python (parallel with Phase 4)
4. Complete Phase 4: US2 — Upgrade to .NET 10
5. **STOP and VALIDATE**: Build + test everything
6. Complete Phase 5: US3 — Documentation cleanup
7. Complete Phase 6: Polish — Final regression run

### Incremental Delivery

1. Foundational → Bash replacement works
2. US1 complete → Zero Python in repo
3. US2 complete → All projects on .NET 10, tests pass
4. US3 complete → Documentation accurate
5. Polish → Full regression green

---

## Notes

- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
- US1 and US2 are both P1 and can run in parallel
- US3 must wait for US1 + US2 since it documents the final state
- Commit after each phase or logical group
- The spec does not request new tests; existing F# and C tests serve as regression suite
