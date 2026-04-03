// Auto-generated BAR unit data: Legion/SeaDefenses
namespace BarData.Units

open BarData

module Legion_SeaDefenses =

    let legctl =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "legctl.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5900.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "38 46 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 2200.0
            LuaKey.String "explodeas", LuaValue.String "smallBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 2200.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "objectname", LuaValue.String "Units/legctl.s3o"
            LuaKey.String "script", LuaValue.String "Units/legctl.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 617.0
            LuaKey.String "sonardistance", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "yyyyyooyyooyyyyy"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/SeaDefenses"
                    LuaKey.String "unitgroup", LuaValue.String "sub"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "38 46 40"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 609.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 30.0
                            LuaKey.String "metal", LuaValue.Number 176.0
                            LuaKey.String "object", LuaValue.String "Units/legctl_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 305.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 70.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3C.s3o"
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
                    LuaKey.String "torplauncher", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.6
                            LuaKey.String "bounceslip", LuaValue.Number 0.6
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 1.75
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "groundbounce", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legbasictorpedo.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.2
                            LuaKey.String "name", LuaValue.String "Homing Torpedo Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "numbounce", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundhitvolume", LuaValue.Number 3.0
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 12.0
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 190.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 0.6
                            LuaKey.String "turnrate", LuaValue.Number 64000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 75.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 225.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "def", LuaValue.String "torplauncher"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTHOVER"
                        ]
                ]
        ]

    let legfdrag =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "legfdrag.DDS"
            LuaKey.String "buildtime", LuaValue.Number 400.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "36 14 36"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "crushresistance", LuaValue.Number 250.0
            LuaKey.String "energycost", LuaValue.Number 0.0
            LuaKey.String "explodeas", LuaValue.String "WallExplosionWater"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 4450.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 32.0
            LuaKey.String "metalcost", LuaValue.Number 15.0
            LuaKey.String "minwaterdepth", LuaValue.Number 1.0
            LuaKey.String "objectname", LuaValue.String "Units/legfdrag.s3o"
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/legfdrag.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "WallExplosionWater"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 1.0
            LuaKey.String "sightdistance", LuaValue.Number 1.0
            LuaKey.String "waterline", LuaValue.Number 8.0
            LuaKey.String "yardmap", LuaValue.String "oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "objectify", LuaValue.Bool true
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/SeaDefenses"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table []
                ]
        ]

    let legfhive =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 4.5
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "energycost", LuaValue.Number 9000.0
            LuaKey.String "metalcost", LuaValue.Number 350.0
            LuaKey.String "buildpic", LuaValue.String "legfhive.DDS"
            LuaKey.String "buildtime", LuaValue.Number 7500.0
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
            LuaKey.String "minwaterdepth", LuaValue.Number 12.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/legfhive.s3o"
            LuaKey.String "script", LuaValue.String "Units/leghive.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "turnrate", LuaValue.Number 1.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 4.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armnanotc_aoplane.dds"
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
                                    LuaKey.String "spawns_surface", LuaValue.String "SEA"
                                    LuaKey.String "spawnrate", LuaValue.Number 8.0
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

    let legfmg =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "airsightdistance", LuaValue.Number 650.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 32768.0
            LuaKey.String "energycost", LuaValue.Number 5500.0
            LuaKey.String "metalcost", LuaValue.Number 450.0
            LuaKey.String "buildpic", LuaValue.String "legfmg.DDS"
            LuaKey.String "buildtime", LuaValue.Number 7600.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -8 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "36 90 36"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 3900.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 7500.0
            LuaKey.String "minwaterdepth", LuaValue.Number 5.0
            LuaKey.String "objectname", LuaValue.String "Units/legfmg.s3o"
            LuaKey.String "script", LuaValue.String "Units/legfmg.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 525.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weaponaa"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/SeaDefenses"
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
                            LuaKey.String "object", LuaValue.String "Units/legfmg_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
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
                    LuaKey.String "gatling_gun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
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
                            LuaKey.String "name", LuaValue.String "Rapid-Fire Gatling Gun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 575.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mgun6heavy"
                            LuaKey.String "soundstartvolume", LuaValue.Number 4.5
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
                                    LuaKey.String "default", LuaValue.Number 18.0
                                    LuaKey.String "vtol", LuaValue.Number 18.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "gatling_gun"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                        ]
                ]
        ]

    let legfrl =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "airsightdistance", LuaValue.Number 750.0
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "legfrl.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2200.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "26 52 26"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 1000.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 380.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 90.0
            LuaKey.String "minwaterdepth", LuaValue.Number 2.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/legfrl.s3o"
            LuaKey.String "script", LuaValue.String "Units/legfrl.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 468.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "yardmap", LuaValue.String "wwwwwwwwwwwwwwww"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/SeaDefenses"
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "26 52 26"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 151.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 46.0
                            LuaKey.String "object", LuaValue.String "Units/legfrl_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
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
                            LuaKey.String "reloadtime", LuaValue.Number 1.2
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

    let legnavaldefturret =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "airsightdistance", LuaValue.Number 650.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 32768.0
            LuaKey.String "energycost", LuaValue.Number 7500.0
            LuaKey.String "metalcost", LuaValue.Number 600.0
            LuaKey.String "buildpic", LuaValue.String "legnavaldefturret.DDS"
            LuaKey.String "buildtime", LuaValue.Number 12000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "70 50 70"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "mass", LuaValue.Number 9500.0
            LuaKey.String "health", LuaValue.Number 5190.0
            LuaKey.String "minwaterdepth", LuaValue.Number 18.0
            LuaKey.String "objectname", LuaValue.String "Units/legnavaldefturret.s3o"
            LuaKey.String "script", LuaValue.String "Units/legnavaldefturret.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 650.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooooooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/SeaDefenses"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "70 50 70"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 2500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 50.0
                            LuaKey.String "metal", LuaValue.Number 350.0
                            LuaKey.String "object", LuaValue.String "Units/legnavaldefturret_dead.s3o"
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
                    LuaKey.String "leg_med_anti_naval_salvo_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 100.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.185
                            LuaKey.String "cegtag", LuaValue.String "missiletrailsmall-simple"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "dance", LuaValue.Number 10.0
                            LuaKey.String "flighttime", LuaValue.Number 5.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.2
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.185
                            LuaKey.String "intensity", LuaValue.Number 2.25
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "legmediumrocket.s3o"
                            LuaKey.String "name", LuaValue.String "Dual-Salvo Medium Rocket Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 720.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 11.0
                            LuaKey.String "smoketime", LuaValue.Number 28.0
                            LuaKey.String "smokesize", LuaValue.Number 3.3
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "SabotFire"
                            LuaKey.String "startvelocity", LuaValue.Number 300.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketraildark"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 3000.0
                            LuaKey.String "firetolerance", LuaValue.Number 7000.0
                            LuaKey.String "tolerance", LuaValue.Number 7000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 150.0
                            LuaKey.String "weapontimer", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 95.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "overrange_distance", LuaValue.Number 850.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "leg_med_anti_naval_salvo_rocket"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "burstControlWhenOutOfArc", LuaValue.Number 2.0
                        ]
                ]
        ]

    let legtl =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "legtl.DDS"
            LuaKey.String "collisionvolumescales", LuaValue.String "14 43 30"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "buildtime", LuaValue.Number 3700.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 1500.0
            LuaKey.String "explodeas", LuaValue.String "mediumExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1300.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 170.0
            LuaKey.String "minwaterdepth", LuaValue.Number 12.0
            LuaKey.String "objectname", LuaValue.String "Units/legtl.s3o"
            LuaKey.String "script", LuaValue.String "Units/legtl.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 494.0
            LuaKey.String "sonardistance", LuaValue.Number 400.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "yardmap", LuaValue.String "wwwwwwwww"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "Legion/SeaDefenses"
                    LuaKey.String "unitgroup", LuaValue.String "sub"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumescales", LuaValue.String "14 43 30"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 870.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 70.0
                            LuaKey.String "object", LuaValue.String "Units/legtl_dead.s3o"
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
                            LuaKey.Int 1, LuaValue.String "sharmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "sharmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "torpedo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-tiny"
                            LuaKey.String "collidefriendly", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.55
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 1.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legbasictorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "Torpedo Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 230.0
                            LuaKey.String "tracks", LuaValue.Bool false
                            LuaKey.String "turnrate", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 50.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 280.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 280.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "HOVER NOTSHIP"
                            LuaKey.String "def", LuaValue.String "TORPEDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTHOVER"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "legctl", legctl
            "legfdrag", legfdrag
            "legfhive", legfhive
            "legfmg", legfmg
            "legfrl", legfrl
            "legnavaldefturret", legnavaldefturret
            "legtl", legtl
        ]
