// Auto-generated BAR unit data: other/raptors
namespace BarData.V1.Units

open BarData.V1

module other_raptors =

    let raptor_air_gunship_acid_t2_v1 : UnitDef =
        { name = "raptor_air_gunship_acid_t2_v1"
          subfolder = "other/raptors"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 350.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorf1.s3o"
          buildPic = Some "raptors/raptorf1.DDS"
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
              { name = "acidspit"
                displayName = Some "GOOLAUNCHER"
                weaponType = None
                damage = Map.ofList [
                    "default", 1.0
                    "shields", 160.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.6)
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
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "125.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "2.0"
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
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "paralyzemultiplier", "0.0"
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
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
              "hoverAttack", "true"
          ] }

    let raptor_air_gunship_antiair_t2_v1 : UnitDef =
        { name = "raptor_air_gunship_antiair_t2_v1"
          subfolder = "other/raptors"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 350.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorf1.s3o"
          buildPic = Some "raptors/raptorf1.DDS"
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
              { name = "aaweapon"
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
              "nochasecategory", "NOTAIR"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
              "hoverAttack", "true"
          ] }

    let raptor_air_gunship_basic_t2_v1 : UnitDef =
        { name = "raptor_air_gunship_basic_t2_v1"
          subfolder = "other/raptors"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 350.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorf1.s3o"
          buildPic = Some "raptors/raptorf1.DDS"
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
              { name = "weapon"
                displayName = Some "Spike"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 325.0
                ]
                range = Some (ValueOrExpr.Concrete 525.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
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
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
              "hoverAttack", "true"
          ] }

    let raptor_air_gunship_emp_t2_v1 : UnitDef =
        { name = "raptor_air_gunship_emp_t2_v1"
          subfolder = "other/raptors"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 350.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorf1.s3o"
          buildPic = Some "raptors/raptorf1.DDS"
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
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "125.0"
                    "collidefriendly", "0.0"
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
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "paralyzemultiplier", "0.0"
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
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
              "hoverAttack", "true"
          ] }

    let raptor_air_gunship_fire_t2_v1 : UnitDef =
        { name = "raptor_air_gunship_fire_t2_v1"
          subfolder = "other/raptors"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 350.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorf1.s3o"
          buildPic = Some "raptors/raptorf1.DDS"
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
              { name = "flamer"
                displayName = Some "FlameThrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "default", 16.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.7)
                weaponVelocity = Some 265.0
                areaOfEffect = Some 64.0
                accuracy = None
                turret = Some true
                tolerance = Some 2500.0
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "cflamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:burnblack"
                rgbColor = Some "1 0.94 0.88"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "12.0"
                    "burstrate", "0.03333"
                    "cegtag", "burnflamexm"
                    "colormap", "1 0.95 0.82 0.03   0.7 0.4 0.25 0.027   0.44 0.25 0.15 0.024   0.033 0.018 0.011 0.02   0.0 0.0 0.0 0.01"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flamegfxtime", "1.0"
                    "intensity", "0.65"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.9 0.83 0.77"
                    "sizegrowth", "0.7"
                    "soundhitwet", "sizzle"
                    "soundtrigger", "false"
                    "sprayangle", "100.0"
                    "targetmoveerror", "0.001"
                    "weapontimer", "1.0"
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
              "paralyzemultiplier", "0.0"
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
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
              "hoverAttack", "true"
          ] }

    let all : (string * UnitDef) list =
        [
            "raptor_air_gunship_acid_t2_v1", raptor_air_gunship_acid_t2_v1
            "raptor_air_gunship_antiair_t2_v1", raptor_air_gunship_antiair_t2_v1
            "raptor_air_gunship_basic_t2_v1", raptor_air_gunship_basic_t2_v1
            "raptor_air_gunship_emp_t2_v1", raptor_air_gunship_emp_t2_v1
            "raptor_air_gunship_fire_t2_v1", raptor_air_gunship_fire_t2_v1
        ]
