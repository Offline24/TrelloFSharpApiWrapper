namespace TrelloFSharpApiWrapper.DomainTypes

open System

type BoardName = BoardName of string

module BoardName = 
    let create boardName = 
        if 
            not (boardName |> String.IsNullOrEmpty) &&
            boardName |> String.length >= 1 &&
            boardName |> String.length <= 16384
        then Some (BoardName boardName)
        else None