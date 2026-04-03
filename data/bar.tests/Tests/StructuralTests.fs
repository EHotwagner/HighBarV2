module BarData.Tests.StructuralTests

open Xunit
open BarData
open BarData.Units

let concrete (v: ValueOrExpr<float>) =
    match v with
    | ValueOrExpr.Concrete n -> n
    | ValueOrExpr.Expr _ -> 1.0 // expressions are valid, treat as non-zero

/// Verify that the vast majority of units have positive health.
/// A small number of edge cases (e.g., hats, critters) may have zero health.
[<Fact>]
let ``most units have positive health`` () =
    let allSummaries = AllUnits.all
    let zeroHealth =
        allSummaries
        |> List.filter (fun u ->
            match u.health with
            | ValueOrExpr.Concrete n -> n <= 0.0
            | ValueOrExpr.Expr _ -> false)
    // Allow up to 20 edge cases
    Assert.True(zeroHealth.Length <= 20, sprintf "Too many units with zero health: %d" zeroHealth.Length)

/// Verify no unit has negative metalCost.
[<Fact>]
let ``no unit has negative metalCost`` () =
    let negCost =
        AllUnits.all
        |> List.filter (fun u ->
            match u.metalCost with
            | ValueOrExpr.Concrete n -> n < 0.0
            | ValueOrExpr.Expr _ -> false)
    Assert.Empty(negCost)

/// Verify builders have non-empty buildOptions.
[<Fact>]
let ``armck builder has non-empty buildOptions`` () =
    Assert.NotEmpty(ArmBots.armck.buildOptions)

[<Fact>]
let ``corck builder has non-empty buildOptions`` () =
    Assert.NotEmpty(CorBots.corck.buildOptions)

/// Verify armed units have weapons.
[<Fact>]
let ``armham has weapons`` () =
    Assert.NotEmpty(ArmBots.armham.weapons)

[<Fact>]
let ``armham weapons have non-empty damage maps`` () =
    for w in ArmBots.armham.weapons do
        Assert.False(w.damage.IsEmpty, sprintf "Weapon %s has empty damage map" w.name)

/// Verify all unit names are non-empty and unique.
[<Fact>]
let ``all unit names are non-empty`` () =
    let allSummaries = AllUnits.all
    for u in allSummaries do
        Assert.False(System.String.IsNullOrWhiteSpace u.name, "Found unit with empty name")

[<Fact>]
let ``all unit names are unique`` () =
    let allSummaries = AllUnits.all
    let names = allSummaries |> List.map (fun u -> u.name)
    let uniqueNames = names |> Set.ofList
    Assert.Equal(names.Length, uniqueNames.Count)

/// T032: Verify zero data loss — at least one unit has non-empty extras map.
[<Fact>]
let ``at least one unit has non-empty extras`` () =
    // armck has extras (e.g., "upright" = "true")
    Assert.False(ArmBots.armck.extras.IsEmpty, "Expected armck to have non-empty extras")

/// T033: Verify expression preservation — Expr values contain original Lua expression text.
[<Fact>]
let ``Expr values preserve original Lua expression text`` () =
    // armrespawn and similar units use Lua expressions like "range" for sightDistance
    match other.armrespawn.sightDistance with
    | ValueOrExpr.Expr s ->
        Assert.False(System.String.IsNullOrWhiteSpace s, "Expr should contain expression text")
    | ValueOrExpr.Concrete _ ->
        Assert.Fail("Expected armrespawn.sightDistance to be an Expr, not Concrete")
