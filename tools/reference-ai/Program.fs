open System
open HighBar.Client

/// Patrol demo: commander walks back and forth between two points forever.
[<EntryPoint>]
let main argv =
    let socketPath =
        match argv with
        | [| path |] -> path
        | _ -> "/tmp/highbar.sock"

    printfn "Patrol demo AI listening on %s..." socketPath

    use client = HighBarClient.AcceptFromProxy(socketPath, 600_000)
    printfn "Proxy connected! Game starting."

    let mutable commanderUnitId = -1
    let mutable startX = 0.0f
    let mutable startZ = 0.0f
    let mutable startY = 0.0f
    let mutable goingToB = false
    let mutable lastSentFrame = -1
    let mutable started = false

    // Target B: map center
    let mutable targetBx = 0.0f
    let mutable targetBz = 0.0f

    client.Run(fun frame ->
        let mutable commands = []

        for event in frame.Events do
            match event with
            | GameEvent.Init teamId ->
                printfn "[Frame %d] Init: team %d" frame.FrameNumber teamId
                let mapW = float32 (client.GetMapWidth()) * 4.0f
                let mapH = float32 (client.GetMapHeight()) * 4.0f
                targetBx <- mapW
                targetBz <- mapH
                printfn "[Frame %d] Map center: (%.0f, %.0f)" frame.FrameNumber targetBx targetBz

            | GameEvent.UnitFinished unitId when commanderUnitId < 0 ->
                let defId = client.GetUnitDef(unitId)
                let defName = client.GetUnitDefName(defId)
                let (px, py, pz) = client.GetUnitPos(unitId)
                commanderUnitId <- unitId
                startX <- px
                startY <- py
                startZ <- pz
                printfn "[Frame %d] Commander: %s (id=%d) at (%.0f, %.0f)" frame.FrameNumber defName unitId px pz

            | GameEvent.UnitIdle unitId when unitId = commanderUnitId ->
                // Arrived at destination — flip direction
                let (px, _, pz) = client.GetUnitPos(unitId)
                if goingToB then
                    printfn "[Frame %d] Arrived at B (%.0f, %.0f) — heading back to A" frame.FrameNumber px pz
                    commands <- Commands.MoveCommand unitId startX startY startZ :: commands
                    goingToB <- false
                else
                    printfn "[Frame %d] Arrived at A (%.0f, %.0f) — heading to B" frame.FrameNumber px pz
                    commands <- Commands.MoveCommand unitId targetBx startY targetBz :: commands
                    goingToB <- true
            | GameEvent.Update f ->
                // Kick off the first move at frame 60
                if f = 60 && commanderUnitId >= 0 && not started then
                    printfn "[Frame %d] Starting patrol: A(%.0f,%.0f) <-> B(%.0f,%.0f)" f startX startZ targetBx targetBz
                    commands <- Commands.MoveCommand commanderUnitId targetBx startY targetBz :: commands
                    goingToB <- true
                    started <- true

                // Position log every 10 seconds
                if f > 0 && f % 300 = 0 && commanderUnitId >= 0 then
                    let (px, _, pz) = client.GetUnitPos(commanderUnitId)
                    let dir = if goingToB then "-> B" else "-> A"
                    printfn "[Frame %d] Position: (%.0f, %.0f) %s" f px pz dir

            | _ -> ()

        commands
    )

    printfn "Patrol demo finished."
    0
