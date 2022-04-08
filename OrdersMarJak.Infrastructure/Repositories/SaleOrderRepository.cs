namespace OrdersMarJak.Infrastructure.Repositories;

public class SaleOrderRepository: ISaleOrderRepository
{
    private readonly Context _context;
    public SaleOrderRepository(Context context)
    {
        _context = context;
    }

    public int AddSaleOrder(SaleOrder saleOrder)
    {
        saleOrder.UserAdd = "userSymbol";
        saleOrder.DateAdd = DateTime.Now;
        saleOrder.IsDeleted = false;
        _context.SaleOrders.Add(saleOrder);
        _context.SaveChanges();
        return saleOrder.Id;
    }

    public bool DeleteSaleOrder(int saleOrderId)
    {
        var saleOrder = _context.SaleOrders.FirstOrDefault(c => c.Id == saleOrderId);
        if (saleOrder != null)
        {
            saleOrder.UserDelete = "userSymbol";
            saleOrder.DateDelete = DateTime.Now;
            saleOrder.IsDeleted = true;
            _context.Attach(saleOrder);
            _context.Entry(saleOrder).Property("UserDelete").IsModified = true;
            _context.Entry(saleOrder).Property("DateDelete").IsModified = true;
            _context.Entry(saleOrder).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<SaleOrder> GetAllSaleOrder()
    {
        var saleOrder = _context.SaleOrders.Where(w => w.IsDeleted == false);
        return saleOrder;
    }

    public SaleOrder GetSaleOrderById(int saleOrderId)
    {
        var saleOrder = _context.SaleOrders.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == saleOrderId);
        return saleOrder;
    }

    public bool UpdateSaleOrder(SaleOrder saleOrder)
    {
        saleOrder.UserUpdate = "userSymbol";
        saleOrder.DateUpdate = DateTime.Now;
        _context.Attach(saleOrder);
        _context.Entry(saleOrder).Property("Year").IsModified = true;
        _context.Entry(saleOrder).Property("Number").IsModified = true;
        _context.Entry(saleOrder).Property("NumberFull").IsModified = true;
        _context.Entry(saleOrder).Property("NumberShort").IsModified = true;
        _context.Entry(saleOrder).Property("NumberInContractor").IsModified = true;
        _context.Entry(saleOrder).Property("DateIn").IsModified = true;
        _context.Entry(saleOrder).Property("Name").IsModified = true;
        _context.Entry(saleOrder).Property("DateSigning ").IsModified = true;
        _context.Entry(saleOrder).Property("DateDeadline").IsModified = true;
        _context.Entry(saleOrder).Property("DateEnd").IsModified = true;
        _context.Entry(saleOrder).Property("Brutto ").IsModified = true;
        _context.Entry(saleOrder).Property("Netto").IsModified = true;
        _context.Entry(saleOrder).Property("Paid").IsModified = true;
        _context.Entry(saleOrder).Property("LeftPay").IsModified = true;
        _context.Entry(saleOrder).Property("Remarks").IsModified = true;
        _context.Entry(saleOrder).Property("ContractorId").IsModified = true;
        _context.Entry(saleOrder).Property("SaleOrderStatusId").IsModified = true;
        _context.Entry(saleOrder).Property("SaleOrderRegisterId").IsModified = true;
        _context.Entry(saleOrder).Property("UserUpdate").IsModified = true;
        _context.Entry(saleOrder).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
