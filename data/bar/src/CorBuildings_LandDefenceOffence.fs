// Auto-generated BAR unit data: CorBuildings/LandDefenceOffence
namespace BarData.Units

open BarData

module CorBuildings_LandDefenceOffence =

    let corbhmth : UnitDef =
        { name = "corbhmth"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 3100.0
          energyCost = ValueOrExpr.Concrete 35000.0
          buildTime = ValueOrExpr.Concrete 59600.0
          health = ValueOrExpr.Concrete 8300.0
          sightDistance = ValueOrExpr.Concrete 650.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/CORBHMTH.s3o"
          buildPic = Some "CORBHMTH.DDS"
          script = Some "Units/corbhmth.cob"
          corpse = Some "dead"
          explodeAs = Some "largeBuildingExplosionGeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "80 80 80"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "corbhmth_weapon"
                displayName = Some "Heavy g2g barrage plasma battery"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 450.0
                    "subs", 150.0
                    "vtol", 110.0
                ]
                range = Some (ValueOrExpr.Concrete 1650.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.166)
                weaponVelocity = Some 620.0
                areaOfEffect = Some 192.0
                accuracy = Some 780.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 0.8
                noSelfDamage = Some true
                soundStart = Some "xplolrg5"
                soundHit = Some "xplonuk5"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "arty-extraheavy"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "150.0"
                    "firestarter", "99.0"
                    "gravityaffected", "true"
                    "soundhitvolume", "30.0"
                    "soundhitwet", "splslrg"
                    "soundstartvolume", "20.0"
                ] }
              { name = "corbhmth_weapon"
                displayName = Some "Heavy g2g barrage plasma battery"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 450.0
                    "subs", 150.0
                    "vtol", 110.0
                ]
                range = Some (ValueOrExpr.Concrete 1650.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.166)
                weaponVelocity = Some 620.0
                areaOfEffect = Some 192.0
                accuracy = Some 780.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 0.8
                noSelfDamage = Some true
                soundStart = Some "xplolrg5"
                soundHit = Some "xplonuk5"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "arty-extraheavy"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "150.0"
                    "firestarter", "99.0"
                    "gravityaffected", "true"
                    "soundhitvolume", "30.0"
                    "soundhitwet", "splslrg"
                    "soundstartvolume", "20.0"
                ] }
              { name = "corbhmth_weapon"
                displayName = Some "Heavy g2g barrage plasma battery"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 450.0
                    "subs", 150.0
                    "vtol", 110.0
                ]
                range = Some (ValueOrExpr.Concrete 1650.0)
                reloadTime = Some (ValueOrExpr.Concrete 4.166)
                weaponVelocity = Some 620.0
                areaOfEffect = Some 192.0
                accuracy = Some 780.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.85
                impulseFactor = Some 0.8
                noSelfDamage = Some true
                soundStart = Some "xplolrg5"
                soundHit = Some "xplonuk5"
                explosiongenerator = Some "custom:genericshellexplosion-large-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "arty-extraheavy"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "150.0"
                    "firestarter", "99.0"
                    "gravityaffected", "true"
                    "soundhitvolume", "30.0"
                    "soundhitwet", "splslrg"
                    "soundstartvolume", "20.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 450.0)
              metalMake = None
              energyStorage = Some 500.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "h cbyybsgybc bsbssbbssb ysbsbssbby gbsssbsssy sbsbsssbsb bsbsssbsbs ysssbsssbg ybbssbsbsy bssbbssbsb cbygsbyybc"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "80 80 80"
                collisionVolumeType = Some "cylY"
                damage = Some 4500.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 1917.0
                object_ = Some "Units/corbhmth_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 2250.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 767.0
                object_ = Some "Units/cor5X5C.s3o"
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
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = []
              select = ["geothrm2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "8.0"
              "buildinggrounddecalsizey", "8.0"
              "buildinggrounddecaltype", "decals/corbhmth_aoplane.dds"
              "cvbuildable", "true"
              "geothermal", "1.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "unitgroup", "energy"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "nochasecategory", "MOBILE"
          ] }

    let corbuzz : UnitDef =
        { name = "corbuzz"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 68000.0
          energyCost = ValueOrExpr.Concrete 800000.0
          buildTime = ValueOrExpr.Concrete 1400000.0
          health = ValueOrExpr.Concrete 33500.0
          sightDistance = ValueOrExpr.Concrete 700.0
          footprintX = 8.0
          footprintZ = 8.0
          objectName = Some "Units/CORBUZZ.s3o"
          buildPic = Some "CORBUZZ.DDS"
          script = Some "Units/CORBUZZ.cob"
          corpse = Some "DEAD"
          explodeAs = Some "advancedFusionExplosion"
          selfDestructAs = Some "advancedFusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "80 160 80"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "rflrpc"
                displayName = Some "Rapid-fire long-range plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 2000.0
                    "shields", 1000.0
                    "subs", 600.0
                ]
                range = Some (ValueOrExpr.Concrete 6100.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.75)
                weaponVelocity = Some 1150.0
                areaOfEffect = Some 157.0
                accuracy = Some 750.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.1
                noSelfDamage = Some true
                soundStart = Some "lrpcshot"
                soundHit = Some "rflrpcexplo"
                explosiongenerator = Some "custom:genericshellexplosion-huge"
                rgbColor = Some "1, 0.4, 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "avoidground", "false"
                    "cegtag", "arty-huge"
                    "collidefriendly", "false"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "18000.0"
                    "gravityaffected", "true"
                    "soundhitvolume", "36.0"
                    "soundhitwet", "splshbig"
                    "weapontimer", "14.0"
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
                collisionVolumeScales = Some "80 160 80"
                collisionVolumeType = Some "CylY"
                damage = Some 26000.0
                featureDead = Some "HEAP"
                footprintX = Some 7.0
                footprintZ = Some 7.0
                height = Some 20.0
                metal = Some 30000.0
                object_ = Some "Units/corbuzz_dead.s3o"
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
                metal = Some 14000.0
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "11.0"
              "buildinggrounddecalsizey", "11.0"
              "buildinggrounddecaltype", "decals/corbuzz_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "unitgroup", "weapon"
              "restrictions_inclusion", "_nolrpc_noendgamelrpc_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "29096.0"
              "firestate", "0.0"
          ] }

    let cordoom : UnitDef =
        { name = "cordoom"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 3000.0
          energyCost = ValueOrExpr.Concrete 37000.0
          buildTime = ValueOrExpr.Concrete 55200.0
          health = ValueOrExpr.Concrete 9400.0
          sightDistance = ValueOrExpr.Concrete 780.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORDOOM.s3o"
          buildPic = Some "CORDOOM.DDS"
          script = Some "Units/CORDOOM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0.0 -17.0 0.0"
          collisionVolumeScales = Some "48.0 110.0 48.0"
          collisionVolumeType = Some "box"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "atadr"
                displayName = Some "Long-range g2g tachyon accelerator"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 999.0
                    "default", 4500.0
                ]
                range = Some (ValueOrExpr.Concrete 950.0)
                reloadTime = Some (ValueOrExpr.Concrete 6.0)
                weaponVelocity = Some 1500.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "annigun1"
                soundHit = None
                explosiongenerator = Some "custom:laserhit-large-blue"
                rgbColor = Some "0 0 1"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "beamtime", "0.3"
                    "corethickness", "0.32"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "800.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.8"
                    "scrollspeed", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "texture3", "largebeam"
                    "thickness", "5.5"
                    "tilelength", "150.0"
                ] }
              { name = "doomsday_green_laser"
                displayName = Some "High energy g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 247.0
                    "vtol", 65.0
                ]
                range = Some (ValueOrExpr.Concrete 650.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.53333)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrhvy3"
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
                    "beamtime", "0.25"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "50.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "proximitypriority", "0.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.6"
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
            { yardMap = Some "yooy oooo oooo yooy"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.281730651855 -0.153618286133 3.57356262207"
                collisionVolumeScales = Some "80.6815948486 91.7637634277 82.1471252441"
                collisionVolumeType = Some "Box"
                damage = Some 5400.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 1611.0
                object_ = Some "Units/cordoom_dead.s3o"
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
                metal = Some 644.0
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/cordoom_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "unitgroup", "weapon"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "damagemodifier", "0.25"
              "nochasecategory", "VTOL"
              "onoffable", "true"
              "radardistance", "1200.0"
              "radaremitheight", "80.0"
              "sightemitheight", "80.0"
          ] }

    let corerad : UnitDef =
        { name = "corerad"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 800.0
          energyCost = ValueOrExpr.Concrete 7900.0
          buildTime = ValueOrExpr.Concrete 12000.0
          health = ValueOrExpr.Concrete 4450.0
          sightDistance = ValueOrExpr.Concrete 380.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORERAD.s3o"
          buildPic = Some "CORERAD.DDS"
          script = Some "Units/CORERAD.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "cor_erad"
                displayName = Some "Long-range rapid-fire g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 1125.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.6)
                weaponVelocity = Some 1300.0
                areaOfEffect = Some 48.0
                accuracy = None
                turret = Some true
                tolerance = Some 100000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "rocklit1"
                soundHit = Some "xplosml2"
                explosiongenerator = Some "custom:genericshellexplosion-tiny-aa"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTAIR LIGHTAIRSCOUT"
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "VTOL"
                    "avoidfeature", "false"
                    "burnblow", "true"
                    "burst", "4.0"
                    "burstrate", "0.23333"
                    "canattackground", "false"
                    "castshadow", "false"
                    "cegtag", "missiletrailaa"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "20.0"
                    "flighttime", "2.3"
                    "model", "cormissile.s3o"
                    "projectiles", "1.0"
                    "proximitypriority", "-0.5"
                    "smokecolor", "0.95"
                    "smokeperiod", "8.0"
                    "smokesize", "5.2"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "soundtrigger", "true"
                    "startvelocity", "540.0"
                    "texture1", "null"
                    "texture2", "smoketrailaa3"
                    "tracks", "true"
                    "turnrate", "38000.0"
                    "weaponacceleration", "300.0"
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
                collisionVolumeOffsets = Some "-0.683853149414 -1.83105470342e-07 -1.83734893799"
                collisionVolumeScales = Some "54.6322937012 35.8339996338 48.325302124"
                collisionVolumeType = Some "Box"
                damage = Some 1560.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 370.0
                object_ = Some "Units/corerad_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 780.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 150.0
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
              ok = ["twrturn3"]
              select = ["twrturn3"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/corerad_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "unitgroup", "aa"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "airsightdistance", "1060.0"
              "buildangle", "65536.0"
          ] }

    let corexp : UnitDef =
        { name = "corexp"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 240.0
          energyCost = ValueOrExpr.Concrete 1900.0
          buildTime = ValueOrExpr.Concrete 2900.0
          health = ValueOrExpr.Concrete 1440.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/COREXP.s3o"
          buildPic = Some "COREXP.DDS"
          script = Some "Units/COREXP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -10 0"
          collisionVolumeScales = Some "40 45 40"
          collisionVolumeType = Some "BOX"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "hllt_bottom"
                displayName = Some "Light close-quarters g2g laser turret"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 112.5
                    "default", 75.0
                    "vtol", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 435.0)
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
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.12"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "15.0"
                    "firestarter", "100.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.5"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some 75.0
              extractsMetal = Some 0.001 })
          building = Some (
            { yardMap = Some "h cbbbbbbc bssssosb bosbbssb bsbbbbsb bsbbbbsb bssbbsob bsossssb cbbbbbbc"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 0.0 -0.0"
                collisionVolumeScales = Some "40 45 40"
                collisionVolumeType = Some "Box"
                damage = Some 780.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 122.0
                object_ = Some "Units/corexp_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 390.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 49.0
                object_ = Some "Units/cor3X3A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "mexrun2"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = ["cantdo4"]
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["servmed2"]
              select = ["mexon2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/corexp_aoplane.dds"
              "cvbuildable", "true"
              "metal_extractor", "1.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "32768.0"
              "canattack", "true"
              "energyupkeep", "3.0"
              "nochasecategory", "MOBILE"
              "onoffable", "false"
          ] }

    let corflak : UnitDef =
        { name = "corflak"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 850.0
          energyCost = ValueOrExpr.Concrete 14000.0
          buildTime = ValueOrExpr.Concrete 20100.0
          health = ValueOrExpr.Concrete 1840.0
          sightDistance = ValueOrExpr.Concrete 525.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORFLAK.s3o"
          buildPic = Some "CORFLAK.DDS"
          script = Some "Units/CORFLAK.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingExplosionGeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "28 34 28"
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
                weaponVelocity = Some 1600.0
                areaOfEffect = Some 172.0
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
                    "soundhitvolume", "7.5"
                    "soundhitwet", "splslrg"
                    "soundstartvolume", "9.0"
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
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "37.281829834 27.9406890869 36.1777038574"
                collisionVolumeType = Some "CylY"
                damage = Some 993.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 515.0
                object_ = Some "Units/corflak_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 497.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 206.0
                object_ = Some "Units/cor2X2D.s3o"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecaltype", "decals/corflak_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "unitgroup", "aa"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "airsightdistance", "1000.0"
              "buildangle", "8192.0"
              "nochasecategory", "ALL"
          ] }

    let corfmd : UnitDef =
        { name = "corfmd"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 1500.0
          energyCost = ValueOrExpr.Concrete 40000.0
          buildTime = ValueOrExpr.Concrete 60000.0
          health = ValueOrExpr.Concrete 3300.0
          sightDistance = ValueOrExpr.Concrete 195.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORFMD.s3o"
          buildPic = Some "CORFMD.DDS"
          script = Some "Units/corfmd.cob"
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
                object_ = Some "Units/corfmd_dead.s3o"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/corfmd_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "unitgroup", "antinuke"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "canattack", "false"
              "noautofire", "true"
              "radardistance", "50.0"
          ] }

    let corhllt : UnitDef =
        { name = "corhllt"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 195.0
          energyCost = ValueOrExpr.Concrete 1750.0
          buildTime = ValueOrExpr.Concrete 4900.0
          health = ValueOrExpr.Concrete 1670.0
          sightDistance = ValueOrExpr.Concrete 475.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORHLLT.s3o"
          buildPic = Some "CORHLLT.DDS"
          script = Some "Units/CORHLLT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 6 0"
          collisionVolumeScales = Some "32 90 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "hllt_top"
                displayName = Some "Close-quarters light g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 112.5
                    "default", 75.0
                    "vtol", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 490.0)
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
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.12"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "15.0"
                    "firestarter", "30.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "proximitypriority", "-1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
              { name = "hllt_bottom"
                displayName = Some "Close-quarters light g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 112.5
                    "default", 75.0
                    "vtol", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 400.0)
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
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.12"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "15.0"
                    "firestarter", "100.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "proximitypriority", "1.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
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
                collisionVolumeOffsets = Some "0 6 0"
                collisionVolumeScales = Some "32 90 32"
                collisionVolumeType = Some "CylY"
                damage = Some 900.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 6.5
                metal = Some 120.0
                object_ = Some "Units/corhllt_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 450.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 1.0
                metal = Some 48.0
                object_ = Some "Units/cor4X4D.s3o"
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
              select = ["hlltselect"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecaltype", "decals/corhllt_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "unitgroup", "weapon"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "32768.0"
              "cantbetransported", "false"
              "mass", "10200.0"
          ] }

    let corhlt : UnitDef =
        { name = "corhlt"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 480.0
          energyCost = ValueOrExpr.Concrete 4700.0
          buildTime = ValueOrExpr.Concrete 11400.0
          health = ValueOrExpr.Concrete 2750.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORHLT.s3o"
          buildPic = Some "CORHLT.DDS"
          script = Some "Units/CORHLT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -8 0"
          collisionVolumeScales = Some "38 90 38"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "cor_laserh1"
                displayName = Some "High energy g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 392.0
                    "default", 261.0
                    "vtol", 35.0
                ]
                range = Some (ValueOrExpr.Concrete 620.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.2)
                weaponVelocity = Some 2250.0
                areaOfEffect = Some 14.0
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
                    "beamtime", "0.15"
                    "corethickness", "0.2"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "50.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "8.8"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.7"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = Some 200.0
              metalStorage = None
              extractsMetal = None })
          building = Some (
            { yardMap = Some "oooo"
              activateWhenBuilt = None
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 0"
                collisionVolumeScales = Some "38 95 38"
                collisionVolumeType = Some "CylY"
                damage = Some 1485.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 292.0
                object_ = Some "Units/corhlt_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 743.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 117.0
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecaltype", "decals/corhlt_aoplane.dds"
              "legacyname", "Gaat Gun"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "unitgroup", "weapon"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "nochasecategory", "MOBILE"
          ] }

    let corint : UnitDef =
        { name = "corint"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 4600.0
          energyCost = ValueOrExpr.Concrete 67000.0
          buildTime = ValueOrExpr.Concrete 93300.0
          health = ValueOrExpr.Concrete 4700.0
          sightDistance = ValueOrExpr.Concrete 273.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "Units/CORINT.s3o"
          buildPic = Some "CORINT.DDS"
          script = Some "Units/corint.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingExplosionGeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 -20"
          collisionVolumeScales = Some "72 105 72"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "lrpc"
                displayName = Some "Long-range plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 2000.0
                    "shields", 1000.0
                    "subs", 600.0
                ]
                range = Some (ValueOrExpr.Concrete 4950.0)
                reloadTime = Some (ValueOrExpr.Concrete 16.0)
                weaponVelocity = Some 1150.0
                areaOfEffect = Some 157.0
                accuracy = Some 335.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 1.1
                noSelfDamage = Some true
                soundStart = Some "lrpcshot"
                soundHit = Some "lrpcexplo"
                explosiongenerator = Some "custom:genericshellexplosion-huge"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "cegtag", "arty-huge"
                    "collidefriendly", "false"
                    "craterareaofeffect", "136.0"
                    "craterboost", "0.1"
                    "cratermult", "0.1"
                    "energypershot", "6000.0"
                    "gravityaffected", "true"
                    "heightboostfactor", "6.0"
                    "leadbonus", "0.0"
                    "soundhitvolume", "42.0"
                    "soundhitwet", "splshbig"
                    "soundstartvolume", "28.0"
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
                collisionVolumeOffsets = Some "0.0 0.0987820556641 -0.0"
                collisionVolumeScales = Some "86.25 91.6069641113 74.6947021484"
                collisionVolumeType = Some "Box"
                damage = Some 2760.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 2813.0
                object_ = Some "Units/corint_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 1380.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 1125.0
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
              ok = ["servlrg4"]
              select = ["servlrg4"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "7.5"
              "buildinggrounddecalsizey", "7.5"
              "buildinggrounddecaltype", "decals/corint_aoplane.dds"
              "canareaattack", "1.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "unitgroup", "weapon"
              "restrictions_inclusion", "_nolrpc_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "32700.0"
              "usepiececollisionvolumes", "1.0"
          ] }

    let corjuno : UnitDef =
        { name = "corjuno"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 660.0
          energyCost = ValueOrExpr.Concrete 16000.0
          buildTime = ValueOrExpr.Concrete 27700.0
          health = ValueOrExpr.Concrete 2500.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORJUNO.s3o"
          buildPic = Some "CORJUNO.DDS"
          script = Some "Units/CORJUNO.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -2 0"
          collisionVolumeScales = Some "50 88 50"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "juno_pulse"
                displayName = Some "Anti radar/minefield/jammer magnetic impulse rocket"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "default", 1.0
                    "mines", 1.0
                ]
                range = Some (ValueOrExpr.Concrete 32000.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 500.0
                areaOfEffect = Some 1400.0
                accuracy = None
                turret = None
                tolerance = Some 4000.0
                edgeEffectiveness = Some 1.0
                impulseFactor = Some 0.0
                noSelfDamage = None
                soundStart = Some "junofir2"
                soundHit = Some "junohit2"
                explosiongenerator = Some "custom:juno-explo"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "junotype", "base"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "MOBILE"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "castshadow", "true"
                    "cegtag", "missiletrail-juno"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "commandfire", "true"
                    "craterareaofeffect", "1400.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "12000.0"
                    "flighttime", "400.0"
                    "metalpershot", "200.0"
                    "model", "epulse.s3o"
                    "smokecolor", "0.7"
                    "smokeperiod", "8.0"
                    "smokesize", "14.0"
                    "smoketime", "45.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "stockpile", "true"
                    "stockpiletime", "75.0"
                    "interceptedbyshieldtype", "0.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "5500.0"
                    "weaponacceleration", "75.0"
                    "weapontimer", "4.0"
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
                collisionVolumeOffsets = Some "1.02378845215 -0.244132250977 6.86585998535"
                collisionVolumeScales = Some "65.8518981934 75.545135498 65.7558898926"
                collisionVolumeType = Some "Box"
                damage = Some 1350.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 388.0
                object_ = Some "Units/corjuno_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "85.0 14.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 675.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 192.0
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
              ok = ["drone1"]
              select = ["drone1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.4"
              "buildinggrounddecalsizey", "5.4"
              "buildinggrounddecaltype", "decals/corjuno_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "unitgroup", "weapon"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "stealth", "true"
          ] }

    let corllt : UnitDef =
        { name = "corllt"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 90.0
          energyCost = ValueOrExpr.Concrete 700.0
          buildTime = ValueOrExpr.Concrete 2500.0
          health = ValueOrExpr.Concrete 650.0
          sightDistance = ValueOrExpr.Concrete 494.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORLLT.s3o"
          buildPic = Some "CORLLT.DDS"
          script = Some "Units/CORLLT.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -29 0"
          collisionVolumeScales = Some "32 72 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "cor_lightlaser"
                displayName = Some "Light g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 112.5
                    "default", 75.0
                    "subs", 5.0
                    "vtol", 5.0
                ]
                range = Some (ValueOrExpr.Concrete 435.0)
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
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "beamtime", "0.12"
                    "corethickness", "0.175"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "20.0"
                    "firestarter", "100.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
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
                collisionVolumeScales = Some "32 72 32"
                collisionVolumeType = Some "CylY"
                damage = Some 351.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 55.0
                object_ = Some "Units/corllt_dead.s3o"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "4.0"
              "buildinggrounddecalsizey", "4.0"
              "buildinggrounddecaltype", "decals/corllt_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "unitgroup", "weapon"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "32000.0"
              "cantbetransported", "false"
              "mass", "5100.0"
              "nochasecategory", "MOBILE"
          ] }

    let cormadsam : UnitDef =
        { name = "cormadsam"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 315.0
          energyCost = ValueOrExpr.Concrete 6100.0
          buildTime = ValueOrExpr.Concrete 5240.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 375.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORMADSAM.s3o"
          buildPic = Some "CORMADSAM.DDS"
          script = Some "Units/CORMADSAM.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingexplosiongeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "-1 5 -2"
          collisionVolumeScales = Some "45 54 45"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "madsam_missile"
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
                collisionVolumeScales = Some "45 54 45"
                collisionVolumeType = Some "CylY"
                damage = Some 1500.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 10.0
                metal = Some 233.0
                object_ = Some "Units/cormadsam_dead.s3o"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/cormadsam_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "unitgroup", "aa"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "airsightdistance", "850.0"
              "buildangle", "8192.0"
          ] }

    let cormaw : UnitDef =
        { name = "cormaw"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 290.0
          energyCost = ValueOrExpr.Concrete 1550.0
          buildTime = ValueOrExpr.Concrete 4420.0
          health = ValueOrExpr.Concrete 1610.0
          sightDistance = ValueOrExpr.Concrete 422.0
          footprintX = 2.0
          footprintZ = 2.0
          objectName = Some "Units/CORMAW.s3o"
          buildPic = Some "CORMAW.DDS"
          script = Some "Units/cormaw.cob"
          corpse = Some "DEAD"
          explodeAs = Some "flamethrower"
          selfDestructAs = Some "flamethrowerSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "dmaw"
                displayName = Some "Pop-up anti-swarm AoE flamethrower"
                weaponType = Some "Flame"
                damage = Map.ofList [
                    "commanders", 33.0
                    "default", 22.0
                    "subs", 5.5
                ]
                range = Some (ValueOrExpr.Concrete 410.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.1)
                weaponVelocity = Some 300.0
                areaOfEffect = Some 64.0
                accuracy = None
                turret = Some true
                tolerance = Some 2500.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Flamhvy1"
                soundHit = None
                explosiongenerator = Some "custom:burnblack"
                rgbColor = Some "1 0.94 0.88"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_fastautoretargeting", "true"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "burst", "16.0"
                    "burstrate", "0.05"
                    "cegtag", "burnflame-anim"
                    "colormap", "1 0.95 0.82 0.03   0.65 0.4 0.35 0.030   0.44 0.25 0.20 0.028   0.033 0.018 0.012 0.03   0.0 0.0 0.0 0.01"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "100.0"
                    "flamegfxtime", "1.0"
                    "intensity", "0.68"
                    "proximitypriority", "1.0"
                    "rgbcolor2", "0.9 0.84 0.8"
                    "sizegrowth", "0.75"
                    "soundhitdry", "flamhit1"
                    "soundhitvolume", "7.5"
                    "soundhitwet", "sizzle"
                    "soundstartvolume", "5.3"
                    "soundtrigger", "false"
                    "sprayangle", "100.0"
                    "targetmoveerror", "0.001"
                    "texture1", "flame"
                    "weapontimer", "1.0"
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
                object_ = Some "Units/cordrag.s3o"
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
              "buildinggrounddecaltype", "decals/cormaw_aoplane.dds"
              "decoyfor", "cormaw"
              "model_author", "Mr Bob"
              "neutral_when_closed", "true"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "unitgroup", "weapon"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "damagemodifier", "0.33"
              "decoyfor", "cordrag"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000000000.0"
              "nochasecategory", "MOBILE"
              "radardistancejam", "8.0"
              "stealth", "true"
              "upright", "true"
              "usepiececollisionvolumes", "1.0"
          ] }

    let cormexp : UnitDef =
        { name = "cormexp"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 2400.0
          energyCost = ValueOrExpr.Concrete 12000.0
          buildTime = ValueOrExpr.Concrete 32500.0
          health = ValueOrExpr.Concrete 7800.0
          sightDistance = ValueOrExpr.Concrete 676.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORMEXP.s3o"
          buildPic = Some "CORMEXP.DDS"
          script = Some "Units/CORMEXP.cob"
          corpse = Some "DEAD"
          explodeAs = Some "hugeBuildingexplosiongeneric"
          selfDestructAs = Some "hugeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -3 0"
          collisionVolumeScales = Some "75 44 75"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "corsumo_weapon"
                displayName = Some "High energy g2g laser"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "default", 215.0
                    "vtol", 50.0
                ]
                range = Some (ValueOrExpr.Concrete 650.0)
                reloadTime = Some (ValueOrExpr.Concrete 0.53333)
                weaponVelocity = Some 800.0
                areaOfEffect = Some 12.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrhvy3"
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
                    "beamtime", "0.15"
                    "corethickness", "0.18"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "50.0"
                    "firestarter", "90.0"
                    "impactonly", "1.0"
                    "laserflaresize", "7.7"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.4"
                ] }
              { name = "cormexp_rocket"
                displayName = Some "Heavy g2g/g2a barrage missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 260.0
                    "vtol", 45.0
                ]
                range = Some (ValueOrExpr.Concrete 650.0)
                reloadTime = Some (ValueOrExpr.Concrete 5.9)
                weaponVelocity = Some 750.0
                areaOfEffect = Some 128.0
                accuracy = None
                turret = Some true
                tolerance = None
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
                ]
                extras = Map.ofList [
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "burst", "5.0"
                    "burstrate", "0.3"
                    "cegtag", "missiletrailsmall"
                    "craterareaofeffect", "128.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "1.3"
                    "model", "cormissile.s3o"
                    "smoketrail", "false"
                    "soundhitwet", "splsmed"
                    "startvelocity", "450.0"
                    "texture1", "null"
                    "weaponacceleration", "150.0"
                    "weapontimer", "5.0"
                ] }
          ]
          economy = Some (
            { energyMake = None
              metalMake = None
              energyStorage = None
              metalStorage = Some 600.0
              extractsMetal = Some 0.004 })
          building = Some (
            { yardMap = Some "h oooooooo osssssso osssssso ossoosso ossoosso osssssso osssssso oooooooo"
              activateWhenBuilt = Some true
              canRepeat = Some false })
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0.0 0.0263531005859 -0.0"
                collisionVolumeScales = Some "85.8415527344 30.0151062012 74.3409423828"
                collisionVolumeType = Some "Box"
                damage = Some 1200.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 20.0
                metal = Some 1442.0
                object_ = Some "Units/cormexp_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = None
                collisionVolumeType = None
                damage = Some 600.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 577.0
                object_ = Some "Units/cor5X5A.s3o"
                reclaimable = Some true
                resurrectable = Some 0.0 }
          ])
          sounds = Some (
            { build = None
              repair = None
              working = Some "mohorun2"
              underAttack = Some "warning1"
              cancelDestruct = Some "cancel2"
              capture = None
              cant = []
              count = ["count6"; "count5"; "count4"; "count3"; "count2"; "count1"]
              ok = ["twractv3"]
              select = ["mohoon2"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "7.6"
              "buildinggrounddecalsizey", "7.6"
              "buildinggrounddecaltype", "decals/cormoho_aoplane.dds"
              "cvbuildable", "true"
              "metal_extractor", "4.0"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "unitgroup", "metal"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "canattack", "true"
              "decoyfor", "cormoho"
              "energyupkeep", "20.0"
              "nochasecategory", "MOBILE"
              "onoffable", "true"
          ] }

    let corpun : UnitDef =
        { name = "corpun"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 1300.0
          energyCost = ValueOrExpr.Concrete 13500.0
          buildTime = ValueOrExpr.Concrete 17400.0
          health = ValueOrExpr.Concrete 3250.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORPUN.s3o"
          buildPic = Some "CORPUN.DDS"
          script = Some "Units/armguard.cob"
          corpse = Some "DEAD"
          explodeAs = Some "largeBuildingexplosiongeneric"
          selfDestructAs = Some "largeBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 -13 0"
          collisionVolumeScales = Some "52 60 52"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "plasma"
                displayName = Some "Long-range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 350.0
                    "lboats", 350.0
                    "subs", 90.0
                    "vtol", 95.0
                ]
                range = Some (ValueOrExpr.Concrete 1245.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.16667)
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
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 1 0"
                    "mount_maxangledif", "230.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "cegtag", "arty-medium"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "soundhitwet", "splsmed"
                ] }
              { name = "plasma_high"
                displayName = Some "Long-range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 350.0
                    "lboats", 350.0
                    "subs", 90.0
                    "vtol", 95.0
                ]
                range = Some (ValueOrExpr.Concrete 1245.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.16667)
                weaponVelocity = Some 600.0
                areaOfEffect = Some 120.0
                accuracy = Some 75.0
                turret = Some true
                tolerance = None
                edgeEffectiveness = Some 0.4
                impulseFactor = Some 1.4
                noSelfDamage = Some true
                soundStart = Some "cannhvy5"
                soundHit = Some "xplomed2"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "cegtag", "arty-medium"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "hightrajectory", "1.0"
                    "mygravity", "0.289"
                    "soundhitwet", "splsmed"
                ] }
              { name = "smart_trajectory_dummy"
                displayName = Some "Long-range g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1245.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.16667)
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
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL"
                    "mount_maindir", "0 1 0"
                    "mount_maxangledif", "230.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "cegtag", "arty-medium"
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
                collisionVolumeOffsets = Some "-0.184280395508 -6.88419337158 0.0344696044922"
                collisionVolumeScales = Some "49.7204589844 16.4592132568 48.6775512695"
                collisionVolumeType = Some "Box"
                damage = Some 1764.0
                featureDead = Some "HEAP"
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 20.0
                metal = Some 936.0
                object_ = Some "Units/corpun_dead.s3o"
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
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.7"
              "buildinggrounddecalsizey", "5.7"
              "buildinggrounddecaltype", "decals/corpun_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "unitgroup", "weapon"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "nochasecategory", "MOBILE"
          ] }

    let corrl : UnitDef =
        { name = "corrl"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 80.0
          energyCost = ValueOrExpr.Concrete 850.0
          buildTime = ValueOrExpr.Concrete 1750.0
          health = ValueOrExpr.Concrete 335.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORRL.s3o"
          buildPic = Some "CORRL.DDS"
          script = Some "Units/CORRL.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 5 0"
          collisionVolumeScales = Some "32 70 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "corrl_missile"
                displayName = Some "Light g2a missile launcher"
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
                    "flighttime", "1.9"
                    "metalpershot", "0.0"
                    "model", "cormissile.s3o"
                    "smokecolor", "0.95"
                    "smokeperiod", "6.0"
                    "smokesize", "4.8"
                    "smoketime", "12.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
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
                collisionVolumeOffsets = Some "-0.808319091797 0.000184020996095 2.23503112793"
                collisionVolumeScales = Some "30.2288513184 52.705368042 33.0822753906"
                collisionVolumeType = Some "Box"
                damage = Some 180.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 49.0
                object_ = Some "Units/corrl_dead.s3o"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/corrl_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "unitgroup", "aa"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "airsightdistance", "700.0"
              "cantbetransported", "false"
              "mass", "5100.0"
              "nochasecategory", "ALL"
          ] }

    let corscreamer : UnitDef =
        { name = "corscreamer"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 1650.0
          energyCost = ValueOrExpr.Concrete 32000.0
          buildTime = ValueOrExpr.Concrete 28000.0
          health = ValueOrExpr.Concrete 1670.0
          sightDistance = ValueOrExpr.Concrete 600.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORSCREAMER.s3o"
          buildPic = Some "CORSCREAMER.DDS"
          script = Some "Units/CORSCREAMER.cob"
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
              { name = "cor_advsam"
                displayName = Some "Long-range heavy g2a missile launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "vtol", 750.0
                ]
                range = Some (ValueOrExpr.Concrete 2400.0)
                reloadTime = Some (ValueOrExpr.Concrete 1.8)
                weaponVelocity = Some 1850.0
                areaOfEffect = Some 425.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.75
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "aarocket"
                soundHit = Some "impact"
                explosiongenerator = Some "custom:genericshellexplosion-huge-aa"
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
                    "castshadow", "false"
                    "cegtag", "missiletrailaa-large"
                    "collidefriendly", "false"
                    "craterareaofeffect", "425.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "1800.0"
                    "firestarter", "90.0"
                    "flighttime", "2.2"
                    "metalpershot", "0.0"
                    "model", "corscreamermissile.s3o"
                    "proximitypriority", "-1.0"
                    "smokecolor", "0.9"
                    "smokeperiod", "3.0"
                    "smokesize", "11.0"
                    "smoketime", "24.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitvolume", "8.0"
                    "soundhitwet", "splslrg"
                    "soundstartvolume", "8.0"
                    "sprayangle", "10000.0"
                    "startvelocity", "1400.0"
                    "stockpile", "true"
                    "stockpiletime", "14.0"
                    "texture1", "null"
                    "texture2", "smoketrailaaflak"
                    "tracks", "true"
                    "trajectoryheight", "0.55"
                    "turnrate", "99000.0"
                    "weaponacceleration", "1000.0"
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
                object_ = Some "Units/corscreamer_dead.s3o"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "6.0"
              "buildinggrounddecalsizey", "6.0"
              "buildinggrounddecaltype", "decals/corscreamer_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "unitgroup", "aa"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "airsightdistance", "2400.0"
          ] }

    let corsilo : UnitDef =
        { name = "corsilo"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 7700.0
          energyCost = ValueOrExpr.Concrete 82000.0
          buildTime = ValueOrExpr.Concrete 181000.0
          health = ValueOrExpr.Concrete 6200.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 7.0
          footprintZ = 7.0
          objectName = Some "Units/CORSILO.s3o"
          buildPic = Some "CORSILO.DDS"
          script = Some "Units/CORSILO.cob"
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
              { name = "crblmssl"
                displayName = Some "Intercontinental thermonuclear ballistic missile"
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
                impulseFactor = Some 1.1
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
                    "interceptedbyshieldtype", "0.0"
                    "metalpershot", "1500.0"
                    "model", "crblmssl.s3o"
                    "smokecolor", "0.85"
                    "smokeperiod", "10.0"
                    "smokesize", "28.0"
                    "smoketime", "130.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "true"
                    "soundhitwet", "nukewater"
                    "soundhitwetvolume", "56.0"
                    "soundstartvolume", "20.0"
                    "stockpile", "true"
                    "stockpiletime", "180.0"
                    "targetable", "1.0"
                    "texture1", "null"
                    "texture2", "railguntrail"
                    "texture3", "null"
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
                object_ = Some "Units/corsilo_dead.s3o"
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
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "10.0"
              "buildinggrounddecalsizey", "10.0"
              "buildinggrounddecaltype", "decals/corsilo_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "unitgroup", "nuke"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "radardistance", "50.0"
          ] }

    let cortoast : UnitDef =
        { name = "cortoast"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 17000.0
          buildTime = ValueOrExpr.Concrete 25700.0
          health = ValueOrExpr.Concrete 4250.0
          sightDistance = ValueOrExpr.Concrete 416.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORTOAST.s3o"
          buildPic = Some "CORTOAST.DDS"
          script = Some "Units/CORTOAST.cob"
          corpse = Some "DEAD"
          explodeAs = Some "mediumBuildingExplosionGeneric"
          selfDestructAs = Some "mediumBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "60 30 15"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "cortoast_gun"
                displayName = Some "Pop-up long-range heavy g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 420.0
                    "hvyboats", 420.0
                    "lboats", 420.0
                    "subs", 90.0
                    "vtol", 90.0
                ]
                range = Some (ValueOrExpr.Concrete 1390.0)
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
                explosiongenerator = Some "custom:genericshellexplosion-medium-aoe"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_maindir", "0 1 0"
                    "mount_maxangledif", "230.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "cegtag", "arty-heavy"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "predictboost", "0.2"
                    "soundhitwet", "splslrg"
                ] }
              { name = "cortoast_gun_high"
                displayName = Some "Pop-up long-range heavy g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 420.0
                    "hvyboats", 420.0
                    "lboats", 420.0
                    "subs", 90.0
                    "vtol", 90.0
                ]
                range = Some (ValueOrExpr.Concrete 1390.0)
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
                explosiongenerator = Some "custom:genericshellexplosion-medium-aoe"
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
                    "hightrajectory", "1.0"
                    "predictboost", "0.2"
                    "soundhitwet", "splslrg"
                ] }
              { name = "smart_trajectory_dummy"
                displayName = Some "Pop-up long-range heavy g2g plasma cannon"
                weaponType = Some "Cannon"
                damage = Map.ofList [
                    "default", 0.0
                ]
                range = Some (ValueOrExpr.Concrete 1390.0)
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
                explosiongenerator = Some "custom:genericshellexplosion-medium-aoe"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "mount_badtargetcategory", "VTOL GROUNDSCOUT"
                    "mount_maindir", "0 1 0"
                    "mount_maxangledif", "230.0"
                    "mount_onlytargetcategory", "SURFACE"
                    "avoidfeature", "false"
                    "avoidneutral", "true"
                    "cegtag", "arty-heavy"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "gravityaffected", "true"
                    "predictboost", "0.2"
                    "soundhitwet", "splslrg"
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
                collisionVolumeScales = Some "60 30 60"
                collisionVolumeType = Some "cylY"
                damage = Some 2304.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 1507.0
                object_ = Some "Units/cortoast_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "55.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 576.0
                featureDead = None
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 4.0
                metal = Some 241.0
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
              ok = ["twrturn3"]
              select = ["twrturn3"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "5.0"
              "buildinggrounddecalsizey", "5.0"
              "buildinggrounddecaltype", "decals/cortoast_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "unitgroup", "weapon"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "damagemodifier", "0.25"
              "nochasecategory", "MOBILE"
              "usepiececollisionvolumes", "1.0"
          ] }

    let cortron : UnitDef =
        { name = "cortron"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 1200.0
          energyCost = ValueOrExpr.Concrete 14000.0
          buildTime = ValueOrExpr.Concrete 59000.0
          health = ValueOrExpr.Concrete 3550.0
          sightDistance = ValueOrExpr.Concrete 455.0
          footprintX = 4.0
          footprintZ = 4.0
          objectName = Some "Units/CORTRON.s3o"
          buildPic = Some "CORTRON.DDS"
          script = Some "Units/CORTRON.cob"
          corpse = Some "DEAD"
          explodeAs = Some "nukeBuilding"
          selfDestructAs = Some "nukeBuildingSelfd"
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "59 47 59"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "cortron_weapon"
                displayName = Some "Long range tactical g2g nuclear warheads"
                weaponType = Some "StarburstLauncher"
                damage = Map.ofList [
                    "commanders", 750.0
                    "default", 4000.0
                ]
                range = Some (ValueOrExpr.Concrete 2250.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 1200.0
                areaOfEffect = Some 380.0
                accuracy = None
                turret = None
                tolerance = Some 4000.0
                edgeEffectiveness = Some 0.55
                impulseFactor = Some 1.1
                noSelfDamage = Some true
                soundStart = Some "mismed1"
                soundHit = Some "xplomed4"
                explosiongenerator = Some "custom:newnuketac"
                rgbColor = None
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.ofList [
                    "water_splash_ceg", "splash-gigantic"
                ]
                extras = Map.ofList [
                    "mount_badtargetcategory", "NOTLAND"
                    "mount_onlytargetcategory", "NOTSUB"
                    "avoidfeature", "false"
                    "avoidfriendly", "false"
                    "cegtag", "cruisemissiletrail-tacnuke"
                    "collideenemy", "false"
                    "collidefeature", "false"
                    "collidefriendly", "false"
                    "commandfire", "true"
                    "craterareaofeffect", "512.0"
                    "craterboost", "1.6"
                    "cratermult", "0.7"
                    "energypershot", "17437.0"
                    "firestarter", "0.0"
                    "flighttime", "400.0"
                    "interceptedbyshieldtype", "0.0"
                    "metalpershot", "550.0"
                    "model", "cortronmissile.s3o"
                    "smokecolor", "0.7"
                    "smokeperiod", "9.0"
                    "smokesize", "14.0"
                    "smoketime", "60.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "stockpile", "true"
                    "stockpiletime", "75.0"
                    "texture1", "null"
                    "texture2", "smoketrailbar"
                    "texture3", "null"
                    "turnrate", "10000.0"
                    "weaponacceleration", "150.0"
                    "weapontimer", "3.0"
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
                collisionVolumeOffsets = Some "-3.71137237549 -0.216808312988 -0.0546798706055"
                collisionVolumeScales = Some "54.9480133057 48.063583374 52.6346282959"
                collisionVolumeType = Some "Box"
                damage = Some 1920.0
                featureDead = Some "HEAP"
                footprintX = Some 3.0
                footprintZ = Some 3.0
                height = Some 20.0
                metal = Some 445.0
                object_ = Some "Units/cortron_dead.s3o"
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
              "buildinggrounddecalsizex", "7.5"
              "buildinggrounddecalsizey", "7.5"
              "buildinggrounddecaltype", "decals/cortron_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "removewait", "true"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "unitgroup", "weapon"
              "restrictions_inclusion", "_notacnukes_"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
          ] }

    let corvipe : UnitDef =
        { name = "corvipe"
          subfolder = "CorBuildings/LandDefenceOffence"
          metalCost = ValueOrExpr.Concrete 730.0
          energyCost = ValueOrExpr.Concrete 14000.0
          buildTime = ValueOrExpr.Concrete 15000.0
          health = ValueOrExpr.Concrete 3000.0
          sightDistance = ValueOrExpr.Concrete 546.0
          footprintX = 3.0
          footprintZ = 3.0
          objectName = Some "Units/CORVIPE.s3o"
          buildPic = Some "CORVIPE.DDS"
          script = Some "Units/CORVIPE.cob"
          corpse = Some "DEAD"
          explodeAs = Some "smallBuildingexplosiongeneric"
          selfDestructAs = Some "smallBuildingExplosionGenericSelfd"
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = Some [
              { name = "vipersabot"
                displayName = Some "Heavy g2g sabot rocket launcher"
                weaponType = Some "MissileLauncher"
                damage = Map.ofList [
                    "default", 825.0
                    "hvyboats", 577.5
                    "subs", 5.0
                    "vtol", 26.0
                ]
                range = Some (ValueOrExpr.Concrete 730.0)
                reloadTime = Some (ValueOrExpr.Concrete 2.0)
                weaponVelocity = Some 950.0
                areaOfEffect = Some 24.0
                accuracy = None
                turret = Some true
                tolerance = Some 8000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.123
                noSelfDamage = Some true
                soundStart = Some "SabotFire"
                soundHit = Some "SabotHit"
                explosiongenerator = Some "custom:genericshellexplosion-medium-bomb"
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
                    "cegtag", "missiletrailviper"
                    "craterareaofeffect", "0.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "firestarter", "70.0"
                    "flighttime", "1.05"
                    "model", "cormissile3fast.s3o"
                    "smokecolor", "0.8"
                    "smokeperiod", "10.0"
                    "smokesize", "10.0"
                    "smoketime", "33.0"
                    "smoketrail", "true"
                    "smoketrailcastshadow", "false"
                    "soundhitwet", "splshbig"
                    "startvelocity", "570.0"
                    "targetmoveerror", "0.2"
                    "texture1", "null"
                    "texture2", "railguntrail"
                    "tracks", "true"
                    "turnrate", "6000.0"
                    "weaponacceleration", "400.0"
                    "weapontimer", "0.1"
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
                collisionVolumeOffsets = Some "-2.7282333374 -4.31274414048e-05 -3.87004852295"
                collisionVolumeScales = Some "42.4275054932 38.4097137451 38.8498077393"
                collisionVolumeType = Some "Box"
                damage = Some 1631.0
                featureDead = Some "HEAP"
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 20.0
                metal = Some 380.0
                object_ = Some "Units/corvipe_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 408.0
                featureDead = None
                footprintX = Some 2.0
                footprintZ = Some 2.0
                height = Some 4.0
                metal = Some 61.0
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
              ok = ["servmed1"]
              select = ["servmed1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "4.7"
              "buildinggrounddecalsizey", "4.7"
              "buildinggrounddecaltype", "decals/corvipe_aoplane.dds"
              "model_author", "Mr Bob"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "CorBuildings/LandDefenceOffence"
              "techlevel", "2.0"
              "unitgroup", "weapon"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "damagemodifier", "0.5"
              "nochasecategory", "MOBILE"
              "usepiececollisionvolumes", "1.0"
          ] }

    let all : (string * UnitDef) list =
        [
            "corbhmth", corbhmth
            "corbuzz", corbuzz
            "cordoom", cordoom
            "corerad", corerad
            "corexp", corexp
            "corflak", corflak
            "corfmd", corfmd
            "corhllt", corhllt
            "corhlt", corhlt
            "corint", corint
            "corjuno", corjuno
            "corllt", corllt
            "cormadsam", cormadsam
            "cormaw", cormaw
            "cormexp", cormexp
            "corpun", corpun
            "corrl", corrl
            "corscreamer", corscreamer
            "corsilo", corsilo
            "cortoast", cortoast
            "cortron", cortron
            "corvipe", corvipe
        ]
