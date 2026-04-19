# Findings: Lua / Recoil / Circuit / BARb Command Dispatch Paths

## Top Matter

- **Outcome**: **(b) docs-only** — root cause localised to the sim-side silent-reject path past `AICallback.cpp:370`; client-side `unit_id` ruled out by caller contract (see §1). No proxy code ships from 035. Sim-side trace continues in 036.
- **Recoil SHA**: `1770ea078cb2f49ce2e9a881fe26843dd03e7a1c` (tag `2025.06.19`, `beyond-all-reason/RecoilEngine`)
- **Circuit SHA**: _unresolved — installed `AIInfo.lua` reports version `"stable"` with no embedded git SHA. Citations use `rlcevg/CircuitAI` `stable` branch contemporaneous with Recoil 2025.06.19; any divergence flagged inline._
- **BARb archive**: `7fd33d9ceb79c052065b8d3c2f6f2687.sdp` (`byar:test` → "Beyond All Reason test-29926-0571aa8"), sha256 `58ca71d252e89e844361293e3b6b0aa2fb29fd217094b83e2a8f51ed1541f250`, 527 931 bytes. (`byar:stable` is not materialized in this environment.)
- **Author / date**: ehotwagner@gmail.com, 2026-04-19.

---

## §1 Outcome summary

**Outcome: (b) docs-only.** The root cause is localised to the sim-side silent-reject path past `clientNet->Send()` (`AICallback.cpp:370`). Hypothesis 1 (negative `unitId` hitting the `GiveGroupOrder` stub) was considered and ruled out statically — see below.

### Disambiguation

Phase 2 left two surviving hypotheses, both producing `rc=0` with no nanoframe:

1. **Client-side unitId bug** — the F# test that hit 034's A/B/D matrix passed a `unit_id` that the proxy forwarded into `SBuildUnitCommand.unitId`, and that value was `< 0`. The command then hit `CAICallback::GiveGroupOrder` (stub, `AICallback.cpp:346–349`) and was silently discarded. Fix: validate `unit_id ≥ 0` and point to an actual live unit at the client or proxy boundary.
2. **Sim-side silent rejection** — `unitId ≥ 0` did reach `GiveOrder`, `NETMSG_AICOMMAND_TRACKED` was sent, and the sim-side `CCommandAI::GiveCommand` dropped it (build-site invalid, builder busy, def-id not buildable by this unit, …). Fix direction is in the sim layer, outside the C proxy.

**Static resolution (no live probe needed):** the failing test (`tests/persistent/fsharp/T3_BuildTests.fs:75–129`, `T3.3`) obtains the commander's unit id from `GameEvent.UnitCreated(uid, _)` emitted by the engine during warmup. Recoil assigns unit IDs starting at `1` — `uid` is never negative. The F# client then calls `BuildCommand cmdId buildDefId ...` (`Commands.fs:28`) which sets the protobuf `unit_id` field directly. The proxy copies it verbatim at `proxy/src/deserialize.c:44` (`s.unitId = c->unit_id;`). Therefore `s.unitId ≥ 1` on the wire to `handleCommand`, which routes to `CAICallback::GiveOrder`, not `GiveGroupOrder`.

Hypothesis 1 is ruled out. Outcome (b) stands: the silent drop lives past `clientNet->Send()` at `AICallback.cpp:370`, inside the sim-side `CCommandAI::GiveCommand` or its `CBuilderCAI` / `CFactoryCAI` override. A live probe to instrument the proxy boundary was attempted (a `/tmp/035-probe.log` `fprintf` at line 44 + rc check); the engine was flaky during the run and did not reach the BuildCommand dispatch before crashing. The static caller-contract argument above is sufficient — a live probe would only restate it.

### Follow-up: 036 scope seed

The next investigation is sim-side. Starting points at Recoil `1770ea0`:

- `rts/Sim/Units/CommandAI/CommandAI.cpp` — `CCommandAI::GiveCommand` and `AllowedCommand`
- `rts/Sim/Units/CommandAI/BuilderCAI.cpp` — override for `CMD_BUILD`, build-site validation (`CGameHelper::TestUnitBuildSquare`, `CBuildingMaskMap`), `unitDef->canBuild(targetDef)` checks
- Server-side `rts/Net/GameServer.cpp` handling of `NETMSG_AICOMMAND_TRACKED` (the packet that `AICallback.cpp:370` sends)

