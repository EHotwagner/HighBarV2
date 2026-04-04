# Data Model: AI Validation and Competitive Testing

**Feature**: 015-ai-validation-tests | **Date**: 2026-04-04

## Entities

### GameResult (Discriminated Union)

Represents the outcome classification of a single game.

| Variant | Description |
|---------|-------------|
| `Win` | Game ended naturally, our team survived |
| `Loss` | Game ended naturally, our team eliminated |
| `Crash` | Engine process died mid-game (socket error) |
| `Stall` | AI issued zero commands for 60+ consecutive seconds (1800 frames at 30fps) |
| `Timeout` | Game exceeded maximum frame limit without ending |

### GameOutcome (Record)

Result of a single AI game run. Extends the existing `GameRunner.GameOutcome` type with milestone tracking.

| Field | Type | Description |
|-------|------|-------------|
| `GameNumber` | `int` | 1-indexed game number in the batch |
| `Result` | `GameResult` | Win/Loss/Crash/Stall/Timeout |
| `DurationFrames` | `int` | Total frames elapsed |
| `DurationMinutes` | `float` | Duration in real game minutes (frames / 30 / 60) |
| `UnitsProduced` | `int` | Total friendly units created |
| `UnitsLost` | `int` | Total friendly units destroyed |
| `EnemyUnitsDestroyed` | `int` | Total enemy units we destroyed |
| `MexBuiltCount` | `int` | Metal extractors completed |
| `MexFirstBuiltFrame` | `int option` | Frame when first mex completed |
| `EnergyBuiltCount` | `int` | Energy structures completed |
| `EnergyFirstBuiltFrame` | `int option` | Frame when first energy structure completed |
| `FactoryBuiltCount` | `int` | Factories completed |
| `FactoryFirstBuiltFrame` | `int option` | Frame when first factory completed |
| `FirstCombatUnitFrame` | `int option` | Frame when first combat unit produced from factory |
| `CrashMessage` | `string option` | Error message if Result = Crash |
| `WeaponFiredCount` | `int` | Number of WeaponFired events observed (live engine only; always 0 in headless) |
| `UnitDamagedCount` | `int` | Number of UnitDamaged events for friendly units |
| `EnemyDamagedCount` | `int` | Number of EnemyDamaged events for enemy units |
| `UnitDestroyedCount` | `int` | Number of UnitDestroyed events for friendly units |
| `EnemyDestroyedCount` | `int` | Number of EnemyDestroyed events for enemy units |

**Validation rules**:
- `GameNumber >= 1`
- `DurationFrames >= 0`
- `DurationMinutes = float DurationFrames / 30.0 / 60.0`
- Milestone frames (when `Some`) must be `<= DurationFrames`
- Count fields must be `>= 0`

### ValidationCriterion (Record)

A single pass/fail check applied to game outcomes.

| Field | Type | Description |
|-------|------|-------------|
| `Id` | `string` | Criterion identifier (e.g., "SC-001") |
| `Description` | `string` | Human-readable description |
| `Evaluate` | `GameOutcome list -> bool` | Function that checks outcomes against threshold |

### ValidationReport (Record)

Aggregated results across a batch of game runs.

| Field | Type | Description |
|-------|------|-------------|
| `SuiteName` | `string` | Test suite identifier (e.g., "End-to-End vs NullAI") |
| `RunDate` | `DateTime` | When the validation was run |
| `TotalGames` | `int` | Number of games in the batch |
| `Outcomes` | `GameOutcome list` | Per-game results |
| `Criteria` | `(ValidationCriterion * bool) list` | Each criterion paired with its pass/fail result |
| `OverallPass` | `bool` | True if all criteria passed |

**Validation rules**:
- `TotalGames = Outcomes.Length`
- `OverallPass = Criteria |> List.forall snd`

### TestAssertion (Record)

A single verifiable condition within a non-combat or combat test run.

| Field | Type | Description |
|-------|------|-------------|
| `Name` | `string` | Assertion identifier (e.g., "economy_positive_income_2min") |
| `Category` | `TestCategory` | Economy / BuildOrder / Movement / Scouting / Combat |
| `Passed` | `bool` | Whether the assertion held |
| `ActualValue` | `string` | Observed value for diagnostics |
| `ExpectedValue` | `string` | Expected threshold or condition |
| `GameNumber` | `int` | Which game run this assertion came from |

### TestCategory (Discriminated Union)

| Variant | Description |
|---------|-------------|
| `Economy` | Metal/energy income, extractor count, stall detection |
| `BuildOrder` | Opening sequence (mex → energy → factory) |
| `Movement` | Units reaching target positions |
| `Scouting` | Map exploration coverage |
| `Combat` | WeaponFired, UnitDamaged, UnitDestroyed events |

### TestSuiteReport (Record)

Aggregated test assertion results across multiple game runs.

| Field | Type | Description |
|-------|------|-------------|
| `SuiteName` | `string` | "Headless Non-Combat" or "Live Combat" |
| `RunDate` | `DateTime` | When the suite was run |
| `TotalRuns` | `int` | Number of game runs |
| `Assertions` | `TestAssertion list` | All assertions from all runs |
| `PassRate` | `float` | Percentage of assertions that passed |
| `PassedCount` | `int` | Number of passed assertions |
| `FailedCount` | `int` | Number of failed assertions |
| `OverallPass` | `bool` | True if pass rate meets threshold (95% non-combat, 90% combat) |

**Validation rules**:
- `PassRate = float PassedCount / float (PassedCount + FailedCount) * 100.0`
- `OverallPass` depends on suite: non-combat requires `PassRate >= 95.0`, combat requires `PassRate >= 90.0`

## Relationships

```
ValidationReport
├── GameOutcome[]          (1:N — one per game run)
│   └── GameResult         (1:1 — outcome classification)
└── ValidationCriterion[]  (1:N — success criteria checks)

TestSuiteReport
└── TestAssertion[]        (1:N — assertions across all runs)
    └── TestCategory       (1:1 — assertion domain)
```

## State Transitions

### Game Lifecycle

```
Starting → Running → Ended(Win|Loss) | Crashed | Stalled | TimedOut
```

- **Starting → Running**: Engine launches, proxy connects, first frame received
- **Running → Ended(Win)**: `Shutdown(GAME_OVER)` received + our units exist
- **Running → Ended(Loss)**: `Shutdown(GAME_OVER)` received + our commander destroyed
- **Running → Crashed**: Socket error or engine process death
- **Running → Stalled**: Zero commands for 1800+ consecutive frames
- **Running → TimedOut**: Frame count exceeds max limit (54000 frames = 30 min)

### Validation Lifecycle

```
Pending → Running(game 1/N) → ... → Running(game N/N) → Reporting → Complete
```

Each game within a batch is independent. A crash in game 3 does not prevent games 4-10 from running.
