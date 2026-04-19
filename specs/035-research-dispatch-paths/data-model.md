# Phase 1 Data Model: findings.md Structural Shape

**Feature**: 035-research-dispatch-paths
**Purpose**: This is a documentation-dominant feature — there is no runtime data model. The "data model" here is the required structural shape of the `findings.md` deliverable, expressed as sections and their required content, with the mapping from each Functional Requirement in spec.md to the section that satisfies it.

---

## Entity: `findings.md`

**Type**: Single markdown document under `specs/035-research-dispatch-paths/findings.md`.

**Required top matter** (before the first `##` heading):

| Field | Source | Example |
|-------|--------|---------|
| `Outcome` (one sentence) | SC-003 | "This branch terminates in outcome (a): live-engine-confirmed fix shipped as commit `abc1234`." |
| `Recoil SHA` | FR-006 | `2025.06.19` → resolved 40-char SHA |
| `Circuit SHA` | FR-006 | Resolved SHA of shipping CircuitAI |
| `BARb archive version + sha256` | FR-006 | e.g., `BAR-chobby_2026.04.01.sdz sha256=…` |
| `Author / date` | convention | `EHotwagner / 2026-04-19` |

---

## Required sections (in order)

Each section lists which FRs it satisfies. Every FR in spec.md MUST appear at least once in this column.

### 1. Outcome summary (1 paragraph)
- **Satisfies**: SC-001, SC-003
- **Content**: Which of (a)/(b)/(c). If (a), commit SHA of the fix. If (b), the ≤30-LOC scope seed for 036. If (c), the architectural pivot and scope estimate.

### 2. Recoil dispatch trace — `Engine_handleCommand` path
- **Satisfies**: FR-001, FR-008
- **Content**: File:line chain from `Engine_handleCommand` function-pointer target → … → order enqueue or silent-drop branch. Every step quoted inline.

### 3. Recoil dispatch trace — `Engine_executeCommand` path
- **Satisfies**: FR-001, FR-008, FR-011
- **Content**: Same, for `Engine_executeCommand`. Includes the `RawCommand` struct definition quoted verbatim from Recoil source (field order, types, build-order encoding `id[0] = -buildUnitDefId`).

### 4. Lua path (`Spring.GiveOrderToUnit`) vs C path join/divergence
- **Satisfies**: FR-003, SC-006 (Lua citation)
- **Content**: Call chain from Lua `GiveOrderToUnit` → engine internals; explicit join or divergence point with file:line; BARb (or fallback) verbatim Lua quote.

### 5. Circuit AI reference dispatch
- **Satisfies**: FR-002, SC-006 (Circuit citation)
- **Content**: Quote Circuit's `Engine_executeCommand` call site with all wrapper layers (`springai::Unit::Build` → `CAIAICallback::GiveOrder` → raw callback). List every parameter value it passes. Any pre-dispatch setup (cheat, counter).

### 6. Hypothesis verdicts (one subsection per hypothesis)
- **Satisfies**: FR-004, FR-009, FR-015, SC-002
- **Content**: Five subsections, one per 034 mailbox hypothesis:
  1. `commandData` layout for `Engine_executeCommand`
  2. Seat-kind / team-ownership gate
  3. `BuildPosition.Y` ground-snap
  4. CommandOptions bitfield
  5. `commandId` scheme
  Each: verdict (confirmed / ruled out / inconclusive), Recoil source citation, and — when source conflicts with prior 033/034 empirical — the fresh probe's `engine.infolog` line quoted verbatim (FR-015).

### 7. Prior attempts (017 / 033 / 034)
- **Satisfies**: FR-012
- **Content**: Table of prior rule-outs with commit SHA + empirical verdict + Recoil-source explanation of *why* each variant had its observed effect. Explicit "a 036 fix proposal MUST NOT revive an empirically-ruled-out hypothesis without new evidence."

### 8. Divergence list: HighBarV2 vs Circuit
- **Satisfies**: FR-002 (comparative), drives next-step
- **Content**: Field-by-field table — every divergent `{callback entry, struct, value, pre-setup}` between `proxy/src/deserialize.c` (COMMAND_BUILD_UNIT) and Circuit's dispatch.

### 9. `INTERNAL_ORDER` vs `SHIFT_KEY` resolution
- **Satisfies**: FR-013, FR-014
- **Content**: Recoil `UnitCommandOptions` enum quoted from 2025.06.19 source. Verdict on whether `INTERNAL_ORDER = 8u` in `Commands.fs` is safe / ambiguous / harmful. If not safe, FR-014 cleanup commit SHA cited here.

### 10. Recent Recoil changes survey (last ~18 months)
- **Satisfies**: FR-004(recent), US4 acceptance
- **Content**: Bullet list of relevant commits in `SSkirmishAICallbackImpl.cpp`, `SkirmishAIWrapper.cpp`, `AICallback.cpp`, `NETMSG_AICOMMAND*`; OR an explicit negative result naming the paths searched.

### 11. Header-vs-source conflicts (if any)
- **Satisfies**: FR-009
- **Content**: Any place the vendored `proxy/include/AI/SSkirmishAICallback.h` comments disagree with the actual engine source behaviour.

### 12. Next-step recommendation
- **Satisfies**: FR-005
- **Content**: If outcome (a): "shipped — see commit". If (b): field-by-field ≤30-LOC proxy diff specifying what to change. If (c): Lua-shim architecture with scope estimate.

---

## FR coverage map (audit)

| FR | Satisfying section(s) |
|----|----------------------|
| FR-001 | §2, §3 |
| FR-002 | §5, §8 |
| FR-003 | §4 |
| FR-004 | §6, §10 |
| FR-005 | §1, §12 |
| FR-006 | Top matter |
| FR-007 | §1, §12 (outcome selection) + branch artifacts outside findings.md |
| FR-008 | §2, §3, §5 (inline quoting requirement) |
| FR-009 | §11 |
| FR-010 | Commit message convention — not a section |
| FR-011 | §3 (`RawCommand` struct) |
| FR-012 | §7 |
| FR-013 | §9 |
| FR-014 | §9 (cleanup trigger) + client/mailbox artifacts outside findings.md |
| FR-015 | §6 (per-hypothesis fresh probe where triggered) |

**Result**: Every FR in spec.md maps to at least one section of `findings.md` or an out-of-document artefact listed in `plan.md`.

---

## Key Entities referenced

- **034 Probe Matrix**: §6 and §7.
- **Canonical Dispatch Chain**: §2, §3.
- **Divergence List**: §8.
- **Recoil `RawCommand`**: §3.
