// Auto-generated BAR unit data: Legion/Other
namespace BarData.Units

open BarData

module Legion_Other =

    let legvision =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 1.0
            LuaKey.String "buildpic", LuaValue.String "COREYES.DDS"
            LuaKey.String "buildtime", LuaValue.Number 750.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "20 24 20"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "cloakcost", LuaValue.Number 0.001
            LuaKey.String "cloakcostmoving", LuaValue.Number 0.0
            LuaKey.String "corpse", LuaValue.String "CDRAGONSEYES_DEAD"
            LuaKey.String "energyupkeep", LuaValue.Number 0.0
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "initcloaked", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "health", LuaValue.Number 1.0
            LuaKey.String "maxslope", LuaValue.Number 24.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "mincloakdistance", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGVISION.s3o"
            LuaKey.String "script", LuaValue.String "Units/COREYES.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "sightdistance", LuaValue.Number 300.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 5.0
            LuaKey.String "yardmap", LuaValue.String "o"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
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

    let all : (string * LuaValue) list =
        [
            "legvision", legvision
        ]
