// Auto-generated BAR unit data: CorShips (flat per-unit types)
namespace BarData.Units

open BarData

module CorShips =

    type Corcs =
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

    let corcs : Corcs =
        { name = "corcs"
          subfolder = "CorShips"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 3700.0
          health = ValueOrExpr.Concrete 1080.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 60.0
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
          workerTime = ValueOrExpr.Concrete 125.0
          buildDistance = 200.0
          buildOptions = ["cormex"; "corvp"; "corap"; "corlab"; "coreyes"; "cordl"; "cordrag"; "cormaw"; "corpun"; "cortide"; "corgeo"; "coruwgeo"; "corfmkr"; "coruwms"; "coruwes"; "corsy"; "corasy"; "cornanotcplat"; "corfhp"; "coramsub"; "corplat"; "corfrad"; "corfdrag"; "cortl"; "corfrt"; "corfhlt"]
          terraformSpeed = 1250.0
          energyMake = ValueOrExpr.Concrete 7.0
          energyStorage = 50.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 0.0 0.0374984741211"
                  collisionVolumeScales = Some "45.9999694824 17.25 80.0749969482"
                  collisionVolumeType = Some "Box"
                  damage = Some 1380.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 100.0
                  object_ = Some "Units/corcs_dead.s3o"
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
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips"
                "unitgroup", "builder"
            ] }

    type Coresupp =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let coresupp : Coresupp =
        { name = "coresupp"
          subfolder = "CorShips"
          metalCost = ValueOrExpr.Concrete 100.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 1400.0
          health = ValueOrExpr.Concrete 480.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 109.8
          maxAcc = 0.11054
          maxDec = 0.11054
          turnRate = 500.0
          movementClass = "BOAT3"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 4.0
          waterline = 0.7
          weapons = [
                { name = "laser"
                  displayName = Some "LightLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 41.0
                      "vtol", 6.0
                  ]
                  range = Some (ValueOrExpr.Concrete 280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.93)
                  weaponVelocity = Some 2250.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "285.0"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "30.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.0"
                      "minintensity", "0.6"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "1.7"
                  ] }
                { name = "laser"
                  displayName = Some "LightLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 41.0
                      "vtol", 6.0
                  ]
                  range = Some (ValueOrExpr.Concrete 280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.93)
                  weaponVelocity = Some 2250.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 -1"
                      "mount_maxangledif", "285.0"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "30.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.0"
                      "minintensity", "0.6"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "1.7"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "2.05702972412 -6.65740128174 -1.55792999268"
                  collisionVolumeScales = Some "20 16 40"
                  collisionVolumeType = Some "Box"
                  damage = Some 300.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 15.0
                  metal = Some 50.0
                  object_ = Some "Units/coresupp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 25.0
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["shcormov"]
                select = ["shcorsel"] }
          customParams = Map.ofList [
                "model_author", "Flaka"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "nochasecategory", "UNDERWATER VTOL"
            ] }

    type Corpship =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corpship : Corpship =
        { name = "corpship"
          subfolder = "CorShips"
          metalCost = ValueOrExpr.Concrete 420.0
          energyCost = ValueOrExpr.Concrete 2800.0
          buildTime = ValueOrExpr.Concrete 4550.0
          health = ValueOrExpr.Concrete 2350.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 82.5
          maxAcc = 0.04391
          maxDec = 0.04391
          turnRate = 350.0
          movementClass = "BOAT4"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 6.0
          waterline = 0.0
          weapons = [
                { name = "plasma"
                  displayName = Some "LightCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 96.0
                      "vtol", 31.0
                  ]
                  range = Some (ValueOrExpr.Concrete 480.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.8)
                  weaponVelocity = Some 340.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannon1"
                  soundHit = Some "xplomed3"
                  explosiongenerator = Some "custom:genericshellexplosion-small"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "LIGHTAIRSCOUT UNDERWATER"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "gravityaffected", "true"
                      "predictboost", "0.4"
                      "soundhitwet", "splshbig"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.255500793457 0 -1.26264953613"
                  collisionVolumeScales = Some "20.0704803467 16.0 67.0992736816"
                  collisionVolumeType = Some "Box"
                  damage = Some 500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 205.0
                  object_ = Some "Units/corpship_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1032.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 102.5
                  object_ = Some "Units/cor3X3A.s3o"
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
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "nochasecategory", "VTOL UNDERWATER"
            ] }

    type Corpt =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corpt : Corpt =
        { name = "corpt"
          subfolder = "CorShips"
          metalCost = ValueOrExpr.Concrete 210.0
          energyCost = ValueOrExpr.Concrete 1400.0
          buildTime = ValueOrExpr.Concrete 2500.0
          health = ValueOrExpr.Concrete 890.0
          sightDistance = ValueOrExpr.Concrete 670.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 69.0
          maxAcc = 0.05
          maxDec = 0.06473
          turnRate = 520.5
          movementClass = "BOAT3"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 6.0
          waterline = 0.0
          weapons = [
                { name = "cortruck_aa"
                  displayName = Some "Light g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 1.0
                      "vtol", 120.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 680.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 8000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rockhvy2"
                  soundHit = Some "rockhit2"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "canattackground", "false"
                      "castshadow", "true"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "2.0"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "predictboost", "1.0"
                      "smokecolor", "0.66"
                      "smokeperiod", "8.0"
                      "smokesize", "4.5"
                      "smoketime", "14.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splssml"
                      "soundstartvolume", "8.5"
                      "startvelocity", "500.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "tracks", "true"
                      "turnrate", "63000.0"
                      "weaponacceleration", "110.0"
                      "weapontimer", "5.0"
                  ] }
                { name = "cortruck_missile"
                  displayName = Some "Missiles"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 47.0
                  ]
                  range = Some (ValueOrExpr.Concrete 650.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 680.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 8000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rockhvy2"
                  soundHit = Some "rockhit2"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "castshadow", "true"
                      "cegtag", "missiletrailtiny"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "2.0"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smokecolor", "0.7"
                      "smokeperiod", "8.0"
                      "smokesize", "6.0"
                      "smoketime", "15.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splssml"
                      "soundstartvolume", "8.5"
                      "startvelocity", "420.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "tracks", "true"
                      "turnrate", "63000.0"
                      "weaponacceleration", "110.0"
                      "weapontimer", "5.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-3.69921112061 1.72119140629e-06 -0.0"
                  collisionVolumeScales = Some "32.8984222412 14.8354034424 64.0"
                  collisionVolumeType = Some "Box"
                  damage = Some 500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 97.5
                  object_ = Some "Units/corpt_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1432.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 48.75
                  object_ = Some "Units/cor3X3A.s3o"
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
                ok = ["shcormov"]
                select = ["shcorsel"] }
          customParams = Map.ofList [
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "1.0"
                "subfolder", "CorShips"
                "unitgroup", "weaponaa"
            ]
          extras = Map.ofList [
                "airsightdistance", "800.0"
                "movestate", "0.0"
                "nochasecategory", "VTOL UNDERWATER"
                "radardistance", "1000.0"
                "radaremitheight", "25.0"
                "sonardistance", "400.0"
            ] }

    type Correcl =
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
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let correcl : Correcl =
        { name = "correcl"
          subfolder = "CorShips"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 3500.0
          buildTime = ValueOrExpr.Concrete 6200.0
          health = ValueOrExpr.Concrete 420.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 66.0
          maxAcc = 0.05333
          maxDec = 0.05333
          turnRate = 525.0
          movementClass = "UBOAT4"
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 80.0
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["suarmmov"]
                select = ["suarmsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "canassist", "false"
                "canresurrect", "true"
                "sonardistance", "150.0"
            ] }

    type Corroy =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corroy : Corroy =
        { name = "corroy"
          subfolder = "CorShips"
          metalCost = ValueOrExpr.Concrete 960.0
          energyCost = ValueOrExpr.Concrete 7200.0
          buildTime = ValueOrExpr.Concrete 10600.0
          health = ValueOrExpr.Concrete 3950.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 62.4
          maxAcc = 0.02757
          maxDec = 0.02757
          turnRate = 291.0
          movementClass = "BOAT4"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 12.0
          waterline = 0.0
          weapons = [
                { name = "plasma"
                  displayName = Some "HeavyCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 385.0
                      "vtol", 45.0
                  ]
                  range = Some (ValueOrExpr.Concrete 710.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 320.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splssml"
                  ] }
                { name = "depthcharge"
                  displayName = Some "Depthcharge launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 225.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.9)
                  weaponVelocity = Some 140.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 1000.0
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-uw"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTSUB"
                      "mount_maindir", "0 -1 0"
                      "mount_maxangledif", "179.0"
                      "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "3.0"
                      "model", "cordepthcharge.s3o"
                      "predictboost", "0.0"
                      "startvelocity", "120.0"
                      "tracks", "true"
                      "turnrate", "9000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "20.0"
                      "weapontimer", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0580749511719 -0.062504465332 -0.201034545898"
                  collisionVolumeScales = Some "33.2652587891 20.5109710693 79.4415893555"
                  collisionVolumeType = Some "Box"
                  damage = Some 3360.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 480.0
                  object_ = Some "Units/corroy_dead.s3o"
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
                  metal = Some 240.0
                  object_ = Some "Units/cor5X5D.s3o"
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
                ok = ["shcormov"]
                select = ["shcorsel"] }
          customParams = Map.ofList [
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips"
                "unitgroup", "weaponsub"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "movestate", "0.0"
                "nochasecategory", "VTOL"
                "sonardistance", "400.0"
            ] }

    type Corsub =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corsub : Corsub =
        { name = "corsub"
          subfolder = "CorShips"
          metalCost = ValueOrExpr.Concrete 580.0
          energyCost = ValueOrExpr.Concrete 4000.0
          buildTime = ValueOrExpr.Concrete 7200.0
          health = ValueOrExpr.Concrete 1060.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 57.0
          maxAcc = 0.0451
          maxDec = 0.0451
          turnRate = 600.0
          movementClass = "UBOAT4"
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 45.0
          weapons = [
                { name = "torpedo"
                  displayName = Some "Light torpedo launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 342.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 200.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 12000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep1"
                  explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "HOVER NOTSHIP"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "90.0"
                      "mount_onlytargetcategory", "NOTHOVER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "cegtag", "torpedotrail-tiny"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "3.0"
                      "model", "cortorpedo.s3o"
                      "predictboost", "1.0"
                      "soundhitvolume", "15.0"
                      "startvelocity", "130.0"
                      "turnrate", "12000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "15.0"
                      "weapontimer", "3.25"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "2.76780700684 0.0 -0.0"
                  collisionVolumeScales = Some "24.2856140137 12.625 49.0312194824"
                  collisionVolumeType = Some "Box"
                  damage = Some 1002.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 265.0
                  object_ = Some "Units/corsub_dead.s3o"
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
                  metal = Some 132.5
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sucormov"]
                select = ["sucorsel"] }
          customParams = Map.ofList [
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips"
                "unitgroup", "sub"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "sonardistance", "400.0"
                "upright", "true"
            ] }

