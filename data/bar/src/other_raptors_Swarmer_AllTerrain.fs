// Auto-generated BAR unit data: other/raptors/Swarmer/AllTerrain
namespace BarData.Units

open BarData

module other_raptors_Swarmer_AllTerrain =

    let raptor_6legged_l =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 1.4375
            LuaKey.String "maxdec", LuaValue.Number 2.3
            LuaKey.String "energycost", LuaValue.Number 5280.0
            LuaKey.String "metalcost", LuaValue.Number 99.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorc3c.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1875.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 -3"
            LuaKey.String "collisionvolumescales", LuaValue.String "18 28 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 89.0
            LuaKey.String "health", LuaValue.Number 2650.0
            LuaKey.String "maxreversevelocity", LuaValue.Number 3.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 63.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORALLTERRAINHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_6legged_l.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptor_6legged_l.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BIGBUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 200.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "trackoffset", LuaValue.Number 0.5
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrackPointy"
            LuaKey.String "trackwidth", LuaValue.Number 35.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_6legged_l"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 16.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "Kremenchuk, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
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
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 24.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-small-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "Claws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 200.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 700.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 110.0
                        ]
                ]
        ]

    let raptor_allterrain_swarmer_basic_t2_v1 =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 1.4375
            LuaKey.String "maxdec", LuaValue.Number 2.3
            LuaKey.String "energycost", LuaValue.Number 5280.0
            LuaKey.String "metalcost", LuaValue.Number 99.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorc3.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2250.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 -3"
            LuaKey.String "collisionvolumescales", LuaValue.String "18 28 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 89.0
            LuaKey.String "health", LuaValue.Number 890.0
            LuaKey.String "maxreversevelocity", LuaValue.Number 3.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 97.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORALLTERRAINHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorc3.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorc3.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BIGBUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 200.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "trackoffset", LuaValue.Number 0.5
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrackPointy"
            LuaKey.String "trackwidth", LuaValue.Number 35.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_allterrain_swarmer_basic_t2_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 10.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_s_normals.png"
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
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 24.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-small-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "Claws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 200.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 150.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 110.0
                        ]
                ]
        ]

    let raptor_allterrain_swarmer_basic_t3_v1 =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 1.4375
            LuaKey.String "maxdec", LuaValue.Number 2.3
            LuaKey.String "energycost", LuaValue.Number 5280.0
            LuaKey.String "metalcost", LuaValue.Number 99.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorc3b.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2625.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 -3"
            LuaKey.String "collisionvolumescales", LuaValue.String "18 28 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 89.0
            LuaKey.String "health", LuaValue.Number 1780.0
            LuaKey.String "maxreversevelocity", LuaValue.Number 3.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 105.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORALLTERRAINHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorc3b.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorc3b.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BIGBUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 200.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "trackoffset", LuaValue.Number 0.5
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrackPointy"
            LuaKey.String "trackwidth", LuaValue.Number 35.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_allterrain_swarmer_basic_t3_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 13.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_s_normals.png"
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
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 24.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-small-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "Claws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 200.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 250.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 110.0
                        ]
                ]
        ]

    let raptor_allterrain_swarmer_basic_t4_v1 =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 1.4375
            LuaKey.String "maxdec", LuaValue.Number 2.3
            LuaKey.String "energycost", LuaValue.Number 5280.0
            LuaKey.String "metalcost", LuaValue.Number 99.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorc3c.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1875.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 -3"
            LuaKey.String "collisionvolumescales", LuaValue.String "18 28 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "640"
            LuaKey.String "mass", LuaValue.Number 89.0
            LuaKey.String "health", LuaValue.Number 2650.0
            LuaKey.String "maxreversevelocity", LuaValue.Number 3.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 96.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 15.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORALLTERRAINHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorc3c.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorc3c.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BIGBUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 200.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "trackoffset", LuaValue.Number 0.5
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrackPointy"
            LuaKey.String "trackwidth", LuaValue.Number 35.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_allterrain_swarmer_basic_t4_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 16.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_s_normals.png"
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
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 24.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-small-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "Claws"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 200.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 350.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 110.0
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "raptor_6legged_l", raptor_6legged_l
            "raptor_allterrain_swarmer_basic_t2_v1", raptor_allterrain_swarmer_basic_t2_v1
            "raptor_allterrain_swarmer_basic_t3_v1", raptor_allterrain_swarmer_basic_t3_v1
            "raptor_allterrain_swarmer_basic_t4_v1", raptor_allterrain_swarmer_basic_t4_v1
        ]
