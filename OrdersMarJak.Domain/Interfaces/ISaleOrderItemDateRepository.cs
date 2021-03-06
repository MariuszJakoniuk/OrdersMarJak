namespace OrdersMarJak.Domain.Interfaces;

public interface ISaleOrderItemDateRepository
{
    int AddSaleOrderItemDate(SaleOrderItemDate saleOrderItemDate);

    bool DeleteSaleOrderItemDate(int saleOrderItemDateId);

    IQueryable<SaleOrderItemDate> GetAllSaleOrderItemDateByOrderItemId(int saleOrderItemId);

    SaleOrderItemDate GetSaleOrderItemDateById(int saleOrderItemDateId);

    bool UpdateSaleOrderItemDate(SaleOrderItemDate saleOrderItemDate);
}
