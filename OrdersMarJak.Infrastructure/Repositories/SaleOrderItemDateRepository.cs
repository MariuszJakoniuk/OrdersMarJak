namespace OrdersMarJak.Infrastructure.Repositories;

public class SaleOrderItemDateRepository : ISaleOrderItemDateRepository
{
    private readonly Context _context;
    public SaleOrderItemDateRepository(Context context)
    {
        _context = context;
    }

    public int AddSaleOrderItemDate(SaleOrderItemDate saleOrderItemDate)
    {
        saleOrderItemDate.UserAdd = "userSymbol";
        saleOrderItemDate.DateAdd = DateTime.Now;
        saleOrderItemDate.IsDeleted = false;
        _context.SaleOrderItemDates.Add(saleOrderItemDate);
        _context.SaveChanges();
        return saleOrderItemDate.Id;
    }

    public bool DeleteSaleOrderItemDate(int saleOrderItemDateId)
    {
        var saleOrderItemDate = _context.SaleOrderItemDates.FirstOrDefault(c => c.Id == saleOrderItemDateId);
        if (saleOrderItemDate != null)
        {
            saleOrderItemDate.UserDelete = "userSymbol";
            saleOrderItemDate.DateDelete = DateTime.Now;
            saleOrderItemDate.IsDeleted = true;
            _context.Attach(saleOrderItemDate);
            _context.Entry(saleOrderItemDate).Property("UserDelete").IsModified = true;
            _context.Entry(saleOrderItemDate).Property("DateDelete").IsModified = true;
            _context.Entry(saleOrderItemDate).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<SaleOrderItemDate> GetAllSaleOrderItemDateByOrderItemId(int saleOrderItemId)
    {
        var saleOrderItemDate = _context.SaleOrderItemDates.Where(w => w.IsDeleted == false).Where(w => w.SaleOrderItemId == saleOrderItemId);
        return saleOrderItemDate;
    }

    public SaleOrderItemDate GetSaleOrderItemDateById(int saleOrderItemDateId)
    {
        var saleOrderItemDate = _context.SaleOrderItemDates.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == saleOrderItemDateId);
        return saleOrderItemDate;
    }

    public bool UpdateSaleOrderItemDate(SaleOrderItemDate saleOrderItemDate)
    {
        saleOrderItemDate.UserUpdate = "userSymbol";
        saleOrderItemDate.DateUpdate = DateTime.Now;
        _context.Attach(saleOrderItemDate);
        _context.Entry(saleOrderItemDate).Property("DateIn").IsModified = true;
        _context.Entry(saleOrderItemDate).Property("DateStart").IsModified = true;
        _context.Entry(saleOrderItemDate).Property("DateEnd").IsModified = true;
        _context.Entry(saleOrderItemDate).Property("Comment").IsModified = true;
        _context.Entry(saleOrderItemDate).Property("EmployeeId").IsModified = true;
        _context.Entry(saleOrderItemDate).Property("EmployeeGroupId").IsModified = true;
        _context.Entry(saleOrderItemDate).Property("UserUpdate").IsModified = true;
        _context.Entry(saleOrderItemDate).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
