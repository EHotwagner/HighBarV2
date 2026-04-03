module BarData.Tests.StructuralTests

open Xunit
open BarData
open BarData.Units

[<Fact>]
let ``most units do not have Concrete 0 for health`` () =
    // Some units legitimately have 0 health (drones, geo-derived units with expression health)
    let zeroHealth =
        AllUnits.all
        |> List.filter (fun (_, _, u) ->
            match u.health with ValueOrExpr.Concrete 0.0 -> true | _ -> false)
    // Allow up to 20 units with zero health (known edge cases: geos, drones, evolved units)
    Assert.True(zeroHealth.Length < 20, sprintf "Too many units with zero health (%d): %A" zeroHealth.Length (zeroHealth |> List.map (fun (n,_,_) -> n)))

[<Fact>]
let ``no unit has negative metalCost`` () =
    let negative =
        AllUnits.all
        |> List.filter (fun (_, _, u) ->
            match u.metalCost with ValueOrExpr.Concrete n when n < 0.0 -> true | _ -> false)
    Assert.True(negative.IsEmpty, sprintf "Units with negative metalCost: %A" (negative |> List.map (fun (n,_,_) -> n)))

[<Fact>]
let ``most builders have non-empty buildOptions`` () =
    // Some builders (EvoCom, upgraded commanders, raptors) use VFS.Include for build options
    let totalBuilders = AllUnits.all |> List.filter (fun (_, _, u) -> u.builder.IsSome) |> List.length
    let buildersWithOpts = AllUnits.all |> List.filter (fun (_, _, u) -> match u.builder with Some b -> not b.buildOptions.IsEmpty | None -> false) |> List.length
    Assert.True(buildersWithOpts > totalBuilders / 2, sprintf "Expected most builders to have buildOptions: %d/%d" buildersWithOpts totalBuilders)

[<Fact>]
let ``most armed units have at least one weapon with non-empty damage map`` () =
    let armedUnits = AllUnits.all |> List.filter (fun (_, _, u) -> u.weapons.IsSome)
    let withDamage = armedUnits |> List.filter (fun (_, _, u) ->
        match u.weapons with
        | Some ws -> ws |> List.exists (fun w -> not w.damage.IsEmpty)
        | None -> false)
    // Allow some weapons without damage maps (some weapons use expression-based damage)
    Assert.True(withDamage.Length > armedUnits.Length * 9 / 10,
        sprintf "Expected >90%% of armed units to have damage maps: %d/%d" withDamage.Length armedUnits.Length)

[<Fact>]
let ``Expr values preserve non-empty expression text`` () =
    // armassistdrone_land has workerTime as an Expr containing Spring.GetModOptions
    let drone = Root.armassistdrone_land
    match drone.builder with
    | Some b ->
        match b.workerTime with
        | ValueOrExpr.Expr s ->
            Assert.True(s.Contains("Spring.GetModOptions"), sprintf "Expected Spring.GetModOptions in expression, got: %s" s)
        | ValueOrExpr.Concrete _ ->
            Assert.Fail("Expected Expr for armassistdrone_land workerTime, got Concrete")
    | None -> Assert.Fail("armassistdrone_land should be a builder")

[<Fact>]
let ``at least one unit has non-empty extras map`` () =
    let hasExtras =
        AllUnits.all
        |> List.exists (fun (_, _, u) -> not u.extras.IsEmpty)
    Assert.True(hasExtras, "At least one unit should have non-empty extras (unrecognized fields)")

[<Fact>]
let ``all unit names are non-empty`` () =
    let emptyNames =
        AllUnits.all
        |> List.filter (fun (n, _, _) -> System.String.IsNullOrEmpty(n))
    Assert.True(emptyNames.IsEmpty, "Found units with empty names")

[<Fact>]
let ``no duplicate unit names in AllUnits`` () =
    let names = AllUnits.all |> List.map (fun (n, _, _) -> n)
    let unique = names |> List.distinct
    Assert.Equal(names.Length, unique.Length)
