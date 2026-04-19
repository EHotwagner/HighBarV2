# Contract: `findings.md` Structural Contract

**Feature**: 035-research-dispatch-paths
**Scope**: The research deliverable is the single external artefact this feature publishes. This contract is the checkable shape any reviewer (or `/speckit.analyze`) can use to verify the deliverable satisfies spec.md.

---

## Contract checklist

A compliant `findings.md` MUST satisfy every item below. Each item references the spec FR(s) that require it.

### Top matter

- [ ] **C-TOP-1**: Document begins (before first `##`) with a one-sentence outcome statement naming (a) / (b) / (c). *(SC-003)*
- [ ] **C-TOP-2**: Resolved Recoil SHA pinned to tag `2025.06.19`, recorded verbatim (40-char hex). *(FR-006)*
- [ ] **C-TOP-3**: Resolved Circuit repo SHA recorded. *(FR-006)*
- [ ] **C-TOP-4**: BARb archive filename + sha256 recorded (or explicit "BARb source not accessible — used <X> instead" per Decision 4). *(FR-006, SC-006 fallback)*

### Section presence (all must exist; see `data-model.md` for ordering)

- [ ] **C-SEC-1**: §2 traces `Engine_handleCommand` end-to-end with file:line at every step. *(FR-001, FR-008)*
- [ ] **C-SEC-2**: §3 traces `Engine_executeCommand` end-to-end AND quotes the `RawCommand` struct verbatim from Recoil source. *(FR-001, FR-011, FR-008)*
- [ ] **C-SEC-3**: §4 states Lua/C join-or-divergence with file:line AND contains at least one verbatim Lua quote (BARb or documented fallback). *(FR-003, SC-006)*
- [ ] **C-SEC-4**: §5 quotes Circuit's dispatch call-site verbatim through every wrapper layer down to the raw callback call. Lists every parameter value. *(FR-002, FR-008, SC-006)*
- [ ] **C-SEC-5**: §6 has exactly five subsections, one per 034-mailbox hypothesis, each with verdict + source citation. *(FR-004, SC-002)*
- [ ] **C-SEC-6**: Wherever §6 source reading conflicts with a prior 033/034 empirical verdict, a fresh `engine.infolog` line from a live run on this branch against `spring-headless 2025.06.19` is quoted verbatim. *(FR-015)*
- [ ] **C-SEC-7**: §7 "Prior attempts" cites commits `dce4e42` (017), `357ab8e` (017), the 033 Q4 Resolution, and the 034 4-variant probe matrix — each with empirical verdict and Recoil-source explanation. *(FR-012)*
- [ ] **C-SEC-8**: §8 provides a field-by-field divergence table between `proxy/src/deserialize.c` `COMMAND_BUILD_UNIT` and Circuit's dispatch. *(FR-002 comparative)*
- [ ] **C-SEC-9**: §9 quotes Recoil's `UnitCommandOptions` enum from 2025.06.19 source (NOT the vendored header) and states the verdict on `INTERNAL_ORDER = 8u`. *(FR-013)*
- [ ] **C-SEC-10**: §10 either lists relevant recent Recoil commits or explicitly states "no relevant changes found — searched <paths>". *(US4)*
- [ ] **C-SEC-11**: §11 enumerates any header-vs-source conflicts, or states "none found". *(FR-009)*
- [ ] **C-SEC-12**: §12 "Next-step recommendation" matches the outcome stated in C-TOP-1. *(FR-005)*

### Content-quality rules

- [ ] **C-QUAL-1**: Every source citation is `path/to/file.ext:LINE` against the pinned Recoil / Circuit SHAs — no floating references. *(FR-006)*
- [ ] **C-QUAL-2**: Every cited line is quoted inline (not just referenced); a reviewer without local source can verify the claim from the document alone. *(FR-008)*
- [ ] **C-QUAL-3**: No "see <external source>" hand-waves. *(FR-008)*

### Outcome-specific gates

If outcome (a) — live-engine-confirmed fix shipped on this branch:

- [ ] **C-A-1**: Commit SHA of the shipped fix quoted in §1 and §12.
- [ ] **C-A-2**: New live-engine regression test present under `tests/Persistent/` or `tests/Integration/` that asserts engine-observable effect (nanoframe, unit motion, economy delta) — not `rc=0`. *(FR-007, SC-004)*
- [ ] **C-A-3**: Commit series demonstrates pre-fix test failure and post-fix test success. *(SC-004)*
- [ ] **C-A-4**: `HighBar.Client` patch version bumped. *(FR-007)*
- [ ] **C-A-5**: Mailbox reply under `Mailbox/2026-04-19_*.md` announces outcome + client version + any API-surface change. *(FR-007)*

If outcome (b) / (c) — docs-only:

- [ ] **C-BC-1**: `git diff master..035-research-dispatch-paths -- . ':(exclude)specs/035-research-dispatch-paths/' ':(exclude)Mailbox/'` is empty, **except** for FR-014 cleanup if triggered (see C-FR14-*). *(SC-004)*

### FR-014 gate (independent of outcome)

Triggered iff §9 concludes Recoil bit-3 is `SHIFT_KEY` or any flag other than "internal AI order":

- [ ] **C-FR14-1**: `INTERNAL_ORDER = 8u` removed from `clients/fsharp/src/Commands.fs`.
- [ ] **C-FR14-2**: All unit-command builders default `Options = 0u`.
- [ ] **C-FR14-3**: `HighBar.Client` patch version bumped (may be the same bump as outcome (a) or a separate standalone bump).
- [ ] **C-FR14-4**: Mailbox reply notes the constant removal for FSBarV1 re-review.

### Commit-convention gate

- [ ] **C-COMMIT-1**: All commits on this branch use `docs:` (or `fix:` for outcome-(a) code commits). *(FR-010)*

---

## Verification command (advisory)

```bash
# After findings.md is written, a reviewer can sanity-check presence:
grep -E '^## ' specs/035-research-dispatch-paths/findings.md
# Expect ~12 top-level sections matching data-model.md §1–§12.
```

No automated contract-test is produced; the contract is checked by the `/speckit.analyze` cross-artefact review and by the reviewer applying the checklist above during PR review.
