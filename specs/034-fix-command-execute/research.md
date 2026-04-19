# Phase 0 Research: Scripting Command Execution Fix

**Feature**: 034-fix-command-execute
**Date**: 2026-04-19

## Unknowns from Technical Context

All unknowns concern *which* proxy→engine handoff actually causes the engine to queue a per-unit order. The constitution forbids reading engine source (I); resolution is therefore empirical via an in-proxy probe.

## Decision 1: Dispatch-convention candidates to probe

- **Decision**: The probe will compare, on the same incoming `AICommand`, the return codes and observable engine effects of these candidates, in order:
  1. `Engine_handleCommand(skirmishAIId, toId=-1, commandId=-1, topic, data)` — current 033 baseline.
  2. `Engine_handleCommand(skirmishAIId, toId=unitId, commandId=-1, topic, data)` — `toId` set to the acting unit rather than `-1`.
  3. `Engine_executeCommand(skirmishAIId, unitId, commandId=-1, topic, data)` — alternative callback exposed in `SSkirmishAICallback`.
  4. `Engine_executeCommand` with `commandId=0` and/or team-id arg permutations documented in the vendored AI callback header (`proxy/include/AI/SSkirmishAICallback.h`).
- **Rationale**: 033 proved (1) is accepted but silently dropped. The most economical next hypotheses are (a) the callback is correct but `toId=-1` routes to a no-op queue for per-unit orders, or (b) `handleCommand` is the wrong entry point for queued orders and `executeCommand` is the right one. These two hypotheses cover the bulk of the probable surface with a single probe.
- **Alternatives considered**:
  - Reading engine source to pick the right callback — rejected (constitution I).
  - Changing the protobuf schema to carry a `toId` hint from clients — rejected (constitution II, VI; FSBarV1 already sends everything needed).
  - Adding a Lua synergy layer — rejected (reintroduces V1's latency regression; out of scope).

## Decision 2: Probe implementation shape

- **Decision**: The probe is a compile-time-opt-in branch in `proxy/src/proxy.c`'s per-unit dispatch site, guarded by `#ifdef HB_DISPATCH_PROBE`. When enabled, it calls candidate (1), logs `rc`, calls candidate (3) with a distinct log prefix, and logs both. The engine-observable effect (nanoframe / position delta) is observed via the existing test harness, not via new proxy logging.
- **Rationale**: Keeps the probe off the shipped hot path by default (constitution V). Uses the already-audited `[HB] dispatch` logging path (FR-002) to avoid a separate log contract. Compile guard makes removal (FR-008) a single-commit deletion.
- **Alternatives considered**: A runtime env-var flag — rejected; adds always-compiled code paths the shipped binary should never carry.

## Decision 3: Success signal — what "the right convention" means

- **Decision**: A candidate is declared correct iff, when it is the *only* call in the dispatch path, three consecutive `diag_one_build.py` runs each produce a friendly nanoframe within 1500 engine frames (SC-001), AND the new BUILD/MOVE/STOP/REPAIR persistent test (SC-003) passes on first clean run. A probe-only log-line mismatch (e.g., `rc=0` from both candidates) is insufficient — engine-observable effect is the sole acceptance signal. This reaffirms FR-001's empirical requirement.
- **Rationale**: 033 already demonstrated that `rc=0` is not sufficient evidence of execution.
- **Alternatives considered**: Deciding based on callback-handle presence or header comments — rejected; 033 showed header-driven reasoning already failed once.

## Decision 4: Fallback if no candidate works

- **Decision**: If none of the probed conventions produce engine effect, the feature re-scopes to a mailbox-only deliverable (FR-007) summarising the negative findings and proposing the next hypothesis surface (e.g., AI team bitset, `SCommand` layout mismatch, unit-ownership check). No speculative code ships. This matches the spec's "Assumptions" section.
- **Rationale**: Keeps the branch honest; a half-working fix would mask the real issue for a third iteration.

## Decision 5: Regression coverage for team-wide / unit-less commands

- **Decision**: Reuse existing persistent tests covering `GiveMeNewUnitCommand` and `SendTextMessageCommand` as the regression gate for FR-003. Do not add new coverage there — the fix either leaves team-wide paths untouched (if only the per-unit branch changes) or is uniform and must pass existing tests unmodified.
- **Rationale**: Minimizes test surface churn; preserves the "no regressions" assertion as a pure delta signal.

## Open Items

None — all NEEDS CLARIFICATION resolved. Empirical probe will answer the remaining engineering question during Phase 3 implementation.
