// Auto-generated BAR unit data: Legion/Other/Commanders
namespace BarData.Units

open BarData

module Legion_Other_Commanders =

    let legcomecon : UnitDef =
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
                displayName = Some "RiotCannon"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "Level1TorpedoLauncher"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "EMP Grenade"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "Pop-up rapid-fire g2a missile launcher"
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
                onlyTargetCategory = None
                badTargetCategory = None
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

    let legcomoff : UnitDef =
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
                displayName = Some "Rapid-fire a2g machine guns"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "Level1TorpedoLauncher"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "EMP Grenade"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "Pop-up rapid-fire g2a missile launcher"
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
                onlyTargetCategory = None
                badTargetCategory = None
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

    let legcomt2com : UnitDef =
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
                displayName = Some "Rapid-fire a2g machine guns"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "Level1TorpedoLauncher"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "EMP Grenade"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "Pop-up rapid-fire g2a missile launcher"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "Parabolic trajectory g2g multi-rocket launcher"
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
                onlyTargetCategory = None
                badTargetCategory = None
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

    let legcomt2def : UnitDef =
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
                displayName = Some "Level1TorpedoLauncher"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "EMP Grenade"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "Pop-up rapid-fire g2a missile launcher"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "PlasmaRepulsor"
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
                onlyTargetCategory = None
                badTargetCategory = None
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

    let legcomt2off : UnitDef =
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
                displayName = Some "Rapid-fire a2g machine guns"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "Level1TorpedoLauncher"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "EMP Grenade"
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
                onlyTargetCategory = None
                badTargetCategory = None
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
                displayName = Some "Pop-up rapid-fire g2a missile launcher"
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
                onlyTargetCategory = None
                badTargetCategory = None
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

    let all : (string * UnitDef) list =
        [
            "legcomecon", legcomecon
            "legcomoff", legcomoff
            "legcomt2com", legcomt2com
            "legcomt2def", legcomt2def
            "legcomt2off", legcomt2off
        ]
