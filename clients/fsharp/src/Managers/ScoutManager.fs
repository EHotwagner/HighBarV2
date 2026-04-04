namespace HighBar.Client.Managers

open HighBar.Client
open HighBar.Client.Tasks
open HighBar.Client.Strategy

/// Manages map exploration and enemy tracking.
type ScoutManager() =
    inherit ManagerBase("Scout")

    let mutable scoutTargetIndex = 0

    /// Evaluate and propose scouting tasks for idle scouts/cheap mobile units.
    member _.EvaluateScout(registry: UnitRegistry, taskAssigner: TaskAssigner,
                          mapModel: MapModel, frame: uint32) : CommandProposal list =
        let proposals = System.Collections.Generic.List<CommandProposal>()

        // Build list of scout targets: enemy start positions, then map corners
        let targets = [
            // Enemy start positions
            for (sx, sy, sz) in mapModel.StartPositions do
                if abs(sx - mapModel.OurStartX) > 500.0f || abs(sz - mapModel.OurStartZ) > 500.0f then
                    yield (sx, sy, sz)
            // Map quadrants
            let w = float32 (mapModel.Width * 8)
            let h = float32 (mapModel.Height * 8)
            yield (w * 0.25f, 0.0f, h * 0.25f)
            yield (w * 0.75f, 0.0f, h * 0.25f)
            yield (w * 0.25f, 0.0f, h * 0.75f)
            yield (w * 0.75f, 0.0f, h * 0.75f)
        ]

        if targets.IsEmpty then proposals |> Seq.toList
        else

        // Find idle scout-like units (fast, cheap, or units classified as Scout)
        let idleScouts =
            registry.GetFriendlyByClass(UnitClass.MobileArmed)
            |> List.filter (fun u ->
                u.Lifecycle = UnitLifecycle.Ready &&
                not (u.Classification.HasFlag(UnitClass.Builder)) &&
                not (u.Classification.HasFlag(UnitClass.Factory)) &&
                (taskAssigner.GetTask(u.UnitId) = UnitTask.Idle))
            |> List.truncate 2

        for scout in idleScouts do
            let (tx, ty, tz) = targets.[scoutTargetIndex % targets.Length]
            scoutTargetIndex <- scoutTargetIndex + 1
            proposals.Add({
                UnitId = scout.UnitId
                Task = UnitTask.Scout(tx, ty, tz)
                Priority = 30
            })

        proposals |> Seq.toList

    override _.Evaluate(_gameState: obj) = []
