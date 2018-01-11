namespace TrelloFSharpApiWrapper.DomainTypes

open System

type LabelName = LabelName of string

module LabelName = 
    let create labelName = 
        if 
            not (labelName |> String.IsNullOrEmpty) &&
            labelName |> String.length <= 16384
        then Some (LabelName labelName)
        else None