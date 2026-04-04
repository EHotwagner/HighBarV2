# Tasks: Repository Cleanup

**Input**: Design documents from `/specs/020-repo-cleanup/`
**Prerequisites**: plan.md (required), spec.md (required), research.md, data-model.md

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup

**Purpose**: Capture baseline metrics before making any changes

- [x] T001 Record baseline file counts: `git ls-files -- specs/ | wc -l` (expect ~139) and `git ls-files | wc -l` (expect ~435)
- [x] T002 Record baseline CLAUDE.md Active Technologies line count (expect 40+)

---

## Phase 2: Foundational (No blocking prerequisites)

**Purpose**: This feature has no foundational infrastructure — all user stories are independent file operations.

**Checkpoint**: Phase 1 baseline captured. All user story phases can now proceed.

---

## Phase 3: User Story 1 - Remove Outdated Documentation (Priority: P1) 🎯 MVP

**Goal**: Eliminate all stale Python references from tracked documentation so no developer follows dead-end instructions.

**Independent Test**: Run `git ls-files -- '*.md' | xargs grep -li 'python'` and verify every match is either (a) appropriate historical context or (b) a template/constitution example.

### Implementation for User Story 1

- [x] T003 [P] [US1] Remove Python Client Bindings section from docs/bar-data-reference.md (lines referencing `clients/python/`)
- [x] T004 [P] [US1] Remove Python test category, pytest prereqs, and `clients/python` setup from tests/README.md
- [x] T005 [P] [US1] Add "Note: Python support was removed in feature 019" to docs/research/05-architecture-spec.md near lines referencing Python as secondary target
- [x] T006 [P] [US1] Add "Note: Python support was removed in feature 019" to docs/research/07-implementation-roadmap.md near Python binding/client sections
- [x] T007 [P] [US1] Edit reports/007-test-suite-overview.md to remove Python test rows and references (lines 24, 38, 42, 44, 49)
- [x] T008 [P] [US1] Edit reports/009-live-engine-integration.md to update "both F# and Python harnesses" to F#-only (lines 8, 147)
- [x] T009 [P] [US1] Edit reports/010-remaining-test-failures.md to remove "Update Python harness" task (line 148)
- [x] T010 [P] [US1] Edit reports/011-test-fix-results.md to remove Python harness note (line 104)
- [x] T011 [P] [US1] Check if tests/fixtures/dummy-client.py exists; if not, remove its reference from reports/013-diagnose-fix-test-gaps.md (line 183)
- [x] T012 [US1] Verify: run `git ls-files -- '*.md' | xargs grep -li 'python'` and confirm all remaining matches are appropriate (V1 analysis, constitution examples, templates)

**Checkpoint**: All stale Python references removed. Every tracked markdown is either current or clearly historical.

---

## Phase 4: User Story 2 - Consolidate CLAUDE.md (Priority: P1)

**Goal**: Replace the 40+ line per-feature Active Technologies listing with a consolidated ~15 line summary. No information loss.

**Independent Test**: Read CLAUDE.md and verify (a) every unique technology from the old format is represented, (b) no per-feature duplication remains, (c) Active Technologies section is ≤15 lines.

### Implementation for User Story 2

- [x] T013 [US2] Rewrite the "Active Technologies" section of CLAUDE.md: replace per-feature bullet list with a consolidated table organized by category (Languages, Dependencies, Testing, Tooling, Game Integration). Each technology listed once with its purpose.
- [x] T014 [US2] Trim "Recent Changes" section of CLAUDE.md to last 3 features only (keep 018, 019, 020)
- [x] T015 [US2] Remove per-feature storage/database annotations from CLAUDE.md (they all say "Filesystem only")
- [x] T016 [US2] Verify: count lines in Active Technologies section (target ≤15) and confirm no unique technology was lost

**Checkpoint**: CLAUDE.md is concise, non-repetitive, and complete. SC-001 and SC-004 met.

---

## Phase 5: User Story 3 - Archive Completed Spec Artifacts (Priority: P2)

**Goal**: Remove verbose planning artifacts (research.md, data-model.md, quickstart.md, checklists/, contracts/) from completed features 001-019, reducing specs/ file count by ~63 files.

**Independent Test**: Run `git ls-files -- specs/ | wc -l` and verify count is under 85. Verify each feature 001-019 retains spec.md, plan.md, and tasks.md.

### Implementation for User Story 3

- [x] T017 [US3] Remove research.md from all 19 completed features (specs/001-* through specs/019-*)
- [x] T018 [P] [US3] Remove data-model.md from all 19 completed features (specs/001-* through specs/019-*)
- [x] T019 [P] [US3] Remove quickstart.md from 18 completed features that have it (all except 010)
- [x] T020 [P] [US3] Remove checklists/ directories from all 19 completed features (specs/001-* through specs/019-*)
- [x] T021 [P] [US3] Remove contracts/ directories from features 001, 004, 013, 018
- [x] T022 [P] [US3] Remove test-report.md from feature 003 (specs/003-tools-prereqs-test-fixes/test-report.md)
- [x] T023 [US3] Verify: run `git ls-files -- specs/ | wc -l` (target: under 85) and confirm spec.md + plan.md + tasks.md remain in each feature 001-019

**Checkpoint**: specs/ directory is lean. Each completed feature retains its core record. SC-003 met.

---

## Phase 6: User Story 4 - Clean Up Stale Report Content (Priority: P2)

**Goal**: Remove report 006 and update the reports index so the reports/ directory reflects current project state.

