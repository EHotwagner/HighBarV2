namespace HighBar.Client

open System
open System.Diagnostics
open System.IO

/// Manages engine process spawning, data directory detection, and shutdown.
module EngineLauncher =

    /// Extract the GUID portion from a socket path like /tmp/highbar-abcd1234.sock
    let private extractGuid (socketPath: string) =
        let fileName = Path.GetFileNameWithoutExtension(socketPath)
        if fileName.StartsWith("highbar-") then
            fileName.Substring(8)
        else
            Guid.NewGuid().ToString("N")[..7]

    /// Get the session directory for a given config.
    let getSessionDir (config: EngineConfig) : string =
        let guid = extractGuid config.SocketPath
        Path.Combine(Path.GetTempPath(), $"highbar-{guid}")

    /// Auto-detect SPRING_DATADIR from engine binary location or standard paths.
    let detectDataDir (engineBin: string) : string option =
        // First check environment variable
        match Environment.GetEnvironmentVariable("SPRING_DATADIR") with
        | null | "" -> ()
        | v when Directory.Exists(v) -> ()  // handled by caller via config
        | _ -> ()

        // Try walking up from the engine binary location
        let tryBinaryParent () =
            try
                let psi = ProcessStartInfo(
                    FileName = "which",
                    Arguments = engineBin,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true)
                use proc = Process.Start(psi)
                let output = proc.StandardOutput.ReadToEnd().Trim()
                proc.WaitForExit()
                if proc.ExitCode <> 0 || String.IsNullOrEmpty(output) then
                    None
                else
                    let binDir = Path.GetDirectoryName(output)
                    let parent = Directory.GetParent(binDir)
                    if isNull parent || isNull parent.Parent then None
                    else
                        let candidate = parent.Parent.FullName
                        if Directory.Exists(Path.Combine(candidate, "maps"))
                           && Directory.Exists(Path.Combine(candidate, "packages")) then
                            Some candidate
                        else None
            with _ -> None

        let tryStandardPath () =
            let candidate = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                ".local/state/Beyond All Reason")
            if Directory.Exists(Path.Combine(candidate, "maps"))
               && Directory.Exists(Path.Combine(candidate, "packages")) then
                Some candidate
            else None

        tryBinaryParent () |> Option.orElseWith tryStandardPath

    /// Copy ArchiveCache20.lua from data dir to session dir if available.
    let private copyArchiveCache (dataDir: string) (sessionDir: string) =
        let sourcePath = Path.Combine(dataDir, "cache", "ArchiveCache20.lua")
        if File.Exists(sourcePath) then
            let destDir = Path.Combine(sessionDir, "cache")
            Directory.CreateDirectory(destDir) |> ignore
            File.Copy(sourcePath, Path.Combine(destDir, "ArchiveCache20.lua"), overwrite = true)

    /// Launch the engine process with the given config and script content.
    /// Returns the engine Process handle. Writes PID to {socketPath}.pid.
    let launch (config: EngineConfig) (scriptContent: string) : Process =
        let sessionDir = getSessionDir config
        Directory.CreateDirectory(sessionDir) |> ignore

        // Write script file
        let scriptPath = Path.Combine(sessionDir, "script.txt")
        File.WriteAllText(scriptPath, scriptContent)

        // Resolve SPRING_DATADIR
        let dataDir =
            match config.DataDir with
            | Some dir -> Some dir
            | None -> detectDataDir config.EngineBin

        // Copy archive cache if available
        dataDir |> Option.iter (fun dir -> copyArchiveCache dir sessionDir)

        // Write springsettings.cfg with hang timeout
        let settingsPath = Path.Combine(sessionDir, "springsettings.cfg")
        File.WriteAllText(settingsPath, "HangTimeout = 600\nFullscreen=0\nXResolution=1280\nYResolution=720\n")

        // Set up process
        let engineBinary =
            match config.Mode with
            | Headless -> config.EngineBin
            | Graphical -> config.EngineBin  // caller should set EngineBin to AppImage path for graphical

        let psi = ProcessStartInfo(
            FileName = engineBinary,
            Arguments = scriptPath,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = true)

        psi.Environment.["HIGHBAR_SOCKET_PATH"] <- config.SocketPath
        psi.Environment.["SPRING_WRITEDIR"] <- sessionDir
        dataDir |> Option.iter (fun dir -> psi.Environment.["SPRING_DATADIR"] <- dir)

        let proc = Process.Start(psi)

        // Redirect stdout/stderr to files in session dir
        let stdoutWriter = new StreamWriter(Path.Combine(sessionDir, "engine-stdout.log"), append = false)
        let stderrWriter = new StreamWriter(Path.Combine(sessionDir, "engine-stderr.log"), append = false)

        proc.OutputDataReceived.Add(fun args ->
            if not (isNull args.Data) then
                stdoutWriter.WriteLine(args.Data)
                stdoutWriter.Flush())

        proc.ErrorDataReceived.Add(fun args ->
            if not (isNull args.Data) then
                stderrWriter.WriteLine(args.Data)
                stderrWriter.Flush())

        proc.BeginOutputReadLine()
        proc.BeginErrorReadLine()

        // Write PID file
        let pidPath = $"{config.SocketPath}.pid"
        File.WriteAllText(pidPath, string proc.Id)

        eprintfn $"Engine started (PID {proc.Id}), socket: {config.SocketPath}"
        proc

    /// Stop an engine process: SIGTERM, wait graceMs, then SIGKILL if needed.
    /// Cleans up socket and PID files.
    let stop (socketPath: string) (proc: Process) (graceMs: int) : unit =
        if not proc.HasExited then
            // Send SIGTERM via kill command
            try
                let killPsi = ProcessStartInfo(
                    FileName = "kill",
                    Arguments = $"-TERM {proc.Id}",
                    UseShellExecute = false,
                    CreateNoWindow = true)
                use killProc = Process.Start(killPsi)
                killProc.WaitForExit()
            with _ -> ()

            // Wait for graceful exit
            if not (proc.WaitForExit(graceMs)) then
                try proc.Kill() with _ -> ()

        // Clean up socket file
        if File.Exists(socketPath) then
            try File.Delete(socketPath) with _ -> ()

        // Clean up PID file
        let pidPath = $"{socketPath}.pid"
        if File.Exists(pidPath) then
            try File.Delete(pidPath) with _ -> ()

    /// Scan for stale PID files from previous runs and clean up dead processes.
    /// Only kills processes tracked via our PID files. Logs warnings for untracked
    /// spring-headless processes.
    let cleanupStaleProcesses () : unit =
        // Scan for our PID files
        let pidFiles =
            try Directory.GetFiles("/tmp", "highbar-*.pid")
            with _ -> [||]

        for pidFile in pidFiles do
            try
                let pidStr = File.ReadAllText(pidFile).Trim()
                match Int32.TryParse(pidStr) with
                | true, pid ->
                    try
                        let proc = Process.GetProcessById(pid)
                        // Process still alive — kill it
                        eprintfn $"Cleaning up stale engine process (PID {pid}) from {pidFile}"
                        try proc.Kill() with _ -> ()
                        proc.WaitForExit(3000) |> ignore
                    with :? ArgumentException ->
                        () // Process already dead, just clean up file
                    // Clean up the PID file and associated socket
                    try File.Delete(pidFile) with _ -> ()
                    let socketPath = pidFile.Replace(".pid", "")
                    if File.Exists(socketPath) then
                        try File.Delete(socketPath) with _ -> ()
                | _ -> ()
            with _ -> ()

        // Warn about untracked spring-headless processes
        try
            let psi = ProcessStartInfo(
                FileName = "pgrep",
                Arguments = "-x spring-headless",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true)
            use proc = Process.Start(psi)
            let output = proc.StandardOutput.ReadToEnd().Trim()
            proc.WaitForExit()
            if proc.ExitCode = 0 && not (String.IsNullOrEmpty(output)) then
                let pids = output.Split('\n') |> Array.map (fun s -> s.Trim()) |> Array.filter (fun s -> s.Length > 0)
                if pids.Length > 0 then
                    let pidList = String.Join(", ", pids)
                    eprintfn $"WARNING: {pids.Length} untracked spring-headless process(es) detected (PIDs: {pidList}). These were not started by the test harness."
        with _ -> ()
