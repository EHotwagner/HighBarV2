// Auto-generated BAR unit data: Legion/SeaPlanes
namespace BarData.V1.Units

open BarData.V1

module Legion_SeaPlanes =

    let legspbomber : UnitDef =
        { name = "legspbomber"
          subfolder = "Legion/SeaPlanes"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 7500.0
          buildTime = ValueOrExpr.Concrete 9890.0
          health = ValueOrExpr.Concrete 1170.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legspbomber.s3o"
          buildPic = Some "legspbomber.DDS"
          script = Some "Units/legspbomber.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 267.29999
              maxAcc = 0.06
              maxDec = 0.045
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 210.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "leg_seaplane_bomb"
                displayName = Some "Advanced Scatterfire Warheads"
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
                    "model", "legkambomb.s3o"
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
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["seapsel1"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/SeaPlanes"
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

    let legspfighter : UnitDef =
        { name = "legspfighter"
          subfolder = "Legion/SeaPlanes"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 4500.0
          buildTime = ValueOrExpr.Concrete 6540.0
          health = ValueOrExpr.Concrete 220.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legspfighter.s3o"
          buildPic = Some "legspfighter.DDS"
          script = Some "Units/legspfighter.cob"
          corpse = None
          explodeAs = Some "smallExplosionGenericAir"
          selfDestructAs = Some "smallExplosionGenericAir"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 310.79999
              maxAcc = 0.2075
              maxDec = 0.1
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 140.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "leg_light_antiair_missile"
                displayName = Some "Light Salvo Missile Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 37.0
                ]
                range = Some (ValueOrExpr.Concrete 760.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 2500.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = None
                tolerance = Some 12000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "burst", "3.0"
                    "burstrate", "0.005"
                    "dance", "150.0"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "model", "legsmallrocket.s3o"
                    "smoketrail", "true"
                    "smokecolor", "0.95"
                    "smokeperiod", "5.0"
                    "smokesize", "0.5"
                    "smoketime", "5.0"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "800.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "300.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["seapsel1"] })
          customParams = Map.ofList [
              "attacksafetydistance", "300.0"
              "fighter", "1.0"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/SeaPlanes"
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

    let legspradarsonarplane : UnitDef =
        { name = "legspradarsonarplane"
          subfolder = "Legion/SeaPlanes"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 7000.0
          buildTime = ValueOrExpr.Concrete 10680.0
          health = ValueOrExpr.Concrete 580.0
          sightDistance = ValueOrExpr.Concrete 1100.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legspradarsonarplane.s3o"
          buildPic = Some "legspradarsonarplane.DDS"
          script = Some "Units/legspradarsonarplane.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 338.10001
              maxAcc = 0.1325
              maxDec = 0.05
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolarmv"]
              select = ["seasonr2"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/SeaPlanes"
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

    let legspsurfacegunship : UnitDef =
        { name = "legspsurfacegunship"
          subfolder = "Legion/SeaPlanes"
          metalCost = ValueOrExpr.Concrete 270.0
          energyCost = ValueOrExpr.Concrete 6700.0
          buildTime = ValueOrExpr.Concrete 12140.0
          health = ValueOrExpr.Concrete 1200.0
          sightDistance = ValueOrExpr.Concrete 595.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legspsurfacegunship.s3o"
          buildPic = Some "legspsurfacegunship.DDS"
          script = Some "Units/legspsurfacegunship.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 148.0
              maxAcc = 0.17
              maxDec = 0.38
              turnRate = 720.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 85.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "leg_riot_cannon"
                displayName = Some "Area Control Riot Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 200.0
                    "subs", 45.0
                    "vtol", 10.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.5)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 140.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 2.0
                noSelfDamage = Some true
                soundStart = Some "largegun"
                soundHit = Some "corlevlrhit"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "soundhitwet", "splsmed"
                    "soundhitvolume", "12.0"
                    "soundstartvolume", "14.0"
                    "separation", "2.0"
                    "nogap", "false"
                    "size", "3.0"
                    "sizeDecay", "0.07"
                    "stages", "10.0"
                    "alphaDecay", "0.1"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["seapsel1"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/SeaPlanes"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "cansubmerge", "true"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
          ] }

    let legsptorpgunship : UnitDef =
        { name = "legsptorpgunship"
          subfolder = "Legion/SeaPlanes"
          metalCost = ValueOrExpr.Concrete 190.0
          energyCost = ValueOrExpr.Concrete 5000.0
          buildTime = ValueOrExpr.Concrete 10720.0
          health = ValueOrExpr.Concrete 900.0
          sightDistance = ValueOrExpr.Concrete 535.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legsptorpgunship.s3o"
          buildPic = Some "legsptorpgunship.DDS"
          script = Some "Units/legsptorpgunship.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 273.0
              maxAcc = 0.24
              maxDec = 0.4
              turnRate = 720.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 255.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 100.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "leg_torpedo_launcher"
                displayName = Some "VTOL Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "commanders", 70.0
                    "default", 140.0
                    "vtol", 15.0
                ]
                range = Some (ValueOrExpr.Concrete 460.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.5)
                weaponVelocity = Some 250.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 12000.0
                edgeEffectiveness = Some 0.25
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "splsmed"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "speceffect", "torpwaterpen"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSHIP"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "120.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "burst", "2.0"
                    "burstrate", "0.3"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "3.0"
                    "gravityaffected", "false"
                    "model", "legtorpedomini.s3o"
                    "predictboost", "0.3"
                    "soundhitwet", "xplodep1"
                    "soundhitvolume", "1.5"
                    "soundhitwetvolume", "3.0"
                    "startvelocity", "200.0"
                    "tracks", "true"
                    "turnrate", "8000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "2.0"
                    "weapontimer", "4.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["seapsel1"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Seaplanes"
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

    let all : (string * UnitDef) list =
        [
            "legspbomber", legspbomber
            "legspfighter", legspfighter
            "legspradarsonarplane", legspradarsonarplane
            "legspsurfacegunship", legspsurfacegunship
            "legsptorpgunship", legsptorpgunship
        ]
