// Auto-generated BAR unit data: ArmBuildings/SeaUtil
namespace BarData.Units

open BarData

module ArmBuildings_SeaUtil =

    let armason : UnitDef =
        { name = "armason"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 170.0
          energyCost = ValueOrExpr.Concrete 2600.0
          buildTime = ValueOrExpr.Concrete 6150.0
          health = ValueOrExpr.Concrete 2350.0
          sightDistance = ValueOrExpr.Concrete 215.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMASON.s3o"
          buildPic = Some "ARMASON.DDS"
          script = Some "Units/ARMASON.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric-uw"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "yooy oooo oooo yooy"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-2.53617095947 -6.10351563068e-07 -2.30155944824"
                collisionVolumeScales = Some "30.2144622803 57.7799987793 23.5352478027"
                collisionVolumeType = Some "Box"
                damage = Some 1272.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 106.0
                object_ = Some "Units/armason_dead.s3o"
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
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["sonar1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/armason_aoplane.dds"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaUtil"
              "techlevel", "2.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "canattack", "false"
              "onoffable", "false"
              "sonardistance", "1600.0"
          ] }

    let armfatf : UnitDef =
        { name = "armfatf"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 800.0
          energyCost = ValueOrExpr.Concrete 7300.0
          buildTime = ValueOrExpr.Concrete 9880.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMFATF.s3o"
          buildPic = Some "ARMFATF.DDS"
          script = Some "Units/ARMFATF.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -10 0"
          collisionVolumeScales = Some "52 44 52"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "wwwwwwwwwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "1.36531829834 -6.85653535156 1.18824005127"
                collisionVolumeScales = Some "59.4412994385 29.0925292969 58.6490936279"
                collisionVolumeType = Some "Box"
                damage = Some 871.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 467.0
                object_ = Some "Units/armfatf_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 436.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 187.0
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
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaUtil"
              "techlevel", "2.0"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "buildangle", "16400.0"
              "energyupkeep", "150.0"
              "istargetingupgrade", "true"
              "onoffable", "true"
          ] }

    let armfdrag : UnitDef =
        { name = "armfdrag"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 15.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 370.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMFDRAG.s3o"
          buildPic = Some "ARMFDRAG.DDS"
          script = Some "Units/ARMFDRAG.cob"
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
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "objectify", "true"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaUtil"
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

    let armfgate : UnitDef =
        { name = "armfgate"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 3900.0
          energyCost = ValueOrExpr.Concrete 72000.0
          buildTime = ValueOrExpr.Concrete 59000.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/armfgate.s3o"
          buildPic = Some "ARMFGATE.DDS"
          script = Some "Units/armfgate.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -30 0"
          collisionVolumeScales = Some "53 65 53"
          collisionVolumeType = Some "cyly"
          seismicSignature = Some 0.0
          category = Some "NOWEAPON"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = None
              canFly = false
              canMove = false
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.0
              cruiseAltitude = None
              minWaterDepth = Some 16.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "sea_repulsor"
                displayName = Some "NavalPlasmaRepulsor"
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
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -2.91625976558e-05 -0.414924621582"
                collisionVolumeScales = Some "57.2399902344 32.5033416748 63.3298492432"
                collisionVolumeType = Some "Box"
                damage = Some 1800.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2296.0
                object_ = Some "Units/armfgate_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 900.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 918.0
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
              ok = ["drone1"]
              select = ["drone1"] })
          customParams = Map.ofList [
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "shield_color_mult", "0.8"
              "shield_power", "9500.0"
              "shield_radius", "600.0"
              "subfolder", "ArmBuildings/SeaUtil"
              "techlevel", "2.0"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "onoffable", "true"
              "canattack", "false"
              "exemptcategory", "WEAPON"
              "noautofire", "true"
              "norestrict", "1.0"
              "unitname", "armfgate"
          ] }

    let armfmine3 : UnitDef =
        { name = "armfmine3"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 32.0
          energyCost = ValueOrExpr.Concrete 1600.0
          buildTime = ValueOrExpr.Concrete 400.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 78.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/ARMFMINE3.s3o"
          buildPic = Some "ARMFMINE3.DDS"
          script = Some "mines_lus.lua"
          corpse = None
          explodeAs = Some "FMINE_HEAVY"
          selfDestructAs = Some "FMINE_HEAVY"
          collisionVolumeOffsets = Some "0 -1.5 0"
          collisionVolumeScales = Some "18 5 18"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "minerange"
                displayName = Some "Crawlingbomb Dummy Weapon"
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
          building = Some (
            { yardMap = Some "w"
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
              ok = ["servsml6"]
              select = ["minesel1"] })
          customParams = Map.ofList [
              "detonaterange", "64"
              "instantselfd", "true"
              "mine", "true"
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaUtil"
              "unitgroup", "explo"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "false"
              "canguard", "false"
              "canpatrol", "false"
              "cloakcost", "4.0"
              "collide", "false"
              "firestate", "2.0"
              "initcloaked", "true"
              "mincloakdistance", "8.0"
              "nochasecategory", "VTOL"
              "selfdestructcountdown", "0.0"
              "sonarstealth", "true"
              "stealth", "true"
          ] }

    let armfrad : UnitDef =
        { name = "armfrad"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 130.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 1800.0
          health = ValueOrExpr.Concrete 110.0
          sightDistance = ValueOrExpr.Concrete 760.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMFRAD.s3o"
          buildPic = Some "ARMFRAD.DDS"
          script = Some "Units/ARMFRAD.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 5 0"
          collisionVolumeScales = Some "36 59 36"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "wwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -14.8080587891 -0.125"
                collisionVolumeScales = Some "45.9999694824 25.4694824219 42.75"
                collisionVolumeType = Some "Box"
                damage = Some 59.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 40.0
                metal = Some 83.0
                object_ = Some "Units/armfrad_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaUtil"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "canattack", "false"
              "onoffable", "false"
              "radardistance", "2100.0"
              "radaremitheight", "52.0"
              "sightemitheight", "52.0"
              "sonardistance", "900.0"
          ] }

    let armnanotc2plat : UnitDef =
        { name = "armnanotc2plat"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 840.0
          energyCost = ValueOrExpr.Concrete 12800.0
          buildTime = ValueOrExpr.Concrete 21000.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/armnanotc2plat.s3o"
          buildPic = Some "armnanotc2plat.DDS"
          script = Some "Units/armnanotc2plat.cob"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/armnanotc_aoplane.dds"
              "model_author", "Beherith, Hornet"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/SeaUtil"
              "unitgroup", "builder"
              "usebuildinggrounddecal", "true"
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

    let armnanotcplat : UnitDef =
        { name = "armnanotcplat"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 5300.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMNANOTCPLAT.s3o"
          buildPic = Some "ARMNANOTCPLAT.DDS"
          script = Some "Units/ARMNANOTCPLAT.cob"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/armnanotc_aoplane.dds"
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/SeaUtil"
              "unitgroup", "builder"
              "usebuildinggrounddecal", "false"
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

    let armsonar : UnitDef =
        { name = "armsonar"
          subfolder = "ArmBuildings/SeaUtil"
          metalCost = ValueOrExpr.Concrete 20.0
          energyCost = ValueOrExpr.Concrete 450.0
          buildTime = ValueOrExpr.Concrete 910.0
          health = ValueOrExpr.Concrete 56.0
          sightDistance = ValueOrExpr.Concrete 515.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMSONAR.s3o"
          buildPic = Some "ARMSONAR.DDS"
          script = Some "Units/ARMSONAR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric-uw"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "28 41 28"
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
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -1.56127929678e-05 -0.0"
                collisionVolumeScales = Some "31.3499755859 42.5373687744 28.2463684082"
                collisionVolumeType = Some "Box"
                damage = Some 30.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 13.0
                object_ = Some "Units/armsonar_dead.s3o"
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
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["sonar1"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaUtil"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "canattack", "false"
              "onoffable", "false"
              "sonardistance", "1200.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "armason", armason
            "armfatf", armfatf
            "armfdrag", armfdrag
            "armfgate", armfgate
            "armfmine3", armfmine3
            "armfrad", armfrad
            "armnanotc2plat", armnanotc2plat
            "armnanotcplat", armnanotcplat
            "armsonar", armsonar
        ]
