// Auto-generated BAR unit data: other/raptors/Spiker
namespace BarData.Units

open BarData

module other_raptors_Spiker =

    let raptor_land_spiker_basic_t2_v1 =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 1.725
            LuaKey.String "maxdec", LuaValue.Number 1.4375
            LuaKey.String "energycost", LuaValue.Number 174.0
            LuaKey.String "metalcost", LuaValue.Number 174.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptors1.DDS"
            LuaKey.String "buildtime", LuaValue.Number 3750.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "21 30 46"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "750"
            LuaKey.String "mass", LuaValue.Number 900.0
            LuaKey.String "health", LuaValue.Number 910.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 150.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptors.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptors1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 525.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "sonardistance", LuaValue.Number 720.0
            LuaKey.String "trackoffset", LuaValue.Number 6.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 28.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_spiker_basic_t2_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "waterline", LuaValue.Number 24.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "375"
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
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
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "cegtag", LuaValue.String "sporetrail-large"
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefeature", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-huge-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "Spike"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 525.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.0
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "startvelocity", LuaValue.Number 600.0
                            LuaKey.String "texture1", LuaValue.String ""
                            LuaKey.String "texture2", LuaValue.String "sporetrail"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool false
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 325.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_land_spiker_basic_t4_v1 =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 3.45
            LuaKey.String "maxdec", LuaValue.Number 3.45
            LuaKey.String "energycost", LuaValue.Number 174.0
            LuaKey.String "metalcost", LuaValue.Number 174.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptors2.DDS"
            LuaKey.String "buildtime", LuaValue.Number 10500.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "cloakable", LuaValue.Number 1.0
            LuaKey.String "cloakcost", LuaValue.Number 0.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 0.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "24 34 53"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "BUG_DEATH"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "initcloaked", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.String "750"
            LuaKey.String "mass", LuaValue.Number 300.0
            LuaKey.String "health", LuaValue.Number 2780.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 270.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "mincloakdistance", LuaValue.Number 200.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptors2.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptors2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "BUG_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 950.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "sonardistance", LuaValue.Number 720.0
            LuaKey.String "trackoffset", LuaValue.Number 6.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 30.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_spiker_basic_t4_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "waterline", LuaValue.Number 29.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "375"
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
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
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "cegtag", LuaValue.String "sporetrail-large"
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collidefeature", LuaValue.Bool true
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:raptorspike-huge-sparks-burn"
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "Raptors/spike.s3o"
                            LuaKey.String "name", LuaValue.String "Spike"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 950.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "soundstart", LuaValue.String "smallraptorattack"
                            LuaKey.String "startvelocity", LuaValue.Number 600.0
                            LuaKey.String "texture1", LuaValue.String ""
                            LuaKey.String "texture2", LuaValue.String "sporetrail"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool false
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 600.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "WEAPON"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "raptor_land_spiker_basic_t2_v1", raptor_land_spiker_basic_t2_v1
            "raptor_land_spiker_basic_t4_v1", raptor_land_spiker_basic_t4_v1
        ]
