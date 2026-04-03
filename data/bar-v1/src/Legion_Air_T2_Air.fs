// Auto-generated BAR unit data: Legion/Air/T2 Air
namespace BarData.V1.Units

open BarData.V1

module Legion_Air_T2_Air =

    let legafigdef : UnitDef =
        { name = "legafigdef"
          subfolder = "Legion/Air/T2 Air"
          metalCost = ValueOrExpr.Concrete 180.0
          energyCost = ValueOrExpr.Concrete 6200.0
          buildTime = ValueOrExpr.Concrete 11850.0
          health = ValueOrExpr.Concrete 480.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legafigdef.s3o"
          buildPic = Some "legafigdef.DDS"
          script = Some "Units/legafigdef.cob"
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
              maxAcc = 0.4
              maxDec = 0.0875
              turnRate = 1500.0
              movementClass = None
              maxSlope = Some 15.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 160.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "leggun"
                displayName = Some "Heavy A2A Gatling Guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 1.0
                    "default", 2.0
                    "vtol", 80.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 2500.0
                areaOfEffect = Some 2.0
                accuracy = Some 5.0
                turret = Some true
                tolerance = Some 2400.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "minigun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.4 0.95"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "18.0"
                    "mount_onlytargetcategory", "VTOL"
                    "mount_weaponAimAdjustPriority", "20.0"
                    "mount_fastAutoRetargeting", "true"
                    "avoidfeature", "true"
                    "avoidfriendly", "false"
                    "burst", "10.0"
                    "burstrate", "0.04"
                    "burnblow", "false"
                    "collideFriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.05"
                    "fallOffRate", "0.0"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "minIntensity", "0.8"
                    "ownerExpAccWeight", "8.0"
                    "predictboost", "1.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "2.0"
                    "soundTrigger", "true"
                    "sprayangle", "125.0"
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
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "unitgroup", "aa"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Air/T2 Air"
              "techlevel", "2.0"
              "attacksafetydistance", "300.0"
              "fighter", "1.0"
          ]
          extras = Map.ofList [
              "airsightdistance", "1100.0"
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.016"
              "maxbank", "0.72"
              "maxelevator", "0.013"
              "maxpitch", "0.745"
              "maxrudder", "0.015"
              "nochasecategory", "NOTAIR"
              "speedtofront", "0.06475"
              "stealth", "false"
              "turnradius", "32.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06363"
              "wingdrag", "0.21"
          ] }

    let legatorpbomber : UnitDef =
        { name = "legatorpbomber"
          subfolder = "Legion/Air/T2 Air"
          metalCost = ValueOrExpr.Concrete 480.0
          energyCost = ValueOrExpr.Concrete 9480.0
          buildTime = ValueOrExpr.Concrete 21970.0
          health = ValueOrExpr.Concrete 1900.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGATORPBOMBER.s3o"
          buildPic = Some "LEGATORPBOMBER.DDS"
          script = Some "Units/LEGATORPBOMBER.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 290.0
              maxAcc = 0.1325
              maxDec = 0.0725
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 90.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "legair_torp"
                displayName = Some "Medium Homing Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 750.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 7.0)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some false
                tolerance = Some 2000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "speceffect", "torpwaterpen"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSHIP"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-large"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "4.0"
                    "model", "legmediumtorpedo.s3o"
                    "mygravity", "0.1"
                    "soundhitvolume", "3.5"
                    "soundhitwet", "splsmed"
                    "soundhitwetvolume", "14.0"
                    "startvelocity", "35.0"
                    "tracks", "true"
                    "turnrate", "17000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "35.0"
                    "weapontimer", "6.0"
                ] }
              { name = "legair_torp"
                displayName = Some "Medium Homing Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 750.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 7.0)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some false
                tolerance = Some 2000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "speceffect", "torpwaterpen"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSHIP"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-large"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "4.0"
                    "model", "legmediumtorpedo.s3o"
                    "mygravity", "0.1"
                    "soundhitvolume", "3.5"
                    "soundhitwet", "splsmed"
                    "soundhitwetvolume", "14.0"
                    "startvelocity", "35.0"
                    "tracks", "true"
                    "turnrate", "17000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "35.0"
                    "weapontimer", "6.0"
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
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Air/T2 Air"
              "techlevel", "2.0"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "maxaileron", "0.01347"
              "maxbank", "0.8"
              "maxelevator", "0.00972"
              "maxpitch", "0.625"
              "maxrudder", "0.00522"
              "nochasecategory", "VTOL"
              "radardistance", "800.0"
              "sonardistance", "800.0"
              "speedtofront", "0.063"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06222"
              "wingdrag", "0.18"
          ] }

    let legfort : UnitDef =
        { name = "legfort"
          subfolder = "Legion/Air/T2 Air"
          metalCost = ValueOrExpr.Concrete 5600.0
          energyCost = ValueOrExpr.Concrete 79000.0
          buildTime = ValueOrExpr.Concrete 119750.0
          health = ValueOrExpr.Concrete 16700.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGFORT.s3o"
          buildPic = Some "LEGFORT.DDS"
          script = Some "Units/legfort.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "70 40 110"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 93.0
              maxAcc = 0.09
              maxDec = 0.09
              turnRate = 240.0
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
          weapons = Some [
              { name = "plasma"
                displayName = Some "PlasmaCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 166.0
                    "subs", 50.0
                    "vtol", 30.0
                ]
                range = Some (ValueOrExpr.Concrete 915.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.7)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 160.0
                accuracy = Some 960.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 1.25
                noSelfDamage = Some true
                soundStart = Some "cannhvy2"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTLAND"
                    "mount_maindir", "-1 0 0"
                    "mount_maxangledif", "210.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "arty-heavy"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "plasma"
                displayName = Some "PlasmaCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 166.0
                    "subs", 50.0
                    "vtol", 30.0
                ]
                range = Some (ValueOrExpr.Concrete 915.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.7)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 160.0
                accuracy = Some 960.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 1.25
                noSelfDamage = Some true
                soundStart = Some "cannhvy2"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTLAND"
                    "mount_maindir", "1 0 0"
                    "mount_maxangledif", "210.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "arty-heavy"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "semiauto"
                displayName = Some "Burst-fire Machine Gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 36.0
                    "vtol", 18.0
                ]
                range = Some (ValueOrExpr.Concrete 650.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 970.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.5
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "240.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "3.0"
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
              { name = "semiauto"
                displayName = Some "Burst-fire Machine Gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 36.0
                    "vtol", 18.0
                ]
                range = Some (ValueOrExpr.Concrete 650.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 970.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.5
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "-1 0 0"
                    "mount_maxangledif", "190.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "3.0"
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
              { name = "semiauto"
                displayName = Some "Burst-fire Machine Gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 36.0
                    "vtol", 18.0
                ]
                range = Some (ValueOrExpr.Concrete 650.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 970.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.5
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "1 0 0"
                    "mount_maxangledif", "190.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "3.0"
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
              { name = "aa_missiles"
                displayName = Some "Advanced d2a rapid missile launcher"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "vtol", 76.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 1200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = None
                tolerance = Some 9950.0
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
                    "mount_maindir", "0 1 0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "72.0"
                    "fixedLauncher", "true"
                    "flighttime", "2.5"
                    "model", "legsmallrocket.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "5.0"
                    "smoketime", "8.0"
                    "smokesize", "4.2"
                    "smokecolor", "1.0"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "175.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "trajectoryHeight", "1.0"
                    "turnrate", "58000.0"
                    "weaponacceleration", "800.0"
                    "weapontimer", "0.28"
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
              "model_author", "tHARSIS"
              "normaltex", "unittextures/LEG_normal.dds"
              "subfolder", "CorAircraft/T2"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "bankingallowed", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
              "radardistance", "1000.0"
              "upright", "true"
          ] }

    let legheavydrone : UnitDef =
        { name = "legheavydrone"
          subfolder = "Legion/Air/T2 Air"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 5820.0
          health = ValueOrExpr.Concrete 1650.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGHEAVYDRONE.s3o"
          buildPic = Some "legheavydrone.DDS"
          script = Some "Units/LEGHEAVYDRONE.cob"
          corpse = None
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 180.5
              maxAcc = 0.15
              maxDec = 0.35
              turnRate = 750.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 68.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "heat_ray"
                displayName = Some "a2g Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 10.0
                    "vtol", 2.0
                ]
                range = Some (ValueOrExpr.Concrete 430.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 950.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 4400.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heliosfire"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small"
                rgbColor = Some "1 0.55 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_burstControlWhenOutOfArc", "1.0"
                    "avoidfeature", "false"
                    "beamburst", "true"
                    "burst", "10.0"
                    "burstrate", "0.03"
                    "corethickness", "0.23"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "30.0"
                    "fireTolerance", "4400.0"
                    "impactonly", "1.0"
                    "laserflaresize", "10.0"
                    "predictboost", "1.0"
                    "rgbcolor2", "0.9 1.0 0.5"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
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
          ] }

    let legheavydronesmall : UnitDef =
        { name = "legheavydronesmall"
          subfolder = "Legion/Air/T2 Air"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 5820.0
          health = ValueOrExpr.Concrete 1650.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legheavydronesmall.s3o"
          buildPic = Some "legheavydrone.DDS"
          script = Some "Units/legheavydrone.cob"
          corpse = None
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 180.5
              maxAcc = 0.15
              maxDec = 0.35
              turnRate = 750.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 68.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "heat_ray"
                displayName = Some "a2g Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 10.0
                    "vtol", 2.0
                ]
                range = Some (ValueOrExpr.Concrete 430.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 950.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 4400.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heliosfire"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small"
                rgbColor = Some "1 0.55 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_burstControlWhenOutOfArc", "1.0"
                    "avoidfeature", "false"
                    "beamburst", "true"
                    "burst", "10.0"
                    "burstrate", "0.03"
                    "corethickness", "0.23"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "30.0"
                    "fireTolerance", "4400.0"
                    "impactonly", "1.0"
                    "laserflaresize", "10.0"
                    "predictboost", "1.0"
                    "rgbcolor2", "0.9 1.0 0.5"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
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
          ] }

    let legionnaire : UnitDef =
        { name = "legionnaire"
          subfolder = "Legion/Air/T2 Air"
          metalCost = ValueOrExpr.Concrete 180.0
          energyCost = ValueOrExpr.Concrete 6200.0
          buildTime = ValueOrExpr.Concrete 11850.0
          health = ValueOrExpr.Concrete 480.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legionnaire.s3o"
          buildPic = Some "legionnaire.DDS"
          script = Some "Units/legionnaire.cob"
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
              maxAcc = 0.35
              maxDec = 0.0875
              turnRate = 1500.0
              movementClass = None
              maxSlope = Some 15.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 160.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "leggun"
                displayName = Some "Rapid-fire dual A2A machine guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 1.0
                    "default", 2.0
                    "vtol", 80.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 2500.0
                areaOfEffect = Some 2.0
                accuracy = Some 5.0
                turret = Some true
                tolerance = Some 2400.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "minigun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.4 0.95"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "18.0"
                    "mount_onlytargetcategory", "VTOL"
                    "mount_weaponAimAdjustPriority", "20.0"
                    "mount_fastAutoRetargeting", "true"
                    "avoidfeature", "true"
                    "avoidfriendly", "false"
                    "burst", "10.0"
                    "burstrate", "0.04"
                    "burnblow", "false"
                    "collideFriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.02"
                    "fallOffRate", "0.0"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "minIntensity", "0.8"
                    "ownerExpAccWeight", "8.0"
                    "predictboost", "1.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "2.0"
                    "sprayangle", "125.0"
                    "thickness", "0.6"
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
              "unitgroup", "aa"
              "model_author", "Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorAircraft/T2"
              "techlevel", "2.0"
              "attacksafetydistance", "300.0"
              "fighter", "1.0"
          ]
          extras = Map.ofList [
              "airsightdistance", "1100.0"
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.016"
              "maxbank", "0.72"
              "maxelevator", "0.013"
              "maxpitch", "0.745"
              "maxrudder", "0.015"
              "nochasecategory", "NOTAIR"
              "speedtofront", "0.06475"
              "stealth", "false"
              "turnradius", "32.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06363"
              "wingdrag", "0.21"
          ] }

    let legmineb : UnitDef =
        { name = "legmineb"
          subfolder = "Legion/Air/T2 Air"
          metalCost = ValueOrExpr.Concrete 300.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 30550.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legmineb.s3o"
          buildPic = Some "LEGMINEB.DDS"
          script = Some "Units/legmineb.cob"
          corpse = None
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 210.0
              maxAcc = 0.06
              maxDec = 0.045
              turnRate = 600.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 150.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "cor_seaadvbomb"
                displayName = Some "LegionMineBomb"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 1600.0)
                reloadTime = Some (ValueOrExpr.Concrete 10.0)
                weaponVelocity = None
                areaOfEffect = Some 40.0
                accuracy = Some 500.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = None
                explosiongenerator = Some "custom:dirtpopup"
                rgbColor = Some "0.8 0.8 0.25"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "legmine1"
                    "spawns_surface", "LAND"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "bounceexplosiongenerator", "custom:dirt"
                    "bouncerebound", "0.15"
                    "bounceslip", "0.75"
                    "burst", "6.0"
                    "burstrate", "0.25"
                    "collidefriendly", "false"
                    "commandfire", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "metalpershot", "30.0"
                    "energypershot", "1620.0"
                    "gravityaffected", "true"
                    "intensity", "0.01"
                    "model", "leglmineproj.s3o"
                    "mygravity", "0.07"
                    "numbounce", "3.0"
                    "size", "8.0"
                    "soundhitdry", "xplodragconcrete"
                    "soundhitwet", "splsmed"
                    "sprayangle", "300.0"
                    "stockpile", "true"
                    "stockpiletime", "10.0"
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
              select = ["seapsel2"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Air/T2 Air"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "acceleration", "0.055"
              "blocking", "false"
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

    let legnap : UnitDef =
        { name = "legnap"
          subfolder = "Legion/Air/T2 Air"
          metalCost = ValueOrExpr.Concrete 420.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 41910.0
          health = ValueOrExpr.Concrete 2900.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGNAP.s3o"
          buildPic = Some "LEGNAP.DDS"
          script = Some "Units/CORHURC.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 215.0
              maxAcc = 0.0525
              maxDec = 0.045
              turnRate = 400.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 180.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "napalmbombs"
                displayName = Some "Heavy a2g napalm warheads"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 50.0
                    "subs", 20.0
                ]
                range = Some (ValueOrExpr.Concrete 1280.0)
                reloadTime = Some (ValueOrExpr.Concrete 10.0)
                weaponVelocity = None
                areaOfEffect = Some 300.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrelxl"
                soundHit = Some "bombsmed2"
                explosiongenerator = Some "custom:burnfire-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "area_onhit_ceg", "fire-area-150-repeat"
                    "area_onhit_damageCeg", "burnflamexl-gen"
                    "area_onhit_resistance", "fire"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "4.0"
                    "burstrate", "0.6"
                    "craterareaofeffect", "180.0"
                    "collidefriendly", "false"
                    "commandfire", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "legbomb.s3o"
                    "mygravity", "0.4"
                    "soundhitwet", "splslrg"
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "CorAircraft/T2"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "acceleration", "0.04"
              "airsightdistance", "800.0"
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.01273"
              "maxbank", "0.8"
              "maxelevator", "0.00898"
              "maxpitch", "0.625"
              "maxrudder", "0.00448"
              "noautofire", "true"
              "nochasecategory", "VTOL"
              "speedtofront", "0.063"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06148"
              "wingdrag", "0.125"
          ] }

    let legphoenix : UnitDef =
        { name = "legphoenix"
          subfolder = "Legion/Air/T2 Air"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 46600.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legphoenix.s3o"
          buildPic = Some "LEGPHOENIX.DDS"
          script = Some "Units/legphoenix.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 270.0
              maxAcc = 0.05
              maxDec = 0.025
              turnRate = 400.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
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
          weapons = Some [
              { name = "legphtarg"
                displayName = Some "Targetting System"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 0.0
                    "subs", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1280.0)
                reloadTime = Some (ValueOrExpr.Concrete 7.0)
                weaponVelocity = None
                areaOfEffect = Some 121.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some -0.99
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = None
                soundHit = None
                explosiongenerator = Some "custom:noexplosion"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "5.0"
                    "burstrate", "0.4"
                    "craterareaofeffect", "0.0"
                    "collidefriendly", "false"
                    "commandfire", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "empty.s3o"
                    "mygravity", "0.4"
                ] }
              { name = "skybeam"
                displayName = Some "Heavy a2g Phoenix Flame Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 125.0
                    "default", 145.0
                    "vtol", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 950.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 120.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some ""
                soundHit = None
                explosiongenerator = Some "custom:heatray-huge"
                rgbColor = Some "1 0.5 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "beamttl", "0.099"
                    "camerashake", "0.1"
                    "corethickness", "0.4"
                    "collidefriendly", "false"
                    "craterareaofeffect", "120.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "17.0"
                    "firestarter", "90.0"
                    "firetolerance", "300.0"
                    "laserflaresize", "6.0"
                    "predictboost", "1.0"
                    "proximitypriority", "-1.0"
                    "rgbcolor2", "0.9 1.0 0.5"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "0.0"
                    "soundtrigger", "0.0"
                    "thickness", "4.5"
                ] }
              { name = "legphsound"
                displayName = Some "PhoenixBlast"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = None
                reloadTime = None
                weaponVelocity = None
                areaOfEffect = Some 0.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = None
                impulseFactor = None
                noSelfDamage = Some true
                soundStart = None
                soundHit = None
                explosiongenerator = None
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "impactonly", "1.0"
                    "SoundHitDry", "heatray3lp"
                    "SoundHitDryVolume", "18.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1200.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 200.0
                object_ = Some "Units/legphoenix_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 600.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 110.0
                object_ = Some "Units/cor3X3A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
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
              "model_author", "Protar/Hornet"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legionaircraft/T2"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "true"
              "collide", "false"
              "maxaileron", "0.01273"
              "maxbank", "0.6"
              "maxelevator", "0.00898"
              "maxpitch", "0.625"
              "maxrudder", "0.01"
              "noautofire", "true"
              "nochasecategory", "VTOL"
              "speedtofront", "0.063"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06148"
              "wingdrag", "0.125"
          ] }

    let legstronghold : UnitDef =
        { name = "legstronghold"
          subfolder = "Legion/Air/T2 Air"
          metalCost = ValueOrExpr.Concrete 550.0
          energyCost = ValueOrExpr.Concrete 11000.0
          buildTime = ValueOrExpr.Concrete 24200.0
          health = ValueOrExpr.Concrete 2600.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legstronghold.s3o"
          buildPic = Some "legstronghold.DDS"
          script = Some "Units/legstronghold.cob"
          corpse = None
          explodeAs = Some "hugeExplosionGeneric"
          selfDestructAs = Some "hugeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "1 -3 0"
          collisionVolumeScales = Some "52 21 52"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 175.0
              maxAcc = 0.12
              maxDec = 0.6
              turnRate = 380.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 135.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "shotgun"
                displayName = Some "Medium Shotgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 30.0
                    "vtol", 12.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.6)
                weaponVelocity = Some 960.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "kroggie2xs"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "160.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "projectiles", "8.0"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.015"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "1.0"
                    "sprayangle", "1000.0"
                    "thickness", "0.75"
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
              "paralyzemultiplier", "0.025"
              "subfolder", "CorAircraft/T2"
              "techlevel", "2.0"
              "crashable", "0.0"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
              "releaseheld", "true"
              "transportcapacity", "1.0"
              "transportsize", "4.0"
              "transportunloadmethod", "0.0"
              "unloadspread", "0.0"
              "upright", "true"
          ] }

    let legvenator : UnitDef =
        { name = "legvenator"
          subfolder = "Legion/Air/T2 Air"
          metalCost = ValueOrExpr.Concrete 110.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 9730.0
          health = ValueOrExpr.Concrete 210.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legvenator.s3o"
          buildPic = Some "legvenator.DDS"
          script = Some "Units/legvenator.cob"
          corpse = None
          explodeAs = Some "smallExplosionGenericAir"
          selfDestructAs = Some "smallExplosionGenericAir"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 450.0
              maxAcc = 0.6
              maxDec = 0.0675
              turnRate = 700.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 160.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "birdshot"
                displayName = Some "Birdshot Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "commanders", 8.0
                    "default", 24.0
                    "vtol", 480.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 1600.0
                areaOfEffect = Some 100.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.2
                noSelfDamage = Some true
                soundStart = Some "flakfire"
                soundHit = Some "flakhit"
                explosiongenerator = Some "custom:genericshellexplosion-small"
                rgbColor = Some "1 0.75 0.25"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR"
                    "mount_onlytargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "25.0"
                    "mount_fastautoretargeting", "true"
                    "mount_weaponAimAdjustPriority", "20.0"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "collidefriendly", "false"
                    "intensity", "3.0"
                    "predictboost", "1.0"
                    "projectiles", "3.0"
                    "size", "2.0"
                    "soundhitwet", "splshsml"
                    "soundstartvolume", "6.0"
                    "sprayangle", "200.0"
                    "weapontimer", "1.0"
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
              "unitgroup", "aa"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Air/T2 Air"
              "techlevel", "2.0"
              "attacksafetydistance", "300.0"
              "fighter", "1.0"
          ]
          extras = Map.ofList [
              "airsightdistance", "1100.0"
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.01488"
              "maxbank", "0.7"
              "maxelevator", "0.01113"
              "maxpitch", "0.525"
              "maxrudder", "0.00463"
              "nochasecategory", "NOTAIR"
              "speedtofront", "0.06475"
              "stealth", "true"
              "turnradius", "90.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06363"
              "wingdrag", "0.21"
          ] }

    let legwhisper : UnitDef =
        { name = "legwhisper"
          subfolder = "Legion/Air/T2 Air"
          metalCost = ValueOrExpr.Concrete 210.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 16480.0
          health = ValueOrExpr.Concrete 990.0
          sightDistance = ValueOrExpr.Concrete 1250.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legwhisper.s3o"
          buildPic = Some "legwhisper.DDS"
          script = Some "Units/legwhisper.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 321.0
              maxAcc = 0.1575
              maxDec = 0.0375
              turnRate = 650.0
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
              select = ["caradsel"] })
          customParams = Map.ofList [
              "unitgroup", "util"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Air/T2 Air"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.01366"
              "maxbank", "0.8"
              "maxelevator", "0.00991"
              "maxpitch", "0.625"
              "maxrudder", "0.00541"
              "radardistance", "2400.0"
              "sonardistance", "1200.0"
              "speedtofront", "0.06417"
              "stealth", "true"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06241"
              "wingdrag", "0.11"
          ] }

    let all : (string * UnitDef) list =
        [
            "legafigdef", legafigdef
            "legatorpbomber", legatorpbomber
            "legfort", legfort
            "legheavydrone", legheavydrone
            "legheavydronesmall", legheavydronesmall
            "legionnaire", legionnaire
            "legmineb", legmineb
            "legnap", legnap
            "legphoenix", legphoenix
            "legstronghold", legstronghold
            "legvenator", legvenator
            "legwhisper", legwhisper
        ]
