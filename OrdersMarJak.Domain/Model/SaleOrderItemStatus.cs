namespace OrdersMarJak.Domain.Model;
public class SaleOrderItemStatus : AuditableModel
{
    public string Name { get; set; }
    public byte Sort { get; set; }
    public bool IsEnd { get; set; } = false;

    public virtual ICollection<SaleOrderItem> SaleOrderItems { get; set; }
}