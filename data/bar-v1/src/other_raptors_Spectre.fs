// Auto-generated BAR unit data: other/raptors/Spectre
namespace BarData.V1.Units

open BarData.V1

module other_raptors_Spectre =

    let raptor_land_assault_spectre_t2_v1 : UnitDef =
        { name = "raptor_land_assault_spectre_t2_v1"
          subfolder = "other/raptors/Spectre"
          metalCost = ValueOrExpr.Concrete 152.0
          energyCost = ValueOrExpr.Concrete 3520.0
          buildTime = ValueOrExpr.Concrete 9000.0
          health = ValueOrExpr.Concrete 2500.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptora_spectre.s3o"
          buildPic = Some "raptors/raptora1_spectre.DDS"
          script = Some "Raptors/raptora1.cob"
          corpse = None
          explodeAs = Some "BIGBUG_DEATH"
          selfDestructAs = Some "BIGBUG_DEATH"
          collisionVolumeOffsets = Some "0 -10 0"
          collisionVolumeScales = Some "27 48 60"
          collisionVolumeType = Some "box"
          seismicSignature = Some 3.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 39.0
              maxAcc = 0.414
              maxDec = 0.46
              turnRate = 920.0
              movementClass = Some "RAPTORBIGHOVER"
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
              waterline = Some 24.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 200.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 42.0
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
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "125.0"
                    "mount_onlytargetcategory", "NOTAIR"
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
                ] }
              { name = "aaweapon"
                displayName = Some "Deadly Defensive Spores"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "vtol", 2000.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 20.0)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 256.0
                accuracy = None
                turret = Some true
                tolerance = Some 60000.0
                edgeEffectiveness = Some 0.35
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "spore_xl"
                soundHit = Some "spore_explo"
                explosiongenerator = Some "custom:genericshellexplosion-huge-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cameraShake", "700.0"
                    "dance", "20.0"
                    "firestarter", "0.0"
                    "flighttime", "5.0"
                    "firesubmersed", "true"
                    "interceptedbyshieldtype", "4.0"
                    "metalpershot", "0.0"
                    "model", "SimpleFlareXL.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "2.0"
                    "smoketime", "45.0"
                    "smokesize", "10.5"
                    "smokecolor", "1.0"
                    "soundstartvolume", "9.0"
                    "startvelocity", "1000.0"
                    "texture1", "orangenovaexplo"
                    "texture2", "sporetrail_xl"
                    "tracks", "true"
                    "trajectoryheight", "2.0"
                    "turnrate", "60000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "40.0"
                    "wobble", "32000.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "maxrange", "200"
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "airsightdistance", "650.0"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "cancloak", "true"
              "cloakcost", "0.0"
              "cloakcostmoving", "0.0"
              "defaultmissiontype", "Standby"
              "initcloak", "true"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "100000.0"
              "mincloakdistance", "50.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "stealth", "1.0"
              "trackoffset", "7.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "34.0"
              "unitname", "raptor_land_assault_spectre_t2_v1"
              "upright", "false"
          ] }

    let raptor_land_assault_spectre_t4_v1 : UnitDef =
        { name = "raptor_land_assault_spectre_t4_v1"
          subfolder = "other/raptors/Spectre"
          metalCost = ValueOrExpr.Concrete 302.0
          energyCost = ValueOrExpr.Concrete 3520.0
          buildTime = ValueOrExpr.Concrete 30000.0
          health = ValueOrExpr.Concrete 10000.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptora2_spectre.s3o"
          buildPic = Some "raptors/raptora2_spectre.DDS"
          script = Some "Raptors/raptora2.cob"
          corpse = None
          explodeAs = Some "MEGABUG_DEATH"
          selfDestructAs = Some "MEGABUG_DEATH"
          collisionVolumeOffsets = Some "0 0 2"
          collisionVolumeScales = Some "37 75 130"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.414
              maxDec = 0.46
              turnRate = 920.0
              movementClass = Some "RAPTORBIG2HOVER"
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
              waterline = Some 40.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 550.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.6)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 42.0
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
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "125.0"
                    "mount_onlytargetcategory", "NOTAIR"
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
                ] }
              { name = "aaweapon"
                displayName = Some "Deadly Defensive Spores"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "vtol", 2000.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 256.0
                accuracy = None
                turret = Some true
                tolerance = Some 60000.0
                edgeEffectiveness = Some 0.35
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "spore_xl"
                soundHit = Some "spore_explo"
                explosiongenerator = Some "custom:genericshellexplosion-huge-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cameraShake", "700.0"
                    "dance", "20.0"
                    "firestarter", "0.0"
                    "flighttime", "5.0"
                    "firesubmersed", "true"
                    "interceptedbyshieldtype", "4.0"
                    "metalpershot", "0.0"
                    "model", "SimpleFlareXL.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "2.0"
                    "smoketime", "45.0"
                    "smokesize", "10.5"
                    "smokecolor", "1.0"
                    "soundstartvolume", "9.0"
                    "startvelocity", "1000.0"
                    "texture1", "orangenovaexplo"
                    "texture2", "sporetrail_xl"
                    "tracks", "true"
                    "trajectoryheight", "2.0"
                    "turnrate", "60000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "40.0"
                    "wobble", "32000.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "maxrange", "200"
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "airsightdistance", "1800.0"
              "autoheal", "25.0"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "cancloak", "true"
              "cloakcost", "0.0"
              "cloakcostmoving", "0.0"
              "defaultmissiontype", "Standby"
              "initcloak", "true"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "200000.0"
              "mincloakdistance", "50.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "stealth", "1.0"
              "trackoffset", "7.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "38.0"
              "unitname", "raptor_land_assault_spectre_t4_v1"
              "upright", "false"
          ] }

    let raptor_land_spiker_spectre_t4_v1 : UnitDef =
        { name = "raptor_land_spiker_spectre_t4_v1"
          subfolder = "other/raptors/Spectre"
          metalCost = ValueOrExpr.Concrete 174.0
          energyCost = ValueOrExpr.Concrete 174.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 1250.0
          sightDistance = ValueOrExpr.Concrete 950.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptors2_spectre.s3o"
          buildPic = Some "raptors/raptors2_spectre.DDS"
          script = Some "Raptors/raptors2.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH"
          selfDestructAs = Some "BUG_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "24 34 53"
          collisionVolumeType = Some "box"
          seismicSignature = Some 2.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 270.0
              maxAcc = 3.45
              maxDec = 3.45
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
                displayName = Some "Spike"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 600.0
                ]
                range = Some (ValueOrExpr.Concrete 950.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "smallraptorattack"
                soundHit = None
                explosiongenerator = Some "custom:raptorspike-huge-sparks-burn"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "cegtag", "sporetrail-large"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burnblow", "true"
                    "collidefeature", "true"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "true"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/spike.s3o"
                    "startvelocity", "600.0"
                    "texture1", ""
                    "texture2", "sporetrail"
                    "waterweapon", "false"
                    "weapontimer", "1.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "maxrange", "375"
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "cancloak", "true"
              "cloakcost", "0.0"
              "cloakcostmoving", "0.0"
              "defaultmissiontype", "Standby"
              "initcloaked", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "750"
              "mass", "300.0"
              "mincloakdistance", "50.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "sonardistance", "720.0"
              "stealth", "1.0"
              "trackoffset", "6.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "30.0"
              "unitname", "raptor_land_spiker_spectre_t4_v1"
              "upright", "false"
          ] }

    let raptor_land_swarmer_spectre_t3_v1 : UnitDef =
        { name = "raptor_land_swarmer_spectre_t3_v1"
          subfolder = "other/raptors/Spectre"
          metalCost = ValueOrExpr.Concrete 79.0
          energyCost = ValueOrExpr.Concrete 79.0
          buildTime = ValueOrExpr.Concrete 1500.0
          health = ValueOrExpr.Concrete 500.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptor1x_spectre.s3o"
          buildPic = Some "raptors/raptor1x_spectre.DDS"
          script = Some "Raptors/raptor1x.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH"
          selfDestructAs = Some "BUG_DEATH"
          collisionVolumeOffsets = Some "0 -3 -3"
          collisionVolumeScales = Some "18 40 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 2.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 150.0
              maxAcc = 0.345
              maxDec = 0.345
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
              waterline = Some 19.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 120.0
                ]
                range = Some (ValueOrExpr.Concrete 200.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.8)
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
                    "mount_onlytargetcategory", "NOTAIR"
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
              "autoheal", "3.0"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "cancloak", "true"
              "cloakcost", "0.0"
              "cloakcostmoving", "0.0"
              "defaultmissiontype", "Standby"
              "initcloak", "true"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "90.0"
              "mincloakdistance", "50.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "stealth", "1.0"
              "trackoffset", "0.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "18.0"
              "unitname", "raptor_land_swarmer_spectre_t3_v1"
              "upright", "false"
          ] }

    let raptor_land_swarmer_spectre_t4_v1 : UnitDef =
        { name = "raptor_land_swarmer_spectre_t4_v1"
          subfolder = "other/raptors/Spectre"
          metalCost = ValueOrExpr.Concrete 100.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 7500.0
          health = ValueOrExpr.Concrete 1300.0
          sightDistance = ValueOrExpr.Concrete 200.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor2_spectre.s3o"
          buildPic = Some "raptors/raptor2_spectre.DDS"
          script = Some "Raptors/raptor2.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH"
          selfDestructAs = Some "BUG_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "20 40 44"
          collisionVolumeType = Some "box"
          seismicSignature = Some 2.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 180.0
              maxAcc = 0.4025
              maxDec = 0.345
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
              waterline = Some 22.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 300.0
                ]
                range = Some (ValueOrExpr.Concrete 200.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.4)
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
                    "mount_onlytargetcategory", "NOTAIR"
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
              "normaltex", "unittextures/chicken_m_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "cancloak", "true"
              "cloakcost", "0.0"
              "cloakcostmoving", "0.0"
              "defaultmissiontype", "Standby"
              "initcloak", "true"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "200.0"
              "mincloakdistance", "50.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "stealth", "1.0"
              "trackoffset", "0.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "18.0"
              "unitname", "raptor_land_swarmer_spectre_t4_v1"
              "upright", "false"
          ] }

    let all : (string * UnitDef) list =
        [
            "raptor_land_assault_spectre_t2_v1", raptor_land_assault_spectre_t2_v1
            "raptor_land_assault_spectre_t4_v1", raptor_land_assault_spectre_t4_v1
            "raptor_land_spiker_spectre_t4_v1", raptor_land_spiker_spectre_t4_v1
            "raptor_land_swarmer_spectre_t3_v1", raptor_land_swarmer_spectre_t3_v1
            "raptor_land_swarmer_spectre_t4_v1", raptor_land_swarmer_spectre_t4_v1
        ]
