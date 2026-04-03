// Auto-generated BAR unit data: ArmGantry
namespace BarData.V1.Units

open BarData.V1

module ArmGantry =

    let armbanth : UnitDef =
        { name = "armbanth"
          subfolder = "ArmGantry"
          metalCost = ValueOrExpr.Concrete 13500.0
          energyCost = ValueOrExpr.Concrete 286000.0
          buildTime = ValueOrExpr.Concrete 360000.0
          health = ValueOrExpr.Concrete 69000.0
          sightDistance = ValueOrExpr.Concrete 617.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMBANTH.s3o"
          buildPic = Some "ARMBANTH.DDS"
          script = Some "Units/ARMBANTH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "bantha"
          selfDestructAs = Some "banthaSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "60 88 60"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 45.6
              maxAcc = 0.11845
              maxDec = 0.7521
              turnRate = 1214.40002
              movementClass = Some "HABOT5"
              maxSlope = Some 17.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.089
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armbantha_fire"
                displayName = Some "Close-quarters impulsion blaster"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 730.0
                ]
                range = Some (ValueOrExpr.Concrete 465.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.4)
                weaponVelocity = Some 1072.0
                areaOfEffect = Some 64.0
                accuracy = Some 100.0
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "banthie2"
                soundHit = Some "xplosml3"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = Some "0.7 0.7 0.1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamdecay", "12.0"
                    "corethickness", "0.85"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.02"
                    "intensity", "1.0"
                    "laserflaresize", "10.1"
                    "proximitypriority", "1.0"
                    "size", "2.0"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "45.0"
                    "thickness", "3.3"
                ] }
              { name = "tehlazerofdewm"
                displayName = Some "High-energy long-range g2g/g2a lazor of DEEEEEEWWWWWWMMMMMM"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 1800.0
                    "default", 6000.0
                    "vtol", 3000.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 7.5)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 14.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "annigun1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-blue"
                rgbColor = Some "0.2 0.2 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "1.05"
                    "corethickness", "0.3"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "1300.0"
                    "firestarter", "90.0"
                    "laserflaresize", "9.1"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "4.7"
                ] }
              { name = "bantha_rocket"
                displayName = Some "Heavy g2g/g2a guided starburst missile launcher"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 900.0
                    "subs", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 860.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.86667)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 96.0
                accuracy = None
                turret = None
                tolerance = Some 9000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rapidrocket3"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "canattackground", "false"
                    "castshadow", "true"
                    "cegtag", "missiletrailsmall-starburst"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "model", "corkbmissl1.s3o"
                    "proximitypriority", "-1.0"
                    "smokecolor", "0.7"
                    "smokeperiod", "9.0"
                    "smokesize", "12.0"
                    "smoketime", "36.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splsmed"
                    "startvelocity", "10.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "tracks", "true"
                    "turnrate", "15000.0"
                    "weaponacceleration", "200.0"
                    "weapontimer", "1.0"
                ] }
              { name = "banthfootstep"
                displayName = Some "BanthStep"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 0.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = None
                areaOfEffect = Some 128.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.0
                impulseFactor = None
                noSelfDamage = Some true
                soundStart = None
                soundHit = Some "banthstep"
                explosiongenerator = Some "custom:footstep-large"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "camerashake", "300.0"
                    "canattackground", "false"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "impactonly", "1.0"
                    "soundhitvolume", "35.0"
                    "soundhitwet", "splssml"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 150.0)
              metalMake = None
              energyStorage = Some 2500.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "66.5059539795 40 69.125361816406"
                collisionVolumeType = Some "Box"
                damage = Some 21000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 8249.0
                object_ = Some "Units/armbanth_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 10500.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 3300.0
                object_ = Some "Units/arm3X3A.s3o"
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
              ok = ["krogok1"]
              select = ["krogsel1"] })
          customParams = Map.ofList [
              "customrange", "465.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "1.0"
              "subfolder", "ArmGantry"
              "techlevel", "3.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "airsightdistance", "1100.0"
              "cantbetransported", "true"
              "mass", "13500.0"
              "nochasecategory", "VTOL"
              "selfdestructcountdown", "10.0"
              "upright", "true"
          ] }

    let armlun : UnitDef =
        { name = "armlun"
          subfolder = "ArmGantry"
          metalCost = ValueOrExpr.Concrete 1150.0
          energyCost = ValueOrExpr.Concrete 23000.0
          buildTime = ValueOrExpr.Concrete 40000.0
          health = ValueOrExpr.Concrete 5300.0
          sightDistance = ValueOrExpr.Concrete 620.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMLUN.s3o"
          buildPic = Some "ARMLUN.DDS"
          script = Some "Units/armlun.cob"
          corpse = Some "dead"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = None
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 50.1
              maxAcc = 0.01788
              maxDec = 0.01788
              turnRate = 250.0
              movementClass = Some "HHOVER4"
              maxSlope = Some 16.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.122
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "cannon"
                displayName = Some "Heavy ballistic underwater cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 370.0
                    "subs", 370.0
                    "vtol", 60.0
                ]
                range = Some (ValueOrExpr.Concrete 575.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.8)
                weaponVelocity = Some 300.0
                areaOfEffect = Some 160.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "largegun"
                soundHit = Some "xplomed1"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "cegtag", "missiletrailcorroyspecial"
                    "def", "armlun_cannonuw"
                    "model", "airbombt2"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "missiletrailcorroyspecial"
                    "craterareaofeffect", "160.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "interceptedbyshieldtype", "4.0"
                    "model", "airbombt2.s3o"
                    "soundhitwet", "splslrg"
                    "waterweapon", "false"
                ] }
              { name = "depthcharge"
                displayName = Some "Depthcharge launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 225.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 140.0
                areaOfEffect = Some 24.0
                accuracy = None
                turret = Some true
                tolerance = Some 1000.0
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-medium-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSUB"
                    "mount_maindir", "0 -1 0"
                    "mount_maxangledif", "179.0"
                    "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "3.0"
                    "model", "cordepthcharge.s3o"
                    "predictboost", "0.0"
                    "startvelocity", "120.0"
                    "tracks", "true"
                    "turnrate", "6000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "20.0"
                    "weapontimer", "3.0"
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
                damage = Some 7000.0
                featureDead = Some "heap"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 15.0
                metal = Some 514.0
                object_ = Some "Units/armlun_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 3500.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 188.0
                object_ = Some "Units/arm4x4d.s3o"
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
              ok = ["hovt2lasok"]
              select = ["hovt2lassel"] })
          customParams = Map.ofList [
              "model_author", "Flaka"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmGantry"
              "techlevel", "3.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1.0"
              "cantbetransported", "true"
              "nochasecategory", "VTOL"
              "radardistance", "0.0"
              "sonardistance", "550.0"
          ] }

    let armmar : UnitDef =
        { name = "armmar"
          subfolder = "ArmGantry"
          metalCost = ValueOrExpr.Concrete 970.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 33000.0
          health = ValueOrExpr.Concrete 4900.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMMAR.s3o"
          buildPic = Some "ARMMAR.DDS"
          script = Some "Units/armmar.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3med"
          selfDestructAs = Some "explosiont3"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "50 70 50"
          collisionVolumeType = Some "CYLY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 94.5
              maxAcc = 0.253
              maxDec = 0.8211
              turnRate = 1214.40002
              movementClass = Some "HABOT5"
              maxSlope = Some 17.0
              maxWaterDepth = Some 32.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.98
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armmech_cannon"
                displayName = Some "Double close-quarters gauss cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 235.0
                    "vtol", 60.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.7)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "KroGun1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "5.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                    "targetmoveerror", "0.15"
                    "weapontimer", "2.0"
                ] }
              { name = "armamph_missile"
                displayName = Some "Guided g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 90.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.1)
                weaponVelocity = Some 850.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 9000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rocklit1"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "1.75"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.95"
                    "smokeperiod", "6.0"
                    "smokesize", "4.4"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "650.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "48000.0"
                    "weaponacceleration", "200.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "60 30 60"
                collisionVolumeType = Some "Box"
                damage = Some 2400.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 592.0
                object_ = Some "Units/armmar_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "40 40 40"
                collisionVolumeType = Some "Sphere"
                damage = Some 1200.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 237.0
                object_ = Some "Units/arm3X3F.s3o"
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
              ok = ["mavbok1"]
              select = ["mavbsel1"] })
          customParams = Map.ofList [
              "maxrange", "350"
              "model_author", "PtaQ"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmGantry"
              "techlevel", "3.0"
              "unitgroup", "weapon"
              "weapon1turretx", "90.0"
              "weapon1turrety", "150.0"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "970.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let armprowl : UnitDef =
        { name = "armprowl"
          subfolder = "ArmGantry"
          metalCost = ValueOrExpr.Concrete 970.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 33000.0
          health = ValueOrExpr.Concrete 4900.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/armprowl.s3o"
          buildPic = Some "ARMMAR.DDS"
          script = Some "Units/armprowl.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3med"
          selfDestructAs = Some "explosiont3"
          collisionVolumeOffsets = Some "0 -2 -1"
          collisionVolumeScales = Some "34 68 38"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 94.5
              maxAcc = 0.253
              maxDec = 0.8211
              turnRate = 1214.40002
              movementClass = Some "ATANK3"
              maxSlope = Some 17.0
              maxWaterDepth = Some 32.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.98
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armmech_cannon"
                displayName = Some "Double close-quarters gauss cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 235.0
                    "vtol", 60.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.7)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "KroGun1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "5.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                    "targetmoveerror", "0.15"
                    "weapontimer", "2.0"
                ] }
              { name = "armamph_missile"
                displayName = Some "Guided g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 85.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 850.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 9000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rocklit1"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "1.75"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.95"
                    "smokeperiod", "5.0"
                    "smokesize", "4.4"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "650.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "48000.0"
                    "weaponacceleration", "200.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.882118225098 0.0283161499023 6.0887298584"
                collisionVolumeScales = Some "32.1447906494 31.2162322998 37.0860900879"
                collisionVolumeType = Some "Box"
                damage = Some 2400.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 592.0
                object_ = Some "Units/armmar_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1200.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 237.0
                object_ = Some "Units/arm3X3F.s3o"
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
              ok = ["mavbok1"]
              select = ["mavbsel1"] })
          customParams = Map.ofList [
              "i18nfromunit", "armmar"
              "model_author", "PtaQ"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmGantry"
              "techlevel", "3.0"
              "unitgroup", "weapon"
              "weapon1turretx", "90.0"
              "weapon1turrety", "150.0"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "970.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let armraz : UnitDef =
        { name = "armraz"
          subfolder = "ArmGantry"
          metalCost = ValueOrExpr.Concrete 3800.0
          energyCost = ValueOrExpr.Concrete 68000.0
          buildTime = ValueOrExpr.Concrete 120000.0
          health = ValueOrExpr.Concrete 13300.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMRAZ.s3o"
          buildPic = Some "ARMRAZ.DDS"
          script = Some "Units/armraz.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "55 80 55"
          collisionVolumeType = Some "CYLY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 69.0
              maxAcc = 0.2369
              maxDec = 0.9039
              turnRate = 600.0
              movementClass = Some "HBOT4"
              maxSlope = Some 15.0
              maxWaterDepth = Some 22.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.518
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "mech_rapidlaser"
                displayName = Some "Rapid-fire close quarters g2g armor-piercing laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 116.0
                    "vtol", 22.0
                ]
                range = Some (ValueOrExpr.Concrete 475.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.63333)
                weaponVelocity = Some 920.0
                areaOfEffect = Some 32.0
                accuracy = Some 32.0
                turret = Some true
                tolerance = Some 4500.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasfirerc"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-red"
                rgbColor = Some "0.75 0 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_burstcontrolwhenoutofarc", "2.0"
                    "mount_comment", "seems to have 40 deg burst limit arc limit w the burstcontrolwhenoutofarc = 2, fastautoretargeting, compounding"
                    "mount_fastautoretargeting", "true"
                    "mount_fastquerypointupdate", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamburst", "true"
                    "beamdecay", "1.0"
                    "beamtime", "0.07"
                    "burst", "6.0"
                    "burstrate", "0.06667"
                    "corethickness", "0.35"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "75.0"
                    "firestarter", "10.0"
                    "firetolerance", "3640.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.8"
                    "proximitypriority", "1.0"
                    "pulsespeed", "8.0"
                    "rgbcolor2", "0.9 0.9 0.6"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.4"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "61.6002807617 54.8114776611 71.5794219971"
                collisionVolumeType = Some "Box"
                damage = Some 1500.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 2325.0
                object_ = Some "Units/armraz_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 2000.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 930.0
                object_ = Some "Units/arm3X3B.s3o"
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
              ok = ["mavbok1"]
              select = ["mavbsel1"] })
          customParams = Map.ofList [
              "model_author", "PtaQ"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmGantry"
              "techlevel", "3.0"
              "unitgroup", "weapon"
              "weapon1turretx", "200.0"
              "weapon1turrety", "200.0"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "3800.0"
              "strafetoattack", "true"
              "upright", "true"
          ] }

    let armthor : UnitDef =
        { name = "armthor"
          subfolder = "ArmGantry"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 240000.0
          buildTime = ValueOrExpr.Concrete 320000.0
          health = ValueOrExpr.Concrete 56000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/ARMTHOR.s3o"
          buildPic = Some "ARMTHOR.DDS"
          script = Some "Units/ARMTHOR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3xl"
          selfDestructAs = Some "explosiont3xxl"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "58 34 58"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 54.0
              maxAcc = 0.015
              maxDec = 0.03
              turnRate = 180.0
              movementClass = Some "HTANK7"
              maxSlope = Some 14.0
              maxWaterDepth = Some 20.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.6
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "thunder"
                displayName = Some "Heavy Lighting Cannon"
                weaponType = Some "LightningCannon"
                damage = Map.ofList [
                    "default", 300.0
                    "subs", 30.0
                ]
                range = Some (ValueOrExpr.Concrete 540.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.1)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lghthvy1"
                soundHit = Some "lasrfir2"
                explosiongenerator = Some "custom:genericshellexplosion-large-lightning-thor"
                rgbColor = Some "0.5 0.5 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "spark_ceg", "genericshellexplosion-splash-large-lightning"
                    "spark_forkdamage", "0.25"
                    "spark_maxunits", "5"
                    "spark_range", "125"
                ]
                extras = Map.ofList [
                    "mount_burstcontrolwhenoutofarc", "2.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamttl", "1.0"
                    "burst", "10.0"
                    "burstrate", "0.03333"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "2.0"
                    "energypershot", "350.0"
                    "falloffrate", "0.5"
                    "firestarter", "50.0"
                    "hardstop", "false"
                    "impactonly", "1.0"
                    "intensity", "28.0"
                    "soundhitwet", "sizzle"
                    "soundtrigger", "true"
                    "thickness", "1.8"
                ] }
              { name = "empmissile"
                displayName = Some "Heavy long-range g2g EMP starburst rocket"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 80000.0
                ]
                range = Some (ValueOrExpr.Concrete 1050.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 196.0
                accuracy = None
                turret = Some true
                tolerance = Some 4000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "mismed1emp1"
                soundHit = Some "emgpuls1"
                explosiongenerator = Some "custom:genericshellexplosion-huge-lightning"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "cruisemissiletrail-emp"
                    "collidefriendly", "false"
                    "commandfire", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "5000.0"
                    "firestarter", "0.0"
                    "fixedlauncher", "true"
                    "flighttime", "12.0"
                    "interceptedbyshieldtype", "0.0"
                    "metalpershot", "100.0"
                    "model", "corshiprocket.s3o"
                    "paralyzer", "true"
                    "paralyzetime", "12.0"
                    "smoketrail", "false"
                    "startvelocity", "0.0"
                    "stockpile", "true"
                    "stockpiletime", "65.0"
                    "texture1", "null"
                    "texture2", "null"
                    "texture3", "null"
                    "turnrate", "20000.0"
                    "weaponacceleration", "75.0"
                    "weapontimer", "2.5"
                ] }
              { name = "emp"
                displayName = Some "Long Range EMP laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 300.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.25)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 1820.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "hackshot"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "-1 0 0"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "EMPABLE"
                    "avoidfeature", "false"
                    "beamdecay", "0.5"
                    "beamtime", "0.25"
                    "beamttl", "1.0"
                    "collidefriendly", "false"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.01"
                    "energypershot", "15.0"
                    "firetolerance", "1820.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "paralyzer", "true"
                    "paralyzetime", "8.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "1.2"
                ] }
              { name = "emp"
                displayName = Some "Long Range EMP laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 300.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.25)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 1820.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "hackshot"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "1 0 0"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "EMPABLE"
                    "avoidfeature", "false"
                    "beamdecay", "0.5"
                    "beamtime", "0.25"
                    "beamttl", "1.0"
                    "collidefriendly", "false"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.01"
                    "energypershot", "15.0"
                    "firetolerance", "1820.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "paralyzer", "true"
                    "paralyzetime", "8.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "1.2"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.01699066162 -0.66435255127 0.0775146484375"
                collisionVolumeScales = Some "31.8865509033 22.2328948975 29.3510131836"
                collisionVolumeType = Some "Box"
                damage = Some 25000.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 25.0
                metal = Some 5500.0
                object_ = Some "Units/armthor_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 10000.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 2750.0
                object_ = Some "Units/arm2X2D.s3o"
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
              ok = ["tarmmove"]
              select = ["tarmsel"] })
          customParams = Map.ofList [
              "lumamult", "0.7"
              "maxrange", "540"
              "model_author", "Flaka"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "ArmGantry"
              "techlevel", "3.0"
              "unitgroup", "emp"
          ]
          extras = Map.ofList [
              "canmanualfire", "true"
              "cantbetransported", "true"
              "leavetracks", "true"
              "mass", "9000.0"
              "nochasecategory", "VTOL"
              "trackoffset", "6.0"
              "trackstrength", "5.0"
              "tracktype", "armacv_tracks"
              "trackwidth", "60.0"
              "usepiececollisionvolumes", "1.0"
          ] }

    let armvang : UnitDef =
        { name = "armvang"
          subfolder = "ArmGantry"
          metalCost = ValueOrExpr.Concrete 3300.0
          energyCost = ValueOrExpr.Concrete 71000.0
          buildTime = ValueOrExpr.Concrete 120000.0
          health = ValueOrExpr.Concrete 8500.0
          sightDistance = ValueOrExpr.Concrete 625.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMVANG.s3o"
          buildPic = Some "ARMVANG.DDS"
          script = Some "Units/ARMVANG.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "65 60 65"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 33.0
              maxAcc = 0.02645
              maxDec = 0.345
              turnRate = 265.64999
              movementClass = Some "HTBOT6"
              maxSlope = Some 17.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.726
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "shocker_low"
                displayName = Some "Heavy long-range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "commanders", 1100.0
                    "default", 1265.0
                    "shields", 765.0
                    "subs", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 1450.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 192.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "cannhvy5"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-huge"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "avoidneutral", "true"
                    "cegtag", "arty-huge"
                    "collidefriendly", "false"
                    "craterareaofeffect", "192.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firetolerance", "5000.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "2.8"
                    "predictboost", "0.25"
                    "soundhitwet", "splslrg"
                ] }
              { name = "shocker_high"
                displayName = Some "Heavy long-range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "commanders", 1100.0
                    "default", 1265.0
                    "shields", 765.0
                    "subs", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 1450.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 192.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "cannhvy5"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-huge"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "cegtag", "arty-huge"
                    "collidefriendly", "false"
                    "craterareaofeffect", "192.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firetolerance", "5000.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "2.8"
                    "hightrajectory", "1.0"
                    "predictboost", "0.25"
                    "soundhitwet", "splslrg"
                ] }
              { name = "smart_trajectory_dummy"
                displayName = Some "Heavy long-range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1450.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 192.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "cannhvy5"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-huge"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "avoidneutral", "true"
                    "cegtag", "arty-huge"
                    "collidefriendly", "false"
                    "craterareaofeffect", "192.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firetolerance", "5000.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "2.8"
                    "predictboost", "0.25"
                    "soundhitwet", "splslrg"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-3.37104034424 -1.05229058838 1.8899307251"
                collisionVolumeScales = Some "64.0154266357 41.4324188232 55.433883667"
                collisionVolumeType = Some "Box"
                damage = Some 3000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 2028.0
                object_ = Some "Units/armvang_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 3015.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 811.0
                object_ = Some "Units/arm4X4D.s3o"
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
              ok = ["kbarmmov"]
              select = ["kbarmsel"] })
          customParams = Map.ofList [
              "model_author", "Flaka"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmGantry"
              "techlevel", "3.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "3300.0"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
          ] }

    let all : (string * UnitDef) list =
        [
            "armbanth", armbanth
            "armlun", armlun
            "armmar", armmar
            "armprowl", armprowl
            "armraz", armraz
            "armthor", armthor
            "armvang", armvang
        ]
