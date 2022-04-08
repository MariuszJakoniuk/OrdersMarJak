namespace OrdersMarJak.Infrastructure.Repositories;

public class ContractorContactRepository: IContractorContactRepository
{
    private readonly Context _context;
    public ContractorContactRepository(Context context)
    {
        _context = context;
    }

    public int AddContractorContact(ContractorContact contractorContact)
    {
        contractorContact.UserAdd = "userSymbol";
        contractorContact.DateAdd = DateTime.Now;
        contractorContact.IsDeleted = false;
        _context.ContractorContacts.Add(contractorContact);
        _context.SaveChanges();
        return contractorContact.Id;
    }

    public bool DeleteContractorContact(int contractorContactId)
    {
        var contractorContact = _context.ContractorContacts.FirstOrDefault(c => c.Id == contractorContactId);
        if (contractorContact != null)
        {
            contractorContact.UserDelete = "userSymbol";
            contractorContact.DateDelete = DateTime.Now;
            contractorContact.IsDeleted = true;
            _context.Attach(contractorContact);
            _context.Entry(contractorContact).Property("UserDelete").IsModified = true;
            _context.Entry(contractorContact).Property("DateDelete").IsModified = true;
            _context.Entry(contractorContact).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<ContractorContact> GetAllContractorContact()
    {
        var contractorContact = _context.ContractorContacts.Where(w => w.IsDeleted == false);
        return contractorContact;
    }

    public IQueryable<ContractorContact> GetAllContractorContactByContractorId(int contractorId)
    {
        var contractorContact = _context.ContractorContacts.Where(w => w.IsDeleted == false).Where(w => w.ContractorId == contractorId);
        return contractorContact;
    }

    public ContractorContact GetContractorContactById(int contractorContactId)
    {
        var contractorContact = _context.ContractorContacts.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == contractorContactId);
        return contractorContact;
    }

    public bool UpdateContractorContact(ContractorContact contractorContact)
    {
        contractorContact.UserUpdate = "userSymbol";
        contractorContact.DateUpdate = DateTime.Now;
        _context.Attach(contractorContact);
        _context.Entry(contractorContact).Property("ContactTypeId").IsModified = true;
        _context.Entry(contractorContact).Property("Name").IsModified = true;
        _context.Entry(contractorContact).Property("IsPrimary").IsModified = true;
        _context.Entry(contractorContact).Property("Comment").IsModified = true;
        _context.Entry(contractorContact).Property("UserUpdate").IsModified = true;
        _context.Entry(contractorContact).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
