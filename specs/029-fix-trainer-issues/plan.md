# Implementation Plan: Fix Five Proxy Issues from FSBarV1 Trainer Session

**Branch**: `029-fix-trainer-issues` | **Date**: 2026-04-12 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/home/developer/projects/HighBarV2/specs/029-fix-trainer-issues/spec.md`

## Summary

Fix five proxy- and callback-level defects observed during the FSBarV1 trainer session on 2026-04-12 (`Mailbox/2026-04-12_FSBarV1_trainer_session_findings.md`):

1. **Non-Move unit commands silently no-op.** The proxy already routes Fight/Attack/Patrol/etc. through `Engine_handleCommand` with `commandId=-1` (the 017 fix), but their in-engine effect was never live-tested. The trainer is the first to observe that only `MoveUnit` actually moves a unit. Root cause is unknown from headers alone; the plan includes a diagnostic spike before the fix.
2. **Economy callbacks return 0.0f.** `proxy/src/callbacks.c` is missing switch cases for `CALLBACK_ECONOMY_GET_*` (61–64); requests fall through to the default error response and the F# client silently maps that to `0.0f`. Fix: add four cases calling the existing `Economy_get*` engine callbacks.
3. **No `Shutdown` event when the surviving team's enemy dies.** `proxy/src/proxy.c` `handleEvent` does not branch on `EVENT_RELEASE`, so when the engine fires `EVENT_RELEASE` with `reason=1` (game ended) on Spring.GameOver, the surviving AI gets no terminal event and runs to its frame limit. Fix: add an `EVENT_RELEASE` handler that emits a `Highbar__Shutdown` and closes the socket.
4. **`GiveMe` cheat command is also affected.** Likely a phantom of Issue 2 (the resource was given but the query was broken). Re-test after Issues 2 and 1 land; only treat as a separate fix if the retest confirms.
5. **Misleading `CMD_DETAIL enum_move=42` log line bloats infolog.** Hardcoded constant printed for every command at default verbosity. Fix: gate per-command tracing behind a `verbose_commands` config flag (default OFF) and remove the misleading constant when the flag is on.

The technical approach is governed by clarifications recorded in `spec.md § Clarifications`:
- In-scope command set is exactly the FR-002 list (12 commands); other proto cases return non-zero `rc` from the proxy switch table.
- `rc != 0` is purely a proxy-side switch-table check; no engine-effect verification.
- Proto schema changes ARE permitted where needed (the prior "no proto changes" assumption is dropped).
- `CMD_DETAIL` line is gated behind a debug verbosity flag, default OFF, with the misleading `enum_move` constant removed.
- After emitting the GameOver Shutdown event, the proxy MUST close the socket; the bot terminates via the existing `EngineDisconnectedException` path.

## Technical Context

**Language/Version**: C11 (proxy), F# / .NET 10.0 (client and live tests), Protobuf3 (proto schema)
**Primary Dependencies**: protobuf-c (C proxy serialization), Google.Protobuf 3.28 (F# client), Recoil engine SSkirmishAI plugin interface (vendored headers in `proxy/include/AI/`), spring-headless 2025.06.19 (live tests)
**Storage**: Filesystem only — Unix domain sockets for IPC, session directories under `/tmp` for live tests, `engine.infolog` files for trainer sessions
**Testing**: xUnit 2.9.x for F# (live engine tests in `tests/persistent/fsharp/`), CTest/CMake for C proxy (mock engine in `proxy/tests/`); both invoked through `./tests/run-all.sh`
**Target Platform**: Linux x86_64; spring-headless engine via the standard Skirmish AI plugin ABI (no GUI dependency)
**Project Type**: C shared library (`proxy/`) + F# client library (`clients/fsharp/`) + protobuf schema (`proto/`) + live test harness (`tests/`)
**Performance Goals**: Constitution V — total proxy hot-path overhead < 1ms/frame at 30 fps. The four new economy switch cases and the EVENT_RELEASE branch are O(1) constant-time additions. The verbose_commands gate REDUCES default-mode latency by removing per-command snprintf.
**Constraints**: Constitution I (zero engine modifications), Constitution III (1:1 mapping to documented engine struct/callback), Constitution VII (every config flag explicit, default documented, env-overridable). Issue 1 root cause is unknown — diagnostic must complete before any fix is committed.
**Scale/Scope**: 5 issues, 4 changed source files (`proxy/src/callbacks.c`, `proxy/src/proxy.c`, `proxy/src/deserialize.c`, `proxy/src/config.c`), 1 changed F# file (`clients/fsharp/src/Client.fs`), 5–8 new tests across `proxy/tests/` and `tests/persistent/fsharp/`. Estimated total diff: 200–400 lines depending on Issue 1 root cause.

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-checked after Phase 1 design.*

| Principle | Applies? | Verdict | Notes |
|---|---|---|---|
| I. Zero Engine Modifications | Yes | ✅ PASS | All fixes live in `proxy/`, `clients/fsharp/`, and `proto/`. No engine source patches. The Issue 1 diagnostic plan reserves a temporary scenario-local Lua gadget as a last-resort diagnostic — not a permanent change to BAR or the engine. |
| II. Binary Protocol First | Yes | ✅ PASS | Protobuf-only over Unix domain sockets. The economy NaN sentinel is in-band on the existing `float_value` wire field. No JSON, no text protocol additions. |
| III. Correctness Over Cleverness | Yes | ✅ PASS | Each fix is a direct mapping to a documented engine API (`Economy_getCurrent` etc., `SReleaseEvent.reason`). No clever transformations. The Issue 1 fix is intentionally deferred until root cause is known so the fix is direct rather than speculative. |
| IV. Test at the Boundary | Yes | ✅ PASS | Each fix gets both a C round-trip test (mock engine) AND a live-engine F# test in `tests/persistent/`. Issue 1 specifically requires a live test that asserts observable in-engine effect (FR-016), not just engine survival — closing the test gap that allowed 017 to ship without catching the bug. |
| V. Latency Budget Discipline | Yes | ✅ PASS | All additions are O(1) constant-time. The verbose_commands gate is a net latency improvement at default verbosity. No new heap allocations on hot path. The EVENT_RELEASE branch fires once per session, not per frame. |
| VI. Language-Agnostic by Default | Yes | ✅ PASS | Any proto additions (deferred — see research.md) preserve cross-language semantics. The NaN sentinel is reproducible in any client language via the standard IEEE 754 float check. The new `verbose_commands` flag is configured at the proxy boundary, not in any client. |
| VII. Explicit Over Implicit | Yes | ✅ PASS | The new `verbose_commands` flag has an explicit default (OFF), is documented in `AIOptions.lua`, and is overridable via `HIGHBAR_VERBOSE_COMMANDS` env var. The Shutdown event reason is explicit (`SHUTDOWN_REASON_GAME_OVER`), not inferred. The economy NaN sentinel is documented alongside the F# wrapper. |

**Gate result**: PASS. No principles require justification in the Complexity Tracking table.

## Project Structure

### Documentation (this feature)

```text
specs/029-fix-trainer-issues/
├── plan.md              # This file (/speckit.plan command output)
├── spec.md              # Feature specification with clarifications
├── research.md          # Phase 0 — root cause analysis per issue
├── data-model.md        # Phase 1 — entity / message changes
├── quickstart.md        # Phase 1 — manual verification recipe
├── contracts/           # Phase 1 — proxy ↔ client contract additions
│   ├── economy-callbacks.md
│   ├── shutdown-event.md
│   └── command-dispatch.md
├── checklists/
│   └── requirements.md  # Spec quality checklist (already complete)
└── tasks.md             # Phase 2 output (NOT created by /speckit.plan)
```

### Source Code (repository root)

```text
proto/
└── highbar/
    ├── callbacks.proto       # CALLBACK_ECONOMY_GET_* enum (already declared, no edit)
    ├── messages.proto        # ShutdownReason enum (existing values reused)
    └── commands.proto        # AICommand oneof (no edit; in-scope set per FR-002)

