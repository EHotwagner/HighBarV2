// Auto-generated BAR unit data: other/critters
namespace BarData.V1.Units

open BarData.V1

module other_critters =

    let critter_ant : UnitDef =
        { name = "critter_ant"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Critters/critter_ant.s3o"
          buildPic = Some "critters/critter_ant.DDS"
          script = Some "Critters/critter_ant.cob"
          corpse = None
          explodeAs = Some "MICROBUG_DEATH"
          selfDestructAs = Some "MICROBUG_DEATH"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 18.0
              maxAcc = 0.575
              maxDec = 1.15
              turnRate = 2300.0
              movementClass = Some "SBOT2"
              maxSlope = Some 90.0
              maxWaterDepth = Some 2.0
              canFly = false
              canMove = true
              floater = true
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 6.0 })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "paralyzemultiplier", "0.0"
              "nohealthbars", "true"
              "subfolder", "other/critters"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "cantbetransported", "true"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "10.0"
              "movestate", "-1.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE "
              "reclaimable", "false"
              "selfdestructcountdown", "0.0"
              "smoothanim", "true"
              "sonarstealth", "true"
              "stealth", "true"
              "trackoffset", "0.0"
              "trackstrength", "1.3"
              "trackstretch", "1.0"
              "tracktype", "bigfoot"
              "trackwidth", "7.0"
              "unitname", "critter_ant"
              "upright", "false"
          ] }

    let critter_crab : UnitDef =
        { name = "critter_crab"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 44.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Critters/critter_crab.s3o"
          buildPic = Some "critters/critter_crab.dds"
          script = Some "Critters/critter_crab.lua"
          corpse = None
          explodeAs = Some "SMALLBUG_DEATH"
          selfDestructAs = None
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 13.5
              maxAcc = 0.1
              maxDec = 0.01
              turnRate = 500.0
              movementClass = Some "ABOT3"
              maxSlope = Some 65.0
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
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "paralyzemultiplier", "0.0"
              "nohealthbars", "true"
              "subfolder", "other/critters"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "cantbetransported", "true"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "false"
              "maneuverleashlength", "640"
              "mass", "24.0"
              "movestate", "-1.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE "
              "reclaimable", "false"
              "selfdestructcountdown", "0.0"
              "smoothanim", "true"
              "sonarstealth", "true"
              "stealth", "true"
              "trackoffset", "0.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "trackwidth", "10.0"
              "unitname", "critter_crab"
              "upright", "false"
          ] }

    let critter_duck : UnitDef =
        { name = "critter_duck"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 17.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Critters/critter_duck.s3o"
          buildPic = Some "critters/critter_duck.DDS"
          script = Some "Critters/critter_duck.lua"
          corpse = None
          explodeAs = Some "SMALLBUG_DEATH"
          selfDestructAs = None
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 10.5
              maxAcc = 0.12
              maxDec = 1.0
              turnRate = 500.0
              movementClass = Some "SBOT2"
              maxSlope = Some 45.0
              maxWaterDepth = Some 22.0
              canFly = false
              canMove = true
              floater = true
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 6.0 })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "paralyzemultiplier", "0.0"
              "nohealthbars", "true"
              "subfolder", "other/critters"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "cantbetransported", "true"
              "capturable", "false"
              "defaultmissiontype", "Standby"
              "leavetracks", "false"
              "maneuverleashlength", "640"
              "mass", "24.0"
              "movestate", "-1.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE "
              "reclaimable", "false"
              "selfdestructcountdown", "0.0"
              "smoothanim", "true"
              "sonarstealth", "true"
              "stealth", "true"
              "trackoffset", "0.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "trackwidth", "10.0"
              "unitname", "critter_duck"
              "upright", "false"
          ] }

    let critter_goldfish : UnitDef =
        { name = "critter_goldfish"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 600.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Critters/critter_goldfish.s3o"
          buildPic = Some "critters/critter_goldfish.DDS"
          script = Some "Critters/critter_goldfish.lua"
          corpse = None
          explodeAs = Some "MICROBUG_DEATH"
          selfDestructAs = None
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 18.0
              maxAcc = 0.123
              maxDec = 0.123
              turnRate = 4500.0
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
              waterline = Some 20.0 })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "paralyzemultiplier", "0.0"
              "nohealthbars", "true"
              "subfolder", "other/critters"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "true"
              "cantbetransported", "true"
              "capturable", "false"
              "mass", "1.0"
              "mincloakdistance", "75.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE "
              "reclaimable", "false"
              "selfdestructcountdown", "0.0"
              "sonardistance", "550.0"
              "sonarstealth", "true"
              "stealth", "true"
              "unitname", "critter_goldfish"
              "upright", "true"
          ] }

    let critter_gull : UnitDef =
        { name = "critter_gull"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 0.0
          energyCost = ValueOrExpr.Concrete 1.0
          buildTime = ValueOrExpr.Concrete 10.0
          health = ValueOrExpr.Concrete 11.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Critters/critter_gull.s3o"
          buildPic = Some "critters/critter_gull.DDS"
          script = Some "Critters/critter_gull.lua"
          corpse = None
          explodeAs = Some "MICROBUG_DEATH"
          selfDestructAs = None
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 54.0
              maxAcc = 0.2
              maxDec = 3.75
              turnRate = 500.0
              movementClass = None
              maxSlope = None
              maxWaterDepth = None
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 200.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "paralyzemultiplier", "0.0"
              "nohealthbars", "true"
              "subfolder", "other/critters"
              "crashable", "0.0"
          ]
          extras = Map.ofList [
              "airstrafe", "false"
              "bankscale", "1.0"
              "blocking", "false"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "cantbetransported", "true"
              "capturable", "false"
              "collide", "false"
              "collision", "false"
              "hoverattack", "true"
              "mass", "125.0"
              "maxbank", "0.2"
              "maxpitch", "0.2"
              "reclaimable", "false"
              "selfdestructcountdown", "0.0"
              "sonarstealth", "true"
              "stealth", "true"
              "turnradius", "5.0"
              "upright", "false"
          ] }

    let critter_penguin : UnitDef =
        { name = "critter_penguin"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 15.0
          energyCost = ValueOrExpr.Concrete 200.0
          buildTime = ValueOrExpr.Concrete 250.0
          health = ValueOrExpr.Concrete 167.0
          sightDistance = ValueOrExpr.Concrete 0.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Critters/critter_penguin.s3o"
          buildPic = Some "critters/critter_penguin.DDS"
          script = Some "Critters/critter_penguin.lua"
          corpse = None
          explodeAs = Some "MICROBUG_DEATH"
          selfDestructAs = Some "MICROBUG_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "8 15 8"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 15.0
              maxAcc = 0.15
              maxDec = 1.0
              turnRate = 2000.0
              movementClass = Some "SBOT2"
              maxSlope = Some 45.0
              maxWaterDepth = Some 22.0
              canFly = false
              canMove = true
              floater = true
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 6.0 })
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "paralyzemultiplier", "0.0"
              "subfolder", "other/critters"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "cantbetransported", "true"
              "capturable", "false"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "24.0"
              "movestate", "-1.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE "
              "reclaimable", "false"
              "selfdestructcountdown", "0.0"
              "smoothanim", "true"
              "sonarstealth", "true"
              "stealth", "true"
              "trackoffset", "0.0"
              "trackstrength", "3.0"
              "trackstretch", "1.0"
              "tracktype", "bigfoot"
              "trackwidth", "6.0"
              "unitname", "critter_penguin"
              "upright", "false"
          ] }

    let critter_penguinbro : UnitDef =
        { name = "critter_penguinbro"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 1500.0
          energyCost = ValueOrExpr.Concrete 15000.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 280.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Critters/critter_penguinbro.s3o"
          buildPic = Some "critters/critter_penguin.DDS"
          script = Some "Critters/critter_penguin.lua"
          corpse = None
          explodeAs = Some "TINYBUG_DEATH"
          selfDestructAs = Some "TINYBUG_DEATH"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "15 32 15"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 22.5
              maxAcc = 0.15
              maxDec = 1.0
              turnRate = 2000.0
              movementClass = Some "SBOT2"
              maxSlope = Some 45.0
              maxWaterDepth = Some 22.0
              canFly = false
              canMove = true
              floater = true
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 6.0 })
          builder = None
          weapons = Some [
              { name = "eyelaser"
                displayName = Some "LightLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 70.0
                    "vtol", 7.0
                ]
                range = Some (ValueOrExpr.Concrete 266.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.2)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some false
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-tiny-red"
                rgbColor = Some "1 0 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", ""
                    "avoidfeature", "false"
                    "beamtime", "0.2"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "100.0"
                    "impactonly", "1.0"
                    "laserflaresize", "3.146"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "1.25"
                ] }
              { name = "eyelaser"
                displayName = Some "LightLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 70.0
                    "vtol", 7.0
                ]
                range = Some (ValueOrExpr.Concrete 266.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.2)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some false
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-tiny-red"
                rgbColor = Some "1 0 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", ""
                    "avoidfeature", "false"
                    "beamtime", "0.2"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "100.0"
                    "impactonly", "1.0"
                    "laserflaresize", "3.146"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "1.25"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/critters"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "cantbetransported", "true"
              "capturable", "false"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "66.0"
              "movestate", "-1.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE "
              "reclaimable", "false"
              "selfdestructcountdown", "0.0"
              "smoothanim", "true"
              "sonarstealth", "true"
              "stealth", "true"
              "trackoffset", "0.0"
              "trackstrength", "4.0"
              "trackstretch", "1.0"
              "tracktype", "bigfoot"
              "trackwidth", "10.0"
              "unitname", "critter_penguinbro"
              "upright", "false"
          ] }

    let critter_penguinking : UnitDef =
        { name = "critter_penguinking"
          subfolder = "other/critters"
          metalCost = ValueOrExpr.Concrete 20000.0
          energyCost = ValueOrExpr.Concrete 400000.0
          buildTime = ValueOrExpr.Concrete 35000.0
          health = ValueOrExpr.Concrete 56000.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Critters/critter_penguinking.s3o"
          buildPic = Some "critters/critter_penguin.DDS"
          script = Some "Critters/critter_penguin.lua"
          corpse = None
          explodeAs = Some "BIGBUG_DEATH"
          selfDestructAs = Some "BIGBUG_DEATH"
          collisionVolumeOffsets = Some "0 6 0"
          collisionVolumeScales = Some "50 107 50"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 25.5
              maxAcc = 0.15
              maxDec = 1.0
              turnRate = 2000.0
              movementClass = Some "SBOT2"
              maxSlope = Some 45.0
              maxWaterDepth = Some 22.0
              canFly = false
              canMove = true
              floater = true
              turnInPlace = None
              turnInPlaceAngleLimit = None
              turnInPlaceSpeedLimit = None
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 6.0 })
          builder = None
          weapons = Some [
              { name = "eyelaser"
                displayName = Some "LightLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 750.0
                    "default", 2000.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.5)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some false
                tolerance = Some 9500.0
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrhvy3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-red"
                rgbColor = Some "1 0 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", ""
                    "avoidfeature", "false"
                    "beamtime", "1.0"
                    "corethickness", "0.33"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "100.0"
                    "impactonly", "1.0"
                    "laserflaresize", "3.146"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "5.5"
                ] }
              { name = "eyelaser"
                displayName = Some "LightLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 750.0
                    "default", 2000.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.5)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some false
                tolerance = Some 9500.0
                edgeEffectiveness = Some 0.3
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrhvy3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-red"
                rgbColor = Some "1 0 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", ""
                    "avoidfeature", "false"
                    "beamtime", "1.0"
                    "corethickness", "0.33"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "100.0"
                    "impactonly", "1.0"
                    "laserflaresize", "3.146"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "5.5"
                ] }
          ]
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "other/critters"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1"
              "cantbetransported", "true"
              "capturable", "false"
              "leavetracks", "true"
              "maneuverleashlength", "640"
              "mass", "1000.0"
              "movestate", "-1.0"
              "noautofire", "false"
              "nochasecategory", "MOBILE "
              "reclaimable", "false"
              "selfdestructcountdown", "5.0"
              "smoothanim", "true"
              "sonarstealth", "true"
              "stealth", "true"
              "trackoffset", "0.0"
              "trackstrength", "8.0"
              "trackstretch", "1.0"
              "tracktype", "bigfoot"
              "trackwidth", "22.0"
              "unitname", "critter_penguinking"
              "upright", "false"
          ] }

    let all : (string * UnitDef) list =
        [
            "critter_ant", critter_ant
            "critter_crab", critter_crab
            "critter_duck", critter_duck
            "critter_goldfish", critter_goldfish
            "critter_gull", critter_gull
            "critter_penguin", critter_penguin
            "critter_penguinbro", critter_penguinbro
            "critter_penguinking", critter_penguinking
        ]
