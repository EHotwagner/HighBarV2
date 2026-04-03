// Auto-generated BAR unit data: ArmAircraft (flat per-unit types)
namespace BarData.Units

open BarData

module ArmAircraft =

    type Armatlas =
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
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armatlas : Armatlas =
        { name = "armatlas"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 68.0
          energyCost = ValueOrExpr.Concrete 1300.0
          buildTime = ValueOrExpr.Concrete 3850.0
          health = ValueOrExpr.Concrete 265.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 207.0
          maxAcc = 0.1
          maxDec = 0.75
          turnRate = 550.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 100.0
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
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "crashable", "0.0"
                "model_author", "Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", "ArmAircraft"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "false"
                "loadingradius", "300.0"
                "releaseheld", "true"
                "transportcapacity", "1.0"
                "transportmass", "750.0"
                "transportsize", "3.0"
                "transportunloadmethod", "0.0"
                "verticalspeed", "3.75"
            ] }

    type Armca =
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
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armca : Armca =
        { name = "armca"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 110.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 7960.0
          health = ValueOrExpr.Concrete 156.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 208.2
          maxAcc = 0.07
          maxDec = 0.4275
          turnRate = 240.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 70.0
          workerTime = ValueOrExpr.Concrete 60.0
          buildDistance = 136.0
          buildOptions = ["armsolar"; "armadvsol"; "armwin"; "armgeo"; "armmstor"; "armestor"; "armmex"; "armamex"; "armmakr"; "armaap"; "armlab"; "armvp"; "armap"; "armhp"; "armnanotc"; "armeyes"; "armrad"; "armdrag"; "armclaw"; "armllt"; "armbeamer"; "armhlt"; "armguard"; "armrl"; "armferret"; "armcir"; "armdl"; "armjamt"; "armjuno"; "armsy"; "armuwgeo"]
          terraformSpeed = 225.0
          energyMake = ValueOrExpr.Concrete 5.0
          energyStorage = 25.0
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolarmv"]
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "model_author", "FireStorm, Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "true"
                "hoverattack", "true"
            ] }

    type Armdrone =
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
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armdrone : Armdrone =
        { name = "armdrone"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 1200.0
          health = ValueOrExpr.Concrete 450.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 1.0
          footprintZ = 1.0
          speed = ValueOrExpr.Concrete 330.0
          maxAcc = 0.22
          maxDec = 0.5
          turnRate = 1000.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 40.0
          weapons = [
                { name = "med_emg"
                  displayName = Some "Rapid-fire a2g machine guns"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 11.0
                      "vtol", 3.0
                  ]
                  range = Some (ValueOrExpr.Concrete 350.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.8)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 13.0
                  turret = Some false
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.5
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "mgun3"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:laserhit-small-yellow"
                  rgbColor = Some "1 0.95 0.4"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "90.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burnblow", "false"
                      "burst", "3.0"
                      "burstrate", "0.105"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.025"
                      "intensity", "0.8"
                      "ownerexpaccweight", "2.0"
                      "predictboost", "1.0"
                      "soundhitwet", "splshbig"
                      "sprayangle", "1024.0"
                      "thickness", "0.7"
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
                ok = ["vtolarmv"]
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "drone", "1.0"
                "model_author", "FireStorm"
                "nohealthbars", "1.0"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "true"
                "hoverattack", "true"
                "nochasecategory", "VTOL"
            ] }

    type Armdroneold =
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
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armdroneold : Armdroneold =
        { name = "armdroneold"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 55.0
          energyCost = ValueOrExpr.Concrete 1100.0
          buildTime = ValueOrExpr.Concrete 2200.0
          health = ValueOrExpr.Concrete 400.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 225.0
          maxAcc = 0.2
          maxDec = 0.45
          turnRate = 900.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 70.0
          weapons = [
                { name = "railgun"
                  displayName = Some "Railgun"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 350.0)
                  reloadTime = Some (ValueOrExpr.Concrete 6.0)
                  weaponVelocity = Some 2000.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "railgun3"
                  soundHit = Some "mavgun3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "0.34 0.64 0.94"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burnblow", "false"
                      "cegtag", "railgun"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.06"
                      "falloffrate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerexpaccweight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "13.0"
                      "thickness", "1.5"
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
                ok = ["vtolarmv"]
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "drone", "1.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "true"
                "hoverattack", "true"
                "nochasecategory", "VTOL"
            ] }

    type Armfig =
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
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armfig : Armfig =
        { name = "armfig"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 73.0
          energyCost = ValueOrExpr.Concrete 2900.0
          buildTime = ValueOrExpr.Concrete 3500.0
          health = ValueOrExpr.Concrete 167.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 289.20001
          maxAcc = 0.1825
          maxDec = 0.075
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 125.0
          weapons = [
                { name = "armvtol_missile"
                  displayName = Some "Light a2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 4.0
                      "default", 12.0
                      "vtol", 125.0
                  ]
                  range = Some (ValueOrExpr.Concrete 680.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 850.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = None
                  tolerance = Some 12000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Rocklit3"
                  soundHit = Some "xplosml2"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-air"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "castshadow", "false"
                      "cegtag", "missiletrailfighter"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "0.0"
                      "flighttime", "1.2"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smokecolor", "0.55"
                      "smokeperiod", "4.0"
                      "smokesize", "1.8"
                      "smoketime", "8.0"
                      "smoketrail", "false"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "startvelocity", "450.0"
                      "texture1", "null"
                      "texture2", "smoketrail"
                      "tracks", "true"
                      "turnrate", "20000.0"
                      "weaponacceleration", "400.0"
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
                ok = ["vtolarmv"]
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "attacksafetydistance", "300.0"
                "fighter", "1.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "950.0"
                "blocking", "false"
                "collide", "false"
                "maxaileron", "0.0144"
                "maxbank", "0.8"
                "maxelevator", "0.01065"
                "maxpitch", "0.625"
                "maxrudder", "0.00615"
                "nochasecategory", "NOTAIR"
                "speedtofront", "0.06417"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06315"
                "wingdrag", "0.185"
            ] }

    type Armhvytrans =
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
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armhvytrans : Armhvytrans =
        { name = "armhvytrans"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 190.0
          energyCost = ValueOrExpr.Concrete 4000.0
          buildTime = ValueOrExpr.Concrete 8500.0
          health = ValueOrExpr.Concrete 630.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 110.0
          maxAcc = 0.1
          maxDec = 0.75
          turnRate = 550.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 100.0
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
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "crashable", "0.0"
                "model_author", "Protar"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", "ArmAircraft"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "false"
                "loadingradius", "300.0"
                "releaseheld", "true"
                "transportcapacity", "1.0"
                "transportsize", "4.0"
                "transportunloadmethod", "0.0"
                "verticalspeed", "3.75"
            ] }

    type Armkam =
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
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armkam : Armkam =
        { name = "armkam"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 135.0
          energyCost = ValueOrExpr.Concrete 2300.0
          buildTime = ValueOrExpr.Concrete 5050.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 184.8
          maxAcc = 0.15
          maxDec = 0.375
          turnRate = 1400.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 70.0
          weapons = [
                { name = "emg"
                  displayName = Some "Rapid-fire close-quarters a2g plasma guns"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 9.0
                      "vtol", 3.0
                  ]
                  range = Some (ValueOrExpr.Concrete 350.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.7)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 40.0
                  accuracy = Some 13.0
                  turret = None
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.5
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "flashemg"
                  soundHit = None
                  explosiongenerator = Some "custom:plasmahit-small"
                  rgbColor = Some "1 0.95 0.4"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "3.0"
                      "burstrate", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "100.0"
                      "gravityaffected", "true"
                      "intensity", "0.66"
                      "size", "2.0"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "sprayangle", "1024.0"
                      "weapontimer", "0.1"
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
                ok = ["vtolarmv"]
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "true"
                "hoverattack", "true"
                "nochasecategory", "VTOL"
            ] }

    type Armpeep =
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

    let armpeep : Armpeep =
        { name = "armpeep"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 52.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 2800.0
          health = ValueOrExpr.Concrete 89.0
          sightDistance = ValueOrExpr.Concrete 865.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 375.0
          maxAcc = 0.1825
          maxDec = 0.01125
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 180.0
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
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "crashable", "0.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "selectable_as_combat_unit", "true"
                "subfolder", "ArmAircraft"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "false"
                "maxaileron", "0.0144"
                "maxbank", "0.8"
                "maxelevator", "0.01065"
                "maxpitch", "0.625"
                "maxrudder", "0.00615"
                "radardistance", "1140.0"
                "selfdestructcountdown", "1.0"
                "speedtofront", "0.06417"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06315"
                "wingdrag", "0.0575"
            ] }

    type Armthund =
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
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armthund : Armthund =
        { name = "armthund"
          subfolder = "ArmAircraft"
          metalCost = ValueOrExpr.Concrete 145.0
          energyCost = ValueOrExpr.Concrete 4200.0
          buildTime = ValueOrExpr.Concrete 4780.0
          health = ValueOrExpr.Concrete 670.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 250.0
          maxAcc = 0.0575
          maxDec = 0.05
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 165.0
          weapons = [
                { name = "armbomb"
                  displayName = Some "Light a2g impulse warheads"
                  weaponType = Some "AircraftBomb"
                  damage = Map.ofList [
                      "default", 105.0
                      "subs", 35.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 6.0)
                  weaponVelocity = None
                  areaOfEffect = Some 144.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.55
                  impulseFactor = Some 0.5
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = Some "bombssml1"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "5.0"
                      "burstrate", "0.25"
                      "collidefriendly", "false"
                      "commandfire", "false"
                      "craterareaofeffect", "144.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "model", "airbomb.s3o"
                      "soundhitwet", "splsmed"
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
                ok = ["vtolarmv"]
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "collide", "false"
                "maxaileron", "0.0144"
                "maxbank", "0.8"
                "maxelevator", "0.01065"
                "maxpitch", "0.625"
                "maxrudder", "0.00615"
                "noautofire", "true"
                "nochasecategory", "VTOL"
                "speedtofront", "0.063"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06315"
                "wingdrag", "0.135"
            ] }

