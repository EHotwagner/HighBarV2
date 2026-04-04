namespace HighBar.Client.Managers

open HighBar.Client
open HighBar.Client.Tasks
open HighBar.Client.Strategy

/// Build priority based on economy state.
[<RequireQualifiedAccess>]
type EconomyPriority =
    | BuildMex
    | BuildEnergy
    | Balanced

/// Monitors resource state and sets build priorities for builders.
type EconomyManager() =
    inherit ManagerBase("Economy")

    /// Determine what the economy needs most right now.
    static member GetPriority(eco: EconomyModel) =
        if EconomyModel.isEnergyStalled eco then
            EconomyPriority.BuildEnergy
        elif EconomyModel.isMetalStalled eco then
            EconomyPriority.BuildMex
        elif eco.MetalIncome < eco.EnergyIncome * 0.5f then
            EconomyPriority.BuildMex
        elif eco.EnergyIncome < eco.MetalIncome * 1.5f then
            EconomyPriority.BuildEnergy
        else
            EconomyPriority.Balanced

    /// Find the nearest unoccupied metal spot.
    static member FindBestMexSpot(mapModel: MapModel) =
        mapModel.MetalSpots
        |> List.filter (fun s -> not s.IsOccupied)
        |> List.sortBy (fun s -> s.DistanceFromBase)
        |> List.tryHead

    /// Pick an energy build position near base.
    static member GetEnergyPosition(mapModel: MapModel, offsetIndex: int) =
        let offset = float32 (80 + offsetIndex * 100)
        (mapModel.OurStartX + offset, mapModel.OurStartY, mapModel.OurStartZ + offset)

    /// Evaluate economy state and propose tasks for idle builders.
    member _.EvaluateEconomy(economy: EconomyModel, mapModel: MapModel,
                            registry: UnitRegistry, taskAssigner: TaskAssigner) : CommandProposal list =
        let priority = EconomyManager.GetPriority(economy)
        let proposals = System.Collections.Generic.List<CommandProposal>()

        // Find idle builders (not commanders initially, not factories)
        let idleBuilders =
            registry.GetFriendlyByClass(UnitClass.Builder)
            |> List.filter (fun u ->
                u.Lifecycle = UnitLifecycle.Ready &&
                not (u.Classification.HasFlag(UnitClass.Factory)) &&
                (taskAssigner.GetTask(u.UnitId) = UnitTask.Idle))

        let mutable energyOffset = 0
        for builder in idleBuilders do
            match priority with
            | EconomyPriority.BuildMex | EconomyPriority.Balanced ->
                match EconomyManager.FindBestMexSpot(mapModel) with
                | Some spot ->
                    proposals.Add({
                        UnitId = builder.UnitId
                        Task = UnitTask.BuildMex(spot.X, spot.Y, spot.Z)
                        Priority = 50
                    })
                | None ->
                    let (ex, ey, ez) = EconomyManager.GetEnergyPosition(mapModel, energyOffset)
                    energyOffset <- energyOffset + 1
                    proposals.Add({
                        UnitId = builder.UnitId
                        Task = UnitTask.BuildEnergy(ex, ey, ez)
                        Priority = 40
                    })
            | EconomyPriority.BuildEnergy ->
                let (ex, ey, ez) = EconomyManager.GetEnergyPosition(mapModel, energyOffset)
                energyOffset <- energyOffset + 1
                proposals.Add({
                    UnitId = builder.UnitId
                    Task = UnitTask.BuildEnergy(ex, ey, ez)
                    Priority = 50
                })

        proposals |> Seq.toList

    override _.Evaluate(_gameState: obj) = []
