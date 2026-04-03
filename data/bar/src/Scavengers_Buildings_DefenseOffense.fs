// Auto-generated BAR unit data: Scavengers/Buildings/DefenseOffense
namespace BarData.Units

open BarData

module Scavengers_Buildings_DefenseOffense =

    let armannit3 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "energycost", LuaValue.Number 450000.0
            LuaKey.String "metalcost", LuaValue.Number 13500.0
            LuaKey.String "buildpic", LuaValue.String "ARMANNIT3.DDS"
            LuaKey.String "buildtime", LuaValue.Number 190000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 15 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "81 122 81"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.25
            LuaKey.String "energystorage", LuaValue.Number 3000.0
            LuaKey.String "explodeas", LuaValue.String "fusionExplosion"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "sightemitheight", LuaValue.Number 72.0
            LuaKey.String "health", LuaValue.Number 28000.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/scavbuildings/ARMANNIT3.s3o"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "radardistance", LuaValue.Number 1500.0
            LuaKey.String "radaremitheight", LuaValue.Number 72.0
            LuaKey.String "script", LuaValue.String "Units/ARMANNI.cob"
            LuaKey.String "usePieceCollisionVolumes", LuaValue.Number 1.0
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "fusionExplosion"
            LuaKey.String "sightdistance", LuaValue.Number 900.0
            LuaKey.String "yardmap", LuaValue.String "oooooo oooooo oooooo oooooo oooooo oooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armannit3_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Cremuss"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 1.06567382829e-05 -0.0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "62.5 81.7362213135 62.5"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1800.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 5820.0
                            LuaKey.String "object", LuaValue.String "Units/scavbuildings/armannit3_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 900.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2328.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:tachyonshot"
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
                            LuaKey.Int 1, LuaValue.String "obli"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "obli"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "ata", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 1.0
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.5
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "energypershot", LuaValue.Number 7000.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-large-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 8.0
                            LuaKey.String "name", LuaValue.String "Heavy long-range g2g tachyon accelerator beam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1800.0
                            LuaKey.String "reloadtime", LuaValue.Number 15.0
                            LuaKey.String "rgbcolor", LuaValue.String "0 0 1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "annigun1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "texture3", LuaValue.String "largebeam"
                            LuaKey.String "thickness", LuaValue.Number 10.0
                            LuaKey.String "tilelength", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3100.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 480.0
                                    LuaKey.String "default", LuaValue.Number 48000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "ATA"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let armbotrail =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 32700.0
            LuaKey.String "energycost", LuaValue.Number 192000.0
            LuaKey.String "metalcost", LuaValue.Number 13500.0
            LuaKey.String "buildpic", LuaValue.String "ARMBOTRAIL.DDS"
            LuaKey.String "buildtime", LuaValue.Number 255000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 -20"
            LuaKey.String "collisionvolumescales", LuaValue.String "48 90 48"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingExplosionGeneric"
            LuaKey.String "firestate", LuaValue.Number 0.0
            LuaKey.String "footprintx", LuaValue.Number 8.0
            LuaKey.String "footprintz", LuaValue.Number 8.0
            LuaKey.String "health", LuaValue.Number 4450.0
            LuaKey.String "maxslope", LuaValue.Number 12.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "scavs/armbotrail.s3o"
            LuaKey.String "script", LuaValue.String "scavs/armbotrail.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 1.0
            LuaKey.String "yardmap", LuaValue.String "oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo "
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armbotrail_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_nolrpc_"
                    LuaKey.String "canareaattack", LuaValue.Number 1.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 1.0
                    LuaKey.String "childreninheritxp", LuaValue.String "BOTCANNON"
                    LuaKey.String "parentsinheritxp", LuaValue.String "BOTCANNON"
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
                            LuaKey.String "object", LuaValue.String "Units/armbrtha_dead.s3o"
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
                            LuaKey.Int 1, LuaValue.String "custom:tachyonshot"
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
                    LuaKey.String "arm_botrail", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1.0
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-botrail"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 116.0
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 2880.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:botrailspawn"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 8.0
                            LuaKey.String "hightrajectory", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "leadbonus", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 96.0
                            LuaKey.String "model", LuaValue.String "armpw_anim_projectile.s3o"
                            LuaKey.String "mygravity", LuaValue.Number 0.22
                            LuaKey.String "name", LuaValue.String "Long range bot cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 5250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "sprayangle", LuaValue.Number 720.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 3.0
                            LuaKey.String "soundhit", LuaValue.String "xplonuk1xs"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 50.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterbounce", LuaValue.Bool true
                            LuaKey.String "bounceSlip", LuaValue.Number 0.74
                            LuaKey.String "bouncerebound", LuaValue.Number 0.5
                            LuaKey.String "numbounce", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1250.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "armpw"
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 50.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 10.0
                                    LuaKey.String "shields", LuaValue.Number 150.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "ARM_BOTRAIL"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let armlwall =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 4800.0
            LuaKey.String "metalcost", LuaValue.Number 1020.0
            LuaKey.String "buildpic", LuaValue.String "ARMLWALL.DDS"
            LuaKey.String "buildtime", LuaValue.Number 14000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 50 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "crushresistance", LuaValue.Number 1000.0
            LuaKey.String "damagemodifier", LuaValue.Number 0.25
            LuaKey.String "decoyfor", LuaValue.String "armfort"
            LuaKey.String "explodeas", LuaValue.String "smallBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000000000.0
            LuaKey.String "health", LuaValue.Number 5320.0
            LuaKey.String "maxslope", LuaValue.Number 24.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/ARMLWALL.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMLWALL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 330.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "neutral_when_closed", LuaValue.Bool true
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armfort_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "decoyfor", LuaValue.String "armfort"
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "autoreclaimable", LuaValue.Number 0.0
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32 50 32"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 540.0
                            LuaKey.String "featuredead", LuaValue.String "ROCKTEETH"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 205.0
                            LuaKey.String "object", LuaValue.String "Units/armfort.s3o"
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
                            LuaKey.String "object", LuaValue.String "Units/arm1X1A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "shadtrans", LuaValue.Number 1.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-lightning"
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
                    LuaKey.String "lightning", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 10.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 5.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-lightning2"
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 28.0
                            LuaKey.String "name", LuaValue.String "Medium Lightning Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 315.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.33
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0.5 1"
                            LuaKey.String "soundhit", LuaValue.String "lashit"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lghthvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "thickness", LuaValue.Number 2.2
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LightningCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "spark_ceg", LuaValue.String "genericshellexplosion-splash-lightning"
                                    LuaKey.String "spark_forkdamage", LuaValue.String "0.3"
                                    LuaKey.String "spark_maxunits", LuaValue.String "3"
                                    LuaKey.String "spark_range", LuaValue.String "80"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 64.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "lightning"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let armminivulc =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 29096.0
            LuaKey.String "energycost", LuaValue.Number 60000.0
            LuaKey.String "metalcost", LuaValue.Number 2000.0
            LuaKey.String "buildpic", LuaValue.String "ARMMINIVULC.DDS"
            LuaKey.String "buildtime", LuaValue.Number 65000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -6 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 64 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 6700.0
            LuaKey.String "maxslope", LuaValue.Number 13.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/scavbuildings/armminivulc.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavbuildings/armminivulc.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 700.0
            LuaKey.String "yardmap", LuaValue.String "ooo ooo ooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armminivulc_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32 64 32"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 3000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 6000.0
                            LuaKey.String "object", LuaValue.String "Units/scavbuildings/armminivulc_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1500.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 3000.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-large"
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
                    LuaKey.String "armminivulc_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 700.0
                            LuaKey.String "areaofeffect", LuaValue.Number 44.8
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "avoidground", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "arty-heavy"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.02
                            LuaKey.String "cratermult", LuaValue.Number 0.02
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.9
                            LuaKey.String "energypershot", LuaValue.Number 1000.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-bomb"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.1
                            LuaKey.String "name", LuaValue.String "Mini Rapid-fire long-range plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1, 0.4, 0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "cannon2"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 14.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 660.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 210.0
                                    LuaKey.String "shields", LuaValue.Number 105.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "ARMMINIVULC_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let cordoomt3 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "energycost", LuaValue.Number 400000.0
            LuaKey.String "metalcost", LuaValue.Number 12000.0
            LuaKey.String "buildpic", LuaValue.String "CORDOOMT3.DDS"
            LuaKey.String "buildtime", LuaValue.Number 170000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -7.5 0.0"
            LuaKey.String "collisionvolumescales", LuaValue.String "72.0 165.0 72.0"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.25
            LuaKey.String "energystorage", LuaValue.Number 1000.0
            LuaKey.String "explodeas", LuaValue.String "fusionExplosion"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "sightemitheight", LuaValue.Number 80.0
            LuaKey.String "health", LuaValue.Number 39000.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/scavbuildings/CORDOOMT3.s3o"
            LuaKey.String "usePieceCollisionVolumes", LuaValue.Number 1.0
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "radardistance", LuaValue.Number 1200.0
            LuaKey.String "radaremitheight", LuaValue.Number 80.0
            LuaKey.String "script", LuaValue.String "Units/CORDOOM.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "fusionExplosion"
            LuaKey.String "sightdistance", LuaValue.Number 900.0
            LuaKey.String "yardmap", LuaValue.String "yyooyy oooooo oooooo oooooo oooooo yyooyy"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/cordoomt3_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.4
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.281730651855 -0.153618286133 3.57356262207"
                            LuaKey.String "collisionvolumescales", LuaValue.String "80.6815948486 91.7637634277 82.1471252441"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 5400.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 4833.0
                            LuaKey.String "object", LuaValue.String "Units/scavbuildings/cordoomt3_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 2700.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1932.0
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
                            LuaKey.Int 1, LuaValue.String "armag"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "armag"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armagmheat", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 72.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.6
                            LuaKey.String "cameraShake", LuaValue.Number 350.0
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 1200.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-beam"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Armageddon Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1350.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.8 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0 0"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heatray2xl"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 7.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 1350.0
                                    LuaKey.String "default", LuaValue.Number 7500.0
                                    LuaKey.String "vtol", LuaValue.Number 3000.0
                                ]
                        ]
                    LuaKey.String "armageddon_blue_laser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "corethickness", LuaValue.Number 0.32
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-large-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Long-range g2g tachyon accelerator"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 0.0
                            LuaKey.String "range", LuaValue.Number 950.0
                            LuaKey.String "reloadtime", LuaValue.Number 6.0
                            LuaKey.String "rgbcolor", LuaValue.String "0 0 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "annigun1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "texture3", LuaValue.String "largebeam"
                            LuaKey.String "thickness", LuaValue.Number 5.5
                            LuaKey.String "tilelength", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 999.0
                                    LuaKey.String "default", LuaValue.Number 4500.0
                                ]
                        ]
                    LuaKey.String "armageddon_green_laser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.25
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 50.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-green"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "High energy g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 0.0
                            LuaKey.String "range", LuaValue.Number 650.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.26
                            LuaKey.String "rgbcolor", LuaValue.String "0 1 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrhvy3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.6
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 247.0
                                    LuaKey.String "vtol", LuaValue.Number 65.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "ARMAGMHEAT"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMAGEDDON_BLUE_LASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMAGEDDON_GREEN_LASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corhllllt =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 32768.0
            LuaKey.String "energycost", LuaValue.Number 7000.0
            LuaKey.String "metalcost", LuaValue.Number 300.0
            LuaKey.String "buildpic", LuaValue.String "CORHLLLLT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 8800.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0-20 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 160 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "mass", LuaValue.Number 10200.0
            LuaKey.String "health", LuaValue.Number 1670.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/scavbuildings/CORHLLLLT.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavbuildings/CORHLLLLT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 475.0
            LuaKey.String "yardmap", LuaValue.String "oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corhllt_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 35 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32 140 32"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 900.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 6.5
                            LuaKey.String "metal", LuaValue.Number 180.0
                            LuaKey.String "object", LuaValue.String "Units/scavbuildings/corhllllt_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 450.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 1.0
                            LuaKey.String "metal", LuaValue.Number 72.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4D.s3o"
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
                            LuaKey.Int 1, LuaValue.String "hlltselect"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "hllt_1", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.05
                            LuaKey.String "corethickness", LuaValue.Number 0.175
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 15.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Close-quarters light g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 475.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.2
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2250.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 100.0
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "vtol", LuaValue.Number 5.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                ]
                        ]
                    LuaKey.String "hllt_2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "corethickness", LuaValue.Number 0.175
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 15.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Close-quarters light g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 475.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.3
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2250.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 100.0
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "vtol", LuaValue.Number 5.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "norangering", LuaValue.Number 1.0
                                ]
                        ]
                    LuaKey.String "hllt_3", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.15
                            LuaKey.String "corethickness", LuaValue.Number 0.175
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 15.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Close-quarters light g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 475.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2250.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 100.0
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "vtol", LuaValue.Number 5.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "norangering", LuaValue.Number 1.0
                                ]
                        ]
                    LuaKey.String "hllt_4", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.2
                            LuaKey.String "corethickness", LuaValue.Number 0.175
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 15.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Close-quarters light g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 475.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2250.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 100.0
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "vtol", LuaValue.Number 5.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "norangering", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "HLLT_1"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "HLLT_2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "HLLT_3"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "HLLT_4"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corminibuzz =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 29096.0
            LuaKey.String "energycost", LuaValue.Number 60000.0
            LuaKey.String "metalcost", LuaValue.Number 2000.0
            LuaKey.String "buildpic", LuaValue.String "CORMINIBUZZ.DDS"
            LuaKey.String "buildtime", LuaValue.Number 65000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -6 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 64 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 6700.0
            LuaKey.String "maxslope", LuaValue.Number 13.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/scavbuildings/CORMINIBUZZ.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavbuildings/CORMINIBUZZ.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 700.0
            LuaKey.String "yardmap", LuaValue.String "ooo ooo ooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corminibuzz_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32 64 32"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 3000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 10.0
                            LuaKey.String "metal", LuaValue.Number 6000.0
                            LuaKey.String "object", LuaValue.String "Units/scavbuildings/corminibuzz_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1500.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 2.0
                            LuaKey.String "metal", LuaValue.Number 3000.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3A.s3o"
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
                            LuaKey.Int 1, LuaValue.String "servlrg4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servlrg4"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corminibuzz_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 700.0
                            LuaKey.String "areaofeffect", LuaValue.Number 44.8
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "avoidground", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "arty-heavy"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.02
                            LuaKey.String "cratermult", LuaValue.Number 0.02
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.9
                            LuaKey.String "energypershot", LuaValue.Number 1000.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-bomb"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.1
                            LuaKey.String "name", LuaValue.String "Mini Rapid-fire long-range plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1450.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1, 0.4, 0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "cannon2"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 14.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 660.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 210.0
                                    LuaKey.String "shields", LuaValue.Number 105.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "CORMINIBUZZ_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let cormwall =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 4800.0
            LuaKey.String "metalcost", LuaValue.Number 1020.0
            LuaKey.String "buildpic", LuaValue.String "CORMWALL.DDS"
            LuaKey.String "buildtime", LuaValue.Number 14000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 50 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.25
            LuaKey.String "decoyfor", LuaValue.String "corfort"
            LuaKey.String "explodeas", LuaValue.String "smallBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000000000.0
            LuaKey.String "health", LuaValue.Number 5320.0
            LuaKey.String "maxslope", LuaValue.Number 24.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/CORMWALL.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORMWALL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 330.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "neutral_when_closed", LuaValue.Bool true
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corfort_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "decoyfor", LuaValue.String "armfort"
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "autoreclaimable", LuaValue.Number 0.0
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32 50 32"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 540.0
                            LuaKey.String "featuredead", LuaValue.String "ROCKTEETH"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 205.0
                            LuaKey.String "object", LuaValue.String "Units/corfort.s3o"
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
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "shadtrans", LuaValue.Number 1.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:flamestreamxm"
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
                    LuaKey.String "exp_heavyrocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 96.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 7.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "cegtag", LuaValue.String "missiletrailsmall-red"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "dance", LuaValue.Number 24.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-catapult"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 3.2
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "catapultmissile.s3o"
                            LuaKey.String "movingaccuracy", LuaValue.Number 600.0
                            LuaKey.String "name", LuaValue.String "CatapultRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 675.0
                            LuaKey.String "reloadtime", LuaValue.Number 15.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 4.0
                            LuaKey.String "smoketime", LuaValue.Number 16.0
                            LuaKey.String "smokesize", LuaValue.Number 8.5
                            LuaKey.String "smokecolor", LuaValue.Number 0.5
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "rockhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "rapidrocket3"
                            LuaKey.String "startvelocity", LuaValue.Number 165.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "trajectoryheight", LuaValue.Number 3.0
                            LuaKey.String "turnrate", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 100.0
                            LuaKey.String "weapontimer", LuaValue.Number 6.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 530.0
                            LuaKey.String "wobble", LuaValue.Number 2000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 450.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "overrange_distance", LuaValue.Number 777.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "exp_heavyrocket"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let corscavdrag =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 8.0
            LuaKey.String "buildpic", LuaValue.String "scavengers/CORSCAVDRAG.DDS"
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
            LuaKey.String "objectname", LuaValue.String "scavs/scavdrag.s3o"
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/cordrag.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "WallExplosionConcrete"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 1.0
            LuaKey.String "sightdistance", LuaValue.Number 1.0
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/scavdtf_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
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

    let corscavdtf =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 1550.0
            LuaKey.String "metalcost", LuaValue.Number 290.0
            LuaKey.String "buildpic", LuaValue.String "CORSCAVDTF.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4400.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.25
            LuaKey.String "decoyfor", LuaValue.String "scavdrag"
            LuaKey.String "energystorage", LuaValue.Number 15.0
            LuaKey.String "explodeas", LuaValue.String "flamethrower"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000000000.0
            LuaKey.String "health", LuaValue.Number 1610.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "scavs/SCAVDTF.s3o"
            LuaKey.String "radardistancejam", LuaValue.Number 8.0
            LuaKey.String "script", LuaValue.String "units/scavbuildings/SCAVDTF.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "flamethrowerSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 422.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/scavdtf_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "decoyfor", LuaValue.String "corscavdrag"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
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
                            LuaKey.String "object", LuaValue.String "scavs/scavdrag.s3o"
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
                            LuaKey.String "object", LuaValue.String "Units/cor1X1B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "shadtrans", LuaValue.Number 1.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:flamestreamxm"
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
                    LuaKey.String "dmaw", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 22.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "burnflame"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.82 0.03   0.7 0.4 0.25 0.027   0.44 0.25 0.15 0.024   0.033 0.018 0.011 0.02   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnblack"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flamegfxtime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.75
                            LuaKey.String "name", LuaValue.String "Pop-up anti-swarm AoE flamethrower"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 410.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.1
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.84 0.8"
                            LuaKey.String "sizegrowth", LuaValue.Number 0.7
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Flamhvy1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 7.5
                            LuaKey.String "soundstartvolume", LuaValue.Number 5.3
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "sprayangle", LuaValue.Number 100.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.001
                            LuaKey.String "tolerance", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 12.0
                                    LuaKey.String "default", LuaValue.Number 16.0
                                    LuaKey.String "subs", LuaValue.Number 5.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DMAW"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let corscavdtl =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 1600.0
            LuaKey.String "metalcost", LuaValue.Number 340.0
            LuaKey.String "buildpic", LuaValue.String "CORSCAVDTL.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4600.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -24 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "30 51 30"
            LuaKey.String "collisionvolumetype", LuaValue.String "Ell"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.25
            LuaKey.String "decoyfor", LuaValue.String "scavdrag"
            LuaKey.String "explodeas", LuaValue.String "smallBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000000000.0
            LuaKey.String "health", LuaValue.Number 1330.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "scavs/SCAVDTL.s3o"
            LuaKey.String "radardistancejam", LuaValue.Number 8.0
            LuaKey.String "script", LuaValue.String "units/scavbuildings/SCAVDTL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 440.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/scavdtf_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "decoyfor", LuaValue.String "corscavdrag"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "autoreclaimable", LuaValue.Number 0.0
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 2.37060546837e-06 -0.0625"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32.0 17.7499847412 31.375"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 540.0
                            LuaKey.String "featuredead", LuaValue.String "ROCKTEETH"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 205.0
                            LuaKey.String "object", LuaValue.String "scavs/scavdrag.s3o"
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
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "shadtrans", LuaValue.Number 1.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-lightning"
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
                    LuaKey.String "dclaw", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 10.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-lightning2"
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 24.0
                            LuaKey.String "name", LuaValue.String "Close-quarters g2g lightning turret"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 440.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.13333
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0.5 1"
                            LuaKey.String "soundhit", LuaValue.String "lashit"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lghthvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LightningCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spark_ceg", LuaValue.String "genericshellexplosion-splash-lightning"
                                    LuaKey.String "spark_forkdamage", LuaValue.String "0.33"
                                    LuaKey.String "spark_maxunits", LuaValue.String "2"
                                    LuaKey.String "spark_range", LuaValue.String "60"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 39.0
                                    LuaKey.String "default", LuaValue.Number 21.0
                                    LuaKey.String "vtol", LuaValue.Number 2.5
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DCLAW"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let corscavdtm =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 1550.0
            LuaKey.String "metalcost", LuaValue.Number 290.0
            LuaKey.String "buildpic", LuaValue.String "CORSCAVDTM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4400.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.25
            LuaKey.String "decoyfor", LuaValue.String "scavdrag"
            LuaKey.String "explodeas", LuaValue.String "flamethrower"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000000000.0
            LuaKey.String "health", LuaValue.Number 1610.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "scavs/SCAVDTM.s3o"
            LuaKey.String "radardistancejam", LuaValue.Number 8.0
            LuaKey.String "script", LuaValue.String "units/scavbuildings/SCAVDTM.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "flamethrowerSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 422.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/scavdtf_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "decoyfor", LuaValue.String "corscavdrag"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
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
                            LuaKey.String "object", LuaValue.String "scavs/scavdrag.s3o"
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
                    LuaKey.String "cormh_weapon", LuaValue.Table [
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
                            LuaKey.String "model", LuaValue.String "corkbmissl1.s3o"
                            LuaKey.String "name", LuaValue.String "Rocket"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "smoketrail", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "null"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 70.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.9
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 480.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 550.0
                                    LuaKey.String "subs", LuaValue.Number 200.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "overrange_distance", LuaValue.Number 575.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "CORMH_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let corscavfort =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 500.0
            LuaKey.String "metalcost", LuaValue.Number 40.0
            LuaKey.String "buildpic", LuaValue.String "scavengers/SCAVFORT.DDS"
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
            LuaKey.String "objectname", LuaValue.String "scavs/SCAVFORT.s3o"
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "scavs/SCAVFORT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "WallExplosionConcrete"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 1.0
            LuaKey.String "sightdistance", LuaValue.Number 1.0
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corscavfort_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "objectify", LuaValue.Bool true
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other/scavengers"
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

    let legdtf =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 1550.0
            LuaKey.String "metalcost", LuaValue.Number 290.0
            LuaKey.String "buildpic", LuaValue.String "CORSCAVDTF.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4400.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.33
            LuaKey.String "decoyfor", LuaValue.String "scavdrag"
            LuaKey.String "energystorage", LuaValue.Number 15.0
            LuaKey.String "explodeas", LuaValue.String "flamethrower"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000000000.0
            LuaKey.String "health", LuaValue.Number 1610.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "scavs/SCAVDTF.s3o"
            LuaKey.String "radardistancejam", LuaValue.Number 8.0
            LuaKey.String "script", LuaValue.String "units/scavbuildings/SCAVDTF.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "flamethrowerSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 422.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/scavdtf_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "decoyfor", LuaValue.String "corscavdrag"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
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
                            LuaKey.String "object", LuaValue.String "scavs/scavdrag.s3o"
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
                            LuaKey.String "object", LuaValue.String "Units/cor1X1B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "shadtrans", LuaValue.Number 1.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:flamestreamxm"
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
                    LuaKey.String "dmaw", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 22.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "burnflame"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.82 0.03   0.7 0.4 0.25 0.027   0.44 0.25 0.15 0.024   0.033 0.018 0.011 0.02   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnblack"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flamegfxtime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.75
                            LuaKey.String "name", LuaValue.String "Pop-up anti-swarm AoE flamethrower"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 410.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.1
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.84 0.8"
                            LuaKey.String "sizegrowth", LuaValue.Number 0.7
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Flamhvy1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 7.5
                            LuaKey.String "soundstartvolume", LuaValue.Number 5.3
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "sprayangle", LuaValue.Number 100.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.001
                            LuaKey.String "tolerance", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 12.0
                                    LuaKey.String "default", LuaValue.Number 16.0
                                    LuaKey.String "subs", LuaValue.Number 5.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DMAW"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let legdtl =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 1600.0
            LuaKey.String "metalcost", LuaValue.Number 340.0
            LuaKey.String "buildpic", LuaValue.String "CORSCAVDTL.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4600.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -24 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "30 51 30"
            LuaKey.String "collisionvolumetype", LuaValue.String "Ell"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.33
            LuaKey.String "decoyfor", LuaValue.String "scavdrag"
            LuaKey.String "explodeas", LuaValue.String "smallBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000000000.0
            LuaKey.String "health", LuaValue.Number 1330.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "scavs/SCAVDTL.s3o"
            LuaKey.String "radardistancejam", LuaValue.Number 8.0
            LuaKey.String "script", LuaValue.String "units/scavbuildings/SCAVDTL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 440.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/scavdtf_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "decoyfor", LuaValue.String "corscavdrag"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "autoreclaimable", LuaValue.Number 0.0
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 2.37060546837e-06 -0.0625"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32.0 17.7499847412 31.375"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 540.0
                            LuaKey.String "featuredead", LuaValue.String "ROCKTEETH"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 205.0
                            LuaKey.String "object", LuaValue.String "scavs/scavdrag.s3o"
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
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "shadtrans", LuaValue.Number 1.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-lightning"
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
                    LuaKey.String "dclaw", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 10.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-lightning2"
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 24.0
                            LuaKey.String "name", LuaValue.String "Close-quarters g2g lightning turret"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 440.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.13333
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0.5 1"
                            LuaKey.String "soundhit", LuaValue.String "lashit"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lghthvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LightningCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spark_ceg", LuaValue.String "genericshellexplosion-splash-lightning"
                                    LuaKey.String "spark_forkdamage", LuaValue.String "0.33"
                                    LuaKey.String "spark_maxunits", LuaValue.String "2"
                                    LuaKey.String "spark_range", LuaValue.String "60"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 39.0
                                    LuaKey.String "default", LuaValue.Number 21.0
                                    LuaKey.String "vtol", LuaValue.Number 2.5
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DCLAW"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let legdtm =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 1550.0
            LuaKey.String "metalcost", LuaValue.Number 290.0
            LuaKey.String "buildpic", LuaValue.String "CORSCAVDTM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4400.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.33
            LuaKey.String "decoyfor", LuaValue.String "scavdrag"
            LuaKey.String "explodeas", LuaValue.String "flamethrower"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000000000.0
            LuaKey.String "health", LuaValue.Number 1610.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "scavs/SCAVDTM.s3o"
            LuaKey.String "radardistancejam", LuaValue.Number 8.0
            LuaKey.String "script", LuaValue.String "units/scavbuildings/SCAVDTM.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "flamethrowerSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 422.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/scavdtf_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "decoyfor", LuaValue.String "corscavdrag"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
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
                            LuaKey.String "object", LuaValue.String "scavs/scavdrag.s3o"
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
                    LuaKey.String "cormh_weapon", LuaValue.Table [
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
                            LuaKey.String "model", LuaValue.String "corkbmissl1.s3o"
                            LuaKey.String "name", LuaValue.String "Rocket"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "smoketrail", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "null"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 70.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.9
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 480.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 550.0
                                    LuaKey.String "subs", LuaValue.Number 200.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "overrange_distance", LuaValue.Number 575.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "CORMH_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let legministarfall =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.0
            LuaKey.String "brakerate", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 29096.0
            LuaKey.String "buildcostenergy", LuaValue.Number 60000.0
            LuaKey.String "buildcostmetal", LuaValue.Number 2000.0
            LuaKey.String "buildpic", LuaValue.String "LEGSTARFALL.DDS"
            LuaKey.String "buildtime", LuaValue.Number 65000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "52 65 52"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "maxdamage", LuaValue.Number 7000.0
            LuaKey.String "maxslope", LuaValue.Number 13.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/scavbuildings/legministarfall.s3o"
            LuaKey.String "script", LuaValue.String "Units/scavbuildings/legministarfall.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 700.0
            LuaKey.String "yardmap", LuaValue.String "ooo ooo ooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "45 60 45"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 3000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 6000.0
                            LuaKey.String "object", LuaValue.String "Units/scavbuildings/legministarfall_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1500.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 3000.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3A.s3o"
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
                            LuaKey.Int 1, LuaValue.String "servlrg3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servlrg3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "starfire", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 55.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 63.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03
                            LuaKey.String "sprayangle", LuaValue.Number 400.0
                            LuaKey.String "highTrajectory", LuaValue.Number 1.0
                            LuaKey.String "cegtag", LuaValue.String "ministarfire"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.95
                            LuaKey.String "energypershot", LuaValue.Number 20000.0
                            LuaKey.String "fireTolerance", LuaValue.Number 364.0
                            LuaKey.String "tolerance", LuaValue.Number 364.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:ministarfire-explosion"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Long-Range High-Trajectory 63-Salvo Plasma Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1400.0
                            LuaKey.String "reloadtime", LuaValue.Number 7.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1.0"
                            LuaKey.String "soundhit", LuaValue.String "xplomed3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "cannon2"
                            LuaKey.String "soundhitvolume", LuaValue.Number 20.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 14.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "windup", LuaValue.Number 2.5
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 125.0
                                    LuaKey.String "shields", LuaValue.Number 110.0
                                    LuaKey.String "subs", LuaValue.Number 10.0
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
                            LuaKey.String "name", LuaValue.String "Mini Plasma Volley Energy Charger (supplies energy to Mini Starfall cannon)"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "range", LuaValue.Number 1.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "size", LuaValue.Number 0.0
                            LuaKey.String "soundhit", LuaValue.String "ministarfallchargup"
                            LuaKey.String "soundhitwet", LuaValue.String "ministarfallchargup"
                            LuaKey.String "soundstart", LuaValue.String "ministarfallchargup"
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

    let legrwall =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 6000.0
            LuaKey.String "metalcost", LuaValue.Number 1250.0
            LuaKey.String "buildpic", LuaValue.String "legrwall.DDS"
            LuaKey.String "buildtime", LuaValue.Number 12000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -8 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 42 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.25
            LuaKey.String "decoyfor", LuaValue.String "corfort"
            LuaKey.String "explodeas", LuaValue.String "smallBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000000000.0
            LuaKey.String "health", LuaValue.Number 9600.0
            LuaKey.String "maxslope", LuaValue.Number 24.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/legrwall.s3o"
            LuaKey.String "script", LuaValue.String "Units/legrwall.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 330.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "neutral_when_closed", LuaValue.Bool true
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legforti_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "decoyfor", LuaValue.String "armfort"
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "autoreclaimable", LuaValue.Number 0.0
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32 50 32"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 540.0
                            LuaKey.String "featuredead", LuaValue.String "ROCKTEETH"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 205.0
                            LuaKey.String "object", LuaValue.String "Units/legforti.s3o"
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
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "shadtrans", LuaValue.Number 1.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:flamestreamxm"
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
                    LuaKey.String "railgunt2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "railgun"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.12
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "energypershot", LuaValue.Number 250.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "hardstop", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Bool true
                            LuaKey.String "impulseboost", LuaValue.Number 0.4
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Compact Railgun"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 950.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.34 0.64 0.94"
                            LuaKey.String "soundhit", LuaValue.String "mavgun3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lancefire"
                            LuaKey.String "soundstartvolume", LuaValue.Number 26.0
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overpenetrate", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 250.0
                                    LuaKey.String "default", LuaValue.Number 1000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "railgunt2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "armannit3", armannit3
            "armbotrail", armbotrail
            "armlwall", armlwall
            "armminivulc", armminivulc
            "cordoomt3", cordoomt3
            "corhllllt", corhllllt
            "corminibuzz", corminibuzz
            "cormwall", cormwall
            "corscavdrag", corscavdrag
            "corscavdtf", corscavdtf
            "corscavdtl", corscavdtl
            "corscavdtm", corscavdtm
            "corscavfort", corscavfort
            "legdtf", legdtf
            "legdtl", legdtl
            "legdtm", legdtm
            "legministarfall", legministarfall
            "legrwall", legrwall
        ]
