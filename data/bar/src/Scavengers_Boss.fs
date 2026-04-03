// Auto-generated BAR unit data: Scavengers/Boss
namespace BarData.Units

open BarData

module Scavengers_Boss =

    let armcomboss =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 2000.0
            LuaKey.String "maxdec", LuaValue.Number 0.6
            LuaKey.String "energycost", LuaValue.Number 10000000.0
            LuaKey.String "metalcost", LuaValue.Number 10000000.0
            LuaKey.String "builddistance", LuaValue.Number 750.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "scavengers/ARMCOMBOSS.DDS"
            LuaKey.String "buildtime", LuaValue.Number 750000000000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canresurrect", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 6000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 7 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "75 160 75"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 250.0
            LuaKey.String "explodeas", LuaValue.String "ScavComBossExplo"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "sightemitheight", LuaValue.Number 100.0
            LuaKey.String "mass", LuaValue.Number 500000.0
            LuaKey.String "health", LuaValue.Number 2800000.0
            LuaKey.String "maxslope", LuaValue.Number 25.0
            LuaKey.String "speed", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 200.0
            LuaKey.String "metalmake", LuaValue.Number 5.0
            LuaKey.String "movementclass", LuaValue.String "SCAVCOMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/ARMCOMBOSS.s3o"
            LuaKey.String "radardistance", LuaValue.Number 2000.0
            LuaKey.String "radaremitheight", LuaValue.Number 100.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/ARMCOMBOSS.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "ScavComBossExplo"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool false
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "sonardistance", LuaValue.Number 1000.0
            LuaKey.String "terraformspeed", LuaValue.Number 10000.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 500.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 2000.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armbanth"
                    LuaKey.Int 2, LuaValue.String "corkorg"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "buildert4"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.01
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "techlevel", LuaValue.Number 4.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "110 28 110"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 55.0
                            LuaKey.String "metal", LuaValue.Number 2500.0
                            LuaKey.String "object", LuaValue.String "Units/scavboss/armcomboss_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "kcarmmov"
                    LuaKey.String "working", LuaValue.String "reclaim1"
                    LuaKey.String "cant", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "cantdo4"
                        ]
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "ok", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kcarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kcarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armcomlaserboss", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 25.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "corethickness", LuaValue.Number 0.22
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-large-red"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.0
                            LuaKey.String "name", LuaValue.String "J8Laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.3 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "xplomas2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 12.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1000.0
                                    LuaKey.String "vtol", LuaValue.Number 4000.0
                                ]
                        ]
                    LuaKey.String "armcomsealaserboss", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 35.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "corethickness", LuaValue.Number 0.22
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-large-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 5.0
                            LuaKey.String "name", LuaValue.String "J8NSLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.3 0.4"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "xplomas2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 12.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1000.0
                                    LuaKey.String "vtol", LuaValue.Number 4000.0
                                ]
                        ]
                    LuaKey.String "disintegratorxl", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 65.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cameraShake", LuaValue.Number 500.0
                            LuaKey.String "cegtag", LuaValue.String "gausscannonprojectilexl"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnblackbiggest"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "gravityaffected", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 4.0
                            LuaKey.String "name", LuaValue.String "Darkmatter Photon-Disruptor"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.3 1.0"
                            LuaKey.String "size", LuaValue.Number 8.5
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool false
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 375.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 999999.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMCOMLASERBOSS"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASERBOSS"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATORXL"
                        ]
                ]
        ]

    let corcomboss =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.6
            LuaKey.String "energycost", LuaValue.Number 3000000.0
            LuaKey.String "metalcost", LuaValue.Number 300000.0
            LuaKey.String "builddistance", LuaValue.Number 750.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "scavengers/CORCOMBOSS.DDS"
            LuaKey.String "buildtime", LuaValue.Number 300000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canresurrect", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 6000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 7 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "75 160 75"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 250.0
            LuaKey.String "explodeas", LuaValue.String "ScavComBossExplo"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "sightemitheight", LuaValue.Number 100.0
            LuaKey.String "mass", LuaValue.Number 500000.0
            LuaKey.String "health", LuaValue.Number 300000.0
            LuaKey.String "maxslope", LuaValue.Number 25.0
            LuaKey.String "speed", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 200.0
            LuaKey.String "metalmake", LuaValue.Number 5.0
            LuaKey.String "movementclass", LuaValue.String "SCAVCOMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/CORCOMBOSS.s3o"
            LuaKey.String "radardistance", LuaValue.Number 2000.0
            LuaKey.String "radaremitheight", LuaValue.Number 100.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/CORCOMBOSS.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "ScavComBossExplo"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool false
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "sonardistance", LuaValue.Number 1000.0
            LuaKey.String "terraformspeed", LuaValue.Number 10000.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 500.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 500.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armbanth"
                    LuaKey.Int 2, LuaValue.String "corkorg"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "buildert4"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.01
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "techlevel", LuaValue.Number 4.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85 33 100"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 55.0
                            LuaKey.String "metal", LuaValue.Number 150000.0
                            LuaKey.String "object", LuaValue.String "Units/scavboss/corcomboss_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 75000.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "repair", LuaValue.String "repair2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "kccorsel"
                    LuaKey.String "working", LuaValue.String "reclaim1"
                    LuaKey.String "cant", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "cantdo4"
                        ]
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "ok", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kcormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kccorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corcomlaserboss", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 35.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "corethickness", LuaValue.Number 0.22
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-large-red"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.0
                            LuaKey.String "name", LuaValue.String "J8Laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.3 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "xplomas2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 12.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                ]
                        ]
                    LuaKey.String "corcomsealaserboss", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 25.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "corethickness", LuaValue.Number 0.22
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-large-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 5.0
                            LuaKey.String "name", LuaValue.String "J8NSLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.3 1"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.7 0.3 0.4"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "xplomas2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 12.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                ]
                        ]
                    LuaKey.String "disintegratorxl", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 65.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cameraShake", LuaValue.Number 500.0
                            LuaKey.String "cegtag", LuaValue.String "gausscannonprojectilexl"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnblackbiggest"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "gravityaffected", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 4.0
                            LuaKey.String "name", LuaValue.String "Darkmatter Photon-Disruptor"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.3 1.0"
                            LuaKey.String "size", LuaValue.Number 8.5
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool false
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 375.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 999999.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMLASERBOSS"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMSEALASERBOSS"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATORXL"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "armcomboss", armcomboss
            "corcomboss", corcomboss
        ]
