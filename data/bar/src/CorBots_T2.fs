// Auto-generated BAR unit data: CorBots/T2 (flat per-unit types)
namespace BarData.Units

open BarData

module CorBots_T2 =

    type Coraak =
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
          turnInPlaceSpeedLimit: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let coraak : Coraak =
        { name = "coraak"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 650.0
          energyCost = ValueOrExpr.Concrete 6200.0
          buildTime = ValueOrExpr.Concrete 11000.0
          health = ValueOrExpr.Concrete 3200.0
          sightDistance = ValueOrExpr.Concrete 390.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 34.5
          maxAcc = 0.138
          maxDec = 0.6486
          turnRate = 1048.79993
          movementClass = "ABOT3"
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.759
          weapons = [
                { name = "coraabot_missile1"
                  displayName = Some "Missiles"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 250.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.6)
                  weaponVelocity = Some 825.0
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
                      "mount_badtargetcategory", "LIGHTAIRSCOUT"
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
                      "flighttime", "1.9"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smokecolor", "0.5"
                      "smokeperiod", "6.0"
                      "smokesize", "6.0"
                      "smoketime", "12.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitvolume", "7.5"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "7.5"
                      "startvelocity", "640.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "30000.0"
                      "weaponacceleration", "141.0"
                      "weapontimer", "5.0"
                  ] }
                { name = "botflak"
                  displayName = Some "Heavy g2a flak cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "vtol", 300.0
                  ]
                  range = Some (ValueOrExpr.Concrete 775.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.5)
                  weaponVelocity = Some 1550.0
                  areaOfEffect = Some 140.0
                  accuracy = Some 1000.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "flakfire"
                  soundHit = Some "flakhit"
                  explosiongenerator = Some "custom:flak"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "flaktrailaa"
                      "craterareaofeffect", "140.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "2.0"
                      "mygravity", "0.01"
                      "soundhitwet", "splsmed"
                      "stages", "0.0"
                      "weapontimer", "1.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "1.21222686768 -2.24119818115 -5.60705566406"
                  collisionVolumeScales = Some "38.4586334229 17.0406036377 34.7582092285"
                  collisionVolumeType = Some "Box"
                  damage = Some 1548.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 15.0
                  metal = Some 395.0
                  object_ = Some "Units/coraak_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 774.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 158.0
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "1200.0"
                "movestate", "0.0"
                "nochasecategory", "NOTAIR"
                "upright", "true"
            ] }

    type Corack =
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

    let corack : Corack =
        { name = "corack"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 470.0
          energyCost = ValueOrExpr.Concrete 6900.0
          buildTime = ValueOrExpr.Concrete 12500.0
          health = ValueOrExpr.Concrete 1000.0
          sightDistance = ValueOrExpr.Concrete 318.5
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 33.0
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
          workerTime = ValueOrExpr.Concrete 220.0
          buildDistance = 136.0
          buildOptions = ["corfus"; "corafus"; "corgant"; "corageo"; "corbhmth"; "cormoho"; "cormexp"; "cormmkr"; "coruwadves"; "coruwadvms"; "corarad"; "corshroud"; "corfort"; "cortarg"; "corsd"; "corgate"; "cortoast"; "corvipe"; "cordoom"; "corflak"; "corscreamer"; "cortron"; "corfmd"; "corsilo"; "corint"; "corbuzz"; "corlab"; "coralab"]
          terraformSpeed = 900.0
          energyMake = ValueOrExpr.Concrete 14.0
          energyStorage = 100.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -1.11450195313e-05 -6.82949829102"
                  collisionVolumeScales = Some "22.0 23.11277771 24.3265991211"
                  collisionVolumeType = Some "Box"
                  damage = Some 800.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 207.0
                  object_ = Some "Units/corack_dead.s3o"
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
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
                "upright", "true"
            ] }

    type Coramph =
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

    let coramph : Coramph =
        { name = "coramph"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 330.0
          energyCost = ValueOrExpr.Concrete 9500.0
          buildTime = ValueOrExpr.Concrete 12500.0
          health = ValueOrExpr.Concrete 2350.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 55.5
          maxAcc = 0.1035
          maxDec = 0.6486
          turnRate = 1147.69995
          movementClass = "ABOT3"
          maxSlope = 14.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.221
          weapons = [
                { name = "coramph_weapon1"
                  displayName = Some "Torpedo"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 250.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 6.0)
                  weaponVelocity = Some 135.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep2"
                  explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTHOVER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "model", "cortorpedo.s3o"
                      "predictboost", "0.0"
                      "startvelocity", "75.0"
                      "turnrate", "1700.0"
                      "waterweapon", "true"
                      "weaponacceleration", "20.0"
                      "weapontimer", "3.0"
                  ] }
                { name = "coramph_weapon2"
                  displayName = Some "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 150.0
                      "vtol", 38.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.13333)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrhvy3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0 1 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.15"
                      "corethickness", "0.16"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "35.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "7.7"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.4"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -7.5 0"
                  collisionVolumeScales = Some "32 29 32"
                  collisionVolumeType = Some "CylY"
                  damage = Some 1056.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 152.0
                  object_ = Some "Units/coramph_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 920.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 114.0
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weaponsub"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "radardistance", "300.0"
                "sonardistance", "300.0"
                "sonarstealth", "false"
                "upright", "true"
            ] }

    type Corcan =
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

    let corcan : Corcan =
        { name = "corcan"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 560.0
          energyCost = ValueOrExpr.Concrete 9300.0
          buildTime = ValueOrExpr.Concrete 15000.0
          health = ValueOrExpr.Concrete 5940.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.138
          maxDec = 0.6486
          turnRate = 1115.5
          movementClass = "BOT2"
          maxSlope = 14.0
          maxWaterDepth = 21.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.825
          weapons = [
                { name = "cor_canlaser"
                  displayName = Some "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 275.0
                      "vtol", 25.0
                  ]
                  range = Some (ValueOrExpr.Concrete 275.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.8)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrhvy3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0.027 0.40 0.027"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.16"
                      "beamttl", "2.4"
                      "corethickness", "0.21"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "45.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.9 1 0.9"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "4.0"
                  ] }
                { name = "canhvylaserroar"
                  displayName = Some "Laserroar"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = None
                  reloadTime = None
                  weaponVelocity = None
                  areaOfEffect = Some 0.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = None
                  impulseFactor = None
                  noSelfDamage = Some true
                  soundStart = None
                  soundHit = None
                  explosiongenerator = None
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "impactonly", "1.0"
                      "soundhitdry", ""
                      "soundhitdryvolume", "16.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.220962524414 -3.57609763184 -0.162803649902"
                  collisionVolumeScales = Some "39.2589111328 21.1636047363 24.3341522217"
                  collisionVolumeType = Some "Box"
                  damage = Some 3500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 339.0
                  object_ = Some "Units/corcan_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 2500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 136.0
                  object_ = Some "Units/cor2X2F.s3o"
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
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    type Cordecom =
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

    let cordecom : Cordecom =
        { name = "cordecom"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 13000.0
          buildTime = ValueOrExpr.Concrete 33000.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1133.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 300.0
          buildDistance = 145.0
          buildOptions = ["cormine1"; "cormine2"; "cormine3"; "corsolar"; "corwin"; "cormstor"; "corestor"; "cormex"; "cormakr"; "corrad"; "corllt"; "corrl"; "cortide"; "coruwms"; "coruwes"; "corfmkr"]
          terraformSpeed = 750.0
          energyMake = ValueOrExpr.Concrete 15.0
          energyStorage = 50.0
          weapons = [
                { name = "armcomlaser"
                  displayName = Some "J7Laser"
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
                      "corethickness", "0.1"
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
                  displayName = Some "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "default", 40.0
                  ]
                  range = Some (ValueOrExpr.Concrete 262.0)
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
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture2"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["kcormov"]
                select = ["kccorsel"] }
          customParams = Map.ofList [
                "decoyfor", "corcom"
                "isdecoycommander", "true"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", "CorBots/T2"
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
                "decoyfor", "corcom"
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

    type Corfast =
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

    let corfast : Corfast =
        { name = "corfast"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 210.0
          energyCost = ValueOrExpr.Concrete 3800.0
          buildTime = ValueOrExpr.Concrete 8000.0
          health = ValueOrExpr.Concrete 830.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 90.0
          maxAcc = 0.23
          maxDec = 1.725
          turnRate = 1391.5
          movementClass = "BOT2"
          maxSlope = 17.0
          maxWaterDepth = 22.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.98
          workerTime = ValueOrExpr.Concrete 125.0
          buildDistance = 136.0
          buildOptions = ["corsolar"; "cormex"; "corlab"; "cornanotc"; "coreyes"; "corshroud"; "corfort"; "corarad"; "cormine2"; "cordl"; "corhllt"; "cortoast"; "cormadsam"; "corflak"; "corck"; "corak"; "corcrash"; "cormando"; "corpyro"; "coramph"; "corcs"; "corroy"; "cortermite"]
          terraformSpeed = 750.0
          energyMake = ValueOrExpr.Concrete 15.0
          energyStorage = 100.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "2.70434570313 -0.526537158203 -1.280418396"
                  collisionVolumeScales = Some "37.4086914063 20.6713256836 39.1832122803"
                  collisionVolumeType = Some "Box"
                  damage = Some 600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 125.0
                  object_ = Some "Units/corfast_dead.s3o"
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
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "upright", "true"
            ] }

    type Corhack =
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

    let corhack : Corhack =
        { name = "corhack"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 1260.0
          energyCost = ValueOrExpr.Concrete 22800.0
          buildTime = ValueOrExpr.Concrete 42000.0
          health = ValueOrExpr.Concrete 1830.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 85.0
          maxAcc = 0.23
          maxDec = 1.725
          turnRate = 1391.5
          movementClass = "BOT3"
          maxSlope = 17.0
          maxWaterDepth = 22.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.98
          workerTime = ValueOrExpr.Concrete 550.0
          buildDistance = 136.0
          buildOptions = ["corafus"; "corfus"; "corageo"; "corbhmth"; "cormoho"; "cormexp"; "cormmkr"; "coruwadves"; "coruwadvms"; "corfort"; "cortarg"; "corgate"; "cortoast"; "corvipe"; "cordoom"; "corflak"; "corscreamer"; "cortron"; "corfmd"; "corsilo"; "corint"; "corbuzz"; "coralab"; "corhalab"; "corjugg"; "corkorg"; "corsy"; "corap"; "corvp"; "corlab"; "corgant"; "corsd"]
          terraformSpeed = 750.0
          energyMake = ValueOrExpr.Concrete 15.0
          energyStorage = 100.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "2.70434570313 -0.526537158203 -1.280418396"
                  collisionVolumeScales = Some "37.4086914063 20.6713256836 39.1832122803"
                  collisionVolumeType = Some "Box"
                  damage = Some 600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 125.0
                  object_ = Some "Units/corfast_dead.s3o"
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
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "3.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "mass", "2700.0"
                "upright", "true"
            ] }

    type Corhrk =
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

    let corhrk : Corhrk =
        { name = "corhrk"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 600.0
          energyCost = ValueOrExpr.Concrete 5800.0
          buildTime = ValueOrExpr.Concrete 9500.0
          health = ValueOrExpr.Concrete 610.0
          sightDistance = ValueOrExpr.Concrete 370.5
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 54.0
          maxAcc = 0.1265
          maxDec = 0.6486
          turnRate = 1268.44995
          movementClass = "BOT3"
          maxSlope = 14.0
          maxWaterDepth = 21.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.188
          weapons = [
                { name = "corhrk_rocket"
                  displayName = Some "HeavyRockets"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 800.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1210.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 70.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.61
                  impulseFactor = Some 0.8
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
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
                      "cegtag", "missiletrailmedium-starburst"
                      "craterareaofeffect", "70.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "99.0"
                      "metalpershot", "0.0"
                      "model", "corkbmissl1.s3o"
                      "smokecolor", "0.7"
                      "smokeperiod", "8.0"
                      "smokesize", "12.0"
                      "smoketime", "30.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "true"
                      "soundhitwet", "splssml"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "15000.0"
                      "weaponacceleration", "100.0"
                      "weapontimer", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.59033203125 -0.11500802002 -0.125"
                  collisionVolumeScales = Some "31.73046875 27.05418396 31.9737854004"
                  collisionVolumeType = Some "Box"
                  damage = Some 450.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 194.0
                  object_ = Some "Units/corhrk_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 350.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 78.0
                  object_ = Some "Units/cor2X2B.s3o"
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
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "movestate", "0.0"
                "nochasecategory", "VTOL"
                "separationdistance", "8.0"
                "upright", "true"
                "usepiececollisionvolumes", "1.0"
            ] }

    type Cormando =
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
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          energyMake: ValueOrExpr<float>
          energyStorage: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cormando : Cormando =
        { name = "cormando"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 1200.0
          energyCost = ValueOrExpr.Concrete 15500.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 1560.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 75.0
          maxAcc = 0.4025
          maxDec = 1.725
          turnRate = 1168.40002
          movementClass = "ABOT3"
          maxSlope = 20.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.65
          workerTime = ValueOrExpr.Concrete 200.0
          buildDistance = 275.0
          buildOptions = ["corvalk"; "corfink"; "cormine2"; "cormaw"; "cordrag"; "coreyes"; "corjamt"]
          energyMake = ValueOrExpr.Concrete 10.0
          energyStorage = 20.0
          weapons = [
                { name = "commando_blaster"
                  displayName = Some "CommandoBlaster"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.5)
                  weaponVelocity = Some 930.0
                  areaOfEffect = Some 70.0
                  accuracy = Some 120.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir5"
                  soundHit = Some "xplosml5"
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "0.85,0.3,0.2"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "craterareaofeffect", "70.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "gravityaffected", "true"
                      "predictboost", "0.5"
                      "proximitypriority", "-1.0"
                      "soundhitwet", "sizzle"
                  ] }
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
                "fall_damage_multiplier", "0.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "paratrooper", "true"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
                "water_fall_damage_multiplier", "0.0"
            ]
          extras = Map.ofList [
                "autoheal", "9.0"
                "canassist", "true"
                "canreclaim", "true"
                "canrepair", "true"
                "canrestore", "false"
                "mass", "750.0"
                "nochasecategory", "VTOL"
                "radardistance", "900.0"
                "radardistancejam", "150.0"
                "upright", "true"
            ] }

    type Cormort =
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

    let cormort : Cormort =
        { name = "cormort"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 2800.0
          buildTime = ValueOrExpr.Concrete 7000.0
          health = ValueOrExpr.Concrete 940.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 50.4
          maxAcc = 0.1518
          maxDec = 0.77625
          turnRate = 1263.84998
          movementClass = "BOT2"
          maxSlope = 14.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.1352
          weapons = [
                { name = "cor_mort"
                  displayName = Some "PlasmaCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 105.0
                      "vtol", 14.0
                  ]
                  range = Some (ValueOrExpr.Concrete 850.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.6)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 36.0
                  accuracy = Some 100.0
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
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "cegtag", "arty-fast"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splshbig"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-2.46048736572 -3.00319400146 6.99045562744"
                  collisionVolumeScales = Some "41.948348999 14.0481719971 51.4421844482"
                  collisionVolumeType = Some "Box"
                  damage = Some 600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 118.0
                  object_ = Some "Units/cormort_dead.s3o"
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
                  metal = Some 47.0
                  object_ = Some "Units/cor2X2A.s3o"
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
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm, Flaka"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "movestate", "0.0"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    type Corpyro =
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

    let corpyro : Corpyro =
        { name = "corpyro"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 6500.0
          health = ValueOrExpr.Concrete 1060.0
          sightDistance = ValueOrExpr.Concrete 318.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 82.5
          maxAcc = 0.5175
          maxDec = 2.2425
          turnRate = 1316.75
          movementClass = "BOT2"
          maxSlope = 17.0
          maxWaterDepth = 25.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.815
          weapons = [
                { name = "flamethrower"
                  displayName = Some "FlameThrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 16.5
                      "subs", 5.5
                  ]
                  range = Some (ValueOrExpr.Concrete 230.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.1)
                  weaponVelocity = Some 265.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 2500.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "flamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:burnblack"
                  rgbColor = Some "1 0.94 0.88"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "bouncerebound", "0.8"
                      "bounceslip", "1.0"
                      "burst", "16.0"
                      "burstrate", "0.05"
                      "cegtag", "burnflame-anim"
                      "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flamegfxtime", "1.0"
                      "intensity", "0.6"
                      "rgbcolor2", "0.9 0.84 0.8"
                      "sizegrowth", "0.8"
                      "soundhitdry", "flamhit1"
                      "soundhitvolume", "7.5"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "5.3"
                      "soundtrigger", "false"
                      "sprayangle", "100.0"
                      "weapontimer", "1.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 650.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 124.0
                  object_ = Some "Units/cor2X2C.s3o"
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
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith, PtaQ"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "1.0"
                "strafetoattack", "true"
                "upright", "true"
            ] }

    type Corroach =
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
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corroach : Corroach =
        { name = "corroach"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 69.0
          energyCost = ValueOrExpr.Concrete 5800.0
          buildTime = ValueOrExpr.Concrete 8000.0
          health = ValueOrExpr.Concrete 620.0
          sightDistance = ValueOrExpr.Concrete 260.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 76.0
          maxAcc = 0.138
          maxDec = 0.5175
          turnRate = 1733.04993
          movementClass = "ABOTBOMB2"
          maxSlope = 32.0
          maxWaterDepth = 112.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.782
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
                      "default", 0.0
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
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["servsml6"]
                select = ["servsml6"] }
          customParams = Map.ofList [
                "instantselfd", "true"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "explo"
            ]
          extras = Map.ofList [
                "firestate", "0.0"
                "mass", "749.0"
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "0.0"
            ] }

    type Corsack =
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

    let corsack : Corsack =
        { name = "corsack"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 6900.0
          buildTime = ValueOrExpr.Concrete 12500.0
          health = ValueOrExpr.Concrete 1000.0
          sightDistance = ValueOrExpr.Concrete 318.5
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 33.0
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
          workerTime = ValueOrExpr.Concrete 190.0
          buildDistance = 136.0
          buildOptions = ["corafus"; "corageo"; "cormexp"; "cormmkr"; "cortoast"; "cordoom"; "corscreamer"; "corsilo"; "corint"; "corbuzz"; "corlab"; "coralab"; "corsalab"; "corgant"]
          terraformSpeed = 900.0
          energyMake = ValueOrExpr.Concrete 14.0
          energyStorage = 100.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -1.11450195313e-05 -6.82949829102"
                  collisionVolumeScales = Some "22.0 23.11277771 24.3265991211"
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
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
                "upright", "true"
            ] }

    type Corsktl =
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
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corsktl : Corsktl =
        { name = "corsktl"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 755.0
          energyCost = ValueOrExpr.Concrete 27000.0
          buildTime = ValueOrExpr.Concrete 23000.0
          health = ValueOrExpr.Concrete 355.0
          sightDistance = ValueOrExpr.Concrete 260.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 84.0
          maxAcc = 0.138
          maxDec = 0.6486
          turnRate = 1290.29993
          movementClass = "ABOTBOMB2"
          maxSlope = 255.0
          maxWaterDepth = 30.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.155
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
                  displayName = Some "Mine Detonator"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "crawlingbombs", 1000.0
                      "default", 0.0
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
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["servsml6"]
                select = ["servsml6"] }
          customParams = Map.ofList [
                "instantselfd", "true"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "explo"
            ]
          extras = Map.ofList [
                "cloakcost", "15.0"
                "cloakcostmoving", "40.0"
                "firestate", "0.0"
                "mincloakdistance", "60.0"
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "0.0"
                "upright", "true"
            ] }

    type Corspec =
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

    let corspec : Corspec =
        { name = "corspec"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 75.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 6500.0
          health = ValueOrExpr.Concrete 345.0
          sightDistance = ValueOrExpr.Concrete 250.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 39.0
          maxAcc = 0.115
          maxDec = 0.414
          turnRate = 1086.75
          movementClass = "BOT2"
          maxSlope = 32.0
          maxWaterDepth = 112.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.858
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.340003967285 0.0 -2.33979034424"
                  collisionVolumeScales = Some "23.679977417 24.5 24.0577850342"
                  collisionVolumeType = Some "Box"
                  damage = Some 300.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 56.0
                  object_ = Some "Units/corspec_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 248.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 28.0
                  object_ = Some "Units/cor2X2B.s3o"
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
                ok = ["kbcormov"]
                select = ["radjam2"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "off_on_stun", "true"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "canattack", "false"
                "energyupkeep", "80.0"
                "movestate", "0.0"
                "nochasecategory", "MOBILE"
                "onoffable", "true"
                "radardistance", "0.0"
                "radardistancejam", "450.0"
                "upright", "true"
            ] }

    type Corspy =
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

    let corspy : Corspy =
        { name = "corspy"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 165.0
          energyCost = ValueOrExpr.Concrete 12500.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 380.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 62.099
          maxAcc = 0.276
          maxDec = 0.60375
          turnRate = 1518.0
          movementClass = "BOT2"
          maxSlope = 32.0
          maxWaterDepth = 112.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.3662
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
                  collisionVolumeOffsets = Some "1.62395477295 -0.0601244018555 -0.106101989746"
                  collisionVolumeScales = Some "35.1202545166 24.5693511963 34.7390899658"
                  collisionVolumeType = Some "Box"
                  damage = Some 250.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 101.0
                  object_ = Some "Units/corspy_dead.s3o"
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
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 40.0
                  object_ = Some "Units/cor1X1A.s3o"
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
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", "CorBots/T2"
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

    type Corsumo =
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

    let corsumo : Corsumo =
        { name = "corsumo"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 2200.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 65000.0
          health = ValueOrExpr.Concrete 15600.0
          sightDistance = ValueOrExpr.Concrete 510.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 22.5
          maxAcc = 0.0552
          maxDec = 0.43125
          turnRate = 368.0
          movementClass = "HBOT4"
          maxSlope = 15.0
          maxWaterDepth = 23.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.495
          weapons = [
                { name = "corsumo_weapon"
                  displayName = Some "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 302.0
                      "vtol", 71.0
                  ]
                  range = Some (ValueOrExpr.Concrete 650.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.6)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrhvy3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-green"
                  rgbColor = Some "0.027 0.40 0.027"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.19"
                      "beamttl", "2.8"
                      "corethickness", "0.22"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "75.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "6.2"
                      "rgbcolor2", "0.9 1 0.9"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "4.6"
                  ] }
                { name = "sumohvylaserroar"
                  displayName = Some "Laserroar"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = None
                  reloadTime = None
                  weaponVelocity = None
                  areaOfEffect = Some 0.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = None
                  impulseFactor = None
                  noSelfDamage = Some true
                  soundStart = None
                  soundHit = None
                  explosiongenerator = None
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "impactonly", "1.0"
                      "soundhitdry", ""
                      "soundhitdryvolume", "17.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -8 1.8"
                  collisionVolumeScales = Some "44.2 41.0 49.1"
                  collisionVolumeType = Some "Box"
                  damage = Some 8400.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 1118.0
                  object_ = Some "Units/corsumo_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4200.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 447.0
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
                ok = ["kbcormov"]
                select = ["kbcorsel"] }
          customParams = Map.ofList [
                "model_author", "Tharsis"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "1.0"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "usepiececollisionvolumes", "1.0"
            ] }

    type Cortermite =
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

    let cortermite : Cortermite =
        { name = "cortermite"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 540.0
          energyCost = ValueOrExpr.Concrete 8100.0
          buildTime = ValueOrExpr.Concrete 17000.0
          health = ValueOrExpr.Concrete 3100.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 50.0
          maxAcc = 0.19665
          maxDec = 0.60375
          turnRate = 1214.40002
          movementClass = "TBOT3"
          maxSlope = 50.0
          maxWaterDepth = 30.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.0626
          weapons = [
                { name = "cor_termite_laser"
                  displayName = Some "HeatRay"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 265.0
                      "subs", 5.0
                      "vtol", 55.0
                  ]
                  range = Some (ValueOrExpr.Concrete 340.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.8)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 42.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-yellow"
                  rgbColor = Some "1 0.8 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "beamtime", "0.55"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "60.0"
                      "firestarter", "90.0"
                      "laserflaresize", "4.95"
                      "rgbcolor2", "0.8 0 0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.6"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -1.2 0"
                  collisionVolumeScales = Some "26 12 43"
                  collisionVolumeType = Some "Box"
                  damage = Some 2000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 10.0
                  metal = Some 523.0
                  object_ = Some "Units/cortermite_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = None
                  metal = Some 209.0
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
                ok = ["spider2"]
                select = ["spider"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.2"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "mygravity", "10000.0"
                "nochasecategory", "VTOL"
                "strafetoattack", "true"
                "usepiececollisionvolumes", "1.0"
            ] }

    type Corvoyr =
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

    let corvoyr : Corvoyr =
        { name = "corvoyr"
          subfolder = "CorBots/T2"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 1350.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 390.0
          sightDistance = ValueOrExpr.Concrete 925.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 45.0
          maxAcc = 0.05635
          maxDec = 0.05175
          turnRate = 670.45001
          movementClass = "BOT2"
          maxSlope = 16.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.99
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.170890808105 0.277459492187 0.523490905762"
                  collisionVolumeScales = Some "36.3329315186 19.9079589844 23.0387420654"
                  collisionVolumeType = Some "Box"
                  damage = Some 300.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 60.0
                  object_ = Some "Units/corvoyr_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 250.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 24.0
                  object_ = Some "Units/cor2X2A.s3o"
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
                ok = ["kbcormov"]
                select = ["ckradsel"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "canattack", "false"
                "movestate", "0.0"
                "onoffable", "false"
                "radardistance", "2200.0"
            ] }

