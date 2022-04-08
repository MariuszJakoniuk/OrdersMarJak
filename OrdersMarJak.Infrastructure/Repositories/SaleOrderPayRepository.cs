namespace OrdersMarJak.Infrastructure.Repositories;


public class SaleOrderPayRepository: ISaleOrderPayRepository
{
    private readonly Context _context;
    public SaleOrderPayRepository(Context context)
    {
        _context = context;
    }

    public int AddSaleOrderPay(SaleOrderPay saleOrderPay)
    {
        saleOrderPay.UserAdd = "userSymbol";
        saleOrderPay.DateAdd = DateTime.Now;
        saleOrderPay.IsDeleted = false;
        _context.SaleOrderPays.Add(saleOrderPay);
        _context.SaveChanges();
        return saleOrderPay.Id;
    }

    public bool DeleteSaleOrderPay(int saleOrderPayId)
    {
         var saleOrderPay = _context.SaleOrderPays.FirstOrDefault(c => c.Id == saleOrderPayId);
        if (saleOrderPay != null)
        {
            saleOrderPay.UserDelete = "userSymbol";
            saleOrderPay.DateDelete = DateTime.Now;
            saleOrderPay.IsDeleted = true;
            _context.Attach(saleOrderPay);
            _context.Entry(saleOrderPay).Property("UserDelete").IsModified = true;
            _context.Entry(saleOrderPay).Property("DateDelete").IsModified = true;
            _context.Entry(saleOrderPay).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<SaleOrderPay> GetAllSaleOrderPayBySaleOrderId(int saleOrderId)
    {
        var saleOrderPay = _context.SaleOrderPays.Where(w => w.IsDeleted == false).Where(w => w.SaleOrderId == saleOrderId);
        return saleOrderPay;
    }

    public SaleOrderPay GetSaleOrderPayById(int saleOrderPayId)
    {
        var saleOrderPay = _context.SaleOrderPays.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == saleOrderPayId);
        return saleOrderPay;
    }

    public bool UpdateSaleOrderPay(SaleOrderPay saleOrderPay)
    {
        saleOrderPay.UserUpdate = "userSymbol";
        saleOrderPay.DateUpdate = DateTime.Now;
        _context.Attach(saleOrderPay);
        _context.Entry(saleOrderPay).Property("DatePay").IsModified = true;
        _context.Entry(saleOrderPay).Property("Pay").IsModified = true;
        _context.Entry(saleOrderPay).Property("Name").IsModified = true;
        _context.Entry(saleOrderPay).Property("Remarks").IsModified = true;
        _context.Entry(saleOrderPay).Property("UserUpdate").IsModified = true;
        _context.Entry(saleOrderPay).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
