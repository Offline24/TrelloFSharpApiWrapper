// Learn more about F# at http://fsharp.org

open System

open Expecto


let tests =
  test "A simple test" {
    let subject = "Hello World"
    Expect.equal subject "Hello World" "The strings should equal"
  }

[<EntryPoint>]
let main args =
  runTestsWithArgs defaultConfig args tests