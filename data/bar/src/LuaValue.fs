namespace BarData

/// Key type for Lua table entries.
[<RequireQualifiedAccess>]
type LuaKey =
    | String of string
    | Int of int

/// A parsed Lua value (Lua tables used as a data format).
[<RequireQualifiedAccess>]
type LuaValue =
    | String of string
    | Number of float
    | Bool of bool
    | Nil
    | Table of (LuaKey * LuaValue) list
    | Expr of string  // Runtime Lua expression that can't be statically evaluated

module LuaValue =

    /// Lookup a string key in a table.
    let tryGet (key: string) (v: LuaValue) : LuaValue option =
        match v with
        | LuaValue.Table entries ->
            entries
            |> List.tryFind (fun (k, _) -> match k with LuaKey.String s -> s = key | _ -> false)
            |> Option.map snd
        | _ -> None

    /// Get a string field or default.
    let getString (key: string) (def: string) (v: LuaValue) : string =
        match tryGet key v with
        | Some(LuaValue.String s) -> s
        | _ -> def

    /// Get a numeric field or default.
    let getNumber (key: string) (def: float) (v: LuaValue) : float =
        match tryGet key v with
        | Some(LuaValue.Number n) -> n
        | _ -> def

    /// Get a boolean field or default.
    let getBool (key: string) (def: bool) (v: LuaValue) : bool =
        match tryGet key v with
        | Some(LuaValue.Bool b) -> b
        | _ -> def

    /// Get all string-keyed entries from a table.
    let entries (v: LuaValue) : (string * LuaValue) list =
        match v with
        | LuaValue.Table items ->
            items
            |> List.choose (fun (k, v) -> match k with LuaKey.String s -> Some(s, v) | _ -> None)
        | _ -> []

    /// Get indexed entries from a table as a list of values.
    let indexed (v: LuaValue) : LuaValue list =
        match v with
        | LuaValue.Table items ->
            items
            |> List.choose (fun (k, v) -> match k with LuaKey.Int _ -> Some v | _ -> None)
        | _ -> []

    /// Get build options as a string list.
    let buildOptions (v: LuaValue) : string list =
        match tryGet "buildoptions" v with
        | Some(LuaValue.Table items) ->
            items
            |> List.sortBy (fun (k, _) -> match k with LuaKey.Int i -> i | _ -> 999)
            |> List.choose (fun (_, v) -> match v with LuaValue.String s -> Some s | _ -> None)
        | _ -> []
