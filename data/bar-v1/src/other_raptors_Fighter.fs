// Auto-generated BAR unit data: other/raptors/Fighter
namespace BarData.V1.Units

open BarData.V1

module other_raptors_Fighter =

    let raptor_air_fighter_basic_t1_v1 : UnitDef =
        { name = "raptor_air_fighter_basic_t1_v1"
          subfolder = "other/raptors/Fighter"
          metalCost = ValueOrExpr.Concrete 72.0
          energyCost = ValueOrExpr.Concrete 2200.0
          buildTime = ValueOrExpr.Concrete 1950.0
          health = ValueOrExpr.Concrete 85.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptorw1_mini.s3o"
          buildPic = Some "raptors/raptorw1_mini.DDS"
          script = Some "Raptors/raptorw1.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "58 58 58"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 360.0
              maxAcc = 0.25
              maxDec = 0.2
              turnRate = 1600.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = true
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Deadly Defensive Spores"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "vtol", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
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
                    "mount_badtargetcategory", "WEAPON"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cameraShake", "700.0"
                    "dance", "20.0"
                    "firestarter", "0.0"
                    "flighttime", "4.0"
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
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "acceleration", "2.0"
              "airsightdistance", "600.0"
              "amphibious", "true"
              "bankscale", "1"
              "cancrash", "false"
              "canguard", "true"
              "canland", "true"
              "canloopbackattack", "true"
              "canpatrol", "true"
              "canstop", "true"
              "cansubmerge", "false"
              "capturable", "false"
              "collide", "false"
              "defaultmissiontype", "VTOL_standby"
              "hidedamage", "1.0"
              "maneuverleashlength", "1280"
              "mass", "90.0"
              "maxaileron", "0.025"
              "maxbank", "0.8"
              "maxelevator", "0.025"
              "maxpitch", "0.75"
              "maxrudder", "0.025"
              "moverate1", "32"
              "noautofire", "false"
              "nochasecategory", "NOTAIR"
              "separation", "0.2"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptor_air_fighter_basic_t1_v1"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.435"
          ] }

    let raptor_air_fighter_basic_t2_v1 : UnitDef =
        { name = "raptor_air_fighter_basic_t2_v1"
          subfolder = "other/raptors/Fighter"
          metalCost = ValueOrExpr.Concrete 72.0
          energyCost = ValueOrExpr.Concrete 2200.0
          buildTime = ValueOrExpr.Concrete 1950.0
          health = ValueOrExpr.Concrete 350.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptor_pidgeon.s3o"
          buildPic = Some "raptors/raptorw1.DDS"
          script = Some "Raptors/raptorw1.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "58 58 58"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 360.0
              maxAcc = 0.25
              maxDec = 0.2
              turnRate = 1600.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = true
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Deadly Defensive Spores"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "vtol", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
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
                    "mount_badtargetcategory", "WEAPON"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cameraShake", "700.0"
                    "dance", "20.0"
                    "firestarter", "0.0"
                    "flighttime", "6.0"
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
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "acceleration", "2.0"
              "airsightdistance", "600.0"
              "amphibious", "true"
              "bankscale", "1"
              "cancrash", "false"
              "canguard", "true"
              "canland", "true"
              "canloopbackattack", "true"
              "canpatrol", "true"
              "canstop", "true"
              "cansubmerge", "false"
              "capturable", "false"
              "collide", "false"
              "defaultmissiontype", "VTOL_standby"
              "hidedamage", "1.0"
              "maneuverleashlength", "1280"
              "mass", "90.0"
              "maxaileron", "0.025"
              "maxbank", "0.8"
              "maxelevator", "0.025"
              "maxpitch", "0.75"
              "maxrudder", "0.025"
              "moverate1", "32"
              "noautofire", "false"
              "nochasecategory", "NOTAIR"
              "separation", "0.2"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptor_air_fighter_basic_t2_v1"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.435"
          ] }

    let raptor_air_fighter_basic_t2_v2 : UnitDef =
        { name = "raptor_air_fighter_basic_t2_v2"
          subfolder = "other/raptors/Fighter"
          metalCost = ValueOrExpr.Concrete 72.0
          energyCost = ValueOrExpr.Concrete 2200.0
          buildTime = ValueOrExpr.Concrete 2025.0
          health = ValueOrExpr.Concrete 350.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptor_pidgeonb.s3o"
          buildPic = Some "raptors/raptorw1b.DDS"
          script = Some "Raptors/raptorw1b.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "58 58 58"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 360.0
              maxAcc = 0.25
              maxDec = 0.2
              turnRate = 1600.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = true
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Deadly Defensive Spores"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "vtol", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
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
                    "mount_badtargetcategory", "WEAPON"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cameraShake", "700.0"
                    "dance", "20.0"
                    "firestarter", "0.0"
                    "flighttime", "6.0"
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
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "acceleration", "2.0"
              "airsightdistance", "600.0"
              "amphibious", "true"
              "bankscale", "1"
              "cancrash", "false"
              "canguard", "true"
              "canland", "true"
              "canloopbackattack", "true"
              "canpatrol", "true"
              "canstop", "true"
              "cansubmerge", "false"
              "capturable", "false"
              "collide", "false"
              "defaultmissiontype", "VTOL_standby"
              "hidedamage", "1.0"
              "maneuverleashlength", "1280"
              "mass", "90.0"
              "maxaileron", "0.025"
              "maxbank", "0.8"
              "maxelevator", "0.025"
              "maxpitch", "0.75"
              "maxrudder", "0.025"
              "moverate1", "32"
              "noautofire", "false"
              "nochasecategory", "NOTAIR"
              "separation", "0.2"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptor_air_fighter_basic_t2_v2"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.435"
          ] }

    let raptor_air_fighter_basic_t2_v3 : UnitDef =
        { name = "raptor_air_fighter_basic_t2_v3"
          subfolder = "other/raptors/Fighter"
          metalCost = ValueOrExpr.Concrete 72.0
          energyCost = ValueOrExpr.Concrete 2200.0
          buildTime = ValueOrExpr.Concrete 1875.0
          health = ValueOrExpr.Concrete 350.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptor_pidgeonc.s3o"
          buildPic = Some "raptors/raptorw1c.DDS"
          script = Some "Raptors/raptorw1c.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "58 58 58"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 360.0
              maxAcc = 0.25
              maxDec = 0.2
              turnRate = 1600.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = true
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Deadly Defensive Spores"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "vtol", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.75)
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
                    "mount_badtargetcategory", "WEAPON"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cameraShake", "700.0"
                    "dance", "20.0"
                    "firestarter", "0.0"
                    "flighttime", "6.0"
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
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "acceleration", "2.0"
              "airsightdistance", "600.0"
              "amphibious", "true"
              "bankscale", "1"
              "cancrash", "false"
              "canguard", "true"
              "canland", "true"
              "canloopbackattack", "true"
              "canpatrol", "true"
              "canstop", "true"
              "cansubmerge", "false"
              "capturable", "false"
              "collide", "false"
              "defaultmissiontype", "VTOL_standby"
              "hidedamage", "1.0"
              "maneuverleashlength", "1280"
              "mass", "90.0"
              "maxaileron", "0.025"
              "maxbank", "0.8"
              "maxelevator", "0.025"
              "maxpitch", "0.75"
              "maxrudder", "0.025"
              "moverate1", "32"
              "noautofire", "false"
              "nochasecategory", "NOTAIR"
              "separation", "0.2"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptor_air_fighter_basic_t2_v3"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.435"
          ] }

    let raptor_air_fighter_basic_t2_v4 : UnitDef =
        { name = "raptor_air_fighter_basic_t2_v4"
          subfolder = "other/raptors/Fighter"
          metalCost = ValueOrExpr.Concrete 72.0
          energyCost = ValueOrExpr.Concrete 2200.0
          buildTime = ValueOrExpr.Concrete 1650.0
          health = ValueOrExpr.Concrete 350.0
          sightDistance = ValueOrExpr.Concrete 400.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptor_pidgeond.s3o"
          buildPic = Some "raptors/raptorw1d.DDS"
          script = Some "Raptors/raptorw1d.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "22 22 22"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 360.0
              maxAcc = 0.25
              maxDec = 0.2
              turnRate = 1600.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = true
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Deadly Defensive Spores"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "vtol", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
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
                    "mount_badtargetcategory", "WEAPON"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cameraShake", "700.0"
                    "dance", "20.0"
                    "firestarter", "0.0"
                    "flighttime", "6.0"
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
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "acceleration", "2.0"
              "airsightdistance", "600.0"
              "amphibious", "true"
              "bankscale", "1"
              "cancrash", "false"
              "canguard", "true"
              "canland", "true"
              "canloopbackattack", "true"
              "canpatrol", "true"
              "canstop", "true"
              "cansubmerge", "false"
              "capturable", "false"
              "collide", "false"
              "defaultmissiontype", "VTOL_standby"
              "hidedamage", "1.0"
              "maneuverleashlength", "1280"
              "mass", "90.0"
              "maxaileron", "0.025"
              "maxbank", "0.8"
              "maxelevator", "0.025"
              "maxpitch", "0.75"
              "maxrudder", "0.025"
              "moverate1", "32"
              "noautofire", "false"
              "nochasecategory", "NOTAIR"
              "separation", "0.2"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptor_air_fighter_basic_t2_v4"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.435"
          ] }

    let raptor_air_fighter_basic_t4_v1 : UnitDef =
        { name = "raptor_air_fighter_basic_t4_v1"
          subfolder = "other/raptors/Fighter"
          metalCost = ValueOrExpr.Concrete 72.0
          energyCost = ValueOrExpr.Concrete 2200.0
          buildTime = ValueOrExpr.Concrete 1950.0
          health = ValueOrExpr.Concrete 1000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptor_crow.s3o"
          buildPic = Some "raptors/raptorw2.DDS"
          script = Some "Raptors/raptorw2.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "58 58 58"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 450.0
              maxAcc = 0.25
              maxDec = 0.2
              turnRate = 1600.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = true
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Deadly Defensive Spores"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "vtol", 1250.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
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
                    "mount_badtargetcategory", "NOTAIR"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "90.0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cameraShake", "700.0"
                    "dance", "20.0"
                    "firestarter", "0.0"
                    "flighttime", "8.0"
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
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "acceleration", "2.0"
              "airsightdistance", "1500.0"
              "amphibious", "true"
              "autoheal", "10.0"
              "bankscale", "1"
              "cancrash", "false"
              "canguard", "true"
              "canland", "true"
              "canloopbackattack", "true"
              "canpatrol", "true"
              "canstop", "true"
              "cansubmerge", "false"
              "capturable", "false"
              "collide", "false"
              "defaultmissiontype", "VTOL_standby"
              "hidedamage", "1.0"
              "maneuverleashlength", "1280"
              "mass", "200.0"
              "maxaileron", "0.025"
              "maxbank", "0.8"
              "maxelevator", "0.025"
              "maxpitch", "0.75"
              "maxrudder", "0.025"
              "moverate1", "32"
              "noautofire", "false"
              "nochasecategory", "NOTAIR"
              "separation", "0.2"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptor_air_fighter_basic_t4_v1"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.435"
          ] }

    let all : (string * UnitDef) list =
        [
            "raptor_air_fighter_basic_t1_v1", raptor_air_fighter_basic_t1_v1
            "raptor_air_fighter_basic_t2_v1", raptor_air_fighter_basic_t2_v1
            "raptor_air_fighter_basic_t2_v2", raptor_air_fighter_basic_t2_v2
            "raptor_air_fighter_basic_t2_v3", raptor_air_fighter_basic_t2_v3
            "raptor_air_fighter_basic_t2_v4", raptor_air_fighter_basic_t2_v4
            "raptor_air_fighter_basic_t4_v1", raptor_air_fighter_basic_t4_v1
        ]
