# Feature Specification: Fix Unit Commands

**Feature Branch**: `017-fix-unit-commands`  
**Created**: 2026-04-04  
**Status**: Draft  
**Input**: User description: "fix the problems reported in the report. i ran a barb ai and it worked fine so finecombing how CircuitAI handles it seems productive."

## User Scenarios & Testing *(mandatory)*

### User Story 1 - AI Issues Unit Commands That Execute (Priority: P1)

When the HighBarV2 AI proxy sends unit commands (move, patrol, fight, attack, self-destruct, etc.) during a live game, those commands must be executed by the engine and produce visible effects on the units.

**Why this priority**: This is the core bug — unit commands are silently ignored despite the engine returning success. Without this fix, the AI cannot control any units, making it non-functional in live games.

**Independent Test**: Start a live game with the HighBarV2 AI. Issue a move command on the starting commander. The commander must visibly move to the target position.

**Acceptance Scenarios**:

1. **Given** a running game with the HighBarV2 AI, **When** the AI issues a MOVE command on a unit it owns, **Then** the unit moves to the target position.
2. **Given** a running game with the HighBarV2 AI, **When** the AI issues a SELF-DESTRUCT command on a unit it owns, **Then** the unit self-destructs.
3. **Given** a running game with the HighBarV2 AI, **When** the AI issues a PATROL command on a unit it owns, **Then** the unit patrols to the target position.

---

### User Story 2 - Existing Cheat Commands Continue Working (Priority: P1)

Cheat commands (spawning units, giving resources) must continue to work correctly after the fix.

**Why this priority**: Cheat commands currently work and are essential for testing. The fix must not regress them.

**Independent Test**: Start a live game with cheats enabled. Spawn a unit via COMMAND_CHEATS_GIVE_ME_NEW_UNIT. The unit must appear.

**Acceptance Scenarios**:

1. **Given** a running game with cheats enabled, **When** the AI spawns a unit, **Then** the unit appears at the specified position.
2. **Given** a running game with cheats enabled, **When** the AI spawns a unit and then issues a MOVE command on it, **Then** the spawned unit moves.

---

### User Story 3 - Automated Tests Pass (Priority: P2)

Existing headless engine tests that exercise command sending must pass after the fix. Any test infrastructure that hardcodes the command ID parameter must be updated.

**Why this priority**: Ensures the fix does not break the existing test suite.

**Independent Test**: Run the full F# test suite (`dotnet test`) and verify all previously passing tests still pass.

**Acceptance Scenarios**:

1. **Given** the fix is applied, **When** the full test suite is run, **Then** all previously passing tests still pass.
2. **Given** the fix is applied, **When** command deserialization tests run, **Then** the correct command ID parameter (-1) is used.

---

### Edge Cases

- What happens when unit commands are issued before the game starts (frame 0)? Commands during the placement phase may still be lost; the fix addresses the network packet type, not timing.
- What happens with group commands (groupId > 0)? The same commandId fix applies; group commands use the same `Engine_handleCommand` path.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The proxy MUST pass `-1` as the `commandId` parameter (third argument) to `Engine_handleCommand` for all unit commands, so the engine creates `NETMSG_AICOMMAND` packets instead of `NETMSG_AICOMMAND_TRACKED` packets.
- **FR-002**: The F# client MUST pass `-1` as the command ID when building command structs sent to the proxy, or the proxy MUST override the value regardless of what the client sends.
- **FR-003**: All unit command types (move, patrol, fight, attack, guard, self-destruct, stop, wait, build, etc.) MUST execute with visible effect when issued on units owned by the AI.
- **FR-004**: Cheat commands MUST continue to function correctly after the fix.
- **FR-005**: The proxy's direct-test code (hardcoded command tests in proxy.c) MUST be removed or updated to use the corrected parameter.

### Key Entities

- **Engine_handleCommand**: The C callback function that sends commands to the Recoil engine. The third parameter (`commandId`) controls whether the engine creates a `NETMSG_AICOMMAND` (-1) or `NETMSG_AICOMMAND_TRACKED` (any other value) network packet.
- **NETMSG_AICOMMAND vs NETMSG_AICOMMAND_TRACKED**: The GameServer only processes `NETMSG_AICOMMAND` in its main switch; `NETMSG_AICOMMAND_TRACKED` is silently dropped because there is no case for it.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: Units commanded by the AI visibly respond to move, patrol, fight, and self-destruct commands in a live game.
- **SC-002**: Cheat commands (unit spawning) continue to work.
- **SC-003**: The full existing test suite passes with no regressions.
- **SC-004**: All command paths through the proxy use the corrected `commandId` value of -1.

## Assumptions

- The root cause is confirmed: passing `commandId = 0` to `Engine_handleCommand` causes the engine to create `NETMSG_AICOMMAND_TRACKED` packets, which the Recoil GameServer does not handle (no `case NETMSG_AICOMMAND_TRACKED:` in its main switch). Passing `-1` produces `NETMSG_AICOMMAND` packets, which are handled correctly.
- BARb AI and CircuitAI both pass `-1` as the commandId parameter, confirming this is the expected usage.
- The fix is localized to the proxy C code and potentially the F# client command builders — no engine modifications needed.
- The `COMMAND_SEND_TEXT_MESSAGE` failure reported in the original report is a separate issue (it uses `ProcessCommandText` which only handles engine commands, not chat messages) and is out of scope for this fix.
