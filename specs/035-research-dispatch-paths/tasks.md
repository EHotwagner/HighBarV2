---

description: "Task list for 035-research-dispatch-paths"
---

# Tasks: Research Lua/Recoil/Circuit/BARb Command Dispatch Paths

**Input**: Design documents from `/specs/035-research-dispatch-paths/`
**Prerequisites**: plan.md, spec.md, research.md, data-model.md, contracts/findings.contract.md, quickstart.md

**Tests**: No speculative tests. Live regression test is required only in outcome (a) — see US5.

**Organization**: Tasks are grouped by user story. This is a research-dominant feature — the "implementation" for US1–US4 is drafting `findings.md` sections, not code. US5 is the optional fix-shipping path triggered by a successful live probe.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files / independent research threads, no dependencies on incomplete tasks)
- **[Story]**: Which user story this task belongs to (US1, US2, US3, US4, US5)

## Path Conventions

- Research artefacts: `specs/035-research-dispatch-paths/`
- Optional code changes (outcome (a) / FR-014): `proxy/src/deserialize.c`, `clients/fsharp/src/Commands.fs`, `clients/fsharp/src/HighBar.Client.fsproj`, `tests/Persistent/` or `tests/Integration/`
- Mailbox reply: `Mailbox/2026-04-19_to_FSBarV1_*.md`

---

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Resolve pinned source revisions and create the empty deliverable scaffold so every user-story task has a well-defined place to write into.

- [X] T001 Resolve Recoil tag `2025.06.19` to a 40-char SHA via `git ls-remote --tags https://github.com/beyond-all-reason/RecoilEngine 2025.06.19` and record it in a scratch note at `specs/035-research-dispatch-paths/.shas.txt` (git-ignored working file — not committed).
- [X] T002 [P] Identify the Circuit AI source revision matching the binary at `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/AI/Skirmish/CircuitAI/` (inspect `AIInfo.lua`, `strings` the `.so` if needed) and record the SHA in `specs/035-research-dispatch-paths/.shas.txt`.
- [X] T003 [P] Locate the BARb archive under `~/.local/state/Beyond All Reason/packages/`, compute its sha256, and record filename + hash in `specs/035-research-dispatch-paths/.shas.txt`. If BARb is unreachable (rapid pool only), note the documented fallback per research.md Decision 4.
- [X] T004 Create empty `specs/035-research-dispatch-paths/findings.md` with the Top Matter skeleton filled from T001–T003 (Outcome line left as placeholder, to be set during US1 / US5): `Outcome`, `Recoil SHA`, `Circuit SHA`, `BARb archive + sha256`, `Author / date`.

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Establish the Recoil call-graph skeleton that every downstream hypothesis verdict and divergence finding references. Without this, US1/US2/US3 cannot cite file:line precisely.

**⚠️ CRITICAL**: US1–US5 cannot complete until T005–T007 land the two primary dispatch traces and the `RawCommand` struct quote.

- [X] T005 Trace the `Engine_handleCommand` function-pointer target from `SSkirmishAICallbackImpl.cpp` at the pinned Recoil SHA down through `SkirmishAIWrapper.cpp` → `AICallback.cpp` → `CCommandAI::GiveCommand` (or the drop point) and write the trace into `specs/035-research-dispatch-paths/findings.md` §2 with file:line at every step, every cited line quoted inline. (FR-001, FR-008)
- [X] T006 [P] Trace the `Engine_executeCommand` function-pointer target analogously and write the trace into `specs/035-research-dispatch-paths/findings.md` §3, including any branch that validates / rejects the incoming struct. (FR-001, FR-008)
- [X] T007 Locate the canonical `RawCommand` struct definition in Recoil source at the pinned SHA (likely under `rts/ExternalAI/Interface/AISCommands.h` or similar) and quote it verbatim (field order, types, build-order encoding `id[0] = -buildUnitDefId`) into `specs/035-research-dispatch-paths/findings.md` §3. (FR-011)

**Checkpoint**: Both dispatch traces and the `RawCommand` struct are now in §2/§3. All subsequent stories can cite from these.

---

## Phase 3: User Story 1 — Engineer gets a root-cause finding (Priority: P1) 🎯 MVP

