namespace OrdersMarJak.Domain.Interfaces;

public interface ISaleOrderRepository
{
    int AddSaleOrder(SaleOrder saleOrder);

    bool DeleteSaleOrder(int saleOrderId);

    IQueryable<SaleOrder> GetAllSaleOrder();

    SaleOrder GetSaleOrderById(int saleOrderId);

    bool UpdateSaleOrder(SaleOrder saleOrder);
}
