module BarData.Tests.CompletenessTests

open Xunit
open BarData
open BarData.Units

[<Fact>]
let ``AllUnits contains at least 950 entries`` () =
    Assert.True(AllUnits.all.Length >= 950, sprintf "Expected >= 950 units, got %d" AllUnits.all.Length)

[<Fact>]
let ``Arm faction has expected unit count`` () =
    let armCount = AllUnits.all |> List.filter (fun (_, sub, _) -> sub.StartsWith("Arm")) |> List.length
    Assert.True(armCount >= 200, sprintf "Expected >= 200 Arm units, got %d" armCount)

[<Fact>]
let ``Cor faction has expected unit count`` () =
    let corCount = AllUnits.all |> List.filter (fun (_, sub, _) -> sub.StartsWith("Cor")) |> List.length
    Assert.True(corCount >= 200, sprintf "Expected >= 200 Cor units, got %d" corCount)

[<Fact>]
let ``Legion faction has expected unit count`` () =
    let legCount = AllUnits.all |> List.filter (fun (_, sub, _) -> sub.StartsWith("Legion")) |> List.length
    Assert.True(legCount >= 220, sprintf "Expected >= 220 Legion units, got %d" legCount)

[<Fact>]
let ``Scavengers faction has expected unit count`` () =
    let scavCount = AllUnits.all |> List.filter (fun (_, sub, _) -> sub.StartsWith("Scav")) |> List.length
    Assert.True(scavCount >= 80, sprintf "Expected >= 80 Scavenger units, got %d" scavCount)

[<Fact>]
let ``ArmBots module all list is non-empty`` () =
    Assert.NotEmpty(ArmBots.all)

[<Fact>]
let ``CorBots module all list is non-empty`` () =
    Assert.NotEmpty(CorBots.all)

[<Fact>]
let ``Legion_Bots module all list is non-empty`` () =
    Assert.NotEmpty(Legion_Bots.all)

[<Fact>]
let ``Root module all list is non-empty`` () =
    Assert.NotEmpty(Root.all)

[<Fact>]
let ``AllUnits tryFind returns Some for known unit`` () =
    let result = AllUnits.tryFind "armham"
    Assert.True(result.IsSome, "armham should be findable")

[<Fact>]
let ``AllUnits tryFind returns None for unknown unit`` () =
    let result = AllUnits.tryFind "nonexistent_unit_xyz"
    Assert.True(result.IsNone)
