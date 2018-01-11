namespace TrelloFSharpApiWrapper.DomainTypes

type Board = {
    Id : Id
    Name : BoardName
    Closed : bool
    IdOrganization : Id
    Pinned : bool
    Url : Url
    ShortUrl : Url
    Prefs : BoardPreferences
    LabelNames : LabelColor*LabelName
    }