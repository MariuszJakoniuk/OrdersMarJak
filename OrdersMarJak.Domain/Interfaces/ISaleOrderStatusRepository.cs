namespace OrdersMarJak.Domain.Interfaces;

public interface ISaleOrderStatusRepository
{
    int AddSaleOrderStatus(SaleOrderStatus saleOrderStatus);

    bool DeleteSaleOrderStatus(int saleOrderStatusId);

    IQueryable<SaleOrderStatus> GetAllSaleOrderStatus();

    SaleOrderStatus GetSaleOrderStatusById(int saleOrderStatusId);

    bool UpdateSaleOrderStatus(SaleOrderStatus saleOrderStatus);
}
