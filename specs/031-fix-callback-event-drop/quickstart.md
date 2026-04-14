# Quickstart: Fix Mid-Game Callback Event Drop

**Feature**: 031-fix-callback-event-drop
**Date**: 2026-04-14

This quickstart shows how to verify the fix locally and what a bot author needs to
know after the fix ships.

## Prerequisites

- HighBarV2 checkout on branch `031-fix-callback-event-drop` (or master after the
  feature merges).
- .NET 10.0 SDK.
- spring-headless 2025.06.19 (already installed in the dev container —
  `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/spring-headless`).
- `./tests/check-prerequisites.sh` passes.

## Run the deterministic test (no engine needed)

```bash
dotnet test tests/integration/fsharp/HighBar.Tests.fsproj \
  --filter "FullyQualifiedName~CallbackFrameInterleavingTests"
```

Expected: the test passes in well under 100 ms (success criterion SC-003). The test
does NOT start an engine — it feeds a scripted `ProxyMessage` stream through a
test-only `HighBarClient` constructor and asserts that interleaved frame events are
delivered on subsequent frame reads.

## Run the live-engine reconciliation test

```bash
./tests/run-all.sh --category integration --filter CallbackEventLossTests
```

Expected: the test starts a spring-headless match, runs a bot that issues
`MapGetWidth` (cheap, side-effect free) on every frame for at least 1 000 frames,
and asserts that every event topic the proxy reported in `engine.infolog` was also
observed by the bot. Any non-zero delta means the fix regressed.

## Use the fixed client from a bot

The public API is **unchanged**. Existing bots keep working:

```fsharp
let client = new HighBarClient(socketPath)
client.Connect()
client.Handshake() |> ignore

client.Run(fun frame ->
    // You can now safely call SendCallback from inside the frame handler
    // without losing events on subsequent frames.
    let width = client.MapGetWidth()
    // ... use width ...
    []   // no commands
)
```

Before this fix, the above pattern could silently drop a `UnitFinished` event that
fired while `MapGetWidth`'s `CallbackResponse` was in flight. After this fix, the
event is preserved in the client's replay buffer and delivered to the next invocation
of the frame handler with its original frame number.

## Verify the FSBarV1 repro no longer stalls

This is the scenario from the inbound mailbox (§"Reproduction"):

```bash
# On the FSBarV1 side, after picking up HighBar.Client 0.1.3:
cd /path/to/FSBarV1
BOT_SCRIPT=bot_macro.fsx bash bots/trainer/run.sh NullAI 031-fix-verification
```

Expected: the macro bot reaches a
`cause=commander-death-win-after-upgrade` outcome (matching the 023 iter 026 clean
win) on five consecutive runs — i.e. the `Callbacks.getUnitPos` probe no longer
drops the `UnitFinished` event that advances `openingProgress`.

Note: FSBarV1 is a separate repository and the verification above happens outside
this repo. It is listed here for completeness of success criterion SC-005 but is
not part of this feature's automated test suite. HighBarV2's automated tests
(deterministic + live reconciliation) are sufficient to assert the fix on this
side.

## Observe the new protocol-doc section

```bash
grep -n "Callback/Frame Interleaving" docs/protocol.md
```

Expected: one match pointing at the new subsection under `## Callbacks`. Follow the
link inside that subsection to
`specs/031-fix-callback-event-drop/contracts/callback-frame-interleaving.md` for the
full normative contract.

## Version bump

After the fix merges to master, `clients/fsharp/HighBar.Client.fsproj` is bumped
from `0.1.2` to `0.1.3` following the convention established in recent commits
(`a1916e5`, `32ce22f`). Downstream consumers pin to `0.1.3` to opt into the new
event-preservation behaviour and remove any "replay instead of drop" stopgap they
may have written on their side.

## Troubleshooting

**The deterministic test can't find a `HighBarClient` constructor that takes a
`Stream`**: the test-only constructor is gated on `InternalsVisibleTo` — make sure
the `HighBar.Client.fsproj` has an `InternalsVisibleTo` attribute for
`HighBar.Tests`, or that the constructor is exposed via a `[<TestHook>]` attribute.
See tasks.md for the exact mechanism once implementation begins.

**The live test reports a non-zero delta but only on the first run after an engine
restart**: check that the `EngineFixture` warm-up frames are not being counted in
the bot's tally — the baseline subtraction in R6 relies on counting only the window
the bot is active for, not the entire match.

**The mailbox reply file is missing**: FR-010 requires a
`Mailbox/2026-04-14_to_FSBarV1_callback-event-drop-resolved.md` file. It is produced
during implementation (see tasks.md), not during planning.
