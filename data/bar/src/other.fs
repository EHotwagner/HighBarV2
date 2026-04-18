// Auto-generated BAR unit data: other (unified)
namespace BarData.Units

open BarData

module other =

    type Armrespawn =
        { name: string
          subfolder: string
          printableName: string option
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
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armrespawn : Armrespawn =
        { name = "armrespawn"
          subfolder = "other"
          printableName = Some "Base Builder"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 20000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Expr "range"
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMRESPAWN.s3o"
          buildPic = Some "ARMNANOTCPLAT.DDS"
          script = Some "Units/ARMNANOT2.cob"
          corpse = None
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "31 50 31"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["varmmove"]
                select = ["varmsel"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/armnanotc_aoplane.dds"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmBuildings/SeaUtil"
            ]
          extras = Map.ofList [
                "canassist", "true"
                "canfight", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canreclaim", "true"
                "canstop", "true"
                "cantbetransported", "true"
                "mass", "700.0"
                "upright", "true"
            ] }

    let armrespawnDef : UnitDef =
        { name = "armrespawn"
          subfolder = "other"
          printableName = Some "Base Builder"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 20000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Expr "range"
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMRESPAWN.s3o"
          buildPic = Some "ARMNANOTCPLAT.DDS"
          script = Some "Units/ARMNANOT2.cob"
          corpse = None
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderExplosion"
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
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/armnanotc_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "builder"
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmBuildings/SeaUtil"
          ]
          extras = Map.ofList [
              "canassist", "true"
              "canfight", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canreclaim", "true"
              "canstop", "true"
              "cantbetransported", "true"
              "mass", "700.0"
              "upright", "true"
          ] }

    let armrespawnToFlat (def: UnitDef) : Armrespawn =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armrespawnToUnitDef (flat: Armrespawn) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armsat =
        { name: string
          subfolder: string
          printableName: string option
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
          canFly: bool
          canMove: bool
          cruiseAltitude: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armsat : Armsat =
        { name = "armsat"
          subfolder = "other"
          printableName = Some "Satellite"
          metalCost = ValueOrExpr.Concrete 4000.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 12800.0
          health = ValueOrExpr.Concrete 780.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMSAT.s3o"
          buildPic = Some "ARMAWAC.DDS"
          script = Some "Units/ARMSAT.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.05
          maxDec = 0.01
          turnRate = 80.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 2700.0
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolarmv"]
                select = ["aaradsel"] }
          customParams = Map.ofList [
                "unitgroup", "util"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "other"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "acceleration", "0.05"
                "airhoverfactor", "0.4"
                "blocking", "false"
                "capturable", "false"
                "collide", "false"
                "hoverattack", "true"
                "maxaileron", "0.01"
                "maxbank", "0.15"
                "maxelevator", "0.004"
                "maxpitch", "0.1"
                "maxrudder", "0.003"
                "radardistance", "700.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonardistance", "0.0"
                "speedtofront", "0.04"
                "turnradius", "200.0"
                "usesmoothmesh", "true"
                "wingangle", "0.05"
                "wingdrag", "0.1"
            ] }

    let armsatDef : UnitDef =
        { name = "armsat"
          subfolder = "other"
          printableName = Some "Satellite"
          metalCost = ValueOrExpr.Concrete 4000.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 12800.0
          health = ValueOrExpr.Concrete 780.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMSAT.s3o"
          buildPic = Some "ARMAWAC.DDS"
          script = Some "Units/ARMSAT.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.05
              maxDec = 0.01
              turnRate = 80.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 2700.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
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
              ok = ["vtolarmv"]
              select = ["aaradsel"] })
          customParams = Map.ofList [
              "unitgroup", "util"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "other"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "acceleration", "0.05"
              "airhoverfactor", "0.4"
              "blocking", "false"
              "capturable", "false"
              "collide", "false"
              "hoverattack", "true"
              "maxaileron", "0.01"
              "maxbank", "0.15"
              "maxelevator", "0.004"
              "maxpitch", "0.1"
              "maxrudder", "0.003"
              "radardistance", "700.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonardistance", "0.0"
              "speedtofront", "0.04"
              "turnradius", "200.0"
              "usesmoothmesh", "true"
              "wingangle", "0.05"
              "wingdrag", "0.1"
          ] }

    let armsatToFlat (def: UnitDef) : Armsat =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armsatToUnitDef (flat: Armsat) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Chip =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let chip : Chip =
        { name = "chip"
          subfolder = "other"
          printableName = Some "Chip"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "chip.s3o"
          buildPic = Some "other/chip.dds"
          script = Some "chip.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "12 1.7 12"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "unitgroup", "util"
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "25.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let chipDef : UnitDef =
        { name = "chip"
          subfolder = "other"
          printableName = Some "Chip"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "chip.s3o"
          buildPic = Some "other/chip.dds"
          script = Some "chip.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "12 1.7 12"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "unitgroup", "util"
              "model_author", "Floris"
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "25.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let chipToFlat (def: UnitDef) : Chip =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let chipToUnitDef (flat: Chip) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Correspawn =
        { name: string
          subfolder: string
          printableName: string option
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
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let correspawn : Correspawn =
        { name = "correspawn"
          subfolder = "other"
          printableName = Some "Base Builder"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 20000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Expr "range"
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORRESPAWN.s3o"
          buildPic = Some "CORNANOTCPLAT.DDS"
          script = Some "Units/CORNANOT2.cob"
          corpse = None
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "31 50 31"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vcormove"]
                select = ["vcorsel"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/cornanotc_aoplane.dds"
                "buildinggrounddecalsizey", "5.0"
                "buildinggrounddecalsizex", "5.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "unitgroup", "builder"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
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
                "mass", "700.0"
                "upright", "true"
            ] }

    let correspawnDef : UnitDef =
        { name = "correspawn"
          subfolder = "other"
          printableName = Some "Base Builder"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 20000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Expr "range"
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORRESPAWN.s3o"
          buildPic = Some "CORNANOTCPLAT.DDS"
          script = Some "Units/CORNANOT2.cob"
          corpse = None
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderExplosion"
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
              "buildinggrounddecaltype", "decals/cornanotc_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "builder"
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
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
              "mass", "700.0"
              "upright", "true"
          ] }

    let correspawnToFlat (def: UnitDef) : Correspawn =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let correspawnToUnitDef (flat: Correspawn) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corsat =
        { name: string
          subfolder: string
          printableName: string option
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
          canFly: bool
          canMove: bool
          cruiseAltitude: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corsat : Corsat =
        { name = "corsat"
          subfolder = "other"
          printableName = Some "Satellite"
          metalCost = ValueOrExpr.Concrete 4000.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 12800.0
          health = ValueOrExpr.Concrete 780.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/corsat.s3o"
          buildPic = Some "CORAWAC.DDS"
          script = Some "Units/corsat.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.05
          maxDec = 0.01
          turnRate = 80.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 2700.0
          sounds =
              { build = None
                repair = None
                working = None
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolcrmv"]
                select = ["aaradsel"] }
          customParams = Map.ofList [
                "unitgroup", "util"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "acceleration", "0.05"
                "airhoverfactor", "0.4"
                "blocking", "false"
                "capturable", "false"
                "collide", "false"
                "hoverattack", "true"
                "maxaileron", "0.01"
                "maxbank", "0.15"
                "maxelevator", "0.004"
                "maxpitch", "0.1"
                "maxrudder", "0.003"
                "radardistance", "580.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonardistance", "0.0"
                "speedtofront", "0.04"
                "turnradius", "200.0"
                "usesmoothmesh", "true"
                "wingangle", "0.05"
                "wingdrag", "0.1"
            ] }

    let corsatDef : UnitDef =
        { name = "corsat"
          subfolder = "other"
          printableName = Some "Satellite"
          metalCost = ValueOrExpr.Concrete 4000.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 12800.0
          health = ValueOrExpr.Concrete 780.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/corsat.s3o"
          buildPic = Some "CORAWAC.DDS"
          script = Some "Units/corsat.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.05
              maxDec = 0.01
              turnRate = 80.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 2700.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
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
              ok = ["vtolcrmv"]
              select = ["aaradsel"] })
          customParams = Map.ofList [
              "unitgroup", "util"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "acceleration", "0.05"
              "airhoverfactor", "0.4"
              "blocking", "false"
              "capturable", "false"
              "collide", "false"
              "hoverattack", "true"
              "maxaileron", "0.01"
              "maxbank", "0.15"
              "maxelevator", "0.004"
              "maxpitch", "0.1"
              "maxrudder", "0.003"
              "radardistance", "580.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonardistance", "0.0"
              "speedtofront", "0.04"
              "turnradius", "200.0"
              "usesmoothmesh", "true"
              "wingangle", "0.05"
              "wingdrag", "0.1"
          ] }

    let corsatToFlat (def: UnitDef) : Corsat =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corsatToUnitDef (flat: Corsat) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Dbg_sphere =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let dbg_sphere : Dbg_sphere =
        { name = "dbg_sphere"
          subfolder = "other"
          printableName = Some "dbg_sphere"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 3400.0
          buildTime = ValueOrExpr.Concrete 5090.0
          health = ValueOrExpr.Concrete 940.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "dbg_sphere.s3o"
          buildPic = Some "ARMSPID.DDS"
          script = None
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "28 15 28"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 71.55
          maxAcc = 0.207
          maxDec = 0.6486
          turnRate = 1290.29993
          movementClass = "TBOT3"
          maxWaterDepth = 16.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.749
          customParams = Map.ofList [
                "model_author", "Beherith"
                "nohealthbars", "true"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "autoheal", "15.0"
                "capturable", "false"
                "mygravity", "10000.0"
                "nochasecategory", "ALL"
                "stealth", "true"
                "strafetoattack", "true"
            ] }

    let dbg_sphereDef : UnitDef =
        { name = "dbg_sphere"
          subfolder = "other"
          printableName = Some "dbg_sphere"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 3400.0
          buildTime = ValueOrExpr.Concrete 5090.0
          health = ValueOrExpr.Concrete 940.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "dbg_sphere.s3o"
          buildPic = Some "ARMSPID.DDS"
          script = None
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "28 15 28"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 71.55
              maxAcc = 0.207
              maxDec = 0.6486
              turnRate = 1290.29993
              movementClass = Some "TBOT3"
              maxSlope = None
              maxWaterDepth = Some 16.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.749
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Beherith"
              "nohealthbars", "true"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "autoheal", "15.0"
              "capturable", "false"
              "mygravity", "10000.0"
              "nochasecategory", "ALL"
              "stealth", "true"
              "strafetoattack", "true"
          ] }

    let dbg_sphereToFlat (def: UnitDef) : Dbg_sphere =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          customParams = def.customParams
          extras = def.extras }

    let dbg_sphereToUnitDef (flat: Dbg_sphere) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
              maxSlope = None
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Dbg_sphere_fullmetal =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let dbg_sphere_fullmetal : Dbg_sphere_fullmetal =
        { name = "dbg_sphere_fullmetal"
          subfolder = "other"
          printableName = Some "dbg_sphere"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 3400.0
          buildTime = ValueOrExpr.Concrete 5090.0
          health = ValueOrExpr.Concrete 940.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "dbg_sphere_fullmetal.s3o"
          buildPic = Some "ARMSPID.DDS"
          script = None
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "28 15 28"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 71.55
          maxAcc = 0.207
          maxDec = 0.6486
          turnRate = 1290.29993
          movementClass = "TBOT3"
          maxWaterDepth = 16.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.749
          customParams = Map.ofList [
                "model_author", "Beherith"
                "nohealthbars", "true"
                "normaltex", "unittextures/blank_normal.dds"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "autoheal", "15.0"
                "capturable", "false"
                "mygravity", "10000.0"
                "nochasecategory", "ALL"
                "stealth", "true"
                "strafetoattack", "true"
            ] }

    let dbg_sphere_fullmetalDef : UnitDef =
        { name = "dbg_sphere_fullmetal"
          subfolder = "other"
          printableName = Some "dbg_sphere"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 3400.0
          buildTime = ValueOrExpr.Concrete 5090.0
          health = ValueOrExpr.Concrete 940.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "dbg_sphere_fullmetal.s3o"
          buildPic = Some "ARMSPID.DDS"
          script = None
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "28 15 28"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 71.55
              maxAcc = 0.207
              maxDec = 0.6486
              turnRate = 1290.29993
              movementClass = Some "TBOT3"
              maxSlope = None
              maxWaterDepth = Some 16.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.749
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Beherith"
              "nohealthbars", "true"
              "normaltex", "unittextures/blank_normal.dds"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "autoheal", "15.0"
              "capturable", "false"
              "mygravity", "10000.0"
              "nochasecategory", "ALL"
              "stealth", "true"
              "strafetoattack", "true"
          ] }

    let dbg_sphere_fullmetalToFlat (def: UnitDef) : Dbg_sphere_fullmetal =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          customParams = def.customParams
          extras = def.extras }

    let dbg_sphere_fullmetalToUnitDef (flat: Dbg_sphere_fullmetal) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
              maxSlope = None
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Dice =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let dice : Dice =
        { name = "dice"
          subfolder = "other"
          printableName = Some "Dice"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "dice.s3o"
          buildPic = Some "other/dice.dds"
          script = Some "dice.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "14 14 14"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "50.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let diceDef : UnitDef =
        { name = "dice"
          subfolder = "other"
          printableName = Some "Dice"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "dice.s3o"
          buildPic = Some "other/dice.dds"
          script = Some "dice.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "14 14 14"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "50.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let diceToFlat (def: UnitDef) : Dice =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let diceToUnitDef (flat: Dice) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Freefusion =
        { name: string
          subfolder: string
          printableName: string option
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
          energyMake: ValueOrExpr<float>
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let freefusion : Freefusion =
        { name = "freefusion"
          subfolder = "other"
          printableName = Some "Free Fusion Reactor"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 50.0
          buildTime = ValueOrExpr.Concrete 800.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 250.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/freefusion.s3o"
          buildPic = Some "FREEFUSION.DDS"
          script = None
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosionSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          energyMake = ValueOrExpr.Concrete 850.0
          energyStorage = 150.0
          yardMap = "ooooooooooooooooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 2500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 20.0
                  metal = Some 30.0
                  object_ = Some "Units/freefusion_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1350.0
                  featureDead = None
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 5.0
                  metal = Some 10.0
                  object_ = Some "Units/arm5X5A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          customParams = Map.ofList [
                "removestop", "true"
                "removewait", "true"
                "subfolder", "other"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
            ] }

    let freefusionDef : UnitDef =
        { name = "freefusion"
          subfolder = "other"
          printableName = Some "Free Fusion Reactor"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 50.0
          buildTime = ValueOrExpr.Concrete 800.0
          health = ValueOrExpr.Concrete 560.0
          sightDistance = ValueOrExpr.Concrete 250.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/freefusion.s3o"
          buildPic = Some "FREEFUSION.DDS"
          script = None
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosionSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 850.0)
              metalMake = None
              energyStorage = Some 150.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "ooooooooooooooooooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 2500.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 30.0
                object_ = Some "Units/freefusion_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1350.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 5.0
                metal = Some 10.0
                object_ = Some "Units/arm5X5A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = None
          customParams = Map.ofList [
              "removestop", "true"
              "removewait", "true"
              "subfolder", "other"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
          ] }

    let freefusionToFlat (def: UnitDef) : Freefusion =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          customParams = def.customParams
          extras = def.extras }

    let freefusionToUnitDef (flat: Freefusion) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
          movement = None
          builder = None
          weapons = None
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Legnanotcbase =
        { name: string
          subfolder: string
          printableName: string option
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
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let legnanotcbase : Legnanotcbase =
        { name = "legnanotcbase"
          subfolder = "other"
          printableName = Some "Base Builder"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 20000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Expr "range"
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legnanotcbase.s3o"
          buildPic = Some "legnanotc.DDS"
          script = Some "Units/LEGNANOTCTEMP.cob"
          corpse = None
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "31 50 31"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vcormove"]
                select = ["vcorsel"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "false"
                "buildinggrounddecaltype", "decals/legnanotcbase_aoplane.dds"
                "buildinggrounddecalsizey", "8.0"
                "buildinggrounddecalsizex", "8.0"
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
                "mass", "700.0"
                "upright", "true"
            ] }

    let legnanotcbaseDef : UnitDef =
        { name = "legnanotcbase"
          subfolder = "other"
          printableName = Some "Base Builder"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 20000.0
          health = ValueOrExpr.Concrete 20000.0
          sightDistance = ValueOrExpr.Expr "range"
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/legnanotcbase.s3o"
          buildPic = Some "legnanotc.DDS"
          script = Some "Units/LEGNANOTCTEMP.cob"
          corpse = None
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderExplosion"
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
              "buildinggrounddecaltype", "decals/legnanotcbase_aoplane.dds"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecalsizex", "8.0"
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
              "mass", "700.0"
              "upright", "true"
          ] }

    let legnanotcbaseToFlat (def: UnitDef) : Legnanotcbase =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let legnanotcbaseToUnitDef (flat: Legnanotcbase) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Meteor =
        { name: string
          subfolder: string
          printableName: string option
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
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let meteor : Meteor =
        { name = "meteor"
          subfolder = "other"
          printableName = Some "Meteor"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 1.0
          health = ValueOrExpr.Concrete 2.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "meteor.s3o"
          buildPic = Some "other/meteor.dds"
          script = None
          corpse = None
          explodeAs = Some ""
          selfDestructAs = Some ""
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "56 11 56"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          yardMap = "oo oo"
          activateWhenBuilt = true
          canRepeat = false
          weapons = [
                { name = "weapon"
                  displayName = "Asteroid"
                  weaponType = None
                  damage = Map.ofList [
                      "raptor", 0.001
                      "commanders", 10.0
                      "default", 700.0
                      "tinyraptor", 0.001
                  ]
                  range = Some (ValueOrExpr.Concrete 29999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 2000.0
                  areaOfEffect = Some 450.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.75
                  impulseFactor = None
                  noSelfDamage = None
                  soundStart = None
                  soundHit = Some "xplonuk4"
                  explosiongenerator = Some "custom:genericshellexplosion-meteor"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "avoidfeature", "false"
                      "cegtag", "meteortrail"
                      "collidefriendly", "1.0"
                      "craterareaofeffect", "450.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "100.0"
                      "metalpershot", "0.0"
                      "smoketrail", "1.0"
                      "soundhitwet", "sizzle"
                      "soundhitwetvolume", "0.5"
                      "stages", "0.0"
                      "startvelocity", "2000.0"
                      "weaponacceleration", "120.0"
                      "weapontimer", "10.0"
                      "wobble", "0.0"
                  ] }
            ]
          customParams = Map.ofList [
                "removestop", "true"
                "removewait", "true"
                "subfolder", "other"
            ]
          extras = Map.ofList [
                "autoheal", "0.0"
                "levelground", "false"
                "mass", "165.75"
                "noautofire", "false"
                "radardistance", "900.0"
                "smoothanim", "true"
                "unitname", "meteor"
                "upright", "false"
            ] }

    let meteorDef : UnitDef =
        { name = "meteor"
          subfolder = "other"
          printableName = Some "Meteor"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 1.0
          health = ValueOrExpr.Concrete 2.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "meteor.s3o"
          buildPic = Some "other/meteor.dds"
          script = None
          corpse = None
          explodeAs = Some ""
          selfDestructAs = Some ""
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "56 11 56"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = "Asteroid"
                weaponType = None
                damage = Map.ofList [
                    "raptor", 0.001
                    "commanders", 10.0
                    "default", 700.0
                    "tinyraptor", 0.001
                ]
                range = Some (ValueOrExpr.Concrete 29999.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 2000.0
                areaOfEffect = Some 450.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.75
                impulseFactor = None
                noSelfDamage = None
                soundStart = None
                soundHit = Some "xplonuk4"
                explosiongenerator = Some "custom:genericshellexplosion-meteor"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "cegtag", "meteortrail"
                    "collidefriendly", "1.0"
                    "craterareaofeffect", "450.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "100.0"
                    "metalpershot", "0.0"
                    "smoketrail", "1.0"
                    "soundhitwet", "sizzle"
                    "soundhitwetvolume", "0.5"
                    "stages", "0.0"
                    "startvelocity", "2000.0"
                    "weaponacceleration", "120.0"
                    "weapontimer", "10.0"
                    "wobble", "0.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oo oo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "removestop", "true"
              "removewait", "true"
              "subfolder", "other"
          ]
          extras = Map.ofList [
              "autoheal", "0.0"
              "levelground", "false"
              "mass", "165.75"
              "noautofire", "false"
              "radardistance", "900.0"
              "smoothanim", "true"
              "unitname", "meteor"
              "upright", "false"
          ] }

    let meteorToFlat (def: UnitDef) : Meteor =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let meteorToUnitDef (flat: Meteor) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
          movement = None
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Mission_command_tower =
        { name: string
          subfolder: string
          printableName: string option
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
          energyMake: ValueOrExpr<float>
          yardMap: string
          activateWhenBuilt: bool
          canRepeat: bool
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let mission_command_tower : Mission_command_tower =
        { name = "mission_command_tower"
          subfolder = "other"
          printableName = Some "Command Tower"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 100000.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 100.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/mission_command_tower.s3o"
          buildPic = Some "MISSION_COMMAND_TOWER.DDS"
          script = Some "mission_command_tower.cob"
          corpse = None
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosionSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          energyMake = ValueOrExpr.Concrete 250.0
          yardMap = "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
          activateWhenBuilt = true
          canRepeat = false
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
                select = ["geothrm1"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/mission_command_tower_aoplane.dds"
                "buildinggrounddecalsizey", "11.25"
                "buildinggrounddecalsizex", "11.25"
                "buildinggrounddecaldecayspeed", "30.0"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "other"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "energyupkeep", "0.0"
                "reclaimable", "false"
            ] }

    let mission_command_towerDef : UnitDef =
        { name = "mission_command_tower"
          subfolder = "other"
          printableName = Some "Command Tower"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 100000.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 100.0
          footprintX = 12.0
          footprintZ = 12.0
          objectName = Some "Units/mission_command_tower.s3o"
          buildPic = Some "MISSION_COMMAND_TOWER.DDS"
          script = Some "mission_command_tower.cob"
          corpse = None
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosionSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 250.0)
              metalMake = None
              energyStorage = None
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/mission_command_tower_aoplane.dds"
              "buildinggrounddecalsizey", "11.25"
              "buildinggrounddecalsizex", "11.25"
              "buildinggrounddecaldecayspeed", "30.0"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "other"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "energyupkeep", "0.0"
              "reclaimable", "false"
          ] }

    let mission_command_towerToFlat (def: UnitDef) : Mission_command_tower =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          energyMake = def.economy.Value.energyMake.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          canRepeat = def.building.Value.canRepeat.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let mission_command_towerToUnitDef (flat: Mission_command_tower) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
          movement = None
          builder = None
          weapons = None
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = None
              metalStorage = None
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = Some flat.activateWhenBuilt
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Nuketest =
        { name: string
          subfolder: string
          printableName: string option
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
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let nuketest : Nuketest =
        { name = "nuketest"
          subfolder = "other"
          printableName = Some "New Nuke Spawner"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/cube.s3o"
          buildPic = Some "other/nuketest.dds"
          script = Some "scavs/droppod.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = Some "custom:newnuke"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0 0 0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          energyStorage = 1000.0
          yardMap = "yy yy"
          activateWhenBuilt = true
          weapons = [
                { name = "nuketest"
                  displayName = "Newest Nuke"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 2500.0
                      "default", 9500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 29999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 1280.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 0.5
                  noSelfDamage = None
                  soundStart = Some "aarocket"
                  soundHit = Some "nukearm"
                  explosiongenerator = Some "custom:newnuke"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysvisible", "true"
                      "avoidfriendly", "false"
                      "cegtag", "NUKETRAIL"
                      "collidefriendly", "0.0"
                      "craterareaofeffect", "1280.0"
                      "craterboost", "2.4"
                      "cratermult", "1.2"
                      "firestarter", "100.0"
                      "flighttime", "100.0"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "crblmssl.s3o"
                      "smoketrail", "1.0"
                      "startvelocity", "1.0"
                      "weaponacceleration", "1800.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "isairbase", "true"
                "subfolder", "other"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "capturable", "false"
                "levelground", "false"
                "mass", "165.75"
                "noautofire", "false"
                "radardistance", "900.0"
                "smoothanim", "true"
                "unitname", "nukedroppod"
                "upright", "false"
            ] }

    let nuketestDef : UnitDef =
        { name = "nuketest"
          subfolder = "other"
          printableName = Some "New Nuke Spawner"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/cube.s3o"
          buildPic = Some "other/nuketest.dds"
          script = Some "scavs/droppod.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = Some "custom:newnuke"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0 0 0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "nuketest"
                displayName = "Newest Nuke"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "commanders", 2500.0
                    "default", 9500.0
                ]
                range = Some (ValueOrExpr.Concrete 29999.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 1280.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 0.5
                noSelfDamage = None
                soundStart = Some "aarocket"
                soundHit = Some "nukearm"
                explosiongenerator = Some "custom:newnuke"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "alwaysvisible", "true"
                    "avoidfriendly", "false"
                    "cegtag", "NUKETRAIL"
                    "collidefriendly", "0.0"
                    "craterareaofeffect", "1280.0"
                    "craterboost", "2.4"
                    "cratermult", "1.2"
                    "firestarter", "100.0"
                    "flighttime", "100.0"
                    "interceptedbyshieldtype", "4.0"
                    "metalpershot", "0.0"
                    "model", "crblmssl.s3o"
                    "smoketrail", "1.0"
                    "startvelocity", "1.0"
                    "weaponacceleration", "1800.0"
                    "weapontimer", "2.0"
                    "wobble", "50.0"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "yy yy"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "isairbase", "true"
              "subfolder", "other"
          ]
          extras = Map.ofList [
              "autoheal", "1.8"
              "capturable", "false"
              "levelground", "false"
              "mass", "165.75"
              "noautofire", "false"
              "radardistance", "900.0"
              "smoothanim", "true"
              "unitname", "nukedroppod"
              "upright", "false"
          ] }

    let nuketestToFlat (def: UnitDef) : Nuketest =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let nuketestToUnitDef (flat: Nuketest) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
          movement = None
          builder = None
          weapons = Some flat.weapons
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
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Nuketestcor =
        { name: string
          subfolder: string
          printableName: string option
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
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let nuketestcor : Nuketestcor =
        { name = "nuketestcor"
          subfolder = "other"
          printableName = Some "New Nuke Spawner"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 6200.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/cube.s3o"
          buildPic = Some "other/nuketest.dds"
          script = Some "scavs/droppod.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = Some "custom:newnuke-cor"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0 0 0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          energyStorage = 1000.0
          yardMap = "yy yy"
          activateWhenBuilt = true
          weapons = [
                { name = "nuketestcor"
                  displayName = "Newest Nuke"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 2500.0
                      "default", 11500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 29999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 1920.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 0.5
                  noSelfDamage = None
                  soundStart = Some "aarocket"
                  soundHit = Some "nukecor"
                  explosiongenerator = Some "custom:newnukecor"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysvisible", "true"
                      "avoidfriendly", "false"
                      "cegtag", "NUKETRAIL"
                      "collidefriendly", "0.0"
                      "craterareaofeffect", "1920.0"
                      "craterboost", "2.4"
                      "cratermult", "1.2"
                      "firestarter", "100.0"
                      "flighttime", "100.0"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "crblmssl.s3o"
                      "smoketrail", "1.0"
                      "startvelocity", "1.0"
                      "weaponacceleration", "1800.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "isairbase", "true"
                "subfolder", "other"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "capturable", "false"
                "levelground", "false"
                "mass", "165.75"
                "noautofire", "false"
                "radardistance", "900.0"
                "smoothanim", "true"
                "unitname", "nukedroppod"
                "upright", "false"
            ] }

    let nuketestcorDef : UnitDef =
        { name = "nuketestcor"
          subfolder = "other"
          printableName = Some "New Nuke Spawner"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 6200.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/cube.s3o"
          buildPic = Some "other/nuketest.dds"
          script = Some "scavs/droppod.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = Some "custom:newnuke-cor"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0 0 0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "nuketestcor"
                displayName = "Newest Nuke"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "commanders", 2500.0
                    "default", 11500.0
                ]
                range = Some (ValueOrExpr.Concrete 29999.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 1920.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 0.5
                noSelfDamage = None
                soundStart = Some "aarocket"
                soundHit = Some "nukecor"
                explosiongenerator = Some "custom:newnukecor"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "alwaysvisible", "true"
                    "avoidfriendly", "false"
                    "cegtag", "NUKETRAIL"
                    "collidefriendly", "0.0"
                    "craterareaofeffect", "1920.0"
                    "craterboost", "2.4"
                    "cratermult", "1.2"
                    "firestarter", "100.0"
                    "flighttime", "100.0"
                    "interceptedbyshieldtype", "4.0"
                    "metalpershot", "0.0"
                    "model", "crblmssl.s3o"
                    "smoketrail", "1.0"
                    "startvelocity", "1.0"
                    "weaponacceleration", "1800.0"
                    "weapontimer", "2.0"
                    "wobble", "50.0"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "yy yy"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "isairbase", "true"
              "subfolder", "other"
          ]
          extras = Map.ofList [
              "autoheal", "1.8"
              "capturable", "false"
              "levelground", "false"
              "mass", "165.75"
              "noautofire", "false"
              "radardistance", "900.0"
              "smoothanim", "true"
              "unitname", "nukedroppod"
              "upright", "false"
          ] }

    let nuketestcorToFlat (def: UnitDef) : Nuketestcor =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let nuketestcorToUnitDef (flat: Nuketestcor) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
          movement = None
          builder = None
          weapons = Some flat.weapons
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
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Nuketestorg =
        { name: string
          subfolder: string
          printableName: string option
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
          energyStorage: float
          yardMap: string
          activateWhenBuilt: bool
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let nuketestorg : Nuketestorg =
        { name = "nuketestorg"
          subfolder = "other"
          printableName = Some "Original Arm Nuke Spawner"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/cube.s3o"
          buildPic = Some "other/nuketest.dds"
          script = Some "scavs/droppod.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = Some "custom:armnuke"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0 0 0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          energyStorage = 1000.0
          yardMap = "yy yy"
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = "Newest Nuke"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 2500.0
                      "default", 9500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 29999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 1500.0
                  areaOfEffect = Some 1280.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 0.5
                  noSelfDamage = None
                  soundStart = Some "misicbm1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:armnuke"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysvisible", "true"
                      "avoidfriendly", "false"
                      "cegtag", "NUKETRAIL"
                      "collidefriendly", "0.0"
                      "craterareaofeffect", "1280.0"
                      "craterboost", "2.4"
                      "cratermult", "1.2"
                      "firestarter", "0.0"
                      "flighttime", "100.0"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "model", "scavs/cube.s3o"
                      "smoketrail", "false"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "null"
                      "texture3", "null"
                      "weaponacceleration", "1800.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "isairbase", "true"
                "subfolder", "other"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "capturable", "false"
                "levelground", "false"
                "mass", "165.75"
                "noautofire", "false"
                "radardistance", "900.0"
                "smoothanim", "true"
                "unitname", "nukedroppod"
                "upright", "false"
            ] }

    let nuketestorgDef : UnitDef =
        { name = "nuketestorg"
          subfolder = "other"
          printableName = Some "Original Arm Nuke Spawner"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 5900.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "scavs/cube.s3o"
          buildPic = Some "other/nuketest.dds"
          script = Some "scavs/droppod.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = Some "custom:armnuke"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0 0 0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = "Newest Nuke"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "commanders", 2500.0
                    "default", 9500.0
                ]
                range = Some (ValueOrExpr.Concrete 29999.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 1280.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 0.5
                noSelfDamage = None
                soundStart = Some "misicbm1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:armnuke"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "alwaysvisible", "true"
                    "avoidfriendly", "false"
                    "cegtag", "NUKETRAIL"
                    "collidefriendly", "0.0"
                    "craterareaofeffect", "1280.0"
                    "craterboost", "2.4"
                    "cratermult", "1.2"
                    "firestarter", "0.0"
                    "flighttime", "100.0"
                    "interceptedbyshieldtype", "4.0"
                    "metalpershot", "0.0"
                    "model", "scavs/cube.s3o"
                    "smoketrail", "false"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "null"
                    "texture3", "null"
                    "weaponacceleration", "1800.0"
                    "weapontimer", "2.0"
                    "wobble", "50.0"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "yy yy"
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "isairbase", "true"
              "subfolder", "other"
          ]
          extras = Map.ofList [
              "autoheal", "1.8"
              "capturable", "false"
              "levelground", "false"
              "mass", "165.75"
              "noautofire", "false"
              "radardistance", "900.0"
              "smoothanim", "true"
              "unitname", "nukedroppod"
              "upright", "false"
          ] }

    let nuketestorgToFlat (def: UnitDef) : Nuketestorg =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          energyStorage = def.economy.Value.energyStorage.Value
          yardMap = def.building.Value.yardMap.Value
          activateWhenBuilt = def.building.Value.activateWhenBuilt.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let nuketestorgToUnitDef (flat: Nuketestorg) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
          movement = None
          builder = None
          weapons = Some flat.weapons
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
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Pbr_cube =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxWaterDepth: float
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let pbr_cube : Pbr_cube =
        { name = "pbr_cube"
          subfolder = "other"
          printableName = Some "PBR Test Cube Thing"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 3400.0
          buildTime = ValueOrExpr.Concrete 5090.0
          health = ValueOrExpr.Concrete 940.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "pbr_cube.s3o"
          buildPic = Some "ARMSPID.DDS"
          script = None
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "28 15 28"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 71.55
          maxAcc = 0.207
          maxDec = 0.6486
          turnRate = 1290.29993
          movementClass = "TBOT3"
          maxWaterDepth = 16.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 1.749
          customParams = Map.ofList [
                "model_author", "Beherith"
                "nohealthbars", "true"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "autoheal", "15.0"
                "capturable", "false"
                "mygravity", "10000.0"
                "nochasecategory", "ALL"
                "stealth", "true"
                "strafetoattack", "true"
            ] }

    let pbr_cubeDef : UnitDef =
        { name = "pbr_cube"
          subfolder = "other"
          printableName = Some "PBR Test Cube Thing"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 3400.0
          buildTime = ValueOrExpr.Concrete 5090.0
          health = ValueOrExpr.Concrete 940.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "pbr_cube.s3o"
          buildPic = Some "ARMSPID.DDS"
          script = None
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "28 15 28"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 71.55
              maxAcc = 0.207
              maxDec = 0.6486
              turnRate = 1290.29993
              movementClass = Some "TBOT3"
              maxSlope = None
              maxWaterDepth = Some 16.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.749
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Beherith"
              "nohealthbars", "true"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "autoheal", "15.0"
              "capturable", "false"
              "mygravity", "10000.0"
              "nochasecategory", "ALL"
              "stealth", "true"
              "strafetoattack", "true"
          ] }

    let pbr_cubeToFlat (def: UnitDef) : Pbr_cube =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          customParams = def.customParams
          extras = def.extras }

    let pbr_cubeToUnitDef (flat: Pbr_cube) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
              maxSlope = None
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Resourcecheat =
        { name: string
          subfolder: string
          printableName: string option
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
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          yardMap: string
          canRepeat: bool
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let resourcecheat : Resourcecheat =
        { name = "resourcecheat"
          subfolder = "other"
          printableName = Some "INFINITE RESOURCES"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 312500.0
          health = ValueOrExpr.Concrete 7900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMAFUS.s3o"
          buildPic = Some "other/resourcecheat.dds"
          script = Some "Units/ARMAFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advancedFusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "110 110 110"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          energyMake = ValueOrExpr.Concrete 1000000.0
          metalMake = ValueOrExpr.Concrete 1000000.0
          energyStorage = 1000000.0
          metalStorage = 1000000.0
          yardMap = "oooooooooooooooooooooooooooooooooooo"
          canRepeat = false
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "110 110 110"
                  collisionVolumeType = Some "Box"
                  damage = Some 16290.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 4.0
                  height = Some 40.0
                  metal = Some 6441.0
                  object_ = Some "Units/armafus_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 8145.0
                  featureDead = None
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 4.0
                  metal = Some 2576.0
                  object_ = Some "Units/arm4X4A.s3o"
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
                select = ["fusion1"] }
          customParams = Map.ofList [
                "usebuildinggrounddecal", "true"
                "buildinggrounddecaltype", "decals/armafus_aoplane.dds"
                "buildinggrounddecalsizey", "9.0"
                "buildinggrounddecalsizex", "9.0"
                "buildinggrounddecaldecayspeed", "30.0"
                "model_author", "Cremuss"
                "normaltex", "unittextures/Arm_normal.dds"
                "removestop", "true"
                "removewait", "true"
                "subfolder", "other"
                "techlevel", "2.0"
            ]
          extras = Map.ofList [
                "buildangle", "4096.0"
                "damagemodifier", "0.95"
            ] }

    let resourcecheatDef : UnitDef =
        { name = "resourcecheat"
          subfolder = "other"
          printableName = Some "INFINITE RESOURCES"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 312500.0
          health = ValueOrExpr.Concrete 7900.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/ARMAFUS.s3o"
          buildPic = Some "other/resourcecheat.dds"
          script = Some "Units/ARMAFUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advancedFusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "110 110 110"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 1000000.0)
              metalMake = Some (ValueOrExpr.Concrete 1000000.0)
              energyStorage = Some 1000000.0
              metalStorage = Some 1000000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooooooooooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "110 110 110"
                collisionVolumeType = Some "Box"
                damage = Some 16290.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 6441.0
                object_ = Some "Units/armafus_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 8145.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 2576.0
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/armafus_aoplane.dds"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "model_author", "Cremuss"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "other"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "damagemodifier", "0.95"
          ] }

    let resourcecheatToFlat (def: UnitDef) : Resourcecheat =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let resourcecheatToUnitDef (flat: Resourcecheat) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
          movement = None
          builder = None
          weapons = None
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Volcano_projectile_unit =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          canMove: bool
          yardMap: string
          canRepeat: bool
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let volcano_projectile_unit : Volcano_projectile_unit =
        { name = "volcano_projectile_unit"
          subfolder = "other"
          printableName = None
          metalCost = ValueOrExpr.Concrete 100.0
          energyCost = ValueOrExpr.Concrete 100.0
          buildTime = ValueOrExpr.Concrete 1.0
          health = ValueOrExpr.Concrete 1000000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORTHUD.s3o"
          buildPic = None
          script = Some "Units/CORTHUD.cob"
          corpse = Some ""
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "SURFACE"
          speed = ValueOrExpr.Concrete 0.0001
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "BOT3"
          canMove = true
          yardMap = "o"
          canRepeat = false
          weapons = [
                { name = "volcano_fireball"
                  displayName = "Volcano Fireball"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 32000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 780.0
                  areaOfEffect = Some 220.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 3.0
                  noSelfDamage = None
                  soundStart = None
                  soundHit = Some "xplolrg1"
                  explosiongenerator = Some "custom:volcano_rock_impact"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlyTargetCategory", "SURFACE"
                      "model", "Raptors/greyrock2.s3o"
                      "cegtag", "volcano_rock_trail"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "trajectoryheight", "1.1"
                      "mygravity", "0.16"
                      "impulseboost", "400.0"
                      "collideground", "true"
                      "avoidfriendly", "false"
                      "avoidfeature", "false"
                      "soundhitvolume", "75.0"
                  ] }
            ]
          customParams = Map.ofList [
                "faction", "NONE"
                "is_volcano_launcher", "1.0"
            ]
          extras = Map.ofList [
                "power", "1.0"
                "leavetracks", "false"
                "canattack", "true"
                "canattackground", "true"
                "drawtype", "0.0"
                "selectable", "false"
                "blocking", "false"
                "canstop", "false"
                "canpatrol", "false"
                "initcloaked", "true"
                "cloakcost", "0.0"
                "cloakcostmoving", "0.0"
                "mincloakdistance", "0.0"
                "stealth", "true"
                "sonarstealth", "true"
                "radardistance", "0.0"
            ] }

    let volcano_projectile_unitDef : UnitDef =
        { name = "volcano_projectile_unit"
          subfolder = "other"
          printableName = None
          metalCost = ValueOrExpr.Concrete 100.0
          energyCost = ValueOrExpr.Concrete 100.0
          buildTime = ValueOrExpr.Concrete 1.0
          health = ValueOrExpr.Concrete 1000000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORTHUD.s3o"
          buildPic = None
          script = Some "Units/CORTHUD.cob"
          corpse = Some ""
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "SURFACE"
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0001
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "BOT3"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "volcano_fireball"
                displayName = "Volcano Fireball"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 32000.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 780.0
                areaOfEffect = Some 220.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 3.0
                noSelfDamage = None
                soundStart = None
                soundHit = Some "xplolrg1"
                explosiongenerator = Some "custom:volcano_rock_impact"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlyTargetCategory", "SURFACE"
                    "model", "Raptors/greyrock2.s3o"
                    "cegtag", "volcano_rock_trail"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "trajectoryheight", "1.1"
                    "mygravity", "0.16"
                    "impulseboost", "400.0"
                    "collideground", "true"
                    "avoidfriendly", "false"
                    "avoidfeature", "false"
                    "soundhitvolume", "75.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "o"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "faction", "NONE"
              "is_volcano_launcher", "1.0"
          ]
          extras = Map.ofList [
              "power", "1.0"
              "leavetracks", "false"
              "canattack", "true"
              "canattackground", "true"
              "drawtype", "0.0"
              "selectable", "false"
              "blocking", "false"
              "canstop", "false"
              "canpatrol", "false"
              "initcloaked", "true"
              "cloakcost", "0.0"
              "cloakcostmoving", "0.0"
              "mincloakdistance", "0.0"
              "stealth", "true"
              "sonarstealth", "true"
              "radardistance", "0.0"
          ] }

    let volcano_projectile_unitToFlat (def: UnitDef) : Volcano_projectile_unit =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let volcano_projectile_unitToUnitDef (flat: Volcano_projectile_unit) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
              maxSlope = None
              maxWaterDepth = None
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
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Xmasball1_1 =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball1_1 : Xmasball1_1 =
        { name = "xmasball1_1"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball1_1.s3o"
          buildPic = Some "other/xmasball.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "3.5 3.5 3.5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "40.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let xmasball1_1Def : UnitDef =
        { name = "xmasball1_1"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball1_1.s3o"
          buildPic = Some "other/xmasball.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "3.5 3.5 3.5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Floris"
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "40.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let xmasball1_1ToFlat (def: UnitDef) : Xmasball1_1 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let xmasball1_1ToUnitDef (flat: Xmasball1_1) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Xmasball1_2 =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball1_2 : Xmasball1_2 =
        { name = "xmasball1_2"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball1_2.s3o"
          buildPic = Some "other/xmasball.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "4 4 4"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "40.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let xmasball1_2Def : UnitDef =
        { name = "xmasball1_2"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball1_2.s3o"
          buildPic = Some "other/xmasball.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "4 4 4"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Floris"
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "40.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let xmasball1_2ToFlat (def: UnitDef) : Xmasball1_2 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let xmasball1_2ToUnitDef (flat: Xmasball1_2) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Xmasball1_3 =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball1_3 : Xmasball1_3 =
        { name = "xmasball1_3"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball1_3.s3o"
          buildPic = Some "other/xmasball.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "4.5 4.5 4.5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "40.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let xmasball1_3Def : UnitDef =
        { name = "xmasball1_3"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball1_3.s3o"
          buildPic = Some "other/xmasball.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "4.5 4.5 4.5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Floris"
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "40.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let xmasball1_3ToFlat (def: UnitDef) : Xmasball1_3 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let xmasball1_3ToUnitDef (flat: Xmasball1_3) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Xmasball1_4 =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball1_4 : Xmasball1_4 =
        { name = "xmasball1_4"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball1_4.s3o"
          buildPic = Some "other/xmasball.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "5 5 5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "40.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let xmasball1_4Def : UnitDef =
        { name = "xmasball1_4"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball1_4.s3o"
          buildPic = Some "other/xmasball.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "5 5 5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Floris"
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "40.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let xmasball1_4ToFlat (def: UnitDef) : Xmasball1_4 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let xmasball1_4ToUnitDef (flat: Xmasball1_4) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Xmasball1_5 =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball1_5 : Xmasball1_5 =
        { name = "xmasball1_5"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball1_5.s3o"
          buildPic = Some "other/xmasball.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "5.5 5.5 5.5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "40.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let xmasball1_5Def : UnitDef =
        { name = "xmasball1_5"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball1_5.s3o"
          buildPic = Some "other/xmasball.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "5.5 5.5 5.5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Floris"
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "40.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let xmasball1_5ToFlat (def: UnitDef) : Xmasball1_5 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let xmasball1_5ToUnitDef (flat: Xmasball1_5) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Xmasball1_6 =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball1_6 : Xmasball1_6 =
        { name = "xmasball1_6"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball1_6.s3o"
          buildPic = Some "other/xmasball.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "6 6 6"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "40.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let xmasball1_6Def : UnitDef =
        { name = "xmasball1_6"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball1_6.s3o"
          buildPic = Some "other/xmasball.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "6 6 6"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Floris"
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "40.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let xmasball1_6ToFlat (def: UnitDef) : Xmasball1_6 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let xmasball1_6ToUnitDef (flat: Xmasball1_6) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Xmasball2_1 =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball2_1 : Xmasball2_1 =
        { name = "xmasball2_1"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball2_1.s3o"
          buildPic = Some "other/xmasball2.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "3.5 3.5 3.5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "45.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let xmasball2_1Def : UnitDef =
        { name = "xmasball2_1"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball2_1.s3o"
          buildPic = Some "other/xmasball2.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "3.5 3.5 3.5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Floris"
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "45.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let xmasball2_1ToFlat (def: UnitDef) : Xmasball2_1 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let xmasball2_1ToUnitDef (flat: Xmasball2_1) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Xmasball2_2 =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball2_2 : Xmasball2_2 =
        { name = "xmasball2_2"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball2_2.s3o"
          buildPic = Some "other/xmasball2.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "4 4 4"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "45.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let xmasball2_2Def : UnitDef =
        { name = "xmasball2_2"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball2_2.s3o"
          buildPic = Some "other/xmasball2.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "4 4 4"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Floris"
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "45.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let xmasball2_2ToFlat (def: UnitDef) : Xmasball2_2 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let xmasball2_2ToUnitDef (flat: Xmasball2_2) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Xmasball2_3 =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball2_3 : Xmasball2_3 =
        { name = "xmasball2_3"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball2_3.s3o"
          buildPic = Some "other/xmasball2.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "4.5 4.5 4.5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "45.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let xmasball2_3Def : UnitDef =
        { name = "xmasball2_3"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball2_3.s3o"
          buildPic = Some "other/xmasball2.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "4.5 4.5 4.5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Floris"
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "45.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let xmasball2_3ToFlat (def: UnitDef) : Xmasball2_3 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let xmasball2_3ToUnitDef (flat: Xmasball2_3) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Xmasball2_4 =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball2_4 : Xmasball2_4 =
        { name = "xmasball2_4"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball2_4.s3o"
          buildPic = Some "other/xmasball2.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "5 5 5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "45.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let xmasball2_4Def : UnitDef =
        { name = "xmasball2_4"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball2_4.s3o"
          buildPic = Some "other/xmasball2.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "5 5 5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Floris"
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "45.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let xmasball2_4ToFlat (def: UnitDef) : Xmasball2_4 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let xmasball2_4ToUnitDef (flat: Xmasball2_4) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Xmasball2_5 =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball2_5 : Xmasball2_5 =
        { name = "xmasball2_5"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball2_5.s3o"
          buildPic = Some "other/xmasball2.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "5.5 5.5 5.5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "45.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let xmasball2_5Def : UnitDef =
        { name = "xmasball2_5"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball2_5.s3o"
          buildPic = Some "other/xmasball2.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "5.5 5.5 5.5"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Floris"
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "45.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let xmasball2_5ToFlat (def: UnitDef) : Xmasball2_5 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let xmasball2_5ToUnitDef (flat: Xmasball2_5) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Xmasball2_6 =
        { name: string
          subfolder: string
          printableName: string option
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          canMove: bool
          yardMap: string
          canRepeat: bool
          customParams: Map<string, string>
          extras: Map<string, string> }

    let xmasball2_6 : Xmasball2_6 =
        { name = "xmasball2_6"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball2_6.s3o"
          buildPic = Some "other/xmasball2.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "6 6 6"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 0.0
          movementClass = "SBOT2"
          maxSlope = 64.0
          maxWaterDepth = 0.0
          canMove = true
          yardMap = "f"
          canRepeat = false
          customParams = Map.ofList [
                "model_author", "Floris"
                "nohealthbars", "true"
                "subfolder", "other"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "canattack", "false"
                "cantbetransported", "true"
                "capturable", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "mass", "45.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "usebuildinggrounddecal", "false"
            ] }

    let xmasball2_6Def : UnitDef =
        { name = "xmasball2_6"
          subfolder = "other"
          printableName = Some "Xmas ball"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 560000.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "xmasball2_6.s3o"
          buildPic = Some "other/xmasball2.dds"
          script = Some "xmasball.lua"
          corpse = None
          explodeAs = Some "blank"
          selfDestructAs = Some "blank"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "6 6 6"
          collisionVolumeType = Some "Sphere"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 0.0
              movementClass = Some "SBOT2"
              maxSlope = Some 64.0
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
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "f"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "model_author", "Floris"
              "nohealthbars", "true"
              "subfolder", "other"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "cantbetransported", "true"
              "capturable", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "mass", "45.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "usebuildinggrounddecal", "false"
          ] }

    let xmasball2_6ToFlat (def: UnitDef) : Xmasball2_6 =
        { name = def.name
          subfolder = def.subfolder
          printableName = def.printableName
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          canMove = def.movement.Value.canMove
          yardMap = def.building.Value.yardMap.Value
          canRepeat = def.building.Value.canRepeat.Value
          customParams = def.customParams
          extras = def.extras }

    let xmasball2_6ToUnitDef (flat: Xmasball2_6) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          printableName = flat.printableName
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
              movementClass = Some flat.movementClass
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
          builder = None
          weapons = None
          economy = None
          building = Some {
              yardMap = Some flat.yardMap
              activateWhenBuilt = None
              canRepeat = Some flat.canRepeat
            }
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

