# Phase 1 — Data Model

**Feature**: 033-fix-scripting-dispatch

This feature does not introduce persistent data. The only new "entity" is an in-memory log record emitted on the proxy's hot path for every dispatched `AICommand`. It is defined here so the regression test, downstream tooling (FSBarV1 `FSBAR_TRACE_DISPATCH`), and future log scrapers have a contract to grep against.

## Entity: DispatchLogRecord

A single line written via `Log_log` (engine callback) at the moment the proxy hands an `AICommand` to `Engine_handleCommand`.

| Field | Type | Source | Notes |
|-------|------|--------|-------|
| `frame` | uint32 | `state->frame_number` | Engine frame on which the command was dispatched. |
| `case` | string | oneof name from `Highbar__AICommand__CommandCase` | Human-readable, e.g. `BUILD_UNIT`, `MOVE_UNIT`. Stable across releases — tests grep on this. |
| `unit` | int32 | per-command `unit_id` field | `-1` for commands with no unit (e.g., `PAUSE_TEAM`, `SEND_TEXT_MESSAGE`). |
| `engine_rc` | int32 | return value of `Engine_handleCommand` | `0` = accepted; negative = engine rejected; see taxonomy below. |

### Severity ladder

| Condition | Level | Reason |
|-----------|-------|--------|
| `engine_rc == 0` | INFO | Normal accepted dispatch. |
| `engine_rc < 0` | WARN | Engine rejected the command — surface so callers can react. |
| Oneof falls into `default` branch (`HB_DESERIALIZE_RC_UNSUPPORTED`) | WARN | Proxy switch table is missing this case; FR-003. |

### Engine return-code taxonomy

The Recoil `SSkirmishAICallback::Engine_handleCommand` contract (per vendored `proxy/include/AI/`) returns:

- `0` — command accepted.
- `-1..-N` — engine-defined rejection reasons. The proxy MUST surface the raw value verbatim; it does not re-interpret. A future enhancement may add a known-codes table, but that is out of scope for this feature.

## State transitions

`DispatchLogRecord` is a write-once event with no lifecycle — it is emitted, logged, and discarded. No persistence, no aggregation. The engine-side effect (unit appears, command queued) is observed via `GameStateSnapshot` from feature 032 and asserted by the regression test in `quickstart.md`.