proxy/
├── include/
│   ├── AI/
│   │   ├── AISCommands.h           # Engine struct definitions (read-only reference)
│   │   ├── AISEvents.h             # Event topics including EVENT_RELEASE = 2
│   │   └── SSkirmishAICallback.h   # Engine callback table (Economy_get* at lines 454-460)
│   └── highbar/
│       ├── config.h                # ProxyConfig struct — ADD verbose_commands bool
│       ├── deserialize.h           # No change
│       └── engine_types.h          # No change
├── src/
│   ├── callbacks.c                 # ADD 4 ECONOMY cases
│   ├── proxy.c                     # ADD EVENT_RELEASE branch in handleEvent + gate per-command tracing
│   ├── deserialize.c               # MAYBE EDIT for Issue 1 fix; remove orphan stderr fprintf
│   └── config.c                    # ADD verbose_commands key parsing
└── tests/
    ├── test_callbacks.c            # ADD economy-cases round-trip tests
    ├── test_deserialize.c          # ADD assertions for Issue 1 fix once root cause known
    └── mock_engine.{c,h}           # ADD mock Economy_getCurrent / Economy_getIncome stubs

clients/fsharp/
└── src/
    └── Client.fs                   # ADD NaN-aware economy wrappers (~6 lines)

tests/
├── integration/fsharp/
│   └── CommandTests.fs             # No change
└── persistent/fsharp/
    ├── T029_NonMoveCommandEffect.fs  # NEW — live FR-016 test for Issue 1
    ├── T029_EconomyCallbacks.fs      # NEW — live FR-017 test for Issue 2
    └── T029_GameOverShutdown.fs      # NEW — live FR-018 test for Issue 3
