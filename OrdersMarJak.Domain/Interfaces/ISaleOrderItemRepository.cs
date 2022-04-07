namespace OrdersMarJak.Domain.Interfaces;

public interface ISaleOrderItemRepository
{
    int AddSaleOrderItem(SaleOrderItem saleOrderItem);

    bool DeleteSaleOrderItem(int saleOrderItemId);

    IQueryable<SaleOrderItem> GetAllSaleOrderItem();

    IQueryable<SaleOrderItem> GetAllSaleOrderItemBySaleOrderId(int saleOrderId);

    SaleOrderItem GetSaleOrderItemById(int saleOrderItemId);

    bool UpdateSaleOrderItem(SaleOrderItem saleOrderItem);
}
