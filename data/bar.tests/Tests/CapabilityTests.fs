module BarData.Tests.CapabilityTests

open Xunit
open BarData
open BarData.Units

// --- Builder bot (armck): builder=Some, weapons=None ---

[<Fact>]
let ``armck has builder capability`` () =
    Assert.True(ArmBots.armck.builder.IsSome, "armck should be a builder")

[<Fact>]
let ``armck has no weapons`` () =
    Assert.True(ArmBots.armck.weapons.IsNone, "armck should not have weapons")

[<Fact>]
let ``armck has movement`` () =
    Assert.True(ArmBots.armck.movement.IsSome, "armck should be mobile")

// --- Combat bot (armham): weapons=Some, builder=None ---

[<Fact>]
let ``armham has weapons`` () =
    Assert.True(ArmBots.armham.weapons.IsSome, "armham should have weapons")

[<Fact>]
let ``armham has no builder`` () =
    Assert.True(ArmBots.armham.builder.IsNone, "armham should not be a builder")

[<Fact>]
let ``armham has movement`` () =
    Assert.True(ArmBots.armham.movement.IsSome, "armham should be mobile")

// --- Commander (armcom): movement + builder + weapons ---

[<Fact>]
let ``armcom has movement`` () =
    Assert.True(Root.armcom.movement.IsSome, "commander should be mobile")

[<Fact>]
let ``armcom has builder`` () =
    Assert.True(Root.armcom.builder.IsSome, "commander should be a builder")

[<Fact>]
let ``armcom has weapons`` () =
    Assert.True(Root.armcom.weapons.IsSome, "commander should have weapons")

// --- Solar (armadvsol): economy + building, no movement ---

[<Fact>]
let ``armadvsol has economy`` () =
    Assert.True(ArmBuildings_LandEconomy.armadvsol.economy.IsSome, "solar should have economy")

[<Fact>]
let ``armadvsol has building`` () =
    Assert.True(ArmBuildings_LandEconomy.armadvsol.building.IsSome, "solar should be a building")

[<Fact>]
let ``armadvsol has no movement`` () =
    Assert.True(ArmBuildings_LandEconomy.armadvsol.movement.IsNone, "solar should not be mobile")

// --- Factory (armlab): building + builder ---

[<Fact>]
let ``armlab has building`` () =
    Assert.True(ArmBuildings_LandFactories.armlab.building.IsSome, "factory should be a building")

[<Fact>]
let ``armlab has builder`` () =
    Assert.True(ArmBuildings_LandFactories.armlab.builder.IsSome, "factory should be a builder")

[<Fact>]
let ``armlab builder has buildOptions`` () =
    let bo = ArmBuildings_LandFactories.armlab.builder.Value.buildOptions
    Assert.True(bo.Length > 0, "factory builder should have build options")
