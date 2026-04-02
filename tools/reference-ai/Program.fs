open System
open HighBar.Client

/// Simple reference AI:
/// 1. On game start, orders the first builder to construct a factory
/// 2. When units finish building, sends them to patrol/attack nearest enemy
[<EntryPoint>]
let main argv =
    let socketPath =
        match argv with
        | [| path |] -> path
        | _ -> "/tmp/highbar.sock"

    printfn "Reference AI starting, connecting to %s..." socketPath

    let mutable firstUnit = -1
    let mutable builtFactory = false
    let mutable knownEnemies = Set.empty<int>

    use client = new HighBarClient(socketPath)
    client.Connect()
    let hs = client.Handshake()
    printfn "Playing as team %d on %s" hs.TeamId hs.MapName

    client.Run(fun frame ->
        let mutable commands = []

        for event in frame.Events do
            match event with
            | GameEvent.UnitFinished unitId ->
                if firstUnit < 0 then firstUnit <- unitId
                if not builtFactory && firstUnit = unitId then
                    // Build a factory at a fixed position
                    commands <- Commands.BuildCommand unitId 1 500.0f 0.0f 500.0f 0 :: commands
                    builtFactory <- true
                else
                    // Send new units to fight
                    commands <- Commands.FightCommand unitId 2000.0f 0.0f 2000.0f :: commands

            | GameEvent.UnitIdle unitId ->
                // Idle units patrol forward
                commands <- Commands.PatrolCommand unitId 2000.0f 0.0f 2000.0f :: commands

            | GameEvent.EnemyEnterLOS enemyId ->
                knownEnemies <- knownEnemies.Add(enemyId)

            | GameEvent.EnemyDestroyed(enemyId, _) ->
                knownEnemies <- knownEnemies.Remove(enemyId)

            | _ -> ()

        commands
    )

    printfn "Reference AI finished."
    0