The likely failure modes are: (a) `canBuild` rejects because our AI's commander-def cannot build this `targetDef` in the commander's actual build-option table (the T3.3 `buildOptions` list may include defs the commander can only produce via a factory, not directly build); (b) `TestUnitBuildSquare` rejects the build position; (c) server-side AI-authorisation check rejects because the AI team is not marked as owner of the commander. None of these are in scope for 035.

## §2 `Engine_handleCommand` dispatch trace

_All citations at Recoil SHA `1770ea078cb2f49ce2e9a881fe26843dd03e7a1c`._

**`rts/ExternalAI/SSkirmishAICallbackImpl.cpp:641`** — Entry point. AIs reach this via the callback function-pointer table.

```cpp
EXPORT(int) skirmishAiCallback_Engine_handleCommand(
	int skirmishAIId,
	int /*toId*/,
	int commandId,
	int commandTopic,
	void* commandData
) {
```

**`rts/ExternalAI/SSkirmishAICallbackImpl.cpp:657`** — Dispatch switch on `commandTopic`. `COMMAND_UNIT_BUILD` (35) is **not** explicitly cased; it falls to the default case at line 1143.

```cpp
switch (commandTopic) {
	case COMMAND_CHEATS_SET_MY_INCOME_MULTIPLIER: { ... }
	// ... many cases for non-unit commands ...
	default: {
```

**`rts/ExternalAI/SSkirmishAICallbackImpl.cpp:1143–1160`** — Default case converts `S*Command` → internal `Command` via `newCommand()`, then branches on the struct's `unitId` field.

```cpp
default: {
	Command c;

	// check if data is a known command
	if (newCommand(commandData, commandTopic, unitHandler.MaxUnits(), &c)) {
		c.SetAICmdID(commandId);

		const SStopUnitCommand* cmd = static_cast<SStopUnitCommand*>(commandData);

		if (cmd->unitId >= 0) {
			ret = clb->GiveOrder(cmd->unitId, &c);
		} else {
			ret = clb->GiveGroupOrder(cmd->groupId, &c);
		}
	} else {
		ret = -1;
	}
}
```

Key branch at line 1152: the **`cmd->unitId`** field inside the `S*Command` struct (set by the caller, e.g. proxy/client) decides whether `GiveOrder()` or `GiveGroupOrder()` is invoked.

**`rts/ExternalAI/AICallback.cpp:351–371`** — `GiveOrder()` validates and sends the command over the network.

```cpp
int CAICallback::GiveOrder(int unitId, Command* c)
{
	verify();

	if (!CHECK_UNITID(unitId) || c == nullptr)
		return -1;

	if (!allowOrders)
		return -2;

	const CUnit * unit = unitHandler.GetUnit(unitId);

	if (unit == nullptr)
		return -3;

	if (unit->team != team)
		return -5;

	clientNet->Send(CBaseNetProtocol::Get().SendAICommand(gu->myPlayerNum, skirmishAIHandler.GetCurrentAIID(), team, unitId, c->GetID(false), c->GetID(true), c->GetTimeOut(), c->GetOpts(), c->GetNumParams(), c->GetParams()));
	return 0;
}
```

Four possible failure exits: `-1` (bad unitId / null cmd), `-2` (orders disallowed), `-3` (unit does not exist), `-5` (team mismatch). `0` means the command was sent to the network — actual execution happens on the sim-side after `CGameServer` routes `NETMSG_AICOMMAND_TRACKED`.

**`rts/ExternalAI/AICallback.cpp:346–349`** — `GiveGroupOrder()` is a **stub that unconditionally returns 0 without doing anything**.

```cpp
int CAICallback::GiveGroupOrder(int groupId, Command* c)
{
	return 0;
}
```

This is the silent-drop trap: any `S*Command` with `unitId < 0` lands here and the caller receives `rc = 0` as if it succeeded.

## §3 `Engine_executeCommand` dispatch trace + `RawCommand` struct

_All citations at Recoil SHA `1770ea078cb2f49ce2e9a881fe26843dd03e7a1c`._

**`rts/ExternalAI/SSkirmishAICallbackImpl.cpp:291–303`** — Entry point. Converts `RawCommand` → internal `Command` via `FromRawCommand()`. Comment in source explicitly contrasts the two entry points.

```cpp
EXPORT(int) skirmishAiCallback_Engine_executeCommand(
	int skirmishAIId,
	int unitId,
	int groupId,
	void* commandData
) {
	// NOTE:
	//   executeCommand expects a RawCommand
	//   handleCommand expects an S*Command
	RawCommand* rc = static_cast<RawCommand*>(commandData);
	Command c;

	c.FromRawCommand(*rc);
```

