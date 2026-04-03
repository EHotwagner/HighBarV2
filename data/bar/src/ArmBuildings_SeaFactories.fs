// Auto-generated BAR unit data: ArmBuildings/SeaFactories
namespace BarData.Units

open BarData

module ArmBuildings_SeaFactories =

    let armamsub : UnitDef =
        { name = "armamsub"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 1200.0
          energyCost = ValueOrExpr.Concrete 5500.0
          buildTime = ValueOrExpr.Concrete 11100.0
          health = ValueOrExpr.Concrete 2650.0
          sightDistance = ValueOrExpr.Concrete 234.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMAMSUB.s3o"
          buildPic = Some "ARMAMSUB.DDS"
          script = Some "Units/ARMAMSUB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric-uw"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 16 0"
          collisionVolumeScales = Some "96 42 96"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
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
              minWaterDepth = Some 25.0
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = None
              buildOptions = ["armbeaver"; "armpincer"; "armcroc"; "armjeth"; "armaak"; "armdecom"]
              terraformSpeed = Some 750.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 150.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooo oooooo oeeeeo oeeeeo oeeeeo oeeeeo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 2"
                collisionVolumeScales = Some "118 35 107"
                collisionVolumeType = Some "Box"
                damage = Some 1440.0
                featureDead = None
                footprintX = Some 7.0
                footprintZ = Some 7.0
                height = Some 5.0
                metal = Some 800.0
                object_ = Some "Units/armamsub_dead.s3o"
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
              select = ["pvehactv"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "11.0"
              "buildinggrounddecalsizey", "11.0"
              "buildinggrounddecaltype", "decals/armamsub_aoplane.dds"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/SeaFactories"
              "unitgroup", "builder"
              "usebuildinggrounddecal", "true"
              "techlevel", "1.5"
          ]
          extras = Map.empty }

    let armasy : UnitDef =
        { name = "armasy"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 2900.0
          energyCost = ValueOrExpr.Concrete 9700.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 6000.0
          sightDistance = ValueOrExpr.Concrete 299.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/ARMASY.s3o"
          buildPic = Some "ARMASY.DDS"
          script = Some "Units/ARMASY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -9 -2"
          collisionVolumeScales = Some "192 60 192"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 30.0
              waterline = Some 1.5 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 600.0
              buildDistance = None
              buildOptions = ["armacsub"; "armmls"; "armcrus"; "armsubk"; "armserp"; "armaas"; "armsjam"; "armantiship"; "armbats"; "armmship"; "armepoch"; "armlship"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "weeeeeeeeeew eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee weeeeeeeeeew"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -9 -2"
                collisionVolumeScales = Some "180 60 176"
                collisionVolumeType = Some "Box"
                damage = Some 2707.0
                featureDead = None
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 4.0
                metal = Some 2232.0
                object_ = Some "Units/armasy_dead.s3o"
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
              select = ["pshpactv"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/SeaFactories"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.empty }

    let armfhp : UnitDef =
        { name = "armfhp"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 670.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 8700.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 286.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMFHP.s3o"
          buildPic = Some "ARMFHP.DDS"
          script = Some "Units/ARMFHP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = Some "100 40 90"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 5.0
              waterline = Some 4.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 150.0
              buildDistance = None
              buildOptions = ["armch"; "armsh"; "armanac"; "armah"; "armmh"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "weeeew weeeew weeeew weeeew weeeew weeeew"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "116 20 104"
                collisionVolumeType = Some "Box"
                damage = Some 1803.0
                featureDead = None
                footprintX = Some 8.0
                footprintZ = Some 7.0
                height = Some 20.0
                metal = Some 670.0
                object_ = Some "Units/armfhp_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
          ])
          sounds = Some (
            { build = Some "hoverok1"
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["hoversl1"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/SeaFactories"
              "unitgroup", "builder"
              "techlevel", "1.5"
          ]
          extras = Map.empty }

    let armhasy : UnitDef =
        { name = "armhasy"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 5000.0
          energyCost = ValueOrExpr.Concrete 44000.0
          buildTime = ValueOrExpr.Concrete 85000.0
          health = ValueOrExpr.Concrete 16000.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 15.0
          footprintZ = 15.0
          objectName = Some "Units/ARMHASY.s3o"
          buildPic = Some "ARMSHLTXUW.DDS"
          script = Some "Units/techsplit/ARMHASY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric-uw"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "256 80 221"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
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
              minWaterDepth = Some 30.0
              waterline = Some 1.5 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 600.0
              buildDistance = None
              buildOptions = ["armhacs"; "armserp"; "armbats"; "armepoch"; "armantiship"; "armlship"; "armlun"; "armaas"; "armmship"]
              terraformSpeed = Some 3000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1400.0
              metalStorage = Some 800.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "weeeeeeeeeeeeew eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee eeeeeeeeeeeeeee weeeeeeeeeeeeew"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-2 -2 -3"
                collisionVolumeScales = Some "116 52 116"
                collisionVolumeType = Some "Box"
                damage = Some 8640.0
                featureDead = Some "HEAP"
                footprintX = Some 15.0
                footprintZ = Some 15.0
                height = Some 20.0
                metal = Some 4807.0
                object_ = Some "Units/armhasy_dead.s3o"
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
              select = ["pshpactv"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/SeaFactories"
              "techlevel", "3.0"
              "unitgroup", "buildert3"
          ]
          extras = Map.empty }

    let armplat : UnitDef =
        { name = "armplat"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 1450.0
          energyCost = ValueOrExpr.Concrete 5000.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMPLAT.s3o"
          buildPic = Some "ARMPLAT.DDS"
          script = Some "Units/ARMPLAT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "SURFACE UNDERWATER"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 30.0
              waterline = Some 39.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = None
              buildOptions = ["armcsa"; "armsaber"; "armsb"; "armseap"; "armsfig"; "armsehak"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "wwwwww weeeew weeeew weeeew weeeew wwwwww"
              activateWhenBuilt = Some false
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "1.25 -7.62939453125e-06 -0.375"
                collisionVolumeScales = Some "108.669647217 46.9999847412 117.478393555"
                collisionVolumeType = Some "Box"
                damage = Some 1092.0
                featureDead = None
                footprintX = Some 7.0
                footprintZ = Some 7.0
                height = Some 20.0
                metal = Some 975.0
                object_ = Some "Units/armplat_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
          ])
          sounds = Some (
            { build = Some "seaplok1"
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["seaplsl1"] })
          customParams = Map.ofList [
              "airfactory", "true"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/SeaFactories"
              "unitgroup", "builder"
              "restrictions_inclusion", "_noair_"
              "techlevel", "1.5"
          ]
          extras = Map.ofList [
              "onoffable", "true"
              "radardistance", "750.0"
              "sonardistance", "600.0"
          ] }

    let armsasy : UnitDef =
        { name = "armsasy"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 30000.0
          health = ValueOrExpr.Concrete 6000.0
          sightDistance = ValueOrExpr.Concrete 299.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/ARMASY.s3o"
          buildPic = Some "ARMASY.DDS"
          script = Some "Units/ARMASY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -9 -2"
          collisionVolumeScales = Some "192 60 192"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 30.0
              waterline = Some 1.5 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = None
              buildOptions = ["armsacsub"; "armserp"; "armsjam"; "armbats"; "armmship"; "armepoch"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "weeeeeeeeeew eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee weeeeeeeeeew"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -9 -2"
                collisionVolumeScales = Some "180 60 176"
                collisionVolumeType = Some "Box"
                damage = Some 2707.0
                featureDead = None
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 4.0
                metal = Some 2232.0
                object_ = Some "Units/armasy_dead.s3o"
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
              select = ["pshpactv"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/SeaFactories"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.empty }

    let armshltxuw : UnitDef =
        { name = "armshltxuw"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 7900.0
          energyCost = ValueOrExpr.Concrete 58000.0
          buildTime = ValueOrExpr.Concrete 62000.0
          health = ValueOrExpr.Concrete 16000.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/ARMSHLTX.s3o"
          buildPic = Some "ARMSHLTXUW.DDS"
          script = Some "Units/armshltx.cob"
          corpse = Some "ARMSHLT_DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric-uw"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "180 120 166"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
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
              minWaterDepth = Some 30.0
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 1800.0
              buildDistance = None
              buildOptions = ["armbanth"; "armmar"; "armcroc"; "armlun"]
              terraformSpeed = Some 3000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1400.0
              metalStorage = Some 800.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "armshlt_dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "125 75 145"
                collisionVolumeType = Some "Box"
                damage = Some 8640.0
                featureDead = Some "ARMSHLT_HEAP"
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 20.0
                metal = Some 4807.0
                object_ = Some "Units/armshltx_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "armshlt_heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 4320.0
                featureDead = None
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 4.0
                metal = Some 1923.0
                object_ = Some "Units/arm7X7D.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "gantok2"
              repair = Some "lathelrg"
              working = Some "build"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["gantsel1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "10.0"
              "buildinggrounddecalsizey", "10.0"
              "buildinggrounddecaltype", "decals/armshltx_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/SeaFactories"
              "techlevel", "3.0"
              "unitgroup", "buildert3"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.empty }

    let armsy : UnitDef =
        { name = "armsy"
          subfolder = "ArmBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 950.0
          buildTime = ValueOrExpr.Concrete 5160.0
          health = ValueOrExpr.Concrete 4100.0
          sightDistance = ValueOrExpr.Concrete 340.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMSY.s3o"
          buildPic = Some "ARMSY.DDS"
          script = Some "Units/ARMSY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 16 0"
          collisionVolumeScales = Some "90 60 90"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 30.0
              waterline = Some 1.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 150.0
              buildDistance = None
              buildOptions = ["armcs"; "armrecl"; "armdecade"; "armpt"; "armpship"; "armroy"; "armsub"]
              terraformSpeed = Some 500.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = Some 100.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oyyyyo yeeeey yeeeey yeeeey yeeeey oyyyyo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-2 -2 -3"
                collisionVolumeScales = Some "116 52 116"
                collisionVolumeType = Some "Box"
                damage = Some 1794.0
                featureDead = None
                footprintX = Some 7.0
                footprintZ = Some 7.0
                height = Some 4.0
                metal = Some 400.0
                object_ = Some "Units/armsy_dead.s3o"
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
              select = ["pshpactv"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/SeaFactories"
              "unitgroup", "builder"
          ]
          extras = Map.empty }

    let all : (string * UnitDef) list =
        [
            "armamsub", armamsub
            "armasy", armasy
            "armfhp", armfhp
            "armhasy", armhasy
            "armplat", armplat
            "armsasy", armsasy
            "armshltxuw", armshltxuw
            "armsy", armsy
        ]
