// Auto-generated BAR unit data: Legion/Defenses
namespace BarData.Units

open BarData

module Legion_Defenses =

    let legabm : UnitDef =
        { name = "legabm"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 1500.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 60000.0
          health = ValueOrExpr.Concrete 3650.0
          sightDistance = ValueOrExpr.Concrete 195.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legabm.s3o"
          buildPic = Some "legabm.DDS"
          script = Some "Units/legabm.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeexplosiongeneric"
          selfDestructAs = Some "largeExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -19 0"
          collisionVolumeScales = Some "48 78 48"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "fmd_rocket"
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
                    "coverage", "2000.0"
                    "craterareaofeffect", "420.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "7500.0"
                    "firestarter", "100.0"
                    "flighttime", "20.0"
                    "interceptor", "1.0"
                    "metalpershot", "150.0"
                    "model", "leghomingmissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "10.0"
                    "smoketime", "110.0"
                    "smokesize", "27.0"
                    "smokecolor", "0.7"
                    "smokeTrailCastShadow", "true"
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
          economy = None
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -1.36962890629e-05 -0.0"
                collisionVolumeScales = Some "48.0 37.2831726074 48.0"
                collisionVolumeType = Some "Box"
                damage = Some 1968.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 980.0
                object_ = Some "Units/legabm_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 984.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 392.0
                object_ = Some "Units/cor5X5D.s3o"
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
              ok = ["loadwtr1"]
              select = ["loadwtr1"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legabm_aoplane.dds"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "antinuke"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "canattack", "false"
              "noautofire", "true"
              "radardistance", "50.0"
          ] }

    let legacluster : UnitDef =
        { name = "legacluster"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 2300.0
          energyCost = ValueOrExpr.Concrete 15000.0
          buildTime = ValueOrExpr.Concrete 25700.0
          health = ValueOrExpr.Concrete 3700.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGACLUSTER.s3o"
          buildPic = Some "LEGACLUSTER.DDS"
          script = Some "Units/LEGACLUSTER.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "47 47 47"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "plasma"
                displayName = Some "Pop-Up Long-range g2g Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 414.0
                    "lboats", 414.0
                    "subs", 132.0
                    "vtol", 132.0
                ]
                range = Some (ValueOrExpr.Concrete 1380.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.5)
                weaponVelocity = Some 450.0
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
                    "cluster_def", "cluster_munition"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 1 0"
                    "mount_maxangledif", "230.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "cegtag", "starfire_arty"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "plasma_high"
                displayName = Some "Pop-Up Long-range g2g Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 414.0
                    "lboats", 414.0
                    "subs", 132.0
                    "vtol", 132.0
                ]
                range = Some (ValueOrExpr.Concrete 1380.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.5)
                weaponVelocity = Some 450.0
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
                    "cluster_def", "cluster_munition"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "cegtag", "starfire_arty"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "soundhitwet", "splsmed"
                ] }
              { name = "smart_trajectory_dummy"
                displayName = Some "Pop-Up Long-range g2g Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1380.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.6)
                weaponVelocity = Some 450.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 1 0"
                    "mount_maxangledif", "230.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "starfire_arty"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooo oooo oooo oooo"
              activateWhenBuilt = Some false
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "47 47 47"
                collisionVolumeType = Some "Box"
                damage = Some 1764.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 936.0
                object_ = Some "Units/legacluster_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 882.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 3.0
                metal = Some 373.0
                object_ = Some "Units/cor4X4B.s3o"
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
              ok = ["twrturn3"]
              select = ["twrturn3"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legacluster_aoplane.dds"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "Legion/Defenses"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "damagemodifier", "0.25"
              "nochasecategory", "MOBILE"
          ] }

    let legapopupdef : UnitDef =
        { name = "legapopupdef"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 15000.0
          buildTime = ValueOrExpr.Concrete 17500.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 598.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legapopupdef.s3o"
          buildPic = Some "legapopupdef.dds"
          script = Some "Units/legapopupdef.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingExplosionGeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "35 35 35"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "advanced_riot_cannon"
                displayName = Some "Heavy Riot Blast Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 280.0
                ]
                range = Some (ValueOrExpr.Concrete 730.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.7)
                weaponVelocity = Some 850.0
                areaOfEffect = Some 140.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 2.4
                noSelfDamage = Some true
                soundStart = Some "largegun"
                soundHit = Some "xplomed1"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = Some "1 0.7 0.25"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "soundhitwet", "splslrg"
                    "soundhitvolume", "14.0"
                    "soundstartvolume", "13.0"
                    "separation", "2.0"
                    "nogap", "false"
                    "size", "6.0"
                    "sizeDecay", "0.06"
                    "stages", "9.0"
                    "alphaDecay", "0.1"
                ] }
              { name = "standard_minigun"
                displayName = Some "Dual Rotary Machine Guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 10.0
                    "vtol", 10.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 1100.0
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
                    "mount_burstcontrolwhenoutofarc", "2.0"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_slaveTo", "1.0"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.066"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.038"
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
                    "thickness", "3.0"
                ] }
              { name = "standard_minigun"
                displayName = Some "Dual Rotary Machine Guns"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 10.0
                    "vtol", 10.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 1100.0
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
                    "mount_burstcontrolwhenoutofarc", "2.0"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_slaveTo", "1.0"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.066"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.038"
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
                    "thickness", "3.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -10 0"
                collisionVolumeScales = Some "35 20 35"
                collisionVolumeType = Some "Box"
                damage = Some 1519.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 15.0
                metal = Some 350.0
                object_ = Some "Units/legapopupdef_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 760.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 140.0
                object_ = Some "Units/arm3X3D.s3o"
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
              ok = ["twrturn3"]
              select = ["twrturn3"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legapopupdef_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "model_author", "ZephyrSkies (Model), Johnathan Crimson (Proposal)"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/Defenses"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "damagemodifier", "0.5"
              "nochasecategory", "MOBILE"
          ] }

    let legbastion : UnitDef =
        { name = "legbastion"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 4200.0
          energyCost = ValueOrExpr.Concrete 58000.0
          buildTime = ValueOrExpr.Concrete 79000.0
          health = ValueOrExpr.Concrete 12000.0
          sightDistance = ValueOrExpr.Concrete 780.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/legbastion.s3o"
          buildPic = Some "legbastion.DDS"
          script = Some "Units/legbastion.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0.0 0.0 0.0"
          collisionVolumeScales = Some "102 151 97"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "t2heatray"
                displayName = Some "Heavy Sustained Sweepfire Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 155.0
                    "vtol", 15.0
                ]
                range = Some (ValueOrExpr.Concrete 1100.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 120.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray3"
                soundHit = None
                explosiongenerator = Some "custom:heatray-huge"
                rgbColor = Some "1 0.5 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "beamtime", "0.1"
                    "camerashake", "0.1"
                    "corethickness", "0.3"
                    "craterareaofeffect", "120.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "500.0"
                    "firestarter", "90.0"
                    "firetolerance", "300.0"
                    "laserflaresize", "6.0"
                    "predictboost", "0.3"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.9 1.0 0.5"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "38.0"
                    "soundtrigger", "1.0"
                    "thickness", "5.5"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 1000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "yoooy ooooo ooooo ooooo yoooy"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 0.0 0.0"
                collisionVolumeScales = Some "102 151 97"
                collisionVolumeType = Some "CylY"
                damage = Some 5400.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 2911.0
                object_ = Some "Units/legbastion_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 2700.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 1644.0
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
              "maxrange", "1125.0"
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legbastion_aoplane.dds"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "model_author", "Gabs"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "damagemodifier", "0.25"
              "losemitheight", "80.0"
              "nochasecategory", "VTOL"
              "onoffable", "true"
              "radardistance", "1200.0"
              "radaremitheight", "80.0"
          ] }

    let legbombard : UnitDef =
        { name = "legbombard"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 750.0
          energyCost = ValueOrExpr.Concrete 15000.0
          buildTime = ValueOrExpr.Concrete 17500.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 598.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/legbombard.s3o"
          buildPic = Some "legbombard.dds"
          script = Some "Units/legbombard.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingExplosionGeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 18 32"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "bombardier_weapon"
                displayName = Some "Pop-up heavy g2g grenade launcher"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 375.0
                    "subs", 300.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.0)
                weaponVelocity = Some 300.0
                areaOfEffect = Some 124.0
                accuracy = Some 1.0
                turret = Some true
                tolerance = Some 8000.0
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
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_maindir", "0 0 1"
                    "mount_maxangledif", "300.0"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "separation", "1.8"
                    "nogap", "false"
                    "sizeDecay", "0.06"
                    "stages", "14.0"
                    "alphaDecay", "0.08"
                    "soundhitwet", "splshbig"
                    "targetmoveerror", "0.2"
                    "model", "legnade.s3o"
                    "weaponacceleration", "-0.3"
                    "weapontimer", "0.01"
                    "startvelocity", "700.0"
                    "smoketrail", "true"
                    "smokePeriod", "100.0"
                    "smoketime", "110.0"
                    "smokesize", "27.0"
                    "smokecolor", "0.7"
                    "smokeTrailCastShadow", "true"
                    "cegtag", "missiletrail-grenadesmoke"
                    "avoidfeature", "false"
                    "avoidfriendly", "true"
                    "avoidground", "true"
                    "burnblow", "false"
                    "burst", "3.0"
                    "burstrate", "0.5"
                    "sprayangle", "500.0"
                    "bounce", "1.0"
                    "bounceslip", "0.6"
                    "bouncerebound", "0.4"
                    "numbounce", "5.0"
                    "groundbounce", "true"
                    "collideenemy", "true"
                    "collidefeature", "false"
                    "collideground", "true"
                    "collidefriendly", "false"
                    "collidefirebase", "false"
                    "collideneutral", "false"
                    "flighttime", "2.05"
                    "proximityPriority", "1.0"
                    "gravityaffected", "true"
                    "waterbounce", "true"
                    "predictboost", "0.8"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "32 18 32"
                collisionVolumeType = Some "Box"
                damage = Some 1519.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 15.0
                metal = Some 350.0
                object_ = Some "Units/legbombard_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 760.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 140.0
                object_ = Some "Units/arm3X3D.s3o"
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
              ok = ["twrturn3"]
              select = ["twrturn3"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legbombard_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "model_author", "Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandDefenceOffence"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "damagemodifier", "0.5"
              "nochasecategory", "MOBILE"
          ] }

    let legcluster : UnitDef =
        { name = "legcluster"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 850.0
          energyCost = ValueOrExpr.Concrete 11000.0
          buildTime = ValueOrExpr.Concrete 17400.0
          health = ValueOrExpr.Concrete 2900.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGCLUSTER.s3o"
          buildPic = Some "LEGCLUSTER.DDS"
          script = Some "Units/LEGCLUSTER.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "47 47 47"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "plasma"
                displayName = Some "Long-Range g2g Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 300.0
                    "subs", 75.0
                    "vtol", 75.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 120.0
                accuracy = Some 75.0
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
                    "cluster_def", "cluster_munition"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 1 0"
                    "mount_maxangledif", "230.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "cegtag", "starfire_arty"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "plasma_high"
                displayName = Some "Long-Range g2g Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 300.0
                    "subs", 75.0
                    "vtol", 75.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 120.0
                accuracy = Some 75.0
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
                    "cluster_def", "cluster_munition"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "cegtag", "starfire_arty"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "soundhitwet", "splsmed"
                ] }
              { name = "smart_trajectory_dummy"
                displayName = Some "Long-Range g2g Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1000.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.0)
                weaponVelocity = Some 450.0
                areaOfEffect = Some 120.0
                accuracy = Some 75.0
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
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 1 0"
                    "mount_maxangledif", "230.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "starfire_arty"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = Some false
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "47 47 47"
                collisionVolumeType = Some "Box"
                damage = Some 1764.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 936.0
                object_ = Some "Units/legcluster_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 882.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 3.0
                metal = Some 373.0
                object_ = Some "Units/cor4X4B.s3o"
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
              ok = ["twrturn3"]
              select = ["twrturn3"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legcluster_aoplane.dds"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "subfolder", "CorBuildings/LandDefenceOffence"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "nochasecategory", "MOBILE"
          ] }

    let legdrag : UnitDef =
        { name = "legdrag"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 8.0
          energyCost = ValueOrExpr.Concrete 0.0
          buildTime = ValueOrExpr.Concrete 255.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/legdrag.s3o"
          buildPic = Some "LEGDRAG.DDS"
          script = Some "Units/legdrag.cob"
          corpse = Some "ROCKTEETH"
          explodeAs = Some "WallExplosionConcrete"
          selfDestructAs = Some "WallExplosionConcrete"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 22 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "rockteeth",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2.0
                object_ = Some "Units/cor1X1A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = None
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legdrag_aoplane.dds"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "objectify", "true"
              "paralyzemultiplier", "0.0"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandUtil"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "canattack", "false"
              "crushresistance", "250.0"
              "hidedamage", "true"
              "levelground", "false"
              "repairable", "false"
              "selfdestructcountdown", "1.0"
          ] }

    let legdtr : UnitDef =
        { name = "legdtr"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 290.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 4420.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 440.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGDTR.s3o"
          buildPic = Some "LEGDTR.DDS"
          script = Some "Units/LEGDTR.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "tinyBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "corlevlr_weapon"
                displayName = Some "Area Control Riot Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 240.0
                    "commanders", 375.0
                    "subs", 90.0
                    "vtol", 35.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 140.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.9
                impulseFactor = Some 2.0
                noSelfDamage = Some true
                soundStart = Some "largegun"
                soundHit = Some "corlevlrhit"
                explosiongenerator = Some "custom:genericshellexplosion-large"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "soundhitwet", "splsmed"
                    "soundhitvolume", "12.0"
                    "soundstartvolume", "14.0"
                    "separation", "2.0"
                    "nogap", "false"
                    "size", "3.0"
                    "sizeDecay", "0.07"
                    "stages", "10.0"
                    "alphaDecay", "0.1"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 0.0149960864258 0.116882324219"
                collisionVolumeScales = Some "32.042388916 19.5953521729 32.6287231445"
                collisionVolumeType = Some "Box"
                damage = Some 600.0
                featureDead = Some "ROCKTEETH"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 177.0
                object_ = Some "Units/legdrag_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "rockteeth",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 500.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 2.0
                object_ = Some "Units/cor1X1A.s3o"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecaltype", "decals/legdrag_aoplane.dds"
              "decoyfor", "LEGLAW"
              "model_author", "ZephyrSkies"
              "neutral_when_closed", "true"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "selectionscalemult", "1.0"
              "subfolder", "Legion/Defenses"
              "unitgroup", "weapon"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "damagemodifier", "0.33"
              "decoyfor", "legdrag"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000000000.0"
              "nochasecategory", "MOBILE"
              "radardistancejam", "8.0"
              "usepiececollisionvolumes", "1.0"
              "stealth", "true"
              "upright", "true"
          ] }

    let legflak : UnitDef =
        { name = "legflak"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 820.0
          energyCost = ValueOrExpr.Concrete 13000.0
          buildTime = ValueOrExpr.Concrete 19000.0
          health = ValueOrExpr.Concrete 1750.0
          sightDistance = ValueOrExpr.Concrete 525.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGFLAK.s3o"
          buildPic = Some "LEGFLAK.DDS"
          script = Some "Units/LEGFLAK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "55 85 55"
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
            { yardMap = Some "ooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -15 0"
                collisionVolumeScales = Some "55 55 55"
                collisionVolumeType = Some "Box"
                damage = Some 945.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 500.0
                object_ = Some "Units/legflak_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 473.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 200.0
                object_ = Some "Units/arm2X2C.s3o"
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
              ok = ["twrturn3"]
              select = ["twrturn3"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legflak_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "aa"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/defenses"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "airsightdistance", "1000.0"
              "buildangle", "8192.0"
              "nochasecategory", "ALL"
          ] }

    let legforti : UnitDef =
        { name = "legforti"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 40.0
          energyCost = ValueOrExpr.Concrete 500.0
          buildTime = ValueOrExpr.Concrete 1000.0
          health = ValueOrExpr.Concrete 8900.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "units/legforti.s3o"
          buildPic = Some "legforti.DDS"
          script = Some "units/legforti.cob"
          corpse = Some "ROCKTEETHX"
          explodeAs = Some "WallExplosionConcreteXL"
          selfDestructAs = Some "WallExplosionConcrete"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "32 50 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some "ffff"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "rockteethx",
              { blocking = Some true
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 3000.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 7.0
                object_ = Some "Units/cor1X1A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = None
          customParams = Map.ofList [
              "usebuildinggrounddecal", "false"
              "buildinggrounddecaltype", "decals/legforti_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "model_author", "Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "objectify", "true"
              "paralyzemultiplier", "0.0"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "legion/Defenses"
          ]
          extras = Map.ofList [
              "blocking", "true"
              "buildangle", "0.0"
              "canattack", "false"
              "crushresistance", "1000.0"
              "hidedamage", "true"
              "levelground", "false"
              "repairable", "false"
              "selfdestructcountdown", "1.0"
          ] }

    let leggatet3 : UnitDef =
        { name = "leggatet3"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 14500.0
          energyCost = ValueOrExpr.Concrete 216000.0
          buildTime = ValueOrExpr.Concrete 261000.0
          health = ValueOrExpr.Concrete 18000.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 6.0
          objectName = Some "Units/LEGGATET3.s3o"
          buildPic = Some "LEGGATET3.DDS"
          script = Some "Units/LEGGATET3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "88 70 88"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "NOWEAPON"
          movement = None
          builder = None
          weapons = Some [
              { name = "repulsor"
                displayName = Some "PlasmaRepulsor"
                weaponType = Some "Shield"
                damage = Map.ofList [
                    "default", 100.0
                ]
                range = Some (ValueOrExpr.Concrete 710.0)
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
            { energyMake = None
              metalMake = None
              energyStorage = Some 4000.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "88 60 88"
                collisionVolumeType = Some "CylY"
                damage = Some 15000.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 9062.0
                object_ = Some "Units/leggatet3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 9000.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 3866.0
                object_ = Some "Units/arm4X4A.s3o"
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
              ok = ["drone1"]
              select = ["drone1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecaltype", "decals/leggatet3_aoplane.dds"
              "model_author", "Protar"
              "normaltex", "unittextures/leg_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "shield_color_mult", "25.0"
              "shield_power", "49400.0"
              "shield_radius", "710.0"
              "subfolder", "Legion/Defenses"
              "techlevel", "3.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "onoffable", "true"
              "canattack", "false"
              "damagemodifier", "0.333"
              "exemptcategory", "WEAPON"
              "noautofire", "true"
          ] }

    let leghive : UnitDef =
        { name = "leghive"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 350.0
          energyCost = ValueOrExpr.Concrete 9000.0
          buildTime = ValueOrExpr.Concrete 6600.0
          health = ValueOrExpr.Concrete 1200.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/leghive.s3o"
          buildPic = Some "leghive.DDS"
          script = Some "Units/leghive.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -7 0"
          collisionVolumeScales = Some "44 23 44"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = Some (
            { speed = ValueOrExpr.Concrete 0.0
              maxAcc = 0.0
              maxDec = 4.5
              turnRate = 1.0
              movementClass = None
              maxSlope = Some 10.0
              maxWaterDepth = Some 0.0
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
          weapons = Some [
              { name = "plasma"
                displayName = Some "HeavyCannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1100.0)
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
                    "spawns_surface", "LAND"
                    "carrierdeaththroe", "release"
                    "dockingpieces", "4 5 6 7 8 9"
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
                    "stockpile", "true"
                    "stockpiletime", "10.0"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "38 95 38"
                collisionVolumeType = Some "CylY"
                damage = Some 700.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 130.0
                object_ = Some "Units/leghive_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 400.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 65.0
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
              ok = ["twractv3"]
              select = ["twractv3"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/leghive_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "model_author", "Zephyr"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "legacyname", "Gaat Gun"
              "inheritxpratemultiplier", "1.0"
              "childreninheritxp", "DRONE"
              "parentsinheritxp", "DRONE"
              "restrictions_inclusion", "_noair_"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "mass", "700.0"
              "nochasecategory", "MOBILE"
              "upright", "true"
          ] }

    let leglht : UnitDef =
        { name = "leglht"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 70.0
          energyCost = ValueOrExpr.Concrete 550.0
          buildTime = ValueOrExpr.Concrete 2200.0
          health = ValueOrExpr.Concrete 550.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGLHT.s3o"
          buildPic = Some "LEGLHT.DDS"
          script = Some "Units/LEGLHT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -7 0"
          collisionVolumeScales = Some "32 61 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "heat_ray"
                displayName = Some "Light g2g Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 270.0
                    "default", 200.0
                    "vtol", 25.0
                ]
                range = Some (ValueOrExpr.Concrete 430.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.1)
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
                explosiongenerator = Some "custom:laserhit-small"
                rgbColor = Some "1 0.55 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.45"
                    "corethickness", "0.4"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "30.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.0"
                    "leadlimit", "0.0"
                    "predictboost", "1.0"
                    "rgbcolor2", "0.9 1.0 0.5"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.66"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -7 0"
                collisionVolumeScales = Some "32 61 32"
                collisionVolumeType = Some "CylY"
                damage = Some 351.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 55.0
                object_ = Some "Units/LEGLHT_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 176.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 22.0
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
              ok = ["lltok"]
              select = ["lltselect"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/leglht_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "basename", "base"
              "cannon1name", "barrel"
              "driftratio", "0.6"
              "firingceg", "barrelshot-tiny"
              "flare1name", "flare"
              "kickback", "-2.0"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
          ]
          extras = Map.ofList [
              "buildangle", "32000.0"
              "cantbetransported", "false"
              "mass", "5100.0"
              "nochasecategory", "MOBILE"
          ] }

    let leglraa : UnitDef =
        { name = "leglraa"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 1600.0
          energyCost = ValueOrExpr.Concrete 36000.0
          buildTime = ValueOrExpr.Concrete 28000.0
          health = ValueOrExpr.Concrete 1670.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/LEGLRAA.s3o"
          buildPic = Some "LEGLRAA.DDS"
          script = Some "Units/LEGLRAA.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "63 57 63"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "railgunt2"
                displayName = Some "Heavy Anti-Air Railgun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 1.0
                    "vtol", 700.0
                ]
                range = Some (ValueOrExpr.Concrete 2000.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.0)
                weaponVelocity = Some 3529.0
                areaOfEffect = Some 100.0
                accuracy = None
                turret = Some true
                tolerance = Some 6000.0
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 2.0
                noSelfDamage = Some true
                soundStart = Some "railgun3"
                soundHit = Some "impact"
                explosiongenerator = Some "custom:plasmahit-sparkonly"
                rgbColor = Some "1 0.33 0.7"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "predictboost", "1.0"
                    "avoidfeature", "false"
                    "burnblow", "false"
                    "canattackground", "false"
                    "cegtag", "railgun"
                    "burst", "2.0"
                    "burstrate", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.12"
                    "energypershot", "1800.0"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "1.0"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "80.0"
                    "thickness", "4.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "63 57 63"
                collisionVolumeType = Some "CylY"
                damage = Some 942.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 1145.0
                object_ = Some "Units/leglraa_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 471.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = None
                metal = Some 458.0
                object_ = Some "Units/cor4X4A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "targsel2"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["targsel2"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/leglraa_aoplane.dds"
              "buildinggrounddecalsizey", "7.0"
              "buildinggrounddecalsizex", "7.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "aa"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/Defenses"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "airsightdistance", "2400.0"
          ] }

    let leglrpc : UnitDef =
        { name = "leglrpc"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 5200.0
          energyCost = ValueOrExpr.Concrete 76000.0
          buildTime = ValueOrExpr.Concrete 93000.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/LEGLRPC.s3o"
          buildPic = Some "LEGLRPC.DDS"
          script = Some "Units/LEGLRPC.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingExplosionGeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "lrpc"
                displayName = Some "Long-Range g2g Heavy Cluster Plasma Cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 600.0
                    "shields", 300.0
                    "subs", 120.0
                ]
                range = Some (ValueOrExpr.Concrete 4800.0)
                reloadTime = Some (ValueOrExpr.Concrete 18.0)
                weaponVelocity = Some 1100.0
                areaOfEffect = Some 135.0
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
                    "cluster_def", "cluster_munition"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "sprayangle", "150.0"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "cegtag", "starfire-small"
                    "collidefriendly", "false"
                    "craterareaofeffect", "116.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "burst", "3.0"
                    "burstrate", "0.4"
                    "energypershot", "6000.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "8.0"
                    "leadbonus", "0.0"
                    "model", "legbomb.s3o"
                    "soundhitwet", "splshbig"
                    "soundhitvolume", "38.0"
                    "soundstartvolume", "24.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "3.15924835205 -0.787798413086 6.6563873291"
                collisionVolumeScales = Some "81.6838531494 113.772003174 72.5632324219"
                collisionVolumeType = Some "Box"
                damage = Some 2520.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 40.0
                metal = Some 2720.0
                object_ = Some "Units/leglrpc_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1260.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 1088.0
                object_ = Some "Units/arm3X3E.s3o"
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
              ok = ["servlrg3"]
              select = ["servlrg3"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/leglrpc_aoplane.dds"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "restrictions_inclusion", "_nolrpc_"
              "canareaattack", "1.0"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/Defenses"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "32700.0"
          ] }

    let leglupara : UnitDef =
        { name = "leglupara"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 900.0
          energyCost = ValueOrExpr.Concrete 8200.0
          buildTime = ValueOrExpr.Concrete 12500.0
          health = ValueOrExpr.Concrete 4000.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/LEGLUPARA.s3o"
          buildPic = Some "LEGLUPARA.DDS"
          script = Some "Units/LEGLUPARA.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -5 0"
          collisionVolumeScales = Some "45 65 45"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "legflak_gun"
                displayName = Some "Medium g2a Flak Blunderbuss"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "vtol", 255.0
                ]
                range = Some (ValueOrExpr.Concrete 1125.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.8)
                weaponVelocity = Some 1600.0
                areaOfEffect = Some 150.0
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
                    "sprayangle", "200.0"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "burst", "2.0"
                    "burstrate", "0.01"
                    "cegtag", "flaktrailaa"
                    "collidefriendly", "false"
                    "craterareaofeffect", "192.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "cylindertargeting", "1.0"
                    "gravityaffected", "true"
                    "mygravity", "0.01"
                    "predictboost", "1.0"
                    "soundhitwet", "splslrg"
                    "soundhitvolume", "7.5"
                    "soundstartvolume", "9.0"
                    "stages", "0.0"
                    "weapontimer", "1.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "55 85 55"
                collisionVolumeType = Some "CylY"
                damage = Some 1560.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 370.0
                object_ = Some "Units/leglupara_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 780.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 150.0
                object_ = Some "Units/arm2x2c.s3o"
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
              ok = ["twrturn3"]
              select = ["twrturn3"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/leglupara_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "aa"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/defenses"
          ]
          extras = Map.ofList [
              "airsightdistance", "1000.0"
              "buildangle", "65536.0"
              "nochasecategory", "ALL"
          ] }

    let legmg : UnitDef =
        { name = "legmg"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 380.0
          energyCost = ValueOrExpr.Concrete 5500.0
          buildTime = ValueOrExpr.Concrete 7600.0
          health = ValueOrExpr.Concrete 2200.0
          sightDistance = ValueOrExpr.Concrete 525.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGMG.s3o"
          buildPic = Some "legmg.DDS"
          script = Some "Units/LEGMG.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "36 80 36"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "armmg_weapon"
                displayName = Some "Heavy Rapid-fire Machine Gun"
                weaponType = Some "LaserCannon"
                damage = Map.ofList [
                    "default", 17.0
                    "vtol", 17.0
                ]
                range = Some (ValueOrExpr.Concrete 575.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.4)
                weaponVelocity = Some 958.0
                areaOfEffect = Some 16.0
                accuracy = Some 7.0
                turret = Some true
                tolerance = Some 6000.0
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
                    "mount_onlytargetcategory", "NOTSUB"
                    "mount_burstControlWhenOutOfArc", "2.0"
                    "avoidfeature", "false"
                    "burst", "6.0"
                    "burstrate", "0.066"
                    "burnblow", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "duration", "0.05"
                    "fallOffRate", "0.2"
                    "firestarter", "0.0"
                    "intensity", "0.8"
                    "ownerExpAccWeight", "4.0"
                    "proximitypriority", "1.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "3.0"
                    "soundtrigger", "true"
                    "sprayangle", "968.0"
                    "texture1", "shot"
                    "texture2", "empty"
                    "thickness", "3.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "-1.45989990234 -3.69362253418 0.310646057129"
                collisionVolumeScales = Some "48.9197998047 59.9625549316 37.0396270752"
                collisionVolumeType = Some "Box"
                damage = Some 774.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 50.0
                metal = Some 114.0
                object_ = Some "Units/legmg_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 387.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 46.0
                object_ = Some "Units/arm2X2A.s3o"
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
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legmg_aoplane.dds"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weaponaa"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandDefenceOffence"
          ]
          extras = Map.ofList [
              "airsightdistance", "650.0"
              "buildangle", "32768.0"
              "cantbetransported", "false"
              "mass", "7500.0"
          ] }

    let legperdition : UnitDef =
        { name = "legperdition"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 1250.0
          energyCost = ValueOrExpr.Concrete 15000.0
          buildTime = ValueOrExpr.Concrete 62000.0
          health = ValueOrExpr.Concrete 4000.0
          sightDistance = ValueOrExpr.Concrete 500.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/legperdition.s3o"
          buildPic = Some "legperdition.DDS"
          script = Some "Units/legperdition.cob"
          corpse = Some "DEAD"
          explodeAs = Some "nukeBuilding"
          selfDestructAs = Some "nukeBuildingSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "80 70 80"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "napalmmissile"
                displayName = Some "Long-Range Tactical Hellfire Napalm Shell"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "commanders", 700.0
                    "default", 1200.0
                ]
                range = Some (ValueOrExpr.Concrete 2300.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 550.0
                areaOfEffect = Some 425.0
                accuracy = None
                turret = Some true
                tolerance = Some 9000.0
                edgeEffectiveness = Some 0.75
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "cannhvy6"
                soundHit = Some "xplolrg4"
                explosiongenerator = Some "custom:fire-explosion-large"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "area_onhit_ceg", "fire-area-150-repeat"
                    "area_onhit_damageceg", "burnflamexl-gen"
                    "area_onhit_resistance", "fire"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTLAND"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "cegtag", "burnflame-xs"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "commandfire", "true"
                    "craterareaofeffect", "360.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "13000.0"
                    "flamegfxtime", "1.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "interceptedbyshieldtype", "0.0"
                    "metalpershot", "350.0"
                    "model", "legbomb.s3o"
                    "smokecolor", "0.7"
                    "smokeperiod", "9.0"
                    "smokesize", "14.0"
                    "smoketime", "60.0"
                    "smoketrail", "true"
                    "soundhitwet", "splslrg"
                    "stockpile", "true"
                    "stockpiletime", "50.0"
                    "texture1", "null"
                    "texture2", "railguntrail"
                    "turnrate", "5000.0"
                    "weaponacceleration", "220.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "80 70 80"
                collisionVolumeType = Some "CylY"
                damage = Some 1920.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 445.0
                object_ = Some "Units/legperdition_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 960.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 178.0
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
              ok = ["servroc1"]
              select = ["servroc1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecaltype", "decals/legperdition_aoplane.dds"
              "model_author", "Hornet, Tharsis"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "selectionscalemult", "1.0"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "unitgroup", "weapon"
              "restrictions_inclusion", "_notacnukes_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let legrhapsis : UnitDef =
        { name = "legrhapsis"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 280.0
          energyCost = ValueOrExpr.Concrete 6500.0
          buildTime = ValueOrExpr.Concrete 4700.0
          health = ValueOrExpr.Concrete 1900.0
          sightDistance = ValueOrExpr.Concrete 375.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGRHAPSIS.s3o"
          buildPic = Some "LEGRHAPSIS.DDS"
          script = Some "Units/LEGRHAPSIS.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "28 40 28"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "burst_aa_missile"
                displayName = Some "Advanced g2a Salvo Missile Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 13.0
                ]
                range = Some (ValueOrExpr.Concrete 840.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.5)
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
                    "burst", "6.0"
                    "burstrate", "0.005"
                    "dance", "150.0"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "72.0"
                    "flighttime", "2.5"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "7.0"
                    "smoketime", "10.0"
                    "smokesize", "1.7"
                    "smokecolor", "1.0"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "800.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "68000.0"
                    "weaponacceleration", "300.0"
                    "weapontimer", "2.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "28 40 28"
                collisionVolumeType = Some "CylY"
                damage = Some 1500.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 10.0
                metal = Some 190.0
                object_ = Some "Units/legrhapsis_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 750.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = None
                metal = Some 100.0
                object_ = Some "Units/cor2X2C.s3o"
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
              ok = ["twrturn3"]
              select = ["twrturn3"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legrhapsis_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "aa"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/Defenses"
          ]
          extras = Map.ofList [
              "airsightdistance", "850.0"
              "buildangle", "8192.0"
              "energyupkeep", "5.0"
          ] }

    let legrl : UnitDef =
        { name = "legrl"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 80.0
          energyCost = ValueOrExpr.Concrete 850.0
          buildTime = ValueOrExpr.Concrete 1750.0
          health = ValueOrExpr.Concrete 335.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/LEGRL.s3o"
          buildPic = Some "LEGRL.DDS"
          script = Some "Units/LEGRL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "26 52 26"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "legrl_missile"
                displayName = Some "Light g2a Missile Launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 115.0
                ]
                range = Some (ValueOrExpr.Concrete 765.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.7)
                weaponVelocity = Some 750.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
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
                    "mount_badtargetcategory", "NOWEAPON LIGHTAIRSCOUT"
                    "mount_onlytargetcategory", "VTOL"
                    "mount_fastautoretargeting", "true"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "canattackground", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "1.9"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "6.0"
                    "smoketime", "12.0"
                    "smokesize", "4.8"
                    "smokecolor", "0.95"
                    "smokeTrailCastShadow", "false"
                    "castshadow", "false"
                    "soundhitwet", "splshbig"
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
            { yardMap = Some "ooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "26 52 26"
                collisionVolumeType = Some "Box"
                damage = Some 180.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 49.0
                object_ = Some "Units/legrl_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 90.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 20.0
                object_ = Some "Units/cor3X3D.s3o"
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
              ok = ["kbcormov"]
              select = ["kbcorsel"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legrl_aoplane.dds"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "aa"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/Defenses"
          ]
          extras = Map.ofList [
              "airsightdistance", "700.0"
              "cantbetransported", "false"
              "mass", "5100.0"
              "nochasecategory", "ALL"
          ] }

    let legsilo : UnitDef =
        { name = "legsilo"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 7700.0
          energyCost = ValueOrExpr.Concrete 82000.0
          buildTime = ValueOrExpr.Concrete 181000.0
          health = ValueOrExpr.Concrete 6200.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/LEGSILO.s3o"
          buildPic = Some "LEGSILO.DDS"
          script = Some "Units/LEGSILO.cob"
          corpse = Some "DEAD"
          explodeAs = Some "nukeBuilding"
          selfDestructAs = Some "nukeBuildingSelfd"
          collisionVolumeOffsets = Some "0 18 -2"
          collisionVolumeScales = Some "90 38 84"
          collisionVolumeType = Some "Box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "legicbm"
                displayName = Some "Intercontinental Thermonuclear Ballistic Missile"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "commanders", 2500.0
                    "default", 11500.0
                ]
                range = Some (ValueOrExpr.Concrete 72000.0)
                reloadTime = Some (ValueOrExpr.Concrete 30.0)
                weaponVelocity = Some 1600.0
                areaOfEffect = Some 1920.0
                accuracy = None
                turret = None
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.45
                impulseFactor = Some 0.5
                noSelfDamage = None
                soundStart = Some "nukelaunch"
                soundHit = Some "nukecor"
                explosiongenerator = Some "custom:newnukecor"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "place_target_on_ground", "true"
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "cegtag", "NUKETRAIL"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "commandfire", "true"
                    "craterareaofeffect", "1920.0"
                    "craterboost", "2.4"
                    "cratermult", "1.2"
                    "energypershot", "187500.0"
                    "firestarter", "100.0"
                    "flighttime", "400.0"
                    "metalpershot", "1500.0"
                    "model", "legicbm.s3o"
                    "smoketrail", "true"
                    "smokePeriod", "10.0"
                    "smoketime", "130.0"
                    "smokesize", "28.0"
                    "smokecolor", "0.85"
                    "smokeTrailCastShadow", "true"
                    "soundhitwet", "nukewater"
                    "soundhitwetvolume", "56.0"
                    "soundstartvolume", "20.0"
                    "stockpile", "true"
                    "stockpiletime", "180.0"
                    "texture1", "null"
                    "texture2", "railguntrail"
                    "texture3", "null"
                    "targetable", "1.0"
                    "turnrate", "5500.0"
                    "weaponacceleration", "100.0"
                    "weapontimer", "5.5"
                ] }
              { name = "nuclear_launch"
                displayName = Some "Nuclear Launch"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 0.0)
                reloadTime = Some (ValueOrExpr.Concrete 30.0)
                weaponVelocity = Some 100.0
                areaOfEffect = Some 0.0
                accuracy = None
                turret = None
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.0
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = None
                soundHit = Some "nukelaunchalarm"
                explosiongenerator = None
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "metalpershot", "0.0"
                    "soundhitvolume", "50.0"
                    "turnrate", "10000.0"
                    "weaponacceleration", "101.0"
                    "weapontimer", "0.1"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "ooooooooooooooooooooooooooooooooooooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = None })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 -0.0182740600586 2.87522888184"
                collisionVolumeScales = Some "75.0 23.7250518799 77.7504577637"
                collisionVolumeType = Some "Box"
                damage = Some 3336.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 4672.0
                object_ = Some "Units/legsilo_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1668.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 1869.0
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
              ok = ["servroc1"]
              select = ["servroc1"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legsilo_aoplane.dds"
              "buildinggrounddecalsizey", "10.0"
              "buildinggrounddecalsizex", "10.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "nuke"
              "model_author", "Tharsy"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "radardistance", "50.0"
          ] }

    let legstarfall : UnitDef =
        { name = "legstarfall"
          subfolder = "Legion/Defenses"
          metalCost = ValueOrExpr.Concrete 63000.0
          energyCost = ValueOrExpr.Concrete 720000.0
          buildTime = ValueOrExpr.Concrete 1400000.0
          health = ValueOrExpr.Concrete 26000.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 9.0
          footprintZ = 9.0
          objectName = Some "Units/legstarfall.s3o"
          buildPic = Some "legstarfall.DDS"
          script = Some "Units/legstarfall.cob"
          corpse = Some "DEAD"
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advancedFusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "125 135 120"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "starfire"
                displayName = Some "Very Long-Range High-Trajectory 63-Salvo Plasma Launcher"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 600.0
                    "shields", 240.0
                    "subs", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 6100.0)
                reloadTime = Some (ValueOrExpr.Concrete 14.0)
                weaponVelocity = Some 900.0
                areaOfEffect = Some 256.0
                accuracy = Some 0.0
                turret = Some true
                tolerance = Some 364.0
                edgeEffectiveness = Some 0.95
                impulseFactor = Some 0.5
                noSelfDamage = Some true
                soundStart = Some "lrpcshot"
                soundHit = Some "rflrpcexplo"
                explosiongenerator = Some "custom:starfire-explosion"
                rgbColor = Some "0.7 0.7 1.0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "mount_burstControlWhenOutOfArc", "1.0"
                    "mount_maindir", "0 0 1"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "burst", "63.0"
                    "burstrate", "0.03"
                    "sprayangle", "500.0"
                    "highTrajectory", "1.0"
                    "cegtag", "starfire"
                    "collidefriendly", "false"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "360000.0"
                    "fireTolerance", "364.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splshbig"
                    "soundhitvolume", "36.0"
                    "weapontimer", "14.0"
                    "windup", "5.0"
                ] }
              { name = "energycharger"
                displayName = Some "Plasma Volley Energy Charger (supplies energy to Starfall cannon)"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.0)
                weaponVelocity = Some 1000.0
                areaOfEffect = Some 0.0
                accuracy = None
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "starfallchargup"
                soundHit = Some "starfallchargup"
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
                    "metalpershot", "0.0"
                    "energypershot", "0.0"
                    "size", "0.0"
                    "soundhitwet", "starfallchargup"
                    "soundstartvolume", "124.0"
                ] }
          ]
          economy = None
          building = Some (
            { yardMap = Some "oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "125 100 120"
                collisionVolumeType = Some "CylY"
                damage = Some 26000.0
                featureDead = Some "HEAP"
                footprintX = Some 7.0
                footprintZ = Some 7.0
                height = Some 20.0
                metal = Some 25000.0
                object_ = Some "Units/legstarfall_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "80 10 80"
                collisionVolumeType = None
                damage = Some 12000.0
                featureDead = None
                footprintX = Some 7.0
                footprintZ = Some 7.0
                height = Some 4.0
                metal = Some 12000.0
                object_ = Some "Units/cor7X7A.s3o"
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
              ok = ["servlrg4"]
              select = ["servlrg4"] })
          customParams = Map.ofList [
              "usebuildinggrounddecal", "true"
              "buildinggrounddecaltype", "decals/legstarfall_aoplane.dds"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecaldecayspeed", "30.0"
              "unitgroup", "weapon"
              "restrictions_inclusion", "_nolrpc_noendgamelrpc_"
              "model_author", "ZephyrSkies"
              "normaltex", "unittextures/leg_normal.dds"
              "removewait", "true"
              "subfolder", "Legion/Defenses"
              "techlevel", "2.0"
          ]
          extras = Map.ofList [
              "buildangle", "29096.0"
              "hightrajectory", "1.0"
              "firestate", "0.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "legabm", legabm
            "legacluster", legacluster
            "legapopupdef", legapopupdef
            "legbastion", legbastion
            "legbombard", legbombard
            "legcluster", legcluster
            "legdrag", legdrag
            "legdtr", legdtr
            "legflak", legflak
            "legforti", legforti
            "leggatet3", leggatet3
            "leghive", leghive
            "leglht", leglht
            "leglraa", leglraa
            "leglrpc", leglrpc
            "leglupara", leglupara
            "legmg", legmg
            "legperdition", legperdition
            "legrhapsis", legrhapsis
            "legrl", legrl
            "legsilo", legsilo
            "legstarfall", legstarfall
        ]
