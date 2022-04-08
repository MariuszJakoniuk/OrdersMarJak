namespace OrdersMarJak.Infrastructure.Repositories;

public class SaleOrderItemRepository: ISaleOrderItemRepository
{
    private readonly Context _context;
    public SaleOrderItemRepository(Context context)
    {
        _context = context;
    }

    public int AddSaleOrderItem(SaleOrderItem saleOrderItem)
    {
        saleOrderItem.UserAdd = "userSymbol";
        saleOrderItem.DateAdd = DateTime.Now;
        saleOrderItem.IsDeleted = false;
        _context.SaleOrdersItems.Add(saleOrderItem);
        _context.SaveChanges();
        return saleOrderItem.Id;
    }

    public bool DeleteSaleOrderItem(int saleOrderItemId)
    {
        var saleOrderItem = _context.SaleOrdersItems.FirstOrDefault(c => c.Id == saleOrderItemId);
        if (saleOrderItem != null)
        {
            saleOrderItem.UserDelete = "userSymbol";
            saleOrderItem.DateDelete = DateTime.Now;
            saleOrderItem.IsDeleted = true;
            _context.Attach(saleOrderItem);
            _context.Entry(saleOrderItem).Property("UserDelete").IsModified = true;
            _context.Entry(saleOrderItem).Property("DateDelete").IsModified = true;
            _context.Entry(saleOrderItem).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<SaleOrderItem> GetAllSaleOrderItem()
    {
        var saleOrderItem = _context.SaleOrdersItems.Where(w => w.IsDeleted == false);
        return saleOrderItem;
    }

    public IQueryable<SaleOrderItem> GetAllSaleOrderItemBySaleOrderId(int saleOrderId)
    {
        var saleOrderItem = _context.SaleOrdersItems.Where(w => w.IsDeleted == false).Where(w => w.SaleOrderId == saleOrderId);
        return saleOrderItem;
    }

    public SaleOrderItem GetSaleOrderItemById(int saleOrderItemId)
    {
        var saleOrderItem = _context.SaleOrdersItems.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == saleOrderItemId);
        return saleOrderItem;
    }

    public bool UpdateSaleOrderItem(SaleOrderItem saleOrderItem)
    {
        saleOrderItem.UserUpdate = "userSymbol";
        saleOrderItem.DateUpdate = DateTime.Now;
        _context.Attach(saleOrderItem);
        _context.Entry(saleOrderItem).Property("Name").IsModified = true;
        _context.Entry(saleOrderItem).Property("Comment").IsModified = true;
        _context.Entry(saleOrderItem).Property("ToInvoice").IsModified = true;
        _context.Entry(saleOrderItem).Property("CountryId").IsModified = true;
        _context.Entry(saleOrderItem).Property("CityId").IsModified = true;
        _context.Entry(saleOrderItem).Property("StreetId").IsModified = true;
        _context.Entry(saleOrderItem).Property("Number").IsModified = true;
        _context.Entry(saleOrderItem).Property("ZipCode").IsModified = true;
        _context.Entry(saleOrderItem).Property("PostOfficeId").IsModified = true;
        _context.Entry(saleOrderItem).Property("UserUpdate").IsModified = true;
        _context.Entry(saleOrderItem).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
