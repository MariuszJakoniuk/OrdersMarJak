namespace OrdersMarJak.Domain.Interfaces;

public interface ISaleOrderPayRepository
{
    int AddSaleOrderPay(SaleOrderPay saleOrderPay);

    bool DeleteSaleOrderPay(int saleOrderPayId);

    IQueryable<SaleOrderPay> GetAllSaleOrderPayBySaleOrderId(int saleOrderId);

    SaleOrderPay GetSaleOrderPayById(int saleOrderPayId);

    bool UpdateSaleOrderPay(SaleOrderPay saleOrderPay);
}
