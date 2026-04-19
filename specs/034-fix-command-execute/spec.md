# Feature Specification: Fix Scripting Command Execution (Proxy → Engine Handoff)

**Feature Branch**: `034-fix-command-execute`
**Created**: 2026-04-19
**Status**: Draft
**Input**: User description: "Scripting-originated AICommand silently dropped below Engine_handleCommand — follow-up to 033. Proxy dispatch is healthy (engine_rc=0), but no engine-observable effect. Investigate toId semantics and Engine_executeCommand alternative."

## Background (non-normative)

Feature 033 (`fix-scripting-dispatch`) proved that `AICommand` messages arriving from an external scripting client reach the proxy's dispatch loop and trigger `Engine_handleCommand` with a success return code (`engine_rc=0`) — yet the commander never builds and no engine-observable effect appears (no nanoframe, no move, no reclaim). Three independent payload variants (`Y=1989`, `Y=0`, `options=0`) all produced the same "accepted and silently dropped" pattern. The bug therefore sits below the public dispatch boundary — in the proxy's call convention with the engine's AI callback. 033 deferred the fix here.

## User Scenarios & Testing *(mandatory)*

### User Story 1 - External scripting client's BuildUnitCommand actually builds a unit (Priority: P1)

A developer using the scripting API (Python, F#, gRPC, or any polyglot client) sends a single `BuildUnitCommand` for their commander against a valid metal spot. The commander moves toward the spot and a friendly nanoframe of the requested unit-def appears within a reasonable frame budget, identical to what the in-process trainer produces when issuing the same command locally.

**Why this priority**: This is the entire feature. External scripting has been end-to-end green on F# serialization, dispatch logging, and engine-side acceptance since 033, but the command has never actually *executed*. Every other scripting feature (polyglot demos, multi-command orchestration, test harness authoring) is blocked by this one gap.

**Independent Test**: Run the FSBarV1 Python repro `diag_one_build.py` three consecutive times against a single headless engine session. All three runs must produce a friendly unit of the requested def-id within 1500 engine frames, and the proxy's `[HB] dispatch … engine_rc=0` line must appear (log contract from 033 already in place).

**Acceptance Scenarios**:

1. **Given** a fresh headless engine session with HighBar proxy attached, **When** an external scripting client issues one `BuildUnitCommand` for the commander at a valid metal spot, **Then** a nanoframe of the requested unit-def appears within 1500 engine frames.
2. **Given** the same setup, **When** three consecutive `BuildUnitCommand`s are issued one after another, **Then** three nanoframes appear and the commander visibly switches targets.
3. **Given** the same setup, **When** the client issues a `MoveUnitCommand` for the commander to a reachable position, **Then** the commander's engine-reported position changes toward the target within 300 frames.

---

### User Story 2 - Regression: other per-unit commands also execute (Priority: P1)

The fix must cover the class of per-unit commands (MOVE, BUILD, ATTACK, REPAIR, PATROL, FIGHT, GUARD, RECLAIM_UNIT, STOP, WAIT, SET_ON_OFF, SET_REPEAT, etc.), not just BUILD_UNIT. 033's dispatch log makes it trivial to assert `engine_rc=0` and observe engine-side effects for each.

**Why this priority**: If the root cause is the proxy's `toId`/`execute` handoff convention (working hypothesis), the fix is categorical — every per-unit command is either fixed or still broken together. Shipping a narrow "only BUILD works" fix would mask the remaining gaps and re-trigger the same mailbox thread.

**Independent Test**: Live-engine regression covering at least BUILD_UNIT, MOVE_UNIT, STOP, and one REPAIR-like command. Each must produce the corresponding engine-observable effect; dispatch log shows `engine_rc=0`.

**Acceptance Scenarios**:

1. **Given** the proxy with the 034 fix in place, **When** the test issues each of `{BUILD_UNIT, MOVE_UNIT, STOP, REPAIR}`, **Then** each produces its engine-observable effect within its expected frame budget.

---

### User Story 3 - The fix is auditable and does not regress team-wide / unit-less commands (Priority: P2)

Team-wide commands (`PAUSE_TEAM`, `SEND_TEXT_MESSAGE`, `SEND_RESOURCES`, `GIVE_ME_NEW_UNIT`, etc.) that were working before 033 must continue to work after 034. Draw/figure/path-query commands likewise.

**Why this priority**: The fix hypothesis touches the proxy's dispatch convention. If the change is applied uniformly, it risks breaking the "no-unit" commands whose behavior was already correct. A regression assertion on these prevents a win/loss trade.

**Independent Test**: After applying the fix, run an existing persistent test that issues `GiveMeNewUnitCommand` and `SendTextMessageCommand`; both must continue producing their observable effects (unit spawns; chat message in infolog).

**Acceptance Scenarios**:

1. **Given** the 034 fix in place, **When** the test suite runs, **Then** all existing team-wide-command tests pass with no regressions.

---

### Edge Cases

- A `BuildUnitCommand` with an invalid `unit_id` (not the AI's unit, or a non-builder) — the engine's return code must surface via the existing `[HB] dispatch` WARN severity; the fix must not silently mask rejections.
- A `BuildUnitCommand` whose position is blocked or occupied — engine returns accepted (`rc=0`) but queues nothing; this is engine behavior, not a proxy bug, and the spec does not require a nanoframe in this case. Test cases must pick unblocked positions.
- Rapid back-to-back commands (5+ in one `FrameResponse`) — all must execute in order; the static position-buffer pool in the proxy must not alias across commands.
- A proxy probe that calls two alternative dispatch conventions back-to-back for diagnosis must not leave duplicate orders in the engine's command queue once removed (probe is a development artefact, not a shipped code path).

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The proxy MUST dispatch every per-unit `AICommand` received from an external scripting client to the engine using whichever callback convention actually causes the engine to queue the order. The chosen convention MUST be determined empirically by observing engine-side effect, not by reading engine source.
- **FR-002**: The proxy MUST retain and honour the always-on `[HB] dispatch frame=… case=… unit=… engine_rc=…` log line introduced in 033. The 034 change MUST NOT remove, rename, or re-gate this contract.
- **FR-003**: Team-wide commands (`PAUSE_TEAM`, `SEND_TEXT_MESSAGE`, `SEND_RESOURCES`, `GIVE_ME`, `GIVE_ME_NEW_UNIT`, `CALL_LUA_RULES`, `CALL_LUA_UI`, `SET_SHARE_LEVEL`, `SET_MY_INCOME_SHARE_DIRECT`, draw/figure ops, path queries) MUST continue to produce their pre-034 engine-observable effects.
- **FR-004**: A live-engine regression test MUST exist that exercises at least four distinct per-unit command types (covering BUILD, MOVE, and two others) and asserts each engine-observable effect. The test runs under `./tests/run-all.sh --category persistent`.
- **FR-005**: The FSBarV1 `diag_one_build.py` repro MUST pass 3 of 3 consecutive runs after the fix lands (SC-001 carry-over from 033).
- **FR-006**: The `HighBar.Client` NuGet package version MUST be bumped (patch bump from whatever is current when 034 starts) so downstream consumers can pick up the fix.
- **FR-007**: A reply mailbox file MUST be written to `Mailbox/` describing the root cause found, the convention adopted, and any caller-side guidance that changed.
- **FR-008**: Any diagnostic probe code added to isolate the correct convention (e.g., a dual-call logger in the dispatch loop) MUST be removed before the feature ships. Only the chosen, single-path dispatch remains in the shipped proxy.

### Key Entities

- **Dispatch convention**: the specific callback invocation pattern the proxy uses to hand an `AICommand` to the engine — currently `Engine_handleCommand(skirmishAIId, toId=-1, commandId=-1, commandTopic, commandData)`. The feature may change `toId`, the callback chosen, or add a second call. The chosen convention is the primary engineering artefact of this feature.
- **Probe**: a temporary, development-only branch in the proxy that invokes two or more dispatch-convention variants on the same command and logs each return code plus the observed engine effect. Exists only long enough to select the correct convention; removed before shipping per FR-008.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: 3 of 3 consecutive `diag_one_build.py` runs produce a friendly nanoframe within 1500 engine frames (same success bar 033 set but couldn't meet).
- **SC-002**: The existing persistent-test suite (`./tests/run-all.sh --category persistent`) passes with zero regressions against the 034 proxy build.
- **SC-003**: A new persistent test covering BUILD, MOVE, STOP, and REPAIR from an external-wire path (simulating scripting origin) passes on first clean run, with each command's engine-observable effect confirmed within its expected frame budget.
- **SC-004**: The `[HB] dispatch` log line continues to appear for every command issued during the regression test, with `engine_rc=0` on accepted commands — proving the 033 logging contract survives the 034 change.
- **SC-005**: The mailbox reply (FR-007) is filed within the same working day the fix lands, so FSBarV1 knows when to re-bundle.

## Assumptions

- Recoil engine source is out of scope (constitution I). Root cause is determined empirically via in-proxy experimentation (the "probe" entity) and the 033 dispatch log.
- The bug class is a proxy↔engine handoff convention issue. If probing reveals the issue is elsewhere (e.g., inside the AI-loader / engine-side team-ownership bitset), the feature re-scopes to the narrower finding and may produce only a mailbox reply plus a revised hypothesis. This is acceptable.
- The fix is likely ≤50 LOC in `proxy/src/proxy.c` or `proxy/src/deserialize.c`. No schema changes expected. No breaking changes to the external protobuf contract.
- `BuildPosition.Y` is not the cause (definitively answered in 033/Q4). No ground-snap is required on the caller side or in the proxy.
- The `T12_BuildPositionY.fs` persistent test from 033 may be repaired or removed during this feature; its fixture-shared-engine instability may or may not share a root cause with the dispatch bug.

## Dependencies

- 033 must be merged to master before 034 starts (it is, as of 2026-04-19).
- FSBarV1's `diag_one_build.py` repro remains the authoritative end-to-end gate.
- Live headless engine (`spring-headless 2025.06.19`) and BAR game archive must be available on the dev machine (already a constitution-VI environment guarantee).

## Out of Scope

- Any modification to the Recoil engine (constitution I).
- Any protobuf schema change or wire-format extension (constitution II, VI).
- Removal, rename, or re-gating of the 033 `[HB] dispatch` log line (contract-stable).
- A fix for the persistent-test fixture instability beyond what is needed to run the 034 regression tests; a broader fixture-reliability pass belongs in a separate feature.
- Performance tuning of the proxy's dispatch hot path beyond keeping the 033 per-command overhead budget.
