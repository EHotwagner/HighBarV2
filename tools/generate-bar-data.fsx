#!/usr/bin/env dotnet fsi
/// Clones the Beyond All Reason repo and generates a typed F# library
/// with all unit definitions, weapon definitions, and command IDs.
///
/// Usage:  dotnet fsi tools/generate-bar-data.fsx [--skip-clone]
///
/// Output: data/bar/src/  — generated .fs files
///         data/bar/BarData.fsproj — updated with generated file references

#r "nuget: XParsec"

open System
open System.IO
open System.Text
open System.Text.RegularExpressions
open System.Diagnostics
open System.Collections.Immutable
open XParsec
open XParsec.Parsers
open XParsec.CharParsers

// ---------------------------------------------------------------------------
// Config
// ---------------------------------------------------------------------------

let root     = Path.GetFullPath(Path.Combine(__SOURCE_DIRECTORY__, ".."))
let repoUrl  = "https://github.com/beyond-all-reason/Beyond-All-Reason.git"
let repoDir  = Path.Combine(root, "bar-repo")
let outDir   = Path.Combine(root, "data", "bar", "src")
let projFile = Path.Combine(root, "data", "bar", "BarData.fsproj")
let skipClone = Environment.GetCommandLineArgs() |> Array.exists (fun a -> a = "--skip-clone")

// ---------------------------------------------------------------------------
// Helpers
// ---------------------------------------------------------------------------

let run (exe: string) (args: string) (workDir: string) =
    let psi = ProcessStartInfo(exe, arguments = args)
    psi.WorkingDirectory <- workDir
    psi.RedirectStandardOutput <- true
    psi.RedirectStandardError  <- true
    psi.UseShellExecute <- false
    let p = Process.Start(psi)
    let out = p.StandardOutput.ReadToEnd()
    let err = p.StandardError.ReadToEnd()
    p.WaitForExit()
    if p.ExitCode <> 0 then
        failwithf "Command failed (%d): %s %s\n%s\n%s" p.ExitCode exe args out err
    out

// ---------------------------------------------------------------------------
// 1. Clone repo
// ---------------------------------------------------------------------------

if not skipClone then
    if Directory.Exists(repoDir) then
        printfn "Removing existing bar-repo..."
        Directory.Delete(repoDir, true)
    printfn "Cloning BAR repo (shallow, sparse)..."
    run "git" (sprintf "clone --depth 1 --filter=blob:none --sparse \"%s\" \"%s\"" repoUrl repoDir) root |> ignore
    printfn "Setting up sparse checkout..."
    run "git" "sparse-checkout set units modules gamedata" repoDir |> ignore
    run "git" "checkout" repoDir |> ignore
    printfn "Clone complete."
else
    printfn "Skipping clone (--skip-clone)."

if not (Directory.Exists(repoDir)) then
    failwith "bar-repo directory not found. Run without --skip-clone first."

// ---------------------------------------------------------------------------
// 2. Lua table parser using XParsec
// ---------------------------------------------------------------------------

#nowarn "40"

type LVal =
    | LStr of string | LNum of float | LBool of bool | LNil
    | LTbl of (LKey * LVal) list
    | LExpr of string
and LKey = KStr of string | KInt of int

// -- Whitespace & comments ---------------------------------------------------

let lineComment : Parser<unit, char, unit, ReadableString, ReadableStringSlice> =
    parser {
        let! _ = pstring "--"
        let! next = lookAhead (opt anyChar)
        match next with
        | ValueSome '[' -> return! pzero
        | _ ->
            do! skipManySatisfies (fun c -> c <> '\n')
            return ()
    }

let blockComment : Parser<unit, char, unit, ReadableString, ReadableStringSlice> =
    parser {
        let! _ = pstring "--[["
        let! _, _ = manyCharsTill anyChar (pstring "]]")
        return ()
    }

let ws : Parser<unit, char, unit, ReadableString, ReadableStringSlice> =
    skipMany (
        (satisfyL (fun c -> c = ' ' || c = '\t' || c = '\r' || c = '\n') "ws" |>> ignore)
        <|> blockComment
        <|> lineComment
    )

// -- Primitives --------------------------------------------------------------

let pEscChar : Parser<char, char, unit, ReadableString, ReadableStringSlice> =
    pchar '\\' >>. anyChar |>> fun c ->
        match c with 'n' -> '\n' | 't' -> '\t' | 'r' -> '\r' | _ -> c

let pDblStr = pchar '"' >>. manyChars (pEscChar <|> satisfyL (fun c -> c <> '"' && c <> '\\') "ch") .>> pchar '"'
let pSglStr = pchar '\'' >>. manyChars (pEscChar <|> satisfyL (fun c -> c <> '\'' && c <> '\\') "ch") .>> pchar '\''

