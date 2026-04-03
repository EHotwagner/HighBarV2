// Auto-generated BAR unit data: other/raptors/Healer (unified)
namespace BarData.Units

open BarData

module other_raptors_Healer =

    type Raptor_land_swarmer_heal_t1_v1 =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          energyMake: ValueOrExpr<float>
          metalStorage: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_swarmer_heal_t1_v1 : Raptor_land_swarmer_heal_t1_v1 =
        { name = "raptor_land_swarmer_heal_t1_v1"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 250.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptorhealer1.s3o"
          buildPic = Some "raptors/raptorhealer.DDS"
          script = Some "Raptors/raptorhealer.cob"
          corpse = None
          explodeAs = Some "WEAVER_DEATH"
          selfDestructAs = Some "WEAVER_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "10 14 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 1.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 75.0
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 12.0
          energyMake = ValueOrExpr.Concrete 25.0
          metalStorage = 1000.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "32.0"
                "canassist", "1.0"
                "canbuild", "1.0"
                "canguard", "1.0"
                "canpatrol", "1.0"
                "canrepair", "1.0"
                "canreclaim", "0.0"
                "canstop", "1.0"
                "capturable", "false"
                "collide", "0.0"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "50.0"
                "mobilestandorders", "1.0"
                "noautofire", "0.0"
                "reclaimspeed", "400.0"
                "repairable", "false"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "standingmoveorder", "1.0"
                "stealth", "1.0"
                "trackoffset", "1.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "10.0"
                "unitname", "raptor_land_swarmer_heal_t1_v1"
                "upright", "false"
            ] }

    let raptor_land_swarmer_heal_t1_v1Def : UnitDef =
        { name = "raptor_land_swarmer_heal_t1_v1"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 250.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptorhealer1.s3o"
          buildPic = Some "raptors/raptorhealer.DDS"
          script = Some "Raptors/raptorhealer.cob"
          corpse = None
          explodeAs = Some "WEAVER_DEATH"
          selfDestructAs = Some "WEAVER_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "10 14 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 1.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 75.0
              maxAcc = 1.0
              maxDec = 1.0
              turnRate = 1840.0
              movementClass = Some "RAPTORSMALLHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 12.0 })
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 25.0)
              metalMake = None
              energyStorage = None
              metalStorage = Some 1000.0
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
          ]
          extras = Map.ofList [
              "autoheal", "32.0"
              "canassist", "1.0"
              "canbuild", "1.0"
              "canguard", "1.0"
              "canpatrol", "1.0"
              "canrepair", "1.0"
              "canreclaim", "0.0"
              "canstop", "1.0"
              "capturable", "false"
              "collide", "0.0"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "50.0"
              "mobilestandorders", "1.0"
              "noautofire", "0.0"
              "reclaimspeed", "400.0"
              "repairable", "false"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "standingmoveorder", "1.0"
              "stealth", "1.0"
              "trackoffset", "1.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "10.0"
              "unitname", "raptor_land_swarmer_heal_t1_v1"
              "upright", "false"
          ] }

    let raptor_land_swarmer_heal_t1_v1ToFlat (def: UnitDef) : Raptor_land_swarmer_heal_t1_v1 =
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          waterline = def.movement.Value.waterline.Value
          energyMake = def.economy.Value.energyMake.Value
          metalStorage = def.economy.Value.metalStorage.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_land_swarmer_heal_t1_v1ToUnitDef (flat: Raptor_land_swarmer_heal_t1_v1) : UnitDef =
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = None
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = None
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Raptor_land_swarmer_heal_t2_v1 =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          energyMake: ValueOrExpr<float>
          metalStorage: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_swarmer_heal_t2_v1 : Raptor_land_swarmer_heal_t2_v1 =
        { name = "raptor_land_swarmer_heal_t2_v1"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 500.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptorhealer2.s3o"
          buildPic = Some "raptors/raptorhealer.DDS"
          script = Some "Raptors/raptorhealer.cob"
          corpse = None
          explodeAs = Some "WEAVER_DEATH"
          selfDestructAs = Some "WEAVER_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "10 14 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 1.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 112.5
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 12.0
          energyMake = ValueOrExpr.Concrete 25.0
          metalStorage = 1000.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "32.0"
                "canassist", "1.0"
                "canbuild", "1.0"
                "canguard", "1.0"
                "canpatrol", "1.0"
                "canrepair", "1.0"
                "canreclaim", "0.0"
                "canstop", "1.0"
                "capturable", "false"
                "collide", "0.0"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "50.0"
                "mobilestandorders", "1.0"
                "noautofire", "0.0"
                "reclaimspeed", "400.0"
                "repairable", "false"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "standingmoveorder", "1.0"
                "stealth", "1.0"
                "trackoffset", "1.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "10.0"
                "unitname", "raptor_land_swarmer_heal_t2_v1"
                "upright", "false"
            ] }

    let raptor_land_swarmer_heal_t2_v1Def : UnitDef =
        { name = "raptor_land_swarmer_heal_t2_v1"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 500.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptorhealer2.s3o"
          buildPic = Some "raptors/raptorhealer.DDS"
          script = Some "Raptors/raptorhealer.cob"
          corpse = None
          explodeAs = Some "WEAVER_DEATH"
          selfDestructAs = Some "WEAVER_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "10 14 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 1.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 112.5
              maxAcc = 1.0
              maxDec = 1.0
              turnRate = 1840.0
              movementClass = Some "RAPTORSMALLHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 12.0 })
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 25.0)
              metalMake = None
              energyStorage = None
              metalStorage = Some 1000.0
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
          ]
          extras = Map.ofList [
              "autoheal", "32.0"
              "canassist", "1.0"
              "canbuild", "1.0"
              "canguard", "1.0"
              "canpatrol", "1.0"
              "canrepair", "1.0"
              "canreclaim", "0.0"
              "canstop", "1.0"
              "capturable", "false"
              "collide", "0.0"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "50.0"
              "mobilestandorders", "1.0"
              "noautofire", "0.0"
              "reclaimspeed", "400.0"
              "repairable", "false"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "standingmoveorder", "1.0"
              "stealth", "1.0"
              "trackoffset", "1.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "10.0"
              "unitname", "raptor_land_swarmer_heal_t2_v1"
              "upright", "false"
          ] }

    let raptor_land_swarmer_heal_t2_v1ToFlat (def: UnitDef) : Raptor_land_swarmer_heal_t2_v1 =
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          waterline = def.movement.Value.waterline.Value
          energyMake = def.economy.Value.energyMake.Value
          metalStorage = def.economy.Value.metalStorage.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_land_swarmer_heal_t2_v1ToUnitDef (flat: Raptor_land_swarmer_heal_t2_v1) : UnitDef =
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = None
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = None
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Raptor_land_swarmer_heal_t3_v1 =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          energyMake: ValueOrExpr<float>
          metalStorage: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_swarmer_heal_t3_v1 : Raptor_land_swarmer_heal_t3_v1 =
        { name = "raptor_land_swarmer_heal_t3_v1"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 750.0
          sightDistance = ValueOrExpr.Concrete 800.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptorhealer3.s3o"
          buildPic = Some "raptors/raptorhealer.DDS"
          script = Some "Raptors/raptorhealer.cob"
          corpse = None
          explodeAs = Some "WEAVER_DEATH"
          selfDestructAs = Some "WEAVER_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "10 14 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 1.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 150.0
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 12.0
          energyMake = ValueOrExpr.Concrete 25.0
          metalStorage = 1000.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "32.0"
                "canassist", "1.0"
                "canbuild", "1.0"
                "canguard", "1.0"
                "canpatrol", "1.0"
                "canrepair", "1.0"
                "canreclaim", "0.0"
                "canstop", "1.0"
                "capturable", "false"
                "collide", "0.0"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "50.0"
                "mobilestandorders", "1.0"
                "noautofire", "0.0"
                "reclaimspeed", "400.0"
                "repairable", "false"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "standingmoveorder", "1.0"
                "stealth", "1.0"
                "trackoffset", "1.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "10.0"
                "unitname", "raptor_land_swarmer_heal_t3_v1"
                "upright", "false"
            ] }

    let raptor_land_swarmer_heal_t3_v1Def : UnitDef =
        { name = "raptor_land_swarmer_heal_t3_v1"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 750.0
          sightDistance = ValueOrExpr.Concrete 800.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptorhealer3.s3o"
          buildPic = Some "raptors/raptorhealer.DDS"
          script = Some "Raptors/raptorhealer.cob"
          corpse = None
          explodeAs = Some "WEAVER_DEATH"
          selfDestructAs = Some "WEAVER_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "10 14 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 1.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 150.0
              maxAcc = 1.0
              maxDec = 1.0
              turnRate = 1840.0
              movementClass = Some "RAPTORSMALLHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 12.0 })
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 25.0)
              metalMake = None
              energyStorage = None
              metalStorage = Some 1000.0
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
          ]
          extras = Map.ofList [
              "autoheal", "32.0"
              "canassist", "1.0"
              "canbuild", "1.0"
              "canguard", "1.0"
              "canpatrol", "1.0"
              "canrepair", "1.0"
              "canreclaim", "0.0"
              "canstop", "1.0"
              "capturable", "false"
              "collide", "0.0"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "50.0"
              "mobilestandorders", "1.0"
              "noautofire", "0.0"
              "reclaimspeed", "400.0"
              "repairable", "false"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "standingmoveorder", "1.0"
              "stealth", "1.0"
              "trackoffset", "1.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "10.0"
              "unitname", "raptor_land_swarmer_heal_t3_v1"
              "upright", "false"
          ] }

    let raptor_land_swarmer_heal_t3_v1ToFlat (def: UnitDef) : Raptor_land_swarmer_heal_t3_v1 =
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          waterline = def.movement.Value.waterline.Value
          energyMake = def.economy.Value.energyMake.Value
          metalStorage = def.economy.Value.metalStorage.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_land_swarmer_heal_t3_v1ToUnitDef (flat: Raptor_land_swarmer_heal_t3_v1) : UnitDef =
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = None
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = None
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Raptor_land_swarmer_heal_t4_v1 =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          energyMake: ValueOrExpr<float>
          metalStorage: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_swarmer_heal_t4_v1 : Raptor_land_swarmer_heal_t4_v1 =
        { name = "raptor_land_swarmer_heal_t4_v1"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 1000.0
          sightDistance = ValueOrExpr.Concrete 900.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptorhealer4.s3o"
          buildPic = Some "raptors/raptorhealer.DDS"
          script = Some "Raptors/raptorhealer.cob"
          corpse = None
          explodeAs = Some "WEAVER_DEATH"
          selfDestructAs = Some "WEAVER_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "10 14 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 1.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 187.5
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 12.0
          energyMake = ValueOrExpr.Concrete 25.0
          metalStorage = 1000.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "32.0"
                "canassist", "1.0"
                "canbuild", "1.0"
                "canguard", "1.0"
                "canpatrol", "1.0"
                "canrepair", "1.0"
                "canreclaim", "0.0"
                "canstop", "1.0"
                "capturable", "false"
                "collide", "0.0"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "50.0"
                "mobilestandorders", "1.0"
                "noautofire", "0.0"
                "reclaimspeed", "400.0"
                "repairable", "false"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "standingmoveorder", "1.0"
                "stealth", "1.0"
                "trackoffset", "1.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "10.0"
                "unitname", "raptor_land_swarmer_heal_t4_v1"
                "upright", "false"
            ] }

    let raptor_land_swarmer_heal_t4_v1Def : UnitDef =
        { name = "raptor_land_swarmer_heal_t4_v1"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 750.0
          health = ValueOrExpr.Concrete 1000.0
          sightDistance = ValueOrExpr.Concrete 900.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptorhealer4.s3o"
          buildPic = Some "raptors/raptorhealer.DDS"
          script = Some "Raptors/raptorhealer.cob"
          corpse = None
          explodeAs = Some "WEAVER_DEATH"
          selfDestructAs = Some "WEAVER_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "10 14 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 1.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 187.5
              maxAcc = 1.0
              maxDec = 1.0
              turnRate = 1840.0
              movementClass = Some "RAPTORSMALLHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 12.0 })
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 25.0)
              metalMake = None
              energyStorage = None
              metalStorage = Some 1000.0
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
          ]
          extras = Map.ofList [
              "autoheal", "32.0"
              "canassist", "1.0"
              "canbuild", "1.0"
              "canguard", "1.0"
              "canpatrol", "1.0"
              "canrepair", "1.0"
              "canreclaim", "0.0"
              "canstop", "1.0"
              "capturable", "false"
              "collide", "0.0"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "50.0"
              "mobilestandorders", "1.0"
              "noautofire", "0.0"
              "reclaimspeed", "400.0"
              "repairable", "false"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "standingmoveorder", "1.0"
              "stealth", "1.0"
              "trackoffset", "1.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "10.0"
              "unitname", "raptor_land_swarmer_heal_t4_v1"
              "upright", "false"
          ] }

    let raptor_land_swarmer_heal_t4_v1ToFlat (def: UnitDef) : Raptor_land_swarmer_heal_t4_v1 =
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          waterline = def.movement.Value.waterline.Value
          energyMake = def.economy.Value.energyMake.Value
          metalStorage = def.economy.Value.metalStorage.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_land_swarmer_heal_t4_v1ToUnitDef (flat: Raptor_land_swarmer_heal_t4_v1) : UnitDef =
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = None
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = None
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Raptorh1b =
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
          movementClass: string
          maxSlope: float
          maxWaterDepth: float
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          energyMake: ValueOrExpr<float>
          metalStorage: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptorh1b : Raptorh1b =
        { name = "raptorh1b"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 1125.0
          health = ValueOrExpr.Concrete 365.0
          sightDistance = ValueOrExpr.Concrete 50.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptor_droneb.s3o"
          buildPic = Some "raptors/raptorh1b.DDS"
          script = Some "Raptors/raptorh1b.cob"
          corpse = None
          explodeAs = Some "WEAVER_DEATH"
          selfDestructAs = Some "WEAVER_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "15 18 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 1.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 150.0
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 13.0
          energyMake = ValueOrExpr.Concrete 15.0
          metalStorage = 1000.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
            ]
          extras = Map.ofList [
                "autoheal", "24.0"
                "canassist", "0.0"
                "canbuild", "1.0"
                "canguard", "1.0"
                "canpatrol", "1.0"
                "canrepair", "0.0"
                "canreclaim", "1.0"
                "canstop", "1.0"
                "capturable", "false"
                "collide", "0.0"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "60.0"
                "mobilestandorders", "1.0"
                "noautofire", "0.0"
                "reclaimspeed", "400.0"
                "repairable", "false"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "standingmoveorder", "1.0"
                "stealth", "1.0"
                "trackoffset", "1.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "10.0"
                "unitname", "raptorh1b"
                "upright", "false"
            ] }

    let raptorh1bDef : UnitDef =
        { name = "raptorh1b"
          subfolder = "other/raptors/Healer"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 600.0
          buildTime = ValueOrExpr.Concrete 1125.0
          health = ValueOrExpr.Concrete 365.0
          sightDistance = ValueOrExpr.Concrete 50.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptor_droneb.s3o"
          buildPic = Some "raptors/raptorh1b.DDS"
          script = Some "Raptors/raptorh1b.cob"
          corpse = None
          explodeAs = Some "WEAVER_DEATH"
          selfDestructAs = Some "WEAVER_DEATH"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "15 18 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 1.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 150.0
              maxAcc = 1.0
              maxDec = 1.0
              turnRate = 1840.0
              movementClass = Some "RAPTORSMALLHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 13.0 })
          builder = None
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 15.0)
              metalMake = None
              energyStorage = None
              metalStorage = Some 1000.0
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
          ]
          extras = Map.ofList [
              "autoheal", "24.0"
              "canassist", "0.0"
              "canbuild", "1.0"
              "canguard", "1.0"
              "canpatrol", "1.0"
              "canrepair", "0.0"
              "canreclaim", "1.0"
              "canstop", "1.0"
              "capturable", "false"
              "collide", "0.0"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "60.0"
              "mobilestandorders", "1.0"
              "noautofire", "0.0"
              "reclaimspeed", "400.0"
              "repairable", "false"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "standingmoveorder", "1.0"
              "stealth", "1.0"
              "trackoffset", "1.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "10.0"
              "unitname", "raptorh1b"
              "upright", "false"
          ] }

    let raptorh1bToFlat (def: UnitDef) : Raptorh1b =
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
          movementClass = def.movement.Value.movementClass.Value
          maxSlope = def.movement.Value.maxSlope.Value
          maxWaterDepth = def.movement.Value.maxWaterDepth.Value
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          waterline = def.movement.Value.waterline.Value
          energyMake = def.economy.Value.energyMake.Value
          metalStorage = def.economy.Value.metalStorage.Value
          customParams = def.customParams
          extras = def.extras }

    let raptorh1bToUnitDef (flat: Raptorh1b) : UnitDef =
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
              movementClass = Some flat.movementClass
              maxSlope = Some flat.maxSlope
              maxWaterDepth = Some flat.maxWaterDepth
              canFly = false
              canMove = false
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = None
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = None
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

