namespace OrdersMarJak.Infrastructure.Repositories;

public class ContactTypeRepository : IContactTypeRepository
{
    private readonly Context _context;
    public ContactTypeRepository(Context context)
    {
        _context = context;
    }

    public int AddContactType(ContactType contactType)
    {
        contactType.UserAdd = "userSymbol";
        contactType.DateAdd = DateTime.Now;
        contactType.IsDeleted = false;
        _context.ContactTypes.Add(contactType);
        _context.SaveChanges();
        return contactType.Id;
    }

    public bool DeleteContactType(int contactTypeId)
    {
        var contactType = _context.ContactTypes.FirstOrDefault(c => c.Id == contactTypeId);
        if (contactType != null)
        {
            contactType.UserDelete = "userSymbol";
            contactType.DateDelete = DateTime.Now;
            contactType.IsDeleted = true;
            _context.Attach(contactType);
            _context.Entry(contactType).Property("UserDelete").IsModified = true;
            _context.Entry(contactType).Property("DateDelete").IsModified = true;
            _context.Entry(contactType).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<ContactType> GetAllContactType()
    {
        var contactType = _context.ContactTypes.Where(w => w.IsDeleted == false);
        return contactType;
    }

    public ContactType GetContactTypeById(int contactTypeId)
    {
        var contactType = _context.ContactTypes.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == contactTypeId);
        return contactType;
    }

    public bool UpdateContactType(ContactType contactType)
    {
        contactType.UserUpdate = "userSymbol";
        contactType.DateUpdate = DateTime.Now;
        _context.Attach(contactType);
        _context.Entry(contactType).Property("Name").IsModified = true;
        _context.Entry(contactType).Property("UserUpdate").IsModified = true;
        _context.Entry(contactType).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
