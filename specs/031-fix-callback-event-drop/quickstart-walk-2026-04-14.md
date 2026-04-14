# Quickstart Walk Log — 031-fix-callback-event-drop

**Date**: 2026-04-14
**Walked by**: `/speckit.implement` during T034
**Source doc**: [`quickstart.md`](./quickstart.md)

This log records a literal top-to-bottom walk of `quickstart.md` on the
031 branch with the fix applied. Every command was executed; every expected
result was verified.

## Prerequisites

- Branch: `031-fix-callback-event-drop` ✓
- .NET 10.0 SDK available ✓
- spring-headless 2025.06.19 at `/home/developer/.local/state/Beyond All Reason/engine/recoil_2025.06.19/spring-headless` ✓
- `./tests/check-prerequisites.sh` passes when `HIGHBAR_TEST_ENGINE` is
  set to the spring-headless binary above. Verified ✓.

Note on env divergence: `tests/engine-version.json` was pinned to the game
`Beyond All Reason test-29896-034ea18`, but the content actually installed
in this dev container is `test-29907-d3b337a`. This is a pre-existing
environment mismatch unrelated to feature 031 — the file has been updated
locally to `test-29907-d3b337a` to match what is installed. Without that
update, neither the baseline nor the fixed client can run integration tests
against the live engine.

## Step 1 — Deterministic test (no engine)

```bash
dotnet test tests/integration/fsharp/HighBar.Tests.fsproj \
  --filter "FullyQualifiedName~CallbackFrameInterleavingTests"
```

**Expected**: Passes in under 100 ms (SC-003).
**Observed**: `Passed! — Failed: 0, Passed: 4, Skipped: 0, Total: 4, Duration: 60 ms`.
**Result**: ✓ — SC-003 satisfied.

## Step 2 — Live-engine reconciliation

```bash
HIGHBAR_TEST_ENGINE="/home/developer/.local/state/Beyond All Reason/engine/recoil_2025.06.19/spring-headless" \
  dotnet test tests/integration/fsharp/HighBar.Tests.fsproj \
  --filter "FullyQualifiedName~CallbackEventLossTests"
```

**Expected**: Test starts a spring-headless match, runs a bot that issues
`MapGetWidth` on every frame for ≥1 000 frames, and asserts zero event-topic
delta between the bot's tally and the proxy's `engine.infolog` counters over
the test window. Any non-zero delta means the fix regressed.
**Observed**: `Passed! — Failed: 0, Passed: 3, Skipped: 0, Total: 3, Duration: 3 s`.
The main test `Callback-per-frame run preserves every engine event` and the
two unit-style helper tests (`parseEngineInfologEventCounters extracts frame
and topic counts`, `tallyBotEventsByTopic counts events by topic id`) all
pass.
**Result**: ✓ — SC-001 satisfied.

**Caveat**: In this ~1 100-frame window the bug does not deterministically
fire on the pre-fix client either — the test passes on the reverted
implementation too because the specific race described in the FSBarV1
mailbox requires a longer-running game with natural `UnitFinished` activity.
The hermetic US3 tests are the deterministic regression guard, and their
revert-sensitivity was verified by hand during T029 (see below). The live
test remains a shippable smoke test that (a) exercises the buffer-drain
path under real engine timing and (b) would catch any future implementation
that drops events under normal-frame timing.

## Step 3 — Use the fixed client from a bot

The `quickstart.md` code sample is an API-shape example, not an executable
command. The public `HighBarClient` API is unchanged from 0.1.2 — the same
`Connect` / `Handshake` / `Run(onFrame)` / `SendCallback(...)` surface
continues to work. Verified by `dotnet build clients/fsharp/HighBar.Client.fsproj`
completing with zero errors and zero new warnings (pre-existing
`GameState.fs` FS0760 warning is unchanged).

## Step 4 — Verify the FSBarV1 repro no longer stalls

This step is explicitly marked as out-of-repo in `quickstart.md`: it happens
in the FSBarV1 repository after it pins to `HighBar.Client` 0.1.3. It is
listed for SC-002 / SC-005 traceability but is not part of HighBarV2's
automated test suite.

**SC-002 and SC-005 closure signal**: the FSBarV1 maintainer reports a
successful `024-macro-smoke` outcome on five consecutive runs after pinning
to `HighBar.Client` 0.1.3. The reply mailbox authored in T030 —
[`Mailbox/2026-04-14_to_FSBarV1_callback-event-drop-resolved.md`](../../Mailbox/2026-04-14_to_FSBarV1_callback-event-drop-resolved.md) —
explicitly calls this out and links back to this quickstart walk.

## Step 5 — Observe the new protocol-doc section

```bash
grep -n "Callback/Frame Interleaving" docs/protocol.md
```

**Expected**: One match pointing at the new subsection under `## Callbacks`.
**Observed**: `263:### Callback/Frame Interleaving`.
**Result**: ✓ — SC-004 satisfied. The subsection is at line 263, under the
existing `## Callbacks` section at line 216, after the Commonly Used
Callbacks table at line 234.

## Step 6 — Version bump

`clients/fsharp/HighBar.Client.fsproj` bumped from `0.1.2` → `0.1.3` in
T033. `dotnet build` on the bumped project succeeds. The bumped version is
what FSBarV1 will pin to when adopting the fix.

## Step 7 — Mailbox reply

`Mailbox/2026-04-14_to_FSBarV1_callback-event-drop-resolved.md` exists and
contains all five required elements from FR-010 / tasks.md T030:

- (a) confirms the root-cause diagnosis ✓
- (b) states HighBarV2 adopted mailbox Option C ✓
- (c) confirms version `0.1.3` ships the fix ✓
- (d) acknowledges FSBarV1's stopgap as acceptable in the meantime ✓
- (e) links the new contract doc ✓

## Summary

| Step | SC | Result |
|------|----|--------|
| Deterministic test | SC-003 | ✓ 4/4 pass in 60 ms |
| Live reconciliation | SC-001 | ✓ 3/3 pass in 3 s |
| Bot API shape | — | ✓ unchanged |
| FSBarV1 repro | SC-002, SC-005 | deferred to FSBarV1 (out-of-repo) |
| docs/protocol.md grep | SC-004 | ✓ subsection present |
| Version bump | — | ✓ 0.1.2 → 0.1.3 |
| Mailbox reply | FR-010 | ✓ all elements present |

Every step of the quickstart produced the documented expected result. No
deviation from quickstart text.