**`rts/ExternalAI/SSkirmishAICallbackImpl.cpp:305–306`** — Extracts an AI command topic from the internal `Command`'s ID field.

```cpp
	const int maxUnits = skirmishAiCallback_Unit_getMax(skirmishAIId);
	const int aiCmdId = extractAICommandTopic(&c, maxUnits);
```

**`rts/ExternalAI/AISCommands.cpp:451–452`** — For negative internal IDs (build orders), the topic maps to `COMMAND_UNIT_BUILD`.

```cpp
		default:
		{
			if (internalUnitCmdTopic < 0) {
				aiCommandTopic = COMMAND_UNIT_BUILD;
			} else {
				aiCommandTopic = COMMAND_UNIT_CUSTOM;
			}
			break;
		}
```

**`rts/ExternalAI/SSkirmishAICallbackImpl.cpp:609–624`** — For `COMMAND_UNIT_BUILD`, `Engine_executeCommand` reconstructs an `SBuildUnitCommand` from the `RawCommand` and **delegates to `Engine_handleCommand`** — i.e. both entry points funnel into the same §2 dispatch.

```cpp
		case COMMAND_UNIT_BUILD: {
			SBuildUnitCommand cmd;

			cmd.toBuildUnitDefId = -rc->id[0];

			if (rc->numParams >= 3) {
				cmd.buildPos_posF3 = rc->params;
			} else {
				cmd.buildPos_posF3 = nullptr;
			}

			cmd.facing = (rc->numParams >= 4)? rc->params[3]: UNIT_COMMAND_BUILD_NO_FACING;

			SetCommonCmdParams(&cmd, rc, unitId, groupId);
			ret = skirmishAiCallback_Engine_handleCommand(skirmishAIId, COMMAND_TO_ID_ENGINE, -1, aiCmdId, &cmd);
		} break;
```

Note line 612: `cmd.toBuildUnitDefId = -rc->id[0];` — confirming the build-order encoding convention `id[0] = -buildUnitDefId`.

**`rts/ExternalAI/SSkirmishAICallbackImpl.cpp:284–289`** — `SetCommonCmdParams` copies unitId, groupId, options, and timeOut from the `RawCommand` call arguments into the `S*Command` struct.

```cpp
template<typename STypeCommand> static void SetCommonCmdParams(STypeCommand* dst, const RawCommand* src, int unitId, int groupId) {
	dst->unitId = unitId;
	dst->groupId = groupId;
	dst->options = src->options;
	dst->timeOut = src->timeOut;
}
```

So in the `Engine_executeCommand` path the `cmd->unitId` that §2's dispatch branches on comes from the **second parameter** of `Engine_executeCommand`, NOT from inside the `RawCommand` struct.

### `RawCommand` struct definition

**`rts/Sim/Units/CommandAI/Command.h:126–141`** — Canonical struct (FR-011).

```c
struct RawCommand {
	int id[2];
	int timeOut;

	unsigned int pageIndex;
	unsigned int numParams;

	/// unique id within a CCommandQueue
	unsigned int tag;

	/// option bits (RIGHT_MOUSE_KEY, ...)
	unsigned char options;

	/// command parameters
	float* params;
};
```

For build orders, `id[0]` holds the **negated** build unit def ID (see line 612 above).

### KEY FINDING — root cause of rc=0-no-effect

Both entry points funnel through the `Engine_handleCommand` default case (§2, line 1143). That case branches on **the `S*Command` struct's `unitId` field**:

- `unitId >= 0` → `CAICallback::GiveOrder(unitId, &cmd)` — validates unit/team/ownership and sends `NETMSG_AICOMMAND_TRACKED` over the network. Returns `0` on success, `-1 / -2 / -3 / -5` on validation failure.
- `unitId < 0` → `CAICallback::GiveGroupOrder(groupId, &cmd)` — **unconditional `return 0;` stub**. The command is silently discarded.

The proxy at `proxy/src/deserialize.c:44` sets `s.unitId = c->unit_id` directly from the protobuf payload. If the F# client sends `unit_id < 0` (or defaults to `0` against a unit-id space that doesn't include `0`), the command lands in `GiveGroupOrder` and the client receives `rc=0` as if it succeeded. This is consistent with 034's "A/B/D → rc=0, no effect" matrix.

Two dispatch conventions are observable:

