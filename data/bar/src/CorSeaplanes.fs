// Auto-generated BAR unit data: CorSeaplanes (flat per-unit types)
namespace BarData.Units

open BarData

module CorSeaplanes =

    type Corcsa =
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

    let corcsa : Corcsa =
        { name = "corcsa"
          subfolder = "CorSeaplanes"
          metalCost = ValueOrExpr.Concrete 140.0
          energyCost = ValueOrExpr.Concrete 8200.0
          buildTime = ValueOrExpr.Concrete 14500.0
          health = ValueOrExpr.Concrete 435.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 217.5
          maxAcc = 0.072
          maxDec = 0.4275
          turnRate = 240.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 55.0
          workerTime = ValueOrExpr.Concrete 75.0
          buildDistance = 136.0
          buildOptions = ["corsolar"; "coradvsol"; "corwin"; "corgeo"; "cormstor"; "corestor"; "cormex"; "corexp"; "cormakr"; "corlab"; "corvp"; "corap"; "corhp"; "cornanotc"; "cornanotcplat"; "coreyes"; "corrad"; "cordrag"; "cormaw"; "corllt"; "corhllt"; "corhlt"; "corpun"; "corrl"; "cormadsam"; "corerad"; "cordl"; "corjamt"; "corjuno"; "corfhp"; "corsy"; "coramsub"; "corplat"; "coraap"; "cortide"; "corfmkr"; "coruwms"; "coruwes"; "corfdrag"; "corfrad"; "corfhlt"; "corfrt"; "cortl"; "coruwgeo"]
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
                select = ["seapsel2"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorSeaplanes"
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "true"
                "hoverattack", "true"
            ] }

    type Corcut =
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

    let corcut : Corcut =
        { name = "corcut"
          subfolder = "CorSeaplanes"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 5400.0
          buildTime = ValueOrExpr.Concrete 11500.0
          health = ValueOrExpr.Concrete 1010.0
          sightDistance = ValueOrExpr.Concrete 595.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 152.39999
          maxAcc = 0.18
          maxDec = 0.3938
          turnRate = 550.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 85.0
          weapons = [
                { name = "vtol_rocket2"
                  displayName = Some "RiotCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 47.0
                      "vtol", 9.0
                  ]
                  range = Some (ValueOrExpr.Concrete 430.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.3)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 18.0
                  accuracy = None
                  turret = Some false
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "canlite3"
                  soundHit = Some "xplosml3"
                  explosiongenerator = Some "custom:genericshellexplosion-small"
                  rgbColor = Some "0.8 0.8 0.1"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "burst", "2.0"
                      "burstrate", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "predictboost", "0.3"
                      "size", "3.0"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
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
                select = ["seapsel2"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorSeaplanes"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "true"
                "hoverattack", "true"
                "nochasecategory", "VTOL"
            ] }

    type Corhaca =
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

    let corhaca : Corhaca =
        { name = "corhaca"
          subfolder = "CorSeaplanes"
          metalCost = ValueOrExpr.Concrete 1040.0
          energyCost = ValueOrExpr.Concrete 28800.0
          buildTime = ValueOrExpr.Concrete 58000.0
          health = ValueOrExpr.Concrete 1435.0
          sightDistance = ValueOrExpr.Concrete 351.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 182.0
          maxAcc = 0.072
          maxDec = 0.4275
          turnRate = 240.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 55.0
          workerTime = ValueOrExpr.Concrete 450.0
          buildDistance = 136.0
          buildOptions = ["corafus"; "corfus"; "corageo"; "corbhmth"; "cormoho"; "cormexp"; "cormmkr"; "coruwadves"; "coruwadvms"; "corfort"; "cortarg"; "corgate"; "cortoast"; "corvipe"; "cordoom"; "corflak"; "corscreamer"; "cortron"; "corfmd"; "corsilo"; "corint"; "corbuzz"; "coraap"; "corhaap"; "corjugg"; "corkorg"; "corlab"; "corsy"; "corvp"; "corap"; "corgant"; "corsd"]
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
                select = ["seapsel2"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorSeaplanes"
                "techlevel", "3.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "true"
                "hoverattack", "true"
            ] }

    type Corhunt =
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

    let corhunt : Corhunt =
        { name = "corhunt"
          subfolder = "CorSeaplanes"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 6900.0
          buildTime = ValueOrExpr.Concrete 11500.0
          health = ValueOrExpr.Concrete 730.0
          sightDistance = ValueOrExpr.Concrete 1130.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 324.29999
          maxAcc = 0.1425
          maxDec = 0.0375
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          cruiseAltitude = 190.0
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
                select = ["seasonr2"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorSeaplanes"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "false"
                "maxaileron", "0.01377"
                "maxbank", "0.8"
                "maxelevator", "0.01002"
                "maxpitch", "0.625"
                "maxrudder", "0.00552"
                "radardistance", "2200.0"
                "sonardistance", "900.0"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06252"
                "wingdrag", "0.11"
            ] }

    type Corsb =
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

    let corsb : Corsb =
        { name = "corsb"
          subfolder = "CorSeaplanes"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 8200.0
          buildTime = ValueOrExpr.Concrete 9000.0
          health = ValueOrExpr.Concrete 940.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 240.0
          maxAcc = 0.06
          maxDec = 0.045
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          cruiseAltitude = 150.0
          weapons = [
                { name = "cor_seaadvbomb"
                  displayName = Some "CorSeaAdvancedBombs"
                  weaponType = Some "AircraftBomb"
                  damage = Map.ofList [
                      "default", 50.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = None
                  areaOfEffect = Some 100.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = None
                  explosiongenerator = Some "custom:genericshellexplosion-small-bomb"
                  rgbColor = Some "0.8 0.8 0.25"
                  onlyTargetCategory = None
                  badTargetCategory = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "bounceexplosiongenerator", "custom:genericshellexplosion-small"
                      "bouncerebound", "0.15"
                      "bounceslip", "0.75"
                      "burst", "3.0"
                      "burstrate", "0.13333"
                      "collidefriendly", "false"
                      "commandfire", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "intensity", "0.01"
                      "model", "airbombsea.s3o"
                      "mygravity", "0.4"
                      "numbounce", "3.0"
                      "projectiles", "8.0"
                      "size", "8.0"
                      "soundhitdry", "bombsmed2"
                      "soundhitwet", "splsmed"
                      "sprayangle", "6000.0"
                      "waterbounce", "true"
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
                select = ["seapsel2"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorSeaplanes"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "blocking", "false"
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
                "wingdrag", "0.125"
            ] }

    type Corseap =
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

    let corseap : Corseap =
        { name = "corseap"
          subfolder = "CorSeaplanes"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 5500.0
          buildTime = ValueOrExpr.Concrete 13000.0
          health = ValueOrExpr.Concrete 1070.0
          sightDistance = ValueOrExpr.Concrete 535.0
          footprintX = 3.0
          footprintZ = 3.0
          speed = ValueOrExpr.Concrete 266.10001
          maxAcc = 0.22
          maxDec = 0.375
          turnRate = 610.0
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
                      "default", 342.0
                      "vtol", 15.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 12000.0
                  edgeEffectiveness = Some 0.35
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = Some "xplodep3"
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
                select = ["seapsel2"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorSeaplanes"
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

    type Corsfig =
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

    let corsfig : Corsfig =
        { name = "corsfig"
          subfolder = "CorSeaplanes"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 4600.0
          buildTime = ValueOrExpr.Concrete 6500.0
          health = ValueOrExpr.Concrete 220.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 315.60001
          maxAcc = 0.2175
          maxDec = 0.1
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          cruiseAltitude = 140.0
          weapons = [
                { name = "corsfig_weapon"
                  displayName = Some "Guided a2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 4.0
                      "default", 12.0
                      "vtol", 200.0
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
                      "weapontimer", "9.0"
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
                select = ["seapsel2"] }
          customParams = Map.ofList [
                "attacksafetydistance", "300.0"
                "fighter", "1.0"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorSeaplanes"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "950.0"
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "false"
                "maxaileron", "0.01377"
                "maxbank", "0.8"
                "maxelevator", "0.01002"
                "maxpitch", "0.625"
                "maxrudder", "0.00552"
                "nochasecategory", "NOTAIR"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06252"
                "wingdrag", "0.235"
            ] }

    type Corsfig2 =
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

    let corsfig2 : Corsfig2 =
        { name = "corsfig2"
          subfolder = "CorSeaplanes"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 4600.0
          buildTime = ValueOrExpr.Concrete 6500.0
          health = ValueOrExpr.Concrete 220.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 315.60001
          maxAcc = 0.2175
          maxDec = 0.1
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          cruiseAltitude = 140.0
          weapons = [
                { name = "corsfig_weapon"
                  displayName = Some "Guided a2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 4.0
                      "default", 12.0
                      "vtol", 200.0
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
                      "weapontimer", "9.0"
                  ] }
                { name = "small_weapon"
                  displayName = Some "Guided a2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 4.0
                      "default", 12.0
                      "vtol", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 710.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.83333)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = None
                  tolerance = Some 15000.0
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
                      "weapontimer", "9.0"
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
                select = ["seapsel2"] }
          customParams = Map.ofList [
                "attacksafetydistance", "300.0"
                "fighter", "1.0"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorSeaplanes"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "950.0"
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "false"
                "maxaileron", "0.01377"
                "maxbank", "0.8"
                "maxelevator", "0.01002"
                "maxpitch", "0.625"
                "maxrudder", "0.00552"
                "nochasecategory", "NOTAIR"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06252"
                "wingdrag", "0.235"
            ] }

    type Leghaca =
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

    let leghaca : Leghaca =
        { name = "leghaca"
          subfolder = "CorSeaplanes"
          metalCost = ValueOrExpr.Concrete 960.0
          energyCost = ValueOrExpr.Concrete 32800.0
          buildTime = ValueOrExpr.Concrete 58000.0
          health = ValueOrExpr.Concrete 435.0
          sightDistance = ValueOrExpr.Concrete 351.0
          footprintX = 2.0
          footprintZ = 2.0
          speed = ValueOrExpr.Concrete 217.5
          maxAcc = 0.072
          maxDec = 0.4275
          turnRate = 240.0
          maxSlope = 10.0
          maxWaterDepth = 255.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 55.0
          workerTime = ValueOrExpr.Concrete 400.0
          buildDistance = 136.0
          buildOptions = ["legafus"; "leggant"; "legageo"; "legrampart"; "legmoho"; "legadveconv"; "legadvestore"; "legamstor"; "legforti"; "legtarg"; "legdeflector"; "legacluster"; "legapopupdef"; "legbastion"; "legflak"; "leglraa"; "legperdition"; "legabm"; "legsilo"; "leglrpc"; "legstarfall"; "legaap"; "leghaap"; "legvp"; "legap"; "corsy"; "legnanotc"; "legfus"; "legsd"; "leglab"; "legeheatraymech"; "legelrpcmech"]
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
                select = ["seapsel2"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorSeaplanes"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "cansubmerge", "true"
                "collide", "true"
                "hoverattack", "true"
            ] }

