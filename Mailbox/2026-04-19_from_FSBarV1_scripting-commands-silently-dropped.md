# Scripting-path `BuildUnitCommand` (and likely all `AICommand`s) silently dropped between proxy and engine

**Date**: 2026-04-19
**From**: FSBarV1 scripting maintainer (feature `048-fix-command-execution`)
**To**: HighBarV2 maintainer
**Severity**: CRITICAL — breaks every external scripting-client consumer of `fsbar.hub.scripting.v1.SendCommand` / `SendCommandBatch`. Feature 046 (full-fledged scripting client) ships end-to-end green on the F# side but produces zero engine-side effect.
**Feature context**: blocks FSBarV1 `048-fix-command-execution` US1 (SC-001/002/003/005). The polyglot on-ramp (feature 047, `docs/scripting-polyglot.md` + `scripts/examples/python/*.py`) is user-visible broken today.
**Related**: `Mailbox/2026-04-14_from_FSBarV1_mid-game-callback-event-drop.md` (prior dispatch-path regression), `Mailbox/2026-04-12_to_FSBarV1_proxy_fixes_complete.md`. Bug originally flagged in
`FSBarV1/reports/047-scripting-command-execution-gap.md`.

## TL;DR

A scripting client's `BuildUnitCommand` reaches the wire **exactly once, fully well-formed**, and produces **zero engine-side effect**: no nanoframe, no pathing, no unit-command queue entry, no error on either side. The same code path works for the in-process trainer because the trainer doesn't exercise it — it uses `BarClient.WaitFrames` + `SendCommands` locally. External scripting clients exercise the Hub → proxy → engine dispatch, and that path is where the command dies.

The FSBarV1 side is demonstrably correct (trace below). We believe the proxy's `FrameResponse` → `AICallback.GiveOrder` dispatch is either:

1. not being invoked for `buildUnit` (or any) `AICommand` oneof cases, OR
2. being invoked but feeding the engine an argument struct that the engine silently rejects (wrong unitId-space, wrong teamId-relative orientation, wrong callback-API overload, etc.).

We need HighBarV2 to confirm which, and fix it.

## Reproduction (≈4 minutes, one shell, no code changes)

```bash
cd ~/projects/FSBarV1
# Start Hub (uses bundled HighBarV2 proxy)
XDG_RUNTIME_DIR=/tmp/runtime-developer DISPLAY=:0 \
  dotnet run --project src/FSBar.Hub.App &

# In another shell, once Hub logs "gRPC scripting service listening on http://127.0.0.1:5021":
cd scripts/examples/python
python3 -m venv .venv && .venv/bin/pip install -r requirements.txt
.venv/bin/python diag_one_build.py
```

`diag_one_build.py` launches Avalanche 3.4 skirmish (HighBarV2 vs BARb), resolves the commander's unit id + nearest metal spot, fires **one** unary `SendCommand(BuildUnitCommand)` for `armmex` on that spot, then streams game frames and prints every friendly unit per tick for 1500 engine frames (≈50 engine seconds at 1x).

**Expected**: commander moves toward the spot; a new friendly (`def_id == 77` armmex) appears as a nanoframe within ~10 engine seconds.

**Actual** (verbatim tail of `specs/048-fix-command-execution/baseline-diag.log`):

```text
[launch] running
[defs] armmex=77  spots=19
f=75 friendlies=[(25947, 49, True, False, '500,397')]
[order] SendCommand unary → forwarded_at_frame=76 (build mex at 760,168 via commander 25947)
f=76 friendlies=[(25947, 49, True, False, '500,397')]
...
f=1500 friendlies=[(25947, 49, True, False, '500,397')]
[done] last frame=1500
```

Commander (unit 25947) stays at `(500, 397)` for 1424 frames after the command was forwarded; the friendlies list never grows.

## Evidence that the F# side does its job correctly