let pLongStr : Parser<string, char, unit, ReadableString, ReadableStringSlice> =
    parser {
        let! _ = pstring "[["
        let! s, _ = manyCharsTill anyChar (pstring "]]")
        return s
    }

let pLuaStr = pDblStr <|> pSglStr <|> pLongStr
let pIdent : Parser<string, char, unit, ReadableString, ReadableStringSlice> =
    many1Chars (satisfyL (fun c -> Char.IsLetterOrDigit c || c = '_') "id")

let pHex : Parser<float, char, unit, ReadableString, ReadableStringSlice> =
    parser {
        let! _ = pstring "0x" <|> pstring "0X"
        let! d = many1Chars (satisfyL (fun c -> "0123456789abcdefABCDEF".Contains(c)) "hex")
        return float (Convert.ToInt64(d, 16))
    }
let pNum = pHex <|> pfloat
let pNeg : Parser<float, char, unit, ReadableString, ReadableStringSlice> =
    pchar '-' >>. ws >>. pNum |>> fun n -> -n
let pAnyNum = pNeg <|> pNum

// -- Expression fallback: for runtime Lua expressions we can't evaluate ------

let pExprFallback : Parser<LVal, char, unit, ReadableString, ReadableStringSlice> =
    fun reader ->
        let sb = StringBuilder()
        let mutable parenDepth = 0
        let mutable braceDepth = 0
        let mutable bracketDepth = 0
        let mutable keepGoing = true
        while keepGoing do
            match reader.Peek() with
            | ValueNone -> keepGoing <- false
            | ValueSome c ->
                match c with
                | '(' -> parenDepth <- parenDepth + 1; sb.Append(c) |> ignore; reader.TryRead() |> ignore
                | ')' ->
                    if parenDepth > 0 then parenDepth <- parenDepth - 1; sb.Append(c) |> ignore; reader.TryRead() |> ignore
                    else keepGoing <- false
                | '{' -> braceDepth <- braceDepth + 1; sb.Append(c) |> ignore; reader.TryRead() |> ignore
                | '}' ->
                    if braceDepth > 0 then braceDepth <- braceDepth - 1; sb.Append(c) |> ignore; reader.TryRead() |> ignore
                    else keepGoing <- false
                | '[' -> bracketDepth <- bracketDepth + 1; sb.Append(c) |> ignore; reader.TryRead() |> ignore
                | ']' ->
                    if bracketDepth > 0 then bracketDepth <- bracketDepth - 1; sb.Append(c) |> ignore; reader.TryRead() |> ignore
                    else keepGoing <- false
                | ',' when parenDepth = 0 && braceDepth = 0 && bracketDepth = 0 -> keepGoing <- false
                | '\n' | '\r' when parenDepth = 0 && braceDepth = 0 && bracketDepth = 0 -> keepGoing <- false
                | '-' ->
                    reader.TryRead() |> ignore
                    match reader.Peek() with
                    | ValueSome '-' when parenDepth = 0 -> keepGoing <- false
                    | _ -> sb.Append('-') |> ignore
                | '"' ->
                    sb.Append(c) |> ignore; reader.TryRead() |> ignore
                    let mutable inStr = true
                    while inStr do
                        match reader.Peek() with
                        | ValueNone -> inStr <- false
                        | ValueSome '\\' ->
                            sb.Append('\\') |> ignore; reader.TryRead() |> ignore
                            match reader.Peek() with
                            | ValueSome c2 -> sb.Append(c2) |> ignore; reader.TryRead() |> ignore
                            | _ -> ()
                        | ValueSome '"' -> sb.Append('"') |> ignore; reader.TryRead() |> ignore; inStr <- false
                        | ValueSome c2 -> sb.Append(c2) |> ignore; reader.TryRead() |> ignore
                | '\'' ->
                    sb.Append(c) |> ignore; reader.TryRead() |> ignore
                    let mutable inStr = true
                    while inStr do
                        match reader.Peek() with
                        | ValueNone -> inStr <- false
                        | ValueSome '\\' ->
                            sb.Append('\\') |> ignore; reader.TryRead() |> ignore
                            match reader.Peek() with
                            | ValueSome c2 -> sb.Append(c2) |> ignore; reader.TryRead() |> ignore
                            | _ -> ()
                        | ValueSome '\'' -> sb.Append('\'') |> ignore; reader.TryRead() |> ignore; inStr <- false
                        | ValueSome c2 -> sb.Append(c2) |> ignore; reader.TryRead() |> ignore
                | _ -> sb.Append(c) |> ignore; reader.TryRead() |> ignore
        let s = sb.ToString().Trim()
        if s.Length > 0 then Ok (LExpr s)
        else Error { Position = reader.Position; Errors = ErrorType.Message "expected expression" }

