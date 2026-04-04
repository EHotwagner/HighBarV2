open System
open HighBar.Client

/// Simple reference AI with logging:
/// 1. Discovers unit defs from the engine
/// 2. Orders commander to move toward map center
/// 3. When idle, patrols forward
[<EntryPoint>]
let main argv =
    let socketPath =
        match argv with
        | [| path |] -> path
        | _ -> "/tmp/highbar.sock"

    printfn "Reference AI listening on %s..." socketPath
    printfn "Start a game with HighBarV2 bot in the BAR lobby."

    use client = HighBarClient.AcceptFromProxy(socketPath, 600_000)
    printfn "Proxy connected! Game starting."

    let mutable initialized = false
    let mutable myTeam = -1
    let mutable frameCount = 0
    let mutable commanderUnitId = -1
    let mutable sentInitialCommand = false

    client.Run(fun frame ->
        let mutable commands = []
        frameCount <- frameCount + 1

        for event in frame.Events do
            match event with
            | GameEvent.Init teamId ->
                myTeam <- teamId
                printfn "[Frame %d] Init: team %d" frame.FrameNumber myTeam

                // Query map info
                let mapW = client.GetMapWidth()
                let mapH = client.GetMapHeight()
                printfn "[Frame %d] Map size: %d x %d" frame.FrameNumber mapW mapH

                initialized <- true

            | GameEvent.UnitCreated(unitId, builderId) ->
                let defId = client.GetUnitDef(unitId)
                let defName = client.GetUnitDefName(defId)
                printfn "[Frame %d] UnitCreated: id=%d def=%s builderId=%d" frame.FrameNumber unitId defName builderId

            | GameEvent.UnitFinished unitId ->
                let defId = client.GetUnitDef(unitId)
                let defName = client.GetUnitDefName(defId)
                let (px, py, pz) = client.GetUnitPos(unitId)
                printfn "[Frame %d] UnitFinished: id=%d def=%s pos=(%.0f, %.0f, %.0f)" frame.FrameNumber unitId defName px py pz
                if commanderUnitId < 0 then
                    commanderUnitId <- unitId

            | GameEvent.UnitIdle unitId ->
                let defId = client.GetUnitDef(unitId)
                let defName = client.GetUnitDefName(defId)
                let (px, py, pz) = client.GetUnitPos(unitId)
                printfn "[Frame %d] UnitIdle: id=%d def=%s pos=(%.0f, %.0f, %.0f)" frame.FrameNumber unitId defName px py pz

                // Move toward map center (sent on idle, after game truly starts)
                let mapW = float32 (client.GetMapWidth()) * 4.0f
                let mapH = float32 (client.GetMapHeight()) * 4.0f
                printfn "[Frame %d] Sending MoveCommand unit %d to (%.0f, %.0f, %.0f)" frame.FrameNumber unitId mapW py mapH
                commands <- Commands.MoveCommand unitId mapW py mapH :: commands
                commands <- Commands.SendTextMessageCommand (sprintf "HighBarV2: moving %s to center!" defName) 0 :: commands

            | GameEvent.EnemyEnterLOS enemyId ->
                printfn "[Frame %d] EnemyEnterLOS: %d" frame.FrameNumber enemyId

            | GameEvent.EnemyDestroyed(enemyId, _) ->
                printfn "[Frame %d] EnemyDestroyed: %d" frame.FrameNumber enemyId

            | GameEvent.UnitDamaged(unitId, attackerId, damage, _, _) ->
                printfn "[Frame %d] UnitDamaged: id=%d attacker=%A dmg=%.0f" frame.FrameNumber unitId attackerId damage

            | GameEvent.UnitDestroyed(unitId, attackerId) ->
                printfn "[Frame %d] UnitDestroyed: id=%d attacker=%A" frame.FrameNumber unitId attackerId

            | GameEvent.Update f ->
                // Send initial command at frame 60 (2 seconds after game start)
                if f = 300 && commanderUnitId >= 0 && not sentInitialCommand then
                    sentInitialCommand <- true
                    let (px, py, pz) = client.GetUnitPos(commanderUnitId)
                    let defId = client.GetUnitDef(commanderUnitId)

                    // Spawn a second commander via cheat
                    printfn "[Frame %d] GiveMeNewUnit defId=%d at (%.0f,%.0f,%.0f)" f defId (px + 200.0f) py pz
                    commands <- Commands.GiveMeNewUnitCommand defId (px + 200.0f) py pz :: commands

                    // Move commander
                    let mapW = float32 (client.GetMapWidth()) * 4.0f
                    let mapH = float32 (client.GetMapHeight()) * 4.0f
                    let moveCmd = Commands.MoveCommand commanderUnitId mapW py mapH
                    let mc = moveCmd.MoveUnit
                    printfn "[Frame %d] MoveCommand: unit %d to (%.0f,%.0f,%.0f) timeout=%d" f mc.UnitId mc.ToPosition.X mc.ToPosition.Y mc.ToPosition.Z mc.Timeout
                    commands <- moveCmd :: commands

                    // Chat message
                    commands <- Commands.SendTextMessageCommand "HighBarV2: commands sent!" 0 :: commands

                if f % 900 = 0 then
                    printfn "[Frame %d] Update tick" f

            | _ -> ()

        if frameCount = 1 then
            printfn "[Frame %d] Returning %d commands from first frame" frame.FrameNumber commands.Length

        commands
    )

    printfn "Reference AI finished."
    0
