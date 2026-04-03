// Auto-generated BAR unit data: Legion/SeaDefenses
namespace BarData.V1.Units

open BarData.V1

module Legion_SeaDefenses =

    let legctl : UnitDef =
        { name = "legctl"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 2200.0
          buildTime = ValueOrExpr.Concrete 5900.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 617.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legctl.s3o"
          buildPic = Some "legctl.DDS"
          script = Some "Units/legctl.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingExplosionGeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "38 46 40"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "torplauncher"
                displayName = Some "Homing Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 225.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 300.0
                areaOfEffect = None
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSUB"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "bouncerebound", "0.6"
                    "bounceslip", "0.6"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.75"
                    "gravityaffected", "true"
                    "groundbounce", "true"
                    "model", "legbasictorpedo.s3o"
                    "mygravity", "0.2"
                    "numbounce", "1.0"
                    "soundhitvolume", "3.0"
                    "soundhitwet", "splsmed"
                    "soundhitwetvolume", "12.0"
                    "startvelocity", "190.0"
                    "tracks", "true"
                    "trajectoryheight", "0.6"
                    "turnrate", "64000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "75.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "yyyyyooyyooyyyyy"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "38 46 40"
                collisionVolumeType = Some "Box"
                damage = Some 609.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 30.0
                metal = Some 176.0
                object_ = Some "Units/legctl_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 305.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 70.0
                object_ = Some "Units/arm3X3C.s3o"
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
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/SeaDefenses"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "sonardistance", "600.0"
          ] }

    let legfdrag : UnitDef =
        { name = "legfdrag"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 15.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 400.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legfdrag.s3o"
          buildPic = Some "legfdrag.DDS"
          script = Some "Units/legfdrag.cob"
          corpse = None
          explodeAs = Some "WallExplosionWater"
          selfDestructAs = Some "WallExplosionWater"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "36 14 36"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "oooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "objectify", "true"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/SeaDefenses"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "buildangle", "8192.0"
              "canattack", "false"
              "crushresistance", "250.0"
              "hidedamage", "true"
              "repairable", "false"
              "selfdestructcountdown", "1.0"
          ] }

    let legfhive : UnitDef =
        { name = "legfhive"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 350.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 7500.0
          health = ValueOrExpr.Concrete 1200.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legfhive.s3o"
          buildPic = Some "legfhive.DDS"
          script = Some "Units/leghive.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -7 0"
          collisionVolumeScales = Some "44 23 44"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 4.5
              turnRate = 1.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 12.0
              waterline = Some 4.0 })
          builder = None
          weapons = Some [
              { name = "plasma"
                displayName = Some "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1100.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 4.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some ""
                soundHit = Some ""
                explosiongenerator = Some ""
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "carried_unit", "legdrone"
                    "spawns_surface", "SEA"
                    "carrierdeaththroe", "release"
                    "dockingpieces", "4 5 6 7 8 9"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "metalpershot", "15.0"
                    "energypershot", "500.0"
                    "size", "0.0"
                    "soundhitwet", ""
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "38 95 38"
                collisionVolumeType = Some "CylY"
                damage = Some 700.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 130.0
                object_ = Some "Units/leghive_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 400.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 65.0
                object_ = Some "Units/cor2X2A.s3o"
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
              ok = ["twractv3"]
              select = ["twractv3"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/armnanotc_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "model_author", "Zephyr"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "legacyname", "Gaat Gun"
              "inheritxpratemultiplier", "1.0"
              "childreninheritxp", "DRONE"
              "parentsinheritxp", "DRONE"
              "restrictions_inclusion", "_noair_"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "mass", "700.0"
              "nochasecategory", "MOBILE"
              "upright", "true"
          ] }

    let legfmg : UnitDef =
        { name = "legfmg"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 5500.0
          buildTime = ValueOrExpr.Concrete 7600.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 525.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legfmg.s3o"
          buildPic = Some "legfmg.DDS"
          script = Some "Units/legfmg.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -8 0"
          collisionVolumeScales = Some "36 90 36"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "gatling_gun"
                displayName = Some "Rapid-Fire Gatling Gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 18.0
                    "vtol", 18.0
                ]
                range = Some (ValueOrExpr.Concrete 575.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 958.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun6heavy"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.066"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.038"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "4.5"
                    "soundtrigger", "true"
                    "sprayangle", "968.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "3.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.45989990234 -3.69362253418 0.310646057129"
                collisionVolumeScales = Some "48.9197998047 59.9625549316 37.0396270752"
                collisionVolumeType = Some "Box"
                damage = Some 774.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 50.0
                metal = Some 114.0
                object_ = Some "Units/legfmg_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "unitgroup", "weaponaa"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/SeaDefenses"
          ]
          extras = Map.ofList [
              "airsightdistance", "650.0"
              "buildangle", "32768.0"
              "cantbetransported", "false"
              "levelground", "false"
              "mass", "7500.0"
          ] }

    let legfrl : UnitDef =
        { name = "legfrl"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 2200.0
          health = ValueOrExpr.Concrete 380.0
          sightDistance = ValueOrExpr.Concrete 468.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legfrl.s3o"
          buildPic = Some "legfrl.DDS"
          script = Some "Units/legfrl.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "26 52 26"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "legrl_missile"
                displayName = Some "Light g2a Missile Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 115.0
                ]
                range = Some (ValueOrExpr.Concrete 765.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 750.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rockhvy2"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOWEAPON LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "1.9"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "6.0"
                    "smoketime", "12.0"
                    "smokesize", "4.8"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "400.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "63000.0"
                    "weaponacceleration", "150.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "wwwwwwwwwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "26 52 26"
                collisionVolumeType = Some "Box"
                damage = Some 151.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 40.0
                metal = Some 46.0
                object_ = Some "Units/legfrl_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/SeaDefenses"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "750.0"
              "buildangle", "16384.0"
              "nochasecategory", "ALL"
          ] }

    let legnavaldefturret : UnitDef =
        { name = "legnavaldefturret"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 600.0
          energyCost = ValueOrExpr.Concrete 7500.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 5190.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/legnavaldefturret.s3o"
          buildPic = Some "legnavaldefturret.DDS"
          script = Some "Units/legnavaldefturret.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "70 50 70"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "leg_med_anti_naval_salvo_rocket"
                displayName = Some "Dual-Salvo Medium Rocket Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 95.0
                ]
                range = Some (ValueOrExpr.Concrete 720.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 100.0
                accuracy = None
                turret = Some true
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.2
                impulseFactor = Some 0.185
                noSelfDamage = Some true
                soundStart = Some "SabotFire"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "avoidfeature", "false"
                    "burst", "4.0"
                    "burstrate", "0.185"
                    "cegtag", "missiletrailsmall-simple"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "dance", "10.0"
                    "flighttime", "5.0"
                    "firestarter", "70.0"
                    "intensity", "2.25"
                    "metalpershot", "0.0"
                    "model", "legmediumrocket.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "11.0"
                    "smoketime", "28.0"
                    "smokesize", "3.3"
                    "smokecolor", "1.0"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "true"
                    "soundhitwet", "splshbig"
                    "startvelocity", "300.0"
                    "texture1", "null"
                    "texture2", "smoketraildark"
                    "tracks", "true"
                    "turnrate", "3000.0"
                    "firetolerance", "7000.0"
                    "weaponacceleration", "150.0"
                    "weapontimer", "10.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ooooooooooooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "70 50 70"
                collisionVolumeType = Some "CylY"
                damage = Some 2500.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 50.0
                metal = Some 350.0
                object_ = Some "Units/legnavaldefturret_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "unitgroup", "weapon"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/SeaDefenses"
          ]
          extras = Map.ofList [
              "airsightdistance", "650.0"
              "buildangle", "32768.0"
              "mass", "9500.0"
          ] }

    let legtl : UnitDef =
        { name = "legtl"
          subfolder = "Legion/SeaDefenses"
          metalCost = ValueOrExpr.Concrete 170.0
          energyCost = ValueOrExpr.Concrete 1500.0
          buildTime = ValueOrExpr.Concrete 3700.0
          health = ValueOrExpr.Concrete 1300.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legtl.s3o"
          buildPic = Some "legtl.DDS"
          script = Some "Units/legtl.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "14 43 30"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "torpedo"
                displayName = Some "Torpedo Launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 280.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 280.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "legbasictorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "wwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "14 43 30"
                collisionVolumeType = Some "Box"
                damage = Some 870.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 70.0
                object_ = Some "Units/legtl_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/SeaDefenses"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "sonardistance", "400.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "legctl", legctl
            "legfdrag", legfdrag
            "legfhive", legfhive
            "legfmg", legfmg
            "legfrl", legfrl
            "legnavaldefturret", legnavaldefturret
            "legtl", legtl
        ]
