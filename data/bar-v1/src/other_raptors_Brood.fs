// Auto-generated BAR unit data: other/raptors/Brood
namespace BarData.V1.Units

open BarData.V1

module other_raptors_Brood =

    let raptor_air_bomber_brood_t4_v2 : UnitDef =
        { name = "raptor_air_bomber_brood_t4_v2"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorbroodbomber.s3o"
          buildPic = Some "raptors/raptorbroodbomber.DDS"
          script = Some "Raptors/raptorf1.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "70 70 70"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 240.0
              maxAcc = 0.25
              maxDec = 0.1
              turnRate = 1600.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = true
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "bloodyeggs"
                displayName = Some "GooBombs"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = None
                areaOfEffect = Some 128.0
                accuracy = Some 500000.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "smallraptorattack"
                explosiongenerator = Some "custom:dirt"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "raptor_land_swarmer_brood_t4_v1"
                    "spawns_surface", "LAND SEA"
                ]
                extras = Map.ofList [
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "1.0"
                    "burstrate", "0.033"
                    "canattackground", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/s_raptorboss_white.s3o"
                    "mygravity", "0.5"
                    "sprayangle", "1000000.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "acceleration", "0.8"
              "airhoverfactor", "0.0"
              "attackrunlength", "32.0"
              "canattack", "true"
              "canguard", "true"
              "canland", "true"
              "canloopbackattack", "true"
              "canpatrol", "true"
              "canstop", "1"
              "cansubmerge", "true"
              "capturable", "false"
              "collide", "true"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "maneuverleashlength", "20000"
              "mass", "227.5"
              "maxaileron", "0.025"
              "maxbank", "0.8"
              "maxelevator", "0.025"
              "maxpitch", "0.75"
              "maxrudder", "0.025"
              "moverate1", "32"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptorbroodbomber"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
          ] }

    let raptor_air_bomber_brood_t4_v3 : UnitDef =
        { name = "raptor_air_bomber_brood_t4_v3"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorbroodbomber.s3o"
          buildPic = Some "raptors/raptorbroodbomber.DDS"
          script = Some "Raptors/raptorf1.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "70 70 70"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 240.0
              maxAcc = 0.25
              maxDec = 0.1
              turnRate = 1600.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = true
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "bloodyeggs"
                displayName = Some "GooBombs"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = None
                areaOfEffect = Some 128.0
                accuracy = Some 500000.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "smallraptorattack"
                explosiongenerator = Some "custom:dirt"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "raptor_land_swarmer_brood_t3_v1"
                    "spawns_surface", "LAND SEA"
                ]
                extras = Map.ofList [
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "2.0"
                    "burstrate", "0.5"
                    "canattackground", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/s_raptorboss2_white.s3o"
                    "mygravity", "0.5"
                    "sprayangle", "1000000.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "acceleration", "0.8"
              "airhoverfactor", "0.0"
              "attackrunlength", "32.0"
              "canattack", "true"
              "canguard", "true"
              "canland", "true"
              "canloopbackattack", "true"
              "canpatrol", "true"
              "canstop", "1"
              "cansubmerge", "true"
              "capturable", "false"
              "collide", "true"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "maneuverleashlength", "20000"
              "mass", "227.5"
              "maxaileron", "0.025"
              "maxbank", "0.8"
              "maxelevator", "0.025"
              "maxpitch", "0.75"
              "maxrudder", "0.025"
              "moverate1", "32"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptorbroodbomber"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
          ] }

    let raptor_air_bomber_brood_t4_v4 : UnitDef =
        { name = "raptor_air_bomber_brood_t4_v4"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorbroodbomber.s3o"
          buildPic = Some "raptors/raptorbroodbomber.DDS"
          script = Some "Raptors/raptorf1.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "70 70 70"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 240.0
              maxAcc = 0.25
              maxDec = 0.1
              turnRate = 1600.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = true
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "bloodyeggs"
                displayName = Some "GooBombs"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = None
                areaOfEffect = Some 128.0
                accuracy = Some 500000.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "smallraptorattack"
                explosiongenerator = Some "custom:dirt"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "raptor_land_swarmer_brood_t2_v1"
                    "spawns_surface", "LAND SEA"
                ]
                extras = Map.ofList [
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "8.0"
                    "burstrate", "0.033"
                    "canattackground", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/s_raptor_white.s3o"
                    "mygravity", "0.5"
                    "sprayangle", "1000000.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "acceleration", "0.8"
              "airhoverfactor", "0.0"
              "attackrunlength", "32.0"
              "canattack", "true"
              "canguard", "true"
              "canland", "true"
              "canloopbackattack", "true"
              "canpatrol", "true"
              "canstop", "1"
              "cansubmerge", "true"
              "capturable", "false"
              "collide", "true"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "maneuverleashlength", "20000"
              "mass", "227.5"
              "maxaileron", "0.025"
              "maxbank", "0.8"
              "maxelevator", "0.025"
              "maxpitch", "0.75"
              "maxrudder", "0.025"
              "moverate1", "32"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptorbroodbomber"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
          ] }

    let raptor_allterrain_arty_brood_t2_v1 : UnitDef =
        { name = "raptor_allterrain_arty_brood_t2_v1"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 396.0
          energyCost = ValueOrExpr.Concrete 12320.0
          buildTime = ValueOrExpr.Concrete 6750.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptor_artillery_brood_small.s3o"
          buildPic = Some "raptors/raptorbroodarty.DDS"
          script = Some "Raptors/raptor_artillery_v2.cob"
          corpse = None
          explodeAs = Some "BIGBUG_DEATH"
          selfDestructAs = Some "BIGBUG_DEATH"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "25 34 44"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 42.0
              maxAcc = 0.115
              maxDec = 0.414
              turnRate = 1840.0
              movementClass = Some "RAPTORALLTERRAINBIGHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 10.0 })
          builder = None
          weapons = Some [
              { name = "bloodyeggs"
                displayName = Some "GOOLAUNCHER"
                weaponType = None
                damage = Map.ofList [
                    "default", 1.0
                    "shields", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 10.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 128.0
                accuracy = Some 512.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "bugarty"
                soundHit = Some "smallraptorattack"
                explosiongenerator = Some "custom:dirt"
                rgbColor = Some "0.5 0 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "raptor_land_swarmer_brood_t2_v1"
                    "spawns_surface", "LAND SEA"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "50.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "1.0"
                    "burstrate", "0.01"
                    "canattackground", "false"
                    "cegtag", "arty-heavy-purple"
                    "craterareaofeffect", "128.0"
                    "craterboost", "0.2"
                    "cratermult", "0.2"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/s_raptor_white.s3o"
                    "proximitypriority", "-1.0"
                    "size", "5.5"
                    "sizedecay", "0.09"
                    "sprayangle", "512.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "4000.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "6.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "30.0"
              "unitname", "raptor_allterrain_arty_brood_t2_v1"
              "upright", "false"
          ] }

    let raptor_allterrain_arty_brood_t4_v1 : UnitDef =
        { name = "raptor_allterrain_arty_brood_t4_v1"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 396.0
          energyCost = ValueOrExpr.Concrete 12320.0
          buildTime = ValueOrExpr.Concrete 270000.0
          health = ValueOrExpr.Concrete 8000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Raptors/raptor_artillery_brood_big.s3o"
          buildPic = Some "raptors/raptorbroodarty.DDS"
          script = Some "Raptors/raptor_artillery_v2.cob"
          corpse = None
          explodeAs = Some "LOBBER_MORPH"
          selfDestructAs = Some "LOBBER_MORPH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "120 80 120"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 84.0
              maxAcc = 1.15
              maxDec = 9.2
              turnRate = 600.0
              movementClass = Some "RAPTORALLTERRAINBIG2HOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 10.0 })
          builder = None
          weapons = Some [
              { name = "bloodyeggs"
                displayName = Some "GOOLAUNCHER"
                weaponType = None
                damage = Map.ofList [
                    "default", 1.0
                    "shields", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 2000.0)
                reloadTime = Some (ValueOrExpr.Concrete 10.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 128.0
                accuracy = Some 1024.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "bugarty"
                soundHit = Some "smallraptorattack"
                explosiongenerator = Some "custom:dirt"
                rgbColor = Some "0.5 0 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spawns_name", "raptor_land_swarmer_brood_t2_v1"
                    "spawns_surface", "LAND SEA"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "50.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "4.0"
                    "burstrate", "0.001"
                    "canattackground", "false"
                    "cegtag", "arty-heavy-purple"
                    "craterareaofeffect", "128.0"
                    "craterboost", "0.2"
                    "cratermult", "0.2"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/s_raptor_white.s3o"
                    "proximitypriority", "-1.0"
                    "size", "5.5"
                    "sizedecay", "0.09"
                    "sprayangle", "1024.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "collisionvolumetest", "1.0"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "40000.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "6.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "100.0"
              "unitname", "raptor_allterrain_arty_brood_t4_v1"
              "upright", "false"
          ] }

    let raptor_land_swarmer_brood_t2_v1 : UnitDef =
        { name = "raptor_land_swarmer_brood_t2_v1"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 20.0
          energyCost = ValueOrExpr.Concrete 250.0
          buildTime = ValueOrExpr.Concrete 2250.0
          health = ValueOrExpr.Concrete 540.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/s_raptor_white.s3o"
          buildPic = Some "raptors/raptorh4.DDS"
          script = Some "Raptors/raptorh4.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH"
          selfDestructAs = Some "BUG_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "13 20 22"
          collisionVolumeType = Some "box"
          seismicSignature = None
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 245.999
              maxAcc = 0.644
              maxDec = 0.23
              turnRate = 1840.0
              movementClass = Some "RAPTORSMALLHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 15.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 200.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 24.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "smallraptorattack"
                soundHit = None
                explosiongenerator = Some "custom:raptorspike-small-sparks-burn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "true"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/spike.s3o"
                    "waterweapon", "true"
                    "weapontimer", "0.1"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "collide", "0.0"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "100.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "0.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "18.0"
              "unitname", "raptor_land_swarmer_brood_t2_v1"
              "upright", "false"
          ] }

    let raptor_land_swarmer_brood_t3_v1 : UnitDef =
        { name = "raptor_land_swarmer_brood_t3_v1"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 123.0
          energyCost = ValueOrExpr.Concrete 2326.0
          buildTime = ValueOrExpr.Concrete 4500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/s_raptorboss2_white.s3o"
          buildPic = Some "raptors/raptorh3.DDS"
          script = Some "Raptors/raptorh3.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH"
          selfDestructAs = Some "BUG_DEATH"
          collisionVolumeOffsets = Some "0 2 0"
          collisionVolumeScales = Some "30 38 60"
          collisionVolumeType = Some "box"
          seismicSignature = None
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 135.0
              maxAcc = 0.414
              maxDec = 0.23
              turnRate = 1840.0
              movementClass = Some "RAPTORSMALLHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 29.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 24.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "smallraptorattack"
                soundHit = None
                explosiongenerator = Some "custom:raptorspike-medium-sparks-burn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "true"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/spike.s3o"
                    "waterweapon", "true"
                    "weapontimer", "0.1"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "700.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "4.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "22.0"
              "unitname", "raptor_land_swarmer_brood_t3_v1"
              "upright", "false"
          ] }

    let raptor_land_swarmer_brood_t4_v1 : UnitDef =
        { name = "raptor_land_swarmer_brood_t4_v1"
          subfolder = "other/raptors/Brood"
          metalCost = ValueOrExpr.Concrete 251.0
          energyCost = ValueOrExpr.Concrete 5201.0
          buildTime = ValueOrExpr.Concrete 9000.0
          health = ValueOrExpr.Concrete 6700.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/s_raptorboss_white.s3o"
          buildPic = Some "raptors/raptorh2.DDS"
          script = Some "Raptors/raptorh2.cob"
          corpse = None
          explodeAs = Some "BIGBUG_DEATH"
          selfDestructAs = Some "BUG_DEATH"
          collisionVolumeOffsets = Some "0 0 2"
          collisionVolumeScales = Some "37 70 90"
          collisionVolumeType = Some "box"
          seismicSignature = None
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 90.0
              maxAcc = 0.644
              maxDec = 0.23
              turnRate = 920.0
              movementClass = Some "RAPTORSMALLHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 42.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 400.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 24.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "smallraptorattack"
                soundHit = None
                explosiongenerator = Some "custom:raptorspike-large-sparks-burn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "true"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/spike.s3o"
                    "waterweapon", "true"
                    "weapontimer", "0.1"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "1500.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "7.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "30.0"
              "unitname", "raptor_land_swarmer_brood_t4_v1"
              "upright", "false"
          ] }

    let all : (string * UnitDef) list =
        [
            "raptor_air_bomber_brood_t4_v2", raptor_air_bomber_brood_t4_v2
            "raptor_air_bomber_brood_t4_v3", raptor_air_bomber_brood_t4_v3
            "raptor_air_bomber_brood_t4_v4", raptor_air_bomber_brood_t4_v4
            "raptor_allterrain_arty_brood_t2_v1", raptor_allterrain_arty_brood_t2_v1
            "raptor_allterrain_arty_brood_t4_v1", raptor_allterrain_arty_brood_t4_v1
            "raptor_land_swarmer_brood_t2_v1", raptor_land_swarmer_brood_t2_v1
            "raptor_land_swarmer_brood_t3_v1", raptor_land_swarmer_brood_t3_v1
            "raptor_land_swarmer_brood_t4_v1", raptor_land_swarmer_brood_t4_v1
        ]
