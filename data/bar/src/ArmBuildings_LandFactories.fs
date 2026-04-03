// Auto-generated BAR unit data: ArmBuildings/LandFactories
namespace BarData.Units

open BarData

module ArmBuildings_LandFactories =

    let armaap =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMAAP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 32000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "144 70 144"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 29000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 3750.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 2900.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMAAP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "radaremitheight", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/ARMAAP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 312.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armaca"
                    LuaKey.Int 2, LuaValue.String "armbrawl"
                    LuaKey.Int 3, LuaValue.String "armpnix"
                    LuaKey.Int 4, LuaValue.String "armlance"
                    LuaKey.Int 5, LuaValue.String "armhawk"
                    LuaKey.Int 6, LuaValue.String "armawac"
                    LuaKey.Int 7, LuaValue.String "armdfly"
                    LuaKey.Int 8, LuaValue.String "armblade"
                    LuaKey.Int 9, LuaValue.String "armstil"
                    LuaKey.Int 10, LuaValue.String "armliche"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "airfactory", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armaap_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss, Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_noair_"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -17 -23"
                            LuaKey.String "collisionvolumescales", LuaValue.String "106 40 48"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2016.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 7.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1953.0
                            LuaKey.String "object", LuaValue.String "Units/armaap_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1008.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 977.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:YellowLight"
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

    let armalab =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMALAB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 25000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "124 75 140"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 15000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 4250.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 2600.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMALAB.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMALAB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 286.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo eeeeeeeee eeeeeeeee eeeeeeeee eeeeeeeee eeeeeeeee"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armack"
                    LuaKey.Int 2, LuaValue.String "armfark"
                    LuaKey.Int 3, LuaValue.String "armfast"
                    LuaKey.Int 4, LuaValue.String "armamph"
                    LuaKey.Int 5, LuaValue.String "armzeus"
                    LuaKey.Int 6, LuaValue.String "armmav"
                    LuaKey.Int 7, LuaValue.String "armsptk"
                    LuaKey.Int 8, LuaValue.String "armfido"
                    LuaKey.Int 9, LuaValue.String "armsnipe"
                    LuaKey.Int 10, LuaValue.String "armfboy"
                    LuaKey.Int 11, LuaValue.String "armspid"
                    LuaKey.Int 12, LuaValue.String "armaak"
                    LuaKey.Int 13, LuaValue.String "armvader"
                    LuaKey.Int 14, LuaValue.String "armdecom"
                    LuaKey.Int 15, LuaValue.String "armscab"
                    LuaKey.Int 16, LuaValue.String "armaser"
                    LuaKey.Int 17, LuaValue.String "armspy"
                    LuaKey.Int 18, LuaValue.String "armmark"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armalab_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -17 -1"
                            LuaKey.String "collisionvolumescales", LuaValue.String "73 56 89"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
                            LuaKey.String "damage", LuaValue.Number 2285.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1773.0
                            LuaKey.String "object", LuaValue.String "Units/armalab_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1143.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 887.0
                            LuaKey.String "object", LuaValue.String "Units/arm5X5A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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

    let armap =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMAP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5450.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "134 49 82"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 1100.0
            LuaKey.String "energystorage", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 2050.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 650.0
            LuaKey.String "metalstorage", LuaValue.Number 100.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMAP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 510.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "script", LuaValue.String "Units/ARMAP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 292.0
            LuaKey.String "terraformspeed", LuaValue.Number 500.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armca"
                    LuaKey.Int 2, LuaValue.String "armpeep"
                    LuaKey.Int 3, LuaValue.String "armfig"
                    LuaKey.Int 4, LuaValue.String "armthund"
                    LuaKey.Int 5, LuaValue.String "armatlas"
                    LuaKey.Int 6, LuaValue.String "armkam"
                    LuaKey.Int 7, LuaValue.String "armhvytrans"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "airfactory", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armap_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_noair_"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "11 -17 -23"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85 39 49"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1110.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 7.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 553.0
                            LuaKey.String "object", LuaValue.String "Units/armap_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 555.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 221.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:YellowLight"
                            LuaKey.Int 2, LuaValue.String "custom:radarpulse_t1_slow"
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

    let armavp =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMAVP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 27000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "130 86 140"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 14000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 4750.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 2600.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMAVP.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMAVP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 283.39999
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armacv"
                    LuaKey.Int 2, LuaValue.String "armconsul"
                    LuaKey.Int 3, LuaValue.String "armcroc"
                    LuaKey.Int 4, LuaValue.String "armlatnk"
                    LuaKey.Int 5, LuaValue.String "armbull"
                    LuaKey.Int 6, LuaValue.String "armgremlin"
                    LuaKey.Int 7, LuaValue.String "armmart"
                    LuaKey.Int 8, LuaValue.String "armmerl"
                    LuaKey.Int 9, LuaValue.String "armmanni"
                    LuaKey.Int 10, LuaValue.String "armyork"
                    LuaKey.Int 11, LuaValue.String "armseer"
                    LuaKey.Int 12, LuaValue.String "armjam"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armavp_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 2"
                            LuaKey.String "collisionvolumescales", LuaValue.String "96 70 96"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2578.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1754.0
                            LuaKey.String "object", LuaValue.String "Units/armavp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1289.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 877.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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

    let armhaap =
        LuaValue.Table [
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMAAP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 85000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "180 120 166"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 72000.0
            LuaKey.String "energystorage", LuaValue.Number 1400.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric-uw"
            LuaKey.String "footprintx", LuaValue.Number 15.0
            LuaKey.String "footprintz", LuaValue.Number 15.0
            LuaKey.String "health", LuaValue.Number 16000.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 4600.0
            LuaKey.String "metalstorage", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMHAAP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 750.0
            LuaKey.String "radaremitheight", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/ARMAAP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "workertime", LuaValue.Number 1800.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armhaca"
                    LuaKey.Int 2, LuaValue.String "armhawk"
                    LuaKey.Int 3, LuaValue.String "armpnix"
                    LuaKey.Int 4, LuaValue.String "armlance"
                    LuaKey.Int 5, LuaValue.String "armawac"
                    LuaKey.Int 6, LuaValue.String "armdfly"
                    LuaKey.Int 7, LuaValue.String "armliche"
                    LuaKey.Int 8, LuaValue.String "armblade"
                    LuaKey.Int 9, LuaValue.String "armbrawl"
                    LuaKey.Int 10, LuaValue.String "armstil"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 16.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 16.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armaap_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss, Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert3"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "2.5 0 -0.75"
                            LuaKey.String "collisionvolumescales", LuaValue.String "217 94 290"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 8640.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 14.0
                            LuaKey.String "footprintz", LuaValue.Number 14.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 4807.0
                            LuaKey.String "object", LuaValue.String "Units/armhaap_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4320.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1923.0
                            LuaKey.String "object", LuaValue.String "Units/arm7X7D.s3o"
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
                    LuaKey.String "build", LuaValue.String "seaplok1"
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
                            LuaKey.Int 1, LuaValue.String "seaplsl1"
                        ]
                ]
        ]

    let armhaapuw =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMPLAT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 42000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "144 70 144"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 24000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 3750.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "metalcost", LuaValue.Number 1900.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "minwaterdepth", LuaValue.Number 30.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMAAPLAT.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "radaremitheight", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/techsplit/ARMHAAPUW.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 312.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 200.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armaca"
                    LuaKey.Int 2, LuaValue.String "armseap"
                    LuaKey.Int 3, LuaValue.String "armsb"
                    LuaKey.Int 4, LuaValue.String "armsfig"
                    LuaKey.Int 5, LuaValue.String "armsehak"
                    LuaKey.Int 6, LuaValue.String "armsaber"
                    LuaKey.Int 7, LuaValue.String "armhvytrans"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "airfactory", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armaap_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss, Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -17 -23"
                            LuaKey.String "collisionvolumescales", LuaValue.String "106 40 48"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2016.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 7.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1953.0
                            LuaKey.String "object", LuaValue.String "Units/armhaap_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1008.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 977.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6A.s3o"
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
                    LuaKey.String "build", LuaValue.String "seaplok1"
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
                            LuaKey.Int 1, LuaValue.String "seaplsl1"
                        ]
                ]
        ]

    let armhalab =
        LuaValue.Table [
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMSHLTX.DDS"
            LuaKey.String "buildtime", LuaValue.Number 85000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "180 120 166"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "ARMSHLT_DEAD"
            LuaKey.String "energycost", LuaValue.Number 58000.0
            LuaKey.String "energystorage", LuaValue.Number 1400.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 16000.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 4800.0
            LuaKey.String "metalstorage", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMSHLTX.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMSHLTX.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armhack"
                    LuaKey.Int 2, LuaValue.String "armsnipe"
                    LuaKey.Int 3, LuaValue.String "armfboy"
                    LuaKey.Int 4, LuaValue.String "armaser"
                    LuaKey.Int 5, LuaValue.String "armdecom"
                    LuaKey.Int 6, LuaValue.String "armscab"
                    LuaKey.Int 7, LuaValue.String "armzeus"
                    LuaKey.Int 8, LuaValue.String "armmar"
                    LuaKey.Int 9, LuaValue.String "armspy"
                    LuaKey.Int 10, LuaValue.String "armaak"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armshltx_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert3"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "armshlt_dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "125 75 145"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 8640.0
                            LuaKey.String "featuredead", LuaValue.String "ARMSHLT_HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 4807.0
                            LuaKey.String "object", LuaValue.String "Units/armshltx_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "armshlt_heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4320.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1923.0
                            LuaKey.String "object", LuaValue.String "Units/arm7X7D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:YellowLight"
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

    let armhavp =
        LuaValue.Table [
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMHAVP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 85000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "180 120 166"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 51000.0
            LuaKey.String "energystorage", LuaValue.Number 1400.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 16000.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 4900.0
            LuaKey.String "metalstorage", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMHAVP.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMAMSUB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armhacv"
                    LuaKey.Int 2, LuaValue.String "armbull"
                    LuaKey.Int 3, LuaValue.String "armmerl"
                    LuaKey.Int 4, LuaValue.String "armmanni"
                    LuaKey.Int 5, LuaValue.String "armyork"
                    LuaKey.Int 6, LuaValue.String "armjam"
                    LuaKey.Int 7, LuaValue.String "armgremlin"
                    LuaKey.Int 8, LuaValue.String "armlun"
                    LuaKey.Int 9, LuaValue.String "armlatnk"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 19.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 19.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armamsub_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert3"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "125 75 145"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 8640.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 4807.0
                            LuaKey.String "object", LuaValue.String "Units/armamsub_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4320.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1923.0
                            LuaKey.String "object", LuaValue.String "Units/arm7X7D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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

    let armhp =
        LuaValue.Table [
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMHP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 8700.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumescales", LuaValue.String "100 40 90"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 2000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 3350.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 670.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMHP.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMHP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 286.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armch"
                    LuaKey.Int 2, LuaValue.String "armsh"
                    LuaKey.Int 3, LuaValue.String "armanac"
                    LuaKey.Int 4, LuaValue.String "armah"
                    LuaKey.Int 5, LuaValue.String "armmh"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armhp_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "techlevel", LuaValue.Number 1.5
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "116 20 104"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1803.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 8.0
                            LuaKey.String "footprintz", LuaValue.Number 7.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 621.0
                            LuaKey.String "object", LuaValue.String "Units/armhp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 902.0
                            LuaKey.String "footprintx", LuaValue.Number 8.0
                            LuaKey.String "footprintz", LuaValue.Number 7.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 248.0
                            LuaKey.String "object", LuaValue.String "Units/arm7X7A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "hoverok1"
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
                            LuaKey.Int 1, LuaValue.String "hoversl1"
                        ]
                ]
        ]

    let armlab =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMLAB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "84 22 84"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 950.0
            LuaKey.String "energystorage", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 2900.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 500.0
            LuaKey.String "metalstorage", LuaValue.Number 100.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMLAB.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMLAB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 290.0
            LuaKey.String "terraformspeed", LuaValue.Number 500.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooooooooooooeeeeeeeeeeeeeeeeee"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armck"
                    LuaKey.Int 2, LuaValue.String "armpw"
                    LuaKey.Int 3, LuaValue.String "armrectr"
                    LuaKey.Int 4, LuaValue.String "armrock"
                    LuaKey.Int 5, LuaValue.String "armham"
                    LuaKey.Int 6, LuaValue.String "armjeth"
                    LuaKey.Int 7, LuaValue.String "armwar"
                    LuaKey.Int 8, LuaValue.String "armflea"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armlab_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -7 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "95 22 95"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1614.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 458.0
                            LuaKey.String "object", LuaValue.String "Units/armlab_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 807.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 183.0
                            LuaKey.String "object", LuaValue.String "Units/arm5X5B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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

    let armsaap =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGAAP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 52000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "144 70 144"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 35000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 3750.0
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
            LuaKey.String "sightdistance", LuaValue.Number 312.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 200.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armcsa"
                    LuaKey.Int 2, LuaValue.String "armpnix"
                    LuaKey.Int 3, LuaValue.String "armlance"
                    LuaKey.Int 4, LuaValue.String "armhawk"
                    LuaKey.Int 5, LuaValue.String "armdfly"
                    LuaKey.Int 6, LuaValue.String "armblade"
                    LuaKey.Int 7, LuaValue.String "armstil"
                    LuaKey.Int 8, LuaValue.String "armliche"
                    LuaKey.Int 9, LuaValue.String "armsehak"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "airfactory", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/laap_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss, Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -17 -23"
                            LuaKey.String "collisionvolumescales", LuaValue.String "106 40 48"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2016.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 7.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1953.0
                            LuaKey.String "object", LuaValue.String "Units/legaap_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1008.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 977.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:YellowLight"
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

    let armsalab =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGALAB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 51000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "124 75 140"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 35000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 4250.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 3500.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGALAB.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGALAB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 286.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 300.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo eeeeeeeee eeeeeeeee eeeeeeeee eeeeeeeee eeeeeeeee"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armsack"
                    LuaKey.Int 2, LuaValue.String "armsnipe"
                    LuaKey.Int 3, LuaValue.String "armfboy"
                    LuaKey.Int 4, LuaValue.String "armsptk"
                    LuaKey.Int 5, LuaValue.String "armscab"
                    LuaKey.Int 6, LuaValue.String "armaser"
                    LuaKey.Int 7, LuaValue.String "armmark"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armalab_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -17 -1"
                            LuaKey.String "collisionvolumescales", LuaValue.String "73 56 89"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylZ"
                            LuaKey.String "damage", LuaValue.Number 2285.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1773.0
                            LuaKey.String "object", LuaValue.String "Units/legalab_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1143.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 887.0
                            LuaKey.String "object", LuaValue.String "Units/arm5X5A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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

    let armsavp =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGAVP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 51000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "130 86 140"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 35000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 4750.0
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
            LuaKey.String "sightdistance", LuaValue.Number 283.39999
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 300.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armsacv"
                    LuaKey.Int 2, LuaValue.String "armgremlin"
                    LuaKey.Int 3, LuaValue.String "armmerl"
                    LuaKey.Int 4, LuaValue.String "armmanni"
                    LuaKey.Int 5, LuaValue.String "armseer"
                    LuaKey.Int 6, LuaValue.String "armjam"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armavp_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 2"
                            LuaKey.String "collisionvolumescales", LuaValue.String "96 70 96"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2578.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1754.0
                            LuaKey.String "object", LuaValue.String "Units/legavp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1289.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 877.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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

    let armshltx =
        LuaValue.Table [
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMSHLTX.DDS"
            LuaKey.String "buildtime", LuaValue.Number 62000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "180 120 166"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "ARMSHLT_DEAD"
            LuaKey.String "energycost", LuaValue.Number 58000.0
            LuaKey.String "energystorage", LuaValue.Number 1400.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 16000.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 7900.0
            LuaKey.String "metalstorage", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMSHLTX.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMSHLTX.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "workertime", LuaValue.Number 1800.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee eeeeeeeeeeee"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armbanth"
                    LuaKey.Int 2, LuaValue.String "armraz"
                    LuaKey.Int 3, LuaValue.String "armmar"
                    LuaKey.Int 4, LuaValue.String "armvang"
                    LuaKey.Int 5, LuaValue.String "armlun"
                    LuaKey.Int 6, LuaValue.String "armthor"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armshltx_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert3"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "armshlt_dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "125 75 145"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 8640.0
                            LuaKey.String "featuredead", LuaValue.String "ARMSHLT_HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 4807.0
                            LuaKey.String "object", LuaValue.String "Units/armshltx_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "armshlt_heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4320.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1923.0
                            LuaKey.String "object", LuaValue.String "Units/arm7X7D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:YellowLight"
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

    let armvp =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMVP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5700.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumescales", LuaValue.String "120 34 92"
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
            LuaKey.String "metalcost", LuaValue.Number 590.0
            LuaKey.String "metalstorage", LuaValue.Number 100.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMVP.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMVP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 500.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "oooooo oooooo oooooo oeeeeo oeeeeo oeeeeo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armcv"
                    LuaKey.Int 2, LuaValue.String "armbeaver"
                    LuaKey.Int 3, LuaValue.String "armmlv"
                    LuaKey.Int 4, LuaValue.String "armfav"
                    LuaKey.Int 5, LuaValue.String "armflash"
                    LuaKey.Int 6, LuaValue.String "armpincer"
                    LuaKey.Int 7, LuaValue.String "armstump"
                    LuaKey.Int 8, LuaValue.String "armart"
                    LuaKey.Int 9, LuaValue.String "armjanus"
                    LuaKey.Int 10, LuaValue.String "armsam"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armvp_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Cremuss"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandFactories"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-5 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "110 34 92"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1668.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 483.0
                            LuaKey.String "object", LuaValue.String "Units/armvp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 834.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 193.0
                            LuaKey.String "object", LuaValue.String "Units/arm6X6A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
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

    let all : (string * LuaValue) list =
        [
            "armaap", armaap
            "armalab", armalab
            "armap", armap
            "armavp", armavp
            "armhaap", armhaap
            "armhaapuw", armhaapuw
            "armhalab", armhalab
            "armhavp", armhavp
            "armhp", armhp
            "armlab", armlab
            "armsaap", armsaap
            "armsalab", armsalab
            "armsavp", armsavp
            "armshltx", armshltx
            "armvp", armvp
        ]
