namespace DependencyHandling.Application

open DependencyHandling.Domain

open System

type LoadContact = Guid -> Contact
type SaveConctact = Contact -> Result<unit, string>
