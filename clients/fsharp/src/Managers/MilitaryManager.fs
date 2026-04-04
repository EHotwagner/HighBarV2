namespace HighBar.Client.Managers

open HighBar.Client
open HighBar.Client.Tasks
open HighBar.Client.Strategy

/// Coordinates combat — army grouping, attack decisions, retreat.
type MilitaryManager() =
    inherit ManagerBase("Military")

    let attackSquadSize = 5

    /// Evaluate military situation and propose combat tasks.
    member _.EvaluateMilitary(registry: UnitRegistry, taskAssigner: TaskAssigner,
                             threatMap: ThreatMap, mapModel: MapModel,
                             frame: uint32) : CommandProposal list =
        let proposals = System.Collections.Generic.List<CommandProposal>()

        // Retreat damaged units
        let damagedUnits =
            registry.GetFriendlyByClass(UnitClass.MobileArmed)
            |> List.filter (fun u ->
                u.Lifecycle = UnitLifecycle.Ready &&
                u.MaxHealth > 0.0f &&
                u.Health / u.MaxHealth < 0.3f &&
                not (u.Classification.HasFlag(UnitClass.Builder)))

        for damaged in damagedUnits do
            proposals.Add({
                UnitId = damaged.UnitId
                Task = UnitTask.Retreat(mapModel.OurStartX, mapModel.OurStartY, mapModel.OurStartZ)
                Priority = 80
            })

        // Defend base from nearby enemies
        let nearbyEnemies =
            registry.GetAliveEnemies()
            |> List.filter (fun e ->
                let dx = e.PosX - mapModel.OurStartX
                let dz = e.PosZ - mapModel.OurStartZ
                sqrt(dx*dx + dz*dz) < 1500.0f)

        if not nearbyEnemies.IsEmpty then
            let avgX = nearbyEnemies |> List.averageBy (fun e -> float e.PosX) |> float32
            let avgZ = nearbyEnemies |> List.averageBy (fun e -> float e.PosZ) |> float32

            let defenders =
                registry.GetFriendlyByClass(UnitClass.MobileArmed)
                |> List.filter (fun u ->
                    u.Lifecycle = UnitLifecycle.Ready &&
                    not (u.Classification.HasFlag(UnitClass.Builder)) &&
                    not (u.Classification.HasFlag(UnitClass.Factory)))
                |> List.truncate 10

            for defender in defenders do
                proposals.Add({
                    UnitId = defender.UnitId
                    Task = UnitTask.Attack(avgX, 0.0f, avgZ)
                    Priority = 70
                })
        else
            // Attack: group idle combat units and send them at known enemy positions
            let idleCombat =
                registry.GetFriendlyByClass(UnitClass.MobileArmed)
                |> List.filter (fun u ->
                    u.Lifecycle = UnitLifecycle.Ready &&
                    not (u.Classification.HasFlag(UnitClass.Builder)) &&
                    not (u.Classification.HasFlag(UnitClass.Factory)) &&
                    (taskAssigner.GetTask(u.UnitId) = UnitTask.Idle))

            if idleCombat.Length >= attackSquadSize then
                // Find a target: known enemy position or enemy start
                let target =
                    match registry.GetAliveEnemies() |> List.tryHead with
                    | Some enemy -> (enemy.PosX, enemy.PosY, enemy.PosZ)
                    | None ->
                        // Attack enemy start position
                        mapModel.StartPositions
                        |> List.tryFind (fun (sx, _, sz) ->
                            abs(sx - mapModel.OurStartX) > 500.0f || abs(sz - mapModel.OurStartZ) > 500.0f)
                        |> Option.defaultValue (mapModel.OurStartX, mapModel.OurStartY, mapModel.OurStartZ)

                let (tx, ty, tz) = target
                for unit in idleCombat do
                    proposals.Add({
                        UnitId = unit.UnitId
                        Task = UnitTask.Attack(tx, ty, tz)
                        Priority = 40
                    })

        proposals |> Seq.toList

    override _.Evaluate(_gameState: obj) = []
