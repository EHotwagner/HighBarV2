// Auto-generated BAR unit data: Legion/Constructors (flat per-unit types)
namespace BarData.Units

open BarData

module Legion_Constructors =

    type Legaca =
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
          canFly: bool
          canMove: bool
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legaca : Legaca =
        { name = "legaca"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 330.0
          energyCost = ValueOrExpr.Concrete 11000.0
          buildTime = ValueOrExpr.Concrete 17500.0
          health = ValueOrExpr.Concrete 195.0
          sightDistance = ValueOrExpr.Concrete 383.5
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 203.0
          maxAcc = 0.075
          maxDec = 0.4275
          turnRate = 240.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 70.0
          workerTime = ValueOrExpr.Concrete 115.0
          buildDistance = 136.0
          buildOptions = []
          terraformSpeed = 650.0
          energyMake = ValueOrExpr.Concrete 10.0
          energyStorage = 50.0
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolcrmv"]
                select = ["vtolcrac"] }
          customParams = Map.ofList [
                "unitgroup", "buildert2"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Constructors"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "true"
                "hoverattack", "true"
                "radardistance", "50.0"
            ] }

    type Legaceb =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legaceb : Legaceb =
        { name = "legaceb"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 310.0
          energyCost = ValueOrExpr.Concrete 5600.0
          buildTime = ValueOrExpr.Concrete 9500.0
          health = ValueOrExpr.Concrete 830.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 75.0
          maxAcc = 0.2
          maxDec = 1.45
          turnRate = 640.0
          movementClass = "TBOT3"
          maxSlope = 50.0
          maxWaterDepth = 22.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 2.0
          workerTime = ValueOrExpr.Concrete 125.0
          buildDistance = 136.0
          buildOptions = []
          terraformSpeed = 750.0
          energyMake = ValueOrExpr.Concrete 15.0
          energyStorage = 100.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "26 16 26"
                  collisionVolumeType = Some "Cyly"
                  damage = Some 600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 125.0
                  object_ = Some "Units/legaceb_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 50.0
                  object_ = Some "Units/cor2X2D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture2"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "buildert2"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/constructors"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "upright", "false"
            ] }

    type Legack =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legack : Legack =
        { name = "legack"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 410.0
          energyCost = ValueOrExpr.Concrete 6900.0
          buildTime = ValueOrExpr.Concrete 9300.0
          health = ValueOrExpr.Concrete 860.0
          sightDistance = ValueOrExpr.Concrete 318.5
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 36.0
          maxAcc = 0.4692
          maxDec = 2.9325
          turnRate = 1075.25
          movementClass = "BOT2"
          maxSlope = 20.0
          maxWaterDepth = 25.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.726
          workerTime = ValueOrExpr.Concrete 195.0
          buildDistance = 136.0
          buildOptions = []
          terraformSpeed = 900.0
          energyMake = ValueOrExpr.Concrete 14.0
          energyStorage = 100.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -1.31450195313e-05 -8.2949829102"
                  collisionVolumeScales = Some "25.0 26.11277771 27.3265991211"
                  collisionVolumeType = Some "Box"
                  damage = Some 800.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 207.0
                  object_ = Some "Units/legack_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 600.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 83.0
                  object_ = Some "Units/cor2X2B.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture2"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "buildert2"
                "area_mex_def", "legmoho"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
                "upright", "false"
            ] }

    type Legacv =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legacv : Legacv =
        { name = "legacv"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 530.0
          energyCost = ValueOrExpr.Concrete 6600.0
          buildTime = ValueOrExpr.Concrete 11900.0
          health = ValueOrExpr.Concrete 1950.0
          sightDistance = ValueOrExpr.Concrete 295.10001
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 55.5
          maxAcc = 0.02547
          maxDec = 0.05093
          turnRate = 363.0
          movementClass = "TANK3"
          maxSlope = 16.0
          maxWaterDepth = 18.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.1616
          workerTime = ValueOrExpr.Concrete 270.0
          buildDistance = 136.0
          buildOptions = []
          terraformSpeed = 1250.0
          energyMake = ValueOrExpr.Concrete 20.0
          energyStorage = 100.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "36 22 55"
                  collisionVolumeType = Some "Box"
                  damage = Some 1500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 294.0
                  object_ = Some "Units/legacv_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1000.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 118.0
                  object_ = Some "Units/cor3X3A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
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
                "unitgroup", "buildert2"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Constructors"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "radardistance", "50.0"
                "trackstrength", "6.0"
                "tracktype", "corwidetracks"
                "trackwidth", "28.0"
            ] }

    type Legafcv =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legafcv : Legafcv =
        { name = "legafcv"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 2900.0
          buildTime = ValueOrExpr.Concrete 4000.0
          health = ValueOrExpr.Concrete 450.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 110.0
          maxAcc = 0.07029
          maxDec = 0.14059
          turnRate = 635.0
          movementClass = "TANK2"
          maxSlope = 18.0
          maxWaterDepth = 18.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.83678
          workerTime = ValueOrExpr.Concrete 120.0
          buildDistance = 110.0
          buildOptions = []
          terraformSpeed = 750.0
          energyMake = ValueOrExpr.Concrete 10.0
          energyStorage = 50.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "20 17 30"
                  collisionVolumeType = Some "Box"
                  damage = Some 800.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 80.0
                  object_ = Some "Units/legafcv_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 700.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 45.0
                  object_ = Some "Units/arm3X3A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["tarmmove"]
                select = ["tarmsel"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Constructors"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "trackoffset", "10.0"
                "trackstrength", "5.0"
                "tracktype", "armgremlin_tracks"
                "trackwidth", "35.0"
            ] }

    type Leganavyconsub =
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
          movementClass: string
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let leganavyconsub : Leganavyconsub =
        { name = "leganavyconsub"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 700.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 18000.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 156.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 64.8
          maxAcc = 0.042
          maxDec = 0.042
          turnRate = 385.5
          movementClass = "UBOAT4"
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 20.0
          waterline = 80.0
          workerTime = ValueOrExpr.Concrete 345.0
          buildDistance = 180.0
          buildOptions = []
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 30.0
          energyStorage = 150.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "30 30 71"
                  collisionVolumeType = Some "Box"
                  damage = Some 444.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 350.0
                  object_ = Some "Units/leganavyconsub_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1432.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 175.0
                  object_ = Some "Units/cor4X4C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sucormov"]
                select = ["sucorsel"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Constructors"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
            ] }

    type Leganavyengineer =
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
          movementClass: string
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let leganavyengineer : Leganavyengineer =
        { name = "leganavyengineer"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 3300.0
          buildTime = ValueOrExpr.Concrete 4800.0
          health = ValueOrExpr.Concrete 1600.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 57.75
          maxAcc = 0.03446
          maxDec = 0.03446
          turnRate = 393.0
          movementClass = "BOAT3"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 0.0
          workerTime = ValueOrExpr.Concrete 200.0
          buildDistance = 250.0
          buildOptions = []
          terraformSpeed = 2000.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "30 25 49"
                  collisionVolumeType = Some "Box"
                  damage = Some 1726.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 100.0
                  object_ = Some "Units/leganavyengineer_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 50.0
                  object_ = Some "Units/cor4X4A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["shcormov"]
                select = ["shcorsel"] }
          customParams = Map.ofList [
                "minesweeper", "600.0"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Constructors"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "movestate", "0.0"
            ] }

    type Legca =
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
          canFly: bool
          canMove: bool
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legca : Legca =
        { name = "legca"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 105.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 7560.0
          health = ValueOrExpr.Concrete 151.0
          sightDistance = ValueOrExpr.Concrete 351.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 215.0
          maxAcc = 0.07
          maxDec = 0.4275
          turnRate = 240.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 75.0
          workerTime = ValueOrExpr.Concrete 55.0
          buildDistance = 136.0
          buildOptions = []
          terraformSpeed = 225.0
          energyMake = ValueOrExpr.Concrete 5.0
          energyStorage = 25.0
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolcrmv"]
                select = ["vtolcrac"] }
          customParams = Map.ofList [
                "unitgroup", "builder"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "CorAircraft"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "true"
                "hoverattack", "true"
                "radardistance", "50.0"
            ] }

    type Legch =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legch : Legch =
        { name = "legch"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 185.0
          energyCost = ValueOrExpr.Concrete 2600.0
          buildTime = ValueOrExpr.Concrete 4360.0
          health = ValueOrExpr.Concrete 1390.0
          sightDistance = ValueOrExpr.Concrete 338.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 72.9
          maxAcc = 0.049
          maxDec = 0.11
          turnRate = 410.0
          movementClass = "HOVER3"
          maxSlope = 16.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.518
          workerTime = ValueOrExpr.Concrete 105.0
          buildDistance = 150.0
          buildOptions = ["legsolar"; "legadvsol"; "legwin"; "leggeo"; "legmstor"; "legestor"; "legmex"; "legmext15"; "legeconv"; "leglab"; "legvp"; "legap"; "leghp"; "legavp"; "legnanotc"; "legnanotcplat"; "legeyes"; "legrad"; "legdrag"; "legdtr"; "leglht"; "legmg"; "legcluster"; "legrl"; "legrhapsis"; "leglupara"; "legjuno"; "legctl"; "legjam"; "legfhp"; "legamphlab"; "legsplab"; "legsy"; "legtide"; "legfeconv"; "leguwmstore"; "leguwestore"; "legfdrag"; "legfrad"; "legfmg"; "legfrl"; "legtl"; "leguwgeo"; "legadvshipyard"; "leghive"; "legfhive"]
          terraformSpeed = 550.0
          energyMake = ValueOrExpr.Concrete 11.0
          energyStorage = 75.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "27 18 38"
                  collisionVolumeType = Some "Box"
                  damage = Some 805.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 100.0
                  object_ = Some "Units/legch_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 403.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 40.0
                  object_ = Some "Units/cor3X3D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["hovmdok2"]
                select = ["hovmdsl2"] }
          customParams = Map.ofList [
                "unitgroup", "builder"
                "model_author", "EnderRobo"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "CorHovercraft"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
            ] }

    type Legck =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legck : Legck =
        { name = "legck"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 100.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 3250.0
          health = ValueOrExpr.Concrete 630.0
          sightDistance = ValueOrExpr.Concrete 299.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 39.0
          maxAcc = 0.58
          maxDec = 3.6
          turnRate = 1300.0
          movementClass = "BOT2"
          maxSlope = 20.0
          maxWaterDepth = 25.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.759
          workerTime = ValueOrExpr.Concrete 75.0
          buildDistance = 130.0
          buildOptions = []
          terraformSpeed = 450.0
          energyMake = ValueOrExpr.Concrete 5.0
          energyStorage = 50.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.363754272461 2.60498046867e-05 -3.5"
                  collisionVolumeScales = Some "20 26 26"
                  collisionVolumeType = Some "Box"
                  damage = Some 454.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 73.0
                  object_ = Some "Units/legck_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 277.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 29.0
                  object_ = Some "Units/cor2X2F.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture2"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "builder"
                "area_mexT15_def", "legmext15"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "CorBots"
            ]
          extras = Map.ofList [
                "upright", "false"
            ] }

    type Legcv =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legcv : Legcv =
        { name = "legcv"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 2100.0
          buildTime = ValueOrExpr.Concrete 3900.0
          health = ValueOrExpr.Concrete 1330.0
          sightDistance = ValueOrExpr.Concrete 260.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 57.0
          maxAcc = 0.036
          maxDec = 0.14
          turnRate = 445.0
          movementClass = "TANK3"
          maxSlope = 16.0
          maxWaterDepth = 19.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.1979
          workerTime = ValueOrExpr.Concrete 85.0
          buildDistance = 130.0
          buildOptions = []
          terraformSpeed = 450.0
          energyMake = ValueOrExpr.Concrete 7.0
          energyStorage = 50.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.31364440918 1.09863281317e-06 0.657264709473"
                  collisionVolumeScales = Some "32.9147644043 17.5585021973 49.4168548584"
                  collisionVolumeType = Some "Box"
                  damage = Some 874.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 87.0
                  object_ = Some "Units/legcv_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 487.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 35.0
                  object_ = Some "Units/cor3X3D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
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
                "unitgroup", "builder"
                "area_mexT15_def", "legmext15"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "CorVehicles"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "radardistance", "50.0"
                "trackoffset", "3.0"
                "trackstrength", "6.0"
                "tracktype", "corwidetracks"
                "trackwidth", "32.0"
            ] }

    type Leghack =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let leghack : Leghack =
        { name = "leghack"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 1240.0
          energyCost = ValueOrExpr.Concrete 22400.0
          buildTime = ValueOrExpr.Concrete 38000.0
          health = ValueOrExpr.Concrete 830.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 75.0
          maxAcc = 0.2
          maxDec = 1.45
          turnRate = 640.0
          movementClass = "TBOT3"
          maxSlope = 50.0
          maxWaterDepth = 22.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 2.0
          workerTime = ValueOrExpr.Concrete 600.0
          buildDistance = 136.0
          buildOptions = ["legafus"; "leggant"; "legageo"; "legrampart"; "legmoho"; "legadveconv"; "legadvestore"; "legamstor"; "legforti"; "legtarg"; "legdeflector"; "legacluster"; "legapopupdef"; "legbastion"; "legflak"; "leglraa"; "legperdition"; "legabm"; "legsilo"; "leglrpc"; "legstarfall"; "legalab"; "leghalab"; "legvp"; "legap"; "legsy"; "legnanotc"; "legfus"; "legsd"; "leglab"; "legeheatraymech"; "legelrpcmech"]
          terraformSpeed = 750.0
          energyMake = ValueOrExpr.Concrete 15.0
          energyStorage = 100.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "26 16 26"
                  collisionVolumeType = Some "Cyly"
                  damage = Some 600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 125.0
                  object_ = Some "Units/legaceb_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 50.0
                  object_ = Some "Units/cor2X2D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture2"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "unitgroup", "buildert2"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/constructors"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "upright", "false"
            ] }

    type Leghacv =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let leghacv : Leghacv =
        { name = "leghacv"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 800.0
          energyCost = ValueOrExpr.Concrete 9400.0
          buildTime = ValueOrExpr.Concrete 16800.0
          health = ValueOrExpr.Concrete 450.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 110.0
          maxAcc = 0.07029
          maxDec = 0.14059
          turnRate = 635.0
          movementClass = "TANK2"
          maxSlope = 18.0
          maxWaterDepth = 18.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.83678
          workerTime = ValueOrExpr.Concrete 400.0
          buildDistance = 110.0
          buildOptions = ["legafus"; "leggant"; "legageo"; "legrampart"; "legmoho"; "legadveconv"; "legadvestore"; "legamstor"; "legforti"; "legtarg"; "legdeflector"; "legacluster"; "legapopupdef"; "legbastion"; "legflak"; "leglraa"; "legperdition"; "legabm"; "legsilo"; "leglrpc"; "legstarfall"; "legavp"; "leghavp"; "legvp"; "legap"; "legsy"; "legnanotc"; "legfus"; "legsd"; "leglab"; "legeheatraymech"; "legelrpcmech"]
          terraformSpeed = 750.0
          energyMake = ValueOrExpr.Concrete 10.0
          energyStorage = 50.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "20 17 30"
                  collisionVolumeType = Some "Box"
                  damage = Some 800.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 80.0
                  object_ = Some "Units/legafcv_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 700.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 45.0
                  object_ = Some "Units/arm3X3A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["tarmmove"]
                select = ["tarmsel"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Constructors"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "trackoffset", "10.0"
                "trackstrength", "5.0"
                "tracktype", "armgremlin_tracks"
                "trackwidth", "35.0"
            ] }

    type Legnavyconship =
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
          movementClass: string
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let legnavyconship : Legnavyconship =
        { name = "legnavyconship"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 180.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 3500.0
          health = ValueOrExpr.Concrete 1080.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 71.0
          maxAcc = 0.03567
          maxDec = 0.03567
          turnRate = 391.5
          movementClass = "BOAT3"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 0.0
          workerTime = ValueOrExpr.Concrete 115.0
          buildDistance = 200.0
          buildOptions = []
          terraformSpeed = 1250.0
          energyMake = ValueOrExpr.Concrete 5.0
          energyStorage = 50.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "42 30 50"
                  collisionVolumeType = Some "Box"
                  damage = Some 1380.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 100.0
                  object_ = Some "Units/legnavyconship_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 50.0
                  object_ = Some "Units/cor5X5C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["shcormov"]
                select = ["shcorsel"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies (Model), Phill-Arts (Concept Art)"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Constructors"
                "unitgroup", "builder"
            ] }

    type Legotter =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legotter : Legotter =
        { name = "legotter"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 150.0
          energyCost = ValueOrExpr.Concrete 3100.0
          buildTime = ValueOrExpr.Concrete 6540.0
          health = ValueOrExpr.Concrete 950.0
          sightDistance = ValueOrExpr.Concrete 260.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 43.5
          maxAcc = 0.01722
          maxDec = 0.10332
          turnRate = 300.0
          movementClass = "ATANK3"
          maxSlope = 16.0
          maxWaterDepth = 255.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.9504
          workerTime = ValueOrExpr.Concrete 75.0
          buildDistance = 110.0
          buildOptions = []
          terraformSpeed = 400.0
          energyMake = ValueOrExpr.Concrete 8.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-1.3500289917 4.80712890649e-06 3.49253082275"
                  collisionVolumeScales = Some "25.27003479 12.0197296143 44.3021697998"
                  collisionVolumeType = Some "Box"
                  damage = Some 697.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 105.0
                  object_ = Some "Units/legotter_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 299.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 42.0
                  object_ = Some "Units/cor3X3C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
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
                "unitgroup", "builder"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "CorVehicles"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "trackoffset", "8.0"
                "trackstrength", "5.0"
                "tracktype", "corwidetracks"
                "trackwidth", "24.0"
            ] }

    type Legspcon =
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
          canFly: bool
          canMove: bool
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legspcon : Legspcon =
        { name = "legspcon"
          subfolder = "Legion/Constructors"
          metalCost = ValueOrExpr.Concrete 150.0
          energyCost = ValueOrExpr.Concrete 7800.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 405.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 192.0
          maxAcc = 0.07
          maxDec = 0.4275
          turnRate = 240.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 50.0
          workerTime = ValueOrExpr.Concrete 75.0
          buildDistance = 136.0
          buildOptions = []
          terraformSpeed = 300.0
          energyMake = ValueOrExpr.Concrete 20.0
          energyStorage = 75.0
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolcrmv"]
                select = ["seapsel1"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Constructors"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "true"
                "hoverattack", "true"
            ] }

