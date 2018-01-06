module Types

open System

type Id = Id of string
type BoardName = BoardName of string //1 - 16384
type LabelName = LabelName of string //0 - 16384

type BoardPermissionLevel = Org | Private | Public
type BoardVoting = Disabled | Members | Observers | Org | Public
type BoardComments = Disabled | Members | Observes | Org | Public
type BoardInvitations = Admins | Members
type BoardBackground = Blue | Orange | Green | Red | Purple | Pink | Lime | Sky | Grey
type BoardCardAging = Pirate | Regular

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
   
type LabelColor = Yellow | Purple | Blue | Red | Green | Orange | Black | Sky | Pink | Lime | Null

type Board = {
    id : Id
    name : BoardName
    closed : bool
    idOrganization : Id
    pinned : bool
    url : Uri
    shortUrl : Uri
    prefs : BoardPreferences
    labelNames : (LabelName*LabelColor) seq
    }