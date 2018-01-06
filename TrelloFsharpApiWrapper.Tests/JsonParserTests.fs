module JsonParserTests

open System
open Types
open Xunit
open FsUnit.Xunit

type ``Deserializing tests`` () =

    [<Fact>]
    let ``board parsing`` () =
        //Given
        let xx = dict["blue", 40; "red", 700]
        let jsonText = System.IO.File.ReadAllText "./JsonExamples/board.json"
        //let expectedResult = {
        //    id = "586e8f681d4fe9b06a928307"
        //    name = "Best Test Board!"
        //    closed = false
        //    idOrganization = "586e8d7b1af892b26d5b76b1"
        //    pinned = false
        //    url = Uri "https://trello.com/b/d2EnEWSY/best-test-board"
        //    shortUrl = Uri "https://trello.com/b/d2EnEWSY"
        //    prefs = {
        //            permissionLevel = BoardPermissionLevel.org
        //            voting = BoardVoting.disabled
        //            comments = BoardComments.members
        //            invitations = BoardInvitations.members
        //            selfJoin = true
        //            cardCovers = true
        //            background = BoardBackground.blue
        //            cardAging = BoardCardAging.regular
        //        }
        //    labelNames = 
        //        dict[
        //            LabelColor.sky, "Test Label 1"
        //            LabelColor.lime, "Test Label 2"
        //            LabelColor.pink, "f"
        //        ]
        //    }

        //When
        let result = JsonParser.deserializeToBoard jsonText

        //Then      
        result |> should be null
        //result |> should equal expectedResult