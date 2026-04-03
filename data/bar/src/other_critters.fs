// Auto-generated BAR unit data: other/critters (flat per-unit types)
namespace BarData.Units

open BarData

module other_critters =

    type Critter_ant =
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
          turnInPlaceAngleLimit: float
          waterline: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let critter_ant : Critter_ant =
        { name = "critter_ant"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 18.0
          maxAcc = 0.575
          maxDec = 1.15
          turnRate = 2300.0
          movementClass = "SBOT2"
          maxSlope = 90.0
          maxWaterDepth = 2.0
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 6.0
          customParams = Map.ofList [
                "paralyzemultiplier", "0.0"
                "nohealthbars", "true"
                "subfolder", "other/critters"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cantbetransported", "true"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "10.0"
                "movestate", "-1.0"
                "noautofire", "false"
                "nochasecategory", "MOBILE "
                "reclaimable", "false"
                "selfdestructcountdown", "0.0"
                "smoothanim", "true"
                "sonarstealth", "true"
                "stealth", "true"
                "trackoffset", "0.0"
                "trackstrength", "1.3"
                "trackstretch", "1.0"
                "tracktype", "bigfoot"
                "trackwidth", "7.0"
                "unitname", "critter_ant"
                "upright", "false"
            ] }

    type Critter_crab =
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
          canMove: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let critter_crab : Critter_crab =
        { name = "critter_crab"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 44.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 13.5
          maxAcc = 0.1
          maxDec = 0.01
          turnRate = 500.0
          movementClass = "ABOT3"
          maxSlope = 65.0
          canMove = true
          customParams = Map.ofList [
                "paralyzemultiplier", "0.0"
                "nohealthbars", "true"
                "subfolder", "other/critters"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cantbetransported", "true"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "leavetracks", "false"
                "maneuverleashlength", "640"
                "mass", "24.0"
                "movestate", "-1.0"
                "noautofire", "false"
                "nochasecategory", "MOBILE "
                "reclaimable", "false"
                "selfdestructcountdown", "0.0"
                "smoothanim", "true"
                "sonarstealth", "true"
                "stealth", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "trackwidth", "10.0"
                "unitname", "critter_crab"
                "upright", "false"
            ] }

    type Critter_duck =
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
          waterline: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let critter_duck : Critter_duck =
        { name = "critter_duck"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 17.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 10.5
          maxAcc = 0.12
          maxDec = 1.0
          turnRate = 500.0
          movementClass = "SBOT2"
          maxSlope = 45.0
          maxWaterDepth = 22.0
          canMove = true
          floater = true
          waterline = 6.0
          customParams = Map.ofList [
                "paralyzemultiplier", "0.0"
                "nohealthbars", "true"
                "subfolder", "other/critters"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cantbetransported", "true"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "leavetracks", "false"
                "maneuverleashlength", "640"
                "mass", "24.0"
                "movestate", "-1.0"
                "noautofire", "false"
                "nochasecategory", "MOBILE "
                "reclaimable", "false"
                "selfdestructcountdown", "0.0"
                "smoothanim", "true"
                "sonarstealth", "true"
                "stealth", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "trackwidth", "10.0"
                "unitname", "critter_duck"
                "upright", "false"
            ] }

    type Critter_goldfish =
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
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let critter_goldfish : Critter_goldfish =
        { name = "critter_goldfish"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 600.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 18.0
          maxAcc = 0.123
          maxDec = 0.123
          turnRate = 4500.0
          movementClass = "UBOAT4"
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 20.0
          customParams = Map.ofList [
                "paralyzemultiplier", "0.0"
                "nohealthbars", "true"
                "subfolder", "other/critters"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "true"
                "cantbetransported", "true"
                "capturable", "false"
                "mass", "1.0"
                "mincloakdistance", "75.0"
                "noautofire", "false"
                "nochasecategory", "MOBILE "
                "reclaimable", "false"
                "selfdestructcountdown", "0.0"
                "sonardistance", "550.0"
                "sonarstealth", "true"
                "stealth", "true"
                "unitname", "critter_goldfish"
                "upright", "true"
            ] }

    type Critter_gull =
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
          canFly: bool
          canMove: bool
          cruiseAltitude: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let critter_gull : Critter_gull =
        { name = "critter_gull"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 54.0
          maxAcc = 0.2
          maxDec = 3.75
          turnRate = 500.0
          canFly = true
          canMove = true
          cruiseAltitude = 200.0
          customParams = Map.ofList [
                "paralyzemultiplier", "0.0"
                "nohealthbars", "true"
                "subfolder", "other/critters"
                "crashable", "0.0"
            ]
          extras = Map.ofList [
                "airstrafe", "false"
                "bankscale", "1.0"
                "blocking", "false"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cantbetransported", "true"
                "capturable", "false"
                "collide", "false"
                "collision", "false"
                "hoverattack", "true"
                "mass", "125.0"
                "maxbank", "0.2"
                "maxpitch", "0.2"
                "reclaimable", "false"
                "selfdestructcountdown", "0.0"
                "sonarstealth", "true"
                "stealth", "true"
                "turnradius", "5.0"
                "upright", "false"
            ] }

    type Critter_penguin =
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
          waterline: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let critter_penguin : Critter_penguin =
        { name = "critter_penguin"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 15.0
          energyCost = ValueOrExpr.Concrete 200.0
          buildTime = ValueOrExpr.Concrete 250.0
          health = ValueOrExpr.Concrete 167.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 15.0
          maxAcc = 0.15
          maxDec = 1.0
          turnRate = 2000.0
          movementClass = "SBOT2"
          maxSlope = 45.0
          maxWaterDepth = 22.0
          canMove = true
          floater = true
          waterline = 6.0
          customParams = Map.ofList [
                "paralyzemultiplier", "0.0"
                "subfolder", "other/critters"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cantbetransported", "true"
                "capturable", "false"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "24.0"
                "movestate", "-1.0"
                "noautofire", "false"
                "nochasecategory", "MOBILE "
                "reclaimable", "false"
                "selfdestructcountdown", "0.0"
                "smoothanim", "true"
                "sonarstealth", "true"
                "stealth", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "bigfoot"
                "trackwidth", "6.0"
                "unitname", "critter_penguin"
                "upright", "false"
            ] }

    type Critter_penguinbro =
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
          waterline: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let critter_penguinbro : Critter_penguinbro =
        { name = "critter_penguinbro"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 1500.0
          energyCost = ValueOrExpr.Concrete 15000.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 280.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 22.5
          maxAcc = 0.15
          maxDec = 1.0
          turnRate = 2000.0
          movementClass = "SBOT2"
          maxSlope = 45.0
          maxWaterDepth = 22.0
          canMove = true
          floater = true
          waterline = 6.0
          weapons = [
                { name = "eyelaser"
                  displayName = Some "LightLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 70.0
                      "vtol", 7.0
                  ]
                  range = Some (ValueOrExpr.Concrete 266.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.2)
                  weaponVelocity = Some 2250.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 7000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-tiny-red"
                  rgbColor = Some "1 0 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", ""
                      "avoidfeature", "false"
                      "beamtime", "0.2"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "100.0"
                      "impactonly", "1.0"
                      "laserflaresize", "3.146"
                      "proximitypriority", "1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "1.25"
                  ] }
                { name = "eyelaser"
                  displayName = Some "LightLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 70.0
                      "vtol", 7.0
                  ]
                  range = Some (ValueOrExpr.Concrete 266.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.2)
                  weaponVelocity = Some 2250.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 7000.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-tiny-red"
                  rgbColor = Some "1 0 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", ""
                      "avoidfeature", "false"
                      "beamtime", "0.2"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "100.0"
                      "impactonly", "1.0"
                      "laserflaresize", "3.146"
                      "proximitypriority", "1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "1.25"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/critters"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cantbetransported", "true"
                "capturable", "false"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "66.0"
                "movestate", "-1.0"
                "noautofire", "false"
                "nochasecategory", "MOBILE "
                "reclaimable", "false"
                "selfdestructcountdown", "0.0"
                "smoothanim", "true"
                "sonarstealth", "true"
                "stealth", "true"
                "trackoffset", "0.0"
                "trackstrength", "4.0"
                "trackstretch", "1.0"
                "tracktype", "bigfoot"
                "trackwidth", "10.0"
                "unitname", "critter_penguinbro"
                "upright", "false"
            ] }

    type Critter_penguinking =
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
          waterline: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let critter_penguinking : Critter_penguinking =
        { name = "critter_penguinking"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 20000.0
          energyCost = ValueOrExpr.Concrete 400000.0
          buildTime = ValueOrExpr.Concrete 35000.0
          health = ValueOrExpr.Concrete 56000.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 25.5
          maxAcc = 0.15
          maxDec = 1.0
          turnRate = 2000.0
          movementClass = "SBOT2"
          maxSlope = 45.0
          maxWaterDepth = 22.0
          canMove = true
          floater = true
          waterline = 6.0
          weapons = [
                { name = "eyelaser"
                  displayName = Some "LightLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 750.0
                      "default", 2000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.5)
                  weaponVelocity = Some 2250.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 9500.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrhvy3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-red"
                  rgbColor = Some "1 0 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", ""
                      "avoidfeature", "false"
                      "beamtime", "1.0"
                      "corethickness", "0.33"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "100.0"
                      "impactonly", "1.0"
                      "laserflaresize", "3.146"
                      "proximitypriority", "1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.5"
                  ] }
                { name = "eyelaser"
                  displayName = Some "LightLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "commanders", 750.0
                      "default", 2000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.5)
                  weaponVelocity = Some 2250.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 9500.0
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrhvy3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-large-red"
                  rgbColor = Some "1 0 0"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", ""
                      "avoidfeature", "false"
                      "beamtime", "1.0"
                      "corethickness", "0.33"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "100.0"
                      "impactonly", "1.0"
                      "laserflaresize", "3.146"
                      "proximitypriority", "1.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.5"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/critters"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cantbetransported", "true"
                "capturable", "false"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "1000.0"
                "movestate", "-1.0"
                "noautofire", "false"
                "nochasecategory", "MOBILE "
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "smoothanim", "true"
                "sonarstealth", "true"
                "stealth", "true"
                "trackoffset", "0.0"
                "trackstrength", "8.0"
                "trackstretch", "1.0"
                "tracktype", "bigfoot"
                "trackwidth", "22.0"
                "unitname", "critter_penguinking"
                "upright", "false"
            ] }

