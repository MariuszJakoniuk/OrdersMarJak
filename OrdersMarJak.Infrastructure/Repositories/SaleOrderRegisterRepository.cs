namespace OrdersMarJak.Infrastructure.Repositories;

public class SaleOrderRegisterRepository: ISaleOrderRegisterRepository
{
    private readonly Context _context;
    public SaleOrderRegisterRepository(Context context)
    {
        _context = context;
    }

    public int AddSaleOrderRegister(SaleOrderRegister saleOrderRegister)
    {
        saleOrderRegister.UserAdd = "userSymbol";
        saleOrderRegister.DateAdd = DateTime.Now;
        saleOrderRegister.IsDeleted = false;
        _context.SaleOrdersRegisters.Add(saleOrderRegister);
        _context.SaveChanges();
        return saleOrderRegister.Id;
    }

    public bool DeleteSaleOrderRegister(int saleOrderRegisterId)
    {
        var saleOrderRegister = _context.SaleOrdersRegisters.FirstOrDefault(c => c.Id == saleOrderRegisterId);
        if (saleOrderRegister != null)
        {
            saleOrderRegister.UserDelete = "userSymbol";
            saleOrderRegister.DateDelete = DateTime.Now;
            saleOrderRegister.IsDeleted = true;
            _context.Attach(saleOrderRegister);
            _context.Entry(saleOrderRegister).Property("UserDelete").IsModified = true;
            _context.Entry(saleOrderRegister).Property("DateDelete").IsModified = true;
            _context.Entry(saleOrderRegister).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<SaleOrderRegister> GetAllSaleOrderRegister()
    {
        var saleOrderRegister = _context.SaleOrdersRegisters.Where(w => w.IsDeleted == false);
        return saleOrderRegister;
    }

    public SaleOrderRegister GetSaleOrderRegisterById(int saleOrderRegisterId)
    {
        var saleOrderRegister = _context.SaleOrdersRegisters.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == saleOrderRegisterId);
        return saleOrderRegister;
    }

    public bool UpdateSaleOrderRegister(SaleOrderRegister saleOrderRegister)
    {
        saleOrderRegister.UserUpdate = "userSymbol";
        saleOrderRegister.DateUpdate = DateTime.Now;
        _context.Attach(saleOrderRegister);
        _context.Entry(saleOrderRegister).Property("Symbol").IsModified = true;
        _context.Entry(saleOrderRegister).Property("Name").IsModified = true;
        _context.Entry(saleOrderRegister).Property("UserUpdate").IsModified = true;
        _context.Entry(saleOrderRegister).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
