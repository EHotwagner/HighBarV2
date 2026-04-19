# Implementation Plan: Fix Scripting Command Dispatch

**Branch**: `033-fix-scripting-dispatch` | **Date**: 2026-04-19 | **Spec**: [spec.md](./spec.md)
**Input**: Feature specification from `/specs/033-fix-scripting-dispatch/spec.md`

## Summary

External scripting clients (FSBarV1 Hub → HighBar.Client → bundled proxy → engine) issue well-formed `BuildUnitCommand`s that produce zero engine-side effect, while the in-process trainer driving the same wire format works. This plan investigates root cause through (1) always-on proxy dispatch logging, (2) a HighBarV2-side reproduction harness that bypasses FSBarV1's gRPC layer, (3) a regression test exercising the full scripting → proxy → engine path. The fix may be in the proxy (oneof dispatch, position handling), in HighBar.Client (frame-thread vs sync drain semantics), or in stale bundled-proxy SHA on the FSBarV1 side; the investigation determines which and corrects it.

## Technical Context

**Language/Version**: C11 (proxy), F# / .NET 10.0 (client + tests)
**Primary Dependencies**: protobuf-c (proxy), Google.Protobuf 3.28 (client), Recoil `SSkirmishAICallback` (read-only), spring-headless 2025.06.19, xUnit 2.9.x
**Storage**: Filesystem only — Unix domain sockets, session dirs in `/tmp`
**Testing**: xUnit (F# integration + persistent), CTest/CMake (C unit), live headless engine
**Target Platform**: Linux (proxy `.so` loaded by `spring-headless`)
**Project Type**: Multi-language repo — C shared library + F# client library + live test harness
**Performance Goals**: Per-frame proxy overhead <1ms (constitution V); always-on dispatch log adds at most one `snprintf` + `Log_log` per non-empty `FrameResponse` (typically 0–few/frame, not per frame)
**Constraints**: Zero engine modifications (constitution I); no protocol changes that other-language clients can't replicate (VI); explicit logging at INFO for dispatch lifecycle (VII)
**Scale/Scope**: One scripting test scenario (Avalanche 3.4 skirmish, single `BuildUnitCommand`), one regression test, ≤50 LOC of proxy diff expected, possible HighBar.Client patch

## Constitution Check

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | ✅ | Fix lives in proxy and/or client; no engine patching. |
| II. Binary Protocol First | ✅ | No protocol additions; same `AICommand` oneof, same wire framing. |
| III. Correctness Over Cleverness | ✅ | Goal is to make dispatch deterministic and identical across origins; explicitly the opposite of clever. |
| IV. Test at the Boundary | ✅ | Adds a wire-level regression test that drives the proxy from a synthetic AI process and asserts engine-observable effect. |
| V. Latency Budget Discipline | ✅ | Always-on dispatch log fires only when `n_commands > 0` (rare frames); WARN-on-unsupported-oneof fires only on a default-branch hit (never in steady state). No hot-path allocation added. |
| VI. Language-Agnostic by Default | ✅ | No schema changes. Behaviour is restored to match the wire contract that any language client can emit. |
| VII. Explicit Over Implicit | ✅ | Removes implicit "silent drop" behaviour; surfaces engine return codes; logs dispatch lifecycle. Directly fixes a VII violation. |

**Gate decision**: PASS for Phase 0. No complexity-tracking entries needed.

## Project Structure

### Documentation (this feature)

```text
specs/033-fix-scripting-dispatch/
├── plan.md              # This file
├── research.md          # Phase 0: hypothesis ranking, repro design, BuildPosition.Y answer
├── data-model.md        # Phase 1: dispatch-log entity + return-code taxonomy
├── quickstart.md        # Phase 1: how to run the regression repro locally
├── contracts/
│   └── dispatch-log.md  # Phase 1: contract for proxy dispatch log line format
├── checklists/
│   └── requirements.md  # Spec quality checklist (already exists)
└── tasks.md             # Phase 2 — created by /speckit.tasks
```

### Source Code (repository root)

```text
proxy/
├── src/
│   ├── proxy.c               # MODIFY: always-on dispatch logging in the FrameResponse loop
│   └── deserialize.c         # MODIFY (if needed): WARN log on default-branch oneof miss
├── include/highbar/
│   └── deserialize.h         # MAY MODIFY: expose oneof-case → name helper for logs
└── tests/
    └── test_dispatch.c       # NEW (optional): C-level verification that all oneof cases route

clients/fsharp/
├── HighBar.Client/
│   ├── BarClient.fs          # INVESTIGATE: frame-thread vs sync drain; possible MODIFY
│   └── Protocol.fs           # READ-ONLY reference (FSBarV1's traced sender mirrors this)
└── HighBar.Client.IntegrationTests/  (or PersistentTests/)
    └── ScriptingDispatchTests.fs     # NEW: regression test, drives proxy from synthetic AI process

specs/033-fix-scripting-dispatch/
└── (artefacts above)

Mailbox/
└── 2026-04-19_to_FSBarV1_scripting-dispatch-fixed.md  # NEW: reply with root cause + version bump
```

**Structure Decision**: Use the existing multi-language layout. The fix is constrained to `proxy/src/` (logging + possibly behavioural fix) and a new test under `clients/fsharp/`. No new top-level directories. The agent context file is updated to register this feature's tech additions (which are subset-of-existing — no new entry needed beyond the auto-generated line).

## Phase 0 — Research (research.md)

Resolve four open questions before writing code:

1. **Bundled proxy SHA freshness** — confirm the proxy bytes shipped in FSBarV1's `BundledProxy.fs` are byte-identical to `HighBarV2/master` HEAD's built artefact. If stale, the bug is on the FSBarV1 side (just bump the SHA) and the rest of this plan reduces to FR-002/003 (logging hygiene) + FR-008 (regression test).
2. **Trainer-vs-scripting code-path divergence** — read `clients/fsharp/HighBar.Client/BarClient.fs` and confirm whether `SendCommands` queues commands into a structure that is drained by *both* `WaitFrames` (sync) and the background frame thread, or whether one path bypasses the other. Specific suspect: `BarClient.fs:86` background frame thread referenced in mailbox.
3. **Proxy oneof dispatch completeness** — verify `hb_deserialize_and_execute` (already read in spec phase) covers `COMMAND_BUILD_UNIT` (✅ confirmed line 40), and that the iteration in `proxy.c:212` reaches it for every command. Identify whether the trainer happens to use a path that succeeds in `verbose_commands=true` runs while scripting does not.
4. **`BuildPosition.Y` engine semantics** — empirically test whether `Engine_handleCommand(COMMAND_BUILD_UNIT, ...)` with a Y of 1989 (mailbox value) is rejected vs. ground-snapped vs. accepted. Use the existing `tools/echo-ai/` or a new minimal driver that issues one build at a known spot via the engine callback directly.

Each question gets a Decision / Rationale / Alternatives entry in `research.md`. Do not begin Phase 1 until all four are answered.

## Phase 1 — Design & Contracts

Produced after Phase 0 completes:

1. **`data-model.md`** — define the dispatch-log record: fields (`frame`, `oneof_case_name`, `unit_id`, `engine_rc`, `bytes`), severity ladder (INFO for accepted, WARN for engine_rc<0, WARN for unsupported oneof), and the engine-rc taxonomy as documented in `proxy/include/AI/` headers.
2. **`contracts/dispatch-log.md`** — the exact log-line format the regression test will grep for. Stable across releases so downstream tooling (FSBarV1 `FSBAR_TRACE_DISPATCH`, future log scrapers) can rely on it. One line per dispatched command, machine-parseable key=value, e.g.:

   ```
   [HB] dispatch frame=76 case=BUILD_UNIT unit=25947 engine_rc=0
   ```

3. **`quickstart.md`** — copy-pasteable steps: build proxy, run new xUnit regression test, run FSBarV1 Python repro for end-to-end validation, expected output snippets. Includes the engine prerequisite check.
4. **Agent context update** — run `.specify/scripts/bash/update-agent-context.sh claude` to append the feature's tech line to `CLAUDE.md`. No new technology beyond what's already registered.
5. **Re-evaluate Constitution Check** — re-confirm gates after research lands (especially V if Phase 0 surfaces a fix that adds hot-path work).

## Complexity Tracking

No constitution violations identified. Table omitted.

## Post-Implementation Gate Re-check (2026-04-19)

Re-evaluating gates I / V / VII after landing T006–T008 + T012/T013 diagnostics:

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | ✅ | No engine source touched. Debugging stayed at the AI-API boundary (`Engine_handleCommand` return value + infolog). |
| V. Latency Budget Discipline | ✅ | Always-on dispatch log fires one `snprintf` + `Log_log` per non-empty `AICommand` (≤1 per tick in typical AI usage). No hot-path allocations added. |
| VII. Explicit Over Implicit | ✅ | Silent drop in the `deserialize.c` default branch replaced with a proxy-side `[HB] dispatch case=UNKNOWN(<n>)` WARN line. Engine return code now surfaced on every dispatch. Directly improves the VII posture that motivated this feature. |

Gates hold post-implementation. The one spec-level goal not met (US1 independent test: build-command produces nanoframe) is documented as deferred to feature 034 with the reason recorded in the mailbox reply — not because of a gate violation but because diagnosis proved the bug is below the proxy↔engine API contract and requires a narrower follow-up probe.
