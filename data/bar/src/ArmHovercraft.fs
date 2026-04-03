// Auto-generated BAR unit data: ArmHovercraft (flat per-unit types)
namespace BarData.Units

open BarData

module ArmHovercraft =

    type Armah =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armah : Armah =
        { name = "armah"
          subfolder = "ArmHovercraft"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 4500.0
          buildTime = ValueOrExpr.Concrete 3560.0
          health = ValueOrExpr.Concrete 1070.0
          sightDistance = ValueOrExpr.Concrete 509.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 88.5
          maxAcc = 0.06585
          maxDec = 0.06585
          turnRate = 490.0
          movementClass = "HOVER3"
          maxSlope = 16.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 2.2044
          weapons = [
                { name = "bogus_missile"
                  displayName = Some "Missiles"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 830.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.5)
                  weaponVelocity = Some 720.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 9000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = None
                  soundStart = None
                  soundHit = None
                  explosiongenerator = None
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "canattackground", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "metalpershot", "0.0"
                      "soundhitwet", "splshbig"
                      "startvelocity", "150.0"
                      "turnrate", "33000.0"
                      "weaponacceleration", "100.0"
                      "weapontimer", "0.1"
                  ] }
                { name = "armah_weapon"
                  displayName = Some "Light g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 62.0
                  ]
                  range = Some (ValueOrExpr.Concrete 700.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.2)
                  weaponVelocity = Some 670.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rockhvy2"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "burst", "3.0"
                      "burstrate", "0.2"
                      "canattackground", "false"
                      "castshadow", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "1.75"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smokecolor", "0.95"
                      "smokeperiod", "6.0"
                      "smokesize", "4.2"
                      "smoketime", "11.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "startvelocity", "450.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "63000.0"
                      "weaponacceleration", "164.0"
                      "weapontimer", "5.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -3 0"
                  collisionVolumeScales = Some "34 15 34"
                  collisionVolumeType = Some "Box"
                  damage = Some 575.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 141.0
                  object_ = Some "Units/armah_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 288.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 56.0
                  object_ = Some "Units/arm3X3B.s3o"
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
                ok = ["hovt1aaok"]
                select = ["hovt1aasel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmHovercraft"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "800.0"
                "movestate", "0.0"
                "nochasecategory", "NOTAIR"
                "sonardistance", "350.0"
            ] }

    type Armanac =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armanac : Armanac =
        { name = "armanac"
          subfolder = "ArmHovercraft"
          metalCost = ValueOrExpr.Concrete 270.0
          energyCost = ValueOrExpr.Concrete 2400.0
          buildTime = ValueOrExpr.Concrete 3000.0
          health = ValueOrExpr.Concrete 1530.0
          sightDistance = ValueOrExpr.Concrete 509.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 69.99
          maxAcc = 0.05333
          maxDec = 0.05333
          turnRate = 525.0
          movementClass = "HOVER3"
          maxSlope = 16.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.6698
          weapons = [
                { name = "armanac_weapon"
                  displayName = Some "Medium g2g plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 98.0
                      "vtol", 29.0
                  ]
                  range = Some (ValueOrExpr.Concrete 370.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.4)
                  weaponVelocity = Some 260.0
                  areaOfEffect = Some 32.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "canlite3"
                  soundHit = Some "xplosml3"
                  explosiongenerator = Some "custom:genericshellexplosion-small"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splshbig"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -2 0"
                  collisionVolumeScales = Some "40 19 40"
                  collisionVolumeType = Some "Cyly"
                  damage = Some 826.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 175.0
                  object_ = Some "Units/armanac_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 413.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 70.0
                  object_ = Some "Units/arm3X3D.s3o"
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
                ok = ["hovt1canok"]
                select = ["hovt1cansel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmHovercraft"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "usepiececollisionvolumes", "1.0"
            ] }

    type Armch =
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

    let armch : Armch =
        { name = "armch"
          subfolder = "ArmHovercraft"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 2700.0
          buildTime = ValueOrExpr.Concrete 4470.0
          health = ValueOrExpr.Concrete 1440.0
          sightDistance = ValueOrExpr.Concrete 351.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 66.9
          maxAcc = 0.04318
          maxDec = 0.12
          turnRate = 425.0
          movementClass = "HOVER3"
          maxSlope = 16.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.6698
          workerTime = ValueOrExpr.Concrete 110.0
          buildDistance = 150.0
          buildOptions = ["armsolar"; "armadvsol"; "armwin"; "armgeo"; "armmstor"; "armestor"; "armmex"; "armamex"; "armmakr"; "armlab"; "armvp"; "armap"; "armhp"; "armnanotc"; "armnanotcplat"; "armeyes"; "armrad"; "armdrag"; "armclaw"; "armllt"; "armbeamer"; "armhlt"; "armguard"; "armrl"; "armferret"; "armcir"; "armdl"; "armjamt"; "armjuno"; "armfhp"; "armsy"; "armamsub"; "armplat"; "armtide"; "armfmkr"; "armuwms"; "armuwes"; "armfdrag"; "armfrad"; "armfhlt"; "armfrt"; "armtl"; "armavp"; "armasy"; "armuwgeo"]
          terraformSpeed = 550.0
          energyMake = ValueOrExpr.Concrete 11.0
          energyStorage = 75.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "31 12 31"
                  collisionVolumeType = Some "Box"
                  damage = Some 778.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 88.0
                  object_ = Some "Units/armch_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 389.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 35.0
                  object_ = Some "Units/arm3X3A.s3o"
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
                ok = ["hovt1conok"]
                select = ["hovt1consel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmHovercraft"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
            ] }

    type Armmh =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armmh : Armmh =
        { name = "armmh"
          subfolder = "ArmHovercraft"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 3300.0
          health = ValueOrExpr.Concrete 530.0
          sightDistance = ValueOrExpr.Concrete 509.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 63.9
          maxAcc = 0.04561
          maxDec = 0.04561
          turnRate = 470.0
          movementClass = "HOVER3"
          maxSlope = 16.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.5972
          weapons = [
                { name = "armmh_weapon"
                  displayName = Some "Light long-range g2g starburst rocket launcher"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 300.0
                      "subs", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 710.0)
                  reloadTime = Some (ValueOrExpr.Concrete 6.0)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = None
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "castshadow", "true"
                      "cegtag", "missiletrailsmall-starburst"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "10.0"
                      "metalpershot", "0.0"
                      "model", "corkbmissl1.s3o"
                      "smokecolor", "0.7"
                      "smokeperiod", "9.0"
                      "smokesize", "10.0"
                      "smoketime", "28.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splssml"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "weaponacceleration", "100.0"
                      "weapontimer", "2.3"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -2 0"
                  collisionVolumeScales = Some "33 15 43"
                  collisionVolumeType = Some "Box"
                  damage = Some 286.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 106.0
                  object_ = Some "Units/armmh_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 143.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 42.0
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
                ok = ["hovt1vrocok"]
                select = ["hovt1vrocsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmHovercraft"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "movestate", "0.0"
                "nochasecategory", "VTOL"
            ] }

    type Armsh =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armsh : Armsh =
        { name = "armsh"
          subfolder = "ArmHovercraft"
          metalCost = ValueOrExpr.Concrete 85.0
          energyCost = ValueOrExpr.Concrete 1250.0
          buildTime = ValueOrExpr.Concrete 1700.0
          health = ValueOrExpr.Concrete 290.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 113.7
          maxAcc = 0.1105
          maxDec = 0.1105
          turnRate = 640.0
          movementClass = "HOVER2"
          maxSlope = 16.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 2.9634
          weapons = [
                { name = "armsh_weapon"
                  displayName = Some "Light Close-Quarters Fast-Firing g2g Laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 36.0
                      "vtol", 7.0
                  ]
                  range = Some (ValueOrExpr.Concrete 230.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.6)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfast"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-yellow"
                  rgbColor = Some "1 1 0.3"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "burstrate", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.02"
                      "energypershot", "0.0"
                      "firestarter", "50.0"
                      "impactonly", "1.0"
                      "laserflaresize", "4.5"
                      "rgbcolor2", "1 0.55 0.3"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "1.25"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -2 0"
                  collisionVolumeScales = Some "24 15 26"
                  collisionVolumeType = Some "Box"
                  damage = Some 185.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 49.0
                  object_ = Some "Units/armsh_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 93.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 20.0
                  object_ = Some "Units/arm3X3D.s3o"
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
                ok = ["hovt1fastok"]
                select = ["hovt1fastsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmHovercraft"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
            ] }

