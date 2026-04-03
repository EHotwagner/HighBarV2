// Auto-generated BAR unit data: ArmBuildings/LandUtil
namespace BarData.V1.Units

open BarData.V1

module ArmBuildings_LandUtil =

    let armarad : UnitDef =
        { name = "armarad"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 14000.0
          buildTime = ValueOrExpr.Concrete 8000.0
          health = ValueOrExpr.Concrete 500.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMARAD.s3o"
          buildPic = Some "ARMARAD.DDS"
          script = Some "Units/ARMARAD.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 80 32"
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
                collisionVolumeOffsets = Some "6.23959350586 -0.334806103516 -0.00547027587891"
                collisionVolumeScales = Some "37.4791870117 33.549987793 30.0109405518"
                collisionVolumeType = Some "Box"
                damage = Some 192.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 40.0
                metal = Some 341.0
                object_ = Some "Units/armarad_dead.s3o"
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
              "buildinggrounddecalsizex", "3.6"
              "buildinggrounddecalsizey", "3.6"
              "buildinggrounddecaltype", "decals/armarad_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
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

    let armdf : UnitDef =
        { name = "armdf"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 270.0
          energyCost = ValueOrExpr.Concrete 100.0
          buildTime = ValueOrExpr.Concrete 7500.0
          health = ValueOrExpr.Concrete 3800.0
          sightDistance = ValueOrExpr.Concrete 210.0
          footprintX = 6.0
          footprintZ = 5.0
          objectName = Some "Units/ARMFUS.s3o"
          buildPic = Some "ARMDF.DDS"
          script = Some "Units/ARMFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 -2"
          collisionVolumeScales = Some "91 57 59"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "oooooo oooooo oooooo oooooo oooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.420112609863 0.0956184448242 -0.353080749512"
                collisionVolumeScales = Some "98.7820892334 38.6634368896 65.8547515869"
                collisionVolumeType = Some "Box"
                damage = Some 2790.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 222.0
                object_ = Some "Units/armfus_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1395.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 89.0
                object_ = Some "Units/arm4X4A.s3o"
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
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["fusion1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecaltype", "decals/armfus_aoplane.dds"
              "decoyfor", "armfus"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
              "techlevel", "2.0"
              "unitgroup", "util"
              "restrictions_inclusion", "_nofusion_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "decoyfor", "armfus"
              "hidedamage", "true"
          ] }

    let armdrag : UnitDef =
        { name = "armdrag"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 8.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/armdrag.s3o"
          buildPic = Some "ARMDRAG.DDS"
          script = Some "Units/armdrag.cob"
          corpse = Some "ROCKTEETH"
          explodeAs = Some "WallExplosionMetal"
          selfDestructAs = Some "WallExplosionMetal"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 22 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "rockteeth",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2.0
                object_ = Some "Units/arm1X1B.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = None
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecaltype", "decals/armdrag_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "objectify", "true"
              "paralyzemultiplier", "0.0"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "crushresistance", "250.0"
              "hidedamage", "true"
              "levelground", "false"
              "repairable", "false"
              "selfdestructcountdown", "1.0"
          ] }

    let armeyes : UnitDef =
        { name = "armeyes"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 32.0
          energyCost = ValueOrExpr.Concrete 850.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 280.0
          sightDistance = ValueOrExpr.Concrete 560.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/ARMEYES.s3o"
          buildPic = Some "ARMEYES.DDS"
          script = Some "Units/ARMEYES.cob"
          corpse = Some "DRAGONSEYES_DEAD"
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "20 32 20"
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
              "dragonseyes_dead",
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
                object_ = Some "Units/arm1X1A.s3o"
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
              select = ["minesel1"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "cloakcost", "10.0"
              "energyupkeep", "3.0"
              "initcloaked", "true"
              "levelground", "false"
              "mincloakdistance", "36.0"
              "stealth", "true"
          ] }

    let armfort : UnitDef =
        { name = "armfort"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 500.0
          buildTime = ValueOrExpr.Concrete 900.0
          health = ValueOrExpr.Concrete 8900.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMFORT.s3o"
          buildPic = Some "ARMFORT.DDS"
          script = Some "Units/ARMFORT.cob"
          corpse = Some "ROCKTEETHX"
          explodeAs = Some "WallExplosionMetalXL"
          selfDestructAs = Some "WallExplosionMetal"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "32 50 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "rockteethx",
              { blocking = Some true
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 3000.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 7.0
                object_ = Some "Units/arm1X1A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = None
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecaltype", "decals/armfort_aoplane.dds"
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "objectify", "true"
              "paralyzemultiplier", "0.0"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
              "techlevel", "2.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "buildangle", "0.0"
              "canattack", "false"
              "crushresistance", "1000.0"
              "hidedamage", "true"
              "levelground", "false"
              "repairable", "false"
              "selfdestructcountdown", "1.0"
          ] }

    let armgate : UnitDef =
        { name = "armgate"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 3000.0
          energyCost = ValueOrExpr.Concrete 54000.0
          buildTime = ValueOrExpr.Concrete 55000.0
          health = ValueOrExpr.Concrete 3550.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMGATE.s3o"
          buildPic = Some "ARMGATE.DDS"
          script = Some "Units/ARMGATE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 1"
          collisionVolumeScales = Some "57 37 57"
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
                collisionVolumeOffsets = Some "0.0 -2.91625976558e-05 -0.414924621582"
                collisionVolumeScales = Some "57.2399902344 32.5033416748 63.3298492432"
                collisionVolumeType = Some "Box"
                damage = Some 1900.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2000.0
                object_ = Some "Units/armgate_dead.s3o"
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
                metal = Some 800.0
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/armgate_aoplane.dds"
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "shield_color_mult", "0.8"
              "shield_power", "6175.0"
              "shield_radius", "550.0"
              "subfolder", "ArmBuildings/LandUtil"
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

    let armjamt : UnitDef =
        { name = "armjamt"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 8500.0
          buildTime = ValueOrExpr.Concrete 9950.0
          health = ValueOrExpr.Concrete 790.0
          sightDistance = ValueOrExpr.Concrete 195.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMJAMT.s3o"
          buildPic = Some "ARMJAMT.DDS"
          script = Some "Units/ARMJAMT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 82 32"
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
                collisionVolumeOffsets = Some "-7.62939453125e-06 -2.49999949951 -0.0"
                collisionVolumeScales = Some "28.2096405029 67.270401001 28.2096252441"
                collisionVolumeType = Some "Box"
                damage = Some 427.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 3.0
                metal = Some 147.0
                object_ = Some "Units/armjamt_dead.s3o"
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
              select = ["radjam1"] })
          customParams = Map.ofList [
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "buildangle", "4400.0"
              "canattack", "false"
              "energyupkeep", "40.0"
              "onoffable", "true"
              "radardistancejam", "500.0"
          ] }

    let armmine1 : UnitDef =
        { name = "armmine1"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 7.0
          energyCost = ValueOrExpr.Concrete 270.0
          buildTime = ValueOrExpr.Concrete 100.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 83.2
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/ARMMINE1.s3o"
          buildPic = Some "ARMMINE1.DDS"
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
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
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

    let armmine2 : UnitDef =
        { name = "armmine2"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 1050.0
          buildTime = ValueOrExpr.Concrete 300.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 83.2
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/ARMMINE2.s3o"
          buildPic = Some "ARMMINE2.DDS"
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
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
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

    let armmine3 : UnitDef =
        { name = "armmine3"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 50.0
          energyCost = ValueOrExpr.Concrete 2800.0
          buildTime = ValueOrExpr.Concrete 700.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 83.2
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/ARMMINE3.s3o"
          buildPic = Some "ARMMINE3.DDS"
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
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
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

    let armnanotc : UnitDef =
        { name = "armnanotc"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 5300.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMNANOTC.s3o"
          buildPic = Some "ARMNANOTC.DDS"
          script = Some "Units/ARMNANOTC.cob"
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
              "subfolder", "ArmBuildings/LandUtil"
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
              "mass", "700.0"
              "upright", "true"
          ] }

    let armnanotct2 : UnitDef =
        { name = "armnanotct2"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 840.0
          energyCost = ValueOrExpr.Concrete 12800.0
          buildTime = ValueOrExpr.Concrete 21000.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMNANOT2.s3o"
          buildPic = Some "ARMNANOTC.DDS"
          script = Some "Units/ARMNANOT2.cob"
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
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/LandUtil"
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

    let armrad : UnitDef =
        { name = "armrad"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 60.0
          energyCost = ValueOrExpr.Concrete 630.0
          buildTime = ValueOrExpr.Concrete 1140.0
          health = ValueOrExpr.Concrete 180.0
          sightDistance = ValueOrExpr.Concrete 680.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMRAD.s3o"
          buildPic = Some "ARMRAD.DDS"
          script = Some "Units/ARMRAD.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 115 32"
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
                collisionVolumeOffsets = Some "-1.52809143066 -0.0377662597656 8.02375793457"
                collisionVolumeScales = Some "46.8276062012 74.2716674805 38.2336730957"
                collisionVolumeType = Some "Box"
                damage = Some 49.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 35.0
                object_ = Some "Units/armrad_dead.s3o"
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
                object_ = Some "Units/arm2X2A.s3o"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecaltype", "decals/armrad_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "canattack", "false"
              "cantbetransported", "false"
              "mass", "5100.0"
              "onoffable", "false"
              "radardistance", "2100.0"
              "radaremitheight", "66.0"
              "sightemitheight", "66.0"
              "usepiececollisionvolumes", "0.0"
          ] }

    let armsd : UnitDef =
        { name = "armsd"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 710.0
          energyCost = ValueOrExpr.Concrete 7100.0
          buildTime = ValueOrExpr.Concrete 11900.0
          health = ValueOrExpr.Concrete 2650.0
          sightDistance = ValueOrExpr.Concrete 240.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMSD.s3o"
          buildPic = Some "ARMSD.DDS"
          script = Some "Units/ARMSD.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -6 0"
          collisionVolumeScales = Some "75 23 75"
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
                collisionVolumeOffsets = Some "1.95468139648 -4.13748790283 4.81853485107"
                collisionVolumeScales = Some "63.6464233398 24.2004241943 64.3273773193"
                collisionVolumeType = Some "Box"
                damage = Some 1440.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 15.0
                metal = Some 566.0
                object_ = Some "Units/armsd_dead.s3o"
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
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/armsd_aoplane.dds"
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
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

    let armtarg : UnitDef =
        { name = "armtarg"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 810.0
          energyCost = ValueOrExpr.Concrete 7200.0
          buildTime = ValueOrExpr.Concrete 8700.0
          health = ValueOrExpr.Concrete 2100.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMTARG.s3o"
          buildPic = Some "ARMTARG.DDS"
          script = Some "Units/ARMTARG.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "55 80 55"
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
                collisionVolumeScales = Some "55 80 55"
                collisionVolumeType = Some "cylY"
                damage = Some 1140.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 492.0
                object_ = Some "Units/armtarg_dead.s3o"
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
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/armtarg_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
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

    let armveil : UnitDef =
        { name = "armveil"
          subfolder = "ArmBuildings/LandUtil"
          metalCost = ValueOrExpr.Concrete 125.0
          energyCost = ValueOrExpr.Concrete 19000.0
          buildTime = ValueOrExpr.Concrete 9100.0
          health = ValueOrExpr.Concrete 830.0
          sightDistance = ValueOrExpr.Concrete 155.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMVEIL.s3o"
          buildPic = Some "ARMVEIL.DDS"
          script = Some "Units/ARMVEIL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "38 88 38"
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
                collisionVolumeOffsets = Some "-7.16355133057 1.47216796904e-05 -4.91466522217"
                collisionVolumeScales = Some "47.5629425049 83.2464294434 33.8293304443"
                collisionVolumeType = Some "Box"
                damage = Some 450.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 77.0
                object_ = Some "Units/armveil_dead.s3o"
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
                footprintX = Some 3.0
                footprintZ = Some 3.0
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
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecaltype", "decals/armveil_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
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
          ] }

    let all : (string * UnitDef) list =
        [
            "armarad", armarad
            "armdf", armdf
            "armdrag", armdrag
            "armeyes", armeyes
            "armfort", armfort
            "armgate", armgate
            "armjamt", armjamt
            "armmine1", armmine1
            "armmine2", armmine2
            "armmine3", armmine3
            "armnanotc", armnanotc
            "armnanotct2", armnanotct2
            "armrad", armrad
            "armsd", armsd
            "armtarg", armtarg
            "armveil", armveil
        ]
