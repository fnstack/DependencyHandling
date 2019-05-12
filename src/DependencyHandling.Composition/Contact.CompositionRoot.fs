namespace DependencyHandling.Composition

module ContactCompositionRoot =
    open DependencyHandling.Application
    open DependencyHandling.DataAccess

    let contactService = new ContactService(ContactRepository.loadContact, ContactRepository.saveContact)
