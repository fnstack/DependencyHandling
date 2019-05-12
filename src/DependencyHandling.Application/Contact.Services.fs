namespace DependencyHandling.Application
open System
open DependencyHandling.Domain

module ContactValidators =
    let validateName contact =
        match contact.Name |> String.IsNullOrWhiteSpace with
        | true ->
            "Le nom ne doit pas etre nul" |> Error
        | false ->
            contact |> Ok

type ContactService (loadContact : LoadContact, saveContact : SaveConctact) =
    member __.SaveContact (contact : Contact) =
        contact
        |> ContactValidators.validateName
        |> Result.bind saveContact
    member __.LoadContact (id : Guid) =
        id |> loadContact