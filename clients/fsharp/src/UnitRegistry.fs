namespace HighBar.Client

open System.Collections.Generic

/// Classification of a unit based on its engine properties.
[<System.Flags>]
type UnitClass =
    | None = 0
    | Commander = 1
    | Builder = 2
    | Factory = 4
    | MobileArmed = 8
    | StaticDefense = 16
    | Scout = 32
    | Economy = 64
    | Radar = 128
    | Transport = 256

/// Lifecycle state of a tracked unit.
[<RequireQualifiedAccess>]
type UnitLifecycle =
    | Alive
    | Ready
    | Dead
    | LastKnown
    | Forgotten

/// A unit definition discovered from the engine at init time.
type RuntimeUnitDef = {
    DefId: int
    Name: string
    BuildOptions: int array
    MaxWeaponRange: float32
    BuildSpeed: float32
    Cost: float32
    BuildTime: float32
    Classification: UnitClass
}

/// A tracked unit instance (friendly or enemy).
type UnitRecord = {
    UnitId: int
    DefId: int
    Team: int
    IsFriendly: bool
    UnitName: string
    mutable PosX: float32
    mutable PosY: float32
    mutable PosZ: float32
    mutable Health: float32
    mutable MaxHealth: float32
    mutable Lifecycle: UnitLifecycle
    mutable LastSeenFrame: uint32
    Classification: UnitClass
}