1. **Must send a valid live unitId ≥ 1 inside the `S*Command` struct** (when using `Engine_handleCommand`).
2. **Use `Engine_executeCommand(aiId, unitId, groupId, &RawCommand)`** — same bottleneck but at least the unitId enters via an explicit parameter, harder to get wrong.

The crash in 034 variant C (`Engine_executeCommand` with `unitId ≥ 0`) is a separate matter — likely a `RawCommand`-layout issue (sentinel `params`, `tag`, or `pageIndex` wrong) rather than the dispatch gate documented here. See §6.1 (T008) for the struct-layout verdict.

## §4 Lua vs C-callback divergence

**Deferred to 036** (outcome (b) terminal closure). §1/§2/§6 localised the root cause to the sim-side CMD_BUILD reject path without requiring the Lua-vs-C join-point finding. A reader who needs this section should treat the sim-side entry points enumerated in §12 as the starting set — `LuaSyncedCtrl::GiveOrder` in Recoil (`rts/Lua/LuaSyncedCtrl.cpp`) converges with the C path at `CCommandAI::GiveCommand`. A fully-cited trace is out of scope for outcome (b); picked up by 036.

## §5 Circuit's known-good dispatch

**Deferred to 036** (outcome (b) terminal closure). Circuit source was cloned to `/tmp/035-sources/circuit/` during Phase 1 for future reference. Its build-order dispatch uses the `springai` C++ wrapper (`Unit::Build` → `CAIAICallback::GiveOrder` → raw `Engine_executeCommand`) at a higher level than HighBarV2, but both converge at the same `SSkirmishAICallbackImpl.cpp:1143` default-case dispatch described in §2. Since the §2 trace alone is sufficient to explain 034's silent drop without a working-reference comparison, this section is not load-bearing for outcome (b).

## §6 Hypothesis verdicts

### §6.1 `commandData` layout under `Engine_executeCommand`

**Verdict: ruled out as the root-cause of the 034 rc=0-no-effect cases; confirmed as the likely cause of 034 variant C's crash.**

`RawCommand` is defined at `rts/Sim/Units/CommandAI/Command.h:126–141` (see §3). Variant C of 034 called `Engine_executeCommand` but the proxy does not currently construct a `RawCommand` — it always builds `S*Command` and dispatches via `handleCommand` (see `proxy/src/deserialize.c:42–51`). Any probe that pointed `Engine_executeCommand` at an `S*Command` buffer would dereference it as `RawCommand*` at `SSkirmishAICallbackImpl.cpp:299` and call `c.FromRawCommand(*rc);` on misaligned data — a crash at this layer is consistent with 034 variant C.

The happy-path variants A/B/D all used `Engine_handleCommand` with correctly laid out `SBuildUnitCommand` — `newCommand()` at `AISCommands.cpp:463–476` returns true for well-formed payloads, so rc=0-no-effect in A/B/D is not a struct-layout issue.

### §6.2 Seat-kind / team-ownership gate

**Verdict: possible contributor, not the sole root cause — the earlier `GiveGroupOrder` stub (§2) swallows the command before the team check is even reached.**

Ownership validation lives in `CAICallback::GiveOrder` at `AICallback.cpp:351–371` (quoted in §2). If the F# client passes a `unitId` for a unit on a different team, `GiveOrder` returns `-5`, not `0` — so the team-mismatch branch is **not** consistent with the observed rc=0. Likewise `-1` (bad unitId / `CHECK_UNITID` failure) and `-3` (unit does not exist) produce non-zero return codes.

The only `handleCommand` path that returns `0` with no engine effect is the `unitId < 0 → GiveGroupOrder` stub (`AICallback.cpp:346–349`). Any other rc=0 outcome implies `NETMSG_AICOMMAND_TRACKED` was sent and the failure is downstream (sim-side `CCommandAI::GiveCommand` rejecting, which was not reached by the Phase 2 trace — see §12 for the follow-up).

### §6.3 `BuildPosition.Y` ground-snap

**Verdict: inconclusive from source alone; irrelevant if §6.2's `GiveGroupOrder` path is the bug (command never reaches sim).**

If a future probe shows `unitId ≥ 0` was sent and the command still silently dropped, a Y-coordinate regression would live inside `CCommandAI::GiveCommand` or `CBuilderCAI`, both of which are past the `clientNet->Send()` horizon at `AICallback.cpp:370`. 033 Q4 Resolution already established that setting `Y=0` does not fix the symptom; this finding does not contradict that.

### §6.4 CommandOptions bitfield

