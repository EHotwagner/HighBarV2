namespace HighBar.Client.Tasks

/// Per-unit task discriminated union.
/// Each friendly unit has exactly one assigned task at any time.
[<RequireQualifiedAccess>]
type UnitTask =
    | Idle
    | BuildMex of mexX: float32 * mexY: float32 * mexZ: float32
    | BuildEnergy of posX: float32 * posY: float32 * posZ: float32
    | BuildFactory of defId: int * posX: float32 * posY: float32 * posZ: float32
    | BuildStructure of defId: int * posX: float32 * posY: float32 * posZ: float32
    | Produce of defId: int
    | Scout of targetX: float32 * targetY: float32 * targetZ: float32
    | Attack of targetX: float32 * targetY: float32 * targetZ: float32
    | Defend of posX: float32 * posY: float32 * posZ: float32
    | Retreat of safeX: float32 * safeY: float32 * safeZ: float32
    | Guard of targetUnitId: int
    | Reclaim of targetId: int
    | Repair of targetUnitId: int
