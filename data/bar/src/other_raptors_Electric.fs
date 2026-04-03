// Auto-generated BAR unit data: other/raptors/Electric
namespace BarData.Units

open BarData

module other_raptors_Electric =

    let raptor_air_bomber_emp_t2_v1 : UnitDef =
        { name = "raptor_air_bomber_emp_t2_v1"
          subfolder = "other/raptors/Electric"
          metalCost = ValueOrExpr.Concrete 50.0
          energyCost = ValueOrExpr.Concrete 50.0
          buildTime = ValueOrExpr.Concrete 6000.0
          health = ValueOrExpr.Concrete 835.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorebomber1.s3o"
          buildPic = Some "raptors/raptorebomber1.DDS"
          script = Some "Raptors/raptorf2.cob"
          corpse = None
          explodeAs = Some "raptor_empdeath_small"
          selfDestructAs = Some "raptor_empdeath_small"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "75 75 75"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 210.0
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
              { name = "weapon"
                displayName = Some "GooBombs"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 40000.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
                weaponVelocity = None
                areaOfEffect = Some 240.0
                accuracy = Some 10000.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "empbomb"
                explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "4.0"
                    "burstrate", "0.28"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/raptoregg_l_blue.s3o"
                    "mygravity", "0.5"
                    "paralyzer", "true"
                    "paralyzetime", "20.0"
                    "sprayangle", "20000.0"
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
              "paralyzemultiplier", "0.0"
          ]
          extras = Map.ofList [
              "acceleration", "1.0"
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
              "radardistance", "500.0"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptor_air_bomber_emp_t2_v1"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
          ] }

    let raptor_allterrain_arty_emp_t2_v1 : UnitDef =
        { name = "raptor_allterrain_arty_emp_t2_v1"
          subfolder = "other/raptors/Electric"
          metalCost = ValueOrExpr.Concrete 396.0
          energyCost = ValueOrExpr.Concrete 12320.0
          buildTime = ValueOrExpr.Concrete 6750.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptor_artillery_electric_v2.s3o"
          buildPic = Some "raptors/raptorearty1.DDS"
          script = Some "Raptors/raptor_artillery_v2.cob"
          corpse = None
          explodeAs = Some "raptor_empdeath_small"
          selfDestructAs = Some "raptor_empdeath_small"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "50 35 50"
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
              { name = "goolauncher"
                displayName = Some "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 3600.0
                    "shields", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 20.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 220.0
                accuracy = Some 1024.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "bugarty"
                soundHit = Some "empbomb"
                explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                rgbColor = Some "0.2 0.5 0.9"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "50.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "2.0"
                    "burstrate", "0.001"
                    "cegtag", "blob_trail_blue"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "true"
                    "gravityaffected", "true"
                    "intensity", "0.8"
                    "interceptedbyshieldtype", "1.0"
                    "paralyzer", "true"
                    "paralyzetime", "20.0"
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
              "normaltex", "unittextures/chicken_s_normals.png"
              "paralyzemultiplier", "0.0"
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
              "unitname", "raptor_allterrain_arty_emp_t2_v1"
              "upright", "false"
          ] }

    let raptor_allterrain_arty_emp_t4_v1 : UnitDef =
        { name = "raptor_allterrain_arty_emp_t4_v1"
          subfolder = "other/raptors/Electric"
          metalCost = ValueOrExpr.Concrete 396.0
          energyCost = ValueOrExpr.Concrete 12320.0
          buildTime = ValueOrExpr.Concrete 6750.0
          health = ValueOrExpr.Concrete 8000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptor_artillery_meteor_v2_electric.s3o"
          buildPic = Some "raptors/raptorearty2.DDS"
          script = Some "Raptors/raptor_artillery_v2.cob"
          corpse = None
          explodeAs = Some "raptor_empdeath_big"
          selfDestructAs = Some "raptor_empdeath_big"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "25 34 44"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 84.0
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
              { name = "goolauncher"
                displayName = Some "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 3600.0
                    "shields", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 2000.0)
                reloadTime = Some (ValueOrExpr.Concrete 20.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 220.0
                accuracy = Some 2048.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "bugarty"
                soundHit = Some "empbomb"
                explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                rgbColor = Some "0.2 0.5 0.9"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "50.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "8.0"
                    "burstrate", "0.001"
                    "cegtag", "blob_trail_blue"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "true"
                    "gravityaffected", "true"
                    "intensity", "0.8"
                    "interceptedbyshieldtype", "1.0"
                    "paralyzer", "true"
                    "paralyzetime", "20.0"
                    "proximitypriority", "-1.0"
                    "size", "5.5"
                    "sizedecay", "0.09"
                    "sprayangle", "2048.0"
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
              "paralyzemultiplier", "0.0"
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
              "unitname", "raptor_allterrain_arty_emp_t4_v1"
              "upright", "false"
          ] }

    let raptor_allterrain_assault_emp_t2_v1 : UnitDef =
        { name = "raptor_allterrain_assault_emp_t2_v1"
          subfolder = "other/raptors/Electric"
          metalCost = ValueOrExpr.Concrete 152.0
          energyCost = ValueOrExpr.Concrete 3520.0
          buildTime = ValueOrExpr.Concrete 9000.0
          health = ValueOrExpr.Concrete 22000.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorelectricallterrainassault.s3o"
          buildPic = Some "raptors/raptorelectricallterrainassault.DDS"
          script = Some "Raptors/raptorallterraina1.cob"
          corpse = None
          explodeAs = Some "raptor_empdeath_big"
          selfDestructAs = Some "raptor_empdeath_big"
          collisionVolumeOffsets = Some "0 2 0"
          collisionVolumeScales = Some "27 38 60"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 33.75
              maxAcc = 0.414
              maxDec = 0.46
              turnRate = 920.0
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
              waterline = Some 20.0 })
          builder = None
          weapons = Some [
              { name = "raptorparalyzerbig"
                displayName = Some "Close-quarters g2g lightning rifle"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 1400.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.5)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 100.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "alien_electric_xl"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "0.5 0.5 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "125.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "false"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "beamttl", "1.0"
                    "burst", "20.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "energypershot", "0.0"
                    "firestarter", "50.0"
                    "firesubmersed", "true"
                    "impactonly", "0.0"
                    "intensity", "24.0"
                    "laserFlareSize", "5.0"
                    "paralyzer", "true"
                    "paralyzetime", "20.0"
                    "soundstartvolume", "65.0"
                    "soundtrigger", "true"
                    "targetmoveerror", "0.15"
                    "thickness", "1.5"
                    "waterweapon", "true"
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
              "paralyzemultiplier", "0.0"
          ]
          extras = Map.ofList [
              "airsightdistance", "650.0"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "1500.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "7.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "34.0"
              "unitname", "raptore2"
              "upright", "false"
          ] }

    let raptor_allterrain_swarmer_emp_t2_v1 : UnitDef =
        { name = "raptor_allterrain_swarmer_emp_t2_v1"
          subfolder = "other/raptors/Electric"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 5280.0
          buildTime = ValueOrExpr.Concrete 2250.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptorelectricallterrain.s3o"
          buildPic = Some "raptors/raptorelectricallterrain.DDS"
          script = Some "Raptors/raptorc3.cob"
          corpse = None
          explodeAs = Some "raptor_empdeath_small"
          selfDestructAs = Some "raptor_empdeath_small"
          collisionVolumeOffsets = Some "0 -3 -3"
          collisionVolumeScales = Some "18 28 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 97.5
              maxAcc = 1.4375
              maxDec = 2.3
              turnRate = 1840.0
              movementClass = Some "RAPTORALLTERRAINHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 15.0
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
              { name = "raptorparalyzersmall"
                displayName = Some "Close-quarters g2g lightning rifle"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 375.0
                ]
                range = Some (ValueOrExpr.Concrete 250.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 100.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "alien_electric"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "0.5 0.5 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "110.0"
                    "collidefriendly", "false"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "beamttl", "1.0"
                    "burst", "10.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "energypershot", "0.0"
                    "firestarter", "50.0"
                    "impactonly", "0.0"
                    "intensity", "12.0"
                    "laserFlareSize", "2.0"
                    "paralyzer", "true"
                    "paralyzetime", "20.0"
                    "soundstartvolume", "42.0"
                    "soundtrigger", "true"
                    "targetmoveerror", "0.15"
                    "thickness", "0.5"
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
              "paralyzemultiplier", "0.0"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "89.0"
              "maxreversevelocity", "3.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "sonardistance", "450.0"
              "trackoffset", "0.5"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrackPointy"
              "trackwidth", "35.0"
              "unitname", "raptorc3"
              "upright", "false"
          ] }

    let raptor_land_assault_emp_t2_v1 : UnitDef =
        { name = "raptor_land_assault_emp_t2_v1"
          subfolder = "other/raptors/Electric"
          metalCost = ValueOrExpr.Concrete 152.0
          energyCost = ValueOrExpr.Concrete 3520.0
          buildTime = ValueOrExpr.Concrete 9000.0
          health = ValueOrExpr.Concrete 22000.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptore2.s3o"
          buildPic = Some "raptors/raptore2.DDS"
          script = Some "Raptors/raptora1.cob"
          corpse = None
          explodeAs = Some "raptor_empdeath_big"
          selfDestructAs = Some "raptor_empdeath_big"
          collisionVolumeOffsets = Some "0 2 0"
          collisionVolumeScales = Some "27 38 60"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 33.75
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
              waterline = Some 20.0 })
          builder = None
          weapons = Some [
              { name = "raptorparalyzerbig"
                displayName = Some "Close-quarters g2g lightning rifle"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 1400.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.5)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 100.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "alien_electric_xl"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "0.5 0.5 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "125.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "false"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "beamttl", "1.0"
                    "burst", "20.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "energypershot", "0.0"
                    "firestarter", "50.0"
                    "firesubmersed", "true"
                    "impactonly", "0.0"
                    "intensity", "24.0"
                    "laserFlareSize", "5.0"
                    "paralyzer", "true"
                    "paralyzetime", "20.0"
                    "soundstartvolume", "65.0"
                    "soundtrigger", "true"
                    "targetmoveerror", "0.15"
                    "thickness", "1.5"
                    "waterweapon", "true"
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
              "paralyzemultiplier", "0.0"
          ]
          extras = Map.ofList [
              "airsightdistance", "650.0"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "1500.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "7.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "34.0"
              "unitname", "raptor_land_assault_emp_t2_v1"
              "upright", "false"
          ] }

    let raptor_land_kamikaze_emp_t2_v1 : UnitDef =
        { name = "raptor_land_kamikaze_emp_t2_v1"
          subfolder = "other/raptors/Electric"
          metalCost = ValueOrExpr.Concrete 128.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 4500.0
          health = ValueOrExpr.Concrete 890.0
          sightDistance = ValueOrExpr.Concrete 50.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptor_dodo_electric.s3o"
          buildPic = Some "raptors/raptor_dodo1_electric.DDS"
          script = Some "Raptors/raptor_dodo1.cob"
          corpse = None
          explodeAs = Some "raptor_empdeath_small"
          selfDestructAs = Some "raptor_empdeath_small"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "10 14 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 2.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 210.0
              maxAcc = 6.9
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
              waterline = Some 13.0 })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
              "instantselfd", "true"
              "paralyzemultiplier", "0.0"
          ]
          extras = Map.ofList [
              "autoheal", "50.0"
              "canguard", "true"
              "canhover", "1"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "collide", "false"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "kamikaze", "true"
              "kamikazedistance", "40.0"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "50.0"
              "noautofire", "false"
              "nochasecategory", "VTOL HOVER"
              "selfdestructcountdown", "0.0"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "stealth", "1.0"
              "trackoffset", "1.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "10.0"
              "unitname", "raptor_land_kamikaze_emp_t2_v1"
              "upright", "false"
          ] }

    let raptor_land_kamikaze_emp_t4_v1 : UnitDef =
        { name = "raptor_land_kamikaze_emp_t4_v1"
          subfolder = "other/raptors/Electric"
          metalCost = ValueOrExpr.Concrete 350.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 22500.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 100.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptor_dodo2_electric.s3o"
          buildPic = Some "raptors/raptor_dodo2_electric.DDS"
          script = Some "Raptors/raptor_dodo2.cob"
          corpse = None
          explodeAs = Some "raptor_empdeath_big"
          selfDestructAs = Some "raptor_empdeath_big"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "18 35 41"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 240.0
              maxAcc = 6.9
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
              waterline = Some 21.0 })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "instantselfd", "true"
              "paralyzemultiplier", "0.0"
          ]
          extras = Map.ofList [
              "autoheal", "135.0"
              "canguard", "true"
              "canhover", "1"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "collide", "0.0"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "kamikaze", "true"
              "kamikazedistance", "72.0"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "100.0"
              "noautofire", "false"
              "nochasecategory", "VTOL HOVER"
              "selfdestructcountdown", "0.0"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "stealth", "1.0"
              "trackoffset", "1.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "10.0"
              "unitname", "raptor_land_kamikaze_emp_t4_v1"
              "upright", "false"
          ] }

    let raptor_land_swarmer_emp_t2_v1 : UnitDef =
        { name = "raptor_land_swarmer_emp_t2_v1"
          subfolder = "other/raptors/Electric"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 53.0
          buildTime = ValueOrExpr.Concrete 900.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 1.5
          footprintZ = 1.5
          objectName = Some "Raptors/raptore1.s3o"
          buildPic = Some "raptors/raptore1.DDS"
          script = Some "Raptors/raptor1.cob"
          corpse = None
          explodeAs = Some "raptor_empdeath_small"
          selfDestructAs = Some "raptor_empdeath_small"
          collisionVolumeOffsets = Some "0 -3 -3"
          collisionVolumeScales = Some "18 40 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 81.0
              maxAcc = 0.1725
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
              waterline = Some 16.0 })
          builder = None
          weapons = Some [
              { name = "raptorparalyzersmall"
                displayName = Some "Close-quarters g2g lightning rifle"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 375.0
                ]
                range = Some (ValueOrExpr.Concrete 250.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 100.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "alien_electric"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-lightning2"
                rgbColor = Some "0.5 0.5 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "collidefriendly", "false"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "beamttl", "1.0"
                    "burst", "10.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "1.0"
                    "energypershot", "0.0"
                    "firestarter", "50.0"
                    "impactonly", "0.0"
                    "intensity", "12.0"
                    "laserFlareSize", "2.0"
                    "paralyzer", "true"
                    "paralyzetime", "20.0"
                    "soundstartvolume", "42.0"
                    "soundtrigger", "true"
                    "targetmoveerror", "0.15"
                    "thickness", "0.5"
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
              "paralyzemultiplier", "0.0"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "30.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "0.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "18.0"
              "unitname", "raptor_land_swarmer_emp_t2_v1"
              "upright", "false"
          ] }

    let all : (string * UnitDef) list =
        [
            "raptor_air_bomber_emp_t2_v1", raptor_air_bomber_emp_t2_v1
            "raptor_allterrain_arty_emp_t2_v1", raptor_allterrain_arty_emp_t2_v1
            "raptor_allterrain_arty_emp_t4_v1", raptor_allterrain_arty_emp_t4_v1
            "raptor_allterrain_assault_emp_t2_v1", raptor_allterrain_assault_emp_t2_v1
            "raptor_allterrain_swarmer_emp_t2_v1", raptor_allterrain_swarmer_emp_t2_v1
            "raptor_land_assault_emp_t2_v1", raptor_land_assault_emp_t2_v1
            "raptor_land_kamikaze_emp_t2_v1", raptor_land_kamikaze_emp_t2_v1
            "raptor_land_kamikaze_emp_t4_v1", raptor_land_kamikaze_emp_t4_v1
            "raptor_land_swarmer_emp_t2_v1", raptor_land_swarmer_emp_t2_v1
        ]
