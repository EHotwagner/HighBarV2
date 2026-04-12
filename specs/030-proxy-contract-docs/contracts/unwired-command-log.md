# Contract: Unwired Command Log Format

**Feature**: 030-proxy-contract-docs
**Satisfies**: FR-004, FR-005
**Supplements**: [029-fix-trainer-issues/contracts/command-dispatch.md](../../029-fix-trainer-issues/contracts/command-dispatch.md)

## Overview

When the proxy receives a command with a protobuf oneof case that is not in its dispatch switch table, it logs a diagnostic line and returns a specific error code. This document specifies the log format, output stream, return code semantics, and stability guarantee.

## Log Format

### Unconditional stderr line

Every unsupported command produces exactly one line on **stderr**:

```
[HB] unsupported command oneof case=<INT> (proxy switch table miss)
```

Where `<INT>` is the **integer value** of the protobuf `AICommand.command_case` oneof enum. This is NOT the string name of the command type.

Example:
```
[HB] unsupported command oneof case=99 (proxy switch table miss)
```

This line is **always emitted** regardless of the `verbose_commands` configuration setting.

### Verbose-mode infolog lines (optional)

When `verbose_commands=true` in the proxy's AI options, the proxy additionally logs two lines per command to the **engine infolog** (via `proxy_log`):

```
Cmd <INDEX>: case=<INT>
Cmd <INDEX>: rc=<RC>
```

Where:
- `<INDEX>` is the zero-based index of the command within the current frame's command batch
- `<INT>` is the protobuf oneof case integer value (same as the stderr line)
- `<RC>` is the return code from dispatch (see below)

These two lines are on **separate log lines**. They share the same `<INDEX>` value, which can be used to correlate them.

Example (unsupported command at index 2):
```
Cmd 2: case=99
Cmd 2: rc=-2
```

## Return Code Semantics

| Return code | Meaning | Source |
|---|---|---|
| `0` | Engine accepted the command (does NOT guarantee in-game effect) | `Engine_handleCommand` return value |
| `-1` | Null command pointer or null callback (programmer error) | `hb_deserialize_and_execute` guard |
| `-2` | Protobuf oneof case not in proxy dispatch switch table | `HB_DESERIALIZE_RC_UNSUPPORTED` constant |
| Other | Engine-specific non-zero return (command rejected by engine) | `Engine_handleCommand` return value |

The value `-2` is defined as `HB_DESERIALIZE_RC_UNSUPPORTED` in `proxy/src/deserialize.c`.

## Parsing Guidance

To detect unsupported commands from the proxy's output:

**Option A — Parse stderr** (recommended, always available):
- Grep for the literal substring `unsupported command oneof case=` on stderr
- Extract the integer after `case=` using pattern: `case=([0-9]+)`
- One line = one unsupported command dispatch

**Option B — Parse infolog** (requires `verbose_commands=true`):
- Grep for lines matching `Cmd <N>: rc=-2` in the engine infolog
- To get the command case, find the preceding `Cmd <N>: case=<INT>` line with the same index `<N>`
- The case and rc are on **separate lines** — do NOT assume they are on the same line

**Mapping integer case to command name**: The integer values correspond to protobuf oneof field numbers in the `AICommand` message. Consult `proto/highbar/messages.proto` for the field-number-to-name mapping. The proxy does not emit the string name.

## Stability Promise

The following are stable for the proxy `0.1.x` version series:

- The stderr line format: `[HB] unsupported command oneof case=%d (proxy switch table miss)\n`
- The return code value `-2` for unsupported commands
- The verbose-mode line format: `Cmd %zu: case=%d` and `Cmd %zu: rc=%d`
- The output streams: stderr for the unconditional line, engine infolog for verbose lines

Changes to these formats in a future proxy version (0.2.x or later) will be noted in the release changelog. The `case=` token will always carry an integer value, not a string name, in the `0.1.x` series.
