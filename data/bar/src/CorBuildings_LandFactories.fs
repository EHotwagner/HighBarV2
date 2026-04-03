// Auto-generated BAR unit data: CorBuildings/LandFactories
namespace BarData.Units

open BarData

module CorBuildings_LandFactories =

    let coraap =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORAAP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 32000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "142 64 142"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 28000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 3900.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 2900.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/CORAAP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "radaremitheight", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/CORAAP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 305.5
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "coraca"
                    LuaKey.Int 2, LuaValue.String "corape"
                    LuaKey.Int 3, LuaValue.String "corhurc"
                    LuaKey.Int 4, LuaValue.String "cortitan"
                    LuaKey.Int 5, LuaValue.String "corvamp"
                    LuaKey.Int 6, LuaValue.String "corawac"
                    LuaKey.Int 7, LuaValue.String "corseah"
                    LuaKey.Int 8, LuaValue.String "corcrwh"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "airfactory", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/coraap_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_noair_"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -12 -22"
                            LuaKey.String "collisionvolumescales", LuaValue.String "98 32 52"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2112.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1936.0
                            LuaKey.String "object", LuaValue.String "Units/coraap_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1056.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 968.0
                            LuaKey.String "object", LuaValue.String "Units/cor6X6A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                            LuaKey.Int 2, LuaValue.String "custom:radarpulse_t1_slow"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "pairactv"
                        ]
                ]
        ]

    let coralab =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORALAB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 26000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 2 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "144 56 144"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 16000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 4500.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 2600.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/CORALAB.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORALAB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 288.60001
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo oooeeeooo oooeeeooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corack"
                    LuaKey.Int 2, LuaValue.String "corfast"
                    LuaKey.Int 3, LuaValue.String "corpyro"
                    LuaKey.Int 4, LuaValue.String "coramph"
                    LuaKey.Int 5, LuaValue.String "corcan"
                    LuaKey.Int 6, LuaValue.String "corsumo"
                    LuaKey.Int 7, LuaValue.String "cortermite"
                    LuaKey.Int 8, LuaValue.String "cormort"
                    LuaKey.Int 9, LuaValue.String "corhrk"
                    LuaKey.Int 10, LuaValue.String "coraak"
                    LuaKey.Int 11, LuaValue.String "corroach"
                    LuaKey.Int 12, LuaValue.String "corsktl"
                    LuaKey.Int 13, LuaValue.String "cordecom"
                    LuaKey.Int 14, LuaValue.String "corvoyr"
                    LuaKey.Int 15, LuaValue.String "corspy"
                    LuaKey.Int 16, LuaValue.String "corspec"
                    LuaKey.Int 17, LuaValue.String "cormando"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/coralab_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -16 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "100 34 90"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2443.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1743.0
                            LuaKey.String "object", LuaValue.String "Units/coralab_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1222.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 872.0
                            LuaKey.String "object", LuaValue.String "Units/cor5X5A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "plabactv"
                        ]
                ]
        ]

    let corap =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORAP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5380.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "128 33 96"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 1100.0
            LuaKey.String "energystorage", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 2150.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 630.0
            LuaKey.String "metalstorage", LuaValue.Number 100.0
            LuaKey.String "objectname", LuaValue.String "Units/CORAP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 510.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "script", LuaValue.String "Units/CORAP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "terraformspeed", LuaValue.Number 500.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corca"
                    LuaKey.Int 2, LuaValue.String "corfink"
                    LuaKey.Int 3, LuaValue.String "corveng"
                    LuaKey.Int 4, LuaValue.String "corshad"
                    LuaKey.Int 5, LuaValue.String "corvalk"
                    LuaKey.Int 6, LuaValue.String "corbw"
                    LuaKey.Int 7, LuaValue.String "corhvytrans"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "airfactory", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 11.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corap_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_noair_"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -14 -23"
                            LuaKey.String "collisionvolumescales", LuaValue.String "110 33 50"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1155.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 12.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 540.0
                            LuaKey.String "object", LuaValue.String "Units/corap_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 578.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 216.0
                            LuaKey.String "object", LuaValue.String "Units/cor6X6B.s3o"
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
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "unitready"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "airplantselect"
                        ]
                ]
        ]

    let coravp =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORAVP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 28000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 8 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "144 70 144"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 16000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 5100.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 2600.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/CORAVP.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORAVP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 286.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "coracv"
                    LuaKey.Int 2, LuaValue.String "corsala"
                    LuaKey.Int 3, LuaValue.String "correap"
                    LuaKey.Int 4, LuaValue.String "corparrow"
                    LuaKey.Int 5, LuaValue.String "corgol"
                    LuaKey.Int 6, LuaValue.String "corban"
                    LuaKey.Int 7, LuaValue.String "cormart"
                    LuaKey.Int 8, LuaValue.String "corvroc"
                    LuaKey.Int 9, LuaValue.String "cortrem"
                    LuaKey.Int 10, LuaValue.String "corsent"
                    LuaKey.Int 11, LuaValue.String "cormabm"
                    LuaKey.Int 12, LuaValue.String "coreter"
                    LuaKey.Int 13, LuaValue.String "corvrad"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 0.01
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/coravp_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -6 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "124 30 104"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2777.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1721.0
                            LuaKey.String "object", LuaValue.String "Units/coravp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1389.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 860.0
                            LuaKey.String "object", LuaValue.String "Units/cor6X6C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "pvehactv"
                        ]
                ]
        ]

    let corgant =
        LuaValue.Table [
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORGANT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 68000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "196 110 196"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 62000.0
            LuaKey.String "energystorage", LuaValue.Number 1400.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 17800.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 8400.0
            LuaKey.String "metalstorage", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/CORGANT.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORGANT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "workertime", LuaValue.Number 1800.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corkorg"
                    LuaKey.Int 2, LuaValue.String "corkarg"
                    LuaKey.Int 3, LuaValue.String "corjugg"
                    LuaKey.Int 4, LuaValue.String "corshiva"
                    LuaKey.Int 5, LuaValue.String "corcat"
                    LuaKey.Int 6, LuaValue.String "corsok"
                    LuaKey.Int 7, LuaValue.String "cordemon"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corgant_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob, Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert3"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -21 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "114 74 129"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
                            LuaKey.String "damage", LuaValue.Number 9600.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 12.0
                            LuaKey.String "footprintz", LuaValue.Number 12.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 5101.0
                            LuaKey.String "object", LuaValue.String "Units/corgant_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4800.0
                            LuaKey.String "footprintx", LuaValue.Number 12.0
                            LuaKey.String "footprintz", LuaValue.Number 12.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2040.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:GantWhiteLight"
                            LuaKey.Int 2, LuaValue.String "custom:YellowLight"
                            LuaKey.Int 3, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "activate", LuaValue.String "gantok2"
                    LuaKey.String "build", LuaValue.String "gantok2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "deactivate", LuaValue.String "gantok2"
                    LuaKey.String "repair", LuaValue.String "lathelrg"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "gantok1"
                    LuaKey.String "working", LuaValue.String "build"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "gantsel1"
                        ]
                ]
        ]

    let corhaap =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORAAP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 92000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 65000.0
            LuaKey.String "energystorage", LuaValue.Number 1400.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 17800.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 4700.0
            LuaKey.String "metalstorage", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/CORHAAP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 750.0
            LuaKey.String "radaremitheight", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/CORAAP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "workertime", LuaValue.Number 1800.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corhaca"
                    LuaKey.Int 2, LuaValue.String "corape"
                    LuaKey.Int 3, LuaValue.String "corhurc"
                    LuaKey.Int 4, LuaValue.String "cortitan"
                    LuaKey.Int 5, LuaValue.String "corvamp"
                    LuaKey.Int 6, LuaValue.String "corseah"
                    LuaKey.Int 7, LuaValue.String "corawac"
                    LuaKey.Int 8, LuaValue.String "corcrwh"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "airfactory", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/coraap_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert3"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "5 0.0 -0.0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "235 82.5 225"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 9600.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 12.0
                            LuaKey.String "footprintz", LuaValue.Number 12.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 5101.0
                            LuaKey.String "object", LuaValue.String "Units/corhaap_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4800.0
                            LuaKey.String "footprintx", LuaValue.Number 12.0
                            LuaKey.String "footprintz", LuaValue.Number 12.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2040.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "seaplok2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "seaplsl2"
                        ]
                ]
        ]

    let corhaapuw =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORPLAT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 42000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "142 64 142"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 23000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 3900.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "metalcost", LuaValue.Number 1900.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "minwaterdepth", LuaValue.Number 30.0
            LuaKey.String "objectname", LuaValue.String "Units/CORAAPLAT.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "radaremitheight", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/CORPLAT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 305.5
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 200.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "coraca"
                    LuaKey.Int 2, LuaValue.String "corhunt"
                    LuaKey.Int 3, LuaValue.String "corcut"
                    LuaKey.Int 4, LuaValue.String "corsb"
                    LuaKey.Int 5, LuaValue.String "corseap"
                    LuaKey.Int 6, LuaValue.String "corsfig"
                    LuaKey.Int 7, LuaValue.String "corhvytrans"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "airfactory", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/coraap_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -12 -22"
                            LuaKey.String "collisionvolumescales", LuaValue.String "98 32 52"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2112.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1936.0
                            LuaKey.String "object", LuaValue.String "Units/coraaplat_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1056.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 968.0
                            LuaKey.String "object", LuaValue.String "Units/cor6X6A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "seaplok2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "seaplsl2"
                        ]
                ]
        ]

    let corhalab =
        LuaValue.Table [
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORGANT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 92000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "196 110 196"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 52200.0
            LuaKey.String "energystorage", LuaValue.Number 1400.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 17800.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 4900.0
            LuaKey.String "metalstorage", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/CORGANT.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORGANT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "workertime", LuaValue.Number 1200.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "coraak"
                    LuaKey.Int 2, LuaValue.String "corshiva"
                    LuaKey.Int 3, LuaValue.String "corpyro"
                    LuaKey.Int 4, LuaValue.String "corhack"
                    LuaKey.Int 5, LuaValue.String "corsumo"
                    LuaKey.Int 6, LuaValue.String "cordecom"
                    LuaKey.Int 7, LuaValue.String "corsktl"
                    LuaKey.Int 8, LuaValue.String "corspec"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corgant_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob, Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert3"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -21 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "114 74 129"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
                            LuaKey.String "damage", LuaValue.Number 9600.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 12.0
                            LuaKey.String "footprintz", LuaValue.Number 12.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 5101.0
                            LuaKey.String "object", LuaValue.String "Units/corgant_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4800.0
                            LuaKey.String "footprintx", LuaValue.Number 12.0
                            LuaKey.String "footprintz", LuaValue.Number 12.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2040.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:GantWhiteLight"
                            LuaKey.Int 2, LuaValue.String "custom:YellowLight"
                            LuaKey.Int 3, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "activate", LuaValue.String "gantok2"
                    LuaKey.String "build", LuaValue.String "gantok2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "deactivate", LuaValue.String "gantok2"
                    LuaKey.String "repair", LuaValue.String "lathelrg"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "gantok1"
                    LuaKey.String "working", LuaValue.String "build"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "gantsel1"
                        ]
                ]
        ]

    let corhavp =
        LuaValue.Table [
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORHAVP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 92000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "196 110 196"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 46000.0
            LuaKey.String "energystorage", LuaValue.Number 1400.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 17800.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 4900.0
            LuaKey.String "metalstorage", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/CORHAVP.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORAMSUB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "workertime", LuaValue.Number 1200.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corhacv"
                    LuaKey.Int 2, LuaValue.String "corgol"
                    LuaKey.Int 3, LuaValue.String "corvroc"
                    LuaKey.Int 4, LuaValue.String "cortrem"
                    LuaKey.Int 5, LuaValue.String "corsent"
                    LuaKey.Int 6, LuaValue.String "cormabm"
                    LuaKey.Int 7, LuaValue.String "coreter"
                    LuaKey.Int 8, LuaValue.String "corsok"
                    LuaKey.Int 9, LuaValue.String "corparrow"
                    LuaKey.Int 10, LuaValue.String "corsala"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 18.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 18.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/coramsub_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob, Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert3"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -21 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "114 74 129"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
                            LuaKey.String "damage", LuaValue.Number 9600.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 12.0
                            LuaKey.String "footprintz", LuaValue.Number 12.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 5101.0
                            LuaKey.String "object", LuaValue.String "Units/corhavp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4800.0
                            LuaKey.String "footprintx", LuaValue.Number 12.0
                            LuaKey.String "footprintz", LuaValue.Number 12.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2040.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:GantWhiteLight"
                            LuaKey.Int 2, LuaValue.String "custom:YellowLight"
                            LuaKey.Int 3, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "activate", LuaValue.String "gantok2"
                    LuaKey.String "build", LuaValue.String "gantok2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "deactivate", LuaValue.String "gantok2"
                    LuaKey.String "repair", LuaValue.String "lathelrg"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "gantok1"
                    LuaKey.String "working", LuaValue.String "build"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "gantsel1"
                        ]
                ]
        ]

    let corhp =
        LuaValue.Table [
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORHP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 8700.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 5 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "96 32 96"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 2000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 3750.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 670.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/CORHP.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORHP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 312.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corch"
                    LuaKey.Int 2, LuaValue.String "corsh"
                    LuaKey.Int 3, LuaValue.String "corsnap"
                    LuaKey.Int 4, LuaValue.String "corah"
                    LuaKey.Int 5, LuaValue.String "cormh"
                    LuaKey.Int 6, LuaValue.String "corhal"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corhp_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "techlevel", LuaValue.Number 1.5
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "120 26 108"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2014.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 662.0
                            LuaKey.String "object", LuaValue.String "Units/corhp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1007.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 265.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "hoverok2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "hoversl2"
                        ]
                ]
        ]

    let corlab =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORLAB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "93 92 87"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 1050.0
            LuaKey.String "energystorage", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 2900.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 470.0
            LuaKey.String "metalstorage", LuaValue.Number 100.0
            LuaKey.String "objectname", LuaValue.String "Units/CORLAB.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORLAB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 290.0
            LuaKey.String "terraformspeed", LuaValue.Number 500.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "oeeeeooeeeeooeeeeooeeeeooeeeeooeeeeo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corck"
                    LuaKey.Int 2, LuaValue.String "corak"
                    LuaKey.Int 3, LuaValue.String "cornecro"
                    LuaKey.Int 4, LuaValue.String "corstorm"
                    LuaKey.Int 5, LuaValue.String "corthud"
                    LuaKey.Int 6, LuaValue.String "corcrash"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corlab_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "88 28 88"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1560.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 442.0
                            LuaKey.String "object", LuaValue.String "Units/corlab_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 780.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 177.0
                            LuaKey.String "object", LuaValue.String "Units/cor6X6B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "unitready"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "labselect"
                        ]
                ]
        ]

    let corsaap =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGAAP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 51000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "142 64 142"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 35000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 3900.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 3500.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGAAP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "radaremitheight", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/LEGAAP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 305.5
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 200.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corcsa"
                    LuaKey.Int 2, LuaValue.String "corape"
                    LuaKey.Int 3, LuaValue.String "corhurc"
                    LuaKey.Int 4, LuaValue.String "cortitan"
                    LuaKey.Int 5, LuaValue.String "corvamp"
                    LuaKey.Int 6, LuaValue.String "corseah"
                    LuaKey.Int 7, LuaValue.String "corcrwh"
                    LuaKey.Int 8, LuaValue.String "corhunt"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "airfactory", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/coraap_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -12 -22"
                            LuaKey.String "collisionvolumescales", LuaValue.String "98 32 52"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2112.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1936.0
                            LuaKey.String "object", LuaValue.String "Units/legaap_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1056.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 968.0
                            LuaKey.String "object", LuaValue.String "Units/cor6X6A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                            LuaKey.Int 2, LuaValue.String "custom:radarpulse_t1_slow"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "pairactv"
                        ]
                ]
        ]

    let corsalab =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGALAB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 51000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 2 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "144 56 144"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 35000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 4500.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 3500.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGALAB.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGALAB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 288.60001
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 300.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo oooeeeooo oooeeeooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corsack"
                    LuaKey.Int 2, LuaValue.String "corsumo"
                    LuaKey.Int 3, LuaValue.String "corhrk"
                    LuaKey.Int 4, LuaValue.String "corsktl"
                    LuaKey.Int 5, LuaValue.String "corvoyr"
                    LuaKey.Int 6, LuaValue.String "corspec"
                    LuaKey.Int 7, LuaValue.String "cormando"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/coralab_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -16 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "100 34 90"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2443.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1743.0
                            LuaKey.String "object", LuaValue.String "Units/legalab_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1222.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 872.0
                            LuaKey.String "object", LuaValue.String "Units/cor5X5A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "plabactv"
                        ]
                ]
        ]

    let corsavp =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGAVP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 51000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 8 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "144 70 144"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 35000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 5100.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 3500.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGAVP.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGAVP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 286.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 300.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corsacv"
                    LuaKey.Int 2, LuaValue.String "corparrow"
                    LuaKey.Int 3, LuaValue.String "corgol"
                    LuaKey.Int 4, LuaValue.String "corban"
                    LuaKey.Int 5, LuaValue.String "corvroc"
                    LuaKey.Int 6, LuaValue.String "cortrem"
                    LuaKey.Int 7, LuaValue.String "coreter"
                    LuaKey.Int 8, LuaValue.String "corvrad"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 0.01
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/coravp_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -6 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "124 30 104"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2777.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1721.0
                            LuaKey.String "object", LuaValue.String "Units/legavp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1389.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 860.0
                            LuaKey.String "object", LuaValue.String "Units/cor6X6C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "pvehactv"
                        ]
                ]
        ]

    let corvp =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 2048.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORVP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5650.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 5 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "96 40 96"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 1550.0
            LuaKey.String "energystorage", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 3000.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 570.0
            LuaKey.String "metalstorage", LuaValue.Number 100.0
            LuaKey.String "objectname", LuaValue.String "Units/CORVP.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORVP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 279.0
            LuaKey.String "terraformspeed", LuaValue.Number 500.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "oooooo oooooo oeeeeo oeeeeo oeeeeo oeeeeo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corcv"
                    LuaKey.Int 2, LuaValue.String "cormuskrat"
                    LuaKey.Int 3, LuaValue.String "cormlv"
                    LuaKey.Int 4, LuaValue.String "corfav"
                    LuaKey.Int 5, LuaValue.String "corgator"
                    LuaKey.Int 6, LuaValue.String "corgarp"
                    LuaKey.Int 7, LuaValue.String "corraid"
                    LuaKey.Int 8, LuaValue.String "corlevlr"
                    LuaKey.Int 9, LuaValue.String "corwolv"
                    LuaKey.Int 10, LuaValue.String "cormist"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corvp_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -13 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "101 40 106"
                            LuaKey.String "collisionvolumetype", LuaValue.String "BOX"
                            LuaKey.String "damage", LuaValue.Number 1590.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 470.0
                            LuaKey.String "object", LuaValue.String "Units/corvp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 795.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 188.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "unitready"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vehplantselect"
                        ]
                ]
        ]

    let leghaap =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORHAAP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 92000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "196 110 196"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 62000.0
            LuaKey.String "energystorage", LuaValue.Number 1400.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 17800.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 4700.0
            LuaKey.String "metalstorage", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/CORHAAP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 750.0
            LuaKey.String "radaremitheight", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/CORHAAP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "leghaca"
                    LuaKey.Int 2, LuaValue.String "legstronghold"
                    LuaKey.Int 3, LuaValue.String "legmineb"
                    LuaKey.Int 4, LuaValue.String "legatorpbomber"
                    LuaKey.Int 5, LuaValue.String "legafigdef"
                    LuaKey.Int 6, LuaValue.String "legwhisper"
                    LuaKey.Int 7, LuaValue.String "legfort"
                    LuaKey.Int 8, LuaValue.String "legphoenix"
                    LuaKey.Int 9, LuaValue.String "legvenator"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "airfactory", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/coraap_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert3"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "2.5 0.0 -0.0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "117.5 41.25 112.5"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 9600.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 12.0
                            LuaKey.String "footprintz", LuaValue.Number 12.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 5101.0
                            LuaKey.String "object", LuaValue.String "Units/corplat_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4800.0
                            LuaKey.String "footprintx", LuaValue.Number 12.0
                            LuaKey.String "footprintz", LuaValue.Number 12.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2040.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "seaplok2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "seaplsl2"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "coraap", coraap
            "coralab", coralab
            "corap", corap
            "coravp", coravp
            "corgant", corgant
            "corhaap", corhaap
            "corhaapuw", corhaapuw
            "corhalab", corhalab
            "corhavp", corhavp
            "corhp", corhp
            "corlab", corlab
            "corsaap", corsaap
            "corsalab", corsalab
            "corsavp", corsavp
            "corvp", corvp
            "leghaap", leghaap
        ]
