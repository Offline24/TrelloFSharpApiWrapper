module Tests

open System
open Xunit
open System.Net.Http

[<Fact>]
let ``My test`` () =

    let url = "https://api.trello.com/1/boards/AEKIrAPW?key=[key]&token=[token]"
    let test = HttpClient.get (new Uri(url))
    let board = JsonParser.deserializeToBoard test

    Assert.Null board
