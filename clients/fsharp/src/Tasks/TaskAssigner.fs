namespace HighBar.Client.Tasks

open System.Collections.Generic
open HighBar.Client.Managers

/// Assigns and reassigns UnitTask to friendly units based on manager proposals.
/// Each unit has exactly one task at any time.
type TaskAssigner() =
    let assignments = Dictionary<int, UnitTask>()

    /// Get the current task for a unit.
    member _.GetTask(unitId: int) =
        match assignments.TryGetValue(unitId) with
        | true, task -> task
        | _ -> UnitTask.Idle

    /// Assign a task to a unit.
    member _.Assign(unitId: int, task: UnitTask) =
        assignments.[unitId] <- task

    /// Remove a unit's task (e.g. when destroyed).
    member _.Remove(unitId: int) =
        assignments.Remove(unitId) |> ignore

    /// Get all unit-task assignments.
    member _.AllAssignments =
        assignments |> Seq.map (fun kv -> kv.Key, kv.Value) |> Seq.toList

    /// Process proposals from managers, resolving conflicts by priority.
    /// Higher priority wins. Defense > current task > new assignment.
    member this.ProcessProposals(proposals: CommandProposal list) =
        let bestByUnit = Dictionary<int, CommandProposal>()
        for p in proposals do
            match bestByUnit.TryGetValue(p.UnitId) with
            | true, existing when existing.Priority >= p.Priority -> ()
            | _ -> bestByUnit.[p.UnitId] <- p

        for kv in bestByUnit do
            this.Assign(kv.Key, kv.Value.Task)
