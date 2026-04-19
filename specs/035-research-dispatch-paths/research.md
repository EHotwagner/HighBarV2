# Phase 0 Research: Dispatch-Path Investigation Methodology

**Feature**: 035-research-dispatch-paths
**Date**: 2026-04-19
**Purpose**: Resolve methodology NEEDS CLARIFICATIONs before writing `findings.md`. This document records the decisions that shape how the research is conducted, *not* the research output itself. The output lives in `findings.md` (produced during `/speckit.implement`).

---

## Decision 1 — Authoritative Recoil source revision

**Decision**: Pin every Recoil file:line citation to the `2025.06.19` tag at `https://github.com/beyond-all-reason/RecoilEngine`. Record the resolved commit SHA at the top of `findings.md`. `master` is used only for "is this still present upstream?" footnotes.

**Rationale**: The shipping binary on this machine is `spring-headless 2025.06.19` (see CLAUDE.md). Citing any other revision risks reading code that isn't running. Spec clarification Q1 confirmed this.

**Alternatives considered**:
- *Cite `master` for ergonomics*: rejected — drift between tag and master has already bitten this project once (see feature 029).
- *Cite whatever commit is HEAD on day of writing*: rejected — non-reproducible.

**Action**: On first read, `git ls-remote --tags https://github.com/beyond-all-reason/RecoilEngine 2025.06.19` to resolve the tag to a SHA; record it at `findings.md` top.

---

## Decision 2 — Source acquisition method

**Decision**: Read Recoil and Circuit source via `gh` CLI / raw GitHub URL fetches at the pinned SHA. Do **not** clone the full Recoil tree (~hundreds of MB of C++ unrelated to AI dispatch).

**Rationale**: The call graph is scoped to `SSkirmishAICallbackImpl.cpp`, `SkirmishAIWrapper.cpp`, `AICallback.cpp`, `CommandAI/*`, `NETMSG_AICOMMAND*` handlers, and the `RawCommand` / `Command` definitions. A targeted fetch is faster and keeps the repo small.

**Alternatives considered**:
- *Full clone*: rejected — slow, and `find`-style exploration in a huge tree wastes context.
- *Read only from BAR install's compiled artifacts*: rejected — no source there.

**Action**: Use `WebFetch` with raw.githubusercontent.com URLs at the resolved SHA. Cache quoted excerpts in-line in `findings.md`.

---

## Decision 3 — Circuit AI source & BAR fork check

**Decision**: Read canonical upstream `rlcevg/CircuitAI`. Cross-check the binary actually installed under `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/AI/Skirmish/CircuitAI/` — if the AIInfo.lua or the `.so` version string indicates a BAR fork, re-pivot to the `beyond-all-reason` org fork (or whichever matches). Record the resolved Circuit SHA at `findings.md` top.

**Rationale**: Spec edge case: BAR may ship a modified Circuit. The research must cite whichever binary is actually loaded.

**Alternatives considered**:
- *Read only upstream*: rejected — could miss BAR-specific patches.
- *Read only the compiled `.so`*: rejected — no source there; disassembly is not a source citation.

**Action**: Inspect `AIInfo.lua` + any README in the shipped CircuitAI dir on first read. If ambiguous, `strings` the `.so` for version markers.

---

## Decision 4 — BARb Lua source access

**Decision**: Locate BARb inside the BAR rapid pool under `~/.local/state/Beyond All Reason/packages/`. Game packages are zip-like (`.sdz`) or rapid-pool `.sdp`. Extract with `unzip` (sdz) or the rapid pool index (sdp). If BARb is only reachable as a rapid archive, extract only the files under `LuaAI/BARb/` (or equivalent) for quotation.

**Fallback**: If BARb is not extractable, cite any other Lua AI or Lua widget that issues `Spring.GiveOrderToUnit` build orders (e.g., the Chobby UI "build mode" widget, or a stock Spring Lua AI from the engine tree). Clearly flag the substitution in `findings.md`. SC-006 allows a negative BARb result if documented.

**Rationale**: US3 and SC-006 require at least one verbatim Lua citation. The Lua path is P2, so a substitution is acceptable provided the citation still demonstrates `Spring.GiveOrderToUnit`'s join point with the C path inside the engine.