// -- Recursive value parser --------------------------------------------------

let rec pValue : Parser<LVal, char, unit, ReadableString, ReadableStringSlice> =
    fun reader ->
        let p =
            match reader.Peek() with
            | ValueSome '{' -> pTable
            | ValueSome '"' -> pDblStr |>> LStr
            | ValueSome '\'' -> pSglStr |>> LStr
            | ValueSome '[' -> pLongStr |>> LStr
            | ValueSome 't' -> (pstring "true" >>% LBool true) <|> pExprFallback
            | ValueSome 'f' -> (pstring "false" >>% LBool false) <|> pExprFallback
            | ValueSome 'n' -> (pstring "nil" >>% LNil) <|> pExprFallback
            | ValueSome '-' -> (pNeg |>> LNum) <|> pExprFallback
            | ValueSome '#' -> pExprFallback
            | ValueSome '(' -> pExprFallback
            | ValueSome _ -> (pAnyNum |>> LNum) <|> pExprFallback
            | ValueNone -> pzero
        let pMaybeExpr : Parser<LVal, char, unit, ReadableString, ReadableStringSlice> =
            parser {
                let! v = p
                let! next = lookAhead (opt anyChar)
                match next with
                | ValueSome c when c = '*' || c = '+' || c = '/' || c = '%' || c = '^'
                                || c = '.' || c = '(' || c = ':' || c = '#' ->
                    return! pzero
                | _ -> return v
            }
        (pMaybeExpr <|> pExprFallback) reader

and pEntry : Parser<LKey * LVal, char, unit, ReadableString, ReadableStringSlice> =
    let pBracket =
        parser {
            let! _ = pchar '['
            let! _ = ws
            let! key = (pAnyNum |>> fun n -> KInt(int n)) <|> (pLuaStr |>> KStr)
            let! _ = ws
            let! _ = pchar ']'
            let! _ = ws
            let! _ = pchar '='
            let! _ = ws
            let! v = pValue
            return (key, v)
        }
    let pIdentEntry =
        parser {
            let! name = pIdent
            let! _ = ws
            let! _ = pchar '='
            let! _ = ws
            let! v = pValue
            return (KStr name, v)
        }
    pBracket <|> pIdentEntry

and pTable : Parser<LVal, char, unit, ReadableString, ReadableStringSlice> =
    parser {
        let! _ = pchar '{'
        let! _ = ws
        let! entries, _ = sepEndBy (pEntry .>> ws) ((pchar ',' <|> pchar ';') .>> ws)
        let! _ = ws
        let! _ = pchar '}'
        return LTbl(List.ofSeq entries)
    }

let pTop : Parser<LVal, char, unit, ReadableString, ReadableStringSlice> =
    parser {
        let! _ = ws
        let! _ = skipMany (pstring "local" >>. ws >>. pIdent >>. ws >>. pchar '=' >>. ws >>. pExprFallback >>. ws)
        let! _ = opt (pstring "return" >>. ws)
        let! v = pValue
        let! _ = ws
        return v
    }

let parseLua (src: string) : Result<LVal, string> =
    let reader = Reader.ofString src ()
    match pTop reader with
    | Ok v -> Ok v
    | Error e -> Error (XParsec.ErrorFormatting.formatStringError src e)

// ---------------------------------------------------------------------------
// 3. Code generation — emit F# source
// ---------------------------------------------------------------------------

