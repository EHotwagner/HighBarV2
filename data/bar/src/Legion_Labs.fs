// Auto-generated BAR unit data: Legion/Labs (unified)
namespace BarData.Units

open BarData

module Legion_Labs =

    type Legaap =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          activateWhenBuilt: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legaap : Legaap =
        { name = "legaap"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 2900.0
          energyCost = ValueOrExpr.Concrete 28000.0
          buildTime = ValueOrExpr.Concrete 31050.0
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
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "142 50 142"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = ["legaca"; "legstronghold"; "legmineb"; "legatorpbomber"; "legafigdef"; "legwhisper"; "legfort"; "legphoenix"; "legvenator"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "142 50 142"
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
                  object_ = Some "Units/cor7X7A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["pairactv"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legaap_aoplane.dds"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert2"
                "restrictions_inclusion", "_noair_"
                "airfactory", "true"
                "model_author", "Protar/Ghoulish"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "radardistance", "1000.0"
                "radaremitheight", "50.0"
            ] }

    let legaapDef : UnitDef =
        { name = "legaap"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 2900.0
          energyCost = ValueOrExpr.Concrete 28000.0
          buildTime = ValueOrExpr.Concrete 31050.0
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
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "142 50 142"
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
              buildOptions = ["legaca"; "legstronghold"; "legmineb"; "legatorpbomber"; "legafigdef"; "legwhisper"; "legfort"; "legphoenix"; "legvenator"]
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "142 50 142"
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
                object_ = Some "Units/cor7X7A.s3o"
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
              "buildinggrounddecaltype", "decals/legaap_aoplane.dds"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "buildert2"
              "restrictions_inclusion", "_noair_"
              "airfactory", "true"
              "model_author", "Protar/Ghoulish"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "radardistance", "1000.0"
              "radaremitheight", "50.0"
          ] }

    let legaapToFlat (def: UnitDef) : Legaap =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legaapToUnitDef (flat: Legaap) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legadvshipyard =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          canMove: bool
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let legadvshipyard : Legadvshipyard =
        { name = "legadvshipyard"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 2800.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 23550.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 301.60001
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/legadvshipyard.s3o"
          buildPic = Some "legadvshipyard.DDS"
          script = Some "Units/legadvshipyard.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 10 -2"
          collisionVolumeScales = Some "186 78 183"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          canMove = true
          minWaterDepth = 30.0
          waterline = 19.0
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = []
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew"
          featureDefs = Map.ofList [
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
                  object_ = Some "Units/legadvshipyard_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["pshpactv"] }
          customParams = Map.ofList [
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ] }

    let legadvshipyardDef : UnitDef =
        { name = "legadvshipyard"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 2800.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 23550.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 301.60001
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/legadvshipyard.s3o"
          buildPic = Some "legadvshipyard.DDS"
          script = Some "Units/legadvshipyard.cob"
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
              buildOptions = []
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
                object_ = Some "Units/legadvshipyard_dead.s3o"
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
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.empty }

    let legadvshipyardToFlat (def: UnitDef) : Legadvshipyard =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          canMove = def.movement.Value.canMove
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams }

    let legadvshipyardToUnitDef (flat: Legadvshipyard) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = Map.empty }

    type Legalab =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legalab : Legalab =
        { name = "legalab"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 2600.0
          energyCost = ValueOrExpr.Concrete 16000.0
          buildTime = ValueOrExpr.Concrete 25200.0
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
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "140 52 140"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = []
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "ooooooooo ooooooooo oooeeeooo oooeeeooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "140 52 140"
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
                  object_ = Some "Units/cor7X7A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["plabactv"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legalab_aoplane.dds"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert2"
                "model_author", "Protar/Ghoulish"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
                "radardistance", "50.0"
            ] }

    let legalabDef : UnitDef =
        { name = "legalab"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 2600.0
          energyCost = ValueOrExpr.Concrete 16000.0
          buildTime = ValueOrExpr.Concrete 25200.0
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
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "140 52 140"
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "140 52 140"
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
                object_ = Some "Units/cor7X7A.s3o"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legalab_aoplane.dds"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "buildert2"
              "model_author", "Protar/Ghoulish"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "1024.0"
              "radardistance", "50.0"
          ] }

    let legalabToFlat (def: UnitDef) : Legalab =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legalabToUnitDef (flat: Legalab) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legamphlab =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          canMove: bool
          minWaterDepth: float
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let legamphlab : Legamphlab =
        { name = "legamphlab"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 1200.0
          energyCost = ValueOrExpr.Concrete 5600.0
          buildTime = ValueOrExpr.Concrete 11400.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 240.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legamphlab.s3o"
          buildPic = Some "legamphlab.DDS"
          script = Some "Units/legamphlab.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 5 0"
          collisionVolumeScales = Some "98 60 91"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 10.0
          canMove = true
          minWaterDepth = 25.0
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["legotter"; "legamphtank"; "legfloat"; "legamph"; "legaabot"; "legadvaabot"; "legdecom"]
          terraformSpeed = 750.0
          energyStorage = 160.0
          yardMap = "oooooo oooooo oeeeeo oeeeeo oeeeeo oeeeeo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "96 44 89"
                  collisionVolumeType = Some "Box"
                  damage = Some 1500.0
                  featureDead = None
                  footprintX = Some 7.0
                  footprintZ = Some 7.0
                  height = Some 5.0
                  metal = Some 800.0
                  object_ = Some "Units/legamphlab_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["pvehactv"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legamphlab_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "ZephyrSkies, Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "1.5"
            ] }

    let legamphlabDef : UnitDef =
        { name = "legamphlab"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 1200.0
          energyCost = ValueOrExpr.Concrete 5600.0
          buildTime = ValueOrExpr.Concrete 11400.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 240.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legamphlab.s3o"
          buildPic = Some "legamphlab.DDS"
          script = Some "Units/legamphlab.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 5 0"
          collisionVolumeScales = Some "98 60 91"
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
            { workerTime = ValueOrExpr.Concrete 150.0
              buildDistance = None
              buildOptions = ["legotter"; "legamphtank"; "legfloat"; "legamph"; "legaabot"; "legadvaabot"; "legdecom"]
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "96 44 89"
                collisionVolumeType = Some "Box"
                damage = Some 1500.0
                featureDead = None
                footprintX = Some 7.0
                footprintZ = Some 7.0
                height = Some 5.0
                metal = Some 800.0
                object_ = Some "Units/legamphlab_dead.s3o"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legamphlab_aoplane.dds"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "builder"
              "model_author", "ZephyrSkies, Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
              "techlevel", "1.5"
          ]
          extras = Map.empty }

    let legamphlabToFlat (def: UnitDef) : Legamphlab =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          canMove = def.movement.Value.canMove
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams }

    let legamphlabToUnitDef (flat: Legamphlab) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = Map.empty }

    type Legap =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          activateWhenBuilt: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legap : Legap =
        { name = "legap"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 430.0
          energyCost = ValueOrExpr.Concrete 1100.0
          buildTime = ValueOrExpr.Concrete 6380.0
          health = ValueOrExpr.Concrete 1780.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/LEGAP.s3o"
          buildPic = Some "LEGAP.DDS"
          script = Some "Units/LEGAP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "96 45 96"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["legca"; "legfig"; "legkam"; "legcib"; "legmos"; "leglts"; "legatrans"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "oooooo oooooo oooooo oooooo oooooo oooooo"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "96 45 96"
                  collisionVolumeType = Some "Box"
                  damage = Some 1155.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 540.0
                  object_ = Some "Units/legap_dead.s3o"
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
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["airplantselect"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legap_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "restrictions_inclusion", "_noair_"
                "airfactory", "true"
                "model_author", "Protar/Ghoulish"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
            ]
          extras = Map.ofList [
                "sightemitheight", "40.0"
                "radardistance", "510.0"
                "radaremitheight", "40.0"
            ] }

    let legapDef : UnitDef =
        { name = "legap"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 430.0
          energyCost = ValueOrExpr.Concrete 1100.0
          buildTime = ValueOrExpr.Concrete 6380.0
          health = ValueOrExpr.Concrete 1780.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/LEGAP.s3o"
          buildPic = Some "LEGAP.DDS"
          script = Some "Units/LEGAP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "96 45 96"
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
              buildOptions = ["legca"; "legfig"; "legkam"; "legcib"; "legmos"; "leglts"; "legatrans"]
              terraformSpeed = Some 500.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = Some 100.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooo oooooo oooooo oooooo oooooo oooooo"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "96 45 96"
                collisionVolumeType = Some "Box"
                damage = Some 1155.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 540.0
                object_ = Some "Units/legap_dead.s3o"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legap_aoplane.dds"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "builder"
              "restrictions_inclusion", "_noair_"
              "airfactory", "true"
              "model_author", "Protar/Ghoulish"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
          ]
          extras = Map.ofList [
              "sightemitheight", "40.0"
              "radardistance", "510.0"
              "radaremitheight", "40.0"
          ] }

    let legapToFlat (def: UnitDef) : Legap =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legapToUnitDef (flat: Legap) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legavp =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legavp : Legavp =
        { name = "legavp"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 16000.0
          buildTime = ValueOrExpr.Concrete 27750.0
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
          collisionVolumeOffsets = Some "0 0 5"
          collisionVolumeScales = Some "144 70 144"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = []
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "h\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        "
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 5"
                  collisionVolumeScales = Some "144 70 144"
                  collisionVolumeType = Some "Box"
                  damage = Some 2777.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
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
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 860.0
                  object_ = Some "Units/cor6X6C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["pvehactv"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/legavp_aoplane.dds"
                "buildinggrounddecalsizey", "12.0"
                "buildinggrounddecalsizex", "12.0"
                "buildinggrounddecaldecayspeed", "0.01"
                "unitgroup", "buildert2"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
                "levelground", "false"
                "radardistance", "50.0"
            ] }

    let legavpDef : UnitDef =
        { name = "legavp"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 16000.0
          buildTime = ValueOrExpr.Concrete 27750.0
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
          collisionVolumeOffsets = Some "0 0 5"
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
              buildOptions = []
              terraformSpeed = Some 1000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = Some 200.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "h\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        "
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 5"
                collisionVolumeScales = Some "144 70 144"
                collisionVolumeType = Some "Box"
                damage = Some 2777.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
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
                footprintX = Some 6.0
                footprintZ = Some 6.0
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
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/legavp_aoplane.dds"
              "buildinggrounddecalsizey", "12.0"
              "buildinggrounddecalsizex", "12.0"
              "buildinggrounddecaldecayspeed", "0.01"
              "unitgroup", "buildert2"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "1024.0"
              "levelground", "false"
              "radardistance", "50.0"
          ] }

    let legavpToFlat (def: UnitDef) : Legavp =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legavpToUnitDef (flat: Legavp) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legfhp =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          canMove: bool
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let legfhp : Legfhp =
        { name = "legfhp"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 670.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 8700.0
          health = ValueOrExpr.Concrete 3750.0
          sightDistance = ValueOrExpr.Concrete 312.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legfhp.s3o"
          buildPic = Some "LEGFHP.DDS"
          script = Some "Units/legfhp.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "96 35 96"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          canMove = true
          minWaterDepth = 5.0
          waterline = 4.0
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["legch"; "legsh"; "legner"; "legah"; "legmh"; "legcar"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "weeeew weeeew weeeew weeeew weeeew weeeew"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "96 35 96"
                  collisionVolumeType = Some "Box"
                  damage = Some 2014.0
                  featureDead = None
                  footprintX = Some 8.0
                  footprintZ = Some 7.0
                  height = Some 20.0
                  metal = Some 715.0
                  object_ = Some "Units/legfhp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
            ]
          sounds =
              { build = Some "hoverok2"
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["hoversl2"] }
          customParams = Map.ofList [
                "unitgroup", "builder"
                "model_author", "Protar, ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "1.5"
            ] }

    let legfhpDef : UnitDef =
        { name = "legfhp"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 670.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 8700.0
          health = ValueOrExpr.Concrete 3750.0
          sightDistance = ValueOrExpr.Concrete 312.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legfhp.s3o"
          buildPic = Some "LEGFHP.DDS"
          script = Some "Units/legfhp.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "96 35 96"
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
              buildOptions = ["legch"; "legsh"; "legner"; "legah"; "legmh"; "legcar"]
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
                collisionVolumeScales = Some "96 35 96"
                collisionVolumeType = Some "Box"
                damage = Some 2014.0
                featureDead = None
                footprintX = Some 8.0
                footprintZ = Some 7.0
                height = Some 20.0
                metal = Some 715.0
                object_ = Some "Units/legfhp_dead.s3o"
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
              "unitgroup", "builder"
              "model_author", "Protar, ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
              "techlevel", "1.5"
          ]
          extras = Map.empty }

    let legfhpToFlat (def: UnitDef) : Legfhp =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          canMove = def.movement.Value.canMove
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams }

    let legfhpToUnitDef (flat: Legfhp) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = Map.empty }

    type Leggant =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let leggant : Leggant =
        { name = "leggant"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 8400.0
          energyCost = ValueOrExpr.Concrete 62000.0
          buildTime = ValueOrExpr.Concrete 67300.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/LEGGANT.s3o"
          buildPic = Some "LEGGANT.DDS"
          script = Some "Units/LEGGANT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 12 0"
          collisionVolumeScales = Some "196 105 196"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 1800.0
          buildOptions = []
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 12 0"
                  collisionVolumeScales = Some "190 100 190"
                  collisionVolumeType = Some "Box"
                  damage = Some 9600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 5101.0
                  object_ = Some "Units/leggant_dead.s3o"
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
            ]
          sounds =
              { build = Some "gantok2"
                repair = Some "lathelrg"
                working = Some "build"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["gantsel1"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/leggant_aoplane.dds"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecalsizex", "15.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert3"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
            ] }

    let leggantDef : UnitDef =
        { name = "leggant"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 8400.0
          energyCost = ValueOrExpr.Concrete 62000.0
          buildTime = ValueOrExpr.Concrete 67300.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/LEGGANT.s3o"
          buildPic = Some "LEGGANT.DDS"
          script = Some "Units/LEGGANT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 12 0"
          collisionVolumeScales = Some "196 105 196"
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
              buildOptions = []
              terraformSpeed = Some 3000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1400.0
              metalStorage = Some 800.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 12 0"
                collisionVolumeScales = Some "190 100 190"
                collisionVolumeType = Some "Box"
                damage = Some 9600.0
                featureDead = Some "HEAP"
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 20.0
                metal = Some 5101.0
                object_ = Some "Units/leggant_dead.s3o"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/leggant_aoplane.dds"
              "buildinggrounddecalsizey", "15.0"
              "buildinggrounddecalsizex", "15.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "buildert3"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "radardistance", "50.0"
          ] }

    let leggantToFlat (def: UnitDef) : Leggant =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let leggantToUnitDef (flat: Leggant) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Leggantuw =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          canMove: bool
          minWaterDepth: float
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let leggantuw : Leggantuw =
        { name = "leggantuw"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 8400.0
          energyCost = ValueOrExpr.Concrete 62000.0
          buildTime = ValueOrExpr.Concrete 67300.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/LEGGANT.s3o"
          buildPic = Some "LEGGANTUW.DDS"
          script = Some "Units/LEGGANT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 12 0"
          collisionVolumeScales = Some "196 105 196"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 10.0
          canMove = true
          minWaterDepth = 30.0
          workerTime = ValueOrExpr.Concrete 1800.0
          buildOptions = []
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 12 0"
                  collisionVolumeScales = Some "190 100 190"
                  collisionVolumeType = Some "Box"
                  damage = Some 9600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 5101.0
                  object_ = Some "Units/leggant_dead.s3o"
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
            ]
          sounds =
              { build = Some "gantok2"
                repair = Some "lathelrg"
                working = Some "build"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["gantsel1"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/leggant_aoplane.dds"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecalsizex", "15.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert3"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
            ] }

    let leggantuwDef : UnitDef =
        { name = "leggantuw"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 8400.0
          energyCost = ValueOrExpr.Concrete 62000.0
          buildTime = ValueOrExpr.Concrete 67300.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/LEGGANT.s3o"
          buildPic = Some "LEGGANTUW.DDS"
          script = Some "Units/LEGGANT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 12 0"
          collisionVolumeScales = Some "196 105 196"
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
              buildOptions = []
              terraformSpeed = Some 3000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1400.0
              metalStorage = Some 800.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 12 0"
                collisionVolumeScales = Some "190 100 190"
                collisionVolumeType = Some "Box"
                damage = Some 9600.0
                featureDead = Some "HEAP"
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 20.0
                metal = Some 5101.0
                object_ = Some "Units/leggant_dead.s3o"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/leggant_aoplane.dds"
              "buildinggrounddecalsizey", "15.0"
              "buildinggrounddecalsizex", "15.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "buildert3"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "radardistance", "50.0"
          ] }

    let leggantuwToFlat (def: UnitDef) : Leggantuw =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          canMove = def.movement.Value.canMove
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let leggantuwToUnitDef (flat: Leggantuw) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Leghalab =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let leghalab : Leghalab =
        { name = "leghalab"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 4900.0
          energyCost = ValueOrExpr.Concrete 62000.0
          buildTime = ValueOrExpr.Concrete 67300.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/LEGGANT.s3o"
          buildPic = Some "LEGGANT.DDS"
          script = Some "Units/LEGGANT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 12 0"
          collisionVolumeScales = Some "196 105 196"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 1200.0
          buildOptions = ["leghack"; "leginc"; "legsrail"; "legajamk"; "legdecom"; "legadvaabot"; "legjav"; "legshot"; "legamph"; "legaspy"]
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 12 0"
                  collisionVolumeScales = Some "190 100 190"
                  collisionVolumeType = Some "Box"
                  damage = Some 9600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 5101.0
                  object_ = Some "Units/leggant_dead.s3o"
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
            ]
          sounds =
              { build = Some "gantok2"
                repair = Some "lathelrg"
                working = Some "build"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["gantsel1"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/leggant_aoplane.dds"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecalsizex", "15.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert3"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
            ] }

    let leghalabDef : UnitDef =
        { name = "leghalab"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 4900.0
          energyCost = ValueOrExpr.Concrete 62000.0
          buildTime = ValueOrExpr.Concrete 67300.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/LEGGANT.s3o"
          buildPic = Some "LEGGANT.DDS"
          script = Some "Units/LEGGANT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 12 0"
          collisionVolumeScales = Some "196 105 196"
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
              buildOptions = ["leghack"; "leginc"; "legsrail"; "legajamk"; "legdecom"; "legadvaabot"; "legjav"; "legshot"; "legamph"; "legaspy"]
              terraformSpeed = Some 3000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1400.0
              metalStorage = Some 800.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 12 0"
                collisionVolumeScales = Some "190 100 190"
                collisionVolumeType = Some "Box"
                damage = Some 9600.0
                featureDead = Some "HEAP"
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 20.0
                metal = Some 5101.0
                object_ = Some "Units/leggant_dead.s3o"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/leggant_aoplane.dds"
              "buildinggrounddecalsizey", "15.0"
              "buildinggrounddecalsizex", "15.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "buildert3"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "radardistance", "50.0"
          ] }

    let leghalabToFlat (def: UnitDef) : Leghalab =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let leghalabToUnitDef (flat: Leghalab) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Leghavp =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let leghavp : Leghavp =
        { name = "leghavp"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 4900.0
          energyCost = ValueOrExpr.Concrete 46000.0
          buildTime = ValueOrExpr.Concrete 67300.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/LEGHAVP.s3o"
          buildPic = Some "LEGHAVP.DDS"
          script = Some "Units/LEGHAVP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 12 0"
          collisionVolumeScales = Some "196 105 196"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 600.0
          buildOptions = ["leghacv"; "legaheattank"; "legmed"; "legavroc"; "leginf"; "legvflak"; "legavantinuke"; "legavjam"; "legmrv"; "legehovertank"]
          terraformSpeed = 3000.0
          energyStorage = 1400.0
          metalStorage = 800.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 12 0"
                  collisionVolumeScales = Some "190 100 190"
                  collisionVolumeType = Some "Box"
                  damage = Some 9600.0
                  featureDead = Some "HEAP"
                  footprintX = Some 9.0
                  footprintZ = Some 9.0
                  height = Some 20.0
                  metal = Some 5101.0
                  object_ = Some "Units/leghavp_dead.s3o"
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
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["pvehactv"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legamphlab_aoplane.dds"
                "buildinggrounddecalsizey", "15.0"
                "buildinggrounddecalsizex", "15.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "buildert3"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "3.0"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
            ] }

    let leghavpDef : UnitDef =
        { name = "leghavp"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 4900.0
          energyCost = ValueOrExpr.Concrete 46000.0
          buildTime = ValueOrExpr.Concrete 67300.0
          health = ValueOrExpr.Concrete 17800.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/LEGHAVP.s3o"
          buildPic = Some "LEGHAVP.DDS"
          script = Some "Units/LEGHAVP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 12 0"
          collisionVolumeScales = Some "196 105 196"
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
              buildOptions = ["leghacv"; "legaheattank"; "legmed"; "legavroc"; "leginf"; "legvflak"; "legavantinuke"; "legavjam"; "legmrv"; "legehovertank"]
              terraformSpeed = Some 3000.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1400.0
              metalStorage = Some 800.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 12 0"
                collisionVolumeScales = Some "190 100 190"
                collisionVolumeType = Some "Box"
                damage = Some 9600.0
                featureDead = Some "HEAP"
                footprintX = Some 9.0
                footprintZ = Some 9.0
                height = Some 20.0
                metal = Some 5101.0
                object_ = Some "Units/leghavp_dead.s3o"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legamphlab_aoplane.dds"
              "buildinggrounddecalsizey", "15.0"
              "buildinggrounddecalsizex", "15.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "buildert3"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
              "techlevel", "3.0"
          ]
          extras = Map.ofList [
              "radardistance", "50.0"
          ] }

    let leghavpToFlat (def: UnitDef) : Leghavp =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let leghavpToUnitDef (flat: Leghavp) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Leghp =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let leghp : Leghp =
        { name = "leghp"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 670.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 8700.0
          health = ValueOrExpr.Concrete 3750.0
          sightDistance = ValueOrExpr.Concrete 312.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/LEGHP.s3o"
          buildPic = Some "LEGHP.DDS"
          script = Some "Units/LEGHP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "96 35 96"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["legch"; "legsh"; "legner"; "legah"; "legmh"; "legcar"]
          terraformSpeed = 1000.0
          energyStorage = 200.0
          metalStorage = 200.0
          yardMap = "oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "96 35 96"
                  collisionVolumeType = Some "Box"
                  damage = Some 2014.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 20.0
                  metal = Some 662.0
                  object_ = Some "Units/leghp_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = Some "0 5 0"
                  collisionVolumeScales = Some "96 12 96"
                  collisionVolumeType = Some "Box"
                  damage = Some 1007.0
                  featureDead = None
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 265.0
                  object_ = Some "Units/cor7X7D.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "hoverok2"
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["hoversl2"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/leghp_aoplane.dds"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecalsizex", "8.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "Protar"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "techlevel", "1.5"
            ] }

    let leghpDef : UnitDef =
        { name = "leghp"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 670.0
          energyCost = ValueOrExpr.Concrete 2000.0
          buildTime = ValueOrExpr.Concrete 8700.0
          health = ValueOrExpr.Concrete 3750.0
          sightDistance = ValueOrExpr.Concrete 312.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/LEGHP.s3o"
          buildPic = Some "LEGHP.DDS"
          script = Some "Units/LEGHP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "96 35 96"
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
              buildOptions = ["legch"; "legsh"; "legner"; "legah"; "legmh"; "legcar"]
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
                collisionVolumeScales = Some "96 35 96"
                collisionVolumeType = Some "Box"
                damage = Some 2014.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 662.0
                object_ = Some "Units/leghp_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = Some "0 5 0"
                collisionVolumeScales = Some "96 12 96"
                collisionVolumeType = Some "Box"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/leghp_aoplane.dds"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "builder"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
              "techlevel", "1.5"
          ]
          extras = Map.empty }

    let leghpToFlat (def: UnitDef) : Leghp =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams }

    let leghpToUnitDef (flat: Leghp) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = Map.empty }

    type Leglab =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let leglab : Leglab =
        { name = "leglab"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 470.0
          energyCost = ValueOrExpr.Concrete 1050.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 2900.0
          sightDistance = ValueOrExpr.Concrete 290.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/LEGLAB.s3o"
          buildPic = Some "LEGLAB.DDS"
          script = Some "Units/LEGLAB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 5 0"
          collisionVolumeScales = Some "100 45 100"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["legck"; "legrezbot"; "leggob"; "leglob"; "legcen"; "legbal"; "legkark"; "legaabot"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "oooooo oooooo oeeeeo oeeeeo oeeeeo oeeeeo"
          featureDefs = Map.ofList [
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
                  object_ = Some "Units/leglab_dead.s3o"
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
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["labselect"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/leglab_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "CorBuildings/LandFactories"
            ]
          extras = Map.ofList [
                "buildangle", "1024.0"
                "radardistance", "50.0"
            ] }

    let leglabDef : UnitDef =
        { name = "leglab"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 470.0
          energyCost = ValueOrExpr.Concrete 1050.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 2900.0
          sightDistance = ValueOrExpr.Concrete 290.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/LEGLAB.s3o"
          buildPic = Some "LEGLAB.DDS"
          script = Some "Units/LEGLAB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 5 0"
          collisionVolumeScales = Some "100 45 100"
          collisionVolumeType = Some "CylY"
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
              buildOptions = ["legck"; "legrezbot"; "leggob"; "leglob"; "legcen"; "legbal"; "legkark"; "legaabot"]
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "88 28 88"
                collisionVolumeType = Some "Box"
                damage = Some 1560.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 442.0
                object_ = Some "Units/leglab_dead.s3o"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/leglab_aoplane.dds"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "builder"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorBuildings/LandFactories"
          ]
          extras = Map.ofList [
              "buildangle", "1024.0"
              "radardistance", "50.0"
          ] }

    let leglabToFlat (def: UnitDef) : Leglab =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let leglabToUnitDef (flat: Leglab) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legsplab =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          canMove: bool
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legsplab : Legsplab =
        { name = "legsplab"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 1400.0
          energyCost = ValueOrExpr.Concrete 5500.0
          buildTime = ValueOrExpr.Concrete 11800.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legsplab.s3o"
          buildPic = Some "legsplab.DDS"
          script = Some "Units/legsplab.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "SURFACE UNDERWATER"
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          canMove = true
          minWaterDepth = 30.0
          waterline = 0.0
          workerTime = ValueOrExpr.Concrete 300.0
          buildOptions = []
          terraformSpeed = 1000.0
          energyStorage = 200.0
          yardMap = "wwwwww weeeew weeeew weeeew weeeew wwwwww"
          activateWhenBuilt = true
          featureDefs = Map.ofList [
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
                  object_ = Some "Units/legsplab_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
            ]
          sounds =
              { build = Some "seaplok2"
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["seaplsl2"] }
          customParams = Map.ofList [
                "airfactory", "true"
                "model_author", "ZephyrSkies"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "unitgroup", "builder"
                "restrictions_inclusion", "_noair_"
                "techlevel", "1.5"
            ]
          extras = Map.ofList [
                "sonardistance", "800.0"
            ] }

    let legsplabDef : UnitDef =
        { name = "legsplab"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 1400.0
          energyCost = ValueOrExpr.Concrete 5500.0
          buildTime = ValueOrExpr.Concrete 11800.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 169.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legsplab.s3o"
          buildPic = Some "legsplab.DDS"
          script = Some "Units/legsplab.cob"
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
              waterline = Some 0.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = None
              buildOptions = []
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
                object_ = Some "Units/legsplab_dead.s3o"
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
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
              "unitgroup", "builder"
              "restrictions_inclusion", "_noair_"
              "techlevel", "1.5"
          ]
          extras = Map.ofList [
              "sonardistance", "800.0"
          ] }

    let legsplabToFlat (def: UnitDef) : Legsplab =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          canMove = def.movement.Value.canMove
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legsplabToUnitDef (flat: Legsplab) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Legsy =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          canMove: bool
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string> }

    let legsy : Legsy =
        { name = "legsy"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 950.0
          buildTime = ValueOrExpr.Concrete 5100.0
          health = ValueOrExpr.Concrete 4300.0
          sightDistance = ValueOrExpr.Concrete 340.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legsy.s3o"
          buildPic = Some "legsy.DDS"
          script = Some "Units/legsy.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "96 42 96"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          canMove = true
          minWaterDepth = 30.0
          waterline = 1.0
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["legnavyconship"; "legnavyrezsub"; "legnavyscout"; "legnavyaaship"; "legnavyfrigate"; "legnavydestro"; "legnavysub"; "legnavyartyship"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "oyyyyo oeeeeo oeeeeo oeeeeo oeeeeo oyyyyo"
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "103 42 103"
                  collisionVolumeType = Some "Box"
                  damage = Some 1794.0
                  featureDead = None
                  footprintX = Some 7.0
                  footprintZ = Some 7.0
                  height = Some 4.0
                  metal = Some 400.0
                  object_ = Some "Units/legsy_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["pshpactv"] }
          customParams = Map.ofList [
                "model_author", "Tharsis"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
                "unitgroup", "builder"
            ] }

    let legsyDef : UnitDef =
        { name = "legsy"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 950.0
          buildTime = ValueOrExpr.Concrete 5100.0
          health = ValueOrExpr.Concrete 4300.0
          sightDistance = ValueOrExpr.Concrete 340.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legsy.s3o"
          buildPic = Some "legsy.DDS"
          script = Some "Units/legsy.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "96 42 96"
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
              buildOptions = ["legnavyconship"; "legnavyrezsub"; "legnavyscout"; "legnavyaaship"; "legnavyfrigate"; "legnavydestro"; "legnavysub"; "legnavyartyship"]
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "103 42 103"
                collisionVolumeType = Some "Box"
                damage = Some 1794.0
                featureDead = None
                footprintX = Some 7.0
                footprintZ = Some 7.0
                height = Some 4.0
                metal = Some 400.0
                object_ = Some "Units/legsy_dead.s3o"
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
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
              "unitgroup", "builder"
          ]
          extras = Map.empty }

    let legsyToFlat (def: UnitDef) : Legsy =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          canMove = def.movement.Value.canMove
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams }

    let legsyToUnitDef (flat: Legsy) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = Map.empty }

    type Legvp =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          speed: ValueOrExpr<float>
          maxAcc: float
          maxDec: float
          turnRate: float
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          workerTime: ValueOrExpr<float>
          buildOptions: string list
          terraformSpeed: float
          energyStorage: float
          metalStorage: float
          yardMap: string
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legvp : Legvp =
        { name = "legvp"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 570.0
          energyCost = ValueOrExpr.Concrete 1650.0
          buildTime = ValueOrExpr.Concrete 5700.0
          health = ValueOrExpr.Concrete 3000.0
          sightDistance = ValueOrExpr.Concrete 279.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/LEGVP.s3o"
          buildPic = Some "LEGVP.DDS"
          script = Some "Units/LEGVP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 19 0"
          collisionVolumeScales = Some "101 53 106"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canMove = true
          workerTime = ValueOrExpr.Concrete 150.0
          buildOptions = ["legscout"; "legcv"; "legotter"; "leghades"; "leghelios"; "leggat"; "legbar"; "legrail"; "legmlv"; "legamphtank"]
          terraformSpeed = 500.0
          energyStorage = 100.0
          metalStorage = 100.0
          yardMap = "h\r\n    oo oo oo oo oo oo\r\n    oo oo oo oo oo oo\r\n    oo oo oo oo oo oo\r\n    oo oo oo oo oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    "
          featureDefs = Map.ofList [
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
                  object_ = Some "Units/legvp_dead.s3o"
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
            ]
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = []
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = []
                select = ["vehplantselect"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/legvp_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "Protar/Ghoulish"
                "normaltex", "unittextures/leg_normal.dds"
                "subfolder", "Legion/Labs"
            ]
          extras = Map.ofList [
                "buildangle", "2048.0"
                "levelground", "true"
                "radardistance", "50.0"
            ] }

    let legvpDef : UnitDef =
        { name = "legvp"
          subfolder = "Legion/Labs"
          metalCost = ValueOrExpr.Concrete 570.0
          energyCost = ValueOrExpr.Concrete 1650.0
          buildTime = ValueOrExpr.Concrete 5700.0
          health = ValueOrExpr.Concrete 3000.0
          sightDistance = ValueOrExpr.Concrete 279.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/LEGVP.s3o"
          buildPic = Some "LEGVP.DDS"
          script = Some "Units/LEGVP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 19 0"
          collisionVolumeScales = Some "101 53 106"
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
              buildOptions = ["legscout"; "legcv"; "legotter"; "leghades"; "leghelios"; "leggat"; "legbar"; "legrail"; "legmlv"; "legamphtank"]
              terraformSpeed = Some 500.0 })
          weapons = None
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 100.0
              metalStorage = Some 100.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "h\r\n    oo oo oo oo oo oo\r\n    oo oo oo oo oo oo\r\n    oo oo oo oo oo oo\r\n    oo oo oo oo oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    "
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
                object_ = Some "Units/legvp_dead.s3o"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legvp_aoplane.dds"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "builder"
              "model_author", "Protar/Ghoulish"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Labs"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "levelground", "true"
              "radardistance", "50.0"
          ] }

    let legvpToFlat (def: UnitDef) : Legvp =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          speed = def.movement.Value.speed
          maxAcc = def.movement.Value.maxAcc
          maxDec = def.movement.Value.maxDec
          turnRate = def.movement.Value.turnRate
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          workerTime = def.builder.Value.workerTime
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legvpToUnitDef (flat: Legvp) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = Some {
              speed = flat.speed
              maxAcc = flat.maxAcc
              maxDec = flat.maxDec
              turnRate = flat.turnRate
              movementClass = None
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = None
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = None
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = None
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

