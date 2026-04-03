#!/usr/bin/env dotnet fsi
/// Unified BAR data generator — produces both composable UnitDef instances
/// and flat per-unit types in one pass.
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
// 3. Code generation
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

    let toPascalCase (s: string) =
        let sanitized = sanitizeIdent s
        if sanitized.Length = 0 then sanitized
        else (string (Char.ToUpperInvariant(sanitized.[0]))) + sanitized.[1..]

    // -- Lookup helpers for LVal tables --

    let tblEntries (v: LVal) =
        match v with LTbl entries -> entries | _ -> []

    let strEntries (v: LVal) =
        tblEntries v |> List.choose (fun (k, v) -> match k with KStr s -> Some(s, v) | _ -> None)

    let intEntries (v: LVal) =
        tblEntries v
        |> List.choose (fun (k, v) -> match k with KInt i -> Some(i, v) | _ -> None)
        |> List.sortBy fst

    let tryGet (key: string) (v: LVal) =
        strEntries v |> List.tryFind (fun (k, _) -> k = key) |> Option.map snd

    let getStr key v = match tryGet key v with Some(LStr s) -> Some s | _ -> None
    let getNum key v = match tryGet key v with Some(LNum n) -> Some n | _ -> None
    let getBool key v = match tryGet key v with Some(LBool b) -> Some b | _ -> None

    // -- Emit helpers --

    let emitFloat (n: float) =
        if n = Math.Floor(n) && not (Double.IsInfinity n) && Math.Abs(n) < 1e15 then
            sprintf "%s.0" (int64 n |> string)
        else
            n.ToString("G", Globalization.CultureInfo.InvariantCulture)

    let emitValueOrExprFloat (v: LVal) =
        match v with
        | LNum n -> sprintf "ValueOrExpr.Concrete %s" (emitFloat n)
        | LExpr s -> sprintf "ValueOrExpr.Expr \"%s\"" (escapeString s)
        | LStr s ->
            match Double.TryParse(s, Globalization.NumberStyles.Float, Globalization.CultureInfo.InvariantCulture) with
            | true, n -> sprintf "ValueOrExpr.Concrete %s" (emitFloat n)
            | _ -> sprintf "ValueOrExpr.Expr \"%s\"" (escapeString s)
        | _ -> "ValueOrExpr.Concrete 0.0"

    let emitOptionStr = function Some s -> sprintf "Some \"%s\"" (escapeString s) | None -> "None"
    let emitOptionFloat = function Some n -> sprintf "Some %s" (emitFloat n) | None -> "None"
    let emitOptionBool = function Some true -> "Some true" | Some false -> "Some false" | None -> "None"

    let emitStringList (items: string list) =
        if items.IsEmpty then "[]"
        else
            let inner = items |> List.map (fun s -> sprintf "\"%s\"" (escapeString s)) |> String.concat "; "
            sprintf "[%s]" inner

    let emitStringMap (pad: string) (items: (string * string) list) =
        if items.IsEmpty then "Map.empty"
        else
            let lines = items |> List.map (fun (k, v) -> sprintf "%s    \"%s\", \"%s\"" pad (escapeString k) (escapeString v))
            sprintf "Map.ofList [\n%s\n%s]" (String.concat "\n" lines) pad

    let emitFloatMap (pad: string) (items: (string * float) list) =
        if items.IsEmpty then "Map.empty"
        else
            let lines = items |> List.map (fun (k, v) -> sprintf "%s    \"%s\", %s" pad (escapeString k) (emitFloat v))
            sprintf "Map.ofList [\n%s\n%s]" (String.concat "\n" lines) pad

    // -- Sub-record emitters (shared by both representations) --

    let emitSoundDef (pad: string) (tbl: LVal) : string =
        let getOptStr key = getStr key tbl
        let getStrList key =
            match tryGet key tbl with
            | Some sub ->
                intEntries sub
                |> List.choose (fun (_, v) -> match v with LStr s -> Some s | _ -> None)
            | None -> []
        [ sprintf "%s{ build = %s" pad (emitOptionStr (getOptStr "build"))
          sprintf "%s  repair = %s" pad (emitOptionStr (getOptStr "repair"))
          sprintf "%s  working = %s" pad (emitOptionStr (getOptStr "working"))
          sprintf "%s  underAttack = %s" pad (emitOptionStr (getOptStr "underattack"))
          sprintf "%s  cancelDestruct = %s" pad (emitOptionStr (getOptStr "canceldestruct"))
          sprintf "%s  capture = %s" pad (emitOptionStr (getOptStr "capture"))
          sprintf "%s  cant = %s" pad (emitStringList (getStrList "cant"))
          sprintf "%s  count = %s" pad (emitStringList (getStrList "count"))
          sprintf "%s  ok = %s" pad (emitStringList (getStrList "ok"))
          sprintf "%s  select = %s }" pad (emitStringList (getStrList "select")) ]
        |> String.concat "\n"

    let emitFeatureDef (pad: string) (tbl: LVal) : string =
        [ sprintf "%s{ blocking = %s" pad (emitOptionBool (getBool "blocking" tbl))
          sprintf "%s  category = %s" pad (emitOptionStr (getStr "category" tbl))
          sprintf "%s  collisionVolumeOffsets = %s" pad (emitOptionStr (getStr "collisionvolumeoffsets" tbl))
          sprintf "%s  collisionVolumeScales = %s" pad (emitOptionStr (getStr "collisionvolumescales" tbl))
          sprintf "%s  collisionVolumeType = %s" pad (emitOptionStr (getStr "collisionvolumetype" tbl))
          sprintf "%s  damage = %s" pad (emitOptionFloat (getNum "damage" tbl))
          sprintf "%s  featureDead = %s" pad (emitOptionStr (getStr "featuredead" tbl))
          sprintf "%s  footprintX = %s" pad (emitOptionFloat (getNum "footprintx" tbl))
          sprintf "%s  footprintZ = %s" pad (emitOptionFloat (getNum "footprintz" tbl))
          sprintf "%s  height = %s" pad (emitOptionFloat (getNum "height" tbl))
          sprintf "%s  metal = %s" pad (emitOptionFloat (getNum "metal" tbl))
          sprintf "%s  object_ = %s" pad (emitOptionStr (getStr "object" tbl))
          sprintf "%s  reclaimable = %s" pad (emitOptionBool (getBool "reclaimable" tbl))
          sprintf "%s  resurrectable = %s }" pad (emitOptionFloat (getNum "resurrectable" tbl)) ]
        |> String.concat "\n"

    let emitWeaponDef (pad: string) (weaponName: string) (tbl: LVal) (mountOverrides: (string * LVal) list) : string =
        let coreFields = Set.ofList [
            "name"; "weapontype"; "range"; "reloadtime"; "weaponvelocity"
            "areaofeffect"; "accuracy"; "turret"; "tolerance"; "edgeeffectiveness"
            "impulsefactor"; "noselfdamage"; "soundstart"; "soundhit"
            "explosiongenerator"; "rgbcolor"; "onlytargetcategory"; "badtargetcategory"
            "damage"; "customparams" ]

        let damageEntries =
            match tryGet "damage" tbl with
            | Some dmgTbl ->
                strEntries dmgTbl
                |> List.choose (fun (k, v) -> match v with LNum n -> Some(k, n) | _ -> None)
            | None -> []

        let cpEntries =
            match tryGet "customparams" tbl with
            | Some cpTbl ->
                strEntries cpTbl
                |> List.choose (fun (k, v) -> match v with LStr s -> Some(k, s) | _ -> None)
            | None -> []

        let extras =
            strEntries tbl
            |> List.filter (fun (k, _) -> not (coreFields.Contains k))
            |> List.choose (fun (k, v) ->
                match v with
                | LStr s -> Some(k, s)
                | LNum n -> Some(k, emitFloat n)
                | LBool b -> Some(k, if b then "true" else "false")
                | LExpr s -> Some(k, s)
                | _ -> None)
            |> List.append (
                mountOverrides
                |> List.filter (fun (k, _) -> k <> "def")
                |> List.choose (fun (k, v) ->
                    match v with
                    | LStr s -> Some("mount_" + k, s)
                    | LNum n -> Some("mount_" + k, emitFloat n)
                    | LBool b -> Some("mount_" + k, if b then "true" else "false")
                    | _ -> None))

        let emitVoEOption key =
            match tryGet key tbl with
            | Some v -> sprintf "Some (%s)" (emitValueOrExprFloat v)
            | None -> "None"

        [ sprintf "%s{ name = \"%s\"" pad (escapeString weaponName)
          sprintf "%s  displayName = \"%s\"" pad (escapeString (getStr "name" tbl |> Option.defaultValue weaponName))
          sprintf "%s  weaponType = %s" pad (emitOptionStr (getStr "weapontype" tbl))
          sprintf "%s  damage = %s" pad (emitFloatMap (pad + "  ") damageEntries)
          sprintf "%s  range = %s" pad (emitVoEOption "range")
          sprintf "%s  reloadTime = %s" pad (emitVoEOption "reloadtime")
          sprintf "%s  weaponVelocity = %s" pad (emitOptionFloat (getNum "weaponvelocity" tbl))
          sprintf "%s  areaOfEffect = %s" pad (emitOptionFloat (getNum "areaofeffect" tbl))
          sprintf "%s  accuracy = %s" pad (emitOptionFloat (getNum "accuracy" tbl))
          sprintf "%s  turret = %s" pad (emitOptionBool (getBool "turret" tbl))
          sprintf "%s  tolerance = %s" pad (emitOptionFloat (getNum "tolerance" tbl))
          sprintf "%s  edgeEffectiveness = %s" pad (emitOptionFloat (getNum "edgeeffectiveness" tbl))
          sprintf "%s  impulseFactor = %s" pad (emitOptionFloat (getNum "impulsefactor" tbl))
          sprintf "%s  noSelfDamage = %s" pad (emitOptionBool (getBool "noselfdamage" tbl))
          sprintf "%s  soundStart = %s" pad (emitOptionStr (getStr "soundstart" tbl))
          sprintf "%s  soundHit = %s" pad (emitOptionStr (getStr "soundhit" tbl))
          sprintf "%s  explosiongenerator = %s" pad (emitOptionStr (getStr "explosiongenerator" tbl))
          sprintf "%s  rgbColor = %s" pad (emitOptionStr (getStr "rgbcolor" tbl))
          sprintf "%s  customParams = %s" pad (emitStringMap (pad + "  ") cpEntries)
          sprintf "%s  extras = %s }" pad (emitStringMap (pad + "  ") extras) ]
        |> String.concat "\n"

    // -- Known fields to exclude from extras --
    let knownUnitFields = Set.ofList [
        "name"; "metalcost"; "energycost"; "buildtime"; "health"; "sightdistance"
        "footprintx"; "footprintz"; "objectname"; "buildpic"; "script"; "corpse"
        "explodeas"; "selfdestructas"; "collisionvolumeoffsets"; "collisionvolumescales"
        "collisionvolumetype"; "seismicsignature"; "category"
        // Movement
        "speed"; "maxacc"; "maxdec"; "turnrate"; "movementclass"; "maxslope"
        "maxwaterdepth"; "canfly"; "canmove"; "floater"; "turninplace"
        "turninplaceanglelimit"; "turninplacespeedlimit"; "cruisealtitude"
        "minwaterdepth"; "waterline"
        // Builder
        "builder"; "workertime"; "builddistance"; "buildoptions"; "terraformspeed"
        // Economy
        "energymake"; "metalmake"; "energystorage"; "metalstorage"; "extractsmetal"
        // Building
        "yardmap"; "activatewhenbuilt"; "canrepeat"
        // Sub-tables
        "weapondefs"; "weapons"; "featuredefs"; "sounds"; "customparams"; "sfxtypes" ]

    // -----------------------------------------------------------------------
    // Capability detection helpers
    // -----------------------------------------------------------------------

    let hasMovement (unit: LVal) =
        let canMove = getBool "canmove" unit |> Option.defaultValue false
        let canFly = getBool "canfly" unit |> Option.defaultValue false
        let speed = getNum "speed" unit
        let hasYardMap = getStr "yardmap" unit |> Option.isSome
        let maxAcc = getNum "maxacc" unit |> Option.defaultValue 0.0
        canMove || canFly || (speed.IsSome && not (hasYardMap && maxAcc = 0.0))

    let hasBuilder (unit: LVal) =
        let isBuilder = getBool "builder" unit |> Option.defaultValue false
        let hasBuildOpts = tryGet "buildoptions" unit |> Option.isSome
        isBuilder && hasBuildOpts

    let hasEconomy (unit: LVal) =
        let em = tryGet "energymake" unit
        let mm = tryGet "metalmake" unit
        let es = getNum "energystorage" unit
        let ms = getNum "metalstorage" unit
        let ext = getNum "extractsmetal" unit
        em.IsSome || mm.IsSome || es.IsSome || ms.IsSome || ext.IsSome

    let hasBuilding (unit: LVal) =
        (getStr "yardmap" unit).IsSome

    let hasWeapons (unit: LVal) =
        match tryGet "weapondefs" unit with
        | Some _ -> true
        | None -> false

    let hasFeatureDefs (unit: LVal) =
        match tryGet "featuredefs" unit with
        | Some fdTbl -> not (strEntries fdTbl |> List.isEmpty)
        | None -> false

    let hasSounds (unit: LVal) =
        (tryGet "sounds" unit).IsSome

    let hasCustomParams (unit: LVal) =
        match tryGet "customparams" unit with
        | Some cpTbl -> not (strEntries cpTbl |> List.isEmpty)
        | None -> false

    let hasExtras (unit: LVal) =
        strEntries unit
        |> List.exists (fun (k, v) ->
            not (knownUnitFields.Contains k) &&
            match v with LTbl _ -> false | LNil -> false | _ -> true)

    let getWeaponsList (unit: LVal) =
        match tryGet "weapondefs" unit, tryGet "weapons" unit with
        | Some wdTbl, Some waTbl ->
            let wdefs = strEntries wdTbl |> Map.ofList
            let mountSlots =
                intEntries waTbl
                |> List.sortBy fst
                |> List.choose (fun (_, slotTbl) ->
                    match getStr "def" slotTbl with
                    | Some defName ->
                        let overrides = strEntries slotTbl
                        Some(defName, overrides)
                    | None -> None)
            let weapDefs =
                mountSlots |> List.choose (fun (defName, overrides) ->
                    let lowerDef = defName.ToLowerInvariant()
                    wdefs |> Map.tryFind lowerDef
                    |> Option.orElseWith (fun () ->
                        wdefs |> Map.tryPick (fun k v -> if k.ToLowerInvariant() = lowerDef then Some v else None))
                    |> Option.map (fun wdef -> (lowerDef, wdef, overrides)))
            if weapDefs.IsEmpty then None
            else Some weapDefs
        | Some wdTbl, None ->
            let wdefs = strEntries wdTbl
            if wdefs.IsEmpty then None
            else Some (wdefs |> List.map (fun (k, v) -> (k, v, [])))
        | _ -> None

    // ===================================================================
    // FLAT: Per-unit type definitions and instances
    // ===================================================================

    /// Build field definitions for a specific unit based on what fields it has.
    let buildFieldDefs (unit: LVal) : (string * string) list =
        let fields = ResizeArray<string * string>()

        // Universal fields
        fields.Add("name", "string")
        fields.Add("subfolder", "string")
        fields.Add("metalCost", "ValueOrExpr<float>")
        fields.Add("energyCost", "ValueOrExpr<float>")
        fields.Add("buildTime", "ValueOrExpr<float>")
        fields.Add("health", "ValueOrExpr<float>")
        fields.Add("sightDistance", "ValueOrExpr<float>")
        fields.Add("footprintX", "float")
        fields.Add("footprintZ", "float")

        // Universal optional fields (11 new fields for lossless round-trip)
        fields.Add("objectName", "string option")
        fields.Add("buildPic", "string option")
        fields.Add("script", "string option")
        fields.Add("corpse", "string option")
        fields.Add("explodeAs", "string option")
        fields.Add("selfDestructAs", "string option")
        fields.Add("collisionVolumeOffsets", "string option")
        fields.Add("collisionVolumeScales", "string option")
        fields.Add("collisionVolumeType", "string option")
        fields.Add("seismicSignature", "float option")
        fields.Add("category", "string option")

        // Movement fields (flattened)
        if hasMovement unit then
            fields.Add("speed", "ValueOrExpr<float>")
            fields.Add("maxAcc", "float")
            fields.Add("maxDec", "float")
            fields.Add("turnRate", "float")
            if (getStr "movementclass" unit).IsSome then fields.Add("movementClass", "string")
            if (getNum "maxslope" unit).IsSome then fields.Add("maxSlope", "float")
            if (getNum "maxwaterdepth" unit).IsSome then fields.Add("maxWaterDepth", "float")
            if (getBool "canfly" unit) = Some true then fields.Add("canFly", "bool")
            if (getBool "canmove" unit).IsSome then fields.Add("canMove", "bool")
            if (getBool "floater" unit) = Some true then fields.Add("floater", "bool")
            if (getBool "turninplace" unit).IsSome then fields.Add("turnInPlace", "bool")
            if (getNum "turninplaceanglelimit" unit).IsSome then fields.Add("turnInPlaceAngleLimit", "float")
            if (getNum "turninplacespeedlimit" unit).IsSome then fields.Add("turnInPlaceSpeedLimit", "float")
            if (getNum "cruisealtitude" unit).IsSome then fields.Add("cruiseAltitude", "float")
            if (getNum "minwaterdepth" unit).IsSome then fields.Add("minWaterDepth", "float")
            if (getNum "waterline" unit).IsSome then fields.Add("waterline", "float")

        // Builder fields (flattened)
        if hasBuilder unit then
            fields.Add("workerTime", "ValueOrExpr<float>")
            if (getNum "builddistance" unit).IsSome then fields.Add("buildDistance", "float")
            fields.Add("buildOptions", "string list")
            if (getNum "terraformspeed" unit).IsSome then fields.Add("terraformSpeed", "float")

        // Economy fields (flattened)
        if hasEconomy unit then
            if (tryGet "energymake" unit).IsSome then fields.Add("energyMake", "ValueOrExpr<float>")
            if (tryGet "metalmake" unit).IsSome then fields.Add("metalMake", "ValueOrExpr<float>")
            if (getNum "energystorage" unit).IsSome then fields.Add("energyStorage", "float")
            if (getNum "metalstorage" unit).IsSome then fields.Add("metalStorage", "float")
            if (getNum "extractsmetal" unit).IsSome then fields.Add("extractsMetal", "float")

        // Building fields (flattened)
        if hasBuilding unit then
            fields.Add("yardMap", "string")
            if (getBool "activatewhenbuilt" unit).IsSome then fields.Add("activateWhenBuilt", "bool")
            if (getBool "canrepeat" unit).IsSome then fields.Add("canRepeat", "bool")

        // Weapons
        if hasWeapons unit then
            fields.Add("weapons", "WeaponDef list")

        // Feature defs
        if hasFeatureDefs unit then
            fields.Add("featureDefs", "Map<string, FeatureDef>")

        // Sounds
        if hasSounds unit then
            fields.Add("sounds", "SoundDef")

        // Custom params
        if hasCustomParams unit then
            fields.Add("customParams", "Map<string, string>")

        // Extras
        if hasExtras unit then
            fields.Add("extras", "Map<string, string>")

        fields |> Seq.toList

    /// Emit a record type definition for a unit.
    let emitTypeDefinition (pad: string) (typeName: string) (fields: (string * string) list) : string =
        let sb = StringBuilder()
        sb.AppendLine(sprintf "%stype %s =" pad typeName) |> ignore
        sb.Append(sprintf "%s    { " pad) |> ignore
        for i in 0 .. fields.Length - 1 do
            let (name, typ) = fields.[i]
            if i = 0 then
                sb.AppendLine(sprintf "%s: %s" name typ) |> ignore
            else
                sb.AppendLine(sprintf "%s      %s: %s" pad name typ) |> ignore
        sb.Length <- sb.Length - 1
        sb.Append(" }") |> ignore
        sb.ToString()

    /// Emit a singleton instance value for a unit.
    let emitInstance (pad: string) (unitName: string) (subfolder: string) (unit: LVal) (fields: (string * string) list) : string =
        let p = pad + "    "
        let sb = StringBuilder()

        let emitVoE key =
            match tryGet key unit with
            | Some v -> emitValueOrExprFloat v
            | None -> "ValueOrExpr.Concrete 0.0"

        sb.Append(sprintf "%s{ " pad) |> ignore

        let mutable first = true
        for (name, _typ) in fields do
            if not first then
                sb.Append(sprintf "%s  " pad) |> ignore
            first <- false

            match name with
            | "name" -> sb.AppendLine(sprintf "name = \"%s\"" (escapeString unitName)) |> ignore
            | "subfolder" -> sb.AppendLine(sprintf "subfolder = \"%s\"" (escapeString subfolder)) |> ignore
            | "metalCost" -> sb.AppendLine(sprintf "metalCost = %s" (emitVoE "metalcost")) |> ignore
            | "energyCost" -> sb.AppendLine(sprintf "energyCost = %s" (emitVoE "energycost")) |> ignore
            | "buildTime" -> sb.AppendLine(sprintf "buildTime = %s" (emitVoE "buildtime")) |> ignore
            | "health" -> sb.AppendLine(sprintf "health = %s" (emitVoE "health")) |> ignore
            | "sightDistance" -> sb.AppendLine(sprintf "sightDistance = %s" (emitVoE "sightdistance")) |> ignore
            | "footprintX" -> sb.AppendLine(sprintf "footprintX = %s" (emitFloat (getNum "footprintx" unit |> Option.defaultValue 1.0))) |> ignore
            | "footprintZ" -> sb.AppendLine(sprintf "footprintZ = %s" (emitFloat (getNum "footprintz" unit |> Option.defaultValue 1.0))) |> ignore
            // Universal optional fields
            | "objectName" -> sb.AppendLine(sprintf "objectName = %s" (emitOptionStr (getStr "objectname" unit))) |> ignore
            | "buildPic" -> sb.AppendLine(sprintf "buildPic = %s" (emitOptionStr (getStr "buildpic" unit))) |> ignore
            | "script" -> sb.AppendLine(sprintf "script = %s" (emitOptionStr (getStr "script" unit))) |> ignore
            | "corpse" -> sb.AppendLine(sprintf "corpse = %s" (emitOptionStr (getStr "corpse" unit))) |> ignore
            | "explodeAs" -> sb.AppendLine(sprintf "explodeAs = %s" (emitOptionStr (getStr "explodeas" unit))) |> ignore
            | "selfDestructAs" -> sb.AppendLine(sprintf "selfDestructAs = %s" (emitOptionStr (getStr "selfdestructas" unit))) |> ignore
            | "collisionVolumeOffsets" -> sb.AppendLine(sprintf "collisionVolumeOffsets = %s" (emitOptionStr (getStr "collisionvolumeoffsets" unit))) |> ignore
            | "collisionVolumeScales" -> sb.AppendLine(sprintf "collisionVolumeScales = %s" (emitOptionStr (getStr "collisionvolumescales" unit))) |> ignore
            | "collisionVolumeType" -> sb.AppendLine(sprintf "collisionVolumeType = %s" (emitOptionStr (getStr "collisionvolumetype" unit))) |> ignore
            | "seismicSignature" -> sb.AppendLine(sprintf "seismicSignature = %s" (emitOptionFloat (getNum "seismicsignature" unit))) |> ignore
            | "category" -> sb.AppendLine(sprintf "category = %s" (emitOptionStr (getStr "category" unit))) |> ignore
            // Movement (flattened)
            | "speed" -> sb.AppendLine(sprintf "speed = %s" (match tryGet "speed" unit with Some v -> emitValueOrExprFloat v | None -> "ValueOrExpr.Concrete 0.0")) |> ignore
            | "maxAcc" -> sb.AppendLine(sprintf "maxAcc = %s" (emitFloat (getNum "maxacc" unit |> Option.defaultValue 0.0))) |> ignore
            | "maxDec" -> sb.AppendLine(sprintf "maxDec = %s" (emitFloat (getNum "maxdec" unit |> Option.defaultValue 0.0))) |> ignore
            | "turnRate" -> sb.AppendLine(sprintf "turnRate = %s" (emitFloat (getNum "turnrate" unit |> Option.defaultValue 0.0))) |> ignore
            | "movementClass" -> sb.AppendLine(sprintf "movementClass = \"%s\"" (escapeString (getStr "movementclass" unit |> Option.defaultValue ""))) |> ignore
            | "maxSlope" -> sb.AppendLine(sprintf "maxSlope = %s" (emitFloat (getNum "maxslope" unit |> Option.get))) |> ignore
            | "maxWaterDepth" -> sb.AppendLine(sprintf "maxWaterDepth = %s" (emitFloat (getNum "maxwaterdepth" unit |> Option.get))) |> ignore
            | "canFly" -> sb.AppendLine(sprintf "canFly = %b" (getBool "canfly" unit |> Option.defaultValue false)) |> ignore
            | "canMove" -> sb.AppendLine(sprintf "canMove = %b" (getBool "canmove" unit |> Option.defaultValue false)) |> ignore
            | "floater" -> sb.AppendLine(sprintf "floater = %b" (getBool "floater" unit |> Option.defaultValue false)) |> ignore
            | "turnInPlace" -> sb.AppendLine(sprintf "turnInPlace = %b" (getBool "turninplace" unit |> Option.get)) |> ignore
            | "turnInPlaceAngleLimit" -> sb.AppendLine(sprintf "turnInPlaceAngleLimit = %s" (emitFloat (getNum "turninplaceanglelimit" unit |> Option.get))) |> ignore
            | "turnInPlaceSpeedLimit" -> sb.AppendLine(sprintf "turnInPlaceSpeedLimit = %s" (emitFloat (getNum "turninplacespeedlimit" unit |> Option.get))) |> ignore
            | "cruiseAltitude" -> sb.AppendLine(sprintf "cruiseAltitude = %s" (emitFloat (getNum "cruisealtitude" unit |> Option.get))) |> ignore
            | "minWaterDepth" -> sb.AppendLine(sprintf "minWaterDepth = %s" (emitFloat (getNum "minwaterdepth" unit |> Option.get))) |> ignore
            | "waterline" -> sb.AppendLine(sprintf "waterline = %s" (emitFloat (getNum "waterline" unit |> Option.get))) |> ignore
            // Builder (flattened)
            | "workerTime" -> sb.AppendLine(sprintf "workerTime = %s" (match tryGet "workertime" unit with Some v -> emitValueOrExprFloat v | None -> "ValueOrExpr.Concrete 0.0")) |> ignore
            | "buildDistance" -> sb.AppendLine(sprintf "buildDistance = %s" (emitFloat (getNum "builddistance" unit |> Option.get))) |> ignore
            | "buildOptions" ->
                let buildOpts =
                    match tryGet "buildoptions" unit with
                    | Some boTbl ->
                        intEntries boTbl
                        |> List.choose (fun (_, v) -> match v with LStr s -> Some s | _ -> None)
                    | None -> []
                sb.AppendLine(sprintf "buildOptions = %s" (emitStringList buildOpts)) |> ignore
            | "terraformSpeed" -> sb.AppendLine(sprintf "terraformSpeed = %s" (emitFloat (getNum "terraformspeed" unit |> Option.get))) |> ignore
            // Economy (flattened)
            | "energyMake" -> sb.AppendLine(sprintf "energyMake = %s" (emitValueOrExprFloat (tryGet "energymake" unit |> Option.get))) |> ignore
            | "metalMake" -> sb.AppendLine(sprintf "metalMake = %s" (emitValueOrExprFloat (tryGet "metalmake" unit |> Option.get))) |> ignore
            | "energyStorage" -> sb.AppendLine(sprintf "energyStorage = %s" (emitFloat (getNum "energystorage" unit |> Option.get))) |> ignore
            | "metalStorage" -> sb.AppendLine(sprintf "metalStorage = %s" (emitFloat (getNum "metalstorage" unit |> Option.get))) |> ignore
            | "extractsMetal" -> sb.AppendLine(sprintf "extractsMetal = %s" (emitFloat (getNum "extractsmetal" unit |> Option.get))) |> ignore
            // Building (flattened)
            | "yardMap" -> sb.AppendLine(sprintf "yardMap = \"%s\"" (escapeString (getStr "yardmap" unit |> Option.defaultValue ""))) |> ignore
            | "activateWhenBuilt" -> sb.AppendLine(sprintf "activateWhenBuilt = %b" (getBool "activatewhenbuilt" unit |> Option.get)) |> ignore
            | "canRepeat" -> sb.AppendLine(sprintf "canRepeat = %b" (getBool "canrepeat" unit |> Option.get)) |> ignore
            // Weapons
            | "weapons" ->
                match getWeaponsList unit with
                | None -> sb.AppendLine("weapons = []") |> ignore
                | Some wl ->
                    let lines = wl |> List.map (fun (wname, wdef, overrides) ->
                        emitWeaponDef (p + "    ") wname wdef overrides)
                    sb.AppendLine(sprintf "weapons = [\n%s\n%s]" (String.concat "\n" lines) p) |> ignore
            // Feature defs
            | "featureDefs" ->
                match tryGet "featuredefs" unit with
                | None -> sb.AppendLine("featureDefs = Map.empty") |> ignore
                | Some fdTbl ->
                    let entries = strEntries fdTbl
                    if entries.IsEmpty then sb.AppendLine("featureDefs = Map.empty") |> ignore
                    else
                        let lines =
                            entries |> List.map (fun (name, ftbl) ->
                                sprintf "%s    \"%s\",\n%s" p (escapeString name) (emitFeatureDef (p + "    ") ftbl))
                        sb.AppendLine(sprintf "featureDefs = Map.ofList [\n%s\n%s]" (String.concat "\n" lines) p) |> ignore
            // Sounds
            | "sounds" ->
                match tryGet "sounds" unit with
                | None -> sb.AppendLine("sounds = { build = None; repair = None; working = None; underAttack = None; cancelDestruct = None; capture = None; cant = []; count = []; ok = []; select = [] }") |> ignore
                | Some stbl -> sb.AppendLine(sprintf "sounds =\n%s" (emitSoundDef (p + "  ") stbl)) |> ignore
            // Custom params
            | "customParams" ->
                let cpEntries =
                    match tryGet "customparams" unit with
                    | Some cpTbl ->
                        strEntries cpTbl
                        |> List.choose (fun (k, v) -> match v with LStr s -> Some(k, s) | LBool b -> Some(k, if b then "true" else "false") | LNum n -> Some(k, emitFloat n) | _ -> None)
                    | None -> []
                sb.AppendLine(sprintf "customParams = %s" (emitStringMap p cpEntries)) |> ignore
            // Extras
            | "extras" ->
                let extraEntries =
                    strEntries unit
                    |> List.filter (fun (k, _) -> not (knownUnitFields.Contains k))
                    |> List.choose (fun (k, v) ->
                        match v with
                        | LStr s -> Some(k, s)
                        | LNum n -> Some(k, emitFloat n)
                        | LBool b -> Some(k, if b then "true" else "false")
                        | LExpr s -> Some(k, s)
                        | _ -> None)
                sb.AppendLine(sprintf "extras = %s" (emitStringMap p extraEntries)) |> ignore
            | other -> failwithf "Unknown field: %s" other

        sb.Length <- sb.Length - 1
        sb.Append(" }") |> ignore
        sb.ToString()

    // ===================================================================
    // COMPOSABLE: UnitDef emitters
    // ===================================================================

    let emitMovementDef (pad: string) (unit: LVal) : string option =
        if not (hasMovement unit) then None
        else
            let speedVal = match tryGet "speed" unit with Some v -> emitValueOrExprFloat v | None -> "ValueOrExpr.Concrete 0.0"
            [ sprintf "%s{ speed = %s" pad speedVal
              sprintf "%s  maxAcc = %s" pad (emitFloat (getNum "maxacc" unit |> Option.defaultValue 0.0))
              sprintf "%s  maxDec = %s" pad (emitFloat (getNum "maxdec" unit |> Option.defaultValue 0.0))
              sprintf "%s  turnRate = %s" pad (emitFloat (getNum "turnrate" unit |> Option.defaultValue 0.0))
              sprintf "%s  movementClass = %s" pad (emitOptionStr (getStr "movementclass" unit))
              sprintf "%s  maxSlope = %s" pad (emitOptionFloat (getNum "maxslope" unit))
              sprintf "%s  maxWaterDepth = %s" pad (emitOptionFloat (getNum "maxwaterdepth" unit))
              sprintf "%s  canFly = %b" pad (getBool "canfly" unit |> Option.defaultValue false)
              sprintf "%s  canMove = %b" pad (getBool "canmove" unit |> Option.defaultValue false)
              sprintf "%s  floater = %b" pad (getBool "floater" unit |> Option.defaultValue false)
              sprintf "%s  turnInPlace = %s" pad (emitOptionBool (getBool "turninplace" unit))
              sprintf "%s  turnInPlaceAngleLimit = %s" pad (emitOptionFloat (getNum "turninplaceanglelimit" unit))
              sprintf "%s  turnInPlaceSpeedLimit = %s" pad (emitOptionFloat (getNum "turninplacespeedlimit" unit))
              sprintf "%s  cruiseAltitude = %s" pad (emitOptionFloat (getNum "cruisealtitude" unit))
              sprintf "%s  minWaterDepth = %s" pad (emitOptionFloat (getNum "minwaterdepth" unit))
              sprintf "%s  waterline = %s }" pad (emitOptionFloat (getNum "waterline" unit)) ]
            |> String.concat "\n"
            |> Some

    let emitBuilderDef (pad: string) (unit: LVal) : string option =
        if not (hasBuilder unit) then None
        else
            let buildOpts =
                match tryGet "buildoptions" unit with
                | Some boTbl ->
                    intEntries boTbl
                    |> List.choose (fun (_, v) -> match v with LStr s -> Some s | _ -> None)
                | None -> []
            let wtVal = match tryGet "workertime" unit with Some v -> emitValueOrExprFloat v | None -> "ValueOrExpr.Concrete 0.0"
            [ sprintf "%s{ workerTime = %s" pad wtVal
              sprintf "%s  buildDistance = %s" pad (emitOptionFloat (getNum "builddistance" unit))
              sprintf "%s  buildOptions = %s" pad (emitStringList buildOpts)
              sprintf "%s  terraformSpeed = %s }" pad (emitOptionFloat (getNum "terraformspeed" unit)) ]
            |> String.concat "\n"
            |> Some

    let emitEconomyDef (pad: string) (unit: LVal) : string option =
        if not (hasEconomy unit) then None
        else
            let emitVoEOptField key =
                match tryGet key unit with
                | Some v -> sprintf "Some (%s)" (emitValueOrExprFloat v)
                | None -> "None"
            [ sprintf "%s{ energyMake = %s" pad (emitVoEOptField "energymake")
              sprintf "%s  metalMake = %s" pad (emitVoEOptField "metalmake")
              sprintf "%s  energyStorage = %s" pad (emitOptionFloat (getNum "energystorage" unit))
              sprintf "%s  metalStorage = %s" pad (emitOptionFloat (getNum "metalstorage" unit))
              sprintf "%s  extractsMetal = %s }" pad (emitOptionFloat (getNum "extractsmetal" unit)) ]
            |> String.concat "\n"
            |> Some

    let emitBuildingDef (pad: string) (unit: LVal) : string option =
        if not (hasBuilding unit) then None
        else
            [ sprintf "%s{ yardMap = %s" pad (emitOptionStr (getStr "yardmap" unit))
              sprintf "%s  activateWhenBuilt = %s" pad (emitOptionBool (getBool "activatewhenbuilt" unit))
              sprintf "%s  canRepeat = %s }" pad (emitOptionBool (getBool "canrepeat" unit)) ]
            |> String.concat "\n"
            |> Some

    let emitFeatureDefs (pad: string) (unit: LVal) : string option =
        match tryGet "featuredefs" unit with
        | None -> None
        | Some fdTbl ->
            let entries = strEntries fdTbl
            if entries.IsEmpty then None
            else
                let lines =
                    entries |> List.map (fun (name, ftbl) ->
                        sprintf "%s    \"%s\",\n%s" pad (escapeString name) (emitFeatureDef (pad + "    ") ftbl))
                sprintf "Map.ofList [\n%s\n%s]" (String.concat "\n" lines) pad |> Some

    /// Emit a composable UnitDef instance for a unit.
    let emitUnitDef (pad: string) (unitName: string) (subfolder: string) (unit: LVal) : string =
        let p = pad + "  "

        let emitWeapons (pad2: string) =
            match getWeaponsList unit with
            | None -> "None"
            | Some wl ->
                let lines = wl |> List.map (fun (wname, wdef, overrides) ->
                    emitWeaponDef (pad2 + "    ") wname wdef overrides)
                sprintf "Some [\n%s\n%s]" (String.concat "\n" lines) pad2

        let emitSounds (pad2: string) =
            match tryGet "sounds" unit with
            | None -> "None"
            | Some stbl -> sprintf "Some (\n%s)" (emitSoundDef (pad2 + "  ") stbl)

        let emitFdefs (pad2: string) =
            match emitFeatureDefs pad2 unit with
            | None -> "None"
            | Some s -> sprintf "Some (%s)" s

        let cpEntries =
            match tryGet "customparams" unit with
            | Some cpTbl ->
                strEntries cpTbl
                |> List.choose (fun (k, v) -> match v with LStr s -> Some(k, s) | LBool b -> Some(k, if b then "true" else "false") | LNum n -> Some(k, emitFloat n) | _ -> None)
            | None -> []

        let extraEntries =
            strEntries unit
            |> List.filter (fun (k, _) -> not (knownUnitFields.Contains k))
            |> List.choose (fun (k, v) ->
                match v with
                | LStr s -> Some(k, s)
                | LNum n -> Some(k, emitFloat n)
                | LBool b -> Some(k, if b then "true" else "false")
                | LExpr s -> Some(k, s)
                | _ -> None)

        let emitVoE key =
            match tryGet key unit with
            | Some v -> emitValueOrExprFloat v
            | None -> "ValueOrExpr.Concrete 0.0"

        let movOpt = emitMovementDef (p + "  ") unit
        let bldOpt = emitBuilderDef (p + "  ") unit
        let ecoOpt = emitEconomyDef (p + "  ") unit
        let bldgOpt = emitBuildingDef (p + "  ") unit

        [ sprintf "%s{ name = \"%s\"" pad (escapeString unitName)
          sprintf "%s  subfolder = \"%s\"" pad (escapeString subfolder)
          sprintf "%s  metalCost = %s" pad (emitVoE "metalcost")
          sprintf "%s  energyCost = %s" pad (emitVoE "energycost")
          sprintf "%s  buildTime = %s" pad (emitVoE "buildtime")
          sprintf "%s  health = %s" pad (emitVoE "health")
          sprintf "%s  sightDistance = %s" pad (emitVoE "sightdistance")
          sprintf "%s  footprintX = %s" pad (emitFloat (getNum "footprintx" unit |> Option.defaultValue 1.0))
          sprintf "%s  footprintZ = %s" pad (emitFloat (getNum "footprintz" unit |> Option.defaultValue 1.0))
          sprintf "%s  objectName = %s" pad (emitOptionStr (getStr "objectname" unit))
          sprintf "%s  buildPic = %s" pad (emitOptionStr (getStr "buildpic" unit))
          sprintf "%s  script = %s" pad (emitOptionStr (getStr "script" unit))
          sprintf "%s  corpse = %s" pad (emitOptionStr (getStr "corpse" unit))
          sprintf "%s  explodeAs = %s" pad (emitOptionStr (getStr "explodeas" unit))
          sprintf "%s  selfDestructAs = %s" pad (emitOptionStr (getStr "selfdestructas" unit))
          sprintf "%s  collisionVolumeOffsets = %s" pad (emitOptionStr (getStr "collisionvolumeoffsets" unit))
          sprintf "%s  collisionVolumeScales = %s" pad (emitOptionStr (getStr "collisionvolumescales" unit))
          sprintf "%s  collisionVolumeType = %s" pad (emitOptionStr (getStr "collisionvolumetype" unit))
          sprintf "%s  seismicSignature = %s" pad (emitOptionFloat (getNum "seismicsignature" unit))
          sprintf "%s  category = %s" pad (emitOptionStr (getStr "category" unit))
          sprintf "%s  movement = %s" pad (match movOpt with None -> "None" | Some s -> sprintf "Some (\n%s)" s)
          sprintf "%s  builder = %s" pad (match bldOpt with None -> "None" | Some s -> sprintf "Some (\n%s)" s)
          sprintf "%s  weapons = %s" pad (emitWeapons p)
          sprintf "%s  economy = %s" pad (match ecoOpt with None -> "None" | Some s -> sprintf "Some (\n%s)" s)
          sprintf "%s  building = %s" pad (match bldgOpt with None -> "None" | Some s -> sprintf "Some (\n%s)" s)
          sprintf "%s  featureDefs = %s" pad (emitFdefs p)
          sprintf "%s  sounds = %s" pad (emitSounds p)
          sprintf "%s  customParams = %s" pad (emitStringMap p cpEntries)
          sprintf "%s  extras = %s }" pad (emitStringMap p extraEntries) ]
        |> String.concat "\n"

    // ===================================================================
    // CONVERSION: toFlat and toUnitDef emitters
    // ===================================================================

    /// Emit a toFlat function: UnitDef -> FlatType
    let emitToFlat (pad: string) (ident: string) (typeName: string) (fields: (string * string) list) (unit: LVal) : string =
        let sb = StringBuilder()
        sb.AppendLine(sprintf "%slet %sToFlat (def: UnitDef) : %s =" pad ident typeName) |> ignore
        sb.Append(sprintf "%s    { " pad) |> ignore

        let mutable first = true
        for (name, _typ) in fields do
            if not first then
                sb.Append(sprintf "%s      " pad) |> ignore
            first <- false

            match name with
            | "name" -> sb.AppendLine("name = def.name") |> ignore
            | "subfolder" -> sb.AppendLine("subfolder = def.subfolder") |> ignore
            | "metalCost" -> sb.AppendLine("metalCost = def.metalCost") |> ignore
            | "energyCost" -> sb.AppendLine("energyCost = def.energyCost") |> ignore
            | "buildTime" -> sb.AppendLine("buildTime = def.buildTime") |> ignore
            | "health" -> sb.AppendLine("health = def.health") |> ignore
            | "sightDistance" -> sb.AppendLine("sightDistance = def.sightDistance") |> ignore
            | "footprintX" -> sb.AppendLine("footprintX = def.footprintX") |> ignore
            | "footprintZ" -> sb.AppendLine("footprintZ = def.footprintZ") |> ignore
            // Universal optional fields
            | "objectName" -> sb.AppendLine("objectName = def.objectName") |> ignore
            | "buildPic" -> sb.AppendLine("buildPic = def.buildPic") |> ignore
            | "script" -> sb.AppendLine("script = def.script") |> ignore
            | "corpse" -> sb.AppendLine("corpse = def.corpse") |> ignore
            | "explodeAs" -> sb.AppendLine("explodeAs = def.explodeAs") |> ignore
            | "selfDestructAs" -> sb.AppendLine("selfDestructAs = def.selfDestructAs") |> ignore
            | "collisionVolumeOffsets" -> sb.AppendLine("collisionVolumeOffsets = def.collisionVolumeOffsets") |> ignore
            | "collisionVolumeScales" -> sb.AppendLine("collisionVolumeScales = def.collisionVolumeScales") |> ignore
            | "collisionVolumeType" -> sb.AppendLine("collisionVolumeType = def.collisionVolumeType") |> ignore
            | "seismicSignature" -> sb.AppendLine("seismicSignature = def.seismicSignature") |> ignore
            | "category" -> sb.AppendLine("category = def.category") |> ignore
            // Movement
            | "speed" -> sb.AppendLine("speed = def.movement.Value.speed") |> ignore
            | "maxAcc" -> sb.AppendLine("maxAcc = def.movement.Value.maxAcc") |> ignore
            | "maxDec" -> sb.AppendLine("maxDec = def.movement.Value.maxDec") |> ignore
            | "turnRate" -> sb.AppendLine("turnRate = def.movement.Value.turnRate") |> ignore
            | "movementClass" -> sb.AppendLine("movementClass = def.movement.Value.movementClass.Value") |> ignore
            | "maxSlope" -> sb.AppendLine("maxSlope = def.movement.Value.maxSlope.Value") |> ignore
            | "maxWaterDepth" -> sb.AppendLine("maxWaterDepth = def.movement.Value.maxWaterDepth.Value") |> ignore
            | "canFly" -> sb.AppendLine("canFly = def.movement.Value.canFly") |> ignore
            | "canMove" -> sb.AppendLine("canMove = def.movement.Value.canMove") |> ignore
            | "floater" -> sb.AppendLine("floater = def.movement.Value.floater") |> ignore
            | "turnInPlace" -> sb.AppendLine("turnInPlace = def.movement.Value.turnInPlace.Value") |> ignore
            | "turnInPlaceAngleLimit" -> sb.AppendLine("turnInPlaceAngleLimit = def.movement.Value.turnInPlaceAngleLimit.Value") |> ignore
            | "turnInPlaceSpeedLimit" -> sb.AppendLine("turnInPlaceSpeedLimit = def.movement.Value.turnInPlaceSpeedLimit.Value") |> ignore
            | "cruiseAltitude" -> sb.AppendLine("cruiseAltitude = def.movement.Value.cruiseAltitude.Value") |> ignore
            | "minWaterDepth" -> sb.AppendLine("minWaterDepth = def.movement.Value.minWaterDepth.Value") |> ignore
            | "waterline" -> sb.AppendLine("waterline = def.movement.Value.waterline.Value") |> ignore
            // Builder
            | "workerTime" -> sb.AppendLine("workerTime = def.builder.Value.workerTime") |> ignore
            | "buildDistance" -> sb.AppendLine("buildDistance = def.builder.Value.buildDistance.Value") |> ignore
            | "buildOptions" -> sb.AppendLine("buildOptions = def.builder.Value.buildOptions") |> ignore
            | "terraformSpeed" -> sb.AppendLine("terraformSpeed = def.builder.Value.terraformSpeed.Value") |> ignore
            // Economy
            | "energyMake" -> sb.AppendLine("energyMake = def.economy.Value.energyMake.Value") |> ignore
            | "metalMake" -> sb.AppendLine("metalMake = def.economy.Value.metalMake.Value") |> ignore
            | "energyStorage" -> sb.AppendLine("energyStorage = def.economy.Value.energyStorage.Value") |> ignore
            | "metalStorage" -> sb.AppendLine("metalStorage = def.economy.Value.metalStorage.Value") |> ignore
            | "extractsMetal" -> sb.AppendLine("extractsMetal = def.economy.Value.extractsMetal.Value") |> ignore
            // Building
            | "yardMap" -> sb.AppendLine("yardMap = def.building.Value.yardMap.Value") |> ignore
            | "activateWhenBuilt" -> sb.AppendLine("activateWhenBuilt = def.building.Value.activateWhenBuilt.Value") |> ignore
            | "canRepeat" -> sb.AppendLine("canRepeat = def.building.Value.canRepeat.Value") |> ignore
            // Weapons
            | "weapons" -> sb.AppendLine("weapons = def.weapons.Value") |> ignore
            // Feature defs
            | "featureDefs" -> sb.AppendLine("featureDefs = def.featureDefs.Value") |> ignore
            // Sounds
            | "sounds" -> sb.AppendLine("sounds = def.sounds.Value") |> ignore
            // Custom params
            | "customParams" -> sb.AppendLine("customParams = def.customParams") |> ignore
            // Extras
            | "extras" -> sb.AppendLine("extras = def.extras") |> ignore
            | other -> failwithf "Unknown field in toFlat: %s" other

        sb.Length <- sb.Length - 1
        sb.Append(" }") |> ignore
        sb.ToString()

    /// Emit a toUnitDef function: FlatType -> UnitDef
    let emitToUnitDef (pad: string) (ident: string) (typeName: string) (fields: (string * string) list) (unit: LVal) : string =
        let sb = StringBuilder()
        let p = pad + "    "
        let fieldSet = fields |> List.map fst |> Set.ofList
        sb.AppendLine(sprintf "%slet %sToUnitDef (flat: %s) : UnitDef =" pad ident typeName) |> ignore
        sb.Append(sprintf "%s    { " pad) |> ignore

        // Universal fields
        sb.AppendLine("name = flat.name") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("subfolder = flat.subfolder") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("metalCost = flat.metalCost") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("energyCost = flat.energyCost") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("buildTime = flat.buildTime") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("health = flat.health") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("sightDistance = flat.sightDistance") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("footprintX = flat.footprintX") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("footprintZ = flat.footprintZ") |> ignore
        // Universal optional
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("objectName = flat.objectName") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("buildPic = flat.buildPic") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("script = flat.script") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("corpse = flat.corpse") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("explodeAs = flat.explodeAs") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("selfDestructAs = flat.selfDestructAs") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("collisionVolumeOffsets = flat.collisionVolumeOffsets") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("collisionVolumeScales = flat.collisionVolumeScales") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("collisionVolumeType = flat.collisionVolumeType") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("seismicSignature = flat.seismicSignature") |> ignore
        sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("category = flat.category") |> ignore

        // Movement
        if hasMovement unit then
            sb.Append(sprintf "%s      " pad) |> ignore
            sb.AppendLine("movement = Some {") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore; sb.AppendLine("speed = flat.speed") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore; sb.AppendLine("maxAcc = flat.maxAcc") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore; sb.AppendLine("maxDec = flat.maxDec") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore; sb.AppendLine("turnRate = flat.turnRate") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "movementClass" then "movementClass = Some flat.movementClass" else "movementClass = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "maxSlope" then "maxSlope = Some flat.maxSlope" else "maxSlope = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "maxWaterDepth" then "maxWaterDepth = Some flat.maxWaterDepth" else "maxWaterDepth = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "canFly" then "canFly = flat.canFly" else sprintf "canFly = %b" (getBool "canfly" unit |> Option.defaultValue false)) |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "canMove" then "canMove = flat.canMove" else sprintf "canMove = %b" (getBool "canmove" unit |> Option.defaultValue false)) |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "floater" then "floater = flat.floater" else sprintf "floater = %b" (getBool "floater" unit |> Option.defaultValue false)) |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "turnInPlace" then "turnInPlace = Some flat.turnInPlace" else "turnInPlace = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "turnInPlaceAngleLimit" then "turnInPlaceAngleLimit = Some flat.turnInPlaceAngleLimit" else "turnInPlaceAngleLimit = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "turnInPlaceSpeedLimit" then "turnInPlaceSpeedLimit = Some flat.turnInPlaceSpeedLimit" else "turnInPlaceSpeedLimit = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "cruiseAltitude" then "cruiseAltitude = Some flat.cruiseAltitude" else "cruiseAltitude = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "minWaterDepth" then "minWaterDepth = Some flat.minWaterDepth" else "minWaterDepth = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "waterline" then "waterline = Some flat.waterline" else "waterline = None") |> ignore
            sb.Append(sprintf "%s        " pad) |> ignore; sb.AppendLine("}") |> ignore
        else
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("movement = None") |> ignore

        // Builder
        if hasBuilder unit then
            sb.Append(sprintf "%s      " pad) |> ignore
            sb.AppendLine("builder = Some {") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore; sb.AppendLine("workerTime = flat.workerTime") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "buildDistance" then "buildDistance = Some flat.buildDistance" else "buildDistance = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore; sb.AppendLine("buildOptions = flat.buildOptions") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "terraformSpeed" then "terraformSpeed = Some flat.terraformSpeed" else "terraformSpeed = None") |> ignore
            sb.Append(sprintf "%s        " pad) |> ignore; sb.AppendLine("}") |> ignore
        else
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("builder = None") |> ignore

        // Weapons
        if hasWeapons unit then
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("weapons = Some flat.weapons") |> ignore
        else
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("weapons = None") |> ignore

        // Economy
        if hasEconomy unit then
            sb.Append(sprintf "%s      " pad) |> ignore
            sb.AppendLine("economy = Some {") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "energyMake" then "energyMake = Some flat.energyMake" else "energyMake = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "metalMake" then "metalMake = Some flat.metalMake" else "metalMake = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "energyStorage" then "energyStorage = Some flat.energyStorage" else "energyStorage = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "metalStorage" then "metalStorage = Some flat.metalStorage" else "metalStorage = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "extractsMetal" then "extractsMetal = Some flat.extractsMetal" else "extractsMetal = None") |> ignore
            sb.Append(sprintf "%s        " pad) |> ignore; sb.AppendLine("}") |> ignore
        else
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("economy = None") |> ignore

        // Building
        if hasBuilding unit then
            sb.Append(sprintf "%s      " pad) |> ignore
            sb.AppendLine("building = Some {") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore; sb.AppendLine("yardMap = Some flat.yardMap") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "activateWhenBuilt" then "activateWhenBuilt = Some flat.activateWhenBuilt" else "activateWhenBuilt = None") |> ignore
            sb.Append(sprintf "%s          " pad) |> ignore
            sb.AppendLine(if fieldSet.Contains "canRepeat" then "canRepeat = Some flat.canRepeat" else "canRepeat = None") |> ignore
            sb.Append(sprintf "%s        " pad) |> ignore; sb.AppendLine("}") |> ignore
        else
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("building = None") |> ignore

        // Feature defs
        if hasFeatureDefs unit then
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("featureDefs = Some flat.featureDefs") |> ignore
        else
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("featureDefs = None") |> ignore

        // Sounds
        if hasSounds unit then
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("sounds = Some flat.sounds") |> ignore
        else
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("sounds = None") |> ignore

        // Custom params
        if hasCustomParams unit then
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("customParams = flat.customParams") |> ignore
        else
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("customParams = Map.empty") |> ignore

        // Extras
        if hasExtras unit then
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("extras = flat.extras") |> ignore
        else
            sb.Append(sprintf "%s      " pad) |> ignore; sb.AppendLine("extras = Map.empty") |> ignore

        sb.Length <- sb.Length - 1
        sb.Append(" }") |> ignore
        sb.ToString()

    // ===================================================================
    // MODULE EMITTER: one module per subfolder with both representations
    // ===================================================================

    let emitUnitsModule (modName: string) (subfolder: string) (units: (string * LVal) list) : string =
        let sb = StringBuilder()
        sb.AppendLine(sprintf "// Auto-generated BAR unit data: %s (unified)" subfolder) |> ignore
        sb.AppendLine("namespace BarData.Units") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("open BarData") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine(sprintf "module %s =" modName) |> ignore
        sb.AppendLine() |> ignore

        for (name, value) in units |> List.sortBy fst do
            let ident = sanitizeIdent name
            let typeName = toPascalCase name
            let fields = buildFieldDefs value

            // Flat type definition
            sb.AppendLine(emitTypeDefinition "    " typeName fields) |> ignore
            sb.AppendLine() |> ignore

            // Flat singleton instance
            sb.AppendLine(sprintf "    let %s : %s =" ident typeName) |> ignore
            sb.AppendLine(emitInstance "        " name subfolder value fields) |> ignore
            sb.AppendLine() |> ignore

            // Composable UnitDef instance
            sb.AppendLine(sprintf "    let %sDef : UnitDef =" ident) |> ignore
            sb.AppendLine(emitUnitDef "        " name subfolder value) |> ignore
            sb.AppendLine() |> ignore

            // toFlat conversion
            sb.AppendLine(emitToFlat "    " ident typeName fields value) |> ignore
            sb.AppendLine() |> ignore

            // toUnitDef conversion
            sb.AppendLine(emitToUnitDef "    " ident typeName fields value) |> ignore
            sb.AppendLine() |> ignore

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

    // -----------------------------------------------------------------------
    // UnitSummary emitter
    // -----------------------------------------------------------------------

    let emitUnitSummaryEntry (pad: string) (unitName: string) (subfolder: string) (unit: LVal) : string =
        let emitVoE key =
            match tryGet key unit with
            | Some v -> emitValueOrExprFloat v
            | None -> "ValueOrExpr.Concrete 0.0"
        let isBldr = hasBuilder unit
        let isArmed = hasWeapons unit
        let isMobile = hasMovement unit && not (hasBuilding unit)
        let canFly = getBool "canfly" unit |> Option.defaultValue false
        let hasEco = hasEconomy unit
        let isBldg = hasBuilding unit
        [ sprintf "%s{ name = \"%s\"" pad (escapeString unitName)
          sprintf "%s  subfolder = \"%s\"" pad (escapeString subfolder)
          sprintf "%s  metalCost = %s" pad (emitVoE "metalcost")
          sprintf "%s  energyCost = %s" pad (emitVoE "energycost")
          sprintf "%s  health = %s" pad (emitVoE "health")
          sprintf "%s  isBuilder = %b" pad isBldr
          sprintf "%s  isArmed = %b" pad isArmed
          sprintf "%s  isMobile = %b" pad isMobile
          sprintf "%s  canFly = %b" pad canFly
          sprintf "%s  hasEconomy = %b" pad hasEco
          sprintf "%s  isBuilding = %b }" pad isBldg ]
        |> String.concat "\n"

    /// Emit AllUnits.fs with UnitSummary list and query functions.
    let emitAllUnits (groups: (string * (string * LVal) list) list) : string =
        let sb = StringBuilder()
        sb.AppendLine("// Auto-generated index of all BAR unit definitions") |> ignore
        sb.AppendLine("namespace BarData") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("module AllUnits =") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("    let all : UnitSummary list =") |> ignore
        sb.AppendLine("        [") |> ignore
        for (subfolder, units) in groups do
            for (name, value) in units |> List.sortBy fst do
                sb.AppendLine(emitUnitSummaryEntry "            " name subfolder value) |> ignore
        sb.AppendLine("        ]") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("    let tryFind (name: string) : UnitSummary option =") |> ignore
        sb.AppendLine("        all |> List.tryFind (fun u -> u.name = name)") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("    let builders () = all |> List.filter (fun u -> u.isBuilder)") |> ignore
        sb.AppendLine("    let armed () = all |> List.filter (fun u -> u.isArmed)") |> ignore
        sb.AppendLine("    let mobile () = all |> List.filter (fun u -> u.isMobile)") |> ignore
        sb.AppendLine("    let flying () = all |> List.filter (fun u -> u.canFly)") |> ignore
        sb.AppendLine("    let economy () = all |> List.filter (fun u -> u.hasEconomy)") |> ignore
        sb.AppendLine("    let buildings () = all |> List.filter (fun u -> u.isBuilding)") |> ignore
        sb.ToString()

    /// Emit AllUnitDefs.fs with composable UnitDef index.
    let emitAllUnitDefs (groups: (string * (string * LVal) list) list) : string =
        let sb = StringBuilder()
        sb.AppendLine("// Auto-generated index of all BAR composable UnitDef instances") |> ignore
        sb.AppendLine("namespace BarData") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("open BarData.Units") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("module AllUnitDefs =") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("    let all : (string * string * UnitDef) list =") |> ignore
        sb.AppendLine("        [") |> ignore
        for (sub, units) in groups do
            let modName = sanitizeIdent sub
            for (name, _) in units |> List.sortBy fst do
                sb.AppendLine(sprintf "            \"%s\", \"%s\", %s.%sDef" name sub modName (sanitizeIdent name)) |> ignore
        sb.AppendLine("        ]") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("    let tryFind (name: string) : UnitDef option =") |> ignore
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
let keepFiles = Set.ofList ["Types.fs"; "ComposableTypes.fs"; "Commands.fs"; "UnitSummary.fs"]
if Directory.Exists(outDir) then
    for f in Directory.GetFiles(outDir, "*.fs") do
        if not (keepFiles.Contains(Path.GetFileName f)) then File.Delete(f)
