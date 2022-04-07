namespace OrdersMarJak.Domain.Model;
public class SaleOrderItem : AuditableModel
{
    public string? ItemChar { get; set; }
    public bool IsReclamation { get; set; } = false;
    public string Name { get; set; }
    public decimal Brutto { get; set; } = 0;
    public decimal Netto { get; set; } = 0;

    public int SaleOrderId { get; set; }
    public SaleOrder SaleOrder { get; set; }

    public int SaleOrderStatusId { get; set; }
    public SaleOrderItemStatus SaleOrderItemStatus { get; set; }


    public virtual ICollection<SaleOrderItemDate> SaleOrderItemDates{ get; set; }
    public virtual ICollection<SaleOrderItemMemo> SaleOrderItemMemos { get; set; }

}