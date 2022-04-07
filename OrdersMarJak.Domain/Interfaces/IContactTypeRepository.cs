namespace OrdersMarJak.Domain.Interfaces;

public interface IContactTypeRepository
{
    int AddContactType(ContactType contactType);

    bool DeleteContactType(int contactTypeId);

    IQueryable<ContactType> GetAllContactType();

    ContactType GetContactTypeById(int contactTypeId);

    bool UpdateContactType(ContactType contactType);
}