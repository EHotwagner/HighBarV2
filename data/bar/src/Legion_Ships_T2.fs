// Auto-generated BAR unit data: Legion/Ships/T2
namespace BarData.Units

open BarData

module Legion_Ships_T2 =

    let leganavyaaship : UnitDef =
        { name = "leganavyaaship"
          subfolder = "Legion/Ships/T2"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 20100.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 465.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/leganavyaaship.s3o"
          buildPic = Some "leganavyaaship.DDS"
          script = Some "Units/leganavyaaship.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "38 35 85"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 57.0
              maxAcc = 0.03
              maxDec = 0.03
              turnRate = 320.0
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
              { name = "leg_t2_microflak_mobile"
                displayName = Some "Dual Rotary Microflak Cannons"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "vtol", 40.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.166)
                weaponVelocity = Some 1900.0
                areaOfEffect = Some 35.0
                accuracy = Some 1000.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "flakfire"
                soundHit = Some "flakhit"
                explosiongenerator = Some "custom:flakshard"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "LIGHTAIRSCOUT"
                    "mount_burstcontrolwhenoutofarc", "2.0"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "VTOL"
                    "burst", "3.0"
                    "burstrate", "0.02"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "flaktrailaamg"
                    "craterareaofeffect", "35.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "collidefriendly", "false"
                    "gravityaffected", "true"
                    "size", "0.0"
                    "sizedecay", "0.08"
                    "soundhitwet", "splsmed"
                    "stages", "0.0"
                    "weapontimer", "1.0"
                ] }
              { name = "light_antiair_missile"
                displayName = Some "Advanced Anti-Air Salvo Missile Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 20.0
                ]
                range = Some (ValueOrExpr.Concrete 860.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 2500.0
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR"
                    "mount_onlytargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "avoidfriendly", "false"
                    "burst", "3.0"
                    "burstrate", "0.005"
                    "collidefriendly", "false"
                    "dance", "150.0"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "model", "legsmallrocket.s3o"
                    "smoketrail", "true"
                    "smokecolor", "0.95"
                    "smokeperiod", "5.0"
                    "smokesize", "0.5"
                    "smoketime", "5.0"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "800.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "fixedlauncher", "true"
                    "weaponacceleration", "300.0"
                    "weapontimer", "2.0"
                ] }
              { name = "light_antiair_missile"
                displayName = Some "Advanced Anti-Air Salvo Missile Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 20.0
                ]
                range = Some (ValueOrExpr.Concrete 860.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 2500.0
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR"
                    "mount_onlytargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "avoidfriendly", "false"
                    "burst", "3.0"
                    "burstrate", "0.005"
                    "collidefriendly", "false"
                    "dance", "150.0"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "model", "legsmallrocket.s3o"
                    "smoketrail", "true"
                    "smokecolor", "0.95"
                    "smokeperiod", "5.0"
                    "smokesize", "0.5"
                    "smoketime", "5.0"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "800.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "fixedlauncher", "true"
                    "weaponacceleration", "300.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "38 25 85"
                collisionVolumeType = Some "Box"
                damage = Some 2940.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 500.0
                object_ = Some "Units/leganavyaaship_dead.s3o"
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
              "model_author", "ZephyrSkies, Tharsis (AA Guns)"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Ships/T2"
              "techlevel", "2.0"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "900.0"
              "buildangle", "16384.0"
              "movestate", "0.0"
              "nochasecategory", "NOTAIR"
          ] }

    let leganavyantinukecarrier : UnitDef =
        { name = "leganavyantinukecarrier"
          subfolder = "Legion/Ships/T2"
          metalCost = ValueOrExpr.Concrete 1600.0
          energyCost = ValueOrExpr.Concrete 13000.0
          buildTime = ValueOrExpr.Concrete 26800.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 1000.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/leganavyantinukecarrier.s3o"
          buildPic = Some "leganavyantinukecarrier.DDS"
          script = Some "Units/leganavyantinukecarrier.cob"
          corpse = Some "DEAD"
          explodeAs = Some "minifusionExplosion"
          selfDestructAs = Some "minifusionExplosion"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "59 52 154"
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
              { name = "leg_drone_controller"
                displayName = Some "Multi-Drone Control Matrix"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1300.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 1000.0
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "carried_unit", "legdrone"
                    "carrierdeaththroe", "release"
                    "dockingpieces", "16 17 18 19 20 21"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "metalpershot", "15.0"
                    "energypershot", "500.0"
                    "size", "0.0"
                    "soundhitwet", ""
                ] }
              { name = "amd_rocket"
                displayName = Some "ICBM intercepting missile launcher"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "59 42 154"
                collisionVolumeType = Some "Box"
                damage = Some 9168.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 700.0
                object_ = Some "Units/leganavyantinukecarrier_dead.s3o"
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
              "maxrange", "1300.0"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Ships/T2"
              "inheritxpratemultiplier", "1.0"
              "childreninheritxp", "DRONE"
              "parentsinheritxp", "DRONE"
              "techlevel", "2.0"
              "unitgroup", "antinuke"
              "restrictions_exclusion", "_noantinuke_"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "canassist", "false"
              "canattack", "true"
              "canreclaim", "false"
              "canrepair", "false"
              "canrestore", "false"
              "energypershot", "7500.0"
              "mass", "10000.0"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "radardistance", "1500.0"
              "radaremitheight", "56.0"
              "sightemitheight", "56.0"
              "sonardistance", "760.0"
          ] }

    let leganavyantiswarm : UnitDef =
        { name = "leganavyantiswarm"
          subfolder = "Legion/Ships/T2"
          metalCost = ValueOrExpr.Concrete 500.0
          energyCost = ValueOrExpr.Concrete 8500.0
          buildTime = ValueOrExpr.Concrete 11270.0
          health = ValueOrExpr.Concrete 2300.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/leganavyantiswarm.s3o"
          buildPic = Some "leganavyantiswarm.DDS"
          script = Some "Units/leganavyantiswarm.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 4"
          collisionVolumeScales = Some "28 30 82"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 105.0
              maxAcc = 0.07
              maxDec = 0.07
              turnRate = 500.0
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
              { name = "legion_riot_cannon_t2"
                displayName = Some "Medium Blast Riot Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 210.0
                    "subs", 90.0
                    "vtol", 35.0
                ]
                range = Some (ValueOrExpr.Concrete 350.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.1)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 144.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 2.5
                noSelfDamage = Some true
                soundStart = Some "largegun"
                soundHit = Some "corlevlrhit"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "tolerace", "3000.0"
                    "firetolerance", "3000.0"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "soundhitwet", "splsmed"
                    "soundhitvolume", "12.0"
                    "soundstartvolume", "14.0"
                    "separation", "2.0"
                    "nogap", "false"
                    "size", "4.0"
                    "sizeDecay", "0.07"
                    "stages", "10.0"
                    "alphaDecay", "0.1"
                ] }
              { name = "light_antiair_missile"
                displayName = Some "Advanced g2a Salvo Missile Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 24.0
                ]
                range = Some (ValueOrExpr.Concrete 760.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 2500.0
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "burst", "3.0"
                    "burstrate", "0.005"
                    "dance", "150.0"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "model", "legsmallrocket.s3o"
                    "smoketrail", "true"
                    "smokecolor", "0.95"
                    "smokeperiod", "5.0"
                    "smokesize", "0.5"
                    "smoketime", "5.0"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "800.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "300.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.255500793457 0.0 -1.26264953613"
                collisionVolumeScales = Some "20.0704803467 16.0 67.0992736816"
                collisionVolumeType = Some "Box"
                damage = Some 500.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 390.0
                object_ = Some "Units/leganavyantiswarm_dead.s3o"
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
                metal = Some 195.0
                object_ = Some "Units/arm3X3A.s3o"
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
              "model_author", "EnderRobo"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Ships/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "nochasecategory", "VTOL UNDERWATER"
              "radardistance", "750.0"
              "radaremitheight", "52.0"
          ] }

    let leganavyartyship : UnitDef =
        { name = "leganavyartyship"
          subfolder = "Legion/Ships/T2"
          metalCost = ValueOrExpr.Concrete 13000.0
          energyCost = ValueOrExpr.Concrete 125000.0
          buildTime = ValueOrExpr.Concrete 204750.0
          health = ValueOrExpr.Concrete 22000.0
          sightDistance = ValueOrExpr.Concrete 689.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/leganavyartyship.s3o"
          buildPic = Some "leganavyartyship.DDS"
          script = Some "Units/leganavyartyship.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flagshipExplosion"
          selfDestructAs = Some "flagshipExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "79 80 200"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 48.0
              maxAcc = 0.01
              maxDec = 0.01
              turnRate = 125.0
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
              { name = "leg_mobile_cluster_lrpc_cannon"
                displayName = Some "Dual Quad-Barrelled Long-Range Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 350.0
                    "subs", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 2100.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.4)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 150.0
                accuracy = Some 300.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "lrpcshot3"
                soundHit = Some "lrpcexplo"
                explosiongenerator = Some "custom:starfire-explosion"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "cluster_def", "cluster_munition_main"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "sprayangle", "600.0"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "cegtag", "starfire_arty"
                    "collidefriendly", "false"
                    "craterareaofeffect", "116.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "burst", "4.0"
                    "burstrate", "0.2"
                    "energypershot", "2500.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "8.0"
                    "leadbonus", "0.0"
                    "model", "legbomb.s3o"
                    "soundhitwet", "splshbig"
                    "soundhitvolume", "38.0"
                    "soundstartvolume", "24.0"
                ] }
              { name = "leg_mobile_cluster_plasma"
                displayName = Some "Heavy Artillery Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 250.0
                    "lboats", 250.0
                    "subs", 55.0
                    "vtol", 55.0
                ]
                range = Some (ValueOrExpr.Concrete 1600.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.8)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 120.0
                accuracy = Some 50.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "cannhvy5"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:ministarfire-explosion"
                rgbColor = Some "0.7 0.7 1.0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "cluster_def", "cluster_munition_secondary"
                ]
                extras = Map.ofList [
                    "mount_maindir", "-0.342 0 0.940"
                    "mount_maxangledif", "280.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "avoidfriendly", "false"
                    "cegtag", "starfire_tiny"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "leg_mobile_cluster_plasma"
                displayName = Some "Heavy Artillery Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 250.0
                    "lboats", 250.0
                    "subs", 55.0
                    "vtol", 55.0
                ]
                range = Some (ValueOrExpr.Concrete 1600.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.8)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 120.0
                accuracy = Some 50.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "cannhvy5"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:ministarfire-explosion"
                rgbColor = Some "0.7 0.7 1.0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "cluster_def", "cluster_munition_secondary"
                ]
                extras = Map.ofList [
                    "mount_maindir", "0.259 0 0.966"
                    "mount_maxangledif", "320.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "avoidfriendly", "false"
                    "cegtag", "starfire_tiny"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "leg_mobile_cluster_plasma"
                displayName = Some "Heavy Artillery Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 250.0
                    "lboats", 250.0
                    "subs", 55.0
                    "vtol", 55.0
                ]
                range = Some (ValueOrExpr.Concrete 1600.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.8)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 120.0
                accuracy = Some 50.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "cannhvy5"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:ministarfire-explosion"
                rgbColor = Some "0.7 0.7 1.0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "cluster_def", "cluster_munition_secondary"
                ]
                extras = Map.ofList [
                    "mount_maindir", "-0.174 0 0.985"
                    "mount_maxangledif", "330.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "avoidfriendly", "false"
                    "cegtag", "starfire_tiny"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "79 65 200"
                collisionVolumeType = Some "Box"
                damage = Some 85500.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 18.0
                height = Some 4.0
                metal = Some 8500.0
                object_ = Some "Units/leganavyartyship_dead.s3o"
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
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Ships/T2"
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

    let leganavybattleship : UnitDef =
        { name = "leganavybattleship"
          subfolder = "Legion/Ships/T2"
          metalCost = ValueOrExpr.Concrete 2900.0
          energyCost = ValueOrExpr.Concrete 21000.0
          buildTime = ValueOrExpr.Concrete 49350.0
          health = ValueOrExpr.Concrete 10350.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/leganavybattleship.s3o"
          buildPic = Some "leganavybattleship.DDS"
          script = Some "Units/leganavybattleship.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeexplosiongeneric"
          selfDestructAs = Some "hugeexplosiongenericSelfD"
          collisionVolumeOffsets = Some "0 -15 -2"
          collisionVolumeScales = Some "48 48 120"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 25.0
              maxAcc = 0.005
              maxDec = 0.005
              turnRate = 90.0
              movementClass = Some "HOVER7"
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
              { name = "burst_plasma_t2"
                displayName = Some "Heavy long-range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 270.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.7)
                weaponVelocity = Some 440.0
                areaOfEffect = Some 200.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "burstrate", "0.066"
                    "burst", "3.0"
                    "avoidfeature", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                    "sprayangle", "750.0"
                ] }
              { name = "burst_plasma_t2"
                displayName = Some "Heavy long-range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 270.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.7)
                weaponVelocity = Some 440.0
                areaOfEffect = Some 200.0
                accuracy = None
                turret = Some true
                tolerance = Some 5000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy1"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "burstrate", "0.066"
                    "burst", "3.0"
                    "avoidfeature", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                    "sprayangle", "750.0"
                ] }
              { name = "legion_shotgun"
                displayName = Some "Medium Shotgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 20.0
                    "vtol", 6.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 2.9
                noSelfDamage = Some true
                soundStart = Some "kroggie2xs"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "projectiles", "10.0"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.015"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "3.0"
                    "sprayangle", "950.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "2.0"
                    "cylindertargeting", "true"
                ] }
              { name = "legion_shotgun"
                displayName = Some "Medium Shotgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 20.0
                    "vtol", 6.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 2.9
                noSelfDamage = Some true
                soundStart = Some "kroggie2xs"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "projectiles", "10.0"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.015"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "3.0"
                    "sprayangle", "950.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "2.0"
                    "cylindertargeting", "true"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -15 -2"
                collisionVolumeScales = Some "48 38 120"
                collisionVolumeType = Some "CylZ"
                damage = Some 13662.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 1650.0
                object_ = Some "Units/leganavybattleship_dead.s3o"
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
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Ships/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
              "speedfactorinwater", "2.6"
              "speedfactoratdepth", "15.0"
          ]
          extras = Map.ofList [
              "buildangle", "16000.0"
              "usePieceCollisionVolumes", "true"
              "movestate", "0.0"
              "nochasecategory", "VTOL"
          ] }

    let leganavybattlesub : UnitDef =
        { name = "leganavybattlesub"
          subfolder = "Legion/Ships/T2"
          metalCost = ValueOrExpr.Concrete 1100.0
          energyCost = ValueOrExpr.Concrete 16000.0
          buildTime = ValueOrExpr.Concrete 25000.0
          health = ValueOrExpr.Concrete 2350.0
          sightDistance = ValueOrExpr.Concrete 450.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/leganavybattlesub.s3o"
          buildPic = Some "leganavybattlesub.DDS"
          script = Some "Units/leganavybattlesub.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumExplosionGeneric-uw"
          selfDestructAs = Some "mediumExplosionGenericSelfd-uw"
          collisionVolumeOffsets = Some "0 5 0"
          collisionVolumeScales = Some "40 26 64"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 72.0
              maxAcc = 0.0425
              maxDec = 0.0425
              turnRate = 360.0
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
              { name = "torpedo_swarm"
                displayName = Some "Packhound Torpedo System"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 150.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 250.0
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "180.0"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "burst", "3.0"
                    "burstrate", "0.33"
                    "cegtag", "torpedotrail-small"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "legtorpedomini.s3o"
                    "soundhitvolume", "18.0"
                    "startvelocity", "200.0"
                    "tracks", "false"
                    "waterweapon", "true"
                    "weaponacceleration", "10.0"
                    "weapontimer", "2.0"
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
                object_ = Some "Units/leganavybattlesub_dead.s3o"
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
              "model_author", "Model by Tharsis, Concept by Chris/Airnac"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "legion/Navy/T2"
              "techlevel", "2.0"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "nochasecategory", "VTOL"
              "sonardistance", "500.0"
              "upright", "true"
          ] }

    let leganavycruiser : UnitDef =
        { name = "leganavycruiser"
          subfolder = "Legion/Ships/T2"
          metalCost = ValueOrExpr.Concrete 900.0
          energyCost = ValueOrExpr.Concrete 10800.0
          buildTime = ValueOrExpr.Concrete 20290.0
          health = ValueOrExpr.Concrete 5600.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/leganavycruiser.s3o"
          buildPic = Some "leganavycruiser.DDS"
          script = Some "Units/leganavycruiser.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "38 55 100"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 57.0
              maxAcc = 0.028
              maxDec = 0.028
              turnRate = 270.0
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
              { name = "mg_guns"
                displayName = Some "Twin Rapid-fire Machine Guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 24.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 958.0
                areaOfEffect = Some 32.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 16000.0
                edgeEffectiveness = Some 0.5
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun12"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.066"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.06"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "6.0"
                    "soundtrigger", "true"
                    "sprayangle", "1024.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "3.0"
                ] }
              { name = "advdepthcharge"
                displayName = Some "Medium depthcharge launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 225.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.8)
                weaponVelocity = Some 225.0
                areaOfEffect = Some 32.0
                accuracy = None
                turret = Some true
                tolerance = Some 32767.0
                edgeEffectiveness = Some 0.95
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
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "300.0"
                    "mount_onlytargetcategory", "CANBEUW UNDERWATER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "legbasictorpedo.s3o"
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "38 45 100"
                collisionVolumeType = Some "Box"
                damage = Some 5578.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 500.0
                object_ = Some "Units/leganavycruiser_dead.s3o"
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
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Ships/T2"
              "techlevel", "2.0"
              "unitgroup", "weaponsub"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "nochasecategory", "VTOL"
              "sonardistance", "375.0"
          ] }

    let leganavyflagship : UnitDef =
        { name = "leganavyflagship"
          subfolder = "Legion/Ships/T2"
          metalCost = ValueOrExpr.Concrete 16000.0
          energyCost = ValueOrExpr.Concrete 240000.0
          buildTime = ValueOrExpr.Concrete 269000.0
          health = ValueOrExpr.Concrete 48000.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/leganavyflagship.s3o"
          buildPic = Some "leganavyflagship.DDS"
          script = Some "Units/leganavyflagship.cob"
          corpse = Some "DEAD"
          explodeAs = Some "FlagshipExplosion"
          selfDestructAs = Some "FlagshipExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "72 95 208"
          collisionVolumeType = Some "CylZ"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 63.0
              maxAcc = 0.012
              maxDec = 0.012
              turnRate = 150.0
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
              { name = "targeting_system"
                displayName = Some "Targeting System"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.5)
                weaponVelocity = Some 360.0
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "size", "0.0"
                    "soundhitwet", ""
                ] }
              { name = "leg_experimental_heatray"
                displayName = Some "Dual Experimental Thermal Ordnance Generators"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 17.0
                    "default", 33.0
                    "vtol", 14.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Expr ".033")
                weaponVelocity = None
                areaOfEffect = Some 90.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray4burn"
                soundHit = None
                explosiongenerator = Some "custom:heatray-large"
                rgbColor = Some "1 0.3 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "mount_slaveto", "1.0"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "beamttl", "0.033"
                    "camerashake", "0.1"
                    "corethickness", "0.3"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "17.0"
                    "firestarter", "90.0"
                    "firetolerance", "50.0"
                    "largebeamlaser", "true"
                    "intensity", "5.0"
                    "laserflaresize", "6.5"
                    "predictboost", "0.0"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "1 0.8 0.5"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "scrollspeed", "5.0"
                    "soundstartvolume", "11.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "6.5"
                    "tilelength", "500.0"
                ] }
              { name = "leg_experimental_heatray"
                displayName = Some "Dual Experimental Thermal Ordnance Generators"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 17.0
                    "default", 33.0
                    "vtol", 14.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Expr ".033")
                weaponVelocity = None
                areaOfEffect = Some 90.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray4burn"
                soundHit = None
                explosiongenerator = Some "custom:heatray-large"
                rgbColor = Some "1 0.3 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "mount_slaveto", "1.0"
                    "avoidfeature", "false"
                    "beamtime", "0.033"
                    "beamttl", "0.033"
                    "camerashake", "0.1"
                    "corethickness", "0.3"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "17.0"
                    "firestarter", "90.0"
                    "firetolerance", "50.0"
                    "largebeamlaser", "true"
                    "intensity", "5.0"
                    "laserflaresize", "6.5"
                    "predictboost", "0.0"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "1 0.8 0.5"
                    "soundhitdry", "flamhit1"
                    "soundhitwet", "sizzle"
                    "scrollspeed", "5.0"
                    "soundstartvolume", "11.0"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "6.5"
                    "tilelength", "500.0"
                ] }
              { name = "leg_experimental_railgun"
                displayName = Some "Dual Naval-Series Rail Accelerators"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 300.0
                    "default", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 2850.0
                areaOfEffect = Some 80.0
                accuracy = None
                turret = Some true
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "railgunxl"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "0.34 0.64 0.94"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_maindir", "0.966 0 0.259"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "mount_maxangledif", "180.0"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "cegtag", "railgun"
                    "collisionSize", "0.667"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "energypershot", "600.0"
                    "firestarter", "1.0"
                    "hardstop", "true"
                    "impactonly", "true"
                    "intensity", "0.8"
                    "noexplode", "true"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "0.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "30.0"
                    "thickness", "4.0"
                    "firetolerance", "7000.0"
                ] }
              { name = "leg_experimental_railgun"
                displayName = Some "Dual Naval-Series Rail Accelerators"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 300.0
                    "default", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 2850.0
                areaOfEffect = Some 80.0
                accuracy = None
                turret = Some true
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "railgunxl"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "0.34 0.64 0.94"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_maindir", "-0.966 0 0.259"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "mount_maxangledif", "180.0"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "cegtag", "railgun"
                    "collisionSize", "0.667"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "energypershot", "600.0"
                    "firestarter", "1.0"
                    "hardstop", "true"
                    "impactonly", "true"
                    "intensity", "0.8"
                    "noexplode", "true"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "0.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "30.0"
                    "thickness", "4.0"
                    "firetolerance", "7000.0"
                ] }
              { name = "leg_experimental_railgun"
                displayName = Some "Dual Naval-Series Rail Accelerators"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 300.0
                    "default", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 2850.0
                areaOfEffect = Some 80.0
                accuracy = None
                turret = Some true
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "railgunxl"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "0.34 0.64 0.94"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_maindir", "0.966 0 -0.259"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "mount_maxangledif", "180.0"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "cegtag", "railgun"
                    "collisionSize", "0.667"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "energypershot", "600.0"
                    "firestarter", "1.0"
                    "hardstop", "true"
                    "impactonly", "true"
                    "intensity", "0.8"
                    "noexplode", "true"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "0.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "30.0"
                    "thickness", "4.0"
                    "firetolerance", "7000.0"
                ] }
              { name = "leg_experimental_railgun"
                displayName = Some "Dual Naval-Series Rail Accelerators"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "commanders", 300.0
                    "default", 800.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 2850.0
                areaOfEffect = Some 80.0
                accuracy = None
                turret = Some true
                tolerance = Some 7000.0
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 1.0
                noSelfDamage = Some true
                soundStart = Some "railgunxl"
                soundHit = Some "mavgun3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "0.34 0.64 0.94"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_maindir", "-0.966 0 -0.259"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "mount_maxangledif", "180.0"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "cegtag", "railgun"
                    "collisionSize", "0.667"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "energypershot", "600.0"
                    "firestarter", "1.0"
                    "hardstop", "true"
                    "impactonly", "true"
                    "intensity", "0.8"
                    "noexplode", "true"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "0.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "30.0"
                    "thickness", "4.0"
                    "firetolerance", "7000.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 500.0)
              metalMake = None
              energyStorage = None
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "72 95 208"
                collisionVolumeType = Some "Box"
                damage = Some 93000.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 18.0
                height = Some 4.0
                metal = Some 9450.0
                object_ = Some "Units/leganavyflagship_dead.s3o"
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
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "paralyzemultiplier", "0.0"
              "subfolder", "Legion/Ships/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "mass", "9999999.0"
              "movestate", "0.0"
              "radardistance", "1000.0"
              "radaremitheight", "64.0"
              "sightemitheight", "64.0"
          ] }

    let leganavyheavysub : UnitDef =
        { name = "leganavyheavysub"
          subfolder = "Legion/Ships/T2"
          metalCost = ValueOrExpr.Concrete 1900.0
          energyCost = ValueOrExpr.Concrete 29000.0
          buildTime = ValueOrExpr.Concrete 34370.0
          health = ValueOrExpr.Concrete 3900.0
          sightDistance = ValueOrExpr.Concrete 570.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/leganavyheavysub.s3o"
          buildPic = Some "leganavyheavysub.DDS"
          script = Some "Units/leganavyheavysub.cob"
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
              { name = "torpedo_large"
                displayName = Some "Long-Range Heavy Torpedo"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                    "model", "legfattorpedo.s3o"
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
                object_ = Some "Units/leganavyheavysub_dead.s3o"
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
              "model_author", "Model by Tharsis, Concept by Chris/Airnac"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "legion/Navy/T2"
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

    let leganavymissileship : UnitDef =
        { name = "leganavymissileship"
          subfolder = "Legion/Ships/T2"
          metalCost = ValueOrExpr.Concrete 2000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 23000.0
          health = ValueOrExpr.Concrete 3350.0
          sightDistance = ValueOrExpr.Concrete 318.5
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/leganavymissileship.s3o"
          buildPic = Some "leganavymissileship.DDS"
          script = Some "Units/leganavymissileship.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "38 40 95"
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
              { name = "leg_salvo_vertical_rocket"
                displayName = Some "Heavy Long-Range Vertical Salvo Rocket Launcher"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "commanders", 300.0
                    "default", 450.0
                ]
                range = Some (ValueOrExpr.Concrete 1550.0)
                reloadTime = Some (ValueOrExpr.Concrete 9.0)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 80.0
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "projectile_destruction_method", "descend"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "burst", "6.0"
                    "burstrate", "0.12"
                    "sprayangle", "450.0"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "cegtag", "missiletrailmship"
                    "craterareaofeffect", "68.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flighttime", "15.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "interceptedbyshieldtype", "8.0"
                    "metalpershot", "0.0"
                    "model", "legmediumrocket.s3o"
                    "mygravity", "0.08"
                    "proximitypriority", "1.0"
                    "smoketrail", "false"
                    "soundhitwet", "splslrg"
                    "texture1", "null"
                    "texture2", "null"
                    "texture3", "null"
                    "turnrate", "24384.0"
                    "weaponacceleration", "80.0"
                    "weapontimer", "1.5"
                ] }
              { name = "leg_light_aa_missile"
                displayName = Some "Anti-Air Salvo Missile Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 20.0
                ]
                range = Some (ValueOrExpr.Concrete 760.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 2500.0
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
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "avoidfriendly", "false"
                    "burst", "3.0"
                    "burstrate", "0.005"
                    "collidefriendly", "false"
                    "dance", "150.0"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "model", "legsmallrocket.s3o"
                    "smoketrail", "true"
                    "smokecolor", "0.95"
                    "smokeperiod", "5.0"
                    "smokesize", "0.5"
                    "smoketime", "5.0"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "800.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "fixedlauncher", "true"
                    "weaponacceleration", "300.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "38 30 95"
                collisionVolumeType = Some "Box"
                damage = Some 2700.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 4.0
                metal = Some 1000.0
                object_ = Some "Units/leganavymissileship_dead.s3o"
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
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorShips/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "movestate", "0.0"
              "nochasecategory", "VTOL"
              "radardistance", "1000.0"
          ] }

    let leganavyradjamship : UnitDef =
        { name = "leganavyradjamship"
          subfolder = "Legion/Ships/T2"
          metalCost = ValueOrExpr.Concrete 450.0
          energyCost = ValueOrExpr.Concrete 6000.0
          buildTime = ValueOrExpr.Concrete 19800.0
          health = ValueOrExpr.Concrete 1700.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/leganavyradjamship.s3o"
          buildPic = Some "leganavyradjamship.DDS"
          script = Some "Units/leganavyradjamship.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumexplosiongenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "34 40 90"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 42.0
              maxAcc = 0.042
              maxDec = 0.042
              turnRate = 350.0
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
                object_ = Some "Units/leganavyradjamship_dead.s3o"
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
              "normaltex", "unittextures/leg_normal.dds"
              "off_on_stun", "true"
              "subfolder", "Legion/Ships/T2"
              "techlevel", "2.0"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "energyupkeep", "120.0"
              "nochasecategory", "MOBILE"
              "onoffable", "true"
              "radardistancejam", "650.0"
              "radardistance", "1850.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "leganavyaaship", leganavyaaship
            "leganavyantinukecarrier", leganavyantinukecarrier
            "leganavyantiswarm", leganavyantiswarm
            "leganavyartyship", leganavyartyship
            "leganavybattleship", leganavybattleship
            "leganavybattlesub", leganavybattlesub
            "leganavycruiser", leganavycruiser
            "leganavyflagship", leganavyflagship
            "leganavyheavysub", leganavyheavysub
            "leganavymissileship", leganavymissileship
            "leganavyradjamship", leganavyradjamship
        ]
