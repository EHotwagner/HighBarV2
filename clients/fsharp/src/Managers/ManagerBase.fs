namespace HighBar.Client.Managers

open Highbar
open HighBar.Client.Tasks

/// A command proposal from a manager.
type CommandProposal = {
    UnitId: int
    Task: UnitTask
    Priority: int
}

/// Base interface for all AI managers.
/// Each manager evaluates its domain per frame and returns command proposals.
[<AbstractClass>]
type ManagerBase(name: string) =
    member _.Name = name

    /// Evaluate the current game state and return proposed tasks for units.
    abstract member Evaluate: gameState: obj -> CommandProposal list
