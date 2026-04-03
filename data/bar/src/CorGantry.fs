// Auto-generated BAR unit data: CorGantry
namespace BarData.Units

open BarData

module CorGantry =

    let corcat =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "CORCAT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 160000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 2"
            LuaKey.String "collisionvolumescales", LuaValue.String "60 53 48"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 80000.0
            LuaKey.String "explodeas", LuaValue.String "explosiont3"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 6100.0
            LuaKey.String "maxacc", LuaValue.Number 0.1242
            LuaKey.String "maxdec", LuaValue.Number 0.6486
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "metalcost", LuaValue.Number 4900.0
            LuaKey.String "movementclass", LuaValue.String "HBOT4"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORCAT.s3o"
            LuaKey.String "script", LuaValue.String "Units/corcat.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3xl"
            LuaKey.String "sightdistance", LuaValue.Number 700.0
            LuaKey.String "speed", LuaValue.Number 48.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.056
            LuaKey.String "turnrate", LuaValue.Number 525.84998
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "3.19359588623 0.0 1.04564666748"
                            LuaKey.String "collisionvolumescales", LuaValue.String "66.3871917725 26.0 41.4744720459"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 3300.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 2958.0
                            LuaKey.String "object", LuaValue.String "Units/corcat_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 1650.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1183.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:rocketflare-large"
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
                    LuaKey.String "exp_heavyrocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 96.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 20.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "cegtag", LuaValue.String "missiletrailsmall-red"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "dance", LuaValue.Number 24.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-catapult"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 3.2
                            LuaKey.String "impulsefactor", LuaValue.Number 0.6
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "catapultmissile.s3o"
                            LuaKey.String "movingaccuracy", LuaValue.Number 600.0
                            LuaKey.String "name", LuaValue.String "CatapultRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 1350.0
                            LuaKey.String "reloadtime", LuaValue.Number 15.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.5
                            LuaKey.String "smokeperiod", LuaValue.Number 4.0
                            LuaKey.String "smokesize", LuaValue.Number 8.5
                            LuaKey.String "smoketime", LuaValue.Number 16.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "rockhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "rapidrocket3"
                            LuaKey.String "startvelocity", LuaValue.Number 185.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "trajectoryheight", LuaValue.Number 1.0
                            LuaKey.String "turnrate", LuaValue.Number 0.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 100.0
                            LuaKey.String "weapontimer", LuaValue.Number 6.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 530.0
                            LuaKey.String "wobble", LuaValue.Number 2000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 1553.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 450.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "EXP_HEAVYROCKET"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let cordemon =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "CORDEMON.DDS"
            LuaKey.String "buildtime", LuaValue.Number 160000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "60 88 60"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 90000.0
            LuaKey.String "explodeas", LuaValue.String "explosiont3xl"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 18000.0
            LuaKey.String "mass", LuaValue.Number 6000.0
            LuaKey.String "maxacc", LuaValue.Number 0.2208
            LuaKey.String "maxdec", LuaValue.Number 1.0
            LuaKey.String "maxslope", LuaValue.Number 160.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "metalcost", LuaValue.Number 6000.0
            LuaKey.String "movementclass", LuaValue.String "HBOT4"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/cordemon.s3o"
            LuaKey.String "script", LuaValue.String "Units/cordemon.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3xxl"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "speed", LuaValue.Number 63.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.99
            LuaKey.String "turnrate", LuaValue.Number 607.20001
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "500"
                    LuaKey.String "model_author", LuaValue.String "FireStorm, Hornet"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "3.89811706543 -12.9994070068 -38.2052841187"
                            LuaKey.String "collisionvolumescales", LuaValue.String "77.9624938965 23.0893859863 76.4105682373"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 3600.0
                            LuaKey.String "object", LuaValue.String "Units/cordemon_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2750.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:flamestreamxxl"
                            LuaKey.Int 2, LuaValue.String "custom:pilotlightxl"
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
                    LuaKey.String "dmaw", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.8
                            LuaKey.String "bounceslip", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 5.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "burnflamexl"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.15
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "damageareaofeffect", LuaValue.Number 5.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnblackxl"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flamegfxtime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.85
                            LuaKey.String "name", LuaValue.String "Heavy long range AoE flamethrower"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.0667
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.84 0.8"
                            LuaKey.String "sizegrowth", LuaValue.Number 1.7
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Flamhvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "sprayangle", LuaValue.Number 200.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.001
                            LuaKey.String "texture1", LuaValue.String "flame_alt2"
                            LuaKey.String "tolerance", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "notFlame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 48.0
                                    LuaKey.String "subs", LuaValue.Number 16.0
                                ]
                        ]
                    LuaKey.String "karg_shoulder", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 72.0
                            LuaKey.String "fixedlauncher", LuaValue.Bool true
                            LuaKey.String "flighttime", LuaValue.Number 1.75
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "ShoulderRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.6
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 5.0
                            LuaKey.String "smokesize", LuaValue.Number 4.4
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "startvelocity", LuaValue.Number 820.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 160.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 820.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                    LuaKey.String "vtol", LuaValue.Number 150.0
                                ]
                        ]
                    LuaKey.String "newdmaw", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "avoidground", LuaValue.Bool true
                            LuaKey.String "bouncerebound", LuaValue.Number 1.0
                            LuaKey.String "bounceslip", LuaValue.Number 1.0
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 12.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "demonflame"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.01
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnblackxl"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "flamegfxtime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.85
                            LuaKey.String "name", LuaValue.String "Demon's Maw; Heavy long range AoE flamethrower"
                            LuaKey.String "noexplode", LuaValue.Bool false
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.39996
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.84 0.8"
                            LuaKey.String "sizegrowth", LuaValue.Number 1.1
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 9.5
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Flamhvy1"
                            LuaKey.String "soundstartvolume", LuaValue.Number 7.3
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool false
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 48.0
                                    LuaKey.String "subs", LuaValue.Number 16.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT VTOL"
                            LuaKey.String "def", LuaValue.String "newdmaw"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "KARG_SHOULDER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let corjugg =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "CORJUGG.DDS"
            LuaKey.String "buildtime", LuaValue.Number 780000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "90 80 90"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 513000.0
            LuaKey.String "explodeas", LuaValue.String "juggernaut"
            LuaKey.String "footprintx", LuaValue.Number 7.0
            LuaKey.String "footprintz", LuaValue.Number 7.0
            LuaKey.String "health", LuaValue.Number 335000.0
            LuaKey.String "mass", LuaValue.Number 20000.0
            LuaKey.String "maxacc", LuaValue.Number 0.0552
            LuaKey.String "maxdec", LuaValue.Number 0.43125
            LuaKey.String "maxslope", LuaValue.Number 14.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "metalcost", LuaValue.Number 20000.0
            LuaKey.String "movementclass", LuaValue.String "HBOT7"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORJUGG.s3o"
            LuaKey.String "script", LuaValue.String "Units/corjugg.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "juggernautSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 720.0
            LuaKey.String "speed", LuaValue.Number 16.5
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.363
            LuaKey.String "turnrate", LuaValue.Number 125.35
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "customrange", LuaValue.Number 435.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String "CorGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-0.35619354248 -4.26102086182 -1.35372924805"
                            LuaKey.String "collisionvolumescales", LuaValue.String "105.219192505 63.5703582764 119.881469727"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 27000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 8.0
                            LuaKey.String "metal", LuaValue.Number 13959.0
                            LuaKey.String "object", LuaValue.String "Units/corjugg_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 13500.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 2.0
                            LuaKey.String "metal", LuaValue.Number 2793.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4A.s3o"
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
                            LuaKey.Int 1, LuaValue.String "doom"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "doom"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "juggernaut_bottom", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.08
                            LuaKey.String "corethickness", LuaValue.Number 0.175
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 15.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "LightLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 435.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.3
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.2
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2250.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 75.0
                                ]
                        ]
                    LuaKey.String "juggernaut_fire", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 65.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "gausscannonprojectile"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnblackbig"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "gravityaffected", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 4.0
                            LuaKey.String "name", LuaValue.String "GaussCannon"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 590.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.8 0.17"
                            LuaKey.String "size", LuaValue.Number 6.5
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitvolume", LuaValue.Number 32.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "krogun1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool false
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1200.0
                                ]
                        ]
                    LuaKey.String "juggernaut_top", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.15
                            LuaKey.String "corethickness", LuaValue.Number 0.19
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 30.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.25
                            LuaKey.String "name", LuaValue.String "LightLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 550.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.46667
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.6
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2250.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 150.0
                                ]
                        ]
                    LuaKey.String "juggfootstep", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 172.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "camerashake", LuaValue.Number 400.0
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:footstep-large"
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "JuggStep"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 0.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
                            LuaKey.String "soundhitdry", LuaValue.String "korgstep"
                            LuaKey.String "soundhitdryvolume", LuaValue.Number 18.0
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 16.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "nodecal", LuaValue.Bool true
                                    LuaKey.String "noexplosionlight", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "JUGGERNAUT_FIRE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "JUGGERNAUT_BOTTOM"
                            LuaKey.String "maindir", LuaValue.String "-1 0 4"
                            LuaKey.String "maxangledif", LuaValue.Number 90.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "JUGGERNAUT_BOTTOM"
                            LuaKey.String "maindir", LuaValue.String "1 0 4"
                            LuaKey.String "maxangledif", LuaValue.Number 90.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "JUGGERNAUT_TOP"
                            LuaKey.String "maindir", LuaValue.String "0 1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 270.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "JUGGFOOTSTEP"
                        ]
                ]
        ]

    let corkarg =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "CORKARG.DDS"
            LuaKey.String "buildtime", LuaValue.Number 94000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -2.0 1"
            LuaKey.String "collisionvolumescales", LuaValue.String "59.0 63.0 42.0"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 57000.0
            LuaKey.String "explodeas", LuaValue.String "explosiont3med"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 12500.0
            LuaKey.String "mass", LuaValue.Number 2500.0
            LuaKey.String "maxacc", LuaValue.Number 0.1104
            LuaKey.String "maxdec", LuaValue.Number 0.8211
            LuaKey.String "maxslope", LuaValue.Number 160.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "metalcost", LuaValue.Number 2500.0
            LuaKey.String "movementclass", LuaValue.String "HTBOT6"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORKARG.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORKARG.COB"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "speed", LuaValue.Number 45.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.99
            LuaKey.String "turnrate", LuaValue.Number 400.0
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Flaka"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "81 24.5 79"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 1550.0
                            LuaKey.String "object", LuaValue.String "Units/corkarg_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 2500.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 620.0
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
                            LuaKey.Int 1, LuaValue.String "mavbok1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "mavbsel1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "karg_shoulder", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 72.0
                            LuaKey.String "fixedlauncher", LuaValue.Bool true
                            LuaKey.String "flighttime", LuaValue.Number 1.75
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "ShoulderRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.6
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 5.0
                            LuaKey.String "smokesize", LuaValue.Number 4.4
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "startvelocity", LuaValue.Number 820.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 160.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 820.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                    LuaKey.String "vtol", LuaValue.Number 150.0
                                ]
                        ]
                    LuaKey.String "super_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "missiletrailsmall-simple"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "firestarter", LuaValue.Number 5.0
                            LuaKey.String "flighttime", LuaValue.Number 2.5
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cormissile3fast.s3o"
                            LuaKey.String "name", LuaValue.String "KarganethMissiles"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.3
                            LuaKey.String "smokecolor", LuaValue.Number 0.5
                            LuaKey.String "smokeperiod", LuaValue.Number 7.0
                            LuaKey.String "smokesize", LuaValue.Number 7.0
                            LuaKey.String "smoketime", LuaValue.Number 21.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "rocklit1"
                            LuaKey.String "startvelocity", LuaValue.Number 180.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "tolerance", LuaValue.Number 15000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 21800.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 250.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 690.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "speceffect", LuaValue.String "retarget"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 180.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT VTOL"
                            LuaKey.String "def", LuaValue.String "SUPER_MISSILE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "fastquerypointupdate", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "KARG_SHOULDER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let corkorg =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "corkorg.DDS"
            LuaKey.String "buildtime", LuaValue.Number 730000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -6 -5"
            LuaKey.String "collisionvolumescales", LuaValue.String "97 160 85"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 615000.0
            LuaKey.String "energymake", LuaValue.Number 300.0
            LuaKey.String "energystorage", LuaValue.Number 5000.0
            LuaKey.String "explodeas", LuaValue.String "korgExplosion"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 149000.0
            LuaKey.String "mass", LuaValue.Number 29000.0
            LuaKey.String "maxacc", LuaValue.Number 0.1242
            LuaKey.String "maxdec", LuaValue.Number 0.8211
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "metalcost", LuaValue.Number 29000.0
            LuaKey.String "movementclass", LuaValue.String "VBOT6"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL GROUNDSCOUT"
            LuaKey.String "objectname", LuaValue.String "Units/corkorg.s3o"
            LuaKey.String "script", LuaValue.String "Units/corkorg.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "korgExplosionSelfd"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 10.0
            LuaKey.String "sightdistance", LuaValue.Number 845.0
            LuaKey.String "speed", LuaValue.Number 37.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.7392
            LuaKey.String "turnrate", LuaValue.Number 437.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "customrange", LuaValue.Number 590.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String "CorGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -11 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "96 88 134"
                            LuaKey.String "collisionvolumetype", LuaValue.String "box"
                            LuaKey.String "damage", LuaValue.Number 57600.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 17668.0
                            LuaKey.String "object", LuaValue.String "Units/corkorg_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 28800.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 15067.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3A.s3o"
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
                            LuaKey.Int 1, LuaValue.String "krogok1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "krogsel1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corkorg_fire", LuaValue.Table [
                            LuaKey.String "alphadecay", LuaValue.Number 0.66
                            LuaKey.String "areaofeffect", LuaValue.Number 112.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.8
                            LuaKey.String "intensity", LuaValue.Number 5.0
                            LuaKey.String "name", LuaValue.String "GaussCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "projectiles", LuaValue.Number 10.0
                            LuaKey.String "range", LuaValue.Number 590.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.9 0.45"
                            LuaKey.String "size", LuaValue.Number 4.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.044
                            LuaKey.String "soundhit", LuaValue.String "xplomed2xs"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "kroggie2xs"
                            LuaKey.String "sprayangle", LuaValue.Number 2750.0
                            LuaKey.String "stages", LuaValue.Number 8.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 165.0
                                ]
                        ]
                    LuaKey.String "corkorg_laser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 72.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.6
                            LuaKey.String "camerashake", LuaValue.Number 0.1
                            LuaKey.String "corethickness", LuaValue.Number 0.35
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 1200.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-beam"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.25
                            LuaKey.String "name", LuaValue.String "Experimental g2g Eradicator Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 900.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.55 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.95 1.0 0.7"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heatray2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 6.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 1200.0
                                    LuaKey.String "default", LuaValue.Number 5500.0
                                    LuaKey.String "vtol", LuaValue.Number 2750.0
                                ]
                        ]
                    LuaKey.String "corkorg_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 200.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "missiletrailmedium-starburst"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "corkbmissl1.s3o"
                            LuaKey.String "name", LuaValue.String "HeavyRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 950.0
                            LuaKey.String "reloadtime", LuaValue.Number 6.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeperiod", LuaValue.Number 9.0
                            LuaKey.String "smokesize", LuaValue.Number 12.0
                            LuaKey.String "smoketime", LuaValue.Number 36.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "rocklit1"
                            LuaKey.String "startvelocity", LuaValue.Number 10.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 9000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 230.0
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2600.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 1093.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 800.0
                                ]
                        ]
                    LuaKey.String "krogfootstep", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 172.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "camerashake", LuaValue.Number 400.0
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:footstep-huge"
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "KrogStep"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 0.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
                            LuaKey.String "soundhitdry", LuaValue.String "korgstep"
                            LuaKey.String "soundhitdryvolume", LuaValue.Number 18.0
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 16.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                    LuaKey.String "nodecal", LuaValue.Bool true
                                    LuaKey.String "noexplosionlight", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                    LuaKey.String "krogkick", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 192.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "camerashake", LuaValue.Number 1500.0
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:crusherkrog"
                            LuaKey.String "firestarter", LuaValue.Number 40.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "name", LuaValue.String "KrogCrush"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 55.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.2
                            LuaKey.String "rgbcolor", LuaValue.String "0 0 0"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "xplosml2"
                            LuaKey.String "thickness", LuaValue.Number 0.0
                            LuaKey.String "tolerance", LuaValue.Number 9000.0
                            LuaKey.String "turnrate", LuaValue.Number 50000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1650.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                    LuaKey.String "nofire", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 150.0
                                ]
                        ]
                    LuaKey.String "krogweaponaim", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "KrogAim"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "soundhitdry", LuaValue.String "korgaim"
                            LuaKey.String "soundhitdryvolume", LuaValue.Number 16.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                    LuaKey.String "noexplosionlight", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                    LuaKey.String "krogweaponrestore", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "KrogRestore"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "soundhitdry", LuaValue.String "korgrestore2"
                            LuaKey.String "soundhitdryvolume", LuaValue.Number 16.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                    LuaKey.String "noexplosionlight", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "corkorg_FIRE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "corkorg_LASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "corkorg_ROCKET"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "KROGKICK"
                            LuaKey.String "maindir", LuaValue.String "-1.4 -1.5 1"
                            LuaKey.String "maxangledif", LuaValue.Number 170.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "KROGKICK"
                            LuaKey.String "maindir", LuaValue.String "1.4 -1.5 1"
                            LuaKey.String "maxangledif", LuaValue.Number 170.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "KROGFOOTSTEP"
                        ]
                    LuaKey.Int 7, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "KROGWEAPONAIM"
                        ]
                    LuaKey.Int 8, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "KROGWEAPONRESTORE"
                        ]
                ]
        ]

    let corshiva =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "CORSHIVA.DDS"
            LuaKey.String "buildtime", LuaValue.Number 40000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -5 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "61 60 61"
            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 23000.0
            LuaKey.String "explodeas", LuaValue.String "explosiont3"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 9400.0
            LuaKey.String "mass", LuaValue.Number 1550.0
            LuaKey.String "maxacc", LuaValue.Number 0.069
            LuaKey.String "maxdec", LuaValue.Number 0.8211
            LuaKey.String "maxslope", LuaValue.Number 36.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 32.0
            LuaKey.String "metalcost", LuaValue.Number 1550.0
            LuaKey.String "movementclass", LuaValue.String "HABOT5"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORSHIVA.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORSHIVA.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3xl"
            LuaKey.String "sightdistance", LuaValue.Number 520.0
            LuaKey.String "speed", LuaValue.Number 48.3
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.0626
            LuaKey.String "turnrate", LuaValue.Number 708.39996
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "customrange", LuaValue.Number 650.0
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "48.4013214111 35.5686035156 49.8471069336"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 10.0
                            LuaKey.String "metal", LuaValue.Number 937.0
                            LuaKey.String "object", LuaValue.String "Units/corshiva_dead.s3o"
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
                            LuaKey.String "metal", LuaValue.Number 375.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-large"
                            LuaKey.Int 2, LuaValue.String "custom:subbubbles"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
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
                    LuaKey.String "shiva_gun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 176.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-aoe"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "HeavyCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 650.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy2"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 310.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 600.0
                                    LuaKey.String "subs", LuaValue.Number 130.0
                                    LuaKey.String "vtol", LuaValue.Number 55.0
                                ]
                        ]
                    LuaKey.String "shiva_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 60.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "missiletrailmedium-starburst"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 7.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.8
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "corkbmissl1.s3o"
                            LuaKey.String "name", LuaValue.String "HeavyRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 7.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeperiod", LuaValue.Number 9.0
                            LuaKey.String "smokesize", LuaValue.Number 12.0
                            LuaKey.String "smoketime", LuaValue.Number 38.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 100.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 920.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 750.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "SHIVA_GUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "SHIVA_ROCKET"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let corsok =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "CORSOK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 34000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.Number 1.0
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "52 40 58"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "dead"
            LuaKey.String "energycost", LuaValue.Number 19000.0
            LuaKey.String "explodeas", LuaValue.String "hugeexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 4200.0
            LuaKey.String "maxacc", LuaValue.Number 0.01731
            LuaKey.String "maxdec", LuaValue.Number 0.01731
            LuaKey.String "maxslope", LuaValue.Number 16.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 950.0
            LuaKey.String "movementclass", LuaValue.String "HHOVER4"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORSOK.s3o"
            LuaKey.String "radardistance", LuaValue.Number 0.0
            LuaKey.String "script", LuaValue.String "Units/corsok.cob"
            LuaKey.String "selfdestructas", LuaValue.String "hugeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 650.0
            LuaKey.String "sonardistance", LuaValue.Number 550.0
            LuaKey.String "speed", LuaValue.Number 45.3
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.056
            LuaKey.String "turnrate", LuaValue.Number 290.0
            LuaKey.String "waterline", LuaValue.Number 7.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "damage", LuaValue.Number 7000.0
                            LuaKey.String "featuredead", LuaValue.String "heap"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 15.0
                            LuaKey.String "metal", LuaValue.Number 588.0
                            LuaKey.String "object", LuaValue.String "Units/corsok_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 3500.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 221.0
                            LuaKey.String "object", LuaValue.String "Units/cor4x4d.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:waterwake-small-hover"
                            LuaKey.Int 2, LuaValue.String "custom:bowsplash-small-hover"
                            LuaKey.Int 3, LuaValue.String "custom:hover-wake-large"
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
                            LuaKey.Int 1, LuaValue.String "hovlgok2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "hovlgsl2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corsok_laser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 20.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collideenemy", LuaValue.Bool true
                            LuaKey.String "corethickness", LuaValue.Number 1.5
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.05
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-large-aqua"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 2.2
                            LuaKey.String "name", LuaValue.String "Disruptor Bolt"
                            LuaKey.String "range", LuaValue.Number 725.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.5
                            LuaKey.String "rgbcolor", LuaValue.String "0.0 0.5 0.8"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.8 1.0"
                            LuaKey.String "soundhitdry", LuaValue.String "xplosml5"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir5"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.5
                            LuaKey.String "tolerance", LuaValue.Number 525.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1673.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 750.0
                                    LuaKey.String "subs", LuaValue.Number 500.0
                                    LuaKey.String "vtol", LuaValue.Number 250.0
                                ]
                        ]
                    LuaKey.String "depthcharge", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 24.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.9
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-uw"
                            LuaKey.String "flighttime", LuaValue.Number 3.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cordepthcharge.s3o"
                            LuaKey.String "name", LuaValue.String "Depthcharge launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.0
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 120.0
                            LuaKey.String "tolerance", LuaValue.Number 1000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 20.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 140.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 225.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORSOK_LASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "def", LuaValue.String "DEPTHCHARGE"
                            LuaKey.String "maindir", LuaValue.String "0 -1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 179.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "CANBEUW UNDERWATER"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "corcat", corcat
            "cordemon", cordemon
            "corjugg", corjugg
            "corkarg", corkarg
            "corkorg", corkorg
            "corshiva", corshiva
            "corsok", corsok
        ]
