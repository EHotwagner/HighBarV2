# Tasks: Build Tools, Install Prerequisites, and Validate Test Suite

**Input**: Design documents from `/specs/003-tools-prereqs-test-fixes/`
**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, quickstart.md

**Tests**: Not generating new test tasks — this feature builds and runs existing tests.

**Organization**: Tasks grouped by user story to enable independent implementation and testing.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Verify system-level prerequisites are available before attempting builds

- [x] T001 Verify system prerequisites: check that `cmake`, `dotnet`, `python3`, `gcc`/`clang`, `pkg-config`, and `buf` are installed and meet minimum version requirements (CMake 3.20+, .NET 8.0, Python 3.10+, C11 compiler)
- [x] T002 Verify protobuf-c library is available via `pkg-config --exists libprotobuf-c` and report version
- [x] T003 Check headless engine availability: detect if `spring-headless` is on PATH or `HIGHBAR_TEST_ENGINE` environment variable is set; record availability for downstream test phases

**Checkpoint**: All system prerequisites confirmed — build phase can begin

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Generate protobuf code that all downstream components depend on

**CRITICAL**: No component builds can begin until proto generation completes

- [x] T004 Lint protobuf schemas by running `buf lint proto/` from repository root
- [x] T005 Generate protobuf code by running `buf generate proto/` from repository root; verify output exists in `proto/gen/c/`, `proto/gen/csharp/`, and `proto/gen/python/`

**Checkpoint**: Generated protobuf code available — component builds can proceed

---

## Phase 3: User Story 1 — Build All Project Components (Priority: P1) MVP

**Goal**: Build every project component (proxy, clients, tools) in dependency order from a clean state

**Independent Test**: All build artifacts exist at expected paths with non-zero size

### Implementation for User Story 1

- [x] T006 [US1] Build C proxy shared library by running `cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build` from repository root; verify `build/libSkirmishAI.so` (or equivalent) is produced
- [x] T007 [P] [US1] Build F# client library by running `dotnet build` in `clients/fsharp/`; verify HighBar.Client.dll is produced
- [x] T008 [P] [US1] Install Python client package by running `pip install -e .` in `clients/python/`; verify `highbar` is importable
- [x] T009 [P] [US1] Build EchoAI tool by running `dotnet build tools/echo-ai/EchoAI.fsproj`; verify executable is produced (depends on T007)
- [x] T010 [P] [US1] Build ReferenceAI tool by running `dotnet build tools/reference-ai/ReferenceAI.fsproj`; verify executable is produced (depends on T007)
- [x] T011 [P] [US1] Build Replay tool by running `dotnet build tools/replay/Replay.fsproj`; verify executable is produced (depends on T007)
- [x] T012 [US1] Build F# integration test project by running `dotnet build` in `tests/integration/fsharp/`; verify HighBar.Tests.dll is produced (depends on T007)
- [x] T013 [US1] Record build results: for each component, document build status (success/failure), output path, and any warnings or errors encountered

**Checkpoint**: All components built — test execution can begin

---

## Phase 4: User Story 2 — Run Full Test Suite (Priority: P2)

**Goal**: Execute all test suites and capture clear pass/fail results for every test case

**Independent Test**: Each test runner produces output with individual test pass/fail status

### Implementation for User Story 2

- [x] T014 [US2] Run C proxy unit tests by executing `ctest --output-on-failure` in `build/` directory; capture individual results for all 4 tests (test_serialize, test_deserialize, test_roundtrip, test_callbacks)
- [x] T015 [US2] Run F# integration tests by executing `dotnet test tests/integration/fsharp/ --logger "console;verbosity=detailed"` if headless engine is available (per T003); if engine unavailable, document skip reason and list all 22 affected tests
- [x] T016 [US2] Run Python integration tests by executing `pytest tests/integration/python/ -v` if headless engine is available (per T003); if engine unavailable, document skip reason and list all 12 affected tests
- [x] T017 [US2] Compile full test results summary listing each test by name, suite (ctest/xunit/pytest), and status (pass/fail/skip/error)

**Checkpoint**: All test results collected — failure triage can begin

---

## Phase 5: User Story 3 — Fix or Document Failures (Priority: P3)

**Goal**: Every build or test failure is either fixed with a verified passing re-run or documented with root cause and remediation steps

**Independent Test**: Re-running any previously-failing test confirms the fix, or a failure report exists with clear remediation path

