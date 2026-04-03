// Auto-generated BAR unit data: Legion/Utilities
namespace BarData.V1.Units

open BarData.V1

module Legion_Utilities =

    let legajam : UnitDef =
        { name = "legajam"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 19000.0
          buildTime = ValueOrExpr.Concrete 9100.0
          health = ValueOrExpr.Concrete 830.0
          sightDistance = ValueOrExpr.Concrete 155.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGAJAM.s3o"
          buildPic = Some "LEGAJAM.DDS"
          script = Some "Units/LEGAJAM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "54 102 51"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "oooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "54 102 51"
                collisionVolumeType = Some "CylY"
                damage = Some 450.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 77.0
                object_ = Some "Units/legajam_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 225.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 31.0
                object_ = Some "Units/arm2X2A.s3o"
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
              select = ["radjam1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/legajam_aoplane.dds"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Utilities"
              "techlevel", "2.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "canattack", "false"
              "energyupkeep", "125.0"
              "onoffable", "true"
              "radardistancejam", "760.0"
              "usepiececollisionvolumes", "1.0"
          ] }

    let legarad : UnitDef =
        { name = "legarad"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 14000.0
          buildTime = ValueOrExpr.Concrete 8000.0
          health = ValueOrExpr.Concrete 500.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGARAD.s3o"
          buildPic = Some "LEGARAD.DDS"
          script = Some "Units/LEGARAD.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "54 103 51"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "oooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "54 103 51"
                collisionVolumeType = Some "CylY"
                damage = Some 192.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 40.0
                metal = Some 341.0
                object_ = Some "Units/legarad_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 96.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 136.0
                object_ = Some "Units/arm2X2C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "cmd-on"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["radadvn1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/legarad_aoplane.dds"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Utilities"
              "techlevel", "2.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "canattack", "false"
              "onoffable", "false"
              "radardistance", "3500.0"
              "radaremitheight", "66.0"
              "sightemitheight", "40.0"
              "usepiececollisionvolumes", "0.0"
          ] }

    let legdeflector : UnitDef =
        { name = "legdeflector"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 3200.0
          energyCost = ValueOrExpr.Concrete 55000.0
          buildTime = ValueOrExpr.Concrete 55000.0
          health = ValueOrExpr.Concrete 3550.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGDEFLECTOR.s3o"
          buildPic = Some "LEGDEFLECTOR.DDS"
          script = Some "Units/LEGDEFLECTOR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "69 40 66"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "NOWEAPON"
          movement = None
          builder = None
          weapons = Some [
              { name = "repulsor"
                displayName = Some "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.empty
                range = None
                reloadTime = None
                weaponVelocity = None
                areaOfEffect = None
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = None
                noSelfDamage = None
                soundStart = None
                soundHit = None
                explosiongenerator = None
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "soundhitwet", "sizzle"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "69 40 66"
                collisionVolumeType = Some "CylY"
                damage = Some 1900.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2000.0
                object_ = Some "Units/legdeflector_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 960.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 800.0
                object_ = Some "Units/cor2X2E.s3o"
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
              ok = ["drone1"]
              select = ["drone1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "7.0"
              "buildinggrounddecalsizey", "7.0"
              "buildinggrounddecaltype", "decals/legdeflector_aoplane.dds"
              "model_author", "Gabs"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "shield_color_mult", "0.8"
              "shield_power", "6175.0"
              "shield_radius", "550.0"
              "subfolder", "CorBuildings/LandUtil"
              "techlevel", "2.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "onoffable", "true"
              "canattack", "false"
              "exemptcategory", "WEAPON"
              "noautofire", "true"
          ] }

    let legeyes : UnitDef =
        { name = "legeyes"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 32.0
          energyCost = ValueOrExpr.Concrete 850.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 280.0
          sightDistance = ValueOrExpr.Concrete 540.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/legeyes.s3o"
          buildPic = Some "legeyes.DDS"
          script = Some "Units/legeyes_clean.cob"
          corpse = Some "CDRAGONSEYES_DEAD"
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "20 24 20"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "o"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "cdragonseyes_dead",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = Some "-0.0323944091797 0.0 0.00588226318359"
                collisionVolumeScales = Some "21.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 120.0
                featureDead = None
                footprintX = Some 1.0
                footprintZ = Some 1.0
                height = Some 4.0
                metal = Some 12.0
                object_ = Some "Units/cor1X1A.s3o"
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
              ok = ["servsml6"]
              select = ["minesel2"] })
          customParams = Map.ofList [
              "unitgroup", "util"
              "model_author", "NebuchadnezzarII"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/utilities"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "cloakcost", "10.0"
              "energyupkeep", "5.0"
              "initcloaked", "true"
              "levelground", "false"
              "mincloakdistance", "36.0"
              "stealth", "true"
          ] }

    let legjam : UnitDef =
        { name = "legjam"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 140.0
          energyCost = ValueOrExpr.Concrete 7200.0
          buildTime = ValueOrExpr.Concrete 4570.0
          health = ValueOrExpr.Concrete 1070.0
          sightDistance = ValueOrExpr.Concrete 104.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGJAM.s3o"
          buildPic = Some "LEGJAM.DDS"
          script = Some "Units/LEGJAM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "30 84 30"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "oooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "30 84 30"
                collisionVolumeType = Some "CylY"
                damage = Some 576.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 3.0
                metal = Some 71.0
                object_ = Some "Units/legjam_dead.s3o"
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
              ok = ["kbcormov"]
              select = ["radjam2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legjam_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "util"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/utilities"
          ]
          extras = Map.ofList [
              "buildangle", "4400.0"
              "canattack", "false"
              "energyupkeep", "30.0"
              "onoffable", "true"
              "radardistancejam", "390.0"
          ] }

    let legjuno : UnitDef =
        { name = "legjuno"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 660.0
          energyCost = ValueOrExpr.Concrete 16000.0
          buildTime = ValueOrExpr.Concrete 27700.0
          health = ValueOrExpr.Concrete 2500.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legjuno.s3o"
          buildPic = Some "legjuno.DDS"
          script = Some "Units/legjuno.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "44 128 44"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "juno_pulse"
                displayName = Some "Anti-Radar/Jammer/Mine Electromagnetic Payload"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "mines", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 32000.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 1400.0
                accuracy = None
                turret = None
                tolerance = Some 4000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = Some "junofir2"
                soundHit = Some "junohit2"
                explosiongenerator = Some "custom:juno-explo"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "junotype", "base"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "castshadow", "true"
                    "cegtag", "missiletrail-juno"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "commandfire", "true"
                    "craterareaofeffect", "1400.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "12000.0"
                    "flighttime", "400.0"
                    "metalpershot", "200.0"
                    "model", "epulse.s3o"
                    "smokecolor", "0.7"
                    "smokeperiod", "8.0"
                    "smokesize", "14.0"
                    "smoketime", "45.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "stockpile", "true"
                    "stockpiletime", "75.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "5500.0"
                    "weaponacceleration", "75.0"
                    "weapontimer", "4.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "44 128 44"
                collisionVolumeType = Some "Box"
                damage = Some 1350.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 388.0
                object_ = Some "Units/legjuno_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 675.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 192.0
                object_ = Some "Units/cor4X4A.s3o"
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
              ok = ["drone1"]
              select = ["drone1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.4"
              "buildinggrounddecalsizey", "5.4"
              "buildinggrounddecaltype", "decals/legjuno_aoplane.dds"
              "model_author", "Georodin"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/Utilities"
              "unitgroup", "weapon"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "stealth", "true"
          ] }

    let legmine1 : UnitDef =
        { name = "legmine1"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 7.0
          energyCost = ValueOrExpr.Concrete 270.0
          buildTime = ValueOrExpr.Concrete 100.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 83.2
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/legmine1.s3o"
          buildPic = Some "legmine1.DDS"
          script = Some "mines_lus.lua"
          corpse = None
          explodeAs = Some "MINE_LIGHT"
          selfDestructAs = Some "MINE_LIGHT"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "15 10 15"
          collisionVolumeType = Some "cyly"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "minerange"
                displayName = Some "BOOM"
                weaponType = Some "Melee"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 64.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 100000.0
                areaOfEffect = Some 0.0
                accuracy = None
                turret = None
                tolerance = Some 1000000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = None
                soundHit = None
                explosiongenerator = Some ""
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "false"
                    "soundhitwet", ""
                    "soundhitwetvolume", "0.0"
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
              ok = ["servsml6"]
              select = ["minesel1"] })
          customParams = Map.ofList [
              "detonaterange", "64"
              "instantselfd", "true"
              "mine", "true"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Utilities"
              "unitgroup", "explo"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "false"
              "canguard", "false"
              "canpatrol", "false"
              "cloakcost", "1.0"
              "collide", "false"
              "firestate", "2.0"
              "initcloaked", "true"
              "levelground", "false"
              "mincloakdistance", "30.0"
              "nochasecategory", "VTOL"
              "selfdestructcountdown", "0.0"
              "stealth", "true"
          ] }

    let legmine2 : UnitDef =
        { name = "legmine2"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 1050.0
          buildTime = ValueOrExpr.Concrete 300.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 83.2
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/legmine2.s3o"
          buildPic = Some "legmine2.DDS"
          script = Some "mines_lus.lua"
          corpse = None
          explodeAs = Some "MINE_MEDIUM"
          selfDestructAs = Some "MINE_MEDIUM"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "15 10 15"
          collisionVolumeType = Some "cyly"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "minerange"
                displayName = Some "BOOM"
                weaponType = Some "Melee"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 64.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 100000.0
                areaOfEffect = Some 0.0
                accuracy = None
                turret = None
                tolerance = Some 1000000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = None
                soundHit = None
                explosiongenerator = Some ""
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "false"
                    "soundhitwet", ""
                    "soundhitwetvolume", "0.0"
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
              ok = ["servsml6"]
              select = ["minesel1"] })
          customParams = Map.ofList [
              "detonaterange", "64"
              "instantselfd", "true"
              "mine", "true"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Utilities"
              "unitgroup", "explo"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "false"
              "canguard", "false"
              "canpatrol", "false"
              "cloakcost", "2.0"
              "collide", "false"
              "firestate", "2.0"
              "initcloaked", "true"
              "levelground", "false"
              "mincloakdistance", "30.0"
              "nochasecategory", "VTOL"
              "selfdestructcountdown", "0.0"
              "stealth", "true"
          ] }

    let legmine3 : UnitDef =
        { name = "legmine3"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 50.0
          energyCost = ValueOrExpr.Concrete 2800.0
          buildTime = ValueOrExpr.Concrete 700.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 83.2
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/legmine3.s3o"
          buildPic = Some "legmine3.DDS"
          script = Some "mines_lus.lua"
          corpse = None
          explodeAs = Some "MINE_HEAVY"
          selfDestructAs = Some "MINE_HEAVY"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "15 10 15"
          collisionVolumeType = Some "cyly"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "minerange"
                displayName = Some "BOOM"
                weaponType = Some "Melee"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 64.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 100000.0
                areaOfEffect = Some 0.0
                accuracy = None
                turret = None
                tolerance = Some 1000000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = None
                soundHit = None
                explosiongenerator = Some ""
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firesubmersed", "false"
                    "soundhitwet", ""
                    "soundhitwetvolume", "0.0"
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
              ok = ["servsml6"]
              select = ["minesel1"] })
          customParams = Map.ofList [
              "detonaterange", "64"
              "instantselfd", "true"
              "mine", "true"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Utilities"
              "unitgroup", "explo"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "false"
              "canguard", "false"
              "canpatrol", "false"
              "cloakcost", "6.0"
              "collide", "false"
              "firestate", "2.0"
              "initcloaked", "true"
              "levelground", "false"
              "mincloakdistance", "30.0"
              "nochasecategory", "VTOL"
              "selfdestructcountdown", "0.0"
              "stealth", "true"
          ] }

    let legnanotc : UnitDef =
        { name = "legnanotc"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 5300.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGNANOTC.s3o"
          buildPic = Some "LEGNANOTC.DDS"
          script = Some "Units/LEGNANOTC.cob"
          corpse = None
          explodeAs = Some "nanoboom"
          selfDestructAs = Some "nanoselfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "31 32 31"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vcormove"]
              select = ["vcorsel"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legnanotc_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "builder"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorBuildings/LandUtil"
          ]
          extras = Map.ofList [
              "canassist", "true"
              "canfight", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canreclaim", "true"
              "canstop", "true"
              "cantbetransported", "false"
              "leavesghost", "true"
              "mass", "700.0"
              "upright", "true"
          ] }

    let legnanotcplat : UnitDef =
        { name = "legnanotcplat"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 5300.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGNANOTCPLAT.s3o"
          buildPic = Some "legnanotcplat.DDS"
          script = Some "Units/CORNANOTCPLAT.cob"
          corpse = None
          explodeAs = Some "nanoboom"
          selfDestructAs = Some "nanoselfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "31 50 31"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vcormove"]
              select = ["vcorsel"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/legnanotc_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "builder"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorBuildings/SeaUtil"
          ]
          extras = Map.ofList [
              "canassist", "true"
              "canfight", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canreclaim", "true"
              "canstop", "true"
              "cantbetransported", "true"
              "leavesghost", "true"
              "mass", "700.0"
              "upright", "true"
          ] }

    let legnanotct2 : UnitDef =
        { name = "legnanotct2"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 840.0
          energyCost = ValueOrExpr.Concrete 12800.0
          buildTime = ValueOrExpr.Concrete 21000.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legnanotct2.s3o"
          buildPic = Some "legnanotc.DDS"
          script = Some "Units/LEGNANOTCTEMP.cob"
          corpse = None
          explodeAs = Some "nanoboom"
          selfDestructAs = Some "nanoselfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "46 80 46"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
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
              ok = ["varmmove"]
              select = ["varmsel"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legnanotct2_aoplane.dds"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "builder"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorBuildings/LandUtil"
          ]
          extras = Map.ofList [
              "canassist", "true"
              "canfight", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canreclaim", "true"
              "canstop", "true"
              "cantbetransported", "false"
              "leavesghost", "true"
              "mass", "5100.0"
              "upright", "true"
          ] }

    let legnanotct2plat : UnitDef =
        { name = "legnanotct2plat"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 840.0
          energyCost = ValueOrExpr.Concrete 12800.0
          buildTime = ValueOrExpr.Concrete 21000.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legnanotct2plat.s3o"
          buildPic = Some "legnanotcplat.DDS"
          script = Some "Units/cornanotcplat.cob"
          corpse = None
          explodeAs = Some "nanoboom"
          selfDestructAs = Some "nanoselfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "46 80 46"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
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
              ok = ["varmmove"]
              select = ["varmsel"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legnanotct2_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "builder"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorBuildings/LandUtil"
          ]
          extras = Map.ofList [
              "canassist", "true"
              "canfight", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canreclaim", "true"
              "canstop", "true"
              "cantbetransported", "false"
              "leavesghost", "true"
              "mass", "5100.0"
              "upright", "true"
          ] }

    let legrad : UnitDef =
        { name = "legrad"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 60.0
          energyCost = ValueOrExpr.Concrete 630.0
          buildTime = ValueOrExpr.Concrete 1140.0
          health = ValueOrExpr.Concrete 180.0
          sightDistance = ValueOrExpr.Concrete 680.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGRAD.s3o"
          buildPic = Some "LEGRAD.DDS"
          script = Some "Units/LEGRAD.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -12 0"
          collisionVolumeScales = Some "32 99 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "oooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -12 0"
                collisionVolumeScales = Some "32 99 32"
                collisionVolumeType = Some "CylY"
                damage = Some 49.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 36.0
                object_ = Some "Units/legrad_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 25.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 14.0
                object_ = Some "Units/cor2X2D.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "cmd-on"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["radarselect"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legrad_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "util"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/utilities"
          ]
          extras = Map.ofList [
              "buildangle", "16000.0"
              "canattack", "false"
              "cantbetransported", "false"
              "sightemitheight", "72.0"
              "mass", "5100.0"
              "onoffable", "false"
              "radardistance", "2100.0"
              "radaremitheight", "72.0"
          ] }

    let legsd : UnitDef =
        { name = "legsd"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 710.0
          energyCost = ValueOrExpr.Concrete 7100.0
          buildTime = ValueOrExpr.Concrete 11900.0
          health = ValueOrExpr.Concrete 2650.0
          sightDistance = ValueOrExpr.Concrete 240.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGSD.s3o"
          buildPic = Some "LEGSD.DDS"
          script = Some "Units/LEGSD.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "76 42 52"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "76 42 52"
                collisionVolumeType = Some "CylY"
                damage = Some 1440.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 15.0
                metal = Some 566.0
                object_ = Some "Units/legsd_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 720.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 227.0
                object_ = Some "Units/arm4X4A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "cmd-on"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["targsel1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "7.0"
              "buildinggrounddecalsizey", "7.0"
              "buildinggrounddecaltype", "decals/legsd_aoplane.dds"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Utilities"
              "techlevel", "2.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "energyupkeep", "125.0"
              "levelground", "false"
              "onoffable", "true"
              "seismicdistance", "2000.0"
          ] }

    let legtarg : UnitDef =
        { name = "legtarg"
          subfolder = "Legion/Utilities"
          metalCost = ValueOrExpr.Concrete 810.0
          energyCost = ValueOrExpr.Concrete 7200.0
          buildTime = ValueOrExpr.Concrete 8700.0
          health = ValueOrExpr.Concrete 2100.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGTARG.s3o"
          buildPic = Some "LEGTARG.DDS"
          script = Some "Units/LEGTARG.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "60 101 52"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "ooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "60 101 52"
                collisionVolumeType = Some "CylY"
                damage = Some 1140.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 492.0
                object_ = Some "Units/legtarg_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 570.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 197.0
                object_ = Some "Units/arm4X4A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "cmd-on"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["targsel1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/legtarg_aoplane.dds"
              "model_author", "Protar & ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "Legion/Utilities"
              "techlevel", "2.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "energyupkeep", "100.0"
              "istargetingupgrade", "true"
              "onoffable", "true"
          ] }

    let all : (string * UnitDef) list =
        [
            "legajam", legajam
            "legarad", legarad
            "legdeflector", legdeflector
            "legeyes", legeyes
            "legjam", legjam
            "legjuno", legjuno
            "legmine1", legmine1
            "legmine2", legmine2
            "legmine3", legmine3
            "legnanotc", legnanotc
            "legnanotcplat", legnanotcplat
            "legnanotct2", legnanotct2
            "legnanotct2plat", legnanotct2plat
            "legrad", legrad
            "legsd", legsd
            "legtarg", legtarg
        ]
