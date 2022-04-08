namespace OrdersMarJak.Infrastructure.Repositories;

public class SaleOrderItemStatusRepository: ISaleOrderItemStatusRepository
{
    private readonly Context _context;
    public SaleOrderItemStatusRepository(Context context)
    {
        _context = context;
    }

    public int AddSaleOrderItemStatus(SaleOrderItemStatus saleOrderItemStatus)
    {
        saleOrderItemStatus.UserAdd = "userSymbol";
        saleOrderItemStatus.DateAdd = DateTime.Now;
        saleOrderItemStatus.IsDeleted = false;
        _context.SaleOrdersItemsStatus.Add(saleOrderItemStatus);
        _context.SaveChanges();
        return saleOrderItemStatus.Id;
    }

    public bool DeleteSaleOrderItemStatus(int saleOrderItemStatusId)
    {
        var saleOrderItemStatus = _context.SaleOrdersItemsStatus.FirstOrDefault(c => c.Id == saleOrderItemStatusId);
        if (saleOrderItemStatus != null)
        {
            saleOrderItemStatus.UserDelete = "userSymbol";
            saleOrderItemStatus.DateDelete = DateTime.Now;
            saleOrderItemStatus.IsDeleted = true;
            _context.Attach(saleOrderItemStatus);
            _context.Entry(saleOrderItemStatus).Property("UserDelete").IsModified = true;
            _context.Entry(saleOrderItemStatus).Property("DateDelete").IsModified = true;
            _context.Entry(saleOrderItemStatus).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<SaleOrderItemStatus> GetAllSaleOrderItemStatus()
    {
        var saleOrderItemStatus = _context.SaleOrdersItemsStatus.Where(w => w.IsDeleted == false);
        return saleOrderItemStatus;
    }

    public SaleOrderItemStatus GetSaleOrderItemStatusById(int saleOrderItemStatusId)
    {
        var saleOrderItemStatus = _context.SaleOrdersItemsStatus.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == saleOrderItemStatusId);
        return saleOrderItemStatus;
    }

    public bool UpdateSaleOrderItemStatus(SaleOrderItemStatus saleOrderItemStatus)
    {
        saleOrderItemStatus.UserUpdate = "userSymbol";
        saleOrderItemStatus.DateUpdate = DateTime.Now;
        _context.Attach(saleOrderItemStatus);
        _context.Entry(saleOrderItemStatus).Property("Name").IsModified = true;
        _context.Entry(saleOrderItemStatus).Property("Sort").IsModified = true;
        _context.Entry(saleOrderItemStatus).Property("IsEnd").IsModified = true;
        _context.Entry(saleOrderItemStatus).Property("UserUpdate").IsModified = true;
        _context.Entry(saleOrderItemStatus).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
