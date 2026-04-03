// Auto-generated BAR unit data: CorBuildings/SeaEconomy (flat per-unit types)
namespace BarData.Units

open BarData

module CorBuildings_SeaEconomy =

    type Corfmkr =
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

    let corfmkr : Corfmkr =
        { name = "corfmkr"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1250.0
          buildTime = ValueOrExpr.Concrete 2680.0
          health = ValueOrExpr.Concrete 167.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "wwwwwwwww"
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
                select = ["metlon2"] }
          customParams = Map.ofList [
                "energyconv_capacity", "70.0"
                "energyconv_efficiency", "0.01429"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaEconomy"
                "unitgroup", "metal"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
            ] }

    type Cortide =
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

    let cortide : Cortide =
        { name = "cortide"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 85.0
          energyCost = ValueOrExpr.Concrete 250.0
          buildTime = ValueOrExpr.Concrete 2100.0
          health = ValueOrExpr.Concrete 395.0
          sightDistance = ValueOrExpr.Concrete 130.0
          footprintX = 3.0
          footprintZ = 3.0
          energyStorage = 50.0
          yardMap = "wwwwwwwww"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0854949951172 0.00585021972656 -1.6875"
                  collisionVolumeScales = Some "43.4789733887 28.4617004395 39.825012207"
                  collisionVolumeType = Some "Box"
                  damage = Some 145.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 53.0
                  object_ = Some "Units/cortide_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 185.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 17.0
                  object_ = Some "Units/cor2X2D.s3o"
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
                select = ["tidegen2"] }
          customParams = Map.ofList [
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaEconomy"
                "unitgroup", "energy"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "onoffable", "false"
                "tidalgenerator", "1.0"
            ] }

    type Coruwadves =
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

    let coruwadves : Coruwadves =
        { name = "coruwadves"
          subfolder = "CorBuildings/SeaEconomy"
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
                  collisionVolumeOffsets = Some "-2.07458496094 4.21508789046e-05 -0.501388549805"
                  collisionVolumeScales = Some "87.0777893066 35.5382843018 90.1298522949"
                  collisionVolumeType = Some "Box"
                  damage = Some 4560.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 9.0
                  metal = Some 514.0
                  object_ = Some "Units/coruwadves_dead.s3o"
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
                "buildinggrounddecaltype", "decals/coruwadves_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaEconomy"
                "techlevel", "2.0"
                "unitgroup", "energy"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "7822.0"
            ] }

    type Coruwadvms =
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

    let coruwadvms : Coruwadvms =
        { name = "coruwadvms"
          subfolder = "CorBuildings/SeaEconomy"
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
                  object_ = Some "Units/coruwadvms_dead.s3o"
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/coruwadvms_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaEconomy"
                "techlevel", "2.0"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "6093.0"
            ] }

    type Coruwageo =
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

    let coruwageo : Coruwageo =
        { name = "coruwageo"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 48000.0
          health = ValueOrExpr.Concrete 0.0
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecaltype", "decals/corageo_aoplane.dds"
                "cvbuildable", "true"
                "geothermal", "1.0"
                "model_author", "Cremuss, Hornet"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaEconomy"
                "techlevel", "2.0"
                "unitgroup", "energy"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "acceleration", "0.0"
                "brakerate", "0.0"
                "buildangle", "0.0"
                "buildcostenergy", "27000.0"
                "buildcostmetal", "1500.0"
                "maxdamage", "4150.0"
            ] }

    type Coruwes =
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

    let coruwes : Coruwes =
        { name = "coruwes"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 1800.0
          buildTime = ValueOrExpr.Concrete 4260.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 4.0
          footprintZ = 4.0
          energyStorage = 6000.0
          yardMap = "oooooooooooooooo"
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "5.91815185547 -0.0585083374023 -0.949203491211"
                  collisionVolumeScales = Some "57.7583618164 50.6997833252 64.7775878906"
                  collisionVolumeType = Some "Box"
                  damage = Some 1825.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 182.0
                  object_ = Some "Units/coruwes_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 913.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 73.0
                  object_ = Some "Units/cor4X4D.s3o"
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
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/coruwes_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaEconomy"
                "unitgroup", "energy"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
            ] }

    type Coruwfus =
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

    let coruwfus : Coruwfus =
        { name = "coruwfus"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 5400.0
          energyCost = ValueOrExpr.Concrete 34000.0
          buildTime = ValueOrExpr.Concrete 105000.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 143.0
          footprintX = 5.0
          footprintZ = 5.0
          energyMake = ValueOrExpr.Concrete 1220.0
          energyStorage = 2500.0
          yardMap = "ooooooooooooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "1.8653717041 -0.0807505981445 0.994560241699"
                  collisionVolumeScales = Some "89.9762878418 27.3368988037 72.5986480713"
                  collisionVolumeType = Some "Box"
                  damage = Some 3210.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 3099.0
                  object_ = Some "Units/coruwfus_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 1605.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 1240.0
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
                select = ["watfusn2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecaltype", "decals/coruwfus_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaEconomy"
                "techlevel", "2.0"
                "unitgroup", "energy"
                "restrictions_inclusion", "_nofusion_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "hidedamage", "true"
            ] }

    type Coruwgeo =
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

    let coruwgeo : Coruwgeo =
        { name = "coruwgeo"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 12900.0
          health = ValueOrExpr.Concrete 0.0
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
                  object_ = Some "Units/corgeo_dead.s3o"
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/corgeo_aoplane.dds"
                "cvbuildable", "true"
                "geothermal", "1.0"
                "model_author", "Cremuss, Hornet"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaEconomy"
                "unitgroup", "energy"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "acceleration", "0.0"
                "brakerate", "0.0"
                "buildangle", "4096.0"
                "buildcostenergy", "13000.0"
                "buildcostmetal", "540.0"
                "maxdamage", "2050.0"
            ] }

    type Coruwmme =
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

    let coruwmme : Coruwmme =
        { name = "coruwmme"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 640.0
          energyCost = ValueOrExpr.Concrete 8100.0
          buildTime = ValueOrExpr.Concrete 14100.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 169.0
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
                  collisionVolumeOffsets = Some "0.0 -4.8856736084 -0.0"
                  collisionVolumeScales = Some "80.0 29.6428527832 80.0"
                  collisionVolumeType = Some "Box"
                  damage = Some 1243.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 150.0
                  metal = Some 550.0
                  object_ = Some "Units/coruwmme_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 622.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 5.0
                  metal = Some 220.0
                  object_ = Some "Units/cor5X5C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "waterex2"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["waterex2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "7.7"
                "buildinggrounddecalsizey", "7.7"
                "buildinggrounddecaltype", "decals/coruwmme_aoplane.dds"
                "cvbuildable", "true"
                "metal_extractor", "4.0"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaEconomy"
                "techlevel", "2.0"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "32768.0"
                "damagemodifier", "0.5"
                "energyupkeep", "20.0"
                "onoffable", "true"
            ] }

    type Coruwmmm =
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

    let coruwmmm : Coruwmmm =
        { name = "coruwmmm"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 370.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 31300.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 143.0
          footprintX = 5.0
          footprintZ = 5.0
          yardMap = "ooooooooooooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -2.2497558593e-05 -0.0"
                  collisionVolumeScales = Some "60.0 29.4457550049 60.0"
                  collisionVolumeType = Some "Box"
                  damage = Some 300.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 242.0
                  object_ = Some "Units/coruwmmm_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 150.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 97.0
                  object_ = Some "Units/cor5X5A.s3o"
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
                "energyconv_capacity", "600.0"
                "energyconv_efficiency", "0.01724"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaEconomy"
                "techlevel", "2.0"
                "unitgroup", "metal"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
            ] }

    type Coruwms =
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

    let coruwms : Coruwms =
        { name = "coruwms"
          subfolder = "CorBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 340.0
          energyCost = ValueOrExpr.Concrete 590.0
          buildTime = ValueOrExpr.Concrete 2920.0
          health = ValueOrExpr.Concrete 2100.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 4.0
          footprintZ = 4.0
          metalStorage = 3000.0
          yardMap = "oooooooooooooooo"
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 8.00781250021e-06 -0.0"
                  collisionVolumeScales = Some "80.0 48.7014160156 80.0"
                  collisionVolumeType = Some "Box"
                  damage = Some 2100.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 228.0
                  object_ = Some "Units/coruwms_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1050.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 91.0
                  object_ = Some "Units/cor4X4D.s3o"
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/coruwms_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaEconomy"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
            ] }

