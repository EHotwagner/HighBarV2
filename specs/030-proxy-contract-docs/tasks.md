# Tasks: Proxy Contract Documentation

**Input**: Design documents from `/specs/030-proxy-contract-docs/`
**Prerequisites**: plan.md (required), spec.md (required), research.md, data-model.md, contracts/

**Tests**: Not applicable — this is a documentation-only feature. No test tasks generated.

**Organization**: Tasks are grouped by user story to enable independent delivery.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2, US3)
- Include exact file paths in descriptions

---

## Phase 1: Setup

**Purpose**: No project initialization needed. This feature produces only markdown documents in existing directories.

- [x] T001 Verify feature branch `030-proxy-contract-docs` is checked out and specs directory exists at `specs/030-proxy-contract-docs/`

---

## Phase 2: Foundational (Source Verification)

**Purpose**: Verify all proxy source references cited in the contract documents are accurate against the current codebase. Must complete before writing any contract documents.

- [x] T002 [P] Read `proxy/src/proxy.c` lines 351-406 and confirm the EVENT_RELEASE handler maps SReleaseEvent.reason values 1-6 to ShutdownReason enum values as documented in `specs/030-proxy-contract-docs/research.md` section R2
- [x] T003 [P] Read `proxy/src/deserialize.c` lines 708-712 and confirm the stderr log format matches `[HB] unsupported command oneof case=%d (proxy switch table miss)` and return code is `HB_DESERIALIZE_RC_UNSUPPORTED` (-2) as documented in `specs/030-proxy-contract-docs/research.md` section R3
- [x] T004 [P] Read `proxy/src/proxy.c` lines 214-238 and confirm verbose-mode log format is `Cmd %zu: case=%d` and `Cmd %zu: rc=%d` on separate lines, gated behind `verbose_commands` config, as documented in `specs/030-proxy-contract-docs/research.md` section R3
- [x] T005 [P] Read `proto/highbar/messages.proto` and confirm ShutdownReason enum values (UNKNOWN=0, GAME_OVER=1, DISCONNECT=2, ERROR=3) and Shutdown message definition match `specs/030-proxy-contract-docs/research.md` section R5

**Checkpoint**: All source references verified. Contract document authoring can begin.

---

## Phase 3: User Story 1 — Document Shutdown Wire Shape (Priority: P1) 🎯 MVP

**Goal**: Produce a contract document that fully describes the Shutdown message wire shape, reason mapping, trigger conditions, and client handling guidance.

**Independent Test**: A developer unfamiliar with the proxy can read the contract document and correctly determine how to handle end-of-match signaling without reading proxy source code.

### Implementation for User Story 1

- [x] T006 [US1] Review and finalize the Shutdown wire shape contract document at `specs/030-proxy-contract-docs/contracts/shutdown-wire-shape.md` (Phase 1 draft already exists) covering: (1) wire shape as top-level ProxyMessage.Shutdown envelope, (2) message sequencing (after last Frame, before socket close), (3) proto schema excerpt, (4) full SReleaseEvent.reason-to-ShutdownReason mapping table per research.md R2, (5) trigger conditions for all four ShutdownReason values per research.md R2, (6) recommended client handling pattern (read all ProxyMessage types, handle Shutdown as terminal), (7) anti-pattern warning against modeling Shutdown as a frame event. Source of truth: `proxy/src/proxy.c` lines 351-406, `proto/highbar/messages.proto` lines 78-87
- [x] T007 [US1] Add a cross-reference note to `specs/029-fix-trainer-issues/contracts/shutdown-event.md` pointing readers to `specs/030-proxy-contract-docs/contracts/shutdown-wire-shape.md` for the complete Shutdown wire shape documentation including trigger conditions and client handling guidance

**Checkpoint**: Shutdown contract document is complete and self-contained. FR-001, FR-002, FR-003, FR-006 satisfied.

---

## Phase 4: User Story 2 — Document Unwired Command Log Format (Priority: P2)

**Goal**: Produce a contract document that specifies the exact log format for unsupported commands, output streams, return code semantics, and a stability promise.

**Independent Test**: A developer can write a correct rc=-2 log parser using only this document, without reading proxy source code.

### Implementation for User Story 2

- [x] T008 [US2] Review and finalize the unwired-command log format contract document at `specs/030-proxy-contract-docs/contracts/unwired-command-log.md` (Phase 1 draft already exists) covering: (1) unconditional stderr format `[HB] unsupported command oneof case=%d (proxy switch table miss)`, (2) verbose-mode infolog format `Cmd %zu: case=%d` and `Cmd %zu: rc=%d` on separate lines, (3) note that case values are integers not string names, (4) return code table (0=accepted, -1=null, -2=unsupported, other=engine error), (5) parsing guidance for both stderr and infolog paths, (6) stability promise for proxy 0.1.x series. Source of truth: `proxy/src/deserialize.c` lines 708-712, `proxy/src/proxy.c` lines 214-238

**Checkpoint**: Unwired command log contract is complete. FR-004, FR-005 satisfied.

---

## Phase 5: User Story 3 — Document ShutdownReason Trigger Conditions (Priority: P2)

**Goal**: Ensure all three ShutdownReason values have documented engine-level trigger conditions.

**Independent Test**: A developer can determine from the documentation what engine events produce Error and Disconnect, and can design a test scenario for each.

### Implementation for User Story 3

- [x] T009 [US3] Verify that `specs/030-proxy-contract-docs/contracts/shutdown-wire-shape.md` (written in T006) includes a dedicated "Trigger Conditions" section with subsections for GameOver (reasons 1-3), Error (reasons 4-5), Disconnect (reason 6), and Unknown (default), each describing the engine-level cause and example scenarios that would trigger it. If missing or incomplete, update the document. FR-006 satisfied.

