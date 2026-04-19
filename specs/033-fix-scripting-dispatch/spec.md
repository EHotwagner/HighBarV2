# Feature Specification: Fix Scripting Command Dispatch

**Feature Branch**: `033-fix-scripting-dispatch`
**Created**: 2026-04-19
**Status**: Draft
**Input**: User description: "@Mailbox/2026-04-19_from_FSBarV1_scripting-commands-silently-dropped.md investigate and fix"

## Background

FSBarV1's scripting maintainer reports that `BuildUnitCommand` (and likely all other `AICommand` cases) sent from external scripting clients via `fsbar.hub.scripting.v1.SendCommand` reach the proxy on the wire as well-formed `FrameResponse` messages but produce zero engine-side effect: no nanoframe, no movement, no error. The same wire format works when the in-process trainer drives it. This breaks every external scripting consumer (FSBarV1 features 046, 047, blocks 048) and the polyglot on-ramp documented in `docs/scripting-polyglot.md`. See `Mailbox/2026-04-19_from_FSBarV1_scripting-commands-silently-dropped.md` for the full report, repro script, traced wire payload, and field-by-field audit.

The reporter's three asks: (1) confirm whether the proxy reaches `Engine_handleCommand` for these commands and what the engine returns; (2) share proxy-side logs from the repro; (3) confirm whether `BuildPosition.Y` from `ListMetalSpots` needs ground-snapping.

## User Scenarios & Testing *(mandatory)*

### User Story 1 - External scripting client commands take effect in-game (Priority: P1)