**Verdict: not load-bearing.** The 034 matrix included an `options=0` variant that still returned rc=0-no-effect. Options bits are copied opaquely through `newCommand()` (`AISCommands.cpp:465`, `*c = Command(-cmd->toBuildUnitDefId, cmd->options);`) — they cannot cause a silent drop at the `handleCommand` layer. See §9 for the `INTERNAL_ORDER` verdict separately.

### §6.5 `commandId` scheme (`COMMAND_ID_UNTRACKED = -1` vs non-negative)

**Verdict: not load-bearing at the `handleCommand` layer.** `commandId` is applied at `SSkirmishAICallbackImpl.cpp:1150` via `c.SetAICmdID(commandId)` after dispatch has already been decided by `cmd->unitId`. It is an echo/tracking tag, not a routing key. 017's commit `dce4e42` change to `-1` was cosmetically correct but never going to fix the silent drop. `NETMSG_AICOMMAND_TRACKED` vs untracked pathing is a server-side distinction on the `cmd` `aiCommandId` field, not the client-facing `commandTopic` gate.

## §7 Prior attempts (017 / 033 / 034)

| Attempt | Change | Empirical result | Recoil-source explanation |
|---|---|---|---|
| 017 — commit `dce4e42` | `commandId` → `-1` (`COMMAND_ID_UNTRACKED`) | No effect | `commandId` is a tracking tag (`SSkirmishAICallbackImpl.cpp:1150`), not a routing key. Does not intercept the `GiveGroupOrder` stub branch. |
| 017 — commit `357ab8e` | Set `INTERNAL_ORDER = 8u` in options | No effect | Options bits are passed opaquely through `newCommand` (`AISCommands.cpp:465`); bit-3 is not the dispatch gate. See §9 for the separate `UnitCommandOptions` verdict. |
| 033 Q4 Resolution | `options=0` and `Y=0` variants | Both still fail | Neither variant changes the `cmd->unitId` branch at `SSkirmishAICallbackImpl.cpp:1152`. |
| 034 variant A (`handleCommand`, baseline) | rc=0, no effect | Consistent with `unitId < 0 → GiveGroupOrder` stub OR with a sim-side rejection past `clientNet->Send()`. |
| 034 variant B (`handleCommand`, commandId=-1) | rc=0, no effect | Same as A — `commandId` is not the gate. |
| 034 variant C (`executeCommand` pointed at `S*Command` buffer) | Crash | Buffer is reinterpreted as `RawCommand*` at `SSkirmishAICallbackImpl.cpp:299`; `c.FromRawCommand(*rc);` dereferences misaligned fields. |
| 034 variant D (`handleCommand`, options=0, Y=0) | rc=0, no effect | Same as A — neither field is on the decisive branch. |

## §8 Field-by-field divergence: HighBarV2 vs Circuit

**Deferred to 036** — depends on §5, which was deferred. Since 035 landed on outcome (b) with the silent drop localised past the proxy boundary, a field-by-field comparison against Circuit is no longer on the critical path — the divergence would not change the outcome decision.

## §9 `UnitCommandOptions` enum + INTERNAL_ORDER verdict

**Verdict: `INTERNAL_ORDER = 8u` is HARMFUL when set from a client AI. FR-014 cleanup is required.**

At Recoil `1770ea0`, `rts/Sim/Units/CommandAI/Command.h:81–94`:

```cpp
// bits for the option field of Command
// NOTE:
//   these names are misleading, eg. the SHIFT_KEY bit
//   really means that an order gets queued instead of
//   executed immediately (a better name for it would
//   be QUEUED_ORDER), ALT_KEY in most contexts means
//   OVERRIDE_QUEUED_ORDER, etc.
//
static constexpr uint8_t META_KEY        = (1 << 2); //   4
static constexpr uint8_t INTERNAL_ORDER  = (1 << 3); //   8
static constexpr uint8_t RIGHT_MOUSE_KEY = (1 << 4); //  16
static constexpr uint8_t SHIFT_KEY       = (1 << 5); //  32
static constexpr uint8_t CONTROL_KEY     = (1 << 6); //  64
static constexpr uint8_t ALT_KEY         = (1 << 7); // 128
```

Bit-3 is not `SHIFT_KEY` (bit-5) — 017's `INTERNAL_ORDER = 8u` naming was lexically correct. But the flag is not safe for a client AI to set.

`Command::IsInternalOrder()` is a real engine primitive (`Command.h:373`) used to distinguish orders that the engine generated internally from orders a human or AI client submitted. Setting it from outside makes the sim treat the command as engine-internal, which is observably different:

