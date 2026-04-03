// Auto-generated BAR unit data: ArmSeaplanes (flat per-unit types)
namespace BarData.Units

open BarData

module ArmSeaplanes =

    type Armcsa =
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

    let armcsa : Armcsa =
        { name = "armcsa"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 150.0
          energyCost = ValueOrExpr.Concrete 7800.0
          buildTime = ValueOrExpr.Concrete 14500.0
          health = ValueOrExpr.Concrete 405.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 192.0
          maxAcc = 0.07
          maxDec = 0.4275
          turnRate = 240.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 50.0
          workerTime = ValueOrExpr.Concrete 75.0
          buildDistance = 136.0
          buildOptions = ["armsolar"; "armadvsol"; "armwin"; "armgeo"; "armmstor"; "armestor"; "armmex"; "armamex"; "armmakr"; "armlab"; "armvp"; "armap"; "armhp"; "armnanotc"; "armnanotcplat"; "armeyes"; "armrad"; "armdrag"; "armclaw"; "armllt"; "armbeamer"; "armhlt"; "armguard"; "armrl"; "armferret"; "armcir"; "armdl"; "armjamt"; "armjuno"; "armfhp"; "armsy"; "armamsub"; "armplat"; "armaap"; "armtide"; "armfmkr"; "armuwms"; "armuwes"; "armfdrag"; "armfrad"; "armfhlt"; "armfrt"; "armtl"; "armuwgeo"]
          terraformSpeed = 300.0
          energyMake = ValueOrExpr.Concrete 20.0
          energyStorage = 75.0
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolcrmv"]
                select = ["seapsel1"] }
          customParams = Map.ofList [
                "model_author", "Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmSeaplanes"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "true"
                "hoverattack", "true"
            ] }

    type Armhaca =
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

    let armhaca : Armhaca =
        { name = "armhaca"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 31200.0
          buildTime = ValueOrExpr.Concrete 58000.0
          health = ValueOrExpr.Concrete 1405.0
          sightDistance = ValueOrExpr.Concrete 364.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 192.0
          maxAcc = 0.07
          maxDec = 0.4275
          turnRate = 240.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 50.0
          workerTime = ValueOrExpr.Concrete 400.0
          buildDistance = 136.0
          buildOptions = ["armafus"; "armfus"; "armckfus"; "armageo"; "armgmm"; "armmoho"; "armmmkr"; "armuwadves"; "armuwadvms"; "armfort"; "armtarg"; "armgate"; "armamb"; "armpb"; "armanni"; "armflak"; "armmercury"; "armemp"; "armamd"; "armsilo"; "armbrtha"; "armvulc"; "armdf"; "armbanth"; "armaap"; "armhaap"; "armlab"; "armvp"; "armap"; "armsy"; "armsd"; "armshltx"]
          terraformSpeed = 300.0
          energyMake = ValueOrExpr.Concrete 20.0
          energyStorage = 75.0
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolcrmv"]
                select = ["seapsel1"] }
          customParams = Map.ofList [
                "model_author", "Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmSeaplanes"
                "techlevel", "3.0"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "true"
                "hoverattack", "true"
            ] }

    type Armsaber =
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

    let armsaber : Armsaber =
        { name = "armsaber"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 210.0
          energyCost = ValueOrExpr.Concrete 6400.0
          buildTime = ValueOrExpr.Concrete 11000.0
          health = ValueOrExpr.Concrete 1010.0
          sightDistance = ValueOrExpr.Concrete 595.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 156.89999
          maxAcc = 0.24
          maxDec = 0.46
          turnRate = 720.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 85.0
          weapons = [
                { name = "vtol_emg2"
                  displayName = Some "Light a2g discharge blaster"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "default", 60.0
                      "vtol", 10.0
                  ]
                  range = Some (ValueOrExpr.Concrete 425.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 980.0
                  areaOfEffect = Some 20.0
                  accuracy = Some 100.0
                  turret = Some false
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrhvy3"
                  soundHit = Some "xplosml3"
                  explosiongenerator = Some "custom:genericshellexplosion-small"
                  rgbColor = Some "0.05 0.05 1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.05"
                      "energypershot", "15.0"
                      "intensity", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "sizzle"
                      "thickness", "4.0"
                      "weapontimer", "1.0"
                  ] }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolcrmv"]
                select = ["seapsel1"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmSeaplanes"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "true"
                "hoverattack", "true"
                "nochasecategory", "VTOL"
            ] }

    type Armsb =
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

    let armsb : Armsb =
        { name = "armsb"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 7500.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 1170.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 267.29999
          maxAcc = 0.06
          maxDec = 0.045
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          cruiseAltitude = 210.0
          weapons = [
                { name = "arm_seaadvbomb"
                  displayName = Some "Medium a2g impulse warheads"
                  weaponType = Some "AircraftBomb"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 70.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 7.0)
                  weaponVelocity = None
                  areaOfEffect = Some 128.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = Some "bombsmed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "5.0"
                      "burstrate", "0.16667"
                      "collidefriendly", "false"
                      "commandfire", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "model", "airbombsea.s3o"
                      "mygravity", "0.4"
                      "soundhitwet", "splslrg"
                  ] }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolcrmv"]
                select = ["seapsel1"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmSeaplanes"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "cansubmerge", "true"
                "collide", "false"
                "maxaileron", "0.01347"
                "maxbank", "0.8"
                "maxelevator", "0.00972"
                "maxpitch", "0.625"
                "maxrudder", "0.00522"
                "noautofire", "true"
                "nochasecategory", "VTOL"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06222"
                "wingdrag", "3.035"
            ] }

    type Armseap =
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

    let armseap : Armseap =
        { name = "armseap"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 290.0
          energyCost = ValueOrExpr.Concrete 6500.0
          buildTime = ValueOrExpr.Concrete 18000.0
          health = ValueOrExpr.Concrete 1380.0
          sightDistance = ValueOrExpr.Concrete 535.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 271.20001
          maxAcc = 0.2
          maxDec = 0.375
          turnRate = 720.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          cruiseAltitude = 100.0
          weapons = [
                { name = "armseap_weapon1"
                  displayName = Some "Homing torpedo launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "commanders", 150.0
                      "default", 342.0
                      "vtol", 15.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.0)
                  weaponVelocity = Some 200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 12000.0
                  edgeEffectiveness = Some 0.25
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = Some "xplodep1"
                  explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                  rgbColor = None
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.ofList [
                      "speceffect", "torpwaterpen"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTSHIP"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "40.0"
                      "mount_onlytargetcategory", "NOTHOVER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "cegtag", "torpedotrail-tiny"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "3.0"
                      "model", "torpedo.s3o"
                      "predictboost", "1.0"
                      "soundhitvolume", "3.0"
                      "soundhitwet", "splsmed"
                      "soundhitwetvolume", "12.0"
                      "startvelocity", "130.0"
                      "tracks", "true"
                      "turnrate", "7000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "15.0"
                      "weapontimer", "4.0"
                  ] }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolcrmv"]
                select = ["seapsel1"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmSeaplanes"
                "unitgroup", "sub"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "true"
                "hoverattack", "true"
                "nochasecategory", "VTOL"
                "sonardistance", "535.0"
            ] }

    type Armsehak =
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

    let armsehak : Armsehak =
        { name = "armsehak"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 7000.0
          buildTime = ValueOrExpr.Concrete 11000.0
          health = ValueOrExpr.Concrete 580.0
          sightDistance = ValueOrExpr.Concrete 1100.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 338.10001
          maxAcc = 0.1325
          maxDec = 0.05
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          cruiseAltitude = 220.0
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
                select = ["seasonr2"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmSeaplanes"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "false"
                "maxaileron", "0.01403"
                "maxbank", "0.8"
                "maxelevator", "0.01028"
                "maxpitch", "0.625"
                "maxrudder", "0.00578"
                "radardistance", "2250.0"
                "sonardistance", "900.0"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06278"
                "wingdrag", "0.135"
            ] }

    type Armsfig =
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

    let armsfig : Armsfig =
        { name = "armsfig"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 4500.0
          buildTime = ValueOrExpr.Concrete 7000.0
          health = ValueOrExpr.Concrete 220.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 310.79999
          maxAcc = 0.2075
          maxDec = 0.1
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          cruiseAltitude = 140.0
          weapons = [
                { name = "armsfig_weapon"
                  displayName = Some "Guided a2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 4.0
                      "default", 12.0
                      "vtol", 210.0
                  ]
                  range = Some (ValueOrExpr.Concrete 710.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.83333)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = None
                  tolerance = Some 8000.0
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
                      "flighttime", "1.3"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smokecolor", "0.55"
                      "smokeperiod", "4.0"
                      "smokesize", "1.8"
                      "smoketime", "8.0"
                      "smoketrail", "false"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "startvelocity", "480.0"
                      "texture1", "null"
                      "texture2", "smoketrail"
                      "tracks", "true"
                      "turnrate", "22000.0"
                      "weaponacceleration", "425.0"
                      "weapontimer", "5.0"
                  ] }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolcrmv"]
                select = ["seapsel1"] }
          customParams = Map.ofList [
                "attacksafetydistance", "300.0"
                "fighter", "1.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmSeaplanes"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "950.0"
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "false"
                "maxaileron", "0.01403"
                "maxbank", "0.8"
                "maxelevator", "0.01028"
                "maxpitch", "0.625"
                "maxrudder", "0.00578"
                "nochasecategory", "NOTAIR"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06278"
                "wingdrag", "0.235"
            ] }

    type Armsfig2 =
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

    let armsfig2 : Armsfig2 =
        { name = "armsfig2"
          subfolder = "ArmSeaplanes"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 4500.0
          buildTime = ValueOrExpr.Concrete 7000.0
          health = ValueOrExpr.Concrete 220.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 310.79999
          maxAcc = 0.2075
          maxDec = 0.1
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          cruiseAltitude = 140.0
          weapons = [
                { name = "armsfig_weapon"
                  displayName = Some "Guided a2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 4.0
                      "default", 12.0
                      "vtol", 210.0
                  ]
                  range = Some (ValueOrExpr.Concrete 710.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.83333)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 8000.0
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
                      "flighttime", "1.3"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smokecolor", "0.55"
                      "smokeperiod", "4.0"
                      "smokesize", "1.8"
                      "smoketime", "8.0"
                      "smoketrail", "false"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "startvelocity", "480.0"
                      "texture1", "null"
                      "texture2", "smoketrail"
                      "tracks", "true"
                      "turnrate", "22000.0"
                      "weaponacceleration", "425.0"
                      "weapontimer", "5.0"
                  ] }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolcrmv"]
                select = ["seapsel1"] }
          customParams = Map.ofList [
                "attacksafetydistance", "300.0"
                "fighter", "1.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmSeaplanes"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "950.0"
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "false"
                "maxaileron", "0.01403"
                "maxbank", "0.8"
                "maxelevator", "0.01028"
                "maxpitch", "0.625"
                "maxrudder", "0.00578"
                "nochasecategory", "NOTAIR"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06278"
                "wingdrag", "0.235"
            ] }

