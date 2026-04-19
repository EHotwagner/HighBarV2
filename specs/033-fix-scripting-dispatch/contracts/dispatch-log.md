# Contract: Proxy Dispatch Log Line

**Feature**: 033-fix-scripting-dispatch
**Stability**: STABLE — downstream tooling (FSBarV1 tracer, log scrapers) parses this; do not change without a major proxy version bump.

## Format

One line per dispatched `AICommand`, written via the engine's `Log_log` callback. Format is `key=value` separated by single spaces, prefixed with `[HB] dispatch`:

```
[HB] dispatch frame=<u32> case=<UPPER_SNAKE> unit=<i32> engine_rc=<i32>
```

### Examples

Accepted build order:

```
[HB] dispatch frame=76 case=BUILD_UNIT unit=25947 engine_rc=0
```

Engine-rejected move (hypothetical rc=-2):

```
[HB] dispatch frame=412 case=MOVE_UNIT unit=25947 engine_rc=-2
```

Unsupported oneof (e.g., a future command the proxy switch table doesn't yet handle, oneof case 99):

```
[HB] dispatch frame=120 case=UNKNOWN(99) unit=-1 engine_rc=-2
```

## Field rules

- `frame`: decimal `uint32`, no padding.
- `case`: uppercase identifier matching the protobuf oneof case name with the `COMMAND_` prefix stripped (e.g., `HIGHBAR__AICOMMAND__COMMAND_BUILD_UNIT` → `BUILD_UNIT`). Unknown cases use `UNKNOWN(<n>)` where `<n>` is the numeric `command_case` value.
- `unit`: decimal `int32`. `-1` when the command has no `unit_id` field (team-wide commands like `PAUSE_TEAM`, `SEND_TEXT_MESSAGE`).
- `engine_rc`: decimal `int32`, return value of `Engine_handleCommand`, or `HB_DESERIALIZE_RC_UNSUPPORTED` (-2) when the proxy never reaches the engine.

## Severity

- INFO when `engine_rc == 0`.
- WARN when `engine_rc != 0` (including unsupported oneof).

The line itself does not encode the severity — it is determined by the log level passed to `Log_log`. Consumers who scrape stdout/stderr should match on the `[HB] dispatch` prefix and inspect `engine_rc` to classify.

## Negative guarantees

- This line MUST NOT contain command-payload details (positions, def IDs, params). Those would balloon log volume on busy frames and are not needed for the regression-test contract. Detailed payload logging remains gated behind `verbose_commands` (existing config knob).
- This line MUST be emitted before `Engine_handleCommand` returns control, so a crashing engine call leaves the dispatch attempt in the log.