**Goal**: A cold reader can state, in under 15 minutes, *why* `Engine_handleCommand(aiId, -1, -1, COMMAND_UNIT_BUILD, &SBuildUnitCommand)` returns `rc=0` with no effect, and what the correct call is.

**Independent Test**: A reviewer who has not read Recoil or Circuit source can, from the document alone, answer: "if I call `Engine_executeCommand` with arguments X (or `Engine_handleCommand` with arguments Y), will the engine build the unit?" — correctly.

### Implementation for User Story 1

- [X] T008 [US1] Write §6.1 — hypothesis verdict for `commandData` layout under `Engine_executeCommand`: confirmed / ruled out / inconclusive, citing §3 + T007. In `specs/035-research-dispatch-paths/findings.md`. (FR-004, SC-002)
- [X] T009 [P] [US1] Write §6.2 — hypothesis verdict for seat-kind / team-ownership gate, citing the relevant branch from §2/§3. In `specs/035-research-dispatch-paths/findings.md`. (FR-004)
- [X] T010 [P] [US1] Write §6.3 — hypothesis verdict for `BuildPosition.Y` ground-snap, citing Recoil source. Triggers FR-015 live-probe sub-task if source disagrees with 033 Q4 Resolution. In `specs/035-research-dispatch-paths/findings.md`. (FR-004, FR-015)
- [X] T011 [P] [US1] Write §6.4 — hypothesis verdict for CommandOptions bitfield, cross-referenced with §9 (`UnitCommandOptions` enum). In `specs/035-research-dispatch-paths/findings.md`. (FR-004)
- [X] T012 [P] [US1] Write §6.5 — hypothesis verdict for `commandId` scheme (`COMMAND_ID_UNTRACKED = -1` vs non-negative), citing the `NETMSG_AICOMMAND_TRACKED` path in Recoil. In `specs/035-research-dispatch-paths/findings.md`. (FR-004, FR-012 cross-ref)
- [X] T013 [US1] For every §6.x verdict where T008–T012 found source/empirical disagreement, run one live probe per research.md Decision 5 and quote the resulting `engine.infolog` line verbatim next to the source reading in the relevant subsection. In `specs/035-research-dispatch-paths/findings.md`. (FR-015)
- [X] T014 [US1] Write §7 "Prior attempts" table citing commit `dce4e42` (017, commandId → -1), commit `357ab8e` (017, INTERNAL_ORDER = 8), 033 Q4 Resolution (options=0 and Y=0 both still fail), and 034's 4-variant probe matrix (A/B/D → rc=0 no effect, C → crash), with empirical verdict and Recoil-source explanation for each row. In `specs/035-research-dispatch-paths/findings.md`. (FR-012)
- [X] T015 [US1] Write §1 Outcome summary paragraph and §12 Next-step recommendation, resolving to outcome (a), (b), or (c) based on §6 verdicts. If (a), leave commit-SHA placeholder for US5 to fill. In `specs/035-research-dispatch-paths/findings.md`. (FR-005, SC-003)

**Checkpoint**: US1 MVP complete — the document answers the primary research question even if US2–US5 never land.

---

## Phase 4: User Story 2 — Captured known-good C dispatch signature from Circuit (Priority: P1)

**Goal**: Circuit's build-order dispatch is quoted all the way to the raw `SSkirmishAICallback` function-pointer call, with a field-by-field divergence table versus HighBarV2.

**Independent Test**: Reader can place §5 next to `proxy/src/deserialize.c:51` (COMMAND_BUILD_UNIT case) and enumerate every divergent field.

### Implementation for User Story 2

