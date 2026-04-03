// Auto-generated BAR unit data: Scavengers/Buildings/Economy (flat per-unit types)
namespace BarData.Units

open BarData

module Scavengers_Buildings_Economy =

    type Armafust3 =
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

    let armafust3 : Armafust3 =
        { name = "armafust3"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 90000.0
          energyCost = ValueOrExpr.Concrete 550000.0
          buildTime = ValueOrExpr.Concrete 2500000.0
          health = ValueOrExpr.Concrete 7900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          energyMake = ValueOrExpr.Concrete 30000.0
          energyStorage = 90000.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "192 192 192"
                  collisionVolumeType = Some "Box"
                  damage = Some 16290.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 4.0
                  height = Some 40.0
                  metal = Some 64410.0
                  object_ = Some "Units/armafust3_dead.s3o"
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
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 25760.0
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
                "buildinggrounddecalsizex", "18.0"
                "buildinggrounddecalsizey", "18.0"
                "buildinggrounddecaltype", "decals/armafus_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "techlevel", "3.0"
                "unitgroup", "energy"
                "restrictions_inclusion", "_nofusion_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "damagemodifier", "0.95"
            ] }

    type Armmmkrt3 =
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

    let armmmkrt3 : Armmmkrt3 =
        { name = "armmmkrt3"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 550000.0
          buildTime = ValueOrExpr.Concrete 350000.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 8.0
          footprintZ = 8.0
          yardMap = "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.574371337891 -22.1292811768 1.24842834473"
                  collisionVolumeScales = Some "120.6127624512 104.6148376465 120.6127624512"
                  collisionVolumeType = Some "Box"
                  damage = Some 240.0
                  featureDead = Some "HEAP"
                  footprintX = Some 8.0
                  footprintZ = Some 8.0
                  height = Some 20.0
                  metal = Some 233.0
                  object_ = Some "Units/armmmkrt3_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 120.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 93.0
                  object_ = Some "Units/arm4X4C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/armmmkr_aoplane.dds"
                "energyconv_capacity", "6000.0"
                "energyconv_efficiency", "0.02"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "techlevel", "3.0"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
            ] }

    type Armwint2 =
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

    let armwint2 : Armwint2 =
        { name = "armwint2"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 370.0
          energyCost = ValueOrExpr.Concrete 1750.0
          buildTime = ValueOrExpr.Concrete 16000.0
          health = ValueOrExpr.Concrete 1960.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          energyStorage = 5.0
          yardMap = "oooooo oooooo oooooo oooooo oooooo oooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 1 0"
                  collisionVolumeScales = Some "68 174 68"
                  collisionVolumeType = Some "CylY"
                  damage = Some 1125.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 40.0
                  metal = Some 222.0
                  object_ = Some "Units/scavbuildings/armwint2_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
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
                "buildinggrounddecaltype", "decals/armwint2_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "energy"
                "energymultiplier", "10.0"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandEconomy"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "windgenerator", "500.0"
            ] }

    type Corafust3 =
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

    let corafust3 : Corafust3 =
        { name = "corafust3"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 90000.0
          energyCost = ValueOrExpr.Concrete 550000.0
          buildTime = ValueOrExpr.Concrete 2500000.0
          health = ValueOrExpr.Concrete 9400.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          energyMake = ValueOrExpr.Concrete 30000.0
          energyStorage = 90000.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "188 192 188"
                  collisionVolumeType = Some "CylY"
                  damage = Some 17100.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 64400.0
                  object_ = Some "Units/corafust3_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 8550.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 2576.0
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
                select = ["fusion2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "18.0"
                "buildinggrounddecalsizey", "18.0"
                "buildinggrounddecaltype", "decals/corafus_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandEconomy"
                "techlevel", "3.0"
                "unitgroup", "energy"
                "restrictions_inclusion", "_nofusion_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "damagemodifier", "0.95"
            ] }

    type Cormmkrt3 =
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

    let cormmkrt3 : Cormmkrt3 =
        { name = "cormmkrt3"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 550000.0
          buildTime = ValueOrExpr.Concrete 350000.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 8.0
          footprintZ = 8.0
          yardMap = "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -2.96020507804e-05 0.388763427734"
                  collisionVolumeScales = Some "122.3712463379 106.8299407959 120.5937194824"
                  collisionVolumeType = Some "Box"
                  damage = Some 300.0
                  featureDead = Some "HEAP"
                  footprintX = Some 8.0
                  footprintZ = Some 8.0
                  height = Some 20.0
                  metal = Some 228.0
                  object_ = Some "Units/cormmkrt3_dead.s3o"
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
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/cormmkr_aoplane.dds"
                "energyconv_capacity", "6000.0"
                "energyconv_efficiency", "0.02"
                "flashlightmin", "0.8"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandEconomy"
                "techlevel", "3.0"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
            ] }

    type Corwint2 =
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

    let corwint2 : Corwint2 =
        { name = "corwint2"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 1750.0
          buildTime = ValueOrExpr.Concrete 17000.0
          health = ValueOrExpr.Concrete 1990.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          energyStorage = 5.0
          yardMap = "oooooo oooooo oooooo oooooo oooooo oooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 2 0"
                  collisionVolumeScales = Some "68 178 68"
                  collisionVolumeType = Some "CylY"
                  damage = Some 1125.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 270.0
                  object_ = Some "Units/scavbuildings/CORWINT2_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
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
                "buildinggrounddecaltype", "decals/corwint2_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "energy"
                "energymultiplier", "10.0"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandEconomy"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "windgenerator", "500.0"
            ] }

    type Legadveconvt3 =
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

    let legadveconvt3 : Legadveconvt3 =
        { name = "legadveconvt3"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 550000.0
          buildTime = ValueOrExpr.Concrete 350000.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 8.0
          footprintZ = 8.0
          yardMap = "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "142 60 122"
                  collisionVolumeType = Some "CylY"
                  damage = Some 300.0
                  featureDead = Some "HEAP"
                  footprintX = Some 8.0
                  footprintZ = Some 8.0
                  height = Some 20.0
                  metal = Some 228.0
                  object_ = Some "Units/legadveconvt3_dead.s3o"
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
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecaltype", "decals/cormmkr_aoplane.dds"
                "energyconv_capacity", "6000.0"
                "energyconv_efficiency", "0.02"
                "flashlightmin", "0.8"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "Legion/Economy"
                "techlevel", "3.0"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
            ] }

    type Legafust3 =
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

    let legafust3 : Legafust3 =
        { name = "legafust3"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 90000.0
          energyCost = ValueOrExpr.Concrete 550000.0
          buildTime = ValueOrExpr.Concrete 2500000.0
          health = ValueOrExpr.Concrete 7900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          energyMake = ValueOrExpr.Concrete 30000.0
          energyStorage = 90000.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "222 206 220"
                  collisionVolumeType = Some "Box"
                  damage = Some 16290.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 40.0
                  metal = Some 64410.0
                  object_ = Some "Units/legafust3_dead.s3o"
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
                "buildinggrounddecalsizex", "20.0"
                "buildinggrounddecalsizey", "20.0"
                "buildinggrounddecaltype", "decals/legafus_aoplane.dds"
                "model_author", "Protar/Ghoulish"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "Legion/Economy"
                "techlevel", "3.0"
                "unitgroup", "energy"
                "restrictions_inclusion", "_nofusion_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "damagemodifier", "0.95"
            ] }

    type Legwint2 =
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

    let legwint2 : Legwint2 =
        { name = "legwint2"
          subfolder = "Scavengers/Buildings/Economy"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 1750.0
          buildTime = ValueOrExpr.Concrete 17000.0
          health = ValueOrExpr.Concrete 1990.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          energyStorage = 5.0
          yardMap = "oooooo oooooo oooooo oooooo oooooo oooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 2 0"
                  collisionVolumeScales = Some "68 178 68"
                  collisionVolumeType = Some "CylY"
                  damage = Some 1125.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 270.0
                  object_ = Some "Units/scavbuildings/LEGWINT2_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
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
                "buildinggrounddecaltype", "decals/legwint2_aoplane.dds"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "energy"
                "energymultiplier", "10.0"
                "model_author", "Yzch"
                "normaltex", "unittextures/leg_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandEconomy"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "windgenerator", "500.0"
            ] }