A developer using the polyglot scripting on-ramp (Python/F#/etc.) connects to the Hub's gRPC scripting endpoint, calls `SendCommand` with a `BuildUnitCommand` for a commander to build a metal extractor at a known metal spot, then observes the game. The commander moves toward the spot and a nanoframe appears within ~10 engine seconds, identical to what an in-process trainer driving the same command path produces.

**Why this priority**: This is the only story; the entire external scripting surface is non-functional without it.

**Independent Test**: Run the FSBarV1 repro (`scripts/examples/python/diag_one_build.py` against Avalanche 3.4 skirmish, HighBarV2 vs BARb). Observe that the friendlies list grows to include `def_id == 77` (armmex) within 1500 frames after the `SendCommand` call.

**Acceptance Scenarios**:

1. **Given** an external scripting client has issued one `SendCommand(BuildUnitCommand)` targeting the commander to build `armmex` on a valid metal spot, **When** the engine has run for up to 1500 frames after the command was forwarded, **Then** a new friendly armmex appears in the engine state and the commander has moved from its starting position.
2. **Given** the same command is issued, **When** the proxy receives the `FrameResponse`, **Then** the proxy logs (a) the dispatch attempt with `(teamId, unitId, oneof_case_name)`, (b) the engine's `Engine_handleCommand` return code, so future regressions can be diagnosed without F#-side tracing.
3. **Given** the in-process trainer issues an equivalent `BuildUnitCommand` over the same path, **When** the run completes, **Then** trainer-driven and scripting-driven runs produce identical proxy log lines and identical engine-observable effects.

### Edge Cases

- The engine accepts the command but rejects it (e.g., bad build position, unitId not owned by this team, invalid def id): the proxy MUST surface the engine's return code so callers can distinguish "dropped" from "engine-rejected".
- `BuildPosition.Y` from `ListMetalSpots` may not match ground elevation. Determine whether the engine requires a ground-snapped Y for build orders and either (a) document that callers must snap, or (b) snap inside the proxy / fix the source `ListMetalSpots` Y values.
- Commands arriving in a `FrameResponse` whose `command_case` falls into the `default` branch of `hb_deserialize_and_execute` are returned as `HB_DESERIALIZE_RC_UNSUPPORTED` (-2) but the iteration in `proxy.c` does not log this unless `verbose_commands` is set. Ensure that an unsupported oneof at least produces a visible warning by default.

## Requirements *(mandatory)*

### Functional Requirements

- **FR-001**: The proxy MUST execute `AICommand` entries received in a scripting-originated `FrameResponse` such that the engine produces the same observable behavior as when the in-process trainer issues the equivalent command.
- **FR-002**: The proxy MUST log every command dispatch attempt at INFO level by default (not gated behind `verbose_commands`), including the oneof case name, target `unitId`, and `Engine_handleCommand` return code, so silent-drop regressions can be detected from proxy logs alone.
- **FR-003**: The proxy MUST log a WARN-level message whenever an `AICommand` falls into the `hb_deserialize_and_execute` default branch (`HB_DESERIALIZE_RC_UNSUPPORTED`), including the numeric oneof case, regardless of verbosity settings.
- **FR-004**: The fix MUST be validated end-to-end using the FSBarV1 Python repro (`diag_one_build.py`) and produce the expected nanoframe within 1500 engine frames.
- **FR-005**: The proxy and HighBar.Client MUST NOT silently rewrite, drop, or filter commands based on connection origin (trainer vs. external scripting). Any divergence in handling between the two paths MUST be removed or, if intentional, explicitly documented in the proxy contract docs (feature 030).
- **FR-006**: The investigation MUST produce a written root-cause finding (committed under `specs/033-fix-scripting-dispatch/`) explaining why the trainer path worked while the scripting path did not, even if the fix is a one-liner.
- **FR-007**: The investigation MUST answer the `BuildPosition.Y` question (does the engine require ground-snapped Y for build orders?) and either fix the source data, fix the proxy, or document the contract.
- **FR-008**: A regression test MUST exist in HighBarV2 that exercises the full scripting → proxy → engine dispatch for at least `BuildUnitCommand` and asserts the engine-observable effect (e.g., a new unit appears). The test runs as part of `./tests/run-all.sh --category persistent` or `--category integration`.
- **FR-009**: Once fixed, HighBar.Client MUST be version-bumped and the new SHA published so FSBarV1 can update `BundledProxy.fs` per the mailbox's closing checklist.

## Success Criteria *(mandatory)*

### Measurable Outcomes

- **SC-001**: Running FSBarV1's `diag_one_build.py` against the new proxy produces a friendly armmex nanoframe within 1500 engine frames in 3 of 3 consecutive runs.
- **SC-002**: Proxy logs from a single `SendCommand` repro contain at least one line identifying the dispatched command (oneof case, unit id, engine return code), with no opt-in flag required.
- **SC-003**: A new automated regression test in HighBarV2 covering scripting-originated `BuildUnitCommand` passes in CI and fails if the dispatch path is reverted.
- **SC-004**: FSBarV1 is notified of the new HighBar.Client version and given a 3-step update recipe in the reply mailbox; confirmation that their `ScriptingCommandExecutionTests` passes is tracked out-of-band and is not a gate on this feature.
- **SC-005**: A mailbox reply is written back to FSBarV1 documenting the root cause, the fix, the new HighBar.Client version, and the answer to the `BuildPosition.Y` question.

## Assumptions

- The mailbox's audit of the F# side is correct: the `FrameResponse` arrives at the proxy fully well-formed with `TeamId=0`, valid `UnitId`, `Options=8`, `ToBuildUnitDefId=77`, and a `BuildPosition`. Investigation will verify rather than re-derive this.
- The bundled proxy SHA shipped with FSBarV1 matches the HighBarV2 `master` proxy at the time of the report; if the bundled proxy is stale, that itself is the bug and the fix is on the FSBarV1 side.
- The Avalanche 3.4 skirmish setup, BAR install, and headless engine on this development environment can reproduce the scripting → proxy → engine path without FSBarV1's gRPC layer (e.g., via a direct test harness in HighBarV2 that mimics the wire format the mailbox attached).
- Always-on dispatch logging emits one INFO line per dispatched command (only when `n_commands > 0`, not per frame) and one WARN line per engine rejection or unsupported oneof. No verbosity-gated fallback.
- The fix lands as a single feature branch `033-fix-scripting-dispatch`, gets squash-merged, and triggers a HighBar.Client patch version bump.
