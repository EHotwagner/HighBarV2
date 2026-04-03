// Auto-generated BAR unit data: ArmVehicles (flat per-unit types)
namespace BarData.Units

open BarData

module ArmVehicles =

    type Armart =
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

    let armart : Armart =
        { name = "armart"
          subfolder = "ArmVehicles"
          metalCost = ValueOrExpr.Concrete 135.0
          energyCost = ValueOrExpr.Concrete 2200.0
          buildTime = ValueOrExpr.Concrete 3000.0
          health = ValueOrExpr.Concrete 620.0
          sightDistance = ValueOrExpr.Concrete 364.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 54.0
          maxAcc = 0.02727
          maxDec = 0.05454
          turnRate = 393.79999
          movementClass = "TANK3"
          maxSlope = 15.0
          maxWaterDepth = 8.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.29228
          weapons = [
                { name = "tawf113_weapon"
                  displayName = Some "Long-range high-trajectory g2g plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 182.0
                      "subs", 61.0
                      "vtol", 20.0
                  ]
                  range = Some (ValueOrExpr.Concrete 710.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.3)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 75.0
                  accuracy = Some 175.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy3"
                  soundHit = Some "tawf113a"
                  explosiongenerator = Some "custom:genericshellexplosion-small-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "arty-small"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "mygravity", "0.276"
                      "soundhitwet", "splsmed"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 3.10058593911e-07 3.44650268555"
                  collisionVolumeScales = Some "30.6000061035 17.1577606201 39.1929931641"
                  collisionVolumeType = Some "Box"
                  damage = Some 418.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 24.0
                  metal = Some 92.0
                  object_ = Some "Units/armart_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 259.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 37.0
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
                ok = ["tnkt1artyok"]
                select = ["tnkt1artysel"] }
          customParams = Map.ofList [
                "basename", "base"
                "canareaattack", "1.0"
                "kickback", "-6.25"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmVehicles"
                "unitgroup", "weapon"
                "weapon1turretx", "40.0"
                "weapon1turrety", "110.0"
            ]
          extras = Map.ofList [
                "hightrajectory", "1.0"
                "leavetracks", "true"
                "movestate", "0.0"
                "nochasecategory", "VTOL"
                "trackoffset", "6.0"
                "trackstrength", "5.0"
                "tracktype", "armpincer_tracks"
                "trackwidth", "30.0"
            ] }

    type Armbeaver =
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

    let armbeaver : Armbeaver =
        { name = "armbeaver"
          subfolder = "ArmVehicles"
          metalCost = ValueOrExpr.Concrete 150.0
          energyCost = ValueOrExpr.Concrete 3100.0
          buildTime = ValueOrExpr.Concrete 6700.0
          health = ValueOrExpr.Concrete 1030.0
          sightDistance = ValueOrExpr.Concrete 266.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 42.0
          maxAcc = 0.01842
          maxDec = 0.11052
          turnRate = 311.0
          movementClass = "ATANK3"
          maxSlope = 16.0
          maxWaterDepth = 255.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.9834
          workerTime = ValueOrExpr.Concrete 80.0
          buildDistance = 112.0
          buildOptions = ["armsolar"; "armadvsol"; "armwin"; "armgeo"; "armmstor"; "armestor"; "armmex"; "armamex"; "armmakr"; "armlab"; "armvp"; "armap"; "armhp"; "armavp"; "armnanotc"; "armnanotcplat"; "armeyes"; "armrad"; "armdrag"; "armclaw"; "armllt"; "armbeamer"; "armhlt"; "armguard"; "armrl"; "armferret"; "armcir"; "armjuno"; "armdl"; "armjamt"; "armfhp"; "armsy"; "armtide"; "armfmkr"; "armuwms"; "armuwes"; "armamsub"; "armplat"; "armfdrag"; "armfrad"; "armfhlt"; "armfrt"; "armtl"; "armuwgeo"]
          terraformSpeed = 400.0
          energyMake = ValueOrExpr.Concrete 8.0
          energyStorage = 50.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.732467651367 -1.39770507808e-05 0.332275390625"
                  collisionVolumeScales = Some "34.8473205566 22.7869720459 36.573059082"
                  collisionVolumeType = Some "Box"
                  damage = Some 555.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 92.0
                  object_ = Some "Units/armbeaver_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 278.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 37.0
                  object_ = Some "Units/arm3X3C.s3o"
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
                ok = ["tnkt1canamphok"]
                select = ["tnkt1canamphsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmVehicles"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "trackstrength", "5.0"
                "tracktype", "armpincer_tracks"
                "trackwidth", "34.0"
            ] }

    type Armcv =
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

    let armcv : Armcv =
        { name = "armcv"
          subfolder = "ArmVehicles"
          metalCost = ValueOrExpr.Concrete 135.0
          energyCost = ValueOrExpr.Concrete 1950.0
          buildTime = ValueOrExpr.Concrete 4050.0
          health = ValueOrExpr.Concrete 1380.0
          sightDistance = ValueOrExpr.Concrete 253.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 54.0
          maxAcc = 0.03329
          maxDec = 0.13316
          turnRate = 435.0
          movementClass = "TANK3"
          maxSlope = 16.0
          maxWaterDepth = 18.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.2705
          workerTime = ValueOrExpr.Concrete 90.0
          buildDistance = 130.0
          buildOptions = ["armsolar"; "armadvsol"; "armwin"; "armgeo"; "armmstor"; "armestor"; "armmex"; "armamex"; "armmakr"; "armavp"; "armlab"; "armvp"; "armap"; "armhp"; "armnanotc"; "armeyes"; "armrad"; "armdrag"; "armclaw"; "armllt"; "armbeamer"; "armhlt"; "armguard"; "armrl"; "armferret"; "armcir"; "armdl"; "armjamt"; "armjuno"; "armsy"]
          terraformSpeed = 450.0
          energyMake = ValueOrExpr.Concrete 10.0
          energyStorage = 50.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "2.14814758301 -0.0528551147461 0.625"
                  collisionVolumeScales = Some "39.296295166 32.5338897705 48.75"
                  collisionVolumeType = Some "Box"
                  damage = Some 744.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 83.0
                  object_ = Some "Units/armcv_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 372.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 33.0
                  object_ = Some "Units/arm3X3C.s3o"
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
                ok = ["veht1conok"]
                select = ["veht1consel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmVehicles"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "radardistance", "50.0"
                "trackoffset", "-4.0"
                "trackstrength", "6.0"
                "tracktype", "armacv_tracks"
                "trackwidth", "33.0"
            ] }

    type Armfav =
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

    let armfav : Armfav =
        { name = "armfav"
          subfolder = "ArmVehicles"
          metalCost = ValueOrExpr.Concrete 31.0
          energyCost = ValueOrExpr.Concrete 370.0
          buildTime = ValueOrExpr.Concrete 950.0
          health = ValueOrExpr.Concrete 105.0
          sightDistance = ValueOrExpr.Concrete 635.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 168.0
          maxAcc = 0.16659
          maxDec = 0.33318
          turnRate = 653.0
          movementClass = "TANK2"
          maxSlope = 26.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 4.224
          weapons = [
                { name = "arm_laser"
                  displayName = Some "Light Close-Quarters g2g Laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 35.0
                      "vtol", 2.0
                  ]
                  range = Some (ValueOrExpr.Concrete 180.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-tiny-yellow"
                  rgbColor = Some "1 1 0.4"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.18"
                      "beamttl", "1.0"
                      "burstrate", "0.2"
                      "corethickness", "0.3"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.02"
                      "energypershot", "0.0"
                      "firestarter", "50.0"
                      "hardstop", "true"
                      "impactonly", "1.0"
                      "laserflaresize", "3.85"
                      "rgbcolor2", "1 0.55 0.3"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "0.9"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.351249694824 -0.179103781738 -0.672737121582"
                  collisionVolumeScales = Some "23 13 25"
                  collisionVolumeType = Some "Box"
                  damage = Some 111.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 15.0
                  object_ = Some "Units/armfav_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 56.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 6.0
                  object_ = Some "Units/arm2X2F.s3o"
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
                ok = ["veht1buggyok"]
                select = ["veht1buggysel"] }
          customParams = Map.ofList [
                "basename", "base"
                "firingceg", ""
                "kickback", "0"
                "lumamult", "1.3"
                "model_author", "Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmVehicles"
                "unitgroup", "weapon"
                "weapon1turretx", "300.0"
                "weapon1turrety", "300.0"
            ]
          extras = Map.ofList [
                "leavetracks", "false"
                "movestate", "0.0"
                "nochasecategory", "VTOL"
                "trackoffset", "-2.0"
                "trackstrength", "5.0"
                "tracktype", "armstump_tracks"
                "trackwidth", "20.0"
            ] }

    type Armflash =
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

    let armflash : Armflash =
        { name = "armflash"
          subfolder = "ArmVehicles"
          metalCost = ValueOrExpr.Concrete 110.0
          energyCost = ValueOrExpr.Concrete 900.0
          buildTime = ValueOrExpr.Concrete 1960.0
          health = ValueOrExpr.Concrete 750.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 101.0
          maxAcc = 0.06788
          maxDec = 0.13575
          turnRate = 544.0
          movementClass = "TANK2"
          maxSlope = 10.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 2.424
          weapons = [
                { name = "emgx"
                  displayName = Some "Rapid-fire close-quarters plasma gun"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 9.0
                      "vtol", 3.0
                  ]
                  range = Some (ValueOrExpr.Concrete 180.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.3)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "flashemg"
                  soundHit = None
                  explosiongenerator = Some "custom:plasmahit-small"
                  rgbColor = Some "1 0.95 0.4"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "3.0"
                      "burstrate", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "flighttime", "0.4"
                      "gravityaffected", "true"
                      "intensity", "0.7"
                      "size", "1.9"
                      "soundhitwet", "splshbig"
                      "sprayangle", "1180.0"
                      "weapontimer", "0.1"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -6 0"
                  collisionVolumeScales = Some "24 25 30"
                  collisionVolumeType = Some "Ellipsoid"
                  damage = Some 396.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 71.0
                  object_ = Some "Units/armflash_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 193.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 28.0
                  object_ = Some "Units/arm2X2C.s3o"
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
                ok = ["veht1emgok"]
                select = ["veht1emgsel"] }
          customParams = Map.ofList [
                "basename", "base"
                "firingceg", "barrelshot-tiny"
                "kickback", "-2"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmVehicles"
                "unitgroup", "weapon"
                "weapon1turretx", "240.0"
                "weapon1turrety", "240.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "trackoffset", "5.0"
                "trackstrength", "4.0"
                "tracktype", "armpincer_tracks"
                "trackwidth", "24.0"
            ] }

    type Armjanus =
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

    let armjanus : Armjanus =
        { name = "armjanus"
          subfolder = "ArmVehicles"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 2600.0
          buildTime = ValueOrExpr.Concrete 3550.0
          health = ValueOrExpr.Concrete 1030.0
          sightDistance = ValueOrExpr.Concrete 325.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 54.0
          maxAcc = 0.02111
          maxDec = 0.04222
          turnRate = 271.0
          movementClass = "TANK3"
          maxSlope = 10.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.29228
          weapons = [
                { name = "janus_rocket"
                  displayName = Some "Heavy g2g dual-missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 330.0
                      "subs", 110.0
                      "vtol", 35.0
                  ]
                  range = Some (ValueOrExpr.Concrete 380.0)
                  reloadTime = Some (ValueOrExpr.Concrete 7.5)
                  weaponVelocity = Some 230.0
                  areaOfEffect = Some 128.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 1.015
                  noSelfDamage = Some true
                  soundStart = Some "rocklit1"
                  soundHit = Some "xplosml2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-aoe"
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
                      "cegtag", "missiletrailsmall-red"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "model", "catapultmissile.s3o"
                      "smokecolor", "0.5"
                      "smokeperiod", "5.0"
                      "smokesize", "8.0"
                      "smoketime", "20.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitvolume", "8.0"
                      "soundhitwet", "splsmed"
                      "soundstartvolume", "7.0"
                      "startvelocity", "100.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "tracks", "true"
                      "trajectoryheight", "0.4"
                      "turnrate", "22000.0"
                      "weaponacceleration", "80.0"
                  ] }
                { name = "janus_rocket"
                  displayName = Some "Heavy g2g dual-missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 330.0
                      "subs", 110.0
                      "vtol", 35.0
                  ]
                  range = Some (ValueOrExpr.Concrete 380.0)
                  reloadTime = Some (ValueOrExpr.Concrete 7.5)
                  weaponVelocity = Some 230.0
                  areaOfEffect = Some 128.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 1.015
                  noSelfDamage = Some true
                  soundStart = Some "rocklit1"
                  soundHit = Some "xplosml2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-aoe"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_slaveto", "1.0"
                      "avoidfeature", "false"
                      "castshadow", "true"
                      "cegtag", "missiletrailsmall-red"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "model", "catapultmissile.s3o"
                      "smokecolor", "0.5"
                      "smokeperiod", "5.0"
                      "smokesize", "8.0"
                      "smoketime", "20.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitvolume", "8.0"
                      "soundhitwet", "splsmed"
                      "soundstartvolume", "7.0"
                      "startvelocity", "100.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "tracks", "true"
                      "trajectoryheight", "0.4"
                      "turnrate", "22000.0"
                      "weaponacceleration", "80.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-1.45095062256 -4.56400614014 0.266441345215"
                  collisionVolumeScales = Some "28.8743438721 18.1917877197 33.2305145264"
                  collisionVolumeType = Some "Box"
                  damage = Some 628.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 147.0
                  object_ = Some "Units/armjanus_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 364.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 59.0
                  object_ = Some "Units/arm2X2C.s3o"
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
                ok = ["tnkt1rockok"]
                select = ["tnkt1rocksel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmVehicles"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "movestate", "0.0"
                "nochasecategory", "VTOL"
                "trackoffset", "3.0"
                "trackstrength", "6.0"
                "tracktype", "armstump_tracks"
                "trackwidth", "29.0"
                "usepiececollisionvolumes", "1.0"
            ] }

    type Armmlv =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armmlv : Armmlv =
        { name = "armmlv"
          subfolder = "ArmVehicles"
          metalCost = ValueOrExpr.Concrete 57.0
          energyCost = ValueOrExpr.Concrete 1100.0
          buildTime = ValueOrExpr.Concrete 3520.0
          health = ValueOrExpr.Concrete 335.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 75.0
          maxAcc = 0.07135
          maxDec = 0.1427
          turnRate = 629.0
          movementClass = "TANK3"
          maxSlope = 16.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.66584
          workerTime = ValueOrExpr.Concrete 40.0
          buildDistance = 96.0
          buildOptions = ["armmine1"; "armmine2"; "armmine3"; "armdrag"; "armeyes"]
          terraformSpeed = 120.0
          weapons = [
                { name = "minesweep"
                  displayName = Some "Seismic charge"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 15.0
                  ]
                  range = Some (ValueOrExpr.Concrete 220.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 275.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 3000.0
                  edgeEffectiveness = Some 0.4
                  impulseFactor = None
                  noSelfDamage = Some true
                  soundStart = None
                  soundHit = None
                  explosiongenerator = Some "custom:MINESWEEP"
                  rgbColor = Some "0.2 0.6 0.2"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "90.0"
                      "mount_onlytargetcategory", "MINE"
                      "avoidfeature", "false"
                      "collidefriendly", "false"
                      "craterareaofeffect", "48.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firetolerance", "3000.0"
                      "gravityaffected", "true"
                      "weapontimer", "0.1"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.399993896484 1.98730468792e-06 0.533332824707"
                  collisionVolumeScales = Some "20.5333251953 11.8133239746 27.7333221436"
                  collisionVolumeType = Some "Box"
                  damage = Some 113.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 34.0
                  object_ = Some "Units/armmlv_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 70.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 14.0
                  object_ = Some "Units/arm3X3B.s3o"
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
                ok = ["varmmove"]
                select = ["varmsel"] }
          customParams = Map.ofList [
                "minesweeper", "450.0"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmVehicles"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "canassist", "false"
                "canreclaim", "false"
                "canrepair", "true"
                "canrestore", "false"
                "leavetracks", "false"
                "mass", "740.0"
                "nochasecategory", "VTOL"
                "radardistancejam", "64.0"
                "stealth", "true"
                "trackoffset", "12.0"
                "trackstrength", "5.0"
                "tracktype", "StdTank"
                "trackwidth", "18.0"
            ] }

    type Armpincer =
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

    let armpincer : Armpincer =
        { name = "armpincer"
          subfolder = "ArmVehicles"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 2610.0
          health = ValueOrExpr.Concrete 1340.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 63.0
          maxAcc = 0.03572
          maxDec = 0.07144
          turnRate = 398.0
          movementClass = "ATANK3"
          maxSlope = 15.0
          maxWaterDepth = 125.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.485
          weapons = [
                { name = "arm_pincer_gauss"
                  displayName = Some "Light close-quarters plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 116.0
                      "vtol", 25.0
                  ]
                  range = Some (ValueOrExpr.Concrete 305.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed2"
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
                      "cylindertargeting", "1.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splshbig"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -1.0267456543 -0.357666015625"
                  collisionVolumeScales = Some "29.7029724121 10.5689086914 32.8999633789"
                  collisionVolumeType = Some "Box"
                  damage = Some 689.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 9.0
                  metal = Some 122.0
                  object_ = Some "Units/armpincer_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 528.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 61.0
                  object_ = Some "Units/arm2X2D.s3o"
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
                ok = ["tnkt1canamphok"]
                select = ["tnkt1canamphsel"] }
          customParams = Map.ofList [
                "basename", "base"
                "firingceg", "barrelshot-small"
                "kickback", "-2.7"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.2"
                "subfolder", "ArmVehicles"
                "unitgroup", "weapon"
                "weapon1turretx", "130.0"
                "weapon1turrety", "130.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "sonardistance", "180.0"
                "trackoffset", "3.0"
                "trackstrength", "6.0"
                "tracktype", "armpincer_tracks"
                "trackwidth", "28.0"
                "usepiececollisionvolumes", "1.0"
            ] }

    type Armsam =
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

    let armsam : Armsam =
        { name = "armsam"
          subfolder = "ArmVehicles"
          metalCost = ValueOrExpr.Concrete 150.0
          energyCost = ValueOrExpr.Concrete 2100.0
          buildTime = ValueOrExpr.Concrete 3420.0
          health = ValueOrExpr.Concrete 820.0
          sightDistance = ValueOrExpr.Concrete 620.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 55.0
          maxAcc = 0.0236
          maxDec = 0.0472
          turnRate = 370.0
          movementClass = "TANK3"
          maxSlope = 16.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.056
          weapons = [
                { name = "armtruck_aa"
                  displayName = Some "Light g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 1.0
                      "vtol", 160.0
                  ]
                  range = Some (ValueOrExpr.Concrete 700.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.33333)
                  weaponVelocity = Some 670.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 8000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rockhvy2"
                  soundHit = Some "rockhit2"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
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
                      "smokecolor", "0.66"
                      "smokeperiod", "8.0"
                      "smokesize", "5.0"
                      "smoketime", "14.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splssml"
                      "soundstartvolume", "8.5"
                      "soundtrigger", "true"
                      "startvelocity", "500.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "tracks", "true"
                      "turnrate", "63000.0"
                      "weaponacceleration", "110.0"
                      "weapontimer", "5.0"
                  ] }
                { name = "armtruck_missile"
                  displayName = Some "Light g2g missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 86.0
                  ]
                  range = Some (ValueOrExpr.Concrete 550.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.33333)
                  weaponVelocity = Some 350.0
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
                      "predictboost", "1.0"
                      "smokecolor", "0.66"
                      "smokeperiod", "8.0"
                      "smokesize", "5.0"
                      "smoketime", "14.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splssml"
                      "soundstartvolume", "8.5"
                      "soundtrigger", "true"
                      "startvelocity", "350.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "weaponacceleration", "110.0"
                      "weapontimer", "1.6"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "26 15 41"
                  collisionVolumeType = Some "Box"
                  damage = Some 639.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 97.0
                  object_ = Some "Units/armsam_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 320.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 45.0
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
                ok = ["veht1aaok"]
                select = ["veht1aasel"] }
          customParams = Map.ofList [
                "maxrange", "550.0"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmVehicles"
                "unitgroup", "weaponaa"
            ]
          extras = Map.ofList [
                "airsightdistance", "900.0"
                "leavetracks", "true"
                "movestate", "0.0"
                "trackoffset", "-7.0"
                "trackstrength", "5.0"
                "tracktype", "armsam_tracks"
                "trackwidth", "28.0"
            ] }

    type Armstump =
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

    let armstump : Armstump =
        { name = "armstump"
          subfolder = "ArmVehicles"
          metalCost = ValueOrExpr.Concrete 225.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 2900.0
          health = ValueOrExpr.Concrete 1780.0
          sightDistance = ValueOrExpr.Concrete 325.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 75.9
          maxAcc = 0.0438
          maxDec = 0.08759
          turnRate = 340.0
          movementClass = "TANK3"
          maxSlope = 10.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.952
          weapons = [
                { name = "arm_lightcannon"
                  displayName = Some "Light g2g plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 97.0
                      "vtol", 18.0
                  ]
                  range = Some (ValueOrExpr.Concrete 350.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.16667)
                  weaponVelocity = Some 225.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "corraid"
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
                      "firestarter", "100.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "9.5"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.0399932861328 0.00128356933594 -0.564636230469"
                  collisionVolumeScales = Some "25.7996826172 19.2875671387 29.4318847656"
                  collisionVolumeType = Some "Box"
                  damage = Some 1056.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 152.0
                  object_ = Some "Units/armstump_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 528.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 61.0
                  object_ = Some "Units/arm2X2D.s3o"
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
                ok = ["tnkt1canok"]
                select = ["tnkt1cansel"] }
          customParams = Map.ofList [
                "basename", "base"
                "firingceg", "barrelshot-small"
                "kickback", "-2.4"
                "lumamult", "1.2"
                "model_author", "Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmVehicles"
                "unitgroup", "weapon"
                "weapon1turretx", "45.0"
                "weapon1turrety", "80.0"
            ]
          extras = Map.ofList [
                "leavetracks", "true"
                "nochasecategory", "VTOL"
                "trackoffset", "3.0"
                "trackstrength", "6.0"
                "tracktype", "armstump_tracks"
                "trackwidth", "38.0"
                "usepiececollisionvolumes", "1.0"
            ] }

