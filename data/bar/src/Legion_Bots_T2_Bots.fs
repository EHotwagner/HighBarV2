// Auto-generated BAR unit data: Legion/Bots/T2 Bots (flat per-unit types)
namespace BarData.Units

open BarData

module Legion_Bots_T2_Bots =

    type Legadvaabot =
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

    let legadvaabot : Legadvaabot =
        { name = "legadvaabot"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 6650.0
          buildTime = ValueOrExpr.Concrete 11270.0
          health = ValueOrExpr.Concrete 1200.0
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
                { name = "leg_t2_microflak_mobile"
                  displayName = Some "Rotary Microflak Cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "vtol", 40.0
                  ]
                  range = Some (ValueOrExpr.Concrete 650.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.237)
                  weaponVelocity = Some 1900.0
                  areaOfEffect = Some 35.0
                  accuracy = Some 1000.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "flakfire"
                  soundHit = Some "flakhit"
                  explosiongenerator = Some "custom:flakshard"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "LIGHTAIRSCOUT"
                      "mount_burstcontrolwhenoutofarc", "2.0"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "VTOL"
                      "burst", "3.0"
                      "burstrate", "0.02"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "flaktrailaamg"
                      "craterareaofeffect", "35.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "collidefriendly", "false"
                      "gravityaffected", "true"
                      "size", "0.0"
                      "sizedecay", "0.08"
                      "soundhitwet", "splsmed"
                      "stages", "0.0"
                      "weapontimer", "1.0"
                  ] }
                { name = "aa_railgun"
                  displayName = Some "Light Anti-Air Railgun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 1.0
                      "vtol", 225.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1050.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.0)
                  weaponVelocity = Some 3214.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "lancefire"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "0.94 0.4 0.94"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "mount_slaveto", "1.0"
                      "avoidfeature", "true"
                      "burnblow", "true"
                      "cegtag", "railgun"
                      "collisionsize", "0.7"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.12"
                      "firestarter", "0.0"
                      "hardstop", "true"
                      "impactonly", "true"
                      "intensity", "0.8"
                      "noexplode", "true"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "25.0"
                      "thickness", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "37 19 30"
                  collisionVolumeType = Some "Box"
                  damage = Some 1548.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 15.0
                  metal = Some 395.0
                  object_ = Some "Units/legadvaabot_dead.s3o"
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
                "model_author", "Johnathan Crimson"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Bots/T2 Bots"
                "techlevel", "2.0"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "850.0"
                "movestate", "0.0"
                "nochasecategory", "NOTAIR"
                "upright", "true"
            ] }

    type Legajamk =
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

    let legajamk : Legajamk =
        { name = "legajamk"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 75.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 6280.0
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
                  collisionVolumeOffsets = Some "0.0 0.0 0.0"
                  collisionVolumeScales = Some "24.0 24.0 24.0"
                  collisionVolumeType = Some "Box"
                  damage = Some 300.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 56.0
                  object_ = Some "Units/legajamk_dead.s3o"
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
                "model_author", "Tharsis, ZephyrSkies(helper)"
                "normaltex", "unittextures/leg_normal.dds"
                "off_on_stun", "true"
                "subfolder", "Legion/Bots/T2"
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
                "upright", "false"
            ] }

    type Legamph =
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

    let legamph : Legamph =
        { name = "legamph"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 600.0
          energyCost = ValueOrExpr.Concrete 13200.0
          buildTime = ValueOrExpr.Concrete 16980.0
          health = ValueOrExpr.Concrete 2750.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 48.0
          maxAcc = 0.1035
          maxDec = 0.6486
          turnRate = 450.0
          movementClass = "HABOT5"
          maxSlope = 14.0
          canMove = true
          turnInPlace = false
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.221
          weapons = [
                { name = "heat_ray"
                  displayName = Some "Heavy g2g Cleansing Heat Ray"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 33.0
                      "vtol", 10.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.033)
                  weaponVelocity = Some 950.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray3burn"
                  soundHit = None
                  explosiongenerator = Some "custom:heatray-large"
                  rgbColor = Some "1 0.5 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "mount_burstControlWhenOutOfArc", "2.0"
                      "mount_maxangledif", "180.0"
                      "mount_maindir", "0 0 1"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "beamtime", "0.033"
                      "corethickness", "0.5"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "10.0"
                      "firestarter", "30.0"
                      "firetolerance", "500.0"
                      "laserflaresize", "6.0"
                      "predictboost", "0.3"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.8 1.0 0.3"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "thickness", "4.0"
                  ] }
                { name = "coax_depthcharge"
                  displayName = Some "Depthcharge launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 350.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 32.0
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
                      "avoidground", "false"
                      "bouncerebound", "0.6"
                      "bounceslip", "0.6"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "false"
                      "firetolerance", "100.0"
                      "flighttime", "1.75"
                      "gravityaffected", "true"
                      "groundbounce", "true"
                      "model", "legbasictorpedo.s3o"
                      "mygravity", "0.2"
                      "numbounce", "1.0"
                      "soundhitvolume", "3.0"
                      "soundhitwet", "splsmed"
                      "soundhitwetvolume", "12.0"
                      "startvelocity", "190.0"
                      "tracks", "true"
                      "trajectoryheight", "0.4"
                      "turnrate", "64000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "75.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "32 29 52"
                  collisionVolumeType = Some "Box"
                  damage = Some 1056.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 330.0
                  object_ = Some "Units/legamph_dead.s3o"
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
                  metal = Some 115.0
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
                "maxrange", "400.0"
                "model_author", "Johanthan Crimson, Tuerk"
                "normaltex", "unittextures/leg_normal.dds"
                "paralyzemultiplier", "0.2"
                "subfolder", "Legion/T2"
                "techlevel", "2.0"
                "unitgroup", "weaponsub"
                "speedfactorinwater", "1.3"
                "speedfactoratdepth", "10.0"
                "reactive_armor_health", "750.0"
                "reactive_armor_restore", "17.0"
            ]
          extras = Map.ofList [
                "brakerate", "0.5"
                "damagemodifier", "0.5"
                "nochasecategory", "VTOL"
                "sonardistance", "700.0"
                "sonarstealth", "false"
                "upright", "false"
            ] }

    type Legaradk =
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

    let legaradk : Legaradk =
        { name = "legaradk"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 1350.0
          buildTime = ValueOrExpr.Concrete 4700.0
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
                  collisionVolumeOffsets = Some "0.0 0.0 0.0"
                  collisionVolumeScales = Some "35.0 20.0 24.0"
                  collisionVolumeType = Some "Box"
                  damage = Some 300.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 60.0
                  object_ = Some "Units/legaradk_dead.s3o"
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
                "model_author", "Tharsis, ZephyrSkies(helper)"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Bots/T2"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "canattack", "false"
                "movestate", "0.0"
                "onoffable", "false"
                "radardistance", "2200.0"
                "upright", "false"
            ] }

    type Legaspy =
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

    let legaspy : Legaspy =
        { name = "legaspy"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 8500.0
          buildTime = ValueOrExpr.Concrete 12900.0
          health = ValueOrExpr.Concrete 300.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 62.5
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
                  displayName = Some "coconut.jpg"
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
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "27 27 20"
                  collisionVolumeType = Some "Box"
                  damage = Some 250.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 83.0
                  object_ = Some "Units/legaspy_dead.s3o"
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
                "model_author", "ZephyrSkies (model), Phill-Arts (Concept Art)"
                "normaltex", "unittextures/leg_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", "Legion/Bots/T2"
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

    type Legbart =
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

    let legbart : Legbart =
        { name = "legbart"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 550.0
          energyCost = ValueOrExpr.Concrete 5500.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 1780.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 60.0
          maxAcc = 0.1518
          maxDec = 0.77625
          turnRate = 1263.84998
          movementClass = "BOT3"
          maxSlope = 14.0
          maxWaterDepth = 12.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.1352
          weapons = [
                { name = "clusternapalm"
                  displayName = Some "Heavy Napalm Launcher"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 60.0
                      "subs", 10.0
                      "vtol", 10.0
                  ]
                  range = Some (ValueOrExpr.Concrete 625.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.0)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 150.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy2"
                  soundHit = None
                  explosiongenerator = Some "custom:fire-explosion-small"
                  rgbColor = Some "1 0.25 0.1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "area_onhit_ceg", "fire-area-75-repeat"
                      "area_onhit_damageCeg", "burnflamexl-gen"
                      "area_onhit_resistance", "fire"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "burnflame"
                      "collidefriendly", "false"
                      "colormap", "0.75 0.73 0.67 0.024   0.37 0.4 0.30 0.021   0.22 0.21 0.14 0.018  0.024 0.014 0.009 0.03   0.0 0.0 0.0 0.008"
                      "craterareaofeffect", "90.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flamegfxtime", "1.0"
                      "gravityaffected", "true"
                      "leadlimit", "0.0"
                      "projectiles", "2.0"
                      "firetolerance", "5000.0"
                      "size", "6.0"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "sprayangle", "2500.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "56 31 70"
                  collisionVolumeType = Some "Box"
                  damage = Some 600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 350.0
                  object_ = Some "Units/legbart_dead.s3o"
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
                  metal = Some 150.0
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
                "unitgroup", "weapon"
                "model_author", "ZephyrSkies (Model), Phill-Art (Concept)"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Bots/T2 Bots"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    type Legdecom =
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

    let legdecom : Legdecom =
        { name = "legdecom"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 13000.0
          buildTime = ValueOrExpr.Concrete 32600.0
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
          buildOptions = ["legmine1"; "legmine2"; "legmine3"; "legsolar"; "legwin"; "legmstor"; "legestor"; "legmex"; "legeconv"; "legrad"; "leglht"; "legrl"; "legtide"; "leguwmstore"; "leguwestore"; "legfeconv"]
          terraformSpeed = 750.0
          energyMake = ValueOrExpr.Concrete 15.0
          energyStorage = 50.0
          weapons = [
                { name = "legcomlaser"
                  displayName = Some "Close-Quarters Heatray"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 175.0
                      "subs", 25.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.8)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium"
                  rgbColor = Some "1 0.55 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamtime", "0.4"
                      "corethickness", "0.4"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "7.0"
                      "leadlimit", "0.0"
                      "rgbcolor2", "0.9 1.0 0.5"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "torpedo"
                  displayName = Some "Underwater Torpedo Launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 250.0
                      "subs", 125.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.55
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
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "burnblow", "true"
                      "cegtag", "torpedotrail-tiny"
                      "collidefriendly", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "1.8"
                      "model", "legtorpedo.s3o"
                      "predictboost", "1.0"
                      "startvelocity", "230.0"
                      "tracks", "false"
                      "turnrate", "2500.0"
                      "waterweapon", "true"
                      "weaponacceleration", "50.0"
                      "weapontimer", "3.0"
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
                { name = "aa_missile"
                  displayName = Some "Anti Air Missile Launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 150.0
                      "commanders", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.2)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 9950.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "packolau"
                  soundHit = Some "packohit"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "2.5"
                      "metalpershot", "0.0"
                      "model", "legsmallrocket.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "6.0"
                      "smoketime", "12.0"
                      "smokesize", "2.6"
                      "smokecolor", "0.95"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1200.0"
                      "weapontimer", "2.0"
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
                select = ["armcomsel"] }
          customParams = Map.ofList [
                "unitgroup", "buildert2"
                "decoyfor", "legcom"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "isdecoycommander", "true"
            ]
          extras = Map.ofList [
                "autoheal", "0.0"
                "cancapture", "true"
                "candgun", "true"
                "capturable", "false"
                "capturespeed", "900.0"
                "cloakcost", "30.0"
                "cloakcostmoving", "180.0"
                "decoyfor", "legcom"
                "hidedamage", "true"
                "holdsteady", "true"
                "mass", "4900.0"
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

    type Leghrk =
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

    let leghrk : Leghrk =
        { name = "leghrk"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 12600.0
          health = ValueOrExpr.Concrete 1200.0
          sightDistance = ValueOrExpr.Concrete 370.5
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 45.0
          maxAcc = 0.1265
          maxDec = 0.6486
          turnRate = 300.0
          movementClass = "BOT3"
          maxSlope = 14.0
          maxWaterDepth = 21.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.188
          weapons = [
                { name = "rocket_barrage"
                  displayName = Some "CatapultRockets"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 9.0)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 96.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 2.0
                  noSelfDamage = Some true
                  soundStart = Some "rockhvy3"
                  soundHit = Some "rockhit3"
                  explosiongenerator = Some "custom:genericshellexplosion-small"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "explode"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "120.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.25"
                      "cegtag", "missiletrailtiny"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "dance", "24.0"
                      "firestarter", "70.0"
                      "flighttime", "4.0"
                      "metalpershot", "0.0"
                      "model", "legsmallrocket.s3o"
                      "movingaccuracy", "900.0"
                      "proximitypriority", "-1.0"
                      "smokecolor", "0.5"
                      "smokeperiod", "4.0"
                      "smokesize", "8.5"
                      "smoketime", "12.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splssml"
                      "startvelocity", "250.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "trajectoryheight", "2.0"
                      "turnrate", "300.0"
                      "weaponacceleration", "150.0"
                      "wobble", "1500.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 0.0 0.0"
                  collisionVolumeScales = Some "42.0 26.0 42.0"
                  collisionVolumeType = Some "Box"
                  damage = Some 450.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 194.0
                  object_ = Some "Units/leghrk_dead.s3o"
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
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "legion/bots/T2 Bots"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "separationDistance", "8.0"
                "movestate", "0.0"
                "nochasecategory", "VTOL"
                "upright", "false"
            ] }

    type Leginc =
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

    let leginc : Leginc =
        { name = "leginc"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 2300.0
          energyCost = ValueOrExpr.Concrete 46000.0
          buildTime = ValueOrExpr.Concrete 69700.0
          health = ValueOrExpr.Concrete 9000.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 24.0
          maxAcc = 0.0585
          maxDec = 0.43125
          turnRate = 120.0
          movementClass = "HBOT4"
          maxSlope = 15.0
          maxWaterDepth = 23.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.495
          weapons = [
                { name = "heatraylarge"
                  displayName = Some "Heavy g2g Sustained Heat Ray"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 16.0
                      "default", 33.0
                      "vtol", 11.0
                  ]
                  range = Some (ValueOrExpr.Concrete 725.0)
                  reloadTime = Some (ValueOrExpr.Expr ".033")
                  weaponVelocity = None
                  areaOfEffect = Some 72.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray3burn"
                  soundHit = None
                  explosiongenerator = Some "custom:heatray-large"
                  rgbColor = Some "1 0.55 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_burstcontrolwhenoutofarc", "2.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "beamtime", "0.033"
                      "beamttl", "0.033"
                      "camerashake", "0.1"
                      "corethickness", "0.3"
                      "craterareaofeffect", "72.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "10.0"
                      "firestarter", "90.0"
                      "firetolerance", "100.0"
                      "intensity", "5.0"
                      "laserflaresize", "6.0"
                      "predictboost", "0.0"
                      "rgbcolor2", "0.9 1.0 0.5"
                      "soundhitdry", "flamhit1"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "11.0"
                      "soundtrigger", "1.0"
                      "thickness", "4.5"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-2.34260559082 -0.241825708008 -1.33148193359"
                  collisionVolumeScales = Some "60.9344787598 36.418548584 64.3249511719"
                  collisionVolumeType = Some "Box"
                  damage = Some 4500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 1400.0
                  object_ = Some "Units/leginc_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 2500.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 550.0
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
                "unitgroup", "weapon"
                "model_author", "Protar, Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "mass", "5001.0"
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

    type Leginfestor =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let leginfestor : Leginfestor =
        { name = "leginfestor"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 250.0
          energyCost = ValueOrExpr.Concrete 5200.0
          buildTime = ValueOrExpr.Concrete 4310.0
          health = ValueOrExpr.Concrete 1200.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 54.0
          maxAcc = 0.25
          maxDec = 0.65
          turnRate = 1214.40002
          movementClass = "TBOT3"
          maxSlope = 50.0
          maxWaterDepth = 5.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.0626
          workerTime = ValueOrExpr.Concrete 100.0
          buildDistance = 175.0
          buildOptions = ["leginfestor"]
          weapons = [
                { name = "festorbeam"
                  displayName = Some "Close-Quarters Light Heat Ray"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 120.0
                      "subs", 5.0
                      "vtol", 40.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 42.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 2000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "heatray1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small"
                  rgbColor = Some "1 0.55 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_burstControlWhenOutOfArc", "1.0"
                      "avoidfeature", "false"
                      "beamtime", "0.35"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "90.0"
                      "laserflaresize", "3.95"
                      "rgbcolor2", "0.9 1.0 0.5"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "1.5"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "30 20 30"
                  collisionVolumeType = Some "CYLY"
                  damage = Some 750.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 10.0
                  metal = Some 523.0
                  object_ = Some "Units/leginfestor_dead.s3o"
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
                "unitgroup", "weapon"
                "model_author", "Zath (model), Tuerk (animation)"
                "normaltex", "unittextures/leg_normal.dds"
                "paralyzemultiplier", "0.2"
                "selectable_as_combat_unit", "true"
                "subfolder", "CorBots/T2"
                "techlevel", "2.0"
                "selectionscalemult", "1.0"
            ]
          extras = Map.ofList [
                "canassist", "true"
                "canreclaim", "true"
                "mygravity", "10000.0"
                "nochasecategory", "VTOL"
                "strafetoattack", "false"
                "stealth", "true"
            ] }

    type Legshot =
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

    let legshot : Legshot =
        { name = "legshot"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 4750.0
          buildTime = ValueOrExpr.Concrete 10160.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 50.0
          maxAcc = 0.16
          maxDec = 0.8
          turnRate = 1316.75
          movementClass = "BOT2"
          maxSlope = 17.0
          maxWaterDepth = 25.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.815
          weapons = [
                { name = "legion_riot_cannon_t2"
                  displayName = Some "Medium Blast Riot Cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 210.0
                      "subs", 90.0
                      "vtol", 35.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 144.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 2.5
                  noSelfDamage = Some true
                  soundStart = Some "largegun"
                  soundHit = Some "corlevlrhit"
                  explosiongenerator = Some "custom:genericshellexplosion-large"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "tolerace", "3000.0"
                      "firetolerance", "3000.0"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "soundhitwet", "splsmed"
                      "soundhitvolume", "12.0"
                      "soundstartvolume", "14.0"
                      "separation", "2.0"
                      "nogap", "false"
                      "size", "4.0"
                      "sizeDecay", "0.07"
                      "stages", "10.0"
                      "alphaDecay", "0.1"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 22 40"
                  collisionVolumeType = Some "Box"
                  damage = Some 3500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 450.0
                  object_ = Some "Units/legshot_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
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
                  metal = Some 225.0
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
                "unitgroup", "weapon"
                "model_author", "ZephyrSkies (modeller), Protar (concept art)"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Bots/T2 Bots"
                "techlevel", "2.0"
                "reactive_armor_health", "400.0"
                "reactive_armor_restore", "20.0"
            ]
          extras = Map.ofList [
                "damagemodifier", "0.333"
                "nochasecategory", "VTOL"
                "strafetoattack", "true"
                "upright", "true"
            ] }

    type Legsnapper =
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

    let legsnapper : Legsnapper =
        { name = "legsnapper"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 60.0
          energyCost = ValueOrExpr.Concrete 5600.0
          buildTime = ValueOrExpr.Concrete 9260.0
          health = ValueOrExpr.Concrete 550.0
          sightDistance = ValueOrExpr.Concrete 280.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 81.0
          maxAcc = 0.128
          maxDec = 0.5875
          turnRate = 1650.0
          movementClass = "ABOTBOMB2"
          maxSlope = 32.0
          maxWaterDepth = 112.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.75
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
                "unitgroup", "explo"
                "model_author", "Hornet"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/bots/t2 bots"
                "techlevel", "2.0"
                "instantselfd", "true"
            ]
          extras = Map.ofList [
                "mass", "749.0"
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "0.0"
            ] }

    type Legsrail =
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

    let legsrail : Legsrail =
        { name = "legsrail"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 15000.0
          buildTime = ValueOrExpr.Concrete 19500.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 42.0
          maxAcc = 0.08
          maxDec = 0.345
          turnRate = 800.0
          movementClass = "TBOT3"
          maxSlope = 17.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.0
          weapons = [
                { name = "railgunt2"
                  displayName = Some "Railgun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 375.0
                      "default", 750.0
                  ]
                  range = Some (ValueOrExpr.Concrete 850.0)
                  reloadTime = Some (ValueOrExpr.Concrete 6.0)
                  weaponVelocity = Some 3180.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "heavyrailgun"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "0.34 0.64 0.94"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burnblow", "false"
                      "cegtag", "railgun"
                      "collisionSize", "0.667"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.12"
                      "energypershot", "400.0"
                      "firestarter", "0.0"
                      "hardstop", "true"
                      "impactonly", "true"
                      "intensity", "0.8"
                      "noexplode", "true"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "26.0"
                      "thickness", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-3.37104034424 -1.05229058838 1.8899307251"
                  collisionVolumeScales = Some "38 25 33"
                  collisionVolumeType = Some "Box"
                  damage = Some 3000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 500.0
                  object_ = Some "Units/legsrail_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 3015.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 250.0
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
                "unitgroup", "weapon"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/gantry"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "mygravity", "10000.0"
                "nochasecategory", "VTOL"
                "usepiececollisionvolumes", "1.0"
            ] }

    type Legstr =
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

    let legstr : Legstr =
        { name = "legstr"
          subfolder = "Legion/Bots/T2 Bots"
          metalCost = ValueOrExpr.Concrete 355.0
          energyCost = ValueOrExpr.Concrete 5250.0
          buildTime = ValueOrExpr.Concrete 9240.0
          health = ValueOrExpr.Concrete 1780.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 84.0
          maxAcc = 0.253
          maxDec = 0.8211
          turnRate = 800.0
          movementClass = "BOT3"
          maxSlope = 17.0
          maxWaterDepth = 32.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.98
          weapons = [
                { name = "armmg_weapon"
                  displayName = Some "Twin Rapid-fire Machine Guns"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 8.0
                      "vtol", 3.0
                  ]
                  range = Some (ValueOrExpr.Concrete 280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 933.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 5.0
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "mgun6heavy"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_burstcontrolwhenoutofarc", "2.0"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "12.0"
                      "burstrate", "0.033"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.04"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "2.5"
                      "soundtrigger", "true"
                      "sprayangle", "1024.0"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "2.0 -10.0 2.0"
                  collisionVolumeScales = Some "38.0 32.0 38.0"
                  collisionVolumeType = Some "Box"
                  damage = Some 2400.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 250.0
                  object_ = Some "Units/legstr_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1200.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 125.0
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
                ok = ["mavbok1"]
                select = ["mavbsel1"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "ArmGantry"
                "techlevel", "2.0"
                "weapon1turretx", "90.0"
                "weapon1turrety", "150.0"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "upright", "true"
            ] }

