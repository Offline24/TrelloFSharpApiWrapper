module Types

open System
open System.Collections.Generic

type Id = string
type BoardName = string //1 - 16384
type LabelName = string //0 - 16384

type BoardPermissionLevel = org = 1 | ``private`` = 2 | ``public`` = 3
type BoardVoting = disabled = 1 | members = 2 | observers = 3 | org = 4 | ``public`` = 5
type BoardComments = disabled = 1 | members = 2 | observes = 3 | org = 4 | ``public`` = 5
type BoardInvitations = admins = 1 | members = 2
type BoardBackground = blue = 1 | orange = 2 | green = 3 | red = 4 | purple = 5 | pink = 6 | lime = 7 | sky = 8 | grey = 9
type BoardCardAging = pirate = 1 | regular = 2

type BoardPreferences = {
    permissionLevel : BoardPermissionLevel
    voting : BoardVoting
    comments : BoardComments
    invitations : BoardInvitations
    selfJoin : bool
    cardCovers : bool
    background : BoardBackground
    cardAging : BoardCardAging
    }
   
type LabelColor = yellow = 1 | purple = 2 | blue = 3 | red = 4 | green = 5 | orange = 6 | black = 7 | sky = 8 | pink = 9| lime = 10 | ``null`` = 11

type Board = {
    id : Id
    name : BoardName
    closed : bool
    idOrganization : Id
    pinned : bool
    url : Uri
    shortUrl : Uri
    prefs : BoardPreferences
    labelNames : IDictionary<LabelColor, LabelName>
    }