// Auto-generated BAR unit data: other/raptors/Kamikaze (unified)
namespace BarData.Units

open BarData

module other_raptors_Kamikaze =

    type Raptor_air_kamikaze_basic_t2_v1 =
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
          canFly: bool
          canMove: bool
          turnInPlace: bool
          cruiseAltitude: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_air_kamikaze_basic_t2_v1 : Raptor_air_kamikaze_basic_t2_v1 =
        { name = "raptor_air_kamikaze_basic_t2_v1"
          subfolder = "other/raptors/Kamikaze"
          printableName = Some "Flying Kamikaze"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 1330.0
          sightDistance = ValueOrExpr.Concrete 100.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor_dodo_air.s3o"
          buildPic = Some "raptors/raptor_dodoair.DDS"
          script = Some "Raptors/raptorf1.cob"
          corpse = None
          explodeAs = Some "DODO_DEATHAIR"
          selfDestructAs = Some "DODO_DEATHAIR"
          collisionVolumeOffsets = Some "0 8 -2"
          collisionVolumeScales = Some "35 7 24"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 450.0
          maxAcc = 0.25
          maxDec = 0.1
          turnRate = 3200.0
          canFly = true
          canMove = true
          turnInPlace = true
          cruiseAltitude = 30.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_l_normals.png"
            ]
          extras = Map.ofList [
                "acceleration", "0.8"
                "airhoverfactor", "0.0"
                "attackrunlength", "32.0"
                "canattack", "true"
                "canguard", "true"
                "canland", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cansubmerge", "true"
                "capturable", "false"
                "collide", "false"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "maneuverleashlength", "20000"
                "mass", "227.5"
                "maxaileron", "0.025"
                "maxbank", "0.8"
                "maxelevator", "0.025"
                "maxpitch", "1.0"
                "maxrudder", "0.025"
                "moverate1", "32"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "speedtofront", "0.07"
                "turnradius", "32.0"
                "unitname", "raptorf1"
                "usesmoothmesh", "true"
                "wingangle", "0.06593"
                "wingdrag", "0.835"
                "kamikaze", "true"
                "kamikazedistance", "128.0"
            ] }

    let raptor_air_kamikaze_basic_t2_v1Def : UnitDef =
        { name = "raptor_air_kamikaze_basic_t2_v1"
          subfolder = "other/raptors/Kamikaze"
          printableName = Some "Flying Kamikaze"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 1330.0
          sightDistance = ValueOrExpr.Concrete 100.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptor_dodo_air.s3o"
          buildPic = Some "raptors/raptor_dodoair.DDS"
          script = Some "Raptors/raptorf1.cob"
          corpse = None
          explodeAs = Some "DODO_DEATHAIR"
          selfDestructAs = Some "DODO_DEATHAIR"
          collisionVolumeOffsets = Some "0 8 -2"
          collisionVolumeScales = Some "35 7 24"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 450.0
              maxAcc = 0.25
              maxDec = 0.1
              turnRate = 3200.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = true
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 30.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "acceleration", "0.8"
              "airhoverfactor", "0.0"
              "attackrunlength", "32.0"
              "canattack", "true"
              "canguard", "true"
              "canland", "true"
              "canpatrol", "true"
              "canstop", "1"
              "cansubmerge", "true"
              "capturable", "false"
              "collide", "false"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "maneuverleashlength", "20000"
              "mass", "227.5"
              "maxaileron", "0.025"
              "maxbank", "0.8"
              "maxelevator", "0.025"
              "maxpitch", "1.0"
              "maxrudder", "0.025"
              "moverate1", "32"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "32.0"
              "unitname", "raptorf1"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
              "kamikaze", "true"
              "kamikazedistance", "128.0"
          ] }

    let raptor_air_kamikaze_basic_t2_v1ToFlat (def: UnitDef) : Raptor_air_kamikaze_basic_t2_v1 =
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
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_air_kamikaze_basic_t2_v1ToUnitDef (flat: Raptor_air_kamikaze_basic_t2_v1) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
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
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Raptor_land_kamikaze_basic_t2_v1 =
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
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_kamikaze_basic_t2_v1 : Raptor_land_kamikaze_basic_t2_v1 =
        { name = "raptor_land_kamikaze_basic_t2_v1"
          subfolder = "other/raptors/Kamikaze"
          printableName = Some "Kamikaze"
          metalCost = ValueOrExpr.Concrete 128.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 4500.0
          health = ValueOrExpr.Concrete 890.0
          sightDistance = ValueOrExpr.Concrete 50.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptor_dodo.s3o"
          buildPic = Some "raptors/raptor_dodo1.DDS"
          script = Some "Raptors/raptor_dodo1.cob"
          corpse = None
          explodeAs = Some "DODO_DEATH1"
          selfDestructAs = Some "DODO_DEATH1"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "10 14 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 2.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 210.0
          maxAcc = 6.9
          maxDec = 0.23
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 13.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
                "instantselfd", "true"
            ]
          extras = Map.ofList [
                "autoheal", "50.0"
                "canguard", "true"
                "canhover", "1"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "collide", "false"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "kamikaze", "true"
                "kamikazedistance", "40.0"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "50.0"
                "noautofire", "false"
                "nochasecategory", "VTOL HOVER"
                "selfdestructcountdown", "0.0"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "stealth", "1.0"
                "trackoffset", "1.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "10.0"
                "unitname", "raptor_land_kamikaze_basic_t2_v1"
                "upright", "false"
            ] }

    let raptor_land_kamikaze_basic_t2_v1Def : UnitDef =
        { name = "raptor_land_kamikaze_basic_t2_v1"
          subfolder = "other/raptors/Kamikaze"
          printableName = Some "Kamikaze"
          metalCost = ValueOrExpr.Concrete 128.0
          energyCost = ValueOrExpr.Concrete 3000.0
          buildTime = ValueOrExpr.Concrete 4500.0
          health = ValueOrExpr.Concrete 890.0
          sightDistance = ValueOrExpr.Concrete 50.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/raptor_dodo.s3o"
          buildPic = Some "raptors/raptor_dodo1.DDS"
          script = Some "Raptors/raptor_dodo1.cob"
          corpse = None
          explodeAs = Some "DODO_DEATH1"
          selfDestructAs = Some "DODO_DEATH1"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "10 14 22"
          collisionVolumeType = Some "box"
          seismicSignature = Some 2.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 210.0
              maxAcc = 6.9
              maxDec = 0.23
              turnRate = 1840.0
              movementClass = Some "RAPTORSMALLHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 13.0 })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
              "instantselfd", "true"
          ]
          extras = Map.ofList [
              "autoheal", "50.0"
              "canguard", "true"
              "canhover", "1"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "collide", "false"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "kamikaze", "true"
              "kamikazedistance", "40.0"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "50.0"
              "noautofire", "false"
              "nochasecategory", "VTOL HOVER"
              "selfdestructcountdown", "0.0"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "stealth", "1.0"
              "trackoffset", "1.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "10.0"
              "unitname", "raptor_land_kamikaze_basic_t2_v1"
              "upright", "false"
          ] }

    let raptor_land_kamikaze_basic_t2_v1ToFlat (def: UnitDef) : Raptor_land_kamikaze_basic_t2_v1 =
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
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          waterline = def.movement.Value.waterline.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_land_kamikaze_basic_t2_v1ToUnitDef (flat: Raptor_land_kamikaze_basic_t2_v1) : UnitDef =
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
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Raptor_land_kamikaze_basic_t4_v1 =
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
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          waterline: float
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_kamikaze_basic_t4_v1 : Raptor_land_kamikaze_basic_t4_v1 =
        { name = "raptor_land_kamikaze_basic_t4_v1"
          subfolder = "other/raptors/Kamikaze"
          printableName = Some "Apex Kamikaze"
          metalCost = ValueOrExpr.Concrete 350.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 22500.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 100.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/big_raptor_dodo.s3o"
          buildPic = Some "raptors/raptor_dodo2.DDS"
          script = Some "Raptors/raptor_dodo2.cob"
          corpse = None
          explodeAs = Some "DODO_DEATH2"
          selfDestructAs = Some "DODO_DEATH2"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "18 35 41"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 240.0
          maxAcc = 6.9
          maxDec = 0.23
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 21.0
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_m_normals.png"
                "instantselfd", "true"
            ]
          extras = Map.ofList [
                "autoheal", "135.0"
                "canguard", "true"
                "canhover", "1"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "collide", "0.0"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "kamikaze", "true"
                "kamikazedistance", "72.0"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "100.0"
                "noautofire", "false"
                "nochasecategory", "VTOL HOVER"
                "selfdestructcountdown", "0.0"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "stealth", "1.0"
                "trackoffset", "1.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "10.0"
                "unitname", "raptor_land_kamikaze_basic_t4_v1"
                "upright", "false"
            ] }

    let raptor_land_kamikaze_basic_t4_v1Def : UnitDef =
        { name = "raptor_land_kamikaze_basic_t4_v1"
          subfolder = "other/raptors/Kamikaze"
          printableName = Some "Apex Kamikaze"
          metalCost = ValueOrExpr.Concrete 350.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 22500.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 100.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Raptors/big_raptor_dodo.s3o"
          buildPic = Some "raptors/raptor_dodo2.DDS"
          script = Some "Raptors/raptor_dodo2.cob"
          corpse = None
          explodeAs = Some "DODO_DEATH2"
          selfDestructAs = Some "DODO_DEATH2"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "18 35 41"
          collisionVolumeType = Some "box"
          seismicSignature = Some 4.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 240.0
              maxAcc = 6.9
              maxDec = 0.23
              turnRate = 1840.0
              movementClass = Some "RAPTORSMALLHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 21.0 })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
              "instantselfd", "true"
          ]
          extras = Map.ofList [
              "autoheal", "135.0"
              "canguard", "true"
              "canhover", "1"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "collide", "0.0"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "kamikaze", "true"
              "kamikazedistance", "72.0"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "100.0"
              "noautofire", "false"
              "nochasecategory", "VTOL HOVER"
              "selfdestructcountdown", "0.0"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "stealth", "1.0"
              "trackoffset", "1.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "10.0"
              "unitname", "raptor_land_kamikaze_basic_t4_v1"
              "upright", "false"
          ] }

    let raptor_land_kamikaze_basic_t4_v1ToFlat (def: UnitDef) : Raptor_land_kamikaze_basic_t4_v1 =
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
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          waterline = def.movement.Value.waterline.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_land_kamikaze_basic_t4_v1ToUnitDef (flat: Raptor_land_kamikaze_basic_t4_v1) : UnitDef =
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
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

