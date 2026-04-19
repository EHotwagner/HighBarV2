# Feature Specification: Research Lua/Recoil/Circuit/BARb Command Dispatch Paths

**Feature Branch**: `035-research-dispatch-paths`
**Created**: 2026-04-19
**Status**: Draft
**Input**: User description: "do extensive research how the lua/recoil interface handles this. also how circuit/barb does it. https://github.com/beyond-all-reason/RecoilEngine/tree/master"

## Background

Feature 034 exhausted the four obvious dispatch-convention hypotheses (`Engine_handleCommand` with `toId ∈ {-1, unit_id, team_id}`, and `Engine_executeCommand` with a per-topic struct) and none produced an engine-observable build effect — all returned `rc=0` with no nanoframe, except `Engine_executeCommand` which crashed the engine. The 034 mailbox reply (`Mailbox/2026-04-19_to_FSBarV1_command-execute-negative-result.md`) closed that branch as a negative result and enumerated five ranked follow-up hypotheses but did not pick one.

This feature is the **evidence-gathering step** that must precede any further code-side experiment. Rather than keep probing blind, we read how the engine actually routes per-unit AI commands (Recoil source) and how two independently-working AIs drive the same engine: **Circuit** (C++ Skirmish AI using the same `SSkirmishAICallback` surface HighBarV2 uses) and **BARb** (Lua AI using `Spring.GiveOrderToUnit`, running live on the other team during our 034 diag and successfully issuing orders). The diff between what those two do and what HighBarV2 does is the root cause.

