# Feature Specification: Proxy Contract Documentation

**Feature Branch**: `030-proxy-contract-docs`  
**Created**: 2026-04-12  
**Status**: Draft  
**Input**: User description: "Mailbox/2026-04-12_to_HighBarV2_proxy-contract-refinements.md fix those suggestions."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - Document Shutdown Wire Shape (Priority: P1)

A developer building a new client against the HighBar proxy needs to understand how the proxy signals end-of-match. Today, the only way to discover that Shutdown is a top-level `ProxyMessage` envelope (not an event inside a Frame) is to read the C source or stumble on it at runtime. The developer consults the contract documentation and learns the exact wire shape, message sequencing, and recommended client handling patterns without inspecting proxy source code.

**Why this priority**: The Shutdown wire shape caused the most costly misunderstanding during FSBarV1 integration. The FSBarV1 team built an entire code path around the incorrect assumption that Shutdown was a frame event, then had to unwind it. Documenting this prevents the same mistake for every future client.

**Independent Test**: Can be verified by reading the resulting documentation and confirming it answers: (1) what message type carries the Shutdown, (2) when it appears relative to the last Frame, (3) what each ShutdownReason value means, and (4) how a client should handle it.

**Acceptance Scenarios**:

1. **Given** a contract document for the Shutdown message exists, **When** a client developer reads it, **Then** they can determine without ambiguity that Shutdown is a top-level `ProxyMessage` envelope sent after the final Frame and before the socket close.
2. **Given** the Shutdown contract document lists all `ShutdownReason` values, **When** a client developer reads it, **Then** they can determine the engine trigger conditions for each reason (GameOver, Error, Disconnect, Unknown) including which `SReleaseEvent.reason` integer values map to each.
3. **Given** the Shutdown contract document includes client handling guidance, **When** a client developer reads it, **Then** they understand they must read all `ProxyMessage` envelopes (not just Frame) and handle `ProxyMessage.Shutdown` as a distinct terminal message.

---

### User Story 2 - Document Unwired Command Log Format (Priority: P2)

An operator or developer running the proxy wants to detect command types that the bot attempted to send but which the proxy does not wire to the engine. Today, the only signal is an ad-hoc log line on stderr with no documented format or stability guarantee. After reading the contract documentation, the developer knows the exact log line format, which output stream it appears on, and can write a reliable parser without reverse-engineering the proxy source.

**Why this priority**: FSBarV1 already wrote a parser for this log line, but it makes unverified assumptions about the format. A documented, stable format prevents silent breakage on proxy refactors.

**Independent Test**: Can be verified by reading the resulting documentation and confirming it specifies: (1) the exact log line format, (2) the output stream (stderr), (3) the meaning of the return code, and (4) a stability promise for the format.

**Acceptance Scenarios**:

1. **Given** a contract document for the unwired-command log format exists, **When** a client developer reads it, **Then** they can write a parser that extracts the command case identifier from the log line.
2. **Given** the document specifies the output stream and stability scope, **When** the proxy is refactored in a future version, **Then** the documented format is treated as a contract and changes require a version bump or deprecation notice.

---

### User Story 3 - Document ShutdownReason Trigger Conditions (Priority: P2)

A client developer writing error-classification logic needs to know what engine conditions produce each `ShutdownReason` value. Today, only `GameOver` has been observed in real runs; `Error` and `Disconnect` have never been seen, and their trigger conditions are undocumented. After reading the contract documentation, the developer can write classification logic that correctly differentiates all three cases and can design test scenarios that exercise each one.

**Why this priority**: Tied with US2 because untested enum values are a latent correctness risk. Any client that pattern-matches on `ShutdownReason` today is guessing for two of three cases.

**Independent Test**: Can be verified by reading the resulting documentation and confirming it lists the engine-level trigger for each `ShutdownReason` value, including which `SReleaseEvent.reason` integer values map to each.

**Acceptance Scenarios**:

