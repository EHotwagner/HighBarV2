// Auto-generated BAR unit data: Scavengers/Buildings/Factories (flat per-unit types)
namespace BarData.Units

open BarData

module Scavengers_Buildings_Factories =

    type Armapt3 =
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
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          activateWhenBuilt: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armapt3 : Armapt3 =
        { name = "armapt3"
          subfolder = "Scavengers/Buildings/Factories"
          metalCost = ValueOrExpr.Concrete 8500.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 72400.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 292.0
          footprintX = 18.0
          footprintZ = 12.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = []
          terraformSpeed = 500.0
          energyStorage = 1000.0
          metalStorage = 1000.0
          yardMap = "oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo "
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "11 -17 -23"
                  collisionVolumeScales = Some "170 78 98"
                  collisionVolumeType = Some "Box"
                  damage = Some 11100.0
                  featureDead = Some "HEAP"
                  footprintX = Some 14.0
                  footprintZ = Some 12.0
                  height = Some 40.0
                  metal = Some 5530.0
                  object_ = Some "Units/scavbuildings/armapt3_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 5550.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 2210.0
                  object_ = Some "Units/arm6X6B.s3o"
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
                select = ["pairactv"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/armapt3_aoplane.dds"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecalsizex", "21.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert3"
                "restrictions_inclusion", "_noair_"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandFactories"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "radardistance", "500.0"
                "radaremitheight", "72.0"
            ] }

    type Corapt3 =
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
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corapt3 : Corapt3 =
        { name = "corapt3"
          subfolder = "Scavengers/Buildings/Factories"
          metalCost = ValueOrExpr.Concrete 8500.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 72400.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 16.0
          footprintZ = 12.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = []
          terraformSpeed = 500.0
          energyStorage = 1000.0
          metalStorage = 1000.0
          yardMap = "oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo "
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -14 -23"
                  collisionVolumeScales = Some "220 66 100"
                  collisionVolumeType = Some "Box"
                  damage = Some 11550.0
                  featureDead = Some "HEAP"
                  footprintX = Some 14.0
                  footprintZ = Some 12.0
                  height = Some 20.0
                  metal = Some 5400.0
                  object_ = Some "Units/scavbuildings/corapt3_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 578.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 2160.0
                  object_ = Some "Units/cor6X6B.s3o"
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
                select = ["pairactv"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/corapt3_aoplane.dds"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecalsizex", "19.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert3"
                "restrictions_inclusion", "_noair_"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "sightemitheight", "40.0"
                "radardistance", "510.0"
                "radaremitheight", "40.0"
            ] }

    type Legapt3 =
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
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legapt3 : Legapt3 =
        { name = "legapt3"
          subfolder = "Scavengers/Buildings/Factories"
          metalCost = ValueOrExpr.Concrete 8500.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 72400.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 16.0
          footprintZ = 12.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = []
          terraformSpeed = 500.0
          energyStorage = 1000.0
          metalStorage = 1000.0
          yardMap = "oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo "
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -14 -23"
                  collisionVolumeScales = Some "220 66 100"
                  collisionVolumeType = Some "Box"
                  damage = Some 11550.0
                  featureDead = Some "HEAP"
                  footprintX = Some 14.0
                  footprintZ = Some 12.0
                  height = Some 20.0
                  metal = Some 5400.0
                  object_ = Some "Units/scavbuildings/corapt3_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 578.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 2160.0
                  object_ = Some "Units/cor6X6B.s3o"
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
                select = ["pairactv"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/corapt3_aoplane.dds"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecalsizex", "19.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert3"
                "restrictions_inclusion", "_noair_"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "sightemitheight", "40.0"
                "radardistance", "510.0"
                "radaremitheight", "40.0"
            ] }

