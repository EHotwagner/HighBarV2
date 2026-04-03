// Auto-generated BAR unit data: other/raptors/Miniqueen
namespace BarData.Units

open BarData

module other_raptors_Miniqueen =

    let raptor_matriarch_acid =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.1
            LuaKey.String "airsightdistance", LuaValue.Number 2400.0
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 2000000.0
            LuaKey.String "metalcost", LuaValue.Number 50000.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_miniqueen_acid.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1500000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionspherescale", LuaValue.Number 1.75
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -30 23"
            LuaKey.String "collisionvolumescales", LuaValue.String "60 113 105"
            LuaKey.String "collisionvolumetest", LuaValue.Number 1.0
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BIGBUG_DEATH_ACID"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 2000.0
            LuaKey.String "mass", LuaValue.Number 2000000.0
            LuaKey.String "health", LuaValue.Number 60000.0
            LuaKey.String "maxslope", LuaValue.Number 40.0
            LuaKey.String "speed", LuaValue.Number 67.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORQUEENHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_miniqueen_acid.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor_miniqueen.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BIGBUG_DEATH_ACID"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 18.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 80.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 1.0
            LuaKey.String "turnrate", LuaValue.Number 100.0
            LuaKey.String "unitname", LuaValue.String "raptor_matriarch_acid"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 40.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "acidgoo", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 256.0
                            LuaKey.String "areaofeffect", LuaValue.Number 150.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 5.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_green"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:acid-explosion-xl"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "size", LuaValue.Number 9.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.04
                            LuaKey.String "alphaDecay", LuaValue.Number 0.18
                            LuaKey.String "stages", LuaValue.Number 8.0
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 30.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.8 0.99 0.11"
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 2000.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "area_onhit_ceg", LuaValue.String "acid-area-75-repeat"
                                    LuaKey.String "area_onhit_damageCeg", LuaValue.String "acid-damage-gen"
                                    LuaKey.String "area_onhit_time", LuaValue.Number 10.0
                                    LuaKey.String "area_onhit_damage", LuaValue.Number 40.0
                                    LuaKey.String "area_onhit_range", LuaValue.Number 75.0
                                    LuaKey.String "area_onhit_resistance", LuaValue.String "_RAPTORACID_"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "shields", LuaValue.Number 800.0
                                ]
                        ]
                    LuaKey.String "melee", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 60.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-large-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "RaptorClaws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundstart", LuaValue.String "bigraptorbreath"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 500.0
                                ]
                        ]
                    LuaKey.String "spike_acid_blob", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 256.0
                            LuaKey.String "areaofeffect", LuaValue.Number 150.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_green"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:acid-explosion-xl"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "size", LuaValue.Number 9.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.04
                            LuaKey.String "alphaDecay", LuaValue.Number 0.18
                            LuaKey.String "stages", LuaValue.Number 8.0
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.8 0.99 0.11"
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 256.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "area_onhit_ceg", LuaValue.String "acid-area-75-repeat"
                                    LuaKey.String "area_onhit_damageCeg", LuaValue.String "acid-damage-gen"
                                    LuaKey.String "area_onhit_time", LuaValue.Number 10.0
                                    LuaKey.String "area_onhit_damage", LuaValue.Number 40.0
                                    LuaKey.String "area_onhit_range", LuaValue.Number 75.0
                                    LuaKey.String "area_onhit_resistance", LuaValue.String "_RAPTORACID_"
                                    LuaKey.String "nofire", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "shields", LuaValue.Number 800.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MELEE"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 155.0
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "spike_acid_blob"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "WEAPON"
                            LuaKey.String "def", LuaValue.String "spike_acid_blob"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOWEAPON"
                            LuaKey.String "def", LuaValue.String "spike_acid_blob"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "acidgoo"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_matriarch_basic =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.1
            LuaKey.String "airsightdistance", LuaValue.Number 2400.0
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 2000000.0
            LuaKey.String "metalcost", LuaValue.Number 50000.0
            LuaKey.String "builddistance", LuaValue.Number 1000.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_miniqueen_basic.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1500000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "canrepair", LuaValue.Number 0.0
            LuaKey.String "canreclaim", LuaValue.Number 0.0
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionspherescale", LuaValue.Number 1.75
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -30 23"
            LuaKey.String "collisionvolumescales", LuaValue.String "60 113 105"
            LuaKey.String "collisionvolumetest", LuaValue.Number 1.0
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 2000.0
            LuaKey.String "mass", LuaValue.Number 2000000.0
            LuaKey.String "health", LuaValue.Number 60000.0
            LuaKey.String "maxslope", LuaValue.Number 40.0
            LuaKey.String "speed", LuaValue.Number 67.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORQUEENHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_miniqueen_basic.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor_miniqueen.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 18.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 80.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 1.0
            LuaKey.String "turnrate", LuaValue.Number 100.0
            LuaKey.String "unitname", LuaValue.String "raptor_matriarch_basic"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 40.0
            LuaKey.String "workertime", LuaValue.Number 5000.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_m_normals.png"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "goo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 300.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "nuketrail-roost"
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "model", LuaValue.String "Raptors/SGreyRock1.S3O"
                            LuaKey.String "name", LuaValue.String "Blob"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.1 0.6 1"
                            LuaKey.String "size", LuaValue.Number 8.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.0
                            LuaKey.String "soundhit", LuaValue.String "e16"
                            LuaKey.String "soundstart", LuaValue.String "bigraptorroar"
                            LuaKey.String "sprayangle", LuaValue.Number 1024.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 500.0
                                ]
                        ]
                    LuaKey.String "melee", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 60.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-large-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "RaptorClaws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundstart", LuaValue.String "bigraptorbreath"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 150.0
                                ]
                        ]
                    LuaKey.String "yellow_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cameraShake", LuaValue.Number 700.0
                            LuaKey.String "dance", LuaValue.Number 20.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.35
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 5.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 2.0
                            LuaKey.String "smoketime", LuaValue.Number 45.0
                            LuaKey.String "smokesize", LuaValue.Number 10.5
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "spore_explo"
                            LuaKey.String "soundstart", LuaValue.String "spore_xl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.0
                            LuaKey.String "startvelocity", LuaValue.Number 1000.0
                            LuaKey.String "texture1", LuaValue.String "orangenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "sporetrail_xl"
                            LuaKey.String "tolerance", LuaValue.Number 60000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 2.0
                            LuaKey.String "turnrate", LuaValue.Number 60000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 40.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 32000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 1000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MELEE"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 155.0
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "yellow_missile"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "yellow_missile"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "yellow_missile"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "goo"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                ]
        ]

    let raptor_matriarch_electric =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.1
            LuaKey.String "airsightdistance", LuaValue.Number 2400.0
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 2000000.0
            LuaKey.String "metalcost", LuaValue.Number 50000.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_miniqueen_electric.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1500000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionspherescale", LuaValue.Number 1.75
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -30 23"
            LuaKey.String "collisionvolumescales", LuaValue.String "60 113 105"
            LuaKey.String "collisionvolumetest", LuaValue.Number 1.0
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "raptor_empdeath_big"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 2000.0
            LuaKey.String "mass", LuaValue.Number 2000000.0
            LuaKey.String "health", LuaValue.Number 60000.0
            LuaKey.String "maxslope", LuaValue.Number 40.0
            LuaKey.String "speed", LuaValue.Number 67.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORQUEENHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_miniqueen_electric.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor_miniqueen.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "raptor_empdeath_big"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 18.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 80.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 1.0
            LuaKey.String "turnrate", LuaValue.Number 100.0
            LuaKey.String "unitname", LuaValue.String "raptor_matriarch_electric"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 40.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "goo", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 256.0
                            LuaKey.String "areaofeffect", LuaValue.Number 220.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 5.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_blue"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-lightning"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 20.0
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 30.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.5 0.9"
                            LuaKey.String "size", LuaValue.Number 5.5
                            LuaKey.String "sizedecay", LuaValue.Number 0.09
                            LuaKey.String "soundhit", LuaValue.String "empbomb"
                            LuaKey.String "soundstart", LuaValue.String "bugarty"
                            LuaKey.String "sprayangle", LuaValue.Number 2000.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 9000.0
                                    LuaKey.String "shields", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "melee", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 30.0
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 20.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-lightning2"
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 24.0
                            LuaKey.String "laserFlareSize", LuaValue.Number 5.0
                            LuaKey.String "name", LuaValue.String "Close-quarters g2g lightning rifle"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 20.0
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 15.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0.5 1"
                            LuaKey.String "soundstart", LuaValue.String "alien_electric_xl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 65.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.15
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LightningCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1400.0
                                ]
                        ]
                    LuaKey.String "spike_emp_blob", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 256.0
                            LuaKey.String "areaofeffect", LuaValue.Number 220.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 1.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_blue"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-lightning"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 20.0
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.5 0.9"
                            LuaKey.String "size", LuaValue.Number 5.5
                            LuaKey.String "sizedecay", LuaValue.Number 0.09
                            LuaKey.String "soundhit", LuaValue.String "empbomb"
                            LuaKey.String "soundstart", LuaValue.String "bugarty"
                            LuaKey.String "sprayangle", LuaValue.Number 1000.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 9000.0
                                    LuaKey.String "shields", LuaValue.Number 1000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MELEE"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 155.0
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MELEE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "WEAPON"
                            LuaKey.String "def", LuaValue.String "MELEE"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOWEAPON"
                            LuaKey.String "def", LuaValue.String "MELEE"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "GOO"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                ]
        ]

    let raptor_matriarch_fire =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.1
            LuaKey.String "airsightdistance", LuaValue.Number 2400.0
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 2000000.0
            LuaKey.String "metalcost", LuaValue.Number 50000.0
            LuaKey.String "builddistance", LuaValue.Number 1000.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_miniqueen_fire.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1500000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "canrepair", LuaValue.Number 0.0
            LuaKey.String "canreclaim", LuaValue.Number 0.0
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionspherescale", LuaValue.Number 1.75
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -30 23"
            LuaKey.String "collisionvolumescales", LuaValue.String "60 113 105"
            LuaKey.String "collisionvolumetest", LuaValue.Number 1.0
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 2000.0
            LuaKey.String "mass", LuaValue.Number 2000000.0
            LuaKey.String "health", LuaValue.Number 60000.0
            LuaKey.String "maxslope", LuaValue.Number 40.0
            LuaKey.String "speed", LuaValue.Number 67.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORQUEENHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_miniqueen_fire.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor_miniqueen.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 18.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 80.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 1.0
            LuaKey.String "turnrate", LuaValue.Number 100.0
            LuaKey.String "unitname", LuaValue.String "raptor_matriarch_basic"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 40.0
            LuaKey.String "workertime", LuaValue.Number 5000.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "flamethrowerspike", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bounceSlip", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 12.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "burnflamethermite"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnthermite"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flamegfxtime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.65
                            LuaKey.String "name", LuaValue.String "FlameThrower"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.83 0.77"
                            LuaKey.String "sizegrowth", LuaValue.Number 1.5
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "cflamhvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "sprayangle", LuaValue.Number 100.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.001
                            LuaKey.String "tolerance", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 265.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 20.0
                                ]
                        ]
                    LuaKey.String "flamethrowermain", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bounceSlip", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 12.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "burnflamethermite"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnthermite"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flamegfxtime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.65
                            LuaKey.String "name", LuaValue.String "FlameThrower"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.0
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.83 0.77"
                            LuaKey.String "sizegrowth", LuaValue.Number 1.25
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "cflamhvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "sprayangle", LuaValue.Number 100.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.001
                            LuaKey.String "tolerance", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 265.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 40.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "flamethrowerspike"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 155.0
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "flamethrowerspike"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "WEAPON"
                            LuaKey.String "def", LuaValue.String "flamethrowerspike"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOWEAPON"
                            LuaKey.String "def", LuaValue.String "flamethrowerspike"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "flamethrowermain"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                ]
        ]

    let raptor_matriarch_healer =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.1
            LuaKey.String "airsightdistance", LuaValue.Number 2400.0
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 2000000.0
            LuaKey.String "metalcost", LuaValue.Number 50000.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_miniqueen_healer.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1500000.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "canrepair", LuaValue.Number 1.0
            LuaKey.String "canreclaim", LuaValue.Number 0.0
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionspherescale", LuaValue.Number 1.75
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -30 23"
            LuaKey.String "collisionvolumescales", LuaValue.String "60 113 105"
            LuaKey.String "collisionvolumetest", LuaValue.Number 1.0
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 2000.0
            LuaKey.String "mass", LuaValue.Number 2000000.0
            LuaKey.String "health", LuaValue.Number 60000.0
            LuaKey.String "maxslope", LuaValue.Number 40.0
            LuaKey.String "speed", LuaValue.Number 67.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORQUEENHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_miniqueen_healer.s3o"
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Raptors/raptor_miniqueen.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "trackoffset", LuaValue.Number 18.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 80.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 1.0
            LuaKey.String "turnrate", LuaValue.Number 100.0
            LuaKey.String "unitname", LuaValue.String "raptor_matriarch_healer"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 40.0
            LuaKey.String "workertime", LuaValue.Number 2500.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"raptor_turret_basic_t4_v1\",\r\n\t\t\t\"raptor_turret_antiair_t4_v1\",\r\n\t\t\t\"raptor_turret_acid_t4_v1\",\r\n\t\t\t\"raptor_turret_emp_t4_v1\",\r\n\t\t\t\"raptor_turret_meteor_t4_v1\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "melee", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 60.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-large-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "RaptorClaws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundstart", LuaValue.String "bigraptorbreath"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 50.0
                                ]
                        ]
                    LuaKey.String "meleeBig", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-large-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "RaptorClaws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "soundstart", LuaValue.String "bigraptorbreath"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 500.0
                                ]
                        ]
                    LuaKey.String "yellow_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cameraShake", LuaValue.Number 700.0
                            LuaKey.String "dance", LuaValue.Number 20.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.35
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 2.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 10.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 2.0
                            LuaKey.String "smoketime", LuaValue.Number 45.0
                            LuaKey.String "smokesize", LuaValue.Number 10.5
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "spore_explo"
                            LuaKey.String "soundstart", LuaValue.String "spore_xl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.0
                            LuaKey.String "startvelocity", LuaValue.Number 1000.0
                            LuaKey.String "texture1", LuaValue.String "orangenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "sporetrail_xl"
                            LuaKey.String "tolerance", LuaValue.Number 60000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 2.0
                            LuaKey.String "turnrate", LuaValue.Number 60000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 40.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 32000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 5.0
                                    LuaKey.String "vtol", LuaValue.Number 500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MELEE"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 155.0
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "yellow_missile"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "yellow_missile"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "yellow_missile"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MELEEBIG"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                ]
        ]

    let raptor_matriarch_spectre =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.1
            LuaKey.String "airsightdistance", LuaValue.Number 2400.0
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 2000000.0
            LuaKey.String "metalcost", LuaValue.Number 50000.0
            LuaKey.String "builddistance", LuaValue.Number 1000.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptor_miniqueen_spectre.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1500000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "canrepair", LuaValue.Number 0.0
            LuaKey.String "canreclaim", LuaValue.Number 0.0
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "cloakcost", LuaValue.Number 0.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 0.0
            LuaKey.String "collisionspherescale", LuaValue.Number 1.75
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -30 23"
            LuaKey.String "collisionvolumescales", LuaValue.String "60 113 105"
            LuaKey.String "collisionvolumetest", LuaValue.Number 1.0
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "initcloak", LuaValue.Bool true
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 2000.0
            LuaKey.String "mass", LuaValue.Number 2000000.0
            LuaKey.String "health", LuaValue.Number 30000.0
            LuaKey.String "maxslope", LuaValue.Number 40.0
            LuaKey.String "speed", LuaValue.Number 67.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "mincloakdistance", LuaValue.Number 200.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORQUEENHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_miniqueen_spectre.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor_miniqueen.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Number 1.0
            LuaKey.String "trackoffset", LuaValue.Number 18.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 80.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 1.0
            LuaKey.String "turnrate", LuaValue.Number 100.0
            LuaKey.String "unitname", LuaValue.String "raptor_matriarch_basic"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 40.0
            LuaKey.String "workertime", LuaValue.Number 5000.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_l_normals.png"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "goo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 300.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "nuketrail-roost"
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "model", LuaValue.String "Raptors/SGreyRock1.S3O"
                            LuaKey.String "name", LuaValue.String "Blob"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 1000.0
                            LuaKey.String "reloadtime", LuaValue.Number 20.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.1 0.6 1"
                            LuaKey.String "size", LuaValue.Number 8.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.0
                            LuaKey.String "soundhit", LuaValue.String "e16"
                            LuaKey.String "soundstart", LuaValue.String "bigraptorroar"
                            LuaKey.String "sprayangle", LuaValue.Number 1024.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 500.0
                                ]
                        ]
                    LuaKey.String "melee", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 60.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-large-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "RaptorClaws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "soundstart", LuaValue.String "bigraptorbreath"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 150.0
                                ]
                        ]
                    LuaKey.String "yellow_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 256.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cameraShake", LuaValue.Number 700.0
                            LuaKey.String "dance", LuaValue.Number 20.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.35
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 5.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "SimpleFlareXL.s3o"
                            LuaKey.String "name", LuaValue.String "Deadly Defensive Spores"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 20.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 2.0
                            LuaKey.String "smoketime", LuaValue.Number 45.0
                            LuaKey.String "smokesize", LuaValue.Number 10.5
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "spore_explo"
                            LuaKey.String "soundstart", LuaValue.String "spore_xl"
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.0
                            LuaKey.String "startvelocity", LuaValue.Number 1000.0
                            LuaKey.String "texture1", LuaValue.String "orangenovaexplo"
                            LuaKey.String "texture2", LuaValue.String "sporetrail_xl"
                            LuaKey.String "tolerance", LuaValue.Number 60000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 2.0
                            LuaKey.String "turnrate", LuaValue.Number 60000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 40.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 32000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "vtol", LuaValue.Number 2000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "MELEE"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 155.0
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "yellow_missile"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "yellow_missile"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "yellow_missile"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "goo"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "raptor_matriarch_acid", raptor_matriarch_acid
            "raptor_matriarch_basic", raptor_matriarch_basic
            "raptor_matriarch_electric", raptor_matriarch_electric
            "raptor_matriarch_fire", raptor_matriarch_fire
            "raptor_matriarch_healer", raptor_matriarch_healer
            "raptor_matriarch_spectre", raptor_matriarch_spectre
        ]
