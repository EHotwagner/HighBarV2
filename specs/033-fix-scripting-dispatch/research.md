# Phase 0 — Research

**Feature**: 033-fix-scripting-dispatch
**Date**: 2026-04-19

Four open questions from the plan's Phase 0; each is answered with Decision / Rationale / Alternatives. Where the answer requires running the FSBarV1 repro, the question is staged for the implementation phase but the investigation strategy is fixed here.

## Q1 — Is the bundled proxy SHA in FSBarV1 stale vs HighBarV2 master?

**Decision**: Verify out-of-band before any proxy code change. The implementation phase MUST start by computing `sha256sum` of `proxy/build/libhighbar.so` on HighBarV2 `master` (commit `eb24a1d` at spec time) and comparing against the SHA recorded in FSBarV1 `src/FSBar.Hub/BundledProxy.fs`. If different, FSBarV1 is shipping an old proxy and the substantive fix may already be in master.

**Rationale**: The mailbox author explicitly notes "the trainer doesn't exercise [the wire path] — it uses `BarClient.WaitFrames` + `SendCommands` locally". This means *neither* path has been recently exercised end-to-end on the bundled SHA. A stale bundle is the cheapest explanation and must be ruled out first.

**Alternatives considered**: Skip the SHA check and dive straight into proxy debugging — rejected because we'd risk re-fixing something already fixed, and because shipping a fresh build is required regardless to deliver FR-009.

## Q2 — Trainer-vs-scripting code path divergence in the F# layer

**Decision**: The HighBarV2 `HighBar.Client` library (this repo, `clients/fsharp/src/Client.fs`) emits `FrameResponse` from a single code path; it has no concept of "trainer" vs "scripting". Both labels are FSBarV1 wrapper concepts. Therefore any divergence lives in FSBarV1's `BarClient.fs` / `Protocol.fs` (referenced in the mailbox) — *not* in HighBar.Client. From HighBarV2's side the contract is: "any well-formed `FrameResponse` over an established proxy connection MUST be dispatched". The fix and regression test live at that contract level.

**Rationale**: Searching `clients/fsharp/src/Client.fs` for `FrameResponse` shows ~5 sites that all build the same `FrameResponse()` and write it back via the same socket loop (lines 169, 189, 225, 247, 317). There is no branch on origin or socket identity. Confirms the bug — if any — is in (a) the proxy's processing of `FrameResponse`, or (b) FSBarV1's own dispatch into HighBar.Client. We can only fix (a).

**Alternatives considered**: Treat HighBar.Client as suspect and add tracing there — rejected; mailbox already proved the F# wire output is identical, and adding HighBar.Client tracing would not catch a divergence that exists only inside FSBarV1.

## Q3 — Proxy oneof dispatch completeness

**Decision**: `hb_deserialize_and_execute` (`proxy/src/deserialize.c`) covers `COMMAND_BUILD_UNIT` correctly at line 40, and `proxy.c:212` iterates every `fr->commands[i]` without a short-circuit. There is no obvious "subset" handling. The remaining unknown is whether `Engine_handleCommand` returns success (0) or a negative rc when called with the mailbox's payload. **This unknown can only be answered with logs.** Therefore FR-002 (always-on dispatch logging) is a *prerequisite* for diagnosing the actual bug — it must land first, then we re-run the FSBarV1 repro to read the engine's verdict.

**Rationale**: The current code only logs dispatch when `verbose_commands` is set (`proxy.c:207-238`). The mailbox repro was run without that flag, so we have no data on the engine's return code. Adding the log is cheap (one `snprintf` per command, only fires on non-empty `FrameResponse`) and constitution-V-safe.

**Alternatives considered**: Ask FSBarV1 to re-run with `verbose_commands` enabled — rejected; the proxy contract must not require an opt-in flag for basic observability of a known-broken path (constitution VII: Explicit Over Implicit).

## Q4 — Does `BuildPosition.Y = 1989` matter for `COMMAND_BUILD_UNIT`?

**Decision**: Empirical question to resolve during implementation. Strategy: write a one-shot C harness (or extend an existing CTest) that calls `Engine_handleCommand(COMMAND_BUILD_UNIT)` directly with two payloads — one with the mailbox's Y=1989, one with ground-snapped Y from `Map_getElevationAt(x, z)` — and observe the return code plus engine-side effect. Until the harness runs, the working assumption (informed by Recoil source reading and prior trainer experience) is **the engine ignores Y for build orders and snaps to ground internally**, which would mean Y is not the bug.

