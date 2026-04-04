namespace HighBar.Client.Managers

open HighBar.Client
open HighBar.Client.Tasks
open HighBar.Client.Strategy

/// Manages factory production queues and unit mix.
type ProductionManager() =
    inherit ManagerBase("Production")

    /// Evaluate idle factories and propose unit production.
    member _.EvaluateProduction(registry: UnitRegistry, taskAssigner: TaskAssigner,
                               phase: GamePhase, economy: EconomyModel) : CommandProposal list =
        let proposals = System.Collections.Generic.List<CommandProposal>()

        // Find idle factories
        let idleFactories =
            registry.GetFriendlyByClass(UnitClass.Factory)
            |> List.filter (fun u ->
                u.Lifecycle = UnitLifecycle.Ready &&
                (taskAssigner.GetTask(u.UnitId) = UnitTask.Idle))

        for factory in idleFactories do
            match registry.TryGetDef(factory.DefId) with
            | Some factoryDef when factoryDef.BuildOptions.Length > 0 ->
                // Select unit to produce based on ratios
                // Simple heuristic: pick cheapest armed mobile unit
                let combatUnits =
                    factoryDef.BuildOptions
                    |> Array.choose (fun bid ->
                        match registry.TryGetDef(bid) with
                        | Some d when d.MaxWeaponRange > 0.0f && d.BuildSpeed = 0.0f -> Some (bid, d)
                        | _ -> None)

                let builderUnits =
                    factoryDef.BuildOptions
                    |> Array.choose (fun bid ->
                        match registry.TryGetDef(bid) with
                        | Some d when d.BuildSpeed > 0.0f -> Some (bid, d)
                        | _ -> None)

                // Production ratio: 70% combat, 30% builders
                let existingCombat =
                    registry.GetFriendlyByClass(UnitClass.MobileArmed)
                    |> List.filter (fun u -> not (u.Classification.HasFlag(UnitClass.Builder)))
                    |> List.length

                let existingBuilders =
                    registry.GetFriendlyByClass(UnitClass.Builder)
                    |> List.filter (fun u ->
                        not (u.Classification.HasFlag(UnitClass.Factory)) &&
                        not (u.Classification.HasFlag(UnitClass.Commander)))
                    |> List.length

                let needBuilders = existingBuilders < max 2 (existingCombat / 3)

                let selectedDefId =
                    if needBuilders && builderUnits.Length > 0 then
                        // Pick cheapest builder
                        builderUnits
                        |> Array.minBy (fun (_, d) -> d.Cost)
                        |> fst
                    elif combatUnits.Length > 0 then
                        // Pick cheapest combat unit
                        combatUnits
                        |> Array.minBy (fun (_, d) -> d.Cost)
                        |> fst
                    elif factoryDef.BuildOptions.Length > 0 then
                        factoryDef.BuildOptions.[0]
                    else
                        -1

                if selectedDefId > 0 then
                    proposals.Add({
                        UnitId = factory.UnitId
                        Task = UnitTask.Produce(selectedDefId)
                        Priority = 45
                    })
            | _ -> ()

        proposals |> Seq.toList

    override _.Evaluate(_gameState: obj) = []
