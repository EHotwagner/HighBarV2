// Auto-generated BAR unit data: CorBuildings/SeaDefence
namespace BarData.Units

open BarData

module CorBuildings_SeaDefence =

    let coranavaldefturret : UnitDef =
        { name = "coranavaldefturret"
          subfolder = "CorBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 2000.0
          energyCost = ValueOrExpr.Concrete 22500.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 8000.0
          sightDistance = ValueOrExpr.Concrete 850.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/coranavaldefturret.s3o"
          buildPic = Some "coranavaldefturret.DDS"
          script = Some "Units/coranavaldefturret.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "100 60 100"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "cortex_medium_energy_blaster"
                displayName = Some "Disruptor Bolt"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 900.0
                ]
                range = Some (ValueOrExpr.Concrete 950.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
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
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
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
              { name = "t1_heavy_plasma_cannon"
                displayName = Some "Heavy Plasma Blast Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 525.0
                    "subs", 60.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 370.0
                areaOfEffect = Some 140.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.6
                noSelfDamage = Some true
                soundStart = Some "cannhvy2"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_slaveto", "1.0"
                    "alphadecay", "0.08"
                    "avoidfeature", "false"
                    "cegtag", "Heavy-Plasma"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "predictboost", "0.5"
                    "size", "5.0"
                    "sizedecay", "0.05"
                    "soundhitwet", "splslrg"
                    "stages", "9.0"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "wwwwww wwwwww wwwwww wwwwww wwwwww wwwwww"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "100 60 100"
                collisionVolumeType = Some "CylY"
                damage = Some 2500.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 50.0
                metal = Some 350.0
                object_ = Some "Units/coranavaldefturret_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaDefence"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "buildangle", "32768.0"
              "mass", "9500.0"
              "nochasecategory", "VTOL"
              "sightemitheight", "80.0"
          ] }

    let coratl : UnitDef =
        { name = "coratl"
          subfolder = "CorBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 1050.0
          energyCost = ValueOrExpr.Concrete 8500.0
          buildTime = ValueOrExpr.Concrete 10900.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 585.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORATL.s3o"
          buildPic = Some "CORATL.DDS"
          script = Some "Units/CORATL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingExplosionGeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "coratl_torpedo"
                displayName = Some "Long-range advanced torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 1100.0
                ]
                range = Some (ValueOrExpr.Concrete 890.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.06)
                weaponVelocity = Some 580.0
                areaOfEffect = Some 16.0
                accuracy = None
                turret = Some true
                tolerance = None
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
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfriendly", "true"
                    "burnblow", "true"
                    "cegtag", "torpedotrail-small"
                    "collidefriendly", "false"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "model", "torpedo.s3o"
                    "startvelocity", "100.0"
                    "tracks", "true"
                    "turnrate", "20000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "80.0"
                    "weapontimer", "3.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -1.2890625003e-06 -0.0"
                collisionVolumeScales = Some "44.8439941406 14.7038574219 41.8139953613"
                collisionVolumeType = Some "Box"
                damage = Some 337.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 676.0
                object_ = Some "Units/coratl_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              ok = ["torpadv2"]
              select = ["torpadv2"] })
          customParams = Map.ofList [
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaDefence"
              "techlevel", "2.0"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "sonardistance", "400.0"
          ] }

    let cordl : UnitDef =
        { name = "cordl"
          subfolder = "CorBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 250.0
          energyCost = ValueOrExpr.Concrete 2200.0
          buildTime = ValueOrExpr.Concrete 6200.0
          health = ValueOrExpr.Concrete 2350.0
          sightDistance = ValueOrExpr.Concrete 611.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORDL.s3o"
          buildPic = Some "CORDL.DDS"
          script = Some "Units/CORDL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingExplosionGeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 3 0"
          collisionVolumeScales = Some "38 52 38"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "coax_depthcharge"
                displayName = Some "Depthcharge launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 225.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 300.0
                areaOfEffect = None
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
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
                    "mount_badtargetcategory", "NOTSUB"
                    "mount_onlytargetcategory", "NOTHOVER"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "bouncerebound", "0.6"
                    "bounceslip", "0.6"
                    "burnblow", "true"
                    "collidefriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "flighttime", "1.75"
                    "gravityaffected", "true"
                    "groundbounce", "true"
                    "model", "cordepthcharge.s3o"
                    "mygravity", "0.2"
                    "numbounce", "1.0"
                    "soundhitvolume", "3.0"
                    "soundhitwet", "splsmed"
                    "soundhitwetvolume", "12.0"
                    "startvelocity", "190.0"
                    "tracks", "true"
                    "trajectoryheight", "0.6"
                    "turnrate", "64000.0"
                    "waterweapon", "true"
                    "weaponacceleration", "75.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "yyyyyooyyooyyyyy"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.56217956543 -6.50129699707 0.0390319824219"
                collisionVolumeScales = Some "41.9183044434 28.9974060059 37.2331542969"
                collisionVolumeType = Some "Box"
                damage = Some 645.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 30.0
                metal = Some 182.0
                object_ = Some "Units/cordl_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 323.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 73.0
                object_ = Some "Units/cor3X3B.s3o"
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
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecaltype", "decals/cordl_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaDefence"
              "unitgroup", "sub"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "sonardistance", "600.0"
          ] }

    let corenaa : UnitDef =
        { name = "corenaa"
          subfolder = "CorBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 890.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 23100.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORENAA.s3o"
          buildPic = Some "CORENAA.DDS"
          script = Some "Units/CORENAA.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -10 0"
          collisionVolumeScales = Some "42 44 42"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "armflak_gun"
                displayName = Some "Heavy g2a flak cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "vtol", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 775.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.53333)
                weaponVelocity = Some 2450.0
                areaOfEffect = Some 192.0
                accuracy = Some 1000.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "flakfire"
                soundHit = Some "flakhit2"
                explosiongenerator = Some "custom:flak"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "flaktrailaa"
                    "collidefriendly", "false"
                    "craterareaofeffect", "192.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "gravityaffected", "true"
                    "mygravity", "0.01"
                    "predictboost", "1.0"
                    "size", "4.5"
                    "sizedecay", "0.08"
                    "soundhitwet", "splslrg"
                    "stages", "8.0"
                    "weapontimer", "1.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "wwwwwwwwwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0857467651367 -0.0243953491211 7.02119445801"
                collisionVolumeScales = Some "34.8984832764 33.2414093018 54.6983947754"
                collisionVolumeType = Some "Box"
                damage = Some 1092.0
                featureDead = None
                footprintX = Some 1.0
                footprintZ = Some 1.0
                height = Some 20.0
                metal = Some 541.0
                object_ = Some "Units/corenaa_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              ok = ["twrturn3"]
              select = ["twrturn3"] })
          customParams = Map.ofList [
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaDefence"
              "techlevel", "2.0"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "1000.0"
              "buildangle", "16384.0"
          ] }

    let corfdoom : UnitDef =
        { name = "corfdoom"
          subfolder = "CorBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 1200.0
          energyCost = ValueOrExpr.Concrete 15000.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 6700.0
          sightDistance = ValueOrExpr.Concrete 780.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORFDOOM.s3o"
          buildPic = Some "CORFDOOM.DDS"
          script = Some "Units/CORFDOOM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0.0 15 0.0"
          collisionVolumeScales = Some "55.0 90 55.0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "cortoast_gun"
                displayName = Some "Medium-range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 420.0
                    "subs", 90.0
                    "vtol", 90.0
                ]
                range = Some (ValueOrExpr.Concrete 900.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.1)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 164.0
                accuracy = Some 450.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "cannhvy5"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "arty-heavy"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "predictboost", "0.2"
                    "soundhitwet", "splslrg"
                ] }
              { name = "doomsday_green_laser"
                displayName = Some "High energy g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 231.0
                    "vtol", 52.0
                ]
                range = Some (ValueOrExpr.Concrete 630.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0 1 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.225"
                    "corethickness", "0.185"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "45.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.45"
                ] }
              { name = "doomsday_red_laser"
                displayName = Some "Light close-quarters g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 40.0
                ]
                range = Some (ValueOrExpr.Concrete 370.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.26667)
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
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.1"
                    "burst", "2.0"
                    "burstrate", "0.03333"
                    "corethickness", "0.15"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "10.0"
                    "firestarter", "100.0"
                    "impactonly", "1.0"
                    "laserflaresize", "5.5"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.1"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "wwwwww wwwwww wwwwww wwwwww wwwwww wwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.281730651855 -0.153618286133 3.57356262207"
                collisionVolumeScales = Some "80.6815948486 91.7637634277 82.1471252441"
                collisionVolumeType = Some "Box"
                damage = Some 6000.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 600.0
                object_ = Some "Units/corfdoom_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 3000.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 300.0
                object_ = Some "Units/cor3X3E.s3o"
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
              "model_author", "Zecrus"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaDefence"
              "techlevel", "2.0"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "damagemodifier", "0.25"
              "nochasecategory", "VTOL"
              "onoffable", "true"
              "sightemitheight", "80.0"
          ] }

    let corfhlt : UnitDef =
        { name = "corfhlt"
          subfolder = "CorBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 480.0
          energyCost = ValueOrExpr.Concrete 6200.0
          buildTime = ValueOrExpr.Concrete 11400.0
          health = ValueOrExpr.Concrete 4350.0
          sightDistance = ValueOrExpr.Concrete 630.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORFHLT.s3o"
          buildPic = Some "CORFHLT.DDS"
          script = Some "Units/CORFHLT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "73 67 73"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "corfhlt_laser"
                displayName = Some "High energy g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 350.0
                    "default", 231.0
                    "vtol", 52.0
                ]
                range = Some (ValueOrExpr.Concrete 630.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 8.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-medium-green"
                rgbColor = Some "0 1 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.225"
                    "corethickness", "0.185"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "45.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.45"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "wwwwwwwwwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "1.41945648193 0.0257352172852 3.31944274902"
                collisionVolumeScales = Some "44.3973846436 40.5940704346 42.9052734375"
                collisionVolumeType = Some "Box"
                damage = Some 2356.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 363.0
                object_ = Some "Units/corfhlt_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              ok = ["twractv3"]
              select = ["twractv3"] })
          customParams = Map.ofList [
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaDefence"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "nochasecategory", "MOBILE"
          ] }

    let corfrock : UnitDef =
        { name = "corfrock"
          subfolder = "CorBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 315.0
          energyCost = ValueOrExpr.Concrete 6100.0
          buildTime = ValueOrExpr.Concrete 5240.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 468.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORFROCK.s3o"
          buildPic = Some "CORFROCK.DDS"
          script = Some "Units/CORFROCK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 15 0"
          collisionVolumeScales = Some "36 59 36"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "aamissile"
                displayName = Some "Advanced g2a rapid missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 76.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
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
                    "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
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
          ]
          economy = None
          building = Some (
            { yardMap = Some "wwwwwwwwwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.10124206543 -0.0500075439453 1.15520477295"
                collisionVolumeScales = Some "41.2024536133 67.0857849121 50.3104095459"
                collisionVolumeType = Some "Box"
                damage = Some 1280.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 40.0
                metal = Some 240.0
                object_ = Some "Units/corfrt_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              ok = ["kbcormov"]
              select = ["kbcorsel"] })
          customParams = Map.ofList [
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaDefence"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "750.0"
              "buildangle", "16384.0"
              "nochasecategory", "ALL"
          ] }

    let corfrt : UnitDef =
        { name = "corfrt"
          subfolder = "CorBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 1000.0
          buildTime = ValueOrExpr.Concrete 2200.0
          health = ValueOrExpr.Concrete 395.0
          sightDistance = ValueOrExpr.Concrete 468.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORFRT.s3o"
          buildPic = Some "CORFRT.DDS"
          script = Some "Units/CORFRT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "40 64 40"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "armrl_missile"
                displayName = Some "Light g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 115.0
                ]
                range = Some (ValueOrExpr.Concrete 765.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 750.0
                areaOfEffect = Some 64.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.75
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "rockhvy2"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "LIGHTAIRSCOUT"
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
                    "firestarter", "70.0"
                    "flighttime", "1.75"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "proximitypriority", "1.0"
                    "smokecolor", "0.95"
                    "smokeperiod", "5.0"
                    "smokesize", "4.8"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splssml"
                    "startvelocity", "400.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa"
                    "tracks", "true"
                    "turnrate", "63000.0"
                    "weaponacceleration", "150.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "wwwwwwwwwwwwwwww"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.13062286377 0.0342008544922 1.088722229"
                collisionVolumeScales = Some "48.0115509033 52.983001709 47.76612854"
                collisionVolumeType = Some "Box"
                damage = Some 174.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 47.0
                object_ = Some "Units/corfrt_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              ok = ["kbcormov"]
              select = ["kbcorsel"] })
          customParams = Map.ofList [
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaDefence"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "750.0"
              "buildangle", "16500.0"
              "nochasecategory", "ALL"
          ] }

    let corgplat : UnitDef =
        { name = "corgplat"
          subfolder = "CorBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 120.0
          energyCost = ValueOrExpr.Concrete 950.0
          buildTime = ValueOrExpr.Concrete 3000.0
          health = ValueOrExpr.Concrete 810.0
          sightDistance = ValueOrExpr.Concrete 520.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORGPLAT.s3o"
          buildPic = Some "CORGPLAT.DDS"
          script = Some "Units/CORGPLAT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -6 0"
          collisionVolumeScales = Some "45 36 45"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "gun"
                displayName = Some "Light g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 97.0
                    "vtol", 18.0
                ]
                range = Some (ValueOrExpr.Concrete 520.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
                weaponVelocity = Some 500.0
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
                    "cegtag", "arty-fast"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "9.5"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "wwwwwwwwwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -6.6047363281e-05 -15.62939453125e-06"
                collisionVolumeScales = Some "50.0 45.7867279053 45.9999847412"
                collisionVolumeType = Some "Box"
                damage = Some 750.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 80.0
                object_ = Some "Units/corgplat_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              ok = ["twractv3"]
              select = ["twractv3"] })
          customParams = Map.ofList [
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaDefence"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "nochasecategory", "MOBILE"
          ] }

    let cornavaldefturret : UnitDef =
        { name = "cornavaldefturret"
          subfolder = "CorBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 700.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 14000.0
          health = ValueOrExpr.Concrete 5800.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/cornavaldefturret.s3o"
          buildPic = Some "cornavaldefturret.DDS"
          script = Some "Units/cornavaldefturret.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "80 70 80"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "t1_heavy_plasma_cannon"
                displayName = Some "Heavy Plasma Blast Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 495.0
                    "subs", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 720.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 360.0
                areaOfEffect = Some 145.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.6
                noSelfDamage = Some true
                soundStart = Some "cannhvy2"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:genericshellexplosion-large-aoe"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "Heavy-Plasma"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splslrg"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ooooooooooooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "80 70 80"
                collisionVolumeType = Some "CylY"
                damage = Some 2500.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 50.0
                metal = Some 350.0
                object_ = Some "Units/cornavaldefturret_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              ok = ["servmed2"]
              select = ["servmed2"] })
          customParams = Map.ofList [
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaDefence"
              "unitgroup", "weapon"
          ]
          extras = Map.ofList [
              "airsightdistance", "650.0"
              "buildangle", "32768.0"
              "mass", "9500.0"
          ] }

    let cortl : UnitDef =
        { name = "cortl"
          subfolder = "CorBuildings/SeaDefence"
          metalCost = ValueOrExpr.Concrete 170.0
          energyCost = ValueOrExpr.Concrete 1800.0
          buildTime = ValueOrExpr.Concrete 3750.0
          health = ValueOrExpr.Concrete 1440.0
          sightDistance = ValueOrExpr.Concrete 495.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORTL.s3o"
          buildPic = Some "CORTL.DDS"
          script = Some "Units/CORTL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "torpedo"
                displayName = Some "Torpedo launcher"
                weaponType = Some "TorpedoLauncher"
                damage = Map.ofList [
                    "default", 280.0
                ]
                range = Some (ValueOrExpr.Concrete 500.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.5)
                weaponVelocity = Some 280.0
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
                    "mount_badtargetcategory", "HOVER NOTSHIP"
                    "mount_onlytargetcategory", "NOTHOVER"
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
          ]
          economy = None
          building = Some (
            { yardMap = Some "wwwwwwwww"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some false
                category = Some "corpses"
                collisionVolumeOffsets = Some "-0.449691772461 -1.59912109332e-06 0.155464172363"
                collisionVolumeScales = Some "30.8800354004 19.4210968018 32.1831512451"
                collisionVolumeType = Some "Box"
                damage = Some 912.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 70.0
                object_ = Some "Units/cortl_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
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
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/SeaDefence"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "sonardistance", "400.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "coranavaldefturret", coranavaldefturret
            "coratl", coratl
            "cordl", cordl
            "corenaa", corenaa
            "corfdoom", corfdoom
            "corfhlt", corfhlt
            "corfrock", corfrock
            "corfrt", corfrt
            "corgplat", corgplat
            "cornavaldefturret", cornavaldefturret
            "cortl", cortl
        ]
