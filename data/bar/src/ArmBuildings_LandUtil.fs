// Auto-generated BAR unit data: ArmBuildings/LandUtil (flat per-unit types)
namespace BarData.Units

open BarData

module ArmBuildings_LandUtil =

    type Armarad =
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

    let armarad : Armarad =
        { name = "armarad"
          subfolder = "ArmBuildings/LandUtil"
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
                  collisionVolumeOffsets = Some "6.23959350586 -0.334806103516 -0.00547027587891"
                  collisionVolumeScales = Some "37.4791870117 33.549987793 30.0109405518"
                  collisionVolumeType = Some "Box"
                  damage = Some 192.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 40.0
                  metal = Some 341.0
                  object_ = Some "Units/armarad_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 96.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 136.0
                  object_ = Some "Units/arm2X2C.s3o"
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
                select = ["radadvn1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "3.6"
                "buildinggrounddecalsizey", "3.6"
                "buildinggrounddecaltype", "decals/armarad_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "canattack", "false"
                "onoffable", "false"
                "radardistance", "3500.0"
                "radaremitheight", "66.0"
                "sightemitheight", "40.0"
                "usepiececollisionvolumes", "0.0"
            ] }

    type Armdf =
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
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armdf : Armdf =
        { name = "armdf"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 270.0
          energyCost = ValueOrExpr.Concrete 100.0
          buildTime = ValueOrExpr.Concrete 7500.0
          health = ValueOrExpr.Concrete 3800.0
          sightDistance = ValueOrExpr.Concrete 210.0
          footprintX = 6.0
          footprintZ = 5.0
          yardMap = "oooooo oooooo oooooo oooooo oooooo"
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.420112609863 0.0956184448242 -0.353080749512"
                  collisionVolumeScales = Some "98.7820892334 38.6634368896 65.8547515869"
                  collisionVolumeType = Some "Box"
                  damage = Some 2790.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 4.0
                  height = Some 40.0
                  metal = Some 222.0
                  object_ = Some "Units/armfus_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1395.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 89.0
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
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["fusion1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecaltype", "decals/armfus_aoplane.dds"
                "decoyfor", "armfus"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
                "restrictions_inclusion", "_nofusion_"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "decoyfor", "armfus"
                "hidedamage", "true"
            ] }

    type Armdrag =
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

    let armdrag : Armdrag =
        { name = "armdrag"
          subfolder = "ArmBuildings/LandUtil"
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
                  object_ = Some "Units/arm1X1B.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecaltype", "decals/armdrag_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "objectify", "true"
                "paralyzemultiplier", "0.0"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandUtil"
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

    type Armeyes =
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

    let armeyes : Armeyes =
        { name = "armeyes"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 32.0
          energyCost = ValueOrExpr.Concrete 850.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 280.0
          sightDistance = ValueOrExpr.Concrete 560.0
          footprintX = 1.0
          footprintZ = 1.0
          yardMap = "o"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dragonseyes_dead",
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
                ok = ["servsml6"]
                select = ["minesel1"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandUtil"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "cloakcost", "10.0"
                "energyupkeep", "3.0"
                "initcloaked", "true"
                "levelground", "false"
                "mincloakdistance", "36.0"
                "stealth", "true"
            ] }

    type Armfort =
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

    let armfort : Armfort =
        { name = "armfort"
          subfolder = "ArmBuildings/LandUtil"
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
                  object_ = Some "Units/arm1X1A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecaltype", "decals/armfort_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "objectify", "true"
                "paralyzemultiplier", "0.0"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandUtil"
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

    type Armgate =
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

    let armgate : Armgate =
        { name = "armgate"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 3000.0
          energyCost = ValueOrExpr.Concrete 54000.0
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
                  collisionVolumeOffsets = Some "0.0 -2.91625976558e-05 -0.414924621582"
                  collisionVolumeScales = Some "57.2399902344 32.5033416748 63.3298492432"
                  collisionVolumeType = Some "Box"
                  damage = Some 1900.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2000.0
                  object_ = Some "Units/armgate_dead.s3o"
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
                  metal = Some 800.0
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/armgate_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "shield_color_mult", "0.8"
                "shield_power", "6175.0"
                "shield_radius", "550.0"
                "subfolder", "ArmBuildings/LandUtil"
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

    type Armjamt =
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

    let armjamt : Armjamt =
        { name = "armjamt"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 8500.0
          buildTime = ValueOrExpr.Concrete 9950.0
          health = ValueOrExpr.Concrete 790.0
          sightDistance = ValueOrExpr.Concrete 195.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "oooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-7.62939453125e-06 -2.49999949951 -0.0"
                  collisionVolumeScales = Some "28.2096405029 67.270401001 28.2096252441"
                  collisionVolumeType = Some "Box"
                  damage = Some 427.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 3.0
                  metal = Some 147.0
                  object_ = Some "Units/armjamt_dead.s3o"
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
                select = ["radjam1"] }
          customParams = Map.ofList [
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandUtil"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "buildangle", "4400.0"
                "canattack", "false"
                "energyupkeep", "40.0"
                "onoffable", "true"
                "radardistancejam", "500.0"
            ] }

    type Armmine1 =
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

    let armmine1 : Armmine1 =
        { name = "armmine1"
          subfolder = "ArmBuildings/LandUtil"
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
                "subfolder", "ArmBuildings/LandUtil"
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

    type Armmine2 =
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

    let armmine2 : Armmine2 =
        { name = "armmine2"
          subfolder = "ArmBuildings/LandUtil"
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
                select = ["minesel1"] }
          customParams = Map.ofList [
                "detonaterange", "64"
                "instantselfd", "true"
                "mine", "true"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandUtil"
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

    type Armmine3 =
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

    let armmine3 : Armmine3 =
        { name = "armmine3"
          subfolder = "ArmBuildings/LandUtil"
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
                select = ["minesel1"] }
          customParams = Map.ofList [
                "detonaterange", "64"
                "instantselfd", "true"
                "mine", "true"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandUtil"
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

    type Armnanotc =
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

    let armnanotc : Armnanotc =
        { name = "armnanotc"
          subfolder = "ArmBuildings/LandUtil"
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
                "subfolder", "ArmBuildings/LandUtil"
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

    type Armnanotct2 =
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

    let armnanotct2 : Armnanotct2 =
        { name = "armnanotct2"
          subfolder = "ArmBuildings/LandUtil"
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
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/LandUtil"
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

    type Armrad =
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

    let armrad : Armrad =
        { name = "armrad"
          subfolder = "ArmBuildings/LandUtil"
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
                  collisionVolumeOffsets = Some "-1.52809143066 -0.0377662597656 8.02375793457"
                  collisionVolumeScales = Some "46.8276062012 74.2716674805 38.2336730957"
                  collisionVolumeType = Some "Box"
                  damage = Some 49.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 35.0
                  object_ = Some "Units/armrad_dead.s3o"
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
                  object_ = Some "Units/arm2X2A.s3o"
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
                "buildinggrounddecaltype", "decals/armrad_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandUtil"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "canattack", "false"
                "cantbetransported", "false"
                "mass", "5100.0"
                "onoffable", "false"
                "radardistance", "2100.0"
                "radaremitheight", "66.0"
                "sightemitheight", "66.0"
                "usepiececollisionvolumes", "0.0"
            ] }

    type Armsd =
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

    let armsd : Armsd =
        { name = "armsd"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 710.0
          energyCost = ValueOrExpr.Concrete 7100.0
          buildTime = ValueOrExpr.Concrete 11900.0
          health = ValueOrExpr.Concrete 2650.0
          sightDistance = ValueOrExpr.Concrete 240.0
          footprintX = 4.0
          footprintZ = 4.0
          yardMap = "oooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "1.95468139648 -4.13748790283 4.81853485107"
                  collisionVolumeScales = Some "63.6464233398 24.2004241943 64.3273773193"
                  collisionVolumeType = Some "Box"
                  damage = Some 1440.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 15.0
                  metal = Some 566.0
                  object_ = Some "Units/armsd_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 720.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 227.0
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "6.0"
                "buildinggrounddecalsizey", "6.0"
                "buildinggrounddecaltype", "decals/armsd_aoplane.dds"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandUtil"
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

    type Armtarg =
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

    let armtarg : Armtarg =
        { name = "armtarg"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 810.0
          energyCost = ValueOrExpr.Concrete 7200.0
          buildTime = ValueOrExpr.Concrete 8700.0
          health = ValueOrExpr.Concrete 2100.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "ooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "55 80 55"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1140.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 492.0
                  object_ = Some "Units/armtarg_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 570.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 197.0
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
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecaltype", "decals/armtarg_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandUtil"
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

    type Armveil =
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

    let armveil : Armveil =
        { name = "armveil"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 19000.0
          buildTime = ValueOrExpr.Concrete 9100.0
          health = ValueOrExpr.Concrete 830.0
          sightDistance = ValueOrExpr.Concrete 155.0
          footprintX = 3.0
          footprintZ = 3.0
          yardMap = "ooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-7.16355133057 1.47216796904e-05 -4.91466522217"
                  collisionVolumeScales = Some "47.5629425049 83.2464294434 33.8293304443"
                  collisionVolumeType = Some "Box"
                  damage = Some 450.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 20.0
                  metal = Some 77.0
                  object_ = Some "Units/armveil_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 225.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 31.0
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
                select = ["radjam1"] }
          customParams = Map.ofList [
                "buildinggrounddecaldecayspeed", "30.0"
                "buildinggrounddecalsizex", "4.0"
                "buildinggrounddecalsizey", "4.0"
                "buildinggrounddecaltype", "decals/armveil_aoplane.dds"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "ArmBuildings/LandUtil"
                "techlevel", "2.0"
                "unitgroup", "util"
                "usebuildinggrounddecal", "true"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "canattack", "false"
                "energyupkeep", "125.0"
                "onoffable", "true"
                "radardistancejam", "760.0"
            ] }

