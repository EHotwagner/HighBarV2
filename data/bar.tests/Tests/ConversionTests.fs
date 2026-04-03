module BarData.Tests.ConversionTests

open Xunit
open BarData
open BarData.Units

let concrete (v: ValueOrExpr<float>) =
    match v with
    | ValueOrExpr.Concrete n -> n
    | ValueOrExpr.Expr s -> failwithf "Expected Concrete but got Expr: %s" s

// ===================================================================
// toFlat tests (US2)
// ===================================================================

[<Fact>]
let ``armck toFlat produces matching field values`` () =
    let flat = ArmBots.armckToFlat ArmBots.armckDef
    Assert.Equal(ArmBots.armck.name, flat.name)
    Assert.Equal(ArmBots.armck.metalCost, flat.metalCost)
    Assert.Equal(ArmBots.armck.health, flat.health)
    Assert.Equal(ArmBots.armck.speed, flat.speed)
    Assert.Equal(ArmBots.armck.workerTime, flat.workerTime)
    Assert.Equal(ArmBots.armck.buildDistance, flat.buildDistance)

[<Fact>]
let ``armham toFlat produces matching field values`` () =
    let flat = ArmBots.armhamToFlat ArmBots.armhamDef
    Assert.Equal(ArmBots.armham.name, flat.name)
    Assert.Equal(ArmBots.armham.metalCost, flat.metalCost)
    Assert.Equal(ArmBots.armham.health, flat.health)
    Assert.Equal(ArmBots.armham.speed, flat.speed)
    Assert.NotEmpty(flat.weapons)

[<Fact>]
let ``armsolar toFlat produces matching field values`` () =
    let flat = ArmBuildings_LandEconomy.armsolarToFlat ArmBuildings_LandEconomy.armsolarDef
    Assert.Equal(ArmBuildings_LandEconomy.armsolar.name, flat.name)
    Assert.Equal(ArmBuildings_LandEconomy.armsolar.metalCost, flat.metalCost)
    Assert.Equal(ArmBuildings_LandEconomy.armsolar.health, flat.health)
    Assert.Contains("ooooo", flat.yardMap)

[<Fact>]
let ``armcom toFlat produces matching field values`` () =
    let flat = Root.armcomToFlat Root.armcomDef
    Assert.Equal(Root.armcom.name, flat.name)
    Assert.Equal(Root.armcom.metalCost, flat.metalCost)
    Assert.Equal(Root.armcom.health, flat.health)

[<Fact>]
let ``corck toFlat produces matching field values`` () =
    let flat = CorBots.corckToFlat CorBots.corckDef
    Assert.Equal(CorBots.corck.name, flat.name)
    Assert.Equal(CorBots.corck.workerTime, flat.workerTime)

[<Fact>]
let ``legbal toFlat produces matching field values`` () =
    let flat = Legion_Bots.legbalToFlat Legion_Bots.legbalDef
    Assert.Equal(Legion_Bots.legbal.name, flat.name)
    Assert.Equal(Legion_Bots.legbal.speed, flat.speed)

// ===================================================================
// toUnitDef tests (US3)
// ===================================================================

[<Fact>]
let ``armham toUnitDef produces movement Some`` () =
    let def = ArmBots.armhamToUnitDef ArmBots.armham
    Assert.True(def.movement.IsSome)
    Assert.Equal(46.2, concrete def.movement.Value.speed)

[<Fact>]
let ``armck toUnitDef produces builder Some`` () =
    let def = ArmBots.armckToUnitDef ArmBots.armck
    Assert.True(def.builder.IsSome)
    Assert.Equal(80.0, concrete def.builder.Value.workerTime)

[<Fact>]
let ``armsolar toUnitDef produces building Some, no movement`` () =
    let def = ArmBuildings_LandEconomy.armsolarToUnitDef ArmBuildings_LandEconomy.armsolar
    Assert.True(def.building.IsSome)
    Assert.True(def.movement.IsNone)

[<Fact>]
let ``armcom toUnitDef produces movement + builder + weapons`` () =
    let def = Root.armcomToUnitDef Root.armcom
    Assert.True(def.movement.IsSome)
    Assert.True(def.builder.IsSome)
    Assert.True(def.weapons.IsSome)

// ===================================================================
// Round-trip tests (US3)
// ===================================================================

