# Data Model: Fix Remaining Test Failures

**Feature Branch**: `005-fix-test-failures`  
**Date**: 2026-04-03

## Entities

### game-setup.txt (TDF Start Script Template)

The primary entity being modified. A text file in TDF (INI-style) format that configures the game scenario.

**Attributes**:

| Section | Key | Current Value | Required Value | Purpose |
|---------|-----|---------------|----------------|---------|
| GAME | StartPosType | 0 | 2 | Position selection mode compatible with BAR spawn gadget |
| MODOPTIONS | GameMode | 3 | 3 (no change) | Disables victory conditions |
| MODOPTIONS | startboxes | (missing) | `return { [0] = { 0, 0, 0.5, 1 }, [1] = { 0.5, 0, 1, 1 } }` | Spawn area definitions |
| MODOPTIONS | teamfaction_0 | (missing) | armada | Team 0 faction assignment |
| MODOPTIONS | teamfaction_1 | (missing) | cortex | Team 1 faction assignment |
| TEAM0 | Side | (missing) | Armada | Faction identifier for team 0 |
| TEAM1 | Side | (missing) | Cortex | Faction identifier for team 1 |

**Relationships**: Referenced by `start-headless.sh` which substitutes `__MAP_NAME__` and `__SOCKET_PATH__` placeholders at launch time.

### Init Event Test Expectations

Not a persistent entity but a behavioral contract in the test code.

**Current state**: Tests collect 1 frame and expect Init in that frame.
**Required state**: Tests collect multiple frames (3-5) and scan all of them for Init.

**Affected files**:
- `tests/integration/fsharp/ConnectionTests.fs` — "First frame contains Init event"
- `tests/integration/fsharp/EventTests.fs` — "Init event received with valid team ID"

### Report (011-test-fix-results.md)

**Attributes**:
- Number: 011
- Title: descriptive name for test fix results
- Format: Markdown following reports/TEMPLATE.md structure
- Content: before/after test results, changes made, root cause confirmation, remaining issues
