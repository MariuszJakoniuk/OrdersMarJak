namespace OrdersMarJak.Infrastructure.Repositories;

public class ContractorRepository : IContractorRepository
{
    private readonly Context _context;
    public ContractorRepository(Context context)
    {
        _context = context;
    }

    public int AddContractor(Contractor contractor)
    {
        contractor.UserAdd = "userSymbol";
        contractor.DateAdd = DateTime.Now;
        contractor.IsDeleted = false;
        _context.Contractors.Add(contractor);
        _context.SaveChanges();
        return contractor.Id;
    }

    public bool DeleteContractor(int contractorId)
    {
        var contractor = _context.Contractors.FirstOrDefault(c => c.Id == contractorId);
        if (contractor != null)
        {
            contractor.UserDelete = "userSymbol";
            contractor.DateDelete = DateTime.Now;
            contractor.IsDeleted = true;
            _context.Attach(contractor);
            _context.Entry(contractor).Property("UserDelete").IsModified = true;
            _context.Entry(contractor).Property("DateDelete").IsModified = true;
            _context.Entry(contractor).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<Contractor> GetAllContractor()
    {
        var contractor = _context.Contractors.Where(w => w.IsDeleted == false);
        return contractor;
    }

    public Contractor GetContractorById(int contractorId)
    {
        var contractor = _context.Contractors.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == contractorId);
        return contractor;
    }

    public bool UpdateContractor(Contractor contractor)
    {
        contractor.UserUpdate = "userSymbol";
        contractor.DateUpdate = DateTime.Now;
        _context.Attach(contractor);
        _context.Entry(contractor).Property("IsCompany").IsModified = true;
        _context.Entry(contractor).Property("Symbol").IsModified = true;
        _context.Entry(contractor).Property("Name").IsModified = true;
        _context.Entry(contractor).Property("Nip").IsModified = true;
        _context.Entry(contractor).Property("UserUpdate").IsModified = true;
        _context.Entry(contractor).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