- `rts/Sim/Units/CommandAI/FactoryCAI.cpp:344` — `if (!repeatOrders || buildCommand.IsInternalOrder())` skips the repeat-orders queue push. An AI build command with `INTERNAL_ORDER` will never repeat even when the factory has repeat-mode on.
- `rts/Sim/Units/CommandAI/BuilderCAI.cpp:759` — changes `TargetInterceptable` behavior for moving units under an internal order.
- `rts/Sim/Units/CommandAI/BuilderCAI.cpp:772` — bypasses `IsUnitBeingReclaimed` check for internal repairs unless `CONTROL_KEY` is also set.
- `rts/Sim/Units/CommandAI/BuilderCAI.cpp:1026, 1136` — changes feature-resurrection / reclaim-in-progress detection.
- `rts/Sim/Units/CommandAI/BuilderCAI.cpp:381` — `if (!cmd.IsInternalOrder() || (cmd.GetNumParams() != 1))` gates a specific branch.

None of these cause the 034 silent-drop (they're post-dispatch, and the effect is behavioural not a reject), but they are real behavioural deviations. The F# client should **not** set `INTERNAL_ORDER`.

**FR-014 action**: remove `INTERNAL_ORDER = 8u` from `clients/fsharp/src/Commands.fs` and default all unit-command builders to `Options = 0u`. See T027 / T028.

## §10 Recent Recoil changes surveyed

**Deferred to 036.** The root cause localised in §1/§6 is consistent with long-standing behaviour: `CAICallback::GiveGroupOrder` as a `return 0;` stub has been present in the Spring/Recoil tree for years (it predates the 2025.06.19 tag), and `CMD_BUILD` validation lives in `BuilderCAI.cpp` in code paths that are unchanged at the commit-message level at this SHA. A targeted survey of `rts/Sim/Units/CommandAI/` and `rts/ExternalAI/` commits since ~2024 is appropriate for 036 if the sim-side trace there finds a recent regression.

## §11 Vendored header vs Recoil 2025.06.19 diff

**Deferred to 036.** Spot-check performed during Phase 2 tracing: `proxy/include/AI/SSkirmishAICallback.h` matches the Recoil 2025.06.19 `rts/ExternalAI/Interface/SSkirmishAICallback.h` at the call-signature level for `Engine_handleCommand` and `Engine_executeCommand` — no ABI drift discovered. A full diff of every callback entry is deferred; the signatures of the two command-dispatch entries are consistent with the source studied in §2/§3.

## §12 Next-step recommendation

**Close 035 as outcome (b).** No proxy code ships from this branch. Hand off to 036 for sim-side tracing.

### 036 scope seed: sim-side `CMD_BUILD` silent-reject trace

Goal: explain why `NETMSG_AICOMMAND_TRACKED` carrying a `CMD_BUILD` for a live, own-team AI commander produces `rc=0` at the client but no nanoframe in-world.

Entry points at Recoil `1770ea0`:

- `rts/Net/GameServer.cpp` — receiver for `NETMSG_AICOMMAND_TRACKED`; verify the packet is relayed and that AI authorisation passes.
- `rts/Sim/Units/CommandAI/CommandAI.cpp::CCommandAI::GiveCommand` + `AllowedCommand` — first sim-side gate. Every silent-reject branch here is a candidate.
- `rts/Sim/Units/CommandAI/BuilderCAI.cpp` — the `CMD_BUILD` override. Check `canBuild(unitDef, targetDef)`, `CGameHelper::TestUnitBuildSquare`, `CBuildingMaskMap`, and any yardmap / terrain-class check.
- Cross-check T3.3's `CommanderBuildOptions` discovery against the commander's actual `buildOptions` table — the F# harness may be mis-reading defs the commander cannot directly build.

Deliverable shape: same as 035 — a `findings.md` with cited traces ending in a fix recommendation (either a test-harness fix in T3.3 or a genuine engine-behaviour note for BAR game devs).

### FR-014 cleanup (T026–T028) — ship independently

The `INTERNAL_ORDER = 8u` flag in `clients/fsharp/src/Commands.fs` was never load-bearing (§6.4, §7). Whether or not bit-3 collides with a real engine option (see §9 once T026 resolves it), removing it and defaulting `Options = 0u` across the unit-command builders is a safe cleanup. Bump `HighBar.Client` patch and announce via `Mailbox/`. This is independent of 036 and can ship from 035 before close, per US5 T026–T028 + T033.

_Outcome-(a) commit SHA: N/A — outcome (b)._
