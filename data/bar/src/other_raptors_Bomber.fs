// Auto-generated BAR unit data: other/raptors/Bomber
namespace BarData.Units

open BarData

module other_raptors_Bomber =

    let raptor_air_bomber_basic_t1_v1 : UnitDef =
        { name = "raptor_air_bomber_basic_t1_v1"
          subfolder = "other/raptors/Bomber"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 85.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorf1_mini.s3o"
          buildPic = Some "raptors/raptorf1_mini.DDS"
          script = Some "Raptors/raptorf1.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "35 35 35"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 240.0
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
              { name = "bloodyeggs"
                displayName = Some "GooBombs"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 720.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = None
                areaOfEffect = Some 128.0
                accuracy = Some 10000.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:blood_explode_xl"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "1.0"
                    "burstrate", "0.1"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/raptoregg_s_darkgreen.s3o"
                    "mygravity", "0.5"
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
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "acceleration", "0.8"
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
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptor_air_bomber_basic_t1_v1"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
          ] }

    let raptor_air_bomber_basic_t2_v1 : UnitDef =
        { name = "raptor_air_bomber_basic_t2_v1"
          subfolder = "other/raptors/Bomber"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 350.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorf1.s3o"
          buildPic = Some "raptors/raptorf1.DDS"
          script = Some "Raptors/raptorf1.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "70 70 70"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 240.0
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
              { name = "bloodyeggs"
                displayName = Some "GooBombs"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 1440.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = None
                areaOfEffect = Some 128.0
                accuracy = Some 10000.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:blood_explode_xl"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "4.0"
                    "burstrate", "0.1"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/raptoregg_m_darkgreen.s3o"
                    "mygravity", "0.5"
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
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "acceleration", "0.8"
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
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptor_air_bomber_basic_t2_v1"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
          ] }

    let raptor_air_bomber_basic_t2_v2 : UnitDef =
        { name = "raptor_air_bomber_basic_t2_v2"
          subfolder = "other/raptors/Bomber"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 450.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorf1b.s3o"
          buildPic = Some "raptors/raptorf1b.DDS"
          script = Some "Raptors/raptorf1b.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "65 65 65"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 180.0
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
              { name = "bloodyeggs"
                displayName = Some "GooBombs"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 1680.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = None
                areaOfEffect = Some 150.0
                accuracy = Some 10000.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:blood_explode_xl"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "3.0"
                    "burstrate", "0.2"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/raptoregg_m_darkgreen.s3o"
                    "mygravity", "0.5"
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
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "acceleration", "0.8"
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
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptor_air_bomber_basic_t2_v2"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
          ] }

    let raptor_air_bomber_basic_t4_v1 : UnitDef =
        { name = "raptor_air_bomber_basic_t4_v1"
          subfolder = "other/raptors/Bomber"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 1500.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorf1apex.s3o"
          buildPic = Some "raptors/raptorf1.DDS"
          script = Some "Raptors/raptorf1.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "70 70 70"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 240.0
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
              { name = "bloodyeggs"
                displayName = Some "GooBombs"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 4320.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = None
                areaOfEffect = Some 128.0
                accuracy = Some 10000.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:blood_explode_xl"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "7.0"
                    "burstrate", "0.2"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/raptoregg_l_darkgreen.s3o"
                    "mygravity", "0.5"
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
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "acceleration", "0.8"
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
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptorf1"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
          ] }

    let raptor_air_bomber_basic_t4_v2 : UnitDef =
        { name = "raptor_air_bomber_basic_t4_v2"
          subfolder = "other/raptors/Bomber"
          metalCost = ValueOrExpr.Concrete 212.0
          energyCost = ValueOrExpr.Concrete 4550.0
          buildTime = ValueOrExpr.Concrete 9375.0
          health = ValueOrExpr.Concrete 1700.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Raptors/raptorf1apexb.s3o"
          buildPic = Some "raptors/raptorf1b.DDS"
          script = Some "Raptors/raptorf1b.cob"
          corpse = None
          explodeAs = Some "TALON_DEATH"
          selfDestructAs = Some "TALON_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "70 70 70"
          collisionVolumeType = Some "sphere"
          seismicSignature = Some 0.0
          category = Some "RAPTOR"
          movement = Some (
            { speed = ValueOrExpr.Concrete 180.0
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
              { name = "bloodyeggs"
                displayName = Some "GooBombs"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 4320.0
                ]
                range = Some (ValueOrExpr.Concrete 1500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.1)
                weaponVelocity = None
                areaOfEffect = Some 150.0
                accuracy = Some 10000.0
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "alien_bombrel"
                soundHit = Some "bloodsplash3"
                explosiongenerator = Some "custom:blood_explode_xl"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "collidefriendly", "0.0"
                    "collidefeature", "0.0"
                    "avoidfeature", "0.0"
                    "avoidfriendly", "0.0"
                    "burst", "6.0"
                    "burstrate", "0.1"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "interceptedbyshieldtype", "0.0"
                    "model", "Raptors/raptoregg_l_darkgreen.s3o"
                    "mygravity", "0.5"
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
              "normaltex", "unittextures/chicken_l_normals.png"
          ]
          extras = Map.ofList [
              "acceleration", "0.8"
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
              "side", "THUNDERBIRDS"
              "smoothanim", "true"
              "speedtofront", "0.07"
              "turnradius", "64.0"
              "unitname", "raptorf1b"
              "usesmoothmesh", "true"
              "wingangle", "0.06593"
              "wingdrag", "0.835"
          ] }

    let all : (string * UnitDef) list =
        [
            "raptor_air_bomber_basic_t1_v1", raptor_air_bomber_basic_t1_v1
            "raptor_air_bomber_basic_t2_v1", raptor_air_bomber_basic_t2_v1
            "raptor_air_bomber_basic_t2_v2", raptor_air_bomber_basic_t2_v2
            "raptor_air_bomber_basic_t4_v1", raptor_air_bomber_basic_t4_v1
            "raptor_air_bomber_basic_t4_v2", raptor_air_bomber_basic_t4_v2
        ]