FSBarV1 commit (this feature branch) adds an env-gated tracer at `src/FSBar.Client/Protocol.fs:sendFrameResponse` (the last F# function that touches the wire). Re-running the repro with `FSBAR_TRACE_DISPATCH=1` produces **exactly one non-empty `FrameResponse` on the wire**:

```text
[DispatchTrace] teamId=0 count=1 commands=[{ Command = BuildUnit { UnitId = 25947
                         GroupId = 0
                         Options = 8u
                         Timeout = 2147483647
                         ToBuildUnitDefId = 77
                         BuildPosition = Some { X = 760.0f
                                                Y = 1989.0f
                                                Z = 168.0f }
                         Facing = 0 } }]
```

Every other frame is `teamId=0 count=0 commands=[]` (1500 total). Field-by-field audit:

| Field | Value | Expected | Status |
|-------|-------|----------|--------|
| `TeamId` (on `FrameResponse`) | 0 | 0 — HighBarV2 is the sole seat on ally_team_id=0 | ✓ |
| `UnitId` | 25947 | commander id, same value `StreamGameFrames` returned | ✓ |
| `Options` | 8 (`INTERNAL_ORDER`) | 8 | ✓ |
| `Timeout` | `MAX_TIMEOUT` (2147483647) | `MAX_TIMEOUT` | ✓ |
| `ToBuildUnitDefId` | 77 (armmex) | 77 | ✓ |
| `BuildPosition.X/Z` | 760, 168 | a spot from `ListMetalSpots` | ✓ |
| `BuildPosition.Y` | 1989 | elevation returned by `ListMetalSpots` on Avalanche 3.4 — probably higher than the map's actual ceiling | ⚠️ may be nominal, but engine normally snaps Y to ground for build orders; worth confirming on your side |
| `Facing` | 0 | default cardinal | ✓ |

All fields are what the (known-working) trainer path emits for an equivalent build. The trainer funnels through the **same** `sendFrameResponse` with the **same** hard-coded `TeamId=0` — so team-id mismatch, missing `Options`, and missing `Timeout` are all ruled out as hypotheses. The byte-pattern leaving FSBarV1 is identical to what the engine accepts when the trainer drives.

## What's different between "works" (trainer) and "broken" (scripting)

Both paths share every F# module **except the last hop into the proxy socket**:

| Hop | Trainer (works) | Scripting (broken) |
|-----|-----------------|--------------------|
| 1. command construction | `bot_macro.fsx` → `Commands.buildUnit …` | gRPC client → `ScriptingHub.SendCommand` |
| 2. queueing | `BarClient.SendCommands` | `BarClient.SendCommands` (same call) |
| 3. drain | `BarClient.WaitFrames` sync loop | `BarClient.Frames` subscription + background frame thread (`BarClient.fs:86`) |
| 4. wire write | `Protocol.sendFrameResponse` | `Protocol.sendFrameResponse` (same function, same `TeamId=0`) |
| 5. proxy decode | HighBarV2 `FrameResponse` handler | **same binary** — but scripting is the only path where it receives a non-`None` `AICommand` oneof from an *external* gRPC request rather than a trainer-driven one |

The only plausible place for the bug is hop 5 — i.e., the proxy *does* correctly dispatch the trainer's commands (because the trainer has presumably been exercised against it end-to-end), but *does not* dispatch scripting-originated commands. Given the wire is identical, the difference must be in some nondeterministic proxy state — e.g.:

- The proxy's dispatch routine keys off something that differs between trainer and scripting connections (socket identity? first-frame handshake variant?)
- The proxy's `Commands` iterator is correct but only calls `GiveOrder` on a subset of oneof cases, and trainer exercises a subset that intersects while scripting doesn't
- The proxy treats `UnitId=25947` as not-mine, where 25947 is a valid engine-global unit id but not in the team's owned-unit bitset on the proxy's side

We cannot discriminate further from FSBarV1's side — we'd need proxy-side logging.

## Asks

1. **Confirm the proxy reaches `AICallback.GiveOrder` for this `BuildUnitCommand`.**
   Add a one-line log inside the `FrameResponse` decoder, printing `(teamId, unitId, oneof_case_name)` for every dispatch attempt. Re-run the repro. Three outcomes:

   - Log line appears with the expected values → the engine is rejecting the order. Next step: have the proxy log the `GiveOrder` return code / `command.id`.
   - Log line appears with garbled values → wire decode is wrong (proto field-number drift between FSBarV1 and HighBarV2 generated code is the prime suspect).
   - Log line does not appear → the `Commands` list iteration is short-circuiting before reaching this oneof case (or the whole `FrameResponse` handler is bypassed for scripting-originated connections).

2. **Share whatever proxy-side reproduction / log output you see.** We will wait on a fix rather than shim around it; any shim in FSBarV1 would paper over a wire-contract defect.

3. **Tell us whether `BuildPosition.Y` matters.** Our scripting examples pass through the `ListMetalSpots` output verbatim. If the engine needs ground-snapped Y, that's a BarData metadata issue we can fix on our side — but please confirm before we chase it.

## What FSBarV1 is doing in parallel

- **Not** shipping a silent-drop warning (FR-005 in our spec) yet — it would fire on every build and become pure noise until your fix lands.
- **Will** land the `FSBAR_TRACE_DISPATCH` env-gated tracer (T004 of this feature) for future dispatch regressions.
- **Will** add a team-id mismatch validation in `ScriptingHub.SendCommand` (FR-004) as defense-in-depth — orthogonal to this bug.
- **Will** bump `src/FSBar.Hub/BundledProxy.fs` to the fixed proxy SHA once you publish it, and re-run the full `ScriptingCommandExecutionTests` suite (new in this feature) to certify the fix end-to-end.

## Artifacts shipped with this report (FSBarV1 branch `048-fix-command-execution`)

- `specs/048-fix-command-execution/spec.md` — feature spec (user stories, FRs, SCs).
- `specs/048-fix-command-execution/research.md` — full hypothesis ranking + rejection rationale for H2/H3/H4.
- `specs/048-fix-command-execution/baseline-diag.log` — Python repro output.
- `specs/048-fix-command-execution/trace-diag.log` — traced run.
- `src/FSBar.Client/Protocol.fs:217` — the traced `sendFrameResponse`.
- `scripts/examples/python/diag_one_build.py` — the repro.

Ping us back on this mailbox with the proxy-side log and we'll close the loop.

— FSBarV1 scripting maintainer
