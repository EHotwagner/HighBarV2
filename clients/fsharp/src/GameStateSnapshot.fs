namespace HighBar.Client

open Highbar

/// Friendly unit observation — full visibility (position + health).
type FriendlyUnit = {
    UnitId: int
    X: float32
    Y: float32
    Z: float32
    Health: float32
    UnitDefId: int
    Team: int
}

/// LOS-visible enemy — full visibility (position + health).
type LosEnemyUnit = {
    UnitId: int
    X: float32
    Y: float32
    Z: float32
    Health: float32
    UnitDefId: int
    Team: int
}

/// Radar-only enemy — position only; structurally no health field (Decision 4).
type RadarOnlyEnemyUnit = {
    UnitId: int
    X: float32
    Y: float32
    Z: float32
    UnitDefId: int
    Team: int
}

/// Economy snapshot (metal + energy).
type EconomyRecord = {
    MetalCurrent: float32
    MetalIncome: float32
    MetalUsage: float32
    MetalStorage: float32
    EnergyCurrent: float32
    EnergyIncome: float32
    EnergyUsage: float32
    EnergyStorage: float32
}

/// One-call per-tick game state snapshot returned by client.GetGameState().
type GameStateSnapshot = {
    Frame: int
    Friendlies: FriendlyUnit list
    LosEnemies: LosEnemyUnit list
    RadarOnlyEnemies: RadarOnlyEnemyUnit list
    Economy: EconomyRecord
}

module GameStateSnapshot =
    let private friendlyFromProto (p: Highbar.FriendlyUnit) : FriendlyUnit =
        let pos = p.Position
        { UnitId = p.UnitId
          X = (if isNull pos then 0.0f else pos.X)
          Y = (if isNull pos then 0.0f else pos.Y)
          Z = (if isNull pos then 0.0f else pos.Z)
          Health = p.Health
          UnitDefId = p.UnitDefId
          Team = p.Team }

    let private losFromProto (p: Highbar.LosEnemyUnit) : LosEnemyUnit =
        let pos = p.Position
        { UnitId = p.UnitId
          X = (if isNull pos then 0.0f else pos.X)
          Y = (if isNull pos then 0.0f else pos.Y)
          Z = (if isNull pos then 0.0f else pos.Z)
          Health = p.Health
          UnitDefId = p.UnitDefId
          Team = p.Team }

    let private radarFromProto (p: Highbar.RadarOnlyEnemyUnit) : RadarOnlyEnemyUnit =
        let pos = p.Position
        { UnitId = p.UnitId
          X = (if isNull pos then 0.0f else pos.X)
          Y = (if isNull pos then 0.0f else pos.Y)
          Z = (if isNull pos then 0.0f else pos.Z)
          UnitDefId = p.UnitDefId
          Team = p.Team }

    let private economyFromProto (p: Highbar.EconomyRecord) : EconomyRecord =
        if isNull p then
            { MetalCurrent = 0.0f; MetalIncome = 0.0f; MetalUsage = 0.0f; MetalStorage = 0.0f
              EnergyCurrent = 0.0f; EnergyIncome = 0.0f; EnergyUsage = 0.0f; EnergyStorage = 0.0f }
        else
            { MetalCurrent = p.MetalCurrent
              MetalIncome = p.MetalIncome
              MetalUsage = p.MetalUsage
              MetalStorage = p.MetalStorage
              EnergyCurrent = p.EnergyCurrent
              EnergyIncome = p.EnergyIncome
              EnergyUsage = p.EnergyUsage
              EnergyStorage = p.EnergyStorage }

    /// Convert the generated protobuf snapshot message into the F# record.
    let fromProto (p: Highbar.GameStateSnapshot) : GameStateSnapshot =
        { Frame = p.Frame
          Friendlies = [ for f in p.Friendlies -> friendlyFromProto f ]
          LosEnemies = [ for e in p.LosEnemies -> losFromProto e ]
          RadarOnlyEnemies = [ for e in p.RadarOnlyEnemies -> radarFromProto e ]
          Economy = economyFromProto p.Economy }
