# Quickstart: Proxy Contract Documentation

**Feature**: 030-proxy-contract-docs
**Date**: 2026-04-12

## What this feature delivers

Three contract documents and one mailbox response, all documentation-only:

1. **`contracts/shutdown-wire-shape.md`** — Shutdown message wire shape, reason mapping, trigger conditions, client handling guidance
2. **`contracts/unwired-command-log.md`** — `rc=-2` log format, output streams, stability promise
3. **Mailbox response** — Reply to FSBarV1's AttackCommand probe and contract refinement requests

## Implementation steps

### Step 1: Write the Shutdown wire shape contract

Source of truth: `proxy/src/proxy.c` lines 351-406 (EVENT_RELEASE handler) and `proto/highbar/messages.proto` lines 78-87 (ShutdownReason enum).

The contract document must cover:
- Wire shape: top-level `ProxyMessage.Shutdown` envelope, not a frame event
- Sequencing: after last Frame, before socket close
- Reason mapping table: all `SReleaseEvent.reason` values to `ShutdownReason` enum values
- Trigger conditions: what engine states produce each reason
- Client handling: read all `ProxyMessage` types, handle `Shutdown` as terminal

### Step 2: Write the unwired-command log format contract

Source of truth: `proxy/src/deserialize.c` lines 708-712 (stderr line) and `proxy/src/proxy.c` lines 214-238 (verbose infolog lines).

The contract document must cover:
- Unconditional stderr format: `[HB] unsupported command oneof case=%d (proxy switch table miss)`
- Verbose infolog format: `Cmd %zu: case=%d` and `Cmd %zu: rc=%d` (separate lines)
- Return code table: 0 (accepted), -1 (null), -2 (unsupported), other (engine error)
- Stability promise: format stable for proxy 0.1.x series

### Step 3: Write the mailbox response

Address all four items from the FSBarV1 mailbox:
- Problem 1 (Shutdown wire shape): point to the new contract document
- Problem 2 (rc=-2 log format): point to the new contract document, flag that case values are integers not strings
- Problem 3 (ShutdownReason triggers): point to the trigger conditions section in the Shutdown contract
- Problem 4 (AttackCommand probe): provide analysis from proxy source, recommend verbose-mode probe

### Step 4: Add cross-reference to 029 shutdown-event contract

Add a brief note to `specs/029-fix-trainer-issues/contracts/shutdown-event.md` pointing readers to the 030 wire shape contract for the full Shutdown documentation.

## Verification

All deliverables are markdown documents verified by inspection:
- Contract facts match proxy source code
- All `ShutdownReason` values are covered
- Log format examples match actual `fprintf`/`snprintf` format strings in source
- Mailbox response addresses all four FSBarV1 items

## Prerequisites

None. This feature requires no builds, no engine runs, and no test execution. It is pure documentation derived from reading the existing proxy source.