- [ ] T016 [US2] Quote Circuit's highest-level build-order call site (e.g., `CBuilderManager` or similar) from the Circuit source at the pinned SHA, with file:line, into `specs/035-research-dispatch-paths/findings.md` §5. (FR-002, SC-006)
- [ ] T017 [US2] Quote the wrapper layer (`springai::Unit::Build` / `CAIAICallback::GiveOrder`) with file:line into §5, showing how the wrapper composes the raw callback arguments. In `specs/035-research-dispatch-paths/findings.md`. (FR-002, FR-008)
- [ ] T018 [US2] Quote the final raw `Engine_executeCommand` (or `Engine_handleCommand`) call site with file:line into §5, and enumerate every parameter value Circuit passes (entry point, unitId, groupId/commandId, struct pointer, struct contents, options, pre-dispatch setup such as cheat toggle). In `specs/035-research-dispatch-paths/findings.md`. (FR-002)
- [ ] T019 [US2] Write §8 field-by-field divergence table comparing `proxy/src/deserialize.c` COMMAND_BUILD_UNIT case against Circuit's dispatch captured in T016–T018. Every divergent field lists the proposed HighBarV2 change. In `specs/035-research-dispatch-paths/findings.md`.
- [ ] T020 [US2] If Circuit's dispatch matches HighBarV2's and Circuit still works (per spec edge case), repeat T016–T018 against a second working C AI (KAIK, Shard, or AAI from the Spring tree) and append that trace to §5. In `specs/035-research-dispatch-paths/findings.md`.

**Checkpoint**: §5 and §8 complete. US1 + US2 together give a full root-cause picture.

---

## Phase 5: User Story 3 — Lua vs C-callback divergence documented (Priority: P2)

**Goal**: §4 names whether `Spring.GiveOrderToUnit` (Lua) and `Engine_executeCommand` (C) converge inside the engine, with the join or divergence point cited.

**Independent Test**: Reader can follow both call chains from entry to order-enqueue using only §4.

### Implementation for User Story 3

- [ ] T021 [US3] Extract BARb Lua source per quickstart.md §3 (or apply the documented fallback from T003) and quote the `Spring.GiveOrderToUnit` call site with file:line into `specs/035-research-dispatch-paths/findings.md` §4. (FR-003, SC-006)
- [ ] T022 [US3] Trace the engine-side `Spring.GiveOrderToUnit` handler in Recoil source at the pinned SHA (likely under `rts/Lua/LuaSyncedCtrl.cpp` or similar) down to the same order-enqueue function cited by §2/§3, writing the chain into `specs/035-research-dispatch-paths/findings.md` §4. (FR-003)
- [ ] T023 [US3] State the explicit join-or-divergence verdict in `specs/035-research-dispatch-paths/findings.md` §4: "Lua and C converge at `<function>:<line>`" OR "Lua and C diverge at `<function>:<line>` — the C surface is lossy for <X>". If the latter, append a Lua-shim architecture note to §12. (FR-003, FR-005)

**Checkpoint**: §4 complete. Outcome-(c) scope seed is written iff T023 finds divergence at a lossy point.

---

## Phase 6: User Story 4 — Recent Recoil changes surveyed (Priority: P3)

**Goal**: §10 either lists relevant recent Recoil commits or explicitly records a negative search result.

**Independent Test**: Reader can tell whether an engine-side regression is a plausible explanation for the 034 silent-drop.

### Implementation for User Story 4

- [ ] T024 [P] [US4] Search the Recoil repo for commits in the last ~18 months touching `SSkirmishAICallbackImpl.cpp`, `SkirmishAIWrapper.cpp`, `AICallback.cpp`, `CommandAI/*`, and `NETMSG_AICOMMAND*` handlers. Record findings in `specs/035-research-dispatch-paths/findings.md` §10 as either a bullet list of SHA + summary + "is / isn't our problem" judgment, or a negative result naming the paths searched.
- [ ] T025 [P] [US4] Compare the vendored header `proxy/include/AI/SSkirmishAICallback.h` against the 2025.06.19 Recoil source's equivalent; record any conflicts in `specs/035-research-dispatch-paths/findings.md` §11. (FR-009)

**Checkpoint**: §10 and §11 complete.

---

## Phase 7: User Story 5 — FR-013 INTERNAL_ORDER resolution + optional outcome-(a) fix

**Goal**: §9 resolves the INTERNAL_ORDER vs SHIFT_KEY collision from Recoil source. If bit-3 is SHIFT_KEY (or any non-"internal AI order" flag), FR-014 cleanup ships. If the research from US1/US2 landed a working dispatch convention and a probe confirmed it, outcome (a) ships the proxy fix plus regression test.

**Independent Test (FR-014)**: `clients/fsharp/src/Commands.fs` no longer contains `INTERNAL_ORDER`; all unit-command builders default `Options = 0u`; `HighBar.Client` patch bumped.
**Independent Test (outcome a)**: The new live-engine regression test fails at the pre-fix commit and passes at the fix commit; engine-observable effect (nanoframe, unit motion, economy delta) is asserted — not `rc=0`.

