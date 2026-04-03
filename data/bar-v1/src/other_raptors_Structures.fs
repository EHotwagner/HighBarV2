// Auto-generated BAR unit data: other/raptors/Structures
namespace BarData.V1.Units

open BarData.V1

module other_raptors_Structures =

    let raptor_antinuke : UnitDef =
        { name = "raptor_antinuke"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 1500.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 60000.0
          health = ValueOrExpr.Concrete 10000.0
          sightDistance = ValueOrExpr.Concrete 195.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor_antinuke.s3o"
          buildPic = Some "raptors/raptor_hive.DDS"
          script = Some "Raptors/raptor_antinuke.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "1 1 1"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "SURFACE"
          movement = None
          builder = None
          weapons = Some [
              { name = "fmd_rocket"
                displayName = Some "ICBM intercepting missile launcher"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 1500.0
                ]
                range = Some (ValueOrExpr.Concrete 72000.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 6000.0
                areaOfEffect = Some 420.0
                accuracy = None
                turret = None
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "antinukelaunch"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:antinuke"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "ALL"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "antimissiletrail"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "coverage", "72000.0"
                    "craterareaofeffect", "420.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "dance", "20.0"
                    "firestarter", "100.0"
                    "flighttime", "30.0"
                    "interceptor", "1.0"
                    "model", "SimpleFlareXL.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "10.0"
                    "smoketime", "110.0"
                    "smokesize", "27.0"
                    "smokecolor", "0.7"
                    "smokeTrailCastShadow", "true"
                    "soundhitwet", "splslrg"
                    "stockpile", "true"
                    "stockpiletime", "60.0"
                    "texture1", "bluenovaexplo"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "tracks", "true"
                    "turnrate", "120000.0"
                    "weaponacceleration", "150.0"
                    "weapontimer", "5.0"
                    "wobble", "32000.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooo"
              activateWhenBuilt = None
              canRepeat = Some false })
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
              ok = ["loadwtr1"]
              select = ["loadwtr1"] })
          customParams = Map.ofList [
              "unitgroup", "antinuke"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/chicken_l_normals.png"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "canattack", "false"
              "noautofire", "true"
              "radardistance", "50.0"
              "repairable", "false"
          ] }

    let raptor_hive : UnitDef =
        { name = "raptor_hive"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 50000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Raptors/raptor_hive.s3o"
          buildPic = Some "raptors/raptor_hive.DDS"
          script = Some "Raptors/raptor_hive2_l.cob"
          corpse = None
          explodeAs = Some "ROOST_DEATH"
          selfDestructAs = Some "ROOST_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "84 150 84"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = None
          builder = None
          weapons = Some [
              { name = "antiground"
                displayName = Some "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1280.0
                    "shields", 320.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 20.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 256.0
                accuracy = Some 2048.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "bugarty"
                soundHit = Some "bombsmed2"
                explosiongenerator = Some "custom:genericshellexplosion-huge"
                rgbColor = Some "1 0.5 0.1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "4.0"
                    "burstrate", "0.001"
                    "cegtag", "blob_trail_red"
                    "craterareaofeffect", "256.0"
                    "craterboost", "0.2"
                    "cratermult", "0.2"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "proximitypriority", "-1.0"
                    "size", "5.5"
                    "sizedecay", "0.09"
                    "sprayangle", "2048.0"
                    "weapontimer", "0.2"
                ] }
              { name = "antiair"
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
              { name = "spawnmeteor"
                displayName = Some "Asteroid"
                weaponType = None
                damage = Map.ofList [
                    "raptor", 0.1
                    "default", 50000.0
                ]
                range = Some (ValueOrExpr.Concrete 100.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 144.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = None
                soundHit = Some "nuke4"
                explosiongenerator = Some "custom:genericshellexplosion-meteor"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfriendly", "0.0"
                    "cegtag", "nuketrail-roost"
                    "collidefriendly", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "100.0"
                    "interceptedbyshieldtype", "4.0"
                    "metalpershot", "0.0"
                    "model", "Raptors/greyrock2.s3o"
                    "smoketrail", "1.0"
                    "soundhitvolume", "10.0"
                    "startvelocity", "2000.0"
                    "weaponacceleration", "120.0"
                    "weapontimer", "10.0"
                    "wobble", "0.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 1000.0)
              metalMake = Some (ValueOrExpr.Concrete 100.0)
              energyStorage = Some 10000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooo oooooo oooooo oooooo oooooo oooooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "isairbase", "true"
              "subfolder", "other/raptors"
              "model_author", "FireStorm, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "autoheal", "1.8"
              "capturable", "false"
              "levelground", "false"
              "mass", "165.75"
              "noautofire", "false"
              "radardistance", "900.0"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "roost"
              "upright", "false"
          ] }

    let raptor_turret_acid_t2_v1 : UnitDef =
        { name = "raptor_turret_acid_t2_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 120.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 2700.0
          health = ValueOrExpr.Concrete 1670.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor_turrets_acid_v2.s3o"
          buildPic = Some "raptors/raptor_turrets_acid.DDS"
          script = Some "Raptors/raptor_turrets_v2.cob"
          corpse = None
          explodeAs = Some "bug_death"
          selfDestructAs = Some "bug_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "20 50 20"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "acidspit"
                displayName = Some "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1.0
                    "shields", 320.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 20.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 150.0
                accuracy = Some 1024.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:acid-explosion-xl"
                rgbColor = Some "0.8 0.99 0.11"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "area_onhit_ceg", "acid-area-150-repeat"
                    "area_onhit_damageCeg", "acid-damage-gen"
                    "area_onhit_resistance", "_RAPTORACID_"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "1.0"
                    "burstrate", "0.001"
                    "cegtag", "blob_trail_green"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "nogap", "false"
                    "size", "9.0"
                    "sizedecay", "0.04"
                    "alphaDecay", "0.18"
                    "stages", "8.0"
                    "proximitypriority", "-1.0"
                    "sprayangle", "1024.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 500.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oo oo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "700.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord1"
              "upright", "false"
          ] }

    let raptor_turret_acid_t3_v1 : UnitDef =
        { name = "raptor_turret_acid_t3_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 5200.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Raptors/raptor_turretl_acid_v2.s3o"
          buildPic = Some "raptors/raptor_turretl_acid.DDS"
          script = Some "Raptors/raptor_turretl_v2.cob"
          corpse = None
          explodeAs = Some "tentacle_death"
          selfDestructAs = Some "tentacle_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "40 50 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "acidspit"
                displayName = Some "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1.0
                    "shields", 320.0
                ]
                range = Some (ValueOrExpr.Concrete 2000.0)
                reloadTime = Some (ValueOrExpr.Concrete 40.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 150.0
                accuracy = Some 2048.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:acid-explosion-xl"
                rgbColor = Some "0.8 0.99 0.11"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "area_onhit_ceg", "acid-area-150-repeat"
                    "area_onhit_damageCeg", "acid-damage-gen"
                    "area_onhit_resistance", "_RAPTORACID_"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "4.0"
                    "burstrate", "0.001"
                    "cegtag", "blob_trail_green"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "nogap", "false"
                    "size", "9.0"
                    "sizedecay", "0.04"
                    "alphaDecay", "0.18"
                    "stages", "8.0"
                    "proximitypriority", "-1.0"
                    "sprayangle", "2048.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooo oooo oooo oooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "1400.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord2"
              "upright", "false"
          ] }

    let raptor_turret_acid_t4_v1 : UnitDef =
        { name = "raptor_turret_acid_t4_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 5200.0
          health = ValueOrExpr.Concrete 30000.0
          sightDistance = ValueOrExpr.Concrete 250.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Raptors/raptor_turretxl_acid_v2.s3o"
          buildPic = Some "raptors/raptor_turretl_acid.DDS"
          script = Some "Raptors/raptor_turretxl_v2.cob"
          corpse = None
          explodeAs = Some "tentacle_death"
          selfDestructAs = Some "tentacle_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "40 50 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "acidspit"
                displayName = Some "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1.0
                    "shields", 320.0
                ]
                range = Some (ValueOrExpr.Concrete 5000.0)
                reloadTime = Some (ValueOrExpr.Concrete 240.0)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 150.0
                accuracy = Some 2048.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:acid-explosion-xl"
                rgbColor = Some "0.8 0.99 0.11"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "area_onhit_ceg", "acid-area-150-repeat"
                    "area_onhit_damageCeg", "acid-damage-gen"
                    "area_onhit_resistance", "_RAPTORACID_"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "16.0"
                    "burstrate", "0.001"
                    "cegtag", "blob_trail_green"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "nogap", "false"
                    "size", "9.0"
                    "sizedecay", "0.04"
                    "alphaDecay", "0.18"
                    "stages", "8.0"
                    "proximitypriority", "-1.0"
                    "sprayangle", "2048.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "1400.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord2"
              "upright", "false"
          ] }

    let raptor_turret_antiair_t2_v1 : UnitDef =
        { name = "raptor_turret_antiair_t2_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 120.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 2700.0
          health = ValueOrExpr.Concrete 1670.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor_turrets_red_v2.s3o"
          buildPic = Some "raptors/raptor_turrets_antiair.DDS"
          script = Some "Raptors/raptor_turrets_v2.cob"
          corpse = None
          explodeAs = Some "bug_death"
          selfDestructAs = Some "bug_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "20 50 20"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Deadly Defensive Spores"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "vtol", 1000.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 10.0)
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
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 500.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oo oo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "700.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord1"
              "upright", "false"
          ] }

    let raptor_turret_antiair_t3_v1 : UnitDef =
        { name = "raptor_turret_antiair_t3_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 5200.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Raptors/raptor_turretl_red_v2.s3o"
          buildPic = Some "raptors/raptor_turretl_antiair.DDS"
          script = Some "Raptors/raptor_turretl_v2.cob"
          corpse = None
          explodeAs = Some "tentacle_death"
          selfDestructAs = Some "tentacle_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "40 50 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
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
          building = Some (
            { yardMap = Some "oooo oooo oooo oooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "1400.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord2"
              "upright", "false"
          ] }

    let raptor_turret_antiair_t4_v1 : UnitDef =
        { name = "raptor_turret_antiair_t4_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 5200.0
          health = ValueOrExpr.Concrete 30000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Raptors/raptor_turretxl_red_v2.s3o"
          buildPic = Some "raptors/raptor_turretl_antiair.DDS"
          script = Some "Raptors/raptor_turretxl_v2.cob"
          corpse = None
          explodeAs = Some "tentacle_death"
          selfDestructAs = Some "tentacle_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "80 50 80"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Deadly Defensive Spores"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "vtol", 1000.0
                ]
                range = Some (ValueOrExpr.Concrete 1250.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.25)
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
          building = Some (
            { yardMap = Some "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "1400.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord2"
              "upright", "false"
          ] }

    let raptor_turret_antinuke_t2_v1 : UnitDef =
        { name = "raptor_turret_antinuke_t2_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 120.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 2700.0
          health = ValueOrExpr.Concrete 1670.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor_turrets_antinuke_v2.s3o"
          buildPic = Some "raptors/raptor_turrets_antinuke.DDS"
          script = Some "Raptors/raptor_turrets_v2.cob"
          corpse = None
          explodeAs = Some "bug_death"
          selfDestructAs = Some "bug_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "20 50 20"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "fmd_rocket"
                displayName = Some "ICBM intercepting missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1500.0
                ]
                range = Some (ValueOrExpr.Concrete 72000.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 128.0
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
                    "mount_badtargetcategory", "ALL"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "antimissiletrail"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "coverage", "1500.0"
                    "cameraShake", "700.0"
                    "dance", "20.0"
                    "firestarter", "0.0"
                    "flighttime", "60.0"
                    "firesubmersed", "true"
                    "interceptedbyshieldtype", "4.0"
                    "interceptor", "1.0"
                    "metalpershot", "0.0"
                    "model", "SimpleFlareXL.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "2.0"
                    "smoketime", "45.0"
                    "smokesize", "10.5"
                    "smokecolor", "1.0"
                    "soundstartvolume", "9.0"
                    "stockpile", "true"
                    "stockpiletime", "80.0"
                    "startvelocity", "1000.0"
                    "texture1", "bluenovaexplo"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "tracks", "true"
                    "trajectoryheight", "2.0"
                    "turnrate", "60000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "40.0"
                    "wobble", "32000.0"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 500.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oo oo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "700.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord1"
              "upright", "false"
          ] }

    let raptor_turret_antinuke_t3_v1 : UnitDef =
        { name = "raptor_turret_antinuke_t3_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 5200.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Raptors/raptor_turretl_antinuke_v2.s3o"
          buildPic = Some "raptors/raptor_turretl_antinuke.DDS"
          script = Some "Raptors/raptor_turretl_v2.cob"
          corpse = None
          explodeAs = Some "tentacle_death"
          selfDestructAs = Some "tentacle_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "40 50 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "fmd_rocket"
                displayName = Some "ICBM intercepting missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1500.0
                ]
                range = Some (ValueOrExpr.Concrete 72000.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 128.0
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
                    "mount_badtargetcategory", "ALL"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "antimissiletrail"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "coverage", "2500.0"
                    "cameraShake", "700.0"
                    "dance", "20.0"
                    "firestarter", "0.0"
                    "flighttime", "60.0"
                    "firesubmersed", "true"
                    "interceptedbyshieldtype", "4.0"
                    "interceptor", "1.0"
                    "metalpershot", "0.0"
                    "model", "SimpleFlareXL.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "2.0"
                    "smoketime", "45.0"
                    "smokesize", "10.5"
                    "smokecolor", "1.0"
                    "soundstartvolume", "9.0"
                    "stockpile", "true"
                    "stockpiletime", "40.0"
                    "startvelocity", "1000.0"
                    "texture1", "bluenovaexplo"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "tracks", "true"
                    "trajectoryheight", "2.0"
                    "turnrate", "60000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "40.0"
                    "wobble", "32000.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooo oooo oooo oooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "1400.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord2"
              "upright", "false"
              "turret", "true"
          ] }

    let raptor_turret_basic_t2_v1 : UnitDef =
        { name = "raptor_turret_basic_t2_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 120.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 2700.0
          health = ValueOrExpr.Concrete 1670.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor_turrets_v2.s3o"
          buildPic = Some "raptors/raptor_turrets.DDS"
          script = Some "Raptors/raptor_turrets_v2.cob"
          corpse = None
          explodeAs = Some "bug_death"
          selfDestructAs = Some "bug_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "20 50 20"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1280.0
                    "shields", 320.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 20.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 256.0
                accuracy = Some 1024.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "bugarty"
                soundHit = Some "bombsmed2"
                explosiongenerator = Some "custom:genericshellexplosion-huge"
                rgbColor = Some "1 0.5 0.1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "1.0"
                    "burstrate", "0.001"
                    "cegtag", "blob_trail_red"
                    "craterareaofeffect", "256.0"
                    "craterboost", "0.2"
                    "cratermult", "0.2"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "proximitypriority", "-1.0"
                    "size", "5.5"
                    "sizedecay", "0.09"
                    "sprayangle", "1024.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 500.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oo oo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "700.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord1"
              "upright", "false"
          ] }

    let raptor_turret_basic_t3_v1 : UnitDef =
        { name = "raptor_turret_basic_t3_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 5200.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Raptors/raptor_turretl_v2.s3o"
          buildPic = Some "raptors/raptor_turretl.DDS"
          script = Some "Raptors/raptor_turretl_v2.cob"
          corpse = None
          explodeAs = Some "tentacle_death"
          selfDestructAs = Some "tentacle_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "40 50 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1280.0
                    "shields", 320.0
                ]
                range = Some (ValueOrExpr.Concrete 2000.0)
                reloadTime = Some (ValueOrExpr.Concrete 40.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 256.0
                accuracy = Some 2048.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "bugarty"
                soundHit = Some "bombsmed2"
                explosiongenerator = Some "custom:genericshellexplosion-huge"
                rgbColor = Some "1 0.5 0.1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "4.0"
                    "burstrate", "0.001"
                    "cegtag", "blob_trail_red"
                    "craterareaofeffect", "256.0"
                    "craterboost", "0.2"
                    "cratermult", "0.2"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "proximitypriority", "-1.0"
                    "size", "5.5"
                    "sizedecay", "0.09"
                    "sprayangle", "2048.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooo oooo oooo oooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "1400.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord2"
              "upright", "false"
          ] }

    let raptor_turret_basic_t4_v1 : UnitDef =
        { name = "raptor_turret_basic_t4_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 5200.0
          health = ValueOrExpr.Concrete 30000.0
          sightDistance = ValueOrExpr.Concrete 250.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Raptors/raptor_turretxl_v2.s3o"
          buildPic = Some "raptors/raptor_turretl.DDS"
          script = Some "Raptors/raptor_turretxl_v2.cob"
          corpse = None
          explodeAs = Some "tentacle_death"
          selfDestructAs = Some "tentacle_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "40 50 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1280.0
                    "shields", 320.0
                ]
                range = Some (ValueOrExpr.Concrete 5000.0)
                reloadTime = Some (ValueOrExpr.Concrete 240.0)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 256.0
                accuracy = Some 2048.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "bugarty"
                soundHit = Some "bombsmed2"
                explosiongenerator = Some "custom:genericshellexplosion-huge"
                rgbColor = Some "1 0.5 0.1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "16.0"
                    "burstrate", "0.001"
                    "cegtag", "blob_trail_red"
                    "craterareaofeffect", "256.0"
                    "craterboost", "0.2"
                    "cratermult", "0.2"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "proximitypriority", "-1.0"
                    "size", "5.5"
                    "sizedecay", "0.09"
                    "sprayangle", "2048.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "1400.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord2"
              "upright", "false"
          ] }

    let raptor_turret_burrow_t2_v1 : UnitDef =
        { name = "raptor_turret_burrow_t2_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 120.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 2700.0
          health = ValueOrExpr.Concrete 1670.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor_turrets_v2.s3o"
          buildPic = Some "raptors/raptor_turrets_burrow.DDS"
          script = Some "Raptors/raptor_turrets_v2.cob"
          corpse = None
          explodeAs = Some "bug_death"
          selfDestructAs = Some "bug_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "20 50 20"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "GOOLAUNCHER"
                weaponType = None
                damage = Map.ofList [
                    "default", 1600.0
                    "shields", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 256.0
                accuracy = Some 256.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "bugarty"
                soundHit = Some "bombsmed2"
                explosiongenerator = Some "custom:genericshellexplosion-huge"
                rgbColor = Some "1 0.5 0.1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "1.0"
                    "burstrate", "0.5"
                    "cegtag", "blob_trail_red"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "proximitypriority", "-1.0"
                    "size", "3.0"
                    "sizedecay", "0.09"
                    "sprayangle", "512.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 500.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oo oo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "700.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord1"
              "upright", "false"
          ] }

    let raptor_turret_emp_t2_v1 : UnitDef =
        { name = "raptor_turret_emp_t2_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 120.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 2700.0
          health = ValueOrExpr.Concrete 1670.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor_turrets_electric_v2.s3o"
          buildPic = Some "raptors/raptor_turrets_electric.DDS"
          script = Some "Raptors/raptor_turrets_v2.cob"
          corpse = None
          explodeAs = Some "bug_death"
          selfDestructAs = Some "bug_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "20 50 20"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "raptorparalyzersmall"
                displayName = Some "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 3600.0
                    "shields", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 40.0)
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
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 500.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oo oo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "treeshader", "yes"
              "paralyzemultiplier", "0.0"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "700.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord1"
              "upright", "false"
          ] }

    let raptor_turret_emp_t3_v1 : UnitDef =
        { name = "raptor_turret_emp_t3_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 5200.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Raptors/raptor_turretl_electric_v2.s3o"
          buildPic = Some "raptors/raptor_turretl_electric.DDS"
          script = Some "Raptors/raptor_turretl_v2.cob"
          corpse = None
          explodeAs = Some "tentacle_death"
          selfDestructAs = Some "tentacle_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "40 50 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "raptorparalyzerbig"
                displayName = Some "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 3600.0
                    "shields", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 2000.0)
                reloadTime = Some (ValueOrExpr.Concrete 80.0)
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
          building = Some (
            { yardMap = Some "oooo oooo oooo oooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "treeshader", "yes"
              "paralyzemultiplier", "0.0"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "1400.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord2"
              "upright", "false"
          ] }

    let raptor_turret_emp_t4_v1 : UnitDef =
        { name = "raptor_turret_emp_t4_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 5200.0
          health = ValueOrExpr.Concrete 30000.0
          sightDistance = ValueOrExpr.Concrete 250.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Raptors/raptor_turretxl_electric_v2.s3o"
          buildPic = Some "raptors/raptor_turretl_electric.DDS"
          script = Some "Raptors/raptor_turretxl_v2.cob"
          corpse = None
          explodeAs = Some "tentacle_death"
          selfDestructAs = Some "tentacle_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "40 50 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "raptorparalyzerbig"
                displayName = Some "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 3600.0
                    "shields", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 5000.0)
                reloadTime = Some (ValueOrExpr.Concrete 480.0)
                weaponVelocity = Some 800.0
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
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "32.0"
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
          building = Some (
            { yardMap = Some "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "treeshader", "yes"
              "paralyzemultiplier", "0.0"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "1400.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord2"
              "upright", "false"
          ] }

    let raptor_turret_meteor_t4_v1 : UnitDef =
        { name = "raptor_turret_meteor_t4_v1"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 5200.0
          health = ValueOrExpr.Concrete 30000.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Raptors/raptor_turretxl_meteor_v2.s3o"
          buildPic = Some "raptors/raptor_turretxl_meteor.DDS"
          script = Some "Raptors/raptor_turretxl_v2.cob"
          corpse = None
          explodeAs = Some "tentacle_death"
          selfDestructAs = Some "tentacle_death"
          collisionVolumeOffsets = Some "0 -15 0"
          collisionVolumeScales = Some "80 50 80"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "METEORLAUNCHER"
                weaponType = None
                damage = Map.ofList [
                    "default", 30000.0
                ]
                range = Some (ValueOrExpr.Concrete 72000.0)
                reloadTime = Some (ValueOrExpr.Concrete 30.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 1920.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.5
                impulseFactor = None
                noSelfDamage = None
                soundStart = Some "bugarty"
                soundHit = Some "nukecor"
                explosiongenerator = Some "custom:newnukecor"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NONE"
                    "avoidfriendly", "0.0"
                    "cegtag", "nuketrail-roost"
                    "collidefriendly", "0.0"
                    "commandfire", "true"
                    "craterareaofeffect", "1920.0"
                    "craterboost", "2.4"
                    "cratermult", "1.2"
                    "firestarter", "70.0"
                    "hightrajectory", "1.0"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/greyrock2.s3o"
                    "proximitypriority", "-1.0"
                    "soundhitwet", "nukewater"
                    "targetable", "1.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "hightrajectory", "1.0"
              "levelground", "false"
              "mass", "1400.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "repairable", "true"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord2"
              "upright", "false"
          ] }

    let raptor_worm_green : UnitDef =
        { name = "raptor_worm_green"
          subfolder = "other/raptors/Structures"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 5200.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Raptors/raptor_worm_green.s3o"
          buildPic = Some "raptors/raptor_worm_green.DDS"
          script = Some "Raptors/raptor_worm_m.cob"
          corpse = None
          explodeAs = Some "tentacle_death"
          selfDestructAs = Some "tentacle_death"
          collisionVolumeOffsets = Some "0 15 0"
          collisionVolumeScales = Some "35 50 35"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0115
              maxDec = 0.0115
              turnRate = 1840.0
              movementClass = Some "NANO"
              maxSlope = Some 255.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 1.0 })
          builder = None
          weapons = Some [
              { name = "acidspit"
                displayName = Some "GOOLAUNCHER"
                weaponType = None
                damage = Map.ofList [
                    "default", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.5)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 150.0
                accuracy = Some 1024.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:acid-explosion-xl"
                rgbColor = Some "0.8 0.99 0.11"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burstrate", "0.5"
                    "cegtag", "blob_trail_green"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "nogap", "false"
                    "size", "8.0"
                    "sizedecay", "0.03"
                    "alphaDecay", "0.14"
                    "stages", "9.0"
                    "sprayangle", "92.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "LathanStanley, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "treeshader", "yes"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canattack", "true"
              "canreclaim", "false"
              "canrestore", "false"
              "canstop", "1"
              "capturable", "false"
              "levelground", "false"
              "mass", "1400.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "unitname", "raptord2"
              "upright", "false"
          ] }

    let all : (string * UnitDef) list =
        [
            "raptor_antinuke", raptor_antinuke
            "raptor_hive", raptor_hive
            "raptor_turret_acid_t2_v1", raptor_turret_acid_t2_v1
            "raptor_turret_acid_t3_v1", raptor_turret_acid_t3_v1
            "raptor_turret_acid_t4_v1", raptor_turret_acid_t4_v1
            "raptor_turret_antiair_t2_v1", raptor_turret_antiair_t2_v1
            "raptor_turret_antiair_t3_v1", raptor_turret_antiair_t3_v1
            "raptor_turret_antiair_t4_v1", raptor_turret_antiair_t4_v1
            "raptor_turret_antinuke_t2_v1", raptor_turret_antinuke_t2_v1
            "raptor_turret_antinuke_t3_v1", raptor_turret_antinuke_t3_v1
            "raptor_turret_basic_t2_v1", raptor_turret_basic_t2_v1
            "raptor_turret_basic_t3_v1", raptor_turret_basic_t3_v1
            "raptor_turret_basic_t4_v1", raptor_turret_basic_t4_v1
            "raptor_turret_burrow_t2_v1", raptor_turret_burrow_t2_v1
            "raptor_turret_emp_t2_v1", raptor_turret_emp_t2_v1
            "raptor_turret_emp_t3_v1", raptor_turret_emp_t3_v1
            "raptor_turret_emp_t4_v1", raptor_turret_emp_t4_v1
            "raptor_turret_meteor_t4_v1", raptor_turret_meteor_t4_v1
            "raptor_worm_green", raptor_worm_green
        ]
