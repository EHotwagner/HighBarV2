// Auto-generated BAR unit data: Scavengers/Buildings/Utility
namespace BarData.Units

open BarData

module Scavengers_Buildings_Utility =

    let armgatet3 : UnitDef =
        { name = "armgatet3"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 12000.0
          energyCost = ValueOrExpr.Concrete 216000.0
          buildTime = ValueOrExpr.Concrete 220000.0
          health = ValueOrExpr.Concrete 10250.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 5.0
          footprintZ = 6.0
          objectName = Some "Units/ARMGATET3.s3o"
          buildPic = Some "ARMGATET3.DDS"
          script = Some "Units/ARMGATET3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "fusionExplosion"
          selfDestructAs = Some "fusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 0 3"
          collisionVolumeScales = Some "91 85 91"
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
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 0 3"
                collisionVolumeScales = Some "91 67 91"
                collisionVolumeType = Some "CylY"
                damage = Some 7500.0
                featureDead = Some "HEAP"
                footprintX = Some 5.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 7500.0
                object_ = Some "Units/armgatet3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 3750.0
                featureDead = None
                footprintX = Some 4.0
                footprintZ = Some 4.0
                height = Some 4.0
                metal = Some 3200.0
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
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecaltype", "decals/armgate_aoplane.dds"
              "model_author", "Beherith/Protar"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "shield_color_mult", "25.0"
              "shield_power", "24700.0"
              "shield_radius", "710.0"
              "subfolder", "ArmBuildings/LandUtil"
              "techlevel", "3.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "2048.0"
              "onoffable", "true"
              "canattack", "false"
              "exemptcategory", "WEAPON"
              "noautofire", "true"
          ] }

    let corgatet3 : UnitDef =
        { name = "corgatet3"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 16000.0
          energyCost = ValueOrExpr.Concrete 275000.0
          buildTime = ValueOrExpr.Concrete 275000.0
          health = ValueOrExpr.Concrete 12500.0
          sightDistance = ValueOrExpr.Concrete 350.0
          footprintX = 6.0
          footprintZ = 6.0
          objectName = Some "Units/CORGATET3.s3o"
          buildPic = Some "CORGATET3.DDS"
          script = Some "Units/CORGATET3.cob"
          corpse = Some "DEAD"
          explodeAs = Some "customfusionexplo"
          selfDestructAs = Some "advancedFusionExplosionSelfd"
          collisionVolumeOffsets = Some "0 -4 0"
          collisionVolumeScales = Some "96 143 96"
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
                range = Some (ValueOrExpr.Concrete 825.0)
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
              energyStorage = Some 5000.0
              metalStorage = None
              extractsMetal = None })
          building = None
          featureDefs = Some (Map.ofList [
              "dead",
              { blocking = Some true
                category = Some "corpses"
                collisionVolumeOffsets = Some "0 -4 0"
                collisionVolumeScales = Some "96 115 96"
                collisionVolumeType = Some "CylY"
                damage = Some 8500.0
                featureDead = Some "HEAP"
                footprintX = Some 6.0
                footprintZ = Some 6.0
                height = Some 20.0
                metal = Some 10000.0
                object_ = Some "Units/corgatet3_dead.s3o"
                reclaimable = Some true
                resurrectable = None }
              "heap",
              { blocking = Some false
                category = Some "heaps"
                collisionVolumeOffsets = None
                collisionVolumeScales = Some "35.0 4.0 6.0"
                collisionVolumeType = Some "cylY"
                damage = Some 4250.0
                featureDead = None
                footprintX = Some 5.0
                footprintZ = Some 5.0
                height = Some 4.0
                metal = Some 4000.0
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
              ok = ["drone1"]
              select = ["drone1"] })
          customParams = Map.ofList [
              "buildinggrounddecaldecayspeed", "30.0"
              "buildinggrounddecalsizex", "9.0"
              "buildinggrounddecalsizey", "9.0"
              "buildinggrounddecaltype", "decals/corgate_aoplane.dds"
              "model_author", "Mr Bob/Protar"
              "normaltex", "unittextures/cor_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "shield_color_mult", "25.0"
              "shield_power", "66500.0"
              "shield_radius", "825.0"
              "subfolder", "CorBuildings/LandUtil"
              "techlevel", "3.0"
              "unitgroup", "util"
              "usebuildinggrounddecal", "true"
          ]
          extras = Map.ofList [
              "buildangle", "4096.0"
              "onoffable", "true"
              "canattack", "false"
              "exemptcategory", "WEAPON"
              "noautofire", "true"
          ] }

    let scavbeacon_t1 : UnitDef =
        { name = "scavbeacon_t1"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 500.0
          energyCost = ValueOrExpr.Concrete 5000.0
          buildTime = ValueOrExpr.Concrete 5000.0
          health = ValueOrExpr.Concrete 5000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/scavbeacon_t1.s3o"
          buildPic = Some "scavengers/SCAVBEACON.DDS"
          script = Some "scavs/scavbeacon.cob"
          corpse = None
          explodeAs = Some "advmetalmaker"
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "32 32 32"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 4.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Armageddon Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 83.25
                    "default", 250.0
                    "vtol", 250.0
                ]
                range = Some (ValueOrExpr.Concrete 450.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.75)
                weaponVelocity = Some 1800.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "Lasrmas2"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.8 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "beamtime", "1.0"
                    "cameraShake", "350.0"
                    "corethickness", "0.4"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "1200.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.8"
                    "rgbcolor2", "0.8 0 0"
                    "scrollspeed", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "2.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 200.0)
              metalMake = Some (ValueOrExpr.Concrete 2.0)
              energyStorage = Some 20000.0
              metalStorage = Some 2000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some ""
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "Scavengers"
              "normaltex", "unittextures/cor_normal.dds"
              "paratrooper", "true"
          ]
          extras = Map.ofList [
              "autoheal", "10.0"
              "blocking", "false"
              "canSelfDestruct", "false"
              "capturable", "true"
              "cantbetransported", "true"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000.0"
              "noautofire", "false"
              "selfdestructcountdown", "1.0"
              "smoothanim", "true"
              "transportByEnemy", "true"
              "unitname", "scavengerbeacon"
              "upright", "false"
              "reclaimable", "true"
          ] }

    let scavbeacon_t2 : UnitDef =
        { name = "scavbeacon_t2"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 2500.0
          energyCost = ValueOrExpr.Concrete 25000.0
          buildTime = ValueOrExpr.Concrete 25000.0
          health = ValueOrExpr.Concrete 25000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/scavbeacon_t2.s3o"
          buildPic = Some "scavengers/SCAVBEACON.DDS"
          script = Some "scavs/scavbeacon.cob"
          corpse = None
          explodeAs = Some "advmetalmaker"
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "48 48 48"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 4.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Armageddon Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 250.0
                    "default", 750.0
                ]
                range = Some (ValueOrExpr.Concrete 600.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.75)
                weaponVelocity = Some 1800.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "lasrhvy3"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.8 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "beamtime", "1.0"
                    "cameraShake", "350.0"
                    "corethickness", "0.4"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "1200.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.8"
                    "rgbcolor2", "0.8 0 0"
                    "scrollspeed", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "4.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 400.0)
              metalMake = Some (ValueOrExpr.Concrete 4.0)
              energyStorage = Some 60000.0
              metalStorage = Some 6000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some ""
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "Scavengers"
              "normaltex", "unittextures/cor_normal.dds"
              "paratrooper", "true"
          ]
          extras = Map.ofList [
              "autoheal", "10.0"
              "blocking", "false"
              "canSelfDestruct", "false"
              "capturable", "true"
              "cantbetransported", "true"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000.0"
              "noautofire", "false"
              "selfdestructcountdown", "1.0"
              "smoothanim", "true"
              "transportByEnemy", "true"
              "unitname", "scavengerbeacon"
              "upright", "false"
              "reclaimable", "true"
          ] }

    let scavbeacon_t3 : UnitDef =
        { name = "scavbeacon_t3"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 5000.0
          energyCost = ValueOrExpr.Concrete 50000.0
          buildTime = ValueOrExpr.Concrete 50000.0
          health = ValueOrExpr.Concrete 50000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/scavbeacon_t3.s3o"
          buildPic = Some "scavengers/SCAVBEACON.DDS"
          script = Some "scavs/scavbeacon.cob"
          corpse = None
          explodeAs = Some "commanderExplosion"
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "64 64 64"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 4.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Armageddon Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 750.0
                    "default", 2500.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.75)
                weaponVelocity = Some 1800.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray2xl"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.8 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "beamtime", "1.0"
                    "cameraShake", "350.0"
                    "corethickness", "0.4"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "1200.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.8"
                    "rgbcolor2", "0.8 0 0"
                    "scrollspeed", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "6.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 800.0)
              metalMake = Some (ValueOrExpr.Concrete 8.0)
              energyStorage = Some 100000.0
              metalStorage = Some 10000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some ""
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "Scavengers"
              "normaltex", "unittextures/cor_normal.dds"
              "paratrooper", "true"
          ]
          extras = Map.ofList [
              "autoheal", "10.0"
              "blocking", "false"
              "canSelfDestruct", "false"
              "capturable", "true"
              "cantbetransported", "true"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000.0"
              "noautofire", "false"
              "selfdestructcountdown", "1.0"
              "smoothanim", "true"
              "transportByEnemy", "true"
              "unitname", "scavengerbeacon"
              "upright", "false"
              "reclaimable", "true"
          ] }

    let scavbeacon_t4 : UnitDef =
        { name = "scavbeacon_t4"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 100000.0
          health = ValueOrExpr.Concrete 100000.0
          sightDistance = ValueOrExpr.Concrete 750.0
          footprintX = 0.0
          footprintZ = 0.0
          objectName = Some "scavs/scavbeacon_t4.s3o"
          buildPic = Some "scavengers/SCAVBEACON.DDS"
          script = Some "scavs/scavbeacon.cob"
          corpse = None
          explodeAs = Some "commanderExplosion"
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "85 85 85"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 4.0
          category = Some "CANBEUW"
          movement = None
          builder = None
          weapons = Some [
              { name = "weapon"
                displayName = Some "Armageddon Heat Ray"
                weaponType = Some "BeamLaser"
                damage = Map.ofList [
                    "commanders", 4125.0
                    "default", 12500.0
                ]
                range = Some (ValueOrExpr.Concrete 750.0)
                reloadTime = Some (ValueOrExpr.Concrete 3.75)
                weaponVelocity = Some 1800.0
                areaOfEffect = Some 72.0
                accuracy = None
                turret = Some true
                tolerance = Some 10000.0
                edgeEffectiveness = Some 0.15
                impulseFactor = Some 0.0
                noSelfDamage = Some true
                soundStart = Some "heatray2xl"
                soundHit = None
                explosiongenerator = Some "custom:genericshellexplosion-medium-beam"
                rgbColor = Some "1 0.8 0"
                onlyTargetCategory = None
                badTargetCategory = None
                customParams = Map.empty
                extras = Map.ofList [
                    "avoidfeature", "false"
                    "beamtime", "1.0"
                    "cameraShake", "350.0"
                    "corethickness", "0.4"
                    "craterareaofeffect", "72.0"
                    "craterboost", "0.0"
                    "cratermult", "0.0"
                    "energypershot", "1200.0"
                    "largebeamlaser", "true"
                    "laserflaresize", "8.8"
                    "rgbcolor2", "0.8 0 0"
                    "scrollspeed", "5.0"
                    "soundhitdry", ""
                    "soundhitwet", "sizzle"
                    "soundtrigger", "1.0"
                    "thickness", "8.0"
                ] }
          ]
          economy = Some (
            { energyMake = Some (ValueOrExpr.Concrete 1600.0)
              metalMake = Some (ValueOrExpr.Concrete 16.0)
              energyStorage = Some 200000.0
              metalStorage = Some 20000.0
              extractsMetal = None })
          building = Some (
            { yardMap = Some ""
              activateWhenBuilt = Some true
              canRepeat = None })
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "subfolder", "Scavengers"
              "normaltex", "unittextures/cor_normal.dds"
              "paratrooper", "true"
          ]
          extras = Map.ofList [
              "autoheal", "10.0"
              "blocking", "false"
              "canSelfDestruct", "false"
              "capturable", "true"
              "cantbetransported", "true"
              "hidedamage", "true"
              "levelground", "false"
              "mass", "10000.0"
              "noautofire", "false"
              "selfdestructcountdown", "1.0"
              "smoothanim", "true"
              "transportByEnemy", "true"
              "unitname", "scavengerbeacon"
              "upright", "false"
              "reclaimable", "true"
          ] }

    let scavsafeareabeacon : UnitDef =
        { name = "scavsafeareabeacon"
          subfolder = "Scavengers/Buildings/Utility"
          metalCost = ValueOrExpr.Concrete 10000.0
          energyCost = ValueOrExpr.Concrete 100000.0
          buildTime = ValueOrExpr.Concrete 100000.0
          health = ValueOrExpr.Concrete 2800.0
          sightDistance = ValueOrExpr.Concrete 1560.0
          footprintX = 5.0
          footprintZ = 5.0
          objectName = Some "scavs/scavsafeareabeacon.s3o"
          buildPic = Some "scavengers/scavsafeareabeacon.DDS"
          script = Some "Units/ARMEYES.cob"
          corpse = None
          explodeAs = Some "scavcomexplosion"
          selfDestructAs = None
          collisionVolumeOffsets = None
          collisionVolumeScales = None
          collisionVolumeType = None
          seismicSignature = Some 0.0
          category = None
          movement = None
          builder = None
          weapons = None
          economy = None
          building = Some (
            { yardMap = Some ""
              activateWhenBuilt = Some true
              canRepeat = Some false })
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
              ok = ["servsml6"]
              select = ["minesel1"] })
          customParams = Map.ofList [
              "model_author", "Beherith"
              "normaltex", "unittextures/Arm_normal.dds"
              "removestop", "true"
              "removewait", "true"
              "subfolder", "ArmBuildings/LandUtil"
          ]
          extras = Map.ofList [
              "buildangle", "8192.0"
              "blocking", "false"
              "cloakcost", "10.0"
              "initcloaked", "true"
              "levelground", "false"
              "mincloakdistance", "250.0"
              "stealth", "true"
              "reclaimable", "false"
          ] }

    let all : (string * UnitDef) list =
        [
            "armgatet3", armgatet3
            "corgatet3", corgatet3
            "scavbeacon_t1", scavbeacon_t1
            "scavbeacon_t2", scavbeacon_t2
            "scavbeacon_t3", scavbeacon_t3
            "scavbeacon_t4", scavbeacon_t4
            "scavsafeareabeacon", scavsafeareabeacon
        ]
