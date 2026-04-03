// Auto-generated BAR unit data: Legion/Other/Commanders (unified)
namespace BarData.Units

open BarData

module Legion_Other_Commanders =

    type Legcomecon =
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

    let legcomecon : Legcomecon =
        { name = "legcomecon"
          subfolder = "Legion/Other/Commanders"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGCOM.s3o"
          buildPic = Some "LEGCOMECON.DDS"
          script = Some "Units/legcom.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 24.99
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1148.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 500.0
          buildDistance = 300.0
          buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "legmex"; "armmakr"; "leglab"; "legvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"; "armadvsol"; "legmext15"; "armnanotc"; "armferret"; "armgeo"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 150.0
          metalMake = ValueOrExpr.Concrete 5.0
          energyStorage = 2500.0
          metalStorage = 1500.0
          weapons = [
                { name = "corlevlr_weapon"
                  displayName = "RiotCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 190.0
                      "subs", 70.0
                      "vtol", 27.0
                  ]
                  range = Some (ValueOrExpr.Concrete 280.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.4)
                  weaponVelocity = Some 550.0
                  areaOfEffect = Some 144.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 1.8
                  noSelfDamage = Some true
                  soundStart = Some "corlevlr"
                  soundHit = Some "corlevlrhit"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "soundhitwet", "splsmed"
                      "soundhitvolume", "11.5"
                      "soundstartvolume", "13.0"
                      "separation", "2.0"
                      "nogap", "false"
                      "sizeDecay", "0.08"
                      "stages", "12.0"
                      "alphaDecay", "0.1"
                  ] }
                { name = "torpedo"
                  displayName = "Level1TorpedoLauncher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 250.0
                      "subs", 125.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.55
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep2"
                  explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "burnblow", "true"
                      "cegtag", "torpedotrail-tiny"
                      "collidefriendly", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "1.8"
                      "model", "cortorpedo.s3o"
                      "predictboost", "1.0"
                      "startvelocity", "230.0"
                      "tracks", "false"
                      "turnrate", "2500.0"
                      "waterweapon", "true"
                      "weaponacceleration", "50.0"
                      "weapontimer", "3.0"
                  ] }
                { name = "disintegrator"
                  displayName = "EMP Grenade"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 10000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 0.0
                  areaOfEffect = Some 200.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.25
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = Some "EMGPULS1"
                  explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "model", "airbomb.s3o"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "soundhitwet", "splslrg"
                  ] }
                { name = "ferret_missile"
                  displayName = "Pop-up rapid-fire g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 150.0
                      "commanders", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.2)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 16.0
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "2.5"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "6.0"
                      "smoketime", "12.0"
                      "smokesize", "4.6"
                      "smokecolor", "0.95"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1200.0"
                      "weapontimer", "2.0"
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
                "unitgroup", "builder"
                "iscommander", "true"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
            ]
          extras = Map.ofList [
                "autoheal", "5.0"
                "cancapture", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "sightemitheight", "40.0"
                "mass", "4999.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    let legcomeconDef : UnitDef =
        { name = "legcomecon"
          subfolder = "Legion/Other/Commanders"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGCOM.s3o"
          buildPic = Some "LEGCOMECON.DDS"
          script = Some "Units/legcom.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 24.99
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
            { workerTime = ValueOrExpr.Concrete 500.0
              buildDistance = Some 300.0
              buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "legmex"; "armmakr"; "leglab"; "legvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"; "armadvsol"; "legmext15"; "armnanotc"; "armferret"; "armgeo"]
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "corlevlr_weapon"
                displayName = "RiotCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 190.0
                    "subs", 70.0
                    "vtol", 27.0
                ]
                range = Some (ValueOrExpr.Concrete 280.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.4)
                weaponVelocity = Some 550.0
                areaOfEffect = Some 144.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 1.8
                noSelfDamage = Some true
                soundStart = Some "corlevlr"
                soundHit = Some "corlevlrhit"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "soundhitwet", "splsmed"
                    "soundhitvolume", "11.5"
                    "soundstartvolume", "13.0"
                    "separation", "2.0"
                    "nogap", "false"
                    "sizeDecay", "0.08"
                    "stages", "12.0"
                    "alphaDecay", "0.1"
                ] }
              { name = "torpedo"
                displayName = "Level1TorpedoLauncher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 250.0
                    "subs", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "cortorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
                ] }
              { name = "disintegrator"
                displayName = "EMP Grenade"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 10000.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 0.0
                areaOfEffect = Some 200.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.25
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "EMGPULS1"
                explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "commandfire", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "airbomb.s3o"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "soundhitwet", "splslrg"
                ] }
              { name = "ferret_missile"
                displayName = "Pop-up rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 150.0
                    "commanders", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 16.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "6.0"
                    "smoketime", "12.0"
                    "smokesize", "4.6"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1200.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 150.0)
              metalMake = Some (ValueOrExpr.Concrete 5.0)
              energyStorage = Some 2500.0
              metalStorage = Some 1500.0
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
              "unitgroup", "builder"
              "iscommander", "true"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
          ]
          extras = Map.ofList [
              "autoheal", "5.0"
              "cancapture", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "sightemitheight", "40.0"
              "mass", "4999.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "450.0"
              "upright", "true"
          ] }

    let legcomeconToFlat (def: UnitDef) : Legcomecon =
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

    let legcomeconToUnitDef (flat: Legcomecon) : UnitDef =
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

    type Legcomoff =
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

    let legcomoff : Legcomoff =
        { name = "legcomoff"
          subfolder = "Legion/Other/Commanders"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGCOMOFF.s3o"
          buildPic = Some "LEGCOMOFF.DDS"
          script = Some "Units/legcomoff.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 42.498
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
          buildDistance = 200.0
          buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "legmex"; "armmakr"; "leglab"; "legvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"; "leggob"; "corjamt"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 25.0
          metalMake = ValueOrExpr.Concrete 2.0
          energyStorage = 500.0
          metalStorage = 500.0
          weapons = [
                { name = "armmg_weapon"
                  displayName = "Rapid-fire a2g machine guns"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 13.0
                      "default", 26.0
                      "vtol", 26.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 950.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 7.0
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "minigun3"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.0675"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.03"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "4.5"
                      "sprayangle", "1200.0"
                      "thickness", "0.91"
                  ] }
                { name = "torpedo"
                  displayName = "Level1TorpedoLauncher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 250.0
                      "subs", 125.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 2.0)
                  weaponVelocity = Some 200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.55
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep2"
                  explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "burnblow", "true"
                      "cegtag", "torpedotrail-tiny"
                      "collidefriendly", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "1.8"
                      "model", "cortorpedo.s3o"
                      "predictboost", "1.0"
                      "startvelocity", "230.0"
                      "tracks", "false"
                      "turnrate", "2500.0"
                      "waterweapon", "true"
                      "weaponacceleration", "50.0"
                      "weapontimer", "3.0"
                  ] }
                { name = "disintegrator"
                  displayName = "EMP Grenade"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 10000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 0.0
                  areaOfEffect = Some 200.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.25
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = Some "EMGPULS1"
                  explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "model", "airbomb.s3o"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "soundhitwet", "splslrg"
                  ] }
                { name = "ferret_missile"
                  displayName = "Pop-up rapid-fire g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 150.0
                      "commanders", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.2)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 16.0
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "2.5"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "6.0"
                      "smoketime", "12.0"
                      "smokesize", "4.6"
                      "smokecolor", "0.95"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1200.0"
                      "weapontimer", "2.0"
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
                "unitgroup", "builder"
                "iscommander", "true"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
            ]
          extras = Map.ofList [
                "autoheal", "10.0"
                "cancapture", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "sightemitheight", "40.0"
                "mass", "4999.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    let legcomoffDef : UnitDef =
        { name = "legcomoff"
          subfolder = "Legion/Other/Commanders"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGCOMOFF.s3o"
          buildPic = Some "LEGCOMOFF.DDS"
          script = Some "Units/legcomoff.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 42.498
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
              buildDistance = Some 200.0
              buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "legmex"; "armmakr"; "leglab"; "legvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"; "leggob"; "corjamt"]
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armmg_weapon"
                displayName = "Rapid-fire a2g machine guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 13.0
                    "default", 26.0
                    "vtol", 26.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 950.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "minigun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.0675"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.03"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "4.5"
                    "sprayangle", "1200.0"
                    "thickness", "0.91"
                ] }
              { name = "torpedo"
                displayName = "Level1TorpedoLauncher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 250.0
                    "subs", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "cortorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
                ] }
              { name = "disintegrator"
                displayName = "EMP Grenade"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 10000.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 0.0
                areaOfEffect = Some 200.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.25
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "EMGPULS1"
                explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "commandfire", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "airbomb.s3o"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "soundhitwet", "splslrg"
                ] }
              { name = "ferret_missile"
                displayName = "Pop-up rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 150.0
                    "commanders", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 16.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "6.0"
                    "smoketime", "12.0"
                    "smokesize", "4.6"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1200.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 25.0)
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
              "unitgroup", "builder"
              "iscommander", "true"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
          ]
          extras = Map.ofList [
              "autoheal", "10.0"
              "cancapture", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "sightemitheight", "40.0"
              "mass", "4999.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "450.0"
              "upright", "true"
          ] }

    let legcomoffToFlat (def: UnitDef) : Legcomoff =
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

    let legcomoffToUnitDef (flat: Legcomoff) : UnitDef =
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

    type Legcomt2com =
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

    let legcomt2com : Legcomt2com =
        { name = "legcomt2com"
          subfolder = "Legion/Other/Commanders"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 6700.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGCOMT2COM.s3o"
          buildPic = Some "LEGCOMT2COM.DDS"
          script = Some "Units/legcomt2com.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 4 0"
          collisionVolumeScales = Some "36 67 36"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 30.0
          maxAcc = 0.12
          maxDec = 0.6
          turnRate = 800.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 400.0
          buildDistance = 200.0
          buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "legmex"; "armmakr"; "leglab"; "legvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"; "leggob"; "corjamt"; "legmg"; "armferret"; "armnanotc"; "legmext15"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 25.0
          metalMake = ValueOrExpr.Concrete 2.0
          energyStorage = 500.0
          metalStorage = 500.0
          weapons = [
                { name = "armmg_weapon"
                  displayName = "Rapid-fire a2g machine guns"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 10.0
                      "default", 20.0
                      "vtol", 20.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.2)
                  weaponVelocity = Some 950.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 7.0
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "minigun3"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.033"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.03"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "4.5"
                      "sprayangle", "1200.0"
                      "thickness", "0.91"
                  ] }
                { name = "torpedo"
                  displayName = "Level1TorpedoLauncher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 250.0
                      "subs", 125.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = Some 200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.55
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep2"
                  explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "burnblow", "true"
                      "cegtag", "torpedotrail-tiny"
                      "collidefriendly", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "1.8"
                      "model", "cortorpedo.s3o"
                      "predictboost", "1.0"
                      "startvelocity", "230.0"
                      "tracks", "false"
                      "turnrate", "2500.0"
                      "waterweapon", "true"
                      "weaponacceleration", "50.0"
                      "weapontimer", "3.0"
                  ] }
                { name = "disintegrator"
                  displayName = "EMP Grenade"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 10000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 0.0
                  areaOfEffect = Some 200.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.25
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = Some "EMGPULS1"
                  explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "model", "airbomb.s3o"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "soundhitwet", "splslrg"
                  ] }
                { name = "ferret_missile"
                  displayName = "Pop-up rapid-fire g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 150.0
                      "commanders", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.8)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 16.0
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "2.5"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "6.0"
                      "smoketime", "12.0"
                      "smokesize", "4.6"
                      "smokecolor", "0.95"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1200.0"
                      "weapontimer", "2.0"
                  ] }
                { name = "adv_rocket"
                  displayName = "Parabolic trajectory g2g multi-rocket launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "default", 200.0
                      "subs", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 600.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.25)
                  weaponVelocity = Some 450.0
                  areaOfEffect = Some 90.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.65
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "rocksalvo"
                  soundHit = Some "rockhit3"
                  explosiongenerator = Some "custom:genericshellexplosion-small-bomb"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "cegtag", "missiletrailsmall-simple"
                      "collidefriendly", "false"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "firestarter", "70.0"
                      "flighttime", "3.0"
                      "model", "cormissile2.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "7.0"
                      "smoketime", "21.0"
                      "smokesize", "6.5"
                      "smokecolor", "0.5"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "true"
                      "soundhitwet", "splssml"
                      "soundtrigger", "true"
                      "startvelocity", "80.0"
                      "targetmoveerror", "0.2"
                      "texture1", "null"
                      "texture2", "smoketrailbar"
                      "trajectoryheight", "1.0"
                      "turnrate", "2000.0"
                      "weaponacceleration", "70.0"
                      "weapontimer", "6.0"
                      "wobble", "2500.0"
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
                "unitgroup", "builder"
                "iscommander", "true"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
            ]
          extras = Map.ofList [
                "autoheal", "15.0"
                "cancapture", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "sightemitheight", "40.0"
                "mass", "10000.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    let legcomt2comDef : UnitDef =
        { name = "legcomt2com"
          subfolder = "Legion/Other/Commanders"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 6700.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGCOMT2COM.s3o"
          buildPic = Some "LEGCOMT2COM.DDS"
          script = Some "Units/legcomt2com.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 4 0"
          collisionVolumeScales = Some "36 67 36"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 30.0
              maxAcc = 0.12
              maxDec = 0.6
              turnRate = 800.0
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
            { workerTime = ValueOrExpr.Concrete 400.0
              buildDistance = Some 200.0
              buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "legmex"; "armmakr"; "leglab"; "legvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"; "leggob"; "corjamt"; "legmg"; "armferret"; "armnanotc"; "legmext15"]
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armmg_weapon"
                displayName = "Rapid-fire a2g machine guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 10.0
                    "default", 20.0
                    "vtol", 20.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.2)
                weaponVelocity = Some 950.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "minigun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.033"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.03"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "4.5"
                    "sprayangle", "1200.0"
                    "thickness", "0.91"
                ] }
              { name = "torpedo"
                displayName = "Level1TorpedoLauncher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 250.0
                    "subs", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "cortorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
                ] }
              { name = "disintegrator"
                displayName = "EMP Grenade"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 10000.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 0.0
                areaOfEffect = Some 200.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.25
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "EMGPULS1"
                explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "commandfire", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "airbomb.s3o"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "soundhitwet", "splslrg"
                ] }
              { name = "ferret_missile"
                displayName = "Pop-up rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 150.0
                    "commanders", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 16.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "6.0"
                    "smoketime", "12.0"
                    "smokesize", "4.6"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1200.0"
                    "weapontimer", "2.0"
                ] }
              { name = "adv_rocket"
                displayName = "Parabolic trajectory g2g multi-rocket launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 200.0
                    "subs", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.25)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 90.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rocksalvo"
                soundHit = Some "rockhit3"
                explosiongenerator = Some "custom:genericshellexplosion-small-bomb"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "missiletrailsmall-simple"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "3.0"
                    "model", "cormissile2.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "7.0"
                    "smoketime", "21.0"
                    "smokesize", "6.5"
                    "smokecolor", "0.5"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "true"
                    "soundhitwet", "splssml"
                    "soundtrigger", "true"
                    "startvelocity", "80.0"
                    "targetmoveerror", "0.2"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "trajectoryheight", "1.0"
                    "turnrate", "2000.0"
                    "weaponacceleration", "70.0"
                    "weapontimer", "6.0"
                    "wobble", "2500.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 25.0)
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
              "unitgroup", "builder"
              "iscommander", "true"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
          ]
          extras = Map.ofList [
              "autoheal", "15.0"
              "cancapture", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "sightemitheight", "40.0"
              "mass", "10000.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "450.0"
              "upright", "true"
          ] }

    let legcomt2comToFlat (def: UnitDef) : Legcomt2com =
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

    let legcomt2comToUnitDef (flat: Legcomt2com) : UnitDef =
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

    type Legcomt2def =
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

    let legcomt2def : Legcomt2def =
        { name = "legcomt2def"
          subfolder = "Legion/Other/Commanders"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGCOM.s3o"
          buildPic = Some "LEGCOMT2DEF.DDS"
          script = Some "Units/legcom.cob"
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
          workerTime = ValueOrExpr.Concrete 500.0
          buildDistance = 300.0
          buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "legmex"; "armmakr"; "leglab"; "legvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"; "legmg"; "armclaw"; "armferret"; "legmext15"; "corjamt"; "armguard"; "armcir"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 150.0
          metalMake = ValueOrExpr.Concrete 5.0
          energyStorage = 2500.0
          metalStorage = 1500.0
          weapons = [
                { name = "corlevlr_weapon"
                  displayName = "RiotCannon"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 190.0
                      "subs", 70.0
                      "vtol", 27.0
                  ]
                  range = Some (ValueOrExpr.Concrete 315.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.8)
                  weaponVelocity = Some 550.0
                  areaOfEffect = Some 144.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.9
                  impulseFactor = Some 1.8
                  noSelfDamage = Some true
                  soundStart = Some "corlevlr"
                  soundHit = Some "corlevlrhit"
                  explosiongenerator = Some "custom:genericshellexplosion-medium"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "SURFACE"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "soundhitwet", "splsmed"
                      "soundhitvolume", "11.5"
                      "soundstartvolume", "13.0"
                      "separation", "2.0"
                      "nogap", "false"
                      "sizeDecay", "0.08"
                      "stages", "12.0"
                      "alphaDecay", "0.1"
                  ] }
                { name = "torpedo"
                  displayName = "Level1TorpedoLauncher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 250.0
                      "subs", 125.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = Some 200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.55
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep2"
                  explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "burnblow", "true"
                      "cegtag", "torpedotrail-tiny"
                      "collidefriendly", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "1.8"
                      "model", "cortorpedo.s3o"
                      "predictboost", "1.0"
                      "startvelocity", "230.0"
                      "tracks", "false"
                      "turnrate", "2500.0"
                      "waterweapon", "true"
                      "weaponacceleration", "50.0"
                      "weapontimer", "3.0"
                  ] }
                { name = "empgrenade"
                  displayName = "EMP Grenade"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 10000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 240.0
                  areaOfEffect = Some 200.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.25
                  impulseFactor = Some 0.001
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = Some "EMGPULS1"
                  explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "model", "airbomb.s3o"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "soundhitwet", "splslrg"
                  ] }
                { name = "ferret_missile"
                  displayName = "Pop-up rapid-fire g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 150.0
                      "commanders", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.8)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 16.0
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "2.5"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "6.0"
                      "smoketime", "12.0"
                      "smokesize", "4.6"
                      "smokecolor", "0.95"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1200.0"
                      "weapontimer", "2.0"
                  ] }
                { name = "repulsor"
                  displayName = "PlasmaRepulsor"
                  weaponType = Some "Shield"
                  damage = Map.ofList [
                      "default", 100.0
                  ]
                  range = Some (ValueOrExpr.Concrete 150.0)
                  reloadTime = None
                  weaponVelocity = None
                  areaOfEffect = None
                  accuracy = None
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.15
                  impulseFactor = None
                  noSelfDamage = None
                  soundStart = None
                  soundHit = None
                  explosiongenerator = None
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "soundhitwet", "sizzle"
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
                "unitgroup", "builder"
                "iscommander", "true"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "shield_color_mult", "0.8"
                "shield_power", "1900.0"
                "shield_radius", "150.0"
            ]
          extras = Map.ofList [
                "autoheal", "10.0"
                "onoffable", "true"
                "cancapture", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "sightemitheight", "40.0"
                "mass", "4999.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    let legcomt2defDef : UnitDef =
        { name = "legcomt2def"
          subfolder = "Legion/Other/Commanders"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGCOM.s3o"
          buildPic = Some "LEGCOMT2DEF.DDS"
          script = Some "Units/legcom.cob"
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
            { workerTime = ValueOrExpr.Concrete 500.0
              buildDistance = Some 300.0
              buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "legmex"; "armmakr"; "leglab"; "legvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"; "legmg"; "armclaw"; "armferret"; "legmext15"; "corjamt"; "armguard"; "armcir"]
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "corlevlr_weapon"
                displayName = "RiotCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 190.0
                    "subs", 70.0
                    "vtol", 27.0
                ]
                range = Some (ValueOrExpr.Concrete 315.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.8)
                weaponVelocity = Some 550.0
                areaOfEffect = Some 144.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 1.8
                noSelfDamage = Some true
                soundStart = Some "corlevlr"
                soundHit = Some "corlevlrhit"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "soundhitwet", "splsmed"
                    "soundhitvolume", "11.5"
                    "soundstartvolume", "13.0"
                    "separation", "2.0"
                    "nogap", "false"
                    "sizeDecay", "0.08"
                    "stages", "12.0"
                    "alphaDecay", "0.1"
                ] }
              { name = "torpedo"
                displayName = "Level1TorpedoLauncher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 250.0
                    "subs", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "cortorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
                ] }
              { name = "empgrenade"
                displayName = "EMP Grenade"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 10000.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 240.0
                areaOfEffect = Some 200.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.25
                impulseFactor = Some 0.001
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "EMGPULS1"
                explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "commandfire", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "airbomb.s3o"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "soundhitwet", "splslrg"
                ] }
              { name = "ferret_missile"
                displayName = "Pop-up rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 150.0
                    "commanders", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 16.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "6.0"
                    "smoketime", "12.0"
                    "smokesize", "4.6"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1200.0"
                    "weapontimer", "2.0"
                ] }
              { name = "repulsor"
                displayName = "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 150.0)
                reloadTime = None
                weaponVelocity = None
                areaOfEffect = None
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = None
                noSelfDamage = None
                soundStart = None
                soundHit = None
                explosiongenerator = None
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "soundhitwet", "sizzle"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 150.0)
              metalMake = Some (ValueOrExpr.Concrete 5.0)
              energyStorage = Some 2500.0
              metalStorage = Some 1500.0
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
              "unitgroup", "builder"
              "iscommander", "true"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "shield_color_mult", "0.8"
              "shield_power", "1900.0"
              "shield_radius", "150.0"
          ]
          extras = Map.ofList [
              "autoheal", "10.0"
              "onoffable", "true"
              "cancapture", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "sightemitheight", "40.0"
              "mass", "4999.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "450.0"
              "upright", "true"
          ] }

    let legcomt2defToFlat (def: UnitDef) : Legcomt2def =
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

    let legcomt2defToUnitDef (flat: Legcomt2def) : UnitDef =
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

    type Legcomt2off =
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

    let legcomt2off : Legcomt2off =
        { name = "legcomt2off"
          subfolder = "Legion/Other/Commanders"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGCOMOFF.s3o"
          buildPic = Some "LEGCOMT2OFF.DDS"
          script = Some "Units/legcomoff.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          speed = ValueOrExpr.Concrete 47.499
          maxAcc = 0.18
          maxDec = 1.125
          turnRate = 1148.0
          movementClass = "COMMANDERBOT"
          maxSlope = 20.0
          maxWaterDepth = 35.0
          canMove = true
          turnInPlaceAngleLimit = 140.0
          turnInPlaceSpeedLimit = 0.825
          workerTime = ValueOrExpr.Concrete 500.0
          buildDistance = 300.0
          buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "legmex"; "armmakr"; "leglab"; "legvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"; "leggob"; "corjamt"; "armmine1"; "armatlas"; "armpeep"; "legmg"; "armferret"; "legbal"; "leggat"; "armnanotc"; "legmext15"; "armadvsol"; "armgeo"]
          terraformSpeed = 1500.0
          energyMake = ValueOrExpr.Concrete 150.0
          metalMake = ValueOrExpr.Concrete 5.0
          energyStorage = 2500.0
          metalStorage = 1500.0
          weapons = [
                { name = "armmg_weapon"
                  displayName = "Rapid-fire a2g machine guns"
                  weaponType = Some "LaserCannon"
                  damage = Map.ofList [
                      "commanders", 13.0
                      "default", 26.0
                      "vtol", 26.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.4)
                  weaponVelocity = Some 950.0
                  areaOfEffect = Some 16.0
                  accuracy = Some 7.0
                  turret = Some true
                  tolerance = Some 6000.0
                  edgeEffectiveness = Some 0.85
                  impulseFactor = Some 1.5
                  noSelfDamage = Some true
                  soundStart = Some "minigun3"
                  soundHit = Some "bimpact3"
                  explosiongenerator = Some "custom:plasmahit-sparkonly"
                  rgbColor = Some "1 0.95 0.4"
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "burst", "6.0"
                      "burstrate", "0.0675"
                      "burnblow", "false"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "duration", "0.03"
                      "fallOffRate", "0.2"
                      "firestarter", "0.0"
                      "intensity", "0.8"
                      "ownerExpAccWeight", "4.0"
                      "proximitypriority", "1.0"
                      "soundhitwet", "splshbig"
                      "soundstartvolume", "4.5"
                      "sprayangle", "1200.0"
                      "thickness", "0.91"
                  ] }
                { name = "torpedo"
                  displayName = "Level1TorpedoLauncher"
                  weaponType = Some "TorpedoLauncher"
                  damage = Map.ofList [
                      "default", 250.0
                      "subs", 125.0
                  ]
                  range = Some (ValueOrExpr.Concrete 400.0)
                  reloadTime = Some (ValueOrExpr.Concrete 1.5)
                  weaponVelocity = Some 200.0
                  areaOfEffect = Some 16.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.55
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "torpedo1"
                  soundHit = Some "xplodep2"
                  explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_onlytargetcategory", "NOTAIR"
                      "avoidfeature", "false"
                      "avoidfriendly", "true"
                      "burnblow", "true"
                      "cegtag", "torpedotrail-tiny"
                      "collidefriendly", "true"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "flighttime", "1.8"
                      "model", "cortorpedo.s3o"
                      "predictboost", "1.0"
                      "startvelocity", "230.0"
                      "tracks", "false"
                      "turnrate", "2500.0"
                      "waterweapon", "true"
                      "weaponacceleration", "50.0"
                      "weapontimer", "3.0"
                  ] }
                { name = "disintegrator"
                  displayName = "EMP Grenade"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 10000.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 8.0)
                  weaponVelocity = Some 0.0
                  areaOfEffect = Some 200.0
                  accuracy = None
                  turret = Some true
                  tolerance = None
                  edgeEffectiveness = Some 0.25
                  impulseFactor = Some 0.123
                  noSelfDamage = Some true
                  soundStart = Some "bombrel"
                  soundHit = Some "EMGPULS1"
                  explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                  rgbColor = None
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_onlytargetcategory", "NOTSUB"
                      "avoidfeature", "false"
                      "commandfire", "true"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "gravityaffected", "true"
                      "model", "airbomb.s3o"
                      "paralyzer", "true"
                      "paralyzetime", "7.0"
                      "soundhitwet", "splslrg"
                  ] }
                { name = "ferret_missile"
                  displayName = "Pop-up rapid-fire g2a missile launcher"
                  weaponType = Some "MissileLauncher"
                  damage = Map.ofList [
                      "vtol", 150.0
                      "commanders", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 450.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.8)
                  weaponVelocity = Some 1000.0
                  areaOfEffect = Some 16.0
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
                  customParams = Map.empty
                  extras = Map.ofList [
                      "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                      "mount_onlytargetcategory", "VTOL"
                      "avoidfeature", "false"
                      "burnblow", "true"
                      "canattackground", "false"
                      "cegtag", "missiletrailaa"
                      "craterareaofeffect", "0.0"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "energypershot", "0.0"
                      "firestarter", "72.0"
                      "flighttime", "2.5"
                      "metalpershot", "0.0"
                      "model", "cormissile.s3o"
                      "smoketrail", "true"
                      "smokePeriod", "6.0"
                      "smoketime", "12.0"
                      "smokesize", "4.6"
                      "smokecolor", "0.95"
                      "smokeTrailCastShadow", "false"
                      "castshadow", "false"
                      "soundhitwet", "splshbig"
                      "soundtrigger", "true"
                      "startvelocity", "1.0"
                      "texture1", "null"
                      "texture2", "smoketrailaa3"
                      "tracks", "true"
                      "turnrate", "68000.0"
                      "weaponacceleration", "1200.0"
                      "weapontimer", "2.0"
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
                "unitgroup", "builder"
                "iscommander", "true"
                "model_author", "FireStorm"
                "normaltex", "unittextures/Arm_normal.dds"
                "paralyzemultiplier", "0.025"
                "subfolder", ""
                "paratrooper", "true"
            ]
          extras = Map.ofList [
                "autoheal", "10.0"
                "cancapture", "true"
                "canmanualfire", "true"
                "capturable", "false"
                "capturespeed", "1800.0"
                "hidedamage", "true"
                "holdsteady", "true"
                "sightemitheight", "40.0"
                "mass", "4999.0"
                "mincloakdistance", "50.0"
                "nochasecategory", "ALL"
                "radardistance", "700.0"
                "radaremitheight", "40.0"
                "radardistancejam", "100.0"
                "reclaimable", "false"
                "releaseheld", "true"
                "selfdestructcountdown", "5.0"
                "showplayername", "true"
                "sonardistance", "450.0"
                "upright", "true"
            ] }

    let legcomt2offDef : UnitDef =
        { name = "legcomt2off"
          subfolder = "Legion/Other/Commanders"
          metalCost = ValueOrExpr.Concrete 2700.0
          energyCost = ValueOrExpr.Concrete 26000.0
          buildTime = ValueOrExpr.Concrete 75000.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGCOMOFF.s3o"
          buildPic = Some "LEGCOMT2OFF.DDS"
          script = Some "Units/legcomoff.cob"
          corpse = Some "DEAD"
          explodeAs = Some "commanderExplosion"
          selfDestructAs = Some "commanderexplosion"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "28 52 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 47.499
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
            { workerTime = ValueOrExpr.Concrete 500.0
              buildDistance = Some 300.0
              buildOptions = ["armsolar"; "armwin"; "armmstor"; "armestor"; "legmex"; "armmakr"; "leglab"; "legvp"; "armap"; "armeyes"; "armrad"; "armdrag"; "armllt"; "armrl"; "armdl"; "armtide"; "armuwms"; "armuwes"; "armfmkr"; "armsy"; "armfdrag"; "armtl"; "armfrt"; "armfrad"; "armhp"; "armfhp"; "leggob"; "corjamt"; "armmine1"; "armatlas"; "armpeep"; "legmg"; "armferret"; "legbal"; "leggat"; "armnanotc"; "legmext15"; "armadvsol"; "armgeo"]
              terraformSpeed = Some 1500.0 })
          weapons = Some [
              { name = "armmg_weapon"
                displayName = "Rapid-fire a2g machine guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 13.0
                    "default", 26.0
                    "vtol", 26.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 950.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "minigun3"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.0675"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.03"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "4.5"
                    "sprayangle", "1200.0"
                    "thickness", "0.91"
                ] }
              { name = "torpedo"
                displayName = "Level1TorpedoLauncher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 250.0
                    "subs", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 200.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-small-uw"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTAIR"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-tiny"
                    "collidefriendly", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.8"
                    "model", "cortorpedo.s3o"
                    "predictboost", "1.0"
                    "startvelocity", "230.0"
                    "tracks", "false"
                    "turnrate", "2500.0"
                    "waterweapon", "true"
                    "weaponacceleration", "50.0"
                    "weapontimer", "3.0"
                ] }
              { name = "disintegrator"
                displayName = "EMP Grenade"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 10000.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 0.0
                areaOfEffect = Some 200.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.25
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "EMGPULS1"
                explosiongenerator = Some "custom:genericshellexplosion-large-lightning"
                rgbColor = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "commandfire", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "airbomb.s3o"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "soundhitwet", "splslrg"
                ] }
              { name = "ferret_missile"
                displayName = "Pop-up rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 150.0
                    "commanders", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 16.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "6.0"
                    "smoketime", "12.0"
                    "smokesize", "4.6"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "1.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "1200.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 150.0)
              metalMake = Some (ValueOrExpr.Concrete 5.0)
              energyStorage = Some 2500.0
              metalStorage = Some 1500.0
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
              "unitgroup", "builder"
              "iscommander", "true"
              "model_author", "FireStorm"
              "normaltex", "unittextures/Arm_normal.dds"
              "paralyzemultiplier", "0.025"
              "subfolder", ""
              "paratrooper", "true"
          ]
          extras = Map.ofList [
              "autoheal", "10.0"
              "cancapture", "true"
              "canmanualfire", "true"
              "capturable", "false"
              "capturespeed", "1800.0"
              "hidedamage", "true"
              "holdsteady", "true"
              "sightemitheight", "40.0"
              "mass", "4999.0"
              "mincloakdistance", "50.0"
              "nochasecategory", "ALL"
              "radardistance", "700.0"
              "radaremitheight", "40.0"
              "radardistancejam", "100.0"
              "reclaimable", "false"
              "releaseheld", "true"
              "selfdestructcountdown", "5.0"
              "showplayername", "true"
              "sonardistance", "450.0"
              "upright", "true"
          ] }

    let legcomt2offToFlat (def: UnitDef) : Legcomt2off =
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

    let legcomt2offToUnitDef (flat: Legcomt2off) : UnitDef =
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