module CodeGen =

    let escapeString (s: string) =
        s.Replace("\\", "\\\\")
         .Replace("\"", "\\\"")
         .Replace("\n", "\\n")
         .Replace("\r", "\\r")
         .Replace("\t", "\\t")

    let sanitizeIdent (s: string) =
        let s = s.Replace("-", "_").Replace(" ", "_").Replace("/", "_").Replace("\\", "_")
        if s.Length > 0 && Char.IsDigit(s.[0]) then "_" + s else s

    /// Emit a LVal as an F# expression constructing BarData.LuaValue.
    let rec emitValue (indent: int) (v: LVal) : string =
        let pad2 = String(' ', indent + 4)
        match v with
        | LStr s -> sprintf "LuaValue.String \"%s\"" (escapeString s)
        | LNum n ->
            if n = Math.Floor(n) && not (Double.IsInfinity n) && Math.Abs(n) < 1e15 then
                sprintf "LuaValue.Number %s.0" (int64 n |> string)
            else
                sprintf "LuaValue.Number %s" (n.ToString("G", Globalization.CultureInfo.InvariantCulture))
        | LBool b -> if b then "LuaValue.Bool true" else "LuaValue.Bool false"
        | LNil -> "LuaValue.Nil"
        | LExpr s -> sprintf "LuaValue.Expr \"%s\"" (escapeString s)
        | LTbl [] -> "LuaValue.Table []"
        | LTbl entries ->
            let sb = StringBuilder()
            sb.AppendLine("LuaValue.Table [") |> ignore
            for (k, v) in entries do
                let ks =
                    match k with
                    | KStr s -> sprintf "LuaKey.String \"%s\"" (escapeString s)
                    | KInt i -> sprintf "LuaKey.Int %d" i
                sb.Append(pad2).Append(ks).Append(", ").AppendLine(emitValue (indent + 8) v) |> ignore
            sb.Append(String(' ', indent)).Append("]") |> ignore
            sb.ToString()

    /// Emit a module with unit definitions.
    let emitUnitsModule (modName: string) (subfolder: string) (units: (string * LVal) list) : string =
        let sb = StringBuilder()
        sb.AppendLine(sprintf "// Auto-generated BAR unit data: %s" subfolder) |> ignore
        sb.AppendLine("namespace BarData.Units") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("open BarData") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine(sprintf "module %s =" modName) |> ignore
        sb.AppendLine() |> ignore
        for (name, value) in units |> List.sortBy fst do
            let ident = sanitizeIdent name
            sb.AppendLine(sprintf "    let %s =" ident) |> ignore
            sb.Append("        ").AppendLine(emitValue 8 value) |> ignore
            sb.AppendLine() |> ignore
        sb.AppendLine("    let all : (string * LuaValue) list =") |> ignore
        sb.AppendLine("        [") |> ignore
        for (name, _) in units |> List.sortBy fst do
            sb.AppendLine(sprintf "            \"%s\", %s" name (sanitizeIdent name)) |> ignore
        sb.AppendLine("        ]") |> ignore
        sb.ToString()

    /// Emit the custom commands module.
    let emitCustomCommands (cmds: (string * int) list) : string =
        let sb = StringBuilder()
        sb.AppendLine("// Auto-generated BAR custom command IDs") |> ignore
        sb.AppendLine("namespace BarData") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("module CustomCommands =") |> ignore
        for (name, id) in cmds |> List.sortBy snd do
            sb.AppendLine(sprintf "    [<Literal>] let %s = %d" name id) |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("    let all = [") |> ignore
        for (name, id) in cmds |> List.sortBy snd do
            sb.AppendLine(sprintf "        \"%s\", %d" name id) |> ignore
        sb.AppendLine("    ]") |> ignore
        sb.ToString()

    /// Emit the AllUnits index module.
    let emitIndex (groups: (string * (string * LVal) list) list) : string =
        let sb = StringBuilder()
        sb.AppendLine("// Auto-generated index of all BAR unit definitions") |> ignore
        sb.AppendLine("namespace BarData") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("open BarData.Units") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("module AllUnits =") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("    let all : (string * string * LuaValue) list =") |> ignore
        sb.AppendLine("        [") |> ignore
        for (sub, units) in groups do
            let modName = sanitizeIdent sub
            for (name, _) in units |> List.sortBy fst do
                sb.AppendLine(sprintf "            \"%s\", \"%s\", %s.%s" name sub modName (sanitizeIdent name)) |> ignore
        sb.AppendLine("        ]") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("    let tryFind (name: string) : LuaValue option =") |> ignore
        sb.AppendLine("        all |> List.tryFind (fun (n, _, _) -> n = name) |> Option.map (fun (_, _, v) -> v)") |> ignore
        sb.ToString()

// ---------------------------------------------------------------------------
// 4. Parse custom commands
// ---------------------------------------------------------------------------

let parseCustomCommands () : (string * int) list =
    let path = Path.Combine(repoDir, "modules", "customcommands.lua")
    if not (File.Exists path) then [] else
    let src = File.ReadAllText(path)
    let rx = Regex(@"(\w+)\s*=\s*(\d+)", RegexOptions.Multiline)
    [ for m in rx.Matches(src) do
        let name = m.Groups.[1].Value
        let id = int m.Groups.[2].Value
        if id > 1000 then yield (name, id) ]
    |> List.distinctBy fst

// ---------------------------------------------------------------------------
// 5. Discover and parse unit files
// ---------------------------------------------------------------------------