1. **Given** the Shutdown contract document includes trigger conditions, **When** a client developer reads it, **Then** they can determine what engine events produce Error and Disconnect.
2. **Given** the trigger conditions are documented, **When** a client developer wants to write a regression test, **Then** they have enough information to design a scenario that deliberately triggers each reason.

---

### User Story 4 - Respond to AttackCommand Probe (Priority: P3)

The FSBarV1 team reported that `AttackCommand` appears to have no effect (unit remains stationary) across three probe iterations. They requested either a verbose-mode run from the proxy side, a suggested alternative probe shape, or closure of the issue. The proxy maintainer investigates and provides a documented response.

**Why this priority**: Lower than the documentation items because this is an investigation task, not a contract gap. The FSBarV1 team is not blocked and the command is confirmed wired in the proxy source.

**Independent Test**: Can be verified by the existence of a response in the mailbox or contract documentation that addresses the probe result.

**Acceptance Scenarios**:

1. **Given** the proxy source shows AttackCommand is wired, **When** the maintainer investigates the probe results, **Then** a documented response is provided to the FSBarV1 team explaining the observed behavior or suggesting next steps.

---

### Edge Cases

- What happens if a future proxy version adds a new `ShutdownReason` value? The documentation should note that clients must handle unknown enum values gracefully.
- What happens if the unwired-command log format changes in a future proxy version? The stability promise scope must be explicit.
- What happens if the engine fires `EVENT_RELEASE` with a reason value not in the documented 1-6 range? The documentation should note this maps to `SHUTDOWN_REASON_UNKNOWN`.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: Project MUST include a contract document describing the Shutdown message wire shape, specifying that it is a top-level `ProxyMessage.Shutdown` envelope sent after the final `ProxyMessage.Frame` and before the socket close.
- **FR-002**: The Shutdown contract document MUST list all `ShutdownReason` enum values (Unknown, GameOver, Disconnect, Error) with their protobuf integer values and the corresponding engine release-event reason integers that trigger each.
- **FR-003**: The Shutdown contract document MUST include a recommended client handling pattern explaining that clients should read all `ProxyMessage` envelopes and treat `Shutdown` as a distinct terminal message.
- **FR-004**: Project MUST include a contract document describing the unwired-command log line format, specifying the exact string pattern, output stream (stderr), and the meaning of the unsupported-command return code.
- **FR-005**: The unwired-command log format document MUST include a stability promise scoped to a specific proxy version range.
- **FR-006**: The Shutdown contract document MUST describe trigger conditions for each `ShutdownReason` value in terms of engine behavior, including what game states or operator actions cause each.
- **FR-007**: Project MUST include a documented response to the FSBarV1 AttackCommand probe, either as a mailbox reply or a section in the relevant contract document.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: A developer unfamiliar with the proxy can determine the Shutdown wire shape, message sequencing, and all reason trigger conditions by reading the contract documentation alone, without inspecting proxy source code.
- **SC-002**: A developer can write a correct unwired-command log parser using only the contract documentation, with the exact format, output stream, and token positions specified.
- **SC-003**: All three `ShutdownReason` values (GameOver, Error, Disconnect) have documented engine-level trigger conditions that a developer can use to design deliberate test scenarios for each.
- **SC-004**: The FSBarV1 AttackCommand probe request receives a documented response within the scope of this feature.

## Assumptions

- The contract documents will be placed in the existing `specs/` directory structure, consistent with how previous features organized contract documentation.
- No proxy code changes are required. This feature is documentation-only (Option A from the FSBarV1 mailbox for all three problems).
- The unwired-command log format stability promise applies to the current proxy version series; future major versions may change the format with notice.
- The AttackCommand investigation may require a live engine run with verbose commands enabled or may be resolvable from existing evidence in the proxy source.
- The engine release-event reason integer-to-enum mapping in the proxy source is the authoritative source for shutdown reason triggers.
