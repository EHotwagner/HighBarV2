// Auto-generated BAR unit data: CorBuildings/LandUtil (flat per-unit types)
namespace BarData.Units

open BarData

module CorBuildings_LandUtil =

    type Corarad =
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

    let corarad : Corarad =
        { name = "corarad"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 14000.0
          buildTime = ValueOrExpr.Concrete 8000.0
          health = ValueOrExpr.Concrete 500.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "oooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0 "
                  collisionVolumeScales = Some "37.4503479004 89.5777740479 30.4736785889"
                  collisionVolumeType = Some "Cyly"
                  damage = Some 198.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 339.0
                  object_ = Some "Units/corarad_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 99.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 136.0
                  object_ = Some "Units/cor3X3C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = Some "radar2"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["radadvn2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecaltype", "decals/corarad_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "canattack", "false"
                "onoffable", "false"
                "radardistance", "3500.0"
                "radaremitheight", "87.0"
                "sightemitheight", "87.0"
            ] }

    type Cordrag =
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
          featureDefs: Map<string, FeatureDef>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cordrag : Cordrag =
        { name = "cordrag"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 8.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "ffff"
          canRepeat = false
          featureDefs = Map.ofList [
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
                  object_ = Some "Units/cor1X1A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecaltype", "decals/cordrag_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "objectify", "true"
                "paralyzemultiplier", "0.0"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandUtil"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "crushresistance", "250.0"
                "hidedamage", "true"
                "levelground", "false"
                "repairable", "false"
                "selfdestructcountdown", "1.0"
            ] }

    type Coreyes =
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

    let coreyes : Coreyes =
        { name = "coreyes"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 32.0
          energyCost = ValueOrExpr.Concrete 850.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 280.0
          sightDistance = ValueOrExpr.Concrete 540.0
          footprintX = 1.0
          footprintZ = 1.0
          yardMap = "o"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "cdragonseyes_dead",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = Some "-0.0323944091797 0.0 0.00588226318359"
                  collisionVolumeScales = Some "21.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 120.0
                  featureDead = None
                  footprintX = Some 1.0
                  footprintZ = Some 1.0
                  height = Some 4.0
                  metal = Some 12.0
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
                ok = ["servsml6"]
                select = ["minesel2"] }
          customParams = Map.ofList [
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandUtil"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "cloakcost", "10.0"
                "energyupkeep", "5.0"
                "initcloaked", "true"
                "levelground", "false"
                "mincloakdistance", "36.0"
                "stealth", "true"
            ] }

    type Corfort =
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
          featureDefs: Map<string, FeatureDef>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corfort : Corfort =
        { name = "corfort"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 500.0
          buildTime = ValueOrExpr.Concrete 900.0
          health = ValueOrExpr.Concrete 8900.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "ffff"
          canRepeat = false
          featureDefs = Map.ofList [
                "rockteethx",
                { blocking = Some true
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 3000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 7.0
                  object_ = Some "Units/cor1X1B.s3o"
                  reclaimable = Some true
                  resurrectable = None }
            ]
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecaltype", "decals/corfort_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "objectify", "true"
                "paralyzemultiplier", "0.0"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "buildangle", "0.0"
                "canattack", "false"
                "crushresistance", "1000.0"
                "hidedamage", "true"
                "levelground", "false"
                "repairable", "false"
                "selfdestructcountdown", "1.0"
            ] }

    type Corgate =
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

    let corgate : Corgate =
        { name = "corgate"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 3200.0
          energyCost = ValueOrExpr.Concrete 55000.0
          buildTime = ValueOrExpr.Concrete 55000.0
          health = ValueOrExpr.Concrete 3550.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          energyStorage = 1000.0
          yardMap = "oooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "repulsor"
                  displayName = Some "PlasmaRepulsor"
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
                  collisionVolumeOffsets = Some "0.0 -0.00271934814453 -1.05072021484"
                  collisionVolumeScales = Some "65.7474060059 27.1259613037 55.6685791016"
                  collisionVolumeType = Some "Box"
                  damage = Some 1900.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2000.0
                  object_ = Some "Units/corgate_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 960.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 800.0
                  object_ = Some "Units/cor2X2E.s3o"
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
                "buildinggrounddecaltype", "decals/corgate_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "shield_color_mult", "0.8"
                "shield_power", "6175.0"
                "shield_radius", "550.0"
                "subfolder", "CorBuildings/LandUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "onoffable", "true"
                "canattack", "false"
                "exemptcategory", "WEAPON"
                "noautofire", "true"
            ] }

    type Corjamt =
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

    let corjamt : Corjamt =
        { name = "corjamt"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 100.0
          energyCost = ValueOrExpr.Concrete 4500.0
          buildTime = ValueOrExpr.Concrete 4000.0
          health = ValueOrExpr.Concrete 1070.0
          sightDistance = ValueOrExpr.Concrete 104.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "oooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -2 0"
                  collisionVolumeScales = Some "30 35 30"
                  collisionVolumeType = Some "CylY"
                  damage = Some 576.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 3.0
                  metal = Some 71.0
                  object_ = Some "Units/corjamt_dead.s3o"
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
                ok = ["kbcormov"]
                select = ["radjam2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "3.6"
                "buildinggrounddecalsizey", "3.6"
                "buildinggrounddecaltype", "decals/corjamt_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandUtil"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "9821.0"
                "canattack", "false"
                "energyupkeep", "25.0"
                "onoffable", "true"
                "radardistancejam", "360.0"
            ] }

    type Cormine1 =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cormine1 : Cormine1 =
        { name = "cormine1"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 7.0
          energyCost = ValueOrExpr.Concrete 270.0
          buildTime = ValueOrExpr.Concrete 100.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 83.2
          footprintX = 1.0
          footprintZ = 1.0
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
                  soundHit = Some "minexpl1"
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
                "subfolder", "CorBuildings/LandUtil"
                "unitgroup", "explo"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "false"
                "canguard", "false"
                "canpatrol", "false"
                "cloakcost", "1.0"
                "collide", "false"
                "firestate", "2.0"
                "initcloaked", "true"
                "levelground", "false"
                "mincloakdistance", "30.0"
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "0.0"
                "stealth", "true"
            ] }

    type Cormine2 =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cormine2 : Cormine2 =
        { name = "cormine2"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 1050.0
          buildTime = ValueOrExpr.Concrete 300.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 83.2
          footprintX = 1.0
          footprintZ = 1.0
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
                "subfolder", "CorBuildings/LandUtil"
                "unitgroup", "explo"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "false"
                "canguard", "false"
                "canpatrol", "false"
                "cloakcost", "2.0"
                "collide", "false"
                "firestate", "2.0"
                "initcloaked", "true"
                "levelground", "false"
                "mincloakdistance", "30.0"
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "0.0"
                "stealth", "true"
            ] }

    type Cormine3 =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cormine3 : Cormine3 =
        { name = "cormine3"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 50.0
          energyCost = ValueOrExpr.Concrete 2800.0
          buildTime = ValueOrExpr.Concrete 700.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 83.2
          footprintX = 1.0
          footprintZ = 1.0
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
                "subfolder", "CorBuildings/LandUtil"
                "unitgroup", "explo"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "false"
                "canguard", "false"
                "canpatrol", "false"
                "cloakcost", "6.0"
                "collide", "false"
                "firestate", "2.0"
                "initcloaked", "true"
                "levelground", "false"
                "mincloakdistance", "30.0"
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "0.0"
                "stealth", "true"
            ] }

    type Cormine4 =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cormine4 : Cormine4 =
        { name = "cormine4"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 16.0
          energyCost = ValueOrExpr.Concrete 1050.0
          buildTime = ValueOrExpr.Concrete 200.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 83.2
          footprintX = 1.0
          footprintZ = 1.0
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
                "subfolder", "CorBuildings/LandUtil"
                "unitgroup", "explo"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "false"
                "canguard", "false"
                "canpatrol", "false"
                "cloakcost", "1.0"
                "collide", "false"
                "firestate", "2.0"
                "initcloaked", "true"
                "levelground", "false"
                "mincloakdistance", "8.0"
                "nochasecategory", "VTOL"
                "selfdestructcountdown", "0.0"
                "stealth", "true"
            ] }

    type Cornanotc =
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

    let cornanotc : Cornanotc =
        { name = "cornanotc"
          subfolder = "CorBuildings/LandUtil"
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
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandUtil"
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
                "mass", "700.0"
                "upright", "true"
            ] }

    type Cornanotct2 =
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

    let cornanotct2 : Cornanotct2 =
        { name = "cornanotct2"
          subfolder = "CorBuildings/LandUtil"
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
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/LandUtil"
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

    type Corrad =
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

    let corrad : Corrad =
        { name = "corrad"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 60.0
          energyCost = ValueOrExpr.Concrete 630.0
          buildTime = ValueOrExpr.Concrete 1140.0
          health = ValueOrExpr.Concrete 180.0
          sightDistance = ValueOrExpr.Concrete 680.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "oooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.353988647461 -0.0323567626953 1.37395477295"
                  collisionVolumeScales = Some "34.8413696289 57.1648864746 30.8629608154"
                  collisionVolumeType = Some "Box"
                  damage = Some 49.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 36.0
                  object_ = Some "Units/corrad_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 25.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 14.0
                  object_ = Some "Units/cor2X2D.s3o"
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
                select = ["radarselect"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecaltype", "decals/corrad_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandUtil"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "16000.0"
                "canattack", "false"
                "cantbetransported", "false"
                "mass", "5100.0"
                "onoffable", "false"
                "radardistance", "2100.0"
                "radaremitheight", "72.0"
                "sightemitheight", "72.0"
            ] }

    type Corsd =
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

    let corsd : Corsd =
        { name = "corsd"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 6700.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 225.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "oooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-1.15772247314 -1.86200052979 2.43579101563"
                  collisionVolumeScales = Some "68.8967437744 12.3805389404 66.8254699707"
                  collisionVolumeType = Some "Box"
                  damage = Some 1500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 15.0
                  metal = Some 584.0
                  object_ = Some "Units/corsd_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 750.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 234.0
                  object_ = Some "Units/cor4X4A.s3o"
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/corsd_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "energyupkeep", "125.0"
                "levelground", "false"
                "onoffable", "true"
                "seismicdistance", "2000.0"
            ] }

    type Corshroud =
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

    let corshroud : Corshroud =
        { name = "corshroud"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 20000.0
          buildTime = ValueOrExpr.Concrete 9400.0
          health = ValueOrExpr.Concrete 890.0
          sightDistance = ValueOrExpr.Concrete 155.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "oooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-7.38106536865 2.64404296892e-05 2.18940734863"
                  collisionVolumeScales = Some "57.2317047119 61.2454528809 48.0499572754"
                  collisionVolumeType = Some "Box"
                  damage = Some 480.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 81.0
                  object_ = Some "Units/corshroud_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 240.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 32.0
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
                select = ["radjam2"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "3.8"
                "buildinggrounddecalsizey", "3.8"
                "buildinggrounddecaltype", "decals/corshroud_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "canattack", "false"
                "energyupkeep", "125.0"
                "onoffable", "true"
                "radardistancejam", "700.0"
            ] }

    type Cortarg =
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

    let cortarg : Cortarg =
        { name = "cortarg"
          subfolder = "CorBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 800.0
          energyCost = ValueOrExpr.Concrete 7500.0
          buildTime = ValueOrExpr.Concrete 10900.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 4.0
          yardMap = "oooooooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.625 -3.66210937486e-06 -0.246391296387"
                  collisionVolumeScales = Some "62.75 20.2424926758 64.4927825928"
                  collisionVolumeType = Some "Box"
                  damage = Some 1080.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 487.0
                  object_ = Some "Units/cortarg_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 540.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 195.0
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/cortarg_aoplane.dds"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "CorBuildings/LandUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "energyupkeep", "100.0"
                "istargetingupgrade", "true"
                "onoffable", "true"
            ] }

