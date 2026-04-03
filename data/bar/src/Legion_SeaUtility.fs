// Auto-generated BAR unit data: Legion/SeaUtility
namespace BarData.Units

open BarData

module Legion_SeaUtility =

    let legfrad =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "buildpic", LuaValue.String "legfrad.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1800.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -12 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 99 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 1000.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 110.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "metalcost", LuaValue.Number 130.0
            LuaKey.String "minwaterdepth", LuaValue.Number 5.0
            LuaKey.String "objectname", LuaValue.String "Units/legfrad.s3o"
            LuaKey.String "onoffable", LuaValue.Bool false
            LuaKey.String "radardistance", LuaValue.Number 2100.0
            LuaKey.String "radaremitheight", LuaValue.Number 52.0
            LuaKey.String "script", LuaValue.String "Units/legfrad.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 760.0
            LuaKey.String "sightemitheight", LuaValue.Number 52.0
            LuaKey.String "sonardistance", LuaValue.Number 900.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "yardmap", LuaValue.String "wwwwwwwww"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/SeaUtil"
                    LuaKey.String "unitgroup", LuaValue.String "util"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -14.8080587891 -0.125"
                            LuaKey.String "collisionvolumescales", LuaValue.String "45.9999694824 25.4694824219 42.75"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 59.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 83.0
                            LuaKey.String "object", LuaValue.String "Units/legfrad_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
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

    let all : (string * LuaValue) list =
        [
            "legfrad", legfrad
        ]
