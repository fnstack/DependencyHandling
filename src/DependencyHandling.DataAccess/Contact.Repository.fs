namespace DependencyHandling.DataAccess

module ContactRepository =
    open System
    open DependencyHandling.Domain
    open DependencyHandling.Application

    let saveContact : SaveConctact =
        fun (contact : Contact) ->
        () |> Ok
        
    let loadContact : LoadContact  =
        fun (id : Guid) ->
        {
            Id = Guid.NewGuid()
            Name = "zappy"
            Address = "1229 ggg"
        }
