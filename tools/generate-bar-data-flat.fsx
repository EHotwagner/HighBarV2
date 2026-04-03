#!/usr/bin/env dotnet fsi
/// Generates a flat per-unit type F# library from BAR Lua unit definitions.
/// Each unit gets its own record type containing only the fields it actually has.
///
/// Usage:  dotnet fsi tools/generate-bar-data-flat.fsx [--skip-clone]
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
// 2. Lua table parser using XParsec (copied from generate-bar-data.fsx)
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
// 3. Code generation — emit F# source (flat per-unit types)
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

    // -- Sub-record emitters (reused from v1) --

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
          sprintf "%s  displayName = %s" pad (emitOptionStr (getStr "name" tbl))
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
          sprintf "%s  onlyTargetCategory = %s" pad (emitOptionStr (getStr "onlytargetcategory" tbl))
          sprintf "%s  badTargetCategory = %s" pad (emitOptionStr (getStr "badtargetcategory" tbl))
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
    // Field analysis: determine which fields a unit has
    // -----------------------------------------------------------------------

    type FieldInfo =
        { fieldName: string
          fieldType: string
          emitValue: string -> LVal -> string }

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

    // -----------------------------------------------------------------------
    // Per-unit type definition emitter
    // -----------------------------------------------------------------------

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
        // Close the record
        sb.Length <- sb.Length - 1 // remove trailing newline
        sb.Append(" }") |> ignore
        sb.ToString()

    // -----------------------------------------------------------------------
    // Per-unit instance emitter
    // -----------------------------------------------------------------------

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

        // Remove trailing newline and close record
        sb.Length <- sb.Length - 1
        sb.Append(" }") |> ignore
        sb.ToString()

    // -----------------------------------------------------------------------
    // Module emitter: one module per subfolder with per-unit types + instances
    // -----------------------------------------------------------------------

    let emitUnitsModule (modName: string) (subfolder: string) (units: (string * LVal) list) : string =
        let sb = StringBuilder()
        sb.AppendLine(sprintf "// Auto-generated BAR unit data: %s (flat per-unit types)" subfolder) |> ignore
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

            // Emit type definition
            sb.AppendLine(emitTypeDefinition "    " typeName fields) |> ignore
            sb.AppendLine() |> ignore

            // Emit singleton instance
            sb.AppendLine(sprintf "    let %s : %s =" ident typeName) |> ignore
            sb.AppendLine(emitInstance "        " name subfolder value fields) |> ignore
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
        let isBuilder = hasBuilder unit
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
          sprintf "%s  isBuilder = %b" pad isBuilder
          sprintf "%s  isArmed = %b" pad isArmed
          sprintf "%s  isMobile = %b" pad isMobile
          sprintf "%s  canFly = %b" pad canFly
          sprintf "%s  hasEconomy = %b" pad hasEco
          sprintf "%s  isBuilding = %b }" pad isBldg ]
        |> String.concat "\n"

    /// Emit AllUnits.fs with UnitSummary list and query functions.
    let emitAllUnits (groups: (string * (string * LVal) list) list) : string =
        let sb = StringBuilder()
        sb.AppendLine("// Auto-generated index of all BAR unit definitions (flat types)") |> ignore
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
let keepFiles = Set.ofList ["Types.fs"; "Commands.fs"; "UnitSummary.fs"]
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
    sb.AppendLine("    <Compile Include=\"src/Commands.fs\" />") |> ignore
    sb.AppendLine("    <Compile Include=\"src/CustomCommands.fs\" />") |> ignore
    sb.AppendLine("    <Compile Include=\"src/UnitSummary.fs\" />") |> ignore
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
printfn "  data/bar/BarData.fsproj — %d unit modules + Commands + CustomCommands + UnitSummary + AllUnits" unitFileNames.Count
printfn "  %d total unit definitions, %d custom commands" totalUnits customCmds.Length
printfn ""
printfn "Build: dotnet build data/bar/BarData.fsproj"
