// Auto-generated BAR unit data: Scavengers/Other (flat per-unit types)
namespace BarData.Units

open BarData

module Scavengers_Other =

    type Scavempspawner =
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
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let scavempspawner : Scavempspawner =
        { name = "scavempspawner"
          subfolder = "Scavengers/Other"
          metalCost = ValueOrExpr.Concrete 10.0
          energyCost = ValueOrExpr.Concrete 10.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 0.0
          footprintZ = 0.0
          yardMap = ""
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = Some "Heavy long-range g2g EMP starburst rocket"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 50000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 29999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 1200.0
                  areaOfEffect = Some 312.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 0.123
                  noSelfDamage = None
                  soundStart = Some "mismed1emp1"
                  soundHit = Some "emgpuls1"
                  explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysvisible", "true"
                      "avoidfriendly", "false"
                      "cegtag", "cruisemissiletrail-emp"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "100.0"
                      "metalpershot", "0.0"
                      "model", "cortronmissile.s3o"
                      "paralyzer", "true"
                      "paralyzetime", "35.0"
                      "smoketrail", "false"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "weaponacceleration", "1800.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "blocking", "false"
                "craterboost", "0.0"
                "cratermult", "0.0"
                "capturable", "false"
                "impulsefactor", "0.0"
                "levelground", "false"
                "mass", "10.0"
                "noautofire", "false"
                "smoothanim", "true"
                "unitname", "nukedroppod"
                "upright", "false"
            ] }

    type Scavengerdroppod =
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
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let scavengerdroppod : Scavengerdroppod =
        { name = "scavengerdroppod"
          subfolder = "Scavengers/Other"
          metalCost = ValueOrExpr.Concrete 10.0
          energyCost = ValueOrExpr.Concrete 10.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 0.0
          footprintZ = 0.0
          yardMap = ""
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = Some "Droppod"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "raptor", 0.0
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 29999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 0.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.1
                  noSelfDamage = None
                  soundStart = Some "scavspawn"
                  soundHit = Some "scavdropspawn"
                  explosiongenerator = Some "custom:dirtpoof"
                  rgbColor = Some "0.85 0 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysVisible", "true"
                      "avoidfriendly", "0.0"
                      "cegtag", "scaspawn-trail"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "100.0"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "scavs/scavbeacondroppodbyar.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "9.0"
                      "smoketime", "25.0"
                      "smokesize", "10.0"
                      "smokecolor", "0.9"
                      "smokeTrailCastShadow", "true"
                      "castshadow", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaaflak"
                      "weaponacceleration", "1800.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "Scavengers"
                "normaltex", "unittextures/cor_normal.dds"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "blocking", "false"
                "capturable", "false"
                "levelground", "false"
                "mass", "10.0"
                "noautofire", "false"
                "selfdestructcountdown", "5.0"
                "smoothanim", "true"
                "unitname", "scavengerdroppod"
                "upright", "false"
            ] }

    type Scavengerdroppodfriendly =
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
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let scavengerdroppodfriendly : Scavengerdroppodfriendly =
        { name = "scavengerdroppodfriendly"
          subfolder = "Scavengers/Other"
          metalCost = ValueOrExpr.Concrete 10.0
          energyCost = ValueOrExpr.Concrete 10.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 0.0
          footprintZ = 0.0
          yardMap = ""
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = Some "Droppod"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "raptor", 0.0
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 29999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 2000.0
                  areaOfEffect = Some 0.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.1
                  noSelfDamage = None
                  soundStart = None
                  soundHit = Some "scavspawn"
                  explosiongenerator = Some "custom:dirtpoof"
                  rgbColor = Some "0 1 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysvisible", "true"
                      "avoidfriendly", "0.0"
                      "cegtag", "scaspawn-greentrail"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "250.0"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "scavs/scavbeacondroppodbyar.s3o"
                      "mygravity", "0.1"
                      "smoketrail", "1.0"
                      "startvelocity", "2000.0"
                      "weaponacceleration", "450.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "isairbase", "true"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/scavengers"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "blocking", "false"
                "capturable", "false"
                "levelground", "false"
                "mass", "10.0"
                "noautofire", "false"
                "selfdestructcountdown", "0.0"
                "smoothanim", "true"
                "unitname", "scavengerfriendlydroppod"
                "upright", "false"
            ] }

    type Scavtacnukespawner =
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
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let scavtacnukespawner : Scavtacnukespawner =
        { name = "scavtacnukespawner"
          subfolder = "Scavengers/Other"
          metalCost = ValueOrExpr.Concrete 10.0
          energyCost = ValueOrExpr.Concrete 10.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 0.0
          footprintZ = 0.0
          yardMap = ""
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = Some "Long range tactical g2g nuclear warheads"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 500.0
                      "scavboss", 1.0
                      "default", 2500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 29999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 512.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 0.5
                  noSelfDamage = None
                  soundStart = Some "mismed1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:newnuketac"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysvisible", "true"
                      "avoidfriendly", "false"
                      "cegtag", "cruisemissiletrail-tacnuke"
                      "collidefriendly", "0.0"
                      "craterareaofeffect", "512.0"
                      "craterboost", "1.6"
                      "cratermult", "0.7"
                      "firestarter", "100.0"
                      "flighttime", "100.0"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "cortronmissile.s3o"
                      "smoketrail", "1.0"
                      "startvelocity", "1.0"
                      "texture1", "flare2"
                      "weaponacceleration", "1800.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "blocking", "false"
                "capturable", "false"
                "levelground", "false"
                "mass", "10.0"
                "noautofire", "false"
                "smoothanim", "true"
                "unitname", "nukedroppod"
                "upright", "false"
            ] }

