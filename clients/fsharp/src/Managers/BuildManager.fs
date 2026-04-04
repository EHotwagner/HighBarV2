namespace HighBar.Client.Managers

open HighBar.Client
open HighBar.Client.Tasks
open HighBar.Client.Strategy

/// Manages structure placement and build orders.
type BuildManager() =
    inherit ManagerBase("Build")

    let mutable buildOrderIndex = 0
    let buildOrder = BuildOrder.armadaOpening

    /// Evaluate build order and propose construction tasks.
    member _.EvaluateBuild(economy: EconomyModel, mapModel: MapModel,
                          registry: UnitRegistry, taskAssigner: TaskAssigner,
                          frame: uint32) : CommandProposal list =
        if buildOrderIndex >= buildOrder.Length then []
        else

        let proposals = System.Collections.Generic.List<CommandProposal>()

        // Find idle builders (commanders first during opening)
        let idleBuilders =
            registry.GetFriendlyByClass(UnitClass.Builder)
            |> List.filter (fun u ->
                u.Lifecycle = UnitLifecycle.Ready &&
                not (u.Classification.HasFlag(UnitClass.Factory)) &&
                (taskAssigner.GetTask(u.UnitId) = UnitTask.Idle))

        match idleBuilders with
        | [] -> ()
        | builder :: _ ->
            let step = buildOrder.[buildOrderIndex]
            match step with
            | BuildStep.Mex ->
                match EconomyManager.FindBestMexSpot(mapModel) with
                | Some spot ->
                    proposals.Add({
                        UnitId = builder.UnitId
                        Task = UnitTask.BuildMex(spot.X, spot.Y, spot.Z)
                        Priority = 60
                    })
                    buildOrderIndex <- buildOrderIndex + 1
                | None ->
                    buildOrderIndex <- buildOrderIndex + 1

            | BuildStep.Energy ->
                let (ex, ey, ez) = EconomyManager.GetEnergyPosition(mapModel, 0)
                proposals.Add({
                    UnitId = builder.UnitId
                    Task = UnitTask.BuildEnergy(ex, ey, ez)
                    Priority = 60
                })
                buildOrderIndex <- buildOrderIndex + 1

            | BuildStep.Factory ->
                // Find a factory DefId from commander's build options
                match registry.TryGetDef(builder.DefId) with
                | Some def ->
                    let factoryDefId =
                        def.BuildOptions
                        |> Array.tryFind (fun bid ->
                            match registry.TryGetDef(bid) with
                            | Some d -> d.BuildOptions.Length > 0 && d.BuildSpeed > 0.0f
                            | None -> false)
                    match factoryDefId with
                    | Some fid ->
                        let fx = mapModel.OurStartX + 200.0f
                        let fz = mapModel.OurStartZ
                        proposals.Add({
                            UnitId = builder.UnitId
                            Task = UnitTask.BuildFactory(fid, fx, mapModel.OurStartY, fz)
                            Priority = 60
                        })
                        buildOrderIndex <- buildOrderIndex + 1
                    | None ->
                        buildOrderIndex <- buildOrderIndex + 1
                | None ->
                    buildOrderIndex <- buildOrderIndex + 1

            | BuildStep.Radar ->
                buildOrderIndex <- buildOrderIndex + 1

        proposals |> Seq.toList

    override _.Evaluate(_gameState: obj) = []