**Rationale**: A direct callback test isolates Y from every other variable (oneof routing, wire framing, connection origin). This is the smallest possible experiment that answers the mailbox's third ask definitively.

**Alternatives considered**: (a) Read Recoil engine source to confirm Y handling — rejected per constitution I (no engine source dependence) and because behavior is the contract, not source. (b) Accept the mailbox's hunch and ground-snap inside the proxy — rejected because we'd be adding unrequested transformation that violates correctness-over-cleverness (III).

## Bundled SHA (T002 / T003 — 2026-04-19)

Built `build/libSkirmishAI.so` on `033-fix-scripting-dispatch` (parent master commit `eb24a1d`) and compared against the bundled proxy FSBarV1 actually loads at runtime. Note: tasks.md T001 says `libhighbar.so`, but the CMake target is `SkirmishAI` → `libSkirmishAI.so`; BundledProxy.fs also loads `libSkirmishAI.so`. Treating the filename in T001 as a doc typo.

| Source | Path | sha256 |
|--------|------|--------|
| HighBarV2 fresh build | `build/libSkirmishAI.so` | `90f90317fa0d96ed3797053120c67e6f74185fdbf2e2de574689b228e206e980` |
| FSBarV1 bundled | `FSBarV1/proxy/bundled/0.1/libSkirmishAI.so` | `4c9a2b908ca8fcc85dcb21cbf8ee8de36f56a2814015c332d589bd33d06122d9` |

`FSBarV1/proxy/BUNDLED_VERSION` = `0.1`. **SHAs diverge.** Per T003 this MUST trigger a STOP-and-re-evaluate: the fix may already be in master, and the cheapest path forward may be to (a) re-bundle the fresh `libSkirmishAI.so` into FSBarV1 and re-run `diag_one_build.py` before writing any proxy code. If the re-bundled run still fails, proceed with T004+ as planned.

**Re-run result (2026-04-19):** Re-bundled the fresh `libSkirmishAI.so` into FSBarV1 and re-ran `diag_one_build.py`. Commander still frozen at `(500,397)` through frame 1500; no nanoframe. **The bug reproduces on master HEAD's proxy** — this is not a stale-bundle issue. Proceeding with T004+ (always-on dispatch logging) to diagnose.

Note: `BundledProxy.fs` (in FSBarV1) resolves the proxy by version from `proxy/bundled/<VERSION>/`; it does not embed bytes. So "stale SHA" here means a stale artefact on disk in the FSBarV1 checkout, not an embedded constant.

## Q2 Resolution (T005a — 2026-04-19)

Audited `clients/fsharp/src/Client.fs` (the HighBar.Client library in this repo; FSBarV1 wraps it). `FrameResponse` is constructed at exactly 5 sites (lines 169, 189, 225, 247, 317), all within the single socket-writer loop; no branch on origin, socket identity, connection age, or any "trainer-vs-scripting" discriminator. `SendCommands` pushes into a common pending-commands list that both the synchronous `WaitFrames`/`StepFrame` path and the background replay-buffer drain consume — no origin-based rewriting exists. FR-005 (no silent origin rewriting) verified by construction at the HighBarV2 layer. Any trainer-vs-scripting divergence therefore lives in FSBarV1's wrappers, not HighBar.Client.

## Q3 Resolution (T008 — 2026-04-19)

With always-on `[HB] dispatch` logging landed (T006/T007) and the fresh proxy re-bundled into FSBarV1, re-ran `diag_one_build.py`. Infolog (`/tmp/fsbar-a7dfb36a/infolog.txt`; tail saved to `diagnosis.log`):

```
[t=00:00:09.324409][f=0000074] Skirmish AI <HighBar V2 - Native Proxy Bridge-0.1>: [HB] dispatch frame=74 case=BUILD_UNIT unit=25947 engine_rc=0
```

**Root-cause finding**: the proxy **does** reach dispatch, routes `BUILD_UNIT` correctly, calls `Engine_handleCommand`, and **receives `engine_rc=0` (success)** — yet the commander never builds through 1500 frames. This rules out hypotheses (a) iteration short-circuit, (b) oneof mis-routing, (c) handshake-gated dispatch. It also rules out a proxy-side encoding error detectable by the engine API: the engine accepts the call.

