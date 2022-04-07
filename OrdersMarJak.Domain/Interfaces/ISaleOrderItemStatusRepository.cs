namespace OrdersMarJak.Domain.Interfaces;

public interface ISaleOrderItemStatusRepository
{
    int AddSaleOrderItemStatus(SaleOrderItemStatus saleOrderItemStatus);

    bool DeleteSaleOrderItemStatus(int saleOrderItemStatusId);

    IQueryable<SaleOrderItemStatus> GetAllSaleOrderItemStatus();

    SaleOrderItemStatus GetSaleOrderItemStatusById(int saleOrderItemStatusId);

    bool UpdateSaleOrderItemStatus(SaleOrderItemStatus saleOrderItemStatus);
}
