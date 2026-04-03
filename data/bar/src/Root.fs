// Auto-generated BAR unit data: Root (unified)
namespace BarData.Units

open BarData

module Root =

    type Armassistdrone_land =
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
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armassistdrone_land : Armassistdrone_land =
        { name = "armassistdrone_land"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 150.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/armassistdrone_land.s3o"
          buildPic = Some "ARMBEAVER.DDS"
          script = Some "Units/ARMBEAVER.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "17 11 21"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1000.0
          movementClass = "ATANK3"
          maxSlope = 16.0
          maxWaterDepth = 255.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.9834
          workerTime = ValueOrExpr.Expr "100*Spring.GetModOptions().assistdronesbuildpowermultiplier"
          buildDistance = 150.0
          buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "armmex"; "armmakr"; "armlab"; "armvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"]
          terraformSpeed = 400.0
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning1"
                cancelDestruct = Some "cancel2"
                capture = None
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["tnkt1canamphok"]
                select = ["tnkt1canamphsel"] }
          customParams = Map.ofList [
                "unitgroup", "builder"
                "model_author", "Beherith"
                "normaltex", "unittextures/Arm_normal.dds"
                "subfolder", "ArmVehicles"
            ]
          extras = Map.ofList [
                "cancapture", "true"
                "leavetracks", "true"
                "trackstrength", "5.0"
                "tracktype", "armpincer_tracks"
                "trackwidth", "17.0"
            ] }

    let armassistdrone_landDef : UnitDef =
        { name = "armassistdrone_land"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 150.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/armassistdrone_land.s3o"
          buildPic = Some "ARMBEAVER.DDS"
          script = Some "Units/ARMBEAVER.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "17 11 21"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 1.0
              maxDec = 1.0
              turnRate = 1000.0
              movementClass = Some "ATANK3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 255.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.9834
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Expr "100*Spring.GetModOptions().assistdronesbuildpowermultiplier"
              buildDistance = Some 150.0
              buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "armmex"; "armmakr"; "armlab"; "armvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"]
              terraformSpeed = Some 400.0 })
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
              ok = ["tnkt1canamphok"]
              select = ["tnkt1canamphsel"] })
          customParams = Map.ofList [
              "unitgroup", "builder"
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "subfolder", "ArmVehicles"
          ]
          extras = Map.ofList [
              "cancapture", "true"
              "leavetracks", "true"
              "trackstrength", "5.0"
              "tracktype", "armpincer_tracks"
              "trackwidth", "17.0"
          ] }

    let armassistdrone_landToFlat (def: UnitDef) : Armassistdrone_land =
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
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armassistdrone_landToUnitDef (flat: Armassistdrone_land) : UnitDef =
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
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
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
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armcom =
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
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armcom : Armcom =
        { name = "armcom"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMCOM.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOM_lus.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1148.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 300.0
          buildDistance = 145.0
          buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "armmex"; "armmakr"; "armlab"; "armvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 30.0
          metalMake = ValueOrExpr.Concrete 2.0
          energyStorage = 500.0
          metalStorage = 500.0
          weapons = [
                { name = "armcomlaser"
                  displayName = "Light close-quarters g2g/g2a laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 75.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "7.7"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "armcomsealaser"
                  displayName = "Light underwater-combat laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-blue"
                  rgbColor = Some "0.2 0.2 0.6"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.4"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "impactonly", "1.0"
                      "intensity", "0.3"
                      "laserflaresize", "7.7"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 36.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 20000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2"
                  explosiongenerator = Some "custom:expldgun"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cegtag", "dgunprojectile"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.15"
                      "energypershot", "500.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "noexplode", "true"
                      "soundhitvolume", "36.0"
                      "soundhitwet", "sizzlexs"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "CylY"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 1250.0
                  object_ = Some "Units/armcom_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 500.0
                  object_ = Some "Units/arm2X2F.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning2"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
                select = ["armcomsel"] }
          customParams = Map.ofList [
                "iscommander", "true"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", ""
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "mincloakdistance", "50.0"
                "movestate", "0.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sightemitheight", "40.0"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    let armcomDef : UnitDef =
        { name = "armcom"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/ARMCOM.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOM_lus.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1148.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = Some 145.0
              buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "armmex"; "armmakr"; "armlab"; "armvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"]
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armcomlaser"
                displayName = "Light close-quarters g2g/g2a laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 75.0
                    "subs", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "corethickness", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "70.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "armcomsealaser"
                displayName = "Light underwater-combat laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 200.0
                    "subs", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-blue"
                rgbColor = Some "0.2 0.2 0.6"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "corethickness", "0.4"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "35.0"
                    "firesubmersed", "true"
                    "impactonly", "1.0"
                    "intensity", "0.3"
                    "laserflaresize", "7.7"
                    "rgbcolor2", "0.2 0.2 0.2"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "5.0"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                ]
                range = Some (ValueOrExpr.Concrete 250.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 300.0
                areaOfEffect = Some 36.0
                accuracy = None
                turret = Some true
                tolerance = Some 20000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "disigun1"
                soundHit = Some "xplomas2"
                explosiongenerator = Some "custom:expldgun"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "bouncerebound", "0.0"
                    "cegtag", "dgunprojectile"
                    "commandfire", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.15"
                    "energypershot", "500.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "noexplode", "true"
                    "soundhitvolume", "36.0"
                    "soundhitwet", "sizzlexs"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 30.0)
              metalMake = Some (ValueOrExpr.Concrete 2.0)
              energyStorage = Some 500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "CylY"
                damage = Some 10000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 1250.0
                object_ = Some "Units/armcom_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 5000.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 500.0
                object_ = Some "Units/arm2X2F.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
              select = ["armcomsel"] })
          customParams = Map.ofList [
              "iscommander", "true"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", ""
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "mincloakdistance", "50.0"
              "movestate", "0.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sightemitheight", "40.0"
              "sonardistance", "450.0"
              "upright", "true"
          ] }

    let armcomToFlat (def: UnitDef) : Armcom =
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
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armcomToUnitDef (flat: Armcom) : UnitDef =
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
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armcomcon =
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
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armcomcon : Armcomcon =
        { name = "armcomcon"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOM.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOM_lus.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1148.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 300.0
          buildDistance = 145.0
          buildOptions = ["armrectr"; "armca"; "armck"; "armch"; "armcsa"; "armcs"; "armcv"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 30.0
          metalMake = ValueOrExpr.Concrete 2.0
          energyStorage = 500.0
          metalStorage = 500.0
          weapons = [
                { name = "armcomlaser"
                  displayName = "Light close-quarters g2g/g2a laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 75.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "7.7"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "armcomsealaser"
                  displayName = "Light underwater-combat laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-blue"
                  rgbColor = Some "0.2 0.2 0.6"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.4"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "impactonly", "1.0"
                      "intensity", "0.3"
                      "laserflaresize", "7.7"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "default", 99999.0
                      "scavboss", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 36.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 20000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2"
                  explosiongenerator = Some "custom:expldgun"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cegtag", "dgunprojectile"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.6"
                      "energypershot", "500.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "noexplode", "true"
                      "soundhitvolume", "36.0"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "47 10 47"
                  collisionVolumeType = Some "CylY"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2000.0
                  object_ = Some "Units/armcom_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 1000.0
                  object_ = Some "Units/arm2X2F.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning2"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
                select = ["armcomsel"] }
          customParams = Map.ofList [
                "i18nfromunit", "armcom"
                "iscommander", "true"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", ""
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sightemitheight", "40.0"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    let armcomconDef : UnitDef =
        { name = "armcomcon"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/ARMCOM.s3o"
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOM_lus.lua"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1148.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = Some 145.0
              buildOptions = ["armrectr"; "armca"; "armck"; "armch"; "armcsa"; "armcs"; "armcv"]
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armcomlaser"
                displayName = "Light close-quarters g2g/g2a laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 75.0
                    "subs", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "corethickness", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "70.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "armcomsealaser"
                displayName = "Light underwater-combat laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 200.0
                    "subs", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-blue"
                rgbColor = Some "0.2 0.2 0.6"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "corethickness", "0.4"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "35.0"
                    "firesubmersed", "true"
                    "impactonly", "1.0"
                    "intensity", "0.3"
                    "laserflaresize", "7.7"
                    "rgbcolor2", "0.2 0.2 0.2"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "5.0"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "default", 99999.0
                    "scavboss", 1000.0
                ]
                range = Some (ValueOrExpr.Concrete 250.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 300.0
                areaOfEffect = Some 36.0
                accuracy = None
                turret = Some true
                tolerance = Some 20000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "disigun1"
                soundHit = Some "xplomas2"
                explosiongenerator = Some "custom:expldgun"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "bouncerebound", "0.0"
                    "cegtag", "dgunprojectile"
                    "commandfire", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.6"
                    "energypershot", "500.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "noexplode", "true"
                    "soundhitvolume", "36.0"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 30.0)
              metalMake = Some (ValueOrExpr.Concrete 2.0)
              energyStorage = Some 500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "47 10 47"
                collisionVolumeType = Some "CylY"
                damage = Some 10000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2000.0
                object_ = Some "Units/armcom_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 5000.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 1000.0
                object_ = Some "Units/arm2X2F.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
              select = ["armcomsel"] })
          customParams = Map.ofList [
              "i18nfromunit", "armcom"
              "iscommander", "true"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", ""
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sightemitheight", "40.0"
              "sonardistance", "450.0"
              "upright", "true"
          ] }

    let armcomconToFlat (def: UnitDef) : Armcomcon =
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
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armcomconToUnitDef (flat: Armcomcon) : UnitDef =
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
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Armcomnew =
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
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let armcomnew : Armcomnew =
        { name = "armcomnew"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = None
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOM_lus.lua"
          corpse = Some "DEAD"
          explodeAs = Some "newcommanderexplo"
          selfDestructAs = Some "newcommanderexplo"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1148.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 300.0
          buildDistance = 145.0
          buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "armmex"; "armmakr"; "armlab"; "armvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 30.0
          metalMake = ValueOrExpr.Concrete 2.0
          energyStorage = 500.0
          metalStorage = 500.0
          weapons = [
                { name = "armcomlaser"
                  displayName = "Light close-quarters g2g/g2a laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 75.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "7.7"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "armcomsealaser"
                  displayName = "Light underwater-combat laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-blue"
                  rgbColor = Some "0.2 0.2 0.6"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.4"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "impactonly", "1.0"
                      "intensity", "0.3"
                      "laserflaresize", "7.7"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 36.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 20000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2"
                  explosiongenerator = Some "custom:expldgun"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cegtag", "dgunprojectile"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.15"
                      "energypershot", "500.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "noexplode", "true"
                      "soundhitvolume", "36.0"
                      "soundhitwet", "sizzlexs"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "CylY"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 1250.0
                  object_ = Some "Units/armcom_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 500.0
                  object_ = Some "Units/arm2X2F.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath1"
                repair = Some "repair1"
                working = Some "reclaim1"
                underAttack = Some "warning2"
                cancelDestruct = Some "cancel2"
                capture = Some "capture1"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
                select = ["armcomsel"] }
          customParams = Map.ofList [
                "iscommander", "true"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", ""
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "mincloakdistance", "50.0"
                "movestate", "0.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sightemitheight", "40.0"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    let armcomnewDef : UnitDef =
        { name = "armcomnew"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = None
          buildPic = Some "ARMCOM.DDS"
          script = Some "Units/ARMCOM_lus.lua"
          corpse = Some "DEAD"
          explodeAs = Some "newcommanderexplo"
          selfDestructAs = Some "newcommanderexplo"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1148.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = Some 145.0
              buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "armmex"; "armmakr"; "armlab"; "armvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"]
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armcomlaser"
                displayName = "Light close-quarters g2g/g2a laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 75.0
                    "subs", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "corethickness", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "70.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "armcomsealaser"
                displayName = "Light underwater-combat laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 200.0
                    "subs", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-blue"
                rgbColor = Some "0.2 0.2 0.6"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "corethickness", "0.4"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "35.0"
                    "firesubmersed", "true"
                    "impactonly", "1.0"
                    "intensity", "0.3"
                    "laserflaresize", "7.7"
                    "rgbcolor2", "0.2 0.2 0.2"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "5.0"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                ]
                range = Some (ValueOrExpr.Concrete 250.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 300.0
                areaOfEffect = Some 36.0
                accuracy = None
                turret = Some true
                tolerance = Some 20000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "disigun1"
                soundHit = Some "xplomas2"
                explosiongenerator = Some "custom:expldgun"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "bouncerebound", "0.0"
                    "cegtag", "dgunprojectile"
                    "commandfire", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.15"
                    "energypershot", "500.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "noexplode", "true"
                    "soundhitvolume", "36.0"
                    "soundhitwet", "sizzlexs"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 30.0)
              metalMake = Some (ValueOrExpr.Concrete 2.0)
              energyStorage = Some 500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "CylY"
                damage = Some 10000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 1250.0
                object_ = Some "Units/armcom_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 5000.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 500.0
                object_ = Some "Units/arm2X2F.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath1"
              repair = Some "repair1"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture1"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["armcom1"; "armcom2"; "armcom3"; "armcom4"]
              select = ["armcomsel"] })
          customParams = Map.ofList [
              "iscommander", "true"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", ""
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "mincloakdistance", "50.0"
              "movestate", "0.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sightemitheight", "40.0"
              "sonardistance", "450.0"
              "upright", "true"
          ] }

    let armcomnewToFlat (def: UnitDef) : Armcomnew =
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
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let armcomnewToUnitDef (flat: Armcomnew) : UnitDef =
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
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corassistdrone_land =
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
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corassistdrone_land : Corassistdrone_land =
        { name = "corassistdrone_land"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 150.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/corassistdrone_land.s3o"
          buildPic = Some "CORMUSKRAT.DDS"
          script = Some "Units/CORMUSKRAT.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 -1 1"
          collisionVolumeScales = Some "11 8 21"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 1.0
          maxDec = 1.0
          turnRate = 1000.0
          movementClass = "ATANK3"
          maxSlope = 16.0
          maxWaterDepth = 255.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          turnInPlaceSpeedLimit = 0.9504
          workerTime = ValueOrExpr.Expr "100*Spring.GetModOptions().assistdronesbuildpowermultiplier"
          buildDistance = 150.0
          buildOptions = ["corsolar"; "corwin"; "cormstor"; "corestor"; "cormex"; "cormakr"; "corlab"; "corvp"; "corap"; "coreyes"; "corrad"; "cordrag"; "corllt"; "corrl"; "cordl"; "cortide"; "coruwms"; "coruwes"; "corfmkr"; "corsy"; "corfdrag"; "cortl"; "corfrt"; "corfrad"; "corhp"; "corfhp"]
          terraformSpeed = 400.0
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
                "unitgroup", "builder"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "CorVehicles"
            ]
          extras = Map.ofList [
                "cancapture", "true"
                "leavetracks", "true"
                "trackoffset", "8.0"
                "trackstrength", "5.0"
                "tracktype", "corwidetracks"
                "trackwidth", "12.0"
            ] }

    let corassistdrone_landDef : UnitDef =
        { name = "corassistdrone_land"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 1.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 500.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 150.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/corassistdrone_land.s3o"
          buildPic = Some "CORMUSKRAT.DDS"
          script = Some "Units/CORMUSKRAT.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 -1 1"
          collisionVolumeScales = Some "11 8 21"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 1.0
              maxDec = 1.0
              turnRate = 1000.0
              movementClass = Some "ATANK3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 255.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.9504
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Expr "100*Spring.GetModOptions().assistdronesbuildpowermultiplier"
              buildDistance = Some 150.0
              buildOptions = ["corsolar"; "corwin"; "cormstor"; "corestor"; "cormex"; "cormakr"; "corlab"; "corvp"; "corap"; "coreyes"; "corrad"; "cordrag"; "corllt"; "corrl"; "cordl"; "cortide"; "coruwms"; "coruwes"; "corfmkr"; "corsy"; "corfdrag"; "cortl"; "corfrt"; "corfrad"; "corhp"; "corfhp"]
              terraformSpeed = Some 400.0 })
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
              "unitgroup", "builder"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorVehicles"
          ]
          extras = Map.ofList [
              "cancapture", "true"
              "leavetracks", "true"
              "trackoffset", "8.0"
              "trackstrength", "5.0"
              "tracktype", "corwidetracks"
              "trackwidth", "12.0"
          ] }

    let corassistdrone_landToFlat (def: UnitDef) : Corassistdrone_land =
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
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corassistdrone_landToUnitDef (flat: Corassistdrone_land) : UnitDef =
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
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
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
          economy = None
          building = None
          featureDefs = None
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcom =
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
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corcom : Corcom =
        { name = "corcom"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORCOM.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1133.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 300.0
          buildDistance = 145.0
          buildOptions = ["corsolar"; "corwin"; "cormstor"; "corestor"; "cormex"; "cormakr"; "corlab"; "corvp"; "corap"; "coreyes"; "corrad"; "cordrag"; "corllt"; "corrl"; "cordl"; "cortide"; "coruwms"; "coruwes"; "corfmkr"; "corsy"; "corfdrag"; "cortl"; "corfrt"; "corfrad"; "corhp"; "corfhp"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 30.0
          metalMake = ValueOrExpr.Concrete 2.0
          energyStorage = 500.0
          metalStorage = 500.0
          weapons = [
                { name = "corcomlaser"
                  displayName = "J7Laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 75.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_fastautoretargeting", "true"
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.5"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "corcomsealaser"
                  displayName = "J7NSLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-blue"
                  rgbColor = Some "0.2 0.2 0.6"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "impactonly", "1.0"
                      "intensity", "0.3"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "commanders", 0.0
                      "default", 99999.0
                      "scavboss", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 262.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 36.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2s"
                  explosiongenerator = Some "custom:expldgun"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cegtag", "dgunprojectile"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.15"
                      "energypershot", "500.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "noexplode", "true"
                      "soundhitvolume", "36.0"
                      "soundhitwet", "sizzlexs"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 1250.0
                  object_ = Some "Units/corcom_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 500.0
                  object_ = Some "Units/cor2X2C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning2"
                cancelDestruct = Some "cancel2"
                capture = Some "capture2"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
                select = ["corcomsel"] }
          customParams = Map.ofList [
                "iscommander", "true"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", ""
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "mincloakdistance", "50.0"
                "movestate", "0.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sightemitheight", "40.0"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    let corcomDef : UnitDef =
        { name = "corcom"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORCOM.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1133.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = Some 145.0
              buildOptions = ["corsolar"; "corwin"; "cormstor"; "corestor"; "cormex"; "cormakr"; "corlab"; "corvp"; "corap"; "coreyes"; "corrad"; "cordrag"; "corllt"; "corrl"; "cordl"; "cortide"; "coruwms"; "coruwes"; "corfmkr"; "corsy"; "corfdrag"; "cortl"; "corfrt"; "corfrad"; "corhp"; "corfhp"]
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "corcomlaser"
                displayName = "J7Laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 75.0
                    "subs", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "corethickness", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "70.0"
                    "impactonly", "1.0"
                    "laserflaresize", "5.5"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "corcomsealaser"
                displayName = "J7NSLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 200.0
                    "subs", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-blue"
                rgbColor = Some "0.2 0.2 0.6"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "corethickness", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "35.0"
                    "firesubmersed", "true"
                    "impactonly", "1.0"
                    "intensity", "0.3"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "0.2 0.2 0.2"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "5.0"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "commanders", 0.0
                    "default", 99999.0
                    "scavboss", 1000.0
                ]
                range = Some (ValueOrExpr.Concrete 262.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 300.0
                areaOfEffect = Some 36.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "disigun1"
                soundHit = Some "xplomas2s"
                explosiongenerator = Some "custom:expldgun"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "bouncerebound", "0.0"
                    "cegtag", "dgunprojectile"
                    "commandfire", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.15"
                    "energypershot", "500.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "noexplode", "true"
                    "soundhitvolume", "36.0"
                    "soundhitwet", "sizzlexs"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 30.0)
              metalMake = Some (ValueOrExpr.Concrete 2.0)
              energyStorage = Some 500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 10000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 1250.0
                object_ = Some "Units/corcom_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 5000.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 500.0
                object_ = Some "Units/cor2X2C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
              select = ["corcomsel"] })
          customParams = Map.ofList [
              "iscommander", "true"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", ""
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "mincloakdistance", "50.0"
              "movestate", "0.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sightemitheight", "40.0"
              "sonardistance", "450.0"
              "upright", "true"
          ] }

    let corcomToFlat (def: UnitDef) : Corcom =
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
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcomToUnitDef (flat: Corcom) : UnitDef =
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
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

    type Corcomcon =
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
          turnInPlaceAngleLimit: float
          turnInPlaceSpeedLimit: float
          workerTime: ValueOrExpr<float>
          buildDistance: float
          buildOptions: string list
          terraformSpeed: float
          energyMake: ValueOrExpr<float>
          metalMake: ValueOrExpr<float>
          energyStorage: float
          metalStorage: float
          weapons: WeaponDef list
          featureDefs: Map<string, FeatureDef>
          sounds: SoundDef
          customParams: Map<string, string>
          extras: Map<string, string> }

    let corcomcon : Corcomcon =
        { name = "corcomcon"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOM.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 37.5
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1133.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 300.0
          buildDistance = 145.0
          buildOptions = ["cornecro"; "corca"; "corck"; "corch"; "corcsa"; "corcs"; "corcv"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 30.0
          metalMake = ValueOrExpr.Concrete 2.0
          energyStorage = 500.0
          metalStorage = 500.0
          weapons = [
                { name = "corcomlaser"
                  displayName = "J7Laser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 75.0
                      "subs", 5.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "lasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-red"
                  rgbColor = Some "1 0 0"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "beamtime", "0.1"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "70.0"
                      "impactonly", "1.0"
                      "laserflaresize", "5.5"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "2.0"
                  ] }
                { name = "corcomsealaser"
                  displayName = "J7NSLaser"
                  weaponType = Some "BeamLaser"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.0)
                  weaponVelocity = Some 900.0
                  areaOfEffect = Some 12.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 1.0
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "uwlasrfir1"
                  soundHit = None
                  explosiongenerator = Some "custom:laserhit-small-blue"
                  rgbColor = Some "0.2 0.2 0.6"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "beamtime", "0.3"
                      "corethickness", "0.1"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "cylindertargeting", "1.0"
                      "firestarter", "35.0"
                      "firesubmersed", "true"
                      "impactonly", "1.0"
                      "intensity", "0.3"
                      "laserflaresize", "5.5"
                      "rgbcolor2", "0.2 0.2 0.2"
                      "soundhitdry", ""
                      "soundhitwet", "sizzle"
                      "soundtrigger", "1.0"
                      "thickness", "5.0"
                      "waterweapon", "true"
                  ] }
                { name = "disintegrator"
                  displayName = "Disintegrator"
                  weaponType = Some "DGun"
                  damage = Map.ofList [
                      "default", 99999.0
                      "scavboss", 1000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 250.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.9)
                  weaponVelocity = Some 300.0
                  areaOfEffect = Some 36.0
                  accuracy = None
                  turret = Some true
                  tolerance = Some 10000.0
                  edgeEffectiveness = Some 0.15
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "disigun1"
                  soundHit = Some "xplomas2s"
                  explosiongenerator = Some "custom:expldgun"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "avoidfriendly", "false"
                      "avoidground", "false"
                      "bouncerebound", "0.0"
                      "cegtag", "dgunprojectile"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.6"
                      "energypershot", "500.0"
                      "firestarter", "100.0"
                      "firesubmersed", "false"
                      "noexplode", "true"
                      "soundhitvolume", "36.0"
                      "soundhitwet", "sizzle"
                      "soundstartvolume", "96.0"
                      "soundtrigger", "true"
                      "waterweapon", "true"
                      "weapontimer", "4.2"
                  ] }
            ]
          featureDefs = Map.ofList [
                "dead",
                { blocking = Some true
                  category = Some "corpses"
                  collisionVolumeOffsets = Some "0 0 0"
                  collisionVolumeScales = Some "35 12 54"
                  collisionVolumeType = Some "cylY"
                  damage = Some 10000.0
                  featureDead = Some "HEAP"
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 20.0
                  metal = Some 2000.0
                  object_ = Some "Units/corcom_dead.s3o"
                  reclaimable = Some true
                  resurrectable = None }
                "heap",
                { blocking = Some false
                  category = Some "heaps"
                  collisionVolumeOffsets = None
                  collisionVolumeScales = Some "35.0 4.0 6.0"
                  collisionVolumeType = Some "cylY"
                  damage = Some 5000.0
                  featureDead = None
                  footprintX = Some 2.0
                  footprintZ = Some 2.0
                  height = Some 4.0
                  metal = Some 1000.0
                  object_ = Some "Units/cor2X2C.s3o"
                  reclaimable = Some true
                  resurrectable = Some 0.0 }
            ]
          sounds =
              { build = Some "nanlath2"
                repair = Some "repair2"
                working = Some "reclaim1"
                underAttack = Some "warning2"
                cancelDestruct = Some "cancel2"
                capture = Some "capture2"
                cant = ["cantdo4"]
                count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
                ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
                select = ["corcomsel"] }
          customParams = Map.ofList [
                "i18nfromunit", "corcom"
                "iscommander", "true"
                "model_author", "Mr Bob"
                "normaltex", "unittextures/cor_normal.dds"
                "paralyzemultiplier", "0.0"
                "subfolder", ""
                "unitgroup", "builder"
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "cancloak", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "cloakcost", "100.0"
                "cloakcostmoving", "1000.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sightemitheight", "40.0"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    let corcomconDef : UnitDef =
        { name = "corcomcon"
          subfolder = "Root"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORCOM.s3o"
          buildPic = Some "CORCOM.DDS"
          script = Some "Units/CORCOM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderexplosion"
          selfDestructAs = Some "commanderExplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.5
              maxAcc = 0.18
              maxDec = 1.125
              turnRate = 1133.0
              movementClass = Some "COMMANDERBOT"
              maxSlope = Some 20.0
              maxWaterDepth = Some 35.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 140.0
              turnInPlaceSpeedLimit = Some 0.825
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 300.0
              buildDistance = Some 145.0
              buildOptions = ["cornecro"; "corca"; "corck"; "corch"; "corcsa"; "corcs"; "corcv"]
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "corcomlaser"
                displayName = "J7Laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 75.0
                    "subs", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "corethickness", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "70.0"
                    "impactonly", "1.0"
                    "laserflaresize", "5.5"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "corcomsealaser"
                displayName = "J7NSLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 200.0
                    "subs", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "uwlasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-blue"
                rgbColor = Some "0.2 0.2 0.6"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "corethickness", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "35.0"
                    "firesubmersed", "true"
                    "impactonly", "1.0"
                    "intensity", "0.3"
                    "laserflaresize", "5.5"
                    "rgbcolor2", "0.2 0.2 0.2"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "5.0"
                    "waterweapon", "true"
                ] }
              { name = "disintegrator"
                displayName = "Disintegrator"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "default", 99999.0
                    "scavboss", 1000.0
                ]
                range = Some (ValueOrExpr.Concrete 250.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 300.0
                areaOfEffect = Some 36.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "disigun1"
                soundHit = Some "xplomas2s"
                explosiongenerator = Some "custom:expldgun"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "bouncerebound", "0.0"
                    "cegtag", "dgunprojectile"
                    "commandfire", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.6"
                    "energypershot", "500.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "noexplode", "true"
                    "soundhitvolume", "36.0"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "96.0"
                    "soundtrigger", "true"
                    "waterweapon", "true"
                    "weapontimer", "4.2"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 30.0)
              metalMake = Some (ValueOrExpr.Concrete 2.0)
              energyStorage = Some 500.0
              metalStorage = Some 500.0
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "35 12 54"
                collisionVolumeType = Some "cylY"
                damage = Some 10000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2000.0
                object_ = Some "Units/corcom_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 5000.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 1000.0
                object_ = Some "Units/cor2X2C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning2"
              cancelDestruct = Some "cancel2"
              capture = Some "capture2"
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["corcom1"; "corcom2"; "corcom3"; "corcom4"; "corcom5"]
              select = ["corcomsel"] })
          customParams = Map.ofList [
              "i18nfromunit", "corcom"
              "iscommander", "true"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", ""
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "cancloak", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "cloakcost", "100.0"
              "cloakcostmoving", "1000.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sightemitheight", "40.0"
              "sonardistance", "450.0"
              "upright", "true"
          ] }

    let corcomconToFlat (def: UnitDef) : Corcomcon =
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
          turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value
          turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value
          workerTime = def.builder.Value.workerTime
          buildDistance = def.builder.Value.buildDistance.Value
          buildOptions = def.builder.Value.buildOptions
          terraformSpeed = def.builder.Value.terraformSpeed.Value
          energyMake = def.economy.Value.energyMake.Value
          metalMake = def.economy.Value.metalMake.Value
          energyStorage = def.economy.Value.energyStorage.Value
          metalStorage = def.economy.Value.metalStorage.Value
          weapons = def.weapons.Value
          featureDefs = def.featureDefs.Value
          sounds = def.sounds.Value
          customParams = def.customParams
          extras = def.extras }

    let corcomconToUnitDef (flat: Corcomcon) : UnitDef =
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
              turnInPlace = None
              turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit
              turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None
            }
          builder = Some {
              workerTime = flat.workerTime
              buildDistance = Some flat.buildDistance
              buildOptions = flat.buildOptions
              terraformSpeed = Some flat.terraformSpeed
            }
          weapons = Some flat.weapons
          economy = Some {
              energyMake = Some flat.energyMake
              metalMake = Some flat.metalMake
              energyStorage = Some flat.energyStorage
              metalStorage = Some flat.metalStorage
              extractsMetal = None
            }
          building = None
          featureDefs = Some flat.featureDefs
          sounds = Some flat.sounds
          customParams = flat.customParams
          extras = flat.extras }

