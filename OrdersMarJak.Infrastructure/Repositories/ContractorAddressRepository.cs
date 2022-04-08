namespace OrdersMarJak.Infrastructure.Repositories;

public class ContractorAddressRepository : IContractorAddressRepository
{
    private readonly Context _context;
    public ContractorAddressRepository(Context context)
    {
        _context = context;
    }

    public int AddContractorAddress(ContractorAddress contractorAddress)
    {
        contractorAddress.UserAdd = "userSymbol";
        contractorAddress.DateAdd = DateTime.Now;
        contractorAddress.IsDeleted = false;
        _context.ContractorAddresses.Add(contractorAddress);
        _context.SaveChanges();
        return contractorAddress.Id;
    }

    public bool DeleteContractorAddress(int contractorAddressId)
    {
        var contractorAddress = _context.ContractorAddresses.FirstOrDefault(c => c.Id == contractorAddressId);
        if (contractorAddress != null)
        {
            contractorAddress.UserDelete = "userSymbol";
            contractorAddress.DateDelete = DateTime.Now;
            contractorAddress.IsDeleted = true;
            _context.Attach(contractorAddress);
            _context.Entry(contractorAddress).Property("UserDelete").IsModified = true;
            _context.Entry(contractorAddress).Property("DateDelete").IsModified = true;
            _context.Entry(contractorAddress).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<ContractorAddress> GetAllContractorAddress()
    {
        var contractorAddress = _context.ContractorAddresses.Where(w => w.IsDeleted == false);
        return contractorAddress;
    }

    public IQueryable<ContractorAddress> GetAllContractorAddressByContractorId(int contractorId)
    {
        var contractorAddress = _context.ContractorAddresses.Where(w => w.IsDeleted == false).Where(w => w.ContractorId == contractorId);
        return contractorAddress;
    }

    public ContractorAddress GetContractorAddressById(int contractorAddressId)
    {
        var contractorAddress = _context.ContractorAddresses.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == contractorAddressId);
        return contractorAddress;
    }

    public bool UpdateContractorAddress(ContractorAddress contractorAddress)
    {
        contractorAddress.UserUpdate = "userSymbol";
        contractorAddress.DateUpdate = DateTime.Now;
        _context.Attach(contractorAddress);
        _context.Entry(contractorAddress).Property("Name").IsModified = true;
        _context.Entry(contractorAddress).Property("Comment").IsModified = true;
        _context.Entry(contractorAddress).Property("ToInvoice").IsModified = true;
        _context.Entry(contractorAddress).Property("CountryId").IsModified = true;
        _context.Entry(contractorAddress).Property("CityId").IsModified = true;
        _context.Entry(contractorAddress).Property("StreetId").IsModified = true;
        _context.Entry(contractorAddress).Property("Number").IsModified = true;
        _context.Entry(contractorAddress).Property("ZipCode").IsModified = true;
        _context.Entry(contractorAddress).Property("PostOfficeId").IsModified = true;
        _context.Entry(contractorAddress).Property("UserUpdate").IsModified = true;
        _context.Entry(contractorAddress).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
