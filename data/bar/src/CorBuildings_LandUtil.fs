// Auto-generated BAR unit data: CorBuildings/LandUtil
namespace BarData.Units

open BarData

module CorBuildings_LandUtil =

    let corarad =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "CORARAD.DDS"
            LuaKey.String "buildtime", LuaValue.Number 8000.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "35 98 35"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 14000.0
            LuaKey.String "explodeas", LuaValue.String "smallBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 500.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 400.0
            LuaKey.String "objectname", LuaValue.String "Units/CORARAD.s3o"
            LuaKey.String "onoffable", LuaValue.Bool false
            LuaKey.String "radardistance", LuaValue.Number 3500.0
            LuaKey.String "radaremitheight", LuaValue.Number 87.0
            LuaKey.String "script", LuaValue.String "Units/CORARAD.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "sightemitheight", LuaValue.Number 87.0
            LuaKey.String "yardmap", LuaValue.String "oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corarad_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0 "
                            LuaKey.String "collisionvolumescales", LuaValue.String "37.4503479004 89.5777740479 30.4736785889"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Cyly"
                            LuaKey.String "damage", LuaValue.Number 198.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 339.0
                            LuaKey.String "object", LuaValue.String "Units/corarad_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 99.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 136.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:radarpulse_t2_slow"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "activate", LuaValue.String "radadvn2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "deactivate", LuaValue.String "radadde2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "working", LuaValue.String "radar2"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "radadvn2"
                        ]
                ]
        ]

    let cordrag =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORDRAG.DDS"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 22 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "ROCKTEETH"
            LuaKey.String "crushresistance", LuaValue.Number 250.0
            LuaKey.String "energycost", LuaValue.Number 0.0
            LuaKey.String "explodeas", LuaValue.String "WallExplosionConcrete"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 2800.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 8.0
            LuaKey.String "objectname", LuaValue.String "Units/cordrag.s3o"
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/cordrag.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "WallExplosionConcrete"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 1.0
            LuaKey.String "sightdistance", LuaValue.Number 1.0
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/cordrag_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "objectify", LuaValue.Bool true
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
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

    let coreyes =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "COREYES.DDS"
            LuaKey.String "buildtime", LuaValue.Number 750.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cloakcost", LuaValue.Number 10.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "20 24 20"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "CDRAGONSEYES_DEAD"
            LuaKey.String "energycost", LuaValue.Number 850.0
            LuaKey.String "energyupkeep", LuaValue.Number 5.0
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "health", LuaValue.Number 280.0
            LuaKey.String "initcloaked", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 24.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 32.0
            LuaKey.String "mincloakdistance", LuaValue.Number 36.0
            LuaKey.String "objectname", LuaValue.String "Units/COREYES.s3o"
            LuaKey.String "script", LuaValue.String "Units/COREYES.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "sightdistance", LuaValue.Number 540.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 5.0
            LuaKey.String "yardmap", LuaValue.String "o"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "unitgroup", LuaValue.String "util"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "cdragonseyes_dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-0.0323944091797 0.0 0.00588226318359"
                            LuaKey.String "collisionvolumescales", LuaValue.String "21.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 120.0
                            LuaKey.String "footprintx", LuaValue.Number 1.0
                            LuaKey.String "footprintz", LuaValue.Number 1.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 12.0
                            LuaKey.String "object", LuaValue.String "Units/cor1X1A.s3o"
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
                            LuaKey.Int 1, LuaValue.String "servsml6"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "minesel2"
                        ]
                ]
        ]

    let corfort =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "CORFORT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 900.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 52 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "ROCKTEETHX"
            LuaKey.String "crushresistance", LuaValue.Number 1000.0
            LuaKey.String "energycost", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "WallExplosionConcreteXL"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 8900.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 24.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 40.0
            LuaKey.String "objectname", LuaValue.String "Units/CORFORT.s3o"
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/CORFORT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "WallExplosionConcrete"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 1.0
            LuaKey.String "sightdistance", LuaValue.Number 1.0
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corfort_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "objectify", LuaValue.Bool true
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
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
                            LuaKey.String "object", LuaValue.String "Units/cor1X1B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "shadtrans", LuaValue.Number 1.0
                        ]
                ]
        ]

    let corgate =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 2048.0
            LuaKey.String "buildpic", LuaValue.String "CORGATE.DDS"
            LuaKey.String "buildtime", LuaValue.Number 55000.0
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "NOWEAPON"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -4 1"
            LuaKey.String "collisionvolumescales", LuaValue.String "57 38 57"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 55000.0
            LuaKey.String "energystorage", LuaValue.Number 1000.0
            LuaKey.String "exemptcategory", LuaValue.String "WEAPON"
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 3550.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 3200.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "objectname", LuaValue.String "Units/CORGATE.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORGATE.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corgate_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "shield_color_mult", LuaValue.Number 0.8
                    LuaKey.String "shield_power", LuaValue.Number 6175.0
                    LuaKey.String "shield_radius", LuaValue.Number 550.0
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -0.00271934814453 -1.05072021484"
                            LuaKey.String "collisionvolumescales", LuaValue.String "65.7474060059 27.1259613037 55.6685791016"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1900.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2000.0
                            LuaKey.String "object", LuaValue.String "Units/corgate_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 960.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 800.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2E.s3o"
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
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.17
                                    LuaKey.String "armortype", LuaValue.String "shields"
                                    LuaKey.String "exterior", LuaValue.Bool true
                                    LuaKey.String "energyupkeep", LuaValue.Number 0.0
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 1.0
                                    LuaKey.String "power", LuaValue.Number 6175.0
                                    LuaKey.String "powerregen", LuaValue.Number 130.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 562.5
                                    LuaKey.String "radius", LuaValue.Number 550.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 2090.0
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

    let corjamt =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 9821.0
            LuaKey.String "buildpic", LuaValue.String "CORJAMT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4000.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "30 37 30"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 4500.0
            LuaKey.String "energyupkeep", LuaValue.Number 25.0
            LuaKey.String "explodeas", LuaValue.String "smallexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 1070.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 100.0
            LuaKey.String "objectname", LuaValue.String "Units/CORJAMT.s3o"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "radardistancejam", LuaValue.Number 360.0
            LuaKey.String "script", LuaValue.String "Units/CORJAMT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 104.0
            LuaKey.String "yardmap", LuaValue.String "oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 3.6
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 3.6
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corjamt_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -2 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "30 35 30"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 576.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 3.0
                            LuaKey.String "metal", LuaValue.Number 71.0
                            LuaKey.String "object", LuaValue.String "Units/corjamt_dead.s3o"
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
                            LuaKey.Int 1, LuaValue.String "kbcormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "radjam2"
                        ]
                ]
        ]

    let cormine1 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "CORMINE1.DDS"
            LuaKey.String "buildtime", LuaValue.Number 100.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canguard", LuaValue.Bool false
            LuaKey.String "canpatrol", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cloakcost", LuaValue.Number 1.0
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "15 10 15"
            LuaKey.String "collisionvolumetype", LuaValue.String "cyly"
            LuaKey.String "energycost", LuaValue.Number 270.0
            LuaKey.String "explodeas", LuaValue.String "MINE_LIGHT"
            LuaKey.String "firestate", LuaValue.Number 2.0
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "health", LuaValue.Number 11.0
            LuaKey.String "initcloaked", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 40.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 7.0
            LuaKey.String "mincloakdistance", LuaValue.Number 30.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORMINE1.s3o"
            LuaKey.String "script", LuaValue.String "mines_lus.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "MINE_LIGHT"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 0.0
            LuaKey.String "sightdistance", LuaValue.Number 83.2
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "detonaterange", LuaValue.String "64"
                    LuaKey.String "instantselfd", LuaValue.Bool true
                    LuaKey.String "mine", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "Tristan"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "unitgroup", LuaValue.String "explo"
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
                            LuaKey.Int 1, LuaValue.String "servsml6"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "minesel2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "minerange", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String ""
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Crawlingbomb Dummy Weapon"
                            LuaKey.String "range", LuaValue.Number 64.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "minexpl1"
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 0.0
                            LuaKey.String "tolerance", LuaValue.Number 1000000.0
                            LuaKey.String "weapontype", LuaValue.String "Melee"
                            LuaKey.String "weaponvelocity", LuaValue.Number 100000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MINERANGE"
                        ]
                ]
        ]

    let cormine2 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "CORMINE2.DDS"
            LuaKey.String "buildtime", LuaValue.Number 300.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canguard", LuaValue.Bool false
            LuaKey.String "canpatrol", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cloakcost", LuaValue.Number 2.0
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "15 10 15"
            LuaKey.String "collisionvolumetype", LuaValue.String "cyly"
            LuaKey.String "energycost", LuaValue.Number 1050.0
            LuaKey.String "explodeas", LuaValue.String "MINE_MEDIUM"
            LuaKey.String "firestate", LuaValue.Number 2.0
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "health", LuaValue.Number 11.0
            LuaKey.String "initcloaked", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 40.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 25.0
            LuaKey.String "mincloakdistance", LuaValue.Number 30.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORMINE2.s3o"
            LuaKey.String "script", LuaValue.String "mines_lus.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "MINE_MEDIUM"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 0.0
            LuaKey.String "sightdistance", LuaValue.Number 83.2
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "detonaterange", LuaValue.String "64"
                    LuaKey.String "instantselfd", LuaValue.Bool true
                    LuaKey.String "mine", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "Tristan"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "unitgroup", LuaValue.String "explo"
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
                            LuaKey.Int 1, LuaValue.String "servsml6"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "minesel2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "minerange", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String ""
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Crawlingbomb Dummy Weapon"
                            LuaKey.String "range", LuaValue.Number 64.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 0.0
                            LuaKey.String "tolerance", LuaValue.Number 1000000.0
                            LuaKey.String "weapontype", LuaValue.String "Melee"
                            LuaKey.String "weaponvelocity", LuaValue.Number 100000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MINERANGE"
                        ]
                ]
        ]

    let cormine3 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "CORMINE3.DDS"
            LuaKey.String "buildtime", LuaValue.Number 700.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canguard", LuaValue.Bool false
            LuaKey.String "canpatrol", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cloakcost", LuaValue.Number 6.0
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "15 10 15"
            LuaKey.String "collisionvolumetype", LuaValue.String "cyly"
            LuaKey.String "energycost", LuaValue.Number 2800.0
            LuaKey.String "explodeas", LuaValue.String "MINE_HEAVY"
            LuaKey.String "firestate", LuaValue.Number 2.0
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "health", LuaValue.Number 11.0
            LuaKey.String "initcloaked", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 40.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 50.0
            LuaKey.String "mincloakdistance", LuaValue.Number 30.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORMINE3.s3o"
            LuaKey.String "script", LuaValue.String "mines_lus.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "MINE_HEAVY"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 0.0
            LuaKey.String "sightdistance", LuaValue.Number 83.2
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "detonaterange", LuaValue.String "64"
                    LuaKey.String "instantselfd", LuaValue.Bool true
                    LuaKey.String "mine", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "Tristan"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "unitgroup", LuaValue.String "explo"
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
                            LuaKey.Int 1, LuaValue.String "servsml6"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "minesel2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "minerange", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String ""
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Crawlingbomb Dummy Weapon"
                            LuaKey.String "range", LuaValue.Number 64.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 0.0
                            LuaKey.String "tolerance", LuaValue.Number 1000000.0
                            LuaKey.String "weapontype", LuaValue.String "Melee"
                            LuaKey.String "weaponvelocity", LuaValue.Number 100000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MINERANGE"
                        ]
                ]
        ]

    let cormine4 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "CORMINE2.DDS"
            LuaKey.String "buildtime", LuaValue.Number 200.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canguard", LuaValue.Bool false
            LuaKey.String "canpatrol", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "ALL NOTLAND WEAPON MINE NOTSUB NOTSHIP NOTAIR NOTHOVER SURFACE EMPABLE"
            LuaKey.String "cloakcost", LuaValue.Number 1.0
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "15 10 15"
            LuaKey.String "collisionvolumetype", LuaValue.String "cyly"
            LuaKey.String "energycost", LuaValue.Number 1050.0
            LuaKey.String "explodeas", LuaValue.String "MINE_MEDIUM"
            LuaKey.String "firestate", LuaValue.Number 2.0
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "health", LuaValue.Number 11.0
            LuaKey.String "initcloaked", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 40.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 16.0
            LuaKey.String "mincloakdistance", LuaValue.Number 8.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORMINE2.s3o"
            LuaKey.String "script", LuaValue.String "mines_lus.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "MINE_MEDIUM"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 0.0
            LuaKey.String "sightdistance", LuaValue.Number 83.2
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "detonaterange", LuaValue.String "64"
                    LuaKey.String "instantselfd", LuaValue.Bool true
                    LuaKey.String "mine", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "Tristan"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "unitgroup", LuaValue.String "explo"
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
                            LuaKey.Int 1, LuaValue.String "servsml6"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "minesel2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "minerange", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String ""
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Crawlingbomb Dummy Weapon"
                            LuaKey.String "range", LuaValue.Number 64.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 0.0
                            LuaKey.String "tolerance", LuaValue.Number 1000000.0
                            LuaKey.String "weapontype", LuaValue.String "Melee"
                            LuaKey.String "weaponvelocity", LuaValue.Number 100000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "bogus", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MINERANGE"
                        ]
                ]
        ]

    let cornanotc =
        LuaValue.Table [
            LuaKey.String "builddistance", LuaValue.Number 400.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORNANOTC.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5300.0
            LuaKey.String "canassist", LuaValue.Bool true
            LuaKey.String "canfight", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "31 32 31"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "energycost", LuaValue.Number 3200.0
            LuaKey.String "explodeas", LuaValue.String "nanoboom"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 560.0
            LuaKey.String "leavesghost", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 700.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 4.5
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 230.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "objectname", LuaValue.String "Units/CORNANOTC.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORNANOTC.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "nanoselfd"
            LuaKey.String "sightdistance", LuaValue.Number 380.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "turnrate", LuaValue.Number 1.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 200.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/cornanotc_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
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
        ]

    let cornanotct2 =
        LuaValue.Table [
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORNANOTC.DDS"
            LuaKey.String "buildtime", LuaValue.Number 21000.0
            LuaKey.String "canassist", LuaValue.Bool true
            LuaKey.String "canfight", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "46 80 46"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "energycost", LuaValue.Number 12800.0
            LuaKey.String "explodeas", LuaValue.String "nanoboom"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 2200.0
            LuaKey.String "leavesghost", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 5100.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 4.5
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 840.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "objectname", LuaValue.String "Units/CORNANOT2.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORNANOT2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "nanoselfd"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "turnrate", LuaValue.Number 1.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/cornanotc_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "repair", LuaValue.String "repair1"
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
                            LuaKey.Int 1, LuaValue.String "varmmove"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "varmsel"
                        ]
                ]
        ]

    let corrad =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16000.0
            LuaKey.String "buildpic", LuaValue.String "CORRAD.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1140.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -12 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 99 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 630.0
            LuaKey.String "explodeas", LuaValue.String "smallBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 180.0
            LuaKey.String "mass", LuaValue.Number 5100.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 60.0
            LuaKey.String "objectname", LuaValue.String "Units/CORRAD.s3o"
            LuaKey.String "onoffable", LuaValue.Bool false
            LuaKey.String "radardistance", LuaValue.Number 2100.0
            LuaKey.String "radaremitheight", LuaValue.Number 72.0
            LuaKey.String "script", LuaValue.String "Units/CORRAD.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 680.0
            LuaKey.String "sightemitheight", LuaValue.Number 72.0
            LuaKey.String "yardmap", LuaValue.String "oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corrad_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.353988647461 -0.0323567626953 1.37395477295"
                            LuaKey.String "collisionvolumescales", LuaValue.String "34.8413696289 57.1648864746 30.8629608154"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 49.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 36.0
                            LuaKey.String "object", LuaValue.String "Units/corrad_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 25.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 14.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:radarpulse_t1_slow"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "activate", LuaValue.String "cmd-on"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "deactivate", LuaValue.String "cmd-off"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "working", LuaValue.String "cmd-on"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "radarselect"
                        ]
                ]
        ]

    let corsd =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "buildpic", LuaValue.String "CORSD.DDS"
            LuaKey.String "buildtime", LuaValue.Number 12000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "65 10 60"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 6700.0
            LuaKey.String "energyupkeep", LuaValue.Number 125.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 2800.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 750.0
            LuaKey.String "objectname", LuaValue.String "Units/CORSD.s3o"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/CORSD.cob"
            LuaKey.String "seismicdistance", LuaValue.Number 2000.0
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 225.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corsd_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-1.15772247314 -1.86200052979 2.43579101563"
                            LuaKey.String "collisionvolumescales", LuaValue.String "68.8967437744 12.3805389404 66.8254699707"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 15.0
                            LuaKey.String "metal", LuaValue.Number 584.0
                            LuaKey.String "object", LuaValue.String "Units/corsd_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 750.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 234.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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
        ]

    let corshroud =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "CORSHROUD.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9400.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 16 -2"
            LuaKey.String "collisionvolumescales", LuaValue.String "34 93 34"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 20000.0
            LuaKey.String "energyupkeep", LuaValue.Number 125.0
            LuaKey.String "explodeas", LuaValue.String "smallBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 890.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 130.0
            LuaKey.String "objectname", LuaValue.String "Units/CORSHROUD.s3o"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "radardistancejam", LuaValue.Number 700.0
            LuaKey.String "script", LuaValue.String "Units/CORSHROUD.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 155.0
            LuaKey.String "yardmap", LuaValue.String "oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 3.8
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 3.8
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corshroud_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-7.38106536865 2.64404296892e-05 2.18940734863"
                            LuaKey.String "collisionvolumescales", LuaValue.String "57.2317047119 61.2454528809 48.0499572754"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 480.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 81.0
                            LuaKey.String "object", LuaValue.String "Units/corshroud_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 240.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 32.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2A.s3o"
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
                            LuaKey.Int 1, LuaValue.String "radjam2"
                        ]
                ]
        ]

    let cortarg =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "buildpic", LuaValue.String "CORTARG.DDS"
            LuaKey.String "buildtime", LuaValue.Number 10900.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 7500.0
            LuaKey.String "energyupkeep", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 2000.0
            LuaKey.String "istargetingupgrade", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/CORTARG.s3o"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/CORTARG.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/cortarg_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.625 -3.66210937486e-06 -0.246391296387"
                            LuaKey.String "collisionvolumescales", LuaValue.String "62.75 20.2424926758 64.4927825928"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1080.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 487.0
                            LuaKey.String "object", LuaValue.String "Units/cortarg_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 540.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 195.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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
        ]

    let all : (string * LuaValue) list =
        [
            "corarad", corarad
            "cordrag", cordrag
            "coreyes", coreyes
            "corfort", corfort
            "corgate", corgate
            "corjamt", corjamt
            "cormine1", cormine1
            "cormine2", cormine2
            "cormine3", cormine3
            "cormine4", cormine4
            "cornanotc", cornanotc
            "cornanotct2", cornanotct2
            "corrad", corrad
            "corsd", corsd
            "corshroud", corshroud
            "cortarg", cortarg
        ]
