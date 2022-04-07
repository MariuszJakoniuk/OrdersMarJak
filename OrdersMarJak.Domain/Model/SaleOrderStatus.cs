namespace OrdersMarJak.Domain.Model;
public class SaleOrderStatus : AuditableModel
{
    public string Name { get; set; }
    public byte Sort { get; set; } = 99;
    public bool IsEnd { get; set; } = false;
    public bool IsCanceled { get; set; } = false;

    public virtual ICollection<SaleOrder> SaleOrders { get; set; }
}