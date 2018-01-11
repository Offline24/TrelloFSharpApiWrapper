namespace TrelloFSharpApiWrapper.DomainTypes

open System

type Id = Id of string

module Id = 
    let create id = 
        if not (id |> String.IsNullOrEmpty)
        then Some (Id id)
        else None