// Auto-generated BAR unit data: ArmAircraft/T2 (unified)
namespace BarData.Units

open BarData

module ArmAircraft_T2 =

    type Armaca =
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
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armaca : Armaca =
        { name = "armaca"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Advanced Construction Aircraft"
          metalCost = ValueOrExpr.Concrete 340.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 22000.0
          health = ValueOrExpr.Concrete 200.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMACA.s3o"
          buildPic = Some "ARMACA.DDS"
          script = Some "Units/ARMACA.cob"
          corpse = None
          explodeAs = Some "smallExplosionGeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 192.0
          maxAcc = 0.07
          maxDec = 0.4275
          turnRate = 240.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 80.0
          workerTime = ValueOrExpr.Concrete 120.0
          buildDistance = 136.0
          buildOptions = ["armfus"; "armafus"; "armckfus"; "armageo"; "armuwageo"; "armgmm"; "armmoho"; "armmmkr"; "armuwadves"; "armuwadvms"; "armarad"; "armveil"; "armfort"; "armtarg"; "armsd"; "armgate"; "armamb"; "armpb"; "armanni"; "armflak"; "armmercury"; "armemp"; "armamd"; "armsilo"; "armbrtha"; "armvulc"; "armdf"; "armap"; "armaap"; "armplat"; "armshltx"]
          terraformSpeed = 650.0
          energyMake = ValueOrExpr.Concrete 10.0
          energyStorage = 50.0
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["vtolarmv"]
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft/T2"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "true"
                "hoverattack", "true"
                "radardistance", "50.0"
            ] }

    let armacaDef : UnitDef =
        { name = "armaca"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Advanced Construction Aircraft"
          metalCost = ValueOrExpr.Concrete 340.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 22000.0
          health = ValueOrExpr.Concrete 200.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMACA.s3o"
          buildPic = Some "ARMACA.DDS"
          script = Some "Units/ARMACA.cob"
          corpse = None
          explodeAs = Some "smallExplosionGeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 192.0
              maxAcc = 0.07
              maxDec = 0.4275
              turnRate = 240.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 80.0
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 120.0
              buildDistance = Some 136.0
              buildOptions = ["armfus"; "armafus"; "armckfus"; "armageo"; "armuwageo"; "armgmm"; "armmoho"; "armmmkr"; "armuwadves"; "armuwadvms"; "armarad"; "armveil"; "armfort"; "armtarg"; "armsd"; "armgate"; "armamb"; "armpb"; "armanni"; "armflak"; "armmercury"; "armemp"; "armamd"; "armsilo"; "armbrtha"; "armvulc"; "armdf"; "armap"; "armaap"; "armplat"; "armshltx"]
              terraformSpeed = Some 650.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 10.0)
              metalMake = None
              energyStorage = Some 50.0
              metalStorage = None
              extractsMetal = None })
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
              ok = ["vtolarmv"]
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "radardistance", "50.0"
          ] }

    let armacaToFlat (def: UnitDef) : Armaca =
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
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armacaToUnitDef (flat: Armaca) : UnitDef =
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
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armawac =
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

    let armawac : Armawac =
        { name = "armawac"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Oracle"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 8600.0
          buildTime = ValueOrExpr.Concrete 16000.0
          health = ValueOrExpr.Concrete 890.0
          sightDistance = ValueOrExpr.Concrete 1275.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMAWAC.s3o"
          buildPic = Some "ARMAWAC.DDS"
          script = Some "Units/ARMAWAC.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 317.39999
          maxAcc = 0.1575
          maxDec = 0.05
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 160.0
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
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "selectable_as_combat_unit", "true"
                "subfolder", "ArmAircraft/T2"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "false"
                "maxaileron", "0.01366"
                "maxbank", "0.8"
                "maxelevator", "0.00991"
                "maxpitch", "0.625"
                "maxrudder", "0.00541"
                "radardistance", "2500.0"
                "sonardistance", "1200.0"
                "speedtofront", "0.06417"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06241"
                "wingdrag", "0.135"
            ] }

    let armawacDef : UnitDef =
        { name = "armawac"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Oracle"
          metalCost = ValueOrExpr.Concrete 175.0
          energyCost = ValueOrExpr.Concrete 8600.0
          buildTime = ValueOrExpr.Concrete 16000.0
          health = ValueOrExpr.Concrete 890.0
          sightDistance = ValueOrExpr.Concrete 1275.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMAWAC.s3o"
          buildPic = Some "ARMAWAC.DDS"
          script = Some "Units/ARMAWAC.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 317.39999
              maxAcc = 0.1575
              maxDec = 0.05
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 160.0
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
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "selectable_as_combat_unit", "true"
              "subfolder", "ArmAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.01366"
              "maxbank", "0.8"
              "maxelevator", "0.00991"
              "maxpitch", "0.625"
              "maxrudder", "0.00541"
              "radardistance", "2500.0"
              "sonardistance", "1200.0"
              "speedtofront", "0.06417"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06241"
              "wingdrag", "0.135"
          ] }

    let armawacToFlat (def: UnitDef) : Armawac =
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

    let armawacToUnitDef (flat: Armawac) : UnitDef =
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

    type Armblade =
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
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armblade : Armblade =
        { name = "armblade"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Hornet"
          metalCost = ValueOrExpr.Concrete 1250.0
          energyCost = ValueOrExpr.Concrete 22000.0
          buildTime = ValueOrExpr.Concrete 32000.0
          health = ValueOrExpr.Concrete 3000.0
          sightDistance = ValueOrExpr.Concrete 624.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMBLADE.s3o"
          buildPic = Some "ARMBLADE.DDS"
          script = Some "Units/ARMBLADE.cob"
          corpse = None
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 204.0
          maxAcc = 0.6
          maxDec = 0.35
          turnRate = 720.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 110.0
          weapons = [
                { name = "vtol_sabot"
                  displayName = "Heavy a2g armor-piercing sabot missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 190.0
                  ]
                  range = Some (ValueOrExpr.Concrete 420.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.26667)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 32.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 8000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "SabotFire"
                  soundHit = Some "SabotHit"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "burst", "2.0"
                      "burstrate", "0.23333"
                      "castshadow", "true"
                      "cegtag", "missiletrailsmall-simple"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "model", "cormissile2.s3o"
                      "smokecolor", "0.55"
                      "smokeperiod", "6.0"
                      "smokesize", "9.0"
                      "smoketime", "12.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "500.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "tracks", "true"
                      "turnrate", "18000.0"
                      "weaponacceleration", "440.0"
                      "weapontimer", "3.0"
                  ] }
            ]
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
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "true"
                "hoverattack", "true"
                "nochasecategory", "VTOL"
            ] }

    let armbladeDef : UnitDef =
        { name = "armblade"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Hornet"
          metalCost = ValueOrExpr.Concrete 1250.0
          energyCost = ValueOrExpr.Concrete 22000.0
          buildTime = ValueOrExpr.Concrete 32000.0
          health = ValueOrExpr.Concrete 3000.0
          sightDistance = ValueOrExpr.Concrete 624.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMBLADE.s3o"
          buildPic = Some "ARMBLADE.DDS"
          script = Some "Units/ARMBLADE.cob"
          corpse = None
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 204.0
              maxAcc = 0.6
              maxDec = 0.35
              turnRate = 720.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 110.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "vtol_sabot"
                displayName = "Heavy a2g armor-piercing sabot missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 190.0
                ]
                range = Some (ValueOrExpr.Concrete 420.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.26667)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 32.0
                accuracy = None
                turret = Some false
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "SabotFire"
                soundHit = Some "SabotHit"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "burst", "2.0"
                    "burstrate", "0.23333"
                    "castshadow", "true"
                    "cegtag", "missiletrailsmall-simple"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "model", "cormissile2.s3o"
                    "smokecolor", "0.55"
                    "smokeperiod", "6.0"
                    "smokesize", "9.0"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "500.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "tracks", "true"
                    "turnrate", "18000.0"
                    "weaponacceleration", "440.0"
                    "weapontimer", "3.0"
                ] }
          ]
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
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
          ] }

    let armbladeToFlat (def: UnitDef) : Armblade =
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
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armbladeToUnitDef (flat: Armblade) : UnitDef =
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
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armbrawl =
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
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armbrawl : Armbrawl =
        { name = "armbrawl"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Roughneck"
          metalCost = ValueOrExpr.Concrete 310.0
          energyCost = ValueOrExpr.Concrete 6200.0
          buildTime = ValueOrExpr.Concrete 17000.0
          health = ValueOrExpr.Concrete 1780.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMBRAWL.s3o"
          buildPic = Some "ARMBRAWL.DDS"
          script = Some "Units/ARMBRAWL.cob"
          corpse = None
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 160.8
          maxAcc = 0.24
          maxDec = 0.44
          turnRate = 800.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 100.0
          weapons = [
                { name = "vtol_emg"
                  displayName = "Rapid-fire a2g plasma guns"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 16.0
                      "vtol", 2.0
                  ]
                  range = Some (ValueOrExpr.Concrete 380.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.6)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 40.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "brawlemg"
                  soundHit = None
                  explosiongenerator = Some "custom:plasmahit-medium"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "4.0"
                      "burstrate", "0.15"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "intensity", "0.8"
                      "size", "3.0"
                      "soundhitwet", "splshbig"
                      "sprayangle", "1024.0"
                      "weapontimer", "1.0"
                  ] }
            ]
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
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "firingceg", "barrelshot-tiny"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "true"
                "hoverattack", "true"
                "nochasecategory", "VTOL"
            ] }

    let armbrawlDef : UnitDef =
        { name = "armbrawl"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Roughneck"
          metalCost = ValueOrExpr.Concrete 310.0
          energyCost = ValueOrExpr.Concrete 6200.0
          buildTime = ValueOrExpr.Concrete 17000.0
          health = ValueOrExpr.Concrete 1780.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMBRAWL.s3o"
          buildPic = Some "ARMBRAWL.DDS"
          script = Some "Units/ARMBRAWL.cob"
          corpse = None
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 160.8
              maxAcc = 0.24
              maxDec = 0.44
              turnRate = 800.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 100.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "vtol_emg"
                displayName = "Rapid-fire a2g plasma guns"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 16.0
                    "vtol", 2.0
                ]
                range = Some (ValueOrExpr.Concrete 380.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.6)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 40.0
                accuracy = None
                turret = Some false
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "brawlemg"
                soundHit = None
                explosiongenerator = Some "custom:plasmahit-medium"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "4.0"
                    "burstrate", "0.15"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "intensity", "0.8"
                    "size", "3.0"
                    "soundhitwet", "splshbig"
                    "sprayangle", "1024.0"
                    "weapontimer", "1.0"
                ] }
          ]
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
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "firingceg", "barrelshot-tiny"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
          ] }

    let armbrawlToFlat (def: UnitDef) : Armbrawl =
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
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armbrawlToUnitDef (flat: Armbrawl) : UnitDef =
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
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armdfly =
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
          turnInPlaceAngleLimit: float
          cruiseAltitude: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armdfly : Armdfly =
        { name = "armdfly"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Abductor"
          metalCost = ValueOrExpr.Concrete 320.0
          energyCost = ValueOrExpr.Concrete 6600.0
          buildTime = ValueOrExpr.Concrete 19000.0
          health = ValueOrExpr.Concrete 1170.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMDFLY.s3o"
          buildPic = Some "ARMDFLY.DDS"
          script = Some "Units/ARMDFLY.cob"
          corpse = None
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "1 1 5"
          collisionVolumeScales = Some "52 21 52"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 225.0
          maxAcc = 0.2
          maxDec = 0.625
          turnRate = 420.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          cruiseAltitude = 135.0
          weapons = [
                { name = "armdfly_paralyzer"
                  displayName = "Heavy a2g EMP beam"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 10500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 520.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 32.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "hackshotxl3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-emp"
                  rgbColor = Some "0.7 0.7 1"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "EMPABLE"
                      "avoidfeature", "false"
                      "beamdecay", "0.5"
                      "beamtime", "0.2"
                      "beamttl", "1.0"
                      "collidefriendly", "false"
                      "corethickness", "0.4"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.01"
                      "energypershot", "1000.0"
                      "laserflaresize", "6.05"
                      "paralyzer", "true"
                      "paralyzetime", "6.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "targetmoveerror", "0.3"
                      "thickness", "3.5"
                  ] }
            ]
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
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "crashable", "0.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", "ArmAircraft/T2"
                "techlevel", "2.0"
                "unitgroup", "emp"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "false"
                "hoverattack", "true"
                "nochasecategory", "VTOL"
                "releaseheld", "true"
                "stealth", "true"
                "transportcapacity", "1.0"
                "transportsize", "4.0"
                "transportunloadmethod", "0.0"
                "unloadspread", "0.0"
            ] }

    let armdflyDef : UnitDef =
        { name = "armdfly"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Abductor"
          metalCost = ValueOrExpr.Concrete 320.0
          energyCost = ValueOrExpr.Concrete 6600.0
          buildTime = ValueOrExpr.Concrete 19000.0
          health = ValueOrExpr.Concrete 1170.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMDFLY.s3o"
          buildPic = Some "ARMDFLY.DDS"
          script = Some "Units/ARMDFLY.cob"
          corpse = None
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "1 1 5"
          collisionVolumeScales = Some "52 21 52"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 225.0
              maxAcc = 0.2
              maxDec = 0.625
              turnRate = 420.0
              movementClass = None
              maxSlope = Some 15.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 135.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armdfly_paralyzer"
                displayName = "Heavy a2g EMP beam"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 10500.0
                ]
                range = Some (ValueOrExpr.Concrete 520.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 32.0
                accuracy = None
                turret = Some false
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "hackshotxl3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "EMPABLE"
                    "avoidfeature", "false"
                    "beamdecay", "0.5"
                    "beamtime", "0.2"
                    "beamttl", "1.0"
                    "collidefriendly", "false"
                    "corethickness", "0.4"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.01"
                    "energypershot", "1000.0"
                    "laserflaresize", "6.05"
                    "paralyzer", "true"
                    "paralyzetime", "6.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "targetmoveerror", "0.3"
                    "thickness", "3.5"
                ] }
          ]
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
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "crashable", "0.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "ArmAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "emp"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
              "releaseheld", "true"
              "stealth", "true"
              "transportcapacity", "1.0"
              "transportsize", "4.0"
              "transportunloadmethod", "0.0"
              "unloadspread", "0.0"
          ] }

    let armdflyToFlat (def: UnitDef) : Armdfly =
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
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armdflyToUnitDef (flat: Armdfly) : UnitDef =
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
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some flat.cruiseAltitude
              minWaterDepth = None
              waterline = None
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armhawk =
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
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armhawk : Armhawk =
        { name = "armhawk"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Highwind"
          metalCost = ValueOrExpr.Concrete 140.0
          energyCost = ValueOrExpr.Concrete 5700.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 370.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMHAWK.s3o"
          buildPic = Some "ARMHAWK.DDS"
          script = Some "Units/ARMHAWK.cob"
          corpse = None
          explodeAs = Some "smallExplosionGenericAir"
          selfDestructAs = Some "smallExplosionGenericAir"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 358.79999
          maxAcc = 0.2325
          maxDec = 0.01125
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 160.0
          weapons = [
                { name = "armvtol_advmissile"
                  displayName = "High velocity a2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 8.0
                      "default", 24.0
                      "vtol", 750.0
                  ]
                  range = Some (ValueOrExpr.Concrete 740.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.4)
                  weaponVelocity = Some 970.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = None
                  tolerance = Some 8000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Rocklit3"
                  soundHit = Some "xplosml2"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-air"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "castshadow", "false"
                      "cegtag", "missiletrailfighter"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "0.0"
                      "flighttime", "1.5"
                      "impactonly", "1.0"
                      "metalpershot", "0.0"
                      "model", "cormissilefighter.s3o"
                      "smokecolor", "0.5"
                      "smokeperiod", "4.0"
                      "smokesize", "1.4"
                      "smoketime", "8.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "startvelocity", "515.0"
                      "texture1", "null"
                      "texture2", "smoketrail"
                      "tracks", "true"
                      "turnrate", "28000.0"
                      "weaponacceleration", "450.0"
                      "weapontimer", "7.0"
                  ] }
            ]
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
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "attacksafetydistance", "300.0"
                "fighter", "1.0"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft/T2"
                "techlevel", "2.0"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "1100.0"
                "blocking", "false"
                "collide", "false"
                "maxaileron", "0.01458"
                "maxbank", "0.8"
                "maxelevator", "0.01083"
                "maxpitch", "0.625"
                "maxrudder", "0.00633"
                "nochasecategory", "NOTAIR"
                "speedtofront", "0.063"
                "stealth", "true"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06333"
                "wingdrag", "0.0575"
            ] }

    let armhawkDef : UnitDef =
        { name = "armhawk"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Highwind"
          metalCost = ValueOrExpr.Concrete 140.0
          energyCost = ValueOrExpr.Concrete 5700.0
          buildTime = ValueOrExpr.Concrete 10500.0
          health = ValueOrExpr.Concrete 370.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMHAWK.s3o"
          buildPic = Some "ARMHAWK.DDS"
          script = Some "Units/ARMHAWK.cob"
          corpse = None
          explodeAs = Some "smallExplosionGenericAir"
          selfDestructAs = Some "smallExplosionGenericAir"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 358.79999
              maxAcc = 0.2325
              maxDec = 0.01125
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 160.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armvtol_advmissile"
                displayName = "High velocity a2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "commanders", 8.0
                    "default", 24.0
                    "vtol", 750.0
                ]
                range = Some (ValueOrExpr.Concrete 740.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.4)
                weaponVelocity = Some 970.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = None
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Rocklit3"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-air"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailfighter"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "0.0"
                    "flighttime", "1.5"
                    "impactonly", "1.0"
                    "metalpershot", "0.0"
                    "model", "cormissilefighter.s3o"
                    "smokecolor", "0.5"
                    "smokeperiod", "4.0"
                    "smokesize", "1.4"
                    "smoketime", "8.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "515.0"
                    "texture1", "null"
                    "texture2", "smoketrail"
                    "tracks", "true"
                    "turnrate", "28000.0"
                    "weaponacceleration", "450.0"
                    "weapontimer", "7.0"
                ] }
          ]
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
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "attacksafetydistance", "300.0"
              "fighter", "1.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "1100.0"
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.01458"
              "maxbank", "0.8"
              "maxelevator", "0.01083"
              "maxpitch", "0.625"
              "maxrudder", "0.00633"
              "nochasecategory", "NOTAIR"
              "speedtofront", "0.063"
              "stealth", "true"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06333"
              "wingdrag", "0.0575"
          ] }

    let armhawkToFlat (def: UnitDef) : Armhawk =
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
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armhawkToUnitDef (flat: Armhawk) : UnitDef =
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
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armlance =
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
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armlance : Armlance =
        { name = "armlance"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Cormorant"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 8000.0
          buildTime = ValueOrExpr.Concrete 19000.0
          health = ValueOrExpr.Concrete 1920.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMLANCE.s3o"
          buildPic = Some "ARMLANCE.DDS"
          script = Some "Units/ARMLANCE.cob"
          corpse = None
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 285.0
          maxAcc = 0.1325
          maxDec = 0.075
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 90.0
          weapons = [
                { name = "armair_torpedo"
                  displayName = "Light homing torpedo launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 375.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 6.0)
                  weaponVelocity = Some 200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 2000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = Some "xplodep3"
                  explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                  rgbColor = None
                  customParams = Map.ofList [
                      "speceffect", "torpwaterpen"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTSHIP"
                      "mount_onlytargetcategory", "NOTHOVER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "burst", "3.0"
                      "burstrate", "0.3"
                      "cegtag", "torpedotrail-small"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "4.0"
                      "model", "cortorpedo.s3o"
                      "mygravity", "0.1"
                      "soundhitvolume", "3.5"
                      "soundhitwet", "splsmed"
                      "soundhitwetvolume", "14.0"
                      "startvelocity", "35.0"
                      "tracks", "true"
                      "turnrate", "20000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "35.0"
                      "weapontimer", "6.0"
                  ] }
            ]
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
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "model_author", "Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft/T2"
                "techlevel", "2.0"
                "unitgroup", "sub"
            ]
          extras = Map.ofList [
                "collide", "true"
                "maxaileron", "0.01384"
                "maxbank", "0.8"
                "maxelevator", "0.01009"
                "maxpitch", "0.625"
                "maxrudder", "0.00559"
                "nochasecategory", "VTOL"
                "radardistance", "800.0"
                "sonardistance", "800.0"
                "speedtofront", "0.06417"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06259"
                "wingdrag", "0.185"
            ] }

    let armlanceDef : UnitDef =
        { name = "armlance"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Cormorant"
          metalCost = ValueOrExpr.Concrete 400.0
          energyCost = ValueOrExpr.Concrete 8000.0
          buildTime = ValueOrExpr.Concrete 19000.0
          health = ValueOrExpr.Concrete 1920.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/ARMLANCE.s3o"
          buildPic = Some "ARMLANCE.DDS"
          script = Some "Units/ARMLANCE.cob"
          corpse = None
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 285.0
              maxAcc = 0.1325
              maxDec = 0.075
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 90.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armair_torpedo"
                displayName = "Light homing torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 375.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some false
                tolerance = Some 2000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "xplodep3"
                explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                rgbColor = None
                customParams = Map.ofList [
                    "speceffect", "torpwaterpen"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSHIP"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "burst", "3.0"
                    "burstrate", "0.3"
                    "cegtag", "torpedotrail-small"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "4.0"
                    "model", "cortorpedo.s3o"
                    "mygravity", "0.1"
                    "soundhitvolume", "3.5"
                    "soundhitwet", "splsmed"
                    "soundhitwetvolume", "14.0"
                    "startvelocity", "35.0"
                    "tracks", "true"
                    "turnrate", "20000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "35.0"
                    "weapontimer", "6.0"
                ] }
          ]
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
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "model_author", "Flaka"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "collide", "true"
              "maxaileron", "0.01384"
              "maxbank", "0.8"
              "maxelevator", "0.01009"
              "maxpitch", "0.625"
              "maxrudder", "0.00559"
              "nochasecategory", "VTOL"
              "radardistance", "800.0"
              "sonardistance", "800.0"
              "speedtofront", "0.06417"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06259"
              "wingdrag", "0.185"
          ] }

    let armlanceToFlat (def: UnitDef) : Armlance =
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
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armlanceToUnitDef (flat: Armlance) : UnitDef =
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
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armliche =
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
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armliche : Armliche =
        { name = "armliche"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Liche"
          metalCost = ValueOrExpr.Concrete 2200.0
          energyCost = ValueOrExpr.Concrete 46000.0
          buildTime = ValueOrExpr.Concrete 73000.0
          health = ValueOrExpr.Concrete 2300.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMLICHE.s3o"
          buildPic = Some "ARMLICHE.DDS"
          script = Some "Units/ARMLICHE.cob"
          corpse = None
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 294.89999
          maxAcc = 0.1075
          maxDec = 0.05
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 150.0
          weapons = [
                { name = "arm_pidr"
                  displayName = "Tactical nuclear homing missile"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "commanders", 3150.0
                      "default", 5625.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 9.0)
                  weaponVelocity = Some 420.0
                  areaOfEffect = Some 256.0
                  accuracy = None
                  turret = None
                  tolerance = Some 16000.0
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "bombdropxx"
                  soundHit = Some "tonukeex"
                  explosiongenerator = Some "custom:newnuketac"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "cegtag", "missiletrailmedium-red"
                      "collidefriendly", "false"
                      "craterareaofeffect", "512.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "2.0"
                      "model", "catapultmissile.s3o"
                      "smoketrail", "false"
                      "soundhitwet", "splslrg"
                      "startvelocity", "140.0"
                      "texture1", "null"
                      "tracks", "false"
                      "turnrate", "32768.0"
                      "weaponacceleration", "40.0"
                  ] }
            ]
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
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "attacksafetydistance", "3000.0"
                "lumamult", "1.7"
                "model_author", "Flaka"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "false"
                "firestate", "0.0"
                "maxaileron", "0.01325"
                "maxbank", "0.8"
                "maxelevator", "0.0095"
                "maxpitch", "0.625"
                "maxrudder", "0.005"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "speedtofront", "0.06767"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.062"
                "wingdrag", "0.135"
            ] }

    let armlicheDef : UnitDef =
        { name = "armliche"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Liche"
          metalCost = ValueOrExpr.Concrete 2200.0
          energyCost = ValueOrExpr.Concrete 46000.0
          buildTime = ValueOrExpr.Concrete 73000.0
          health = ValueOrExpr.Concrete 2300.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMLICHE.s3o"
          buildPic = Some "ARMLICHE.DDS"
          script = Some "Units/ARMLICHE.cob"
          corpse = None
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 294.89999
              maxAcc = 0.1075
              maxDec = 0.05
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 150.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "arm_pidr"
                displayName = "Tactical nuclear homing missile"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "commanders", 3150.0
                    "default", 5625.0
                    "subs", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 250.0)
                reloadTime = Some (ValueOrExpr.Concrete 9.0)
                weaponVelocity = Some 420.0
                areaOfEffect = Some 256.0
                accuracy = None
                turret = None
                tolerance = Some 16000.0
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "bombdropxx"
                soundHit = Some "tonukeex"
                explosiongenerator = Some "custom:newnuketac"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "missiletrailmedium-red"
                    "collidefriendly", "false"
                    "craterareaofeffect", "512.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "2.0"
                    "model", "catapultmissile.s3o"
                    "smoketrail", "false"
                    "soundhitwet", "splslrg"
                    "startvelocity", "140.0"
                    "texture1", "null"
                    "tracks", "false"
                    "turnrate", "32768.0"
                    "weaponacceleration", "40.0"
                ] }
          ]
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
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "attacksafetydistance", "3000.0"
              "lumamult", "1.7"
              "model_author", "Flaka"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "firestate", "0.0"
              "maxaileron", "0.01325"
              "maxbank", "0.8"
              "maxelevator", "0.0095"
              "maxpitch", "0.625"
              "maxrudder", "0.005"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "speedtofront", "0.06767"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.062"
              "wingdrag", "0.135"
          ] }

    let armlicheToFlat (def: UnitDef) : Armliche =
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
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armlicheToUnitDef (flat: Armliche) : UnitDef =
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
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armpnix =
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
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armpnix : Armpnix =
        { name = "armpnix"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Blizzard"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 12500.0
          buildTime = ValueOrExpr.Concrete 25000.0
          health = ValueOrExpr.Concrete 1130.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMPNIX.s3o"
          buildPic = Some "ARMPNIX.DDS"
          script = Some "Units/ARMPNIX.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 258.0
          maxAcc = 0.0525
          maxDec = 0.045
          turnRate = 0.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 220.0
          weapons = [
                { name = "armadvbomb"
                  displayName = "Heavy a2g impulse warheads"
                  weaponType = Some "AircraftBomb"
                  damage = Map.ofList [
                      "default", 266.0
                      "subs", 85.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 7.0)
                  weaponVelocity = None
                  areaOfEffect = Some 168.0
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "bombrelxl"
                  soundHit = Some "bombsmed2"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "5.0"
                      "burstrate", "0.2"
                      "collidefriendly", "false"
                      "commandfire", "false"
                      "craterareaofeffect", "168.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "model", "airbombt2.s3o"
                      "mygravity", "0.4"
                      "soundhitwet", "splslrg"
                  ] }
            ]
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
                select = ["vtolarac"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "false"
                "maxaileron", "0.01292"
                "maxbank", "0.8"
                "maxelevator", "0.00917"
                "maxpitch", "0.625"
                "maxrudder", "0.00467"
                "noautofire", "true"
                "nochasecategory", "VTOL"
                "speedtofront", "0.063"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06167"
                "wingdrag", "0.125"
            ] }

    let armpnixDef : UnitDef =
        { name = "armpnix"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Blizzard"
          metalCost = ValueOrExpr.Concrete 230.0
          energyCost = ValueOrExpr.Concrete 12500.0
          buildTime = ValueOrExpr.Concrete 25000.0
          health = ValueOrExpr.Concrete 1130.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMPNIX.s3o"
          buildPic = Some "ARMPNIX.DDS"
          script = Some "Units/ARMPNIX.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 258.0
              maxAcc = 0.0525
              maxDec = 0.045
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "armadvbomb"
                displayName = "Heavy a2g impulse warheads"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 266.0
                    "subs", 85.0
                ]
                range = Some (ValueOrExpr.Concrete 1280.0)
                reloadTime = Some (ValueOrExpr.Concrete 7.0)
                weaponVelocity = None
                areaOfEffect = Some 168.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrelxl"
                soundHit = Some "bombsmed2"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "5.0"
                    "burstrate", "0.2"
                    "collidefriendly", "false"
                    "commandfire", "false"
                    "craterareaofeffect", "168.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "airbombt2.s3o"
                    "mygravity", "0.4"
                    "soundhitwet", "splslrg"
                ] }
          ]
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
              select = ["vtolarac"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.01292"
              "maxbank", "0.8"
              "maxelevator", "0.00917"
              "maxpitch", "0.625"
              "maxrudder", "0.00467"
              "noautofire", "true"
              "nochasecategory", "VTOL"
              "speedtofront", "0.063"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06167"
              "wingdrag", "0.125"
          ] }

    let armpnixToFlat (def: UnitDef) : Armpnix =
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
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armpnixToUnitDef (flat: Armpnix) : UnitDef =
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
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armstil =
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
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armstil : Armstil =
        { name = "armstil"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Stiletto"
          metalCost = ValueOrExpr.Concrete 460.0
          energyCost = ValueOrExpr.Concrete 38000.0
          buildTime = ValueOrExpr.Concrete 39000.0
          health = ValueOrExpr.Concrete 1880.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMSTIL.s3o"
          buildPic = Some "ARMSTIL.DDS"
          script = Some "Units/ARMSTIL.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "24 9 24"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 300.0
          maxAcc = 0.1575
          maxDec = 0.04
          turnRate = 0.0
          maxSlope = 15.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          cruiseAltitude = 120.0
          weapons = [
                { name = "stiletto_bomb"
                  displayName = "Heavy a2g EMP warheads"
                  weaponType = Some "AircraftBomb"
                  damage = Map.ofList [
                      "default", 6000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 7.0)
                  weaponVelocity = None
                  areaOfEffect = Some 200.0
                  accuracy = None
                  turret = None
                  tolerance = Some 7000.0
                  edgeEffectiveness = Some 0.25
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = Some "EMGPULS1"
                  explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "3.0"
                      "burstrate", "0.2333"
                      "collidefriendly", "false"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "90.0"
                      "gravityaffected", "true"
                      "model", "airbomb.s3o"
                      "mygravity", "0.4"
                      "paralyzer", "true"
                      "paralyzetime", "20.0"
                      "soundhitwet", "splslrg"
                  ] }
            ]
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
                select = ["vtolcrac"] }
          customParams = Map.ofList [
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmAircraft/T2"
                "techlevel", "2.0"
                "unitgroup", "emp"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "collide", "false"
                "maxaileron", "0.01347"
                "maxbank", "0.8"
                "maxelevator", "0.00972"
                "maxpitch", "0.625"
                "maxrudder", "0.00522"
                "nochasecategory", "VTOL"
                "speedtofront", "0.06125"
                "stealth", "true"
                "turnradius", "64.0"
                "usesmoothmesh", "true"
                "wingangle", "0.06222"
                "wingdrag", "0.115"
            ] }

    let armstilDef : UnitDef =
        { name = "armstil"
          subfolder = "ArmAircraft/T2"
          printableName = Some "Stiletto"
          metalCost = ValueOrExpr.Concrete 460.0
          energyCost = ValueOrExpr.Concrete 38000.0
          buildTime = ValueOrExpr.Concrete 39000.0
          health = ValueOrExpr.Concrete 1880.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMSTIL.s3o"
          buildPic = Some "ARMSTIL.DDS"
          script = Some "Units/ARMSTIL.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "24 9 24"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 300.0
              maxAcc = 0.1575
              maxDec = 0.04
              turnRate = 0.0
              movementClass = None
              maxSlope = Some 15.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 120.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "stiletto_bomb"
                displayName = "Heavy a2g EMP warheads"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 6000.0
                ]
                range = Some (ValueOrExpr.Concrete 1280.0)
                reloadTime = Some (ValueOrExpr.Concrete 7.0)
                weaponVelocity = None
                areaOfEffect = Some 200.0
                accuracy = None
                turret = None
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.25
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "EMGPULS1"
                explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "3.0"
                    "burstrate", "0.2333"
                    "collidefriendly", "false"
                    "commandfire", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "90.0"
                    "gravityaffected", "true"
                    "model", "airbomb.s3o"
                    "mygravity", "0.4"
                    "paralyzer", "true"
                    "paralyzetime", "20.0"
                    "soundhitwet", "splslrg"
                ] }
          ]
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
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "emp"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.01347"
              "maxbank", "0.8"
              "maxelevator", "0.00972"
              "maxpitch", "0.625"
              "maxrudder", "0.00522"
              "nochasecategory", "VTOL"
              "speedtofront", "0.06125"
              "stealth", "true"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06222"
              "wingdrag", "0.115"
          ] }

    let armstilToFlat (def: UnitDef) : Armstil =
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
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armstilToUnitDef (flat: Armstil) : UnitDef =
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
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

