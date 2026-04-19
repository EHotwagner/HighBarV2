namespace HighBar.Client

open System
open System.IO
open System.IO.Compression

/// Dynamic engine + game resolution.
///
/// Ported from FSBarV1 (src/FSBar.Client/EngineDiscovery.fs). Rationale: the
/// rapid-pool game name changes every few days (e.g. "Beyond All Reason
/// test-29907-d3b337a" → "test-29926-0571aa8") as upstream cuts new test
/// releases. Hardcoding the name in engine-version.json gets stale and breaks
/// live integration tests. This module resolves the current name from
/// `rapid/repos-cdn.beyondallreason.dev/byar/versions.gz` at runtime.
module EngineDiscovery =

    let standardDataDir () =
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            ".local/state/Beyond All Reason")

    let defaultDataDir () =
        let candidate = standardDataDir ()
        if Directory.Exists(Path.Combine(candidate, "maps"))
           && Directory.Exists(Path.Combine(candidate, "packages")) then
            Some candidate
        else
            None

    /// Look up the latest rapid entry for a given tag (e.g. "byar:test") in
    /// the installed rapid/versions.gz. Returns the fully-resolved game name
    /// (e.g. "Beyond All Reason test-29926-0571aa8") or None if not found.
    let discoverGameName (dataDir: string) (tag: string) : string option =
        let candidates = [
            Path.Combine(dataDir, "rapid/repos-cdn.beyondallreason.dev/byar/versions.gz")
            Path.Combine(dataDir, "rapid/repos.springrts.com/byar/versions.gz")
        ]
        let existing = candidates |> List.tryFind File.Exists
        match existing with
        | None -> None
        | Some versionsPath ->
            try
                use fs = File.OpenRead(versionsPath)
                use gz = new GZipStream(fs, CompressionMode.Decompress)
                use reader = new StreamReader(gz)
                let content = reader.ReadToEnd()
                let prefix = tag + ","
                content.Split('\n')
                |> Array.tryFindBack (fun line -> line.StartsWith(prefix))
                |> Option.bind (fun line ->
                    let parts = line.Split(',')
                    if parts.Length >= 4 then Some parts.[3] else None)
            with _ -> None
