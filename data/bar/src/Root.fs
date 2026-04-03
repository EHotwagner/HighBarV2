// Auto-generated BAR unit data: Root
namespace BarData.Units

open BarData

module Root =

    let armassistdrone_land =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 1.0
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 1.0
            LuaKey.String "builddistance", LuaValue.Number 150.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMBEAVER.DDS"
            LuaKey.String "buildtime", LuaValue.Number 500.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "17 11 21"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "explodeas", LuaValue.String "smallexplosiongeneric-builder"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 2000.0
            LuaKey.String "maxslope", LuaValue.Number 16.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 255.0
            LuaKey.String "movementclass", LuaValue.String "ATANK3"
            LuaKey.String "objectname", LuaValue.String "Units/armassistdrone_land.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMBEAVER.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd-builder"
            LuaKey.String "sightdistance", LuaValue.Number 150.0
            LuaKey.String "terraformspeed", LuaValue.Number 400.0
            LuaKey.String "trackstrength", LuaValue.Number 5.0
            LuaKey.String "tracktype", LuaValue.String "armpincer_tracks"
            LuaKey.String "trackwidth", LuaValue.Number 17.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.9834
            LuaKey.String "turnrate", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Expr "100*Spring.GetModOptions().assistdronesbuildpowermultiplier"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armsolar"
                    LuaKey.Int 2, LuaValue.String "armwin"
                    LuaKey.Int 3, LuaValue.String "armmstor"
                    LuaKey.Int 4, LuaValue.String "armestor"
                    LuaKey.Int 5, LuaValue.String "armmex"
                    LuaKey.Int 6, LuaValue.String "armmakr"
                    LuaKey.Int 7, LuaValue.String "armlab"
                    LuaKey.Int 8, LuaValue.String "armvp"
                    LuaKey.Int 9, LuaValue.String "armap"
                    LuaKey.Int 10, LuaValue.String "armeyes"
                    LuaKey.Int 11, LuaValue.String "armrad"
                    LuaKey.Int 12, LuaValue.String "armdrag"
                    LuaKey.Int 13, LuaValue.String "armllt"
                    LuaKey.Int 14, LuaValue.String "armrl"
                    LuaKey.Int 15, LuaValue.String "armdl"
                    LuaKey.Int 16, LuaValue.String "armtide"
                    LuaKey.Int 17, LuaValue.String "armuwms"
                    LuaKey.Int 18, LuaValue.String "armuwes"
                    LuaKey.Int 20, LuaValue.String "armfmkr"
                    LuaKey.Int 21, LuaValue.String "armsy"
                    LuaKey.Int 22, LuaValue.String "armfdrag"
                    LuaKey.Int 23, LuaValue.String "armtl"
                    LuaKey.Int 24, LuaValue.String "armfrt"
                    LuaKey.Int 25, LuaValue.String "armfrad"
                    LuaKey.Int 26, LuaValue.String "armhp"
                    LuaKey.Int 27, LuaValue.String "armfhp"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmVehicles"
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
                            LuaKey.Int 1, LuaValue.String "tnkt1canamphok"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "tnkt1canamphsel"
                        ]
                ]
        ]

    let armcom =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "builddistance", LuaValue.Number 145.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 75000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 26000.0
            LuaKey.String "energymake", LuaValue.Number 30.0
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 3700.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalcost", LuaValue.Number 2700.0
            LuaKey.String "metalmake", LuaValue.Number 2.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMCOM.s3o"
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/ARMCOM_lus.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 300.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armsolar"
                    LuaKey.Int 2, LuaValue.String "armwin"
                    LuaKey.Int 3, LuaValue.String "armmstor"
                    LuaKey.Int 4, LuaValue.String "armestor"
                    LuaKey.Int 5, LuaValue.String "armmex"
                    LuaKey.Int 6, LuaValue.String "armmakr"
                    LuaKey.Int 7, LuaValue.String "armlab"
                    LuaKey.Int 8, LuaValue.String "armvp"
                    LuaKey.Int 9, LuaValue.String "armap"
                    LuaKey.Int 10, LuaValue.String "armeyes"
                    LuaKey.Int 11, LuaValue.String "armrad"
                    LuaKey.Int 12, LuaValue.String "armdrag"
                    LuaKey.Int 13, LuaValue.String "armllt"
                    LuaKey.Int 14, LuaValue.String "armrl"
                    LuaKey.Int 15, LuaValue.String "armdl"
                    LuaKey.Int 16, LuaValue.String "armtide"
                    LuaKey.Int 17, LuaValue.String "armuwms"
                    LuaKey.Int 18, LuaValue.String "armuwes"
                    LuaKey.Int 20, LuaValue.String "armfmkr"
                    LuaKey.Int 21, LuaValue.String "armsy"
                    LuaKey.Int 22, LuaValue.String "armfdrag"
                    LuaKey.Int 23, LuaValue.String "armtl"
                    LuaKey.Int 24, LuaValue.String "armfrt"
                    LuaKey.Int 25, LuaValue.String "armfrad"
                    LuaKey.Int 26, LuaValue.String "armhp"
                    LuaKey.Int 27, LuaValue.String "armfhp"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "armcomsel"
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
                            LuaKey.Int 1, LuaValue.String "armcom1"
                            LuaKey.Int 2, LuaValue.String "armcom2"
                            LuaKey.Int 3, LuaValue.String "armcom3"
                            LuaKey.Int 4, LuaValue.String "armcom4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "armcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armcomlaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "Light close-quarters g2g/g2a laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "subs", LuaValue.Number 5.0
                                ]
                        ]
                    LuaKey.String "armcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "Light underwater-combat laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.2 0.6"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 5.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "norangering", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMCOMLASER"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armcomcon =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "builddistance", LuaValue.Number 145.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 75000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 26000.0
            LuaKey.String "energymake", LuaValue.Number 30.0
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 3350.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalcost", LuaValue.Number 2700.0
            LuaKey.String "metalmake", LuaValue.Number 2.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMCOM.s3o"
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/ARMCOM_lus.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 300.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armrectr"
                    LuaKey.Int 2, LuaValue.String "armca"
                    LuaKey.Int 3, LuaValue.String "armck"
                    LuaKey.Int 4, LuaValue.String "armch"
                    LuaKey.Int 5, LuaValue.String "armcsa"
                    LuaKey.Int 6, LuaValue.String "armcs"
                    LuaKey.Int 7, LuaValue.String "armcv"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "i18nfromunit", LuaValue.String "armcom"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47 10 47"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2000.0
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1000.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "armcomsel"
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
                            LuaKey.Int 1, LuaValue.String "armcom1"
                            LuaKey.Int 2, LuaValue.String "armcom2"
                            LuaKey.Int 3, LuaValue.String "armcom3"
                            LuaKey.Int 4, LuaValue.String "armcom4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "armcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armcomlaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "Light close-quarters g2g/g2a laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "subs", LuaValue.Number 5.0
                                ]
                        ]
                    LuaKey.String "armcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "Light underwater-combat laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.2 0.6"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 5.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.6
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "repulsor1", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "Plasma repulsor"
                            LuaKey.String "range", LuaValue.Number 50.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.25
                                    LuaKey.String "energyupkeep", LuaValue.Number 0.0
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 479.0
                                    LuaKey.String "power", LuaValue.Number 1000.0
                                    LuaKey.String "powerregen", LuaValue.Number 20.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 0.0
                                    LuaKey.String "radius", LuaValue.Number 30.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 1000.0
                                    LuaKey.String "visible", LuaValue.Bool false
                                    LuaKey.String "visiblehitframes", LuaValue.Number 0.0
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.25
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMCOMLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armcomnew =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "builddistance", LuaValue.Number 145.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 75000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 26000.0
            LuaKey.String "energymake", LuaValue.Number 30.0
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "newcommanderexplo"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 3700.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalcost", LuaValue.Number 2700.0
            LuaKey.String "metalmake", LuaValue.Number 2.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.Expr "\"Units/ARMCOM\"..(Spring.GetModOptions().xmas and '-XMAS' or '')..\".s3o\""
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/ARMCOM_lus.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "newcommanderexplo"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 300.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armsolar"
                    LuaKey.Int 2, LuaValue.String "armwin"
                    LuaKey.Int 3, LuaValue.String "armmstor"
                    LuaKey.Int 4, LuaValue.String "armestor"
                    LuaKey.Int 5, LuaValue.String "armmex"
                    LuaKey.Int 6, LuaValue.String "armmakr"
                    LuaKey.Int 7, LuaValue.String "armlab"
                    LuaKey.Int 8, LuaValue.String "armvp"
                    LuaKey.Int 9, LuaValue.String "armap"
                    LuaKey.Int 10, LuaValue.String "armeyes"
                    LuaKey.Int 11, LuaValue.String "armrad"
                    LuaKey.Int 12, LuaValue.String "armdrag"
                    LuaKey.Int 13, LuaValue.String "armllt"
                    LuaKey.Int 14, LuaValue.String "armrl"
                    LuaKey.Int 15, LuaValue.String "armdl"
                    LuaKey.Int 16, LuaValue.String "armtide"
                    LuaKey.Int 17, LuaValue.String "armuwms"
                    LuaKey.Int 18, LuaValue.String "armuwes"
                    LuaKey.Int 20, LuaValue.String "armfmkr"
                    LuaKey.Int 21, LuaValue.String "armsy"
                    LuaKey.Int 22, LuaValue.String "armfdrag"
                    LuaKey.Int 23, LuaValue.String "armtl"
                    LuaKey.Int 24, LuaValue.String "armfrt"
                    LuaKey.Int 25, LuaValue.String "armfrad"
                    LuaKey.Int 26, LuaValue.String "armhp"
                    LuaKey.Int 27, LuaValue.String "armfhp"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "armcomsel"
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
                            LuaKey.Int 1, LuaValue.String "armcom1"
                            LuaKey.Int 2, LuaValue.String "armcom2"
                            LuaKey.Int 3, LuaValue.String "armcom3"
                            LuaKey.Int 4, LuaValue.String "armcom4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "armcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armcomlaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "Light close-quarters g2g/g2a laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "subs", LuaValue.Number 5.0
                                ]
                        ]
                    LuaKey.String "armcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "Light underwater-combat laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.2 0.6"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 5.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "norangering", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMCOMLASER"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corassistdrone_land =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 1.0
            LuaKey.String "maxdec", LuaValue.Number 1.0
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 1.0
            LuaKey.String "builddistance", LuaValue.Number 150.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORMUSKRAT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 500.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 1"
            LuaKey.String "collisionvolumescales", LuaValue.String "11 8 21"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "explodeas", LuaValue.String "smallexplosiongeneric-builder"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 2000.0
            LuaKey.String "maxslope", LuaValue.Number 16.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 255.0
            LuaKey.String "movementclass", LuaValue.String "ATANK3"
            LuaKey.String "objectname", LuaValue.String "Units/corassistdrone_land.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORMUSKRAT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd-builder"
            LuaKey.String "sightdistance", LuaValue.Number 150.0
            LuaKey.String "terraformspeed", LuaValue.Number 400.0
            LuaKey.String "trackoffset", LuaValue.Number 8.0
            LuaKey.String "trackstrength", LuaValue.Number 5.0
            LuaKey.String "tracktype", LuaValue.String "corwidetracks"
            LuaKey.String "trackwidth", LuaValue.Number 12.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.9504
            LuaKey.String "turnrate", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Expr "100*Spring.GetModOptions().assistdronesbuildpowermultiplier"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corsolar"
                    LuaKey.Int 2, LuaValue.String "corwin"
                    LuaKey.Int 3, LuaValue.String "cormstor"
                    LuaKey.Int 4, LuaValue.String "corestor"
                    LuaKey.Int 5, LuaValue.String "cormex"
                    LuaKey.Int 6, LuaValue.String "cormakr"
                    LuaKey.Int 7, LuaValue.String "corlab"
                    LuaKey.Int 8, LuaValue.String "corvp"
                    LuaKey.Int 9, LuaValue.String "corap"
                    LuaKey.Int 10, LuaValue.String "coreyes"
                    LuaKey.Int 11, LuaValue.String "corrad"
                    LuaKey.Int 12, LuaValue.String "cordrag"
                    LuaKey.Int 13, LuaValue.String "corllt"
                    LuaKey.Int 14, LuaValue.String "corrl"
                    LuaKey.Int 15, LuaValue.String "cordl"
                    LuaKey.Int 16, LuaValue.String "cortide"
                    LuaKey.Int 17, LuaValue.String "coruwms"
                    LuaKey.Int 18, LuaValue.String "coruwes"
                    LuaKey.Int 20, LuaValue.String "corfmkr"
                    LuaKey.Int 21, LuaValue.String "corsy"
                    LuaKey.Int 22, LuaValue.String "corfdrag"
                    LuaKey.Int 23, LuaValue.String "cortl"
                    LuaKey.Int 24, LuaValue.String "corfrt"
                    LuaKey.Int 25, LuaValue.String "corfrad"
                    LuaKey.Int 26, LuaValue.String "corhp"
                    LuaKey.Int 27, LuaValue.String "corfhp"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorVehicles"
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

    let corcom =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "builddistance", LuaValue.Number 145.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 75000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 26000.0
            LuaKey.String "energymake", LuaValue.Number 30.0
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "commanderexplosion"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 3700.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalcost", LuaValue.Number 2700.0
            LuaKey.String "metalmake", LuaValue.Number 2.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/CORCOM.s3o"
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/CORCOM.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1133.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 300.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corsolar"
                    LuaKey.Int 2, LuaValue.String "corwin"
                    LuaKey.Int 3, LuaValue.String "cormstor"
                    LuaKey.Int 4, LuaValue.String "corestor"
                    LuaKey.Int 5, LuaValue.String "cormex"
                    LuaKey.Int 6, LuaValue.String "cormakr"
                    LuaKey.Int 7, LuaValue.String "corlab"
                    LuaKey.Int 8, LuaValue.String "corvp"
                    LuaKey.Int 9, LuaValue.String "corap"
                    LuaKey.Int 10, LuaValue.String "coreyes"
                    LuaKey.Int 11, LuaValue.String "corrad"
                    LuaKey.Int 12, LuaValue.String "cordrag"
                    LuaKey.Int 13, LuaValue.String "corllt"
                    LuaKey.Int 14, LuaValue.String "corrl"
                    LuaKey.Int 15, LuaValue.String "cordl"
                    LuaKey.Int 16, LuaValue.String "cortide"
                    LuaKey.Int 17, LuaValue.String "coruwms"
                    LuaKey.Int 18, LuaValue.String "coruwes"
                    LuaKey.Int 20, LuaValue.String "corfmkr"
                    LuaKey.Int 21, LuaValue.String "corsy"
                    LuaKey.Int 22, LuaValue.String "corfdrag"
                    LuaKey.Int 23, LuaValue.String "cortl"
                    LuaKey.Int 24, LuaValue.String "corfrt"
                    LuaKey.Int 25, LuaValue.String "corfrad"
                    LuaKey.Int 26, LuaValue.String "corhp"
                    LuaKey.Int 27, LuaValue.String "corfhp"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/corcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "repair", LuaValue.String "repair2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "corcomsel"
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
                            LuaKey.Int 1, LuaValue.String "corcom1"
                            LuaKey.Int 2, LuaValue.String "corcom2"
                            LuaKey.Int 3, LuaValue.String "corcom3"
                            LuaKey.Int 4, LuaValue.String "corcom4"
                            LuaKey.Int 5, LuaValue.String "corcom5"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "corcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corcomlaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "J7Laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "subs", LuaValue.Number 5.0
                                ]
                        ]
                    LuaKey.String "corcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "J7NSLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.2 0.6"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 5.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "norangering", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 262.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2s"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMLASER"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corcomcon =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "builddistance", LuaValue.Number 145.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 75000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 26000.0
            LuaKey.String "energymake", LuaValue.Number 30.0
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "commanderexplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 3350.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalcost", LuaValue.Number 2700.0
            LuaKey.String "metalmake", LuaValue.Number 2.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/CORCOM.s3o"
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/CORCOM.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1133.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 300.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "cornecro"
                    LuaKey.Int 2, LuaValue.String "corca"
                    LuaKey.Int 3, LuaValue.String "corck"
                    LuaKey.Int 4, LuaValue.String "corch"
                    LuaKey.Int 5, LuaValue.String "corcsa"
                    LuaKey.Int 6, LuaValue.String "corcs"
                    LuaKey.Int 7, LuaValue.String "corcv"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "i18nfromunit", LuaValue.String "corcom"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2000.0
                            LuaKey.String "object", LuaValue.String "Units/corcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1000.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "repair", LuaValue.String "repair2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "corcomsel"
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
                            LuaKey.Int 1, LuaValue.String "corcom1"
                            LuaKey.Int 2, LuaValue.String "corcom2"
                            LuaKey.Int 3, LuaValue.String "corcom3"
                            LuaKey.Int 4, LuaValue.String "corcom4"
                            LuaKey.Int 5, LuaValue.String "corcom5"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "corcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corcomlaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "J7Laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "subs", LuaValue.Number 5.0
                                ]
                        ]
                    LuaKey.String "corcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "J7NSLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.2 0.6"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 5.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.6
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2s"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "repulsor1", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 50.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.25
                                    LuaKey.String "energyupkeep", LuaValue.Number 0.0
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 479.0
                                    LuaKey.String "power", LuaValue.Number 1000.0
                                    LuaKey.String "powerregen", LuaValue.Number 20.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 0.0
                                    LuaKey.String "radius", LuaValue.Number 30.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 1000.0
                                    LuaKey.String "visible", LuaValue.Bool false
                                    LuaKey.String "visiblehitframes", LuaValue.Number 0.0
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.25
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "armassistdrone_land", armassistdrone_land
            "armcom", armcom
            "armcomcon", armcomcon
            "armcomnew", armcomnew
            "corassistdrone_land", corassistdrone_land
            "corcom", corcom
            "corcomcon", corcomcon
        ]
