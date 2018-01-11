namespace TrelloFSharpApiWrapper.DomainTypes

type BoardVoting = 
    | Disabled
    | Members
    | Observers
    | Organization
    | Public