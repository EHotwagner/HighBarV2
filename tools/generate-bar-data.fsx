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
// 3. Code generation — emit F# source (typed records)
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

    // -- Sub-record emitters --

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
        // Core typed fields
        let coreFields = Set.ofList [
            "name"; "weapontype"; "range"; "reloadtime"; "weaponvelocity"
            "areaofeffect"; "accuracy"; "turret"; "tolerance"; "edgeeffectiveness"
            "impulsefactor"; "noselfdamage"; "soundstart"; "soundhit"
            "explosiongenerator"; "rgbcolor"; "onlytargetcategory"; "badtargetcategory"
            "damage"; "customparams" ]

        // Damage map
        let damageEntries =
            match tryGet "damage" tbl with
            | Some dmgTbl ->
                strEntries dmgTbl
                |> List.choose (fun (k, v) -> match v with LNum n -> Some(k, n) | _ -> None)
            | None -> []

        // Custom params
        let cpEntries =
            match tryGet "customparams" tbl with
            | Some cpTbl ->
                strEntries cpTbl
                |> List.choose (fun (k, v) -> match v with LStr s -> Some(k, s) | _ -> None)
            | None -> []

        // Extras: all fields not in coreFields, plus mount overrides with mount_ prefix
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

    let emitMovementDef (pad: string) (unit: LVal) : string option =
        let canMove = getBool "canmove" unit |> Option.defaultValue false
        let canFly = getBool "canfly" unit |> Option.defaultValue false
        let speed = getNum "speed" unit
        let hasYardMap = getStr "yardmap" unit |> Option.isSome
        let maxAcc = getNum "maxacc" unit |> Option.defaultValue 0.0
        if not canMove && not canFly && (speed.IsNone || (hasYardMap && maxAcc = 0.0)) then None
        else
            let speedVal = match tryGet "speed" unit with Some v -> emitValueOrExprFloat v | None -> "ValueOrExpr.Concrete 0.0"
            [ sprintf "%s{ speed = %s" pad speedVal
              sprintf "%s  maxAcc = %s" pad (emitFloat (getNum "maxacc" unit |> Option.defaultValue 0.0))
              sprintf "%s  maxDec = %s" pad (emitFloat (getNum "maxdec" unit |> Option.defaultValue 0.0))
              sprintf "%s  turnRate = %s" pad (emitFloat (getNum "turnrate" unit |> Option.defaultValue 0.0))
              sprintf "%s  movementClass = %s" pad (emitOptionStr (getStr "movementclass" unit))
              sprintf "%s  maxSlope = %s" pad (emitOptionFloat (getNum "maxslope" unit))
              sprintf "%s  maxWaterDepth = %s" pad (emitOptionFloat (getNum "maxwaterdepth" unit))
              sprintf "%s  canFly = %b" pad canFly
              sprintf "%s  canMove = %b" pad canMove
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
        let isBuilder = getBool "builder" unit |> Option.defaultValue false
        let hasBuildOpts = tryGet "buildoptions" unit |> Option.isSome
        if not isBuilder || not hasBuildOpts then None
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
        let em = tryGet "energymake" unit
        let mm = tryGet "metalmake" unit
        let es = getNum "energystorage" unit
        let ms = getNum "metalstorage" unit
        let ext = getNum "extractsmetal" unit
        if em.IsNone && mm.IsNone && es.IsNone && ms.IsNone && ext.IsNone then None
        else
            let emitVoEOptField key =
                match tryGet key unit with
                | Some v -> sprintf "Some (%s)" (emitValueOrExprFloat v)
                | None -> "None"
            [ sprintf "%s{ energyMake = %s" pad (emitVoEOptField "energymake")
              sprintf "%s  metalMake = %s" pad (emitVoEOptField "metalmake")
              sprintf "%s  energyStorage = %s" pad (emitOptionFloat es)
              sprintf "%s  metalStorage = %s" pad (emitOptionFloat ms)
              sprintf "%s  extractsMetal = %s }" pad (emitOptionFloat ext) ]
            |> String.concat "\n"
            |> Some

    let emitBuildingDef (pad: string) (unit: LVal) : string option =
        let ym = getStr "yardmap" unit
        if ym.IsNone then None
        else
            [ sprintf "%s{ yardMap = %s" pad (emitOptionStr ym)
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

    let emitUnitDef (pad: string) (unitName: string) (subfolder: string) (unit: LVal) : string =
        let p = pad + "  "

        // Weapons: merge weapondefs with weapons mount array
        let weaponsList =
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
                            // Try case-insensitive match
                            wdefs |> Map.tryPick (fun k v -> if k.ToLowerInvariant() = lowerDef then Some v else None))
                        |> Option.map (fun wdef -> (lowerDef, wdef, overrides)))
                if weapDefs.IsEmpty then None
                else Some weapDefs
            | Some wdTbl, None ->
                let wdefs = strEntries wdTbl
                if wdefs.IsEmpty then None
                else Some (wdefs |> List.map (fun (k, v) -> (k, v, [])))
            | _ -> None

        let emitWeapons (pad2: string) =
            match weaponsList with
            | None -> "None"
            | Some wl ->
                let lines = wl |> List.map (fun (wname, wdef, overrides) ->
                    emitWeaponDef (pad2 + "    ") wname wdef overrides)
                sprintf "Some [\n%s\n%s]" (String.concat "\n" lines) pad2

        // Sound def
        let emitSounds (pad2: string) =
            match tryGet "sounds" unit with
            | None -> "None"
            | Some stbl -> sprintf "Some (\n%s)" (emitSoundDef (pad2 + "  ") stbl)

        // Feature defs
        let emitFdefs (pad2: string) =
            match emitFeatureDefs pad2 unit with
            | None -> "None"
            | Some s -> sprintf "Some (%s)" s

        // Custom params
        let cpEntries =
            match tryGet "customparams" unit with
            | Some cpTbl ->
                strEntries cpTbl
                |> List.choose (fun (k, v) -> match v with LStr s -> Some(k, s) | LBool b -> Some(k, if b then "true" else "false") | LNum n -> Some(k, emitFloat n) | _ -> None)
            | None -> []

        // Extras: unknown fields
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

    /// Emit a module with unit definitions as typed records.
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
            sb.AppendLine(sprintf "    let %s : UnitDef =" ident) |> ignore
            sb.AppendLine(emitUnitDef "        " name subfolder value) |> ignore
            sb.AppendLine() |> ignore
        sb.AppendLine("    let all : (string * UnitDef) list =") |> ignore
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
        sb.AppendLine("    let all : (string * string * UnitDef) list =") |> ignore
        sb.AppendLine("        [") |> ignore
        for (sub, units) in groups do
            let modName = sanitizeIdent sub
            for (name, _) in units |> List.sortBy fst do
                sb.AppendLine(sprintf "            \"%s\", \"%s\", %s.%s" name sub modName (sanitizeIdent name)) |> ignore
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
let keepFiles = Set.ofList ["Types.fs"; "Commands.fs"]
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
    sb.AppendLine("    <Compile Include=\"src/Types.fs\" />") |> ignore
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
