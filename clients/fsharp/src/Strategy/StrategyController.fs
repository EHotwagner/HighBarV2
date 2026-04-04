namespace HighBar.Client.Strategy

/// Game phase — transitions are one-directional.
[<RequireQualifiedAccess>]
type GamePhase =
    | Opening
    | Expansion
    | MidGame
    | LateGame

/// Manager priority weights by game phase.
type PhaseWeights = {
    Economy: int
    Build: int
    Production: int
    Scout: int
    Military: int
}

module StrategyController =
    /// Priority weights per phase.
    let getWeights (phase: GamePhase) =
        match phase with
        | GamePhase.Opening ->
            { Economy = 60; Build = 60; Production = 30; Scout = 20; Military = 10 }
        | GamePhase.Expansion ->
            { Economy = 50; Build = 50; Production = 40; Scout = 25; Military = 20 }
        | GamePhase.MidGame ->
            { Economy = 30; Build = 30; Production = 45; Scout = 30; Military = 50 }
        | GamePhase.LateGame ->
            { Economy = 20; Build = 20; Production = 40; Scout = 25; Military = 60 }

    /// Evaluate phase transitions based on game state milestones.
    let evaluatePhase (currentPhase: GamePhase) (factoryCount: int) (armyValue: float32) (hasT2Factory: bool) =
        match currentPhase with
        | GamePhase.Opening when factoryCount >= 1 ->
            GamePhase.Expansion
        | GamePhase.Expansion when factoryCount >= 2 && armyValue > 500.0f ->
            GamePhase.MidGame
        | GamePhase.MidGame when hasT2Factory || armyValue > 5000.0f ->
            GamePhase.LateGame
        | phase -> phase
