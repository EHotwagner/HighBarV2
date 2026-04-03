// Auto-generated BAR unit data: CorShips/T2 (unified)
namespace BarData.Units

open BarData

module CorShips_T2 =

    type Coracsub =
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
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let coracsub : Coracsub =
        { name = "coracsub"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 700.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 23000.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 156.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORACSUB.s3o"
          buildPic = Some "CORACSUB.DDS"
          script = Some "Units/CORACSUB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-uw"
          selfDestructAs = Some "mediumexplosiongenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 4"
          collisionVolumeScales = Some "40 25 74"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 64.8
          maxAcc = 0.042
          maxDec = 0.042
          turnRate = 385.5
          movementClass = "UBOAT4"
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 20.0
          waterline = 80.0
          workerTime = ValueOrExpr.Concrete 350.0
          buildDistance = 180.0
          buildOptions = ["coruwfus"; "coruwmmm"; "coruwmme"; "coruwadves"; "coruwadvms"; "corgantuw"; "corasy"; "corsy"; "corason"; "corfatf"; "coratl"; "corenaa"; "corfdoom"; "coruwageo"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 30.0
          energyStorage = 150.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -1.62156426758 -7.49900054932"
                  collisionVolumeScales = Some "45.8502807617 11.0077514648 73.3929595947"
                  collisionVolumeType = Some "Box"
                  damage = Some 444.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 350.0
                  object_ = Some "Units/coracsub_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1432.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 175.0
                  object_ = Some "Units/cor4X4C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sucormov"]
                select = ["sucorsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
            ] }

    let coracsubDef : UnitDef =
        { name = "coracsub"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 700.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 23000.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 156.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORACSUB.s3o"
          buildPic = Some "CORACSUB.DDS"
          script = Some "Units/CORACSUB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-uw"
          selfDestructAs = Some "mediumexplosiongenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 4"
          collisionVolumeScales = Some "40 25 74"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 64.8
              maxAcc = 0.042
              maxDec = 0.042
              turnRate = 385.5
              movementClass = Some "UBOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 20.0
              waterline = Some 80.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 350.0
              buildDistance = Some 180.0
              buildOptions = ["coruwfus"; "coruwmmm"; "coruwmme"; "coruwadves"; "coruwadvms"; "corgantuw"; "corasy"; "corsy"; "corason"; "corfatf"; "coratl"; "corenaa"; "corfdoom"; "coruwageo"]
              terraformSpeed = Some 1500.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 30.0)
              metalMake = None
              energyStorage = Some 150.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -1.62156426758 -7.49900054932"
                collisionVolumeScales = Some "45.8502807617 11.0077514648 73.3929595947"
                collisionVolumeType = Some "Box"
                damage = Some 444.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 350.0
                object_ = Some "Units/coracsub_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1432.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 175.0
                object_ = Some "Units/cor4X4C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sucormov"]
              select = ["sucorsel"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "radardistance", "50.0"
          ] }

    let coracsubToFlat (def: UnitDef) : Coracsub =
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
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let coracsubToUnitDef (flat: Coracsub) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corantiship =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corantiship : Corantiship =
        { name = "corantiship"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1400.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 27000.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/CORANTISHIP.s3o"
          buildPic = Some "CORANTISHIP.DDS"
          script = Some "Units/corantiship.cob"
          corpse = Some "DEAD"
          explodeAs = Some "minifusionExplosion"
          selfDestructAs = Some "minifusionExplosion"
          collisionVolumeOffsets = Some "0 0 2"
          collisionVolumeScales = Some "48 48 140"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 63.0
          maxAcc = 0.01722
          maxDec = 0.01722
          turnRate = 180.0
          movementClass = "BOAT5"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 0.0
          energyMake = ValueOrExpr.Concrete 300.0
          energyStorage = 1500.0
          weapons = [
                { name = "amd_rocket"
                  displayName = "ICBM intercepting missile launcher"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 1500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 72000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 6000.0
                  areaOfEffect = Some 420.0
                  accuracy = None
                  turret = None
                  tolerance = Some 7000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "antinukelaunch"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:antinuke"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "ALL"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "cegtag", "antimissiletrail"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "coverage", "1600.0"
                      "craterareaofeffect", "420.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "7500.0"
                      "firestarter", "100.0"
                      "flighttime", "20.0"
                      "interceptor", "1.0"
                      "metalpershot", "150.0"
                      "model", "fmdmissile.s3o"
                      "smokecolor", "0.7"
                      "smokeperiod", "10.0"
                      "smokesize", "27.0"
                      "smoketime", "110.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "true"
                      "soundhitwet", "splslrg"
                      "stockpile", "true"
                      "stockpiletime", "90.0"
                      "texture1", "bluenovaexplo"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "tracks", "true"
                      "turnrate", "10000.0"
                      "weaponacceleration", "150.0"
                      "weapontimer", "2.5"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.0550308227539 1.52587890767e-06 4.55026245117"
                  collisionVolumeScales = Some "61.8225860596 60.9250030518 154.450805664"
                  collisionVolumeType = Some "Box"
                  damage = Some 9168.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 700.0
                  object_ = Some "Units/corantiship_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 350.0
                  object_ = Some "Units/arm6X6C.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "model_author", "Odin"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "antinuke"
                "restrictions_exclusion", "_noantinuke_"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "canassist", "false"
                "canattack", "false"
                "canreclaim", "false"
                "canrepair", "false"
                "canrestore", "false"
                "energypershot", "7500.0"
                "mass", "10000.0"
                "movestate", "0.0"
                "nochasecategory", "ALL"
                "radardistance", "2950.0"
                "radaremitheight", "56.0"
                "sightemitheight", "56.0"
                "sonardistance", "760.0"
            ] }

    let corantishipDef : UnitDef =
        { name = "corantiship"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1400.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 27000.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/CORANTISHIP.s3o"
          buildPic = Some "CORANTISHIP.DDS"
          script = Some "Units/corantiship.cob"
          corpse = Some "DEAD"
          explodeAs = Some "minifusionExplosion"
          selfDestructAs = Some "minifusionExplosion"
          collisionVolumeOffsets = Some "0 0 2"
          collisionVolumeScales = Some "48 48 140"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 63.0
              maxAcc = 0.01722
              maxDec = 0.01722
              turnRate = 180.0
              movementClass = Some "BOAT5"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "amd_rocket"
                displayName = "ICBM intercepting missile launcher"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 1500.0
                ]
                range = Some (ValueOrExpr.Concrete 72000.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 6000.0
                areaOfEffect = Some 420.0
                accuracy = None
                turret = None
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "antinukelaunch"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:antinuke"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "ALL"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "antimissiletrail"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "coverage", "1600.0"
                    "craterareaofeffect", "420.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "7500.0"
                    "firestarter", "100.0"
                    "flighttime", "20.0"
                    "interceptor", "1.0"
                    "metalpershot", "150.0"
                    "model", "fmdmissile.s3o"
                    "smokecolor", "0.7"
                    "smokeperiod", "10.0"
                    "smokesize", "27.0"
                    "smoketime", "110.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "true"
                    "soundhitwet", "splslrg"
                    "stockpile", "true"
                    "stockpiletime", "90.0"
                    "texture1", "bluenovaexplo"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "tracks", "true"
                    "turnrate", "10000.0"
                    "weaponacceleration", "150.0"
                    "weapontimer", "2.5"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 300.0)
              metalMake = None
              energyStorage = Some 1500.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.0550308227539 1.52587890767e-06 4.55026245117"
                collisionVolumeScales = Some "61.8225860596 60.9250030518 154.450805664"
                collisionVolumeType = Some "Box"
                damage = Some 9168.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 700.0
                object_ = Some "Units/corantiship_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 350.0
                object_ = Some "Units/arm6X6C.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "model_author", "Odin"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "antinuke"
              "restrictions_exclusion", "_noantinuke_"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "canassist", "false"
              "canattack", "false"
              "canreclaim", "false"
              "canrepair", "false"
              "canrestore", "false"
              "energypershot", "7500.0"
              "mass", "10000.0"
              "movestate", "0.0"
              "nochasecategory", "ALL"
              "radardistance", "2950.0"
              "radaremitheight", "56.0"
              "sightemitheight", "56.0"
              "sonardistance", "760.0"
          ] }

    let corantishipToFlat (def: UnitDef) : Corantiship =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corantishipToUnitDef (flat: Corantiship) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corarch =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corarch : Corarch =
        { name = "corarch"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 21000.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 465.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORARCH.s3o"
          buildPic = Some "CORARCH.DDS"
          script = Some "Units/CORARCH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -4 3"
          collisionVolumeScales = Some "37 37 74"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 60.48
          maxAcc = 0.03127
          maxDec = 0.03127
          turnRate = 340.5
          movementClass = "BOAT4"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 30.0
          waterline = 0.0
          weapons = [
                { name = "bogus_missile"
                  displayName = "Missiles"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 800.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.5)
                  weaponVelocity = Some 650.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 9000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = None
                  soundStart = None
                  soundHit = None
                  explosiongenerator = None
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "canattackground", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "metalpershot", "0.0"
                      "soundhitwet", "splshbig"
                      "startvelocity", "450.0"
                      "turnrate", "33000.0"
                      "weaponacceleration", "101.0"
                      "weapontimer", "0.1"
                  ] }
                { name = "ga2"
                  displayName = "AA2Missile"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 125.0
                  ]
                  range = Some (ValueOrExpr.Concrete 870.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.6)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 64.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 9950.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "packolau"
                  soundHit = Some "packohit"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = None
                  customParams = Map.ofList [
                      "projectile_destruction_method", "descend"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "burst", "2.0"
                      "burstrate", "0.4"
                      "canattackground", "false"
                      "castshadow", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "1.75"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smokecolor", "0.95"
                      "smokeperiod", "5.0"
                      "smokesize", "4.8"
                      "smoketime", "12.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splssml"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1200.0"
                      "weapontimer", "2.0"
                  ] }
                { name = "mobileflak"
                  displayName = "FlakCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "vtol", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 775.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.73333)
                  weaponVelocity = Some 1550.0
                  areaOfEffect = Some 140.0
                  accuracy = Some 1000.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "flakfire"
                  soundHit = Some "flakhit"
                  explosiongenerator = Some "custom:flak"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "LIGHTAIRSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "flaktrailaa"
                      "craterareaofeffect", "140.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "gravityaffected", "true"
                      "size", "0.0"
                      "sizedecay", "0.08"
                      "soundhitwet", "splsmed"
                      "stages", "0.0"
                      "weapontimer", "1.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 6.66503906288e-06 0.3125"
                  collisionVolumeScales = Some "36.25 35.0674133301 81.875"
                  collisionVolumeType = Some "Box"
                  damage = Some 2940.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 500.0
                  object_ = Some "Units/corarch_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 250.0
                  object_ = Some "Units/cor4X4A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["shcormov"]
                select = ["shcorsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "aa"
            ]
          extras = Map.ofList [
                "airsightdistance", "900.0"
                "buildangle", "16384.0"
                "movestate", "0.0"
                "nochasecategory", "NOTAIR"
            ] }

    let corarchDef : UnitDef =
        { name = "corarch"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 21000.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 465.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORARCH.s3o"
          buildPic = Some "CORARCH.DDS"
          script = Some "Units/CORARCH.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -4 3"
          collisionVolumeScales = Some "37 37 74"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 60.48
              maxAcc = 0.03127
              maxDec = 0.03127
              turnRate = 340.5
              movementClass = Some "BOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 30.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "bogus_missile"
                displayName = "Missiles"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
                weaponVelocity = Some 650.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 9000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = None
                soundHit = None
                explosiongenerator = None
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "canattackground", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "metalpershot", "0.0"
                    "soundhitwet", "splshbig"
                    "startvelocity", "450.0"
                    "turnrate", "33000.0"
                    "weaponacceleration", "101.0"
                    "weapontimer", "0.1"
                ] }
              { name = "ga2"
                displayName = "AA2Missile"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 870.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.6)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 64.0
                accuracy = None
                turret = Some true
                tolerance = Some 9950.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "burst", "2.0"
                    "burstrate", "0.4"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "1.75"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.95"
                    "smokeperiod", "5.0"
                    "smokesize", "4.8"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splssml"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1200.0"
                    "weapontimer", "2.0"
                ] }
              { name = "mobileflak"
                displayName = "FlakCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "vtol", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 775.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.73333)
                weaponVelocity = Some 1550.0
                areaOfEffect = Some 140.0
                accuracy = Some 1000.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "flakfire"
                soundHit = Some "flakhit"
                explosiongenerator = Some "custom:flak"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "flaktrailaa"
                    "craterareaofeffect", "140.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "gravityaffected", "true"
                    "size", "0.0"
                    "sizedecay", "0.08"
                    "soundhitwet", "splsmed"
                    "stages", "0.0"
                    "weapontimer", "1.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 6.66503906288e-06 0.3125"
                collisionVolumeScales = Some "36.25 35.0674133301 81.875"
                collisionVolumeType = Some "Box"
                damage = Some 2940.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 500.0
                object_ = Some "Units/corarch_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 250.0
                object_ = Some "Units/cor4X4A.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["shcormov"]
              select = ["shcorsel"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "900.0"
              "buildangle", "16384.0"
              "movestate", "0.0"
              "nochasecategory", "NOTAIR"
          ] }

    let corarchToFlat (def: UnitDef) : Corarch =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corarchToUnitDef (flat: Corarch) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corbats =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corbats : Corbats =
        { name = "corbats"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 3400.0
          energyCost = ValueOrExpr.Concrete 23000.0
          buildTime = ValueOrExpr.Concrete 51000.0
          health = ValueOrExpr.Concrete 12000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/CORBATS.s3o"
          buildPic = Some "CORBATS.DDS"
          script = Some "Units/CORBATS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfD"
          collisionVolumeOffsets = Some "0 -15 2"
          collisionVolumeScales = Some "62 62 148"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 53.1
          maxAcc = 0.01427
          maxDec = 0.01427
          turnRate = 177.0
          movementClass = "BOAT9"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 0.0
          weapons = [
                { name = "cor_bats"
                  displayName = "BattleshipCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 450.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 950.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.0)
                  weaponVelocity = Some 422.0
                  areaOfEffect = Some 140.0
                  accuracy = Some 400.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-large"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "cor_bats"
                  displayName = "BattleshipCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 450.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 950.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.0)
                  weaponVelocity = Some 422.0
                  areaOfEffect = Some 140.0
                  accuracy = Some 400.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-large"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_slaveto", "1.0"
                      "avoidfeature", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "cor_bats"
                  displayName = "BattleshipCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 450.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 950.0)
                  reloadTime = Some (ValueOrExpr.Concrete 4.0)
                  weaponVelocity = Some 422.0
                  areaOfEffect = Some 140.0
                  accuracy = Some 400.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy1"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-large"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "SURFACE"
                      "mount_slaveto", "1.0"
                      "avoidfeature", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "soundhitwet", "splsmed"
                  ] }
                { name = "cor_batslaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 300.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 700.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.95)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "350.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamtime", "0.2"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "80.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "12.1"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 -15 2"
                  collisionVolumeScales = Some "62 62 148"
                  collisionVolumeType = Some "CylZ"
                  damage = Some 13662.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 1650.0
                  object_ = Some "Units/corbats_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 825.0
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["shcormov"]
                select = ["shcorsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "buildangle", "16000.0"
                "movestate", "0.0"
                "nochasecategory", "VTOL"
            ] }

    let corbatsDef : UnitDef =
        { name = "corbats"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 3400.0
          energyCost = ValueOrExpr.Concrete 23000.0
          buildTime = ValueOrExpr.Concrete 51000.0
          health = ValueOrExpr.Concrete 12000.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/CORBATS.s3o"
          buildPic = Some "CORBATS.DDS"
          script = Some "Units/CORBATS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfD"
          collisionVolumeOffsets = Some "0 -15 2"
          collisionVolumeScales = Some "62 62 148"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 53.1
              maxAcc = 0.01427
              maxDec = 0.01427
              turnRate = 177.0
              movementClass = Some "BOAT9"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "cor_bats"
                displayName = "BattleshipCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 450.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 950.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = Some 422.0
                areaOfEffect = Some 140.0
                accuracy = Some 400.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "cor_bats"
                displayName = "BattleshipCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 450.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 950.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = Some 422.0
                areaOfEffect = Some 140.0
                accuracy = Some 400.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_slaveto", "1.0"
                    "avoidfeature", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "cor_bats"
                displayName = "BattleshipCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 450.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 950.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = Some 422.0
                areaOfEffect = Some 140.0
                accuracy = Some 400.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_slaveto", "1.0"
                    "avoidfeature", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "cor_batslaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 300.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.95)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "350.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.2"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "80.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "12.1"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -15 2"
                collisionVolumeScales = Some "62 62 148"
                collisionVolumeType = Some "CylZ"
                damage = Some 13662.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 1650.0
                object_ = Some "Units/corbats_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 825.0
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["shcormov"]
              select = ["shcorsel"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "buildangle", "16000.0"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
          ] }

    let corbatsToFlat (def: UnitDef) : Corbats =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corbatsToUnitDef (flat: Corbats) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corblackhy =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corblackhy : Corblackhy =
        { name = "corblackhy"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 21000.0
          energyCost = ValueOrExpr.Concrete 190000.0
          buildTime = ValueOrExpr.Concrete 310000.0
          health = ValueOrExpr.Concrete 53000.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/CORBLACKHY.s3o"
          buildPic = Some "CORBLACKHY.DDS"
          script = Some "Units/CORBLACKHY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "FlagshipExplosion"
          selfDestructAs = Some "FlagshipExplosionSelfd"
          collisionVolumeOffsets = Some "0 -24 5"
          collisionVolumeScales = Some "80 80 186"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 49.5
          maxAcc = 0.00809
          maxDec = 0.00809
          turnRate = 129.0
          movementClass = "BOAT9"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 0.0
          weapons = [
                { name = "heavyplasma"
                  displayName = "BattleshipCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 600.0
                      "subs", 120.0
                      "vtol", 250.0
                  ]
                  range = Some (ValueOrExpr.Concrete 2550.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.5)
                  weaponVelocity = Some 600.0
                  areaOfEffect = Some 240.0
                  accuracy = Some 500.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 1.0
                  noSelfDamage = Some true
                  soundStart = Some "cannhvy2"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_burstcontrolwhenoutofarc", "1.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "4.0"
                      "burstrate", "0.8"
                      "cegtag", "arty-heavy"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "intensity", "1.1"
                      "soundhitwet", "splslrg"
                      "sprayangle", "600.0"
                  ] }
                { name = "heavylaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 270.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 830.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.95)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "300.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamtime", "0.2"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "80.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "12.1"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.0"
                  ] }
                { name = "ferret_missile"
                  displayName = "Pop-up rapid-fire g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 840.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.7)
                  weaponVelocity = Some 1200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10920.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "packolau"
                  soundHit = Some "packohit"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_maindir", "-1.5 0 2"
                      "mount_maxangledif", "300.0"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "burst", "2.0"
                      "burstrate", "0.2"
                      "canattackground", "false"
                      "castshadow", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "firetolerance", "10920.0"
                      "flighttime", "2.5"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smokecolor", "0.95"
                      "smokeperiod", "6.0"
                      "smokesize", "4.6"
                      "smoketime", "12.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1500.0"
                      "weapontimer", "2.0"
                  ] }
                { name = "heavylaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 270.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 830.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.95)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "300.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamtime", "0.2"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "80.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "12.1"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.0"
                  ] }
                { name = "heavylaser"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 270.0
                      "vtol", 65.0
                  ]
                  range = Some (ValueOrExpr.Concrete 830.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.95)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "300.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamtime", "0.2"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "80.0"
                      "firestarter", "90.0"
                      "impactonly", "1.0"
                      "laserflaresize", "12.1"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.0"
                  ] }
                { name = "ferret_missile"
                  displayName = "Pop-up rapid-fire g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 840.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.7)
                  weaponVelocity = Some 1200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10920.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "packolau"
                  soundHit = Some "packohit"
                  explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_maindir", "1.5 0 2"
                      "mount_maxangledif", "300.0"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "burst", "2.0"
                      "burstrate", "0.2"
                      "canattackground", "false"
                      "castshadow", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "firetolerance", "10920.0"
                      "flighttime", "2.5"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smokecolor", "0.95"
                      "smokeperiod", "6.0"
                      "smokesize", "4.6"
                      "smoketime", "12.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1500.0"
                      "weapontimer", "2.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "17.3217697144 -6.85541303711 2.43087005615"
                  collisionVolumeScales = Some "88.47706604 56.7307739258 178.029220581"
                  collisionVolumeType = Some "Box"
                  damage = Some 93000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 18.0
                  height = Some 4.0
                  metal = Some 9450.0
                  object_ = Some "Units/corblackhy_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 40032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 4725.0
                  object_ = Some "Units/cor6X6A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "mass", "9999999.0"
                "movestate", "0.0"
                "radardistance", "1510.0"
                "radaremitheight", "64.0"
                "sightemitheight", "64.0"
            ] }

    let corblackhyDef : UnitDef =
        { name = "corblackhy"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 21000.0
          energyCost = ValueOrExpr.Concrete 190000.0
          buildTime = ValueOrExpr.Concrete 310000.0
          health = ValueOrExpr.Concrete 53000.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/CORBLACKHY.s3o"
          buildPic = Some "CORBLACKHY.DDS"
          script = Some "Units/CORBLACKHY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "FlagshipExplosion"
          selfDestructAs = Some "FlagshipExplosionSelfd"
          collisionVolumeOffsets = Some "0 -24 5"
          collisionVolumeScales = Some "80 80 186"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 49.5
              maxAcc = 0.00809
              maxDec = 0.00809
              turnRate = 129.0
              movementClass = Some "BOAT9"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "heavyplasma"
                displayName = "BattleshipCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 600.0
                    "subs", 120.0
                    "vtol", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 2550.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.5)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 240.0
                accuracy = Some 500.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "cannhvy2"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_burstcontrolwhenoutofarc", "1.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "4.0"
                    "burstrate", "0.8"
                    "cegtag", "arty-heavy"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "intensity", "1.1"
                    "soundhitwet", "splslrg"
                    "sprayangle", "600.0"
                ] }
              { name = "heavylaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 270.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 830.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.95)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "300.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.2"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "80.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "12.1"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.0"
                ] }
              { name = "ferret_missile"
                displayName = "Pop-up rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.7)
                weaponVelocity = Some 1200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 10920.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_maindir", "-1.5 0 2"
                    "mount_maxangledif", "300.0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "firetolerance", "10920.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.95"
                    "smokeperiod", "6.0"
                    "smokesize", "4.6"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1500.0"
                    "weapontimer", "2.0"
                ] }
              { name = "heavylaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 270.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 830.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.95)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "300.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.2"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "80.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "12.1"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.0"
                ] }
              { name = "heavylaser"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 270.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 830.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.95)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "300.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.2"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "80.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "12.1"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.0"
                ] }
              { name = "ferret_missile"
                displayName = "Pop-up rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.7)
                weaponVelocity = Some 1200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 10920.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_maindir", "1.5 0 2"
                    "mount_maxangledif", "300.0"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "firetolerance", "10920.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.95"
                    "smokeperiod", "6.0"
                    "smokesize", "4.6"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1500.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "17.3217697144 -6.85541303711 2.43087005615"
                collisionVolumeScales = Some "88.47706604 56.7307739258 178.029220581"
                collisionVolumeType = Some "Box"
                damage = Some 93000.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 18.0
                height = Some 4.0
                metal = Some 9450.0
                object_ = Some "Units/corblackhy_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 40032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 4725.0
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "mass", "9999999.0"
              "movestate", "0.0"
              "radardistance", "1510.0"
              "radaremitheight", "64.0"
              "sightemitheight", "64.0"
          ] }

    let corblackhyToFlat (def: UnitDef) : Corblackhy =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corblackhyToUnitDef (flat: Corblackhy) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcarry =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corcarry : Corcarry =
        { name = "corcarry"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1400.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 28000.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 1040.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/CORCARRY.s3o"
          buildPic = Some "CORCARRY.DDS"
          script = Some "Units/CORCARRY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "minifusionExplosion"
          selfDestructAs = Some "minifusionExplosion"
          collisionVolumeOffsets = Some "-1 -7 0"
          collisionVolumeScales = Some "61 61 153"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 60.24
          maxAcc = 0.01647
          maxDec = 0.01647
          turnRate = 180.0
          movementClass = "BOAT9"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 8.0
          energyMake = ValueOrExpr.Concrete 300.0
          energyStorage = 1500.0
          weapons = [
                { name = "fmd_rocket"
                  displayName = "ICBM intercepting missile launcher"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 1500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 72000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 6000.0
                  areaOfEffect = Some 420.0
                  accuracy = None
                  turret = None
                  tolerance = Some 7000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "antinukelaunch"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:antinuke"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "ALL"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "cegtag", "antimissiletrail"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "coverage", "1600.0"
                      "craterareaofeffect", "420.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "7500.0"
                      "firestarter", "100.0"
                      "flighttime", "20.0"
                      "interceptor", "1.0"
                      "metalpershot", "150.0"
                      "model", "fmdmissile.s3o"
                      "smokecolor", "0.7"
                      "smokeperiod", "10.0"
                      "smokesize", "27.0"
                      "smoketime", "110.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "true"
                      "soundhitwet", "splslrg"
                      "stockpile", "true"
                      "stockpiletime", "90.0"
                      "texture1", "bluenovaexplo"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "tracks", "true"
                      "turnrate", "10000.0"
                      "weaponacceleration", "150.0"
                      "weapontimer", "2.5"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "3.09324645996 4.5947265626e-05 -1.09795379639"
                  collisionVolumeScales = Some "76.2124633789 40.5466918945 153.329818726"
                  collisionVolumeType = Some "Box"
                  damage = Some 9540.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 700.0
                  object_ = Some "Units/corcarry_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 350.0
                  object_ = Some "Units/cor3X3A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["shcormov"]
                select = ["shcorsel"] }
          customParams = Map.ofList [
                "isairbase", "true"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "antinuke"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "canassist", "false"
                "canattack", "false"
                "canreclaim", "false"
                "canrepair", "false"
                "canrestore", "false"
                "energyupkeep", "25.0"
                "mass", "10000.0"
                "movestate", "0.0"
                "nochasecategory", "ALL"
                "radardistance", "2700.0"
                "radaremitheight", "50.0"
                "sightemitheight", "50.0"
                "sonardistance", "740.0"
            ] }

    let corcarryDef : UnitDef =
        { name = "corcarry"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1400.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 28000.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 1040.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/CORCARRY.s3o"
          buildPic = Some "CORCARRY.DDS"
          script = Some "Units/CORCARRY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "minifusionExplosion"
          selfDestructAs = Some "minifusionExplosion"
          collisionVolumeOffsets = Some "-1 -7 0"
          collisionVolumeScales = Some "61 61 153"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 60.24
              maxAcc = 0.01647
              maxDec = 0.01647
              turnRate = 180.0
              movementClass = Some "BOAT9"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 8.0 })
          builder = None
          weapons = Some [
              { name = "fmd_rocket"
                displayName = "ICBM intercepting missile launcher"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 1500.0
                ]
                range = Some (ValueOrExpr.Concrete 72000.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 6000.0
                areaOfEffect = Some 420.0
                accuracy = None
                turret = None
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "antinukelaunch"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:antinuke"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "ALL"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "antimissiletrail"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "coverage", "1600.0"
                    "craterareaofeffect", "420.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "7500.0"
                    "firestarter", "100.0"
                    "flighttime", "20.0"
                    "interceptor", "1.0"
                    "metalpershot", "150.0"
                    "model", "fmdmissile.s3o"
                    "smokecolor", "0.7"
                    "smokeperiod", "10.0"
                    "smokesize", "27.0"
                    "smoketime", "110.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "true"
                    "soundhitwet", "splslrg"
                    "stockpile", "true"
                    "stockpiletime", "90.0"
                    "texture1", "bluenovaexplo"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "tracks", "true"
                    "turnrate", "10000.0"
                    "weaponacceleration", "150.0"
                    "weapontimer", "2.5"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 300.0)
              metalMake = None
              energyStorage = Some 1500.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "3.09324645996 4.5947265626e-05 -1.09795379639"
                collisionVolumeScales = Some "76.2124633789 40.5466918945 153.329818726"
                collisionVolumeType = Some "Box"
                damage = Some 9540.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 700.0
                object_ = Some "Units/corcarry_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 350.0
                object_ = Some "Units/cor3X3A.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["shcormov"]
              select = ["shcorsel"] })
          customParams = Map.ofList [
              "isairbase", "true"
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "antinuke"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "canassist", "false"
              "canattack", "false"
              "canreclaim", "false"
              "canrepair", "false"
              "canrestore", "false"
              "energyupkeep", "25.0"
              "mass", "10000.0"
              "movestate", "0.0"
              "nochasecategory", "ALL"
              "radardistance", "2700.0"
              "radaremitheight", "50.0"
              "sightemitheight", "50.0"
              "sonardistance", "740.0"
          ] }

    let corcarryToFlat (def: UnitDef) : Corcarry =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcarryToUnitDef (flat: Corcarry) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcrus =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corcrus : Corcrus =
        { name = "corcrus"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 23000.0
          health = ValueOrExpr.Concrete 6200.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/CORCRUS.s3o"
          buildPic = Some "CORCRUS.DDS"
          script = Some "Units/CORCRUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -14 0"
          collisionVolumeScales = Some "34 34 115"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 54.0
          maxAcc = 0.02649
          maxDec = 0.02649
          turnRate = 265.5
          movementClass = "BOAT5"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 30.0
          waterline = 0.0
          weapons = [
                { name = "cor_crus"
                  displayName = "HighEnergyLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                      "vtol", 22.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.125)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Lasrmas2"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-medium-green"
                  rgbColor = Some "0 1 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "beamtime", "0.15"
                      "corethickness", "0.2"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "40.0"
                      "firestarter", "90.0"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "3.0"
                  ] }
                { name = "adv_decklaser"
                  displayName = "L2DeckLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 75.0
                      "vtol", 15.0
                  ]
                  range = Some (ValueOrExpr.Concrete 430.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.333)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 8.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir3"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.15"
                      "corethickness", "0.16"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "15.0"
                      "firestarter", "30.0"
                      "impactonly", "1.0"
                      "laserflaresize", "9.35"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.3"
                  ] }
                { name = "advdepthcharge"
                  displayName = "Medium depthcharge launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 225.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.8)
                  weaponVelocity = Some 225.0
                  areaOfEffect = Some 32.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 32767.0
                  edgeEffectiveness = Some 0.95
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "model", "cordepthcharge.s3o"
                      "startvelocity", "150.0"
                      "tracks", "true"
                      "turnrate", "9800.0"
                      "waterweapon", "true"
                      "weaponacceleration", "25.0"
                      "weapontimer", "10.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 2.11181640619e-05 7.62939453125e-06"
                  collisionVolumeScales = Some "44.054901123 24.9370422363 110.273605347"
                  collisionVolumeType = Some "Box"
                  damage = Some 5578.0
                  featureDead = Some "HEAP"
                  footprintX = Some 5.0
                  footprintZ = Some 5.0
                  height = Some 4.0
                  metal = Some 500.0
                  object_ = Some "Units/corcrus_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 250.0
                  object_ = Some "Units/cor2X2A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["shcormov"]
                select = ["shcorsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "weaponsub"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "nochasecategory", "VTOL"
                "sonardistance", "375.0"
            ] }

    let corcrusDef : UnitDef =
        { name = "corcrus"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 23000.0
          health = ValueOrExpr.Concrete 6200.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/CORCRUS.s3o"
          buildPic = Some "CORCRUS.DDS"
          script = Some "Units/CORCRUS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -14 0"
          collisionVolumeScales = Some "34 34 115"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 54.0
              maxAcc = 0.02649
              maxDec = 0.02649
              turnRate = 265.5
              movementClass = Some "BOAT5"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 30.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "cor_crus"
                displayName = "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 200.0
                    "vtol", 22.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.125)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0 1 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.15"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "40.0"
                    "firestarter", "90.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "3.0"
                ] }
              { name = "adv_decklaser"
                displayName = "L2DeckLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 75.0
                    "vtol", 15.0
                ]
                range = Some (ValueOrExpr.Concrete 430.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.333)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.15"
                    "corethickness", "0.16"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "15.0"
                    "firestarter", "30.0"
                    "impactonly", "1.0"
                    "laserflaresize", "9.35"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.3"
                ] }
              { name = "advdepthcharge"
                displayName = "Medium depthcharge launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 225.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.8)
                weaponVelocity = Some 225.0
                areaOfEffect = Some 32.0
                accuracy = None
                turret = Some false
                tolerance = Some 32767.0
                edgeEffectiveness = Some 0.95
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-medium-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "cordepthcharge.s3o"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "9800.0"
                    "waterweapon", "true"
                    "weaponacceleration", "25.0"
                    "weapontimer", "10.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 2.11181640619e-05 7.62939453125e-06"
                collisionVolumeScales = Some "44.054901123 24.9370422363 110.273605347"
                collisionVolumeType = Some "Box"
                damage = Some 5578.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 500.0
                object_ = Some "Units/corcrus_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 250.0
                object_ = Some "Units/cor2X2A.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["shcormov"]
              select = ["shcorsel"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "weaponsub"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "nochasecategory", "VTOL"
              "sonardistance", "375.0"
          ] }

    let corcrusToFlat (def: UnitDef) : Corcrus =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcrusToUnitDef (flat: Corcrus) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Cordesolator =
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
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cordesolator : Cordesolator =
        { name = "cordesolator"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 95000.0
          buildTime = ValueOrExpr.Concrete 190000.0
          health = ValueOrExpr.Concrete 2600.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/CORDESOLATOR.s3o"
          buildPic = Some "cordesolator.DDS"
          script = Some "Units/cordesolator.cob"
          corpse = Some "DEAD"
          explodeAs = Some "nukeSub"
          selfDestructAs = Some "nukeBuildingSelfd"
          collisionVolumeOffsets = Some "0 1 4"
          collisionVolumeScales = Some "20 45 100"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 45.0
          maxAcc = 0.03
          maxDec = 0.05
          turnRate = 300.0
          movementClass = "UBOAT4"
          maxSlope = 10.0
          maxWaterDepth = 9999.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 20.0
          waterline = 40.0
          weapons = [
                { name = "waterballon"
                  displayName = "Torpedo launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "commanders", 350.0
                      "default", 850.0
                      "subs", 510.0
                  ]
                  range = Some (ValueOrExpr.Concrete 750.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 280.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 8000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep1"
                  explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "HOVER NOTSHIP"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "40.0"
                      "mount_onlytargetcategory", "NOTHOVER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "cegtag", "torpedotrail-small"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "model", "torpedo.s3o"
                      "soundhitvolume", "22.0"
                      "startvelocity", "150.0"
                      "tracks", "true"
                      "turnrate", "2550.0"
                      "waterweapon", "true"
                      "weaponacceleration", "20.0"
                      "weapontimer", "3.0"
                  ] }
                { name = "crblmssl"
                  displayName = "Intercontinental thermonuclear ballistic missile"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "commanders", 2500.0
                      "default", 11500.0
                  ]
                  range = Some (ValueOrExpr.Concrete 72000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 30.0)
                  weaponVelocity = Some 1600.0
                  areaOfEffect = Some 1920.0
                  accuracy = None
                  turret = None
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 0.45
                  impulseFactor = Some 0.5
                  noSelfDamage = None
                  soundStart = Some "nukelaunch"
                  soundHit = Some "nukecor"
                  explosiongenerator = Some "custom:newnukecor"
                  rgbColor = None
                  customParams = Map.ofList [
                      "place_target_on_ground", "true"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "cegtag", "NUKETRAIL"
                      "collideenemy", "false"
                      "collidefeature", "false"
                      "collidefriendly", "false"
                      "commandfire", "true"
                      "craterareaofeffect", "1920.0"
                      "craterboost", "2.4"
                      "cratermult", "1.2"
                      "energypershot", "187500.0"
                      "firestarter", "100.0"
                      "flighttime", "400.0"
                      "metalpershot", "1500.0"
                      "model", "cortronmissile.s3o"
                      "smokecolor", "0.85"
                      "smokeperiod", "10.0"
                      "smokesize", "28.0"
                      "smoketime", "130.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "true"
                      "soundhitwet", "nukewater"
                      "soundhitwetvolume", "56.0"
                      "soundstartvolume", "20.0"
                      "stockpile", "true"
                      "stockpiletime", "210.0"
                      "targetable", "1.0"
                      "texture1", "null"
                      "texture2", "railguntrail"
                      "texture3", "null"
                      "turnrate", "5500.0"
                      "waterweapon", "true"
                      "weaponacceleration", "100.0"
                      "weapontimer", "5.5"
                  ] }
                { name = "nuclear_launch"
                  displayName = "Nuclear Launch"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 0.0)
                  reloadTime = Some (ValueOrExpr.Concrete 30.0)
                  weaponVelocity = Some 100.0
                  areaOfEffect = Some 0.0
                  accuracy = None
                  turret = None
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.0
                  impulseFactor = Some 0.0
                  noSelfDamage = None
                  soundStart = None
                  soundHit = Some "nukelaunchalarm"
                  explosiongenerator = None
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "commandfire", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "metalpershot", "0.0"
                      "soundhitvolume", "50.0"
                      "turnrate", "10000.0"
                      "weaponacceleration", "101.0"
                      "weapontimer", "0.1"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 1 4"
                  collisionVolumeScales = Some "40 40 100"
                  collisionVolumeType = Some "Box"
                  damage = Some 1362.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 375.0
                  object_ = Some "Units/cordesolator_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 187.0
                  object_ = Some "Units/cor2X2A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["servroc1"]
                select = ["servroc1"] }
          customParams = Map.ofList [
                "maxrange", "720"
                "model_author", "Hornet"
                "normaltex", "unittextures/cor_normal.dds"
                "removewait", "true"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "nuke"
            ]
          extras = Map.ofList [
                "buildangle", "8192.0"
                "canmanualfire", "true"
                "firestate", "2.0"
                "nochase", "ALL"
                "radardistance", "50.0"
                "sonardistance", "1100.0"
                "upright", "true"
            ] }

    let cordesolatorDef : UnitDef =
        { name = "cordesolator"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 9000.0
          energyCost = ValueOrExpr.Concrete 95000.0
          buildTime = ValueOrExpr.Concrete 190000.0
          health = ValueOrExpr.Concrete 2600.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/CORDESOLATOR.s3o"
          buildPic = Some "cordesolator.DDS"
          script = Some "Units/cordesolator.cob"
          corpse = Some "DEAD"
          explodeAs = Some "nukeSub"
          selfDestructAs = Some "nukeBuildingSelfd"
          collisionVolumeOffsets = Some "0 1 4"
          collisionVolumeScales = Some "20 45 100"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 45.0
              maxAcc = 0.03
              maxDec = 0.05
              turnRate = 300.0
              movementClass = Some "UBOAT4"
              maxSlope = Some 10.0
              maxWaterDepth = Some 9999.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 20.0
              waterline = Some 40.0 })
          builder = None
          weapons = Some [
              { name = "waterballon"
                displayName = "Torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "commanders", 350.0
                    "default", 850.0
                    "subs", 510.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 280.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "40.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-small"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "torpedo.s3o"
                    "soundhitvolume", "22.0"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "2550.0"
                    "waterweapon", "true"
                    "weaponacceleration", "20.0"
                    "weapontimer", "3.0"
                ] }
              { name = "crblmssl"
                displayName = "Intercontinental thermonuclear ballistic missile"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "commanders", 2500.0
                    "default", 11500.0
                ]
                range = Some (ValueOrExpr.Concrete 72000.0)
                reloadTime = Some (ValueOrExpr.Concrete 30.0)
                weaponVelocity = Some 1600.0
                areaOfEffect = Some 1920.0
                accuracy = None
                turret = None
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 0.5
                noSelfDamage = None
                soundStart = Some "nukelaunch"
                soundHit = Some "nukecor"
                explosiongenerator = Some "custom:newnukecor"
                rgbColor = None
                customParams = Map.ofList [
                    "place_target_on_ground", "true"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "cegtag", "NUKETRAIL"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "commandfire", "true"
                    "craterareaofeffect", "1920.0"
                    "craterboost", "2.4"
                    "cratermult", "1.2"
                    "energypershot", "187500.0"
                    "firestarter", "100.0"
                    "flighttime", "400.0"
                    "metalpershot", "1500.0"
                    "model", "cortronmissile.s3o"
                    "smokecolor", "0.85"
                    "smokeperiod", "10.0"
                    "smokesize", "28.0"
                    "smoketime", "130.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "true"
                    "soundhitwet", "nukewater"
                    "soundhitwetvolume", "56.0"
                    "soundstartvolume", "20.0"
                    "stockpile", "true"
                    "stockpiletime", "210.0"
                    "targetable", "1.0"
                    "texture1", "null"
                    "texture2", "railguntrail"
                    "texture3", "null"
                    "turnrate", "5500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "100.0"
                    "weapontimer", "5.5"
                ] }
              { name = "nuclear_launch"
                displayName = "Nuclear Launch"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 0.0)
                reloadTime = Some (ValueOrExpr.Concrete 30.0)
                weaponVelocity = Some 100.0
                areaOfEffect = Some 0.0
                accuracy = None
                turret = None
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.0
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = None
                soundHit = Some "nukelaunchalarm"
                explosiongenerator = None
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "commandfire", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "metalpershot", "0.0"
                    "soundhitvolume", "50.0"
                    "turnrate", "10000.0"
                    "weaponacceleration", "101.0"
                    "weapontimer", "0.1"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 1 4"
                collisionVolumeScales = Some "40 40 100"
                collisionVolumeType = Some "Box"
                damage = Some 1362.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 375.0
                object_ = Some "Units/cordesolator_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 187.0
                object_ = Some "Units/cor2X2A.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["servroc1"]
              select = ["servroc1"] })
          customParams = Map.ofList [
              "maxrange", "720"
              "model_author", "Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "nuke"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "canmanualfire", "true"
              "firestate", "2.0"
              "nochase", "ALL"
              "radardistance", "50.0"
              "sonardistance", "1100.0"
              "upright", "true"
          ] }

    let cordesolatorToFlat (def: UnitDef) : Cordesolator =
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
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let cordesolatorToUnitDef (flat: Cordesolator) : UnitDef =
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
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Cordronecarry =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cordronecarry : Cordronecarry =
        { name = "cordronecarry"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1700.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 3500.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORDRONECARRY.s3o"
          buildPic = Some "CORDRONECARRY.DDS"
          script = Some "Units/CORDRONECARRY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfD"
          collisionVolumeOffsets = Some "-1 5 2"
          collisionVolumeScales = Some "48 48 136"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 63.0
          maxAcc = 0.01722
          maxDec = 0.01722
          turnRate = 180.0
          movementClass = "BOAT9"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 0.0
          energyMake = ValueOrExpr.Concrete 25.0
          energyStorage = 1500.0
          weapons = [
                { name = "plasma"
                  displayName = "HeavyCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 4.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some ""
                  soundHit = Some ""
                  explosiongenerator = Some ""
                  rgbColor = None
                  customParams = Map.ofList [
                      "carried_unit", "cordrone"
                      "spawns_surface", "SEA"
                      "carrierdeaththroe", "release"
                      "dockingpieces", "9 10 11 12 13 14 15 16 17 18 19"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "metalpershot", "30.0"
                      "energypershot", "750.0"
                      "size", "0.0"
                      "soundhitwet", ""
                      "stockpile", "true"
                      "stockpiletime", "6.0"
                  ] }
                { name = "aamissile"
                  displayName = "Missiles"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 138.0
                  ]
                  range = Some (ValueOrExpr.Concrete 710.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 8000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rockhvy2"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-air"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "1.75"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "7.0"
                      "smoketime", "13.0"
                      "smokesize", "5.4"
                      "smokecolor", "0.95"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "startvelocity", "430.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "30000.0"
                      "weaponacceleration", "90.0"
                      "weapontimer", "5.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.0550308227539 1.52587890767e-06 4.55026245117"
                  collisionVolumeScales = Some "61.8225860596 60.9250030518 154.450805664"
                  collisionVolumeType = Some "Box"
                  damage = Some 9168.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 700.0
                  object_ = Some "Units/cordronecarry_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 350.0
                  object_ = Some "Units/arm6X6C.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "model_author", "Odin"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "inheritxpratemultiplier", "1.0"
                "childreninheritxp", "DRONE"
                "parentsinheritxp", "DRONE"
                "restrictions_inclusion", "_noair_"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "canreclaim", "false"
                "canrepair", "false"
                "canrestore", "false"
                "energyupkeep", "25.0"
                "sightemitheight", "56.0"
                "mass", "10000.0"
                "nochasecategory", "VTOL"
                "radardistance", "1500.0"
                "radaremitheight", "56.0"
                "sonardistance", "700.0"
            ] }

    let cordronecarryDef : UnitDef =
        { name = "cordronecarry"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1700.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 3500.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORDRONECARRY.s3o"
          buildPic = Some "CORDRONECARRY.DDS"
          script = Some "Units/CORDRONECARRY.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfD"
          collisionVolumeOffsets = Some "-1 5 2"
          collisionVolumeScales = Some "48 48 136"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 63.0
              maxAcc = 0.01722
              maxDec = 0.01722
              turnRate = 180.0
              movementClass = Some "BOAT9"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "plasma"
                displayName = "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1300.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 4.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some ""
                soundHit = Some ""
                explosiongenerator = Some ""
                rgbColor = None
                customParams = Map.ofList [
                    "carried_unit", "cordrone"
                    "spawns_surface", "SEA"
                    "carrierdeaththroe", "release"
                    "dockingpieces", "9 10 11 12 13 14 15 16 17 18 19"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "metalpershot", "30.0"
                    "energypershot", "750.0"
                    "size", "0.0"
                    "soundhitwet", ""
                    "stockpile", "true"
                    "stockpiletime", "6.0"
                ] }
              { name = "aamissile"
                displayName = "Missiles"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 138.0
                ]
                range = Some (ValueOrExpr.Concrete 710.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rockhvy2"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium-air"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "1.75"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "7.0"
                    "smoketime", "13.0"
                    "smokesize", "5.4"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "430.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "30000.0"
                    "weaponacceleration", "90.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 25.0)
              metalMake = None
              energyStorage = Some 1500.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.0550308227539 1.52587890767e-06 4.55026245117"
                collisionVolumeScales = Some "61.8225860596 60.9250030518 154.450805664"
                collisionVolumeType = Some "Box"
                damage = Some 9168.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 700.0
                object_ = Some "Units/cordronecarry_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 350.0
                object_ = Some "Units/arm6X6C.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "model_author", "Odin"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "inheritxpratemultiplier", "1.0"
              "childreninheritxp", "DRONE"
              "parentsinheritxp", "DRONE"
              "restrictions_inclusion", "_noair_"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "canreclaim", "false"
              "canrepair", "false"
              "canrestore", "false"
              "energyupkeep", "25.0"
              "sightemitheight", "56.0"
              "mass", "10000.0"
              "nochasecategory", "VTOL"
              "radardistance", "1500.0"
              "radaremitheight", "56.0"
              "sonardistance", "700.0"
          ] }

    let cordronecarryToFlat (def: UnitDef) : Cordronecarry =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let cordronecarryToUnitDef (flat: Cordronecarry) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = None
              energyStorage = Some flat.energyStorage
              metalStorage = None
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corfship =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corfship : Corfship =
        { name = "corfship"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 630.0
          energyCost = ValueOrExpr.Concrete 9400.0
          buildTime = ValueOrExpr.Concrete 13000.0
          health = ValueOrExpr.Concrete 2700.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORFSHIP.s3o"
          buildPic = Some "CORFSHIP.DDS"
          script = Some "Units/corfship.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flamethrowerSelfd"
          selfDestructAs = Some "pyroselfd"
          collisionVolumeOffsets = Some "0 -5 -2"
          collisionVolumeScales = Some "27 20 81"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 93.0
          maxAcc = 0.06
          maxDec = 0.06
          turnRate = 425.0
          movementClass = "BOAT4"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 6.0
          waterline = 0.0
          weapons = [
                { name = "dmaw"
                  displayName = "Heavy long range AoE flamethrower"
                  weaponType = Some "Flame"
                  damage = Map.ofList [
                      "default", 25.0
                      "subs", 12.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.1333)
                  weaponVelocity = Some 400.0
                  areaOfEffect = Some 96.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 2500.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "Flamhvy1"
                  soundHit = None
                  explosiongenerator = Some "custom:burnblackxl"
                  rgbColor = Some "1 0.94 0.88"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "GROUNDSCOUT VTOL"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "bouncerebound", "0.8"
                      "bounceslip", "1.0"
                      "burst", "2.0"
                      "burstrate", "0.0666"
                      "cegtag", "burnflamexl"
                      "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flamegfxtime", "1.0"
                      "intensity", "0.85"
                      "proximitypriority", "1.0"
                      "rgbcolor2", "0.9 0.84 0.8"
                      "sizegrowth", "1.2"
                      "soundhitwet", "sizzle"
                      "soundtrigger", "false"
                      "sprayangle", "200.0"
                      "targetmoveerror", "0.001"
                      "texture1", "flame_alt2"
                      "weapontimer", "1.0"
                  ] }
                { name = "aamissile"
                  displayName = "Missiles"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 138.0
                  ]
                  range = Some (ValueOrExpr.Concrete 710.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 8000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rockhvy2"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-air"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "castshadow", "false"
                      "cegtag", "missiletrailaa"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "1.75"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smokecolor", "0.95"
                      "smokeperiod", "7.0"
                      "smokesize", "5.4"
                      "smoketime", "13.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "startvelocity", "430.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "30000.0"
                      "weaponacceleration", "90.0"
                      "weapontimer", "5.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.255500793457 0 -1.26264953613"
                  collisionVolumeScales = Some "20.0704803467 16.0 67.0992736816"
                  collisionVolumeType = Some "Box"
                  damage = Some 500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 205.0
                  object_ = Some "Units/corfship_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "55.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1032.0
                  featureDead = None
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 102.5
                  object_ = Some "Units/cor3X3A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "model_author", "Odin"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "blocking", "true"
                "nochasecategory", "VTOL UNDERWATER"
                "radardistance", "750.0"
                "radaremitheight", "52.0"
            ] }

    let corfshipDef : UnitDef =
        { name = "corfship"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 630.0
          energyCost = ValueOrExpr.Concrete 9400.0
          buildTime = ValueOrExpr.Concrete 13000.0
          health = ValueOrExpr.Concrete 2700.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORFSHIP.s3o"
          buildPic = Some "CORFSHIP.DDS"
          script = Some "Units/corfship.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flamethrowerSelfd"
          selfDestructAs = Some "pyroselfd"
          collisionVolumeOffsets = Some "0 -5 -2"
          collisionVolumeScales = Some "27 20 81"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 93.0
              maxAcc = 0.06
              maxDec = 0.06
              turnRate = 425.0
              movementClass = Some "BOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 6.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "dmaw"
                displayName = "Heavy long range AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "default", 25.0
                    "subs", 12.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1333)
                weaponVelocity = Some 400.0
                areaOfEffect = Some 96.0
                accuracy = None
                turret = Some true
                tolerance = Some 2500.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Flamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:burnblackxl"
                rgbColor = Some "1 0.94 0.88"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "bouncerebound", "0.8"
                    "bounceslip", "1.0"
                    "burst", "2.0"
                    "burstrate", "0.0666"
                    "cegtag", "burnflamexl"
                    "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flamegfxtime", "1.0"
                    "intensity", "0.85"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.9 0.84 0.8"
                    "sizegrowth", "1.2"
                    "soundhitwet", "sizzle"
                    "soundtrigger", "false"
                    "sprayangle", "200.0"
                    "targetmoveerror", "0.001"
                    "texture1", "flame_alt2"
                    "weapontimer", "1.0"
                ] }
              { name = "aamissile"
                displayName = "Missiles"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 138.0
                ]
                range = Some (ValueOrExpr.Concrete 710.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rockhvy2"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium-air"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "1.75"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.95"
                    "smokeperiod", "7.0"
                    "smokesize", "5.4"
                    "smoketime", "13.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "430.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "30000.0"
                    "weaponacceleration", "90.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.255500793457 0 -1.26264953613"
                collisionVolumeScales = Some "20.0704803467 16.0 67.0992736816"
                collisionVolumeType = Some "Box"
                damage = Some 500.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 205.0
                object_ = Some "Units/corfship_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1032.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 102.5
                object_ = Some "Units/cor3X3A.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "model_author", "Odin"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "nochasecategory", "VTOL UNDERWATER"
              "radardistance", "750.0"
              "radaremitheight", "52.0"
          ] }

    let corfshipToFlat (def: UnitDef) : Corfship =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corfshipToUnitDef (flat: Corfship) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corhacs =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corhacs : Corhacs =
        { name = "corhacs"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1180.0
          energyCost = ValueOrExpr.Concrete 23600.0
          buildTime = ValueOrExpr.Concrete 60000.0
          health = ValueOrExpr.Concrete 2600.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORMLS.s3o"
          buildPic = Some "CORMLS.DDS"
          script = Some "Units/CORMLS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "28 20 42"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 55.0
          maxAcc = 0.03446
          maxDec = 0.03446
          turnRate = 393.0
          movementClass = "BOAT3"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 0.0
          workerTime = ValueOrExpr.Concrete 700.0
          buildDistance = 250.0
          buildOptions = ["coruwfus"; "coruwmmm"; "coruwmme"; "coruwadves"; "coruwadvms"; "corhasy"; "corasy"; "corfatf"; "coratl"; "corenaa"; "corfdoom"; "coruwageo"; "corjugg"; "corkorg"; "corafus"; "cortide"; "corscreamer"; "corvipe"; "corfdrag"; "corgate"; "corsd"; "corlab"; "corap"; "corvp"; "corsy"; "corint"; "corsilo"; "corbuzz"; "corgantuw"]
          terraformSpeed = 2000.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.0500030517578 -0.0636029345703 -0.0"
                  collisionVolumeScales = Some "33.75 14.0462341309 88.0440979004"
                  collisionVolumeType = Some "Box"
                  damage = Some 1726.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 100.0
                  object_ = Some "Units/cormls_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 50.0
                  object_ = Some "Units/cor4X4A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["shcormov"]
                select = ["shcorsel"] }
          customParams = Map.ofList [
                "minesweeper", "600.0"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "3.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "mass", "2700.0"
                "movestate", "0.0"
            ] }

    let corhacsDef : UnitDef =
        { name = "corhacs"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1180.0
          energyCost = ValueOrExpr.Concrete 23600.0
          buildTime = ValueOrExpr.Concrete 60000.0
          health = ValueOrExpr.Concrete 2600.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORMLS.s3o"
          buildPic = Some "CORMLS.DDS"
          script = Some "Units/CORMLS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "28 20 42"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 55.0
              maxAcc = 0.03446
              maxDec = 0.03446
              turnRate = 393.0
              movementClass = Some "BOAT3"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 700.0
              buildDistance = Some 250.0
              buildOptions = ["coruwfus"; "coruwmmm"; "coruwmme"; "coruwadves"; "coruwadvms"; "corhasy"; "corasy"; "corfatf"; "coratl"; "corenaa"; "corfdoom"; "coruwageo"; "corjugg"; "corkorg"; "corafus"; "cortide"; "corscreamer"; "corvipe"; "corfdrag"; "corgate"; "corsd"; "corlab"; "corap"; "corvp"; "corsy"; "corint"; "corsilo"; "corbuzz"; "corgantuw"]
              terraformSpeed = Some 2000.0 })
          weapons = None
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.0500030517578 -0.0636029345703 -0.0"
                collisionVolumeScales = Some "33.75 14.0462341309 88.0440979004"
                collisionVolumeType = Some "Box"
                damage = Some 1726.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 100.0
                object_ = Some "Units/cormls_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 50.0
                object_ = Some "Units/cor4X4A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["shcormov"]
              select = ["shcorsel"] })
          customParams = Map.ofList [
              "minesweeper", "600.0"
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "3.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "mass", "2700.0"
              "movestate", "0.0"
          ] }

    let corhacsToFlat (def: UnitDef) : Corhacs =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corhacsToUnitDef (flat: Corhacs) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Cormls =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cormls : Cormls =
        { name = "cormls"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 3300.0
          buildTime = ValueOrExpr.Concrete 6500.0
          health = ValueOrExpr.Concrete 1600.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORMLS.s3o"
          buildPic = Some "CORMLS.DDS"
          script = Some "Units/CORMLS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "28 20 42"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 57.75
          maxAcc = 0.03446
          maxDec = 0.03446
          turnRate = 393.0
          movementClass = "BOAT3"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 0.0
          workerTime = ValueOrExpr.Concrete 200.0
          buildDistance = 250.0
          buildOptions = ["cortide"; "cormex"; "corfrad"; "corarad"; "cornanotcplat"; "corsy"; "corcs"; "cortl"; "corfhlt"; "corenaa"; "corpt"; "coresupp"; "corroy"; "corfmine3"; "cortoast"; "corfdoom"; "corfdrag"]
          terraformSpeed = 2000.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.0500030517578 -0.0636029345703 -0.0"
                  collisionVolumeScales = Some "33.75 14.0462341309 88.0440979004"
                  collisionVolumeType = Some "Box"
                  damage = Some 1726.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 100.0
                  object_ = Some "Units/cormls_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 50.0
                  object_ = Some "Units/cor4X4A.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["shcormov"]
                select = ["shcorsel"] }
          customParams = Map.ofList [
                "minesweeper", "600.0"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "movestate", "0.0"
            ] }

    let cormlsDef : UnitDef =
        { name = "cormls"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 200.0
          energyCost = ValueOrExpr.Concrete 3300.0
          buildTime = ValueOrExpr.Concrete 6500.0
          health = ValueOrExpr.Concrete 1600.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORMLS.s3o"
          buildPic = Some "CORMLS.DDS"
          script = Some "Units/CORMLS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "28 20 42"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 57.75
              maxAcc = 0.03446
              maxDec = 0.03446
              turnRate = 393.0
              movementClass = Some "BOAT3"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 200.0
              buildDistance = Some 250.0
              buildOptions = ["cortide"; "cormex"; "corfrad"; "corarad"; "cornanotcplat"; "corsy"; "corcs"; "cortl"; "corfhlt"; "corenaa"; "corpt"; "coresupp"; "corroy"; "corfmine3"; "cortoast"; "corfdoom"; "corfdrag"]
              terraformSpeed = Some 2000.0 })
          weapons = None
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.0500030517578 -0.0636029345703 -0.0"
                collisionVolumeScales = Some "33.75 14.0462341309 88.0440979004"
                collisionVolumeType = Some "Box"
                damage = Some 1726.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 100.0
                object_ = Some "Units/cormls_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 50.0
                object_ = Some "Units/cor4X4A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["shcormov"]
              select = ["shcorsel"] })
          customParams = Map.ofList [
              "minesweeper", "600.0"
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "movestate", "0.0"
          ] }

    let cormlsToFlat (def: UnitDef) : Cormls =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let cormlsToUnitDef (flat: Cormls) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = None
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Cormship =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cormship : Cormship =
        { name = "cormship"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 2000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 318.5
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORMSHIP.s3o"
          buildPic = Some "CORMSHIP.DDS"
          script = Some "Units/CORMSHIP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -8 0"
          collisionVolumeScales = Some "43 43 101"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 61.44
          maxAcc = 0.02799
          maxDec = 0.03799
          turnRate = 350.0
          movementClass = "BOAT5"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 12.0
          waterline = 0.0
          weapons = [
                { name = "rocket"
                  displayName = "Heavy long-range g2g starburst rocket launcher"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "commanders", 500.0
                      "default", 1100.0
                      "subs", 300.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1550.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 300.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  customParams = Map.ofList [
                      "cegtag", "missiletrailcorroyspecial"
                      "model", "airbomb"
                      "number", "8"
                      "speceffect", "split"
                      "speceffect_def", "cormship_rocket_split"
                      "splitexplosionceg", "genericshellexplosion-medium"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_maindir", "0 .5 1"
                      "mount_maxangledif", "60.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "cegtag", "missiletrailmship"
                      "craterareaofeffect", "300.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "flighttime", "15.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "interceptedbyshieldtype", "1024.0"
                      "metalpershot", "0.0"
                      "model", "corshiprocket.s3o"
                      "proximitypriority", "1.0"
                      "smoketrail", "false"
                      "soundhitwet", "splslrg"
                      "texture1", "null"
                      "texture2", "null"
                      "texture3", "null"
                      "turnrate", "24384.0"
                      "weaponacceleration", "80.0"
                      "weapontimer", "5.0"
                  ] }
                { name = "missile"
                  displayName = "Medium Range g2a AA Missiles"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 138.0
                  ]
                  range = Some (ValueOrExpr.Concrete 710.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 48.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 8000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rockhvy2"
                  soundHit = Some "xplomed2"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-air"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "castshadow", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "1.75"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smokecolor", "0.95"
                      "smokeperiod", "7.0"
                      "smokesize", "5.4"
                      "smoketime", "13.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splshbig"
                      "startvelocity", "430.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "30000.0"
                      "weaponacceleration", "90.0"
                      "weapontimer", "5.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -1.0875 0.375"
                  collisionVolumeScales = Some "46.75 27.25 110.75"
                  collisionVolumeType = Some "Box"
                  damage = Some 2700.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 1000.0
                  object_ = Some "Units/cormship_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 500.0
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["shcormov"]
                select = ["shcorsel"] }
          customParams = Map.ofList [
                "maxrange", "1650"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "movestate", "0.0"
                "nochasecategory", "VTOL"
                "radardistance", "1000.0"
            ] }

    let cormshipDef : UnitDef =
        { name = "cormship"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 2000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 318.5
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORMSHIP.s3o"
          buildPic = Some "CORMSHIP.DDS"
          script = Some "Units/CORMSHIP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -8 0"
          collisionVolumeScales = Some "43 43 101"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 61.44
              maxAcc = 0.02799
              maxDec = 0.03799
              turnRate = 350.0
              movementClass = Some "BOAT5"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 12.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "rocket"
                displayName = "Heavy long-range g2g starburst rocket launcher"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "commanders", 500.0
                    "default", 1100.0
                    "subs", 300.0
                ]
                range = Some (ValueOrExpr.Concrete 1550.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 300.0
                accuracy = None
                turret = Some true
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                customParams = Map.ofList [
                    "cegtag", "missiletrailcorroyspecial"
                    "model", "airbomb"
                    "number", "8"
                    "speceffect", "split"
                    "speceffect_def", "cormship_rocket_split"
                    "splitexplosionceg", "genericshellexplosion-medium"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_maindir", "0 .5 1"
                    "mount_maxangledif", "60.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "cegtag", "missiletrailmship"
                    "craterareaofeffect", "300.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "15.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "interceptedbyshieldtype", "1024.0"
                    "metalpershot", "0.0"
                    "model", "corshiprocket.s3o"
                    "proximitypriority", "1.0"
                    "smoketrail", "false"
                    "soundhitwet", "splslrg"
                    "texture1", "null"
                    "texture2", "null"
                    "texture3", "null"
                    "turnrate", "24384.0"
                    "weaponacceleration", "80.0"
                    "weapontimer", "5.0"
                ] }
              { name = "missile"
                displayName = "Medium Range g2a AA Missiles"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 138.0
                ]
                range = Some (ValueOrExpr.Concrete 710.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rockhvy2"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium-air"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "1.75"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.95"
                    "smokeperiod", "7.0"
                    "smokesize", "5.4"
                    "smoketime", "13.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "430.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "30000.0"
                    "weaponacceleration", "90.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -1.0875 0.375"
                collisionVolumeScales = Some "46.75 27.25 110.75"
                collisionVolumeType = Some "Box"
                damage = Some 2700.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 1000.0
                object_ = Some "Units/cormship_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 500.0
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["shcormov"]
              select = ["shcorsel"] })
          customParams = Map.ofList [
              "maxrange", "1650"
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "radardistance", "1000.0"
          ] }

    let cormshipToFlat (def: UnitDef) : Cormship =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let cormshipToUnitDef (flat: Cormship) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Coronager =
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
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let coronager : Coronager =
        { name = "coronager"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 950.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 26000.0
          health = ValueOrExpr.Concrete 1400.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/coronager.s3o"
          buildPic = Some "coronager.DDS"
          script = Some "Units/coronager.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric-uw"
          selfDestructAs = Some "mediumExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "18 18 60"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 58.0
          maxAcc = 0.03
          maxDec = 0.05
          turnRate = 540.0
          movementClass = "UBOAT4"
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 40.0
          weapons = [
                { name = "stoa_missile"
                  displayName = "Medium long-range s2g missile launcher"
                  weaponType = Some "StarburstLauncher"
                  damage = Map.ofList [
                      "default", 360.0
                      "ship", 200.0
                      "subs", 150.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 9.0)
                  weaponVelocity = Some 700.0
                  areaOfEffect = Some 150.0
                  accuracy = None
                  turret = None
                  tolerance = Some 4000.0
                  edgeEffectiveness = Some 0.2
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "Rockhvy1"
                  soundHit = Some "xplomed4"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 1 0"
                      "mount_maxangledif", "230.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burst", "2.0"
                      "burstrate", "0.2"
                      "castshadow", "true"
                      "cegtag", "missiletrailsmall-starburst"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "100.0"
                      "firesubmersed", "true"
                      "flighttime", "4.0"
                      "metalpershot", "0.0"
                      "model", "banishermissile.s3o"
                      "smokecolor", "0.7"
                      "smokeperiod", "9.0"
                      "smokesize", "10.0"
                      "smoketime", "28.0"
                      "smoketrail", "true"
                      "smoketrailcastshadow", "false"
                      "soundhitwet", "splssml"
                      "startvelocity", "350.0"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "texture3", "null"
                      "turnrate", "25000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "0.0"
                      "weapontimer", "0.6"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 1 0"
                  collisionVolumeScales = Some "20 20 60"
                  collisionVolumeType = Some "Box"
                  damage = Some 1362.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 375.0
                  object_ = Some "Units/coronager_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 187.0
                  object_ = Some "Units/cor2X2A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sucormov"]
                select = ["sucorsel"] }
          customParams = Map.ofList [
                "model_author", "Hornet"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "sub"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "sonardistance", "200.0"
                "upright", "true"
            ] }

    let coronagerDef : UnitDef =
        { name = "coronager"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 950.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 26000.0
          health = ValueOrExpr.Concrete 1400.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/coronager.s3o"
          buildPic = Some "coronager.DDS"
          script = Some "Units/coronager.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric-uw"
          selfDestructAs = Some "mediumExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "18 18 60"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 58.0
              maxAcc = 0.03
              maxDec = 0.05
              turnRate = 540.0
              movementClass = Some "UBOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 40.0 })
          builder = None
          weapons = Some [
              { name = "stoa_missile"
                displayName = "Medium long-range s2g missile launcher"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 360.0
                    "ship", 200.0
                    "subs", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 9.0)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 150.0
                accuracy = None
                turret = None
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.2
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 1 0"
                    "mount_maxangledif", "230.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "castshadow", "true"
                    "cegtag", "missiletrailsmall-starburst"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "firesubmersed", "true"
                    "flighttime", "4.0"
                    "metalpershot", "0.0"
                    "model", "banishermissile.s3o"
                    "smokecolor", "0.7"
                    "smokeperiod", "9.0"
                    "smokesize", "10.0"
                    "smoketime", "28.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splssml"
                    "startvelocity", "350.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "25000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "0.0"
                    "weapontimer", "0.6"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 1 0"
                collisionVolumeScales = Some "20 20 60"
                collisionVolumeType = Some "Box"
                damage = Some 1362.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 375.0
                object_ = Some "Units/coronager_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 187.0
                object_ = Some "Units/cor2X2A.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sucormov"]
              select = ["sucorsel"] })
          customParams = Map.ofList [
              "model_author", "Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "sonardistance", "200.0"
              "upright", "true"
          ] }

    let coronagerToFlat (def: UnitDef) : Coronager =
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
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let coronagerToUnitDef (flat: Coronager) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corprince =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corprince : Corprince =
        { name = "corprince"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 13500.0
          energyCost = ValueOrExpr.Concrete 115000.0
          buildTime = ValueOrExpr.Concrete 200000.0
          health = ValueOrExpr.Concrete 25000.0
          sightDistance = ValueOrExpr.Concrete 689.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/CORPRINCE.s3o"
          buildPic = Some "corprince.DDS"
          script = Some "Units/CORPRINCE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flagshipExplosion"
          selfDestructAs = Some "flagshipExplosionSelfd"
          collisionVolumeOffsets = Some "0 -6 3"
          collisionVolumeScales = Some "71 71 225"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 53.85
          maxAcc = 0.01104
          maxDec = 0.01104
          turnRate = 135.0
          movementClass = "BOAT9"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 0.0
          weapons = [
                { name = "heavyplasma"
                  displayName = "Heavy Long-Range Plasma Bombardment Cannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 2000.0
                      "shields", 1000.0
                      "subs", 600.0
                  ]
                  range = Some (ValueOrExpr.Concrete 3200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 18.0)
                  weaponVelocity = Some 1100.0
                  areaOfEffect = Some 157.0
                  accuracy = Some 750.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 1.1
                  noSelfDamage = Some true
                  soundStart = Some "lrpcshot"
                  soundHit = Some "rflrpcexplo"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = Some "0.9, 0.5, 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "280.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "burst", "2.0"
                      "burstrate", "0.1"
                      "cegtag", "arty-extraheavy"
                      "collidefriendly", "false"
                      "craterboost", "0.1"
                      "cratermult", "0.1"
                      "energypershot", "9000.0"
                      "gravityaffected", "true"
                      "soundhitvolume", "42.0"
                      "soundhitwet", "splshbig"
                      "weapontimer", "14.0"
                  ] }
                { name = "navalplasma"
                  displayName = "Long-Range Plasma Bombardment Cannons"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 1000.0
                      "shields", 500.0
                      "subs", 300.0
                  ]
                  range = Some (ValueOrExpr.Concrete 2300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 12.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 157.0
                  accuracy = Some 335.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 1.1
                  noSelfDamage = Some true
                  soundStart = Some "lrpcshot"
                  soundHit = Some "lrpcexplo"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 -1"
                      "mount_maxangledif", "260.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burst", "2.0"
                      "burstrate", "0.1"
                      "cegtag", "arty-extraheavy"
                      "collidefriendly", "false"
                      "craterareaofeffect", "136.0"
                      "craterboost", "0.1"
                      "cratermult", "0.1"
                      "energypershot", "3000.0"
                      "gravityaffected", "true"
                      "heightboostfactor", "6.0"
                      "leadbonus", "0.0"
                      "soundhitvolume", "36.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "28.0"
                  ] }
                { name = "navalplasma"
                  displayName = "Long-Range Plasma Bombardment Cannons"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 1000.0
                      "shields", 500.0
                      "subs", 300.0
                  ]
                  range = Some (ValueOrExpr.Concrete 2300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 12.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 157.0
                  accuracy = Some 335.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 1.1
                  noSelfDamage = Some true
                  soundStart = Some "lrpcshot"
                  soundHit = Some "lrpcexplo"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "270.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burst", "2.0"
                      "burstrate", "0.1"
                      "cegtag", "arty-extraheavy"
                      "collidefriendly", "false"
                      "craterareaofeffect", "136.0"
                      "craterboost", "0.1"
                      "cratermult", "0.1"
                      "energypershot", "3000.0"
                      "gravityaffected", "true"
                      "heightboostfactor", "6.0"
                      "leadbonus", "0.0"
                      "soundhitvolume", "36.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "28.0"
                  ] }
                { name = "navalplasma"
                  displayName = "Long-Range Plasma Bombardment Cannons"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 1000.0
                      "shields", 500.0
                      "subs", 300.0
                  ]
                  range = Some (ValueOrExpr.Concrete 2300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 12.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 157.0
                  accuracy = Some 335.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 1.1
                  noSelfDamage = Some true
                  soundStart = Some "lrpcshot"
                  soundHit = Some "lrpcexplo"
                  explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "250.0"
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burst", "2.0"
                      "burstrate", "0.1"
                      "cegtag", "arty-extraheavy"
                      "collidefriendly", "false"
                      "craterareaofeffect", "136.0"
                      "craterboost", "0.1"
                      "cratermult", "0.1"
                      "energypershot", "3000.0"
                      "gravityaffected", "true"
                      "heightboostfactor", "6.0"
                      "leadbonus", "0.0"
                      "soundhitvolume", "36.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "28.0"
                  ] }
                { name = "mobileflak"
                  displayName = "Anti-Air Flak Cannons"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "vtol", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 775.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.466)
                  weaponVelocity = Some 1550.0
                  areaOfEffect = Some 140.0
                  accuracy = Some 1000.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "flakfire"
                  soundHit = Some "flakhit"
                  explosiongenerator = Some "custom:flak"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_onlytargetcategory", "VTOL T4AIR"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "flaktrailaa"
                      "craterareaofeffect", "140.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "gravityaffected", "true"
                      "size", "0.0"
                      "sizedecay", "0.08"
                      "soundhitwet", "splsmed"
                      "stages", "0.0"
                      "weapontimer", "1.0"
                  ] }
                { name = "mobileflak"
                  displayName = "Anti-Air Flak Cannons"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "vtol", 200.0
                  ]
                  range = Some (ValueOrExpr.Concrete 775.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.466)
                  weaponVelocity = Some 1550.0
                  areaOfEffect = Some 140.0
                  accuracy = Some 1000.0
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "flakfire"
                  soundHit = Some "flakhit"
                  explosiongenerator = Some "custom:flak"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_onlytargetcategory", "VTOL T4AIR"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "flaktrailaa"
                      "craterareaofeffect", "140.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "gravityaffected", "true"
                      "size", "0.0"
                      "sizedecay", "0.08"
                      "soundhitwet", "splsmed"
                      "stages", "0.0"
                      "weapontimer", "1.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.439918518066 -4.07348632798e-05 0.367340087891"
                  collisionVolumeScales = Some "75.0081939697 51.5621185303 178.425750732"
                  collisionVolumeType = Some "Box"
                  damage = Some 85500.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 18.0
                  height = Some 4.0
                  metal = Some 8500.0
                  object_ = Some "Units/CorPrince_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 40032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 4250.0
                  object_ = Some "Units/arm6X6A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "model_author", "Johnathan Crimson, ZephyrSkies (Script Assistance)"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "weapon"
            ]
          extras = Map.ofList [
                "buildangle", "16384.0"
                "canattackground", "true"
                "mass", "9999999.0"
                "movestate", "0.0"
                "radardistance", "1530.0"
                "radaremitheight", "52.0"
                "sightemitheight", "52.0"
            ] }

    let corprinceDef : UnitDef =
        { name = "corprince"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 13500.0
          energyCost = ValueOrExpr.Concrete 115000.0
          buildTime = ValueOrExpr.Concrete 200000.0
          health = ValueOrExpr.Concrete 25000.0
          sightDistance = ValueOrExpr.Concrete 689.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/CORPRINCE.s3o"
          buildPic = Some "corprince.DDS"
          script = Some "Units/CORPRINCE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flagshipExplosion"
          selfDestructAs = Some "flagshipExplosionSelfd"
          collisionVolumeOffsets = Some "0 -6 3"
          collisionVolumeScales = Some "71 71 225"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 53.85
              maxAcc = 0.01104
              maxDec = 0.01104
              turnRate = 135.0
              movementClass = Some "BOAT9"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "heavyplasma"
                displayName = "Heavy Long-Range Plasma Bombardment Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 2000.0
                    "shields", 1000.0
                    "subs", 600.0
                ]
                range = Some (ValueOrExpr.Concrete 3200.0)
                reloadTime = Some (ValueOrExpr.Concrete 18.0)
                weaponVelocity = Some 1100.0
                areaOfEffect = Some 157.0
                accuracy = Some 750.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.1
                noSelfDamage = Some true
                soundStart = Some "lrpcshot"
                soundHit = Some "rflrpcexplo"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = Some "0.9, 0.5, 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "280.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "burst", "2.0"
                    "burstrate", "0.1"
                    "cegtag", "arty-extraheavy"
                    "collidefriendly", "false"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "9000.0"
                    "gravityaffected", "true"
                    "soundhitvolume", "42.0"
                    "soundhitwet", "splshbig"
                    "weapontimer", "14.0"
                ] }
              { name = "navalplasma"
                displayName = "Long-Range Plasma Bombardment Cannons"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1000.0
                    "shields", 500.0
                    "subs", 300.0
                ]
                range = Some (ValueOrExpr.Concrete 2300.0)
                reloadTime = Some (ValueOrExpr.Concrete 12.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 157.0
                accuracy = Some 335.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.1
                noSelfDamage = Some true
                soundStart = Some "lrpcshot"
                soundHit = Some "lrpcexplo"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 -1"
                    "mount_maxangledif", "260.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burst", "2.0"
                    "burstrate", "0.1"
                    "cegtag", "arty-extraheavy"
                    "collidefriendly", "false"
                    "craterareaofeffect", "136.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "3000.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "6.0"
                    "leadbonus", "0.0"
                    "soundhitvolume", "36.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "28.0"
                ] }
              { name = "navalplasma"
                displayName = "Long-Range Plasma Bombardment Cannons"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1000.0
                    "shields", 500.0
                    "subs", 300.0
                ]
                range = Some (ValueOrExpr.Concrete 2300.0)
                reloadTime = Some (ValueOrExpr.Concrete 12.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 157.0
                accuracy = Some 335.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.1
                noSelfDamage = Some true
                soundStart = Some "lrpcshot"
                soundHit = Some "lrpcexplo"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burst", "2.0"
                    "burstrate", "0.1"
                    "cegtag", "arty-extraheavy"
                    "collidefriendly", "false"
                    "craterareaofeffect", "136.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "3000.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "6.0"
                    "leadbonus", "0.0"
                    "soundhitvolume", "36.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "28.0"
                ] }
              { name = "navalplasma"
                displayName = "Long-Range Plasma Bombardment Cannons"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1000.0
                    "shields", 500.0
                    "subs", 300.0
                ]
                range = Some (ValueOrExpr.Concrete 2300.0)
                reloadTime = Some (ValueOrExpr.Concrete 12.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 157.0
                accuracy = Some 335.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.1
                noSelfDamage = Some true
                soundStart = Some "lrpcshot"
                soundHit = Some "lrpcexplo"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "250.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burst", "2.0"
                    "burstrate", "0.1"
                    "cegtag", "arty-extraheavy"
                    "collidefriendly", "false"
                    "craterareaofeffect", "136.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "3000.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "6.0"
                    "leadbonus", "0.0"
                    "soundhitvolume", "36.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "28.0"
                ] }
              { name = "mobileflak"
                displayName = "Anti-Air Flak Cannons"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "vtol", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 775.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.466)
                weaponVelocity = Some 1550.0
                areaOfEffect = Some 140.0
                accuracy = Some 1000.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "flakfire"
                soundHit = Some "flakhit"
                explosiongenerator = Some "custom:flak"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL T4AIR"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "flaktrailaa"
                    "craterareaofeffect", "140.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "gravityaffected", "true"
                    "size", "0.0"
                    "sizedecay", "0.08"
                    "soundhitwet", "splsmed"
                    "stages", "0.0"
                    "weapontimer", "1.0"
                ] }
              { name = "mobileflak"
                displayName = "Anti-Air Flak Cannons"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "vtol", 200.0
                ]
                range = Some (ValueOrExpr.Concrete 775.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.466)
                weaponVelocity = Some 1550.0
                areaOfEffect = Some 140.0
                accuracy = Some 1000.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "flakfire"
                soundHit = Some "flakhit"
                explosiongenerator = Some "custom:flak"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL T4AIR"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "flaktrailaa"
                    "craterareaofeffect", "140.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "gravityaffected", "true"
                    "size", "0.0"
                    "sizedecay", "0.08"
                    "soundhitwet", "splsmed"
                    "stages", "0.0"
                    "weapontimer", "1.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.439918518066 -4.07348632798e-05 0.367340087891"
                collisionVolumeScales = Some "75.0081939697 51.5621185303 178.425750732"
                collisionVolumeType = Some "Box"
                damage = Some 85500.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 18.0
                height = Some 4.0
                metal = Some 8500.0
                object_ = Some "Units/CorPrince_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 40032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 4250.0
                object_ = Some "Units/arm6X6A.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "model_author", "Johnathan Crimson, ZephyrSkies (Script Assistance)"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "canattackground", "true"
              "mass", "9999999.0"
              "movestate", "0.0"
              "radardistance", "1530.0"
              "radaremitheight", "52.0"
              "sightemitheight", "52.0"
          ] }

    let corprinceToFlat (def: UnitDef) : Corprince =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corprinceToUnitDef (flat: Corprince) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corsacvsub =
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
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          energyStorage: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corsacvsub : Corsacvsub =
        { name = "corsacvsub"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 500.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 22000.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 156.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORACSUB.s3o"
          buildPic = Some "CORACSUB.DDS"
          script = Some "Units/CORACSUB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-uw"
          selfDestructAs = Some "mediumexplosiongenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 4"
          collisionVolumeScales = Some "40 25 74"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 64.8
          maxAcc = 0.042
          maxDec = 0.042
          turnRate = 385.5
          movementClass = "UBOAT4"
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 20.0
          waterline = 80.0
          workerTime = ValueOrExpr.Concrete 300.0
          buildDistance = 180.0
          buildOptions = ["coruwmmm"; "coruwmme"; "corgantuw"; "corasy"; "corsy"; "coratl"; "coruwageo"; "corsasy"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 30.0
          energyStorage = 150.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0.0 -1.62156426758 -7.49900054932"
                  collisionVolumeScales = Some "45.8502807617 11.0077514648 73.3929595947"
                  collisionVolumeType = Some "Box"
                  damage = Some 444.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 350.0
                  object_ = Some "Units/coracsub_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 1432.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 175.0
                  object_ = Some "Units/cor4X4C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sucormov"]
                select = ["sucorsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "buildert2"
            ]
          extras = Map.ofList [
                "radardistance", "50.0"
            ] }

    let corsacvsubDef : UnitDef =
        { name = "corsacvsub"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 500.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 22000.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 156.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORACSUB.s3o"
          buildPic = Some "CORACSUB.DDS"
          script = Some "Units/CORACSUB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-uw"
          selfDestructAs = Some "mediumexplosiongenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 4"
          collisionVolumeScales = Some "40 25 74"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 64.8
              maxAcc = 0.042
              maxDec = 0.042
              turnRate = 385.5
              movementClass = Some "UBOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 20.0
              waterline = Some 80.0 })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = Some 180.0
              buildOptions = ["coruwmmm"; "coruwmme"; "corgantuw"; "corasy"; "corsy"; "coratl"; "coruwageo"; "corsasy"]
              terraformSpeed = Some 1500.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 30.0)
              metalMake = None
              energyStorage = Some 150.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -1.62156426758 -7.49900054932"
                collisionVolumeScales = Some "45.8502807617 11.0077514648 73.3929595947"
                collisionVolumeType = Some "Box"
                damage = Some 444.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 350.0
                object_ = Some "Units/coracsub_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1432.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 175.0
                object_ = Some "Units/cor4X4C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sucormov"]
              select = ["sucorsel"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "radardistance", "50.0"
          ] }

    let corsacvsubToFlat (def: UnitDef) : Corsacvsub =
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
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corsacvsubToUnitDef (flat: Corsacvsub) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
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
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corsentinel =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corsentinel : Corsentinel =
        { name = "corsentinel"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 20000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORSENTINEL.s3o"
          buildPic = Some "CORSENTINEL.DDS"
          script = Some "Units/CORSENTINEL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfD"
          collisionVolumeOffsets = Some "-1 5 0"
          collisionVolumeScales = Some "48 48 102"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 180.0
          movementClass = "BOAT9"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 0.0
          weapons = [
                { name = "plasma"
                  displayName = "Depth Charge Drones"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 0.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.5)
                  weaponVelocity = Some 800.0
                  areaOfEffect = Some 4.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some ""
                  soundHit = Some ""
                  explosiongenerator = Some ""
                  rgbColor = None
                  customParams = Map.ofList [
                      "carried_unit", "cortdrone"
                      "spawns_surface", "SEA"
                      "carrierdeaththroe", "release"
                      "dockingpieces", "4 5 6 7 8 9 10"
                  ]
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "hightrajectory", "1.0"
                      "metalpershot", "40.0"
                      "energypershot", "1000.0"
                      "size", "0.0"
                      "soundhitwet", ""
                      "stockpile", "true"
                      "stockpiletime", "6.0"
                      "waterweapon", "true"
                  ] }
                { name = "sentinel_depthcharge"
                  displayName = "Depthcharge launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 255.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = Some 200.0
                  areaOfEffect = None
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep2"
                  explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "bouncerebound", "0.6"
                      "bounceslip", "0.6"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "1.75"
                      "groundbounce", "true"
                      "model", "cordepthcharge.s3o"
                      "numbounce", "1.0"
                      "soundhitwet", "splsmed"
                      "soundhitvolume", "3.0"
                      "soundhitwetvolume", "12.0"
                      "startvelocity", "300.0"
                      "tracks", "true"
                      "turnrate", "64000.0"
                      "waterweapon", "true"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-0.0550308227539 1.52587890767e-06 4.55026245117"
                  collisionVolumeScales = Some "61.8225860596 60.9250030518 154.450805664"
                  collisionVolumeType = Some "Box"
                  damage = Some 9168.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 700.0
                  object_ = Some "Units/CORSENTINEL_DEAD.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = None
                  collisionVolumeType = None
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 350.0
                  object_ = Some "Units/arm6X6C.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sharmmov"]
                select = ["sharmsel"] }
          customParams = Map.ofList [
                "maxrange", "600.0"
                "model_author", "Odin, Hornet"
                "normaltex", "unittextures/Cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "inheritxpratemultiplier", "1.0"
                "childreninheritxp", "DRONE"
                "parentsinheritxp", "DRONE"
            ]
          extras = Map.ofList [
                "acceleration", "0.01722"
                "brakerate", "0.01722"
                "buildangle", "16384.0"
                "buildcostenergy", "13500.0"
                "buildcostmetal", "1350.0"
                "canreclaim", "false"
                "canrepair", "false"
                "canrestore", "false"
                "losemitheight", "56.0"
                "mass", "5000.0"
                "maxdamage", "3800.0"
                "maxvelocity", "2.1"
                "nochasecategory", "VTOL"
                "sonardistance", "700.0"
            ] }

    let corsentinelDef : UnitDef =
        { name = "corsentinel"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 20000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORSENTINEL.s3o"
          buildPic = Some "CORSENTINEL.DDS"
          script = Some "Units/CORSENTINEL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfD"
          collisionVolumeOffsets = Some "-1 5 0"
          collisionVolumeScales = Some "48 48 102"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 180.0
              movementClass = Some "BOAT9"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 0.0 })
          builder = None
          weapons = Some [
              { name = "plasma"
                displayName = "Depth Charge Drones"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1300.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 4.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some ""
                soundHit = Some ""
                explosiongenerator = Some ""
                rgbColor = None
                customParams = Map.ofList [
                    "carried_unit", "cortdrone"
                    "spawns_surface", "SEA"
                    "carrierdeaththroe", "release"
                    "dockingpieces", "4 5 6 7 8 9 10"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "metalpershot", "40.0"
                    "energypershot", "1000.0"
                    "size", "0.0"
                    "soundhitwet", ""
                    "stockpile", "true"
                    "stockpiletime", "6.0"
                    "waterweapon", "true"
                ] }
              { name = "sentinel_depthcharge"
                displayName = "Depthcharge launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 255.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 200.0
                areaOfEffect = None
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "bouncerebound", "0.6"
                    "bounceslip", "0.6"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.75"
                    "groundbounce", "true"
                    "model", "cordepthcharge.s3o"
                    "numbounce", "1.0"
                    "soundhitwet", "splsmed"
                    "soundhitvolume", "3.0"
                    "soundhitwetvolume", "12.0"
                    "startvelocity", "300.0"
                    "tracks", "true"
                    "turnrate", "64000.0"
                    "waterweapon", "true"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.0550308227539 1.52587890767e-06 4.55026245117"
                collisionVolumeScales = Some "61.8225860596 60.9250030518 154.450805664"
                collisionVolumeType = Some "Box"
                damage = Some 9168.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 700.0
                object_ = Some "Units/CORSENTINEL_DEAD.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 350.0
                object_ = Some "Units/arm6X6C.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sharmmov"]
              select = ["sharmsel"] })
          customParams = Map.ofList [
              "maxrange", "600.0"
              "model_author", "Odin, Hornet"
              "normaltex", "unittextures/Cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "inheritxpratemultiplier", "1.0"
              "childreninheritxp", "DRONE"
              "parentsinheritxp", "DRONE"
          ]
          extras = Map.ofList [
              "acceleration", "0.01722"
              "brakerate", "0.01722"
              "buildangle", "16384.0"
              "buildcostenergy", "13500.0"
              "buildcostmetal", "1350.0"
              "canreclaim", "false"
              "canrepair", "false"
              "canrestore", "false"
              "losemitheight", "56.0"
              "mass", "5000.0"
              "maxdamage", "3800.0"
              "maxvelocity", "2.1"
              "nochasecategory", "VTOL"
              "sonardistance", "700.0"
          ] }

    let corsentinelToFlat (def: UnitDef) : Corsentinel =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corsentinelToUnitDef (flat: Corsentinel) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corshark =
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
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corshark : Corshark =
        { name = "corshark"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 730.0
          energyCost = ValueOrExpr.Concrete 14000.0
          buildTime = ValueOrExpr.Concrete 23000.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 390.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORSHARK.s3o"
          buildPic = Some "CORSHARK.DDS"
          script = Some "Units/CORSHARK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric-uw"
          selfDestructAs = Some "mediumExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 5 0"
          collisionVolumeScales = Some "30 30 64"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 84.0
          maxAcc = 0.05
          maxDec = 0.05
          turnRate = 540.0
          movementClass = "UBOAT4"
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 15.0
          waterline = 40.0
          weapons = [
                { name = "armsmart_torpedo"
                  displayName = "Rapid armor-piercing torpedoes"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 350.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.2)
                  weaponVelocity = Some 200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some false
                  tolerance = Some 9000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep1"
                  explosiongenerator = Some "custom:genericshellexplosion-medium-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "HOVER NOTSHIP"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "mount_onlytargetcategory", "NOTHOVER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "cegtag", "torpedotrail-small"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "model", "cortorpedo.s3o"
                      "soundhitvolume", "18.0"
                      "startvelocity", "150.0"
                      "tracks", "true"
                      "turnrate", "1000.0"
                      "waterweapon", "true"
                      "weaponacceleration", "10.0"
                      "weapontimer", "3.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "1.25 0.0 0.0374984741211"
                  collisionVolumeScales = Some "20.0 15.5 55.0749969482"
                  collisionVolumeType = Some "Box"
                  damage = Some 1362.0
                  featureDead = Some "HEAP"
                  footprintX = Some 6.0
                  footprintZ = Some 6.0
                  height = Some 4.0
                  metal = Some 375.0
                  object_ = Some "Units/corshark_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 187.0
                  object_ = Some "Units/cor2X2A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sucormov"]
                select = ["sucorsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "sub"
            ]
          extras = Map.ofList [
                "nochasecategory", "VTOL"
                "sonardistance", "525.0"
                "upright", "true"
            ] }

    let corsharkDef : UnitDef =
        { name = "corshark"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 730.0
          energyCost = ValueOrExpr.Concrete 14000.0
          buildTime = ValueOrExpr.Concrete 23000.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 390.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORSHARK.s3o"
          buildPic = Some "CORSHARK.DDS"
          script = Some "Units/CORSHARK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric-uw"
          selfDestructAs = Some "mediumExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 5 0"
          collisionVolumeScales = Some "30 30 64"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 84.0
              maxAcc = 0.05
              maxDec = 0.05
              turnRate = 540.0
              movementClass = Some "UBOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 15.0
              waterline = Some 40.0 })
          builder = None
          weapons = Some [
              { name = "armsmart_torpedo"
                displayName = "Rapid armor-piercing torpedoes"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 350.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.2)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some false
                tolerance = Some 9000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-medium-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-small"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "cortorpedo.s3o"
                    "soundhitvolume", "18.0"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "1000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "10.0"
                    "weapontimer", "3.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "1.25 0.0 0.0374984741211"
                collisionVolumeScales = Some "20.0 15.5 55.0749969482"
                collisionVolumeType = Some "Box"
                damage = Some 1362.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 375.0
                object_ = Some "Units/corshark_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 187.0
                object_ = Some "Units/cor2X2A.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sucormov"]
              select = ["sucorsel"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "sonardistance", "525.0"
              "upright", "true"
          ] }

    let corsharkToFlat (def: UnitDef) : Corshark =
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
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corsharkToUnitDef (flat: Corshark) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corsjam =
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
          canMove: bool
          floater: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corsjam : Corsjam =
        { name = "corsjam"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 280.0
          energyCost = ValueOrExpr.Concrete 4200.0
          buildTime = ValueOrExpr.Concrete 17000.0
          health = ValueOrExpr.Concrete 1450.0
          sightDistance = ValueOrExpr.Concrete 403.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORSJAM.s3o"
          buildPic = Some "CORSJAM.DDS"
          script = Some "Units/CORSJAM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "28 36 70"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 40.0
          maxAcc = 0.03574
          maxDec = 0.03574
          turnRate = 384.0
          movementClass = "BOAT3"
          canMove = true
          floater = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 6.0
          waterline = 0.0
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-3.9418182373 0.0506627246094 -0.0"
                  collisionVolumeScales = Some "41.9625549316 13.4625854492 69.8010559082"
                  collisionVolumeType = Some "Box"
                  damage = Some 684.0
                  featureDead = Some "HEAP"
                  footprintX = Some 4.0
                  footprintZ = Some 4.0
                  height = Some 20.0
                  metal = Some 60.0
                  object_ = Some "Units/corsjam_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "85.0 14.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4032.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 30.0
                  object_ = Some "Units/cor4X4A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["shcormov"]
                select = ["radjam2"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "off_on_stun", "true"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "util"
            ]
          extras = Map.ofList [
                "energyupkeep", "80.0"
                "nochasecategory", "MOBILE"
                "onoffable", "true"
                "radardistancejam", "900.0"
            ] }

    let corsjamDef : UnitDef =
        { name = "corsjam"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 280.0
          energyCost = ValueOrExpr.Concrete 4200.0
          buildTime = ValueOrExpr.Concrete 17000.0
          health = ValueOrExpr.Concrete 1450.0
          sightDistance = ValueOrExpr.Concrete 403.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORSJAM.s3o"
          buildPic = Some "CORSJAM.DDS"
          script = Some "Units/CORSJAM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "28 36 70"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 40.0
              maxAcc = 0.03574
              maxDec = 0.03574
              turnRate = 384.0
              movementClass = Some "BOAT3"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 6.0
              waterline = Some 0.0 })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-3.9418182373 0.0506627246094 -0.0"
                collisionVolumeScales = Some "41.9625549316 13.4625854492 69.8010559082"
                collisionVolumeType = Some "Box"
                damage = Some 684.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 60.0
                object_ = Some "Units/corsjam_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4032.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 30.0
                object_ = Some "Units/cor4X4A.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["shcormov"]
              select = ["radjam2"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "off_on_stun", "true"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "energyupkeep", "80.0"
              "nochasecategory", "MOBILE"
              "onoffable", "true"
              "radardistancejam", "900.0"
          ] }

    let corsjamToFlat (def: UnitDef) : Corsjam =
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
          canMove = def.movement.Value.canMove
          floater = def.movement.Value.floater
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corsjamToUnitDef (flat: Corsjam) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = flat.floater
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corssub =
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
          canMove: bool
          turnInPlace: bool
          turnInPlaceAngleLimit: float
          minWaterDepth: float
          waterline: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corssub : Corssub =
        { name = "corssub"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1900.0
          energyCost = ValueOrExpr.Concrete 29000.0
          buildTime = ValueOrExpr.Concrete 35000.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 570.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORSSUB.s3o"
          buildPic = Some "CORSSUB.DDS"
          script = Some "Units/CORSSUB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeexplosiongeneric-uw"
          selfDestructAs = Some "largeexplosiongenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "52 25 60"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 39.0
          maxAcc = 0.018
          maxDec = 0.018
          turnRate = 320.0
          movementClass = "UBOAT4"
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          minWaterDepth = 20.0
          waterline = 80.0
          weapons = [
                { name = "armserp_weapon"
                  displayName = "AdvTorpedo"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "commanders", 750.0
                      "default", 1650.0
                      "subs", 1110.0
                  ]
                  range = Some (ValueOrExpr.Concrete 850.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 220.0
                  areaOfEffect = Some 160.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 8000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep1"
                  explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "HOVER NOTSHIP"
                      "mount_maindir", "0 0.2 1"
                      "mount_maxangledif", "80.0"
                      "mount_onlytargetcategory", "NOTHOVER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "burnblow", "true"
                      "cegtag", "torpedotrail-large"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "model", "coradvtorpedo.s3o"
                      "soundhitvolume", "22.0"
                      "startvelocity", "150.0"
                      "tracks", "true"
                      "turnrate", "1500.0"
                      "waterweapon", "true"
                      "weaponacceleration", "25.0"
                      "weapontimer", "4.0"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some false
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "-6.04158782959 -4.50195312496e-06 -0.0"
                  collisionVolumeScales = Some "39.0926055908 13.0902709961 63.9697265625"
                  collisionVolumeType = Some "Box"
                  damage = Some 2200.0
                  featureDead = Some "HEAP"
                  footprintX = Some 3.0
                  footprintZ = Some 3.0
                  height = Some 4.0
                  metal = Some 1050.0
                  object_ = Some "Units/corssub_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 4400.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 525.0
                  object_ = Some "Units/cor2X2A.s3o"
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
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["sucormov"]
                select = ["sucorsel"] }
          customParams = Map.ofList [
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "techlevel", "2.0"
                "unitgroup", "sub"
            ]
          extras = Map.ofList [
                "movestate", "0.0"
                "nochasecategory", "VTOL"
                "sonardistance", "400.0"
                "stealth", "true"
                "upright", "true"
            ] }

    let corssubDef : UnitDef =
        { name = "corssub"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 1900.0
          energyCost = ValueOrExpr.Concrete 29000.0
          buildTime = ValueOrExpr.Concrete 35000.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 570.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORSSUB.s3o"
          buildPic = Some "CORSSUB.DDS"
          script = Some "Units/CORSSUB.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeexplosiongeneric-uw"
          selfDestructAs = Some "largeexplosiongenericSelfd-uw"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "52 25 60"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 39.0
              maxAcc = 0.018
              maxDec = 0.018
              turnRate = 320.0
              movementClass = Some "UBOAT4"
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some 20.0
              waterline = Some 80.0 })
          builder = None
          weapons = Some [
              { name = "armserp_weapon"
                displayName = "AdvTorpedo"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "commanders", 750.0
                    "default", 1650.0
                    "subs", 1110.0
                ]
                range = Some (ValueOrExpr.Concrete 850.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 220.0
                areaOfEffect = Some 160.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_maindir", "0 0.2 1"
                    "mount_maxangledif", "80.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-large"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "coradvtorpedo.s3o"
                    "soundhitvolume", "22.0"
                    "startvelocity", "150.0"
                    "tracks", "true"
                    "turnrate", "1500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "25.0"
                    "weapontimer", "4.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-6.04158782959 -4.50195312496e-06 -0.0"
                collisionVolumeScales = Some "39.0926055908 13.0902709961 63.9697265625"
                collisionVolumeType = Some "Box"
                damage = Some 2200.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 1050.0
                object_ = Some "Units/corssub_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4400.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 525.0
                object_ = Some "Units/cor2X2A.s3o"
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
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["sucormov"]
              select = ["sucorsel"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "sonardistance", "400.0"
              "stealth", "true"
              "upright", "true"
          ] }

    let corssubToFlat (def: UnitDef) : Corssub =
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
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          minWaterDepth = def.movement.Value.minWaterDepth.Value
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corssubToUnitDef (flat: Corssub) : UnitDef =
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
              maxSlope = None
              maxWaterDepth = None
              canFly = false
              canMove = flat.canMove
              floater = false
              turnInPlace = Some flat.turnInPlace
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = Some flat.minWaterDepth
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Cortdrone =
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
          canFly: bool
          canMove: bool
          turnInPlaceAngleLimit: float
          weapons: WeaponDef list
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cortdrone : Cortdrone =
        { name = "cortdrone"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/CORDRONE.s3o"
          buildPic = Some "CORBW.DDS"
          script = Some "Units/CORDRONE.cob"
          corpse = None
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 0.0
          maxAcc = 0.0
          maxDec = 0.0
          turnRate = 900.0
          maxSlope = 10.0
          maxWaterDepth = 0.0
          canFly = true
          canMove = true
          turnInPlaceAngleLimit = 360.0
          weapons = [
                { name = "cotd_depthcharge"
                  displayName = "Depthcharge launcher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 255.0
                  ]
                  range = Some (ValueOrExpr.Concrete 200.0)
                  reloadTime = Some (ValueOrExpr.Concrete 6.0)
                  weaponVelocity = Some 200.0
                  areaOfEffect = None
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep2"
                  explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTSUB"
                      "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "bouncerebound", "0.6"
                      "bounceslip", "0.6"
                      "burnblow", "true"
                      "collidefriendly", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "1.75"
                      "groundbounce", "true"
                      "model", "cordepthcharge.s3o"
                      "numbounce", "1.0"
                      "soundhitvolume", "3.0"
                      "soundhitwet", "splsmed"
                      "soundhitwetvolume", "12.0"
                      "startvelocity", "300.0"
                      "tracks", "true"
                      "turnrate", "64000.0"
                      "waterweapon", "true"
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
                "drone", "1.0"
                "model_author", "Mr Bob"
                "nohealthbars", "1.0"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorShips/T2"
                "unitgroup", "emp"
            ]
          extras = Map.ofList [
                "acceleration", "0.2"
                "blocking", "false"
                "brakerate", "0.45"
                "buildcostenergy", "1000.0"
                "buildcostmetal", "40.0"
                "collide", "true"
                "cruisealt", "40.0"
                "hoverattack", "true"
                "maxdamage", "450.0"
                "maxvelocity", "10.5"
                "nochasecategory", "VTOL"
                "sonardistance", "500.0"
                "upright", "true"
                "usesmoothmesh", "0.0"
            ] }

    let cortdroneDef : UnitDef =
        { name = "cortdrone"
          subfolder = "CorShips/T2"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 0.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/CORDRONE.s3o"
          buildPic = Some "CORBW.DDS"
          script = Some "Units/CORDRONE.cob"
          corpse = None
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 0.0
              turnRate = 900.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "cotd_depthcharge"
                displayName = "Depthcharge launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 255.0
                ]
                range = Some (ValueOrExpr.Concrete 200.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 200.0
                areaOfEffect = None
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSUB"
                    "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "bouncerebound", "0.6"
                    "bounceslip", "0.6"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.75"
                    "groundbounce", "true"
                    "model", "cordepthcharge.s3o"
                    "numbounce", "1.0"
                    "soundhitvolume", "3.0"
                    "soundhitwet", "splsmed"
                    "soundhitwetvolume", "12.0"
                    "startvelocity", "300.0"
                    "tracks", "true"
                    "turnrate", "64000.0"
                    "waterweapon", "true"
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
              "drone", "1.0"
              "model_author", "Mr Bob"
              "nohealthbars", "1.0"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorShips/T2"
              "unitgroup", "emp"
          ]
          extras = Map.ofList [
              "acceleration", "0.2"
              "blocking", "false"
              "brakerate", "0.45"
              "buildcostenergy", "1000.0"
              "buildcostmetal", "40.0"
              "collide", "true"
              "cruisealt", "40.0"
              "hoverattack", "true"
              "maxdamage", "450.0"
              "maxvelocity", "10.5"
              "nochasecategory", "VTOL"
              "sonardistance", "500.0"
              "upright", "true"
              "usesmoothmesh", "0.0"
          ] }

    let cortdroneToFlat (def: UnitDef) : Cortdrone =
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
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          weapons = def.weapons.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let cortdroneToUnitDef (flat: Cortdrone) : UnitDef =
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
              canFly = flat.canFly
              canMove = flat.canMove
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
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