```

**Structure Decision**: Single-project layout matching existing HighBarV2 conventions. The proxy is a C shared library with vendored engine headers; the F# client lives in `clients/fsharp/`; live tests live in `tests/persistent/fsharp/` per the 028-adapt-test-harness pattern. No new top-level directories.

## Phase 0: Outline & Research

**Status**: ✅ Complete. See [`research.md`](research.md).

**Summary of unknowns resolved**:

| Issue | Unknown at spec time | Resolution |
|---|---|---|
| 2 — Economy | Where does the proxy lose the value? | `proxy/src/callbacks.c` switch has no cases for IDs 61–64. Fix is 4 added cases calling `callback->Economy_getCurrent/Income/Usage/Storage`. |
| 3 — Shutdown | What engine API tells the proxy "GameOver"? | `EVENT_RELEASE = 2` (`AISEvents.h:33`) with `SReleaseEvent.reason = 1` ("game ended", `AISEvents.h:104-120`). Fires for surviving AIs before the engine calls `release()`. |
| 5 — Debug log | Where does the misleading line come from? | `proxy/src/proxy.c:218-223` hardcodes `HIGHBAR__AICOMMAND__COMMAND_MOVE_UNIT` (constant `42`) into the second `%d`. |
| 1 — Non-Move commands | What's the actual root cause? | **Unresolved from headers alone.** Engine source unavailable. Plan includes a diagnostic spike (5 hypotheses, ranked by likelihood) executed against the live engine before any fix is committed. |
| 4 — GiveMe | Is GiveMe really broken or a phantom of Issue 2? | Indeterminate from findings. Plan defers the determination to a re-test after Issue 2 lands. |

**Remaining NEEDS CLARIFICATION at plan time**: Issue 1 root cause. **This is acknowledged and managed**: the implementation phase begins with a diagnostic task whose deliverable is "we know which hypothesis is correct" before any fix is written. The plan does not commit to a specific fix shape for Issue 1 — it commits to the diagnostic process.

## Phase 1: Design & Contracts

**Status**: ✅ Complete. See [`data-model.md`](data-model.md), [`contracts/`](contracts/), and [`quickstart.md`](quickstart.md).

### Entities (data-model.md)

This feature does not introduce new persistent data entities. The "data model" is the protobuf message and engine struct surface that crosses the proxy boundary. Three categories are touched:

1. **`AICommand` oneof (commands.proto)** — no schema change, but the in-scope set per FR-002 is documented.
2. **`CallbackResult.float_value` oneof case** — repurposed (no schema change) to carry economy values; NaN is the in-band sentinel for invalid `resourceId`.
3. **`Highbar__Shutdown` message + `Highbar__ShutdownReason` enum** — no schema change; the existing `SHUTDOWN_REASON_GAME_OVER` is reused.

### Contracts

Three contract documents in `contracts/` capture the precise wire-level behavior change for each user story (US1, US2, US3). They are written as "before / after" tables so a future bot author can read them as the canonical proxy ↔ client contract for these surfaces.

### Quickstart

A manual verification recipe for the feature: build, install, run a 1v1 headless match, observe each of the five issues fixed.

### Agent context update

To be run after this plan is reviewed. The script `update-agent-context.sh claude` updates `CLAUDE.md` with any new technology entries. This feature introduces no new languages, no new dependencies, and no new external services — only new code within existing C/F#/protobuf files. The agent context update will likely add a single line for the 029 feature noting "added live-engine assertions for non-Move command effect" or be a no-op.

## Phase 2: Tasks (deferred to /speckit.tasks)

The `/speckit.tasks` command will generate `tasks.md` ordered by user story priority. The expected task structure (for plan-phase visibility only, not committed here):

- **Phase A — Quick wins**:
  - T1: Issue 5 — add `verbose_commands` config flag, gate `proxy.c` per-command tracing, delete misleading `enum_move` constant.
  - T2: Issue 2 — add 4 economy cases in `callbacks.c`, mock_engine stubs, C round-trip test, F# Client.fs NaN wrapper, live `T029_EconomyCallbacks.fs`.
  - T3: Issue 3 — add `EVENT_RELEASE` branch in `proxy.c` `handleEvent`, live `T029_GameOverShutdown.fs`.
- **Phase B — Diagnostic + fix**:
  - T4: Issue 1 — write `T029_NonMoveCommandEffect.fs` that asserts observable effect for each in-scope command type. Confirm it FAILS today (regression baseline).
  - T5: Issue 1 — execute diagnostic hypotheses 1→5 from `research.md`, identify root cause.
  - T6: Issue 1 — implement the fix per identified root cause; T029_NonMoveCommandEffect.fs must now PASS.
  - T7: Issue 1 — also extend `T6.11` and friends in `T6_CommandCoverage.fs` to assert effect (not just survival).
- **Phase C — Verification**:
  - T8: Issue 4 — re-run the trainer scenario (or a mini-version) post Issues 1+2 fix; confirm GiveMe works or open as a residual.
  - T9: Run the full `./tests/run-all.sh` matrix; ensure no regression in existing live or persistent tests.

## Complexity Tracking

> No constitution gate violations. Table empty.

| Violation | Why Needed | Simpler Alternative Rejected Because |
|-----------|------------|-------------------------------------|
| _(none)_ | _(none)_ | _(none)_ |
