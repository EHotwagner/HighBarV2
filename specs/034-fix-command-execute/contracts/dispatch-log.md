# Contract: `[HB] dispatch` Log Line (preserved from 033)

**Feature**: 034-fix-command-execute
**Status**: Stable — MUST NOT change in 034 (FR-002).

## Purpose

The proxy's per-command dispatch log line is the authoritative external signal that a command was received, decoded, and handed to the engine, along with the engine's return code. It is the contract against which FSBarV1, this feature's regression tests, and future debugging all assert.

## Format

```
[HB] dispatch frame=<int> case=<CASE> unit=<int> engine_rc=<int>
```

- `frame` — engine frame at dispatch time (matches engine infolog's current frame).
- `case` — the proxy's dispatch-case label (e.g., `BUILD_UNIT`, `MOVE_UNIT`, `STOP`, `REPAIR`, `TEAMWIDE`, etc.). Values are stable across 033/034.
- `unit` — the acting `unit_id` for per-unit commands; `-1` for team-wide or unit-less commands.
- `engine_rc` — integer return code from the chosen engine callback (`Engine_handleCommand` or `Engine_executeCommand`). `0` = accepted.

## Severity

- INFO when `engine_rc == 0`.
- WARN when `engine_rc != 0`.

## Guarantees 034 preserves

- Line appears exactly once per successfully decoded `AICommand`.
- Field names, order, and separators are unchanged.
- No gating by env var, build flag, or AI option. Always on.
- The optional probe (`#ifdef HB_DISPATCH_PROBE`, Decision 2 in research.md) MUST NOT alter this line's shape when probe is disabled (ship configuration).

## Non-goals

- This contract does not cover the probe's own log lines. Probe lines use a distinct prefix (`[HB] probe …`) and are removed before ship (FR-008).

## Mailbox reply schema (FR-007)

A markdown file at `Mailbox/2026-04-<dd>-034-fix-command-execute.md` with these H2 sections:

1. `## Root cause` — paragraph summary of what was wrong in the proxy↔engine handoff (or a negative-result writeup if Decision 4 triggered).
2. `## Adopted dispatch convention` — the winning `DispatchConvention` row from data-model.md, or `none`.
3. `## Caller guidance` — any change required of FSBarV1 (expected: none).
4. `## Client version` — new `HighBar.Client` NuGet version shipped with the fix (FR-006).
5. `## Followups` — remaining gaps, if any (e.g., `T12_BuildPositionY.fs` disposition per spec Assumptions).