### FR-013 / FR-014 cleanup (independent of outcome)

- [X] T026 [US5] Quote Recoil's `UnitCommandOptions` enum from the 2025.06.19 source (NOT the vendored `proxy/include/AI/` header) into `specs/035-research-dispatch-paths/findings.md` §9 and state the verdict on `INTERNAL_ORDER = 8u`: safe / ambiguous / harmful. (FR-013)
- [X] T027 [US5] If T026 concludes bit-3 is SHIFT_KEY or any non-"internal AI order" flag: remove `INTERNAL_ORDER = 8u` from `clients/fsharp/src/Commands.fs` and default all unit-command builders (`MoveCommand`, `BuildCommand`, `PatrolCommand`, `AttackCommand`, `StopCommand`, `RepairCommand`, etc.) to `Options = 0u`. (FR-014)
- [X] T028 [US5] If T027 ran: bump `HighBar.Client` patch version in `clients/fsharp/src/HighBar.Client.fsproj`. (FR-014)

### Outcome-(a) fix (gated on a confirmed live probe from US1/US2)

- [ ] T029 [US5] If US1/US2 identified a working dispatch convention and it confirmed live per research.md Decision 6: apply the ≤30-LOC proxy fix in `proxy/src/deserialize.c` (COMMAND_BUILD_UNIT and any sibling cases that share the same root cause).
- [ ] T030 [US5] If T029 ran: add a live-engine regression test under `tests/Persistent/` (or `tests/Integration/`) that asserts engine-observable effect — nanoframe appearing in `engine.infolog`, or unit position change, or economy delta — NOT `rc=0`. Ensure the test fails at HEAD before T029 is committed and passes after. (FR-007, SC-004)
- [ ] T031 [US5] If T029 ran and T028 has not already bumped: bump `HighBar.Client` patch version in `clients/fsharp/src/HighBar.Client.fsproj` (may be the same bump as T028). (FR-007)
- [ ] T032 [US5] If T029 ran: backfill the fix's commit SHA into `specs/035-research-dispatch-paths/findings.md` §1 and §12; ensure the outcome line at top of `findings.md` reads "outcome (a): live-engine-confirmed fix shipped as commit `<SHA>`." (FR-005, SC-003)

### Mailbox reply (required for any outcome that ships code)

- [X] T033 [US5] If T027 OR T029 ran: write `Mailbox/2026-04-19_to_FSBarV1_<slug>.md` announcing the outcome, the new `HighBar.Client` version, any API-surface change (e.g., removal of `INTERNAL_ORDER`), and — for outcome (a) — the dispatch-convention fix summary. (FR-007, FR-014)

**Checkpoint**: Branch is in one terminal state — (a) code-shipped, (b) docs-only + optional FR-014 cleanup with a 036 scope seed in §12, or (c) docs-only recommending an architectural pivot.

---

## Phase 8: Polish & Cross-Cutting Concerns

**Purpose**: Cross-validate the deliverable against its contract before PR.

