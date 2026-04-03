// Auto-generated BAR unit data: Scavengers/Bots
namespace BarData.Units

open BarData

module Scavengers_Bots =

    let armassimilator =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.2369
            LuaKey.String "maxdec", LuaValue.Number 0.9039
            LuaKey.String "energycost", LuaValue.Number 25000.0
            LuaKey.String "metalcost", LuaValue.Number 2500.0
            LuaKey.String "buildpic", LuaValue.String "ARMASSIMILATOR.DDS"
            LuaKey.String "buildtime", LuaValue.Number 25000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -2.0 -5"
            LuaKey.String "collisionvolumescales", LuaValue.String "50.0 60.0 50.0"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "explosiont3"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "mass", LuaValue.Number 200000.0
            LuaKey.String "health", LuaValue.Number 7500.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "speed", LuaValue.Number 60.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 22.0
            LuaKey.String "movementclass", LuaValue.String "EPICBOT"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/armassimilator.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/armassimilator.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3xl"
            LuaKey.String "sightdistance", LuaValue.Number 800.0
            LuaKey.String "strafetoattack", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.518
            LuaKey.String "turnrate", LuaValue.Number 768.20001
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "PtaQ"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "weapon1turretx", LuaValue.Number 200.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 200.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-1.43661499023 -1.36986116943 12.126411438"
                            LuaKey.String "collisionvolumescales", LuaValue.String "61.6002807617 54.8114776611 71.5794219971"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2325.0
                            LuaKey.String "object", LuaValue.String "Units/scavboss/armassimilator_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 2000.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 930.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
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
                            LuaKey.Int 1, LuaValue.String "mavbok1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "mavbsel1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "machinegun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 50.0
                            LuaKey.String "areaofeffect", LuaValue.Number 25.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool true
                            LuaKey.String "beamtime", LuaValue.Number 0.09
                            LuaKey.String "corethickness", LuaValue.Number 0.45
                            LuaKey.String "duration", LuaValue.Number 0.09
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "falloffrate", LuaValue.Number 0.0
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "minintensity", LuaValue.String "1"
                            LuaKey.String "name", LuaValue.String "scav rapid fire plasma gun"
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "1 1 1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "soundstart", LuaValue.String "tgunshipfire"
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 7.5
                            LuaKey.String "tolerance", LuaValue.Number 1000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "customparams", LuaValue.Table []
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 33.0
                                    LuaKey.String "vtol", LuaValue.Number 100.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "machinegun"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armlunchbox =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.02645
            LuaKey.String "maxdec", LuaValue.Number 0.345
            LuaKey.String "energycost", LuaValue.Number 71000.0
            LuaKey.String "metalcost", LuaValue.Number 3300.0
            LuaKey.String "buildpic", LuaValue.String "ARMLUNCHBOX.DDS"
            LuaKey.String "buildtime", LuaValue.Number 71000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "65 60 65"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "explosiont3"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "hightrajectory", LuaValue.Number 2.0
            LuaKey.String "mass", LuaValue.Number 200000.0
            LuaKey.String "health", LuaValue.Number 10000.0
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "speed", LuaValue.Number 33.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "EPICBOT"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/armlunchbox.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/armlunchbox.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3xl"
            LuaKey.String "sightdistance", LuaValue.Number 625.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.726
            LuaKey.String "turnrate", LuaValue.Number 265.64999
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Flaka"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-3.37104034424 -1.05229058838 1.8899307251"
                            LuaKey.String "collisionvolumescales", LuaValue.String "64.0154266357 41.4324188232 55.433883667"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 3000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2028.0
                            LuaKey.String "object", LuaValue.String "Units/scavboss/armlunchbox_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 3015.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 811.0
                            LuaKey.String "object", LuaValue.String "Units/arm4X4D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-huge"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "shocker", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 192.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "arty-huge"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 192.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge"
                            LuaKey.String "firetolerance", LuaValue.Number 5000.0
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 2.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Heavy long-range g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.25
                            LuaKey.String "range", LuaValue.Number 1325.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 1100.0
                                    LuaKey.String "default", LuaValue.Number 1265.0
                                    LuaKey.String "shields", LuaValue.Number 765.0
                                    LuaKey.String "subs", LuaValue.Number 400.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "SHOCKER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let armmeatball =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.253
            LuaKey.String "maxdec", LuaValue.Number 0.8211
            LuaKey.String "energycost", LuaValue.Number 30000.0
            LuaKey.String "metalcost", LuaValue.Number 3000.0
            LuaKey.String "buildpic", LuaValue.String "ARMMEATBALL.DDS"
            LuaKey.String "buildtime", LuaValue.Number 30000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -2 -1"
            LuaKey.String "collisionvolumescales", LuaValue.String "34 68 38"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "explosiont3med"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "mass", LuaValue.Number 200000.0
            LuaKey.String "health", LuaValue.Number 8000.0
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 32.0
            LuaKey.String "movementclass", LuaValue.String "EPICBOT"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/ARMMEATBALL.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/armmeatball.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3"
            LuaKey.String "sightdistance", LuaValue.Number 800.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.98
            LuaKey.String "turnrate", LuaValue.Number 1214.40002
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "PtaQ"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "weapon1turretx", LuaValue.Number 90.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 150.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.882118225098 0.0283161499023 6.0887298584"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32.1447906494 31.2162322998 37.0860900879"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2400.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 592.0
                            LuaKey.String "object", LuaValue.String "Units/scavboss/armmeatball_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 1200.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 237.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-medium"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
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
                            LuaKey.Int 1, LuaValue.String "mavbok1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "mavbsel1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armamph_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 48.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 1.75
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Guided g2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 5.0
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smokesize", LuaValue.Number 4.4
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "rocklit1"
                            LuaKey.String "startvelocity", LuaValue.Number 650.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 48000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 200.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 850.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 85.0
                                ]
                        ]
                    LuaKey.String "armmech_cannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "firestarter", LuaValue.Number 5.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Double close-quarters gauss cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "KroGun1"
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.15
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 235.0
                                    LuaKey.String "vtol", LuaValue.Number 60.0
                                ]
                        ]
                    LuaKey.String "lrpc", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1500.0
                            LuaKey.String "areaofeffect", LuaValue.Number 75.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-large"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 116.0
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 8.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "leadbonus", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "artshell-large.s3o"
                            LuaKey.String "name", LuaValue.String "Long range g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.3
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "KroGun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 38.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 24.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "lrpc"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMAMPH_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let armpwt4 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.414
            LuaKey.String "maxdec", LuaValue.Number 0.69
            LuaKey.String "energycost", LuaValue.Number 150000.0
            LuaKey.String "metalcost", LuaValue.Number 8000.0
            LuaKey.String "buildpic", LuaValue.String "scavengers/armpwt4.DDS"
            LuaKey.String "buildtime", LuaValue.Number 150000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 -5"
            LuaKey.String "collisionvolumescales", LuaValue.String "55 80 55"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "bantha"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "mass", LuaValue.Number 1000000.0
            LuaKey.String "health", LuaValue.Number 16700.0
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "speed", LuaValue.Number 84.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 25.0
            LuaKey.String "movementclass", LuaValue.String "EPICBOT"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/armpwt4.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/armpwt4.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "banthaSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 2.0
            LuaKey.String "turnrate", LuaValue.Number 1200.44
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Kaiser"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "other/scavengers"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "weapon1turretx", LuaValue.Number 300.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 300.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.979118347168 -0.453806965332 -0.796119689941"
                            LuaKey.String "collisionvolumescales", LuaValue.String "60.1392364502 36.4953460693 58.797164917"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 7500.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 4000.0
                            LuaKey.String "object", LuaValue.String "Units/scavboss/armpwt4_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-medium"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
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
                            LuaKey.Int 1, LuaValue.String "servtny2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servtny2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "emg", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-huge"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "intensity", LuaValue.Number 1.4
                            LuaKey.String "name", LuaValue.String "Rapid-fire huge g2g plasma guns"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.16667
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "size", LuaValue.Number 5.1
                            LuaKey.String "soundhit", LuaValue.String "flashemgxlhit2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "flashemgxl"
                            LuaKey.String "sprayangle", LuaValue.Number 200.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.5
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 50.0
                                    LuaKey.String "default", LuaValue.Number 200.0
                                    LuaKey.String "shields", LuaValue.Number 87.0
                                    LuaKey.String "vtol", LuaValue.Number 50.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "EMG"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armsptkt4 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.207
            LuaKey.String "maxdec", LuaValue.Number 0.6486
            LuaKey.String "energycost", LuaValue.Number 75000.0
            LuaKey.String "metalcost", LuaValue.Number 7500.0
            LuaKey.String "buildpic", LuaValue.String "scavengers/armsptkt4.DDS"
            LuaKey.String "buildtime", LuaValue.Number 75000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "75 50 75"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "empblast"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "mass", LuaValue.Number 5000.0
            LuaKey.String "health", LuaValue.Number 28000.0
            LuaKey.String "speed", LuaValue.Number 36.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "EPICALLTERRAIN"
            LuaKey.String "mygravity", LuaValue.Number 10000.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/armsptkt4.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/armsptkt4.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "empblast"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 350.0
            LuaKey.String "turnrate", LuaValue.Number 650.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.125
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.13973236084 -4.67773437585e-06 -1.37111663818"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47.3038787842 18.2459106445 47.0814971924"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 12500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 3750.0
                            LuaKey.String "object", LuaValue.String "Units/scavboss/armsptkt4_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 6250.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1875.0
                            LuaKey.String "object", LuaValue.String "Units/arm4X4A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
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
                            LuaKey.Int 1, LuaValue.String "spider2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "spider3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "adv_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 100.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "cegtag", LuaValue.String "missiletrailsmall"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "dance", LuaValue.Number 16.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-catapult"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 4.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "catapultmissile.s3o"
                            LuaKey.String "movingaccuracy", LuaValue.Number 450.0
                            LuaKey.String "name", LuaValue.String "Parabolic trajectory g2g multi-rocket launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "smoketrail", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "rockhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "rocksalvo"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 80.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.2
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "trajectoryheight", LuaValue.Number 1.0
                            LuaKey.String "turnrate", LuaValue.Number 2000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 75.0
                            LuaKey.String "weapontimer", LuaValue.Number 7.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "wobble", LuaValue.Number 2000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 500.0
                                    LuaKey.String "subs", LuaValue.Number 200.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "overrange_distance", LuaValue.Number 1150.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ADV_ROCKET"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let corakt4 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.4416
            LuaKey.String "maxdec", LuaValue.Number 0.8625
            LuaKey.String "energycost", LuaValue.Number 120000.0
            LuaKey.String "metalcost", LuaValue.Number 6000.0
            LuaKey.String "buildpic", LuaValue.String "CORAKT4.DDS"
            LuaKey.String "buildtime", LuaValue.Number 120000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -2 -3"
            LuaKey.String "collisionvolumescales", LuaValue.String "49 56 49"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "explosiont3"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "mass", LuaValue.Number 1000000.0
            LuaKey.String "health", LuaValue.Number 11100.0
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "speed", LuaValue.Number 84.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 25.0
            LuaKey.String "movementclass", LuaValue.String "EPICBOT"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/CORAKT4.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/CORAKT4.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3xl"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.848
            LuaKey.String "turnrate", LuaValue.Number 1391.5
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBots"
                    LuaKey.String "weapon1turretx", LuaValue.Number 300.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 300.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.114540100098 -2.64214854004 2.11838531494"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32.2373809814 13.5927429199 29.8415679932"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 15000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 3500.0
                            LuaKey.String "object", LuaValue.String "Units/scavboss/corakt4_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 7500.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1750.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
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
                            LuaKey.Int 1, LuaValue.String "servtny1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servtny1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "gator_laser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 17.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "corethickness", LuaValue.Number 0.315
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.0
                            LuaKey.String "name", LuaValue.String "Laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrlit3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.25
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                    LuaKey.String "vtol", LuaValue.Number 20.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "GATOR_LASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let cordeadeye =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.138
            LuaKey.String "maxdec", LuaValue.Number 0.6486
            LuaKey.String "energycost", LuaValue.Number 27500.0
            LuaKey.String "metalcost", LuaValue.Number 1050.0
            LuaKey.String "buildpic", LuaValue.String "cordeadeye.DDS"
            LuaKey.String "buildtime", LuaValue.Number 32000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 -2"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 34 30"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "penetrator"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 2700.0
            LuaKey.String "maxslope", LuaValue.Number 16.0
            LuaKey.String "speed", LuaValue.Number 40.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 22.0
            LuaKey.String "movementclass", LuaValue.String "HBOT4"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/cordeadeye.s3o"
            LuaKey.String "script", LuaValue.String "scavs/cordeadeye.COB"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "deadeyeSelfd"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 3.0
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.65
            LuaKey.String "turnrate", LuaValue.Number 400.0
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Kaludjo"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBots/t2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.220962524414 -3.57609763184 -0.162803649902"
                            LuaKey.String "collisionvolumescales", LuaValue.String "39.2589111328 21.1636047363 24.3341522217"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1800.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 339.0
                            LuaKey.String "object", LuaValue.String "Units/cordeadeye_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 1250.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 136.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-greenblaster"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
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
                            LuaKey.Int 1, LuaValue.String "kbcormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbcorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "cor_burst_laser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 20.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collideenemy", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.5
                            LuaKey.String "corethickness", LuaValue.Number 1.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "energypershot", LuaValue.Number 800.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-large-aqua"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "impactonly", LuaValue.Number 0.0
                            LuaKey.String "impulseboost", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 2.2
                            LuaKey.String "name", LuaValue.String "HeavyBlaster"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 850.0
                            LuaKey.String "reloadtime", LuaValue.Number 12.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.0 0.5 0.8"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.8 1.0"
                            LuaKey.String "soundhitdry", LuaValue.String "xplosml5"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir5"
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1821.0
                            LuaKey.String "duration", LuaValue.Number 0.05
                            LuaKey.String "sprayAngle", LuaValue.Number 0.1
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 834.0
                                    LuaKey.String "commanders", LuaValue.Number 342.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "COR_BURST_LASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                        ]
                ]
        ]

    let corkark =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0828
            LuaKey.String "maxdec", LuaValue.Number 0.8211
            LuaKey.String "energycost", LuaValue.Number 2400.0
            LuaKey.String "metalcost", LuaValue.Number 280.0
            LuaKey.String "buildpic", LuaValue.String "corkark.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 1"
            LuaKey.String "collisionvolumescales", LuaValue.String "29 35 29"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.5
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 1280.0
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "speed", LuaValue.Number 42.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "BOT2"
            LuaKey.String "name", LuaValue.String "Karkinos"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/corkark.s3o"
            LuaKey.String "script", LuaValue.String "Units/corkark.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 400.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.99
            LuaKey.String "turnrate", LuaValue.Number 885.5
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Firestorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Scavengers/Bots"
                    LuaKey.String "weapon1turretx", LuaValue.Number 200.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 200.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-0.527076721191 -15.09926749023 6.06378173828"
                            LuaKey.String "collisionvolumescales", LuaValue.String "37.3442840576 10.0486450195 42.9995422363"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 880.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 161.0
                            LuaKey.String "object", LuaValue.String "Units/corkark_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 490.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 64.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corwar_laser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.2
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 6.0
                            LuaKey.String "leadlimit", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Light g2g Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 360.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.55 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 1.0 0.5"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 1.6625
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 160.0
                                    LuaKey.String "vtol", LuaValue.Number 25.0
                                ]
                        ]
                    LuaKey.String "corlevlr_weapon", LuaValue.Table [
                            LuaKey.String "alphadecay", LuaValue.Number 0.1
                            LuaKey.String "areaofeffect", LuaValue.Number 144.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.9
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "impulsefactor", LuaValue.Number 3.0
                            LuaKey.String "name", LuaValue.String "RiotCannon"
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 220.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "separation", LuaValue.Number 2.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.08
                            LuaKey.String "soundhit", LuaValue.String "corlevlrhit"
                            LuaKey.String "soundhitvolume", LuaValue.Number 11.5
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "corlevlr"
                            LuaKey.String "soundstartvolume", LuaValue.Number 13.0
                            LuaKey.String "stages", LuaValue.Number 12.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 550.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 190.0
                                    LuaKey.String "subs", LuaValue.Number 70.0
                                    LuaKey.String "vtol", LuaValue.Number 27.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORWAR_LASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORLEVLR_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let cormandot4 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.4025
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 9.0
            LuaKey.String "maxdec", LuaValue.Number 1.725
            LuaKey.String "energycost", LuaValue.Number 90000.0
            LuaKey.String "metalcost", LuaValue.Number 6700.0
            LuaKey.String "builddistance", LuaValue.Number 200.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORMANDO.DDS"
            LuaKey.String "buildtime", LuaValue.Number 17100.0
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "canassist", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool true
            LuaKey.String "canrepair", LuaValue.Bool true
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "38 50 22"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "energymake", LuaValue.Number 50.0
            LuaKey.String "energystorage", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 9600.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 60.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "ABOT3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "scavs/cormandot4.s3o"
            LuaKey.String "radardistance", LuaValue.Number 900.0
            LuaKey.String "radardistancejam", LuaValue.Number 200.0
            LuaKey.String "script", LuaValue.String "Scavs/CORMANDOT4.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.65
            LuaKey.String "turnrate", LuaValue.Number 1168.40002
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 2, LuaValue.String "corape"
                    LuaKey.Int 3, LuaValue.String "cormine3"
                    LuaKey.Int 4, LuaValue.String "cormwall"
                    LuaKey.Int 5, LuaValue.String "corfort"
                    LuaKey.Int 6, LuaValue.String "cortron"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "paratrooper", LuaValue.Bool true
                    LuaKey.String "water_fall_damage_multiplier", LuaValue.Number 0.0
                    LuaKey.String "fall_damage_multiplier", LuaValue.Number 0.0
                    LuaKey.String "nopvebuilder", LuaValue.Bool true
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-small"
                            LuaKey.Int 2, LuaValue.String "custom:radarpulse_t1"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture2"
                    LuaKey.String "repair", LuaValue.String "repair2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
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
                            LuaKey.Int 1, LuaValue.String "kbcormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbcorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "commando_back_cannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "explosionscar", LuaValue.Bool false
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2s"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 200.0
                                    LuaKey.String "default", LuaValue.Number 2400.0
                                ]
                        ]
                    LuaKey.String "commando_stunner", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 75.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Number 0.5
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "beamttl", LuaValue.Number 0.2
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.5
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.01
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-emp"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.0
                            LuaKey.String "name", LuaValue.String "Close-quarters EMP Scattergun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "projectiles", LuaValue.Number 10.0
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.2
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1"
                            LuaKey.String "sprayangle", LuaValue.Number 8000.0
                            LuaKey.String "soundhitdry", LuaValue.String "flashemgxlhit"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasfirerb"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 10.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1200.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 2000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "commando_stunner"
                            LuaKey.String "onlytargetcategory", LuaValue.String "WEAPON"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "WEAPON"
                            LuaKey.String "def", LuaValue.String "commando_back_cannon"
                        ]
                ]
        ]

    let corthermite =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.19665
            LuaKey.String "maxdec", LuaValue.Number 0.60375
            LuaKey.String "energycost", LuaValue.Number 60000.0
            LuaKey.String "metalcost", LuaValue.Number 3500.0
            LuaKey.String "buildpic", LuaValue.String "CORTHERMITE.DDS"
            LuaKey.String "buildtime", LuaValue.Number 188000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "80 50 98"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 15000.0
            LuaKey.String "mass", LuaValue.Number 150000.0
            LuaKey.String "maxslope", LuaValue.Number 50.0
            LuaKey.String "speed", LuaValue.Number 42.3
            LuaKey.String "maxwaterdepth", LuaValue.Number 60.0
            LuaKey.String "movementclass", LuaValue.String "HTBOT6"
            LuaKey.String "mygravity", LuaValue.Number 10000.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/CORTHERMITE.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/CORTHERMITE.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 480.0
            LuaKey.String "strafetoattack", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.0626
            LuaKey.String "turnrate", LuaValue.Number 1214.40002
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Beherith, Hornet"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.125
                    LuaKey.String "subfolder", LuaValue.String "CorBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -1.81045331299 4.38243865967"
                            LuaKey.String "collisionvolumescales", LuaValue.String "64.3684997559 30.844833374 66.5386505127"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 10.0
                            LuaKey.String "metal", LuaValue.Number 1523.0
                            LuaKey.String "object", LuaValue.String "Units/scavboss/corthermite_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "metal", LuaValue.Number 909.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:flamestreamthermite"
                            LuaKey.Int 2, LuaValue.String "custom:thermitesmoke"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
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
                            LuaKey.Int 1, LuaValue.String "spider2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "spider"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "thermite_laser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 72.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "beamtime", LuaValue.Number 0.6
                            LuaKey.String "camerashake", LuaValue.Number 0.1
                            LuaKey.String "corethickness", LuaValue.Number 0.35
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 350.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-beam"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.25
                            LuaKey.String "name", LuaValue.String "Thermite Heatray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 900.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.8 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heatray1s"
                            LuaKey.String "soundstartvolume", LuaValue.Number 70.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 6.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 2000.0
                                    LuaKey.String "vtol", LuaValue.Number 550.0
                                ]
                        ]
                    LuaKey.String "tmaw", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 700.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 12.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "bouncerebound", LuaValue.Number 1.0
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "burnflamethermite"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.01
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnthermite"
                            LuaKey.String "bounceSlip", LuaValue.Number 1.0
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "flameGFXTime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.85
                            LuaKey.String "name", LuaValue.String "Thermite heavy medium range AoE flamethrower"
                            LuaKey.String "noexplode", LuaValue.Bool false
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 350.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.39996
                            LuaKey.String "sizegrowth", LuaValue.Number 3.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Flamhvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 700.0
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool false
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 30.0
                                    LuaKey.String "subs", LuaValue.Number 10.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "THERMITE_LASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "TMAW"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let leggobt3 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "maxdec", LuaValue.Number 0.36
            LuaKey.String "energycost", LuaValue.Number 120000.0
            LuaKey.String "metalcost", LuaValue.Number 6000.0
            LuaKey.String "buildpic", LuaValue.String "LEGGOB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 120000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -7 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "63 77 63"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "explosiont3med"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 14000.0
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "speed", LuaValue.Number 60.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 25.0
            LuaKey.String "movementclass", LuaValue.String "HBOT4"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/LEGGOBT3.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/LEGGOBT3.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3med"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.848
            LuaKey.String "turnrate", LuaValue.Number 650.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Odin"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBots"
                    LuaKey.String "weapon1turretx", LuaValue.Number 300.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 300.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.4 -8 7"
                            LuaKey.String "collisionvolumescales", LuaValue.String "96 40 90"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 120.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 18.0
                            LuaKey.String "object", LuaValue.String "Units/scavboss/leggobt3_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 83.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 9.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
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
                            LuaKey.Int 1, LuaValue.String "servtny1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servtny1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "semiauto", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.3
                            LuaKey.String "projectiles", LuaValue.Number 18.0
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.015
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulseboost", LuaValue.Number 0.4
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Medium Shotgun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "kroggie2xs"
                            LuaKey.String "soundstartvolume", LuaValue.Number 3.0
                            LuaKey.String "sprayangle", LuaValue.Number 900.0
                            LuaKey.String "thickness", LuaValue.Number 0.6
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 960.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 40.0
                                    LuaKey.String "vtol", LuaValue.Number 13.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "SEMIAUTO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let legpede =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.03
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 80000.0
            LuaKey.String "metalcost", LuaValue.Number 5500.0
            LuaKey.String "buildpic", LuaValue.String "LEGPEDE.DDS"
            LuaKey.String "buildtime", LuaValue.Number 110000.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 5 -6"
            LuaKey.String "collisionvolumescales", LuaValue.String "26 28 144"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "explosiont3med"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "mass", LuaValue.Number 200000.0
            LuaKey.String "health", LuaValue.Number 28000.0
            LuaKey.String "speed", LuaValue.Number 51.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "HBOT4"
            LuaKey.String "mygravity", LuaValue.Number 10000.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGPEDE.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGPEDE.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "turninplace", LuaValue.Bool false
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 0.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.3
            LuaKey.String "turnrate", LuaValue.Number 200.0
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 1.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBots/T2"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.13973236084 -4.67773437585e-06 -1.37111663818"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47.3038787842 18.2459106445 47.0814971924"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 3600.0
                            LuaKey.String "object", LuaValue.String "Units/legpede_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1800.0
                            LuaKey.String "object", LuaValue.String "Units/arm4X4A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
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
                            LuaKey.Int 1, LuaValue.String "spider2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "spider3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "adv_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 90.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.3
                            LuaKey.String "cegtag", LuaValue.String "missiletrailsmall-simple"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 3.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cormissile2.s3o"
                            LuaKey.String "name", LuaValue.String "Parabolic trajectory g2g multi-rocket launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.75
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 7.0
                            LuaKey.String "smoketime", LuaValue.Number 21.0
                            LuaKey.String "smokesize", LuaValue.Number 6.5
                            LuaKey.String "smokecolor", LuaValue.Number 0.5
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "rockhit3"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "rocksalvo"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 80.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.2
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "trajectoryheight", LuaValue.Number 1.0
                            LuaKey.String "turnrate", LuaValue.Number 2000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 70.0
                            LuaKey.String "weapontimer", LuaValue.Number 6.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "wobble", LuaValue.Number 2500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
                                ]
                        ]
                    LuaKey.String "armmg_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.0675
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.038
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Rapid-fire a2g machine guns"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 575.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "minigun3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 4.5
                            LuaKey.String "sprayangle", LuaValue.Number 968.0
                            LuaKey.String "thickness", LuaValue.Number 0.91
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 958.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 5.0
                                    LuaKey.String "default", LuaValue.Number 21.0
                                    LuaKey.String "vtol", LuaValue.Number 21.0
                                ]
                        ]
                    LuaKey.String "railgunt2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "railgun"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.12
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "energypershot", LuaValue.Number 400.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "hardstop", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Railgun"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 850.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.5
                            LuaKey.String "rgbcolor", LuaValue.String "0.74 0.64 0.94"
                            LuaKey.String "soundhit", LuaValue.String "mavgun3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "heavyrailgun"
                            LuaKey.String "soundstartvolume", LuaValue.Number 26.0
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3180.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overpenetrate", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 250.0
                                    LuaKey.String "default", LuaValue.Number 500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "armmg_WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 270.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "RAILGUNT2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ADV_ROCKET"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ADV_ROCKET"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "RAILGUNT2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "armmg_WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 -1"
                            LuaKey.String "maxangledif", LuaValue.Number 270.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let legsrailt4 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.04
            LuaKey.String "maxdec", LuaValue.Number 0.15
            LuaKey.String "energycost", LuaValue.Number 300000.0
            LuaKey.String "metalcost", LuaValue.Number 15000.0
            LuaKey.String "buildpic", LuaValue.String "LEGSRAIL.DDS"
            LuaKey.String "buildtime", LuaValue.Number 300000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "99 88 99"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "explosiont3"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "health", LuaValue.Number 40000.0
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "speed", LuaValue.Number 21.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "EPICALLTERRAIN"
            LuaKey.String "mygravity", LuaValue.Number 10000.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/scavboss/LEGSRAILT4.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavboss/LEGSRAILT4.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3xl"
            LuaKey.String "sightdistance", LuaValue.Number 1200.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.0
            LuaKey.String "turnrate", LuaValue.Number 100.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/gantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-3.37104034424 -1.05229058838 1.8899307251"
                            LuaKey.String "collisionvolumescales", LuaValue.String "83 55 73"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 3000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 7500.0
                            LuaKey.String "object", LuaValue.String "Units/scavboss/legsrailt4_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 3015.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 3750.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:rocketflare"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "railgunt2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "ministarfire"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.02
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "energypershot", LuaValue.Number 3000.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:starfire-explosion"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "hardstop", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Railgun"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 1600.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.74 0.64 0.94"
                            LuaKey.String "soundhit", LuaValue.String "mavgun3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "railgunxl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 50.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 12.0
                            LuaKey.String "thickness", LuaValue.Number 4.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3180.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overpenetrate", LuaValue.Bool true
                                    LuaKey.String "stockpilelimit", LuaValue.Number 3.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 1000.0
                                    LuaKey.String "default", LuaValue.Number 6000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "RAILGUNT2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "armassimilator", armassimilator
            "armlunchbox", armlunchbox
            "armmeatball", armmeatball
            "armpwt4", armpwt4
            "armsptkt4", armsptkt4
            "corakt4", corakt4
            "cordeadeye", cordeadeye
            "corkark", corkark
            "cormandot4", cormandot4
            "corthermite", corthermite
            "leggobt3", leggobt3
            "legpede", legpede
            "legsrailt4", legsrailt4
        ]
