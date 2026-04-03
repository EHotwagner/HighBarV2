// Auto-generated BAR unit data: Legion/SeaDefenses (flat per-unit types)
namespace BarData.Units

open BarData

module Legion_SeaDefenses =

    type Legctl =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legctl : Legctl =
        { name = "legctl"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 2200.0
          buildTime = ValueOrExpr.Concrete 5900.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 617.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "yyyyyooyyooyyyyy"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "torplauncher"
                  displayName = Some "Homing Torpedo Launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 225.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = Some 300.0
                  areaOfEffect = None
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
                      "mount_badtargetcategory", "NOTSUB"
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
                      "trajectoryheight", "0.6"
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
                  collisionVolumeScales = Some "38 46 40"
                  collisionVolumeType = Some "Box"
                  damage = Some 609.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 30.0
                  metal = Some 176.0
                  object_ = Some "Units/legctl_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 305.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 70.0
                  object_ = Some "Units/arm3X3C.s3o"
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
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "removewait", "true"
                "subfolder", "Legion/SeaDefenses"
                "unitgroup", "sub"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "sonardistance", "600.0"
            ] }

    type Legfdrag =
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
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legfdrag : Legfdrag =
        { name = "legfdrag"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 15.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 400.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "oooo"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "objectify", "true"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "Legion/SeaDefenses"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "buildangle", "8192.0"
                "canattack", "false"
                "crushresistance", "250.0"
                "hidedamage", "true"
                "repairable", "false"
                "selfdestructcountdown", "1.0"
            ] }

    type Legfhive =
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
          canMove: bool
          minWaterDepth: float
          waterline: float
          energyStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legfhive : Legfhive =
        { name = "legfhive"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 350.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 7500.0
          health = ValueOrExpr.Concrete 1200.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 4.5
          turnRate = 1.0
          maxSlope = 10.0
          canMove = true
          minWaterDepth = 12.0
          waterline = 4.0
          energyStorage = 200.0
          weapons = [
                { name = "plasma"
                  displayName = Some "HeavyCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1100.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 4.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some ""
                  soundHit = Some ""
                  explosiongenerator = Some ""
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "carried_unit", "legdrone"
                      "spawns_surface", "SEA"
                      "carrierdeaththroe", "release"
                      "dockingpieces", "4 5 6 7 8 9"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "metalpershot", "15.0"
                      "energypershot", "500.0"
                      "size", "0.0"
                      "soundhitwet", ""
                      "stockpile", "true"
                      "stockpiletime", "10.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "38 95 38"
                  collisionVolumeType = Some "CylY"
                  damage = Some 700.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 130.0
                  object_ = Some "Units/leghive_dead.s3o"
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
                  metal = Some 65.0
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
                ok = ["twractv3"]
                select = ["twractv3"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/armnanotc_aoplane.dds"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "weapon"
                "model_author", "Zephyr"
                "normaltex", "unittextures/leg_normal.dds"
                "removewait", "true"
                "subfolder", "CorBuildings/LandDefenceOffence"
                "legacyname", "Gaat Gun"
                "inheritxpratemultiplier", "1.0"
                "childreninheritxp", "DRONE"
                "parentsinheritxp", "DRONE"
                "restrictions_inclusion", "_noair_"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "mass", "700.0"
                "nochasecategory", "MOBILE"
                "upright", "true"
            ] }

    type Legfmg =
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
          canRepeat: bool
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legfmg : Legfmg =
        { name = "legfmg"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 5500.0
          buildTime = ValueOrExpr.Concrete 7600.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 525.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "ooooooooo"
          canRepeat = false
          weapons = [
                { name = "gatling_gun"
                  displayName = Some "Rapid-Fire Gatling Gun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 18.0
                      "vtol", 18.0
                  ]
                  range = Some (ValueOrExpr.Concrete 575.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 958.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 7.0
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
                      "mount_badtargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "mount_burstControlWhenOutOfArc", "2.0"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.066"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.038"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "4.5"
                      "soundtrigger", "true"
                      "sprayangle", "968.0"
                      "texture1", "shot"
                      "texture2", "empty"
                      "thickness", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-1.45989990234 -3.69362253418 0.310646057129"
                  collisionVolumeScales = Some "48.9197998047 59.9625549316 37.0396270752"
                  collisionVolumeType = Some "Box"
                  damage = Some 774.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 50.0
                  metal = Some 114.0
                  object_ = Some "Units/legfmg_dead.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "unitgroup", "weaponaa"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "removewait", "true"
                "subfolder", "Legion/SeaDefenses"
            ]
          extras = Map.ofList [
                "airsightdistance", "650.0"
                "buildangle", "32768.0"
                "cantbetransported", "false"
                "levelground", "false"
                "mass", "7500.0"
            ] }

    type Legfrl =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legfrl : Legfrl =
        { name = "legfrl"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 2200.0
          health = ValueOrExpr.Concrete 380.0
          sightDistance = ValueOrExpr.Concrete 468.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "wwwwwwwwwwwwwwww"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "legrl_missile"
                  displayName = Some "Light g2a Missile Launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 115.0
                  ]
                  range = Some (ValueOrExpr.Concrete 765.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.2)
                  weaponVelocity = Some 750.0
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
                      "mount_badtargetcategory", "NOWEAPON LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "1.9"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "6.0"
                      "smoketime", "12.0"
                      "smokesize", "4.8"
                      "smokecolor", "0.95"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "startvelocity", "400.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "63000.0"
                      "weaponacceleration", "150.0"
                      "weapontimer", "5.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "26 52 26"
                  collisionVolumeType = Some "Box"
                  damage = Some 151.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 40.0
                  metal = Some 46.0
                  object_ = Some "Units/legfrl_dead.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "removewait", "true"
                "subfolder", "Legion/SeaDefenses"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "750.0"
                "buildangle", "16384.0"
                "nochasecategory", "ALL"
            ] }

    type Legnavaldefturret =
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
          canRepeat: bool
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legnavaldefturret : Legnavaldefturret =
        { name = "legnavaldefturret"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 600.0
          energyCost = ValueOrExpr.Concrete 7500.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 5190.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 5.0
          footprintZ = 5.0
          yardMap = "ooooooooooooooooooooooooo"
          canRepeat = false
          weapons = [
                { name = "leg_med_anti_naval_salvo_rocket"
                  displayName = Some "Dual-Salvo Medium Rocket Launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 95.0
                  ]
                  range = Some (ValueOrExpr.Concrete 720.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 100.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 7000.0
                  edgeEffectiveness = Some 0.2
                  impulseFactor = Some 0.185
                  noSelfDamage = Some true
                  soundStart = Some "SabotFire"
                  soundHit = Some "xplosml2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_burstControlWhenOutOfArc", "2.0"
                      "avoidfeature", "false"
                      "burst", "4.0"
                      "burstrate", "0.185"
                      "cegtag", "missiletrailsmall-simple"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "dance", "10.0"
                      "flighttime", "5.0"
                      "firestarter", "70.0"
                      "intensity", "2.25"
                      "metalpershot", "0.0"
                      "model", "legmediumrocket.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "11.0"
                      "smoketime", "28.0"
                      "smokesize", "3.3"
                      "smokecolor", "1.0"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "true"
                      "soundhitwet", "splshbig"
                      "startvelocity", "300.0"
                      "texture1", "null"
                      "texture2", "smoketraildark"
                      "tracks", "true"
                      "turnrate", "3000.0"
                      "firetolerance", "7000.0"
                      "weaponacceleration", "150.0"
                      "weapontimer", "10.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "70 50 70"
                  collisionVolumeType = Some "CylY"
                  damage = Some 2500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 50.0
                  metal = Some 350.0
                  object_ = Some "Units/legnavaldefturret_dead.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "unitgroup", "weapon"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "removewait", "true"
                "subfolder", "Legion/SeaDefenses"
            ]
          extras = Map.ofList [
                "airsightdistance", "650.0"
                "buildangle", "32768.0"
                "mass", "9500.0"
            ] }

    type Legtl =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legtl : Legtl =
        { name = "legtl"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 170.0
          energyCost = ValueOrExpr.Concrete 1500.0
          buildTime = ValueOrExpr.Concrete 3700.0
          health = ValueOrExpr.Concrete 1300.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "wwwwwwwww"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "torpedo"
                  displayName = Some "Torpedo Launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 280.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = Some 280.0
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
                      "mount_badtargetcategory", "HOVER NOTSHIP"
                      "mount_onlytargetcategory", "NOTHOVER"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "burnblow", "true"
                      "cegtag", "torpedotrail-tiny"
                      "collidefriendly", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "1.8"
                      "model", "legbasictorpedo.s3o"
                      "predictboost", "1.0"
                      "startvelocity", "230.0"
                      "tracks", "false"
                      "turnrate", "2500.0"
                      "waterweapon", "true"
                      "weaponacceleration", "50.0"
                      "weapontimer", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "14 43 30"
                  collisionVolumeType = Some "Box"
                  damage = Some 870.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 70.0
                  object_ = Some "Units/legtl_dead.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "removewait", "true"
                "subfolder", "Legion/SeaDefenses"
                "unitgroup", "sub"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "sonardistance", "400.0"
            ] }

