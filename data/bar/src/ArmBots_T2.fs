// Auto-generated BAR unit data: ArmBots/T2 (flat per-unit types)
namespace BarData.Units

open BarData

module ArmBots_T2 =

    type Armaak =
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
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armaak : Armaak =
        { name = "armaak"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 520.0
          energyCost = ValueOrExpr.Concrete 5600.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 47.4
          maxAcc = 0.138
          maxDec = 0.6486
          turnRate = 1174.15002
          movementClass = "ABOT3"
          maxSlope = 14.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.0428
          weapons = [
                { name = "longrangemissile"
                  displayName = Some "Long-Range Anti-Air Missile Launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 15000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "rocklit1"
                  soundHit = Some "xplosml2"
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
                      "canattackground", "false"
                      "castshadow", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "fixedlauncher", "true"
                      "flighttime", "1.8"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "proximitypriority", "-1.0"
                      "smokecolor", "1.0"
                      "smokeperiod", "6.0"
                      "smokesize", "5.5"
                      "smoketime", "11.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitvolume", "7.5"
                      "soundhitwet", "splssml"
                      "soundstartvolume", "7.5"
                      "startvelocity", "590.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "30000.0"
                      "weaponacceleration", "150.0"
                      "weapontimer", "6.0"
                  ] }
                { name = "shortrangemissile"
                  displayName = Some "Medium-Range Anti-Air Missile Launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 880.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.7)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 26000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "rocklit1"
                  soundHit = Some "xplosml2"
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
                      "canattackground", "false"
                      "castshadow", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "fixedlauncher", "true"
                      "flighttime", "1.85"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "proximitypriority", "1.0"
                      "smokecolor", "1.0"
                      "smokeperiod", "6.0"
                      "smokesize", "2.0"
                      "smoketime", "11.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitvolume", "7.5"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "7.5"
                      "startvelocity", "100.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "30000.0"
                      "weaponacceleration", "400.0"
                      "weapontimer", "5.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -1.2425585791 1.2922744751"
                  collisionVolumeScales = Some "30.0 14.3981628418 32.5845489502"
                  collisionVolumeType = Some "Box"
                  damage = Some 1212.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 15.0
                  metal = Some 314.0
                  object_ = Some "Units/armaak_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 606.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 126.0
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "Kaiser"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "1200.0"
                "movestate", "0.0"
                "nochasecategory", "NOTAIR"
                "upright", "true"
            ] }

    type Armack =
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

    let armack : Armack =
        { name = "armack"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 430.0
          energyCost = ValueOrExpr.Concrete 6900.0
          buildTime = ValueOrExpr.Concrete 12500.0
          health = ValueOrExpr.Concrete 930.0
          sightDistance = ValueOrExpr.Concrete 323.70001
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 33.0
          maxAcc = 0.4968
          maxDec = 3.105
          turnRate = 1138.5
          movementClass = "BOT2"
          maxSlope = 20.0
          maxWaterDepth = 25.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.759
          workerTime = ValueOrExpr.Concrete 210.0
          buildDistance = 136.0
          buildOptions = ["armfus"; "armafus"; "armckfus"; "armshltx"; "armageo"; "armgmm"; "armmoho"; "armmmkr"; "armuwadves"; "armuwadvms"; "armarad"; "armveil"; "armfort"; "armtarg"; "armsd"; "armgate"; "armamb"; "armpb"; "armanni"; "armflak"; "armmercury"; "armemp"; "armamd"; "armsilo"; "armbrtha"; "armvulc"; "armdf"; "armlab"; "armalab"]
          terraformSpeed = 900.0
          energyMake = ValueOrExpr.Concrete 14.0
          energyStorage = 100.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "1.64561462402 6.61621093734e-06 -1.44562530518"
                  collisionVolumeScales = Some "29.6044616699 29.4648132324 28.049697876"
                  collisionVolumeType = Some "Box"
                  damage = Some 700.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 189.0
                  object_ = Some "Units/armack_dead.s3o"
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
                  metal = Some 76.0
                  object_ = Some "Units/arm2X2B.s3o"
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
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "Kaiser"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
                "upright", "true"
            ] }

    type Armamph =
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
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armamph : Armamph =
        { name = "armamph"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 260.0
          energyCost = ValueOrExpr.Concrete 2700.0
          buildTime = ValueOrExpr.Concrete 7000.0
          health = ValueOrExpr.Concrete 1170.0
          sightDistance = ValueOrExpr.Concrete 377.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 90.0
          maxAcc = 0.138
          maxDec = 0.6486
          turnRate = 506.0
          movementClass = "AHOVER2"
          maxSlope = 14.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.98
          weapons = [
                { name = "armamph_weapon1"
                  displayName = Some "Light close-quarters laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 80.0
                      "vtol", 15.0
                  ]
                  range = Some (ValueOrExpr.Concrete 275.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.73333)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
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
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.175"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "2.0"
                      "firestarter", "20.0"
                      "impactonly", "1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "armamph_missile"
                  displayName = Some "Light g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 90.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.1)
                  weaponVelocity = Some 850.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 9000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rocklit1"
                  soundHit = Some "xplosml2"
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
                      "smokeperiod", "5.0"
                      "smokesize", "4.4"
                      "smoketime", "12.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "startvelocity", "650.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "48000.0"
                      "weaponacceleration", "141.0"
                      "weapontimer", "5.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-1.16748809814 -0.254996625977 -1"
                  collisionVolumeScales = Some "27 10 35"
                  collisionVolumeType = Some "Box"
                  damage = Some 800.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 159.0
                  object_ = Some "Units/armamph_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 64.0
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
                ok = ["amphok1"]
                select = ["amphsel1"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weaponaa"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    type Armaser =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armaser : Armaser =
        { name = "armaser"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 78.0
          energyCost = ValueOrExpr.Concrete 1400.0
          buildTime = ValueOrExpr.Concrete 6000.0
          health = ValueOrExpr.Concrete 340.0
          sightDistance = ValueOrExpr.Concrete 260.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 48.3
          maxAcc = 0.138
          maxDec = 0.5175
          turnRate = 1201.75
          movementClass = "BOT2"
          maxSlope = 32.0
          maxWaterDepth = 112.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.0626
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.136978149414 4.50317382814e-05 -6.27960205078"
                  collisionVolumeScales = Some "28.490814209 34.7166900635 16.3992004395"
                  collisionVolumeType = Some "Box"
                  damage = Some 250.0
                  featureDead = Some "HEAP"
                  footprintX = Some 1.0
                  footprintZ = Some 1.0
                  height = Some 40.0
                  metal = Some 47.0
                  object_ = Some "Units/armaser_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "21.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 150.0
                  featureDead = None
                  footprintX = Some 1.0
                  footprintZ = Some 1.0
                  height = Some 4.0
                  metal = Some 19.0
                  object_ = Some "Units/arm1X1A.s3o"
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
                ok = ["kbarmmov"]
                select = ["radjam1"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "off_on_stun", "true"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "canattack", "false"
                "energyupkeep", "80.0"
                "movestate", "0.0"
                "nochasecategory", "MOBILE"
                "onoffable", "true"
                "radardistancejam", "450.0"
            ] }

    type Armdecom =
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
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armdecom : Armdecom =
        { name = "armdecom"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 770.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 30000.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1148.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 300.0
          buildDistance = 145.0
          buildOptions = ["armmine1"; "armmine2"; "armmine3"; "armsolar"; "armwin"; "armmstor"; "armestor"; "armmex"; "armmakr"; "armrad"; "armllt"; "armrl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"]
          terraformSpeed = 750.0
          energyMake = ValueOrExpr.Concrete 15.0
          energyStorage = 50.0
          weapons = [
                { name = "armcomlaser"
                  displayName = Some "Light close-quarters g2g laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 75.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.5"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "armcomsealaser"
                  displayName = Some "J7NSLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 62.5
                      "subs", 18.75
                  ]
                  range = Some (ValueOrExpr.Concrete 260.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-blue"
                  rgbColor = Some "0.2 0.2 0.6"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.4"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "impactonly", "1.0"
                      "intensity", "0.3"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = Some "Decoy-disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "default", 40.0
                  ]
                  range = Some (ValueOrExpr.Concrete 250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 36.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2"
                  explosiongenerator = Some "custom:expldgun"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cegtag", "dgunprojectile"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.6"
                      "energypershot", "150.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "noexplode", "true"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
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
                ok = ["kcarmmov"]
                select = ["kcarmsel"] }
          customParams = Map.ofList [
                "decoyfor", "armcom"
                "isdecoycommander", "true"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "autoheal", "0.0"
                "cancapture", "true"
                "candgun", "true"
                "capturable", "false"
                "capturespeed", "900.0"
                "cloakcost", "30.0"
                "cloakcostmoving", "180.0"
                "decoyfor", "armcom"
                "hidedamage", "true"
                "holdsteady", "true"
                "mincloakdistance", "50.0"
                "nochasecategory", "VTOL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "showplayername", "true"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    type Armfark =
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

    let armfark : Armfark =
        { name = "armfark"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 210.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 6000.0
          health = ValueOrExpr.Concrete 335.0
          sightDistance = ValueOrExpr.Concrete 377.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 75.0
          maxAcc = 0.4968
          maxDec = 5.175
          turnRate = 1265.0
          movementClass = "BOT2"
          maxSlope = 14.0
          maxWaterDepth = 22.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.7424
          workerTime = ValueOrExpr.Concrete 140.0
          buildDistance = 136.0
          buildOptions = ["armsolar"; "armwin"; "armmex"; "armmakr"; "armeyes"; "armmark"; "armaser"]
          terraformSpeed = 600.0
          energyMake = ValueOrExpr.Concrete 12.0
          energyStorage = 25.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "21 5 17"
                  collisionVolumeType = Some "Box"
                  damage = Some 250.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 131.0
                  object_ = Some "Units/armfark_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 150.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 52.0
                  object_ = Some "Units/arm2X2D.s3o"
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
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "radardistance", "50.0"
                "upright", "true"
            ] }

    type Armfast =
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

    let armfast : Armfast =
        { name = "armfast"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 160.0
          energyCost = ValueOrExpr.Concrete 3800.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 690.0
          sightDistance = ValueOrExpr.Concrete 351.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 111.3
          maxAcc = 0.414
          maxDec = 1.29375
          turnRate = 1644.5
          movementClass = "BOT3"
          maxSlope = 17.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 2.4486
          weapons = [
                { name = "arm_fast"
                  displayName = Some "Rapid-firing close-quarters g2g plasma guns"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 12.0
                      "vtol", 4.0
                  ]
                  range = Some (ValueOrExpr.Concrete 230.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.5)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "fastemg"
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
                      "burst", "5.0"
                      "burstrate", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "flighttime", "0.47"
                      "gravityaffected", "true"
                      "intensity", "0.7"
                      "size", "2.05"
                      "soundhitwet", "splshbig"
                      "weapontimer", "0.6"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-2.49777984619 -2.74520318604 -3.11322021484"
                  collisionVolumeScales = Some "50.1881866455 6.02409362793 37.503112793"
                  collisionVolumeType = Some "Box"
                  damage = Some 500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 105.0
                  object_ = Some "Units/armfast_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 300.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 42.0
                  object_ = Some "Units/arm2X2E.s3o"
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
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm, PtaQ"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
                "weapon1turretx", "400.0"
                "weapon1turrety", "500.0"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    type Armfboy =
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

    let armfboy : Armfboy =
        { name = "armfboy"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 1400.0
          energyCost = ValueOrExpr.Concrete 20000.0
          buildTime = ValueOrExpr.Concrete 32000.0
          health = ValueOrExpr.Concrete 7800.0
          sightDistance = ValueOrExpr.Concrete 510.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.138
          maxDec = 0.43125
          turnRate = 368.0
          movementClass = "HBOT4"
          maxSlope = 20.0
          maxWaterDepth = 25.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.66
          weapons = [
                { name = "arm_fatboy_notalaser"
                  displayName = Some "Heavy AoE g2g plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 800.0
                      "subs", 100.0
                      "vtol", 111.0
                  ]
                  range = Some (ValueOrExpr.Concrete 700.0)
                  reloadTime = Some (ValueOrExpr.Concrete 7.0)
                  weaponVelocity = Some 307.0
                  areaOfEffect = Some 300.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.9
                  noSelfDamage = Some true
                  soundStart = Some "BERTHA1"
                  soundHit = Some "bertha6"
                  explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "Heavy-Plasma"
                      "craterareaofeffect", "240.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splslrg"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "1.35855102539 -5.79698309326 2.2872467041"
                  collisionVolumeScales = Some "33.431427002 25.3690338135 53.5839233398"
                  collisionVolumeType = Some "Box"
                  damage = Some 5000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 9.0
                  metal = Some 1008.0
                  object_ = Some "Units/armfboy_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 3500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = None
                  metal = Some 403.0
                  object_ = Some "Units/arm2X2A.s3o"
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
                ok = ["mavbot1"]
                select = ["capture2"] }
          customParams = Map.ofList [
                "model_author", "Kaiser, PtaQ"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "usepiececollisionvolumes", "1.0"
            ] }

    type Armfido =
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

    let armfido : Armfido =
        { name = "armfido"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 285.0
          energyCost = ValueOrExpr.Concrete 6300.0
          buildTime = ValueOrExpr.Concrete 6500.0
          health = ValueOrExpr.Concrete 1280.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 69.0
          maxAcc = 0.138
          maxDec = 1.29375
          turnRate = 1138.5
          movementClass = "BOT3"
          maxSlope = 14.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.518
          weapons = [
                { name = "bfido"
                  displayName = Some "Ballistic g2g AoE plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 255.0
                      "vtol", 35.0
                  ]
                  range = Some (ValueOrExpr.Concrete 650.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.16667)
                  weaponVelocity = Some 340.0
                  areaOfEffect = Some 72.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannon1"
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
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splssml"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-2.33637237549 -5.01163688965 -4.31414794922"
                  collisionVolumeScales = Some "32.719619751 19.6731262207 35.1108398438"
                  collisionVolumeType = Some "Box"
                  damage = Some 1000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 164.0
                  object_ = Some "Units/armfido_dead.s3o"
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
                  metal = Some 66.0
                  object_ = Some "Units/arm2X2A.s3o"
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
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "usepiececollisionvolumes", "0.0"
            ] }

    type Armhack =
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

    let armhack : Armhack =
        { name = "armhack"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 1260.0
          energyCost = ValueOrExpr.Concrete 18000.0
          buildTime = ValueOrExpr.Concrete 37000.0
          health = ValueOrExpr.Concrete 1335.0
          sightDistance = ValueOrExpr.Concrete 377.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 75.0
          maxAcc = 0.4968
          maxDec = 5.175
          turnRate = 1265.0
          movementClass = "BOT3"
          maxSlope = 14.0
          maxWaterDepth = 22.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.7424
          workerTime = ValueOrExpr.Concrete 600.0
          buildDistance = 136.0
          buildOptions = ["armafus"; "armfus"; "armckfus"; "armageo"; "armgmm"; "armmoho"; "armmmkr"; "armuwadves"; "armuwadvms"; "armfort"; "armtarg"; "armgate"; "armamb"; "armpb"; "armanni"; "armflak"; "armmercury"; "armemp"; "armamd"; "armsilo"; "armbrtha"; "armvulc"; "armdf"; "armbanth"; "armalab"; "armhalab"; "armlab"; "armvp"; "armap"; "armsy"; "armsd"; "armshltx"]
          terraformSpeed = 600.0
          energyMake = ValueOrExpr.Concrete 12.0
          energyStorage = 25.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "21 5 17"
                  collisionVolumeType = Some "Box"
                  damage = Some 250.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 131.0
                  object_ = Some "Units/armfark_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 150.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 52.0
                  object_ = Some "Units/arm2X2D.s3o"
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
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "3.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "mass", "2700.0"
                "radardistance", "50.0"
                "upright", "true"
            ] }

    type Armmark =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armmark : Armmark =
        { name = "armmark"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 100.0
          energyCost = ValueOrExpr.Concrete 1250.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 355.0
          sightDistance = ValueOrExpr.Concrete 900.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 40.5
          maxAcc = 0.05175
          maxDec = 0.0621
          turnRate = 580.75
          movementClass = "BOT2"
          maxSlope = 16.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.891
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-2.9700012207 0.0 2.42810058594"
                  collisionVolumeScales = Some "23.0599975586 13.375 26.6004943848"
                  collisionVolumeType = Some "Box"
                  damage = Some 280.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 76.0
                  object_ = Some "Units/armmark_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 256.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 38.0
                  object_ = Some "Units/arm2X2A.s3o"
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
                ok = ["kbarmmov"]
                select = ["akradsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "canattack", "false"
                "movestate", "0.0"
                "onoffable", "false"
                "radardistance", "2200.0"
                "sonardistance", "0.0"
            ] }

    type Armmav =
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

    let armmav : Armmav =
        { name = "armmav"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 650.0
          energyCost = ValueOrExpr.Concrete 11000.0
          buildTime = ValueOrExpr.Concrete 17000.0
          health = ValueOrExpr.Concrete 1560.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 49.5
          maxAcc = 0.138
          maxDec = 0.43125
          turnRate = 1285.69995
          movementClass = "BOT3"
          maxSlope = 14.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.089
          weapons = [
                { name = "armmav_weapon"
                  displayName = Some "Anti-swarm g2g gauss-impulse guns"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 265.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 365.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 1.1
                  noSelfDamage = Some true
                  soundStart = Some "mavgun4"
                  soundHit = Some "xplomed5"
                  explosiongenerator = Some "custom:genericshellexplosion-small"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "alphadecay", "0.1"
                      "avoidfeature", "false"
                      "cegtag", "impulse-trail"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "gravityaffected", "true"
                      "impactonly", "1.0"
                      "nogap", "false"
                      "predictboost", "0.3"
                      "separation", "1.0"
                      "sizedecay", "0.01"
                      "soundhitwet", "splshbig"
                      "stages", "12.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "50.6378936768 10.4806671143 38.4813079834"
                  collisionVolumeType = Some "Box"
                  damage = Some 900.0
                  featureDead = Some "heap"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 394.0
                  object_ = Some "Units/armmav_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 696.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 196.0
                  object_ = Some "Units/arm2x2e.s3o"
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
                ok = ["mavbok1"]
                select = ["mavbsel1"] }
          customParams = Map.ofList [
                "model_author", "Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "rangexpscale", "0.6"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "autoheal", "50.0"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    type Armsack =
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

    let armsack : Armsack =
        { name = "armsack"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 6900.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 930.0
          sightDistance = ValueOrExpr.Concrete 323.70001
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 33.0
          maxAcc = 0.4968
          maxDec = 3.105
          turnRate = 1138.5
          movementClass = "BOT2"
          maxSlope = 20.0
          maxWaterDepth = 25.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.759
          workerTime = ValueOrExpr.Concrete 180.0
          buildDistance = 136.0
          buildOptions = ["armafus"; "armageo"; "armmoho"; "armmmkr"; "armanni"; "armmercury"; "armsilo"; "armbrtha"; "armvulc"; "armlab"; "armalab"; "armsalab"; "armshltx"]
          terraformSpeed = 900.0
          energyMake = ValueOrExpr.Concrete 14.0
          energyStorage = 100.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "1.64561462402 6.61621093734e-06 -1.44562530518"
                  collisionVolumeScales = Some "29.6044616699 29.4648132324 28.049697876"
                  collisionVolumeType = Some "Box"
                  damage = Some 700.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 189.0
                  object_ = Some "Units/armack_dead.s3o"
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
                  metal = Some 76.0
                  object_ = Some "Units/arm2X2B.s3o"
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
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "Kaiser"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
                "upright", "true"
            ] }

    type Armscab =
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

    let armscab : Armscab =
        { name = "armscab"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 1150.0
          energyCost = ValueOrExpr.Concrete 30000.0
          buildTime = ValueOrExpr.Concrete 49000.0
          health = ValueOrExpr.Concrete 870.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 51.0
          maxAcc = 0.03663
          maxDec = 0.07326
          turnRate = 473.0
          movementClass = "TBOT3"
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.122
          weapons = [
                { name = "armscab_weapon"
                  displayName = Some "ICBM intercepting missile launcher"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 72000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 7000.0
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
                      "collidefriendly", "false"
                      "coverage", "1400.0"
                      "craterareaofeffect", "420.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "6500.0"
                      "firestarter", "100.0"
                      "flighttime", "20.0"
                      "interceptor", "1.0"
                      "metalpershot", "150.0"
                      "model", "fmdmissile.s3o"
                      "smokecolor", "0.7"
                      "smokeperiod", "9.0"
                      "smokesize", "27.0"
                      "smoketime", "110.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "true"
                      "soundhitwet", "splslrg"
                      "stockpile", "true"
                      "stockpiletime", "90.0"
                      "texture1", "bluenovaexplo"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "tracks", "true"
                      "turnrate", "10000.0"
                      "weaponacceleration", "150.0"
                      "weapontimer", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -0.208756103516 6.21000671387"
                  collisionVolumeScales = Some "55.2154541016 21.362487793 50.6700134277"
                  collisionVolumeType = Some "Box"
                  damage = Some 600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 934.0
                  object_ = Some "Units/armscab_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 374.0
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
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "antinuke"
            ]
          extras = Map.ofList [
                "canattack", "false"
                "damagemodifier", "0.5"
                "movestate", "0.0"
                "noautofire", "true"
                "nochasecategory", "ALL"
                "radardistance", "50.0"
            ] }

    type Armsnipe =
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

    let armsnipe : Armsnipe =
        { name = "armsnipe"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 680.0
          energyCost = ValueOrExpr.Concrete 20000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 580.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 33.0
          maxAcc = 0.138
          maxDec = 0.6486
          turnRate = 1538.69995
          movementClass = "BOT2"
          maxSlope = 14.0
          maxWaterDepth = 22.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.7788
          weapons = [
                { name = "old_armsnipe_weapon"
                  displayName = Some "SniperWeapon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "commanders", 1025.0
                      "default", 2500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 900.0)
                  reloadTime = Some (ValueOrExpr.Concrete 10.0)
                  weaponVelocity = Some 3000.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.234
                  noSelfDamage = Some true
                  soundStart = Some "sniper3"
                  soundHit = Some "sniperhit"
                  explosiongenerator = Some "custom:genericshellexplosion-sniper"
                  rgbColor = Some "1 1 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.0025"
                      "energypershot", "500.0"
                      "gravityaffected", "true"
                      "impactonly", "true"
                      "intensity", "0.75"
                      "interceptedbyshieldtype", "0.0"
                      "size", "0.1"
                      "soundhitvolume", "10.0"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "20.0"
                      "thickness", "0.5"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "30 12 44"
                  collisionVolumeType = Some "Box"
                  damage = Some 400.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 322.0
                  object_ = Some "Units/armsnipe_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 20"
                  collisionVolumeType = Some "cylY"
                  damage = Some 300.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 129.0
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
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "Kaiser"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "cloakcost", "75.0"
                "cloakcostmoving", "200.0"
                "mincloakdistance", "80.0"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    type Armspid =
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

    let armspid : Armspid =
        { name = "armspid"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 250.0
          energyCost = ValueOrExpr.Concrete 5000.0
          buildTime = ValueOrExpr.Concrete 7000.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 71.55
          maxAcc = 0.207
          maxDec = 0.6486
          turnRate = 1290.29993
          movementClass = "TBOT3"
          maxWaterDepth = 16.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.749
          weapons = [
                { name = "spider"
                  displayName = Some "Close-quarters light EMP laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 850.0
                      "vtol", 225.0
                  ]
                  range = Some (ValueOrExpr.Concrete 280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.73333)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "hackshot"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-emp"
                  rgbColor = Some "0.7 0.7 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "EMPABLE"
                      "avoidfeature", "false"
                      "beamdecay", "0.5"
                      "beamtime", "0.2"
                      "beamttl", "1.0"
                      "collidefriendly", "false"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.01"
                      "impactonly", "1.0"
                      "laserflaresize", "8.8"
                      "paralyzer", "true"
                      "paralyzetime", "9.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "1.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0926513671875 -4.24316406278e-06 -0.909057617188"
                  collisionVolumeScales = Some "31.362487793 12.4340515137 31.2150268555"
                  collisionVolumeType = Some "Box"
                  damage = Some 600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 40.0
                  metal = Some 108.0
                  object_ = Some "Units/armspid_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 400.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 43.0
                  object_ = Some "Units/arm2X2A.s3o"
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
                ok = ["spider2"]
                select = ["spider"] }
          customParams = Map.ofList [
                "model_author", "Kaiser"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.2"
                "selectable_as_combat_unit", "true"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "emp"
            ]
          extras = Map.ofList [
                "autoheal", "15.0"
                "canassist", "false"
                "canrepair", "false"
                "canrestore", "false"
                "mygravity", "10000.0"
                "nochasecategory", "ALL"
                "stealth", "true"
                "strafetoattack", "true"
            ] }

    type Armsptk =
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

    let armsptk : Armsptk =
        { name = "armsptk"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 4500.0
          buildTime = ValueOrExpr.Concrete 11500.0
          health = ValueOrExpr.Concrete 1390.0
          sightDistance = ValueOrExpr.Concrete 440.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 47.0
          maxAcc = 0.207
          maxDec = 0.6486
          turnRate = 1290.0
          movementClass = "TBOT3"
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.1352
          weapons = [
                { name = "adv_rocket"
                  displayName = Some "Parabolic trajectory g2g multi-rocket launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 575.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.75)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 90.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rocksalvo"
                  soundHit = Some "rockhit3"
                  explosiongenerator = Some "custom:genericshellexplosion-small-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "cruise_max_height", "20"
                      "cruise_min_height", "15"
                      "lockon_dist", "150"
                      "projectile_destruction_method", "descend"
                      "speceffect", "cruise"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "3.0"
                      "burstrate", "0.3"
                      "castshadow", "true"
                      "cegtag", "missiletrailsmall-simple"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "3.0"
                      "model", "cormissile2.s3o"
                      "smokecolor", "0.5"
                      "smokeperiod", "7.0"
                      "smokesize", "6.5"
                      "smoketime", "21.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splssml"
                      "soundtrigger", "true"
                      "startvelocity", "80.0"
                      "targetmoveerror", "0.2"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "trajectoryheight", "0.5"
                      "turnrate", "6000.0"
                      "weaponacceleration", "70.0"
                      "weapontimer", "6.0"
                      "wobble", "2500.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.13973236084 -4.67773437585e-06 -1.37111663818"
                  collisionVolumeScales = Some "47.3038787842 18.2459106445 47.0814971924"
                  collisionVolumeType = Some "Box"
                  damage = Some 800.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 40.0
                  metal = Some 244.0
                  object_ = Some "Units/armsptk_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 98.0
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
                ok = ["spider2"]
                select = ["spider3"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.2"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "mygravity", "10000.0"
                "nochasecategory", "VTOL"
            ] }

    type Armspy =
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

    let armspy : Armspy =
        { name = "armspy"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 135.0
          energyCost = ValueOrExpr.Concrete 8800.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 300.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 65.4
          maxAcc = 0.276
          maxDec = 0.69
          turnRate = 1581.25
          movementClass = "BOT2"
          maxSlope = 32.0
          maxWaterDepth = 112.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.4388
          weapons = [
                { name = "crawl_dummy"
                  displayName = Some "Dummy Weapon"
                  weaponType = Some "Melee"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 100.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 100000.0
                  areaOfEffect = Some 0.0
                  accuracy = None
                  turret = None
                  tolerance = Some 100000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = None
                  soundStart = None
                  soundHit = None
                  explosiongenerator = Some ""
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidground", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "128.0"
                      "firesubmersed", "true"
                      "soundhitwet", "sizzle"
                      "waterweapon", "true"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.497138977051 -0.20779847168 -1.07509613037"
                  collisionVolumeScales = Some "31.7495880127 18.5738830566 32.936630249"
                  collisionVolumeType = Some "Box"
                  damage = Some 250.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 83.0
                  object_ = Some "Units/armspy_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 150.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 33.0
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
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "canassist", "false"
                "canguard", "false"
                "canrepair", "false"
                "canrestore", "false"
                "cloakcost", "15.0"
                "cloakcostmoving", "40.0"
                "mincloakdistance", "75.0"
                "movestate", "0.0"
                "onoffable", "false"
                "selfdestructcountdown", "0.0"
                "sonarstealth", "true"
                "stealth", "true"
                "upright", "true"
            ] }

    type Armvader =
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

    let armvader : Armvader =
        { name = "armvader"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 65.0
          energyCost = ValueOrExpr.Concrete 5800.0
          buildTime = ValueOrExpr.Concrete 8000.0
          health = ValueOrExpr.Concrete 445.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 84.0
          maxAcc = 0.1518
          maxDec = 0.5589
          turnRate = 1771.0
          movementClass = "ABOTBOMB2"
          maxSlope = 32.0
          maxWaterDepth = 112.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.848
          weapons = [
                { name = "crawl_dummy"
                  displayName = Some "Crawlingbomb Dummy Weapon"
                  weaponType = Some "Melee"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 42.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 100000.0
                  areaOfEffect = Some 0.0
                  accuracy = None
                  turret = None
                  tolerance = Some 100000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = None
                  soundStart = None
                  soundHit = None
                  explosiongenerator = Some ""
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidground", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "128.0"
                      "firesubmersed", "true"
                      "soundhitwet", "sizzle"
                      "waterweapon", "true"
                  ] }
                { name = "crawl_detonator"
                  displayName = Some "Self-destruction"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "crawlingbombs", 1000.0
                      "default", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 5.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = None
                  soundStart = None
                  soundHit = None
                  explosiongenerator = Some ""
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "true"
                      "gravityaffected", "true"
                      "soundhitwet", "splshbig"
                  ] }
            ]
          featureDefs = Map.ofList [
                "corpse",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 300.0
                  featureDead = Some "HEAP"
                  footprintX = Some 1.0
                  footprintZ = Some 1.0
                  height = Some 20.0
                  metal = Some 49.0
                  object_ = Some "Units/armvader_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "21.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 200.0
                  featureDead = None
                  footprintX = Some 1.0
                  footprintZ = Some 1.0
                  height = Some 4.0
                  metal = Some 12.0
                  object_ = Some "Units/arm1X1B.s3o"
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
                ok = ["servsml5"]
                select = ["servsml5"] }
          customParams = Map.ofList [
                "instantselfd", "true"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "explo"
            ]
          extras = Map.ofList [
                "firestate", "0.0"
                "mass", "749.0"
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "0.0"
            ] }

    type Armzeus =
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

    let armzeus : Armzeus =
        { name = "armzeus"
          subfolder = "ArmBots/T2"
          metalCost = ValueOrExpr.Concrete 350.0
          energyCost = ValueOrExpr.Concrete 6100.0
          buildTime = ValueOrExpr.Concrete 9500.0
          health = ValueOrExpr.Concrete 2950.0
          sightDistance = ValueOrExpr.Concrete 331.5
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 47.4
          maxAcc = 0.138
          maxDec = 0.8625
          turnRate = 1214.40002
          movementClass = "BOT3"
          maxSlope = 15.0
          maxWaterDepth = 23.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.0428
          weapons = [
                { name = "lightning"
                  displayName = Some "Close-quarters g2g lightning rifle"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "default", 22.0
                  ]
                  range = Some (ValueOrExpr.Concrete 280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.7)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lghthvy1"
                  soundHit = Some "xplomed3"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                  rgbColor = Some "0.5 0.5 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "spark_ceg", "genericshellexplosion-splash-lightning"
                      "spark_forkdamage", "0.33"
                      "spark_maxunits", "2"
                      "spark_range", "60"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamttl", "1.0"
                      "burst", "10.0"
                      "burstrate", "0.03333"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "1.0"
                      "energypershot", "10.0"
                      "firestarter", "50.0"
                      "impactonly", "1.0"
                      "intensity", "24.0"
                      "laserflaresize", "5.0"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "true"
                      "thickness", "1.5"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "39.0425720215 11.3397369385 32.5729980469"
                  collisionVolumeType = Some "Box"
                  damage = Some 1300.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 214.0
                  object_ = Some "Units/armzeus_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 800.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 86.0
                  object_ = Some "Units/arm2X2E.s3o"
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
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm, FLaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

