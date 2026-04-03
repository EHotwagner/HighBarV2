// Auto-generated BAR unit data: ArmBuildings/LandDefenceOffence (flat per-unit types)
namespace BarData.Units

open BarData

module ArmBuildings_LandDefenceOffence =

    type Armamb =
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

    let armamb : Armamb =
        { name = "armamb"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 27000.0
          health = ValueOrExpr.Concrete 4000.0
          sightDistance = ValueOrExpr.Concrete 442.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "oooooooooooooooo"
          activateWhenBuilt = false
          canRepeat = false
          weapons = [
                { name = "armamb_gun"
                  displayName = Some "Pop-up heavy  long range g2g plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 350.0
                      "subs", 150.0
                      "vtol", 90.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1380.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.8)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 152.0
                  accuracy = Some 400.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.4
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy5"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-aoe"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_maindir", "0 1 0"
                      "mount_maxangledif", "230.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidneutral", "true"
                      "cegtag", "arty-heavy"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "predictboost", "0.2"
                      "soundhitwet", "splslrg"
                  ] }
                { name = "armamb_gun_high"
                  displayName = Some "Pop-up heavy  long range g2g plasna cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 350.0
                      "subs", 150.0
                      "vtol", 90.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1380.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.8)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 152.0
                  accuracy = Some 400.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.4
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy5"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-aoe"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "arty-heavy"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "predictboost", "0.2"
                      "soundhitwet", "splslrg"
                  ] }
                { name = "smart_trajectory_dummy"
                  displayName = Some "Pop-up heavy  long range g2g plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1380.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.8)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 152.0
                  accuracy = Some 400.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.4
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy5"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-aoe"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_maindir", "0 1 0"
                      "mount_maxangledif", "230.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidneutral", "true"
                      "cegtag", "arty-heavy"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "predictboost", "0.2"
                      "soundhitwet", "splslrg"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.544998168945 2.61108398441e-05 -0.5"
                  collisionVolumeScales = Some "60 30 60"
                  collisionVolumeType = Some "cylY"
                  damage = Some 2160.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 1522.0
                  object_ = Some "Units/armamb_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 540.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 244.0
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
                ok = ["twrturn3"]
                select = ["twrturn3"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armamb_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
                "unitgroup", "weapon"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "cloakcost", "24.0"
                "damagemodifier", "0.25"
                "mincloakdistance", "70.0"
                "nochasecategory", "MOBILE"
                "usepiececollisionvolumes", "1.0"
            ] }

    type Armamd =
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

    let armamd : Armamd =
        { name = "armamd"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 1500.0
          energyCost = ValueOrExpr.Concrete 38000.0
          buildTime = ValueOrExpr.Concrete 60000.0
          health = ValueOrExpr.Concrete 3300.0
          sightDistance = ValueOrExpr.Concrete 201.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "oooooooooooooooo"
          canRepeat = false
          weapons = [
                { name = "amd_rocket"
                  displayName = Some "ICBM intercepting missile launcher"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 1500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 72000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 6000.0
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
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "coverage", "2000.0"
                      "craterareaofeffect", "420.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "7500.0"
                      "firestarter", "100.0"
                      "flighttime", "20.0"
                      "interceptor", "1.0"
                      "metalpershot", "150.0"
                      "model", "fmdmissile.s3o"
                      "smokecolor", "0.7"
                      "smokeperiod", "10.0"
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
                      "weapontimer", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "53 78 53"
                  collisionVolumeType = Some "Box"
                  damage = Some 1980.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 934.0
                  object_ = Some "Units/armamd_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 990.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 374.0
                  object_ = Some "Units/arm5X5B.s3o"
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
                ok = ["loadwtr2"]
                select = ["loadwtr2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armamd_aoplane.dds"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
                "unitgroup", "antinuke"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "canattack", "false"
                "noautofire", "true"
                "radardistance", "50.0"
            ] }

    type Armanni =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armanni : Armanni =
        { name = "armanni"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 74000.0
          buildTime = ValueOrExpr.Concrete 52000.0
          health = ValueOrExpr.Concrete 6100.0
          sightDistance = ValueOrExpr.Concrete 780.0
          footprintX = 4.0
          footprintZ = 4.0
          energyStorage = 1000.0
          yardMap = "oooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "ata"
                  displayName = Some "Heavy long-range g2g tachyon accelerator beam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 2400.0
                      "default", 10800.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 9.9)
                  weaponVelocity = Some 1400.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "annigun1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-blue"
                  rgbColor = Some "0 0 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamtime", "1.5"
                      "collidefriendly", "false"
                      "corethickness", "0.3"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "1500.0"
                      "firestarter", "90.0"
                      "largebeamlaser", "true"
                      "laserflaresize", "6.5"
                      "scrollspeed", "5.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "texture3", "largebeam"
                      "thickness", "4.5"
                      "tilelength", "150.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 1.06567382829e-05 -0.0"
                  collisionVolumeScales = Some "62.5 81.7362213135 62.5"
                  collisionVolumeType = Some "Box"
                  damage = Some 1800.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 1940.0
                  object_ = Some "Units/armanni_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 900.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 776.0
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
                ok = ["anni"]
                select = ["anni"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecaltype", "decals/armanni_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
                "unitgroup", "weapon"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "damagemodifier", "0.25"
                "nochasecategory", "MOBILE"
                "onoffable", "true"
                "radardistance", "1500.0"
                "radaremitheight", "72.0"
                "sightemitheight", "72.0"
            ] }

    type Armbeamer =
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

    let armbeamer : Armbeamer =
        { name = "armbeamer"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 190.0
          energyCost = ValueOrExpr.Concrete 1500.0
          buildTime = ValueOrExpr.Concrete 4800.0
          health = ValueOrExpr.Concrete 1430.0
          sightDistance = ValueOrExpr.Concrete 475.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "oooo"
          canRepeat = false
          weapons = [
                { name = "armbeamer_weapon"
                  displayName = Some "Anti-swarm constant wave g2g laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 40.0
                      "default", 26.6
                      "vtol", 2.0
                  ]
                  range = Some (ValueOrExpr.Concrete 490.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "beamershot2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-beamer"
                  rgbColor = Some "0 0 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamdecay", "0.05"
                      "beamtime", "0.1"
                      "beamttl", "1.0"
                      "corethickness", "0.233"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "6.0"
                      "firestarter", "30.0"
                      "impactonly", "1.0"
                      "laserflaresize", "9.35"
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
                  collisionVolumeOffsets = Some "0 0 -1"
                  collisionVolumeScales = Some "33 85 33"
                  collisionVolumeType = Some "CylY"
                  damage = Some 774.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 50.0
                  metal = Some 114.0
                  object_ = Some "Units/armbeamer_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 387.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 46.0
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
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecaltype", "decals/armbeamer_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "unitgroup", "weapon"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "32768.0"
                "cantbetransported", "false"
                "mass", "7500.0"
            ] }

    type Armbrtha =
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

    let armbrtha : Armbrtha =
        { name = "armbrtha"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 4500.0
          energyCost = ValueOrExpr.Concrete 64000.0
          buildTime = ValueOrExpr.Concrete 85000.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "oooooooooooooooo"
          canRepeat = false
          weapons = [
                { name = "lrpc"
                  displayName = Some "Long-range plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 1625.0
                      "shields", 812.0
                      "subs", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 4650.0)
                  reloadTime = Some (ValueOrExpr.Concrete 13.2)
                  weaponVelocity = Some 1100.0
                  areaOfEffect = Some 135.0
                  accuracy = Some 300.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 1.1
                  noSelfDamage = Some true
                  soundStart = Some "lrpcshot3"
                  soundHit = Some "lrpcexplo"
                  explosiongenerator = Some "custom:genericshellexplosion-huge"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "cegtag", "arty-huge"
                      "collidefriendly", "false"
                      "craterareaofeffect", "116.0"
                      "craterboost", "0.1"
                      "cratermult", "0.1"
                      "energypershot", "5000.0"
                      "gravityaffected", "true"
                      "heightboostfactor", "8.0"
                      "leadbonus", "0.0"
                      "soundhitvolume", "38.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "24.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "3.15924835205 -0.787798413086 6.6563873291"
                  collisionVolumeScales = Some "81.6838531494 113.772003174 72.5632324219"
                  collisionVolumeType = Some "Box"
                  damage = Some 2520.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 40.0
                  metal = Some 2720.0
                  object_ = Some "Units/armbrtha_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1260.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 1088.0
                  object_ = Some "Units/arm3X3E.s3o"
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
                ok = ["servlrg3"]
                select = ["servlrg3"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/armbrtha_aoplane.dds"
                "canareaattack", "1.0"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
                "unitgroup", "weapon"
                "restrictions_inclusion", "_nolrpc_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "32700.0"
                "usepiececollisionvolumes", "1.0"
            ] }

    type Armcir =
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

    let armcir : Armcir =
        { name = "armcir"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 7300.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "oooooooooooooooo"
          canRepeat = false
          weapons = [
                { name = "arm_cir"
                  displayName = Some "Rapid-fire long-range g2a missile barrel"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 250.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1125.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.6)
                  weaponVelocity = Some 1300.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 100000.0
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
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "burst", "4.0"
                      "burstrate", "0.26667"
                      "canattackground", "false"
                      "castshadow", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "20.0"
                      "flighttime", "2.3"
                      "model", "cormissile.s3o"
                      "projectiles", "1.0"
                      "proximitypriority", "-0.5"
                      "smokecolor", "0.95"
                      "smokeperiod", "8.0"
                      "smokesize", "5.4"
                      "smoketime", "12.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "250.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "42000.0"
                      "weaponacceleration", "300.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "50 77 50"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 370.0
                  object_ = Some "Units/armcir_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 750.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 150.0
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
                ok = ["twrturn3"]
                select = ["twrturn3"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/armcir_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "unitgroup", "aa"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "airsightdistance", "1060.0"
                "buildangle", "65536.0"
            ] }

    type Armclaw =
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

    let armclaw : Armclaw =
        { name = "armclaw"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 340.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 4650.0
          health = ValueOrExpr.Concrete 1330.0
          sightDistance = ValueOrExpr.Concrete 440.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "ffff"
          canRepeat = false
          weapons = [
                { name = "dclaw"
                  displayName = Some "Close-quarters g2g lightning turret"
                  weaponType = Some "LightningCannon"
                  damage = Map.ofList [
                      "commanders", 27.0
                      "default", 18.0
                  ]
                  range = Some (ValueOrExpr.Concrete 430.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.13333)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lghthvy1"
                  soundHit = Some "lashit"
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
                      "mount_burstcontrolwhenoutofarc", "2.0"
                      "mount_fastautoretargeting", "true"
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
                      "soundhitwet", "sizzle"
                      "soundtrigger", "true"
                      "thickness", "1.5"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 2.37060546837e-06 -0.0625"
                  collisionVolumeScales = Some "32.0 17.7499847412 31.375"
                  collisionVolumeType = Some "Box"
                  damage = Some 540.0
                  featureDead = Some "ROCKTEETH"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 205.0
                  object_ = Some "Units/armdrag.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "rockteeth",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 500.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2.0
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
                ok = ["servmed2"]
                select = ["servmed2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecaltype", "decals/armclaw_aoplane.dds"
                "decoyfor", "armdrag"
                "model_author", "Beherith"
                "neutral_when_closed", "true"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "unitgroup", "weapon"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "damagemodifier", "0.33"
                "decoyfor", "armdrag"
                "hidedamage", "true"
                "levelground", "false"
                "mass", "10000000000.0"
                "nochasecategory", "MOBILE"
                "radardistancejam", "8.0"
                "stealth", "true"
                "upright", "true"
                "usepiececollisionvolumes", "1.0"
            ] }

    type Armemp =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armemp : Armemp =
        { name = "armemp"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 1600.0
          energyCost = ValueOrExpr.Concrete 29000.0
          buildTime = ValueOrExpr.Concrete 79300.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "oooooooooooooooo"
          weapons = [
                { name = "armemp_weapon"
                  displayName = Some "Heavy long-range g2g EMP starburst rocket"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 50000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 3650.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 1200.0
                  areaOfEffect = Some 312.0
                  accuracy = None
                  turret = None
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "mismed1emp1"
                  soundHit = Some "emgpuls1"
                  explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "EMPABLE"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "cegtag", "cruisemissiletrail-emp"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "15644.0"
                      "firestarter", "0.0"
                      "flighttime", "400.0"
                      "interceptedbyshieldtype", "0.0"
                      "metalpershot", "500.0"
                      "model", "cortronmissile.s3o"
                      "paralyzer", "true"
                      "paralyzetime", "35.0"
                      "smokecolor", "0.9"
                      "smokeperiod", "8.0"
                      "smokesize", "7.0"
                      "smoketime", "60.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "stockpile", "true"
                      "stockpiletime", "65.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "10000.0"
                      "weaponacceleration", "150.0"
                      "weapontimer", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "80 30 60"
                  collisionVolumeType = Some "Box"
                  damage = Some 1800.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 976.0
                  object_ = Some "Units/armemp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 900.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 390.0
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
                ok = ["servroc1"]
                select = ["servroc1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/armemp_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
                "unitgroup", "emp"
                "restrictions_inclusion", "_notacnukes_"
                "usebuildinggrounddecal", "true"
                "yardmap", "ooooooo ooooooo ooooooo ooooooo ooooooo ooooooo"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
            ] }

    type Armferret =
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

    let armferret : Armferret =
        { name = "armferret"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 360.0
          energyCost = ValueOrExpr.Concrete 5700.0
          buildTime = ValueOrExpr.Concrete 5800.0
          health = ValueOrExpr.Concrete 1330.0
          sightDistance = ValueOrExpr.Concrete 375.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "ooooooooo"
          canRepeat = false
          weapons = [
                { name = "ferret_missile"
                  displayName = Some "Pop-up rapid-fire g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 840.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.7)
                  weaponVelocity = Some 1200.0
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
                      "mount_badtargetcategory", "NOTAIR"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "burst", "2.0"
                      "burstrate", "0.2"
                      "canattackground", "false"
                      "castshadow", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "2.5"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smokecolor", "1.0"
                      "smokeperiod", "8.0"
                      "smokesize", "4.2"
                      "smoketime", "12.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1500.0"
                      "weapontimer", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.544990539551 0.0 -0.500007629395"
                  collisionVolumeScales = Some "48.1152496338 19.0 48.1152496338"
                  collisionVolumeType = Some "Box"
                  damage = Some 720.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 233.0
                  object_ = Some "Units/armferret_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 360.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 100.0
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
                ok = ["servmed1"]
                select = ["servmed1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armferret_aoplane.dds"
                "legacyname", "Pack0"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "unitgroup", "aa"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "airsightdistance", "850.0"
                "buildangle", "8192.0"
                "cloakcost", "12.0"
                "damagemodifier", "0.2"
                "mincloakdistance", "72.0"
                "nochasecategory", "ALL"
            ] }

    type Armflak =
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

    let armflak : Armflak =
        { name = "armflak"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 820.0
          energyCost = ValueOrExpr.Concrete 13000.0
          buildTime = ValueOrExpr.Concrete 19000.0
          health = ValueOrExpr.Concrete 1750.0
          sightDistance = ValueOrExpr.Concrete 525.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "ooooooooo"
          canRepeat = false
          weapons = [
                { name = "armflak_gun"
                  displayName = Some "Heavy g2a flak cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "vtol", 250.0
                  ]
                  range = Some (ValueOrExpr.Concrete 775.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.53333)
                  weaponVelocity = Some 1600.0
                  areaOfEffect = Some 172.0
                  accuracy = Some 1000.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "flakfire"
                  soundHit = Some "flakhit2"
                  explosiongenerator = Some "custom:flak"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "flaktrailaa"
                      "collidefriendly", "false"
                      "craterareaofeffect", "192.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "gravityaffected", "true"
                      "mygravity", "0.01"
                      "predictboost", "1.0"
                      "smoketrail", "false"
                      "soundhitvolume", "7.5"
                      "soundhitwet", "splslrg"
                      "soundstartvolume", "9.0"
                      "stages", "0.0"
                      "weapontimer", "1.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-3.8550491333 -3.09570312496e-05 3.13596343994"
                  collisionVolumeScales = Some "30.5327911377 31.4515380859 37.50050354"
                  collisionVolumeType = Some "Box"
                  damage = Some 945.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 500.0
                  object_ = Some "Units/armflak_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 473.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 200.0
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
                ok = ["twrturn3"]
                select = ["twrturn3"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armflak_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
                "unitgroup", "aa"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "airsightdistance", "1000.0"
                "buildangle", "8192.0"
                "nochasecategory", "ALL"
            ] }

    type Armguard =
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

    let armguard : Armguard =
        { name = "armguard"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 1250.0
          energyCost = ValueOrExpr.Concrete 12500.0
          buildTime = ValueOrExpr.Concrete 19300.0
          health = ValueOrExpr.Concrete 3050.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "oooooooooooooooo"
          activateWhenBuilt = false
          canRepeat = false
          weapons = [
                { name = "plasma"
                  displayName = Some "Heavy g2g long range plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 300.0
                      "subs", 150.0
                      "vtol", 90.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1220.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.85)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 100.0
                  accuracy = Some 75.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.4
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy5"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "0 1 0"
                      "mount_maxangledif", "230.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidneutral", "true"
                      "cegtag", "arty-medium"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "plasma_high"
                  displayName = Some "Heavy g2g long range plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 300.0
                      "subs", 150.0
                      "vtol", 90.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1220.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.85)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 100.0
                  accuracy = Some 75.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.4
                  impulseFactor = Some 1.4
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy5"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "arty-medium"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "mygravity", "0.289"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "smart_trajectory_dummy"
                  displayName = Some "Heavy g2g long range plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1220.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.85)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 100.0
                  accuracy = Some 75.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.4
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy5"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "0 1 0"
                      "mount_maxangledif", "230.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidneutral", "true"
                      "cegtag", "arty-medium"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splsmed"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-1.17901611328 -3.4173887085 2.49339294434"
                  collisionVolumeScales = Some "56.5218811035 34.070022583 54.9867858887"
                  collisionVolumeType = Some "Box"
                  damage = Some 1656.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 40.0
                  metal = Some 890.0
                  object_ = Some "Units/armguard_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 828.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 357.0
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
                ok = ["twrturn3"]
                select = ["twrturn3"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armguard_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "unitgroup", "weapon"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "nochasecategory", "MOBILE"
            ] }

    type Armhlt =
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

    let armhlt : Armhlt =
        { name = "armhlt"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 440.0
          energyCost = ValueOrExpr.Concrete 4700.0
          buildTime = ValueOrExpr.Concrete 11300.0
          health = ValueOrExpr.Concrete 2600.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "oooo"
          canRepeat = false
          weapons = [
                { name = "arm_laserh1"
                  displayName = Some "Heavy g2g high energy laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 580.5
                      "default", 387.0
                      "vtol", 35.0
                  ]
                  range = Some (ValueOrExpr.Concrete 620.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.8)
                  weaponVelocity = Some 2250.0
                  areaOfEffect = Some 14.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0 1 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.15"
                      "corethickness", "0.25"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "75.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "9.9"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "48 88 48"
                  collisionVolumeType = Some "CYLY"
                  damage = Some 1395.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 269.0
                  object_ = Some "Units/armhlt_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 698.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 108.0
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
                ok = ["twractv3"]
                select = ["twractv3"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecaltype", "decals/armhlt_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "unitgroup", "weapon"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "nochasecategory", "MOBILE"
            ] }

    type Armjuno =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armjuno : Armjuno =
        { name = "armjuno"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 640.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 21800.0
          health = ValueOrExpr.Concrete 2350.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "oooooooooooooooo"
          weapons = [
                { name = "juno_pulse"
                  displayName = Some "Anti radar/minefield/jammer magnetic impulse rocket"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 1.0
                      "mines", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 32000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 500.0
                  areaOfEffect = Some 1400.0
                  accuracy = None
                  turret = None
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = None
                  soundStart = Some "junofir2"
                  soundHit = Some "junohit2"
                  explosiongenerator = Some "custom:juno-explo"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "junotype", "base"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "castshadow", "true"
                      "cegtag", "missiletrail-juno"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "commandfire", "true"
                      "craterareaofeffect", "1400.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "12000.0"
                      "flighttime", "400.0"
                      "interceptedbyshieldtype", "0.0"
                      "metalpershot", "200.0"
                      "model", "epulse.s3o"
                      "smokecolor", "0.7"
                      "smokeperiod", "8.0"
                      "smokesize", "14.0"
                      "smoketime", "45.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "stockpile", "true"
                      "stockpiletime", "75.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "5500.0"
                      "weaponacceleration", "75.0"
                      "weapontimer", "4.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -30 0"
                  collisionVolumeScales = Some "44 128 44"
                  collisionVolumeType = Some "CylY"
                  damage = Some 1272.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 352.0
                  object_ = Some "Units/armjuno_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 636.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 145.0
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
                ok = ["drone1"]
                select = ["drone1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/armjuno_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "unitgroup", "weapon"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "stealth", "true"
            ] }

    type Armllt =
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

    let armllt : Armllt =
        { name = "armllt"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 85.0
          energyCost = ValueOrExpr.Concrete 680.0
          buildTime = ValueOrExpr.Concrete 2400.0
          health = ValueOrExpr.Concrete 620.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "oooo"
          canRepeat = false
          weapons = [
                { name = "arm_lightlaser"
                  displayName = Some "Light g2g laser turret"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 112.5
                      "default", 75.0
                      "subs", 5.0
                      "vtol", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 430.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.46667)
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
                      "mount_badtargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.12"
                      "corethickness", "0.175"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "20.0"
                      "firestarter", "30.0"
                      "impactonly", "1.0"
                      "laserflaresize", "7.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -4 0"
                  collisionVolumeScales = Some "32 84 32"
                  collisionVolumeType = Some "CylY"
                  damage = Some 336.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 53.0
                  object_ = Some "Units/armllt_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 168.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 21.0
                  object_ = Some "Units/arm2X2B.s3o"
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
                ok = ["lltok"]
                select = ["lltselect"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecaltype", "decals/armllt_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "unitgroup", "weapon"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "32768.0"
                "cantbetransported", "false"
                "mass", "5100.0"
                "nochasecategory", "MOBILE"
            ] }

    type Armmercury =
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

    let armmercury : Armmercury =
        { name = "armmercury"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 1600.0
          energyCost = ValueOrExpr.Concrete 33000.0
          buildTime = ValueOrExpr.Concrete 28000.0
          health = ValueOrExpr.Concrete 1670.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "oooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "arm_advsam"
                  displayName = Some "Heavy long-range g2a guided missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 750.0
                  ]
                  range = Some (ValueOrExpr.Concrete 2400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.8)
                  weaponVelocity = Some 1850.0
                  areaOfEffect = Some 425.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.75
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "aarocket"
                  soundHit = Some "impact"
                  explosiongenerator = Some "custom:genericshellexplosion-huge-aa"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "castshadow", "false"
                      "cegtag", "missiletrailaa-large"
                      "collidefriendly", "false"
                      "craterareaofeffect", "425.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "1800.0"
                      "firestarter", "90.0"
                      "flighttime", "2.2"
                      "metalpershot", "0.0"
                      "model", "corscreamermissile.s3o"
                      "proximitypriority", "-1.0"
                      "smokecolor", "0.9"
                      "smokeperiod", "3.0"
                      "smokesize", "11.0"
                      "smoketime", "24.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitvolume", "8.0"
                      "soundhitwet", "splslrg"
                      "soundstartvolume", "8.0"
                      "sprayangle", "10000.0"
                      "startvelocity", "1400.0"
                      "stockpile", "true"
                      "stockpiletime", "14.0"
                      "texture1", "null"
                      "texture2", "smoketrailaaflak"
                      "tracks", "true"
                      "trajectoryheight", "0.55"
                      "turnrate", "99000.0"
                      "weaponacceleration", "1000.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "60 78 60"
                  collisionVolumeType = Some "CylY"
                  damage = Some 900.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 1022.0
                  object_ = Some "Units/armmercury_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 450.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = None
                  metal = Some 409.0
                  object_ = Some "Units/arm3X3A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "targsel1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["targsel1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/armmercury_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
                "unitgroup", "aa"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "airsightdistance", "2400.0"
            ] }

    type Armpb =
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

    let armpb : Armpb =
        { name = "armpb"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 680.0
          energyCost = ValueOrExpr.Concrete 14000.0
          buildTime = ValueOrExpr.Concrete 15000.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 598.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "ooooooooo"
          canRepeat = false
          weapons = [
                { name = "armpb_weapon"
                  displayName = Some "Pop-up heavy g2g gauss cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 675.0
                      "hvyboats", 472.5
                      "subs", 300.0
                      "vtol", 26.0
                  ]
                  range = Some (ValueOrExpr.Concrete 730.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.6)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 24.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 8000.0
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
                      "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "alphadecay", "0.08"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "nogap", "false"
                      "separation", "1.8"
                      "sizedecay", "0.06"
                      "soundhitwet", "splshbig"
                      "stages", "14.0"
                      "targetmoveerror", "0.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "32 18 32"
                  collisionVolumeType = Some "Box"
                  damage = Some 1519.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 15.0
                  metal = Some 350.0
                  object_ = Some "Units/armpb_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 760.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 140.0
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
                ok = ["twrturn3"]
                select = ["twrturn3"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armpb_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
                "unitgroup", "weapon"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "cloakcost", "16.0"
                "damagemodifier", "0.5"
                "mincloakdistance", "55.0"
                "nochasecategory", "MOBILE"
            ] }

    type Armrl =
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

    let armrl : Armrl =
        { name = "armrl"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 80.0
          energyCost = ValueOrExpr.Concrete 900.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 330.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "ooooooooo"
          canRepeat = false
          weapons = [
                { name = "armrl_missile"
                  displayName = Some "Light g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 115.0
                  ]
                  range = Some (ValueOrExpr.Concrete 765.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.7)
                  weaponVelocity = Some 800.0
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
                      "mount_fastautoretargeting", "true"
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
                      "flighttime", "1.9"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smokecolor", "0.95"
                      "smokeperiod", "6.0"
                      "smokesize", "4.8"
                      "smoketime", "12.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "startvelocity", "300.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "63000.0"
                      "weaponacceleration", "200.0"
                      "weapontimer", "5.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "48 60 48"
                  collisionVolumeType = Some "CYLY"
                  damage = Some 177.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 51.0
                  object_ = Some "Units/armrl_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 89.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 20.0
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
                ok = ["kbarmmov"]
                select = ["kbarmsel"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armrl_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "unitgroup", "aa"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "airsightdistance", "700.0"
                "cantbetransported", "false"
                "mass", "5100.0"
                "nochasecategory", "ALL"
            ] }

    type Armshockwave =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          metalStorage: float
          extractsMetal: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armshockwave : Armshockwave =
        { name = "armshockwave"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 1200.0
          energyCost = ValueOrExpr.Concrete 14000.0
          buildTime = ValueOrExpr.Concrete 15000.0
          health = ValueOrExpr.Concrete 4200.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 4.0
          footprintZ = 4.0
          metalStorage = 600.0
          extractsMetal = 0.004
          yardMap = "h oooooooo osssssso osssssso ossoosso ossoosso osssssso osssssso oooooooo"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "hllt_bottom"
                  displayName = Some "Medium EMP turret"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 800.0
                      "vtol", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.3)
                  weaponVelocity = Some 540.0
                  areaOfEffect = Some 150.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "hackshot"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-small-lightning"
                  rgbColor = Some "0.8 0.8 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "corethickness", "0.175"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "80.0"
                      "firestarter", "100.0"
                      "gravityaffected", "true"
                      "impactonly", "0.0"
                      "laserflaresize", "7.7"
                      "paralyzer", "true"
                      "paralyzetime", "5.0"
                      "proximitypriority", "1.0"
                      "soundhitdry", "EMGPULS1"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "targetmoveerror", "0.1"
                      "thickness", "2.5"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -4.0 -0.0"
                  collisionVolumeScales = Some "60 72 60"
                  collisionVolumeType = Some "CylY"
                  damage = Some 780.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 122.0
                  object_ = Some "Units/armshockwave_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 390.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 49.0
                  object_ = Some "Units/arm5X5A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "mexrun2"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["servmed2"]
                select = ["mexon2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "7.4"
                "buildinggrounddecalsizey", "7.4"
                "buildinggrounddecaltype", "decals/armmoho_aoplane.dds"
                "cvbuildable", "true"
                "metal_extractor", "4.0"
                "model_author", "Hornet"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
                "unitgroup", "metal"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "32768.0"
                "canattack", "true"
                "cloakcost", "20.0"
                "energyupkeep", "20.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "MOBILE"
                "onoffable", "false"
                "selfdestructcountdown", "1.0"
                "sonarstealth", "true"
                "stealth", "true"
                "usepiececollisionvolumes", "1.0"
            ] }

    type Armsilo =
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
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armsilo : Armsilo =
        { name = "armsilo"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 8100.0
          energyCost = ValueOrExpr.Concrete 90000.0
          buildTime = ValueOrExpr.Concrete 178500.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 7.0
          footprintZ = 7.0
          yardMap = "ooooooooooooooooooooooooooooooooooooooooooooooooo"
          weapons = [
                { name = "nuclear_missile"
                  displayName = Some "Intercontinental ballistic nuclear warhead"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "commanders", 2500.0
                      "default", 9500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 72000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 30.0)
                  weaponVelocity = Some 1600.0
                  areaOfEffect = Some 1280.0
                  accuracy = None
                  turret = None
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 1.1
                  noSelfDamage = None
                  soundStart = Some "nukelaunch"
                  soundHit = Some "nukearm"
                  explosiongenerator = Some "custom:newnuke"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "place_target_on_ground", "true"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "cegtag", "NUKETRAIL"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "commandfire", "true"
                      "craterareaofeffect", "1280.0"
                      "craterboost", "2.4"
                      "cratermult", "1.2"
                      "energypershot", "125000.0"
                      "firestarter", "100.0"
                      "flighttime", "400.0"
                      "interceptedbyshieldtype", "0.0"
                      "metalpershot", "1000.0"
                      "model", "crblmssl.s3o"
                      "smokecolor", "0.85"
                      "smokeperiod", "10.0"
                      "smokesize", "28.0"
                      "smoketime", "130.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "true"
                      "soundhitwet", "nukewater"
                      "soundhitwetvolume", "53.0"
                      "soundstartvolume", "20.0"
                      "stockpile", "true"
                      "stockpiletime", "120.0"
                      "targetable", "1.0"
                      "texture1", "null"
                      "texture2", "railguntrail"
                      "texture3", "null"
                      "turnrate", "5500.0"
                      "weaponacceleration", "100.0"
                      "weapontimer", "5.5"
                  ] }
                { name = "nuclear_launch"
                  displayName = Some "Nuclear Launch"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 0.0)
                  reloadTime = Some (ValueOrExpr.Concrete 30.0)
                  weaponVelocity = Some 100.0
                  areaOfEffect = Some 0.0
                  accuracy = None
                  turret = None
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.0
                  impulseFactor = Some 0.0
                  noSelfDamage = None
                  soundStart = None
                  soundHit = Some "nukelaunchalarm"
                  explosiongenerator = None
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "metalpershot", "0.0"
                      "soundhitvolume", "50.0"
                      "turnrate", "10000.0"
                      "weaponacceleration", "101.0"
                      "weapontimer", "0.1"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "90 80 90"
                  collisionVolumeType = Some "CylY"
                  damage = Some 3180.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 40.0
                  metal = Some 4956.0
                  object_ = Some "Units/armsilo_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1590.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 1982.0
                  object_ = Some "Units/arm3X3F.s3o"
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
                ok = ["servroc1"]
                select = ["servroc1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "10.0"
                "buildinggrounddecalsizey", "10.0"
                "buildinggrounddecaltype", "decals/armsilo_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
                "unitgroup", "nuke"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "radardistance", "50.0"
            ] }

    type Armvulc =
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

    let armvulc : Armvulc =
        { name = "armvulc"
          subfolder = "ArmBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 70000.0
          energyCost = ValueOrExpr.Concrete 830000.0
          buildTime = ValueOrExpr.Concrete 1400000.0
          health = ValueOrExpr.Concrete 32000.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 8.0
          footprintZ = 8.0
          yardMap = "oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo"
          canRepeat = false
          weapons = [
                { name = "rflrpc"
                  displayName = Some "Rapid-fire long-range plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 1625.0
                      "shields", 812.0
                      "subs", 500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 5750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.6)
                  weaponVelocity = Some 1100.0
                  areaOfEffect = Some 135.0
                  accuracy = Some 700.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 1.1
                  noSelfDamage = Some true
                  soundStart = Some "lrpcshot3"
                  soundHit = Some "rflrpcexplo"
                  explosiongenerator = Some "custom:genericshellexplosion-huge"
                  rgbColor = Some "1, 0.4, 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "cegtag", "arty-huge"
                      "collidefriendly", "false"
                      "craterboost", "0.1"
                      "cratermult", "0.1"
                      "energypershot", "15000.0"
                      "gravityaffected", "true"
                      "soundhitvolume", "34.0"
                      "soundhitwet", "splshbig"
                      "weapontimer", "14.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-30.100944519 -5.74996727295 19.3314819336"
                  collisionVolumeScales = Some "169.401870728 123.486465454 147.862945557"
                  collisionVolumeType = Some "Box"
                  damage = Some 26000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 7.0
                  footprintZ = Some 7.0
                  height = Some 20.0
                  metal = Some 30000.0
                  object_ = Some "Units/armvulc_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 12000.0
                  featureDead = None
                  footprintX = Some 7.0
                  footprintZ = Some 7.0
                  height = Some 4.0
                  metal = Some 14000.0
                  object_ = Some "Units/arm7X7A.s3o"
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
                ok = ["servlrg3"]
                select = ["servlrg3"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "7.5"
                "buildinggrounddecalsizey", "7.5"
                "buildinggrounddecaltype", "decals/armvulc_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandDefenceOffence"
                "techlevel", "2.0"
                "unitgroup", "weapon"
                "restrictions_inclusion", "_nolrpc_noendgamelrpc_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "29096.0"
                "firestate", "0.0"
                "usepiececollisionvolumes", "1.0"
            ] }

