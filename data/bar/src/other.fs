// Auto-generated BAR unit data: other (flat per-unit types)
namespace BarData.Units

open BarData

module other =

    type Armrespawn =
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

    let armrespawn : Armrespawn =
        { name = "armrespawn"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 20000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Expr "range"
          footprintX = 6.0
          footprintZ = 6.0
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
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/armnanotc_aoplane.dds"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/SeaUtil"
            ]
          extras = Map.ofList [
                "canassist", "true"
                "canfight", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canreclaim", "true"
                "canstop", "true"
                "cantbetransported", "true"
                "mass", "700.0"
                "upright", "true"
            ] }

    type Armsat =
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
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          cruiseAltitude: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armsat : Armsat =
        { name = "armsat"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 4000.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 12800.0
          health = ValueOrExpr.Concrete 780.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.05
          maxDec = 0.01
          turnRate = 80.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 2700.0
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolarmv"]
                select = ["aaradsel"] }
          customParams = Map.ofList [
                "unitgroup", "util"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "other"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "acceleration", "0.05"
                "airhoverfactor", "0.4"
                "blocking", "false"
                "capturable", "false"
                "collide", "false"
                "hoverattack", "true"
                "maxaileron", "0.01"
                "maxbank", "0.15"
                "maxelevator", "0.004"
                "maxpitch", "0.1"
                "maxrudder", "0.003"
                "radardistance", "700.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonardistance", "0.0"
                "speedtofront", "0.04"
                "turnradius", "200.0"
                "usesmoothmesh", "true"
                "wingangle", "0.05"
                "wingdrag", "0.1"
            ] }

    type Chip =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let chip : Chip =
        { name = "chip"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "unitgroup", "util"
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "25.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    type Correspawn =
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

    let correspawn : Correspawn =
        { name = "correspawn"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 20000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Expr "range"
          footprintX = 6.0
          footprintZ = 6.0
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
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/cornanotc_aoplane.dds"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorBuildings/SeaUtil"
            ]
          extras = Map.ofList [
                "canassist", "true"
                "canfight", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canreclaim", "true"
                "canstop", "true"
                "cantbetransported", "true"
                "mass", "700.0"
                "upright", "true"
            ] }

    type Corsat =
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
          maxWaterDepth: float
          canFly: bool
          canMove: bool
          cruiseAltitude: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corsat : Corsat =
        { name = "corsat"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 4000.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 12800.0
          health = ValueOrExpr.Concrete 780.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.05
          maxDec = 0.01
          turnRate = 80.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 2700.0
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolcrmv"]
                select = ["aaradsel"] }
          customParams = Map.ofList [
                "unitgroup", "util"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "acceleration", "0.05"
                "airhoverfactor", "0.4"
                "blocking", "false"
                "capturable", "false"
                "collide", "false"
                "hoverattack", "true"
                "maxaileron", "0.01"
                "maxbank", "0.15"
                "maxelevator", "0.004"
                "maxpitch", "0.1"
                "maxrudder", "0.003"
                "radardistance", "580.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonardistance", "0.0"
                "speedtofront", "0.04"
                "turnradius", "200.0"
                "usesmoothmesh", "true"
                "wingangle", "0.05"
                "wingdrag", "0.1"
            ] }

    type Dbg_sphere =
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
          customParams: Map<string, string>
          extras: Map<string, string> }

    let dbg_sphere : Dbg_sphere =
        { name = "dbg_sphere"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 3400.0
          buildTime = ValueOrExpr.Concrete 5090.0
          health = ValueOrExpr.Concrete 940.0
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
          customParams = Map.ofList [
                "model_author", "Beherith"
                "nohealthbars", "true"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "autoheal", "15.0"
                "capturable", "false"
                "mygravity", "10000.0"
                "nochasecategory", "ALL"
                "stealth", "true"
                "strafetoattack", "true"
            ] }

    type Dbg_sphere_fullmetal =
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
          customParams: Map<string, string>
          extras: Map<string, string> }

    let dbg_sphere_fullmetal : Dbg_sphere_fullmetal =
        { name = "dbg_sphere_fullmetal"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 3400.0
          buildTime = ValueOrExpr.Concrete 5090.0
          health = ValueOrExpr.Concrete 940.0
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
          customParams = Map.ofList [
                "model_author", "Beherith"
                "nohealthbars", "true"
                "normaltex", "unittextures/blank_normal.dds"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "autoheal", "15.0"
                "capturable", "false"
                "mygravity", "10000.0"
                "nochasecategory", "ALL"
                "stealth", "true"
                "strafetoattack", "true"
            ] }

    type Dice =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let dice : Dice =
        { name = "dice"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "50.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    type Freefusion =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let freefusion : Freefusion =
        { name = "freefusion"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 50.0
          buildTime = ValueOrExpr.Concrete 800.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 250.0
          footprintX = 5.0
          footprintZ = 5.0
          energyMake = ValueOrExpr.Concrete 850.0
          energyStorage = 150.0
          yardMap = "ooooooooooooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 2500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 30.0
                  object_ = Some "Units/freefusion_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1350.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 5.0
                  metal = Some 10.0
                  object_ = Some "Units/arm5X5A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          customParams = Map.ofList [
                "removestop", "true"
                "removewait", "true"
                "subfolder", "other"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
            ] }

    type Legnanotcbase =
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

    let legnanotcbase : Legnanotcbase =
        { name = "legnanotcbase"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 20000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Expr "range"
          footprintX = 6.0
          footprintZ = 6.0
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
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/legnanotcbase_aoplane.dds"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "CorBuildings/SeaUtil"
            ]
          extras = Map.ofList [
                "canassist", "true"
                "canfight", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canreclaim", "true"
                "canstop", "true"
                "cantbetransported", "true"
                "mass", "700.0"
                "upright", "true"
            ] }

    type Meteor =
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
          customParams: Map<string, string>
          extras: Map<string, string> }

    let meteor : Meteor =
        { name = "meteor"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 1.0
          health = ValueOrExpr.Concrete 2.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          yardMap = "oo oo"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "weapon"
                  displayName = Some "Asteroid"
                  weaponType = None
                  damage = Map.ofList [
                      "raptor", 0.001
                      "commanders", 10.0
                      "default", 700.0
                      "tinyraptor", 0.001
                  ]
                  range = Some (ValueOrExpr.Concrete 29999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 2000.0
                  areaOfEffect = Some 450.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.75
                  impulseFactor = None
                  noSelfDamage = None
                  soundStart = None
                  soundHit = Some "xplonuk4"
                  explosiongenerator = Some "custom:genericshellexplosion-meteor"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "avoidfeature", "false"
                      "cegtag", "meteortrail"
                      "collidefriendly", "1.0"
                      "craterareaofeffect", "450.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "100.0"
                      "metalpershot", "0.0"
                      "smoketrail", "1.0"
                      "soundhitwet", "sizzle"
                      "soundhitwetvolume", "0.5"
                      "stages", "0.0"
                      "startvelocity", "2000.0"
                      "weaponacceleration", "120.0"
                      "weapontimer", "10.0"
                      "wobble", "0.0"
                  ] }
            ]
          customParams = Map.ofList [
                "removestop", "true"
                "removewait", "true"
                "subfolder", "other"
            ]
          extras = Map.ofList [
                "autoheal", "0.0"
                "levelground", "false"
                "mass", "165.75"
                "noautofire", "false"
                "radardistance", "900.0"
                "smoothanim", "true"
                "unitname", "meteor"
                "upright", "false"
            ] }

    type Mission_command_tower =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          energyMake: ValueOrExpr<float>
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let mission_command_tower : Mission_command_tower =
        { name = "mission_command_tower"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 100000.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 100.0
          footprintX = 12.0
          footprintZ = 12.0
          energyMake = ValueOrExpr.Concrete 250.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
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
                select = ["geothrm1"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/mission_command_tower_aoplane.dds"
                "buildinggrounddecalsizey", "11.25"
                "buildinggrounddecalsizex", "11.25"
                "buildinggrounddecaldecayspeed", "30.0"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "other"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "energyupkeep", "0.0"
                "reclaimable", "false"
            ] }

    type Nuketest =
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
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let nuketest : Nuketest =
        { name = "nuketest"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          energyStorage = 1000.0
          yardMap = "yy yy"
          activateWhenBuilt = true
          weapons = [
                { name = "nuketest"
                  displayName = Some "Newest Nuke"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 2500.0
                      "default", 9500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 29999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 1280.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 0.5
                  noSelfDamage = None
                  soundStart = Some "aarocket"
                  soundHit = Some "nukearm"
                  explosiongenerator = Some "custom:newnuke"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysvisible", "true"
                      "avoidfriendly", "false"
                      "cegtag", "NUKETRAIL"
                      "collidefriendly", "0.0"
                      "craterareaofeffect", "1280.0"
                      "craterboost", "2.4"
                      "cratermult", "1.2"
                      "firestarter", "100.0"
                      "flighttime", "100.0"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "crblmssl.s3o"
                      "smoketrail", "1.0"
                      "startvelocity", "1.0"
                      "weaponacceleration", "1800.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "isairbase", "true"
                "subfolder", "other"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "capturable", "false"
                "levelground", "false"
                "mass", "165.75"
                "noautofire", "false"
                "radardistance", "900.0"
                "smoothanim", "true"
                "unitname", "nukedroppod"
                "upright", "false"
            ] }

    type Nuketestcor =
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
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let nuketestcor : Nuketestcor =
        { name = "nuketestcor"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 6200.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          energyStorage = 1000.0
          yardMap = "yy yy"
          activateWhenBuilt = true
          weapons = [
                { name = "nuketestcor"
                  displayName = Some "Newest Nuke"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 2500.0
                      "default", 11500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 29999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 1920.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 0.5
                  noSelfDamage = None
                  soundStart = Some "aarocket"
                  soundHit = Some "nukecor"
                  explosiongenerator = Some "custom:newnukecor"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysvisible", "true"
                      "avoidfriendly", "false"
                      "cegtag", "NUKETRAIL"
                      "collidefriendly", "0.0"
                      "craterareaofeffect", "1920.0"
                      "craterboost", "2.4"
                      "cratermult", "1.2"
                      "firestarter", "100.0"
                      "flighttime", "100.0"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "crblmssl.s3o"
                      "smoketrail", "1.0"
                      "startvelocity", "1.0"
                      "weaponacceleration", "1800.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "isairbase", "true"
                "subfolder", "other"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "capturable", "false"
                "levelground", "false"
                "mass", "165.75"
                "noautofire", "false"
                "radardistance", "900.0"
                "smoothanim", "true"
                "unitname", "nukedroppod"
                "upright", "false"
            ] }

    type Nuketestorg =
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
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let nuketestorg : Nuketestorg =
        { name = "nuketestorg"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          energyStorage = 1000.0
          yardMap = "yy yy"
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = Some "Newest Nuke"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 2500.0
                      "default", 9500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 29999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 1280.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 0.5
                  noSelfDamage = None
                  soundStart = Some "misicbm1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:armnuke"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysvisible", "true"
                      "avoidfriendly", "false"
                      "cegtag", "NUKETRAIL"
                      "collidefriendly", "0.0"
                      "craterareaofeffect", "1280.0"
                      "craterboost", "2.4"
                      "cratermult", "1.2"
                      "firestarter", "0.0"
                      "flighttime", "100.0"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "scavs/cube.s3o"
                      "smoketrail", "false"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "null"
                      "texture3", "null"
                      "weaponacceleration", "1800.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "isairbase", "true"
                "subfolder", "other"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "capturable", "false"
                "levelground", "false"
                "mass", "165.75"
                "noautofire", "false"
                "radardistance", "900.0"
                "smoothanim", "true"
                "unitname", "nukedroppod"
                "upright", "false"
            ] }

    type Pbr_cube =
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
          customParams: Map<string, string>
          extras: Map<string, string> }

    let pbr_cube : Pbr_cube =
        { name = "pbr_cube"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 3400.0
          buildTime = ValueOrExpr.Concrete 5090.0
          health = ValueOrExpr.Concrete 940.0
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
          customParams = Map.ofList [
                "model_author", "Beherith"
                "nohealthbars", "true"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "autoheal", "15.0"
                "capturable", "false"
                "mygravity", "10000.0"
                "nochasecategory", "ALL"
                "stealth", "true"
                "strafetoattack", "true"
            ] }

    type Resourcecheat =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          yardMap: string
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let resourcecheat : Resourcecheat =
        { name = "resourcecheat"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 312500.0
          health = ValueOrExpr.Concrete 7900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          energyMake = ValueOrExpr.Concrete 1000000.0
          metalMake = ValueOrExpr.Concrete 1000000.0
          energyStorage = 1000000.0
          metalStorage = 1000000.0
          yardMap = "oooooooooooooooooooooooooooooooooooo"
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "110 110 110"
                  collisionVolumeType = Some "Box"
                  damage = Some 16290.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 4.0
                  height = Some 40.0
                  metal = Some 6441.0
                  object_ = Some "Units/armafus_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 8145.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 2576.0
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
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/armafus_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "other"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "damagemodifier", "0.95"
            ] }

    type Volcano_projectile_unit =
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
          yardMap: string
          canRepeat: bool
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let volcano_projectile_unit : Volcano_projectile_unit =
        { name = "volcano_projectile_unit"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 100.0
          energyCost = ValueOrExpr.Concrete 100.0
          buildTime = ValueOrExpr.Concrete 1.0
          health = ValueOrExpr.Concrete 1000000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 0.0001
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "BOT3"
          canMove = true
          yardMap = "o"
          canRepeat = false
          weapons = [
                { name = "volcano_fireball"
                  displayName = Some "Volcano Fireball"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 32000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 780.0
                  areaOfEffect = Some 220.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 3.0
                  noSelfDamage = None
                  soundStart = None
                  soundHit = Some "xplolrg1"
                  explosiongenerator = Some "custom:volcano_rock_impact"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlyTargetCategory", "SURFACE"
                      "model", "Raptors/greyrock2.s3o"
                      "cegtag", "volcano_rock_trail"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "trajectoryheight", "1.1"
                      "mygravity", "0.16"
                      "impulseboost", "400.0"
                      "collideground", "true"
                      "avoidfriendly", "false"
                      "avoidfeature", "false"
                      "soundhitvolume", "75.0"
                  ] }
            ]
          customParams = Map.ofList [
                "faction", "NONE"
                "is_volcano_launcher", "1.0"
            ]
          extras = Map.ofList [
                "power", "1.0"
                "leavetracks", "false"
                "canattack", "true"
                "canattackground", "true"
                "drawtype", "0.0"
                "selectable", "false"
                "blocking", "false"
                "canstop", "false"
                "canpatrol", "false"
                "initcloaked", "true"
                "cloakcost", "0.0"
                "cloakcostmoving", "0.0"
                "mincloakdistance", "0.0"
                "stealth", "true"
                "sonarstealth", "true"
                "radardistance", "0.0"
            ] }

    type Xmasball1_1 =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball1_1 : Xmasball1_1 =
        { name = "xmasball1_1"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "40.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    type Xmasball1_2 =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball1_2 : Xmasball1_2 =
        { name = "xmasball1_2"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "40.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    type Xmasball1_3 =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball1_3 : Xmasball1_3 =
        { name = "xmasball1_3"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "40.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    type Xmasball1_4 =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball1_4 : Xmasball1_4 =
        { name = "xmasball1_4"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "40.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    type Xmasball1_5 =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball1_5 : Xmasball1_5 =
        { name = "xmasball1_5"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "40.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    type Xmasball1_6 =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball1_6 : Xmasball1_6 =
        { name = "xmasball1_6"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "40.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    type Xmasball2_1 =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball2_1 : Xmasball2_1 =
        { name = "xmasball2_1"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "45.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    type Xmasball2_2 =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball2_2 : Xmasball2_2 =
        { name = "xmasball2_2"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "45.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    type Xmasball2_3 =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball2_3 : Xmasball2_3 =
        { name = "xmasball2_3"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "45.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    type Xmasball2_4 =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball2_4 : Xmasball2_4 =
        { name = "xmasball2_4"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "45.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    type Xmasball2_5 =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball2_5 : Xmasball2_5 =
        { name = "xmasball2_5"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "45.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    type Xmasball2_6 =
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
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball2_6 : Xmasball2_6 =
        { name = "xmasball2_6"
          subfolder = "other"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "45.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

