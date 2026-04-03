module BarData.Tests.ComposableCapabilityTests

open Xunit
open BarData
open BarData.Units

// --- Builder bot (armck): builder=Some, weapons=None ---

[<Fact>]
let ``armckDef has builder capability`` () =
    Assert.True(ArmBots.armckDef.builder.IsSome, "armck should be a builder")

[<Fact>]
let ``armckDef has no weapons`` () =
    Assert.True(ArmBots.armckDef.weapons.IsNone, "armck should not have weapons")

[<Fact>]
let ``armckDef has movement`` () =
    Assert.True(ArmBots.armckDef.movement.IsSome, "armck should be mobile")

// --- Combat bot (armham): weapons=Some, builder=None ---

[<Fact>]
let ``armhamDef has weapons`` () =
    Assert.True(ArmBots.armhamDef.weapons.IsSome, "armham should have weapons")

[<Fact>]
let ``armhamDef has no builder`` () =
    Assert.True(ArmBots.armhamDef.builder.IsNone, "armham should not be a builder")

[<Fact>]
let ``armhamDef has movement`` () =
    Assert.True(ArmBots.armhamDef.movement.IsSome, "armham should be mobile")

// --- Commander (armcom): movement + builder + weapons ---

[<Fact>]
let ``armcomDef has movement`` () =
    Assert.True(Root.armcomDef.movement.IsSome, "commander should be mobile")

[<Fact>]
let ``armcomDef has builder`` () =
    Assert.True(Root.armcomDef.builder.IsSome, "commander should be a builder")

[<Fact>]
let ``armcomDef has weapons`` () =
    Assert.True(Root.armcomDef.weapons.IsSome, "commander should have weapons")

// --- Solar (armadvsol): economy + building, no movement ---

[<Fact>]
let ``armadvsolDef has economy`` () =
    Assert.True(ArmBuildings_LandEconomy.armadvsolDef.economy.IsSome, "solar should have economy")

[<Fact>]
let ``armadvsolDef has building`` () =
    Assert.True(ArmBuildings_LandEconomy.armadvsolDef.building.IsSome, "solar should be a building")

[<Fact>]
let ``armadvsolDef has no movement`` () =
    Assert.True(ArmBuildings_LandEconomy.armadvsolDef.movement.IsNone, "solar should not be mobile")

// --- Factory (armlab): building + builder ---

[<Fact>]
let ``armlabDef has building`` () =
    Assert.True(ArmBuildings_LandFactories.armlabDef.building.IsSome, "factory should be a building")

[<Fact>]
let ``armlabDef has builder`` () =
    Assert.True(ArmBuildings_LandFactories.armlabDef.builder.IsSome, "factory should be a builder")

[<Fact>]
let ``armlabDef builder has buildOptions`` () =
    let bo = ArmBuildings_LandFactories.armlabDef.builder.Value.buildOptions
    Assert.True(bo.Length > 0, "factory builder should have build options")

// --- AllUnitDefs index ---

[<Fact>]
let ``AllUnitDefs contains at least 950 entries`` () =
    Assert.True(AllUnitDefs.all.Length >= 950, sprintf "Expected >= 950, got %d" AllUnitDefs.all.Length)

[<Fact>]
let ``AllUnitDefs tryFind returns Some for armham`` () =
    let result = AllUnitDefs.tryFind "armham"
    Assert.True(result.IsSome, "armham should be findable")

[<Fact>]
let ``AllUnitDefs tryFind returns None for unknown`` () =
    Assert.True((AllUnitDefs.tryFind "nonexistent_unit_xyz").IsNone)
