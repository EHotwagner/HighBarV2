open System
open HighBar.Client

[<EntryPoint>]
let main argv =
    let socketPath =
        match argv with
        | [| path |] -> path
        | _ -> "/tmp/highbar.sock"

    printfn "Echo AI starting, connecting to %s..." socketPath

    use client = new HighBarClient(socketPath)
    client.Connect()
    let hs = client.Handshake()
    printfn "Handshake complete: team=%d map=%s" hs.TeamId hs.MapName

    client.Run(fun frame ->
        printfn "Frame %d: %d events" frame.FrameNumber frame.Events.Length
        for event in frame.Events do
            match event with
            | GameEvent.Init teamId ->
                printfn "  INIT team=%d" teamId
            | GameEvent.Update frame ->
                printfn "  UPDATE frame=%d" frame
            | GameEvent.UnitCreated(unitId, builderId) ->
                printfn "  UNIT_CREATED unit=%d builder=%d" unitId builderId
            | GameEvent.UnitFinished unitId ->
                printfn "  UNIT_FINISHED unit=%d" unitId
            | GameEvent.UnitIdle unitId ->
                printfn "  UNIT_IDLE unit=%d" unitId
            | GameEvent.UnitDamaged(unitId, attacker, damage, _, _) ->
                let attackerStr = attacker |> Option.map string |> Option.defaultValue "none"
                printfn "  UNIT_DAMAGED unit=%d attacker=%s damage=%.1f" unitId attackerStr damage
            | GameEvent.UnitDestroyed(unitId, attacker) ->
                let attackerStr = attacker |> Option.map string |> Option.defaultValue "none"
                printfn "  UNIT_DESTROYED unit=%d attacker=%s" unitId attackerStr
            | GameEvent.EnemyEnterLOS enemyId ->
                printfn "  ENEMY_ENTER_LOS enemy=%d" enemyId
            | GameEvent.EnemyDestroyed(enemyId, _) ->
                printfn "  ENEMY_DESTROYED enemy=%d" enemyId
            | GameEvent.Release ->
                printfn "  RELEASE"
            | other ->
                printfn "  %A" other
        [] // Return no commands — echo only
    )

    printfn "Echo AI finished."
    0
