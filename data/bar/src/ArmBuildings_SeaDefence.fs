// Auto-generated BAR unit data: ArmBuildings/SeaDefence (flat per-unit types)
namespace BarData.Units

open BarData

module ArmBuildings_SeaDefence =

    type Armatl =
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

    let armatl : Armatl =
        { name = "armatl"
          subfolder = "ArmBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 8500.0
          buildTime = ValueOrExpr.Concrete 9260.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 585.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "oooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "armatl_torpedo"
                  displayName = Some "Heavy long-range homing torpedo launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 780.0
                  ]
                  range = Some (ValueOrExpr.Concrete 915.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.166)
                  weaponVelocity = Some 380.0
                  areaOfEffect = Some 32.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 1167.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep1"
                  explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "HOVER NOTSHIP"
                      "mount_onlytargetcategory", "NOTHOVER"
                      "avoidfriendly", "true"
                      "burnblow", "true"
                      "cegtag", "torpedotrail-small"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "model", "torpedo.s3o"
                      "startvelocity", "80.0"
                      "tracks", "true"
                      "turnrate", "20000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "60.0"
                      "weapontimer", "10.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "4.35404205322 2.4731445313e-05 -0.341720581055"
                  collisionVolumeScales = Some "38.3841400146 24.7794494629 44.2891235352"
                  collisionVolumeType = Some "Box"
                  damage = Some 312.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 548.0
                  object_ = Some "Units/armatl_dead.s3o"
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
                ok = ["torpadv2"]
                select = ["torpadv2"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaDefence"
                "techlevel", "2.0"
                "unitgroup", "sub"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "sonardistance", "400.0"
            ] }

    type Armdl =
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

    let armdl : Armdl =
        { name = "armdl"
          subfolder = "ArmBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 2200.0
          buildTime = ValueOrExpr.Concrete 6000.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 617.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "yyyyyooyyooyyyyy"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "coax_depthcharge"
                  displayName = Some "Depthcharge launcher"
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
                      "model", "cordepthcharge.s3o"
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
                  collisionVolumeOffsets = Some "2.08366394043 -8.3923 4.63167572021"
                  collisionVolumeScales = Some "46.5937194824 41.0 51.689743042"
                  collisionVolumeType = Some "Box"
                  damage = Some 609.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 30.0
                  metal = Some 176.0
                  object_ = Some "Units/armdl_dead.s3o"
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecaltype", "decals/armdl_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaDefence"
                "unitgroup", "sub"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "sonardistance", "600.0"
            ] }

    type Armfflak =
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

    let armfflak : Armfflak =
        { name = "armfflak"
          subfolder = "ArmBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 850.0
          energyCost = ValueOrExpr.Concrete 23000.0
          buildTime = ValueOrExpr.Concrete 21900.0
          health = ValueOrExpr.Concrete 1920.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "wwwwwwwww"
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
                  weaponVelocity = Some 2450.0
                  areaOfEffect = Some 192.0
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
                      "size", "4.5"
                      "sizedecay", "0.08"
                      "soundhitwet", "splslrg"
                      "stages", "8.0"
                      "weapontimer", "1.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.25456237793 -3.1726487793 0.162696838379"
                  collisionVolumeScales = Some "33.5091247559 30.6275024414 44.9046173096"
                  collisionVolumeType = Some "Box"
                  damage = Some 1038.0
                  featureDead = None
                  footprintX = Some 1.0
                  footprintZ = Some 1.0
                  height = Some 20.0
                  metal = Some 525.0
                  object_ = Some "Units/armfflak_dead.s3o"
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
                ok = ["twrturn3"]
                select = ["twrturn3"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaDefence"
                "techlevel", "2.0"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "1000.0"
                "buildangle", "16384.0"
            ] }

    type Armfhlt =
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

    let armfhlt : Armfhlt =
        { name = "armfhlt"
          subfolder = "ArmBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 470.0
          energyCost = ValueOrExpr.Concrete 6200.0
          buildTime = ValueOrExpr.Concrete 9670.0
          health = ValueOrExpr.Concrete 4250.0
          sightDistance = ValueOrExpr.Concrete 630.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "wwwwwwwwwwwwwwww"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "armfhlt_laser"
                  displayName = Some "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 300.0
                      "default", 210.0
                      "vtol", 52.0
                  ]
                  range = Some (ValueOrExpr.Concrete 630.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 8.0
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
                      "corethickness", "0.18"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "40.0"
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
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -3.6047363281e-05 -7.62939453125e-06"
                  collisionVolumeScales = Some "50.0 45.7867279053 45.9999847412"
                  collisionVolumeType = Some "Box"
                  damage = Some 2302.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 341.0
                  object_ = Some "Units/armfhlt_dead.s3o"
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
                ok = ["twractv3"]
                select = ["twractv3"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaDefence"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "nochasecategory", "MOBILE"
            ] }

    type Armfrock =
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

    let armfrock : Armfrock =
        { name = "armfrock"
          subfolder = "ArmBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 360.0
          energyCost = ValueOrExpr.Concrete 5700.0
          buildTime = ValueOrExpr.Concrete 5810.0
          health = ValueOrExpr.Concrete 1330.0
          sightDistance = ValueOrExpr.Concrete 468.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "wwwwwwwwwwwwwwww"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "aamissile"
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
                      "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
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
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.10124206543 -0.0500075439453 1.15520477295"
                  collisionVolumeScales = Some "41.2024536133 67.0857849121 50.3104095459"
                  collisionVolumeType = Some "Box"
                  damage = Some 1280.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 40.0
                  metal = Some 240.0
                  object_ = Some "Units/armfrt_dead.s3o"
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
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaDefence"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "750.0"
                "buildangle", "16384.0"
                "nochasecategory", "ALL"
            ] }

    type Armfrt =
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

    let armfrt : Armfrt =
        { name = "armfrt"
          subfolder = "ArmBuildings/SeaDefence"
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
                { name = "armrl_missile"
                  displayName = Some "Missiles"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 115.0
                  ]
                  range = Some (ValueOrExpr.Concrete 765.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.2)
                  weaponVelocity = Some 750.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.75
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
                      "flighttime", "1.75"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "proximitypriority", "1.0"
                      "smokecolor", "0.95"
                      "smokeperiod", "5.0"
                      "smokesize", "4.8"
                      "smoketime", "12.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splssml"
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
                  collisionVolumeOffsets = Some "0.10124206543 -0.0500075439453 1.15520477295"
                  collisionVolumeScales = Some "41.2024536133 67.0857849121 50.3104095459"
                  collisionVolumeType = Some "Box"
                  damage = Some 151.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 40.0
                  metal = Some 46.0
                  object_ = Some "Units/armfrt_dead.s3o"
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
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaDefence"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "750.0"
                "buildangle", "16384.0"
                "nochasecategory", "ALL"
            ] }

    type Armgplat =
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

    let armgplat : Armgplat =
        { name = "armgplat"
          subfolder = "ArmBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 110.0
          energyCost = ValueOrExpr.Concrete 900.0
          buildTime = ValueOrExpr.Concrete 2860.0
          health = ValueOrExpr.Concrete 760.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "wwwwwwwwwwwwwwww"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "gun"
                  displayName = Some "Light g2g plasma cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 97.0
                      "vtol", 18.0
                  ]
                  range = Some (ValueOrExpr.Concrete 520.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.5)
                  weaponVelocity = Some 500.0
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
                      "cegtag", "arty-fast"
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
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -6.6047363281e-05 -15.62939453125e-06"
                  collisionVolumeScales = Some "50.0 45.7867279053 45.9999847412"
                  collisionVolumeType = Some "Box"
                  damage = Some 750.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 80.0
                  object_ = Some "Units/armgplat_dead.s3o"
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
                ok = ["twractv3"]
                select = ["twractv3"] }
          customParams = Map.ofList [
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaDefence"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "nochasecategory", "MOBILE"
            ] }

    type Armkraken =
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

    let armkraken : Armkraken =
        { name = "armkraken"
          subfolder = "ArmBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 13000.0
          buildTime = ValueOrExpr.Concrete 20000.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 5.0
          footprintZ = 5.0
          yardMap = "wwwww wwwww wwwww wwwww wwwww"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "armmech_cannon"
                  displayName = Some "Rapid-fire gauss cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 180.0
                      "vtol", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.35)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy2"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "arty-small"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "5.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splshbig"
                      "targetmoveerror", "0.15"
                      "weapontimer", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -15 0"
                  collisionVolumeScales = Some "84 60 84"
                  collisionVolumeType = Some "Box"
                  damage = Some 4000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 500.0
                  object_ = Some "Units/armkraken_dead.s3o"
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
                  metal = Some 250.0
                  object_ = Some "Units/cor3X3E.s3o"
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
                "model_author", "Zecrus"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaDefence"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "nochasecategory", "MOBILE"
            ] }

    type Armnavaldefturret =
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

    let armnavaldefturret : Armnavaldefturret =
        { name = "armnavaldefturret"
          subfolder = "ArmBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 15000.0
          health = ValueOrExpr.Concrete 5190.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 5.0
          footprintZ = 5.0
          yardMap = "ooooooooooooooooooooooooo"
          canRepeat = false
          weapons = [
                { name = "arm_medium_gauss_cannon"
                  displayName = Some "Dual Medium Plasma Gauss Cannons"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 730.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 18.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 6000.0
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
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "SURFACE"
                      "alphadecay", "0.08"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
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
                  collisionVolumeScales = Some "70 60 70"
                  collisionVolumeType = Some "CylY"
                  damage = Some 2500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 50.0
                  metal = Some 350.0
                  object_ = Some "Units/armnavaldefturret_dead.s3o"
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
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaDefence"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "airsightdistance", "650.0"
                "buildangle", "32768.0"
                "mass", "9500.0"
            ] }

    type Armtl =
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

    let armtl : Armtl =
        { name = "armtl"
          subfolder = "ArmBuildings/SeaDefence"
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
                  displayName = Some "Level1TorpedoLauncher"
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
                      "model", "cortorpedo.s3o"
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
                  collisionVolumeOffsets = Some "0.25 -4.24193335938 -0.393661499023"
                  collisionVolumeScales = Some "32.1499938965 9.51611328125 31.9671630859"
                  collisionVolumeType = Some "Box"
                  damage = Some 870.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 70.0
                  object_ = Some "Units/armtl_dead.s3o"
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
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaDefence"
                "unitgroup", "sub"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "sonardistance", "400.0"
            ] }

