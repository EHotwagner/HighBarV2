// Auto-generated BAR unit data: Scavengers/Buildings/Factories
namespace BarData.V1.Units

open BarData.V1

module Scavengers_Buildings_Factories =

    let armapt3 : UnitDef =
        { name = "armapt3"
          subfolder = "Scavengers/Buildings/Factories"
          metalCost = ValueOrExpr.Concrete 8500.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 72400.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 292.0
          footprintX = 18.0
          footprintZ = 12.0
          objectName = Some "Units/scavbuildings/ARMAPT3.s3o"
          buildPic = Some "ARMAP.DDS"
          script = Some "Units/scavbuildings/ARMAPT3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 8 1"
          collisionVolumeScales = Some "268 98 164"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 15.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 600.0
              buildDistance = None
              buildOptions = []
              terraformSpeed = Some 500.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1000.0
              metalStorage = Some 1000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo oooooooooooooooooo "
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "11 -17 -23"
                collisionVolumeScales = Some "170 78 98"
                collisionVolumeType = Some "Box"
                damage = Some 11100.0
                featureDead = Some "HEAP"
                footprintX = Some 14.0
                footprintZ = Some 12.0
                height = Some 40.0
                metal = Some 5530.0
                object_ = Some "Units/scavbuildings/armapt3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 5550.0
                featureDead = None
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 2210.0
                object_ = Some "Units/arm6X6B.s3o"
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
              select = ["pairactv"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/armapt3_aoplane.dds"
              "buildinggrounddecalsizey", "15.0"
              "buildinggrounddecalsizex", "21.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "buildert3"
              "restrictions_inclusion", "_noair_"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/LandFactories"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "radardistance", "500.0"
              "radaremitheight", "72.0"
          ] }

    let corapt3 : UnitDef =
        { name = "corapt3"
          subfolder = "Scavengers/Buildings/Factories"
          metalCost = ValueOrExpr.Concrete 8500.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 72400.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 16.0
          footprintZ = 12.0
          objectName = Some "Units/scavbuildings/CORAPT3.s3o"
          buildPic = Some "CORAP.DDS"
          script = Some "Units/scavbuildings/CORAPT3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -14 -23"
          collisionVolumeScales = Some "220 66 100"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 15.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 600.0
              buildDistance = None
              buildOptions = []
              terraformSpeed = Some 500.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1000.0
              metalStorage = Some 1000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo "
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -14 -23"
                collisionVolumeScales = Some "220 66 100"
                collisionVolumeType = Some "Box"
                damage = Some 11550.0
                featureDead = Some "HEAP"
                footprintX = Some 14.0
                footprintZ = Some 12.0
                height = Some 20.0
                metal = Some 5400.0
                object_ = Some "Units/scavbuildings/corapt3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 578.0
                featureDead = None
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 2160.0
                object_ = Some "Units/cor6X6B.s3o"
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
              select = ["pairactv"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/corapt3_aoplane.dds"
              "buildinggrounddecalsizey", "15.0"
              "buildinggrounddecalsizex", "19.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "buildert3"
              "restrictions_inclusion", "_noair_"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "sightemitheight", "40.0"
              "radardistance", "510.0"
              "radaremitheight", "40.0"
          ] }

    let legapt3 : UnitDef =
        { name = "legapt3"
          subfolder = "Scavengers/Buildings/Factories"
          metalCost = ValueOrExpr.Concrete 8500.0
          energyCost = ValueOrExpr.Concrete 60000.0
          buildTime = ValueOrExpr.Concrete 72400.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 16.0
          footprintZ = 12.0
          objectName = Some "Units/scavbuildings/CORAPT3.s3o"
          buildPic = Some "LEGAP.DDS"
          script = Some "Units/scavbuildings/CORAPT3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -14 -23"
          collisionVolumeScales = Some "220 66 100"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "ALL NOTLAND NOWEAPON NOTSUB NOTSHIP NOTAIR NOTHOVER SURFACE EMPABLE"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 15.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 600.0
              buildDistance = None
              buildOptions = []
              terraformSpeed = Some 500.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1000.0
              metalStorage = Some 1000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo oooooooooooooooo "
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -14 -23"
                collisionVolumeScales = Some "220 66 100"
                collisionVolumeType = Some "Box"
                damage = Some 11550.0
                featureDead = Some "HEAP"
                footprintX = Some 14.0
                footprintZ = Some 12.0
                height = Some 20.0
                metal = Some 5400.0
                object_ = Some "Units/scavbuildings/corapt3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 578.0
                featureDead = None
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 2160.0
                object_ = Some "Units/cor6X6B.s3o"
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
              select = ["pairactv"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/corapt3_aoplane.dds"
              "buildinggrounddecalsizey", "15.0"
              "buildinggrounddecalsizex", "19.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "buildert3"
              "restrictions_inclusion", "_noair_"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "sightemitheight", "40.0"
              "radardistance", "510.0"
              "radaremitheight", "40.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "armapt3", armapt3
            "corapt3", corapt3
            "legapt3", legapt3
        ]
