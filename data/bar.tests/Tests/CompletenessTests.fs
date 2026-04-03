module BarData.Tests.CompletenessTests

open Xunit
open BarData

[<Fact>]
let ``AllUnits contains at least 950 units`` () =
    Assert.True(AllUnits.all.Length >= 950, sprintf "Expected >= 950 units, got %d" AllUnits.all.Length)

[<Fact>]
let ``Arm faction has at least 200 units`` () =
    let armUnits = AllUnits.all |> List.filter (fun u -> u.subfolder.StartsWith("Arm"))
    Assert.True(armUnits.Length >= 200, sprintf "Expected >= 200 Arm units, got %d" armUnits.Length)

[<Fact>]
let ``Cor faction has at least 200 units`` () =
    let corUnits = AllUnits.all |> List.filter (fun u -> u.subfolder.StartsWith("Cor"))
    Assert.True(corUnits.Length >= 200, sprintf "Expected >= 200 Cor units, got %d" corUnits.Length)

[<Fact>]
let ``Legion faction has at least 220 units`` () =
    let legUnits = AllUnits.all |> List.filter (fun u -> u.subfolder.StartsWith("Legion"))
    Assert.True(legUnits.Length >= 220, sprintf "Expected >= 220 Legion units, got %d" legUnits.Length)

[<Fact>]
let ``Scavengers faction has at least 80 units`` () =
    let scavUnits = AllUnits.all |> List.filter (fun u -> u.subfolder.StartsWith("Scavengers"))
    Assert.True(scavUnits.Length >= 80, sprintf "Expected >= 80 Scavenger units, got %d" scavUnits.Length)

[<Fact>]
let ``tryFind returns Some for known unit`` () =
    let result = AllUnits.tryFind "armck"
    Assert.True(result.IsSome, "Expected to find armck")
    Assert.Equal("armck", result.Value.name)

[<Fact>]
let ``tryFind returns None for unknown unit`` () =
    let result = AllUnits.tryFind "nonexistent_unit_xyz"
    Assert.True(result.IsNone, "Expected None for nonexistent unit")
