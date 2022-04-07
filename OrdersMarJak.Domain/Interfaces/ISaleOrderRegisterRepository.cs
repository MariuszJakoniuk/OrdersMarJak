namespace OrdersMarJak.Domain.Interfaces;

public interface ISaleOrderRegisterRepository
{
    int AddSaleOrderRegister(SaleOrderRegister saleOrderRegister);

    bool DeleteSaleOrderRegister(int saleOrderRegisterId);

    IQueryable<SaleOrderRegister> GetAllSaleOrderRegister();

    SaleOrderRegister GetSaleOrderRegisterById(int saleOrderRegisterId);

    bool UpdateSaleOrderRegister(SaleOrderRegister saleOrderRegister);
}
