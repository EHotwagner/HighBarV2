// Auto-generated BAR unit data: CorBuildings/SeaFactories
namespace BarData.Units

open BarData

module CorBuildings_SeaFactories =

    let coramsub : UnitDef =
        { name = "coramsub"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 1200.0
          energyCost = ValueOrExpr.Concrete 5600.0
          buildTime = ValueOrExpr.Concrete 11400.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 240.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORAMSUB.s3o"
          buildPic = Some "CORAMSUB.DDS"
          script = Some "Units/CORAMSUB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 -6"
          collisionVolumeScales = Some "96 30 96"
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
              minWaterDepth = Some 25.0
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = None
              buildOptions = ["cormuskrat"; "corgarp"; "corsala"; "corparrow"; "corcrash"; "coraak"; "cordecom"]
              terraformSpeed = Some 750.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 160.0
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
                collisionVolumeOffsets = Some "0 0 -15"
                collisionVolumeScales = Some "111 34 86"
                collisionVolumeType = Some "Box"
                damage = Some 1500.0
                featureDead = None
                footprintX = Some 7.0
                footprintZ = Some 7.0
                height = Some 5.0
                metal = Some 800.0
                object_ = Some "Units/coramsub_dead.s3o"
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
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecaltype", "decals/coramsub_aoplane.dds"
              "model_author", "FireStorm"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/SeaFactories"
              "unitgroup", "builder"
              "usebuildinggrounddecal", "true"
              "techlevel", "1.5"
          ]
          extras = Map.empty }

    let corasy : UnitDef =
        { name = "corasy"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 2800.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 301.60001
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/CORASY.s3o"
          buildPic = Some "CORASY.DDS"
          script = Some "Units/CORASY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 10 -2"
          collisionVolumeScales = Some "186 78 183"
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
              waterline = Some 19.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 600.0
              buildDistance = None
              buildOptions = ["coracsub"; "cormls"; "corcrus"; "corshark"; "corssub"; "corarch"; "corsjam"; "corantiship"; "corbats"; "cormship"; "corblackhy"; "corfship"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -13 -3"
                collisionVolumeScales = Some "192 61 180"
                collisionVolumeType = Some "Box"
                damage = Some 2650.0
                featureDead = None
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 4.0
                metal = Some 2174.0
                object_ = Some "Units/corasy_dead.s3o"
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/SeaFactories"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.empty }

    let corfhp : UnitDef =
        { name = "corfhp"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 670.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 8700.0
          health = ValueOrExpr.Concrete 3750.0
          sightDistance = ValueOrExpr.Concrete 312.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORFHP.s3o"
          buildPic = Some "CORFHP.DDS"
          script = Some "Units/CORFHP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
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
            { yardMap = Some "weeeew weeeew weeeew weeeew weeeew weeeew"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "120 26 108"
                collisionVolumeType = Some "Box"
                damage = Some 2014.0
                featureDead = None
                footprintX = Some 8.0
                footprintZ = Some 7.0
                height = Some 20.0
                metal = Some 715.0
                object_ = Some "Units/corfhp_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/SeaFactories"
              "unitgroup", "builder"
              "techlevel", "1.5"
          ]
          extras = Map.empty }

    let corgantuw : UnitDef =
        { name = "corgantuw"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 8350.0
          energyCost = ValueOrExpr.Concrete 62500.0
          buildTime = ValueOrExpr.Concrete 68000.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/CORGANT.s3o"
          buildPic = Some "CORGANTUW.DDS"
          script = Some "Units/corgant.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric-uw"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd-uw"
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
              buildOptions = ["corkorg"; "corshiva"; "corsala"; "corparrow"; "corsok"]
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
                footprintX = Some 9.0
                footprintZ = Some 9.0
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
                footprintX = Some 9.0
                footprintZ = Some 9.0
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
              "buildinggrounddecalsizex", "10.0"
              "buildinggrounddecalsizey", "10.0"
              "buildinggrounddecaltype", "decals/corgant_aoplane.dds"
              "model_author", "Cremuss"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/SeaFactories"
              "techlevel", "3.0"
              "unitgroup", "buildert3"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.empty }

    let corhasy : UnitDef =
        { name = "corhasy"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 5000.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 92000.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 15.0
          footprintZ = 15.0
          objectName = Some "Units/CORHASY.s3o"
          buildPic = Some "CORGANTUW.DDS"
          script = Some "Units/CORHASY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric-uw"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 12 0"
          collisionVolumeScales = Some "260 146 260"
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
              waterline = Some 1.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 600.0
              buildDistance = None
              buildOptions = ["corhacs"; "corssub"; "corbats"; "corblackhy"; "corarch"; "corfship"; "corsok"; "corantiship"; "cormship"]
              terraformSpeed = Some 3000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1400.0
              metalStorage = Some 800.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeeeeew weeeeeeeeeew"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -20 -8"
                collisionVolumeScales = Some "232 112 240"
                collisionVolumeType = Some "Box"
                damage = Some 9600.0
                featureDead = Some "HEAP"
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 8.0
                metal = Some 5101.0
                object_ = Some "Units/corhasy_dead.s3o"
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/SeaFactories"
              "techlevel", "3.0"
              "unitgroup", "buildert3"
          ]
          extras = Map.empty }

    let corplat : UnitDef =
        { name = "corplat"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 1400.0
          energyCost = ValueOrExpr.Concrete 5500.0
          buildTime = ValueOrExpr.Concrete 11800.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORPLAT.s3o"
          buildPic = Some "CORPLAT.DDS"
          script = Some "Units/CORPLAT.cob"
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
              waterline = Some 43.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = None
              buildOptions = ["corcsa"; "corcut"; "corsb"; "corseap"; "corsfig"; "corhunt"]
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
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "2.5 0.0 -0.0"
                collisionVolumeScales = Some "117.5 41.25 112.5"
                collisionVolumeType = Some "Box"
                damage = Some 1200.0
                featureDead = None
                footprintX = Some 7.0
                footprintZ = Some 7.0
                height = Some 20.0
                metal = Some 930.0
                object_ = Some "Units/corplat_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/SeaFactories"
              "unitgroup", "builder"
              "techlevel", "1.5"
          ]
          extras = Map.ofList [
              "sonardistance", "800.0"
          ] }

    let corsasy : UnitDef =
        { name = "corsasy"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 3500.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 51000.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 301.60001
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/CORASY.s3o"
          buildPic = Some "CORASY.DDS"
          script = Some "Units/CORASY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 10 -2"
          collisionVolumeScales = Some "186 78 183"
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
              waterline = Some 19.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = None
              buildOptions = ["corsacsub"; "corssub"; "corsjam"; "corbats"; "cormship"; "corblackhy"]
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -13 -3"
                collisionVolumeScales = Some "192 61 180"
                collisionVolumeType = Some "Box"
                damage = Some 2650.0
                featureDead = None
                footprintX = Some 12.0
                footprintZ = Some 12.0
                height = Some 4.0
                metal = Some 2174.0
                object_ = Some "Units/corasy_dead.s3o"
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/SeaFactories"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.empty }

    let corsy : UnitDef =
        { name = "corsy"
          subfolder = "CorBuildings/SeaFactories"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 950.0
          buildTime = ValueOrExpr.Concrete 5100.0
          health = ValueOrExpr.Concrete 4300.0
          sightDistance = ValueOrExpr.Concrete 340.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORSY.s3o"
          buildPic = Some "CORSY.DDS"
          script = Some "Units/CORSY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "96 59 96"
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
              buildOptions = ["corcs"; "correcl"; "coresupp"; "corpt"; "corpship"; "corroy"; "corsub"]
              terraformSpeed = Some 500.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = Some 100.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oyyyyo oeeeeo oeeeeo oeeeeo oeeeeo oyyyyo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -10 -4"
                collisionVolumeScales = Some "116 56 120"
                collisionVolumeType = Some "Box"
                damage = Some 1794.0
                featureDead = None
                footprintX = Some 7.0
                footprintZ = Some 7.0
                height = Some 4.0
                metal = Some 400.0
                object_ = Some "Units/corsy_dead.s3o"
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/SeaFactories"
              "unitgroup", "builder"
          ]
          extras = Map.empty }

    let all : (string * UnitDef) list =
        [
            "coramsub", coramsub
            "corasy", corasy
            "corfhp", corfhp
            "corgantuw", corgantuw
            "corhasy", corhasy
            "corplat", corplat
            "corsasy", corsasy
            "corsy", corsy
        ]