Preliminary evidence gathered at spec time (Circuit source, `rlcevg/CircuitAI` + `spring/spring` master) already suggests the root cause: **Circuit never calls `Engine_handleCommand` with `COMMAND_UNIT_BUILD` + `SBuildUnitCommand`; it calls `Engine_executeCommand(aiId, unitId, groupId=-1, RawCommand*)` where `RawCommand.id[0] = -buildUnitDefId` and `params = {x, y, z, facing}`.** Our 034 variant C was on the right function but with the wrong struct layout (we passed `SBuildUnitCommand*` instead of `RawCommand*`), which is why it crashed. This spec requires that hypothesis to be confirmed by reading the Recoil engine side of the call (`Engine_executeCommand`'s implementation and the `RawCommand` struct definition) before a follow-up feature proposes a code change.

The primary deliverable is a written finding — a single markdown document in `specs/035-research-dispatch-paths/findings.md` — that either (a) names the concrete missing piece (per-field, with Recoil source citation), or (b) proves that the `SSkirmishAICallback` surface is insufficient and we need a different architecture.

**Scope is "research + (optional) fix"**: if the research identifies a working dispatch convention and a live probe confirms the resulting build/move/stop/repair orders take effect, the fix ships on this branch (same commit series as the findings document) and **no follow-up 036 feature is filed**. If the research runs out of hypotheses or the probe does not confirm, the branch closes as docs-only and the findings document recommends a 036 scope. Either outcome is acceptable at merge time.

## Clarifications

### Session 2026-04-19

- Q: Which Recoil source tree is authoritative for file:line citations in the findings document? → A: Pin to the `2025.06.19` tag/release at `https://github.com/beyond-all-reason/RecoilEngine` (match the shipping `spring-headless` binary on this machine). Cross-reference master only for "is this still there upstream?" footnotes.
- Q: Should the findings document include an explicit "Prior attempts" section re-examining what features 017/033/034 ruled out, so 036 cannot re-propose already-falsified fixes? → A: Yes — add a dedicated FR. Findings MUST cite the commits (`dce4e42` commandId → -1, `357ab8e` INTERNAL_ORDER=8) and the empirical verdicts from feature 033 (Y and INTERNAL_ORDER both disproved) and feature 034's 4-variant probe. A 036 fix proposal may not revive an empirically-ruled-out hypothesis without new evidence.
- Q: May 035 run live-engine probes, and may it ship a fix if one lands? → A: Yes — probes are allowed freely. If the research identifies a working dispatch convention and a probe confirms it live, **the fix ships on this branch and 036 is not filed.** Scope expands from "docs-only" to "research + (optional) fix". FR-007 and SC-004 updated accordingly; if no fix lands within the time budget, the branch closes as docs-only with a findings document and a 036-scope recommendation (prior behaviour).
- Q: If the findings confirm bit-3 (`INTERNAL_ORDER = 8u` in `Commands.fs`) is actually `SHIFT_KEY` in Recoil's `UnitCommandOptions` enum, what ships? → A: Remove `INTERNAL_ORDER = 8u` from `clients/fsharp/src/Commands.fs` and default all unit-command builders to `Options = 0u`. Ships alongside any dispatch-convention fix that lands in 035; if no other fix lands, still ships as a standalone hygiene commit with a client version bump. 033 already proved the flag value doesn't affect the current failure, but carrying a misleadingly-named flag (that actually means SHIFT_KEY — queue-append) is a correctness trap for every future caller.
- Q: When Recoil source and a prior empirical verdict (from 033 or 034) disagree, which wins for the findings document's per-hypothesis verdict? → A: Re-run the narrow case live on this branch. Disagreement triggers a single fresh probe of the contested field against the current `spring-headless 2025.06.19` binary; the fresh infolog line is quoted in the findings and is the authoritative verdict. Source-reading alone and 3-week-old empirical alone are both unreliable; a confirming live run is.

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Engineer gets a root-cause finding for the 034 silent-drop (Priority: P1)

A HighBarV2 or FSBarV1 engineer reads the deliverable and, in under 15 minutes, can state with confidence *why* `Engine_handleCommand(aiId, -1, -1, COMMAND_UNIT_BUILD, &SBuildUnitCommand)` returns rc=0 but produces no engine effect, and what the correct call is. The finding cites the actual Recoil source path (file:line) that accepts the call, the branch inside that function that silently drops it (or the function that would have been called had the dispatch gone through the working path), and the working call signature quoted verbatim from a reference AI.

**Why this priority**: Without this, every follow-up fix attempt remains speculative. Feature 034's Decision 4 fallback explicitly required this before more code-side experiments.

**Independent Test**: A reviewer who did not write the research can read the deliverable alone (no Recoil clone, no Circuit clone) and reproduce the dispatch path from the quoted code. The reviewer can answer: "If I call `Engine_executeCommand` with arguments X (or `Engine_handleCommand` with arguments Y), will the engine build the unit?" — correctly — without re-reading source.

**Acceptance Scenarios**:

1. **Given** the research deliverable is complete, **When** an engineer reads it cold, **Then** they can name the specific Recoil source function that HighBarV2's current dispatch lands in, and name the Recoil source function the dispatch *should* land in.
2. **Given** the 034 mailbox's five-hypothesis list (`commandData` layout, seat-kind/ownership, `BuildPosition.Y` snap, options bitfield, non-negative commandId), **When** the research is complete, **Then** each hypothesis is marked confirmed / ruled out / inconclusive with a source citation.
3. **Given** the research concludes a specific hypothesis is the cause, **When** a follow-up feature is proposed, **Then** the research supplies a concrete proxy-side code change (≤ 30 LOC) that would validate it live.

---

### User Story 2 - Captured known-good C dispatch signature from a working AI (Priority: P1)

The deliverable includes the exact dispatch call site from Circuit AI's build-order path, quoted verbatim with file:line, so HighBarV2 has a reference implementation to compare against field-by-field. The quote MUST reach all the way to the raw `SSkirmishAICallback` function-pointer call (not stop at a wrapper-class facade).

**Why this priority**: Circuit uses the same `SSkirmishAICallback` surface HighBarV2 uses and successfully builds units in BAR matches. Any divergence in its dispatch call vs ours is high-signal. This is the single most cost-effective diff we can capture.

**Independent Test**: Open the 034 proxy dispatch code (`proxy/src/deserialize.c:51` — the `COMMAND_BUILD_UNIT` case) side-by-side with the Circuit citation; the differences across `{callback entry point, command struct layout, options bitfield value, pre-dispatch setup}` are enumerable in one list.

**Acceptance Scenarios**:

1. **Given** the Circuit build-order dispatch is quoted in the deliverable, **When** placed beside HighBarV2's dispatch, **Then** every divergent field is listed with a proposed HighBarV2 change (specific struct field, specific callback field, specific value).
2. **Given** Circuit calls through a wrapper (e.g., `springai::Unit::Build` → `CAIAICallback::GiveOrder` → `Engine_executeCommand`), **When** the wrapper layers are examined, **Then** every layer is quoted with file:line so a reader can verify the final raw C call.
3. **Given** the `options` bitfield is suspected to be mis-interpreted (FSBarV1 sends `INTERNAL_ORDER = 8`, but Recoil's `UnitCommandOptions.SHIFT_KEY` is also bit 3), **When** the deliverable is read, **Then** the correct `options` value for an "execute now" build order is stated with Recoil source citation.

---

### User Story 3 - Lua vs C-callback divergence documented (Priority: P2)

The deliverable explains whether the Lua path (`Spring.GiveOrderToUnit`, which BARb uses and which works live on the other team during our 034 diag) reaches the same engine internal code path as the C callback path. It names both entry points and identifies their join point (or divergence).

**Why this priority**: If BARb's Lua `GiveOrderToUnit` takes a fundamentally different internal code path than the C `Engine_executeCommand` surface, even a correct Circuit-style dispatch may not help us, and we'd need a Lua shim. Lower priority than US1/US2 because the preliminary Circuit evidence already suggests the C surface is sufficient — this story mostly confirms that.

**Independent Test**: The deliverable's "Lua path vs C path" section lists both call chains from entry to order-enqueue, with file:line at every step, so a reader can visually spot whether they converge on a common function (likely `CCommandAI::GiveCommand` or `CSelectedUnitsAI::GiveCommand`).

**Acceptance Scenarios**:

1. **Given** the research is complete, **When** a reader asks "does Lua and C dispatch eventually land in the same function?", **Then** the deliverable answers with a quoted join point or a "no — they diverge at X" statement.
2. **Given** they converge, **When** a follow-up feature is proposed, **Then** the recommendation stays on the C callback surface. **Given** they diverge at a point where the C surface is demonstrably lossy, **When** the recommendation is written, **Then** it pivots to a Lua-shim architecture with a scope estimate.

---

### User Story 4 - Recent Recoil-side changes surveyed (Priority: P3)

The deliverable surveys recent (last ~18 months) commits to Recoil in the AI-dispatch, cheat-gate, and `NETMSG_AICOMMAND*` areas to rule out a regression or recent semantic change that broke what 033's mailbox claimed was working.

**Why this priority**: Lower — 033's original repro notes claim the trainer-driven path worked, so this is mostly defensive coverage to rule out "the engine changed underneath us" as the answer.

**Independent Test**: The deliverable's "Recent Recoil changes" section is either (a) a short bullet list of relevant commits with SHA + summary + "this is / isn't our problem" judgment, or (b) an explicit "no relevant changes found — searched <these paths>" statement.

**Acceptance Scenarios**:

1. **Given** the Recoil repo was searched for changes touching `SSkirmishAICallbackImpl.cpp`, `SkirmishAIWrapper.cpp`, `AICallback.cpp`, and `NETMSG_AICOMMAND*` handling, **When** the research is done, **Then** either relevant changes are cited or a negative result is stated with the paths searched.

---

### Edge Cases

- **Circuit uses a C++ wrapper (`springai::Unit::Build`), not raw `SSkirmishAICallback`**: the research MUST trace through the wrapper layer (`AI/Wrappers/LegacyCpp/AIAICallback.cpp`) and quote the raw callback call, not just the wrapper's public method.
- **BAR ships a fork of Circuit** with modifications to dispatch: the research checks both the canonical upstream (`rlcevg/CircuitAI` or `spring/CircuitAI`) and any `beyond-all-reason`-org fork, and cites whichever is the currently-shipping binary.
- **The Recoil source tree is large**: the research is scoped to the call graph originating from `Engine_executeCommand`'s and `Engine_handleCommand`'s function-pointer targets in `SSkirmishAICallbackImpl.cpp` — not a whole-engine tour.
- **BARb is packaged as a `.sdz` / `.sdp` archive**: the research includes unpacking steps (e.g., `unzip`, or the `packages/` cache layout) if needed so the Lua sources are readable.
- **Recoil source quotes become stale**: every quotation in the deliverable includes the commit SHA it was taken from so a future reader can diff forward.
- **A single candidate AI (Circuit) is insufficient evidence**: if Circuit's dispatch matches HighBarV2's and Circuit still works, the divergence is elsewhere — the research escalates to examining a second working C AI (e.g., KAIK, Shard, or AAI from the Spring tree).
- **`RawCommand` vs `Command` ambiguity**: Recoil has both a `Command` class (C++) and a `RawCommand` struct (C ABI). The research MUST name which one crosses the AI-plugin boundary, and quote its exact field layout from Recoil source (not from an out-of-tree Spring header).
- **Preliminary Circuit finding contradicts Recoil source**: if the engine-side read contradicts the Circuit finding cited in this spec's Background, the deliverable flags the conflict and defers to Recoil source.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The deliverable MUST trace the Recoil engine's handling of an AI per-unit command (build, move, stop, repair) from the `Engine_handleCommand` and `Engine_executeCommand` function-pointer entry points down to the moment an order is enqueued on a unit — with file-path and line-number citations at every step, for BOTH entry points.
- **FR-002**: The deliverable MUST quote the exact callback call site used by Circuit AI to issue a build order, with file:line, and list the values Circuit passes for every parameter (entry point, unitId/toId, groupId/commandId, struct pointer, struct contents including options) plus any pre-dispatch setup (cheat toggle, permission call, command-counter).
- **FR-003**: The deliverable MUST identify whether BARb's Lua `Spring.GiveOrderToUnit` path converges with or diverges from the C `Engine_executeCommand` path inside the engine, with file:line for the join (or divergence) point.
- **FR-004**: The deliverable MUST address each of the five hypotheses from the 034 mailbox reply (`commandData` layout for `Engine_executeCommand`; seat-kind / team-ownership gate; `BuildPosition.Y` ground-snap; CommandOptions bitfield; `commandId` scheme) and mark each confirmed / ruled out / inconclusive with Recoil source citation.
- **FR-005**: The deliverable MUST state a concrete next-step recommendation. If the research lands a confirmed fix within this branch's time budget, the recommendation collapses to "the fix shipped on this branch — see commit <SHA>". Otherwise the recommendation MUST be either (a) a ≤ 30-LOC proxy change specified field-by-field that should fix HighBarV2 based on evidence (feature 036 scope seed), or (b) a statement that the `SSkirmishAICallback` surface is insufficient and a Lua-shim architecture is needed, with an estimated scope.
- **FR-006**: The deliverable MUST pin every Recoil file:line citation to the `2025.06.19` tag/release commit (matching the shipping `spring-headless` binary on this machine) and record that commit SHA at the top of the document. Upstream `master` may be cross-referenced for drift-tracking footnotes, but MUST NOT be the primary citation. The Circuit repo SHA and the BARb / BAR game archive version checksum MUST also be recorded for reproducibility.
- **FR-007**: Live-engine probes and code changes (proxy, client, tests, schema) are **permitted** on this branch. If a probe confirms a working dispatch convention, the resulting fix ships on this branch and no 036 feature is filed. If no fix lands, the branch closes with only documentation artefacts under `specs/035-research-dispatch-paths/` and `Mailbox/`. Any shipped fix MUST be accompanied by (i) a live-engine regression test that asserts engine-observable effect (not just `rc=0`), (ii) a `HighBar.Client` version bump, and (iii) a mailbox reply to FSBarV1 announcing the fix and the new client version.
- **FR-008**: The deliverable MUST be written so a reviewer who has not read Recoil or Circuit source can follow the argument using only the quoted excerpts in the document. No "see Circuit source" hand-waves — the relevant lines are inlined.
- **FR-009**: If the research surfaces a conflict between Recoil header documentation (e.g., `SSkirmishAICallback.h` comments) and actual Recoil source behaviour, the deliverable MUST call out the conflict explicitly — header claims are not authoritative.
- **FR-015**: When Recoil source and a prior empirical verdict (from feature 033's Q4 Resolution or feature 034's probe matrix) disagree about the effect of a field, the deliverable MUST re-run the narrow case live on this branch against the current `spring-headless 2025.06.19` binary and treat the fresh infolog output as authoritative. The fresh probe's infolog line MUST be quoted verbatim in the findings document next to the source reading and the older empirical, so a reader can see the 3-way reconciliation. A prior verdict contradicted by source alone (with no fresh live run) is NOT sufficient grounds to reverse it.
- **FR-010**: Commits on this branch MUST use Conventional Commits prefixes. Research and documentation commits MUST use `docs:`. If outcome (a) ships a fix under FR-007, or FR-014 cleanup ships, those commits MAY use `fix:` (proxy/client code), `test:` (live regression test), or `build:` (version bump) as appropriate. Prefixes outside `{docs, fix, test, build}` MUST NOT appear on this branch.
- **FR-011**: If the research identifies that `Engine_executeCommand` with `RawCommand*` (the Circuit path) is the correct surface, the deliverable MUST quote the `RawCommand` struct definition from Recoil source (not an external Spring header), including field order, types, and the build-order encoding convention (`id[0] = -buildUnitDefId`).
- **FR-012**: The deliverable MUST contain a dedicated "Prior attempts" section summarizing what features 017, 033, and 034 tried and what each ruled out. At minimum it MUST cite:
  - Feature 017 commit `dce4e42` (squash-merge; `commandId = 0 → -1` / `COMMAND_ID_UNTRACKED` to avoid the `NETMSG_AICOMMAND_TRACKED` silent-drop path in GameServer).
  - Feature 017 commit `357ab8e` (adding the `INTERNAL_ORDER = 1 << 3 = 8` flag to all unit-command options in `clients/fsharp/src/Commands.fs`, originally rationalised as "so the engine treats them as programmatic AI orders").
  - Feature 033's empirical elimination (`specs/033-fix-scripting-dispatch/research.md` "Q4 Resolution"): `options = 0` and `BuildPosition.Y = 0` both still produce `engine_rc=0` with no nanoframe. **Neither INTERNAL_ORDER nor Y is the bug.**
  - Feature 034's 4-variant probe matrix (A/B/D → `rc=0` no effect; C → engine crash), as recorded in `Mailbox/2026-04-19_to_FSBarV1_command-execute-negative-result.md`.
  Each row carries the empirical verdict (ruled out / inconclusive / confirmed-but-insufficient) and a Recoil-source explanation of *why* that variant has the effect it has. **A 036 fix proposal MUST NOT revive a hypothesis this section marks "ruled out empirically" without supplying new evidence.**
- **FR-013**: The deliverable MUST explicitly resolve the `INTERNAL_ORDER (8)` vs `SHIFT_KEY (1 << 3 = 8)` bit-3 collision by quoting the Recoil `UnitCommandOptions` enum definition from the 2025.06.19 source (not the vendored header in `proxy/include/AI/`) and stating whether the HighBar-client-side `INTERNAL_ORDER = 8u` constant is safe, ambiguous, or actively harmful.
- **FR-014**: If FR-013 concludes that bit-3 in Recoil's `UnitCommandOptions` is `SHIFT_KEY` (or any flag meaningfully different from "internal AI order"), the branch MUST ship the following cleanup regardless of whether any dispatch-convention fix lands:
  - Remove the `INTERNAL_ORDER = 8u` literal from `clients/fsharp/src/Commands.fs`.
  - Default every unit-command builder (`MoveCommand`, `BuildCommand`, `PatrolCommand`, `AttackCommand`, `StopCommand`, `RepairCommand`, etc.) to `Options = 0u`.
  - Bump `HighBar.Client`'s patch version.
  - Note the rename/removal in the mailbox reply so FSBarV1 knows to re-review any call sites that referenced the constant by name.
  A 035 branch that ships FR-014's cleanup without a dispatch-convention fix is a valid terminal state (outcome (b) or (c) in SC-003).

### Key Entities

- **The 034 Probe Matrix**: the four dispatch-variant results from feature 034 (A/B/D return `rc=0` no effect; C crashes). Referenced throughout as the empirical starting point; the research explains each row's outcome via Recoil source.
- **The Canonical Dispatch Chain**: the call graph from a working AI's command-issue point down to the engine's order-enqueue function. Single source of truth the research produces.
- **The Divergence List**: field-by-field differences between HighBarV2's 033-shipped dispatch (`proxy/src/deserialize.c` `COMMAND_BUILD_UNIT` case) and the corresponding call in Circuit / BARb. Drives the next-step recommendation.
- **The Recoil `RawCommand` struct**: the on-the-wire C struct that crosses the AI-plugin ABI for `Engine_executeCommand`. Preliminary evidence (Circuit) suggests this, not `SBuildUnitCommand`, is what the engine expects. The research MUST quote its canonical definition.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: A reviewer reading only the deliverable (no source access) can correctly answer "what `Engine_handleCommand` or `Engine_executeCommand` arguments would make HighBarV2's external-scripting build command take effect?" within 15 minutes of first opening the document.
- **SC-002**: Every one of the five hypotheses carried forward from the 034 mailbox reply has a verdict (confirmed / ruled out / inconclusive) with a source citation — 5/5.
- **SC-003**: The branch terminates in exactly one of three outcomes: (a) a live-engine-confirmed fix shipped on this branch (regression test passes, client bumped, mailbox reply filed); (b) a findings document naming a ≤ 30-LOC fix scope for feature 036; (c) a findings document recommending an architectural pivot (e.g., Lua-shim) with scope estimate. Which outcome was reached MUST be stated in one sentence at the top of the findings document.
- **SC-004**: If the branch terminates in outcome (b) or (c) (no fix shipped), `git diff master..035-research-dispatch-paths -- . ':(exclude)specs/035-research-dispatch-paths/' ':(exclude)Mailbox/'` returns empty at merge time. If the branch terminates in outcome (a), any shipped code change MUST be covered by a new or extended live-engine test whose pre-fix failure and post-fix success are both demonstrated in the branch's commit series.
- **SC-005**: The work takes no more than 2 developer-days of wall time, ending in outcome (a), (b), or (c). Exceeding the budget means the branch should close at whatever state it has reached with a mailbox reply explaining the state, rather than continue.
- **SC-006**: The deliverable contains at least one verbatim quotation each from (a) Recoil engine source, (b) Circuit AI source, and (c) BARb Lua source (or a definitive "BARb source not accessible — here is why and what was used instead"). No summary-only claims.

## Assumptions

- The `2025.06.19` tag/release in the `beyond-all-reason/RecoilEngine` repo (or the corresponding SHA) is the canonical source of the engine binary shipping as `spring-headless 2025.06.19` on this machine, and every file:line citation in the findings document pins to that commit. `master` is referenced only in drift-tracking footnotes. If the shipped binary turns out to be built from a different branch/fork, the research pivots to that fork and notes the discrepancy.
- Circuit AI is the correct reference C AI. The canonical repo is `rlcevg/CircuitAI` (upstream) or `spring/CircuitAI` (older) — the research uses whichever matches the binary installed under `~/.local/state/Beyond All Reason/engine/.../AI/Skirmish/CircuitAI/`. If Circuit's dispatch path is itself broken for builds, the research falls back to KAIK or another C AI shipped in the Spring tree.
- BARb's Lua sources are accessible on this machine under `~/.local/state/Beyond All Reason/packages/` or extractable from a game archive (`.sdz` / `.sdp`). If BARb is only shipped as a compiled Lua bytecode blob, the research falls back to any other Lua AI or a Lua UI widget that issues `Spring.GiveOrderToUnit` build orders.
- The Recoil header documentation in `proxy/include/AI/SSkirmishAICallback.h` may be inaccurate or out of date with respect to actual Recoil behaviour. The research treats engine source as authoritative, not the header.
- The 034 branch's probe findings (A/B/D → rc=0 no effect; C → crash) are reproducible and not artefacts of the headless-render pipeline, the Hub GUI state, or the BARbarIAn AI running on the other team. The research does not re-run the probe; it uses the 034 findings as given.
- No changes to Recoil's AI command dispatch are landing upstream during the 2-day research window that would invalidate the findings.
- The preliminary Circuit finding cited in this spec's Background (`Engine_executeCommand` with `RawCommand*` where `id[0] = -buildUnitDefId`) is a *hypothesis*, not a ratified conclusion. The deliverable MUST independently verify it against Recoil engine source before recommending a 036 fix.
