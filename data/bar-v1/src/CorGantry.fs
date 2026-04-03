// Auto-generated BAR unit data: CorGantry
namespace BarData.V1.Units

open BarData.V1

module CorGantry =

    let corcat : UnitDef =
        { name = "corcat"
          subfolder = "CorGantry"
          metalCost = ValueOrExpr.Concrete 4900.0
          energyCost = ValueOrExpr.Concrete 80000.0
          buildTime = ValueOrExpr.Concrete 160000.0
          health = ValueOrExpr.Concrete 6100.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORCAT.s3o"
          buildPic = Some "CORCAT.DDS"
          script = Some "Units/corcat.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 0 2"
          collisionVolumeScales = Some "60 53 48"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 48.0
              maxAcc = 0.1242
              maxDec = 0.6486
              turnRate = 525.84998
              movementClass = Some "HBOT4"
              maxSlope = Some 20.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.056
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "exp_heavyrocket"
                displayName = Some "CatapultRockets"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 450.0
                ]
                range = Some (ValueOrExpr.Concrete 1350.0)
                reloadTime = Some (ValueOrExpr.Concrete 15.0)
                weaponVelocity = Some 530.0
                areaOfEffect = Some 96.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.6
                noSelfDamage = Some true
                soundStart = Some "rapidrocket3"
                soundHit = Some "rockhit"
                explosiongenerator = Some "custom:genericshellexplosion-catapult"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "20.0"
                    "burstrate", "0.1"
                    "cegtag", "missiletrailsmall-red"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "dance", "24.0"
                    "firestarter", "70.0"
                    "flighttime", "3.2"
                    "metalpershot", "0.0"
                    "model", "catapultmissile.s3o"
                    "movingaccuracy", "600.0"
                    "proximitypriority", "-1.0"
                    "smokecolor", "0.5"
                    "smokeperiod", "4.0"
                    "smokesize", "8.5"
                    "smoketime", "16.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splsmed"
                    "startvelocity", "185.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "trajectoryheight", "1.0"
                    "turnrate", "0.0"
                    "weaponacceleration", "100.0"
                    "weapontimer", "6.0"
                    "wobble", "2000.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "3.19359588623 0.0 1.04564666748"
                collisionVolumeScales = Some "66.3871917725 26.0 41.4744720459"
                collisionVolumeType = Some "Box"
                damage = Some 3300.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 40.0
                metal = Some 2958.0
                object_ = Some "Units/corcat_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1650.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 1183.0
                object_ = Some "Units/cor3X3C.s3o"
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
              ok = ["mavbok1"]
              select = ["mavbsel1"] })
          customParams = Map.ofList [
              "model_author", "FireStorm"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorGantry"
              "techlevel", "3.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let cordemon : UnitDef =
        { name = "cordemon"
          subfolder = "CorGantry"
          metalCost = ValueOrExpr.Concrete 6000.0
          energyCost = ValueOrExpr.Concrete 90000.0
          buildTime = ValueOrExpr.Concrete 160000.0
          health = ValueOrExpr.Concrete 18000.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/cordemon.s3o"
          buildPic = Some "CORDEMON.DDS"
          script = Some "Units/cordemon.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3xl"
          selfDestructAs = Some "explosiont3xxl"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "60 88 60"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 63.0
              maxAcc = 0.2208
              maxDec = 1.0
              turnRate = 607.20001
              movementClass = Some "HBOT4"
              maxSlope = Some 160.0
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
              { name = "newdmaw"
                displayName = Some "Demon's Maw; Heavy long range AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "default", 48.0
                    "subs", 16.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.39996)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 128.0
                accuracy = Some 0.0
                turret = Some true
                tolerance = Some 20000.0
                edgeEffectiveness = Some 0.01
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Flamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:burnblackxl"
                rgbColor = Some "1 0.94 0.88"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT VTOL"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "avoidground", "true"
                    "bouncerebound", "1.0"
                    "bounceslip", "1.0"
                    "burnblow", "true"
                    "burst", "12.0"
                    "burstrate", "0.03333"
                    "cegtag", "demonflame"
                    "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "flamegfxtime", "1.0"
                    "intensity", "0.85"
                    "noexplode", "false"
                    "predictboost", "1.0"
                    "rgbcolor2", "0.9 0.84 0.8"
                    "sizegrowth", "1.1"
                    "soundhitdry", "flamhit1"
                    "soundhitvolume", "9.5"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "7.3"
                    "soundtrigger", "false"
                    "waterweapon", "false"
                ] }
              { name = "karg_shoulder"
                displayName = Some "ShoulderRockets"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 100.0
                    "vtol", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.6)
                weaponVelocity = Some 820.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 9950.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "72.0"
                    "fixedlauncher", "true"
                    "flighttime", "1.75"
                    "model", "cormissile.s3o"
                    "proximitypriority", "1.0"
                    "smokecolor", "0.95"
                    "smokeperiod", "5.0"
                    "smokesize", "4.4"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "false"
                    "startvelocity", "820.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "160.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "3.89811706543 -12.9994070068 -38.2052841187"
                collisionVolumeScales = Some "77.9624938965 23.0893859863 76.4105682373"
                collisionVolumeType = Some "Box"
                damage = Some 10000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 40.0
                metal = Some 3600.0
                object_ = Some "Units/cordemon_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 10000.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 2750.0
                object_ = Some "Units/arm2X2D.s3o"
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
              ok = ["mavbok1"]
              select = ["mavbsel1"] })
          customParams = Map.ofList [
              "maxrange", "500"
              "model_author", "FireStorm, Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorGantry"
              "techlevel", "3.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "6000.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let corjugg : UnitDef =
        { name = "corjugg"
          subfolder = "CorGantry"
          metalCost = ValueOrExpr.Concrete 20000.0
          energyCost = ValueOrExpr.Concrete 513000.0
          buildTime = ValueOrExpr.Concrete 780000.0
          health = ValueOrExpr.Concrete 335000.0
          sightDistance = ValueOrExpr.Concrete 720.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/CORJUGG.s3o"
          buildPic = Some "CORJUGG.DDS"
          script = Some "Units/corjugg.cob"
          corpse = Some "DEAD"
          explodeAs = Some "juggernaut"
          selfDestructAs = Some "juggernautSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "90 80 90"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 16.5
              maxAcc = 0.0552
              maxDec = 0.43125
              turnRate = 125.35
              movementClass = Some "HBOT7"
              maxSlope = Some 14.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.363
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "juggernaut_fire"
                displayName = Some "GaussCannon"
                weaponType = Some "DGun"
                damage = Map.ofList [
                    "default", 1200.0
                ]
                range = Some (ValueOrExpr.Concrete 590.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = Some 520.0
                areaOfEffect = Some 65.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "krogun1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:burnblackbig"
                rgbColor = Some "1 0.8 0.17"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "bouncerebound", "0.0"
                    "cegtag", "gausscannonprojectile"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "gravityaffected", "true"
                    "intensity", "4.0"
                    "noexplode", "true"
                    "size", "6.5"
                    "soundhitvolume", "32.0"
                    "soundhitwet", "sizzlexs"
                    "soundtrigger", "true"
                    "waterweapon", "false"
                ] }
              { name = "juggernaut_bottom"
                displayName = Some "LightLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 75.0
                ]
                range = Some (ValueOrExpr.Concrete 435.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.3)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 12.0
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "-1 0 4"
                    "mount_maxangledif", "90.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.08"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "15.0"
                    "firestarter", "30.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.2"
                ] }
              { name = "juggernaut_bottom"
                displayName = Some "LightLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 75.0
                ]
                range = Some (ValueOrExpr.Concrete 435.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.3)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 12.0
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "1 0 4"
                    "mount_maxangledif", "90.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.08"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "15.0"
                    "firestarter", "30.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.2"
                ] }
              { name = "juggernaut_top"
                displayName = Some "LightLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 550.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.46667)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 12.0
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 1 0"
                    "mount_maxangledif", "270.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.15"
                    "corethickness", "0.19"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "30.0"
                    "firestarter", "70.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.25"
                    "proximitypriority", "-1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.6"
                ] }
              { name = "juggfootstep"
                displayName = Some "JuggStep"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 0.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = None
                areaOfEffect = Some 172.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.0
                impulseFactor = None
                noSelfDamage = Some true
                soundStart = None
                soundHit = None
                explosiongenerator = Some "custom:footstep-large"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "camerashake", "400.0"
                    "canattackground", "false"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "impactonly", "1.0"
                    "soundhitdry", "korgstep"
                    "soundhitdryvolume", "18.0"
                    "soundhitwet", "splssml"
                    "soundhitwetvolume", "16.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.35619354248 -4.26102086182 -1.35372924805"
                collisionVolumeScales = Some "105.219192505 63.5703582764 119.881469727"
                collisionVolumeType = Some "Box"
                damage = Some 27000.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 8.0
                metal = Some 13959.0
                object_ = Some "Units/corjugg_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 13500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 2.0
                metal = Some 2793.0
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
              ok = ["doom"]
              select = ["doom"] })
          customParams = Map.ofList [
              "customrange", "435.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "CorGantry"
              "techlevel", "3.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "20000.0"
              "nochasecategory", "VTOL"
          ] }

    let corkarg : UnitDef =
        { name = "corkarg"
          subfolder = "CorGantry"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 57000.0
          buildTime = ValueOrExpr.Concrete 94000.0
          health = ValueOrExpr.Concrete 12500.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORKARG.s3o"
          buildPic = Some "CORKARG.DDS"
          script = Some "Units/CORKARG.COB"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3med"
          selfDestructAs = Some "explosiont3"
          collisionVolumeOffsets = Some "0.0 -2.0 1"
          collisionVolumeScales = Some "59.0 63.0 42.0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 45.0
              maxAcc = 0.1104
              maxDec = 0.8211
              turnRate = 400.0
              movementClass = Some "HTBOT6"
              maxSlope = Some 160.0
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
              { name = "super_missile"
                displayName = Some "KarganethMissiles"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 180.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.3)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 64.0
                accuracy = None
                turret = Some true
                tolerance = Some 15000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rocklit1"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                    "speceffect", "retarget"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT VTOL"
                    "mount_fastautoretargeting", "true"
                    "mount_fastquerypointupdate", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "castshadow", "true"
                    "cegtag", "missiletrailsmall-simple"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "5.0"
                    "flighttime", "2.5"
                    "model", "cormissile3fast.s3o"
                    "smokecolor", "0.5"
                    "smokeperiod", "7.0"
                    "smokesize", "7.0"
                    "smoketime", "21.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splssml"
                    "startvelocity", "180.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "tracks", "true"
                    "turnrate", "21800.0"
                    "weaponacceleration", "250.0"
                    "weapontimer", "5.0"
                ] }
              { name = "karg_shoulder"
                displayName = Some "ShoulderRockets"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 100.0
                    "vtol", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.6)
                weaponVelocity = Some 820.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = Some 9950.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "packolau"
                soundHit = Some "packohit"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR GROUNDSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "72.0"
                    "fixedlauncher", "true"
                    "flighttime", "1.75"
                    "model", "cormissile.s3o"
                    "proximitypriority", "1.0"
                    "smokecolor", "0.95"
                    "smokeperiod", "5.0"
                    "smokesize", "4.4"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "false"
                    "startvelocity", "820.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "160.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "81 24.5 79"
                collisionVolumeType = Some "Box"
                damage = Some 2000.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 40.0
                metal = Some 1550.0
                object_ = Some "Units/corkarg_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 2500.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 620.0
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
              ok = ["mavbok1"]
              select = ["mavbsel1"] })
          customParams = Map.ofList [
              "model_author", "Flaka"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorGantry"
              "techlevel", "3.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "2500.0"
              "nochasecategory", "VTOL"
              "upright", "false"
          ] }

    let corkorg : UnitDef =
        { name = "corkorg"
          subfolder = "CorGantry"
          metalCost = ValueOrExpr.Concrete 29000.0
          energyCost = ValueOrExpr.Concrete 615000.0
          buildTime = ValueOrExpr.Concrete 730000.0
          health = ValueOrExpr.Concrete 149000.0
          sightDistance = ValueOrExpr.Concrete 845.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/corkorg.s3o"
          buildPic = Some "corkorg.DDS"
          script = Some "Units/corkorg.cob"
          corpse = Some "DEAD"
          explodeAs = Some "korgExplosion"
          selfDestructAs = Some "korgExplosionSelfd"
          collisionVolumeOffsets = Some "0 -6 -5"
          collisionVolumeScales = Some "97 160 85"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 37.0
              maxAcc = 0.1242
              maxDec = 0.8211
              turnRate = 437.0
              movementClass = Some "VBOT6"
              maxSlope = Some 17.0
              maxWaterDepth = Some 12.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 0.7392
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "corkorg_fire"
                displayName = Some "GaussCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 165.0
                ]
                range = Some (ValueOrExpr.Concrete 590.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.4)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 112.0
                accuracy = None
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.8
                noSelfDamage = Some true
                soundStart = Some "kroggie2xs"
                soundHit = Some "xplomed2xs"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = Some "1 0.9 0.45"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "alphadecay", "0.66"
                    "avoidfeature", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "intensity", "5.0"
                    "predictboost", "1.0"
                    "projectiles", "10.0"
                    "size", "4.0"
                    "sizedecay", "0.044"
                    "soundhitwet", "splsmed"
                    "sprayangle", "2750.0"
                    "stages", "8.0"
                    "weapontimer", "2.0"
                ] }
              { name = "corkorg_laser"
                displayName = Some "Experimental g2g Eradicator Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 1200.0
                    "default", 5500.0
                    "vtol", 2750.0
                ]
                range = Some (ValueOrExpr.Concrete 900.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray2"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.55 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.6"
                    "camerashake", "0.1"
                    "corethickness", "0.35"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "1200.0"
                    "firestarter", "90.0"
                    "laserflaresize", "8.25"
                    "proximitypriority", "-1.0"
                    "rgbcolor2", "0.95 1.0 0.7"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
              { name = "corkorg_rocket"
                displayName = Some "HeavyRockets"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 950.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 2600.0
                areaOfEffect = Some 200.0
                accuracy = None
                turret = None
                tolerance = Some 9000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "rocklit1"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "castshadow", "true"
                    "cegtag", "missiletrailmedium-starburst"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "metalpershot", "0.0"
                    "model", "corkbmissl1.s3o"
                    "proximitypriority", "-1.0"
                    "smokecolor", "0.7"
                    "smokeperiod", "9.0"
                    "smokesize", "12.0"
                    "smoketime", "36.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splslrg"
                    "startvelocity", "10.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "tracks", "true"
                    "turnrate", "15000.0"
                    "weaponacceleration", "230.0"
                    "weapontimer", "1.0"
                ] }
              { name = "krogkick"
                displayName = Some "KrogCrush"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 55.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.2)
                weaponVelocity = Some 1650.0
                areaOfEffect = Some 192.0
                accuracy = None
                turret = Some true
                tolerance = Some 9000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "xplosml2"
                soundHit = None
                explosiongenerator = Some "custom:crusherkrog"
                rgbColor = Some "0 0 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "-1.4 -1.5 1"
                    "mount_maxangledif", "170.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "camerashake", "1500.0"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "40.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splssml"
                    "thickness", "0.0"
                    "turnrate", "50000.0"
                ] }
              { name = "krogkick"
                displayName = Some "KrogCrush"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 55.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.2)
                weaponVelocity = Some 1650.0
                areaOfEffect = Some 192.0
                accuracy = None
                turret = Some true
                tolerance = Some 9000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "xplosml2"
                soundHit = None
                explosiongenerator = Some "custom:crusherkrog"
                rgbColor = Some "0 0 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "1.4 -1.5 1"
                    "mount_maxangledif", "170.0"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "camerashake", "1500.0"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "firestarter", "40.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splssml"
                    "thickness", "0.0"
                    "turnrate", "50000.0"
                ] }
              { name = "krogfootstep"
                displayName = Some "KrogStep"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 0.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = None
                areaOfEffect = Some 172.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.0
                impulseFactor = None
                noSelfDamage = Some true
                soundStart = None
                soundHit = None
                explosiongenerator = Some "custom:footstep-huge"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "camerashake", "400.0"
                    "canattackground", "false"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "impactonly", "1.0"
                    "soundhitdry", "korgstep"
                    "soundhitdryvolume", "18.0"
                    "soundhitwet", "splssml"
                    "soundhitwetvolume", "16.0"
                ] }
              { name = "krogweaponaim"
                displayName = Some "KrogAim"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = None
                reloadTime = None
                weaponVelocity = None
                areaOfEffect = Some 0.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = None
                impulseFactor = None
                noSelfDamage = Some true
                soundStart = None
                soundHit = None
                explosiongenerator = None
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "impactonly", "1.0"
                    "soundhitdry", "korgaim"
                    "soundhitdryvolume", "16.0"
                ] }
              { name = "krogweaponrestore"
                displayName = Some "KrogRestore"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = None
                reloadTime = None
                weaponVelocity = None
                areaOfEffect = Some 0.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = None
                impulseFactor = None
                noSelfDamage = Some true
                soundStart = None
                soundHit = None
                explosiongenerator = None
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "impactonly", "1.0"
                    "soundhitdry", "korgrestore2"
                    "soundhitdryvolume", "16.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 300.0)
              metalMake = None
              energyStorage = Some 5000.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -11 0"
                collisionVolumeScales = Some "96 88 134"
                collisionVolumeType = Some "box"
                damage = Some 57600.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 17668.0
                object_ = Some "Units/corkorg_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 28800.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 15067.0
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
              ok = ["krogok1"]
              select = ["krogsel1"] })
          customParams = Map.ofList [
              "customrange", "590.0"
              "model_author", "FireStorm"
              "normaltex", "unittextures/cor_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "CorGantry"
              "techlevel", "3.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "29000.0"
              "nochasecategory", "VTOL GROUNDSCOUT"
              "selfdestructcountdown", "10.0"
              "upright", "true"
          ] }

    let corshiva : UnitDef =
        { name = "corshiva"
          subfolder = "CorGantry"
          metalCost = ValueOrExpr.Concrete 1550.0
          energyCost = ValueOrExpr.Concrete 23000.0
          buildTime = ValueOrExpr.Concrete 40000.0
          health = ValueOrExpr.Concrete 9400.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORSHIVA.s3o"
          buildPic = Some "CORSHIVA.DDS"
          script = Some "Units/CORSHIVA.cob"
          corpse = Some "DEAD"
          explodeAs = Some "explosiont3"
          selfDestructAs = Some "explosiont3xl"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "61 60 61"
          collisionVolumeType = Some "cylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 48.3
              maxAcc = 0.069
              maxDec = 0.8211
              turnRate = 708.39996
              movementClass = Some "HABOT5"
              maxSlope = Some 36.0
              maxWaterDepth = Some 32.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.0626
              cruiseAltitude = None
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "shiva_gun"
                displayName = Some "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 600.0
                    "subs", 130.0
                    "vtol", 55.0
                ]
                range = Some (ValueOrExpr.Concrete 650.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 310.0
                areaOfEffect = Some 176.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.8
                noSelfDamage = Some true
                soundStart = Some "cannhvy2"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splslrg"
                ] }
              { name = "shiva_rocket"
                displayName = Some "HeavyRockets"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 750.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 7.0)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 60.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.65
                impulseFactor = Some 0.8
                noSelfDamage = Some true
                soundStart = Some "Rockhvy1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "castshadow", "true"
                    "cegtag", "missiletrailmedium-starburst"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "7.0"
                    "metalpershot", "0.0"
                    "model", "corkbmissl1.s3o"
                    "smokecolor", "0.7"
                    "smokeperiod", "9.0"
                    "smokesize", "12.0"
                    "smoketime", "38.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splssml"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "15000.0"
                    "weaponacceleration", "100.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -15 0"
                collisionVolumeScales = Some "48.4013214111 35.5686035156 49.8471069336"
                collisionVolumeType = Some "Box"
                damage = Some 1500.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 10.0
                metal = Some 937.0
                object_ = Some "Units/corshiva_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 2000.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 375.0
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
              ok = ["mavbok1"]
              select = ["mavbsel1"] })
          customParams = Map.ofList [
              "customrange", "650.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorGantry"
              "techlevel", "3.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "cantbetransported", "true"
              "mass", "1550.0"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let corsok : UnitDef =
        { name = "corsok"
          subfolder = "CorGantry"
          metalCost = ValueOrExpr.Concrete 950.0
          energyCost = ValueOrExpr.Concrete 19000.0
          buildTime = ValueOrExpr.Concrete 34000.0
          health = ValueOrExpr.Concrete 4200.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORSOK.s3o"
          buildPic = Some "CORSOK.DDS"
          script = Some "Units/corsok.cob"
          corpse = Some "dead"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "52 40 58"
          collisionVolumeType = Some "CylY"
          seismicSignature = None
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 45.3
              maxAcc = 0.01731
              maxDec = 0.01731
              turnRate = 290.0
              movementClass = Some "HHOVER4"
              maxSlope = Some 16.0
              maxWaterDepth = Some 0.0
              canFly = false
              canMove = true
              floater = false
              turnInPlace = Some true
              turnInPlaceAngleLimit = Some 90.0
              turnInPlaceSpeedLimit = Some 1.056
              cruiseAltitude = None
              minWaterDepth = None
              waterline = Some 7.0 })
          builder = None
          weapons = Some [
              { name = "corsok_laser"
                displayName = Some "Disruptor Bolt"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 750.0
                    "subs", 500.0
                    "vtol", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 725.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.5)
                weaponVelocity = Some 1673.0
                areaOfEffect = Some 20.0
                accuracy = None
                turret = Some true
                tolerance = Some 525.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = Some "lasrfir5"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-aqua"
                rgbColor = Some "0.0 0.5 0.8"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "collideenemy", "true"
                    "corethickness", "1.5"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.05"
                    "energypershot", "500.0"
                    "intensity", "2.2"
                    "rgbcolor2", "0.2 0.8 1.0"
                    "soundhitdry", "xplosml5"
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.5"
                    "tracks", "true"
                    "turnrate", "20000.0"
                ] }
              { name = "depthcharge"
                displayName = Some "Depthcharge launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 225.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 140.0
                areaOfEffect = Some 24.0
                accuracy = None
                turret = Some true
                tolerance = Some 1000.0
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "torpedo1"
                soundHit = Some "xplodep2"
                explosiongenerator = Some "custom:genericshellexplosion-medium-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSUB"
                    "mount_maindir", "0 -1 0"
                    "mount_maxangledif", "179.0"
                    "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "3.0"
                    "model", "cordepthcharge.s3o"
                    "predictboost", "0.0"
                    "startvelocity", "120.0"
                    "tracks", "true"
                    "turnrate", "6000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "20.0"
                    "weapontimer", "3.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 7000.0
                featureDead = Some "heap"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 15.0
                metal = Some 588.0
                object_ = Some "Units/corsok_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 3500.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 221.0
                object_ = Some "Units/cor4x4d.s3o"
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
              ok = ["hovlgok2"]
              select = ["hovlgsl2"] })
          customParams = Map.ofList [
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorGantry"
              "techlevel", "3.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "canattack", "true"
              "canguard", "true"
              "canpatrol", "true"
              "canstop", "1.0"
              "cantbetransported", "true"
              "nochasecategory", "VTOL"
              "radardistance", "0.0"
              "sonardistance", "550.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "corcat", corcat
            "cordemon", cordemon
            "corjugg", corjugg
            "corkarg", corkarg
            "corkorg", corkorg
            "corshiva", corshiva
            "corsok", corsok
        ]
