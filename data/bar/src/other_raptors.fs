// Auto-generated BAR unit data: other/raptors
namespace BarData.Units

open BarData

module other_raptors =

    let raptor_air_gunship_acid_t2_v1 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.8
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 4550.0
            LuaKey.String "metalcost", LuaValue.Number 212.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorf1.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9375.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canland", LuaValue.Bool true
            LuaKey.String "canloopbackattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "cansubmerge", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "70 70 70"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "TALON_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "maneuverleashlength", LuaValue.String "20000"
            LuaKey.String "mass", LuaValue.Number 227.5
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxaileron", LuaValue.Number 0.025
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 350.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 240.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorf1.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorf1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.835
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "hoverAttack", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
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
                    LuaKey.String "acidspit", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1024.0
                            LuaKey.String "areaofeffect", LuaValue.Number 150.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.5
                            LuaKey.String "cegtag", LuaValue.String "blob_trail_green"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.63
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:acid-explosion-xl"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.4
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "GOOLAUNCHER"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.6
                            LuaKey.String "rgbcolor", LuaValue.String "0.8 0.99 0.11"
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "size", LuaValue.Number 8.0
                            LuaKey.String "sizedecay", LuaValue.Number 0.03
                            LuaKey.String "alphaDecay", LuaValue.Number 0.14
                            LuaKey.String "stages", LuaValue.Number 9.0
                            LuaKey.String "soundhit", LuaValue.String "bloodsplash3"
                            LuaKey.String "soundstart", LuaValue.String "alien_bombrel"
                            LuaKey.String "sprayangle", LuaValue.Number 92.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 0.2
                            LuaKey.String "weaponvelocity", LuaValue.Number 520.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "shields", LuaValue.Number 160.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "acidspit"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 125.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let raptor_air_gunship_antiair_t2_v1 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.8
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 4550.0
            LuaKey.String "metalcost", LuaValue.Number 212.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorf1.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9375.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canland", LuaValue.Bool true
            LuaKey.String "canloopbackattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "cansubmerge", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "70 70 70"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "TALON_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "maneuverleashlength", LuaValue.String "20000"
            LuaKey.String "mass", LuaValue.Number 227.5
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxaileron", LuaValue.Number 0.025
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 350.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 240.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorf1.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorf1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.835
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "hoverAttack", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
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
                    LuaKey.String "aaweapon", LuaValue.Table [
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
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "AAWEAPON"
                        ]
                ]
        ]

    let raptor_air_gunship_basic_t2_v1 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.8
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 4550.0
            LuaKey.String "metalcost", LuaValue.Number 212.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorf1.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9375.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canland", LuaValue.Bool true
            LuaKey.String "canloopbackattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "cansubmerge", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "70 70 70"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "TALON_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "maneuverleashlength", LuaValue.String "20000"
            LuaKey.String "mass", LuaValue.Number 227.5
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxaileron", LuaValue.Number 0.025
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 350.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 240.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorf1.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorf1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.835
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "hoverAttack", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
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
                        ]
                ]
        ]

    let raptor_air_gunship_emp_t2_v1 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.8
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 4550.0
            LuaKey.String "metalcost", LuaValue.Number 212.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorf1.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9375.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canland", LuaValue.Bool true
            LuaKey.String "canloopbackattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "cansubmerge", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "70 70 70"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "TALON_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "maneuverleashlength", LuaValue.String "20000"
            LuaKey.String "mass", LuaValue.Number 227.5
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxaileron", LuaValue.Number 0.025
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 350.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 240.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorf1.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorf1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.835
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "hoverAttack", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
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
                    LuaKey.String "raptorparalyzerbig", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 100.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
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
                            LuaKey.String "reloadtime", LuaValue.Number 4.5
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
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "raptorparalyzerbig"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 125.0
                        ]
                ]
        ]

    let raptor_air_gunship_fire_t2_v1 =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.8
            LuaKey.String "airhoverfactor", LuaValue.Number 0.0
            LuaKey.String "attackrunlength", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 0.1
            LuaKey.String "energycost", LuaValue.Number 4550.0
            LuaKey.String "metalcost", LuaValue.Number 212.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorf1.DDS"
            LuaKey.String "buildtime", LuaValue.Number 9375.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canland", LuaValue.Bool true
            LuaKey.String "canloopbackattack", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.String "1"
            LuaKey.String "cansubmerge", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "70 70 70"
            LuaKey.String "collisionvolumetype", LuaValue.String "sphere"
            LuaKey.String "cruisealtitude", LuaValue.Number 220.0
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "explodeas", LuaValue.String "TALON_DEATH"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "maneuverleashlength", LuaValue.String "20000"
            LuaKey.String "mass", LuaValue.Number 227.5
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxaileron", LuaValue.Number 0.025
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "health", LuaValue.Number 350.0
            LuaKey.String "maxelevator", LuaValue.Number 0.025
            LuaKey.String "maxpitch", LuaValue.Number 0.75
            LuaKey.String "maxrudder", LuaValue.Number 0.025
            LuaKey.String "speed", LuaValue.Number 240.0
            LuaKey.String "moverate1", LuaValue.String "32"
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorf1.s3o"
            LuaKey.String "script", LuaValue.String "Raptors/raptorf1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "TALON_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 1000.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "speedtofront", LuaValue.Number 0.07
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "turnrate", LuaValue.Number 1600.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06593
            LuaKey.String "wingdrag", LuaValue.Number 0.835
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "hoverAttack", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
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
                    LuaKey.String "flamer", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "collidefeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Number 0.0
                            LuaKey.String "avoidfriendly", LuaValue.Number 0.0
                            LuaKey.String "burst", LuaValue.Number 12.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "cegtag", LuaValue.String "burnflamexm"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.82 0.03   0.7 0.4 0.25 0.027   0.44 0.25 0.15 0.024   0.033 0.018 0.011 0.02   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.3
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnblack"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flamegfxtime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.65
                            LuaKey.String "name", LuaValue.String "FlameThrower"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.7
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.83 0.77"
                            LuaKey.String "sizegrowth", LuaValue.Number 0.7
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
                                    LuaKey.String "default", LuaValue.Number 16.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "FLAMER"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 270.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "raptor_air_gunship_acid_t2_v1", raptor_air_gunship_acid_t2_v1
            "raptor_air_gunship_antiair_t2_v1", raptor_air_gunship_antiair_t2_v1
            "raptor_air_gunship_basic_t2_v1", raptor_air_gunship_basic_t2_v1
            "raptor_air_gunship_emp_t2_v1", raptor_air_gunship_emp_t2_v1
            "raptor_air_gunship_fire_t2_v1", raptor_air_gunship_fire_t2_v1
        ]