else
    Directory.CreateDirectory(outDir) |> ignore

printfn "Generating..."

File.WriteAllText(Path.Combine(outDir, "CustomCommands.fs"), CodeGen.emitCustomCommands customCmds)

let unitFileNames = ResizeArray<string>()
for (subfolder, units) in grouped do
    let modName = CodeGen.sanitizeIdent subfolder
    let fileName = sprintf "%s.fs" modName
    File.WriteAllText(Path.Combine(outDir, fileName), CodeGen.emitUnitsModule modName subfolder units)
    unitFileNames.Add(fileName)
    printfn "  %s — %d units" fileName units.Length

File.WriteAllText(Path.Combine(outDir, "AllUnits.fs"), CodeGen.emitAllUnits grouped)
File.WriteAllText(Path.Combine(outDir, "AllUnitDefs.fs"), CodeGen.emitAllUnitDefs grouped)

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
    sb.AppendLine("    <Compile Include=\"src/Types.fs\" />") |> ignore
    sb.AppendLine("    <Compile Include=\"src/ComposableTypes.fs\" />") |> ignore
    sb.AppendLine("    <Compile Include=\"src/Commands.fs\" />") |> ignore
    sb.AppendLine("    <Compile Include=\"src/CustomCommands.fs\" />") |> ignore
    sb.AppendLine("    <Compile Include=\"src/UnitSummary.fs\" />") |> ignore
    for fn in unitFileNames |> Seq.sort do
        sb.AppendLine(sprintf "    <Compile Include=\"src/%s\" />" fn) |> ignore
    sb.AppendLine("    <Compile Include=\"src/AllUnits.fs\" />") |> ignore
    sb.AppendLine("    <Compile Include=\"src/AllUnitDefs.fs\" />") |> ignore
    sb.AppendLine("  </ItemGroup>") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine("</Project>") |> ignore
    sb.ToString()
File.WriteAllText(projFile, fsproj)

printfn ""
printfn "=== Done ==="
printfn "  data/bar/BarData.fsproj — %d unit modules + Types + ComposableTypes + Commands + CustomCommands + UnitSummary + AllUnits + AllUnitDefs" unitFileNames.Count
printfn "  %d total unit definitions, %d custom commands" totalUnits customCmds.Length
printfn ""
