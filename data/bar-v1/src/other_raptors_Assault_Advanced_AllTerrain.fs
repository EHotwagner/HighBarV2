// Auto-generated BAR unit data: other/raptors/Assault/Advanced/AllTerrain
namespace BarData.V1.Units

open BarData.V1

module other_raptors_Assault_Advanced_AllTerrain =

    let raptor_allterrain_assault_basic_t4_v1 : UnitDef =
        { name = "raptor_allterrain_assault_basic_t4_v1"
          subfolder = "other/raptors/Assault/Advanced/AllTerrain"
          metalCost = ValueOrExpr.Concrete 302.0
          energyCost = ValueOrExpr.Concrete 3520.0
          buildTime = ValueOrExpr.Concrete 30000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorapexallterrainassault.s3o"
          buildPic = Some "raptors/raptorapexallterrainassault.DDS"
          script = Some "Raptors/raptorapexallterraina.cob"
          corpse = None
          explodeAs = Some "BIGBUG_DEATH"
          selfDestructAs = Some "BIGBUG_DEATH"
          collisionVolumeOffsets = Some "0 10 2"
          collisionVolumeScales = Some "37 55 90"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.414
              maxDec = 0.46
              turnRate = 920.0
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
              waterline = Some 34.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 550.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
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
                    "vtol", 1000.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
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
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "200000.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "7.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "38.0"
              "unitname", "raptor_allterrain_assault_basic_t4_v1"
              "upright", "false"
          ] }

    let raptor_allterrain_assault_basic_t4_v2 : UnitDef =
        { name = "raptor_allterrain_assault_basic_t4_v2"
          subfolder = "other/raptors/Assault/Advanced/AllTerrain"
          metalCost = ValueOrExpr.Concrete 302.0
          energyCost = ValueOrExpr.Concrete 3520.0
          buildTime = ValueOrExpr.Concrete 30000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorapexallterrainassaultb.s3o"
          buildPic = Some "raptors/raptorapexallterrainassaultb.DDS"
          script = Some "Raptors/raptorapexallterraina.cob"
          corpse = None
          explodeAs = Some "BIGBUG_DEATH"
          selfDestructAs = Some "BIGBUG_DEATH"
          collisionVolumeOffsets = Some "0 10 2"
          collisionVolumeScales = Some "37 55 90"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.414
              maxDec = 0.46
              turnRate = 920.0
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
              waterline = Some 34.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Claws"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
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
                    "vtol", 1000.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
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
              "autoheal", "40.0"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "200000.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "7.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "38.0"
              "unitname", "raptor_allterrain_assault_basic_t4_v2"
              "upright", "false"
          ] }

    let all : (string * UnitDef) list =
        [
            "raptor_allterrain_assault_basic_t4_v1", raptor_allterrain_assault_basic_t4_v1
            "raptor_allterrain_assault_basic_t4_v2", raptor_allterrain_assault_basic_t4_v2
        ]
