namespace HighBar.Client

/// A single cell in the threat grid.
type ThreatCell = {
    mutable GroundThreat: float32
    mutable AirThreat: float32
    mutable LastUpdatedFrame: uint32
}

/// Grid-based spatial model of enemy force distribution.
type ThreatMap(mapWidth: int, mapHeight: int, cellSize: int) =
    let cols = max 1 (mapWidth / cellSize)
    let rows = max 1 (mapHeight / cellSize)
    let cells = Array2D.init cols rows (fun _ _ -> { GroundThreat = 0.0f; AirThreat = 0.0f; LastUpdatedFrame = 0u })

    member _.CellSize = cellSize
    member _.Cols = cols
    member _.Rows = rows

    /// Convert world position to grid coordinates.
    member _.ToGrid(x: float32, z: float32) =
        let col = min (cols - 1) (max 0 (int x / cellSize))
        let row = min (rows - 1) (max 0 (int z / cellSize))
        (col, row)

    /// Get the threat cell at a world position.
    member this.GetAt(x: float32, z: float32) =
        let col, row = this.ToGrid(x, z)
        cells.[col, row]

    /// Update ground threat at a position.
    member this.SetGroundThreat(x: float32, z: float32, dps: float32, frame: uint32) =
        let col, row = this.ToGrid(x, z)
        let cell = cells.[col, row]
        cell.GroundThreat <- dps
        cell.LastUpdatedFrame <- frame

    /// Add ground threat at a position.
    member this.AddGroundThreat(x: float32, z: float32, dps: float32, frame: uint32) =
        let col, row = this.ToGrid(x, z)
        let cell = cells.[col, row]
        cell.GroundThreat <- cell.GroundThreat + dps
        cell.LastUpdatedFrame <- frame

    /// Remove ground threat at a position.
    member this.RemoveGroundThreat(x: float32, z: float32, dps: float32) =
        let col, row = this.ToGrid(x, z)
        let cell = cells.[col, row]
        cell.GroundThreat <- max 0.0f (cell.GroundThreat - dps)

    /// Apply decay to all cells not updated since the given frame.
    member _.Decay(currentFrame: uint32, decayRate: float32) =
        for col in 0 .. cols - 1 do
            for row in 0 .. rows - 1 do
                let cell = cells.[col, row]
                if cell.LastUpdatedFrame < currentFrame && (cell.GroundThreat > 0.0f || cell.AirThreat > 0.0f) then
                    cell.GroundThreat <- cell.GroundThreat * decayRate
                    cell.AirThreat <- cell.AirThreat * decayRate
                    if cell.GroundThreat < 0.1f then cell.GroundThreat <- 0.0f
                    if cell.AirThreat < 0.1f then cell.AirThreat <- 0.0f

    /// Get total threat at a world position.
    member this.GetThreat(x: float32, z: float32) =
        let cell = this.GetAt(x, z)
        cell.GroundThreat + cell.AirThreat
