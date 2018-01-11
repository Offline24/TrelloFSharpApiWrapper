namespace TrelloFSharpApiWrapper.DomainTypes

type BoardPreferences = {
    PermissionLevel : BoardPermissionLevel
    Voting : BoardVoting
    Comments : BoardComments
    Invitations : BoardInvitations
    SelfJoin : bool
    CardCovers : bool
    Background : BoardBackground
    CardAging : BoardCardAging
    }
   