**Checkpoint**: All ShutdownReason trigger conditions documented. SC-003 satisfied.

---

## Phase 6: User Story 4 — Respond to AttackCommand Probe (Priority: P3)

**Goal**: Provide a documented response to the FSBarV1 AttackCommand stationary-unit probe.

**Independent Test**: The mailbox response exists, addresses all four FSBarV1 items, and provides actionable next steps for the probe investigation.

### Implementation for User Story 4

- [x] T010 [US4] Run a verbose-mode probe to test AttackCommand dispatch: start a headless engine session on map `Avalanche 3.4` with `verbose_commands=true`, spawn an `armcom` unit and an enemy mobile unit (e.g., `corcom`) within line-of-sight (~500 elmos apart), issue an AttackCommand targeting the enemy, and capture the engine infolog showing the `Cmd N: case=<int>` and `Cmd N: rc=<int>` lines for the attack command. Record the attacker's position before and after 600 frames. Success: position delta > 50 elmos (unit moved toward target). Reproduction of FSBarV1 issue: position delta < 1 elmo (unit stationary). Save results to `specs/030-proxy-contract-docs/diagnostic/attack-probe-verbose.md`
- [x] T011 [US4] Write the mailbox response at `Mailbox/2026-04-12_from_HighBarV2_contract-docs-response.md` addressing all four FSBarV1 items: (1) Problem 1 — point to new shutdown-wire-shape.md contract, (2) Problem 2 — point to new unwired-command-log.md contract and flag that case values are integers not strings and that the FSBarV1 parser's same-line assumption is incorrect for verbose mode, (3) Problem 3 — point to trigger conditions section in shutdown-wire-shape.md, (4) Problem 4 — include verbose-mode probe results from T010 or recommend a re-probe shape if results are inconclusive

**Checkpoint**: Mailbox response complete. FR-007 and SC-004 satisfied.

---

## Phase 7: Polish & Cross-Cutting Concerns

**Purpose**: Final validation and cleanup across all deliverables.

- [x] T012 Review all contract documents for internal consistency: verify that reason mapping tables in shutdown-wire-shape.md match data-model.md and research.md
- [x] T013 Verify the cross-reference in `specs/029-fix-trainer-issues/contracts/shutdown-event.md` (T007) links correctly and the target document exists

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — start immediately
- **Foundational (Phase 2)**: Depends on Phase 1 — BLOCKS all user stories
- **US1 (Phase 3)**: Depends on Phase 2 — can start after source verification
- **US2 (Phase 4)**: Depends on Phase 2 — can run in parallel with US1
- **US3 (Phase 5)**: Depends on US1 (T006) — verifies content written in Phase 3
- **US4 (Phase 6)**: Depends on Phase 2 for the probe (T010); depends on US1+US2+US3 for the mailbox response (T011) since it references all contract docs
- **Polish (Phase 7)**: Depends on all user stories complete

### User Story Dependencies

- **US1 (P1)**: Independent after Phase 2 — can start immediately after source verification
- **US2 (P2)**: Independent after Phase 2 — can run in parallel with US1
- **US3 (P2)**: Depends on US1 (T006) — verifies/extends the shutdown contract written in US1
- **US4 (P3)**: Depends on US1, US2, US3 for the response (T011); probe task (T010) is independent

### Within Each User Story

- Source verification (Phase 2) before document authoring
- Contract documents before mailbox response
- All contract docs before cross-reference validation

### Parallel Opportunities

- T002, T003, T004, T005 (all Phase 2 source verification) can run in parallel
- T006 (US1) and T008 (US2) can run in parallel after Phase 2
- T010 (US4 probe) can run in parallel with US1/US2/US3 document authoring

---

## Parallel Example: Source Verification

```
# All four source verification tasks in parallel:
Task T002: Verify EVENT_RELEASE handler in proxy.c
Task T003: Verify stderr log format in deserialize.c
Task T004: Verify verbose log format in proxy.c
Task T005: Verify proto schema in messages.proto
```

## Parallel Example: Contract Authoring

```
# US1 and US2 contract documents in parallel:
Task T006: Write shutdown-wire-shape.md
Task T008: Write unwired-command-log.md
```

---

## Implementation Strategy

### MVP First (User Story 1 Only)

1. Complete Phase 1: Setup (trivial)
2. Complete Phase 2: Source verification (T002-T005 in parallel)
3. Complete Phase 3: Write shutdown-wire-shape.md (T006) + cross-reference (T007)
4. **STOP and VALIDATE**: Contract document answers all Shutdown questions without needing proxy source
5. Can be delivered independently — highest-value, lowest-cost deliverable

### Incremental Delivery

1. Setup + Source verification → foundation ready
2. US1 (Shutdown wire shape) → immediate value for FSBarV1 Problem 1 + Problem 3
3. US2 (Unwired command log) → addresses FSBarV1 Problem 2
4. US3 (Trigger conditions verification) → ensures completeness of US1 deliverable
5. US4 (Mailbox response + probe) → closes the loop with FSBarV1 on all four items
6. Polish → final consistency check

---

## Notes

- This is a documentation-only feature — no code changes, no builds, no test execution required
- All contract document content is derived from reading existing proxy source code
- The verbose-mode probe (T010) is the only task requiring a live engine run
- If the probe is inconclusive or blocked, T011 can still be written recommending FSBarV1 re-probe with a better shape
- Commit after each contract document for clean history
