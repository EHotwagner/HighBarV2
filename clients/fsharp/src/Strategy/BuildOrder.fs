namespace HighBar.Client.Strategy

/// A single step in the opening build order.
[<RequireQualifiedAccess>]
type BuildStep =
    | Mex
    | Energy
    | Factory
    | Radar

/// Armada opening build order sequences.
module BuildOrder =
    /// Standard Armada opening: 2 mex → energy → factory → 2 mex → energy
    let armadaOpening = [
        BuildStep.Mex
        BuildStep.Mex
        BuildStep.Energy
        BuildStep.Factory
        BuildStep.Mex
        BuildStep.Mex
        BuildStep.Energy
    ]
