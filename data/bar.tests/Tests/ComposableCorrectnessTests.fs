module BarData.Tests.ComposableCorrectnessTests

open Xunit
open BarData
open BarData.Units

let concrete (v: ValueOrExpr<float>) =
    match v with
    | ValueOrExpr.Concrete n -> n
    | ValueOrExpr.Expr s -> failwithf "Expected Concrete but got Expr: %s" s

// --- Arm units ---

[<Fact>]
let ``armhamDef metalCost is 130`` () =
    Assert.Equal(130.0, concrete ArmBots.armhamDef.metalCost)

[<Fact>]
let ``armhamDef health is 1000`` () =
    Assert.Equal(1000.0, concrete ArmBots.armhamDef.health)

[<Fact>]
let ``armhamDef speed is 46.2`` () =
    Assert.Equal(46.2, concrete ArmBots.armhamDef.movement.Value.speed)

[<Fact>]
let ``armckDef workerTime is 80`` () =
    Assert.Equal(80.0, concrete ArmBots.armckDef.builder.Value.workerTime)

[<Fact>]
let ``armckDef buildDistance is 130`` () =
    Assert.Equal(130.0, ArmBots.armckDef.builder.Value.buildDistance.Value)

[<Fact>]
let ``armfleaDef speed is 132`` () =
    Assert.Equal(132.0, concrete ArmBots.armfleaDef.movement.Value.speed)

[<Fact>]
let ``armfleaDef health is 60`` () =
    Assert.Equal(60.0, concrete ArmBots.armfleaDef.health)

[<Fact>]
let ``armfleaDef metalCost is 21`` () =
    Assert.Equal(21.0, concrete ArmBots.armfleaDef.metalCost)

[<Fact>]
let ``armadvsolDef energyMake is 80`` () =
    Assert.Equal(80.0, concrete ArmBuildings_LandEconomy.armadvsolDef.economy.Value.energyMake.Value)

[<Fact>]
let ``armadvsolDef health is 1130`` () =
    Assert.Equal(1130.0, concrete ArmBuildings_LandEconomy.armadvsolDef.health)

[<Fact>]
let ``armadvsolDef metalCost is 350`` () =
    Assert.Equal(350.0, concrete ArmBuildings_LandEconomy.armadvsolDef.metalCost)

// --- Cor units ---

[<Fact>]
let ``corckDef metalCost is 120`` () =
    Assert.Equal(120.0, concrete CorBots.corckDef.metalCost)

[<Fact>]
let ``corckDef health is 750`` () =
    Assert.Equal(750.0, concrete CorBots.corckDef.health)

[<Fact>]
let ``corckDef workerTime is 85`` () =
    Assert.Equal(85.0, concrete CorBots.corckDef.builder.Value.workerTime)

[<Fact>]
let ``corckDef speed is 34.5`` () =
    Assert.Equal(34.5, concrete CorBots.corckDef.movement.Value.speed)

// --- Legion units ---

[<Fact>]
let ``legbalDef metalCost is 160`` () =
    Assert.Equal(160.0, concrete Legion_Bots.legbalDef.metalCost)

[<Fact>]
let ``legbalDef health is 900`` () =
    Assert.Equal(900.0, concrete Legion_Bots.legbalDef.health)

[<Fact>]
let ``legbalDef speed is 43.5`` () =
    Assert.Equal(43.5, concrete Legion_Bots.legbalDef.movement.Value.speed)

// --- Arm commander ---

[<Fact>]
let ``armcomDef metalCost is 2700`` () =
    Assert.Equal(2700.0, concrete Root.armcomDef.metalCost)

[<Fact>]
let ``armcomDef health is 3700`` () =
    Assert.Equal(3700.0, concrete Root.armcomDef.health)
