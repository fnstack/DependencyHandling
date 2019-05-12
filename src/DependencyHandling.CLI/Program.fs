// Learn more about F# at http://fsharp.org

open DependencyHandling.Composition
open DependencyHandling.Domain
open System

[<EntryPoint>]
let main argv =
    let moncontact = ContactCompositionRoot.contactService.LoadContact(Guid.NewGuid())
    let newcontact = {Contact.Id = Guid.NewGuid(); Name = "gismo"; Address = ""}
    let result = ContactCompositionRoot.contactService.SaveContact(newcontact)
    0 // return an integer exit code
