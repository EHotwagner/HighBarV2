module BarData.Tests.CorrectnessTests

open Xunit
open BarData
open BarData.Units

// Helper to extract concrete float values
let concrete (v: ValueOrExpr<float>) =
    match v with
    | ValueOrExpr.Concrete n -> n
    | ValueOrExpr.Expr s -> failwithf "Expected Concrete but got Expr: %s" s

// --- Arm units ---

[<Fact>]
let ``armham metalCost is 130`` () =
    Assert.Equal(130.0, concrete ArmBots.armham.metalCost)

[<Fact>]
let ``armham health is 1000`` () =
    Assert.Equal(1000.0, concrete ArmBots.armham.health)

[<Fact>]
let ``armham speed is 46.2 (direct, not option)`` () =
    Assert.Equal(46.2, concrete ArmBots.armham.speed)

[<Fact>]
let ``armham has weapons list`` () =
    Assert.NotEmpty(ArmBots.armham.weapons)

[<Fact>]
let ``armck workerTime is 80`` () =
    Assert.Equal(80.0, concrete ArmBots.armck.workerTime)

[<Fact>]
let ``armck buildDistance is 130 (direct, not option)`` () =
    Assert.Equal(130.0, ArmBots.armck.buildDistance)

[<Fact>]
let ``armck speed is 36`` () =
    Assert.Equal(36.0, concrete ArmBots.armck.speed)

[<Fact>]
let ``armck has non-empty buildOptions`` () =
    Assert.NotEmpty(ArmBots.armck.buildOptions)

[<Fact>]
let ``armflea speed is 132`` () =
    Assert.Equal(132.0, concrete ArmBots.armflea.speed)

[<Fact>]
let ``armflea health is 60`` () =
    Assert.Equal(60.0, concrete ArmBots.armflea.health)

[<Fact>]
let ``armflea metalCost is 21`` () =
    Assert.Equal(21.0, concrete ArmBots.armflea.metalCost)

[<Fact>]
let ``armsolar health is 340`` () =
    Assert.Equal(340.0, concrete ArmBuildings_LandEconomy.armsolar.health)

[<Fact>]
let ``armsolar metalCost is 155`` () =
    Assert.Equal(155.0, concrete ArmBuildings_LandEconomy.armsolar.metalCost)

[<Fact>]
let ``armsolar has yardMap (building, direct field)`` () =
    Assert.Contains("ooooo", ArmBuildings_LandEconomy.armsolar.yardMap)

[<Fact>]
let ``armadvsol health is 1130`` () =
    Assert.Equal(1130.0, concrete ArmBuildings_LandEconomy.armadvsol.health)

[<Fact>]
let ``armadvsol metalCost is 350`` () =
    Assert.Equal(350.0, concrete ArmBuildings_LandEconomy.armadvsol.metalCost)

// --- Cor units ---

[<Fact>]
let ``corck metalCost is 120`` () =
    Assert.Equal(120.0, concrete CorBots.corck.metalCost)

[<Fact>]
let ``corck health is 750`` () =
    Assert.Equal(750.0, concrete CorBots.corck.health)

[<Fact>]
let ``corck workerTime is 85 (direct)`` () =
    Assert.Equal(85.0, concrete CorBots.corck.workerTime)

[<Fact>]
let ``corck speed is 34.5 (direct)`` () =
    Assert.Equal(34.5, concrete CorBots.corck.speed)

// --- Legion units ---

[<Fact>]
let ``legbal metalCost is 160`` () =
    Assert.Equal(160.0, concrete Legion_Bots.legbal.metalCost)

[<Fact>]
let ``legbal health is 900`` () =
    Assert.Equal(900.0, concrete Legion_Bots.legbal.health)

[<Fact>]
let ``legbal speed is 43.5 (direct)`` () =
    Assert.Equal(43.5, concrete Legion_Bots.legbal.speed)

// --- Commanders ---

[<Fact>]
let ``armcom metalCost is 2700`` () =
    Assert.Equal(2700.0, concrete Root.armcom.metalCost)

[<Fact>]
let ``armcom health is 3700`` () =
    Assert.Equal(3700.0, concrete Root.armcom.health)
