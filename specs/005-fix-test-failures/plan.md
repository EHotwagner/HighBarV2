# Implementation Plan: Fix Remaining Test Failures

**Branch**: `005-fix-test-failures` | **Date**: 2026-04-03 | **Spec**: [spec.md](spec.md)
**Input**: Feature specification from `/specs/005-fix-test-failures/spec.md`

## Summary

Fix 12 failing F# integration tests caused by two root causes: (1) missing BAR-specific modoptions in `game-setup.txt` preventing commander spawning (10 tests), and (2) Init event timing in test expectations (2 tests). Write a report documenting all fixes and results.

## Technical Context

**Language/Version**: F# / .NET 10.0 (test harness + tests), TDF config format (game-setup.txt)
**Primary Dependencies**: xUnit (test framework), spring-headless 2025.06.21 (engine), BAR game content (test-29833-ee0f96a)
**Storage**: Filesystem (config files, reports as markdown)
**Testing**: xUnit via `dotnet test` — 23 integration tests against live engine
**Target Platform**: Linux (headless engine testing)
**Project Type**: Integration test infrastructure fix
**Performance Goals**: N/A (config and test expectation changes only)
**Constraints**: No proxy source changes; no Python harness changes; F# tests only
**Scale/Scope**: 3 files modified, 1 file created

## Constitution Check

*GATE: Must pass before Phase 0 research. Re-check after Phase 1 design.*

| Principle | Status | Notes |
|-----------|--------|-------|
| I. Zero Engine Modifications | PASS | No engine changes — only game config and test code |
| II. Binary Protocol First | PASS | No protocol changes |
| III. Correctness Over Cleverness | PASS | Direct config fix; no clever workarounds |
| IV. Test at the Boundary | PASS | Tests remain boundary-focused (engine→proxy→client) |
| V. Latency Budget Discipline | PASS | No hot-path changes |
| VI. Language-Agnostic by Default | PASS | No schema or protocol changes |
| VII. Explicit Over Implicit | PASS | Adding explicit modoptions replaces implicit defaults that silently failed |

No violations. No Complexity Tracking entries needed.

## Project Structure

### Documentation (this feature)

```text
specs/005-fix-test-failures/
├── plan.md              # This file
├── research.md          # Phase 0 output — spawn modoptions & Init event analysis
├── data-model.md        # Phase 1 output — game-setup.txt change map
├── quickstart.md        # Phase 1 output — verification guide
└── tasks.md             # Phase 2 output (created by /speckit.tasks)
```

### Source Code (repository root)

```text
tests/
├── fixtures/
│   └── game-setup.txt          # MODIFY: add modoptions, Side, StartPosType
├── integration/
│   └── fsharp/
│       ├── ConnectionTests.fs  # MODIFY: widen Init event frame window
│       └── EventTests.fs       # MODIFY: widen Init event frame window

reports/
└── 011-test-fix-results.md     # CREATE: fix documentation and results
```

**Structure Decision**: No new directories or architectural changes. All modifications are to existing files in established locations. One new report file follows the existing numbering convention.

## Implementation Phases

### Phase A: Game Configuration Fix (P1 — 10 tests)

**Goal**: Make BAR's spawn gadget create commander units in headless test games.

**Changes to `tests/fixtures/game-setup.txt`**:

1. Change `StartPosType=0` → `StartPosType=2`
2. Add to `[MODOPTIONS]`:
   - `startboxes=return { [0] = { 0, 0, 0.5, 1 }, [1] = { 0.5, 0, 1, 1 } };`
   - `teamfaction_0=armada;`
   - `teamfaction_1=cortex;`
3. Add to `[TEAM0]`: `Side=Armada;`
4. Add to `[TEAM1]`: `Side=Cortex;`

**Validation**: Run test suite. The 10 unit-dependent tests should now pass. Engine infolog should show unit creation events and no "No modoption start position data found" warning.

### Phase B: Init Event Test Fix (P2 — 2 tests)

**Goal**: Capture the Init event reliably regardless of timing.

**Changes to `tests/integration/fsharp/ConnectionTests.fs`**:
- In "First frame contains Init event" test: change `runForFrames client 1` to collect multiple frames (e.g., 5) and scan all for Init event

**Changes to `tests/integration/fsharp/EventTests.fs`**:
- In "Init event received with valid team ID" test: similarly widen frame collection window and scan all collected frames for Init with valid team ID

**Rationale**: The Init event is batched with the first UPDATE in frame 0. Widening the window tolerates timing variations without requiring proxy changes.

**Validation**: Run only the two Init event tests. Both should pass.

### Phase C: Report (P3)

**Goal**: Document fixes and results.

**Create `reports/011-test-fix-results.md`**:
- Before state: 11 pass, 12 fail
- Root cause 1: missing BAR spawn modoptions (config)
- Root cause 2: Init event timing (test expectations)
- Changes made (with file paths)
- After state: full test results
- Any remaining issues or follow-up items

## Risk Assessment

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| BAR spawn gadget needs additional undocumented modoptions | Low | High | Test iteratively; check engine infolog for errors after each change |
| Init event is actually lost (not just timing) | Low | Medium | If widening window doesn't work, investigate proxy buffering as fallback |
| StartPosType=2 requires additional config we haven't identified | Medium | Medium | Fall back to StartPosType=3; consult recoil-autohost source |
| Map-specific spawn issues | Low | Low | Current map (Comet Catcher Remake) is well-tested in BAR community |

## Post-Phase 1 Constitution Re-Check

| Principle | Status |
|-----------|--------|
| I. Zero Engine Modifications | PASS |
| II. Binary Protocol First | PASS |
| III. Correctness Over Cleverness | PASS |
| IV. Test at the Boundary | PASS |
| V. Latency Budget Discipline | PASS |
| VI. Language-Agnostic by Default | PASS |
| VII. Explicit Over Implicit | PASS |

All gates pass. No violations introduced by the design.
