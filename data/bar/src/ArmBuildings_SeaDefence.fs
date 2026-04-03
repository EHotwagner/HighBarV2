// Auto-generated BAR unit data: ArmBuildings/SeaDefence
namespace BarData.Units

open BarData

module ArmBuildings_SeaDefence =

    let armatl =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "ARMATL.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9260.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 8500.0
            LuaKey.String "explodeas", LuaValue.String "smallBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 2800.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 1000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 12.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMATL.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMATL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 585.0
            LuaKey.String "sonardistance", LuaValue.Number 400.0
            LuaKey.String "waterline", LuaValue.Number 2.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/SeaDefence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "sub"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "4.35404205322 2.4731445313e-05 -0.341720581055"
                            LuaKey.String "collisionvolumescales", LuaValue.String "38.3841400146 24.7794494629 44.2891235352"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 312.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 548.0
                            LuaKey.String "object", LuaValue.String "Units/armatl_dead.s3o"
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
                            LuaKey.Int 1, LuaValue.String "torpadv2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "torpadv2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armatl_torpedo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 32.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-small"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-uw"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "torpedo.s3o"
                            LuaKey.String "name", LuaValue.String "Heavy long-range homing torpedo launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 915.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.166
                            LuaKey.String "soundhit", LuaValue.String "xplodep1"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 80.0
                            LuaKey.String "tolerance", LuaValue.Number 1167.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 60.0
                            LuaKey.String "weapontimer", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 380.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 780.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "HOVER NOTSHIP"
                            LuaKey.String "def", LuaValue.String "ARMATL_TORPEDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTHOVER"
                        ]
                ]
        ]

    let armdl =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "ARMDL.DDS"
            LuaKey.String "buildtime", LuaValue.Number 6000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "44 55 44"
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
            LuaKey.String "objectname", LuaValue.String "Units/ARMDL.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMDL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 617.0
            LuaKey.String "sonardistance", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "yyyyyooyyooyyyyy"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armdl_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/SeaDefence"
                    LuaKey.String "unitgroup", LuaValue.String "sub"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "2.08366394043 -8.3923 4.63167572021"
                            LuaKey.String "collisionvolumescales", LuaValue.String "46.5937194824 41.0 51.689743042"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 609.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 30.0
                            LuaKey.String "metal", LuaValue.Number 176.0
                            LuaKey.String "object", LuaValue.String "Units/armdl_dead.s3o"
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
                    LuaKey.String "coax_depthcharge", LuaValue.Table [
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
                            LuaKey.String "model", LuaValue.String "cordepthcharge.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.2
                            LuaKey.String "name", LuaValue.String "Depthcharge launcher"
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
                            LuaKey.String "def", LuaValue.String "COAX_DEPTHCHARGE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTHOVER"
                        ]
                ]
        ]

    let armfflak =
        LuaValue.Table [
            LuaKey.String "airsightdistance", LuaValue.Number 1000.0
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "ARMFFLAK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 21900.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -10 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "42 64 42"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 23000.0
            LuaKey.String "explodeas", LuaValue.String "mediumExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1920.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 850.0
            LuaKey.String "minwaterdepth", LuaValue.Number 5.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMFFLAK.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMFFLAK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "waterline", LuaValue.Number 0.3
            LuaKey.String "yardmap", LuaValue.String "wwwwwwwww"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/SeaDefence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.25456237793 -3.1726487793 0.162696838379"
                            LuaKey.String "collisionvolumescales", LuaValue.String "33.5091247559 30.6275024414 44.9046173096"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1038.0
                            LuaKey.String "footprintx", LuaValue.Number 1.0
                            LuaKey.String "footprintz", LuaValue.Number 1.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 525.0
                            LuaKey.String "object", LuaValue.String "Units/armfflak_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-medium-aa"
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
                    LuaKey.String "armflak_gun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1000.0
                            LuaKey.String "areaofeffect", LuaValue.Number 192.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
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
                            LuaKey.String "name", LuaValue.String "Heavy g2a flak cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 775.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.53333
                            LuaKey.String "size", LuaValue.Number 4.5
                            LuaKey.String "sizedecay", LuaValue.Number 0.08
                            LuaKey.String "soundhit", LuaValue.String "flakhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "flakfire"
                            LuaKey.String "stages", LuaValue.Number 8.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2450.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 250.0
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
                            LuaKey.String "def", LuaValue.String "ARMFLAK_GUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let armfhlt =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "ARMFHLT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9670.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -10 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "46 74 46"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 6200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 4250.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 470.0
            LuaKey.String "minwaterdepth", LuaValue.Number 2.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/ARMFHLT.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMFHLT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 630.0
            LuaKey.String "waterline", LuaValue.Number 3.0
            LuaKey.String "yardmap", LuaValue.String "wwwwwwwwwwwwwwww"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/SeaDefence"
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -3.6047363281e-05 -7.62939453125e-06"
                            LuaKey.String "collisionvolumescales", LuaValue.String "50.0 45.7867279053 45.9999847412"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2302.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 341.0
                            LuaKey.String "object", LuaValue.String "Units/armfhlt_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
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
                    LuaKey.String "armfhlt_laser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.15
                            LuaKey.String "corethickness", LuaValue.Number 0.18
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 40.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-green"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "HighEnergyLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 630.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "rgbcolor", LuaValue.String "0 1 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Lasrmas2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.4
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 300.0
                                    LuaKey.String "default", LuaValue.Number 210.0
                                    LuaKey.String "vtol", LuaValue.Number 52.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMFHLT_LASER"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armfrock =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "airsightdistance", LuaValue.Number 750.0
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "ARMFROCK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5810.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "36 59 36"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 5700.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 1330.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 360.0
            LuaKey.String "minwaterdepth", LuaValue.Number 2.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMFROCK.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMFROCK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 468.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "yardmap", LuaValue.String "wwwwwwwwwwwwwwww"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/SeaDefence"
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.10124206543 -0.0500075439453 1.15520477295"
                            LuaKey.String "collisionvolumescales", LuaValue.String "41.2024536133 67.0857849121 50.3104095459"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1280.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 240.0
                            LuaKey.String "object", LuaValue.String "Units/armfrt_dead.s3o"
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
                    LuaKey.String "aamissile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 72.0
                            LuaKey.String "flighttime", LuaValue.Number 2.5
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Pop-up rapid-fire g2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 840.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.7
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "smokeperiod", LuaValue.Number 8.0
                            LuaKey.String "smokesize", LuaValue.Number 4.2
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 1.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa3"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 1500.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1200.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 150.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "AAMISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let armfrt =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "airsightdistance", LuaValue.Number 750.0
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "ARMFRT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2200.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "36 74 36"
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
            LuaKey.String "objectname", LuaValue.String "Units/ARMFRT.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMFRT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 468.0
            LuaKey.String "waterline", LuaValue.Number 0.3
            LuaKey.String "yardmap", LuaValue.String "wwwwwwwwwwwwwwww"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/SeaDefence"
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.10124206543 -0.0500075439453 1.15520477295"
                            LuaKey.String "collisionvolumescales", LuaValue.String "41.2024536133 67.0857849121 50.3104095459"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 151.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 46.0
                            LuaKey.String "object", LuaValue.String "Units/armfrt_dead.s3o"
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
                    LuaKey.String "armrl_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.75
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 1.75
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Missiles"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 765.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.2
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 5.0
                            LuaKey.String "smokesize", LuaValue.Number 4.8
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
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
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "ARMRL_MISSILE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let armgplat =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "ARMGPLAT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2860.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -6 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "45 36 45"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 900.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 760.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 110.0
            LuaKey.String "minwaterdepth", LuaValue.Number 1.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/ARMGPLAT.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMGPLAT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "yardmap", LuaValue.String "wwwwwwwwwwwwwwww"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/SeaDefence"
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -6.6047363281e-05 -15.62939453125e-06"
                            LuaKey.String "collisionvolumescales", LuaValue.String "50.0 45.7867279053 45.9999847412"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 750.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 80.0
                            LuaKey.String "object", LuaValue.String "Units/armgplat_dead.s3o"
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
                            LuaKey.Int 1, LuaValue.String "twractv3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twractv3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "gun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 48.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-fast"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Light g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 520.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "soundhit", LuaValue.String "xplosml3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "corraid"
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 97.0
                                    LuaKey.String "vtol", LuaValue.Number 18.0
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

    let armkraken =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "ARMKRAKEN.DDS"
            LuaKey.String "buildtime", LuaValue.Number 20000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "84 60 84"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 13000.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "health", LuaValue.Number 4450.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 1000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 2.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/ARMKRAKEN.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMKRAKEN.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 700.0
            LuaKey.String "waterline", LuaValue.Number 3.0
            LuaKey.String "yardmap", LuaValue.String "wwwww wwwww wwwww wwwww wwwww"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Zecrus"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/SeaDefence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -15 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "84 60 84"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 4000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/armkraken_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 1000.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 250.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3E.s3o"
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
                    LuaKey.String "armmech_cannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-small"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "firestarter", LuaValue.Number 5.0
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Rapid-fire gauss cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.35
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy2"
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.15
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 180.0
                                    LuaKey.String "vtol", LuaValue.Number 50.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "ARMMECH_CANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let armnavaldefturret =
        LuaValue.Table [
            LuaKey.String "airsightdistance", LuaValue.Number 650.0
            LuaKey.String "buildangle", LuaValue.Number 32768.0
            LuaKey.String "buildpic", LuaValue.String "armnavaldefturret.DDS"
            LuaKey.String "buildtime", LuaValue.Number 15000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "70 60 70"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 10000.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "health", LuaValue.Number 5190.0
            LuaKey.String "mass", LuaValue.Number 9500.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 750.0
            LuaKey.String "minwaterdepth", LuaValue.Number 18.0
            LuaKey.String "objectname", LuaValue.String "Units/armnavaldefturret.s3o"
            LuaKey.String "script", LuaValue.String "Units/armnavaldefturret.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 650.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooooooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/SeaDefence"
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "70 60 70"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 2500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 50.0
                            LuaKey.String "metal", LuaValue.Number 350.0
                            LuaKey.String "object", LuaValue.String "Units/armnavaldefturret_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
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
                    LuaKey.String "arm_medium_gauss_cannon", LuaValue.Table [
                            LuaKey.String "alphadecay", LuaValue.Number 0.08
                            LuaKey.String "areaofeffect", LuaValue.Number 18.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Dual Medium Plasma Gauss Cannons"
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 730.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "separation", LuaValue.Number 1.8
                            LuaKey.String "sizedecay", LuaValue.Number 0.06
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy1"
                            LuaKey.String "stages", LuaValue.Number 14.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.2
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "arm_medium_gauss_cannon"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let armtl =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "ARMTL.DDS"
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
            LuaKey.String "objectname", LuaValue.String "Units/ARMTL.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMTL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 494.0
            LuaKey.String "sonardistance", LuaValue.Number 400.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "yardmap", LuaValue.String "wwwwwwwww"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/SeaDefence"
                    LuaKey.String "unitgroup", LuaValue.String "sub"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.25 -4.24193335938 -0.393661499023"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32.1499938965 9.51611328125 31.9671630859"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 870.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 70.0
                            LuaKey.String "object", LuaValue.String "Units/armtl_dead.s3o"
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
                            LuaKey.String "model", LuaValue.String "cortorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "Level1TorpedoLauncher"
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
            "armatl", armatl
            "armdl", armdl
            "armfflak", armfflak
            "armfhlt", armfhlt
            "armfrock", armfrock
            "armfrt", armfrt
            "armgplat", armgplat
            "armkraken", armkraken
            "armnavaldefturret", armnavaldefturret
            "armtl", armtl
        ]
