// Auto-generated BAR unit data: CorBuildings/SeaUtil (flat per-unit types)
namespace BarData.Units

open BarData

module CorBuildings_SeaUtil =

    type Corason =
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

    let corason : Corason =
        { name = "corason"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 160.0
          energyCost = ValueOrExpr.Concrete 2400.0
          buildTime = ValueOrExpr.Concrete 6100.0
          health = ValueOrExpr.Concrete 2400.0
          sightDistance = ValueOrExpr.Concrete 210.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "ooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-2.39038085938 -9.06459454346 0.315093994141"
                  collisionVolumeScales = Some "43.173828125 10.1218109131 43.7690734863"
                  collisionVolumeType = Some "Box"
                  damage = Some 1284.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 99.0
                  object_ = Some "Units/corason_dead.s3o"
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
                select = ["sonar2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/corason_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaUtil"
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

    type Corfatf =
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

    let corfatf : Corfatf =
        { name = "corfatf"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 800.0
          energyCost = ValueOrExpr.Concrete 7500.0
          buildTime = ValueOrExpr.Concrete 10300.0
          health = ValueOrExpr.Concrete 1530.0
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
                  collisionVolumeOffsets = Some "-1.11164093018 -5.62302210693 3.14508056641"
                  collisionVolumeScales = Some "61.8861541748 21.1415557861 54.7463684082"
                  collisionVolumeType = Some "Box"
                  damage = Some 825.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 447.0
                  object_ = Some "Units/corfatf_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 413.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 179.0
                  object_ = Some "Units/cor4X4D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "targsel2"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["targsel2"] }
          customParams = Map.ofList [
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "energyupkeep", "150.0"
                "istargetingupgrade", "true"
                "onoffable", "true"
            ] }

    type Corfdrag =
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

    let corfdrag : Corfdrag =
        { name = "corfdrag"
          subfolder = "CorBuildings/SeaUtil"
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
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "objectify", "true"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaUtil"
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

    type Corfgate =
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

    let corfgate : Corfgate =
        { name = "corfgate"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 4100.0
          energyCost = ValueOrExpr.Concrete 74000.0
          buildTime = ValueOrExpr.Concrete 59000.0
          health = ValueOrExpr.Concrete 4100.0
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
                  object_ = Some "Units/corfgate_dead.s3o"
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
                ok = ["drone1"]
                select = ["drone1"] }
          customParams = Map.ofList [
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "shield_color_mult", "0.8"
                "shield_power", "9500.0"
                "shield_radius", "600.0"
                "subfolder", "CorBuildings/SeaUtil"
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
                "unitname", "corfgate"
            ] }

    type Corfmine3 =
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

    let corfmine3 : Corfmine3 =
        { name = "corfmine3"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 32.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 400.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 71.5
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
                select = ["minesel2"] }
          customParams = Map.ofList [
                "detonaterange", "64"
                "instantselfd", "true"
                "mine", "true"
                "model_author", "Tristan"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaUtil"
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

    type Corfrad =
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

    let corfrad : Corfrad =
        { name = "corfrad"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 114.0
          sightDistance = ValueOrExpr.Concrete 740.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "wwwwwwwww"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-1.90951538086 -2.08381778564 1.08252716064"
                  collisionVolumeScales = Some "41.2277526855 50.2841644287 42.4677886963"
                  collisionVolumeType = Some "Box"
                  damage = Some 62.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 80.0
                  object_ = Some "Units/corfrad_dead.s3o"
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
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaUtil"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "canattack", "false"
                "onoffable", "false"
                "radardistance", "2100.0"
                "radaremitheight", "72.0"
                "sightemitheight", "72.0"
                "sonardistance", "900.0"
            ] }

    type Cornanotc2plat =
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

    let cornanotc2plat : Cornanotc2plat =
        { name = "cornanotc2plat"
          subfolder = "CorBuildings/SeaUtil"
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
                "buildinggrounddecaltype", "decals/cornanotc_aoplane.dds"
                "model_author", "Beherith, Hornet"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/SeaUtil"
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

    type Cornanotcplat =
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

    let cornanotcplat : Cornanotcplat =
        { name = "cornanotcplat"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 5300.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 3.0
          footprintZ = 3.0
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vcormove"]
                select = ["vcorsel"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/cornanotc_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/SeaUtil"
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

    type Corsonar =
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

    let corsonar : Corsonar =
        { name = "corsonar"
          subfolder = "CorBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 20.0
          energyCost = ValueOrExpr.Concrete 450.0
          buildTime = ValueOrExpr.Concrete 900.0
          health = ValueOrExpr.Concrete 58.0
          sightDistance = ValueOrExpr.Concrete 485.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "oooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.230186462402 -5.31005859372e-06 -1.15662384033"
                  collisionVolumeScales = Some "32.5395965576 31.6859893799 26.2655792236"
                  collisionVolumeType = Some "Box"
                  damage = Some 31.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 13.0
                  object_ = Some "Units/corsonar_dead.s3o"
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
                select = ["sonar2"] }
          customParams = Map.ofList [
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/SeaUtil"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "canattack", "false"
                "onoffable", "false"
                "sonardistance", "1200.0"
            ] }

