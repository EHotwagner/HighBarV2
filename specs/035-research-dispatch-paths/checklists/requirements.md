# Specification Quality Checklist: Research Lua/Recoil/Circuit/BARb Command Dispatch Paths

**Purpose**: Validate specification completeness and quality before proceeding to planning
**Created**: 2026-04-19
**Feature**: [spec.md](../spec.md)

## Content Quality

- [X] No implementation details (languages, frameworks, APIs)
- [X] Focused on user value and business needs
- [X] Written for non-technical stakeholders
- [X] All mandatory sections completed

## Requirement Completeness

- [X] No [NEEDS CLARIFICATION] markers remain
- [X] Requirements are testable and unambiguous
- [X] Success criteria are measurable
- [X] Success criteria are technology-agnostic (no implementation details)
- [X] All acceptance scenarios are defined
- [X] Edge cases are identified
- [X] Scope is clearly bounded
- [X] Dependencies and assumptions identified

## Feature Readiness

- [X] All functional requirements have clear acceptance criteria
- [X] User scenarios cover primary flows
- [X] Feature meets measurable outcomes defined in Success Criteria
- [X] No implementation details leak into specification

## Notes

- Items marked incomplete require spec updates before `/speckit.clarify` or `/speckit.plan`
- Preliminary research at spec-time (three parallel agents — Recoil engine, Circuit AI, BARb) surfaced an actionable lead (`buildPos_posF3` failing `TestUnitBuildSquare`, plus `options = INTERNAL_ORDER (8)` colliding with `SHIFT_KEY`). The spec requires these be verified against Recoil source in the findings document, not accepted on the agents' say-so.
- Five clarifications were captured in `## Clarifications / Session 2026-04-19`. They expanded scope from "docs-only research" to "research + (optional) fix": live probes are now permitted, and if a probe confirms a working dispatch convention the fix ships on this branch (no 036 follow-up). FR-007, SC-003, SC-004 were revised accordingly.
- FR-012 requires a "Prior attempts" section citing feature 017 commits (`dce4e42`, `357ab8e`), feature 033's Q4 Resolution, and feature 034's probe matrix. FR-013/FR-014 require resolving the `INTERNAL_ORDER(8)` vs `SHIFT_KEY(1<<3)` collision and, if bit-3 is `SHIFT_KEY` per Recoil source, shipping a `Commands.fs` cleanup regardless of dispatch outcome.
