namespace OrdersMarJak.Domain.Interfaces;

public interface ISaleOrderItemMemoRepository
{
    int AddSaleOrderItemMemo(SaleOrderItemMemo saleOrderItemMemo);

    bool DeleteSaleOrderItemMemo(int saleOrderItemMemoId);

    IQueryable<SaleOrderItemMemo> GetAllSaleOrderItemMemoBySaleOrderItemId(int saleOrderItemId);

    SaleOrderItemMemo GetSaleOrderItemMemoById(int saleOrderItemMemoId);

    bool UpdateSaleOrderItemMemo(SaleOrderItemMemo saleOrderItem);
}
