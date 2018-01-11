namespace TrelloFSharpApiWrapper.DomainTypes

open System.Text.RegularExpressions

type Url = 
    | HttpsUrl of string

module Url =

    let createHttps httpsUrl = 
        let regexPattern =  @"^(https)://[^\s/$.?#].[^\s]*$"    //https://mathiasbynens.be/demo/url-regex
        let regexMatch = Regex.Match(httpsUrl, regexPattern)
        if regexMatch.Success
        then Some (HttpsUrl httpsUrl)
        else None