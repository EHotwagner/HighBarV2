// Auto-generated BAR unit data: Legion/Defenses
namespace BarData.Units

open BarData

module Legion_Defenses =

    let legabm =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "energycost", LuaValue.Number 40000.0
            LuaKey.String "metalcost", LuaValue.Number 1500.0
            LuaKey.String "buildpic", LuaValue.String "legabm.DDS"
            LuaKey.String "buildtime", LuaValue.Number 60000.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -19 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "48 78 48"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 3650.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "objectname", LuaValue.String "Units/legabm.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/legabm.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 195.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legabm_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "antinuke"
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -1.36962890629e-05 -0.0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "48.0 37.2831726074 48.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1968.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 980.0
                            LuaKey.String "object", LuaValue.String "Units/legabm_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 984.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 392.0
                            LuaKey.String "object", LuaValue.String "Units/cor5X5D.s3o"
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
                            LuaKey.Int 1, LuaValue.String "loadwtr1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "loadwtr1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "fmd_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 420.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "antimissiletrail"
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "coverage", LuaValue.Number 2000.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 420.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 7500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:antinuke"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 20.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "interceptor", LuaValue.Number 1.0
                            LuaKey.String "metalpershot", LuaValue.Number 150.0
                            LuaKey.String "model", LuaValue.String "leghomingmissile.s3o"
                            LuaKey.String "name", LuaValue.String "ICBM intercepting missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 72000.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 10.0
                            LuaKey.String "smoketime", LuaValue.Number 110.0
                            LuaKey.String "smokesize", LuaValue.Number 27.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "antinukelaunch"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 90.0
                            LuaKey.String "texture1", LuaValue.String "bluenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 7000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 10000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 150.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.5
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 6000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "stockpilelimit", LuaValue.Number 20.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "ALL"
                            LuaKey.String "def", LuaValue.String "FMD_ROCKET"
                        ]
                ]
        ]

    let legacluster =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 15000.0
            LuaKey.String "metalcost", LuaValue.Number 2300.0
            LuaKey.String "buildpic", LuaValue.String "LEGACLUSTER.DDS"
            LuaKey.String "buildtime", LuaValue.Number 25700.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "47 47 47"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.25
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 3700.0
            LuaKey.String "maxslope", LuaValue.Number 12.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/LEGACLUSTER.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGACLUSTER.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "yardmap", LuaValue.String "oooo oooo oooo oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legacluster_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Defenses"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47 47 47"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1764.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 936.0
                            LuaKey.String "object", LuaValue.String "Units/legacluster_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 882.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 3.0
                            LuaKey.String "metal", LuaValue.Number 373.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4B.s3o"
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
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
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
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "plasma", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 50.0
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidneutral", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "starfire_arty"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Pop-Up Long-range g2g Cluster Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1380.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.5
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "cluster_def", LuaValue.String "cluster_munition"
                                    LuaKey.String "cluster_number", LuaValue.Number 8.0
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_priority", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 414.0
                                    LuaKey.String "lboats", LuaValue.Number 414.0
                                    LuaKey.String "subs", LuaValue.Number 132.0
                                    LuaKey.String "vtol", LuaValue.Number 132.0
                                ]
                        ]
                    LuaKey.String "cluster_munition", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 115.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "ministarfire"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Pop-up Long-Range Heavy g2g Cluster Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 100.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 105.0
                                    LuaKey.String "lboats", LuaValue.Number 105.0
                                    LuaKey.String "subs", LuaValue.Number 15.0
                                    LuaKey.String "vtol", LuaValue.Number 15.0
                                ]
                        ]
                    LuaKey.String "plasma_high", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 50.0
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidneutral", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "starfire_arty"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Pop-Up Long-range g2g Cluster Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1380.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.5
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "cluster_def", LuaValue.String "cluster_munition"
                                    LuaKey.String "cluster_number", LuaValue.Number 8.0
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_backup", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 414.0
                                    LuaKey.String "lboats", LuaValue.Number 414.0
                                    LuaKey.String "subs", LuaValue.Number 132.0
                                    LuaKey.String "vtol", LuaValue.Number 132.0
                                ]
                        ]
                    LuaKey.String "smart_trajectory_dummy", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 50.0
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "starfire_arty"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Pop-Up Long-range g2g Cluster Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1380.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.6
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_trajectory_checker", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "PLASMA"
                            LuaKey.String "maindir", LuaValue.String "0 1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 230.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "PLASMA_HIGH"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "smart_trajectory_dummy"
                            LuaKey.String "maindir", LuaValue.String "0 1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 230.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let legapopupdef =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 15000.0
            LuaKey.String "metalcost", LuaValue.Number 750.0
            LuaKey.String "buildpic", LuaValue.String "legapopupdef.dds"
            LuaKey.String "buildtime", LuaValue.Number 17500.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "35 35 35"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.5
            LuaKey.String "explodeas", LuaValue.String "smallBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 2800.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/legapopupdef.s3o"
            LuaKey.String "script", LuaValue.String "Units/legapopupdef.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 598.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legapopupdef_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies (Model), Johnathan Crimson (Proposal)"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/Defenses"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -10 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 20 35"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1519.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 15.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 350.0
                            LuaKey.String "object", LuaValue.String "Units/legapopupdef_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 760.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 140.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-large-impulse"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-tiny"
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
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "advanced_riot_cannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 140.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.9
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large"
                            LuaKey.String "impulsefactor", LuaValue.Number 2.4
                            LuaKey.String "name", LuaValue.String "Heavy Riot Blast Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 730.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.7
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.7 0.25"
                            LuaKey.String "soundhit", LuaValue.String "xplomed1"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "largegun"
                            LuaKey.String "soundhitvolume", LuaValue.Number 14.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 13.0
                            LuaKey.String "separation", LuaValue.Number 2.0
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "size", LuaValue.Number 6.0
                            LuaKey.String "sizeDecay", LuaValue.Number 0.06
                            LuaKey.String "stages", LuaValue.Number 9.0
                            LuaKey.String "alphaDecay", LuaValue.Number 0.1
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 850.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 280.0
                                ]
                        ]
                    LuaKey.String "standard_minigun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 2.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.066
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
                            LuaKey.String "name", LuaValue.String "Dual Rotary Machine Guns"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mgun6heavy"
                            LuaKey.String "soundstartvolume", LuaValue.Number 4.5
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 650.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 3000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1100.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 10.0
                                    LuaKey.String "vtol", LuaValue.Number 10.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "advanced_riot_cannon"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "burstcontrolwhenoutofarc", LuaValue.Number 2.0
                            LuaKey.String "def", LuaValue.String "standard_minigun"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "slaveTo", LuaValue.Number 1.0
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "burstcontrolwhenoutofarc", LuaValue.Number 2.0
                            LuaKey.String "def", LuaValue.String "standard_minigun"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "slaveTo", LuaValue.Number 1.0
                        ]
                ]
        ]

    let legbastion =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "energycost", LuaValue.Number 58000.0
            LuaKey.String "metalcost", LuaValue.Number 4200.0
            LuaKey.String "buildpic", LuaValue.String "legbastion.DDS"
            LuaKey.String "buildtime", LuaValue.Number 79000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 0.0 0.0"
            LuaKey.String "collisionvolumescales", LuaValue.String "102 151 97"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.25
            LuaKey.String "energystorage", LuaValue.Number 1000.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "losemitheight", LuaValue.Number 80.0
            LuaKey.String "health", LuaValue.Number 12000.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/legbastion.s3o"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "radardistance", LuaValue.Number 1200.0
            LuaKey.String "radaremitheight", LuaValue.Number 80.0
            LuaKey.String "script", LuaValue.String "Units/legbastion.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 780.0
            LuaKey.String "yardmap", LuaValue.String "yoooy ooooo ooooo ooooo yoooy"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.Number 1125.0
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legbastion_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Gabs"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 0.0 0.0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "102 151 97"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 5400.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2911.0
                            LuaKey.String "object", LuaValue.String "Units/legbastion_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 2700.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1644.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3E.s3o"
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
                            LuaKey.Int 1, LuaValue.String "doom"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "doom"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "t2heatray", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "camerashake", LuaValue.Number 0.1
                            LuaKey.String "corethickness", LuaValue.Number 0.3
                            LuaKey.String "craterareaofeffect", LuaValue.Number 120.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:heatray-huge"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firetolerance", LuaValue.Number 300.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 6.0
                            LuaKey.String "name", LuaValue.String "Heavy Sustained Sweepfire Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.3
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 1100.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.5 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 1.0 0.5"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heatray3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 38.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 5.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 155.0
                                    LuaKey.String "vtol", LuaValue.Number 15.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "sweepfire", LuaValue.Number 4.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "t2heatray"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let legbombard =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 15000.0
            LuaKey.String "metalcost", LuaValue.Number 750.0
            LuaKey.String "buildpic", LuaValue.String "legbombard.dds"
            LuaKey.String "buildtime", LuaValue.Number 17500.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 18 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.5
            LuaKey.String "explodeas", LuaValue.String "smallBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 2800.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/legbombard.s3o"
            LuaKey.String "script", LuaValue.String "Units/legbombard.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 598.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legbombard_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Hornet"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32 18 32"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1519.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 15.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 350.0
                            LuaKey.String "object", LuaValue.String "Units/legbombard_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 760.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 140.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-medium-impulse"
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
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "bombardier_weapon", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Pop-up heavy g2g grenade launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "separation", LuaValue.Number 1.8
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "sizeDecay", LuaValue.Number 0.06
                            LuaKey.String "stages", LuaValue.Number 14.0
                            LuaKey.String "alphaDecay", LuaValue.Number 0.08
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy1"
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.2
                            LuaKey.String "tolerance", LuaValue.Number 8000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "model", LuaValue.String "legnade.s3o"
                            LuaKey.String "weaponacceleration", LuaValue.Number -0.3
                            LuaKey.String "weapontimer", LuaValue.Number 0.01
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "startvelocity", LuaValue.Number 700.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 100.0
                            LuaKey.String "smoketime", LuaValue.Number 110.0
                            LuaKey.String "smokesize", LuaValue.Number 27.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "missiletrail-grenadesmoke"
                            LuaKey.String "areaofeffect", LuaValue.Number 124.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "avoidground", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.5
                            LuaKey.String "sprayangle", LuaValue.Number 500.0
                            LuaKey.String "accuracy", LuaValue.Number 1.0
                            LuaKey.String "bounce", LuaValue.Number 1.0
                            LuaKey.String "bounceslip", LuaValue.Number 0.6
                            LuaKey.String "bouncerebound", LuaValue.Number 0.4
                            LuaKey.String "numbounce", LuaValue.Number 5.0
                            LuaKey.String "groundbounce", LuaValue.Bool true
                            LuaKey.String "collideenemy", LuaValue.Bool true
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collideground", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "collidefirebase", LuaValue.Bool false
                            LuaKey.String "collideneutral", LuaValue.Bool false
                            LuaKey.String "flighttime", LuaValue.Number 2.05
                            LuaKey.String "proximityPriority", LuaValue.Number 1.0
                            LuaKey.String "gravityaffected", LuaValue.Bool true
                            LuaKey.String "waterbounce", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.8
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 375.0
                                    LuaKey.String "subs", LuaValue.Number 300.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "bombardier_weapon"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 300.0
                        ]
                ]
        ]

    let legcluster =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 11000.0
            LuaKey.String "metalcost", LuaValue.Number 850.0
            LuaKey.String "buildpic", LuaValue.String "LEGCLUSTER.DDS"
            LuaKey.String "buildtime", LuaValue.Number 17400.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "47 47 47"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 2900.0
            LuaKey.String "maxslope", LuaValue.Number 12.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/LEGCLUSTER.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGCLUSTER.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legcluster_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47 47 47"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1764.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 936.0
                            LuaKey.String "object", LuaValue.String "Units/legcluster_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 882.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 3.0
                            LuaKey.String "metal", LuaValue.Number 373.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4B.s3o"
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
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
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
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "plasma", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 75.0
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidneutral", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "starfire_arty"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Long-Range g2g Cluster Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 6.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "cluster_def", LuaValue.String "cluster_munition"
                                    LuaKey.String "cluster_number", LuaValue.Number 5.0
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_priority", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 300.0
                                    LuaKey.String "subs", LuaValue.Number 75.0
                                    LuaKey.String "vtol", LuaValue.Number 75.0
                                ]
                        ]
                    LuaKey.String "cluster_munition", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 115.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "ministarfire"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Cluster Munitions"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 80.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 105.0
                                    LuaKey.String "lboats", LuaValue.Number 105.0
                                    LuaKey.String "subs", LuaValue.Number 25.0
                                    LuaKey.String "vtol", LuaValue.Number 25.0
                                ]
                        ]
                    LuaKey.String "plasma_high", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 75.0
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidneutral", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "starfire_arty"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Long-Range g2g Cluster Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "reloadtime", LuaValue.Number 6.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "cluster_def", LuaValue.String "cluster_munition"
                                    LuaKey.String "cluster_number", LuaValue.Number 5.0
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_backup", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 300.0
                                    LuaKey.String "subs", LuaValue.Number 75.0
                                    LuaKey.String "vtol", LuaValue.Number 75.0
                                ]
                        ]
                    LuaKey.String "smart_trajectory_dummy", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 75.0
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "starfire_arty"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Long-Range g2g Cluster Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_trajectory_checker", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "PLASMA"
                            LuaKey.String "maindir", LuaValue.String "0 1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 230.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "PLASMA_HIGH"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "smart_trajectory_dummy"
                            LuaKey.String "maindir", LuaValue.String "0 1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 230.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let legdrag =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 8.0
            LuaKey.String "buildpic", LuaValue.String "LEGDRAG.DDS"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 22 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "ROCKTEETH"
            LuaKey.String "crushresistance", LuaValue.Number 250.0
            LuaKey.String "explodeas", LuaValue.String "WallExplosionConcrete"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "health", LuaValue.Number 2800.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/legdrag.s3o"
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/legdrag.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "WallExplosionConcrete"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 1.0
            LuaKey.String "sightdistance", LuaValue.Number 1.0
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legdrag_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "objectify", LuaValue.Bool true
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "rockteeth", LuaValue.Table [
                            LuaKey.String "animating", LuaValue.Number 0.0
                            LuaKey.String "animtrans", LuaValue.Number 0.0
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "crushresistance", LuaValue.Number 0.0
                            LuaKey.String "damage", LuaValue.Number 500.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2.0
                            LuaKey.String "object", LuaValue.String "Units/cor1X1A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "shadtrans", LuaValue.Number 1.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table []
                ]
        ]

    let legdtr =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 1550.0
            LuaKey.String "metalcost", LuaValue.Number 290.0
            LuaKey.String "buildpic", LuaValue.String "LEGDTR.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4420.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.33
            LuaKey.String "decoyfor", LuaValue.String "legdrag"
            LuaKey.String "explodeas", LuaValue.String "smallBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000000000.0
            LuaKey.String "health", LuaValue.Number 1610.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/LEGDTR.s3o"
            LuaKey.String "radardistancejam", LuaValue.Number 8.0
            LuaKey.String "script", LuaValue.String "Units/LEGDTR.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 1.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 440.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legdrag_aoplane.dds"
                    LuaKey.String "decoyfor", LuaValue.String "LEGLAW"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "neutral_when_closed", LuaValue.Bool true
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "selectionscalemult", LuaValue.Number 1.0
                    LuaKey.String "subfolder", LuaValue.String "Legion/Defenses"
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "autoreclaimable", LuaValue.Number 0.0
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 0.0149960864258 0.116882324219"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32.042388916 19.5953521729 32.6287231445"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 600.0
                            LuaKey.String "featuredead", LuaValue.String "ROCKTEETH"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 177.0
                            LuaKey.String "object", LuaValue.String "Units/legdrag_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "rockteeth", LuaValue.Table [
                            LuaKey.String "animating", LuaValue.Number 0.0
                            LuaKey.String "animtrans", LuaValue.Number 0.0
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 500.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2.0
                            LuaKey.String "object", LuaValue.String "Units/cor1X1A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "shadtrans", LuaValue.Number 1.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-medium-impulse"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "servmed2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servmed2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corlevlr_weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 140.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.9
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large"
                            LuaKey.String "impulsefactor", LuaValue.Number 2.0
                            LuaKey.String "name", LuaValue.String "Area Control Riot Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "soundhit", LuaValue.String "corlevlrhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "largegun"
                            LuaKey.String "soundhitvolume", LuaValue.Number 12.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 14.0
                            LuaKey.String "separation", LuaValue.Number 2.0
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "size", LuaValue.Number 3.0
                            LuaKey.String "sizeDecay", LuaValue.Number 0.07
                            LuaKey.String "stages", LuaValue.Number 10.0
                            LuaKey.String "alphaDecay", LuaValue.Number 0.1
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 240.0
                                    LuaKey.String "commanders", LuaValue.Number 375.0
                                    LuaKey.String "subs", LuaValue.Number 90.0
                                    LuaKey.String "vtol", LuaValue.Number 35.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORLEVLR_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let legflak =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "airsightdistance", LuaValue.Number 1000.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 13000.0
            LuaKey.String "metalcost", LuaValue.Number 820.0
            LuaKey.String "buildpic", LuaValue.String "LEGFLAK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 19000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "55 85 55"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1750.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGFLAK.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGFLAK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 525.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legflak_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/defenses"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55 55 55"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 945.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/legflak_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 473.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 200.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-flak"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "leg_t2_microflak", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1000.0
                            LuaKey.String "areaofeffect", LuaValue.Number 44.0
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.02
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "flaktrailaamg"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 35.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:flakshard"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Dual Rotary Microflak Cannons"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.166
                            LuaKey.String "size", LuaValue.Number 0.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.08
                            LuaKey.String "soundhit", LuaValue.String "flakhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "flakfire"
                            LuaKey.String "stages", LuaValue.Number 0.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 58.0
                                ]
                            LuaKey.String "rgbcolor", LuaValue.Table [
                                    LuaKey.Int 1, LuaValue.Number 1.0
                                    LuaKey.Int 2, LuaValue.Number 0.33
                                    LuaKey.Int 3, LuaValue.Number 0.7
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR LIGHTAIRSCOUT"
                            LuaKey.String "burstcontrolwhenoutofarc", LuaValue.Number 2.0
                            LuaKey.String "def", LuaValue.String "leg_t2_microflak"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let legforti =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 500.0
            LuaKey.String "metalcost", LuaValue.Number 40.0
            LuaKey.String "buildpic", LuaValue.String "legforti.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1000.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 50 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "ROCKTEETHX"
            LuaKey.String "crushresistance", LuaValue.Number 1000.0
            LuaKey.String "explodeas", LuaValue.String "WallExplosionConcreteXL"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "health", LuaValue.Number 8900.0
            LuaKey.String "maxslope", LuaValue.Number 24.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "units/legforti.s3o"
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "units/legforti.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "WallExplosionConcrete"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 1.0
            LuaKey.String "sightdistance", LuaValue.Number 1.0
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legforti_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "objectify", LuaValue.Bool true
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "legion/Defenses"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "rockteethx", LuaValue.Table [
                            LuaKey.String "animating", LuaValue.Number 0.0
                            LuaKey.String "animtrans", LuaValue.Number 0.0
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "crushresistance", LuaValue.Number 0.0
                            LuaKey.String "damage", LuaValue.Number 3000.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 7.0
                            LuaKey.String "object", LuaValue.String "Units/cor1X1A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "shadtrans", LuaValue.Number 1.0
                        ]
                ]
        ]

    let leggatet3 =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "buildpic", LuaValue.String "LEGGATET3.DDS"
            LuaKey.String "buildtime", LuaValue.Number 261000.0
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "NOWEAPON"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "88 70 88"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.333
            LuaKey.String "energycost", LuaValue.Number 216000.0
            LuaKey.String "energystorage", LuaValue.Number 4000.0
            LuaKey.String "exemptcategory", LuaValue.String "WEAPON"
            LuaKey.String "explodeas", LuaValue.String "fusionExplosion"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 18000.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 14500.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "objectname", LuaValue.String "Units/LEGGATET3.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGGATET3.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "fusionExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/leggatet3_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Protar"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "shield_color_mult", LuaValue.Number 25.0
                    LuaKey.String "shield_power", LuaValue.Number 49400.0
                    LuaKey.String "shield_radius", LuaValue.Number 710.0
                    LuaKey.String "subfolder", LuaValue.String "Legion/Defenses"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "88 60 88"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 15000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 9062.0
                            LuaKey.String "object", LuaValue.String "Units/leggatet3_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 9000.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 3866.0
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
                            LuaKey.Int 1, LuaValue.String "drone1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "drone1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "repulsor", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 710.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.17
                                    LuaKey.String "armortype", LuaValue.String "shields"
                                    LuaKey.String "exterior", LuaValue.Bool true
                                    LuaKey.String "energyupkeep", LuaValue.Number 0.0
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 1015.0
                                    LuaKey.String "power", LuaValue.Number 49400.0
                                    LuaKey.String "powerregen", LuaValue.Number 520.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 2250.0
                                    LuaKey.String "radius", LuaValue.Number 710.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 15438.0
                                    LuaKey.String "visiblerepulse", LuaValue.Bool true
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.17
                                        ]
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "REPULSOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let leghive =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 4.5
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "energycost", LuaValue.Number 9000.0
            LuaKey.String "metalcost", LuaValue.Number 350.0
            LuaKey.String "buildpic", LuaValue.String "leghive.DDS"
            LuaKey.String "buildtime", LuaValue.Number 6600.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -7 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "44 23 44"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "mass", LuaValue.Number 700.0
            LuaKey.String "health", LuaValue.Number 1200.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/leghive.s3o"
            LuaKey.String "script", LuaValue.String "Units/leghive.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "turnrate", LuaValue.Number 1.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/leghive_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Zephyr"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "legacyname", LuaValue.String "Gaat Gun"
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 1.0
                    LuaKey.String "childreninheritxp", LuaValue.String "DRONE"
                    LuaKey.String "parentsinheritxp", LuaValue.String "DRONE"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_noair_"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "38 95 38"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 700.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 130.0
                            LuaKey.String "object", LuaValue.String "Units/leghive_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 400.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 65.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "twractv3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twractv3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "plasma", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 4.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String ""
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "HeavyCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "metalpershot", LuaValue.Number 15.0
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "range", LuaValue.Number 1100.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
                            LuaKey.String "size", LuaValue.Number 0.0
                            LuaKey.String "soundhit", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String ""
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "carried_unit", LuaValue.String "legdrone"
                                    LuaKey.String "engagementrange", LuaValue.Number 1100.0
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND"
                                    LuaKey.String "spawnrate", LuaValue.Number 10.0
                                    LuaKey.String "maxunits", LuaValue.Number 6.0
                                    LuaKey.String "startingdronecount", LuaValue.Number 3.0
                                    LuaKey.String "energycost", LuaValue.Number 500.0
                                    LuaKey.String "metalcost", LuaValue.Number 15.0
                                    LuaKey.String "controlradius", LuaValue.Number 1000.0
                                    LuaKey.String "deathdecayrate", LuaValue.Number 20.0
                                    LuaKey.String "carrierdeaththroe", LuaValue.String "release"
                                    LuaKey.String "dockingarmor", LuaValue.Number 0.2
                                    LuaKey.String "dockinghealrate", LuaValue.Number 20.0
                                    LuaKey.String "docktohealthreshold", LuaValue.Number 75.0
                                    LuaKey.String "enabledocking", LuaValue.Bool true
                                    LuaKey.String "dockingHelperSpeed", LuaValue.Number 5.0
                                    LuaKey.String "dockingpieces", LuaValue.String "4 5 6 7 8 9"
                                    LuaKey.String "dockingradius", LuaValue.Number 80.0
                                    LuaKey.String "stockpilelimit", LuaValue.Number 6.0
                                    LuaKey.String "stockpilemetal", LuaValue.Number 15.0
                                    LuaKey.String "stockpileenergy", LuaValue.Number 500.0
                                    LuaKey.String "dronesusestockpile", LuaValue.Bool true
                                    LuaKey.String "cobdockparam", LuaValue.Number 1.0
                                    LuaKey.String "cobundockparam", LuaValue.Number 1.0
                                    LuaKey.String "dronedocktime", LuaValue.Number 3.0
                                    LuaKey.String "droneairtime", LuaValue.Number 60.0
                                    LuaKey.String "droneammo", LuaValue.Number 12.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "PLASMA"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let leglht =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 32000.0
            LuaKey.String "energycost", LuaValue.Number 550.0
            LuaKey.String "metalcost", LuaValue.Number 70.0
            LuaKey.String "buildpic", LuaValue.String "LEGLHT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2200.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -7 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 61 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "mass", LuaValue.Number 5100.0
            LuaKey.String "health", LuaValue.Number 550.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/LEGLHT.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGLHT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 494.0
            LuaKey.String "yardmap", LuaValue.String "oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/leglht_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "basename", LuaValue.String "base"
                    LuaKey.String "cannon1name", LuaValue.String "barrel"
                    LuaKey.String "driftratio", LuaValue.String "0.6"
                    LuaKey.String "firingceg", LuaValue.String "barrelshot-tiny"
                    LuaKey.String "flare1name", LuaValue.String "flare"
                    LuaKey.String "kickback", LuaValue.String "-2.0"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -7 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32 61 32"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 351.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 55.0
                            LuaKey.String "object", LuaValue.String "Units/LEGLHT_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 176.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 22.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "lltok"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "lltselect"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "heat_ray", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.45
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.0
                            LuaKey.String "leadlimit", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Light g2g Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 430.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.1
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.55 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 1.0 0.5"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.66
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 270.0
                                    LuaKey.String "default", LuaValue.Number 200.0
                                    LuaKey.String "vtol", LuaValue.Number 25.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
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

    let leglraa =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "airsightdistance", LuaValue.Number 2400.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 36000.0
            LuaKey.String "metalcost", LuaValue.Number 1600.0
            LuaKey.String "buildpic", LuaValue.String "LEGLRAA.DDS"
            LuaKey.String "buildtime", LuaValue.Number 28000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "63 57 63"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 1670.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGLRAA.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGLRAA.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/leglraa_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 7.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 7.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/Defenses"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "63 57 63"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 942.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1145.0
                            LuaKey.String "object", LuaValue.String "Units/leglraa_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 471.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 458.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4A.s3o"
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
                    LuaKey.String "activate", LuaValue.String "targon2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "deactivate", LuaValue.String "targoff2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "working", LuaValue.String "targsel2"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "targsel2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "cor_advsam", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 425.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa-large"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 425.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.75
                            LuaKey.String "energypershot", LuaValue.Number 1800.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-aa"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "flighttime", LuaValue.Number 2.2
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "corscreamermissile.s3o"
                            LuaKey.String "name", LuaValue.String "Long-range heavy g2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 2400.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.8
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 3.0
                            LuaKey.String "smoketime", LuaValue.Number 24.0
                            LuaKey.String "smokesize", LuaValue.Number 11.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.9
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "impact"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "aarocket"
                            LuaKey.String "soundhitvolume", LuaValue.Number 8.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 8.0
                            LuaKey.String "sprayangle", LuaValue.Number 10000.0
                            LuaKey.String "startvelocity", LuaValue.Number 1400.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 14.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaaflak"
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 0.55
                            LuaKey.String "turnrate", LuaValue.Number 99000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 1000.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1850.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 750.0
                                ]
                        ]
                    LuaKey.String "railgunt2", LuaValue.Table [
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "areaofeffect", LuaValue.Number 100.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "railgun"
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.12
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "energypershot", LuaValue.Number 1800.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 2.0
                            LuaKey.String "intensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Heavy Anti-Air Railgun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 2000.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.33 0.7"
                            LuaKey.String "soundhit", LuaValue.String "impact"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "railgun3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 80.0
                            LuaKey.String "thickness", LuaValue.Number 4.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3529.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 700.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "railgunt2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let leglrpc =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 32700.0
            LuaKey.String "energycost", LuaValue.Number 76000.0
            LuaKey.String "metalcost", LuaValue.Number 5200.0
            LuaKey.String "buildpic", LuaValue.String "LEGLRPC.DDS"
            LuaKey.String "buildtime", LuaValue.Number 93000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "health", LuaValue.Number 4450.0
            LuaKey.String "maxslope", LuaValue.Number 12.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGLRPC.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGLRPC.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/leglrpc_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_nolrpc_"
                    LuaKey.String "canareaattack", LuaValue.Number 1.0
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/Defenses"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "3.15924835205 -0.787798413086 6.6563873291"
                            LuaKey.String "collisionvolumescales", LuaValue.String "81.6838531494 113.772003174 72.5632324219"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2520.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 2720.0
                            LuaKey.String "object", LuaValue.String "Units/leglrpc_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 1260.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1088.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3E.s3o"
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
                            LuaKey.Int 1, LuaValue.String "servlrg3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servlrg3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "lrpc", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 300.0
                            LuaKey.String "sprayangle", LuaValue.Number 150.0
                            LuaKey.String "areaofeffect", LuaValue.Number 135.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "starfire-small"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 116.0
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.4
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 6000.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:starfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 8.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "leadbonus", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "legbomb.s3o"
                            LuaKey.String "name", LuaValue.String "Long-Range g2g Heavy Cluster Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 4800.0
                            LuaKey.String "reloadtime", LuaValue.Number 18.0
                            LuaKey.String "soundhit", LuaValue.String "lrpcexplo"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot3"
                            LuaKey.String "soundhitvolume", LuaValue.Number 38.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 24.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1100.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "cluster_def", LuaValue.String "cluster_munition"
                                    LuaKey.String "cluster_number", LuaValue.Number 6.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 600.0
                                    LuaKey.String "shields", LuaValue.Number 300.0
                                    LuaKey.String "subs", LuaValue.Number 120.0
                                ]
                        ]
                    LuaKey.String "cluster_munition", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 115.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "ministarfire"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Plasma Burst"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "maxvelocity", LuaValue.Number 720.0
                            LuaKey.String "range", LuaValue.Number 110.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                    LuaKey.String "subs", LuaValue.Number 25.0
                                    LuaKey.String "vtol", LuaValue.Number 25.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "LRPC"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let leglupara =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "airsightdistance", LuaValue.Number 1000.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 65536.0
            LuaKey.String "energycost", LuaValue.Number 8200.0
            LuaKey.String "metalcost", LuaValue.Number 900.0
            LuaKey.String "buildpic", LuaValue.String "LEGLUPARA.DDS"
            LuaKey.String "buildtime", LuaValue.Number 12500.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -5 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "45 65 45"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 4000.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGLUPARA.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGLUPARA.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 380.0
            LuaKey.String "yardmap", LuaValue.String "oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/leglupara_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/defenses"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55 85 55"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 1560.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 370.0
                            LuaKey.String "object", LuaValue.String "Units/leglupara_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 780.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 150.0
                            LuaKey.String "object", LuaValue.String "Units/arm2x2c.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-flak"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "legflak_gun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1000.0
                            LuaKey.String "sprayangle", LuaValue.Number 200.0
                            LuaKey.String "areaofeffect", LuaValue.Number 150.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.01
                            LuaKey.String "cegtag", LuaValue.String "flaktrailaa"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 192.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:flak"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "mygravity", LuaValue.Number 0.01
                            LuaKey.String "name", LuaValue.String "Medium g2a Flak Blunderbuss"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 1125.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.8
                            LuaKey.String "soundhit", LuaValue.String "flakhit2"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "flakfire"
                            LuaKey.String "soundhitvolume", LuaValue.Number 7.5
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.0
                            LuaKey.String "stages", LuaValue.Number 0.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 255.0
                                ]
                            LuaKey.String "rgbcolor", LuaValue.Table [
                                    LuaKey.Int 1, LuaValue.Number 1.0
                                    LuaKey.Int 2, LuaValue.Number 0.33
                                    LuaKey.Int 3, LuaValue.Number 0.7
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "LEGFLAK_GUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let legmg =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "airsightdistance", LuaValue.Number 650.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 32768.0
            LuaKey.String "energycost", LuaValue.Number 5500.0
            LuaKey.String "metalcost", LuaValue.Number 380.0
            LuaKey.String "buildpic", LuaValue.String "legmg.DDS"
            LuaKey.String "buildtime", LuaValue.Number 7600.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "36 80 36"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "mass", LuaValue.Number 7500.0
            LuaKey.String "health", LuaValue.Number 2200.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGMG.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGMG.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 525.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legmg_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weaponaa"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandDefenceOffence"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-1.45989990234 -3.69362253418 0.310646057129"
                            LuaKey.String "collisionvolumescales", LuaValue.String "48.9197998047 59.9625549316 37.0396270752"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 774.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 50.0
                            LuaKey.String "metal", LuaValue.Number 114.0
                            LuaKey.String "object", LuaValue.String "Units/legmg_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 387.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 46.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2A.s3o"
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
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "servmed2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servmed2"
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
                            LuaKey.String "duration", LuaValue.Number 0.05
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Heavy Rapid-fire Machine Gun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 575.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mgun6heavy"
                            LuaKey.String "soundstartvolume", LuaValue.Number 3.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 968.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 958.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 17.0
                                    LuaKey.String "vtol", LuaValue.Number 17.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "armmg_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                        ]
                ]
        ]

    let legperdition =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "legperdition.DDS"
            LuaKey.String "buildtime", LuaValue.Number 62000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "80 70 80"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 15000.0
            LuaKey.String "explodeas", LuaValue.String "nukeBuilding"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 4000.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 1250.0
            LuaKey.String "objectname", LuaValue.String "Units/legperdition.s3o"
            LuaKey.String "script", LuaValue.String "Units/legperdition.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "nukeBuildingSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legperdition_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Hornet, Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "selectionscalemult", LuaValue.Number 1.0
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_notacnukes_"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "80 70 80"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 1920.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 445.0
                            LuaKey.String "object", LuaValue.String "Units/legperdition_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 960.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 178.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
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
                            LuaKey.Int 1, LuaValue.String "servroc1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servroc1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "napalmmissile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 425.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "burnflame-xs"
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 360.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.75
                            LuaKey.String "energypershot", LuaValue.Number 13000.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:fire-explosion-large"
                            LuaKey.String "flamegfxtime", LuaValue.Number 1.0
                            LuaKey.String "gravityaffected", LuaValue.Bool true
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 350.0
                            LuaKey.String "model", LuaValue.String "legbomb.s3o"
                            LuaKey.String "name", LuaValue.String "Long-Range Tactical Hellfire Napalm Shell"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 2300.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeperiod", LuaValue.Number 9.0
                            LuaKey.String "smokesize", LuaValue.Number 14.0
                            LuaKey.String "smoketime", LuaValue.Number 60.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplolrg4"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy6"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 50.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "railguntrail"
                            LuaKey.String "tolerance", LuaValue.Number 9000.0
                            LuaKey.String "turnrate", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 220.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 550.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "area_onhit_ceg", LuaValue.String "fire-area-150-repeat"
                                    LuaKey.String "area_onhit_damage", LuaValue.Number 120.0
                                    LuaKey.String "area_onhit_damageceg", LuaValue.String "burnflamexl-gen"
                                    LuaKey.String "area_onhit_range", LuaValue.Number 150.0
                                    LuaKey.String "area_onhit_resistance", LuaValue.String "fire"
                                    LuaKey.String "area_onhit_time", LuaValue.Number 15.0
                                    LuaKey.String "stockpilelimit", LuaValue.Number 10.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 700.0
                                    LuaKey.String "default", LuaValue.Number 1200.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTLAND"
                            LuaKey.String "def", LuaValue.String "napalmmissile"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let legrhapsis =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "airsightdistance", LuaValue.Number 850.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 6500.0
            LuaKey.String "metalcost", LuaValue.Number 280.0
            LuaKey.String "buildpic", LuaValue.String "LEGRHAPSIS.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4700.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 40 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energyupkeep", LuaValue.Number 5.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1900.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGRHAPSIS.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGRHAPSIS.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 375.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legrhapsis_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/Defenses"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "28 40 28"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 1500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 10.0
                            LuaKey.String "metal", LuaValue.Number 190.0
                            LuaKey.String "object", LuaValue.String "Units/legrhapsis_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 750.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "metal", LuaValue.Number 100.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "burst_aa_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.005
                            LuaKey.String "dance", LuaValue.Number 150.0
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 72.0
                            LuaKey.String "flighttime", LuaValue.Number 2.5
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Advanced g2a Salvo Missile Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 840.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 7.0
                            LuaKey.String "smoketime", LuaValue.Number 10.0
                            LuaKey.String "smokesize", LuaValue.Number 1.7
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 800.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa3"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 300.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 13.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "BURST_AA_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let legrl =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "airsightdistance", LuaValue.Number 700.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 850.0
            LuaKey.String "metalcost", LuaValue.Number 80.0
            LuaKey.String "buildpic", LuaValue.String "LEGRL.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1750.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "26 52 26"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "mass", LuaValue.Number 5100.0
            LuaKey.String "health", LuaValue.Number 335.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGRL.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGRL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legrl_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/Defenses"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "26 52 26"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 180.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 49.0
                            LuaKey.String "object", LuaValue.String "Units/legrl_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 90.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 20.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3D.s3o"
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
                            LuaKey.Int 1, LuaValue.String "kbcormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbcorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "legrl_missile", LuaValue.Table [
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
                            LuaKey.String "flighttime", LuaValue.Number 1.9
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Light g2a Missile Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 765.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.7
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 6.0
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smokesize", LuaValue.Number 4.8
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "rockhvy2"
                            LuaKey.String "startvelocity", LuaValue.Number 400.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 63000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 150.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 750.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 115.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOWEAPON LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "LEGRL_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let legsilo =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 82000.0
            LuaKey.String "metalcost", LuaValue.Number 7700.0
            LuaKey.String "buildpic", LuaValue.String "LEGSILO.DDS"
            LuaKey.String "buildtime", LuaValue.Number 181000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 18 -2"
            LuaKey.String "collisionvolumescales", LuaValue.String "90 38 84"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "nukeBuilding"
            LuaKey.String "footprintx", LuaValue.Number 7.0
            LuaKey.String "footprintz", LuaValue.Number 7.0
            LuaKey.String "health", LuaValue.Number 6200.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGSILO.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/LEGSILO.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "nukeBuildingSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooooooooooooooooooooooooooooooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legsilo_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 10.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 10.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "nuke"
                    LuaKey.String "model_author", LuaValue.String "Tharsy"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -0.0182740600586 2.87522888184"
                            LuaKey.String "collisionvolumescales", LuaValue.String "75.0 23.7250518799 77.7504577637"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 3336.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 4672.0
                            LuaKey.String "object", LuaValue.String "Units/legsilo_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 1668.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1869.0
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
                            LuaKey.Int 1, LuaValue.String "servroc1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servroc1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "legicbm", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 1920.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "NUKETRAIL"
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 1920.0
                            LuaKey.String "craterboost", LuaValue.Number 2.4
                            LuaKey.String "cratermult", LuaValue.Number 1.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "energypershot", LuaValue.Number 187500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:newnukecor"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 400.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "metalpershot", LuaValue.Number 1500.0
                            LuaKey.String "model", LuaValue.String "legicbm.s3o"
                            LuaKey.String "name", LuaValue.String "Intercontinental Thermonuclear Ballistic Missile"
                            LuaKey.String "range", LuaValue.Number 72000.0
                            LuaKey.String "reloadtime", LuaValue.Number 30.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 10.0
                            LuaKey.String "smoketime", LuaValue.Number 130.0
                            LuaKey.String "smokesize", LuaValue.Number 28.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.85
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "nukecor"
                            LuaKey.String "soundhitwet", LuaValue.String "nukewater"
                            LuaKey.String "soundstart", LuaValue.String "nukelaunch"
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 56.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 20.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 180.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "railguntrail"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "targetable", LuaValue.Number 1.0
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turnrate", LuaValue.Number 5500.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 100.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.5
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1600.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "place_target_on_ground", LuaValue.String "true"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 10.0
                                    LuaKey.String "nuclear", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 2500.0
                                    LuaKey.String "default", LuaValue.Number 11500.0
                                ]
                        ]
                    LuaKey.String "nuclear_launch", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Nuclear Launch"
                            LuaKey.String "range", LuaValue.Number 0.0
                            LuaKey.String "reloadtime", LuaValue.Number 30.0
                            LuaKey.String "soundhit", LuaValue.String "nukelaunchalarm"
                            LuaKey.String "soundhitvolume", LuaValue.Number 50.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turnrate", LuaValue.Number 10000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 101.0
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 100.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "LEGICBM"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "NUCLEAR_LAUNCH"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let legstarfall =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 29096.0
            LuaKey.String "energycost", LuaValue.Number 720000.0
            LuaKey.String "metalcost", LuaValue.Number 63000.0
            LuaKey.String "buildpic", LuaValue.String "legstarfall.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1400000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "125 135 120"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "customfusionexplo"
            LuaKey.String "hightrajectory", LuaValue.Number 1.0
            LuaKey.String "firestate", LuaValue.Number 0.0
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 26000.0
            LuaKey.String "maxslope", LuaValue.Number 13.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/legstarfall.s3o"
            LuaKey.String "script", LuaValue.String "Units/legstarfall.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "advancedFusionExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 700.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legstarfall_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_nolrpc_noendgamelrpc_"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/Defenses"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "125 100 120"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 26000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 7.0
                            LuaKey.String "footprintz", LuaValue.Number 7.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 25000.0
                            LuaKey.String "object", LuaValue.String "Units/legstarfall_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "80 10 80"
                            LuaKey.String "damage", LuaValue.Number 12000.0
                            LuaKey.String "footprintx", LuaValue.Number 7.0
                            LuaKey.String "footprintz", LuaValue.Number 7.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 12000.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 0, LuaValue.String "custom:barrelshot-huge"
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-large-impulse"
                            LuaKey.Int 2, LuaValue.String "custom:genericshellexplosion-tiny"
                            LuaKey.Int 3, LuaValue.String "custom:laserhit-small-yellow"
                            LuaKey.Int 4, LuaValue.String "custom:railgun-old"
                            LuaKey.Int 5, LuaValue.String "custom:smokegen-part"
                            LuaKey.Int 6, LuaValue.String "custom:smokegen-part2"
                            LuaKey.Int 7, LuaValue.String "custom:ventair-puff"
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
                            LuaKey.Int 1, LuaValue.String "servlrg4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servlrg4"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "starfire", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 63.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03
                            LuaKey.String "sprayangle", LuaValue.Number 500.0
                            LuaKey.String "highTrajectory", LuaValue.Number 1.0
                            LuaKey.String "cegtag", LuaValue.String "starfire"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.95
                            LuaKey.String "energypershot", LuaValue.Number 360000.0
                            LuaKey.String "fireTolerance", LuaValue.Number 364.0
                            LuaKey.String "tolerance", LuaValue.Number 364.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:starfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Very Long-Range High-Trajectory 63-Salvo Plasma Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 6100.0
                            LuaKey.String "reloadtime", LuaValue.Number 14.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "rflrpcexplo"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 14.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "windup", LuaValue.Number 5.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 600.0
                                    LuaKey.String "shields", LuaValue.Number 240.0
                                    LuaKey.String "subs", LuaValue.Number 50.0
                                ]
                        ]
                    LuaKey.String "energycharger", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String ""
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Plasma Volley Energy Charger (supplies energy to Starfall cannon)"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "range", LuaValue.Number 1.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "size", LuaValue.Number 0.0
                            LuaKey.String "soundhit", LuaValue.String "starfallchargup"
                            LuaKey.String "soundhitwet", LuaValue.String "starfallchargup"
                            LuaKey.String "soundstart", LuaValue.String "starfallchargup"
                            LuaKey.String "soundstartvolume", LuaValue.Number 124.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "starfire"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 1.0
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "energycharger"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
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
