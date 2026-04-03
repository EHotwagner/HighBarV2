// Auto-generated BAR unit data: CorAircraft/T2
namespace BarData.V1.Units

open BarData.V1

module CorAircraft_T2 =

    let coraca : UnitDef =
        { name = "coraca"
          subfolder = "CorAircraft/T2"
          metalCost = ValueOrExpr.Concrete 360.0
          energyCost = ValueOrExpr.Concrete 11000.0
          buildTime = ValueOrExpr.Concrete 22000.0
          health = ValueOrExpr.Concrete 205.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORACA.s3o"
          buildPic = Some "CORACA.DDS"
          script = Some "Units/CORACA.cob"
          corpse = None
          explodeAs = Some "smallexplosiongeneric-builder"
          selfDestructAs = Some "smallExplosionGenericSelfd-builder"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 181.5
              maxAcc = 0.065
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
              cruiseAltitude = Some 70.0
              minWaterDepth = None
              waterline = None })
          builder = Some (
            { workerTime = ValueOrExpr.Concrete 130.0
              buildDistance = Some 136.0
              buildOptions = ["corfus"; "corafus"; "corageo"; "coruwageo"; "corbhmth"; "cormoho"; "cormexp"; "cormmkr"; "coruwadves"; "coruwadvms"; "corarad"; "corshroud"; "corfort"; "cortarg"; "corsd"; "corgate"; "cortoast"; "corvipe"; "cordoom"; "corflak"; "corscreamer"; "cortron"; "corfmd"; "corsilo"; "corint"; "corbuzz"; "corap"; "coraap"; "corplat"; "corgant"]
              terraformSpeed = Some 650.0 })
          weapons = None
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 10.0)
              metalMake = None
              energyStorage = Some 50.0
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
              "subfolder", "CorAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "buildert2"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "radardistance", "50.0"
          ] }

    let corape : UnitDef =
        { name = "corape"
          subfolder = "CorAircraft/T2"
          metalCost = ValueOrExpr.Concrete 370.0
          energyCost = ValueOrExpr.Concrete 6800.0
          buildTime = ValueOrExpr.Concrete 18000.0
          health = ValueOrExpr.Concrete 1560.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORAPE.s3o"
          buildPic = Some "CORAPE.DDS"
          script = Some "Units/corape.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 5 3"
          collisionVolumeScales = Some "48 18 48"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 159.0
              maxAcc = 0.2
              maxDec = 0.2
              turnRate = 600.0
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
          weapons = Some [
              { name = "vtol_rocket"
                displayName = Some "Heavy a2g shrapnel rockets"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 122.0
                    "subs", 61.0
                    "vtol", 15.0
                ]
                range = Some (ValueOrExpr.Concrete 410.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.1)
                weaponVelocity = Some 700.0
                areaOfEffect = Some 128.0
                accuracy = None
                turret = Some false
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rocklit3"
                soundHit = Some "rockhit"
                explosiongenerator = Some "custom:genericshellexplosion-medium"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "castshadow", "true"
                    "cegtag", "missiletrailsmall-simple"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "2.0"
                    "model", "cormissile2fast.s3o"
                    "predictboost", "0.2"
                    "smokecolor", "0.55"
                    "smokeperiod", "7.0"
                    "smokesize", "9.0"
                    "smoketime", "14.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splsmed"
                    "soundtrigger", "true"
                    "startvelocity", "300.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "tracks", "true"
                    "turnrate", "9000.0"
                    "weaponacceleration", "200.0"
                    "weapontimer", "5.0"
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
              "model_author", "Flaka"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
          ] }

    let corawac : UnitDef =
        { name = "corawac"
          subfolder = "CorAircraft/T2"
          metalCost = ValueOrExpr.Concrete 180.0
          energyCost = ValueOrExpr.Concrete 8300.0
          buildTime = ValueOrExpr.Concrete 16000.0
          health = ValueOrExpr.Concrete 990.0
          sightDistance = ValueOrExpr.Concrete 1250.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORAWAC.s3o"
          buildPic = Some "CORAWAC.DDS"
          script = Some "Units/CORAWAC.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 321.0
              maxAcc = 0.1575
              maxDec = 0.0375
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
              select = ["caradsel"] })
          customParams = Map.ofList [
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "util"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.01366"
              "maxbank", "0.8"
              "maxelevator", "0.00991"
              "maxpitch", "0.625"
              "maxrudder", "0.00541"
              "radardistance", "2400.0"
              "sonardistance", "1200.0"
              "speedtofront", "0.06417"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06241"
              "wingdrag", "0.11"
          ] }

    let corcrwh : UnitDef =
        { name = "corcrwh"
          subfolder = "CorAircraft/T2"
          metalCost = ValueOrExpr.Concrete 5100.0
          energyCost = ValueOrExpr.Concrete 72000.0
          buildTime = ValueOrExpr.Concrete 120000.0
          health = ValueOrExpr.Concrete 16700.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORCRWH.s3o"
          buildPic = Some "CORCRWH.DDS"
          script = Some "Units/corcrwh.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 1 17"
          collisionVolumeScales = Some "55 28 80"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 114.9
              maxAcc = 0.15
              maxDec = 0.15
              turnRate = 300.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 85.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "dragonmawh"
                displayName = Some "Dragon's Maw: heavy medium range AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "default", 6.0
                    "subs", 3.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 128.0
                accuracy = Some 700.0
                turret = Some true
                tolerance = Some 20000.0
                edgeEffectiveness = Some 0.01
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Flamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:burnblackxl"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "0 -1 1"
                    "mount_maxangledif", "240.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "avoidground", "false"
                    "bouncerebound", "1.0"
                    "bounceslip", "1.0"
                    "burnblow", "true"
                    "burst", "12.0"
                    "burstrate", "0.03333"
                    "cegtag", "burnflamethermite"
                    "colormap", "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "firesubmersed", "false"
                    "flamegfxtime", "1.0"
                    "intensity", "0.85"
                    "noexplode", "false"
                    "predictboost", "1.0"
                    "sizegrowth", "2.5"
                    "soundhitdry", "flamhit1"
                    "soundhitvolume", "9.5"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "7.3"
                    "soundtrigger", "false"
                    "sprayangle", "700.0"
                    "waterweapon", "false"
                ] }
              { name = "dragon_missileh"
                displayName = Some "Advanced d2a rapid missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 76.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 1250.0
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
                    "mount_fastautoretargeting", "true"
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
                    "flighttime", "2.5"
                    "model", "cormissile.s3o"
                    "smokecolor", "1.0"
                    "smokeperiod", "7.0"
                    "smokesize", "4.2"
                    "smoketime", "10.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "800.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "160.0"
                    "weapontimer", "2.0"
                ] }
              { name = "krowlaserh"
                displayName = Some "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 90.0
                ]
                range = Some (ValueOrExpr.Concrete 575.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-green"
                rgbColor = Some "0.027 0.40 0.027"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "1 -1 0"
                    "mount_maxangledif", "210.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "corethickness", "0.13"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "energypershot", "30.0"
                    "firestarter", "90.0"
                    "laserflaresize", "6.05"
                    "predictboost", "1.0"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.9 1 0.9"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "krowlaserh"
                displayName = Some "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 90.0
                ]
                range = Some (ValueOrExpr.Concrete 575.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-green"
                rgbColor = Some "0.027 0.40 0.027"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "1 -1 0"
                    "mount_maxangledif", "240.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "corethickness", "0.13"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "energypershot", "30.0"
                    "firestarter", "90.0"
                    "laserflaresize", "6.05"
                    "predictboost", "1.0"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.9 1 0.9"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "krowlaserh"
                displayName = Some "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 90.0
                ]
                range = Some (ValueOrExpr.Concrete 575.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-green"
                rgbColor = Some "0.027 0.40 0.027"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "-1 -1 0"
                    "mount_maxangledif", "210.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "corethickness", "0.13"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "energypershot", "30.0"
                    "firestarter", "90.0"
                    "laserflaresize", "6.05"
                    "predictboost", "1.0"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.9 1 0.9"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "krowlaserh"
                displayName = Some "HighEnergyLaser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 90.0
                ]
                range = Some (ValueOrExpr.Concrete 575.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.8)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrcrw1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-small-green"
                rgbColor = Some "0.027 0.40 0.027"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_maindir", "-1 -1 0"
                    "mount_maxangledif", "240.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "beamttl", "1.0"
                    "corethickness", "0.13"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "energypershot", "30.0"
                    "firestarter", "90.0"
                    "laserflaresize", "6.05"
                    "predictboost", "1.0"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.9 1 0.9"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
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
              "maxrange", "425"
              "model_author", "Mr Bob, Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "airsightdistance", "850.0"
              "bankingallowed", "false"
              "blocking", "true"
              "collide", "true"
              "hoverattack", "true"
              "nochasecategory", "VTOL"
              "upright", "true"
          ] }

    let corhurc : UnitDef =
        { name = "corhurc"
          subfolder = "CorAircraft/T2"
          metalCost = ValueOrExpr.Concrete 310.0
          energyCost = ValueOrExpr.Concrete 18500.0
          buildTime = ValueOrExpr.Concrete 36000.0
          health = ValueOrExpr.Concrete 1520.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORHURC.s3o"
          buildPic = Some "CORHURC.DDS"
          script = Some "Units/CORHURC.cob"
          corpse = None
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 248.399
              maxAcc = 0.0525
              maxDec = 0.045
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
              cruiseAltitude = Some 220.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "coradvbomb"
                displayName = Some "Heavy a2g incinerating warheads"
                weaponType = Some "AircraftBomb"
                damage = Map.ofList [
                    "default", 333.0
                    "subs", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 1280.0)
                reloadTime = Some (ValueOrExpr.Concrete 7.0)
                weaponVelocity = None
                areaOfEffect = Some 180.0
                accuracy = None
                turret = None
                tolerance = None
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrelxl"
                soundHit = Some "bombsmed2"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "5.0"
                    "burstrate", "0.2"
                    "collidefriendly", "false"
                    "commandfire", "false"
                    "craterareaofeffect", "180.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "model", "airbombt2.s3o"
                    "mygravity", "0.4"
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
              "subfolder", "CorAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.01273"
              "maxbank", "0.8"
              "maxelevator", "0.00898"
              "maxpitch", "0.625"
              "maxrudder", "0.00448"
              "noautofire", "true"
              "nochasecategory", "VTOL"
              "speedtofront", "0.063"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06148"
              "wingdrag", "0.125"
          ] }

    let corseah : UnitDef =
        { name = "corseah"
          subfolder = "CorAircraft/T2"
          metalCost = ValueOrExpr.Concrete 370.0
          energyCost = ValueOrExpr.Concrete 6400.0
          buildTime = ValueOrExpr.Concrete 12500.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORSEAH.s3o"
          buildPic = Some "CORSEAH.DDS"
          script = Some "Units/CORSEAH.cob"
          corpse = None
          explodeAs = Some "hugeExplosionGeneric"
          selfDestructAs = Some "hugeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "1 -3 0"
          collisionVolumeScales = Some "52 21 52"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 200.0
              maxAcc = 0.15
              maxDec = 0.5
              turnRate = 380.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
              canFly = true
              canMove = true
              floater = false
              turnInPlace = None
              turnInPlaceAngleLimit = Some 360.0
              turnInPlaceSpeedLimit = None
              cruiseAltitude = Some 135.0
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
              "subfolder", "CorAircraft/T2"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "false"
              "hoverattack", "true"
              "releaseheld", "true"
              "transportcapacity", "1.0"
              "transportsize", "4.0"
              "transportunloadmethod", "0.0"
              "unloadspread", "0.0"
              "upright", "true"
          ] }

    let cortitan : UnitDef =
        { name = "cortitan"
          subfolder = "CorAircraft/T2"
          metalCost = ValueOrExpr.Concrete 410.0
          energyCost = ValueOrExpr.Concrete 8200.0
          buildTime = ValueOrExpr.Concrete 18000.0
          health = ValueOrExpr.Concrete 1960.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORTITAN.s3o"
          buildPic = Some "CORTITAN.DDS"
          script = Some "Units/CORTITAN.cob"
          corpse = None
          explodeAs = Some "mediumexplosiongeneric"
          selfDestructAs = Some "mediumExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 279.0
              maxAcc = 0.1325
              maxDec = 0.0725
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
              cruiseAltitude = Some 90.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "heavy_torpedo"
                displayName = Some "Heavy homing torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 1200.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 8.0)
                weaponVelocity = Some 160.0
                areaOfEffect = Some 150.0
                accuracy = None
                turret = Some false
                tolerance = Some 2000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "bombrel"
                soundHit = Some "xplodep1"
                explosiongenerator = Some "custom:genericshellexplosion-large-uw"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "speceffect", "torpwaterpen"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTSHIP"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-large"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "4.0"
                    "model", "coradvtorpedo.s3o"
                    "mygravity", "0.1"
                    "soundhitvolume", "3.5"
                    "soundhitwet", "splsmed"
                    "soundhitwetvolume", "14.0"
                    "startvelocity", "35.0"
                    "tracks", "true"
                    "turnrate", "12000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "35.0"
                    "weapontimer", "8.0"
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
              "subfolder", "CorAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "collide", "true"
              "maxaileron", "0.01347"
              "maxbank", "0.8"
              "maxelevator", "0.00972"
              "maxpitch", "0.625"
              "maxrudder", "0.00522"
              "nochasecategory", "VTOL"
              "radardistance", "800.0"
              "sonardistance", "800.0"
              "speedtofront", "0.063"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06222"
              "wingdrag", "0.18"
          ] }

    let corvamp : UnitDef =
        { name = "corvamp"
          subfolder = "CorAircraft/T2"
          metalCost = ValueOrExpr.Concrete 135.0
          energyCost = ValueOrExpr.Concrete 4750.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 290.0
          sightDistance = ValueOrExpr.Concrete 430.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORVAMP.s3o"
          buildPic = Some "CORVAMP.DDS"
          script = Some "Units/CORVAMP.cob"
          corpse = None
          explodeAs = Some "smallExplosionGenericAir"
          selfDestructAs = Some "smallExplosionGenericAir"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 379.5
              maxAcc = 0.2075
              maxDec = 0.0875
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
              cruiseAltitude = Some 160.0
              minWaterDepth = None
              waterline = None })
          builder = None
          weapons = Some [
              { name = "corvtol_advmissile"
                displayName = Some "Guided a2a/a2g missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "commanders", 8.0
                    "default", 24.0
                    "vtol", 500.0
                ]
                range = Some (ValueOrExpr.Concrete 740.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 935.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = None
                tolerance = Some 8000.0
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
                    "flighttime", "1.4"
                    "impactonly", "1.0"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.55"
                    "smokeperiod", "4.0"
                    "smokesize", "1.8"
                    "smoketime", "8.0"
                    "smoketrail", "false"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "515.0"
                    "texture1", "null"
                    "texture2", "smoketrail"
                    "tracks", "true"
                    "turnrate", "28000.0"
                    "weaponacceleration", "450.0"
                    "weapontimer", "7.0"
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
              "subfolder", "CorAircraft/T2"
              "techlevel", "2.0"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "1100.0"
              "blocking", "false"
              "collide", "false"
              "maxaileron", "0.01488"
              "maxbank", "0.8"
              "maxelevator", "0.01113"
              "maxpitch", "0.625"
              "maxrudder", "0.00663"
              "nochasecategory", "NOTAIR"
              "speedtofront", "0.06475"
              "stealth", "true"
              "turnradius", "64.0"
              "usesmoothmesh", "true"
              "wingangle", "0.06363"
              "wingdrag", "0.21"
          ] }

    let all : (string * UnitDef) list =
        [
            "coraca", coraca
            "corape", corape
            "corawac", corawac
            "corcrwh", corcrwh
            "corhurc", corhurc
            "corseah", corseah
            "cortitan", cortitan
            "corvamp", corvamp
        ]
