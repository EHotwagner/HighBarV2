// Auto-generated BAR unit data: other/raptors/Acid (unified)
namespace BarData.Units

open BarData

module other_raptors_Acid =

    type Raptor_air_bomber_acid_t2_v1 =
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
          canFly: bool
          canMove: bool
          turnInPlace: bool
          cruiseAltitude: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_air_bomber_acid_t2_v1 : Raptor_air_bomber_acid_t2_v1 =
        { name = "raptor_air_bomber_acid_t2_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 50.0
          energyCost = ValueOrExpr.Concrete 50.0
          buildTime = ValueOrExpr.Concrete 6000.0
          health = ValueOrExpr.Concrete 835.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptoracidbomber.s3o"
          buildPic = Some "raptors/raptoracidbomber.DDS"
          script = Some "Raptors/raptorf2.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "70 14 48"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 210.0
          maxAcc = 0.25
          maxDec = 0.1
          turnRate = 1600.0
          canFly = true
          canMove = true
          turnInPlace = true
          cruiseAltitude = 220.0
          weapons = [
                { name = "acidbomb"
                  displayName = "GooBombs"
                  weaponType = Some "AircraftBomb"
                  damage = Map.ofList [
                      "default", 1.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 0.5)
                  weaponVelocity = None
                  areaOfEffect = Some 75.0
                  accuracy = Some 10000.0
                  turret = None
                  tolerance = None
                  edgeEffectiveness = Some 0.3
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "bloodsplash3"
                  explosiongenerator = Some "custom:acid-explosion-xl"
                  rgbColor = None
                  customParams = Map.ofList [
                      "area_onhit_ceg", "acid-area-150-repeat"
                      "area_onhit_damageCeg", "acid-damage-gen"
                      "area_onhit_resistance", "_RAPTORACID_"
                  ]
                  extras = Map.ofList [
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "8.0"
                      "burstrate", "0.1"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "interceptedbyshieldtype", "0.0"
                      "model", "Raptors/raptoregg_l_green.s3o"
                      "mygravity", "0.5"
                      "paralyzetime", "20.0"
                      "sprayangle", "20000.0"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_m_normals.png"
            ]
          extras = Map.ofList [
                "acceleration", "1.0"
                "airhoverfactor", "0.0"
                "attackrunlength", "32.0"
                "canattack", "true"
                "canguard", "true"
                "canland", "true"
                "canloopbackattack", "true"
                "canpatrol", "true"
                "canstop", "1"
                "cansubmerge", "true"
                "capturable", "false"
                "collide", "true"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "maneuverleashlength", "20000"
                "mass", "227.5"
                "maxaileron", "0.025"
                "maxbank", "0.8"
                "maxelevator", "0.025"
                "maxpitch", "0.75"
                "maxrudder", "0.025"
                "moverate1", "32"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "radardistance", "500.0"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "speedtofront", "0.07"
                "turnradius", "64.0"
                "unitname", "raptorebomber1"
                "usesmoothmesh", "true"
                "wingangle", "0.06593"
                "wingdrag", "0.835"
            ] }

    let raptor_air_bomber_acid_t2_v1Def : UnitDef =
        { name = "raptor_air_bomber_acid_t2_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 50.0
          energyCost = ValueOrExpr.Concrete 50.0
          buildTime = ValueOrExpr.Concrete 6000.0
          health = ValueOrExpr.Concrete 835.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptoracidbomber.s3o"
          buildPic = Some "raptors/raptoracidbomber.DDS"
          script = Some "Raptors/raptorf2.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "70 14 48"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 210.0
              maxAcc = 0.25
              maxDec = 0.1
              turnRate = 1600.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = true
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "acidbomb"
                displayName = "GooBombs"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
                weaponVelocity = None
                areaOfEffect = Some 75.0
                accuracy = Some 10000.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:acid-explosion-xl"
                rgbColor = None
                customParams = Map.ofList [
                    "area_onhit_ceg", "acid-area-150-repeat"
                    "area_onhit_damageCeg", "acid-damage-gen"
                    "area_onhit_resistance", "_RAPTORACID_"
                ]
                extras = Map.ofList [
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "8.0"
                    "burstrate", "0.1"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/raptoregg_l_green.s3o"
                    "mygravity", "0.5"
                    "paralyzetime", "20.0"
                    "sprayangle", "20000.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_m_normals.png"
          ]
          extras = Map.ofList [
              "acceleration", "1.0"
              "airhoverfactor", "0.0"
              "attackrunlength", "32.0"
              "canattack", "true"
              "canguard", "true"
              "canland", "true"
              "canloopbackattack", "true"
              "canpatrol", "true"
              "canstop", "1"
              "cansubmerge", "true"
              "capturable", "false"
              "collide", "true"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "maneuverleashlength", "20000"
              "mass", "227.5"
              "maxaileron", "0.025"
              "maxbank", "0.8"
              "maxelevator", "0.025"
              "maxpitch", "0.75"
              "maxrudder", "0.025"
              "moverate1", "32"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "radardistance", "500.0"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptorebomber1"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
          ] }

    let raptor_air_bomber_acid_t2_v1ToFlat (def: UnitDef) : Raptor_air_bomber_acid_t2_v1 =
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
          canFly = def.movement.Value.canFly
          canMove = def.movement.Value.canMove
          turnInPlace = def.movement.Value.turnInPlace.Value
          cruiseAltitude = def.movement.Value.cruiseAltitude.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_air_bomber_acid_t2_v1ToUnitDef (flat: Raptor_air_bomber_acid_t2_v1) : UnitDef =
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
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Raptor_allterrain_arty_acid_t2_v1 =
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
          waterline: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_allterrain_arty_acid_t2_v1 : Raptor_allterrain_arty_acid_t2_v1 =
        { name = "raptor_allterrain_arty_acid_t2_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 396.0
          energyCost = ValueOrExpr.Concrete 12320.0
          buildTime = ValueOrExpr.Concrete 6750.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptor_artillery_acid_v2.s3o"
          buildPic = Some "raptors/raptoracidarty.DDS"
          script = Some "Raptors/raptor_artillery_v2.cob"
          corpse = None
          explodeAs = Some "LOBBER_MORPH"
          selfDestructAs = Some "LOBBER_MORPH"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "25 34 44"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 42.0
          maxAcc = 0.115
          maxDec = 0.414
          turnRate = 1840.0
          movementClass = "RAPTORALLTERRAINBIGHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 10.0
          weapons = [
                { name = "acidspit"
                  displayName = "GOOLAUNCHER"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 1.0
                      "shields", 320.0
                  ]
                  range = Some (ValueOrExpr.Concrete 1500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 20.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 150.0
                  accuracy = Some 1024.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "bloodsplash3"
                  explosiongenerator = Some "custom:acid-explosion-xl"
                  rgbColor = Some "0.8 0.99 0.11"
                  customParams = Map.ofList [
                      "area_onhit_ceg", "acid-area-150-repeat"
                      "area_onhit_damageCeg", "acid-damage-gen"
                      "area_onhit_resistance", "_RAPTORACID_"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "50.0"
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "1.0"
                      "burstrate", "0.001"
                      "cegtag", "blob_trail_green"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "nogap", "false"
                      "size", "9.0"
                      "sizedecay", "0.04"
                      "alphaDecay", "0.18"
                      "stages", "8.0"
                      "proximitypriority", "-1.0"
                      "sprayangle", "1024.0"
                      "weapontimer", "0.2"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
                "area_ondeath_ceg", "acid-area-150-repeat"
                "area_ondeath_damageCeg", "acid-damage-gen"
                "area_ondeath_time", "10.0"
                "area_ondeath_damage", "100.0"
                "area_ondeath_range", "150.0"
                "area_ondeath_resistance", "_RAPTORACID_"
            ]
          extras = Map.ofList [
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "4000.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "6.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "30.0"
                "unitname", "raptorearty1"
                "upright", "false"
            ] }

    let raptor_allterrain_arty_acid_t2_v1Def : UnitDef =
        { name = "raptor_allterrain_arty_acid_t2_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 396.0
          energyCost = ValueOrExpr.Concrete 12320.0
          buildTime = ValueOrExpr.Concrete 6750.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptor_artillery_acid_v2.s3o"
          buildPic = Some "raptors/raptoracidarty.DDS"
          script = Some "Raptors/raptor_artillery_v2.cob"
          corpse = None
          explodeAs = Some "LOBBER_MORPH"
          selfDestructAs = Some "LOBBER_MORPH"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "25 34 44"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 42.0
              maxAcc = 0.115
              maxDec = 0.414
              turnRate = 1840.0
              movementClass = Some "RAPTORALLTERRAINBIGHOVER"
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
              waterline = Some 10.0 })
          builder = None
          weapons = Some [
              { name = "acidspit"
                displayName = "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1.0
                    "shields", 320.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 20.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 150.0
                accuracy = Some 1024.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:acid-explosion-xl"
                rgbColor = Some "0.8 0.99 0.11"
                customParams = Map.ofList [
                    "area_onhit_ceg", "acid-area-150-repeat"
                    "area_onhit_damageCeg", "acid-damage-gen"
                    "area_onhit_resistance", "_RAPTORACID_"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "50.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "1.0"
                    "burstrate", "0.001"
                    "cegtag", "blob_trail_green"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "nogap", "false"
                    "size", "9.0"
                    "sizedecay", "0.04"
                    "alphaDecay", "0.18"
                    "stages", "8.0"
                    "proximitypriority", "-1.0"
                    "sprayangle", "1024.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
              "area_ondeath_ceg", "acid-area-150-repeat"
              "area_ondeath_damageCeg", "acid-damage-gen"
              "area_ondeath_time", "10.0"
              "area_ondeath_damage", "100.0"
              "area_ondeath_range", "150.0"
              "area_ondeath_resistance", "_RAPTORACID_"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "4000.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "6.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "30.0"
              "unitname", "raptorearty1"
              "upright", "false"
          ] }

    let raptor_allterrain_arty_acid_t2_v1ToFlat (def: UnitDef) : Raptor_allterrain_arty_acid_t2_v1 =
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
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_allterrain_arty_acid_t2_v1ToUnitDef (flat: Raptor_allterrain_arty_acid_t2_v1) : UnitDef =
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
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Raptor_allterrain_arty_acid_t4_v1 =
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
          waterline: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_allterrain_arty_acid_t4_v1 : Raptor_allterrain_arty_acid_t4_v1 =
        { name = "raptor_allterrain_arty_acid_t4_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 396.0
          energyCost = ValueOrExpr.Concrete 12320.0
          buildTime = ValueOrExpr.Concrete 6750.0
          health = ValueOrExpr.Concrete 8000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptor_artillery_meteor_v2_acid.s3o"
          buildPic = Some "raptors/raptoracidartyxl.DDS"
          script = Some "Raptors/raptor_artillery_v2.cob"
          corpse = None
          explodeAs = Some "LOBBER_MORPH"
          selfDestructAs = Some "LOBBER_MORPH"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "60 34 80"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 84.0
          maxAcc = 0.115
          maxDec = 0.414
          turnRate = 1840.0
          movementClass = "RAPTORALLTERRAINBIGHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 10.0
          weapons = [
                { name = "acidspit"
                  displayName = "GOOLAUNCHER"
                  weaponType = Some "Cannon"
                  damage = Map.ofList [
                      "default", 1.0
                      "shields", 320.0
                  ]
                  range = Some (ValueOrExpr.Concrete 2000.0)
                  reloadTime = Some (ValueOrExpr.Concrete 20.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 150.0
                  accuracy = Some 2048.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.0
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "bloodsplash3"
                  explosiongenerator = Some "custom:acid-explosion-xl"
                  rgbColor = Some "0.8 0.99 0.11"
                  customParams = Map.ofList [
                      "area_onhit_ceg", "acid-area-150-repeat"
                      "area_onhit_damageCeg", "acid-damage-gen"
                      "area_onhit_resistance", "_RAPTORACID_"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "MOBILE"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "50.0"
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "4.0"
                      "burstrate", "0.001"
                      "cegtag", "blob_trail_green"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "nogap", "false"
                      "size", "9.0"
                      "sizedecay", "0.04"
                      "alphaDecay", "0.18"
                      "stages", "8.0"
                      "proximitypriority", "-1.0"
                      "sprayangle", "2048.0"
                      "weapontimer", "0.2"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
                "area_ondeath_ceg", "acid-area-150-repeat"
                "area_ondeath_damageCeg", "acid-damage-gen"
                "area_ondeath_time", "10.0"
                "area_ondeath_damage", "100.0"
                "area_ondeath_range", "150.0"
                "area_ondeath_resistance", "_RAPTORACID_"
            ]
          extras = Map.ofList [
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "hidedamage", "1.0"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "4000.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "6.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "30.0"
                "unitname", "raptor_allterrain_arty_acid_t4_v1"
                "upright", "false"
            ] }

    let raptor_allterrain_arty_acid_t4_v1Def : UnitDef =
        { name = "raptor_allterrain_arty_acid_t4_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 396.0
          energyCost = ValueOrExpr.Concrete 12320.0
          buildTime = ValueOrExpr.Concrete 6750.0
          health = ValueOrExpr.Concrete 8000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptor_artillery_meteor_v2_acid.s3o"
          buildPic = Some "raptors/raptoracidartyxl.DDS"
          script = Some "Raptors/raptor_artillery_v2.cob"
          corpse = None
          explodeAs = Some "LOBBER_MORPH"
          selfDestructAs = Some "LOBBER_MORPH"
          collisionVolumeOffsets = Some "0 1 0"
          collisionVolumeScales = Some "60 34 80"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 84.0
              maxAcc = 0.115
              maxDec = 0.414
              turnRate = 1840.0
              movementClass = Some "RAPTORALLTERRAINBIGHOVER"
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
              waterline = Some 10.0 })
          builder = None
          weapons = Some [
              { name = "acidspit"
                displayName = "GOOLAUNCHER"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 1.0
                    "shields", 320.0
                ]
                range = Some (ValueOrExpr.Concrete 2000.0)
                reloadTime = Some (ValueOrExpr.Concrete 20.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 150.0
                accuracy = Some 2048.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:acid-explosion-xl"
                rgbColor = Some "0.8 0.99 0.11"
                customParams = Map.ofList [
                    "area_onhit_ceg", "acid-area-150-repeat"
                    "area_onhit_damageCeg", "acid-damage-gen"
                    "area_onhit_resistance", "_RAPTORACID_"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "50.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "4.0"
                    "burstrate", "0.001"
                    "cegtag", "blob_trail_green"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "nogap", "false"
                    "size", "9.0"
                    "sizedecay", "0.04"
                    "alphaDecay", "0.18"
                    "stages", "8.0"
                    "proximitypriority", "-1.0"
                    "sprayangle", "2048.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
              "area_ondeath_ceg", "acid-area-150-repeat"
              "area_ondeath_damageCeg", "acid-damage-gen"
              "area_ondeath_time", "10.0"
              "area_ondeath_damage", "100.0"
              "area_ondeath_range", "150.0"
              "area_ondeath_resistance", "_RAPTORACID_"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "hidedamage", "1.0"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "4000.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "6.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "30.0"
              "unitname", "raptor_allterrain_arty_acid_t4_v1"
              "upright", "false"
          ] }

    let raptor_allterrain_arty_acid_t4_v1ToFlat (def: UnitDef) : Raptor_allterrain_arty_acid_t4_v1 =
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
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_allterrain_arty_acid_t4_v1ToUnitDef (flat: Raptor_allterrain_arty_acid_t4_v1) : UnitDef =
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
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Raptor_allterrain_assault_acid_t2_v1 =
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
          waterline: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_allterrain_assault_acid_t2_v1 : Raptor_allterrain_assault_acid_t2_v1 =
        { name = "raptor_allterrain_assault_acid_t2_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 152.0
          energyCost = ValueOrExpr.Concrete 3520.0
          buildTime = ValueOrExpr.Concrete 9000.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptoracidallterrainassault.s3o"
          buildPic = Some "raptors/raptoracidallterrainassault.DDS"
          script = Some "Raptors/raptorallterraina1.cob"
          corpse = None
          explodeAs = Some "BIGBUG_DEATH_ACID"
          selfDestructAs = Some "BIGBUG_DEATH_ACID"
          collisionVolumeOffsets = Some "0 2 0"
          collisionVolumeScales = Some "27 38 60"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 33.75
          maxAcc = 0.414
          maxDec = 0.46
          turnRate = 920.0
          movementClass = "RAPTORALLTERRAINBIGHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 24.0
          weapons = [
                { name = "acidspit"
                  displayName = "GOOLAUNCHER"
                  weaponType = None
                  damage = Map.ofList [
                      "default", 1.0
                      "shields", 160.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.6)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 150.0
                  accuracy = Some 1024.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "bloodsplash3"
                  explosiongenerator = Some "custom:acid-explosion-xl"
                  rgbColor = Some "0.8 0.99 0.11"
                  customParams = Map.ofList [
                      "area_onhit_ceg", "acid-area-150-repeat"
                      "area_onhit_damageCeg", "acid-damage-gen"
                      "area_onhit_resistance", "_RAPTORACID_"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "125.0"
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "2.0"
                      "burstrate", "0.5"
                      "cegtag", "blob_trail_green"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "nogap", "false"
                      "size", "8.0"
                      "sizedecay", "0.03"
                      "alphaDecay", "0.14"
                      "stages", "9.0"
                      "sprayangle", "92.0"
                      "weapontimer", "0.2"
                  ] }
            ]
          customParams = Map.ofList [
                "maxrange", "200"
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_l_normals.png"
                "paralyzemultiplier", "0.0"
            ]
          extras = Map.ofList [
                "airsightdistance", "650.0"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "1500.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "7.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "34.0"
                "unitname", "raptore2"
                "upright", "false"
            ] }

    let raptor_allterrain_assault_acid_t2_v1Def : UnitDef =
        { name = "raptor_allterrain_assault_acid_t2_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 152.0
          energyCost = ValueOrExpr.Concrete 3520.0
          buildTime = ValueOrExpr.Concrete 9000.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptoracidallterrainassault.s3o"
          buildPic = Some "raptors/raptoracidallterrainassault.DDS"
          script = Some "Raptors/raptorallterraina1.cob"
          corpse = None
          explodeAs = Some "BIGBUG_DEATH_ACID"
          selfDestructAs = Some "BIGBUG_DEATH_ACID"
          collisionVolumeOffsets = Some "0 2 0"
          collisionVolumeScales = Some "27 38 60"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 33.75
              maxAcc = 0.414
              maxDec = 0.46
              turnRate = 920.0
              movementClass = Some "RAPTORALLTERRAINBIGHOVER"
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
              waterline = Some 24.0 })
          builder = None
          weapons = Some [
              { name = "acidspit"
                displayName = "GOOLAUNCHER"
                weaponType = None
                damage = Map.ofList [
                    "default", 1.0
                    "shields", 160.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.6)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 150.0
                accuracy = Some 1024.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:acid-explosion-xl"
                rgbColor = Some "0.8 0.99 0.11"
                customParams = Map.ofList [
                    "area_onhit_ceg", "acid-area-150-repeat"
                    "area_onhit_damageCeg", "acid-damage-gen"
                    "area_onhit_resistance", "_RAPTORACID_"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "125.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "2.0"
                    "burstrate", "0.5"
                    "cegtag", "blob_trail_green"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "nogap", "false"
                    "size", "8.0"
                    "sizedecay", "0.03"
                    "alphaDecay", "0.14"
                    "stages", "9.0"
                    "sprayangle", "92.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "maxrange", "200"
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "paralyzemultiplier", "0.0"
          ]
          extras = Map.ofList [
              "airsightdistance", "650.0"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "1500.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "7.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "34.0"
              "unitname", "raptore2"
              "upright", "false"
          ] }

    let raptor_allterrain_assault_acid_t2_v1ToFlat (def: UnitDef) : Raptor_allterrain_assault_acid_t2_v1 =
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
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_allterrain_assault_acid_t2_v1ToUnitDef (flat: Raptor_allterrain_assault_acid_t2_v1) : UnitDef =
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
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Raptor_allterrain_swarmer_acid_t2_v1 =
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
          waterline: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_allterrain_swarmer_acid_t2_v1 : Raptor_allterrain_swarmer_acid_t2_v1 =
        { name = "raptor_allterrain_swarmer_acid_t2_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 5280.0
          buildTime = ValueOrExpr.Concrete 2250.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptoracidallterrain.s3o"
          buildPic = Some "raptors/raptoracidallterrain.DDS"
          script = Some "Raptors/raptorc3.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH_ACID"
          selfDestructAs = Some "BIGBUG_DEATH_ACID"
          collisionVolumeOffsets = Some "0 -3 -3"
          collisionVolumeScales = Some "18 28 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 97.5
          maxAcc = 1.4375
          maxDec = 2.3
          turnRate = 1840.0
          movementClass = "RAPTORALLTERRAINHOVER"
          maxSlope = 18.0
          maxWaterDepth = 15.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 12.0
          weapons = [
                { name = "acidspit"
                  displayName = "GOOLAUNCHER"
                  weaponType = None
                  damage = Map.ofList [
                      "default", 1.0
                      "shields", 80.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 75.0
                  accuracy = Some 1024.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "bloodsplash3"
                  explosiongenerator = Some "custom:acid-explosion-small"
                  rgbColor = Some "0.8 0.99 0.11"
                  customParams = Map.ofList [
                      "area_onhit_ceg", "acid-area-75-repeat"
                      "area_onhit_damageCeg", "acid-damage-gen"
                      "area_onhit_resistance", "_RAPTORACID_"
                  ]
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "110.0"
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "2.0"
                      "burstrate", "0.3"
                      "cegtag", "blob_trail_green"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "nogap", "false"
                      "size", "7.0"
                      "sizedecay", "0.05"
                      "alphaDecay", "0.15"
                      "stages", "7.0"
                      "sprayangle", "128.0"
                      "weapontimer", "0.2"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
                "area_ondeath_ceg", "acid-area-75-repeat"
                "area_ondeath_damageCeg", "acid-damage-gen"
                "area_ondeath_time", "10.0"
                "area_ondeath_damage", "40.0"
                "area_ondeath_range", "75.0"
                "area_ondeath_resistance", "_RAPTORACID_"
            ]
          extras = Map.ofList [
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "89.0"
                "maxreversevelocity", "3.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "sonardistance", "450.0"
                "trackoffset", "0.5"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrackPointy"
                "trackwidth", "35.0"
                "unitname", "raptorc3"
                "upright", "false"
            ] }

    let raptor_allterrain_swarmer_acid_t2_v1Def : UnitDef =
        { name = "raptor_allterrain_swarmer_acid_t2_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 99.0
          energyCost = ValueOrExpr.Concrete 5280.0
          buildTime = ValueOrExpr.Concrete 2250.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Raptors/raptoracidallterrain.s3o"
          buildPic = Some "raptors/raptoracidallterrain.DDS"
          script = Some "Raptors/raptorc3.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH_ACID"
          selfDestructAs = Some "BIGBUG_DEATH_ACID"
          collisionVolumeOffsets = Some "0 -3 -3"
          collisionVolumeScales = Some "18 28 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 97.5
              maxAcc = 1.4375
              maxDec = 2.3
              turnRate = 1840.0
              movementClass = Some "RAPTORALLTERRAINHOVER"
              maxSlope = Some 18.0
              maxWaterDepth = Some 15.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 12.0 })
          builder = None
          weapons = Some [
              { name = "acidspit"
                displayName = "GOOLAUNCHER"
                weaponType = None
                damage = Map.ofList [
                    "default", 1.0
                    "shields", 80.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 75.0
                accuracy = Some 1024.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:acid-explosion-small"
                rgbColor = Some "0.8 0.99 0.11"
                customParams = Map.ofList [
                    "area_onhit_ceg", "acid-area-75-repeat"
                    "area_onhit_damageCeg", "acid-damage-gen"
                    "area_onhit_resistance", "_RAPTORACID_"
                ]
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "110.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "2.0"
                    "burstrate", "0.3"
                    "cegtag", "blob_trail_green"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "nogap", "false"
                    "size", "7.0"
                    "sizedecay", "0.05"
                    "alphaDecay", "0.15"
                    "stages", "7.0"
                    "sprayangle", "128.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
              "area_ondeath_ceg", "acid-area-75-repeat"
              "area_ondeath_damageCeg", "acid-damage-gen"
              "area_ondeath_time", "10.0"
              "area_ondeath_damage", "40.0"
              "area_ondeath_range", "75.0"
              "area_ondeath_resistance", "_RAPTORACID_"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "89.0"
              "maxreversevelocity", "3.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "sonardistance", "450.0"
              "trackoffset", "0.5"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrackPointy"
              "trackwidth", "35.0"
              "unitname", "raptorc3"
              "upright", "false"
          ] }

    let raptor_allterrain_swarmer_acid_t2_v1ToFlat (def: UnitDef) : Raptor_allterrain_swarmer_acid_t2_v1 =
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
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_allterrain_swarmer_acid_t2_v1ToUnitDef (flat: Raptor_allterrain_swarmer_acid_t2_v1) : UnitDef =
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
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Raptor_land_assault_acid_t2_v1 =
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
          waterline: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_assault_acid_t2_v1 : Raptor_land_assault_acid_t2_v1 =
        { name = "raptor_land_assault_acid_t2_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 152.0
          energyCost = ValueOrExpr.Concrete 3520.0
          buildTime = ValueOrExpr.Concrete 9000.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptoracidassault.s3o"
          buildPic = Some "raptors/raptoracidassault.DDS"
          script = Some "Raptors/raptora1.cob"
          corpse = None
          explodeAs = Some "BIGBUG_DEATH_ACID"
          selfDestructAs = Some "BIGBUG_DEATH_ACID"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "27 48 60"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 33.75
          maxAcc = 0.414
          maxDec = 0.46
          turnRate = 920.0
          movementClass = "RAPTORBIGHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 20.0
          weapons = [
                { name = "acidspit"
                  displayName = "GOOLAUNCHER"
                  weaponType = None
                  damage = Map.ofList [
                      "default", 1.0
                      "shields", 160.0
                  ]
                  range = Some (ValueOrExpr.Concrete 500.0)
                  reloadTime = Some (ValueOrExpr.Concrete 3.6)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 150.0
                  accuracy = Some 1024.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "bloodsplash3"
                  explosiongenerator = Some "custom:acid-explosion-xl"
                  rgbColor = Some "0.8 0.99 0.11"
                  customParams = Map.ofList [
                      "area_onhit_ceg", "acid-area-150-repeat"
                      "area_onhit_damageCeg", "acid-damage-gen"
                      "area_onhit_resistance", "_RAPTORACID_"
                  ]
                  extras = Map.ofList [
                      "mount_badtargetcategory", "VTOL"
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "125.0"
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "2.0"
                      "burstrate", "0.5"
                      "cegtag", "blob_trail_green"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "nogap", "false"
                      "size", "8.0"
                      "sizedecay", "0.03"
                      "alphaDecay", "0.14"
                      "stages", "9.0"
                      "sprayangle", "92.0"
                      "weapontimer", "0.2"
                  ] }
            ]
          customParams = Map.ofList [
                "maxrange", "200"
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_l_normals.png"
                "paralyzemultiplier", "0.0"
                "area_ondeath_ceg", "acid-area-150-repeat"
                "area_ondeath_damageCeg", "acid-damage-gen"
                "area_ondeath_time", "10.0"
                "area_ondeath_damage", "100.0"
                "area_ondeath_range", "150.0"
                "area_ondeath_resistance", "_RAPTORACID_"
            ]
          extras = Map.ofList [
                "airsightdistance", "650.0"
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "640"
                "mass", "1500.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "7.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "34.0"
                "unitname", "raptore2"
                "upright", "false"
            ] }

    let raptor_land_assault_acid_t2_v1Def : UnitDef =
        { name = "raptor_land_assault_acid_t2_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 152.0
          energyCost = ValueOrExpr.Concrete 3520.0
          buildTime = ValueOrExpr.Concrete 9000.0
          health = ValueOrExpr.Concrete 11100.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptoracidassault.s3o"
          buildPic = Some "raptors/raptoracidassault.DDS"
          script = Some "Raptors/raptora1.cob"
          corpse = None
          explodeAs = Some "BIGBUG_DEATH_ACID"
          selfDestructAs = Some "BIGBUG_DEATH_ACID"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "27 48 60"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 33.75
              maxAcc = 0.414
              maxDec = 0.46
              turnRate = 920.0
              movementClass = Some "RAPTORBIGHOVER"
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
              waterline = Some 20.0 })
          builder = None
          weapons = Some [
              { name = "acidspit"
                displayName = "GOOLAUNCHER"
                weaponType = None
                damage = Map.ofList [
                    "default", 1.0
                    "shields", 160.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.6)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 150.0
                accuracy = Some 1024.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:acid-explosion-xl"
                rgbColor = Some "0.8 0.99 0.11"
                customParams = Map.ofList [
                    "area_onhit_ceg", "acid-area-150-repeat"
                    "area_onhit_damageCeg", "acid-damage-gen"
                    "area_onhit_resistance", "_RAPTORACID_"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "125.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "2.0"
                    "burstrate", "0.5"
                    "cegtag", "blob_trail_green"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "nogap", "false"
                    "size", "8.0"
                    "sizedecay", "0.03"
                    "alphaDecay", "0.14"
                    "stages", "9.0"
                    "sprayangle", "92.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "maxrange", "200"
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_l_normals.png"
              "paralyzemultiplier", "0.0"
              "area_ondeath_ceg", "acid-area-150-repeat"
              "area_ondeath_damageCeg", "acid-damage-gen"
              "area_ondeath_time", "10.0"
              "area_ondeath_damage", "100.0"
              "area_ondeath_range", "150.0"
              "area_ondeath_resistance", "_RAPTORACID_"
          ]
          extras = Map.ofList [
              "airsightdistance", "650.0"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "1500.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "7.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "34.0"
              "unitname", "raptore2"
              "upright", "false"
          ] }

    let raptor_land_assault_acid_t2_v1ToFlat (def: UnitDef) : Raptor_land_assault_acid_t2_v1 =
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
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_land_assault_acid_t2_v1ToUnitDef (flat: Raptor_land_assault_acid_t2_v1) : UnitDef =
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
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Raptor_land_swarmer_acids_t2_v1 =
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
          waterline: float
          weapons: WeaponDef list
          customParams: Map<string, string>
          extras: Map<string, string> }

    let raptor_land_swarmer_acids_t2_v1 : Raptor_land_swarmer_acids_t2_v1 =
        { name = "raptor_land_swarmer_acids_t2_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 53.0
          buildTime = ValueOrExpr.Concrete 900.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 1.5
          footprintZ = 1.5
          objectName = Some "Raptors/raptoracidswarmer.s3o"
          buildPic = Some "raptors/raptoracidswarmer.DDS"
          script = Some "Raptors/raptor1.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH_ACID"
          selfDestructAs = Some "BUG_DEATH_ACID"
          collisionVolumeOffsets = Some "0 -3 -3"
          collisionVolumeScales = Some "18 40 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          speed = ValueOrExpr.Concrete 81.0
          maxAcc = 0.1725
          maxDec = 0.345
          turnRate = 1840.0
          movementClass = "RAPTORSMALLHOVER"
          maxSlope = 18.0
          maxWaterDepth = 0.0
          canMove = true
          turnInPlace = true
          turnInPlaceAngleLimit = 90.0
          waterline = 16.0
          weapons = [
                { name = "acidspit"
                  displayName = "GOOLAUNCHER"
                  weaponType = None
                  damage = Map.ofList [
                      "default", 1.0
                      "shields", 80.0
                  ]
                  range = Some (ValueOrExpr.Concrete 300.0)
                  reloadTime = Some (ValueOrExpr.Concrete 5.0)
                  weaponVelocity = Some 520.0
                  areaOfEffect = Some 75.0
                  accuracy = Some 1024.0
                  turret = Some true
                  tolerance = Some 5000.0
                  edgeEffectiveness = Some 0.63
                  impulseFactor = Some 0.4
                  noSelfDamage = Some true
                  soundStart = Some "alien_bombrel"
                  soundHit = Some "bloodsplash3"
                  explosiongenerator = Some "custom:acid-explosion-small"
                  rgbColor = Some "0.8 0.99 0.11"
                  customParams = Map.ofList [
                      "area_onhit_ceg", "acid-area-75-repeat"
                      "area_onhit_damageCeg", "acid-damage-gen"
                      "area_onhit_resistance", "_RAPTORACID_"
                  ]
                  extras = Map.ofList [
                      "mount_maindir", "0 0 1"
                      "mount_maxangledif", "180.0"
                      "mount_onlytargetcategory", "NOTAIR"
                      "collidefriendly", "0.0"
                      "collidefeature", "0.0"
                      "avoidfeature", "0.0"
                      "avoidfriendly", "0.0"
                      "burst", "2.0"
                      "burstrate", "0.3"
                      "cegtag", "blob_trail_green"
                      "craterboost", "0.0"
                      "cratermult", "0.0"
                      "intensity", "0.7"
                      "interceptedbyshieldtype", "1.0"
                      "nogap", "false"
                      "size", "7.0"
                      "sizedecay", "0.05"
                      "alphaDecay", "0.15"
                      "stages", "7.0"
                      "sprayangle", "128.0"
                      "weapontimer", "0.2"
                  ] }
            ]
          customParams = Map.ofList [
                "subfolder", "other/raptors"
                "model_author", "KDR_11k, Beherith"
                "normalmaps", "yes"
                "normaltex", "unittextures/chicken_s_normals.png"
                "paralyzemultiplier", "0.0"
                "area_ondeath_ceg", "acid-area-75-repeat"
                "area_ondeath_damageCeg", "acid-damage-gen"
                "area_ondeath_time", "10.0"
                "area_ondeath_damage", "40.0"
                "area_ondeath_range", "75.0"
                "area_ondeath_resistance", "_RAPTORACID_"
            ]
          extras = Map.ofList [
                "canattack", "true"
                "canguard", "true"
                "canpatrol", "true"
                "canstop", "1"
                "capturable", "false"
                "defaultmissiontype", "Standby"
                "leavetracks", "true"
                "maneuverleashlength", "640.0"
                "mass", "30.0"
                "noautofire", "false"
                "nochasecategory", "VTOL"
                "side", "THUNDERBIRDS"
                "smoothanim", "true"
                "trackoffset", "0.0"
                "trackstrength", "3.0"
                "trackstretch", "1.0"
                "tracktype", "RaptorTrack"
                "trackwidth", "18.0"
                "unitname", "raptore1"
                "upright", "false"
            ] }

    let raptor_land_swarmer_acids_t2_v1Def : UnitDef =
        { name = "raptor_land_swarmer_acids_t2_v1"
          subfolder = "other/raptors/Acid"
          metalCost = ValueOrExpr.Concrete 25.0
          energyCost = ValueOrExpr.Concrete 53.0
          buildTime = ValueOrExpr.Concrete 900.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 300.0
          footprintX = 1.5
          footprintZ = 1.5
          objectName = Some "Raptors/raptoracidswarmer.s3o"
          buildPic = Some "raptors/raptoracidswarmer.DDS"
          script = Some "Raptors/raptor1.cob"
          corpse = None
          explodeAs = Some "BUG_DEATH_ACID"
          selfDestructAs = Some "BUG_DEATH_ACID"
          collisionVolumeOffsets = Some "0 -3 -3"
          collisionVolumeScales = Some "18 40 40"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 81.0
              maxAcc = 0.1725
              maxDec = 0.345
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
              waterline = Some 16.0 })
          builder = None
          weapons = Some [
              { name = "acidspit"
                displayName = "GOOLAUNCHER"
                weaponType = None
                damage = Map.ofList [
                    "default", 1.0
                    "shields", 80.0
                ]
                range = Some (ValueOrExpr.Concrete 300.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 75.0
                accuracy = Some 1024.0
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.63
                impulseFactor = Some 0.4
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:acid-explosion-small"
                rgbColor = Some "0.8 0.99 0.11"
                customParams = Map.ofList [
                    "area_onhit_ceg", "acid-area-75-repeat"
                    "area_onhit_damageCeg", "acid-damage-gen"
                    "area_onhit_resistance", "_RAPTORACID_"
                ]
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "NOTAIR"
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "2.0"
                    "burstrate", "0.3"
                    "cegtag", "blob_trail_green"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "intensity", "0.7"
                    "interceptedbyshieldtype", "1.0"
                    "nogap", "false"
                    "size", "7.0"
                    "sizedecay", "0.05"
                    "alphaDecay", "0.15"
                    "stages", "7.0"
                    "sprayangle", "128.0"
                    "weapontimer", "0.2"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/raptors"
              "model_author", "KDR_11k, Beherith"
              "normalmaps", "yes"
              "normaltex", "unittextures/chicken_s_normals.png"
              "paralyzemultiplier", "0.0"
              "area_ondeath_ceg", "acid-area-75-repeat"
              "area_ondeath_damageCeg", "acid-damage-gen"
              "area_ondeath_time", "10.0"
              "area_ondeath_damage", "40.0"
              "area_ondeath_range", "75.0"
              "area_ondeath_resistance", "_RAPTORACID_"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640.0"
              "mass", "30.0"
              "noautofire", "false"
              "nochasecategory", "VTOL"
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "trackoffset", "0.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "RaptorTrack"
              "trackwidth", "18.0"
              "unitname", "raptore1"
              "upright", "false"
          ] }

    let raptor_land_swarmer_acids_t2_v1ToFlat (def: UnitDef) : Raptor_land_swarmer_acids_t2_v1 =
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
          waterline = def.movement.Value.waterline.Value
          weapons = def.weapons.Value
          customParams = def.customParams
          extras = def.extras }

    let raptor_land_swarmer_acids_t2_v1ToUnitDef (flat: Raptor_land_swarmer_acids_t2_v1) : UnitDef =
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
              minWaterDepth = None
              waterline = Some flat.waterline
            }
          builder = None
          weapons = Some flat.weapons
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

