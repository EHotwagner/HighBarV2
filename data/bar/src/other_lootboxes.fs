// Auto-generated BAR unit data: other/lootboxes (unified)
namespace BarData.Units

open BarData

module other_lootboxes =

    type Lootboxbronze =
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
          floater: bool
          turnInPlace: bool
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let lootboxbronze : Lootboxbronze =
        { name = "lootboxbronze"
          subfolder = "other/lootboxes"
          printableName = Some "Bronze Resource Generator"
          metalCost = ValueOrExpr.Concrete 375.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 33500.0
          sightDistance = ValueOrExpr.Concrete 96.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "lootboxes/lootboxv2_bronze.s3o"
          buildPic = Some "lootboxes/LOOTBOXBRONZE.DDS"
          script = Some "lootboxes/lootboxv2.cob"
          corpse = None
          explodeAs = Some "lootboxExplosion1"
          selfDestructAs = Some "lootboxExplosion1"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 32 32"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.03
          maxAcc = 0.0
          maxDec = 1.0
          turnRate = 0.0
          movementClass = "HOVER3"
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          floater = true
          turnInPlace = false
          energyMake = ValueOrExpr.Concrete 400.0
          metalMake = ValueOrExpr.Concrete 20.0
          customParams = Map.ofList [
                "fall_damage_multiplier", "0.0"
                "unitgroup", "energy"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/lootboxes"
                "paratrooper", "true"
            ]
          extras = Map.ofList [
                "autoheal", "1.0"
                "canfight", "false"
                "canguard", "false"
                "canhover", "true"
                "canpatrol", "false"
                "canselfdestruct", "true"
                "canstop", "false"
                "cantbetransported", "false"
                "capturable", "true"
                "levelground", "false"
                "mass", "749.0"
                "movestate", "0.0"
                "noautofire", "false"
                "selfdestructcountdown", "9.0"
                "transportbyenemy", "true"
                "unitname", "lootboxbronze"
                "upright", "true"
                "usebuildinggrounddecal", "false"
                "reclaimable", "false"
            ] }

    let lootboxbronzeDef : UnitDef =
        { name = "lootboxbronze"
          subfolder = "other/lootboxes"
          printableName = Some "Bronze Resource Generator"
          metalCost = ValueOrExpr.Concrete 375.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 33500.0
          sightDistance = ValueOrExpr.Concrete 96.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "lootboxes/lootboxv2_bronze.s3o"
          buildPic = Some "lootboxes/LOOTBOXBRONZE.DDS"
          script = Some "lootboxes/lootboxv2.cob"
          corpse = None
          explodeAs = Some "lootboxExplosion1"
          selfDestructAs = Some "lootboxExplosion1"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 32 32"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.03
              maxAcc = 0.0
              maxDec = 1.0
              turnRate = 0.0
              movementClass = Some "HOVER3"
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some false
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 400.0)
              metalMake = Some (ValueOrExpr.Concrete 20.0)
              energyStorage = None
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "fall_damage_multiplier", "0.0"
              "unitgroup", "energy"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other/lootboxes"
              "paratrooper", "true"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canfight", "false"
              "canguard", "false"
              "canhover", "true"
              "canpatrol", "false"
              "canselfdestruct", "true"
              "canstop", "false"
              "cantbetransported", "false"
              "capturable", "true"
              "levelground", "false"
              "mass", "749.0"
              "movestate", "0.0"
              "noautofire", "false"
              "selfdestructcountdown", "9.0"
              "transportbyenemy", "true"
              "unitname", "lootboxbronze"
              "upright", "true"
              "usebuildinggrounddecal", "false"
              "reclaimable", "false"
          ] }

    let lootboxbronzeToFlat (def: UnitDef) : Lootboxbronze =
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
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          customParams = def.customParams
          extras = def.extras }

    let lootboxbronzeToUnitDef (flat: Lootboxbronze) : UnitDef =
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
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = None
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = None
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Lootboxgold =
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
          floater: bool
          turnInPlace: bool
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let lootboxgold : Lootboxgold =
        { name = "lootboxgold"
          subfolder = "other/lootboxes"
          printableName = Some "Gold Resource Generator"
          metalCost = ValueOrExpr.Concrete 1500.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 56000.0
          sightDistance = ValueOrExpr.Concrete 96.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "lootboxes/lootboxv2_gold.s3o"
          buildPic = Some "lootboxes/LOOTBOXGOLD.DDS"
          script = Some "lootboxes/lootboxv2.cob"
          corpse = None
          explodeAs = Some "lootboxExplosion3"
          selfDestructAs = Some "lootboxExplosion3"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "64 64 64"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.03
          maxAcc = 0.0
          maxDec = 1.0
          turnRate = 0.0
          movementClass = "HHOVER4"
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          floater = true
          turnInPlace = false
          energyMake = ValueOrExpr.Concrete 1600.0
          metalMake = ValueOrExpr.Concrete 80.0
          customParams = Map.ofList [
                "fall_damage_multiplier", "0.0"
                "unitgroup", "energy"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/lootboxes"
                "paratrooper", "true"
            ]
          extras = Map.ofList [
                "autoheal", "1.0"
                "canfight", "false"
                "canguard", "false"
                "canpatrol", "false"
                "canselfdestruct", "true"
                "canstop", "false"
                "cantbetransported", "false"
                "capturable", "true"
                "levelground", "false"
                "mass", "4000.0"
                "movestate", "0.0"
                "noautofire", "false"
                "selfdestructcountdown", "9.0"
                "transportbyenemy", "true"
                "unitname", "lootboxgold"
                "upright", "true"
                "usebuildinggrounddecal", "false"
                "reclaimable", "false"
            ] }

    let lootboxgoldDef : UnitDef =
        { name = "lootboxgold"
          subfolder = "other/lootboxes"
          printableName = Some "Gold Resource Generator"
          metalCost = ValueOrExpr.Concrete 1500.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 56000.0
          sightDistance = ValueOrExpr.Concrete 96.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "lootboxes/lootboxv2_gold.s3o"
          buildPic = Some "lootboxes/LOOTBOXGOLD.DDS"
          script = Some "lootboxes/lootboxv2.cob"
          corpse = None
          explodeAs = Some "lootboxExplosion3"
          selfDestructAs = Some "lootboxExplosion3"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "64 64 64"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.03
              maxAcc = 0.0
              maxDec = 1.0
              turnRate = 0.0
              movementClass = Some "HHOVER4"
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some false
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 1600.0)
              metalMake = Some (ValueOrExpr.Concrete 80.0)
              energyStorage = None
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "fall_damage_multiplier", "0.0"
              "unitgroup", "energy"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other/lootboxes"
              "paratrooper", "true"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canfight", "false"
              "canguard", "false"
              "canpatrol", "false"
              "canselfdestruct", "true"
              "canstop", "false"
              "cantbetransported", "false"
              "capturable", "true"
              "levelground", "false"
              "mass", "4000.0"
              "movestate", "0.0"
              "noautofire", "false"
              "selfdestructcountdown", "9.0"
              "transportbyenemy", "true"
              "unitname", "lootboxgold"
              "upright", "true"
              "usebuildinggrounddecal", "false"
              "reclaimable", "false"
          ] }

    let lootboxgoldToFlat (def: UnitDef) : Lootboxgold =
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
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          customParams = def.customParams
          extras = def.extras }

    let lootboxgoldToUnitDef (flat: Lootboxgold) : UnitDef =
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
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = None
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = None
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Lootboxplatinum =
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
          floater: bool
          turnInPlace: bool
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let lootboxplatinum : Lootboxplatinum =
        { name = "lootboxplatinum"
          subfolder = "other/lootboxes"
          printableName = Some "Platinum Resource Generator"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 67000.0
          sightDistance = ValueOrExpr.Concrete 96.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "lootboxes/lootboxv2_platinum.s3o"
          buildPic = Some "lootboxes/LOOTBOXPLATINUM.DDS"
          script = Some "lootboxes/lootboxv2.cob"
          corpse = None
          explodeAs = Some "lootboxExplosion4"
          selfDestructAs = Some "lootboxExplosion4"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "80 80 80"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.03
          maxAcc = 0.0
          maxDec = 1.0
          turnRate = 0.0
          movementClass = "HHOVER4"
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          floater = true
          turnInPlace = false
          energyMake = ValueOrExpr.Concrete 2800.0
          metalMake = ValueOrExpr.Concrete 140.0
          customParams = Map.ofList [
                "fall_damage_multiplier", "0.0"
                "unitgroup", "energy"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/lootboxes"
                "paratrooper", "true"
            ]
          extras = Map.ofList [
                "autoheal", "1.0"
                "canfight", "false"
                "canguard", "false"
                "canpatrol", "false"
                "canselfdestruct", "true"
                "canstop", "false"
                "cantbetransported", "false"
                "capturable", "true"
                "levelground", "false"
                "mass", "4000.0"
                "movestate", "0.0"
                "noautofire", "false"
                "selfdestructcountdown", "9.0"
                "transportbyenemy", "true"
                "unitname", "lootboxplatinum"
                "upright", "true"
                "usebuildinggrounddecal", "false"
                "reclaimable", "false"
            ] }

    let lootboxplatinumDef : UnitDef =
        { name = "lootboxplatinum"
          subfolder = "other/lootboxes"
          printableName = Some "Platinum Resource Generator"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 67000.0
          sightDistance = ValueOrExpr.Concrete 96.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "lootboxes/lootboxv2_platinum.s3o"
          buildPic = Some "lootboxes/LOOTBOXPLATINUM.DDS"
          script = Some "lootboxes/lootboxv2.cob"
          corpse = None
          explodeAs = Some "lootboxExplosion4"
          selfDestructAs = Some "lootboxExplosion4"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "80 80 80"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.03
              maxAcc = 0.0
              maxDec = 1.0
              turnRate = 0.0
              movementClass = Some "HHOVER4"
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some false
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 2800.0)
              metalMake = Some (ValueOrExpr.Concrete 140.0)
              energyStorage = None
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "fall_damage_multiplier", "0.0"
              "unitgroup", "energy"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other/lootboxes"
              "paratrooper", "true"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canfight", "false"
              "canguard", "false"
              "canpatrol", "false"
              "canselfdestruct", "true"
              "canstop", "false"
              "cantbetransported", "false"
              "capturable", "true"
              "levelground", "false"
              "mass", "4000.0"
              "movestate", "0.0"
              "noautofire", "false"
              "selfdestructcountdown", "9.0"
              "transportbyenemy", "true"
              "unitname", "lootboxplatinum"
              "upright", "true"
              "usebuildinggrounddecal", "false"
              "reclaimable", "false"
          ] }

    let lootboxplatinumToFlat (def: UnitDef) : Lootboxplatinum =
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
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          customParams = def.customParams
          extras = def.extras }

    let lootboxplatinumToUnitDef (flat: Lootboxplatinum) : UnitDef =
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
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = None
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = None
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Lootboxsilver =
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
          floater: bool
          turnInPlace: bool
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          customParams: Map<string, string>
          extras: Map<string, string> }

    let lootboxsilver : Lootboxsilver =
        { name = "lootboxsilver"
          subfolder = "other/lootboxes"
          printableName = Some "Silver Resource Generator"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 44500.0
          sightDistance = ValueOrExpr.Concrete 96.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "lootboxes/lootboxv2_silver.s3o"
          buildPic = Some "lootboxes/LOOTBOXSILVER.DDS"
          script = Some "lootboxes/lootboxv2.cob"
          corpse = None
          explodeAs = Some "lootboxExplosion2"
          selfDestructAs = Some "lootboxExplosion2"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "48 48 48"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.03
          maxAcc = 0.0
          maxDec = 1.0
          turnRate = 0.0
          movementClass = "HOVER3"
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canMove = true
          floater = true
          turnInPlace = false
          energyMake = ValueOrExpr.Concrete 800.0
          metalMake = ValueOrExpr.Concrete 40.0
          customParams = Map.ofList [
                "fall_damage_multiplier", "0.0"
                "unitgroup", "energy"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/lootboxes"
                "paratrooper", "true"
            ]
          extras = Map.ofList [
                "autoheal", "1.0"
                "canfight", "false"
                "canguard", "false"
                "canpatrol", "false"
                "canselfdestruct", "true"
                "canstop", "false"
                "cantbetransported", "false"
                "capturable", "true"
                "levelground", "false"
                "mass", "749.0"
                "movestate", "0.0"
                "noautofire", "false"
                "selfdestructcountdown", "9.0"
                "transportbyenemy", "true"
                "unitname", "lootboxsilver"
                "upright", "true"
                "usebuildinggrounddecal", "false"
                "reclaimable", "false"
            ] }

    let lootboxsilverDef : UnitDef =
        { name = "lootboxsilver"
          subfolder = "other/lootboxes"
          printableName = Some "Silver Resource Generator"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 44500.0
          sightDistance = ValueOrExpr.Concrete 96.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "lootboxes/lootboxv2_silver.s3o"
          buildPic = Some "lootboxes/LOOTBOXSILVER.DDS"
          script = Some "lootboxes/lootboxv2.cob"
          corpse = None
          explodeAs = Some "lootboxExplosion2"
          selfDestructAs = Some "lootboxExplosion2"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "48 48 48"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.03
              maxAcc = 0.0
              maxDec = 1.0
              turnRate = 0.0
              movementClass = Some "HOVER3"
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some false
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 800.0)
              metalMake = Some (ValueOrExpr.Concrete 40.0)
              energyStorage = None
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "fall_damage_multiplier", "0.0"
              "unitgroup", "energy"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other/lootboxes"
              "paratrooper", "true"
          ]
          extras = Map.ofList [
              "autoheal", "1.0"
              "canfight", "false"
              "canguard", "false"
              "canpatrol", "false"
              "canselfdestruct", "true"
              "canstop", "false"
              "cantbetransported", "false"
              "capturable", "true"
              "levelground", "false"
              "mass", "749.0"
              "movestate", "0.0"
              "noautofire", "false"
              "selfdestructcountdown", "9.0"
              "transportbyenemy", "true"
              "unitname", "lootboxsilver"
              "upright", "true"
              "usebuildinggrounddecal", "false"
              "reclaimable", "false"
          ] }

    let lootboxsilverToFlat (def: UnitDef) : Lootboxsilver =
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
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          customParams = def.customParams
          extras = def.extras }

    let lootboxsilverToUnitDef (flat: Lootboxsilver) : UnitDef =
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
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = None
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = None
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Lootdroppod_gold =
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

    let lootdroppod_gold : Lootdroppod_gold =
        { name = "lootdroppod_gold"
          subfolder = "other/lootboxes"
          printableName = Some "Lootbox Droppod"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/cube.s3o"
          buildPic = Some "lootboxes/lootdrop.DDS"
          script = Some "scavs/droppod.cob"
          corpse = None
          explodeAs = Some ""
          selfDestructAs = Some ""
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0 0 0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          energyStorage = 1000.0
          yardMap = ""
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = "Lootbox"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "raptor", 1.0
                      "default", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 59999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 100.0
                  areaOfEffect = Some 500.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.1
                  noSelfDamage = None
                  soundStart = Some "scavlootdrop"
                  soundHit = Some "scavdroplootspawn"
                  explosiongenerator = Some "custom:dirtpoof"
                  rgbColor = Some "0.95 0.78 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysvisible", "true"
                      "avoidfriendly", "0.0"
                      "cegtag", "lootbox-trail"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "800.0"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "smoketrail", "0.0"
                      "startvelocity", "1.0"
                      "weaponacceleration", "50.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "unitgroup", "builder"
                "isairbase", "true"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/lootboxes"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "capturable", "false"
                "levelground", "false"
                "mass", "165.75"
                "noautofire", "false"
                "radardistance", "900.0"
                "selfdestructcountdown", "5.0"
                "smoothanim", "true"
                "unitname", "lootdroppod_gold"
                "upright", "false"
            ] }

    let lootdroppod_goldDef : UnitDef =
        { name = "lootdroppod_gold"
          subfolder = "other/lootboxes"
          printableName = Some "Lootbox Droppod"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/cube.s3o"
          buildPic = Some "lootboxes/lootdrop.DDS"
          script = Some "scavs/droppod.cob"
          corpse = None
          explodeAs = Some ""
          selfDestructAs = Some ""
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0 0 0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = "Lootbox"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "raptor", 1.0
                    "default", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 59999.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 100.0
                areaOfEffect = Some 500.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.1
                noSelfDamage = None
                soundStart = Some "scavlootdrop"
                soundHit = Some "scavdroplootspawn"
                explosiongenerator = Some "custom:dirtpoof"
                rgbColor = Some "0.95 0.78 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "alwaysvisible", "true"
                    "avoidfriendly", "0.0"
                    "cegtag", "lootbox-trail"
                    "collidefriendly", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "800.0"
                    "interceptedbyshieldtype", "4.0"
                    "metalpershot", "0.0"
                    "smoketrail", "0.0"
                    "startvelocity", "1.0"
                    "weaponacceleration", "50.0"
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
            { yardMap = Some ""
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "unitgroup", "builder"
              "isairbase", "true"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other/lootboxes"
          ]
          extras = Map.ofList [
              "autoheal", "1.8"
              "capturable", "false"
              "levelground", "false"
              "mass", "165.75"
              "noautofire", "false"
              "radardistance", "900.0"
              "selfdestructcountdown", "5.0"
              "smoothanim", "true"
              "unitname", "lootdroppod_gold"
              "upright", "false"
          ] }

    let lootdroppod_goldToFlat (def: UnitDef) : Lootdroppod_gold =
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

    let lootdroppod_goldToUnitDef (flat: Lootdroppod_gold) : UnitDef =
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

    type Lootdroppod_printer =
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

    let lootdroppod_printer : Lootdroppod_printer =
        { name = "lootdroppod_printer"
          subfolder = "other/lootboxes"
          printableName = Some "Lootbox Droppod"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/cube.s3o"
          buildPic = Some "lootboxes/lootdrop.DDS"
          script = Some "scavs/droppod.cob"
          corpse = None
          explodeAs = Some ""
          selfDestructAs = Some ""
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0 0 0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          energyStorage = 1000.0
          yardMap = ""
          activateWhenBuilt = true
          weapons = [
                { name = "weapon"
                  displayName = "Lootbox"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "raptor", 1.0
                      "default", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 59999.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 100.0
                  areaOfEffect = Some 500.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.1
                  noSelfDamage = None
                  soundStart = Some "scavlootdrop"
                  soundHit = Some "scavdropspawnprinter"
                  explosiongenerator = Some "custom:dirtpoof"
                  rgbColor = Some "0.95 0.78 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "alwaysvisible", "true"
                      "avoidfriendly", "0.0"
                      "cegtag", "lootbox-trail"
                      "collidefriendly", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "800.0"
                      "interceptedbyshieldtype", "4.0"
                      "metalpershot", "0.0"
                      "smoketrail", "0.0"
                      "startvelocity", "1.0"
                      "weaponacceleration", "50.0"
                      "weapontimer", "2.0"
                      "wobble", "50.0"
                  ] }
            ]
          customParams = Map.ofList [
                "unitgroup", "builder"
                "isairbase", "true"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/lootboxes"
            ]
          extras = Map.ofList [
                "autoheal", "1.8"
                "capturable", "false"
                "levelground", "false"
                "mass", "165.75"
                "noautofire", "false"
                "radardistance", "900.0"
                "selfdestructcountdown", "5.0"
                "smoothanim", "true"
                "unitname", "lootdroppod_printer"
                "upright", "false"
            ] }

    let lootdroppod_printerDef : UnitDef =
        { name = "lootdroppod_printer"
          subfolder = "other/lootboxes"
          printableName = Some "Lootbox Droppod"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/cube.s3o"
          buildPic = Some "lootboxes/lootdrop.DDS"
          script = Some "scavs/droppod.cob"
          corpse = None
          explodeAs = Some ""
          selfDestructAs = Some ""
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0 0 0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = "Lootbox"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "raptor", 1.0
                    "default", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 59999.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 100.0
                areaOfEffect = Some 500.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.1
                noSelfDamage = None
                soundStart = Some "scavlootdrop"
                soundHit = Some "scavdropspawnprinter"
                explosiongenerator = Some "custom:dirtpoof"
                rgbColor = Some "0.95 0.78 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "alwaysvisible", "true"
                    "avoidfriendly", "0.0"
                    "cegtag", "lootbox-trail"
                    "collidefriendly", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "800.0"
                    "interceptedbyshieldtype", "4.0"
                    "metalpershot", "0.0"
                    "smoketrail", "0.0"
                    "startvelocity", "1.0"
                    "weaponacceleration", "50.0"
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
            { yardMap = Some ""
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "unitgroup", "builder"
              "isairbase", "true"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other/lootboxes"
          ]
          extras = Map.ofList [
              "autoheal", "1.8"
              "capturable", "false"
              "levelground", "false"
              "mass", "165.75"
              "noautofire", "false"
              "radardistance", "900.0"
              "selfdestructcountdown", "5.0"
              "smoothanim", "true"
              "unitname", "lootdroppod_printer"
              "upright", "false"
          ] }

    let lootdroppod_printerToFlat (def: UnitDef) : Lootdroppod_printer =
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

    let lootdroppod_printerToUnitDef (flat: Lootdroppod_printer) : UnitDef =
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