The remaining live hypotheses are all **payload-semantic** rather than dispatch-mechanical:

1. **BuildPosition.Y out of bounds** (mailbox §Asks.3). Y=1989 is well above any plausible Avalanche 3.4 ground elevation; the engine may accept the handleCommand call but internally fail the build order when queuing against the unit. This is the Q4 question and now the single most likely cause.
2. **INTERNAL_ORDER (opt=8) semantics** — option flag 8 is `INTERNAL_ORDER` in our `Commands.fs`, but if Recoil's current interpretation of that flag on an AI-origin BUILD command is "silently drop / don't queue", the same symptom would appear. Lower-probability than (1) since the trainer path also sets INTERNAL_ORDER=8 and works in its own (non-proxy) code path.
3. **UnitId ownership check** — `unit=25947` is the commander; AI "took over control of team 0" per infolog line 1655, so this should pass, but a callback-layer ownership bitset mismatch can't be 100% ruled out.

**This is NOT a proxy dispatch bug.** T014 therefore collapses to "no proxy change required" unless T012's BuildPosition.Y experiment implicates the proxy's position handling (e.g. a call to ground-snap Y). The fix most likely lives on the caller side (scripting client must ground-snap Y before sending) or in a proxy-side convenience snap (T014 option c). T012 is the next required experiment to discriminate.

## Q4 Resolution (T012/T013 — 2026-04-19)

**Y does NOT matter. INTERNAL_ORDER does NOT matter.** Three back-to-back runs of `diag_one_build.py` against the same proxy build, varying one field each time:

| Run | Change from mailbox baseline | Dispatch line | Nanoframe? |
|-----|------------------------------|----------------|------------|
| 1 | *(none — mailbox repro, Y=1989, opt=8)* | `frame=74 case=BUILD_UNIT unit=25947 engine_rc=0` | no |
| 2 | `y=0.0` in place of `y=sp0.y=1989` | `frame=81 case=BUILD_UNIT unit=25947 engine_rc=0` | no |
| 3 | `options=0` in place of `INTERNAL_ORDER(8)` | `frame=78 case=BUILD_UNIT unit=25947 engine_rc=0` | no |

All three produce `engine_rc=0` with zero engine-side effect. This **rules out BuildPosition.Y**, **rules out INTERNAL_ORDER flag semantics**, and collapses the list of remaining proxy/wire hypotheses to near-empty. The `T12_BuildPositionY.fs` live-engine xUnit test was written and compiled but ran into persistent-harness instability (frame-response timeout during fixture init at frame ~1640, before T12 could exercise a BuildCommand), so the three variant measurements above are the authoritative answer instead.

**T013 decision**: answer is **(a) Y is not the bug**. No caller-side ground-snap or proxy-side snap is required. The question in the mailbox ("Tell us whether `BuildPosition.Y` matters") is answered: no, it doesn't — the engine accepts the handleCommand call identically for any Y and produces no build.

**Remaining live hypotheses** (outside this feature's diagnostic budget):

1. `toId` parameter semantics for per-unit commands — the proxy passes `COMMAND_TO_ID_ENGINE (-1)`, per the API doc. If Recoil actually expects the unit_id here for BUILD/MOVE/etc., the handleCommand would accept and silently drop. **Most likely remaining cause.**
2. A missing post-command step (e.g., `Engine_executeCommand` on line 51 of `SSkirmishAICallback.h`, which the proxy never calls — it only uses `Engine_handleCommand`).
3. Some engine-internal ownership check keyed on the AI's registered team-set that silently rejects the unit_id.

Each of these requires either reading Recoil source (constitution I forbids) or a focused C-level harness that probes both `toId` variants against a live engine. Recommend addressing in a follow-up feature with a narrower scope (033b or 034).

## Summary of decisions feeding Phase 1

- **Always-on dispatch logging** is the first concrete change and the diagnostic basis for everything else.
- **Regression test** drives the proxy from a synthetic AI-side process emitting a single `BuildUnitCommand` `FrameResponse`, asserts engine-observable effect (new unit appears) within a frame budget. Independent of FSBarV1 entirely.
- **`BuildPosition.Y` answer** comes from a small direct-callback experiment, not from spec'd assumption.
- **Bundled-SHA freshness check** is task #1 in implementation; may collapse the rest of the work.