### Implementation for User Story 3

- [x] T018 [US3] Triage each failure from T013/T017: classify as code bug (fixable), environment issue (documentable), or known limitation (documentable)
- [x] T019 [US3] For each code bug: apply minimal fix, re-run the affected test to verify it passes, and note the change made
- [x] T020 [US3] For each environment issue or known limitation: create a failure report entry with test name, suite, error output, root cause analysis, and remediation steps
- [x] T021 [US3] Write consolidated test/build report to `specs/003-tools-prereqs-test-fixes/test-report.md` with sections: Build Results, Test Results (by suite), Fixes Applied, Known Issues & Remediation

**Checkpoint**: All failures addressed — every test is either passing or documented

---

## Phase 6: Polish & Cross-Cutting Concerns

**Purpose**: Final validation and documentation

- [x] T022 Re-run full build sequence (T006–T012) to confirm all fixes hold and no regressions introduced
- [x] T023 Re-run all test suites (T014–T016) to confirm final pass/fail state matches expectations
- [x] T024 Validate `specs/003-tools-prereqs-test-fixes/quickstart.md` by following its steps on a clean build; update if any steps are incorrect or missing

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — can start immediately
- **Foundational (Phase 2)**: Depends on Setup (T001–T003) — BLOCKS all builds
- **User Story 1 (Phase 3)**: Depends on Foundational (T004–T005) — BLOCKS test execution
- **User Story 2 (Phase 4)**: Depends on User Story 1 (all builds successful)
- **User Story 3 (Phase 5)**: Depends on User Story 2 (test results collected)
- **Polish (Phase 6)**: Depends on User Story 3 (fixes applied)

### User Story Dependencies

- **User Story 1 (P1)**: Depends on Foundational phase only — no cross-story dependencies
- **User Story 2 (P2)**: Depends on US1 completion (can't test without builds)
- **User Story 3 (P3)**: Depends on US2 completion (can't triage without test results)

### Within User Story 1 (Build Order)

- T006 (C proxy) depends on T005 (proto gen); T007/T008 also depend on T005 but NOT on T006 (F# and Python clients are independent of the proxy build)
- T007 (F# client) and T008 (Python client) can run in parallel [P] — both depend only on T005
- T009, T010, T011 (tools) depend on T007 (F# client)
- T012 (F# tests build) depends on T007 (F# client)

### Parallel Opportunities

- T007 and T008 can run in parallel (F# client and Python client are independent)
- T009, T010, T011 can run in parallel (three independent F# tool builds, after T007)
- T015 and T016 can potentially run in parallel (F# and Python test suites are independent), but headless engine may not support concurrent sessions

---

## Parallel Example: User Story 1

```bash
# After T006 (proxy build) completes:
# Launch F# and Python client builds in parallel:
Task T007: "Build F# client library in clients/fsharp/"
Task T008: "Install Python client package in clients/python/"

# After T007 completes, launch all three tools in parallel:
Task T009: "Build EchoAI tool — tools/echo-ai/EchoAI.fsproj"
Task T010: "Build ReferenceAI tool — tools/reference-ai/ReferenceAI.fsproj"
Task T011: "Build Replay tool — tools/replay/Replay.fsproj"
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Setup (verify prerequisites)
2. Complete Phase 2: Foundational (proto generation)
3. Complete Phase 3: User Story 1 (build everything)
4. **STOP and VALIDATE**: All artifacts exist and are non-zero
5. Proceed to test execution

### Incremental Delivery

1. Setup + Foundational → Prerequisites confirmed, proto code generated
2. User Story 1 → All components build → Validate artifacts (MVP!)
3. User Story 2 → All tests run → Collect results
4. User Story 3 → All failures triaged → Fixes or documentation complete
5. Polish → Final validation pass

### Sequential Execution (Single Developer)

This feature is inherently sequential (build → test → fix) with limited parallelism within each phase. Estimated effort: focused execution, following the quickstart.md steps.

---

## Notes

- [P] tasks = different files, no dependencies on each other
- [Story] label maps task to specific user story for traceability
- This feature does NOT create new tests — it builds and runs existing ones
- Fixes in US3 must be minimal (no refactoring) per spec assumptions
- Commit after each phase or logical group of fixes
- If headless engine is unavailable, US2 integration tests are documented as skipped (not failed)
