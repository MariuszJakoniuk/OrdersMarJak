namespace OrdersMarJak.Infrastructure.Repositories;

public class SaleOrderItemMemoRepository : ISaleOrderItemMemoRepository
{
    private readonly Context _context;
    public SaleOrderItemMemoRepository(Context context)
    {
        _context = context;
    }

    public int AddSaleOrderItemMemo(SaleOrderItemMemo saleOrderItemMemo)
    {
        saleOrderItemMemo.UserAdd = "userSymbol";
        saleOrderItemMemo.DateAdd = DateTime.Now;
        saleOrderItemMemo.IsDeleted = false;
        _context.SaleOrderItemMemos.Add(saleOrderItemMemo);
        _context.SaveChanges();
        return saleOrderItemMemo.Id;
    }

    public bool DeleteSaleOrderItemMemo(int saleOrderItemMemoId)
    {
        var saleOrderItemMemo = _context.SaleOrderItemMemos.FirstOrDefault(c => c.Id == saleOrderItemMemoId);
        if (saleOrderItemMemo != null)
        {
            saleOrderItemMemo.UserDelete = "userSymbol";
            saleOrderItemMemo.DateDelete = DateTime.Now;
            saleOrderItemMemo.IsDeleted = true;
            _context.Attach(saleOrderItemMemo);
            _context.Entry(saleOrderItemMemo).Property("UserDelete").IsModified = true;
            _context.Entry(saleOrderItemMemo).Property("DateDelete").IsModified = true;
            _context.Entry(saleOrderItemMemo).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<SaleOrderItemMemo> GetAllSaleOrderItemMemoBySaleOrderItemId(int saleOrderItemId)
    {
        var saleOrderItemMemo = _context.SaleOrderItemMemos.Where(w => w.IsDeleted == false).Where(w => w.SaleOrderItemId == saleOrderItemId);
        return saleOrderItemMemo;
    }

    public SaleOrderItemMemo GetSaleOrderItemMemoById(int saleOrderItemMemoId)
    {
        var saleOrderItemMemo = _context.SaleOrderItemMemos.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == saleOrderItemMemoId);
        return saleOrderItemMemo;
    }

    public bool UpdateSaleOrderItemMemo(SaleOrderItemMemo saleOrderItemMemo)
    {
        saleOrderItemMemo.UserUpdate = "userSymbol";
        saleOrderItemMemo.DateUpdate = DateTime.Now;
        _context.Attach(saleOrderItemMemo);
        _context.Entry(saleOrderItemMemo).Property("MemoDate").IsModified = true;
        _context.Entry(saleOrderItemMemo).Property("Memo").IsModified = true;
        _context.Entry(saleOrderItemMemo).Property("UserUpdate").IsModified = true;
        _context.Entry(saleOrderItemMemo).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