/// Runtime registry mapping engine DefIds to unit definitions and tracking all known units.
type UnitRegistry() =
    let defs = Dictionary<int, RuntimeUnitDef>()
    let units = Dictionary<int, UnitRecord>()
    let friendlyUnits = Dictionary<int, UnitRecord>()
    let enemyUnits = Dictionary<int, UnitRecord>()
    let defsByName = Dictionary<string, RuntimeUnitDef>()

    /// All discovered unit definitions.
    member _.Defs = defs :> IReadOnlyDictionary<int, RuntimeUnitDef>

    /// All tracked unit instances.
    member _.Units = units :> IReadOnlyDictionary<int, UnitRecord>

    /// Friendly unit instances.
    member _.FriendlyUnits = friendlyUnits :> IReadOnlyDictionary<int, UnitRecord>

    /// Enemy unit instances.
    member _.EnemyUnits = enemyUnits :> IReadOnlyDictionary<int, UnitRecord>

    /// Look up a unit definition by engine DefId.
    member _.TryGetDef(defId: int) =
        match defs.TryGetValue(defId) with
        | true, d -> Some d
        | _ -> None

    /// Look up a unit definition by name.
    member _.TryGetDefByName(name: string) =
        match defsByName.TryGetValue(name) with
        | true, d -> Some d
        | _ -> None

    /// Register a unit definition discovered from the engine.
    member _.RegisterDef(def: RuntimeUnitDef) =
        defs.[def.DefId] <- def
        if not (System.String.IsNullOrEmpty(def.Name)) then
            defsByName.[def.Name] <- def

    /// Classify a unit based on engine-queried properties.
    static member Classify(buildOptions: int array, maxWeaponRange: float32, buildSpeed: float32,
                           cost: float32, name: string) : UnitClass =
        let mutable cls = UnitClass.None

        // Commander: name contains "com" and is a builder with weapons
        if (name.Contains("com") || name.Contains("decoy")) && buildSpeed > 0.0f && maxWeaponRange > 0.0f then
            cls <- cls ||| UnitClass.Commander

        // Builder: has build speed > 0
        if buildSpeed > 0.0f then
            cls <- cls ||| UnitClass.Builder

        // Factory: has build options and name suggests building
        if buildOptions.Length > 0 && buildSpeed > 0.0f then
            cls <- cls ||| UnitClass.Factory

        // MobileArmed: has weapons (check for armed units that aren't buildings)
        if maxWeaponRange > 0.0f then
            cls <- cls ||| UnitClass.MobileArmed

        // StaticDefense: armed but not mobile (we'll refine with more callbacks later)
        // For now, classification is approximate

        // Scout: cheap, fast (heuristic: low cost + has mobility)
        if cost < 200.0f && cost > 0.0f && maxWeaponRange = 0.0f && buildSpeed = 0.0f then
            cls <- cls ||| UnitClass.Scout

        // Economy: name heuristics for resource structures
        if name.Contains("mex") || name.Contains("solar") || name.Contains("wind") ||
           name.Contains("fusion") || name.Contains("geo") || name.Contains("moho") then
            cls <- cls ||| UnitClass.Economy

        // Radar
        if name.Contains("radar") || name.Contains("arad") then
            cls <- cls ||| UnitClass.Radar

        cls

    /// Query engine at init to discover all unit definitions.
    member this.DiscoverFromEngine(client: HighBarClient) =
        let defIds = client.GetUnitDefs(1000)
        for defId in defIds do
            if defId > 0 then
                let name = client.GetUnitDefName(defId)
                let buildOptions = client.GetBuildOptions(defId)
                let maxRange = client.GetMaxWeaponRange(defId)
                let buildSpeed = client.GetBuildSpeed(defId)
                let cost = client.GetUnitDefCost(defId)
                let buildTime = client.GetUnitDefBuildTime(defId)
                let cls = UnitRegistry.Classify(buildOptions, maxRange, buildSpeed, cost, name)
                this.RegisterDef({
                    DefId = defId
                    Name = name
                    BuildOptions = buildOptions
                    MaxWeaponRange = maxRange
                    BuildSpeed = buildSpeed
                    Cost = cost
                    BuildTime = buildTime
                    Classification = cls
                })

    /// Track a new unit (friendly).
    member _.TrackFriendly(unitId: int, defId: int, team: int, unitName: string) =
        let def = match defs.TryGetValue(defId) with | true, d -> d.Classification | _ -> UnitClass.None
        let record = {
            UnitId = unitId; DefId = defId; Team = team; IsFriendly = true
            UnitName = unitName
            PosX = 0.0f; PosY = 0.0f; PosZ = 0.0f
            Health = 0.0f; MaxHealth = 0.0f
            Lifecycle = UnitLifecycle.Alive; LastSeenFrame = 0u
            Classification = def
        }
        units.[unitId] <- record
        friendlyUnits.[unitId] <- record

    /// Track a new enemy unit.
    member _.TrackEnemy(unitId: int, defId: int, team: int, unitName: string) =
        let def = match defs.TryGetValue(defId) with | true, d -> d.Classification | _ -> UnitClass.None
        let record = {
            UnitId = unitId; DefId = defId; Team = team; IsFriendly = false
            UnitName = unitName
            PosX = 0.0f; PosY = 0.0f; PosZ = 0.0f
            Health = 0.0f; MaxHealth = 0.0f
            Lifecycle = UnitLifecycle.Alive; LastSeenFrame = 0u
            Classification = def
        }
        units.[unitId] <- record
        enemyUnits.[unitId] <- record

    /// Update a unit's position.
    member _.UpdatePosition(unitId: int, x: float32, y: float32, z: float32, frame: uint32) =
        match units.TryGetValue(unitId) with
        | true, u ->
            u.PosX <- x; u.PosY <- y; u.PosZ <- z
            u.LastSeenFrame <- frame
        | _ -> ()

    /// Update a unit's health.
    member _.UpdateHealth(unitId: int, health: float32, maxHealth: float32) =
        match units.TryGetValue(unitId) with
        | true, u ->
            u.Health <- health
            u.MaxHealth <- maxHealth
        | _ -> ()

    /// Mark a unit as finished (ready for commands).
    member _.MarkFinished(unitId: int) =
        match units.TryGetValue(unitId) with
        | true, u -> u.Lifecycle <- UnitLifecycle.Ready
        | _ -> ()

    /// Mark a unit as destroyed.
    member _.MarkDestroyed(unitId: int) =
        match units.TryGetValue(unitId) with
        | true, u ->
            u.Lifecycle <- UnitLifecycle.Dead
            friendlyUnits.Remove(unitId) |> ignore
            enemyUnits.Remove(unitId) |> ignore
        | _ -> ()

    /// Mark an enemy as last known (left LOS).
    member _.MarkLastKnown(unitId: int) =
        match units.TryGetValue(unitId) with
        | true, u -> u.Lifecycle <- UnitLifecycle.LastKnown
        | _ -> ()

    /// Mark an enemy as back in LOS.
    member _.MarkInLOS(unitId: int, frame: uint32) =
        match units.TryGetValue(unitId) with
        | true, u ->
            u.Lifecycle <- UnitLifecycle.Ready
            u.LastSeenFrame <- frame
        | _ -> ()

    /// Try get a unit record.
    member _.TryGet(unitId: int) =
        match units.TryGetValue(unitId) with
        | true, u -> Some u
        | _ -> None

    /// Get all friendly units with a specific classification flag.
    member _.GetFriendlyByClass(cls: UnitClass) =
        friendlyUnits.Values
        |> Seq.filter (fun u -> u.Lifecycle <> UnitLifecycle.Dead && u.Classification.HasFlag(cls))
        |> Seq.toList

    /// Get all alive enemy units.
    member _.GetAliveEnemies() =
        enemyUnits.Values
        |> Seq.filter (fun u -> u.Lifecycle <> UnitLifecycle.Dead && u.Lifecycle <> UnitLifecycle.Forgotten)
        |> Seq.toList
