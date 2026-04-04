namespace HighBar.PersistentTests

open System
open System.Collections.Generic
open Xunit
open Xunit.Abstractions
open Xunit.Sdk

/// Attribute to set execution priority on test methods.
/// Lower values run first.
[<AttributeUsage(AttributeTargets.Method, AllowMultiple = false)>]
type PriorityAttribute(priority: int) =
    inherit Attribute()
    member _.Priority = priority

/// Custom test case orderer that sorts by Priority attribute value (ascending).
/// Tests without a Priority attribute default to Int32.MaxValue (run last).
type PriorityOrderer() =
    interface ITestCaseOrderer with
        member _.OrderTestCases<'TTestCase when 'TTestCase :> ITestCase>(testCases: IEnumerable<'TTestCase>) =
            let sorted =
                testCases
                |> Seq.sortBy (fun tc ->
                    let priorityAttr =
                        tc.TestMethod.Method.GetCustomAttributes(typeof<PriorityAttribute>)
                        |> Seq.tryHead
                    match priorityAttr with
                    | Some attr ->
                        attr.GetNamedArgument<int>("Priority")
                    | None -> Int32.MaxValue)
            sorted