**Independent Test**: Verify reports/006-python-tests.md is gone. Verify reports/README.md no longer references it.

### Implementation for User Story 4

- [x] T024 [P] [US4] Remove reports/006-python-tests.md from version control
- [x] T025 [P] [US4] Update reports/README.md to remove the report 006 index entry (line 14)
- [x] T026 [US4] Review reports/TEMPLATE.md for currency — update if any categories reference removed functionality
- [x] T027 [US4] Verify: confirm `git ls-files -- reports/006*` returns empty

**Checkpoint**: Reports directory is clean. SC-002 met for reports.

---

## Phase 7: User Story 5 - Streamline Repository Root Structure (Priority: P3)

**Goal**: Remove stale .gitignore entries and verify every tracked root-level item serves an active purpose.

**Independent Test**: Read .gitignore and confirm no entries for removed tools. Run `git ls-files | sed 's|/.*||' | sort -u` and verify each top-level entry has a documented purpose.

### Implementation for User Story 5

- [x] T028 [US5] Remove the `# Python` section (6 entries: __pycache__/, *.pyc, .venv/, venv/, dist/, *.egg-info/) from .gitignore
- [x] T029 [US5] Audit remaining .gitignore entries against current build processes — verify each entry corresponds to an artifact that is actually generated
- [x] T030 [US5] Verify: list all tracked root-level items and confirm each has a clear active purpose documented in CLAUDE.md or README

**Checkpoint**: Repository root is clean and fully documented. SC-005 met.

---

## Phase 8: Polish & Cross-Cutting Concerns

**Purpose**: Final validation across all user stories

- [x] T031 Run full staleness audit: `git ls-files -- '*.md' | xargs grep -li 'python'` — verify all remaining Python mentions are appropriate
- [x] T032 Record post-cleanup file counts and compare against baselines from T001/T002: specs/ < 85 files, CLAUDE.md Active Technologies ≤ 15 lines, total tracked files reduced by ~65
- [x] T033 Verify builds still work: `cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build` and `cd clients/fsharp && dotnet build`

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — start immediately
- **Foundational (Phase 2)**: No blocking work — proceed to user stories
- **User Stories (Phases 3-7)**: All independent of each other — can run in parallel
- **Polish (Phase 8)**: Depends on all user stories being complete

### User Story Dependencies

- **User Story 1 (P1)**: No dependencies on other stories. Can start immediately.
- **User Story 2 (P1)**: No dependencies on other stories. Can start immediately.
- **User Story 3 (P2)**: No dependencies on other stories. Can start immediately.
- **User Story 4 (P2)**: No dependencies on other stories. Can start immediately.
- **User Story 5 (P3)**: Best done after US2 (CLAUDE.md consolidation) since .gitignore audit references CLAUDE.md for verification.

### Within Each User Story

- Tasks marked [P] within a story can run in parallel
- Verification task (last in each story) must run after all other tasks in that story

### Parallel Opportunities

- **All 5 user stories** can execute in parallel (they touch different files)
- **Within US1**: T003–T011 are all [P] — different files, no conflicts
- **Within US3**: T018–T022 are all [P] — different artifact types across features
- **Within US4**: T024–T025 are [P] — different files

---

## Parallel Example: User Story 1

```bash
# All these touch different files — launch together:
Task T003: "Remove Python section from docs/bar-data-reference.md"
Task T004: "Remove Python refs from tests/README.md"
Task T005: "Add removal note to docs/research/05-architecture-spec.md"
Task T006: "Add removal note to docs/research/07-implementation-roadmap.md"
Task T007: "Edit reports/007-test-suite-overview.md"
Task T008: "Edit reports/009-live-engine-integration.md"
Task T009: "Edit reports/010-remaining-test-failures.md"
Task T010: "Edit reports/011-test-fix-results.md"
Task T011: "Check dummy-client.py and edit reports/013-diagnose-fix-test-gaps.md"

# Then verify:
Task T012: "Run staleness grep and confirm results"
```

---

## Parallel Example: User Story 3

```bash
# All these are independent artifact types — launch together:
Task T017: "Remove research.md from all completed features"
Task T018: "Remove data-model.md from all completed features"
Task T019: "Remove quickstart.md from all completed features"
Task T020: "Remove checklists/ from all completed features"
Task T021: "Remove contracts/ from features 001, 004, 013, 018"
Task T022: "Remove test-report.md from feature 003"

# Then verify:
Task T023: "Check file counts and retained artifacts"
```

---

## Implementation Strategy

### MVP First (User Stories 1 + 2)

1. Complete Phase 1: Capture baselines (T001-T002)
2. Complete Phase 3: Remove stale Python references (T003-T012)
3. Complete Phase 4: Consolidate CLAUDE.md (T013-T016)
4. **STOP and VALIDATE**: Grep for stale references, verify CLAUDE.md is concise
5. This delivers the highest-value cleanup — accurate docs and a readable CLAUDE.md

### Full Delivery

1. MVP above
2. Add Phase 5: Archive spec artifacts (T017-T023) — biggest file count reduction
3. Add Phase 6: Clean reports (T024-T027) — removes obsolete report
4. Add Phase 7: Streamline root (T028-T030) — final polish
5. Phase 8: Validate everything (T031-T033)

---

## Notes

- All tasks are file deletions or markdown edits — no source code changes
- Git history preserves all removed files — nothing is permanently lost
- Commit after each phase using conventional commits format
- [P] tasks = different files, no dependencies
- [Story] label maps task to specific user story for traceability
