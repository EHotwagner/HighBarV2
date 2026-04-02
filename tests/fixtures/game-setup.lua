-- Game scenario for headless integration tests.
-- Defines a small map, 2 teams with builder units per team.
-- Team 0: HighBarV2 AI (our proxy plugin under test)
-- Team 1: NullAI (passive opponent)
--
-- T022B expansion: Start positions are close enough that armed units
-- from opposing teams will naturally engage within 30 frames, enabling
-- combat event tests (UnitDamaged, EnemyEnterLOS, etc.)

local socketPath = os.getenv("HIGHBAR_SOCKET_PATH") or "/tmp/highbar.sock"
local mapName = os.getenv("HIGHBAR_TEST_MAP") or "Comet Catcher Remake 1.8"

return {
    ["mapname"] = mapName,
    ["modoptions"] = {},
    ["ishost"] = 1,
    ["myplayername"] = "HighBarV2Test",

    -- Player definition (host/spectator)
    ["player0"] = {
        ["name"] = "HighBarV2Test",
        ["team"] = 0,
        ["isfromdemo"] = 0,
        ["spectator"] = 1,
    },

    -- Team 0: HighBarV2 AI
    ["ai0"] = {
        ["name"] = "HighBarV2",
        ["team"] = 0,
        ["shortname"] = "HighBarV2",
        ["version"] = "0.1",
        ["host"] = 0,
        ["options"] = {
            ["socket_path"] = socketPath,
        },
    },

    -- Team 1: Null/Passive AI
    ["ai1"] = {
        ["name"] = "NullAI",
        ["team"] = 1,
        ["shortname"] = "NullAI",
        ["version"] = "",
        ["host"] = 0,
    },

    -- Team definitions
    ["team0"] = {
        ["teamleader"] = 0,
        ["allyteam"] = 0,
    },
    ["team1"] = {
        ["teamleader"] = 0,
        ["allyteam"] = 1,
    },

    -- Ally team definitions
    ["allyteam0"] = {
        ["numallies"] = 0,
    },
    ["allyteam1"] = {
        ["numallies"] = 0,
    },

    ["numteams"] = 2,
    ["numallyteams"] = 2,
    ["numplayers"] = 1,

    -- Start positions: teams spawn close enough for combat engagement.
    -- Builder units spawn at the team start position.
    -- With close spawn points, armed units should engage within ~30 frames.
    ["team0startpos"] = { x = 1024, z = 1024 },
    ["team1startpos"] = { x = 1536, z = 1536 },
}
