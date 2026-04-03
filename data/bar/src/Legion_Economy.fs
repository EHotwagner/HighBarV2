// Auto-generated BAR unit data: Legion/Economy (flat per-unit types)
namespace BarData.Units

open BarData

module Legion_Economy =

    type Legadveconv =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legadveconv : Legadveconv =
        { name = "legadveconv"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 370.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 31300.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "oooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "71 30 61"
                  collisionVolumeType = Some "CylY"
                  damage = Some 300.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 228.0
                  object_ = Some "Units/legadveconv_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 150.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 91.0
                  object_ = Some "Units/cor4X4A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "metlrun2"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["metlon2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/legadveconv_aoplane.dds"
                "energyconv_capacity", "600.0"
                "energyconv_efficiency", "0.01724"
                "flashlightmin", "0.8"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "Legion/Economy"
                "techlevel", "2.0"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
            ] }

    type Legadvestore =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          energyStorage: float
          yardMap: string
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legadvestore : Legadvestore =
        { name = "legadvestore"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 840.0
          energyCost = ValueOrExpr.Concrete 11000.0
          buildTime = ValueOrExpr.Concrete 20400.0
          health = ValueOrExpr.Concrete 12700.0
          sightDistance = ValueOrExpr.Concrete 192.0
          footprintX = 5.0
          footprintZ = 5.0
          energyStorage = 40000.0
          yardMap = "ooooooooooooooooooooooooo"
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "83 55 74"
                  collisionVolumeType = Some "CylY"
                  damage = Some 4560.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 9.0
                  metal = Some 514.0
                  object_ = Some "Units/legadvestore_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 2280.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = None
                  metal = Some 206.0
                  object_ = Some "Units/cor5X5A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["storngy2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecaltype", "decals/legadvestore_aoplane.dds"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "Legion/Economy"
                "techlevel", "2.0"
                "unitgroup", "energy"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "7822.0"
            ] }

    type Legadvsol =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legadvsol : Legadvsol =
        { name = "legadvsol"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 465.0
          energyCost = ValueOrExpr.Concrete 4080.0
          buildTime = ValueOrExpr.Concrete 13580.0
          health = ValueOrExpr.Concrete 1100.0
          sightDistance = ValueOrExpr.Concrete 280.0
          footprintX = 5.0
          footprintZ = 5.0
          energyMake = ValueOrExpr.Concrete 100.0
          energyStorage = 150.0
          yardMap = "ooooo ooooo ooooo ooooo ooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -9 0"
                  collisionVolumeScales = Some "70 36 70"
                  collisionVolumeType = Some "Ell"
                  damage = Some 450.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 320.0
                  object_ = Some "Units/legadvsol_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 225.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 140.0
                  object_ = Some "Units/cor5X5C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["solar2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legadvsol_aoplane.dds"
                "buildinggrounddecalsizey", "7.0"
                "buildinggrounddecalsizex", "7.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "energy"
                "model_author", "EnderRobo"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "solar", "true"
                "subfolder", "Legion/economy"
            ]
          extras = Map.ofList [
                "buildangle", "33000.0"
            ] }

    type Legafus =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legafus : Legafus =
        { name = "legafus"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 10500.0
          energyCost = ValueOrExpr.Concrete 69000.0
          buildTime = ValueOrExpr.Concrete 340000.0
          health = ValueOrExpr.Concrete 9400.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          energyMake = ValueOrExpr.Concrete 3300.0
          energyStorage = 9000.0
          yardMap = "oooooooooooooooooooooooooooooooooooo"
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "111 103 110"
                  collisionVolumeType = Some "Box"
                  damage = Some 16290.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 40.0
                  metal = Some 6441.0
                  object_ = Some "Units/legafus_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "96.0 14.0 6.0"
                  collisionVolumeType = Some "box"
                  damage = Some 8145.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 2576.0
                  object_ = Some "Units/arm4X4A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["fusion1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "10.0"
                "buildinggrounddecalsizey", "10.0"
                "buildinggrounddecaltype", "decals/legafus_aoplane.dds"
                "model_author", "Protar/Ghoulish"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "Legion/Economy"
                "techlevel", "2.0"
                "unitgroup", "energy"
                "restrictions_inclusion", "_nofusion_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "damagemodifier", "0.95"
            ] }

    type Legageo =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legageo : Legageo =
        { name = "legageo"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 1600.0
          energyCost = ValueOrExpr.Concrete 27000.0
          buildTime = ValueOrExpr.Concrete 49950.0
          health = ValueOrExpr.Concrete 4150.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          energyMake = ValueOrExpr.Concrete 1250.0
          energyStorage = 12000.0
          yardMap = "h cbgybsyybc bsbssbbssb ysbsbssbbg ybsssbsssy sbsbsssbsb bsbsssbsbs ysssbsssby gbbssbsbsy bssbbssbsb cbyysbygbc"
          activateWhenBuilt = true
          canRepeat = false
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["geothrm2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legageo_aoplane.dds"
                "buildinggrounddecalsizey", "10.0"
                "buildinggrounddecalsizex", "10.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "energy"
                "cvbuildable", "true"
                "geothermal", "1.0"
                "model_author", "Tharsis"
                "normaltex", "unittextures/LEG_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandEconomy"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "0.0"
            ] }

    type Legamstor =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          metalStorage: float
          yardMap: string
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legamstor : Legamstor =
        { name = "legamstor"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 760.0
          energyCost = ValueOrExpr.Concrete 11000.0
          buildTime = ValueOrExpr.Concrete 20500.0
          health = ValueOrExpr.Concrete 11200.0
          sightDistance = ValueOrExpr.Concrete 182.0
          footprintX = 4.0
          footprintZ = 4.0
          metalStorage = 10000.0
          yardMap = "oooooooooooooooo"
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-8.0463180542 -4.28710937506e-05 2.1676940918"
                  collisionVolumeScales = Some "49.8645172119 42.9171142578 64.3353881836"
                  collisionVolumeType = Some "Box"
                  damage = Some 4020.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 9.0
                  metal = Some 462.0
                  object_ = Some "Units/legamstor_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 2010.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = None
                  metal = Some 185.0
                  object_ = Some "Units/cor4X4A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["stormtl2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legamstor_aoplane.dds"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "metal"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaEconomy"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "6093.0"
            ] }

    type Legeconv =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legeconv : Legeconv =
        { name = "legeconv"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1150.0
          buildTime = ValueOrExpr.Concrete 2600.0
          health = ValueOrExpr.Concrete 167.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "ooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          sounds =
              { build = None
                repair = None
                working = Some "arm-bld-metalmaker"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["metlon1"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legeconv_aoplane.dds"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "metal"
                "energyconv_capacity", "70.0"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
            ] }

    type Legestor =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legestor : Legestor =
        { name = "legestor"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 1800.0
          buildTime = ValueOrExpr.Concrete 4260.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          energyStorage = 6000.0
          yardMap = "oooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-1.1330871582 -3.52050781238e-05 -0.0"
                  collisionVolumeScales = Some "61.5478820801 36.5253295898 59.2817077637"
                  collisionVolumeType = Some "Box"
                  damage = Some 1080.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 108.0
                  object_ = Some "Units/legestor_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 540.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 43.0
                  object_ = Some "Units/cor4X4A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["storngy2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legestor_aoplane.dds"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "energy"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "Legion/economy"
            ]
          extras = Map.ofList [
                "buildangle", "8196.0"
            ] }

    type Legfus =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legfus : Legfus =
        { name = "legfus"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 4000.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 66000.0
          health = ValueOrExpr.Concrete 4600.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 5.0
          energyMake = ValueOrExpr.Concrete 950.0
          energyStorage = 2500.0
          yardMap = "oooooo oooooo oooooo oooooo oooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "101 67 69"
                  collisionVolumeType = Some "Box"
                  damage = Some 2700.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 5.0
                  height = Some 40.0
                  metal = Some 2603.0
                  object_ = Some "Units/legfus_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1350.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 1041.0
                  object_ = Some "Units/arm4X4A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["fusion1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "10.0"
                "buildinggrounddecalsizey", "10.0"
                "buildinggrounddecaltype", "decals/legfus_aoplane.dds"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "Legion/Economy"
                "techlevel", "2.0"
                "unitgroup", "energy"
                "restrictions_inclusion", "_nofusion_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "hidedamage", "true"
            ] }

    type Leggeo =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let leggeo : Leggeo =
        { name = "leggeo"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 560.0
          energyCost = ValueOrExpr.Concrete 13000.0
          buildTime = ValueOrExpr.Concrete 12900.0
          health = ValueOrExpr.Concrete 2050.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          energyMake = ValueOrExpr.Concrete 300.0
          energyStorage = 1000.0
          yardMap = "h cbbbbgbbbc bgbggbbggb bgbgbggbbb bbgggbgggb gbgbgggbgb bgbgggbgbg bgggbgggbb bbbggbgbgb bggbbggbgb cbbbgbbbbc"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "63 45 63"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1110.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 328.0
                  object_ = Some "Units/leggeo_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 555.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 131.0
                  object_ = Some "Units/cor4X4B.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["geothrm2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/leggeo_aoplane.dds"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "energy"
                "cvbuildable", "true"
                "geothermal", "1.0"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "Legion/Economy"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
            ] }

    type Legmex =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          metalStorage: float
          extractsMetal: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legmex : Legmex =
        { name = "legmex"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 50.0
          energyCost = ValueOrExpr.Concrete 500.0
          buildTime = ValueOrExpr.Concrete 1880.0
          health = ValueOrExpr.Concrete 275.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          metalStorage = 50.0
          extractsMetal = 0.0008
          yardMap = "h cbbbbbbc bsbssbsb bbobbobb bsbbbbsb bsbbbbsb bbobbobb bsbssbsb cbbbbbbc"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-3.07257080078 -0.112374182129 0.00819396972656"
                  collisionVolumeScales = Some "61.0307312012 23.0310516357 47.5323181152"
                  collisionVolumeType = Some "Box"
                  damage = Some 105.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 33.0
                  object_ = Some "Units/legmex_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 53.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 13.0
                  object_ = Some "Units/cor3X3E.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "mexworking"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["mexselect"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legmex_aoplane.dds"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "metal"
                "cvbuildable", "true"
                "metal_extractor", "1.0"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandEconomy"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "energyupkeep", "-7.0"
                "onoffable", "true"
                "selfdestructcountdown", "1.0"
            ] }

    type Legmext15 =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          metalStorage: float
          extractsMetal: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legmext15 : Legmext15 =
        { name = "legmext15"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 250.0
          energyCost = ValueOrExpr.Concrete 5000.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          metalStorage = 150.0
          extractsMetal = 0.002
          yardMap = "h cbbbbbbc bssssssb bssobssb bsbbbosb bsobbbsb bssbossb bssssssb cbbbbbbc"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-3.07257080078 -0.112374182129 0.00819396972656"
                  collisionVolumeScales = Some "61.0307312012 23.0310516357 47.5323181152"
                  collisionVolumeType = Some "Box"
                  damage = Some 105.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 150.0
                  object_ = Some "Units/LEGMEXT15_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 53.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 75.0
                  object_ = Some "Units/cor3X3E.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "mexworking"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["mexselect"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legmext15_aoplane.dds"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "metal"
                "cvbuildable", "true"
                "metal_extractor", "1.0"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandEconomy"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "energyupkeep", "30.0"
                "onoffable", "true"
                "selfdestructcountdown", "1.0"
            ] }

    type Legmoho =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          metalStorage: float
          extractsMetal: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legmoho : Legmoho =
        { name = "legmoho"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 640.0
          energyCost = ValueOrExpr.Concrete 8100.0
          buildTime = ValueOrExpr.Concrete 14100.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          metalStorage = 600.0
          extractsMetal = 0.004
          yardMap = "h cbbbbbbc bssssssb bsssossb bsobbssb bssbbosb bssosssb bssssssb cbbbbbbc"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 0.0263531005859 -0.0"
                  collisionVolumeScales = Some "85.8415527344 30.0151062012 74.3409423828"
                  collisionVolumeType = Some "Box"
                  damage = Some 2100.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 318.0
                  object_ = Some "Units/legmoho_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1050.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 137.0
                  object_ = Some "Units/cor5X5A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "mohorun2"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["twractv3"]
                select = ["mohoon2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legmoho_aoplane.dds"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "metal"
                "cvbuildable", "true"
                "metal_extractor", "4.0"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandEconomy"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "energyupkeep", "20.0"
                "onoffable", "true"
            ] }

    type Legmohobp =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          metalStorage: float
          extractsMetal: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legmohobp : Legmohobp =
        { name = "legmohobp"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 640.0
          energyCost = ValueOrExpr.Concrete 8100.0
          buildTime = ValueOrExpr.Concrete 14100.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          metalStorage = 600.0
          extractsMetal = 0.004
          yardMap = "h cbbbbbbc bssssssb bsssossb bsobbssb bssbbosb bssosssb bssssssb cbbbbbbc"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 0.0263531005859 -0.0"
                  collisionVolumeScales = Some "85.8415527344 30.0151062012 74.3409423828"
                  collisionVolumeType = Some "Box"
                  damage = Some 2100.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 318.0
                  object_ = Some "Units/legmoho_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1050.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 137.0
                  object_ = Some "Units/cor5X5A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "mohorun2"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["twractv3"]
                select = ["mohoon2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legmohobp_aoplane.dds"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "metal"
                "cvbuildable", "true"
                "metal_extractor", "4.0"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandEconomy"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "energyupkeep", "20.0"
                "onoffable", "true"
            ] }

    type Legmohobpct =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legmohobpct : Legmohobpct =
        { name = "legmohobpct"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 5125.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 3.0
          footprintZ = 3.0
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vcormove"]
                select = ["vcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "builder"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "paralyzemultiplier", "0.1"
                "subfolder", "CorBuildings/LandUtil"
            ]
          extras = Map.ofList [
                "damagemodifier", "0.0"
                "reclaimable", "false"
                "capturable", "false"
                "stealth", "true"
                "upright", "true"
            ] }

    type Legmohocon =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          metalStorage: float
          extractsMetal: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legmohocon : Legmohocon =
        { name = "legmohocon"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 1060.0
          energyCost = ValueOrExpr.Concrete 14500.0
          buildTime = ValueOrExpr.Concrete 19400.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          metalStorage = 600.0
          extractsMetal = 0.004
          yardMap = "h oooooooo osssssso osssssso ossoosso ossoosso osssssso osssssso oooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 0.0263531005859 -0.0"
                  collisionVolumeScales = Some "85.8415527344 30.0151062012 74.3409423828"
                  collisionVolumeType = Some "Box"
                  damage = Some 2100.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 318.0
                  object_ = Some "Units/legmohocon_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1050.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 137.0
                  object_ = Some "Units/cor5X5A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "mohorun2"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["twractv3"]
                select = ["mohoon2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legmohocon_aoplane.dds"
                "buildinggrounddecalsizey", "7.0"
                "buildinggrounddecalsizex", "7.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "metal"
                "cvbuildable", "true"
                "metal_extractor", "4.0"
                "model_author", "Tharsis and Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "scav_swap_override_created", "null"
                "scav_swap_override_captured", "null"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "energyupkeep", "20.0"
                "onoffable", "true"
            ] }

    type Legmohoconct =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legmohoconct : Legmohoconct =
        { name = "legmohoconct"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 1060.0
          energyCost = ValueOrExpr.Concrete 14500.0
          buildTime = ValueOrExpr.Concrete 19400.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 4.0
          footprintZ = 4.0
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vcormove"]
                select = ["vcorsel"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legmohocon_aoplane.dds"
                "buildinggrounddecalsizey", "7.0"
                "buildinggrounddecalsizex", "7.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "Tharsis and Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "scav_swap_override_created", "delete"
                "scav_swap_override_captured", "legmohocon"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "canassist", "true"
                "canfight", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canreclaim", "true"
                "canstop", "true"
                "cantbetransported", "true"
                "usePieceCollisionVolumes", "true"
                "mass", "700.0"
                "onoffable", "true"
                "upright", "true"
                "icontype", "legmohocon"
            ] }

    type Legmohoconin =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          metalStorage: float
          extractsMetal: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legmohoconin : Legmohoconin =
        { name = "legmohoconin"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 1060.0
          energyCost = ValueOrExpr.Concrete 14500.0
          buildTime = ValueOrExpr.Concrete 19400.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          metalStorage = 600.0
          extractsMetal = 0.004
          yardMap = "h oooooooo osssssso osssssso ossoosso ossoosso osssssso osssssso oooooooo"
          activateWhenBuilt = true
          canRepeat = false
          sounds =
              { build = None
                repair = None
                working = Some "mohorun2"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["twractv3"]
                select = ["mohoon2"] }
          customParams = Map.ofList [
                "unitgroup", "metal"
                "cvbuildable", "true"
                "metal_extractor", "4.0"
                "model_author", "Tharsis and Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "scav_swap_override_created", "delete"
                "scav_swap_override_captured", "delete"
                "subfolder", "CorBuildings/LandEconomy"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "energyupkeep", "20.0"
                "onoffable", "true"
                "icontype", "legmohocon"
            ] }

    type Legmstor =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          metalStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let legmstor : Legmstor =
        { name = "legmstor"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 340.0
          energyCost = ValueOrExpr.Concrete 590.0
          buildTime = ValueOrExpr.Concrete 2920.0
          health = ValueOrExpr.Concrete 2100.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          metalStorage = 3000.0
          yardMap = "oooo oooo oooo oooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "80 40 80"
                  collisionVolumeType = Some "Box"
                  damage = Some 1567.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 208.0
                  object_ = Some "Units/legmstor_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 784.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 83.0
                  object_ = Some "Units/cor5X5A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["stormtl2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legmstor_aoplane.dds"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "metal"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandEconomy"
            ] }

    type Legrampart =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legrampart : Legrampart =
        { name = "legrampart"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 2600.0
          energyCost = ValueOrExpr.Concrete 38000.0
          buildTime = ValueOrExpr.Concrete 36000.0
          health = ValueOrExpr.Concrete 8600.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 5.0
          footprintZ = 5.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 4.5
          turnRate = 1.0
          maxSlope = 20.0
          maxWaterDepth = 5.0
          canMove = true
          energyMake = ValueOrExpr.Concrete 600.0
          energyStorage = 4000.0
          yardMap = "h cbyybsygbc bsbssbbssb gsbsbssbby ybsssbsssy sbsbsssbsb bsbsssbsbs ysssbsssby ybbssbsbsg bssbbssbsb cbgysbyybc"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "fmd_rocket"
                  displayName = Some "ICBM intercepting missile launcher"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 1500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 72000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 6000.0
                  areaOfEffect = Some 420.0
                  accuracy = None
                  turret = None
                  tolerance = Some 7000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "antinukelaunch"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:antinuke"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "ALL"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "cegtag", "antimissiletrail"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "coverage", "1600.0"
                      "craterareaofeffect", "420.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "7500.0"
                      "firestarter", "100.0"
                      "flighttime", "20.0"
                      "interceptor", "1.0"
                      "metalpershot", "150.0"
                      "model", "leghomingmissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "10.0"
                      "smoketime", "110.0"
                      "smokesize", "27.0"
                      "smokecolor", "0.7"
                      "smokeTrailCastShadow", "true"
                      "soundhitwet", "splslrg"
                      "stockpile", "true"
                      "stockpiletime", "90.0"
                      "texture1", "bluenovaexplo"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "tracks", "true"
                      "turnrate", "10000.0"
                      "weaponacceleration", "150.0"
                      "weapontimer", "2.5"
                  ] }
                { name = "plasma"
                  displayName = Some "HeavyCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 360.0
                  areaOfEffect = Some 4.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some ""
                  soundHit = Some ""
                  explosiongenerator = Some ""
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "carried_unit", "legheavydrone"
                      "spawns_surface", "LAND"
                      "carrierdeaththroe", "release"
                      "dockingpieces", "10 11 12"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "size", "0.0"
                      "soundhitwet", ""
                  ] }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["geothrm2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legrampart_aoplane.dds"
                "buildinggrounddecalsizey", "10.0"
                "buildinggrounddecalsizex", "10.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "energy"
                "restrictions_exclusion", "_noantinuke_"
                "cvbuildable", "true"
                "geothermal", "1.0"
                "model_author", "Tharsis"
                "normaltex", "unittextures/LEG_normal.dds"
                "removewait", "true"
                "subfolder", "CorBuildings/LandEconomy"
                "techlevel", "2.0"
                "inheritxpratemultiplier", "1.0"
                "childreninheritxp", "DRONE"
                "parentsinheritxp", "DRONE"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "radardistancejam", "500.0"
                "radardistance", "2100.0"
                "radaremitheight", "72.0"
                "mass", "20000.0"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    type Legsolar =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legsolar : Legsolar =
        { name = "legsolar"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 155.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 2800.0
          health = ValueOrExpr.Concrete 340.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          energyStorage = 50.0
          yardMap = "yoooyoooooooooooooooyoooy"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -10 1"
                  collisionVolumeScales = Some "40 76 40"
                  collisionVolumeType = Some "Ell"
                  damage = Some 184.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 75.0
                  object_ = Some "Units/legsolar_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 92.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 30.0
                  object_ = Some "Units/arm5X5B.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["solar1"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legsolar_aoplane.dds"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "energy"
                "model_author", "Hornet"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "solar", "true"
                "subfolder", "Legion/economy"
            ]
          extras = Map.ofList [
                "buildangle", "4000.0"
                "damagemodifier", "0.5"
                "energyupkeep", "-20.0"
                "onoffable", "true"
            ] }

    type Legwin =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legwin : Legwin =
        { name = "legwin"
          subfolder = "Legion/Economy"
          metalCost = ValueOrExpr.Concrete 45.0
          energyCost = ValueOrExpr.Concrete 175.0
          buildTime = ValueOrExpr.Concrete 1680.0
          health = ValueOrExpr.Concrete 230.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          energyStorage = 0.5
          yardMap = "ooo ooo ooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "34 89 34"
                  collisionVolumeType = Some "cylY"
                  damage = Some 107.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 27.0
                  object_ = Some "Units/legwin_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 54.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 11.0
                  object_ = Some "Units/cor4X4A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["windgen"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legwin_aoplane.dds"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "energy"
                "model_author", "Yzch"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandEconomy"
            ]
          extras = Map.ofList [
                "windgenerator", "25.0"
            ] }