let discoverUnitFiles () =
    let unitsDir = Path.Combine(repoDir, "units")
    if not (Directory.Exists unitsDir) then failwithf "units/ not found in %s" repoDir
    [ for f in Directory.GetFiles(unitsDir, "*.lua", SearchOption.AllDirectories) do
        let rel = Path.GetRelativePath(unitsDir, f)
        let sub =
            let dir = Path.GetDirectoryName(rel)
            if String.IsNullOrEmpty(dir) then "Root"
            else dir.Replace(Path.DirectorySeparatorChar, '/')
        yield (sub, f) ]

let parseUnitFile (path: string) : (string * LVal) list =
    try
        let src = File.ReadAllText(path)
        match parseLua src with
        | Ok(LTbl entries) ->
            [ for (k, v) in entries do match k with KStr name -> yield (name, v) | _ -> () ]
        | Ok _ -> []
        | Error msg ->
            printfn "  Warning: %s: %s" (Path.GetFileName path) (msg.Split('\n').[0])
            []
    with ex ->
        printfn "  Warning: %s: %s" (Path.GetFileName path) ex.Message
        []

// ---------------------------------------------------------------------------
// 6. Main
// ---------------------------------------------------------------------------

printfn "Discovering unit files..."
let unitFiles = discoverUnitFiles ()
printfn "Found %d unit files." unitFiles.Length

printfn "Parsing..."
let grouped =
    unitFiles
    |> List.collect (fun (sub, path) ->
        parseUnitFile path |> List.map (fun (name, v) -> (sub, name, v)))
    |> List.groupBy (fun (sub, _, _) -> sub)
    |> List.map (fun (sub, items) -> (sub, items |> List.map (fun (_, n, v) -> (n, v))))
    |> List.sortBy fst

let totalUnits = grouped |> List.sumBy (fun (_, u) -> u.Length)
printfn "Parsed %d unit definitions." totalUnits

let customCmds = parseCustomCommands ()
printfn "Found %d custom commands." customCmds.Length

// Clean generated files (keep hand-written ones)
let keepFiles = Set.ofList ["LuaValue.fs"; "Commands.fs"]
if Directory.Exists(outDir) then
    for f in Directory.GetFiles(outDir, "*.fs") do
        if not (keepFiles.Contains(Path.GetFileName f)) then File.Delete(f)

printfn "Generating..."

File.WriteAllText(Path.Combine(outDir, "CustomCommands.fs"), CodeGen.emitCustomCommands customCmds)

let unitFileNames = ResizeArray<string>()
for (subfolder, units) in grouped do
    let modName = CodeGen.sanitizeIdent subfolder
    let fileName = sprintf "%s.fs" modName
    File.WriteAllText(Path.Combine(outDir, fileName), CodeGen.emitUnitsModule modName subfolder units)
    unitFileNames.Add(fileName)
    printfn "  %s — %d units" fileName units.Length

File.WriteAllText(Path.Combine(outDir, "AllUnits.fs"), CodeGen.emitIndex grouped)

// Update .fsproj
let fsproj =
    let sb = StringBuilder()
    sb.AppendLine("""<Project Sdk="Microsoft.NET.Sdk">""") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine("  <PropertyGroup>") |> ignore
    sb.AppendLine("    <TargetFramework>net8.0</TargetFramework>") |> ignore
    sb.AppendLine("    <RootNamespace>BarData</RootNamespace>") |> ignore
    sb.AppendLine("    <GenerateDocumentationFile>true</GenerateDocumentationFile>") |> ignore
    sb.AppendLine("    <OtherFlags>--strict-indentation-</OtherFlags>") |> ignore
    sb.AppendLine("  </PropertyGroup>") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine("  <ItemGroup>") |> ignore
    sb.AppendLine("    <Compile Include=\"src/LuaValue.fs\" />") |> ignore
    sb.AppendLine("    <Compile Include=\"src/Commands.fs\" />") |> ignore
    sb.AppendLine("    <Compile Include=\"src/CustomCommands.fs\" />") |> ignore
    for fn in unitFileNames |> Seq.sort do
        sb.AppendLine(sprintf "    <Compile Include=\"src/%s\" />" fn) |> ignore
    sb.AppendLine("    <Compile Include=\"src/AllUnits.fs\" />") |> ignore
    sb.AppendLine("  </ItemGroup>") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine("</Project>") |> ignore
    sb.ToString()
File.WriteAllText(projFile, fsproj)

printfn ""
printfn "=== Done ==="
printfn "  data/bar/BarData.fsproj — %d unit modules + Commands + CustomCommands + AllUnits" unitFileNames.Count
printfn "  %d total unit definitions, %d custom commands" totalUnits customCmds.Length
printfn ""
printfn "Build: dotnet build data/bar/BarData.fsproj"
