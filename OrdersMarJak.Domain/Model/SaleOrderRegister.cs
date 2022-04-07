namespace OrdersMarJak.Domain.Model;
public class SaleOrderRegister : AuditableModel
{
    public string Symbol { get; set; }
    public string Name { get; set; }

    public virtual ICollection<SaleOrder>? SaleOrders { get; set; }
}