namespace HighBar.Client.Strategy

/// A metal extraction location on the map.
type MetalSpot = {
    X: float32
    Y: float32
    Z: float32
    MetalValue: float32
    mutable IsOccupied: bool
    mutable OccupiedByTeam: int option
    DistanceFromBase: float32
    mutable StrategicValue: float32
}

/// Static and dynamic map knowledge.
type MapModel = {
    Width: int
    Height: int
    MetalSpots: MetalSpot list
    StartPositions: (float32 * float32 * float32) list
    OurStartX: float32
    OurStartY: float32
    OurStartZ: float32
}

module MapAnalysis =
    let private distance (x1: float32) (z1: float32) (x2: float32) (z2: float32) =
        let dx = x1 - x2
        let dz = z1 - z2
        sqrt (dx * dx + dz * dz)

    /// Rank metal spots by distance from base and value.
    let rankMetalSpots (baseX: float32) (baseZ: float32) (spots: MetalSpot list) =
        spots
        |> List.sortBy (fun s -> s.DistanceFromBase)

    /// Create a MetalSpot from raw position data.
    let createSpot (baseX: float32) (baseZ: float32) (x: float32) (y: float32) (z: float32) (value: float32) =
        let dist = distance x z baseX baseZ
        {
            X = x; Y = y; Z = z
            MetalValue = value
            IsOccupied = false
            OccupiedByTeam = None
            DistanceFromBase = dist
            StrategicValue = value / (1.0f + dist / 1000.0f)
        }
