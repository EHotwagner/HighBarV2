namespace BarData.V1

/// Standard engine commands (from Spring/Recoil Command.h).
module EngineCommands =
    [<Literal>] let STOP = 0
    [<Literal>] let INSERT = 1
    [<Literal>] let REMOVE = 2
    [<Literal>] let WAIT = 5
    [<Literal>] let TIMEWAIT = 6
    [<Literal>] let DEATHWAIT = 7
    [<Literal>] let SQUADWAIT = 8
    [<Literal>] let GATHERWAIT = 9
    [<Literal>] let MOVE = 10
    [<Literal>] let PATROL = 15
    [<Literal>] let FIGHT = 16
    [<Literal>] let ATTACK = 20
    [<Literal>] let AREA_ATTACK = 21
    [<Literal>] let GUARD = 25
    [<Literal>] let AISELECT = 30
    [<Literal>] let GROUPSELECT = 35
    [<Literal>] let GROUPADD = 36
    [<Literal>] let GROUPCLEAR = 37
    [<Literal>] let REPAIR = 40
    [<Literal>] let FIRE_STATE = 45
    [<Literal>] let MOVE_STATE = 50
    [<Literal>] let SETBASE = 55
    [<Literal>] let INTERNAL = 60
    [<Literal>] let SELFD = 65
    [<Literal>] let SET_WANTED_MAX_SPEED = 70
    [<Literal>] let LOAD_UNITS = 75
    [<Literal>] let LOAD_ONTO = 76
    [<Literal>] let UNLOAD_UNITS = 80
    [<Literal>] let UNLOAD_UNIT = 81
    [<Literal>] let ONOFF = 85
    [<Literal>] let RECLAIM = 90
    [<Literal>] let CLOAK = 95
    [<Literal>] let STOCKPILE = 100
    [<Literal>] let MANUALFIRE = 105
    [<Literal>] let RESTORE = 110
    [<Literal>] let REPEAT = 115
    [<Literal>] let TRAJECTORY = 120
    [<Literal>] let RESURRECT = 125
    [<Literal>] let CAPTURE = 130
    [<Literal>] let AUTOREPAIRLEVEL = 135
    [<Literal>] let IDLEMODE = 145

    /// Build command ID for a unit def (negative of def ID).
    let buildCmd (unitDefId: int) = -unitDefId

    /// All engine commands as (name, id) pairs.
    let all =
        [
            "STOP", STOP; "INSERT", INSERT; "REMOVE", REMOVE
            "WAIT", WAIT; "TIMEWAIT", TIMEWAIT; "DEATHWAIT", DEATHWAIT
            "SQUADWAIT", SQUADWAIT; "GATHERWAIT", GATHERWAIT
            "MOVE", MOVE; "PATROL", PATROL; "FIGHT", FIGHT
            "ATTACK", ATTACK; "AREA_ATTACK", AREA_ATTACK; "GUARD", GUARD
            "AISELECT", AISELECT; "GROUPSELECT", GROUPSELECT
            "GROUPADD", GROUPADD; "GROUPCLEAR", GROUPCLEAR
            "REPAIR", REPAIR; "FIRE_STATE", FIRE_STATE; "MOVE_STATE", MOVE_STATE
            "SETBASE", SETBASE; "INTERNAL", INTERNAL; "SELFD", SELFD
            "SET_WANTED_MAX_SPEED", SET_WANTED_MAX_SPEED
            "LOAD_UNITS", LOAD_UNITS; "LOAD_ONTO", LOAD_ONTO
            "UNLOAD_UNITS", UNLOAD_UNITS; "UNLOAD_UNIT", UNLOAD_UNIT
            "ONOFF", ONOFF; "RECLAIM", RECLAIM; "CLOAK", CLOAK
            "STOCKPILE", STOCKPILE; "MANUALFIRE", MANUALFIRE
            "RESTORE", RESTORE; "REPEAT", REPEAT; "TRAJECTORY", TRAJECTORY
            "RESURRECT", RESURRECT; "CAPTURE", CAPTURE
            "AUTOREPAIRLEVEL", AUTOREPAIRLEVEL; "IDLEMODE", IDLEMODE
        ]
