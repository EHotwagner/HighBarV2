// Auto-generated BAR unit data: other/lootboxes
namespace BarData.Units

open BarData

module other_lootboxes =

    let lootboxbronze : UnitDef =
        { name = "lootboxbronze"
          subfolder = "other/lootboxes"
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

    let lootboxgold : UnitDef =
        { name = "lootboxgold"
          subfolder = "other/lootboxes"
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

    let lootboxplatinum : UnitDef =
        { name = "lootboxplatinum"
          subfolder = "other/lootboxes"
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

    let lootboxsilver : UnitDef =
        { name = "lootboxsilver"
          subfolder = "other/lootboxes"
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

    let lootdroppod_gold : UnitDef =
        { name = "lootdroppod_gold"
          subfolder = "other/lootboxes"
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
                displayName = Some "Lootbox"
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
                onlyTargetCategory = None
                badTargetCategory = None
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

    let lootdroppod_printer : UnitDef =
        { name = "lootdroppod_printer"
          subfolder = "other/lootboxes"
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
                displayName = Some "Lootbox"
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
                onlyTargetCategory = None
                badTargetCategory = None
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

    let all : (string * UnitDef) list =
        [
            "lootboxbronze", lootboxbronze
            "lootboxgold", lootboxgold
            "lootboxplatinum", lootboxplatinum
            "lootboxsilver", lootboxsilver
            "lootdroppod_gold", lootdroppod_gold
            "lootdroppod_printer", lootdroppod_printer
        ]