- [X] T034 Walk `specs/035-research-dispatch-paths/contracts/findings.contract.md` top-to-bottom and tick each `C-*` item against `specs/035-research-dispatch-paths/findings.md`. Any unchecked box is a blocker — loop back to the relevant US task.
- [X] T035 [P] Verify every file:line citation in `findings.md` resolves at the pinned SHAs — spot-check at least 5 Recoil citations and 3 Circuit citations using the commands in `specs/035-research-dispatch-paths/quickstart.md` §2.
- [X] T036 [P] Verify commit-message convention: all commits on this branch use `docs:` (or `fix:` for outcome-(a) code commits, per FR-010) — run `git log --format=%s master..HEAD | grep -vE '^(docs|fix|test|build):'` expecting no output.
- [X] T037 If outcome is (b) or (c): verify `git diff master..035-research-dispatch-paths -- . ':(exclude)specs/035-research-dispatch-paths/' ':(exclude)Mailbox/'` is empty OR contains only the FR-014 cleanup files. (SC-004)
- [X] T038 Delete the scratch `specs/035-research-dispatch-paths/.shas.txt` (its contents are now baked into `findings.md` top matter).

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies — start immediately. T002 and T003 run in parallel with T001; T004 depends on T001–T003.
- **Foundational (Phase 2)**: Depends on Setup. T005/T006/T007 can run in parallel (three different excerpts into three different sections).
- **User Story 1 (Phase 3)**: Depends on Phase 2. T008–T012 can run in parallel (five different subsections). T013 depends on whichever of T008–T012 surfaced disagreement. T014 is independent of T008–T013. T015 depends on T008–T014.
- **User Story 2 (Phase 4)**: Depends on Phase 2. T016 → T017 → T018 sequential (wrapper layers). T019 depends on T018 and on `proxy/src/deserialize.c` (read-only). T020 gated on T019's evaluation.
- **User Story 3 (Phase 5)**: Depends on Phase 2. T021 → T022 → T023 sequential.
- **User Story 4 (Phase 6)**: Depends on Phase 1 only (does not need the T005–T007 traces). Can run in parallel with US1–US3.
- **User Story 5 (Phase 7)**: FR-014 cleanup (T026–T028) depends on Phase 2 + §9 being writable; can run after US1 starts. Outcome-(a) fix (T029–T032) depends on US1 and US2 producing a confirmed live probe. T033 depends on T027 or T029.
- **Polish (Phase 8)**: Depends on all applicable stories.

### Within Each User Story

- Research tasks that target different `findings.md` sections are parallelizable ([P]).
- Tasks that write into the same section are sequential.
- Outcome-(a) code path: fix (T029) must precede regression test authoring (T030); regression test must demonstrate pre-fix failure before T029 is committed.

### Parallel Opportunities

- T002, T003 run in parallel with T001.
- T005, T006, T007 run in parallel (different sections of `findings.md`).
- T008, T009, T010, T011, T012 run in parallel (five §6 subsections).
- T024, T025 run in parallel.
- US3 and US4 can proceed in parallel with US1 and US2.

---

## Parallel Example: User Story 1 hypothesis verdicts

```bash
# Launch all five hypothesis verdicts in parallel (each writes a distinct §6.x subsection):
Task: "Write §6.1 commandData layout verdict"        # T008
Task: "Write §6.2 seat-kind / team-ownership verdict" # T009
Task: "Write §6.3 BuildPosition.Y verdict"            # T010
Task: "Write §6.4 CommandOptions bitfield verdict"    # T011
Task: "Write §6.5 commandId scheme verdict"           # T012
```

---

## Implementation Strategy

### MVP First (US1 only)

1. Phase 1 Setup (T001–T004).
2. Phase 2 Foundational (T005–T007).
3. Phase 3 US1 (T008–T015).
4. **STOP and VALIDATE**: Is the root-cause answer in §6 + §12? If yes, this alone satisfies the feature's primary deliverable (SC-001, SC-002) and the branch can close as docs-only (outcome b) even without US2–US4.

### Incremental Delivery

1. Setup + Foundational → both dispatch traces and `RawCommand` in place.
2. US1 → §6 verdicts + §7 prior attempts + §1/§12 outcome — **primary deliverable landed**.
3. US2 → Circuit reference + §8 divergence — strengthens outcome (a) viability.
4. US3 → Lua/C join-point — enables outcome (c) if divergence is lossy.
5. US4 → Recent-changes sweep — rules out engine regression.
6. US5 → FR-014 cleanup always; outcome (a) fix iff a live probe confirmed.
7. Phase 8 Polish → contract walkthrough + citation spot-check + diff audit.

### Time Budget (SC-005)

2 developer-days wall-time total. If Phase 3 + Phase 4 exhaust the budget, close as outcome (b) with whatever §6 verdicts are in hand and file a 036 scope seed — per research.md Decision 8.

---

## Notes

- [P] tasks = different `findings.md` sections or independent research threads — no file contention.
- [Story] label maps task to the user story it serves (US1–US5).
- Every citation must include file:line at the pinned Recoil / Circuit SHAs (contract C-QUAL-1).
- Live probes (T013, T030) reuse `./tests/run-all.sh --category persistent` and the existing session-dir convention under `/tmp/highbar-session-*/`.
- Commit after each task or logical group using `docs:` (or `fix:` for outcome-(a) code commits).
- Stop at any checkpoint to close the branch as a valid terminal outcome.
