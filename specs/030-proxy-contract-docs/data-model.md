# Data Model: Proxy Contract Documentation

**Feature**: 030-proxy-contract-docs
**Date**: 2026-04-12

This feature is documentation-only and introduces no new data entities. The following reference describes the existing entities that the contract documents describe.

## Entities

### ShutdownReason (existing proto enum)

Represents the reason the proxy terminated the client session.

| Value | Name | Proto int | Trigger |
|---|---|---|---|
| Unknown | `SHUTDOWN_REASON_UNKNOWN` | 0 | Default / unrecognized engine reason |
| GameOver | `SHUTDOWN_REASON_GAME_OVER` | 1 | Engine reasons 1, 2, 3 |
| Disconnect | `SHUTDOWN_REASON_DISCONNECT` | 2 | Engine reason 6 |
| Error | `SHUTDOWN_REASON_ERROR` | 3 | Engine reasons 4, 5 |

### Shutdown (existing proto message)

Terminal message sent once per session, carrying a `ShutdownReason`.

- `reason`: ShutdownReason — the cause of session termination
- Relationship: Sibling of `Frame` in the `ProxyMessage.message` oneof

### Unwired Command Log Entry (informal, not a proto entity)

A diagnostic log line emitted when the proxy encounters a command type it does not dispatch.

- `command_case`: integer — the protobuf oneof field number
- `return_code`: integer — always `-2` (`HB_DESERIALIZE_RC_UNSUPPORTED`)
- Output stream: stderr (unconditional) or engine infolog (verbose mode)
