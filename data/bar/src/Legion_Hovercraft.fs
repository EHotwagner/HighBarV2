// Auto-generated BAR unit data: Legion/Hovercraft
namespace BarData.Units

open BarData

module Legion_Hovercraft =

    let legah =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.06316
            LuaKey.String "airsightdistance", LuaValue.Number 800.0
            LuaKey.String "maxdec", LuaValue.Number 0.06316
            LuaKey.String "energycost", LuaValue.Number 4300.0
            LuaKey.String "metalcost", LuaValue.Number 210.0
            LuaKey.String "buildpic", LuaValue.String "LEGAH.DDS"
            LuaKey.String "buildtime", LuaValue.Number 3300.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 12 38"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "smallexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1120.0
            LuaKey.String "maxslope", LuaValue.Number 16.0
            LuaKey.String "speed", LuaValue.Number 88.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "HOVER3"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Units/legah.s3o"
            LuaKey.String "script", LuaValue.String "Units/legah.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 509.0
            LuaKey.String "sonardistance", LuaValue.Number 350.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 2.2044
            LuaKey.String "turnrate", LuaValue.Number 470.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "model_author", LuaValue.String "EnderRobo"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorHovercraft"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "28 12 38"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 605.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 154.0
                            LuaKey.String "object", LuaValue.String "Units/legah_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 303.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 62.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:waterwake-small-hover"
                            LuaKey.Int 2, LuaValue.String "custom:bowsplash-small-hover"
                            LuaKey.Int 3, LuaValue.String "custom:hover-wake-small"
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
                            LuaKey.Int 1, LuaValue.String "hovmdok2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "hovmdsl2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "aagun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 100.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.066
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.05
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Light G2A Gatling Gun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "predictboost", LuaValue.Number 0.5
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.33 0.7"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "minigun3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 3.0
                            LuaKey.String "sprayangle", LuaValue.Number 900.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 5.0
                                    LuaKey.String "vtol", LuaValue.Number 8.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "aagun"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let legcar =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.02428
            LuaKey.String "maxdec", LuaValue.Number 0.02428
            LuaKey.String "energycost", LuaValue.Number 11000.0
            LuaKey.String "metalcost", LuaValue.Number 550.0
            LuaKey.String "buildpic", LuaValue.String "LEGCAR.DDS"
            LuaKey.String "buildtime", LuaValue.Number 11000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "42 12 42"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 1.0
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 3600.0
            LuaKey.String "maxslope", LuaValue.Number 16.0
            LuaKey.String "speed", LuaValue.Number 51.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "HOVER3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGCAR.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGCAR.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.9768
            LuaKey.String "turnrate", LuaValue.Number 410.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "EnderRobo"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "hovercraft"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -0.5 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "30 20 40"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2079.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 390.0
                            LuaKey.String "object", LuaValue.String "Units/legcar_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 1040.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "metal", LuaValue.Number 156.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-small-impulse"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-small-hover"
                            LuaKey.Int 3, LuaValue.String "custom:bowsplash-small-hover"
                            LuaKey.Int 4, LuaValue.String "custom:hover-wake-small"
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
                            LuaKey.Int 1, LuaValue.String "hovt1canok"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "hovt1cansel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "shot", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "projectiles", LuaValue.Number 14.0
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.015
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Medium Shotgun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 321.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "kroggie2xs"
                            LuaKey.String "soundstartvolume", LuaValue.Number 3.0
                            LuaKey.String "sprayangle", LuaValue.Number 1900.0
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
                            LuaKey.String "def", LuaValue.String "SHOT"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let legmh =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.04415
            LuaKey.String "maxdec", LuaValue.Number 0.04415
            LuaKey.String "energycost", LuaValue.Number 3100.0
            LuaKey.String "metalcost", LuaValue.Number 190.0
            LuaKey.String "buildpic", LuaValue.String "LEGMH.DDS"
            LuaKey.String "buildtime", LuaValue.Number 3300.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "33 18 44"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 520.0
            LuaKey.String "maxslope", LuaValue.Number 16.0
            LuaKey.String "speed", LuaValue.Number 70.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "HOVER3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legmh.s3o"
            LuaKey.String "script", LuaValue.String "Units/legmh.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 509.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.5972
            LuaKey.String "turnrate", LuaValue.Number 455.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "EnderRobo"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorHovercraft"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 1 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "33 18 44"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 297.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 119.0
                            LuaKey.String "object", LuaValue.String "Units/legmh_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 149.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 48.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:waterwake-small-hover"
                            LuaKey.Int 2, LuaValue.String "custom:bowsplash-small-hover"
                            LuaKey.Int 3, LuaValue.String "custom:hover-wake-small"
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
                            LuaKey.Int 1, LuaValue.String "hovmdok2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "hovmdsl2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "legmh_weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 80.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailsmall-starburst"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "flighttime", LuaValue.Number 10.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "leglargerocket.s3o"
                            LuaKey.String "name", LuaValue.String "Rocket"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 7.5
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 9.0
                            LuaKey.String "smoketime", LuaValue.Number 28.0
                            LuaKey.String "smokesize", LuaValue.Number 10.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 70.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.9
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 480.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 400.0
                                    LuaKey.String "subs", LuaValue.Number 175.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "overrange_distance", LuaValue.Number 805.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "LEGMH_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let legner =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.05666
            LuaKey.String "maxdec", LuaValue.Number 0.05666
            LuaKey.String "energycost", LuaValue.Number 2000.0
            LuaKey.String "metalcost", LuaValue.Number 220.0
            LuaKey.String "buildpic", LuaValue.String "LEGNER.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2400.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "34 12 34"
            LuaKey.String "collisionvolumetype", LuaValue.String "Cyly"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1100.0
            LuaKey.String "maxslope", LuaValue.Number 16.0
            LuaKey.String "speed", LuaValue.Number 76.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "HOVER3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGNER.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGNER.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 509.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.6698
            LuaKey.String "turnrate", LuaValue.Number 550.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "EnderRobo"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "hovercraft"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "34 12 34"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Cyly"
                            LuaKey.String "damage", LuaValue.Number 826.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 175.0
                            LuaKey.String "object", LuaValue.String "Units/legner_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 413.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 70.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-small"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-small-hover"
                            LuaKey.Int 3, LuaValue.String "custom:bowsplash-small-hover"
                            LuaKey.Int 4, LuaValue.String "custom:hover-wake-small"
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
                            LuaKey.Int 1, LuaValue.String "hovt1canok"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "hovt1cansel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "legner_weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 24.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Medium g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 370.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "size", LuaValue.Number 1.8
                            LuaKey.String "soundhit", LuaValue.String "xplosml3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "canlite3"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 260.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 55.0
                                    LuaKey.String "vtol", LuaValue.Number 19.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "LEGNER_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let legsh =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.095
            LuaKey.String "maxdec", LuaValue.Number 0.095
            LuaKey.String "energycost", LuaValue.Number 1200.0
            LuaKey.String "metalcost", LuaValue.Number 60.0
            LuaKey.String "buildpic", LuaValue.String "legsh.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1200.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -2 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "19 8 25"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 220.0
            LuaKey.String "maxslope", LuaValue.Number 16.0
            LuaKey.String "speed", LuaValue.Number 96.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "HOVER2"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legsh.s3o"
            LuaKey.String "script", LuaValue.String "Units/legsh.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 2.9634
            LuaKey.String "turnrate", LuaValue.Number 540.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "EnderRobo"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmHovercraft"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -2 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "19 8 25"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 185.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 49.0
                            LuaKey.String "object", LuaValue.String "Units/legsh_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 93.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 20.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:waterwake-small-hover"
                            LuaKey.Int 2, LuaValue.String "custom:bowsplash-small-hover"
                            LuaKey.Int 3, LuaValue.String "custom:hover-wake-tiny"
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
                            LuaKey.Int 1, LuaValue.String "hovt1fastok"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "hovt1fastsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "heat_ray", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.5
                            LuaKey.String "corethickness", LuaValue.Number 0.14
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.0
                            LuaKey.String "name", LuaValue.String "Light Close-Quarters g2g Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 260.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.55 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 1.0 0.5"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 1.2
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 60.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "HEAT_RAY"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "legah", legah
            "legcar", legcar
            "legmh", legmh
            "legner", legner
            "legsh", legsh
        ]
