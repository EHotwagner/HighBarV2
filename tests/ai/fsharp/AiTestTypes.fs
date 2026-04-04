namespace HighBar.AI.Tests

open System

/// Outcome classification of a single game.
[<RequireQualifiedAccess>]
type GameResult =
    | Win
    | Loss
    | Crash
    | Stall
    | Timeout

/// Result of a single AI game run with milestone tracking.
type GameOutcome = {
    GameNumber: int
    Result: GameResult
    DurationFrames: int
    DurationMinutes: float
    UnitsProduced: int
    UnitsLost: int
    EnemyUnitsDestroyed: int
    MexBuiltCount: int
    MexFirstBuiltFrame: int option
    EnergyBuiltCount: int
    EnergyFirstBuiltFrame: int option
    FactoryBuiltCount: int
    FactoryFirstBuiltFrame: int option
    FirstCombatUnitFrame: int option
    CrashMessage: string option
    WeaponFiredCount: int
    UnitDamagedCount: int
    EnemyDamagedCount: int
    UnitDestroyedCount: int
    EnemyDestroyedCount: int
}

/// A single pass/fail check applied to game outcomes.
type ValidationCriterion = {
    Id: string
    Description: string
    Evaluate: GameOutcome list -> bool
}

/// Aggregated results across a batch of game runs.
type ValidationReport = {
    SuiteName: string
    RunDate: DateTime
    TotalGames: int
    Outcomes: GameOutcome list
    Criteria: (ValidationCriterion * bool) list
    OverallPass: bool
}

/// Category of a test assertion.
[<RequireQualifiedAccess>]
type TestCategory =
    | Economy
    | BuildOrder
    | Movement
    | Scouting
    | Combat

/// A single verifiable condition within a test run.
type TestAssertion = {
    Name: string
    Category: TestCategory
    Passed: bool
    ActualValue: string
    ExpectedValue: string
    GameNumber: int
}

/// Aggregated test assertion results across multiple game runs.
type TestSuiteReport = {
    SuiteName: string
    RunDate: DateTime
    TotalRuns: int
    Assertions: TestAssertion list
    PassRate: float
    PassedCount: int
    FailedCount: int
    OverallPass: bool
}
