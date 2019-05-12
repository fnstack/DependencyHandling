namespace DependencyHandling.Application
open System
open DependencyHandling.Domain

type ContactService() =
    member __.SaveContact (contact : Contact) =
        ()
    member __.LoadContact (id : Guid) =
        ()