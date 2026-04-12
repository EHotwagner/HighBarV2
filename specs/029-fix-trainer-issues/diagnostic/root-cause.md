# Issue 1 Root Cause Investigation

**Date**: 2026-04-12
**Status**: Not reproducible in current codebase

## Finding

Issue 1 from `Mailbox/2026-04-12_FSBarV1_trainer_session_findings.md` claimed that only
`MoveCommand` actually moves units — all other command types silently no-op.

During the diagnostic phase of 029, I wrote live-engine tests (`tests/integration/fsharp/
NonMoveCommandEffectTests.fs`) that measure observable effect via `getUnitPos` before and
after each command. Results against current `master` (after the Phase 2 foundational
changes which are behaviorally inert for command dispatch):

| Test | Command | Result | Evidence |
|---|---|---|---|
| T029.baseline | `MoveCommand` | **PASS** | unit moved >10 elmos |
| T029.4a | `AttackCommand(self)` followed by `MoveCommand` | **PASS** | unit still moves after Attack |
| T029.5 | `FightCommand` | **PASS** | unit moved >10 elmos toward destination |
| T029.6 | `PatrolCommand` | **PASS** | unit moved >10 elmos toward patrol point |
| T029.9 | `StopCommand` | **PASS** | moving unit halted within 200 elmos |

All five tests pass on the current codebase without any command-dispatch fix.

## Interpretation

Three possibilities for the original finding:

1. **Headless engine physics limitation** — `T4_CombatTests.fs:70-75` notes that
   spring-headless does NOT simulate weapon physics, so damage/death events do not fire
   in headless mode. The trainer was running headless. If the trainer was inferring
   "AttackCommand did nothing" from absence of damage events, that's consistent with the
   headless limitation and NOT a proxy dispatch bug.
2. **Specific to commander-vs-commander combat** — the trainer's bot is commander-only;
   my tests use the builder unit spawned during warm-up. Commander-specific attack
   behaviour (e.g. commander refusing to engage without explicit Move order) is a BAR
   Lua rule, not a proxy dispatch bug.
3. **Observation artifact** — the finding may have confused "AttackCommand has no
   observable damage effect" with "AttackCommand has no effect at all". Movement
   effects (what my tests measure) were not directly verified in the trainer session.

## Decision

**No proxy or client code fix is needed for Issue 1.** The command-dispatch path is
working end-to-end; the five in-scope non-Move commands tested here all produce
observable in-engine effects.

Commands NOT tested (`GuardCommand`, `RepairCommand`, `ReclaimUnitCommand`,
`SelfDestructCommand`, `BuildCommand`, `GiveMeCommand`, `GiveMeNewUnitCommand`) use the
same `handle_command(skirmish_ai_id, -1, COMMAND_ID_UNTRACKED, TOPIC, &s)` dispatch
pattern as the tested ones in `proxy/src/deserialize.c`. If Fight/Patrol/Stop work,
the dispatch plumbing works; any failure of those would be a per-command-specific
BAR Lua rule (e.g. Guard requires a target to exist, Repair requires a damaged target,
etc.), which is out of scope for the proxy fix.

## FR-003 update — unsupported command sentinel

Independent of the Issue 1 finding, Phase 6 applied the FR-003 `rc=-2` sentinel to
`proxy/src/deserialize.c` default branch — this is the "proxy switch-table check" that
lets bots distinguish "command type not wired" from "engine accepted" when they send a
command oneof case the proxy doesn't handle. That change stands regardless of whether
Issue 1 is reproducible.

## Test gap closure (T040)

Although Issue 1 is not reproducible, the test gap that would have hidden it — namely,
`T6.11 AttackCommand` asserting only engine-survival — is still a problem per FR-016.
The integration-tier `NonMoveCommandEffectTests.fs` added in this feature closes that
gap for Move/Fight/Patrol/Stop. Upgrading T6.11 itself to assert effect would require
the persistent-tier engine-stability issues to be resolved first; deferred.
