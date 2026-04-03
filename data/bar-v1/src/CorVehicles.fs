// Auto-generated BAR unit data: CorVehicles
namespace BarData.V1.Units

open BarData.V1

module CorVehicles =

    let corcv : UnitDef =
        { name = "corcv"
          subfolder = "CorVehicles"
          metalCost = ValueOrExpr.Concrete 145.0
          energyCost = ValueOrExpr.Concrete 2100.0
          buildTime = ValueOrExpr.Concrete 4160.0
          health = ValueOrExpr.Concrete 1430.0
          sightDistance = ValueOrExpr.Concrete 260.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORCV.s3o"
          buildPic = Some "CORCV.DDS"
          script = Some "Units/CORCV.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-builder"
          selfDestructAs = Some "mediumExplosionGenericSelfd-builder"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "35 32 49"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 51.0
              maxAcc = 0.03049
              maxDec = 0.12198
              turnRate = 421.0
              movementClass = Some "TANK3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 19.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.1979
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 95.0
              buildDistance = Some 130.0
              buildOptions = ["corsolar"; "coradvsol"; "corwin"; "corgeo"; "cormstor"; "corestor"; "cormex"; "corexp"; "cormakr"; "coravp"; "corlab"; "corvp"; "corap"; "corhp"; "cornanotc"; "coreyes"; "corrad"; "cordrag"; "cormaw"; "corllt"; "corhllt"; "corhlt"; "corpun"; "corrl"; "cormadsam"; "corerad"; "cordl"; "corjamt"; "corjuno"; "corsy"]
              terraformSpeed = Some 450.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 10.0)
              metalMake = None
              energyStorage = Some 50.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.31364440918 1.09863281317e-06 0.657264709473"
                collisionVolumeScales = Some "32.9147644043 17.5585021973 49.4168548584"
                collisionVolumeType = Some "Box"
                damage = Some 874.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 87.0
                object_ = Some "Units/corcv_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 487.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 35.0
                object_ = Some "Units/cor3X3D.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorVehicles"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "radardistance", "50.0"
              "trackoffset", "3.0"
              "trackstrength", "6.0"
              "tracktype", "corwidetracks"
              "trackwidth", "32.0"
          ] }

    let corfav : UnitDef =
        { name = "corfav"
          subfolder = "CorVehicles"
          metalCost = ValueOrExpr.Concrete 26.0
          energyCost = ValueOrExpr.Concrete 270.0
          buildTime = ValueOrExpr.Concrete 1150.0
          health = ValueOrExpr.Concrete 90.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORFAV.s3o"
          buildPic = Some "CORFAV.DDS"
          script = Some "Units/CORFAV.cob"
          corpse = Some "DEAD"
          explodeAs = Some "tinyExplosionGeneric"
          selfDestructAs = Some "tinyExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "16 16 26"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = Some "GROUNDSCOUT"
          movement = Some (
            { speed = ValueOrExpr.Concrete 153.0
              maxAcc = 0.2
              maxDec = 0.4
              turnRate = 750.0
              movementClass = Some "TANK2"
              maxSlope = Some 26.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 3.5
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "cor_laser"
                displayName = Some "Light Close-Quarters g2g Laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 35.0
                    "vtol", 2.0
                ]
                range = Some (ValueOrExpr.Concrete 180.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.1)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrfir1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-tiny-yellow"
                rgbColor = Some "1 1 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.18"
                    "beamttl", "1.0"
                    "burstrate", "0.2"
                    "corethickness", "0.1"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.02"
                    "energypershot", "0.0"
                    "firestarter", "50.0"
                    "hardstop", "true"
                    "impactonly", "1.0"
                    "laserflaresize", "3.85"
                    "rgbcolor2", "1 0.55 0.3"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "0.95"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -2.81028394531 1.25487518311"
                collisionVolumeScales = Some "16 7.5 24"
                collisionVolumeType = Some "Box"
                damage = Some 132.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 16.0
                object_ = Some "Units/corfav_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 66.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 6.0
                object_ = Some "Units/cor2X2B.s3o"
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
              ok = ["vcormove"]
              select = ["vcorsel"] })
          customParams = Map.ofList [
              "basename", "base"
              "firingceg", ""
              "kickback", "0"
              "model_author", "Flaka"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorVehicles"
              "unitgroup", "weapon"
              "weapon1turretx", "300.0"
              "weapon1turrety", "300.0"
          ]
          extras = Map.ofList [
              "leavetracks", "false"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "trackoffset", "-2.0"
              "trackstrength", "3.0"
              "tracktype", "StdTank"
              "trackwidth", "21.0"
          ] }

    let corgarp : UnitDef =
        { name = "corgarp"
          subfolder = "CorVehicles"
          metalCost = ValueOrExpr.Concrete 220.0
          energyCost = ValueOrExpr.Concrete 2600.0
          buildTime = ValueOrExpr.Concrete 3100.0
          health = ValueOrExpr.Concrete 1420.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORGARP.s3o"
          buildPic = Some "CORGARP.DDS"
          script = Some "Units/CORGARP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric-phib"
          selfDestructAs = Some "smallExplosionGenericSelfd-phib"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "30 21 36"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 58.5
              maxAcc = 0.03226
              maxDec = 0.06453
              turnRate = 387.0
              movementClass = Some "ATANK3"
              maxSlope = Some 12.0
              maxWaterDepth = Some 200.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.386
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "arm_pincer_gauss"
                displayName = Some "PincerCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 116.0
                    "vtol", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 305.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-small"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -0.580979279785 -0.621788024902"
                collisionVolumeScales = Some "30.1485290527 10.4821014404 33.694442749"
                collisionVolumeType = Some "Box"
                damage = Some 731.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 9.0
                metal = Some 134.0
                object_ = Some "Units/corgarp_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 488.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 67.0
                object_ = Some "Units/cor2X2E.s3o"
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
              ok = ["tcormove"]
              select = ["tcorsel"] })
          customParams = Map.ofList [
              "basename", "base"
              "firingceg", "barrelshot-tiny"
              "kickback", "-2.4"
              "model_author", "Flaka"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.2"
              "subfolder", "CorVehicles"
              "unitgroup", "weapon"
              "weapon1turretx", "130.0"
              "weapon1turrety", "130.0"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "nochasecategory", "VTOL"
              "sonardistance", "175.0"
              "trackoffset", "0.0"
              "trackstrength", "6.0"
              "tracktype", "corparrowtracks"
              "trackwidth", "22.0"
              "usepiececollisionvolumes", "1.0"
          ] }

    let corgator : UnitDef =
        { name = "corgator"
          subfolder = "CorVehicles"
          metalCost = ValueOrExpr.Concrete 120.0
          energyCost = ValueOrExpr.Concrete 1100.0
          buildTime = ValueOrExpr.Concrete 2300.0
          health = ValueOrExpr.Concrete 820.0
          sightDistance = ValueOrExpr.Concrete 330.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORGATOR.s3o"
          buildPic = Some "CORGATOR.DDS"
          script = Some "Units/CORGATOR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -1 1"
          collisionVolumeScales = Some "30 15 38"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 85.0
              maxAcc = 0.04631
              maxDec = 0.09262
              turnRate = 427.0
              movementClass = Some "TANK2"
              maxSlope = Some 10.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.96
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "gator_laserx"
                displayName = Some "Laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 75.0
                    "vtol", 14.0
                ]
                range = Some (ValueOrExpr.Concrete 230.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrlit3"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-red"
                rgbColor = Some "1 0 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "corethickness", "0.165"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "0.0"
                    "firestarter", "50.0"
                    "impactonly", "1.0"
                    "laserflaresize", "4.4"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.2"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -0.0103445068359 -0.00248718261719"
                collisionVolumeScales = Some "21.4374389648 12.6050109863 32.0003356934"
                collisionVolumeType = Some "Box"
                damage = Some 550.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 77.0
                object_ = Some "Units/corgator_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 225.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 31.0
                object_ = Some "Units/cor2X2F.s3o"
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
              ok = ["tcormove"]
              select = ["tcorsel"] })
          customParams = Map.ofList [
              "basename", "base"
              "firingceg", "barrelshot-tiny"
              "kickback", "-2.4"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorVehicles"
              "unitgroup", "weapon"
              "weapon1turretx", "192.5"
              "weapon1turrety", "192.5"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "nochasecategory", "VTOL"
              "trackoffset", "8.0"
              "trackstrength", "5.0"
              "tracktype", "corwidetracks"
              "trackwidth", "21.0"
              "usepiececollisionvolumes", "1.0"
          ] }

    let corlevlr : UnitDef =
        { name = "corlevlr"
          subfolder = "CorVehicles"
          metalCost = ValueOrExpr.Concrete 220.0
          energyCost = ValueOrExpr.Concrete 2600.0
          buildTime = ValueOrExpr.Concrete 3000.0
          health = ValueOrExpr.Concrete 1490.0
          sightDistance = ValueOrExpr.Concrete 286.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORLEVLR.s3o"
          buildPic = Some "CORLEVLR.DDS"
          script = Some "Units/CORLEVLR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "29 20 32"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 40.5
              maxAcc = 0.01654
              maxDec = 0.03308
              turnRate = 292.80002
              movementClass = Some "TANK3"
              maxSlope = Some 17.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.94149
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "corlevlr_weapon"
                displayName = Some "RiotCannon"
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "alphadecay", "0.1"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "cegtag", "impulse-trail"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "nogap", "false"
                    "separation", "2.0"
                    "sizedecay", "0.08"
                    "soundhitvolume", "11.5"
                    "soundhitwet", "splsmed"
                    "soundstartvolume", "13.0"
                    "stages", "12.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.00485992431641 -0.393698339844 -0.0"
                collisionVolumeScales = Some "30.4261322021 21.4884033203 31.1059265137"
                collisionVolumeType = Some "Box"
                damage = Some 865.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 190.0
                object_ = Some "Units/corlevlr_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 383.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 76.0
                object_ = Some "Units/cor2X2B.s3o"
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
              ok = ["tcormove"]
              select = ["tcorsel"] })
          customParams = Map.ofList [
              "basename", "base"
              "firingceg", "barrelshot-tiny"
              "kickback", "-4"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorVehicles"
              "unitgroup", "weapon"
              "weapon1turretx", "20.0"
              "weapon1turrety", "170.0"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "nochasecategory", "VTOL"
              "trackoffset", "7.0"
              "trackstrength", "6.0"
              "tracktype", "corwidetracks"
              "trackwidth", "30.0"
              "usepiececollisionvolumes", "0.0"
          ] }

    let cormist : UnitDef =
        { name = "cormist"
          subfolder = "CorVehicles"
          metalCost = ValueOrExpr.Concrete 155.0
          energyCost = ValueOrExpr.Concrete 2400.0
          buildTime = ValueOrExpr.Concrete 3440.0
          health = ValueOrExpr.Concrete 860.0
          sightDistance = ValueOrExpr.Concrete 620.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORMIST.s3o"
          buildPic = Some "CORMIST.DDS"
          script = Some "Units/CORMIST.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 -2"
          collisionVolumeScales = Some "32 31 43"
          collisionVolumeType = Some "ellipsoid"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 52.0
              maxAcc = 0.02208
              maxDec = 0.04416
              turnRate = 370.0
              movementClass = Some "TANK3"
              maxSlope = Some 16.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.99
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "cortruck_aa"
                displayName = Some "Light g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "vtol", 120.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 680.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rockhvy2"
                soundHit = Some "rockhit2"
                explosiongenerator = Some "custom:genericshellexplosion-tiny"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "canattackground", "false"
                    "castshadow", "true"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "2.0"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "predictboost", "1.0"
                    "smokecolor", "0.66"
                    "smokeperiod", "8.0"
                    "smokesize", "4.5"
                    "smoketime", "14.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splssml"
                    "soundstartvolume", "8.5"
                    "startvelocity", "500.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "tracks", "true"
                    "turnrate", "63000.0"
                    "weaponacceleration", "110.0"
                    "weapontimer", "5.0"
                ] }
              { name = "cortruck_missile"
                displayName = Some "Light g2g missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 63.0
                ]
                range = Some (ValueOrExpr.Concrete 575.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 350.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rockhvy2"
                soundHit = Some "rockhit2"
                explosiongenerator = Some "custom:genericshellexplosion-tiny"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "castshadow", "true"
                    "cegtag", "missiletrailtiny"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "2.0"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "predictboost", "1.0"
                    "smokecolor", "0.66"
                    "smokeperiod", "8.0"
                    "smokesize", "4.5"
                    "smoketime", "14.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splssml"
                    "soundstartvolume", "8.5"
                    "startvelocity", "350.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "weaponacceleration", "110.0"
                    "weapontimer", "1.7"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.41771697998 -0.356536877441 1.65004730225"
                collisionVolumeScales = Some "31.3571624756 22.0425262451 48.4261016846"
                collisionVolumeType = Some "Box"
                damage = Some 672.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 100.0
                object_ = Some "Units/cormist_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 336.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 46.0
                object_ = Some "Units/cor3X3F.s3o"
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
              ok = ["vcormove"]
              select = ["vcorsel"] })
          customParams = Map.ofList [
              "maxrange", "575.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorVehicles"
              "unitgroup", "weaponaa"
          ]
          extras = Map.ofList [
              "airsightdistance", "900.0"
              "leavetracks", "true"
              "movestate", "0.0"
              "trackoffset", "-6.0"
              "trackstrength", "5.0"
              "tracktype", "corwidetracks"
              "trackwidth", "30.0"
          ] }

    let cormlv : UnitDef =
        { name = "cormlv"
          subfolder = "CorVehicles"
          metalCost = ValueOrExpr.Concrete 65.0
          energyCost = ValueOrExpr.Concrete 1300.0
          buildTime = ValueOrExpr.Concrete 3640.0
          health = ValueOrExpr.Concrete 450.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORMLV.s3o"
          buildPic = Some "CORMLV.DDS"
          script = Some "Units/cormlv.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "30 17 45"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 69.0
              maxAcc = 0.06681
              maxDec = 0.1327
              turnRate = 590.0
              movementClass = Some "TANK2"
              maxSlope = Some 16.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.62228
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 40.0
              buildDistance = Some 96.0
              buildOptions = ["cormine1"; "cormine2"; "cormine3"; "cordrag"; "coreyes"]
              terraformSpeed = Some 120.0 })
          weapons = Some [
              { name = "minesweep"
                displayName = Some "Seismic charge"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 15.0
                ]
                range = Some (ValueOrExpr.Concrete 220.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 275.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 3000.0
                edgeEffectiveness = Some 0.4
                impulseFactor = None
                noSelfDamage = Some true
                soundStart = None
                soundHit = None
                explosiongenerator = Some "custom:MINESWEEP"
                rgbColor = Some "0.2 0.6 0.2"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "MINE"
                    "avoidfeature", "false"
                    "collidefriendly", "false"
                    "craterareaofeffect", "48.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firetolerance", "3000.0"
                    "gravityaffected", "true"
                    "weapontimer", "0.1"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -1 0"
                collisionVolumeScales = Some "30 17 45"
                collisionVolumeType = Some "Box"
                damage = Some 133.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 37.0
                object_ = Some "Units/cormlv_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 60.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 15.0
                object_ = Some "Units/cor3X3F.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
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
              "minesweeper", "450.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorVehicles"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "canassist", "false"
              "canreclaim", "false"
              "canrepair", "true"
              "canrestore", "false"
              "leavetracks", "true"
              "mass", "740.0"
              "nochasecategory", "VTOL"
              "radardistancejam", "64.0"
              "stealth", "true"
              "trackoffset", "12.0"
              "trackstrength", "5.0"
              "tracktype", "corwidetracks"
              "trackwidth", "17.0"
          ] }

    let cormuskrat : UnitDef =
        { name = "cormuskrat"
          subfolder = "CorVehicles"
          metalCost = ValueOrExpr.Concrete 170.0
          energyCost = ValueOrExpr.Concrete 3500.0
          buildTime = ValueOrExpr.Concrete 6860.0
          health = ValueOrExpr.Concrete 1110.0
          sightDistance = ValueOrExpr.Concrete 260.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORMUSKRAT.s3o"
          buildPic = Some "CORMUSKRAT.DDS"
          script = Some "Units/CORMUSKRAT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric-phib"
          selfDestructAs = Some "mediumExplosionGenericSelfd-phib"
          collisionVolumeOffsets = Some "0 0 1"
          collisionVolumeScales = Some "26 28 46"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 40.5
              maxAcc = 0.01722
              maxDec = 0.10332
              turnRate = 300.0
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
            { workerTime = ValueOrExpr.Concrete 85.0
              buildDistance = Some 110.0
              buildOptions = ["corsolar"; "coradvsol"; "corwin"; "corgeo"; "cormstor"; "corestor"; "cormex"; "corexp"; "cormakr"; "corlab"; "corvp"; "corap"; "corhp"; "coravp"; "cornanotc"; "cornanotcplat"; "coreyes"; "corrad"; "cordrag"; "cormaw"; "corllt"; "corhllt"; "corhlt"; "corpun"; "corrl"; "cormadsam"; "corerad"; "corjuno"; "cordl"; "corjamt"; "corfhp"; "coramsub"; "corplat"; "corsy"; "cortide"; "corfmkr"; "coruwms"; "coruwes"; "corfdrag"; "corfrad"; "corfhlt"; "corfrt"; "cortl"; "coruwgeo"]
              terraformSpeed = Some 400.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 8.0)
              metalMake = None
              energyStorage = None
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.3500289917 4.80712890649e-06 3.49253082275"
                collisionVolumeScales = Some "25.27003479 12.0197296143 44.3021697998"
                collisionVolumeType = Some "Box"
                damage = Some 697.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 105.0
                object_ = Some "Units/cormuskrat_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 299.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 42.0
                object_ = Some "Units/cor3X3C.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorVehicles"
              "unitgroup", "builder"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "trackoffset", "8.0"
              "trackstrength", "5.0"
              "tracktype", "corwidetracks"
              "trackwidth", "24.0"
          ] }

    let corraid : UnitDef =
        { name = "corraid"
          subfolder = "CorVehicles"
          metalCost = ValueOrExpr.Concrete 235.0
          energyCost = ValueOrExpr.Concrete 2400.0
          buildTime = ValueOrExpr.Concrete 3310.0
          health = ValueOrExpr.Concrete 1970.0
          sightDistance = ValueOrExpr.Concrete 325.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORRAID.s3o"
          buildPic = Some "CORRAID.DDS"
          script = Some "Units/CORRAID.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -1 0"
          collisionVolumeScales = Some "32 16 32"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 72.9
              maxAcc = 0.04056
              maxDec = 0.08113
              turnRate = 330.0
              movementClass = Some "TANK3"
              maxSlope = Some 10.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.873
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "arm_lightcannon"
                displayName = Some "LightCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 97.0
                    "vtol", 18.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.16667)
                weaponVelocity = Some 225.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "corraid"
                soundHit = Some "xplosml3"
                explosiongenerator = Some "custom:genericshellexplosion-small"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "10.5"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "1.73252868652 -0.81482236084 -0.546882629395"
                collisionVolumeScales = Some "37.1564331055 16.4705352783 33.7862091064"
                collisionVolumeType = Some "Box"
                damage = Some 975.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 167.0
                object_ = Some "Units/corraid_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 488.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 67.0
                object_ = Some "Units/cor2X2E.s3o"
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
              ok = ["tcormove"]
              select = ["tcorsel"] })
          customParams = Map.ofList [
              "basename", "base"
              "firingceg", "barrelshot-tiny"
              "kickback", "-2.4"
              "model_author", "Mr Bob, Flaka"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorVehicles"
              "unitgroup", "weapon"
              "weapon1turretx", "45.0"
              "weapon1turrety", "80.0"
          ]
          extras = Map.ofList [
              "leavetracks", "true"
              "nochasecategory", "VTOL"
              "trackoffset", "6.0"
              "trackstrength", "5.0"
              "tracktype", "corwidetracks"
              "trackwidth", "28.0"
              "usepiececollisionvolumes", "1.0"
          ] }

    let corwolv : UnitDef =
        { name = "corwolv"
          subfolder = "CorVehicles"
          metalCost = ValueOrExpr.Concrete 170.0
          energyCost = ValueOrExpr.Concrete 2500.0
          buildTime = ValueOrExpr.Concrete 3550.0
          health = ValueOrExpr.Concrete 750.0
          sightDistance = ValueOrExpr.Concrete 299.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORWOLV.s3o"
          buildPic = Some "CORWOLV.DDS"
          script = Some "Units/CORWOLV.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallexplosiongeneric"
          selfDestructAs = Some "smallExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "28 22 38"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 48.0
              maxAcc = 0.02293
              maxDec = 0.04585
              turnRate = 466.0
              movementClass = Some "TANK3"
              maxSlope = Some 10.0
              maxWaterDepth = Some 8.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.2342
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "corwolv_gun"
                displayName = Some "LightArtillery"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 300.0
                    "subs", 75.0
                    "vtol", 30.0
                ]
                range = Some (ValueOrExpr.Concrete 710.0)
                reloadTime = Some (ValueOrExpr.Concrete 7.1)
                weaponVelocity = Some 580.0
                areaOfEffect = Some 113.0
                accuracy = Some 275.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy3"
                soundHit = Some "tawf113a"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "arty-medium"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "mygravity", "0.276"
                    "soundhitwet", "splsmed"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "31 15 43"
                collisionVolumeType = Some "Box"
                damage = Some 430.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 0.0
                metal = Some 103.0
                object_ = Some "Units/corwolv_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 640.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 39.0
                object_ = Some "Units/cor2X2E.s3o"
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
              ok = ["tcormove"]
              select = ["tcorsel"] })
          customParams = Map.ofList [
              "basename", "base"
              "canareaattack", "1.0"
              "cobkickbackrestorespeed", "10"
              "firingceg", "barrelshot-tiny"
              "kickback", "-2"
              "model_author", "Mr Bob, Flaka"
              "normaltex", "unittextures/cor_normal.dds"
              "rockrestorespeed", "1"
              "rockspeed", "2"
              "subfolder", "CorVehicles"
              "unitgroup", "weapon"
              "weapon1turretx", "200.0"
              "weapon1turrety", "200.0"
          ]
          extras = Map.ofList [
              "hightrajectory", "1.0"
              "leavetracks", "true"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "trackoffset", "6.0"
              "trackstrength", "5.0"
              "tracktype", "corwidetracks"
              "trackwidth", "28.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "corcv", corcv
            "corfav", corfav
            "corgarp", corgarp
            "corgator", corgator
            "corlevlr", corlevlr
            "cormist", cormist
            "cormlv", cormlv
            "cormuskrat", cormuskrat
            "corraid", corraid
            "corwolv", corwolv
        ]