**Action**: First read — `ls ~/.local/state/Beyond\ All\ Reason/packages/ | grep -i bar` and follow the rapid pool layout.

---

## Decision 5 — Live probe protocol (FR-015, outcome (a) gate)

**Decision**: A "live probe" is a one-variant run of the trainer against `spring-headless 2025.06.19` on this machine, where:
1. A single field in the proxy dispatch is changed (or a new callback is chosen).
2. The run uses the existing persistent-test harness under `tests/Persistent/` or a minimal bespoke harness.
3. The success criterion is an **engine-observable effect** — nanoframe in `engine.infolog`, unit position change, economy delta — not `rc=0`.
4. The relevant `engine.infolog` line is quoted verbatim into `findings.md` next to the source reading and (if applicable) the older 033/034 empirical verdict.

**Rationale**: FR-015 requires a fresh live run to break ties between source reading and older empirical verdicts. Per-clarification Q5.

**Alternatives considered**:
- *Trust source reading alone*: rejected by FR-015.
- *Trust 033/034 empirical alone*: rejected — 3 weeks old, harness may have changed.

**Action**: Reuse `tests/check-prerequisites.sh` and `./tests/run-all.sh --category persistent` machinery. Each probe is at most one file, ≤30 LOC, revertable if unsuccessful.

---

## Decision 6 — Ship-the-fix-on-this-branch criteria (outcome (a))

**Decision**: The fix ships on this branch iff *all* of the following hold:
- A live probe produces an engine-observable effect (per Decision 5).
- The effect is reproducible across two consecutive runs.
- The fix delta is ≤ 30 LOC in the proxy (+ optionally FR-014 cleanup in `Commands.fs`).
- A live-engine regression test is added that fails pre-fix and passes post-fix (both demonstrated in the commit series, per SC-004).
- `HighBar.Client` patch version is bumped.
- A mailbox reply under `Mailbox/2026-04-19_to_FSBarV1_*.md` announces the outcome, the new client version, and any API-surface change (e.g., `INTERNAL_ORDER` removal per FR-014).

If any condition fails, the branch terminates in outcome (b) or (c) and the fix does not ship on 035 — a 036 feature is seeded from the findings document.

**Rationale**: SC-003, SC-004, FR-007. Ensures the "ship the fix" path does not devolve into a partially-validated commit.

---

## Decision 7 — INTERNAL_ORDER hygiene gate (FR-013, FR-014)

**Decision**: FR-013's resolution is read from Recoil source **first** (the `UnitCommandOptions` enum in the 2025.06.19 source tree — not the vendored header in `proxy/include/AI/`). If bit-3 in that enum is `SHIFT_KEY` (or any flag that is not "internal AI order"), the FR-014 cleanup ships regardless of outcome (a)/(b)/(c):

- Remove `INTERNAL_ORDER = 8u` from `clients/fsharp/src/Commands.fs`.
- Default every unit-command builder to `Options = 0u`.
- Bump `HighBar.Client` patch.
- Note the removal in the mailbox reply.

**Rationale**: Per spec clarification Q4 and FR-014. The constant's name is a correctness trap for every future caller; its empirical harmlessness (feature 033) does not justify keeping a mis-named flag.

**Alternatives considered**:
- *Keep the constant, add a comment*: rejected — the name is the trap, not just the value.
- *Wait for 036*: rejected — FR-014 explicitly says "regardless of whether any dispatch-convention fix lands".

---

## Decision 8 — Scope discipline & time budget

**Decision**: SC-005 caps this branch at 2 developer-days wall time. If exhausted before a firm outcome:
- Write `findings.md` with whatever verdicts are confirmed and mark the rest **inconclusive — out of time**.
- File a mailbox reply explaining the state.
- Terminate as outcome (b) or (c).

**Rationale**: Research branches drift without a hard stop. The 034 negative result is already actionable — "nothing new" plus a clean state beats a week of rabbit-holing.

---

## Open NEEDS CLARIFICATION tracker

None at time of plan. Decisions 1–8 cover all methodology choices called out by the spec's FRs and clarifications.