let assertVoEEqual (expected: ValueOrExpr<float>) (actual: ValueOrExpr<float>) (label: string) =
    match expected, actual with
    | ValueOrExpr.Concrete e, ValueOrExpr.Concrete a -> Assert.Equal(e, a)
    | ValueOrExpr.Expr e, ValueOrExpr.Expr a -> Assert.Equal(e, a)
    | _ -> Assert.Fail(sprintf "%s: expected %A, got %A" label expected actual)

/// toFlat(toUnitDef(flat)) should preserve key field values
let roundTripFlatViaUnitDef
    (name: string)
    (flat: 'T)
    (toUnitDef: 'T -> UnitDef)
    (toFlat: UnitDef -> 'T)
    (getMetalCost: 'T -> ValueOrExpr<float>)
    (getHealth: 'T -> ValueOrExpr<float>)
    (getName: 'T -> string) =
    let def = toUnitDef flat
    let roundTripped = toFlat def
    Assert.Equal(getName flat, getName roundTripped)
    assertVoEEqual (getMetalCost flat) (getMetalCost roundTripped) (sprintf "%s metalCost" name)
    assertVoEEqual (getHealth flat) (getHealth roundTripped) (sprintf "%s health" name)

/// toUnitDef(toFlat(def)) should preserve key UnitDef field values
let roundTripDefViaFlat
    (name: string)
    (def: UnitDef)
    (toFlat: UnitDef -> 'T)
    (toUnitDef: 'T -> UnitDef) =
    let flat = toFlat def
    let roundTripped = toUnitDef flat
    Assert.Equal(def.name, roundTripped.name)
    assertVoEEqual def.metalCost roundTripped.metalCost (sprintf "%s metalCost" name)
    assertVoEEqual def.health roundTripped.health (sprintf "%s health" name)
    Assert.Equal(def.movement.IsSome, roundTripped.movement.IsSome)
    Assert.Equal(def.builder.IsSome, roundTripped.builder.IsSome)
    Assert.Equal(def.weapons.IsSome, roundTripped.weapons.IsSome)
    Assert.Equal(def.economy.IsSome, roundTripped.economy.IsSome)
    Assert.Equal(def.building.IsSome, roundTripped.building.IsSome)

[<Fact>]
let ``round-trip armck flat -> UnitDef -> flat`` () =
    roundTripFlatViaUnitDef "armck" ArmBots.armck ArmBots.armckToUnitDef ArmBots.armckToFlat
        (fun t -> t.metalCost) (fun t -> t.health) (fun t -> t.name)

[<Fact>]
let ``round-trip armham flat -> UnitDef -> flat`` () =
    roundTripFlatViaUnitDef "armham" ArmBots.armham ArmBots.armhamToUnitDef ArmBots.armhamToFlat
        (fun t -> t.metalCost) (fun t -> t.health) (fun t -> t.name)

[<Fact>]
let ``round-trip armck UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armck" ArmBots.armckDef ArmBots.armckToFlat ArmBots.armckToUnitDef

[<Fact>]
let ``round-trip armham UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armham" ArmBots.armhamDef ArmBots.armhamToFlat ArmBots.armhamToUnitDef

[<Fact>]
let ``round-trip armcom UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armcom" Root.armcomDef Root.armcomToFlat Root.armcomToUnitDef

[<Fact>]
let ``round-trip armsolar UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armsolar" ArmBuildings_LandEconomy.armsolarDef ArmBuildings_LandEconomy.armsolarToFlat ArmBuildings_LandEconomy.armsolarToUnitDef

[<Fact>]
let ``round-trip corck UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "corck" CorBots.corckDef CorBots.corckToFlat CorBots.corckToUnitDef

[<Fact>]
let ``round-trip legbal UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "legbal" Legion_Bots.legbalDef Legion_Bots.legbalToFlat Legion_Bots.legbalToUnitDef

[<Fact>]
let ``round-trip armflea UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armflea" ArmBots.armfleaDef ArmBots.armfleaToFlat ArmBots.armfleaToUnitDef

[<Fact>]
let ``round-trip armadvsol UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armadvsol" ArmBuildings_LandEconomy.armadvsolDef ArmBuildings_LandEconomy.armadvsolToFlat ArmBuildings_LandEconomy.armadvsolToUnitDef

[<Fact>]
let ``round-trip armlab UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armlab" ArmBuildings_LandFactories.armlabDef ArmBuildings_LandFactories.armlabToFlat ArmBuildings_LandFactories.armlabToUnitDef

[<Fact>]
let ``round-trip corcom UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "corcom" Root.corcomDef Root.corcomToFlat Root.corcomToUnitDef

[<Fact>]
let ``round-trip corthud UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "corthud" CorBots.corthudDef CorBots.corthudToFlat CorBots.corthudToUnitDef

[<Fact>]
let ``round-trip legcomoff UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "legcomoff" Legion_Other_Commanders.legcomoffDef Legion_Other_Commanders.legcomoffToFlat Legion_Other_Commanders.legcomoffToUnitDef

[<Fact>]
let ``round-trip armfig (flying unit) UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armfig" ArmAircraft.armfigDef ArmAircraft.armfigToFlat ArmAircraft.armfigToUnitDef

[<Fact>]
let ``round-trip armsy (sea factory) UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armsy" ArmBuildings_SeaFactories.armsyDef ArmBuildings_SeaFactories.armsyToFlat ArmBuildings_SeaFactories.armsyToUnitDef

[<Fact>]
let ``round-trip armmex (extractor) UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armmex" ArmBuildings_LandEconomy.armmexDef ArmBuildings_LandEconomy.armmexToFlat ArmBuildings_LandEconomy.armmexToUnitDef

[<Fact>]
let ``round-trip armalab (adv lab) UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armalab" ArmBuildings_LandFactories.armalabDef ArmBuildings_LandFactories.armalabToFlat ArmBuildings_LandFactories.armalabToUnitDef

[<Fact>]
let ``round-trip armhlt (turret) UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armhlt" ArmBuildings_LandDefenceOffence.armhltDef ArmBuildings_LandDefenceOffence.armhltToFlat ArmBuildings_LandDefenceOffence.armhltToUnitDef

[<Fact>]
let ``round-trip armship (ship) UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armdecade" ArmShips.armdecadeDef ArmShips.armdecadeToFlat ArmShips.armdecadeToUnitDef

[<Fact>]
let ``round-trip armhover (hovercraft) UnitDef -> flat -> UnitDef`` () =
    roundTripDefViaFlat "armsh" ArmHovercraft.armshDef ArmHovercraft.armshToFlat ArmHovercraft.armshToUnitDef

// ===================================================================
// Full coverage validation (T029)
// ===================================================================

[<Fact>]
let ``AllUnitDefs and AllUnits have same count`` () =
    Assert.Equal(AllUnits.all.Length, AllUnitDefs.all.Length)

[<Fact>]
let ``AllUnitDefs and AllUnits have same names`` () =
    let unitNames = AllUnits.all |> List.map (fun u -> u.name) |> Set.ofList
    let defNames = AllUnitDefs.all |> List.map (fun (n, _, _) -> n) |> Set.ofList
    Assert.Equal(unitNames.Count, defNames.Count)
    let missing = Set.difference unitNames defNames
    Assert.True(missing.IsEmpty, sprintf "Units in AllUnits but not AllUnitDefs: %A" missing)

[<Fact>]
let ``all UnitDefs have valid basic fields`` () =
    for (name, sub, def) in AllUnitDefs.all do
        Assert.False(System.String.IsNullOrEmpty(name), "Empty name in AllUnitDefs")
        Assert.False(System.String.IsNullOrEmpty(sub), sprintf "Empty subfolder for %s" name)
        Assert.Equal(name, def.name)

// ===================================================================
// Universal optional fields validation (T030)
// ===================================================================

[<Fact>]
let ``armck flat has objectName populated`` () =
    Assert.True(ArmBots.armck.objectName.IsSome, "armck should have objectName")

[<Fact>]
let ``armck flat has buildPic populated`` () =
    Assert.True(ArmBots.armck.buildPic.IsSome, "armck should have buildPic")

[<Fact>]
let ``armck flat has script populated`` () =
    Assert.True(ArmBots.armck.script.IsSome, "armck should have script")

[<Fact>]
let ``armck flat has corpse populated`` () =
    Assert.True(ArmBots.armck.corpse.IsSome, "armck should have corpse")
