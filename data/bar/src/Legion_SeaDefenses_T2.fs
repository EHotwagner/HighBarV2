// Auto-generated BAR unit data: Legion/SeaDefenses/T2
namespace BarData.Units

open BarData

module Legion_SeaDefenses_T2 =

    let leganavalaaturret : UnitDef =
        { name = "leganavalaaturret"
          subfolder = "Legion/SeaDefenses/T2"
          metalCost = ValueOrExpr.Concrete 890.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 23100.0
          health = ValueOrExpr.Concrete 2000.0
          sightDistance = ValueOrExpr.Concrete 550.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/leganavalaaturret.s3o"
          buildPic = Some "leganavalaaturret.DDS"
          script = Some "Units/leganavalaaturret.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "60 52 60"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "leg_t2_microflak"
                displayName = Some "Dual Rotary Microflak Cannons"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "vtol", 58.0
                ]
                range = Some (ValueOrExpr.Concrete 800.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.166)
                weaponVelocity = Some 2600.0
                areaOfEffect = Some 44.0
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
                    "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "60 42 60"
                collisionVolumeType = Some "Box"
                damage = Some 1092.0
                featureDead = None
                footprintX = Some 1.0
                footprintZ = Some 1.0
                height = Some 20.0
                metal = Some 541.0
                object_ = Some "Units/leganavalaaturret_dead.s3o"
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
              "model_author", "Tharsis, ZephyrSkies"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/SeaDefenses/T2"
              "techlevel", "2.0"
              "unitgroup", "aa"
          ]
          extras = Map.ofList [
              "airsightdistance", "1000.0"
              "buildangle", "16384.0"
          ] }

    let leganavaldefturret : UnitDef =
        { name = "leganavaldefturret"
          subfolder = "Legion/SeaDefenses/T2"
          metalCost = ValueOrExpr.Concrete 1250.0
          energyCost = ValueOrExpr.Concrete 16500.0
          buildTime = ValueOrExpr.Concrete 24000.0
          health = ValueOrExpr.Concrete 6300.0
          sightDistance = ValueOrExpr.Concrete 630.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/leganavaldefturret.s3o"
          buildPic = Some "leganavaldefturret.DDS"
          script = Some "Units/leganavaldefturret.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "78 50 78"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "legion_heavy_minigun"
                displayName = Some "Dual Rotary Heavy-Calibre Machine Guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 24.0
                ]
                range = Some (ValueOrExpr.Concrete 700.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 1083.0
                areaOfEffect = Some 16.0
                accuracy = Some 2.0
                turret = Some true
                tolerance = Some 3000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "mgun6heavy"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_fastautoretargeting", "true"
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
                    "soundstartvolume", "4.5"
                    "soundtrigger", "true"
                    "sprayangle", "650.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "4.0"
                ] }
              { name = "advanced_shotgun"
                displayName = Some "Dual Heavy Assault Kinetic Shotgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 30.0
                ]
                range = Some (ValueOrExpr.Concrete 501.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 1.5
                noSelfDamage = Some true
                soundStart = Some "kroggie2xs"
                soundHit = Some "bimpact3"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.95 0.4"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "mount_slaveTo", "1.0"
                    "avoidfeature", "false"
                    "projectiles", "15.0"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.025"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "10.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "3.0"
                    "sprayangle", "1500.0"
                    "thickness", "1.0"
                    "firetolerance", "6000.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "wwwwww wwwwww wwwwww wwwwww wwwwww wwwwww"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "78 50 78"
                collisionVolumeType = Some "CylY"
                damage = Some 2500.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 50.0
                metal = Some 350.0
                object_ = Some "Units/leganavaldefturret_dead.s3o"
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
              "unitgroup", "weapon"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "techlevel", "2.0"
              "subfolder", "Legion/SeaDefenses/T2"
          ]
          extras = Map.ofList [
              "buildangle", "32768.0"
              "mass", "9500.0"
              "nochasecategory", "VTOL"
          ] }

    let leganavaltorpturret : UnitDef =
        { name = "leganavaltorpturret"
          subfolder = "Legion/SeaDefenses/T2"
          metalCost = ValueOrExpr.Concrete 1050.0
          energyCost = ValueOrExpr.Concrete 8500.0
          buildTime = ValueOrExpr.Concrete 10900.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 585.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/leganavaltorpturret.s3o"
          buildPic = Some "leganavaltorpturret.DDS"
          script = Some "Units/leganavaltorpturret.cob"
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
              { name = "leganavaltorpturret_torpedo"
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "44 40 41"
                collisionVolumeType = Some "Box"
                damage = Some 337.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 676.0
                object_ = Some "Units/leganavaltorpturret_dead.s3o"
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
              "model_author", "ZephyrSkies (Model), Protar (Concept Art)"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/SeaDefenses/T2"
              "techlevel", "2.0"
              "unitgroup", "sub"
          ]
          extras = Map.ofList [
              "buildangle", "16384.0"
              "sonardistance", "400.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "leganavalaaturret", leganavalaaturret
            "leganavaldefturret", leganavaldefturret
            "leganavaltorpturret", leganavaltorpturret
        ]
