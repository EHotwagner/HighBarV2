// Auto-generated BAR unit data: CorBuildings/LandFactories
namespace BarData.Units

open BarData

module CorBuildings_LandFactories =

    let coraap : UnitDef =
        { name = "coraap"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 2900.0
          energyCost = ValueOrExpr.Concrete 28000.0
          buildTime = ValueOrExpr.Concrete 32000.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 305.5
          footprintX = 9.0
          footprintZ = 9.0
          objectName = Some "Units/CORAAP.s3o"
          buildPic = Some "CORAAP.DDS"
          script = Some "Units/CORAAP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 4 0"
          collisionVolumeScales = Some "142 64 142"
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
              buildOptions = ["coraca"; "corape"; "corhurc"; "cortitan"; "corvamp"; "corawac"; "corseah"; "corcrwh"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -12 -22"
                collisionVolumeScales = Some "98 32 52"
                collisionVolumeType = Some "Box"
                damage = Some 2112.0
                featureDead = Some "HEAP"
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 20.0
                metal = Some 1936.0
                object_ = Some "Units/coraap_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1056.0
                featureDead = None
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 4.0
                metal = Some 968.0
                object_ = Some "Units/cor6X6A.s3o"
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
              "airfactory", "true"
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecaltype", "decals/coraap_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
              "restrictions_inclusion", "_noair_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "radardistance", "1000.0"
              "radaremitheight", "50.0"
          ] }

    let coralab : UnitDef =
        { name = "coralab"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 2600.0
          energyCost = ValueOrExpr.Concrete 16000.0
          buildTime = ValueOrExpr.Concrete 26000.0
          health = ValueOrExpr.Concrete 4500.0
          sightDistance = ValueOrExpr.Concrete 288.60001
          footprintX = 9.0
          footprintZ = 9.0
          objectName = Some "Units/CORALAB.s3o"
          buildPic = Some "CORALAB.DDS"
          script = Some "Units/CORALAB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 2 0"
          collisionVolumeScales = Some "144 56 144"
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
              buildOptions = ["corack"; "corfast"; "corpyro"; "coramph"; "corcan"; "corsumo"; "cortermite"; "cormort"; "corhrk"; "coraak"; "corroach"; "corsktl"; "cordecom"; "corvoyr"; "corspy"; "corspec"; "cormando"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooooooooo ooooooooo oooeeeooo oooeeeooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -16 0"
                collisionVolumeScales = Some "100 34 90"
                collisionVolumeType = Some "Box"
                damage = Some 2443.0
                featureDead = Some "HEAP"
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 20.0
                metal = Some 1743.0
                object_ = Some "Units/coralab_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1222.0
                featureDead = None
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 4.0
                metal = Some 872.0
                object_ = Some "Units/cor5X5A.s3o"
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
              select = ["plabactv"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecaltype", "decals/coralab_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "1024.0"
          ] }

    let corap : UnitDef =
        { name = "corap"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 630.0
          energyCost = ValueOrExpr.Concrete 1100.0
          buildTime = ValueOrExpr.Concrete 5380.0
          health = ValueOrExpr.Concrete 2150.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 9.0
          footprintZ = 6.0
          objectName = Some "Units/CORAP.s3o"
          buildPic = Some "CORAP.DDS"
          script = Some "Units/CORAP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "128 33 96"
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
            { workerTime = ValueOrExpr.Concrete 150.0
              buildDistance = None
              buildOptions = ["corca"; "corfink"; "corveng"; "corshad"; "corvalk"; "corbw"; "corhvytrans"]
              terraformSpeed = Some 500.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = Some 100.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -14 -23"
                collisionVolumeScales = Some "110 33 50"
                collisionVolumeType = Some "Box"
                damage = Some 1155.0
                featureDead = Some "HEAP"
                footprintX = Some 12.0
                footprintZ = Some 9.0
                height = Some 20.0
                metal = Some 540.0
                object_ = Some "Units/corap_dead.s3o"
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
                metal = Some 216.0
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
              select = ["airplantselect"] })
          customParams = Map.ofList [
              "airfactory", "true"
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "11.0"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecaltype", "decals/corap_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "unitgroup", "builder"
              "restrictions_inclusion", "_noair_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "radardistance", "510.0"
              "radaremitheight", "40.0"
              "sightemitheight", "40.0"
          ] }

    let coravp : UnitDef =
        { name = "coravp"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 2600.0
          energyCost = ValueOrExpr.Concrete 16000.0
          buildTime = ValueOrExpr.Concrete 28000.0
          health = ValueOrExpr.Concrete 5100.0
          sightDistance = ValueOrExpr.Concrete 286.0
          footprintX = 9.0
          footprintZ = 9.0
          objectName = Some "Units/CORAVP.s3o"
          buildPic = Some "CORAVP.DDS"
          script = Some "Units/CORAVP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 8 0"
          collisionVolumeScales = Some "144 70 144"
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
              buildOptions = ["coracv"; "corsala"; "correap"; "corparrow"; "corgol"; "corban"; "cormart"; "corvroc"; "cortrem"; "corsent"; "cormabm"; "coreter"; "corvrad"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooooooooo ooooooooo ooooooooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -6 0"
                collisionVolumeScales = Some "124 30 104"
                collisionVolumeType = Some "Box"
                damage = Some 2777.0
                featureDead = Some "HEAP"
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 20.0
                metal = Some 1721.0
                object_ = Some "Units/coravp_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1389.0
                featureDead = None
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 4.0
                metal = Some 860.0
                object_ = Some "Units/cor6X6C.s3o"
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
              select = ["pvehactv"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "0.01"
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecaltype", "decals/coravp_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "1024.0"
              "levelground", "false"
          ] }

    let corgant : UnitDef =
        { name = "corgant"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 8400.0
          energyCost = ValueOrExpr.Concrete 62000.0
          buildTime = ValueOrExpr.Concrete 68000.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/CORGANT.s3o"
          buildPic = Some "CORGANT.DDS"
          script = Some "Units/CORGANT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 12 0"
          collisionVolumeScales = Some "196 110 196"
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
            { workerTime = ValueOrExpr.Concrete 1800.0
              buildDistance = None
              buildOptions = ["corkorg"; "corkarg"; "corjugg"; "corshiva"; "corcat"; "corsok"; "cordemon"]
              terraformSpeed = Some 3000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1400.0
              metalStorage = Some 800.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -21 0"
                collisionVolumeScales = Some "114 74 129"
                collisionVolumeType = Some "CylZ"
                damage = Some 9600.0
                featureDead = Some "HEAP"
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 20.0
                metal = Some 5101.0
                object_ = Some "Units/corgant_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 4800.0
                featureDead = None
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 4.0
                metal = Some 2040.0
                object_ = Some "Units/cor7X7B.s3o"
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
              "buildinggrounddecalsizex", "15.0"
              "buildinggrounddecalsizey", "15.0"
              "buildinggrounddecaltype", "decals/corgant_aoplane.dds"
              "model_author", "Mr Bob, Tharsis"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "3.0"
              "unitgroup", "buildert3"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.empty }

    let corhaap : UnitDef =
        { name = "corhaap"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 4700.0
          energyCost = ValueOrExpr.Concrete 65000.0
          buildTime = ValueOrExpr.Concrete 92000.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/CORHAAP.s3o"
          buildPic = Some "CORAAP.DDS"
          script = Some "Units/CORAAP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
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
            { workerTime = ValueOrExpr.Concrete 1800.0
              buildDistance = None
              buildOptions = ["corhaca"; "corape"; "corhurc"; "cortitan"; "corvamp"; "corseah"; "corawac"; "corcrwh"]
              terraformSpeed = Some 3000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1400.0
              metalStorage = Some 800.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "5 0.0 -0.0"
                collisionVolumeScales = Some "235 82.5 225"
                collisionVolumeType = Some "Box"
                damage = Some 9600.0
                featureDead = Some "HEAP"
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 20.0
                metal = Some 5101.0
                object_ = Some "Units/corhaap_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 4800.0
                featureDead = None
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 4.0
                metal = Some 2040.0
                object_ = Some "Units/cor7X7B.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "seaplok2"
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["seaplsl2"] })
          customParams = Map.ofList [
              "airfactory", "true"
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecaltype", "decals/coraap_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "3.0"
              "unitgroup", "buildert3"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "radardistance", "750.0"
              "radaremitheight", "50.0"
          ] }

    let corhaapuw : UnitDef =
        { name = "corhaapuw"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 1900.0
          energyCost = ValueOrExpr.Concrete 23000.0
          buildTime = ValueOrExpr.Concrete 42000.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 305.5
          footprintX = 9.0
          footprintZ = 9.0
          objectName = Some "Units/CORAAPLAT.s3o"
          buildPic = Some "CORPLAT.DDS"
          script = Some "Units/CORPLAT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 4 0"
          collisionVolumeScales = Some "142 64 142"
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
            { workerTime = ValueOrExpr.Concrete 200.0
              buildDistance = None
              buildOptions = ["coraca"; "corhunt"; "corcut"; "corsb"; "corseap"; "corsfig"; "corhvytrans"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -12 -22"
                collisionVolumeScales = Some "98 32 52"
                collisionVolumeType = Some "Box"
                damage = Some 2112.0
                featureDead = Some "HEAP"
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 20.0
                metal = Some 1936.0
                object_ = Some "Units/coraaplat_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1056.0
                featureDead = None
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 4.0
                metal = Some 968.0
                object_ = Some "Units/cor6X6A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "seaplok2"
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["seaplsl2"] })
          customParams = Map.ofList [
              "airfactory", "true"
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecaltype", "decals/coraap_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "radardistance", "1000.0"
              "radaremitheight", "50.0"
          ] }

    let corhalab : UnitDef =
        { name = "corhalab"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 4900.0
          energyCost = ValueOrExpr.Concrete 52200.0
          buildTime = ValueOrExpr.Concrete 92000.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/CORGANT.s3o"
          buildPic = Some "CORGANT.DDS"
          script = Some "Units/CORGANT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 12 0"
          collisionVolumeScales = Some "196 110 196"
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
            { workerTime = ValueOrExpr.Concrete 1200.0
              buildDistance = None
              buildOptions = ["coraak"; "corshiva"; "corpyro"; "corhack"; "corsumo"; "cordecom"; "corsktl"; "corspec"]
              terraformSpeed = Some 3000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1400.0
              metalStorage = Some 800.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -21 0"
                collisionVolumeScales = Some "114 74 129"
                collisionVolumeType = Some "CylZ"
                damage = Some 9600.0
                featureDead = Some "HEAP"
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 20.0
                metal = Some 5101.0
                object_ = Some "Units/corgant_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 4800.0
                featureDead = None
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 4.0
                metal = Some 2040.0
                object_ = Some "Units/cor7X7B.s3o"
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
              "buildinggrounddecalsizex", "15.0"
              "buildinggrounddecalsizey", "15.0"
              "buildinggrounddecaltype", "decals/corgant_aoplane.dds"
              "model_author", "Mr Bob, Tharsis"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "3.0"
              "unitgroup", "buildert3"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.empty }

    let corhavp : UnitDef =
        { name = "corhavp"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 4900.0
          energyCost = ValueOrExpr.Concrete 46000.0
          buildTime = ValueOrExpr.Concrete 92000.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/CORHAVP.s3o"
          buildPic = Some "CORHAVP.DDS"
          script = Some "Units/CORAMSUB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 12 0"
          collisionVolumeScales = Some "196 110 196"
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
            { workerTime = ValueOrExpr.Concrete 1200.0
              buildDistance = None
              buildOptions = ["corhacv"; "corgol"; "corvroc"; "cortrem"; "corsent"; "cormabm"; "coreter"; "corsok"; "corparrow"; "corsala"]
              terraformSpeed = Some 3000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1400.0
              metalStorage = Some 800.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -21 0"
                collisionVolumeScales = Some "114 74 129"
                collisionVolumeType = Some "CylZ"
                damage = Some 9600.0
                featureDead = Some "HEAP"
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 20.0
                metal = Some 5101.0
                object_ = Some "Units/corhavp_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 4800.0
                featureDead = None
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 4.0
                metal = Some 2040.0
                object_ = Some "Units/cor7X7B.s3o"
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
              "buildinggrounddecalsizex", "18.0"
              "buildinggrounddecalsizey", "18.0"
              "buildinggrounddecaltype", "decals/coramsub_aoplane.dds"
              "model_author", "Mr Bob, Tharsis"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "3.0"
              "unitgroup", "buildert3"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.empty }

    let corhp : UnitDef =
        { name = "corhp"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 670.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 8700.0
          health = ValueOrExpr.Concrete 3750.0
          sightDistance = ValueOrExpr.Concrete 312.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORHP.s3o"
          buildPic = Some "CORHP.DDS"
          script = Some "Units/CORHP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 5 0"
          collisionVolumeScales = Some "96 32 96"
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
            { workerTime = ValueOrExpr.Concrete 150.0
              buildDistance = None
              buildOptions = ["corch"; "corsh"; "corsnap"; "corah"; "cormh"; "corhal"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "120 26 108"
                collisionVolumeType = Some "Box"
                damage = Some 2014.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 662.0
                object_ = Some "Units/corhp_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1007.0
                featureDead = None
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 265.0
                object_ = Some "Units/cor7X7D.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "hoverok2"
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["hoversl2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecaltype", "decals/corhp_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "unitgroup", "builder"
              "usebuildinggrounddecal", "true"
              "techlevel", "1.5"
          ]
          extras = Map.empty }

    let corlab : UnitDef =
        { name = "corlab"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 470.0
          energyCost = ValueOrExpr.Concrete 1050.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 2900.0
          sightDistance = ValueOrExpr.Concrete 290.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORLAB.s3o"
          buildPic = Some "CORLAB.DDS"
          script = Some "Units/CORLAB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "93 92 87"
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
            { workerTime = ValueOrExpr.Concrete 150.0
              buildDistance = None
              buildOptions = ["corck"; "corak"; "cornecro"; "corstorm"; "corthud"; "corcrash"]
              terraformSpeed = Some 500.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = Some 100.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oeeeeooeeeeooeeeeooeeeeooeeeeooeeeeo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "88 28 88"
                collisionVolumeType = Some "Box"
                damage = Some 1560.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 442.0
                object_ = Some "Units/corlab_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 780.0
                featureDead = None
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 177.0
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
              select = ["labselect"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecaltype", "decals/corlab_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "unitgroup", "builder"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "1024.0"
          ] }

    let corsaap : UnitDef =
        { name = "corsaap"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 51000.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 305.5
          footprintX = 9.0
          footprintZ = 9.0
          objectName = Some "Units/LEGAAP.s3o"
          buildPic = Some "LEGAAP.DDS"
          script = Some "Units/LEGAAP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 4 0"
          collisionVolumeScales = Some "142 64 142"
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
            { workerTime = ValueOrExpr.Concrete 200.0
              buildDistance = None
              buildOptions = ["corcsa"; "corape"; "corhurc"; "cortitan"; "corvamp"; "corseah"; "corcrwh"; "corhunt"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -12 -22"
                collisionVolumeScales = Some "98 32 52"
                collisionVolumeType = Some "Box"
                damage = Some 2112.0
                featureDead = Some "HEAP"
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 20.0
                metal = Some 1936.0
                object_ = Some "Units/legaap_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1056.0
                featureDead = None
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 4.0
                metal = Some 968.0
                object_ = Some "Units/cor6X6A.s3o"
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
              "airfactory", "true"
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecaltype", "decals/coraap_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "radardistance", "1000.0"
              "radaremitheight", "50.0"
          ] }

    let corsalab : UnitDef =
        { name = "corsalab"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 51000.0
          health = ValueOrExpr.Concrete 4500.0
          sightDistance = ValueOrExpr.Concrete 288.60001
          footprintX = 9.0
          footprintZ = 9.0
          objectName = Some "Units/LEGALAB.s3o"
          buildPic = Some "LEGALAB.DDS"
          script = Some "Units/LEGALAB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 2 0"
          collisionVolumeScales = Some "144 56 144"
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
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = None
              buildOptions = ["corsack"; "corsumo"; "corhrk"; "corsktl"; "corvoyr"; "corspec"; "cormando"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooooooooo ooooooooo oooeeeooo oooeeeooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -16 0"
                collisionVolumeScales = Some "100 34 90"
                collisionVolumeType = Some "Box"
                damage = Some 2443.0
                featureDead = Some "HEAP"
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 20.0
                metal = Some 1743.0
                object_ = Some "Units/legalab_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1222.0
                featureDead = None
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 4.0
                metal = Some 872.0
                object_ = Some "Units/cor5X5A.s3o"
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
              select = ["plabactv"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecaltype", "decals/coralab_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "1024.0"
          ] }

    let corsavp : UnitDef =
        { name = "corsavp"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 51000.0
          health = ValueOrExpr.Concrete 5100.0
          sightDistance = ValueOrExpr.Concrete 286.0
          footprintX = 9.0
          footprintZ = 9.0
          objectName = Some "Units/LEGAVP.s3o"
          buildPic = Some "LEGAVP.DDS"
          script = Some "Units/LEGAVP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 8 0"
          collisionVolumeScales = Some "144 70 144"
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
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = None
              buildOptions = ["corsacv"; "corparrow"; "corgol"; "corban"; "corvroc"; "cortrem"; "coreter"; "corvrad"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooooooooo ooooooooo ooooooooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -6 0"
                collisionVolumeScales = Some "124 30 104"
                collisionVolumeType = Some "Box"
                damage = Some 2777.0
                featureDead = Some "HEAP"
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 20.0
                metal = Some 1721.0
                object_ = Some "Units/legavp_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 1389.0
                featureDead = None
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 4.0
                metal = Some 860.0
                object_ = Some "Units/cor6X6C.s3o"
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
              select = ["pvehactv"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "0.01"
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecaltype", "decals/coravp_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "1024.0"
              "levelground", "false"
          ] }

    let corvp : UnitDef =
        { name = "corvp"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 570.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 5650.0
          health = ValueOrExpr.Concrete 3000.0
          sightDistance = ValueOrExpr.Concrete 279.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORVP.s3o"
          buildPic = Some "CORVP.DDS"
          script = Some "Units/CORVP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 5 0"
          collisionVolumeScales = Some "96 40 96"
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
            { workerTime = ValueOrExpr.Concrete 150.0
              buildDistance = None
              buildOptions = ["corcv"; "cormuskrat"; "cormlv"; "corfav"; "corgator"; "corgarp"; "corraid"; "corlevlr"; "corwolv"; "cormist"]
              terraformSpeed = Some 500.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = Some 100.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooo oooooo oeeeeo oeeeeo oeeeeo oeeeeo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -13 0"
                collisionVolumeScales = Some "101 40 106"
                collisionVolumeType = Some "BOX"
                damage = Some 1590.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 470.0
                object_ = Some "Units/corvp_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 795.0
                featureDead = None
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 188.0
                object_ = Some "Units/cor7X7B.s3o"
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
              select = ["vehplantselect"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecaltype", "decals/corvp_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "unitgroup", "builder"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "levelground", "false"
          ] }

    let leghaap : UnitDef =
        { name = "leghaap"
          subfolder = "CorBuildings/LandFactories"
          metalCost = ValueOrExpr.Concrete 4700.0
          energyCost = ValueOrExpr.Concrete 62000.0
          buildTime = ValueOrExpr.Concrete 92000.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/CORHAAP.s3o"
          buildPic = Some "CORHAAP.DDS"
          script = Some "Units/CORHAAP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 12 0"
          collisionVolumeScales = Some "196 110 196"
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
              buildOptions = ["leghaca"; "legstronghold"; "legmineb"; "legatorpbomber"; "legafigdef"; "legwhisper"; "legfort"; "legphoenix"; "legvenator"]
              terraformSpeed = Some 3000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1400.0
              metalStorage = Some 800.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "2.5 0.0 -0.0"
                collisionVolumeScales = Some "117.5 41.25 112.5"
                collisionVolumeType = Some "Box"
                damage = Some 9600.0
                featureDead = Some "HEAP"
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 20.0
                metal = Some 5101.0
                object_ = Some "Units/corplat_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 4800.0
                featureDead = None
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 4.0
                metal = Some 2040.0
                object_ = Some "Units/cor7X7B.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "seaplok2"
              repair = None
              working = None
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["seaplsl2"] })
          customParams = Map.ofList [
              "airfactory", "true"
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecaltype", "decals/coraap_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
              "techlevel", "3.0"
              "unitgroup", "buildert3"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "radardistance", "750.0"
              "radaremitheight", "50.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "coraap", coraap
            "coralab", coralab
            "corap", corap
            "coravp", coravp
            "corgant", corgant
            "corhaap", corhaap
            "corhaapuw", corhaapuw
            "corhalab", corhalab
            "corhavp", corhavp
            "corhp", corhp
            "corlab", corlab
            "corsaap", corsaap
            "corsalab", corsalab
            "corsavp", corsavp
            "corvp", corvp
            "leghaap", leghaap
        ]
