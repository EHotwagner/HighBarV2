// Auto-generated BAR unit data: Legion/Air
namespace BarData.V1.Units

open BarData.V1

module Legion_Air =

    let legatrans : UnitDef =
        { name = "legatrans"
          subfolder = "Legion/Air"
          metalCost = ValueOrExpr.Concrete 190.0
          energyCost = ValueOrExpr.Concrete 4000.0
          buildTime = ValueOrExpr.Concrete 8500.0
          health = ValueOrExpr.Concrete 800.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 3.0
          objectName = Some "Units/LEGATRANS.s3o"
          buildPic = Some "LEGATRANS.DDS"
          script = Some "Units/LEGATRANS.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "ALL MOBILE WEAPON NOTLAND VTOL NOTSUB NOTSHIP NOTHOVER"
          movement = Some (
            { speed = ValueOrExpr.Concrete 100.0
              maxAcc = 0.09
              maxDec = 0.75
              turnRate = 550.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 100.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "Legion/Air"
              "crashable", "0.0"
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

    let legcib : UnitDef =
        { name = "legcib"
          subfolder = "Legion/Air"
          metalCost = ValueOrExpr.Concrete 100.0
          energyCost = ValueOrExpr.Concrete 3500.0
          buildTime = ValueOrExpr.Concrete 4200.0
          health = ValueOrExpr.Concrete 890.0
          sightDistance = ValueOrExpr.Concrete 835.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGCIB.s3o"
          buildPic = Some "LEGCIB.DDS"
          script = Some "Units/LEGCIB.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 300.0
              maxAcc = 0.1825
              maxDec = 0.055
              turnRate = 800.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 130.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "juno_pulse_mini"
                displayName = Some "Anti radar/minefield/jammer magnetic impulse bomb"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "mines", 1000.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 10.0)
                weaponVelocity = Some 300.0
                areaOfEffect = Some 700.0
                accuracy = Some 500.0
                turret = None
                tolerance = Some 16000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = Some "bombrel"
                soundHit = Some "junohit2"
                explosiongenerator = Some "custom:juno-explo-mini"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "junotype", "mini"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "cegtag", "missiletrail-juno"
                    "collidefriendly", "false"
                    "commandfire", "false"
                    "craterareaofeffect", "600.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "epulse_mini.s3o"
                    "model", "legmediumrocket.s3o"
                    "mygravity", "0.2"
                    "smoketrail", "true"
                    "smokePeriod", "8.0"
                    "smoketime", "45.0"
                    "smokesize", "14.0"
                    "smokecolor", "0.7"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "true"
                    "tracks", "true"
                    "turnrate", "10000.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorAircraft"
          ]
          extras = Map.ofList [
              "acceleration", "0.2"
              "blocking", "false"
              "collide", "true"
              "firestate", "0.0"
              "maxaileron", "0.0144"
              "maxbank", "0.8"
              "maxelevator", "0.01065"
              "maxpitch", "0.625"
              "maxrudder", "0.00615"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "speedtofront", "0.06183"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06296"
              "wingdrag", "0.08"
          ] }

    let legdrone : UnitDef =
        { name = "legdrone"
          subfolder = "Legion/Air"
          metalCost = ValueOrExpr.Concrete 15.0
          energyCost = ValueOrExpr.Concrete 500.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 325.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/LEGDRONE.s3o"
          buildPic = Some "legdrone.DDS"
          script = Some "Units/LEGDRONE.cob"
          corpse = None
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 280.5
              maxAcc = 0.35
              maxDec = 0.7
              turnRate = 1100.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 78.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "semiauto"
                displayName = Some "Burst-fire Machine Gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 12.0
                    "vtol", 6.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 692.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.5
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "mgun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "90.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "2.0"
                    "burstrate", "0.066"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.05"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "sprayangle", "1024.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorAircraft"
              "drone", "1.0"
              "nohealthbars", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "cantbetransported", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "COMMANDER VTOL"
              "repairable", "false"
              "upright", "true"
              "usesmoothmesh", "0.0"
          ] }

    let legfig : UnitDef =
        { name = "legfig"
          subfolder = "Legion/Air"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 2000.0
          health = ValueOrExpr.Concrete 220.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGFIG.s3o"
          buildPic = Some "LEGFIG.DDS"
          script = Some "Units/LEGFIG.cob"
          corpse = None
          explodeAs = Some "smallExplosionGenericAir"
          selfDestructAs = Some "smallExplosionGenericAir"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 270.0
              maxAcc = 0.2
              maxDec = 0.075
              turnRate = 950.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 125.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "semiauto"
                displayName = Some "Burst-Fire A2A Machine Gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 1.0
                    "default", 2.0
                    "vtol", 36.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.6)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 0.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 2400.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.4 0.95"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "20.0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "true"
                    "avoidfriendly", "false"
                    "burst", "2.0"
                    "burstrate", "0.1"
                    "burnblow", "false"
                    "collideFriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.05"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "predictboost", "0.5"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "3.0"
                    "soundTrigger", "true"
                    "sprayangle", "500.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "3.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolarmv"]
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "unitgroup", "aa"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Air"
              "attacksafetydistance", "300.0"
              "fighter", "1.0"
          ]
          extras = Map.ofList [
              "acceleration", "0.35"
              "airsightdistance", "950.0"
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.0144"
              "maxbank", "0.8"
              "maxelevator", "0.01065"
              "maxpitch", "0.625"
              "maxrudder", "0.00615"
              "nochasecategory", "NOTAIR"
              "radardistance", "400.0"
              "speedtofront", "0.06417"
              "turnradius", "48.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06315"
              "wingdrag", "0.185"
          ] }

    let legkam : UnitDef =
        { name = "legkam"
          subfolder = "Legion/Air"
          metalCost = ValueOrExpr.Concrete 65.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 2200.0
          health = ValueOrExpr.Concrete 160.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legkam.s3o"
          buildPic = Some "LEGKAM.DDS"
          script = Some "Units/legkam.cob"
          corpse = None
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some ""
          collisionVolumeOffsets = Some "0 5 12"
          collisionVolumeScales = Some "15 15 40"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 220.0
              maxAcc = 0.6
              maxDec = 0.1
              turnRate = 750.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 50.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "trigger"
                displayName = Some "Martyr trigger"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 1280.0)
                reloadTime = Some (ValueOrExpr.Concrete 10.0)
                weaponVelocity = None
                areaOfEffect = Some 0.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = None
                soundHit = None
                explosiongenerator = None
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 -1 1"
                    "mount_maxangledif", "150.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "3.0"
                    "burstrate", "0.5"
                    "collidefriendly", "0.0"
                    "commandfire", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "legnade.s3o"
                    "mygravity", "0.23"
                ] }
              { name = "crawl_detonator"
                displayName = Some "Mine Detonator"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "vtol", 1000.0
                    "default", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 1.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 10.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = Some "bombdropxx"
                soundHit = Some "bombdropxx"
                explosiongenerator = Some ""
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
                    "firesubmersed", "true"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                ] }
              { name = "martyrbomb"
                displayName = Some "Crawlingbomb Dummy Weapon"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "commanders", 220.0
                    "default", 440.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 10.0)
                weaponVelocity = None
                areaOfEffect = Some 200.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = Some "bombdropxx"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericunitexplosion-medium-dirty"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "legvision"
                    "spawns_surface", "LAND SEA"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "collidefriendly", "0.0"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "metalpershot", "1000000000.0"
                    "model", "Units/legkam.s3o"
                    "mygravity", "0.2"
                    "soundhitwet", "sizzle"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Air"
              "crashable", "0.0"
          ]
          extras = Map.ofList [
              "acceleration", "0.3"
              "blocking", "false"
              "collide", "false"
              "firestate", "0.0"
              "maxaileron", "0.028"
              "maxbank", "0.8"
              "maxelevator", "0.01"
              "maxpitch", "0.625"
              "maxrudder", "0.015"
              "nochasecategory", "VTOL"
              "selfdestructcountdown", "0.0"
              "speedtofront", "0.06183"
              "turnradius", "48.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06296"
              "wingdrag", "0.06"
          ] }

    let leglts : UnitDef =
        { name = "leglts"
          subfolder = "Legion/Air"
          metalCost = ValueOrExpr.Concrete 68.0
          energyCost = ValueOrExpr.Concrete 1300.0
          buildTime = ValueOrExpr.Concrete 3850.0
          health = ValueOrExpr.Concrete 265.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 3.0
          objectName = Some "Units/leglts.s3o"
          buildPic = Some "leglts.DDS"
          script = Some "Units/leglts.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 207.0
              maxAcc = 0.1
              maxDec = 0.75
              turnRate = 550.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 100.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolarmv"]
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "Legion/Air"
              "crashable", "0.0"
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

    let legmos : UnitDef =
        { name = "legmos"
          subfolder = "Legion/Air"
          metalCost = ValueOrExpr.Concrete 110.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 4000.0
          health = ValueOrExpr.Concrete 415.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legmos.s3o"
          buildPic = Some "LEGMOS.DDS"
          script = Some "Units/legmos.cob"
          corpse = None
          explodeAs = Some "smallExplosionGeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 165.0
              maxAcc = 0.3
              maxDec = 0.75
              turnRate = 1400.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 70.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "cor_bot_rocket"
                displayName = Some "Rockets"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 44.0
                ]
                range = Some (ValueOrExpr.Concrete 380.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some false
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rocklit1"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-small"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "collideFriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "intensity", "1.5"
                    "metalpershot", "0.0"
                    "model", "legsmallrocket.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "7.0"
                    "smoketime", "20.0"
                    "smokesize", "2.2"
                    "smokecolor", "1.0"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "true"
                    "soundhitwet", "splshbig"
                    "startvelocity", "300.0"
                    "stockpile", "true"
                    "stockpiletime", "1.8"
                    "texture1", "null"
                    "texture2", "smoketraildark"
                    "tracks", "true"
                    "turnrate", "20000.0"
                    "weaponacceleration", "160.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolarmv"]
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "ArmAircraft"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
          ] }

    let all : (string * UnitDef) list =
        [
            "legatrans", legatrans
            "legcib", legcib
            "legdrone", legdrone
            "legfig", legfig
            "legkam", legkam
            "leglts", leglts
            "legmos", legmos
        ]
