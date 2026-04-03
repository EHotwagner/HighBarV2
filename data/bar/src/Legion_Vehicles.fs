// Auto-generated BAR unit data: Legion/Vehicles
namespace BarData.Units

open BarData

module Legion_Vehicles =

    let legamphtank =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.03572
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.07144
            LuaKey.String "energycost", LuaValue.Number 2000.0
            LuaKey.String "metalcost", LuaValue.Number 200.0
            LuaKey.String "buildpic", LuaValue.String "LEGAMPHTANK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2610.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 1"
            LuaKey.String "collisionvolumescales", LuaValue.String "31 13 31"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 1.0
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGeneric-phib"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 1340.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "speed", LuaValue.Number 63.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 125.0
            LuaKey.String "movementclass", LuaValue.String "ATANK3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGAMPHTANK.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGAMPHTANK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd-phib"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "sonardistance", LuaValue.Number 180.0
            LuaKey.String "trackoffset", LuaValue.Number 3.0
            LuaKey.String "trackstrength", LuaValue.Number 6.0
            LuaKey.String "tracktype", LuaValue.String "armpincer_tracks"
            LuaKey.String "trackwidth", LuaValue.Number 28.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.485
            LuaKey.String "turnrate", LuaValue.Number 398.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "basename", LuaValue.String "base"
                    LuaKey.String "firingceg", LuaValue.String "barrelshot-small"
                    LuaKey.String "kickback", LuaValue.String "-2.7"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.125
                    LuaKey.String "subfolder", LuaValue.String "Legion/Vehicles"
                    LuaKey.String "weapon1turretx", LuaValue.Number 130.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 130.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -1.0267456543 -0.357666015625"
                            LuaKey.String "collisionvolumescales", LuaValue.String "29.7029724121 10.5689086914 32.8999633789"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 689.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 9.0
                            LuaKey.String "metal", LuaValue.Number 122.0
                            LuaKey.String "object", LuaValue.String "Units/legamphtank_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 528.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 61.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-small"
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
                            LuaKey.Int 1, LuaValue.String "tnkt1canamphok"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "tnkt1canamphsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "leg_amph_gauss", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Light Close-quarters Gauss Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 305.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy1"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 116.0
                                    LuaKey.String "vtol", LuaValue.Number 25.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "LEG_AMPH_GAUSS"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let legbar =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.01654
            LuaKey.String "maxdec", LuaValue.Number 0.054
            LuaKey.String "energycost", LuaValue.Number 3200.0
            LuaKey.String "metalcost", LuaValue.Number 250.0
            LuaKey.String "buildpic", LuaValue.String "LEGBAR.DDS"
            LuaKey.String "buildtime", LuaValue.Number 3600.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -2 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "37 15 44"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "pyro"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 1500.0
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "speed", LuaValue.Number 40.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "TANK3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGBAR.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGBAR.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "pyro"
            LuaKey.String "sightdistance", LuaValue.Number 400.0
            LuaKey.String "trackoffset", LuaValue.Number 8.0
            LuaKey.String "trackstrength", LuaValue.Number 7.0
            LuaKey.String "tracktype", LuaValue.String "corwidetracks"
            LuaKey.String "trackwidth", LuaValue.Number 32.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.957
            LuaKey.String "turnrate", LuaValue.Number 240.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corgol_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalalpha", LuaValue.Number 0.5
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "basename", LuaValue.String "base"
                    LuaKey.String "firingceg", LuaValue.String "barrelshot-medium"
                    LuaKey.String "kickback", LuaValue.String "-2.4"
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorVehicles/T2"
                    LuaKey.String "weapon1turretx", LuaValue.Number 30.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 40.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "33 18 33"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 650.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 15.0
                            LuaKey.String "metal", LuaValue.Number 192.0
                            LuaKey.String "object", LuaValue.String "Units/legbar_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 325.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 96.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-large"
                            LuaKey.Int 2, LuaValue.String "custom:dust_cloud_dirt"
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
                            LuaKey.Int 1, LuaValue.String "tcormove"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "tcorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "clusternapalm", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "burnflame"
                            LuaKey.String "colormap", LuaValue.String "0.75 0.73 0.67 0.024   0.37 0.4 0.30 0.021   0.22 0.21 0.14 0.018  0.024 0.014 0.009 0.03   0.0 0.0 0.0 0.008"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 90.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:fire-explosion-small"
                            LuaKey.String "flamegfxtime", LuaValue.Number 1.0
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "leadlimit", LuaValue.Number 0.0
                            LuaKey.String "mygravity", LuaValue.Number 0.1
                            LuaKey.String "name", LuaValue.String "Napalm Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "projectiles", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 535.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.25 0.1"
                            LuaKey.String "size", LuaValue.Number 6.0
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy2"
                            LuaKey.String "sprayangle", LuaValue.Number 600.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 250.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "area_onhit_ceg", LuaValue.String "fire-area-60-repeat"
                                    LuaKey.String "area_onhit_damageCeg", LuaValue.String "burnflamel-gen"
                                    LuaKey.String "area_onhit_resistance", LuaValue.String "fire"
                                    LuaKey.String "area_onhit_damage", LuaValue.Number 60.0
                                    LuaKey.String "area_onhit_range", LuaValue.Number 60.0
                                    LuaKey.String "area_onhit_time", LuaValue.Number 7.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 60.0
                                    LuaKey.String "subs", LuaValue.Number 10.0
                                    LuaKey.String "vtol", LuaValue.Number 10.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CLUSTERNAPALM"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let leggat =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.02
            LuaKey.String "maxdec", LuaValue.Number 0.04
            LuaKey.String "energycost", LuaValue.Number 3600.0
            LuaKey.String "metalcost", LuaValue.Number 300.0
            LuaKey.String "buildpic", LuaValue.String "LEGGAT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4800.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -2 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "34 16 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 2550.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 45.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "TANK3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGGAT.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGGAT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 400.0
            LuaKey.String "trackoffset", LuaValue.Number 3.0
            LuaKey.String "trackstrength", LuaValue.Number 6.0
            LuaKey.String "tracktype", LuaValue.String "armstump_tracks"
            LuaKey.String "trackwidth", LuaValue.Number 38.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.952
            LuaKey.String "turnrate", LuaValue.Number 300.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "basename", LuaValue.String "base"
                    LuaKey.String "firingceg", LuaValue.String "barrelshot-small"
                    LuaKey.String "kickback", LuaValue.String "-2.4"
                    LuaKey.String "lumamult", LuaValue.String "1.2"
                    LuaKey.String "model_author", LuaValue.String "Protar"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Vehicles"
                    LuaKey.String "weapon1turretx", LuaValue.Number 45.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 80.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -2 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "34 16 40"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1056.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 200.0
                            LuaKey.String "object", LuaValue.String "Units/leggat_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 528.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 80.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-tiny"
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
                            LuaKey.Int 1, LuaValue.String "tnkt1canok"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "tnkt1cansel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armmg_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.066
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.03
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Rapid-fire Machine Gun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 361.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mgun6"
                            LuaKey.String "soundstartvolume", LuaValue.Number 3.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 1600.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "fireTolerance", LuaValue.Number 6000.0
                            LuaKey.String "tolerance", LuaValue.Number 12000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 12.0
                                    LuaKey.String "vtol", LuaValue.Number 3.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMMG_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                        ]
                ]
        ]

    let leghades =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.06788
            LuaKey.String "maxdec", LuaValue.Number 0.13575
            LuaKey.String "energycost", LuaValue.Number 850.0
            LuaKey.String "metalcost", LuaValue.Number 65.0
            LuaKey.String "buildpic", LuaValue.String "LEGHADES.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1650.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "16 10 23"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 425.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 102.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "TANK2"
            LuaKey.String "name", LuaValue.String "Hades"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGHADES.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGHADES.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 300.0
            LuaKey.String "trackoffset", LuaValue.Number 5.0
            LuaKey.String "trackstrength", LuaValue.Number 4.0
            LuaKey.String "tracktype", LuaValue.String "armpincer_tracks"
            LuaKey.String "trackwidth", LuaValue.Number 22.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 2.424
            LuaKey.String "turnrate", LuaValue.Number 544.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "basename", LuaValue.String "base"
                    LuaKey.String "firingceg", LuaValue.String "barrelshot-tiny"
                    LuaKey.String "kickback", LuaValue.String "-2"
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmVehicles"
                    LuaKey.String "weapon1turretx", LuaValue.Number 240.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 240.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "16 10 23"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 250.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 40.0
                            LuaKey.String "object", LuaValue.String "Units/leghades_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 193.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 20.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-tiny"
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
                            LuaKey.Int 1, LuaValue.String "veht1emgok"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "veht1emgsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "gauss", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small"
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Close-quarters g2g gauss-cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 210.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.3
                            LuaKey.String "size", LuaValue.Number 2.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed1"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy1"
                            LuaKey.String "soundstartvolume", LuaValue.Number 2.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 550.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "vtol", LuaValue.Number 25.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "GAUSS"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let leghelios =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.05
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 2400.0
            LuaKey.String "metalcost", LuaValue.Number 160.0
            LuaKey.String "buildpic", LuaValue.String "LEGHELIOS.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2600.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -4 1"
            LuaKey.String "collisionvolumescales", LuaValue.String "30 12 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 1.0
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "smallexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 800.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 69.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "TANK3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGHELIOS.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGHELIOS.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 360.0
            LuaKey.String "trackoffset", LuaValue.Number 14.0
            LuaKey.String "trackstrength", LuaValue.Number 5.0
            LuaKey.String "tracktype", LuaValue.String "corwidetracks"
            LuaKey.String "trackwidth", LuaValue.Number 28.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.96
            LuaKey.String "turnrate", LuaValue.Number 400.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "basename", LuaValue.String "base"
                    LuaKey.String "cannon1name", LuaValue.String "barrel"
                    LuaKey.String "driftratio", LuaValue.String "0.6"
                    LuaKey.String "firingceg", LuaValue.String "barrelshot-tiny"
                    LuaKey.String "flare1name", LuaValue.String "flare"
                    LuaKey.String "kickback", LuaValue.String "-2.0"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "restoretime", LuaValue.String "3000"
                    LuaKey.String "rockstrength", LuaValue.String "0"
                    LuaKey.String "sleevename", LuaValue.String "turret"
                    LuaKey.String "subfolder", LuaValue.String "CorVehicles"
                    LuaKey.String "turretname", LuaValue.String "turret"
                    LuaKey.String "wpn1turretx", LuaValue.Number 192.5
                    LuaKey.String "wpn1turrety", LuaValue.Number 192.5
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -4 1"
                            LuaKey.String "collisionvolumescales", LuaValue.String "30 12 28"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 550.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 105.0
                            LuaKey.String "object", LuaValue.String "Units/leghelios_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 225.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 45.0
                            LuaKey.String "object", LuaValue.String "units/cor2x2f.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
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
                            LuaKey.Int 1, LuaValue.String "tcormove"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "tcorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "heat_ray", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.5
                            LuaKey.String "corethickness", LuaValue.Number 0.23
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.0
                            LuaKey.String "leadlimit", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Light g2g Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 330.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.3
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.55 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 1.0 0.5"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heliosfire"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 160.0
                                    LuaKey.String "vtol", LuaValue.Number 25.0
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

    let legmlv =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builddistance", LuaValue.Number 96.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "legmlv.DDS"
            LuaKey.String "buildtime", LuaValue.Number 3640.0
            LuaKey.String "canassist", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool false
            LuaKey.String "canrepair", LuaValue.Bool true
            LuaKey.String "canrestore", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 2 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "19 15 29"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 900.0
            LuaKey.String "explodeas", LuaValue.String "smallexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 210.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 740.0
            LuaKey.String "maxacc", LuaValue.Number 0.06681
            LuaKey.String "maxdec", LuaValue.Number 0.1327
            LuaKey.String "maxslope", LuaValue.Number 16.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 52.0
            LuaKey.String "movementclass", LuaValue.String "TANK2"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legmlv.s3o"
            LuaKey.String "radardistancejam", LuaValue.Number 64.0
            LuaKey.String "script", LuaValue.String "Units/legmlv.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "speed", LuaValue.Number 69.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "terraformspeed", LuaValue.Number 120.0
            LuaKey.String "trackoffset", LuaValue.Number 12.0
            LuaKey.String "trackstrength", LuaValue.Number 5.0
            LuaKey.String "tracktype", LuaValue.String "corwidetracks"
            LuaKey.String "trackwidth", LuaValue.Number 17.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.62228
            LuaKey.String "turnrate", LuaValue.Number 580.0
            LuaKey.String "workertime", LuaValue.Number 40.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "legmine1"
                    LuaKey.Int 2, LuaValue.String "legmine2"
                    LuaKey.Int 3, LuaValue.String "legmine3"
                    LuaKey.Int 4, LuaValue.String "legdrag"
                    LuaKey.Int 5, LuaValue.String "legeyes"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "minesweeper", LuaValue.Number 450.0
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Vehicles"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "22 10 25"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 133.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 37.0
                            LuaKey.String "object", LuaValue.String "Units/legmlv_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 60.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 15.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
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
                            LuaKey.Int 1, LuaValue.String "vcormove"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vcorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "minesweep", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 48.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 48.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:MINESWEEP"
                            LuaKey.String "firetolerance", LuaValue.Number 3000.0
                            LuaKey.String "name", LuaValue.String "Seismic charge"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 220.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.6 0.2"
                            LuaKey.String "tolerance", LuaValue.Number 3000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 275.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 15.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MINESWEEP"
                            LuaKey.String "onlytargetcategory", LuaValue.String "MINE"
                        ]
                ]
        ]

    let legrail =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0236
            LuaKey.String "airsightdistance", LuaValue.Number 900.0
            LuaKey.String "maxdec", LuaValue.Number 0.08
            LuaKey.String "energycost", LuaValue.Number 3800.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "buildpic", LuaValue.String "LEGRAIL.DDS"
            LuaKey.String "buildtime", LuaValue.Number 3800.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 7 4"
            LuaKey.String "collisionvolumescales", LuaValue.String "37 39 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 1100.0
            LuaKey.String "maxslope", LuaValue.Number 16.0
            LuaKey.String "speed", LuaValue.Number 46.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "TANK3"
            LuaKey.String "name", LuaValue.String "Railgun"
            LuaKey.String "objectname", LuaValue.String "Units/LEGRAIL.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGRAIL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 525.0
            LuaKey.String "trackoffset", LuaValue.Number 6.0
            LuaKey.String "trackstrength", LuaValue.Number 5.0
            LuaKey.String "tracktype", LuaValue.String "armbull_tracks"
            LuaKey.String "trackwidth", LuaValue.Number 32.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.056
            LuaKey.String "turnrate", LuaValue.Number 250.0
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 1.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.Number 625.0
                    LuaKey.String "unitgroup", LuaValue.String "weaponaa"
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmVehicles"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "1.01370239258 -1.0546875e-05 -0.0623321533203"
                            LuaKey.String "collisionvolumescales", LuaValue.String "34.0520019531 26.7133789063 42.7676696777"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 639.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 180.0
                            LuaKey.String "object", LuaValue.String "Units/legrail_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 320.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 80.0
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
                            LuaKey.Int 1, LuaValue.String "veht1aaok"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "veht1aasel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "aa_railgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "railgun"
                            LuaKey.String "collisionsize", LuaValue.Number 0.7
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.12
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
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
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.33 0.7"
                            LuaKey.String "soundhit", LuaValue.String "mavgun3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lancefire"
                            LuaKey.String "soundstartvolume", LuaValue.Number 13.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3214.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overpenetrate", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 300.0
                                ]
                        ]
                    LuaKey.String "railgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "railgun"
                            LuaKey.String "collisionsize", LuaValue.Number 0.7
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.12
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
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
                            LuaKey.String "range", LuaValue.Number 650.0
                            LuaKey.String "reloadtime", LuaValue.Number 7.5
                            LuaKey.String "rgbcolor", LuaValue.String "0.34 0.64 0.94"
                            LuaKey.String "soundhit", LuaValue.String "mavgun3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lancefire"
                            LuaKey.String "soundstartvolume", LuaValue.Number 13.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3240.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overpenetrate", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 100.0
                                    LuaKey.String "default", LuaValue.Number 200.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "AA_RAILGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "RAILGUN"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 210.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let legscout =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.16659
            LuaKey.String "maxdec", LuaValue.Number 0.33318
            LuaKey.String "energycost", LuaValue.Number 350.0
            LuaKey.String "metalcost", LuaValue.Number 23.0
            LuaKey.String "buildpic", LuaValue.String "LEGSCOUT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 900.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "GROUNDSCOUT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "14 16 14"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "tinyExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "leavetracks", LuaValue.Bool false
            LuaKey.String "health", LuaValue.Number 75.0
            LuaKey.String "maxslope", LuaValue.Number 26.0
            LuaKey.String "speed", LuaValue.Number 160.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "TANK2"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGSCOUT.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGSCOUT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 635.0
            LuaKey.String "trackoffset", LuaValue.Number -2.0
            LuaKey.String "trackstrength", LuaValue.Number 5.0
            LuaKey.String "tracktype", LuaValue.String "armstump_tracks"
            LuaKey.String "trackwidth", LuaValue.Number 20.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 4.224
            LuaKey.String "turnrate", LuaValue.Number 750.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "basename", LuaValue.String "body"
                    LuaKey.String "firingceg", LuaValue.String "barrelshot-small"
                    LuaKey.String "kickback", LuaValue.String "0"
                    LuaKey.String "lumamult", LuaValue.String "1.3"
                    LuaKey.String "model_author", LuaValue.String "Flaka"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "14 16 14"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 111.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 15.0
                            LuaKey.String "object", LuaValue.String "Units/legscout_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 56.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 6.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-tiny"
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
                            LuaKey.Int 1, LuaValue.String "veht1buggyok"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "veht1buggysel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "gun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 13.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.066
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.04
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.5
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Burst-fire Machine Gun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 2.0
                            LuaKey.String "range", LuaValue.Number 169.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mgun3"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 1024.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 720.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 11.0
                                    LuaKey.String "vtol", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "GUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "legamphtank", legamphtank
            "legbar", legbar
            "leggat", leggat
            "leghades", leghades
            "leghelios", leghelios
            "legmlv", legmlv
            "legrail", legrail
            "legscout", legscout
        ]
