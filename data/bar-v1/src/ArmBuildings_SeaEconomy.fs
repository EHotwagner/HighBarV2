// Auto-generated BAR unit data: ArmBuildings/SeaEconomy
namespace BarData.V1.Units

open BarData.V1

module ArmBuildings_SeaEconomy =

    let armfmkr : UnitDef =
        { name = "armfmkr"
          subfolder = "ArmBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1150.0
          buildTime = ValueOrExpr.Concrete 2600.0
          health = ValueOrExpr.Concrete 167.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMFMKR.s3o"
          buildPic = Some "ARMFMKR.DDS"
          script = Some "Units/ARMFMKR.cob"
          corpse = None
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
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
            { yardMap = Some "wwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = None
          sounds = Some (
            { build = None
              repair = None
              working = Some "arm-bld-metalmaker"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["metlon1"] })
          customParams = Map.ofList [
              "energyconv_capacity", "70.0"
              "energyconv_efficiency", "0.01429"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaEconomy"
              "unitgroup", "metal"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let armtide : UnitDef =
        { name = "armtide"
          subfolder = "ArmBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 200.0
          buildTime = ValueOrExpr.Concrete 2190.0
          health = ValueOrExpr.Concrete 400.0
          sightDistance = ValueOrExpr.Concrete 130.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMTIDE.s3o"
          buildPic = Some "ARMTIDE.DDS"
          script = Some "Units/ARMTIDE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "tidal"
          selfDestructAs = Some "tidalSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "37 26 39"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 50.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "wwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.526138305664 2.37060546837e-06 -0.855285644531"
                collisionVolumeScales = Some "37 26 39"
                collisionVolumeType = Some "Box"
                damage = Some 145.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 53.0
                object_ = Some "Units/armtide_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 185.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 17.0
                object_ = Some "Units/arm2X2B.s3o"
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
              select = ["tidegen1"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaEconomy"
              "unitgroup", "energy"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "onoffable", "false"
              "tidalgenerator", "1.0"
          ] }

    let armuwadves : UnitDef =
        { name = "armuwadves"
          subfolder = "ArmBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 830.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 20300.0
          health = ValueOrExpr.Concrete 11700.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMUWADVES.s3o"
          buildPic = Some "ARMUWADVES.DDS"
          script = Some "Units/ARMUWADVES.cob"
          corpse = Some "DEAD"
          explodeAs = Some "advenergystorage"
          selfDestructAs = Some "advenergystorageSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "42 62 62"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 40000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "42 62 62"
                collisionVolumeType = Some "Box"
                damage = Some 4200.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 9.0
                metal = Some 502.0
                object_ = Some "Units/armuwadves_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 2100.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = None
                metal = Some 201.0
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
              select = ["storngy1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/armuwadves_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaEconomy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let armuwadvms : UnitDef =
        { name = "armuwadvms"
          subfolder = "ArmBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 11500.0
          buildTime = ValueOrExpr.Concrete 20400.0
          health = ValueOrExpr.Concrete 10300.0
          sightDistance = ValueOrExpr.Concrete 195.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMUWADVMS.s3o"
          buildPic = Some "ARMUWADVMS.DDS"
          script = Some "Units/ARMUWADVMS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "88 38 72"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some 10000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "7.62939453125e-06 -3.51196289046e-05 -0.0"
                collisionVolumeScales = Some "45.1519927979 49.1111297607 45.1520080566"
                collisionVolumeType = Some "Box"
                damage = Some 3720.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 9.0
                metal = Some 458.0
                object_ = Some "Units/armuwadvms_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1860.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = None
                metal = Some 183.0
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
              select = ["stormtl1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "7.0"
              "buildinggrounddecalsizey", "7.0"
              "buildinggrounddecaltype", "decals/armuwadvms_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaEconomy"
              "techlevel", "2.0"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "5049.0"
          ] }

    let armuwageo : UnitDef =
        { name = "armuwageo"
          subfolder = "ArmBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 50000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/ARMUWAGEO.s3o"
          buildPic = Some "ARMUWAGEO.DDS"
          script = Some "Units/ARMUWAGEO.cob"
          corpse = None
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advgeo"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "107 77 107"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 1250.0)
              metalMake = None
              energyStorage = Some 12000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "h cbgybsyybc bsbssbbssb ysbsbssbbg ybsssbsssy sbsbsssbsb bsbsssbsbs ysssbsssby gbbssbsbsy bssbbssbsb cbyysbygbc"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = None
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
              select = ["geothrm1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "11.0"
              "buildinggrounddecalsizey", "11.0"
              "buildinggrounddecaltype", "decals/armageo_aoplane.dds"
              "cvbuildable", "true"
              "geothermal", "1.0"
              "model_author", "Cremuss, Hornet"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaEconomy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "acceleration", "0.0"
              "brakerate", "0.0"
              "buildangle", "0.0"
              "buildcostenergy", "27000.0"
              "buildcostmetal", "1600.0"
              "maxdamage", "3600.0"
          ] }

    let armuwes : UnitDef =
        { name = "armuwes"
          subfolder = "ArmBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 170.0
          energyCost = ValueOrExpr.Concrete 1700.0
          buildTime = ValueOrExpr.Concrete 4110.0
          health = ValueOrExpr.Concrete 1890.0
          sightDistance = ValueOrExpr.Concrete 182.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMUWES.s3o"
          buildPic = Some "ARMUWES.DDS"
          script = Some "Units/ARMUWES.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric-uw"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 6000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 1.15966796876e-06 -0.187507629395"
                collisionVolumeScales = Some "60.5 18.7805023193 63.6249847412"
                collisionVolumeType = Some "Box"
                damage = Some 1788.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 185.0
                object_ = Some "Units/armuwes_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 894.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 74.0
                object_ = Some "Units/arm4X4B.s3o"
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
              select = ["storngy1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/armuwes_aoplane.dds"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaEconomy"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let armuwfus : UnitDef =
        { name = "armuwfus"
          subfolder = "ArmBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 5200.0
          energyCost = ValueOrExpr.Concrete 33500.0
          buildTime = ValueOrExpr.Concrete 99900.0
          health = ValueOrExpr.Concrete 5600.0
          sightDistance = ValueOrExpr.Concrete 143.0
          footprintX = 6.0
          footprintZ = 4.0
          objectName = Some "Units/ARMUWFUS.s3o"
          buildPic = Some "ARMUWFUS.DDS"
          script = Some "Units/ARMUWFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion-uw"
          selfDestructAs = Some "fusionExplosionSelfd-uw"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = None
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 1200.0)
              metalMake = None
              energyStorage = Some 2500.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooo oooooo oooooo oooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.252502441406 0.0765009643555 0.542335510254"
                collisionVolumeScales = Some "80.2949829102 38.3076019287 56.9153289795"
                collisionVolumeType = Some "Box"
                damage = Some 3000.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 3034.0
                object_ = Some "Units/armuwfus_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1500.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 1214.0
                object_ = Some "Units/arm5X5C.s3o"
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
              select = ["watfusn1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecaltype", "decals/armuwfus_aoplane.dds"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaEconomy"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "restrictions_inclusion", "_nofusion_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "hidedamage", "true"
          ] }

    let armuwgeo : UnitDef =
        { name = "armuwgeo"
          subfolder = "ArmBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 13100.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/ARMUWGEO.s3o"
          buildPic = Some "ARMUWGEO.DDS"
          script = Some "Units/ARMUWGEO.cob"
          corpse = Some "dead"
          explodeAs = Some "geo"
          selfDestructAs = Some "geo"
          collisionVolumeOffsets = Some "0 -4 0"
          collisionVolumeScales = Some "60 70 60"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 300.0)
              metalMake = None
              energyStorage = Some 1000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "h cbbbbgbbbc bgbggbbggb bgbgbggbbb bbgggbgggb gbgbgggbgb bgbgggbgbg bgggbgggbb bbbggbgbgb bggbbggbgb cbbbgbbbbc"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "60 70 60"
                collisionVolumeType = Some "Box"
                damage = Some 1050.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 338.0
                object_ = Some "Units/armgeo_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 525.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 135.0
                object_ = Some "Units/arm4X4B.s3o"
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
              select = ["geothrm1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "7.0"
              "buildinggrounddecalsizey", "7.0"
              "buildinggrounddecaltype", "decals/armgeo_aoplane.dds"
              "cvbuildable", "true"
              "geothermal", "1.0"
              "model_author", "Cremuss, Hornet"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaEconomy"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "acceleration", "0.0"
              "brakerate", "0.0"
              "buildangle", "2048.0"
              "buildcostenergy", "13000.0"
              "buildcostmetal", "560.0"
              "maxdamage", "1940.0"
          ] }

    let armuwmme : UnitDef =
        { name = "armuwmme"
          subfolder = "ArmBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 620.0
          energyCost = ValueOrExpr.Concrete 7700.0
          buildTime = ValueOrExpr.Concrete 14900.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 182.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMUWMME.s3o"
          buildPic = Some "ARMUWMME.DDS"
          script = Some "Units/ARMUWMME.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingExplosionGeneric-uw"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some 600.0
              extractsMetal = Some 0.004 })
          building = Some (
            { yardMap = Some "h cbbbbbbc bssssssb bsssossb bsobbssb bssbbosb bssosssb bssssssb cbbbbbbc"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-4.05554199219 -3.90136718735e-05 1.12891387939"
                collisionVolumeScales = Some "70.6470947266 41.1475219727 59.8421783447"
                collisionVolumeType = Some "Box"
                damage = Some 1232.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 140.0
                metal = Some 391.0
                object_ = Some "Units/armuwmme_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 616.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 156.0
                object_ = Some "Units/arm5X5C.s3o"
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
              select = ["waterex1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecaltype", "decals/armuwmme_aoplane.dds"
              "cvbuildable", "true"
              "metal_extractor", "4.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaEconomy"
              "techlevel", "2.0"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "32768.0"
              "energyupkeep", "20.0"
              "onoffable", "true"
          ] }

    let armuwmmm : UnitDef =
        { name = "armuwmmm"
          subfolder = "ArmBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 380.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 35000.0
          health = ValueOrExpr.Concrete 445.0
          sightDistance = ValueOrExpr.Concrete 156.0
          footprintX = 5.0
          footprintZ = 4.0
          objectName = Some "Units/ARMUWMMM.s3o"
          buildPic = Some "ARMUWMMM.DDS"
          script = Some "Units/ARMUWMMM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingExplosionGeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -4 0"
          collisionVolumeScales = Some "72 72 72"
          collisionVolumeType = Some "Ell"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "oooooooooooooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "1.91563415527 -2.21923828114e-05 -2.03186035156"
                collisionVolumeScales = Some "70.811340332 33.9307556152 58.6123657227"
                collisionVolumeType = Some "Box"
                damage = Some 240.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 247.0
                object_ = Some "Units/armuwmmm_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 120.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 99.0
                object_ = Some "Units/arm4X4C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "arm-bld-metalmaker"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["metlon1"] })
          customParams = Map.ofList [
              "energyconv_capacity", "600.0"
              "energyconv_efficiency", "0.01724"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaEconomy"
              "techlevel", "2.0"
              "unitgroup", "metal"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let armuwms : UnitDef =
        { name = "armuwms"
          subfolder = "ArmBuildings/SeaEconomy"
          metalCost = ValueOrExpr.Concrete 330.0
          energyCost = ValueOrExpr.Concrete 570.0
          buildTime = ValueOrExpr.Concrete 2920.0
          health = ValueOrExpr.Concrete 3600.0
          sightDistance = ValueOrExpr.Concrete 182.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMUWMS.s3o"
          buildPic = Some "ARMUWMS.DDS"
          script = Some "Units/ARMUWMS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric-uw"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some 3000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 0.0 0.0956878662109"
                collisionVolumeScales = Some "62.4999694824 41.0 75.6147460938"
                collisionVolumeType = Some "Box"
                damage = Some 1950.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 234.0
                object_ = Some "Units/armuwms_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 975.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 94.0
                object_ = Some "Units/arm4X4B.s3o"
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
              select = ["stormtl1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecalsizey", "3.6"
              "buildinggrounddecaltype", "decals/armuwms_aoplane.dds"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/SeaEconomy"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "armfmkr", armfmkr
            "armtide", armtide
            "armuwadves", armuwadves
            "armuwadvms", armuwadvms
            "armuwageo", armuwageo
            "armuwes", armuwes
            "armuwfus", armuwfus
            "armuwgeo", armuwgeo
            "armuwmme", armuwmme
            "armuwmmm", armuwmmm
            "armuwms", armuwms
        ]
