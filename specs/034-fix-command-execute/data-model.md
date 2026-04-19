# Phase 1 Data Model: Dispatch Convention

**Feature**: 034-fix-command-execute
**Date**: 2026-04-19

This feature does not introduce persistent data, new wire types, or schema changes. The "data model" here is the decision table that the probe fills in and the chosen convention the shipped proxy adopts.

## Entity: DispatchConvention

A single row describes one way the proxy hands an `AICommand` to the engine.

| Field | Type | Notes |
|-------|------|-------|
| `name` | string | Human-readable label, e.g. `handleCommand-toId=-1` |
| `callback` | enum { `Engine_handleCommand`, `Engine_executeCommand` } | Which `SSkirmishAICallback` entry is invoked |
| `to_id` | int32 | Value passed for the `toId`/`unitId` argument (`-1`, acting unit, team id) |
| `command_id` | int32 | Value passed for the engine's `commandId` arg (typically `-1` for AI-originated orders) |
| `engine_rc` | int32 | Return code observed from the callback during probe |
| `engine_effect` | enum { `observed`, `none`, `error` } | Whether a nanoframe / position change / etc. was seen within the test's frame budget |
| `notes` | string | Free-form (e.g., "dropped when toId=-1 on per-unit orders") |

### Validation rules

- `engine_rc=0` AND `engine_effect=observed` → candidate for adoption.
- `engine_rc=0` AND `engine_effect=none` → the 033 failure signature; reject.
- `engine_rc≠0` → reject; surfaces via the existing `[HB] dispatch` WARN log (FR-002).

### State transitions

Not applicable — the decision table is filled once during the probe phase and collapses to a single shipped row (FR-008).

## Entity: DispatchProbeRun

A single live-engine invocation of the probe against a fixed command.

| Field | Type | Notes |
|-------|------|-------|
| `command_topic` | enum | `BUILD_UNIT`, `MOVE_UNIT`, `STOP`, `REPAIR` at minimum |
| `unit_id` | int32 | Acting unit (commander for BUILD/MOVE/STOP) |
| `frame` | int32 | Engine frame at dispatch |
| `rows` | list<DispatchConvention> | One row per candidate tried this run |
| `outcome` | enum { `single-winner`, `multiple-winners`, `none` } | Drives the FR-008 adoption decision or the Decision 4 fallback |

## Entity: MailboxReply (FR-007)

A single markdown file under `Mailbox/`. Fields are document sections, not schema columns:

- `root_cause` — one paragraph describing the convention-level defect found (or the negative result if Decision 4 triggers).
- `adopted_convention` — the winning `DispatchConvention` row, or "none" if no winner.
- `caller_guidance_delta` — any change FSBarV1 must make (expected: none).
- `client_version_bump` — the new `HighBar.Client` NuGet version (FR-006).

## Non-entities (deliberately out of scope)

- No new protobuf messages, no new enum values, no schema edits. Constitution II & VI.
- No persistent state. The probe's decision table is ephemeral; only the mailbox reply persists, and it lives in the repo, not in a database.
