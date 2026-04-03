// Auto-generated BAR unit data: ArmBuildings/SeaUtil (flat per-unit types)
namespace BarData.Units

open BarData

module ArmBuildings_SeaUtil =

    type Armason =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armason : Armason =
        { name = "armason"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 170.0
          energyCost = ValueOrExpr.Concrete 2600.0
          buildTime = ValueOrExpr.Concrete 6150.0
          health = ValueOrExpr.Concrete 2350.0
          sightDistance = ValueOrExpr.Concrete 215.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "yooy oooo oooo yooy"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-2.53617095947 -6.10351563068e-07 -2.30155944824"
                  collisionVolumeScales = Some "30.2144622803 57.7799987793 23.5352478027"
                  collisionVolumeType = Some "Box"
                  damage = Some 1272.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 40.0
                  metal = Some 106.0
                  object_ = Some "Units/armason_dead.s3o"
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
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["sonar1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/armason_aoplane.dds"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "canattack", "false"
                "onoffable", "false"
                "sonardistance", "1600.0"
            ] }

    type Armfatf =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armfatf : Armfatf =
        { name = "armfatf"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 800.0
          energyCost = ValueOrExpr.Concrete 7300.0
          buildTime = ValueOrExpr.Concrete 9880.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "wwwwwwwwwwwwwwww"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "1.36531829834 -6.85653535156 1.18824005127"
                  collisionVolumeScales = Some "59.4412994385 29.0925292969 58.6490936279"
                  collisionVolumeType = Some "Box"
                  damage = Some 871.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 467.0
                  object_ = Some "Units/armfatf_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 436.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 187.0
                  object_ = Some "Units/arm4X4A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "cmd-on"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["targsel1"] }
          customParams = Map.ofList [
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "16400.0"
                "energyupkeep", "150.0"
                "istargetingupgrade", "true"
                "onoffable", "true"
            ] }

    type Armfdrag =
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

    let armfdrag : Armfdrag =
        { name = "armfdrag"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 15.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 370.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "oooo"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "objectify", "true"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaUtil"
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

    type Armfgate =
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
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armfgate : Armfgate =
        { name = "armfgate"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 3900.0
          energyCost = ValueOrExpr.Concrete 72000.0
          buildTime = ValueOrExpr.Concrete 59000.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 10.0
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.0
          minWaterDepth = 16.0
          waterline = 0.0
          weapons = [
                { name = "sea_repulsor"
                  displayName = Some "NavalPlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.empty
                  range = None
                  reloadTime = None
                  weaponVelocity = None
                  areaOfEffect = None
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = None
                  noSelfDamage = None
                  soundStart = None
                  soundHit = None
                  explosiongenerator = None
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
                      "soundhitwet", "sizzle"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -2.91625976558e-05 -0.414924621582"
                  collisionVolumeScales = Some "57.2399902344 32.5033416748 63.3298492432"
                  collisionVolumeType = Some "Box"
                  damage = Some 1800.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2296.0
                  object_ = Some "Units/armfgate_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 900.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 918.0
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
                ok = ["drone1"]
                select = ["drone1"] }
          customParams = Map.ofList [
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "shield_color_mult", "0.8"
                "shield_power", "9500.0"
                "shield_radius", "600.0"
                "subfolder", "ArmBuildings/SeaUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "onoffable", "true"
                "canattack", "false"
                "exemptcategory", "WEAPON"
                "noautofire", "true"
                "norestrict", "1.0"
                "unitname", "armfgate"
            ] }

    type Armfmine3 =
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
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armfmine3 : Armfmine3 =
        { name = "armfmine3"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 32.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 400.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 78.0
          footprintX = 1.0
          footprintZ = 1.0
          yardMap = "w"
          canRepeat = false
          weapons = [
                { name = "minerange"
                  displayName = Some "Crawlingbomb Dummy Weapon"
                  weaponType = Some "Melee"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 64.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 100000.0
                  areaOfEffect = Some 0.0
                  accuracy = None
                  turret = None
                  tolerance = Some 1000000.0
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
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firesubmersed", "false"
                      "soundhitwet", ""
                      "soundhitwetvolume", "0.0"
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
                select = ["minesel1"] }
          customParams = Map.ofList [
                "detonaterange", "64"
                "instantselfd", "true"
                "mine", "true"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaUtil"
                "unitgroup", "explo"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "false"
                "canguard", "false"
                "canpatrol", "false"
                "cloakcost", "4.0"
                "collide", "false"
                "firestate", "2.0"
                "initcloaked", "true"
                "mincloakdistance", "8.0"
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "0.0"
                "sonarstealth", "true"
                "stealth", "true"
            ] }

    type Armfrad =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armfrad : Armfrad =
        { name = "armfrad"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 110.0
          sightDistance = ValueOrExpr.Concrete 760.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "wwwwwwwww"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -14.8080587891 -0.125"
                  collisionVolumeScales = Some "45.9999694824 25.4694824219 42.75"
                  collisionVolumeType = Some "Box"
                  damage = Some 59.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 40.0
                  metal = Some 83.0
                  object_ = Some "Units/armfrad_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "cmd-on"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["radarselect"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaUtil"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "canattack", "false"
                "onoffable", "false"
                "radardistance", "2100.0"
                "radaremitheight", "52.0"
                "sightemitheight", "52.0"
                "sonardistance", "900.0"
            ] }

    type Armnanotc2plat =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armnanotc2plat : Armnanotc2plat =
        { name = "armnanotc2plat"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 840.0
          energyCost = ValueOrExpr.Concrete 12800.0
          buildTime = ValueOrExpr.Concrete 21000.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armnanotc_aoplane.dds"
                "model_author", "Beherith, Hornet"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/SeaUtil"
                "unitgroup", "builder"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "canassist", "true"
                "canfight", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canreclaim", "true"
                "canstop", "true"
                "cantbetransported", "false"
                "leavesghost", "true"
                "mass", "5100.0"
                "upright", "true"
            ] }

    type Armnanotcplat =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armnanotcplat : Armnanotcplat =
        { name = "armnanotcplat"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 5300.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 3.0
          footprintZ = 3.0
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armnanotc_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/SeaUtil"
                "unitgroup", "builder"
                "usebuildinggrounddecal", "false"
            ]
          extras = Map.ofList [
                "canassist", "true"
                "canfight", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canreclaim", "true"
                "canstop", "true"
                "cantbetransported", "true"
                "leavesghost", "true"
                "mass", "700.0"
                "upright", "true"
            ] }

    type Armsonar =
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
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armsonar : Armsonar =
        { name = "armsonar"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 20.0
          energyCost = ValueOrExpr.Concrete 450.0
          buildTime = ValueOrExpr.Concrete 910.0
          health = ValueOrExpr.Concrete 56.0
          sightDistance = ValueOrExpr.Concrete 515.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "oooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -1.56127929678e-05 -0.0"
                  collisionVolumeScales = Some "31.3499755859 42.5373687744 28.2463684082"
                  collisionVolumeType = Some "Box"
                  damage = Some 30.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 13.0
                  object_ = Some "Units/armsonar_dead.s3o"
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
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["sonar1"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/SeaUtil"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "canattack", "false"
                "onoffable", "false"
                "sonardistance", "1200.0"
            ] }

