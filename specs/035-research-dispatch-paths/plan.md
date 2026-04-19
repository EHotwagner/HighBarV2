# Implementation Plan: Research Lua/Recoil/Circuit/BARb Command Dispatch Paths

**Branch**: `035-research-dispatch-paths` | **Date**: 2026-04-19 | **Spec**: [spec.md](./spec.md)
**Input**: Feature specification from `/specs/035-research-dispatch-paths/spec.md`

## Summary

Close the 034 negative-result investigation by reading the Recoil engine source (tag `2025.06.19`), a working C AI (Circuit), and a working Lua AI (BARb) to determine why `Engine_handleCommand(aiId, -1, -1, COMMAND_UNIT_BUILD, &SBuildUnitCommand)` returns `rc=0` with no engine effect. Deliverable is `findings.md` citing file:line at every step, with a verdict for each of the five 034-mailbox hypotheses. Probes and code changes are permitted: if a probe confirms a working dispatch convention, the fix ships on this branch (proxy change + live regression test + `HighBar.Client` version bump + mailbox reply), terminating outcome (a). Otherwise the branch ships docs-only plus any FR-014 `INTERNAL_ORDER` cleanup (outcome (b) or (c)).

## Technical Context

**Language/Version**: Research reads C11 (Recoil engine, proxy), C++ (engine internals, Circuit wrapper classes), Lua (BARb, `Spring.GiveOrderToUnit`), F# / .NET 10.0 (HighBar.Client for any probe). Any code changes are scoped to the C11 proxy (`proxy/src/deserialize.c`) and optionally F# client (`clients/fsharp/src/Commands.fs` for FR-014).
**Primary Dependencies**: Recoil engine source at tag `2025.06.19` (GitHub `beyond-all-reason/RecoilEngine`); Circuit AI source (`rlcevg/CircuitAI` — resolve actual shipping SHA from `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/AI/Skirmish/CircuitAI/`); BARb Lua source (extract from `.sdz`/`.sdp` under `~/.local/state/Beyond All Reason/packages/`); protobuf-c, Google.Protobuf 3.28, xUnit 2.9.x for any probe.
**Storage**: Filesystem only — markdown under `specs/035-research-dispatch-paths/`, optional mailbox reply under `Mailbox/`, Unix-domain sockets and `/tmp` session dirs if a live probe runs.
**Testing**: If outcome (a), a live-engine regression test under `tests/Persistent/` or `tests/Integration/` that asserts engine-observable effect (nanoframe appearing, unit moving, etc.) — not just `rc=0`. xUnit 2.9.x on spring-headless 2025.06.19. No new tests if outcome (b)/(c).
**Target Platform**: Linux (spring-headless 2025.06.19, per-machine BAR install).
**Project Type**: Research + optional single-file proxy fix. Documentation-dominant.
**Performance Goals**: N/A (research); any shipped fix inherits proxy hot-path constraints from the constitution (< 1 ms per-frame overhead, arena allocation).
**Constraints**:
- FR-006: every Recoil citation pinned to `2025.06.19` tag SHA, recorded at top of `findings.md`. Circuit repo SHA + BARb archive checksum likewise.
- FR-008: self-contained — no "see Circuit source" hand-waves; quote inline.
- FR-015: when source and prior empirical verdict disagree, re-run the narrow case live on `spring-headless 2025.06.19`; fresh infolog is authoritative and quoted verbatim.
- FR-010: all commits use `docs:` prefix unless outcome (a) ships a proxy/client fix (then `fix:` per Conventional Commits is acceptable for those commits).
- SC-005: 2 developer-days wall-time budget.
**Scale/Scope**: Single deliverable `findings.md` (estimated 800–1500 lines with quoted code blocks); optional `≤ 30 LOC` proxy diff; optional `INTERNAL_ORDER` removal (~5 LOC in `Commands.fs`); optional single live regression test.

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Assessment |
|-----------|-----------|
| I. Zero Engine Modifications | ✅ Research only reads engine source; any fix is proxy-side (`SSkirmishAICallback` surface), no engine patches. If FR-005(b) concludes the surface is insufficient, the recommendation is to pivot architecture, still without modifying the engine. |
| II. Binary Protocol First | ✅ No protocol change. Any fix corrects how the existing proxy dispatches a protobuf-delivered command to the engine callback. |
| III. Correctness Over Cleverness | ✅ Core goal — replace speculative probing with a source-cited 1:1 mapping between protobuf command and the exact Recoil callback/struct that takes effect. |
| IV. Test at the Boundary | ✅ If outcome (a), the accompanying regression test asserts engine-observable effect (nanoframe appears), not rc=0 — the true dispatch boundary. |
| V. Latency Budget Discipline | ✅ No hot-path impact. A correct callback call replaces a silently-dropped one; no additional allocation, no extra syscalls. |
| VI. Language-Agnostic by Default | ✅ No `.proto` change. The fix is at the C proxy's engine-callback boundary, below the schema. |
| VII. Explicit Over Implicit | ✅ The whole point of the findings document is to make the dispatch convention explicit and cited. |

**Result**: PASS. No violations, no Complexity Tracking entries.

## Project Structure

### Documentation (this feature)

```text
specs/035-research-dispatch-paths/
├── plan.md              # This file
├── spec.md              # Feature specification (already present)
├── research.md          # Phase 0 — methodology & source acquisition
├── data-model.md        # Phase 1 — entity shape of findings.md (FRs → sections map)
├── quickstart.md        # Phase 1 — how to reproduce the research / verify citations
├── contracts/
│   └── findings.contract.md  # The structural contract findings.md MUST satisfy
├── findings.md          # THE DELIVERABLE (produced during /speckit.implement, not /speckit.plan)
└── tasks.md             # Phase 2 output (/speckit.tasks)
```

### Source Code (repository root)

Research-dominant feature. Code touched only in outcome (a) or FR-014 cleanup:

```text
proxy/src/deserialize.c                   # (outcome a only) ≤30 LOC fix in COMMAND_BUILD_UNIT (and siblings)
clients/fsharp/src/Commands.fs            # (FR-014 only) remove INTERNAL_ORDER = 8u, default Options = 0u
clients/fsharp/src/HighBar.Client.fsproj  # (FR-014 or outcome a) version bump
tests/Persistent/ or tests/Integration/   # (outcome a only) one live regression test asserting engine-observable effect
Mailbox/2026-04-19_*.md                   # Reply to FSBarV1 summarizing outcome + client version
```

**Structure Decision**: Research-first branch. Default path is documentation-only under `specs/035-research-dispatch-paths/`. Code paths listed above are gated on outcomes (a) and FR-014 triggering; they are enumerated here so `/speckit.tasks` and `/speckit.implement` know the full reachable set, but no file is modified during `/speckit.plan`.

## Complexity Tracking

> No Constitution violations — table intentionally empty.

| Violation | Why Needed | Simpler Alternative Rejected Because |
|-----------|------------|-------------------------------------|
| (none) | — | — |
