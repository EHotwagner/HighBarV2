// Auto-generated BAR unit data: CorAircraft
namespace BarData.Units

open BarData

module CorAircraft =

    let corbw : UnitDef =
        { name = "corbw"
          subfolder = "CorAircraft"
          metalCost = ValueOrExpr.Concrete 58.0
          energyCost = ValueOrExpr.Concrete 1300.0
          buildTime = ValueOrExpr.Concrete 2070.0
          health = ValueOrExpr.Concrete 83.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORBW.s3o"
          buildPic = Some "CORBW.DDS"
          script = Some "Units/CORBW.cob"
          corpse = None
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 280.5
              maxAcc = 0.25
              maxDec = 0.55
              turnRate = 1100.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 78.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "bladewing_lyzer"
                displayName = Some "Light EMP laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 600.0
                ]
                range = Some (ValueOrExpr.Concrete 220.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "hackshot"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-emp"
                rgbColor = Some "0.7 0.7 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "90.0"
                    "mount_onlytargetcategory", "EMPABLE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "beamdecay", "0.5"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "collidefriendly", "false"
                    "corethickness", "0.12"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "duration", "0.01"
                    "impactonly", "1.0"
                    "laserflaresize", "6.6"
                    "paralyzer", "true"
                    "paralyzetime", "7.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "targetmoveerror", "0.3"
                    "thickness", "1.4"
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
              "crashable", "0.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorAircraft"
              "unitgroup", "emp"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "cantbetransported", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "COMMANDER VTOL"
              "upright", "true"
              "usesmoothmesh", "0.0"
          ] }

    let corca : UnitDef =
        { name = "corca"
          subfolder = "CorAircraft"
          metalCost = ValueOrExpr.Concrete 115.0
          energyCost = ValueOrExpr.Concrete 3200.0
          buildTime = ValueOrExpr.Concrete 8360.0
          health = ValueOrExpr.Concrete 161.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORCA.s3o"
          buildPic = Some "CORCA.DDS"
          script = Some "Units/CORCA.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 201.0
              maxAcc = 0.06
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
              cruiseAltitude = Some 75.0
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 65.0
              buildDistance = Some 136.0
              buildOptions = ["corsolar"; "coradvsol"; "corwin"; "corgeo"; "cormstor"; "corestor"; "cormex"; "corexp"; "cormakr"; "coraap"; "corlab"; "corvp"; "corap"; "corhp"; "cornanotc"; "coreyes"; "corrad"; "cordrag"; "cormaw"; "corllt"; "corhllt"; "corhlt"; "corpun"; "corrl"; "cormadsam"; "corerad"; "cordl"; "corjamt"; "corjuno"; "corsy"; "coruwgeo"]
              terraformSpeed = Some 225.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 5.0)
              metalMake = None
              energyStorage = Some 25.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = None
          sounds = Some (
            { build = Some "nanlath2"
              repair = Some "repair2"
              working = Some "reclaim1"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "model_author", "Mr Bob, Flaka"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorAircraft"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "radardistance", "50.0"
          ] }

    let cordrone : UnitDef =
        { name = "cordrone"
          subfolder = "CorAircraft"
          metalCost = ValueOrExpr.Concrete 30.0
          energyCost = ValueOrExpr.Concrete 750.0
          buildTime = ValueOrExpr.Concrete 1500.0
          health = ValueOrExpr.Concrete 675.0
          sightDistance = ValueOrExpr.Concrete 600.0
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
            { speed = ValueOrExpr.Concrete 315.0
              maxAcc = 0.2
              maxDec = 0.45
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
              cruiseAltitude = Some 40.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "heat_ray"
                displayName = Some "HeatRay"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 60.0
                    "vtol", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 360.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.35)
                weaponVelocity = Some 950.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-yellow"
                rgbColor = Some "1 0.8 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "90.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.15"
                    "corethickness", "0.15"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "30.0"
                    "impactonly", "1.0"
                    "laserflaresize", "5.0"
                    "predictboost", "1.0"
                    "rgbcolor2", "0.8 0 0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "targetmoveerror", "0.2"
                    "thickness", "1.5"
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
              "subfolder", "CorAircraft"
              "unitgroup", "emp"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "COMMANDER VTOL"
              "upright", "true"
              "usesmoothmesh", "0.0"
          ] }

    let cordroneold : UnitDef =
        { name = "cordroneold"
          subfolder = "CorAircraft"
          metalCost = ValueOrExpr.Concrete 29.0
          energyCost = ValueOrExpr.Concrete 650.0
          buildTime = ValueOrExpr.Concrete 1040.0
          health = ValueOrExpr.Concrete 166.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "Units/CORDRONEOLD.s3o"
          buildPic = Some "CORBW.DDS"
          script = Some "Units/CORBW.cob"
          corpse = None
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 280.5
              maxAcc = 0.25
              maxDec = 0.55
              turnRate = 1100.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 78.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "heat_ray"
                displayName = Some "HeatRay"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 80.0
                    "vtol", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 360.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.8)
                weaponVelocity = Some 950.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-yellow"
                rgbColor = Some "1 0.8 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "90.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.25"
                    "corethickness", "0.15"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "30.0"
                    "impactonly", "1.0"
                    "laserflaresize", "5.0"
                    "rgbcolor2", "0.8 0 0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "targetmoveerror", "0.2"
                    "thickness", "1.5"
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
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorAircraft"
              "unitgroup", "emp"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "cantbetransported", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "COMMANDER VTOL"
              "upright", "true"
              "usesmoothmesh", "0.0"
          ] }

    let corfink : UnitDef =
        { name = "corfink"
          subfolder = "CorAircraft"
          metalCost = ValueOrExpr.Concrete 51.0
          energyCost = ValueOrExpr.Concrete 1450.0
          buildTime = ValueOrExpr.Concrete 2400.0
          health = ValueOrExpr.Concrete 100.0
          sightDistance = ValueOrExpr.Concrete 835.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORFINK.s3o"
          buildPic = Some "CORFINK.DDS"
          script = Some "Units/CORFINK.cob"
          corpse = None
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "LIGHTAIRSCOUT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 360.0
              maxAcc = 0.1825
              maxDec = 0.0125
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
              cruiseAltitude = Some 110.0
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
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "crashable", "0.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "selectable_as_combat_unit", "true"
              "subfolder", "CorAircraft"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.0144"
              "maxbank", "0.8"
              "maxelevator", "0.01065"
              "maxpitch", "0.625"
              "maxrudder", "0.00615"
              "radardistance", "1120.0"
              "selfdestructcountdown", "1.0"
              "speedtofront", "0.06125"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06315"
              "wingdrag", "0.06"
          ] }

    let corhvytrans : UnitDef =
        { name = "corhvytrans"
          subfolder = "CorAircraft"
          metalCost = ValueOrExpr.Concrete 190.0
          energyCost = ValueOrExpr.Concrete 4000.0
          buildTime = ValueOrExpr.Concrete 8500.0
          health = ValueOrExpr.Concrete 800.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 3.0
          objectName = Some "Units/corhvytrans.s3o"
          buildPic = Some "corhvytrans.DDS"
          script = Some "Units/corhvytrans.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = Some "ALL MOBILE WEAPON NOTLAND VTOL NOTSUB NOTSHIP NOTHOVER"
          movement = Some (
            { speed = ValueOrExpr.Concrete 100.0
              maxAcc = 0.09
              maxDec = 0.75
              turnRate = 550.0
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
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "crashable", "0.0"
              "model_author", "Protar"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "CorAircraft"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "loadingradius", "300.0"
              "releaseheld", "true"
              "transportcapacity", "1.0"
              "transportsize", "4.0"
              "transportunloadmethod", "0.0"
              "verticalspeed", "3.75"
          ] }

    let corshad : UnitDef =
        { name = "corshad"
          subfolder = "CorAircraft"
          metalCost = ValueOrExpr.Concrete 150.0
          energyCost = ValueOrExpr.Concrete 4600.0
          buildTime = ValueOrExpr.Concrete 5050.0
          health = ValueOrExpr.Concrete 680.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORSHAD.s3o"
          buildPic = Some "CORSHAD.DDS"
          script = Some "Units/CORSHAD.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 234.0
              maxAcc = 0.0575
              maxDec = 0.055
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
              cruiseAltitude = Some 165.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "corbomb"
                displayName = Some "Medium a2g incinerating warheads"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 112.0
                    "subs", 35.0
                ]
                range = Some (ValueOrExpr.Concrete 1280.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = None
                areaOfEffect = Some 168.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 0.3
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "bombssml1"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "5.0"
                    "burstrate", "0.26667"
                    "collidefriendly", "false"
                    "commandfire", "false"
                    "craterareaofeffect", "168.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "airbomb.s3o"
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorAircraft"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "maxaileron", "0.01421"
              "maxbank", "0.8"
              "maxelevator", "0.01046"
              "maxpitch", "0.625"
              "maxrudder", "0.00596"
              "noautofire", "true"
              "nochasecategory", "VTOL"
              "speedtofront", "0.06183"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06296"
              "wingdrag", "0.145"
          ] }

    let corvalk : UnitDef =
        { name = "corvalk"
          subfolder = "CorAircraft"
          metalCost = ValueOrExpr.Concrete 74.0
          energyCost = ValueOrExpr.Concrete 1450.0
          buildTime = ValueOrExpr.Concrete 4120.0
          health = ValueOrExpr.Concrete 280.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 3.0
          objectName = Some "Units/CORVALK.s3o"
          buildPic = Some "CORVALK.DDS"
          script = Some "Units/CORVALK.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 198.0
              maxAcc = 0.09
              maxDec = 0.75
              turnRate = 550.0
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
              ok = ["vtolcrmv"]
              select = ["vtolcrac"] })
          customParams = Map.ofList [
              "crashable", "0.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "CorAircraft"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "loadingradius", "300.0"
              "releaseheld", "true"
              "transportcapacity", "1.0"
              "transportmass", "750.0"
              "transportsize", "3.0"
              "transportunloadmethod", "0.0"
              "verticalspeed", "3.75"
          ] }

    let corveng : UnitDef =
        { name = "corveng"
          subfolder = "CorAircraft"
          metalCost = ValueOrExpr.Concrete 73.0
          energyCost = ValueOrExpr.Concrete 2800.0
          buildTime = ValueOrExpr.Concrete 3330.0
          health = ValueOrExpr.Concrete 156.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORVENG.s3o"
          buildPic = Some "CORVENG.DDS"
          script = Some "Units/CORVENG.cob"
          corpse = None
          explodeAs = Some "smallExplosionGenericAir"
          selfDestructAs = Some "smallExplosionGenericAir"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 297.60001
              maxAcc = 0.1825
              maxDec = 0.065
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
              cruiseAltitude = Some 125.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "corvtol_missile"
                displayName = Some "Light guided a2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "commanders", 4.0
                    "default", 12.0
                    "vtol", 125.0
                ]
                range = Some (ValueOrExpr.Concrete 680.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.9)
                weaponVelocity = Some 850.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = None
                tolerance = Some 12000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Rocklit3"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-air"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
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
                    "flighttime", "1.2"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.55"
                    "smokeperiod", "4.0"
                    "smokesize", "1.8"
                    "smoketime", "8.0"
                    "smoketrail", "false"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "450.0"
                    "texture1", "null"
                    "texture2", "smoketrail"
                    "tracks", "true"
                    "turnrate", "20000.0"
                    "weaponacceleration", "400.0"
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
              "attacksafetydistance", "300.0"
              "fighter", "1.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorAircraft"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "950.0"
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.0144"
              "maxbank", "0.8"
              "maxelevator", "0.01065"
              "maxpitch", "0.625"
              "maxrudder", "0.00615"
              "nochasecategory", "NOTAIR"
              "speedtofront", "0.063"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06315"
              "wingdrag", "0.165"
          ] }

    let all : (string * UnitDef) list =
        [
            "corbw", corbw
            "corca", corca
            "cordrone", cordrone
            "cordroneold", cordroneold
            "corfink", corfink
            "corhvytrans", corhvytrans
            "corshad", corshad
            "corvalk", corvalk
            "corveng", corveng
        ]
