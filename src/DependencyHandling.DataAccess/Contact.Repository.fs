namespace DependencyHandling.DataAccess

module ContactRepository =
    open System
    open DependencyHandling.Domain

    let saveContact (contact : Contact) =
        () |> Ok
        
    let loadContact (id : Guid) =
        {
            Id = Guid.NewGuid()
            Name = "zappy"
            Address = "1229 ggg"
        } |> Ok
