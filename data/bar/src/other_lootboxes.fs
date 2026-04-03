// Auto-generated BAR unit data: other/lootboxes (flat per-unit types)
namespace BarData.Units

open BarData

module other_lootboxes =

    type Lootboxbronze =
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
          floater: bool
          turnInPlace: bool
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let lootboxbronze : Lootboxbronze =
        { name = "lootboxbronze"
          subfolder = "other/lootboxes"
          metalCost = ValueOrExpr.Concrete 375.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 33500.0
          sightDistance = ValueOrExpr.Concrete 96.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 0.03
          maxAcc = 0.0
          maxDec = 1.0
          turnRate = 0.0
          movementClass = "HOVER3"
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          floater = true
          turnInPlace = false
          energyMake = ValueOrExpr.Concrete 400.0
          metalMake = ValueOrExpr.Concrete 20.0
          customParams = Map.ofList [
                "fall_damage_multiplier", "0.0"
                "unitgroup", "energy"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/lootboxes"
                "paratrooper", "true"
            ]
          extras = Map.ofList [
                "autoheal", "1.0"
                "canfight", "false"
                "canguard", "false"
                "canhover", "true"
                "canpatrol", "false"
                "canselfdestruct", "true"
                "canstop", "false"
                "cantbetransported", "false"
                "capturable", "true"
                "levelground", "false"
                "mass", "749.0"
                "movestate", "0.0"
                "noautofire", "false"
                "selfdestructcountdown", "9.0"
                "transportbyenemy", "true"
                "unitname", "lootboxbronze"
                "upright", "true"
                "usebuildinggrounddecal", "false"
                "reclaimable", "false"
            ] }

    type Lootboxgold =
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
          floater: bool
          turnInPlace: bool
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let lootboxgold : Lootboxgold =
        { name = "lootboxgold"
          subfolder = "other/lootboxes"
          metalCost = ValueOrExpr.Concrete 1500.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 56000.0
          sightDistance = ValueOrExpr.Concrete 96.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 0.03
          maxAcc = 0.0
          maxDec = 1.0
          turnRate = 0.0
          movementClass = "HHOVER4"
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          floater = true
          turnInPlace = false
          energyMake = ValueOrExpr.Concrete 1600.0
          metalMake = ValueOrExpr.Concrete 80.0
          customParams = Map.ofList [
                "fall_damage_multiplier", "0.0"
                "unitgroup", "energy"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/lootboxes"
                "paratrooper", "true"
            ]
          extras = Map.ofList [
                "autoheal", "1.0"
                "canfight", "false"
                "canguard", "false"
                "canpatrol", "false"
                "canselfdestruct", "true"
                "canstop", "false"
                "cantbetransported", "false"
                "capturable", "true"
                "levelground", "false"
                "mass", "4000.0"
                "movestate", "0.0"
                "noautofire", "false"
                "selfdestructcountdown", "9.0"
                "transportbyenemy", "true"
                "unitname", "lootboxgold"
                "upright", "true"
                "usebuildinggrounddecal", "false"
                "reclaimable", "false"
            ] }

    type Lootboxplatinum =
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
          floater: bool
          turnInPlace: bool
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let lootboxplatinum : Lootboxplatinum =
        { name = "lootboxplatinum"
          subfolder = "other/lootboxes"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 67000.0
          sightDistance = ValueOrExpr.Concrete 96.0
          footprintX = 4.0
          footprintZ = 4.0
          speed = ValueOrExpr.Concrete 0.03
          maxAcc = 0.0
          maxDec = 1.0
          turnRate = 0.0
          movementClass = "HHOVER4"
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          floater = true
          turnInPlace = false
          energyMake = ValueOrExpr.Concrete 2800.0
          metalMake = ValueOrExpr.Concrete 140.0
          customParams = Map.ofList [
                "fall_damage_multiplier", "0.0"
                "unitgroup", "energy"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/lootboxes"
                "paratrooper", "true"
            ]
          extras = Map.ofList [
                "autoheal", "1.0"
                "canfight", "false"
                "canguard", "false"
                "canpatrol", "false"
                "canselfdestruct", "true"
                "canstop", "false"
                "cantbetransported", "false"
                "capturable", "true"
                "levelground", "false"
                "mass", "4000.0"
                "movestate", "0.0"
                "noautofire", "false"
                "selfdestructcountdown", "9.0"
                "transportbyenemy", "true"
                "unitname", "lootboxplatinum"
                "upright", "true"
                "usebuildinggrounddecal", "false"
                "reclaimable", "false"
            ] }

    type Lootboxsilver =
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
          floater: bool
          turnInPlace: bool
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let lootboxsilver : Lootboxsilver =
        { name = "lootboxsilver"
          subfolder = "other/lootboxes"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 44500.0
          sightDistance = ValueOrExpr.Concrete 96.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 0.03
          maxAcc = 0.0
          maxDec = 1.0
          turnRate = 0.0
          movementClass = "HOVER3"
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          floater = true
          turnInPlace = false
          energyMake = ValueOrExpr.Concrete 800.0
          metalMake = ValueOrExpr.Concrete 40.0
          customParams = Map.ofList [
                "fall_damage_multiplier", "0.0"
                "unitgroup", "energy"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/lootboxes"
                "paratrooper", "true"
            ]
          extras = Map.ofList [
                "autoheal", "1.0"
                "canfight", "false"
                "canguard", "false"
                "canpatrol", "false"
                "canselfdestruct", "true"
                "canstop", "false"
                "cantbetransported", "false"
                "capturable", "true"
                "levelground", "false"
                "mass", "749.0"
                "movestate", "0.0"
                "noautofire", "false"
                "selfdestructcountdown", "9.0"
                "transportbyenemy", "true"
                "unitname", "lootboxsilver"
                "upright", "true"
                "usebuildinggrounddecal", "false"
                "reclaimable", "false"
            ] }

    type Lootdroppod_gold =
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

    let lootdroppod_gold : Lootdroppod_gold =
        { name = "lootdroppod_gold"
          subfolder = "other/lootboxes"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 0.0
          footprintZ = 0.0
          energyStorage = 1000.0
          yardMap = ""
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = Some "Lootbox"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "raptor", 1.0
                      "default", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 59999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 100.0
                  areaOfEffect = Some 500.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.1
                  noSelfDamage = None
                  soundStart = Some "scavlootdrop"
                  soundHit = Some "scavdroplootspawn"
                  explosiongenerator = Some "custom:dirtpoof"
                  rgbColor = Some "0.95 0.78 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysvisible", "true"
                      "avoidfriendly", "0.0"
                      "cegtag", "lootbox-trail"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "800.0"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "smoketrail", "0.0"
                      "startvelocity", "1.0"
                      "weaponacceleration", "50.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "unitgroup", "builder"
                "isairbase", "true"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/lootboxes"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "capturable", "false"
                "levelground", "false"
                "mass", "165.75"
                "noautofire", "false"
                "radardistance", "900.0"
                "selfdestructcountdown", "5.0"
                "smoothanim", "true"
                "unitname", "lootdroppod_gold"
                "upright", "false"
            ] }

    type Lootdroppod_printer =
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

    let lootdroppod_printer : Lootdroppod_printer =
        { name = "lootdroppod_printer"
          subfolder = "other/lootboxes"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 0.0
          footprintZ = 0.0
          energyStorage = 1000.0
          yardMap = ""
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = Some "Lootbox"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "raptor", 1.0
                      "default", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 59999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 100.0
                  areaOfEffect = Some 500.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.1
                  noSelfDamage = None
                  soundStart = Some "scavlootdrop"
                  soundHit = Some "scavdropspawnprinter"
                  explosiongenerator = Some "custom:dirtpoof"
                  rgbColor = Some "0.95 0.78 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysvisible", "true"
                      "avoidfriendly", "0.0"
                      "cegtag", "lootbox-trail"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "800.0"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "smoketrail", "0.0"
                      "startvelocity", "1.0"
                      "weaponacceleration", "50.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "unitgroup", "builder"
                "isairbase", "true"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/lootboxes"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "capturable", "false"
                "levelground", "false"
                "mass", "165.75"
                "noautofire", "false"
                "radardistance", "900.0"
                "selfdestructcountdown", "5.0"
                "smoothanim", "true"
                "unitname", "lootdroppod_printer"
                "upright", "false"
            ] }

